# DependencyList
The dependency tree, but as a list.

Does the world need another (simple) viewer for .NET dependencies? Maybe, or maybe not.

**LIMITATION: Because the dependencies are loaded into memory, they must be for the same processor/platform (x86/x64/AnyCpu) as this program.**

# Example
```
DependencyList.exe "c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472\Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe"

Loading main assembly...
Current directory is now 'c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472.
File Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe exists: True
Loaded assembly at c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472\Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe
Loading dependencies... Please be patient...
Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe :
Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost, Version=4.12.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
Depends on:
        Microsoft.Build.Locator.dll (1.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        Microsoft.Win32.Primitives.dll (8.0.0.0) via System.Security.Principal.Windows
        Microsoft.Win32.Registry.dll (8.0.0.0) via mscorlib
        mscorlib.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        netstandard.dll (2.1.0.0) via System.CommandLine
        Newtonsoft.Json.dll (13.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Collections.dll (8.0.0.0) via mscorlib
        System.Collections.Concurrent.dll (8.0.0.0) via mscorlib
        System.Collections.Immutable.dll (8.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Collections.NonGeneric.dll (8.0.0.0) via mscorlib
        System.Collections.Specialized.dll (8.0.0.0) via System
        System.CommandLine.dll (2.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.ComponentModel.dll (8.0.0.0) via mscorlib
        System.ComponentModel.EventBasedAsync.dll (8.0.0.0) via System
        System.ComponentModel.Primitives.dll (8.0.0.0) via System
        System.ComponentModel.TypeConverter.dll (8.0.0.0) via System
        System.Console.dll (8.0.0.0) via mscorlib
        System.Core.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Data.dll (4.0.0.0) via Newtonsoft.Json
        System.Data.Common.dll (8.0.0.0) via netstandard
        System.Diagnostics.Contracts.dll (8.0.0.0) via netstandard
        System.Diagnostics.DiagnosticSource.dll (8.0.0.0) via System.Net.Http
        System.Diagnostics.FileVersionInfo.dll (8.0.0.0) via System
        System.Diagnostics.Process.dll (8.0.0.0) via System
        System.Diagnostics.StackTrace.dll (8.0.0.0) via mscorlib
        System.Diagnostics.TextWriterTraceListener.dll (8.0.0.0) via System
        System.Diagnostics.TraceSource.dll (8.0.0.0) via System
        System.Diagnostics.Tracing.dll (8.0.0.0) via System.Net.Primitives
        System.Drawing.Primitives.dll (8.0.0.0) via System.ComponentModel.TypeConverter
        System.Formats.Asn1.dll (8.0.0.0) via System.Security.Cryptography
        System.IO.Compression.dll (8.0.0.0) via System.Reflection.Metadata
        System.IO.Compression.Brotli.dll (8.0.0.0) via System.Net.Http
        System.IO.Compression.ZipFile.dll (8.0.0.0) via netstandard
        System.IO.FileSystem.AccessControl.dll (8.0.0.0) via mscorlib
        System.IO.FileSystem.DriveInfo.dll (8.0.0.0) via mscorlib
        System.IO.FileSystem.Watcher.dll (8.0.0.0) via System
        System.IO.IsolatedStorage.dll (8.0.0.0) via mscorlib
        System.IO.MemoryMappedFiles.dll (8.0.0.0) via System.Reflection.Metadata
        System.IO.Pipes.dll (8.0.0.0) via System.Core
        System.IO.Pipes.AccessControl.dll (8.0.0.0) via System.Core
        System.Linq.dll (8.0.0.0) via System.IO.IsolatedStorage
        System.Linq.Expressions.dll (8.0.0.0) via System.Core
        System.Linq.Parallel.dll (8.0.0.0) via System.Core
        System.Linq.Queryable.dll (8.0.0.0) via System.Core
        System.Memory.dll (8.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Net.Http.dll (8.0.0.0) via System.Private.Xml
        System.Net.HttpListener.dll (8.0.0.0) via System
        System.Net.Mail.dll (8.0.0.0) via System
        System.Net.NameResolution.dll (8.0.0.0) via System
        System.Net.NetworkInformation.dll (8.0.0.0) via System
        System.Net.Ping.dll (8.0.0.0) via System
        System.Net.Primitives.dll (8.0.0.0) via System.Security.Cryptography
        System.Net.Quic.dll (8.0.0.0) via System.Net.Http
        System.Net.Requests.dll (8.0.0.0) via System
        System.Net.Security.dll (8.0.0.0) via System
        System.Net.ServicePoint.dll (8.0.0.0) via System
        System.Net.Sockets.dll (8.0.0.0) via System
        System.Net.WebClient.dll (8.0.0.0) via System
        System.Net.WebHeaderCollection.dll (8.0.0.0) via System
        System.Net.WebProxy.dll (8.0.0.0) via System
        System.Net.WebSockets.dll (8.0.0.0) via System
        System.Net.WebSockets.Client.dll (8.0.0.0) via System
        System.Numerics.dll (4.0.0.0) via Newtonsoft.Json
        System.Numerics.Vectors.dll (8.0.0.0) via System.Linq
        System.ObjectModel.dll (8.0.0.0) via mscorlib
        System.Private.CoreLib.dll (8.0.0.0) via mscorlib
        System.Private.DataContractSerialization.dll (8.0.0.0) via System.Runtime.Serialization.Xml
        System.Private.Uri.dll (8.0.0.0) via System.Runtime
        System.Private.Xml.dll (8.0.0.0) via System.Private.Xml.Linq
        System.Private.Xml.Linq.dll (8.0.0.0) via System.Xml.XDocument
        System.Reflection.DispatchProxy.dll (8.0.0.0) via netstandard
        System.Reflection.Emit.dll (8.0.0.0) via System.Linq.Expressions
        System.Reflection.Emit.ILGeneration.dll (8.0.0.0) via System.Linq.Expressions
        System.Reflection.Emit.Lightweight.dll (8.0.0.0) via System.Linq.Expressions
        System.Reflection.Metadata.dll (8.0.0.0) via System.Diagnostics.StackTrace
        System.Reflection.Primitives.dll (8.0.0.0) via System.Linq.Expressions
        System.Reflection.TypeExtensions.dll (8.0.0.0) via mscorlib
        System.Resources.Writer.dll (8.0.0.0) via mscorlib
        System.Runtime.dll (8.0.0.0) via Microsoft.Win32.Registry
        System.Runtime.CompilerServices.Unsafe.dll (8.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Runtime.CompilerServices.VisualC.dll (8.0.0.0) via mscorlib
        System.Runtime.InteropServices.dll (8.0.0.0) via mscorlib
        System.Runtime.Intrinsics.dll (8.0.0.0) via System.Linq
        System.Runtime.Loader.dll (8.0.0.0) via System.ComponentModel.TypeConverter
        System.Runtime.Numerics.dll (8.0.0.0) via System.Security.Cryptography
        System.Runtime.Serialization.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Runtime.Serialization.Formatters.dll (8.0.0.0) via mscorlib
        System.Runtime.Serialization.Json.dll (8.0.0.0) via netstandard
        System.Runtime.Serialization.Primitives.dll (8.0.0.0) via netstandard
        System.Runtime.Serialization.Xml.dll (8.0.0.0) via netstandard
        System.Security.AccessControl.dll (8.0.0.0) via mscorlib
        System.Security.Claims.dll (8.0.0.0) via mscorlib
        System.Security.Cryptography.dll (8.0.0.0) via mscorlib
        System.Security.Principal.Windows.dll (8.0.0.0) via mscorlib
        System.Text.Encoding.Extensions.dll (8.0.0.0) via System.Console
        System.Text.RegularExpressions.dll (8.0.0.0) via System
        System.Threading.dll (8.0.0.0) via mscorlib
        System.Threading.Channels.dll (8.0.0.0) via System.Net.Http
        System.Threading.Overlapped.dll (8.0.0.0) via System.IO.Pipes
        System.Threading.Tasks.Extensions.dll (8.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Threading.Tasks.Parallel.dll (8.0.0.0) via mscorlib
        System.Threading.Thread.dll (8.0.0.0) via System.IO.MemoryMappedFiles
        System.Threading.ThreadPool.dll (8.0.0.0) via System.Threading.Tasks.Parallel
        System.Transactions.Local.dll (8.0.0.0) via netstandard
        System.Web.HttpUtility.dll (8.0.0.0) via System.Net.WebClient
        System.Xml.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Xml.Linq.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Xml.ReaderWriter.dll (8.0.0.0) via System.Diagnostics.TextWriterTraceListener
        System.Xml.XDocument.dll (8.0.0.0) via System.ComponentModel.TypeConverter
        System.Xml.XmlSerializer.dll (8.0.0.0) via System.Xml
        System.Xml.XPath.dll (8.0.0.0) via System.Xml
        System.Xml.XPath.XDocument.dll (8.0.0.0) via System.Xml.Linq
Dependency errors:
        Microsoft.Build, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        Microsoft.Build.Framework, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        Microsoft.Win32.SystemEvents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System
        System.CodeDom, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System
        System.Configuration.ConfigurationManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System
        System.Data.Odbc, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System.Data
        System.Data.OleDb, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System.Data
        System.Data.SqlClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System.Data
        System.Diagnostics.EventLog, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System.Core
        System.Diagnostics.EventLog, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System
        System.Diagnostics.PerformanceCounter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System.Core
        System.Diagnostics.PerformanceCounter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System
        System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System
        System.Runtime.Serialization.Schema, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System.Runtime.Serialization
        System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via mscorlib
        System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System
        System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System.Data
        System.Threading.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via mscorlib
        System.Threading.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System
        System.Windows.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System
```
