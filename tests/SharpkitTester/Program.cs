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

        private static TArgumentDictionary argHash;

        public static string projectDir;

        public static int Main(string[] args)
        {

            try
            {
                argHash = getArguments(args);

                //projectDir = @"D:\projects\Sharpkit\SharpkitTest";
                projectDir = Environment.CurrentDirectory;

                if (argHash.getValue("compile", "1") == "1")
                { //--> /compile:0 for skip compiling
                    compile();
                }

                if (argHash.getValue("compare", "1") == "1")//--> /compare:0 for skip compiling
                {
                    compare();
                }
                return 0;
            }
            catch (Exception e)
            {
                write(e.Message, ConsoleColor.Red);
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

        private static void compile()
        {
            var version = argHash.getValue("version", "current");

            //var runner = new TSharpkitRunner();
            //runner.references.AddRange(new string[] {
            //    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\mscorlib.dll",
            //    @"D:\dotnet\sharpkit\sdk\bin\v4.0\SharpKit.JavaScript.dll",
            //    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Core.dll",
            //    @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.dll"
            //});

            //runner.projectDirectory = @"D:\projects\Sharpkit\SharpkitTest";
            //runner.csFiles.Add("Tests.cs");

            //if (runner.execute())
            //{
            //    //copyFolder(runner.projectDirectory + "\\js", runner.projectDirectory + "\\versions\\1");
            //}

            var runner = new TMSBUildRunner(projectDir);
            runner.defines.Add(version.ToUpper());

            if (runner.execute())
            {
                //
            }
        }
        public static bool hasErrors(List<TCompareFile> files)
        {
            return files.Any(t => t.status == ECompareFileStatus.ok);
        }

        static int errorCount;

        public static void compare()
        {
            var list = IterateFolderComparison(projectDir + "\\versions\\current", projectDir + "\\versions\\original");
            if (list == null)
                throw new Exception("unknown error");

            foreach (var itm in list)
            {
                Console.WriteLine(itm.fileOriginal +" -> "+itm.status);
                if (itm.status == ECompareFileStatus.ok)
                    continue;
                errorCount++;
                Console.Write(Path.GetFileName(itm.fileOriginal) + " ");

                Console.Write("[");
                write(itm.status.ToString().ToUpper(), ConsoleColor.Red);
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

        private static void write(string text, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = oldColor;
        }

        private static void writeLine(string text, ConsoleColor color)
        {
            write(text + "\n", color);
        }

        private static TArgumentDictionary getArguments(string[] args)
        {
            var dic = new TArgumentDictionary();
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

        private static IEnumerable<TCompareFile> IterateFolderComparison(string currentDir, string originalDir)
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
                yield return TCompareFile.compare(file, file2);
            }
        }

        //private static void copyFolder(string srcDir, string destDir)
        //{
        //    copyFolder(new DirectoryInfo(srcDir), destDir);
        //}

        //private static void copyFolder(DirectoryInfo srcDir, string destDir)
        //{
        //    if (!Directory.Exists(destDir)) Directory.CreateDirectory(destDir);

        //    foreach (var file in srcDir.GetFiles("*.js"))
        //        file.CopyTo(destDir + "\\" + file.Name, true);

        //    foreach (var dir in srcDir.GetDirectories())
        //        copyFolder(dir, destDir + "\\" + dir.Name);
        //}

    }

    public class TArgumentDictionary : Dictionary<string, string>
    {
        public string getValue(string key, string defaultValue = "")
        {
            var value = "";
            if (TryGetValue(key, out value)) return value;
            return defaultValue;
        }
    }

    public enum ECompareFileStatus
    {
        ok,
        missing,
        lineDiff,
        lineCount
    }



    public class TCompareFile
    {
        public ECompareFileStatus status = ECompareFileStatus.ok;
        public string fileOriginal;
        public string fileCurrent;
        public TCompareFileDiff diff;

        public static TCompareFile compare(string currentFile, string originalFile)
        {
            var itm = new TCompareFile() { fileOriginal = originalFile, fileCurrent = currentFile };
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
                    itm.diff = new TCompareFileDiff() { lineNumber = i + 1, lineContentCurrent = currentLines[i], lineContentOriginal = originalLines[i] };
                    return itm;
                }
            }

            return itm;
        }

    }

    public class TCompareFileDiff
    {
        public int lineNumber;
        public string lineContentOriginal;
        public string lineContentCurrent;
    }

}
