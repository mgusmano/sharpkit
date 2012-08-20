using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using SharpkitHelper;

namespace SharpkitTester
{

    public static class Programm
    {

        private static ArgumentDictionary argHash;
        private static string projectDir;
        private static int errorCount;

        public static int Main(string[] args)
        {

            try
            {
                argHash = GetArguments(args);

                //projectDir = @"D:\projects\Sharpkit\SharpkitTest";
                projectDir = Environment.CurrentDirectory;

                if (argHash.getValue("compile", "1") == "1") //--> /compile:0 for skip compiling
                {
                    compile();
                }

                if (argHash.getValue("compare", "1") == "1") //--> /compare:0 for skip comparing
                {
                    compare();
                }
                return 0;
            }
            catch (Exception e)
            {
                Write(e.Message, ConsoleColor.Red);
                if (argHash.ContainsKey("wait"))
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                if (errorCount == 0)
                    return -1;
                return errorCount;
            }

        }

        public static void compile()
        {
            var version = argHash.getValue("version", "current");

            var runner = new MSBUildRunner(projectDir);
            runner.Defines.Add(version.ToUpper());

            if (!runner.Execute())
            {
                throw new Exception("Compilation not successfull");
            }
        }

        public static bool hasErrors(List<CompareFile> files)
        {
            return files.Any(t => t.status == ECompareFileStatus.ok);
        }

        public static void compare()
        {
            var list = IterateFolderComparison(projectDir + "\\versions\\current", projectDir + "\\versions\\original");
            if (list == null)
                throw new Exception("unknown error");

            foreach (var itm in list)
            {
                Console.WriteLine(itm.fileOriginal + " -> " + itm.status);
                if (itm.status == ECompareFileStatus.ok)
                    continue;
                errorCount++;

                var lineNumberStr = "";
                if (itm.status == ECompareFileStatus.lineDiff) lineNumberStr = ":" + itm.diff.lineNumber;
                Console.Write(Path.GetFileName(itm.fileOriginal) + lineNumberStr + " ");

                Console.Write("[");
                Write(itm.status.ToString().ToUpper(), ConsoleColor.Red);
                Console.Write("]");

                Console.Write("\n");
                if (itm.status == ECompareFileStatus.lineDiff)
                {
                    Console.WriteLine("Original: " + itm.diff.lineContentOriginal);
                    Console.WriteLine("Current : " + itm.diff.lineContentCurrent);
                }
                Console.WriteLine("");
            }

            if (errorCount > 0)
                throw new Exception("Found " + errorCount + " errors");
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
                yield return CompareFile.compare(file, file2);
            }
        }

    }

    public class ArgumentDictionary : Dictionary<string, string>
    {
        public string getValue(string key, string defaultValue = "")
        {
            var value = "";
            if (TryGetValue(key, out value)) return value;
            return defaultValue;
        }
    }

    public class CompareFile
    {
        public ECompareFileStatus status = ECompareFileStatus.ok;
        public string fileOriginal;
        public string fileCurrent;
        public CompareFileDiff diff;

        public static CompareFile compare(string currentFile, string originalFile)
        {
            var itm = new CompareFile() { fileOriginal = originalFile, fileCurrent = currentFile };
            if (!File.Exists(originalFile) || !File.Exists(currentFile))
            {
                itm.status = ECompareFileStatus.missing;
                return itm;
            }

            var originalLines = File.ReadAllLines(originalFile);
            var currentLines = File.ReadAllLines(currentFile);

            if (originalLines.Length != currentLines.Length)
            {
                itm.status = ECompareFileStatus.lineCount;
                return itm;
            }

            for (var i = 1; i < currentLines.Length; i++)
            {
                if (originalLines[i] != currentLines[i])
                {
                    itm.status = ECompareFileStatus.lineDiff;
                    itm.diff = new CompareFileDiff() { lineNumber = i + 1, lineContentCurrent = currentLines[i], lineContentOriginal = originalLines[i] };
                    return itm;
                }
            }

            return itm;
        }

    }

    public class CompareFileDiff
    {
        public int lineNumber;
        public string lineContentOriginal;
        public string lineContentCurrent;
    }

    public enum ECompareFileStatus
    {
        ok,
        missing,
        lineDiff,
        lineCount
    }

}
