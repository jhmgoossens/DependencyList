using System;
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
        public static readonly ListDependencies Instance = new ListDependencies();
        private ListDependencies() { }

        public bool Verbose = false;
        public void WriteAllDependencies(string filePath)
        {
            // Try to get the root assembly given the filePath, then list all dependencies.
            // If the given path is rooted, then change current directory to that path.
            Assembly assembly;
            try
            {
                if (!Path.IsPathRooted(filePath))
                {
                    // filePath is NOT rooted
                    filePath = Directory.GetCurrentDirectory() + "\\" + filePath;
                }
                else
                {
                    // filePath is rooted
                    string? directoryName = Path.GetDirectoryName(filePath);
                    if (!string.IsNullOrEmpty(directoryName)) Directory.SetCurrentDirectory(directoryName);
                }
                assembly = Assembly.LoadFile(filePath);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error loading " + filePath + " : " + e.Message);
                return;
            }

            if (!Console.IsOutputRedirected) Console.WriteLine("Loading...");

            Dictionary<Assembly, Assembly> dependencies = new Dictionary<Assembly, Assembly>();
            Dictionary<AssemblyName, Assembly> errors = new Dictionary<AssemblyName, Assembly>();
            AddDependencies(assembly, dependencies, errors);
            
            List<Assembly> list = new List<Assembly>(dependencies.Keys);
            list.Sort( (a,b) => { return string.Compare(a.GetName().Name, b.GetName().Name); });

            Console.WriteLine($"{filePath} : \n{assembly.GetName()}\nDepends on: ");
            foreach (Assembly dependency in list)
            {
                Assembly dependencyOrig = dependencies[dependency];
                string file = Verbose ? dependency.Location : Path.GetFileName(dependency.Location);
                string assemblyName = dependency.GetName().Name ?? "<No name>";
                Console.WriteLine($"\t{file} ({dependency.GetName().Version}) via {dependencyOrig.GetName().Name}");
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
        /// Load the assembly. Returns the assembly if successful, or null otherwise.
        /// First attempt to load the assembly using the give AssemblyName.
        /// If not succesful, then try to load the assembly from the current directory and the name and ".dll"
        /// </summary>
        /// <param name="assemblyName">The assemblyName object to try to load.</param>
        /// <returns>The loaded assembly.</returns>
        private Assembly? LoadAssembly(AssemblyName assemblyName)
        {
            ConsoleSpinner.Instance.Turn();

            Assembly? assembly = null;
            try
            {
                assembly = Assembly.Load(assemblyName);
                return assembly;
            }
            catch { }

            try
            {
                assembly = Assembly.LoadFile(Directory.GetCurrentDirectory() + "\\" + assemblyName.Name + ".dll");
                if (assembly != null && assemblyName.FullName == assembly.FullName) return assembly;
            }
            catch { }

            return null;
        }

        /// <summary>
        /// Add the referenced assemblies of the given assembly to the collection of loaded assemblies, or to the collection of errors.
        /// </summary>
        /// <param name="assembly">The assembly for which to load the referenced assemblies.</param>
        /// <param name="collection">The collection of loaded assemblies.</param>
        /// <param name="errors">The collection of assemblies with errors loading.</param>
        /// <returns>Returns true iff a NEW assembly was added.</returns>
        private void AddDependencies(Assembly assembly, Dictionary<Assembly, Assembly> collection, Dictionary<AssemblyName, Assembly> errors)
        {
            List<Assembly> list = new List<Assembly>();

            AssemblyName[] dependencyNames = assembly.GetReferencedAssemblies();
            foreach (AssemblyName dependencyName in dependencyNames)
            {
                Assembly? dependency = LoadAssembly(dependencyName);

                if (dependency == null)
                {
                    if (!errors.ContainsKey(dependencyName)) errors[dependencyName] = assembly;
                }
                else
                {
                    if (!collection.ContainsKey(dependency))
                    {
                        collection.Add(dependency, assembly);
                        list.Add(dependency);
                    }
                }
            }

            foreach (Assembly newAssembly in list)
            {
                AddDependencies(newAssembly, collection, errors);
            }
        }
    }

    /// <summary>
    /// Simple console spinner
    /// Only turns if output is not redirected.
    /// Adapted from https://stackoverflow.com/questions/1923323/console-animations
    /// </summary>
    public class ConsoleSpinner
    {
        
        public static readonly ConsoleSpinner Instance = new ConsoleSpinner();

        private int state = 0;
        private ConsoleSpinner() { }
  
        public void Turn()
        {
            if (Console.IsOutputRedirected) return;
            state++;
            state = state % 4;
            switch (state)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
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
                ListDependencies.Instance.WriteAllDependencies(args[0]);
            }
            else if (args.Length == 2)
            {
                if (string.Equals(args[0],"-v")) ListDependencies.Instance.Verbose = true;
                else
                {
                    WriteUsage();
                    return;
                }

                ListDependencies.Instance.WriteAllDependencies(args[1]);
            }

            if (!Console.IsOutputRedirected)
            {
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey(true);
            }
        }

        static void WriteUsage()
        {
            string filename = "DependencyList.exe";
            Assembly? entryAssembly = System.Reflection.Assembly.GetEntryAssembly();
            if (entryAssembly != null)
            {
                string location = entryAssembly.Location;
                filename = Path.GetFileNameWithoutExtension(location) ?? filename;
            }
            Console.WriteLine("Lists all dependencies.");
            Console.WriteLine("Usage: " + filename + " [-v] <file path>");
            Console.WriteLine("  -v \tVerbose. Show location of dependencies.");
        }
    }
}