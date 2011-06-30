using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharpKit.JavaScript;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SharpKit.JsClr")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("SharpKit.JsClr")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("db317aaf-7549-4ecc-8cef-3e4e1a56c1d3")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("4.0.0.0")]
[assembly: AssemblyFileVersion("4.05.3000")]

[assembly: JsExport(Minify = false, LongFunctionNames = false, ExportComments = false, EnableProfiler = false)]

[assembly: JsMergedFile(Filename = "res/System.js", Sources = new string[]
{
	"Internal/Core.js",
	"Internal/CoreEx.js",
})]

[assembly: JsMergedFile(Filename = "res/jsclr-4.0.0.js", Sources = new string[]
{
	"res/System.js",
	"res/System.IO.js",
	"res/System.Linq.js",
	"res/System.Collections.js",
	"res/System.Reflection.js",
	"res/System.Diagnostics.js",
	"res/System.Text.js",
	"res/System.Ext.js"
})]
