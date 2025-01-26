// Copyright (C) Jan-Willem Goossens 
// This code is licensed under the terms of the Eclipse Public License (EPL).

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ListDependencies
{
    /// <summary>
    /// Write the dependency tree as a list to console
    /// </summary>
    public class ListDependencies
    {
        //public static readonly ListDependencies Instance = new ListDependencies();
        public ListDependencies(string filePath) 
        {
            FilePath = filePath;
            Console.WriteLine($"Loading main assembly...");
            Assembly = LoadMainAssembly();
        }

        private string FilePath;
        private Assembly Assembly;
        private ProcessorArchitecture AssemblyArch;
        private bool Verbose = false;

        public void WriteAllDependencies(bool verbose = false)
        {
            Verbose = verbose;

            if (Assembly == null) { Console.Error.WriteLine("No main assembly. Exiting..."); }
            
            AssemblyArch = Assembly.GetName().ProcessorArchitecture;

            Console.WriteLine("Loading dependencies... Please be patient...");

            Dictionary<Assembly, Assembly> dependencies = new Dictionary<Assembly, Assembly>();
            Dictionary<AssemblyName, Assembly> errors = new Dictionary<AssemblyName, Assembly>();
            AddDependencies(Assembly, dependencies, errors);
            
            List<Assembly> list = new List<Assembly>(dependencies.Keys);
            list.Sort( (a,b) => { return string.Compare(a.GetName().Name, b.GetName().Name); });

            string assemblyFile = Verbose ? Assembly.Location : Path.GetFileName(Assembly.Location);
            Console.WriteLine();
            Console.WriteLine($"{assemblyFile} : \n{Assembly.GetName()} ({Assembly.GetName().ProcessorArchitecture})\nDepends on: ");
            foreach (Assembly dependency in list)
            {
                Assembly parent = dependencies[dependency];
                string file = Verbose ? dependency.Location : Path.GetFileName(dependency.Location);
                string assemblyName = dependency.GetName().Name ?? "<No name>";
                string arch = dependency.GetName().ProcessorArchitecture.ToString();
                if (assemblyName == "mscorlib") arch = "N/A";
                Console.WriteLine($"\t{file} ({arch}, {dependency.GetName().Version}) via {parent.GetName().Name}");
            }

            if (errors.Count > 0)
            {
                Console.WriteLine("Dependency errors: ");
                List<AssemblyName> errorList = new List<AssemblyName>(errors.Keys);
                errorList.Sort((a,b) => { return string.Compare(a.Name, b.Name); });

                foreach (AssemblyName error in errorList)
                {
                    Assembly errorOrig = errors[error];
                    Console.WriteLine($"\t{error.FullName} via {errorOrig.GetName().Name}");
                }
            }
        }

        /// <summary>
        /// Load the main assembly by Reflection-only using the file path.
        /// Any exception will result an error to console and null return.
        /// This method will change the current directory to the file path and update the file path to only the file.
        /// </summary>
        /// <returns>The assembly object, if the assembly was found. Null otherwise.</returns>
        private Assembly LoadMainAssembly()
        {
            // Try to get the root assembly given the filePath, then list all dependencies.
            // Change the current directory to the directory of the given filePath
            Assembly assembly = null;
            try
            {
                string directoryName = Path.GetDirectoryName(FilePath);
                if (!string.IsNullOrEmpty(directoryName))
                {
                    Directory.SetCurrentDirectory(directoryName);
                    FilePath = Path.GetFileName(FilePath);
                }

                string fullPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + FilePath;
                assembly = Assembly.ReflectionOnlyLoadFrom(fullPath);
                Console.WriteLine($"Loaded assembly at {assembly.Location}");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error loading " + FilePath + " : " + e.Message);
                return null;
            }

            return assembly;
        }

        /// <summary>
        /// Delegate method for how to try to load the assembly given the AssemblyName object.
        /// This typically loaded using Reflection-Only.
        /// </summary>
        /// <param name="an">The AssemblyName to try to load</param>
        /// <returns>The loaded assembly object.</returns>
        private delegate Assembly DelegateToLoadAssembly(AssemblyName an);

        /// <summary>
        /// Load the assembly. Returns the assembly if successful, or null otherwise.
        /// First attempt to load the assembly using the give AssemblyName.
        /// If not succesful, then try to load the assembly from the current directory and the name and ".dll"
        /// </summary>
        /// <param name="assemblyName">The assemblyName object to try to load.</param>
        /// <returns>The succesfully loaded assembly, or null otherwise.</returns>
        private Assembly LoadAssembly(AssemblyName assemblyName)
        {
            // 1. try to load the assembly from its full name
            // 2. if that fails, try to load the assembly in the current directory as "assembly_name.dll"

            Assembly assembly = null;

            // In .NET the ReflectionOnlyLoad is deprecated.
            // Instead, use https://learn.microsoft.com/en-us/dotnet/standard/assembly/inspect-contents-using-metadataloadcontext
            List<DelegateToLoadAssembly> list = new List<DelegateToLoadAssembly>();
            list.Add((an) => {
                return Assembly.ReflectionOnlyLoad(an.FullName);
            });
            list.Add((an) => {
                string fullPath = Directory.GetCurrentDirectory() + "\\" + an.Name + ".dll";
                return Assembly.ReflectionOnlyLoadFrom(fullPath);
            });

            foreach (var del in list)
            {
                try
                {
                    assembly = del.Invoke(assemblyName);
                    CheckAssembly(assembly, assemblyName);
                    if (assembly != null) return assembly;
                }
                catch (Exception ex)
                {
                    // found something, but didnt like it
                    if (ex is BadImageFormatException || ex is FileLoadException)
                    {
                        if (Verbose)
                        {
                            if (assembly != null) Console.Error.WriteLine($"Looking for {assemblyName.FullName} found {assembly.GetName().ProcessorArchitecture} at {assembly.Location}, but '{ex.Message}'.");
                            else Console.Error.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        // ignore. Could be simply not found, etc.
                    }
                    assembly = null;
                }
            }

            return assembly;
        }


        /// <summary>
        /// Check if the given assembly could be loaded from the main assembly.
        /// This checks the architecture, the full name, etc.
        /// Throws FileLoadException if checks fail.
        /// NOTE: "You can't use the reflection-only context to load a version of 
        ///  mscorlib.dll from a version of the .NET Framework other than 
        ///  the version in the execution context."
        /// Therefore, when looking for mscorlib.dll, accept any architecture found.
        /// </summary>
        /// <param name="assembly">The assembly to be checked.</param>
        /// <param name="assemblyName">The assemblyName to check against.</param>
        /// <exception cref="FileLoadException"></exception>
        private void CheckAssembly(Assembly assembly, AssemblyName assemblyName)
        {
            if (assembly == null) return;

            // Loading for reflection-only is nice because the assembly does not need
            // to be the same architecture as DependencyList.
            // However, this also means that child dependencies are accepted even if they are
            // of the wrong architecture. Therefore, check the architecture, etc.

            // check the architecture
            if (assembly.GetName().ProcessorArchitecture == ProcessorArchitecture.MSIL ||
                assembly.GetName().Name == "mscorlib")
            {
                // We DONT need to check the architecture if the loaded assembly is MSIL ("AnyCPU")
                // or is the loaded assembly is mscorlib
            }
            else
            {
                // check the architecure
                if (assembly.GetName().ProcessorArchitecture != AssemblyArch)
                {
                    throw new FileLoadException($"Wrong processor architecture: Need {AssemblyArch} but found {assembly.GetName().ProcessorArchitecture}.");
                }
            }

            // The version should be checked only for Strongly Named assemblies
            // But here we check the full name including version regardless.
            if (assemblyName.FullName != assembly.FullName)
            {
                throw new FileLoadException($"Wrong Full name: Need {assemblyName.FullName} but found {assembly.GetName().FullName}.");
            }
        }

        /// <summary>
        /// Add the referenced assemblies of the given assembly to the collection of loaded assemblies, or to the collection of errors.
        /// </summary>
        /// <param name="assembly">The assembly for which to load the referenced assemblies.</param>
        /// <param name="dependencies">The collection of loaded assemblies.</param>
        /// <param name="errors">The collection of assemblies with errors loading.</param>
        private void AddDependencies(Assembly assembly, Dictionary<Assembly, Assembly> dependencies, Dictionary<AssemblyName, Assembly> errors)
        {
            List<Assembly> list = new List<Assembly>();

            AssemblyName[] dependencyNames = assembly.GetReferencedAssemblies();
            foreach (AssemblyName dependencyName in dependencyNames)
            {
                Assembly dependency = LoadAssembly(dependencyName);

                if (dependency == null)
                {
                    if (!errors.ContainsKey(dependencyName)) errors[dependencyName] = assembly;
                }
                else
                {
                    if (!dependencies.ContainsKey(dependency))
                    {
                        // the value is the parent assembly
                        dependencies.Add(dependency, assembly);
                        list.Add(dependency);
                    }
                }
            }

            foreach (Assembly newAssembly in list)
            {
                AddDependencies(newAssembly, dependencies, errors);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || 
                (args.Length == 1 && string.Equals(args[0], "-v") ) ||
                (args.Length == 2 && !string.Equals(args[0], "-v") ) ||
                (args.Length > 2))
            {
                WriteUsage();
                return;
            }
            else if (args.Length == 1)
            {
                new ListDependencies(args[0]).WriteAllDependencies(false);
            }
            else if (args.Length == 2)
            {
                bool verbose = false;
                if (string.Equals(args[0],"-v")) verbose = true;
                else
                {
                    WriteUsage();
                    return;
                }

                new ListDependencies(args[1]).WriteAllDependencies(verbose);
            }
        }

        static void WriteUsage()
        {
            string filename = "DependencyList.exe";
            Assembly entryAssembly = System.Reflection.Assembly.GetEntryAssembly();
            if (entryAssembly != null)
            {
                string location = entryAssembly.Location;
                filename = Path.GetFileNameWithoutExtension(location) ?? filename;
            }
            Console.WriteLine("Lists all dependencies.");
            Console.WriteLine("Usage: " + filename + " [-v] <file path>");
            Console.WriteLine("  -v \tVerbose. Show reasons for errors and location of dependencies .");
        }
    }
}