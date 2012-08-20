using SharpKit.JavaScript;
using System;

namespace SharpKitWebApp5
{
    [JsType]
    public class DependencyAttribute : Attribute
    {
        public string Name { get; set; }

        public DependencyAttribute()
        { }

        public DependencyAttribute(string name)
        {
            Name = name;
        }
        public Type Type { get; set; }
    }

    [JsType]
    class MyTest
    {


        [Dependency]
        public object DateProvider { get; set; }

        [Dependency(Name = "XX", Type=typeof(string))]
        public object DateProvider3 { get; set; }

        [Dependency("XX")]
        public object DateProvider2 { get; set; }
    }
}