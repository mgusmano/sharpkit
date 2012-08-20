using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace SharpkitHelper
{

    class CompilerLogger
    {

        public CompilerLogger()
        {
            Items = new ConcurrentQueue<CompilerLogItem>();
        }

        public ConcurrentQueue<CompilerLogItem> Items { get; set; }
        public void Log(CompilerLogItem item)
        {
            if (item == null)
                return;
            Items.Enqueue(item);
            var sb = new StringBuilder();
            if (item.ProjectRelativeFilename.IsEmpty())
                sb.AppendFormat("{0}", item.ProjectRelativeFilename);
            if (item.Line > 0 && item.Column > 0)
                sb.AppendFormat("({0},{1})", item.Line, item.Column);
            if (item.ProjectRelativeFilename.IsEmpty() || (item.Line > 0 && item.Column > 0))
                sb.Append(": ");

            sb.AppendFormat("{0} {1}{2}: {3}", item.Type.ToString().ToLower(), "SK", item.Code.ToString("0000"), item.Text);
            if (item.AbsoluteFilename.IsEmpty())
                sb.AppendFormat(" [{0}]", item.AbsoluteFilename);
            var ss = sb.ToString();
            Console.WriteLine(ss);
            //"Compilation\JsCompiler.cs(175,26): warning CS0169: The field 'SharpKit.JavaScript.Compilation.JsCompiler.__LastException' is never used [C:\Projects\SharpKit\googlecode\trunk\SharpKit.JsClr-4.1.0\SharpKit.JsClr-4.1.0.csproj]
        }

        public void Warn(string text)
        {
            Log(new CompilerLogItem { Type = CompilerLogItemType.Warning, Text = text });
        }

        public void Error(string text)
        {
            Log(new CompilerLogItem { Type = CompilerLogItemType.Error, Text = text });
        }

        public void Message(string msg)
        {
            Log(new CompilerLogItem { Type = CompilerLogItemType.Message, Text = msg });
        }

        public void WriteLine(string format, object prm1)
        {
            WriteLine(String.Format(format, prm1));
        }
        public void WriteLine(string format, object prm1, object prm2)
        {
            WriteLine(String.Format(format, prm1, prm2));
        }
        public void WriteLine(string format, object prm1, object prm2, object prm3)
        {
            WriteLine(String.Format(format, prm1, prm2, prm3));
        }
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }

        string LoggingFilename;
        public void Init()
        {
        }
    }

    class CompilerLogItem
    {
        //public AstNode Node { get; set; }
        public string Text { get; set; }
        public int Code { get; set; }
        public CompilerLogItemType Type { get; set; }
        //public IEntity Entity { get; set; }
        public string ProjectRelativeFilename { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }
        public string AbsoluteFilename { get; set; }

    }

    enum CompilerLogItemType
    {
        Message,
        Warning,
        Error
    }

}
