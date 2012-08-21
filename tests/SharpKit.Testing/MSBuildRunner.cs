using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace SharpKit.Testing
{

    public class MSBuildRunner
    {

        public string ProjectDirectory;
        public string MSBuildExe = "";
        public bool UseCache = false;
        public List<String> Defines = new List<String>();

        public MSBuildRunner(string projectDirectory)
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

            var execResult = Utils.ExecuteProcess(ProjectDirectory, GetMsBuildExe(), GetArguments());
            return execResult.ExitCode == 0;
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
            var list = new List<String>();

            foreach (var entry in entries)
                list.Add(entry.ToString());

            return string.Join(" ", list.ToArray());
        }

    }

    public class ArgumentEntry
    {

        public string Name = "";
        private StringBuilder sb = new StringBuilder();
        private ArgumentSeparator LastSeparator = ArgumentSeparator.none;

        public ArgumentEntry() { }

        public ArgumentEntry(string name)
        {
            this.Name = name;
            sb.Append("/" + name);
        }

        public ArgumentEntry Append(string value)
        {
            return Append(value, ArgumentSeparator.doubleDot);
        }

        public ArgumentEntry Append(string value, ArgumentSeparator group)
        {
            if (sb.Length != 0) sb.Append(GetSeparator(group));
            LastSeparator = group;
            sb.Append(GetOutputValue(value));
            return this;
        }

        public ArgumentEntry Append(string key, string value)
        {
            return Append(key, value, ArgumentSeparator.doubleDot);
        }

        public ArgumentEntry Append(string key, string value, ArgumentSeparator group)
        {
            if (sb.Length != 0) sb.Append(GetSeparator(group));
            LastSeparator = group;
            sb.Append(GetOutputValue(key));
            sb.Append("=");
            sb.Append(GetOutputValue(value));
            return this;
        }

        private string GetSeparator(ArgumentSeparator group)
        {
            switch (group)
            {
                case ArgumentSeparator.comma: return ",";
                case ArgumentSeparator.semicolon: return ";";
                case ArgumentSeparator.doubleDot: return ":";
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

    public enum ArgumentSeparator
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
