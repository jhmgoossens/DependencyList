# DependencyList
The dependency tree, but as a list.

Does the world need another (simple) viewer for .NET dependencies? Maybe, or maybe not.

DependencyList requires .NET Framework 4.8.
Dependencies are loaded using Reflection-Only.

Future version might support .NET using MetadataLoadContext.

# Example
```
DependencyList.exe "c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472\Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe"

Loading main assembly...
Loaded assembly at c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472\Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe
Loading dependencies... Please be patient...

Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe :
Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost, Version=4.12.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 (MSIL)
Depends on:
        Microsoft.Build.Locator.dll (MSIL, 1.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        mscorlib.dll (N/A, 4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        netstandard.dll (MSIL, 2.0.0.0) via System.CommandLine
        Newtonsoft.Json.dll (MSIL, 13.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        SMDiagnostics.dll (MSIL, 4.0.0.0) via System.Runtime.Serialization
        System.dll (MSIL, 4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Buffers.dll (MSIL, 4.0.3.0) via System.Collections.Immutable
        System.Collections.Immutable.dll (MSIL, 8.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.CommandLine.dll (MSIL, 2.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.ComponentModel.Composition.dll (MSIL, 4.0.0.0) via netstandard
        System.Configuration.dll (MSIL, 4.0.0.0) via System
        System.Core.dll (MSIL, 4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Data.Common.dll (MSIL, 4.0.0.0) via netstandard
        System.Data.SqlXml.dll (MSIL, 4.0.0.0) via System.Xml
        System.Diagnostics.StackTrace.dll (MSIL, 4.0.0.0) via netstandard
        System.Diagnostics.Tracing.dll (MSIL, 4.0.0.0) via netstandard
        System.Drawing.dll (MSIL, 4.0.0.0) via netstandard
        System.Globalization.Extensions.dll (MSIL, 4.0.0.0) via netstandard
        System.IO.Compression.dll (MSIL, 4.0.0.0) via netstandard
        System.IO.Compression.FileSystem.dll (MSIL, 4.0.0.0) via netstandard
        System.Memory.dll (MSIL, 4.0.1.2) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Net.Http.dll (MSIL, 4.0.0.0) via netstandard
        System.Net.Sockets.dll (MSIL, 4.0.0.0) via netstandard
        System.Numerics.dll (MSIL, 4.0.0.0) via System.Core
        System.Numerics.Vectors.dll (MSIL, 4.1.4.0) via System.Memory
        System.Runtime.CompilerServices.Unsafe.dll (MSIL, 6.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Runtime.InteropServices.RuntimeInformation.dll (MSIL, 4.0.0.0) via netstandard
        System.Runtime.Serialization.dll (MSIL, 4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Runtime.Serialization.Primitives.dll (MSIL, 4.0.0.0) via netstandard
        System.Runtime.Serialization.Xml.dll (MSIL, 4.0.0.0) via netstandard
        System.Security.dll (MSIL, 4.0.0.0) via System.Core
        System.Security.Cryptography.Algorithms.dll (MSIL, 4.0.0.0) via netstandard
        System.Security.SecureString.dll (MSIL, 4.0.0.0) via netstandard
        System.ServiceModel.Internals.dll (MSIL, 4.0.0.0) via System.Runtime.Serialization
        System.Threading.Overlapped.dll (MSIL, 4.0.0.0) via netstandard
        System.Threading.Tasks.Extensions.dll (MSIL, 4.2.0.1) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.ValueTuple.dll (MSIL, 4.0.0.0) via netstandard
        System.Xml.dll (MSIL, 4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Xml.Linq.dll (MSIL, 4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Xml.XPath.XDocument.dll (MSIL, 4.0.0.0) via netstandard
Dependency errors:
        Microsoft.Build, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        Microsoft.Build.Framework, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 via netstandard
        System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 via System.Data.Common
        System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 via Newtonsoft.Json
        System.Memory, Version=4.0.1.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System.CommandLine
        System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System.Memory
        System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System.Threading.Tasks.Extensions
        System.Transactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 via netstandard
        System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via netstandard
```
