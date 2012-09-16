using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SharpKit.Testing;
using System.Diagnostics;

namespace skt
{

    public static class Program
    {

        private static ArgumentDictionary ArgHash;
        private static string ProjectDir;
        private static int ErrorCount;
        private static string SvnExe = @"svn.exe";
        private static string SvnUrl = "http://sharpkit.googlecode.com/svn/trunk/tests/CoreTests";

        public static int Main(string[] args)
        {

            try
            {
                ArgHash = GetArguments(args);

                //ProjectDir = @"C:\Users\sebastian.sharpkit\Documents\Visual Studio 2010\Projects\tests\CoreTests";
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
                if (ErrorCount == 0)
                    return -1;
                return ErrorCount;
            }
            finally
            {
                if (ArgHash != null && ArgHash.ContainsKey("wait"))
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

        }

        static void Compile()
        {
            //var version = ArgHash.GetValue("version", "current");

            var runner = new MSBuildRunner(ProjectDir);
            //runner.Defines.Add(version.ToUpper());

            if (!runner.Execute())
            {
                throw new Exception("Compilation not successfull");
            }
        }

        static bool HasErrors(List<CompareFile> files)
        {
            return files.Any(t => t.Status == CompareFileStatus.Ok);
        }

        static void getSVNFile(string origFile, string destFile)
        {
            if (File.Exists(destFile)) File.Delete(destFile);

            //svn cat -r BASE Dynamics\Dynamics.cs
            var psi = new ProcessStartInfo(SvnExe, "cat -r BASE \"" + origFile + "\"");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            var p = Process.Start(psi);
            var content = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            if (p.ExitCode != 0)
                throw new Exception("SVN exited with code " + p.ExitCode.ToString());

            var dirName = Path.GetDirectoryName(destFile);
            if (!Directory.Exists(dirName)) Directory.CreateDirectory(dirName);
            File.WriteAllText(destFile, content);
        }

        static void Compare()
        {
            var appDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var jsDir = ProjectDir;// +"\\res";
            var tmpDir = appDir + "\\tmp";

            if (Directory.Exists(tmpDir))
                Directory.Delete(tmpDir, true);
            Directory.CreateDirectory(tmpDir);

            var list = IterateFolderComparison(jsDir, tmpDir);
            if (list == null)
                throw new Exception("unknown error");

            foreach (var itm in list)
            {
                var wellFileName = itm.FileOriginal.Replace(tmpDir, "");
                Console.WriteLine(wellFileName + " -> " + itm.Status);
                if (itm.Status == CompareFileStatus.Ok)
                    continue;
                ErrorCount++;

                var lineNumberStr = "";
                if (itm.Status == CompareFileStatus.LineDiff) lineNumberStr = ":" + itm.Diff.LineNumber;
                Console.Write(wellFileName + lineNumberStr + " ");

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

        static void Write(string text, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = oldColor;
        }

        static void WriteLine(string text, ConsoleColor color)
        {
            Write(text + "\n", color);
        }

        static ArgumentDictionary GetArguments(string[] args)
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

        static bool updateSourceFromLocalHistory = true;
        static IEnumerable<CompareFile> IterateFolderComparison(string currentDir, string originalDir)
        {

            if (!Directory.Exists(originalDir))
            {
                throw new Exception("currentDir is missing");
            }

            if (!Directory.Exists(currentDir))
            {
                throw new Exception("originalDir is missing");
            }

            foreach (var currFile in Directory.GetFiles(currentDir, "*.js", SearchOption.AllDirectories))
            {
                var origFile = originalDir + currFile.Substring(currentDir.Length);

                if (updateSourceFromLocalHistory)
                {
                    getSVNFile(currFile, origFile);
                }

                yield return CompareFile.Compare(currFile, origFile);
            }

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

    class CompareFile
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

    class CompareFileDiff
    {
        public int LineNumber;
        public string LineContentOriginal;
        public string LineContentCurrent;
    }

    enum CompareFileStatus
    {
        Ok,
        Missing,
        LineDiff,
        LineCount
    }

}
