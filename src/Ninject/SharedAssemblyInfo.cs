using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Ninject: Lightweight dependency injection for .NET")]
[assembly: AssemblyCompanyAttribute("Ninject Project Contributors")]
[assembly: AssemblyCopyrightAttribute("Copyright © 2007-2014 Ninject Project Contributors and contributors")]
[assembly: AssemblyVersionAttribute("4.0.0.0")]
[assembly: AssemblyFileVersionAttribute("4.0.0.6")]
#if !PCL && !NETSTANDARD1_4 && !WINDOWS_UWP
[assembly: ComVisibleAttribute(false)]
#endif
[assembly: CLSCompliantAttribute(true)]

