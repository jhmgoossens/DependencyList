# DependencyList
The dependency tree, but as a list.

Does the world need another (simple) viewer for .NET dependencies? Maybe, or maybe not.

# Example
```
DependencyList.exe "c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472\Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe"

Loading main assembly...
Current directory is now 'c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472.
Found assembly at c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472\Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe
Loading dependencies... Please be patient...
Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe :
Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost, Version=4.12.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
Depends on:
        Accessibility.dll (4.0.0.0) via System.Design
        Microsoft.Build.Framework.dll (4.0.0.0) via System.Web
        Microsoft.Build.Locator.dll (1.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        Microsoft.Build.Tasks.v4.0.dll (4.0.0.0) via System.Web
        Microsoft.Build.Utilities.v4.0.dll (4.0.0.0) via System.Web
        mscorlib.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        netstandard.dll (2.0.0.0) via System.CommandLine
        Newtonsoft.Json.dll (13.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        SMDiagnostics.dll (4.0.0.0) via System.Runtime.Serialization
        System.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Buffers.dll (4.0.3.0) via System.Collections.Immutable
        System.Collections.Immutable.dll (8.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.CommandLine.dll (2.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.ComponentModel.Composition.dll (4.0.0.0) via netstandard
        System.ComponentModel.DataAnnotations.dll (4.0.0.0) via System.Web
        System.Configuration.dll (4.0.0.0) via System
        System.Configuration.Install.dll (4.0.0.0) via System.ServiceProcess
        System.Core.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Data.dll (4.0.0.0) via netstandard
        System.Data.Common.dll (4.0.0.0) via netstandard
        System.Data.OracleClient.dll (4.0.0.0) via System.Design
        System.Data.SqlXml.dll (4.0.0.0) via System.Xml
        System.Deployment.dll (4.0.0.0) via System.Windows.Forms
        System.Design.dll (4.0.0.0) via System.Web
        System.Diagnostics.StackTrace.dll (4.0.0.0) via netstandard
        System.Diagnostics.Tracing.dll (4.0.0.0) via netstandard
        System.DirectoryServices.dll (4.0.0.0) via System.EnterpriseServices
        System.DirectoryServices.Protocols.dll (4.0.0.0) via System.Web
        System.Drawing.dll (4.0.0.0) via netstandard
        System.Drawing.Design.dll (4.0.0.0) via System.Design
        System.EnterpriseServices.dll (4.0.0.0) via System.Data
        System.Globalization.Extensions.dll (4.0.0.0) via netstandard
        System.IO.Compression.dll (4.0.0.0) via netstandard
        System.IO.Compression.FileSystem.dll (4.0.0.0) via netstandard
        System.Memory.dll (4.0.1.2) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Net.Http.dll (4.0.0.0) via netstandard
        System.Net.Sockets.dll (4.0.0.0) via netstandard
        System.Numerics.dll (4.0.0.0) via System.Core
        System.Numerics.Vectors.dll (4.1.4.0) via System.Memory
        System.Runtime.Caching.dll (4.0.0.0) via System.Data
        System.Runtime.CompilerServices.Unsafe.dll (6.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Runtime.InteropServices.RuntimeInformation.dll (4.0.0.0) via netstandard
        System.Runtime.Remoting.dll (4.0.0.0) via System.EnterpriseServices
        System.Runtime.Serialization.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Runtime.Serialization.Formatters.Soap.dll (4.0.0.0) via System.Runtime.Remoting
        System.Runtime.Serialization.Primitives.dll (4.0.0.0) via netstandard
        System.Runtime.Serialization.Xml.dll (4.0.0.0) via netstandard
        System.Security.dll (4.0.0.0) via System.Core
        System.Security.Cryptography.Algorithms.dll (4.0.0.0) via netstandard
        System.Security.SecureString.dll (4.0.0.0) via netstandard
        System.ServiceModel.Internals.dll (4.0.0.0) via System.Runtime.Serialization
        System.ServiceProcess.dll (4.0.0.0) via System.Web
        System.Threading.Overlapped.dll (4.0.0.0) via netstandard
        System.Threading.Tasks.Extensions.dll (4.2.0.1) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Transactions.dll (4.0.0.0) via netstandard
        System.ValueTuple.dll (4.0.0.0) via netstandard
        System.Web.dll (4.0.0.0) via netstandard
        System.Web.ApplicationServices.dll (4.0.0.0) via System.Web
        System.Web.RegularExpressions.dll (4.0.0.0) via System.Web
        System.Web.Services.dll (4.0.0.0) via System.Web
        System.Windows.Forms.dll (4.0.0.0) via System.Web
        System.Xaml.dll (4.0.0.0) via Microsoft.Build.Framework
        System.Xml.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Xml.Linq.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Xml.XPath.XDocument.dll (4.0.0.0) via netstandard
Dependency errors:
        Microsoft.Build, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        Microsoft.Build.Framework, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Memory, Version=4.0.1.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System.CommandLine
        System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System.Memory
        System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System.Threading.Tasks.Extensions

```
```
DependencyList.exe "c:\Program Files\dotnet\sdk\9.0.100\DotnetTools\dotnet-watch\9.0.100-rtm.24529.9\tools\net9.0\any\BuildHost-net472\Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost.exe"

Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost, Version=4.12.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
Depends on:
        Accessibility.dll (4.0.0.0) via System.Design
        Microsoft.Build.Framework.dll (4.0.0.0) via System.Web
        Microsoft.Build.Locator.dll (1.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        Microsoft.Build.Tasks.v4.0.dll (4.0.0.0) via System.Web
        Microsoft.Build.Utilities.v4.0.dll (4.0.0.0) via System.Web
        mscorlib.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        netstandard.dll (2.0.0.0) via System.CommandLine
        Newtonsoft.Json.dll (13.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        SMDiagnostics.dll (4.0.0.0) via System.Runtime.Serialization
        System.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Buffers.dll (4.0.3.0) via System.Collections.Immutable
        System.Collections.Immutable.dll (8.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.CommandLine.dll (2.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.ComponentModel.Composition.dll (4.0.0.0) via netstandard
        System.ComponentModel.DataAnnotations.dll (4.0.0.0) via System.Web
        System.Configuration.dll (4.0.0.0) via System
        System.Configuration.Install.dll (4.0.0.0) via System.ServiceProcess
        System.Core.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Data.dll (4.0.0.0) via netstandard
        System.Data.Common.dll (4.0.0.0) via netstandard
        System.Data.OracleClient.dll (4.0.0.0) via System.Design
        System.Data.SqlXml.dll (4.0.0.0) via System.Xml
        System.Deployment.dll (4.0.0.0) via System.Windows.Forms
        System.Design.dll (4.0.0.0) via System.Web
        System.Diagnostics.StackTrace.dll (4.0.0.0) via netstandard
        System.Diagnostics.Tracing.dll (4.0.0.0) via netstandard
        System.DirectoryServices.dll (4.0.0.0) via System.EnterpriseServices
        System.DirectoryServices.Protocols.dll (4.0.0.0) via System.Web
        System.Drawing.dll (4.0.0.0) via netstandard
        System.Drawing.Design.dll (4.0.0.0) via System.Design
        System.EnterpriseServices.dll (4.0.0.0) via System.Data
        System.Globalization.Extensions.dll (4.0.0.0) via netstandard
        System.IO.Compression.dll (4.0.0.0) via netstandard
        System.IO.Compression.FileSystem.dll (4.0.0.0) via netstandard
        System.Memory.dll (4.0.1.2) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Net.Http.dll (4.0.0.0) via netstandard
        System.Net.Sockets.dll (4.0.0.0) via netstandard
        System.Numerics.dll (4.0.0.0) via System.Core
        System.Numerics.Vectors.dll (4.1.4.0) via System.Memory
        System.Runtime.Caching.dll (4.0.0.0) via System.Data
        System.Runtime.CompilerServices.Unsafe.dll (6.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Runtime.InteropServices.RuntimeInformation.dll (4.0.0.0) via netstandard
        System.Runtime.Remoting.dll (4.0.0.0) via System.EnterpriseServices
        System.Runtime.Serialization.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Runtime.Serialization.Formatters.Soap.dll (4.0.0.0) via System.Runtime.Remoting
        System.Runtime.Serialization.Primitives.dll (4.0.0.0) via netstandard
        System.Runtime.Serialization.Xml.dll (4.0.0.0) via netstandard
        System.Security.dll (4.0.0.0) via System.Core
        System.Security.Cryptography.Algorithms.dll (4.0.0.0) via netstandard
        System.Security.SecureString.dll (4.0.0.0) via netstandard
        System.ServiceModel.Internals.dll (4.0.0.0) via System.Runtime.Serialization
        System.ServiceProcess.dll (4.0.0.0) via System.Web
        System.Threading.Overlapped.dll (4.0.0.0) via netstandard
        System.Threading.Tasks.Extensions.dll (4.2.0.1) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Transactions.dll (4.0.0.0) via netstandard
        System.ValueTuple.dll (4.0.0.0) via netstandard
        System.Web.dll (4.0.0.0) via netstandard
        System.Web.ApplicationServices.dll (4.0.0.0) via System.Web
        System.Web.RegularExpressions.dll (4.0.0.0) via System.Web
        System.Web.Services.dll (4.0.0.0) via System.Web
        System.Windows.Forms.dll (4.0.0.0) via System.Web
        System.Xaml.dll (4.0.0.0) via Microsoft.Build.Framework
        System.Xml.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Xml.Linq.dll (4.0.0.0) via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Xml.XPath.XDocument.dll (4.0.0.0) via netstandard
Dependency errors:
        Microsoft.Build, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        Microsoft.Build.Framework, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via Microsoft.CodeAnalysis.Workspaces.MSBuild.BuildHost
        System.Memory, Version=4.0.1.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51 via System.CommandLine
        System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System.Memory
        System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a via System.Threading.Tasks.Extensions
Press any key to continue . . .
```
