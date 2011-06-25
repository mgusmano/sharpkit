using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.jQuery.UI;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace SharpKit.jQueryUI.ControlsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var asm = typeof(Slider).Assembly;
            var optionsTypes = asm.GetTypes().Where(t => t.Name.EndsWith("Options")).ToList();
            XmlDoc = XDocument.Load(@"C:\Projects\SharpKit\googlecode\bin\v4.0\SharpKit.jQueryUI-1.8.11.xml");
            using (Writer = File.CreateText(@"C:\Projects\SharpKit\googlecode\trunk\SharpKit.jQueryUI.Controls\jQueryUIControls.cs"))
            {
                Writer.WriteLine("using SharpKit.JavaScript;");
                Writer.WriteLine("namespace SharpKit.jQuery.UI.Controls");
                Writer.WriteLine("{");
                optionsTypes.ForEach(Generate);
                Writer.WriteLine("}");
            }
        }

        static XDocument XmlDoc;
        static string GetTypeSummary(string typeName)
        {
            var name = "T:" + typeName;
            return GetSummary(name);
        }
        static string GetSummary(PropertyInfo pi)
        {
            var name = "P:" + pi.DeclaringType.FullName+ "." + pi.Name;
            return GetSummary(name);
        }

        private static string GetSummary(string key)
        {
            var x = XmlDoc.Root.Element("members").Elements("member").Where(t => t.Attribute("name").Value == key).FirstOrDefault();
            if (x != null)
                return x.Element("summary").Value.Trim();
            return null;
        }
        static TextWriter Writer;
        static string TypeToCode(Type type)
        {
            if (KnownTypes.ContainsKey(type.Name))
                return KnownTypes[type.Name];
            if (type.IsGenericType)
            {
                return type.Name.Substring(0, type.Name.IndexOf("`")) + "<" + String.Join(", ", type.GetGenericArguments().Select(t => TypeToCode(t)).ToArray()) + ">";
            }
            else
            {
                return type.Name;
            }
        }
        static Dictionary<string, string> KnownTypes = new Dictionary<string, string> { { "Object", "object" }, { "String", "string" }, { "Int32", "int" }, { "Boolean", "bool" }, {"Single","float"} };
        static HashSet<string> Keywords = new HashSet<string> { "event", "class", "out" };
        static string Identifier(string name)
        {
            if (Keywords.Contains(name))
                return "@" + name;
            return name;
        }
        static void WriteSummary(string summary)
        {
            if (summary == null)
                return;
            var lines = summary.Split('\n').Select(t=>t.Trim()).Where(t=>t.Length>0).ToList();
            Writer.WriteLine("///<summary>");
            lines.ForEach(t => Writer.WriteLine("///{0}", t.Trim()));
            Writer.WriteLine("///</summary>");
        }
        static void Generate(Type type)
        {
            var ceName = "j"+type.Name.Replace("Options", "");
            var meName = type.Name.Replace("Options", "").ToLower();
            Writer.WriteLine("#region {0}", ceName);
            WriteSummary(GetTypeSummary(type.FullName.Replace("Options", "")));
            Writer.WriteLine("[JsType(JsMode.Prototype)]");
            Writer.WriteLine("public class {0} : jQueryContext", ceName);
            Writer.WriteLine("{");
            Writer.WriteLine("jQuery Selector;");
            Writer.WriteLine("public {0}(JsString selector, {1} options)", ceName, type.Name);
            Writer.WriteLine("{");
            Writer.WriteLine("Selector = J(selector);");
            Writer.WriteLine("Selector.{0}(options);", meName);
            Writer.WriteLine("}");
            foreach (var pe in type.GetProperties())
            {
                var peTypeName = TypeToCode(pe.PropertyType);
                var peName = Identifier(pe.Name);
                WriteSummary(GetSummary(pe));
                Writer.WriteLine("public {0} {1}", peTypeName, peName);
                Writer.WriteLine("{");
                Writer.WriteLine("get {{ return Get(\"{0}\").As<{1}>(); }}", peName, peTypeName);
                Writer.WriteLine("set {{ Set(\"{0}\", value); }}", peName);
                Writer.WriteLine("}");
            }
            Writer.WriteLine("object Get(JsString option)");
            Writer.WriteLine("{");
            Writer.WriteLine("return Selector.{0}(option);", meName);
            Writer.WriteLine("}");
            Writer.WriteLine("void Set(JsString option, object value)");
            Writer.WriteLine("{");
            Writer.WriteLine("Selector.{0}(option, value);", meName);
            Writer.WriteLine("}");

            Writer.WriteLine("}");
            Writer.WriteLine("#endregion");

        }
    }
}
