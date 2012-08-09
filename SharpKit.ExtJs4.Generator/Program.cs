using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using System.CodeDom.Compiler;
using SharpKit.ExtJs4.Generator.ExtDocModel;
using System.Web;

namespace SharpKit.ExtJs4.Generator
{
    class ClassMap
    {
        public ExtClass ExtClass { get; set; }
        public List<Class> Classes { get; set; }
        public string Filename { get; set; }
    }
    class Program
    {
        #region AssemblyContext

        static Class ObjectClass;
        static AssemblyContext Context;
        static Assembly Assembly;
        private static void InitAssemlyContext()
        {
            Assembly = new Assembly
            {
                Usings = new List<string> 
                { 
                    "SharpKit.JavaScript",
             }
            };
            Context = new AssemblyContext
            {
                ClassMappings = new Dictionary<string, string>
                {
                    {"Object", "object"},
                    {"Element", "Ext.Element"},
                    //{"HTMLElement", "HtmlElement"},
                    {"Function", "JsAction"},
                    {"Array", "JsArray"},
                    {"String", "JsString"},
                    {"string", "JsString"},
                    {"Boolean", "bool"},
                    {"Boolan", "bool"},
                    {"boolean", "bool"},
                    {"Float", "JsNumber"},
                    {"integer", "JsNumber"},
                    {"Number", "JsNumber"},
                    {"int", "JsNumber"},
                    {"Date", "JsDate"},
                    {"RegExp", "JsRegExp"},
                    {"Mixed", "object"},
                    {"Ext.fx.target", "Ext.fx.target.Target"},
                    {"Ext", "Ext.ExtContext"},
                    {"Ext.Container", "Ext.container.Container"},
                    {"Container", "Ext.container.Container"},
                    {"Mixed component", "object"},
                    {"Ext.TabBar", "Ext.tab.Bar"},
                    {"Component", "Ext.Component"},
                    {"Region", "Ext.util.Region"},
                    {"ResizeTracker", "Ext.resizer.ResizeTracker"},
                    {"Regexp", "JsRegExp"},
                    {"Menu", "Ext.menu.Menu"},
                    {"Store", "Ext.data.Store"},
                    {"CompositeElement", "Ext.CompositeElement"},
                    {"Label", "Ext.form.Label"},
                    {"Model", "Ext.data.Model"},
                    {"Ext.grid.Grid", "Ext.grid.property.Grid"},
                    {"*", "object"},
                    {"ColorPicker", "Ext.menu.ColorPicker"},
                  }
            };
            Context.Assemblies.Add(Assembly);
            var asm = new Assembly
            {
                Classes = new List<Class>
                {
                    new Class{Name="void"},
                    new Class{Name="object"},
                    new Class{Name="JsObject"},
                    new Class{Name="JsArray"},
                    new Class{Name="JsDate"},
                    new Class{Name="JsRegExp"},
                    new Class{Name="JsAction"},
                    new Class{Name="JsAction`1"},
                    new Class{Name="JsAction`2"},
                    new Class{Name="JsAction`3"},
                    new Class{Name="JsAction`4"},
                    new Class{Name="bool"},
                    new Class{Name="JsString"},
                    new Class{Name="JsNumber"},
                     new Class{Name="JsContext"},
               }
            };
            Context.Assemblies.Add(asm);
            ObjectClass = Context.GetClass("object");
            VoidClass = Context.GetClass("void");

        }
        #endregion
        static string OutputDir;
        static void Main(string[] args)
        {

            InitAssemlyContext();


            var inputDir = @"C:\temp\New folder (29)\ext-4.0.7-gpl\ext-4.0.7-gpl\src\";
            OutputDir = @"C:\temp\New folder (29)\output\";
            var list = new List<ClassMap>();
            foreach (var filename in Directory.GetFiles(inputDir, "Ext*.js"))
            {
                Console.WriteLine(filename);
                var code = File.ReadAllText(filename);
                var code2 = code.SubstringBetween(code.IndexOf("(") + 1, code.LastIndexOf(");"));
                var ce2 = new JavaScriptSerializer().Deserialize(code2, typeof(ExtClass)) as ExtClass;
                list.Add(new ClassMap { ExtClass = ce2, Filename = filename });
            }
            foreach (var item in list)
            {
                item.Classes = Process(item.ExtClass);
            }
            foreach (var item in list)
            {
                ProcessBaseClassAndInterfaces(item.ExtClass);
            }
            foreach (var item in list)
            {
                ProcessMembers(item.ExtClass);
            }
            Assembly.Classes = Fix(Assembly.Classes);

            foreach (var item in list)
            {
                var csFile = Path.Combine(OutputDir, Path.GetFileName(item.Filename).Replace(".js", ".cs"));
                Export(item.Classes, csFile);
                Exported.AddRange(item.Classes);
            }
            var unknown = Assembly.Classes.Where(t => !Exported.Contains(t)).ToList();
            Export(unknown, "Unknown.cs");

        }

        private static List<Class> Fix(List<Class> list)
        {
            list.ForEach(t => t.Members.Where(m => m.DeclaringClass == null).ForEach(m => m.DeclaringClass = t));
            var ceExt = GetClass("Ext.ExtContext", false);
            ceExt.BaseClass = GetClass("JsContext", false);
            ceExt.Attributes[0].NamedParamters.Add("Name", "\"Ext\"");
            list.Where(t => t.FullName == "Ext.util.Sortable" || t.Interfaces.Where(i => i.FullName == "Ext.util.Sortable").FirstOrDefault() != null).ForEach(t => t.Members.Where(m => m.Name.IsNullOrEmpty()).ForEach(m => m.Name = "sortRoot"));
            list.ForEach(t => t.Members.Where(m => m.Type.Name == "this").ForEach(m => m.Type = t));
            list = list.Where(t => t.Name != "this").ToList();
            //list = list.Where(t => t.Name != "target").ToList();
            list.Where(t => t.FullName == "Ext.CompositeElement").ForEach(t => t.Members.Where(m => m.Name.IsNullOrEmpty()).ForEach(m => m.Name = "UNKNOWN"));
            list.Where(t => t.IsInterface && t.BaseClass != null).ForEach(t => t.BaseClass = null);
            list.ForEach(t => t.Members.Where(m => m.Name == "getState" && m.Type == null || m.Type == VoidClass).ForEach(m => m.Type = ObjectClass));
            list.ForEach(t => t.Members.Where(m => m.Name == "getSubTplMarkup" && m.Type == ObjectClass).ForEach(m => m.Type = GetClass("JsString")));
            list.ForEach(t => t.Members.Where(m => m.Name == "getInputId" && m.Type == ObjectClass).ForEach(m => m.Type = GetClass("JsString")));
            list.ForEach(t => t.Members.Where(m => m.Name == "getFieldLabel" && m.Type == ObjectClass).ForEach(m => m.Type = GetClass("JsString")));
            var ceField = GetClass("Ext.form.field.Field");
            list.ForEach(t => t.Members.Where(m => m.Name == "setValue" && m.Type.Interfaces.Contains(ceField)).ForEach(m => m.Type = ceField));
            list.Where(t => t.BaseClass != null && t.BaseClass.IsInterface).ForEach(t =>
                {
                    t.Interfaces.Insert(0, t.BaseClass);
                    t.BaseClass = null;
                });
            var invalidMethods = new List<Method>();
            foreach (var ce in list)
            {
                var ce2 = ce.BaseClass;
                while (ce2 != null)
                {
                    ce.Members.ForEach(pe =>
                        {
                            if (ce2.Members.Where(t => HasSameNameAndParameterTypes(t, pe)).FirstOrDefault() != null)
                                pe.IsNew = true;
                        });
                    ce2 = ce2.BaseClass;
                }
                foreach (var me in ce.Members.OfType<Method>().ToList())
                {
                    var i1 = me.Parameters.FindIndex(p => p.IsOptional);
                    var i2 = me.Parameters.FindLastIndex(p => !p.IsOptional);
                    if (i2>=0 && i1>=0 && i2 > i1)
                    {
                        invalidMethods.Add(me);
                        ce.Members.Remove(me);//invalid method, optional parameters appear everywhere
                    }
                    else if (me.Parameters.Where(t => t.Name == "*").FirstOrDefault() != null)
                    {
                        invalidMethods.Add(me);
                        ce.Members.Remove(me);//invalid method prm name
                    }
                }
            }
            File.WriteAllLines(Path.Combine(OutputDir, "InvalidMethods.txt"), invalidMethods.Select(t => t.DeclaringClass.FullName + ":" + t.Name).ToArray());
            list.RemoveAll(t => t.Name == "*");
            list.Where(ce=>!ce.IsInterface).ForEach(ce =>
                {
                    var ceCfg = GetClass(ce.FullName + "Config", false);
                    if (ceCfg != null)
                    {
                        var ctors = ce.Members.OfType<Method>().Where(t => t.IsConstructor).ToList();
                        if (ctors.Where(t => t.Parameters.Count == 1 && t.Parameters[0].Type == ceCfg).FirstOrDefault() == null)
                        {
                            ce.Members.Add(new Method { IsConstructor = true, Parameters = new List<Parameter> { new Parameter { Name = "config", Type = ceCfg } } });
                        }
                    }
                    if (!HasEmptyOrDefaultConstructor(ce))
                        ce.Members.Add(new Method { IsConstructor = true });
                });

            list.ForEach(t => t.Members.Where(m => m.DeclaringClass == null).ForEach(m => m.DeclaringClass = t));

            return list;
            //list.ForEach(t => t.Members.Where(m => m.Name=="dd" && m.Type==null).ForEach(m => m.Type = GetClass("Ext.dd.DragSource ")));
            //list.ForEach(t => t.Members.Where(m => m.Name == "dd").ForEach(m => 
            //    {
            //        var x = m;
            //    }));
        }

        static bool HasEmptyOrDefaultConstructor(Class ce)
        {
            var ctors = ce.Members.OfType<Method>().Where(t => t.IsConstructor).ToList();
            if (ctors.Count == 0)
                return true;
            foreach (var ctor in ctors)
            {
                if (ctor.Parameters.Count==0 || ctor.Parameters.All(t => t.IsOptional))
                    return true;
            }
            return false;
        }
        static bool HasSameNameAndParameterTypes(Element x, Element y)
        {
            if (x is Method && y is Method)
            {
                var me1 = (Method)x;
                var me2 = (Method)y;
                if ((me1.IsConstructor && me2.IsConstructor) || me1.Name == me2.Name)
                {
                    if (me1.Parameters.Count == me2.Parameters.Count)
                    {
                        if (me1.Parameters.TrueForAllTwice(me2.Parameters, (xx, yy) => xx.Type == yy.Type))
                            return true;
                    }
                }
                return false;
            }
            if (x.Name == y.Name)
            {
                return true;
            }
            return false;
        }

        static HashSet<Class> Exported = new HashSet<Class>();
        private static void Export(List<Class> list, string csFile)
        {
            if (File.Exists(csFile))
                File.Delete(csFile);
            using (var writer = new StreamWriter(csFile))
            {
                var exporter = new CodeModelExporter { Assembly = Assembly, Writer = new IndentedTextWriter(writer) };
                exporter.ExportHeader();
                exporter.Export(list);
            }
        }


        static bool IsDeclared(ExtClass ce2, ExtMember me2)
        {
            if (me2.owner == ce2.name)
                return true;

            var ce = GetClass(ce2.name, false);
            var ceOwner = GetClass(me2.owner);
            if (ce.IsInterface && ceOwner.IsInterface)
                return false;
            if (ceOwner.IsInterface)
            {
                if (ce.BaseClass != null && !ce.BaseClass.IsInterface && ce.BaseClass.Interfaces.Contains(ceOwner) || ce.BaseClass.BaseClass == ceOwner)
                    return false; //base class already implements it
                return true;
            }

            //if (ce2.allMixins.Contains(me2.owner))
            //    return true;
            //var baseCe = ce2.superclasses.Where(t=>t==me2.owner).Select(t=>GetClass(t)).FirstOrDefault();
            //if (baseCe != null && baseCe.IsInterface)
            //    return true;
            return false;
        }
        private static List<Class> Process(ExtClass ce2)
        {
            Console.WriteLine(ce2.name);
            var ce = GetClass(ce2.name, true);
            ce.Attributes.Add(CreateJsAttribute("Prototype"));
            ce.IsInterface = ce2.mixedInto != null && ce2.mixedInto.Count > 0;
            //if (ce2.singleton)
            //{
            //    var pe = new Property { IsStatic = true, Name = "Singleton", Type = ce };
            //    pe.Attributes.Add(new Attribute { Name = "JsProperty", NamedParamters = new Dictionary<string, string> { { "Name", "\"\"" } } });
            //    ce.Members.Add(pe);
            //}


            var ceCfg = GetClass(ce.FullName + "Config", true);
            ceCfg.Attributes.Add(CreateJsAttribute("Json"));

            var ceEvents = GetClass(ce.FullName + "Events", true);
            ceEvents.Attributes.Add(CreateJsAttribute("Json"));
            var list = new List<Class> { ce, ceCfg, ceEvents };

            return list;
        }
        static void ProcessBaseClassAndInterfaces(ExtClass ce2)
        {
            var ce = GetClass(ce2.name, false);
            if (ce2.superclasses != null && ce2.superclasses.Count > 0)
                ce.BaseClass = GetClass(ce2.superclasses.Last());
            ce.Interfaces.AddRange(ce2.allMixins.Select(t => GetClass(t)));

            if (ce.BaseClass != null)
            {
                var ceCfg = GetClass(ce.FullName + "Config", false);
                if (ceCfg != null)
                    ceCfg.BaseClass = GetClass(ce.BaseClass.FullName + "Config", false);
                var ceEvents = GetClass(ce.FullName + "Events", true);
                if (ceEvents != null)
                    ceEvents.BaseClass = GetClass(ce.BaseClass.FullName + "Events", false);
            }

        }
        private static void ProcessMembers(ExtClass ce2)
        {
            Console.WriteLine(ce2.name);
            var ce = GetClass(ce2.name);
            ce.Summary = FixDoc(ce2.doc);
            ce.Members.AddRange(ce2.members.method.Where(t => IsDeclared(ce2, t)).Select(t => ProcessMethod(t)));
            ce.Members.AddRange(ce2.members.property.Where(t => IsDeclared(ce2, t)).Select(t => ProcessProperty(t)));

            var ceCfg = GetClass(ce.FullName + "Config", false);
            if (ceCfg != null)
                ceCfg.Members.AddRange(ce2.members.cfg.Where(t => IsDeclared(ce2, t)).Select(t => ProcessCfg(t)));

            var ceEvents = GetClass(ce.FullName + "Events", false);
            if (ceEvents != null)
                ceEvents.Members.AddRange(ce2.members.@event.Where(t => IsDeclared(ce2, t)).Select(t => ProcessEvent(t)));
            if (ce2.singleton)
            {
                ce.Members.ForEach(t => t.IsStatic = true);
            }
        }

        private static Field ProcessEvent(ExtMember ev2)
        {
            var pe = new Field { Name = ev2.name, Type = GetClass("JsString"), Summary = ev2.shortDoc };
            SetModifiers(ev2, pe);
            pe.IsStatic = true;
            pe.Initializer = "\"" + ev2.name + "\"";
            return pe;
            //var ev = new Event { Name = ev2.name, Type = GetClass(ev2.type) };
            //if (ev.Type == null)
            //{
            //    if (ev2.@params.Count > 0)
            //    {
            //        ev.Type = Context.MakeGenericClass(Context.GetClass("JsAction`"+ev2.@params.Count), ev2.@params.Select(t=>GetClass(t.type)).ToList());
            //    }
            //    else
            //    {
            //        ev.Type = Context.GetClass("JsAction");
            //    }
            //}
            //if (ev.Type == null)
            //{
            //}
            //return ev;
        }

        private static void SetModifiers(ExtMember me2, Element me)
        {
            me.IsStatic = me2.@static;
            me.IsPrivate = me2.@private;
            me.IsProtected = me2.@protected;
        }

        private static Property ProcessProperty(ExtMember p)
        {
            return ProcessCfg(p);
        }

        private static Method ProcessMethod(ExtMember me2)
        {
            var me = new Method { Name = me2.name, Type = GetClass(me2.@return.type), Summary = me2.shortDoc };
            if (me2.name == "constructor")
            {
                me.IsConstructor = true;
            }
            me.Parameters.AddRange(me2.@params.Select(t => ProcessParam(t)));
            return me;
        }

        static string FixDoc(string doc)
        {
            if (doc == null)
                return null;
            var text = new HtmlParser(new Majestic12.HTMLparser(doc)).InnerText();
            var xml = HttpUtility.HtmlEncode(text);
            xml = xml.Replace("&...", "&amp;...");
            return xml;
        }
        private static Parameter ProcessParam(ExtParam prm2)
        {
            var prm = new Parameter { Name = prm2.name, Type = GetClass(prm2.type), IsOptional = prm2.optional, Summary = FixDoc(prm2.doc) };
            return prm;
        }

        static Class GetClass(string name, bool? autoCreate = null)
        {
            if (name.IsNullOrEmpty())
                return null;
            name = name.Trim('[', ']', '.');
            var ce = Context.GetClass(name);
            if (ce == null)
            {
                if (name.Contains("/") || name.Contains("|"))
                    return ObjectClass;
            }
            name = Context.ClassMappings.TryGetValue(name) ?? name;
            if (ce == null && autoCreate.GetValueOrDefault(true))
            {
                if (autoCreate == null)
                {
                }
                ce = new Class { FullName = name };
                Assembly.Classes.Add(ce);
            }
            return ce;
        }

        private static Property ProcessCfg(ExtMember t)
        {
            var pe = new Property { Name = t.name, Type = GetClass(t.type), Summary = t.shortDoc };

            return pe;
        }


        private static Attribute CreateJsAttribute(string jsMode)
        {
            return new Attribute
            {
                Name = "JsType",
                Parameters = new List<string> { "JsMode." + jsMode },
                NamedParamters = new Dictionary<string, string> 
                        {
                            {"Export", "false"}, 
                        }
            };
        }


        public static Class VoidClass { get; set; }
    }
}
