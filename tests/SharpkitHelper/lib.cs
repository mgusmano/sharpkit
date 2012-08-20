using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace SharpkitHelper
{

    public class MSBUildRunner
    {

        public string ProjectDirectory;
        public string MSBuildExe = "";
        public bool UseCache = false;
        public StringList Defines = new StringList();

        public MSBUildRunner(string projectDirectory)
        {
            this.ProjectDirectory = projectDirectory;
        }

        private string GetMsBuildExe()
        {
            if (!MSBuildExe.IsEmpty()) return MSBuildExe;
            return @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"; //TODO
        }

        private void ClearCache()
        {
            ClearCache(new DirectoryInfo(ProjectDirectory));
        }

        private void ClearCache(DirectoryInfo dir)
        {
            foreach (var file in dir.GetFiles("*.skccache"))
                file.Delete();
            foreach (var subDir in dir.GetDirectories())
                ClearCache(subDir);
        }

        public string GetArguments()
        {
            var args = new ArgumentBuilder();
            if (Defines.Count != 0)
                args.Add("p").Append("DefineConstants", string.Join(";", Defines));
            return args.ToString();
        }

        public bool Execute()
        {
            if (!UseCache) ClearCache();

            var execResult = SharpkitUtils.ExecuteProcess(ProjectDirectory, GetMsBuildExe(), GetArguments());
            return execResult.ExitCode == 0;
        }

    }

    //Sample how to run SharpkitRunner:
    //var runner = new TSharpkitRunner();
    //runner.references.AddRange(new string[] {
    //    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\mscorlib.dll",
    //    @"D:\dotnet\sharpkit\sdk\bin\v4.0\SharpKit.JavaScript.dll",
    //    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Core.dll",
    //    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.dll"
    //});

    //runner.projectDirectory = @"D:\projects\Sharpkit\SharpkitTest";
    //runner.csFiles.Add("Tests.cs");
    public class SharpkitRunner
    {

        public string ProjectDirectory = "";
        public string OutputBinFile = "bin\\library.dll";
        public ECompilationTarget Target = ECompilationTarget.library;
        public StringList CsFiles = new StringList();
        public StringList References = new StringList();
        public string SkcExe = "";
        public bool UseCache = false;
        //public string jsOutputBaseDirectory = ""; //Not possible in the moment

        public static SharpkitRunner CreateFromProjectFile(string projectFile)
        {
            throw new NotImplementedException();
        }

        private string GetSkcExe()
        {
            if (!SkcExe.IsEmpty()) return SkcExe;
            return @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\SharpKit\5\skc5.exe"; //TODO
        }

        private string GetArguments()
        {
            var args = new ArgumentBuilder();

            args.Add("dir", ProjectDirectory);
            //args.add("define", "TRACE:DEBUG");
            foreach (var reference in References)
                args.Add("reference", reference);
            args.Add("out", OutputBinFile);
            args.Add("target", Target.ToString());
            foreach (var csFile in CsFiles)
                args.AddValue(csFile);
            //args.add("contentfile", "append.js");
            args.Add("TargetFrameworkVersion", "v4.0");

            return args.ToString();
        }

        private void ClearCache()
        {
            string cacheFile = Path.ChangeExtension(Path.Combine(ProjectDirectory, OutputBinFile), ".skccache");
            if (File.Exists(cacheFile)) File.Delete(cacheFile);
        }

        public bool Execute()
        {
            if (!UseCache) ClearCache();

            var execResult = SharpkitUtils.ExecuteProcess(ProjectDirectory, GetSkcExe(), GetArguments());
            return execResult.ExitCode == 0;
        }

        public enum ECompilationTarget
        {
            library
        }

    }

    public class ArgumentBuilder
    {

        private List<ArgumentEntry> entries = new List<ArgumentEntry>();

        public ArgumentEntry Add(string name)
        {
            var itm = new ArgumentEntry(name);
            entries.Add(itm);
            return itm;
        }

        public ArgumentEntry Add(string name, string value)
        {
            var itm = new ArgumentEntry(name).Append(value);
            entries.Add(itm);
            return itm;
        }

        public ArgumentEntry AddValue(string value)
        {
            var itm = new ArgumentEntry().Append(value);
            entries.Add(itm);
            return itm;
        }

        public override string ToString()
        {
            var list = new StringList();

            foreach (var entry in entries)
                list.Add(entry.ToString());

            return string.Join(" ", list.ToArray());
        }

    }

    public class ArgumentEntry
    {

        public string Name = "";
        private StringBuilder sb = new StringBuilder();
        private EArgumentSeparator LastSeparator = EArgumentSeparator.none;

        public ArgumentEntry() { }

        public ArgumentEntry(string name)
        {
            this.Name = name;
            sb.Append("/" + name);
        }

        public ArgumentEntry Append(string value)
        {
            return Append(value, EArgumentSeparator.doubleDot);
        }

        public ArgumentEntry Append(string value, EArgumentSeparator group)
        {
            if (sb.Length != 0) sb.Append(GetSeparator(group));
            LastSeparator = group;
            sb.Append(GetOutputValue(value));
            return this;
        }

        public ArgumentEntry Append(string key, string value)
        {
            return Append(key, value, EArgumentSeparator.doubleDot);
        }

        public ArgumentEntry Append(string key, string value, EArgumentSeparator group)
        {
            if (sb.Length != 0) sb.Append(GetSeparator(group));
            LastSeparator = group;
            sb.Append(GetOutputValue(key));
            sb.Append("=");
            sb.Append(GetOutputValue(value));
            return this;
        }

        private string GetSeparator(EArgumentSeparator group)
        {
            switch (group)
            {
                case EArgumentSeparator.comma: return ",";
                case EArgumentSeparator.semicolon: return ";";
                case EArgumentSeparator.doubleDot: return ":";
                default: return "";
            }
        }

        private Regex ValueTester = new Regex("^[a-zA-Z0-9._-~+\\[\\]\\(\\#'&!)]+$");
        private string GetOutputValue(string value)
        {
            if (ValueTester.IsMatch(value)) return value;
            else return "\"" + value + "\"";
        }

        public override string ToString()
        {
            return sb.ToString();
        }

    }

    public enum EArgumentSeparator
    {
        none,
        doubleDot,
        comma,
        semicolon
    }

    public class SkcResult
    {
        public bool Success { get; set; }
        public string Output { get; set; }
        public string JsCode { get; set; }
        public string ErrorMessage { get; set; }
        public string JsCodeFormatted { get; set; }
        public string CsCodeFormatted { get; set; }
    }

    public class ExecuteResult
    {
        public int ExitCode { get; set; }
        public List<string> Output { get; set; }
        public List<string> Error { get; set; }
    }

}
