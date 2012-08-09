using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.ExtJs4.Generator
{
    class Class : Element
    {
        public Class()
        {
            Members = new List<Element>();
            GenericArguments = new List<Class>();
            Interfaces = new List<Class>();
        }
        public string Namespace { get; set; }
        public List<Class> GenericArguments { get; set; }
        public Class BaseClass { get; set; }
        public List<Class> Interfaces { get; set; }
        public List<Element> Members { get; set; }
        public string FullName
        {
            get
            {
                if (DeclaringClass != null)
                {
                    return DeclaringClass.FullName + "+" + Name;
                }
                if (Namespace.IsNotNullOrEmpty())
                    return Namespace + "." + Name;
                return Name;
            }
            set
            {
                var tokens = value.Split('.');
                Name = tokens.Skip(tokens.Length - 1).First();
                Namespace = tokens.Take(tokens.Length - 1).StringConcat(".");
            }
        }
        public override string ToString()
        {
            return FullName;
        }
        public bool IsInterface { get; set; }
    }
    class Method : Element
    {
        public Method()
        {
            Parameters = new List<Parameter>();
        }
        public List<Parameter> Parameters { get; set; }

        public bool IsConstructor { get; set; }
    }
    class Parameter : Element
    {
        public bool IsOptional { get; set; }
    }
    class Field : Element
    {
        public string Initializer { get; set; }
    }
    class Property : Element
    {
    }
    class Event : Element
    {
    }
    class Element
    {
        public Element()
        {
            Attributes = new List<Attribute>();
        }
        public bool IsStatic { get; set; }
        public Class DeclaringClass { get; set; }

        public Class Type { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public List<Attribute> Attributes { get; set; }
        public string Summary { get; set; }
        public string Remarks { get; set; }


        public bool IsVirtual { get; set; }

        public bool IsOverride { get; set; }

        public bool IsNew { get; set; }

        public bool IsProtected { get; set; }

        public bool IsPrivate { get; set; }
    }
    class Assembly
    {
        public Assembly()
        {
            Classes = new List<Class>();
            Usings = new List<string>();

        }
        public List<Class> Classes { get; set; }
        public IEnumerable<Class> AllClasses
        {
            get
            {
                foreach (var ce in Classes)
                {
                    yield return ce;
                    foreach (var ce2 in ce.Members.OfType<Class>())
                        yield return ce2;
                }
            }
        }
        public Class GetClass(string fullName)
        {
            return AllClasses.Where(t => t.FullName == fullName).FirstOrDefault();
        }
        public List<string> Usings { get; set; }
    }

    class AssemblyContext
    {
        public AssemblyContext()
        {
            Assemblies = new List<Assembly>();
            ClassMappings = new Dictionary<string, string>();
        }
        public List<Assembly> Assemblies { get; set; }
        public Dictionary<string, string> ClassMappings { get; set; }
        public Class GetClass(string name)
        {
            name = ClassMappings.TryGetValue(name) ?? name;
            foreach (var asm in Assemblies)
            {
                var type = asm.GetClass(name);
                if (type != null)
                    return type;
            }
            return null;
        }
        public Class MakeGenericClass(Class ce, List<Class> genericArgs)
        {
            return new Class { Name = ce.Name, Namespace = ce.Namespace, GenericArguments = genericArgs };
        }
    }

    class Attribute
    {
        public Attribute()
        {
            Parameters = new List<string>();
            NamedParamters = new Dictionary<string, string>();
        }
        public Attribute Clone()
        {
            return new Attribute { Name = Name, Parameters = new List<string>(Parameters), NamedParamters = new Dictionary<string, string>(NamedParamters) };
        }
        public string Name { get; set; }
        public List<string> Parameters { get; set; }
        public Dictionary<string, string> NamedParamters { get; set; }
    }


    static class CodeModelExtensions
    {
        public static bool HasEmptyConstructor(this Class ce)
        {
            return ce.Members.OfType<Method>().Where(t => t.IsConstructor && t.Parameters.Count == 0).FirstOrDefault() != null;
        }
        public static bool HasAnyConstructor(this Class ce)
        {
            return ce.Members.OfType<Method>().Where(t => t.IsConstructor).FirstOrDefault() != null;
        }
        public static IEnumerable<Method> Methods(this Class ce)
        {
            return ce.Members.OfType<Method>().Where(t=>!t.IsConstructor);
        }
        public static IEnumerable<Property> Properties(this Class ce)
        {
            return ce.Members.OfType<Property>();
        }
        public static IEnumerable<Method> Constructors(this Class ce)
        {
            return ce.Members.OfType<Method>().Where(t=>t.IsConstructor);
        }
    }

}
