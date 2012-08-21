using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SharpKit.Testing;


namespace skt
{

    public static class Program
    {

        private static ArgumentDictionary ArgHash;
        private static string ProjectDir;
        private static int ErrorCount;

        public static int Main(string[] args)
        {

            try
            {
                ArgHash = GetArguments(args);

                //ProjectDir = @"D:\projects\Sharpkit\SharpkitTest";
                ProjectDir = Environment.CurrentDirectory;

                if (ArgHash.GetValue("compile", "1") == "1") //--> /compile:0 for skip compiling
                {
                    Compile();
                }

                if (ArgHash.GetValue("compare", "1") == "1") //--> /compare:0 for skip comparing
                {
                    Compare();
                }
                return 0;
            }
            catch (Exception e)
            {
                WriteLine(e.Message, ConsoleColor.Red);
                if (ArgHash.ContainsKey("wait"))
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                if (ErrorCount == 0)
                    return -1;
                return ErrorCount;
            }

        }

        public static void Compile()
        {
            var version = ArgHash.GetValue("version", "current");

            var runner = new MSBuildRunner(ProjectDir);
            runner.Defines.Add(version.ToUpper());

            if (!runner.Execute())
            {
                throw new Exception("Compilation not successfull");
            }
        }

        public static bool HasErrors(List<CompareFile> files)
        {
            return files.Any(t => t.Status == CompareFileStatus.Ok);
        }

        public static void Compare()
        {
            var list = IterateFolderComparison(ProjectDir + "\\versions\\current", ProjectDir + "\\versions\\original");
            if (list == null)
                throw new Exception("unknown error");

            foreach (var itm in list)
            {
                Console.WriteLine(itm.FileOriginal + " -> " + itm.Status);
                if (itm.Status == CompareFileStatus.Ok)
                    continue;
                ErrorCount++;

                var lineNumberStr = "";
                if (itm.Status == CompareFileStatus.LineDiff) lineNumberStr = ":" + itm.Diff.LineNumber;
                Console.Write(Path.GetFileName(itm.FileOriginal) + lineNumberStr + " ");

                Console.Write("[");
                Write(itm.Status.ToString().ToUpper(), ConsoleColor.Red);
                Console.Write("]");

                Console.Write("\n");
                if (itm.Status == CompareFileStatus.LineDiff)
                {
                    Console.WriteLine("Original: " + itm.Diff.LineContentOriginal);
                    Console.WriteLine("Current : " + itm.Diff.LineContentCurrent);
                }
                Console.WriteLine("");
            }

            if (ErrorCount > 0)
                throw new Exception("Found " + ErrorCount + " errors");
            Console.WriteLine("Files have no diffs.");
        }

        private static void Write(string text, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = oldColor;
        }

        private static void WriteLine(string text, ConsoleColor color)
        {
            Write(text + "\n", color);
        }

        private static ArgumentDictionary GetArguments(string[] args)
        {
            var dic = new ArgumentDictionary();
            foreach (var arg in args)
            {
                var idx = arg.IndexOf(":");
                if (idx == -1)
                {
                    dic.Add(arg.Substring(1), null);
                }
                else
                {
                    dic.Add(arg.Substring(1, idx - 1), arg.Substring(1 + idx));
                }
            }
            return dic;
        }

        private static IEnumerable<CompareFile> IterateFolderComparison(string currentDir, string originalDir)
        {
            if (!Directory.Exists(currentDir))
            {
                throw new Exception("currentDir is missing");
            }

            if (!Directory.Exists(originalDir))
            {
                throw new Exception("originalDir is missing");
            }

            foreach (var file in Directory.GetFiles(currentDir, "*.js"))
            {
                var file2 = Path.Combine(originalDir, Path.GetFileName(file));
                yield return CompareFile.Compare(file, file2);
            }

            foreach (var subDir in new DirectoryInfo(currentDir).GetDirectories())
                foreach (var itm in IterateFolderComparison(subDir.FullName, originalDir + "\\" + subDir.Name))
                    yield return itm;
        }

    }

    public class ArgumentDictionary : Dictionary<string, string>
    {
        public string GetValue(string key, string defaultValue = "")
        {
            var value = "";
            if (TryGetValue(key, out value)) return value;
            return defaultValue;
        }
    }

    public class CompareFile
    {
        public CompareFile()
        {
            Status = CompareFileStatus.Ok;
        }
        public CompareFileStatus Status { get; set; }
        public string FileOriginal { get; set; }
        public string FileCurrent { get; set; }
        public CompareFileDiff Diff { get; set; }

        public static CompareFile Compare(string currentFile, string originalFile)
        {
            var itm = new CompareFile() { FileOriginal = originalFile, FileCurrent = currentFile };
            if (!File.Exists(originalFile) || !File.Exists(currentFile))
            {
                itm.Status = CompareFileStatus.Missing;
                return itm;
            }

            var originalLines = File.ReadAllLines(originalFile);
            var currentLines = File.ReadAllLines(currentFile);

            if (originalLines.Length != currentLines.Length)
            {
                itm.Status = CompareFileStatus.LineCount;
                return itm;
            }

            for (var i = 1; i < currentLines.Length; i++)
            {
                if (originalLines[i] != currentLines[i])
                {
                    itm.Status = CompareFileStatus.LineDiff;
                    itm.Diff = new CompareFileDiff() { LineNumber = i + 1, LineContentCurrent = currentLines[i], LineContentOriginal = originalLines[i] };
                    return itm;
                }
            }

            return itm;
        }

    }

    public class CompareFileDiff
    {
        public int LineNumber;
        public string LineContentOriginal;
        public string LineContentCurrent;
    }

    public enum CompareFileStatus
    {
        Ok,
        Missing,
        LineDiff,
        LineCount
    }

}
