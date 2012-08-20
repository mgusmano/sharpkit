using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace SharpkitHelper
{

    public enum ECompilationTarget
    {
        library
    }

    public class TMSBUildRunner
    {

        public string projectDirectory;
        public string msbuildExe = "";
        public bool useCache = false;
        public TStringList defines = new TStringList();

        public TMSBUildRunner(string projectDirectory)
        {
            this.projectDirectory = projectDirectory;
        }

        private string getMsBuildExe()
        {
            if (!msbuildExe.isEmpty()) return msbuildExe;
            return @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"; //TODO
        }

        private void clearCache()
        {
            clearCache(new DirectoryInfo(projectDirectory));
        }

        private void clearCache(DirectoryInfo dir)
        {
            foreach (var file in dir.GetFiles("*.skccache"))
                file.Delete();
            foreach (var subDir in dir.GetDirectories())
                clearCache(subDir);
        }

        public string getArguments()
        {
            var args = new TArgumentBuilder();
            if (defines.Count != 0)
                args.add("p").append("DefineConstants", string.Join(";", defines));
            return args.ToString();
        }

        public bool execute()
        {
            if (!useCache) clearCache();

            var execResult = SharpkitUtils.executeProcess(projectDirectory, getMsBuildExe(), getArguments());
            return execResult.ExitCode == 0;
        }

    }

    public class TSharpkitRunner
    {

        public string projectDirectory = "";
        public string outputBinFile = "bin\\library.dll";
        public ECompilationTarget target = ECompilationTarget.library;
        public TStringList csFiles = new TStringList();
        public TStringList references = new TStringList();
        public string skcExe = "";
        public bool useCache = false;
        //public string jsOutputBaseDirectory = ""; //Not possible in the moment

        public static TSharpkitRunner createFromProjectFile(string projectFile)
        {
            throw new NotImplementedException();
        }

        private string getSkcExe()
        {
            if (!skcExe.isEmpty()) return skcExe;
            return @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\SharpKit\5\skc5.exe"; //TODO
        }

        private string getArguments()
        {

            var args = new TArgumentBuilder();

            args.add("dir", projectDirectory);
            //args.add("define", "TRACE:DEBUG");
            foreach (var reference in references)
                args.add("reference", reference);
            args.add("out", outputBinFile);
            args.add("target", target.ToString());
            foreach (var csFile in csFiles)
                args.addValue(csFile);
            //args.add("contentfile", "append.js");
            args.add("TargetFrameworkVersion", "v4.0");

            return args.ToString();
        }

        private void clearCache()
        {
            string cacheFile = Path.ChangeExtension(Path.Combine(projectDirectory, outputBinFile), ".skccache");
            if (File.Exists(cacheFile)) File.Delete(cacheFile);
        }

        public bool execute()
        {
            if (!useCache) clearCache();

            var execResult = SharpkitUtils.executeProcess(projectDirectory, getSkcExe(), getArguments());
            return execResult.ExitCode == 0;
        }


    }

    public class SharpkitUtils
    {
        public static ExecuteResult executeProcess(string dir, string file, string args)
        {

            Console.WriteLine("Executing: {0} {1} {2}", dir, file, args);
            var process = Process.Start(new ProcessStartInfo
            {
                WorkingDirectory = dir,
                FileName = file,
                Arguments = args,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
            });
            var res = new ExecuteResult { Output = new List<string>(), Error = new List<string>() };

            Console.WriteLine("{0}>{1} {2}", process.StartInfo.WorkingDirectory, process.StartInfo.FileName, process.StartInfo.Arguments);
            process.OutputDataReceived += (s, e) => { Console.WriteLine(e.Data); res.Output.Add(e.Data); };
            process.ErrorDataReceived += (s, e) => { Console.WriteLine(e.Data); res.Error.Add(e.Data); };
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            process.WaitForExit();
            res.ExitCode = process.ExitCode;
            Console.WriteLine("Finished execution. Exit code: {0}", process.ExitCode);
            return res;
        }

    }

    public class TArgumentBuilder
    {
        public string connector = ":";

        public TArgumentBuilder() { }

        public TArgumentBuilder(string connector)
        {
            this.connector = connector;
        }

        private List<TArgumentEntry> entries = new List<TArgumentEntry>();

        public TArgumentEntry add(string name)
        {
            var itm = new TArgumentEntry(name);
            entries.Add(itm);
            return itm;
        }

        public TArgumentEntry add(string name, string value)
        {
            var itm = new TArgumentEntry(name).append(value);
            entries.Add(itm);
            return itm;
        }

        public TArgumentEntry addValue(string value)
        {
            var itm = new TArgumentEntry().append(value);
            entries.Add(itm);
            return itm;
        }

        public override string ToString()
        {
            var list = new TStringList();

            foreach (var entry in entries)
                list.Add(entry.ToString());

            return string.Join(" ", list.ToArray());
        }



    }

    public class TArgumentEntry
    {

        public string name = "";
        private StringBuilder sb = new StringBuilder();
        private EArgumentSeparator lastSeparator = EArgumentSeparator.none;

        public TArgumentEntry() { }

        public TArgumentEntry(string name)
        {
            this.name = name;
            sb.Append("/" + name);
        }

        public TArgumentEntry append(string value)
        {
            return append(value, EArgumentSeparator.doubleDot);
        }

        public TArgumentEntry append(string value, EArgumentSeparator group)
        {
            if (sb.Length != 0) sb.Append(getSeparator(group));
            lastSeparator = group;
            sb.Append(getOutputValue(value));
            return this;
        }

        public TArgumentEntry append(string key, string value)
        {
            return append(key, value, EArgumentSeparator.doubleDot);
        }

        public TArgumentEntry append(string key, string value, EArgumentSeparator group)
        {
            if (sb.Length != 0) sb.Append(getSeparator(group));
            lastSeparator = group;
            sb.Append(getOutputValue(key));
            sb.Append("=");
            sb.Append(getOutputValue(value));
            return this;
        }

        private string getSeparator(EArgumentSeparator group)
        {
            switch (group)
            {
                case EArgumentSeparator.comma: return ",";
                case EArgumentSeparator.semicolon: return ";";
                case EArgumentSeparator.doubleDot: return ":";
                default: return "";
            }
        }

        private Regex valueTester = new Regex("^[a-zA-Z0-9._-~+\\[\\]\\(\\#'&!)]+$");
        private string getOutputValue(string value)
        {
            if (valueTester.IsMatch(value)) return value;
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
