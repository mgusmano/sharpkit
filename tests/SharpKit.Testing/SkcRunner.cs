using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SharpKit.Testing
{
    /// <summary>
    /// Sample how to run SharpkitRunner:
    /// var runner = new TSharpkitRunner();
    /// runner.references.AddRange(new string[] {
    ///     @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\mscorlib.dll",
    ///     @"D:\dotnet\sharpkit\sdk\bin\v4.0\SharpKit.JavaScript.dll",
    ///     @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Core.dll",
    ///     @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.dll"
    /// });
    /// runner.projectDirectory = @"D:\projects\Sharpkit\SharpkitTest";
    /// runner.csFiles.Add("Tests.cs");
    /// </summary>
    public class SkcRunner
    {
        public SkcRunner()
        {
            Target = SkcCompilationTarget.Library;
            ProjectDirectory = "";
            OutputBinFile = "bin\\library.dll";
        }

        public string ProjectDirectory { get; set; }
        public string OutputBinFile { get; set; }
        public SkcCompilationTarget Target { get; set; }
        public List<String> CsFiles = new List<String>();
        public List<String> References = new List<String>();
        public string SkcExe = "";
        public bool UseCache = false;
        public static SkcRunner CreateFromProjectFile(string projectFile)
        {
            throw new NotImplementedException();
        }

        private string GetSkcExe()
        {
            if (!SkcExe.IsEmpty()) 
                return SkcExe;
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

            var execResult = Utils.ExecuteProcess(ProjectDirectory, GetSkcExe(), GetArguments());
            return execResult.ExitCode == 0;
        }
    }


    public enum SkcCompilationTarget
    {
        Library
    }

}
