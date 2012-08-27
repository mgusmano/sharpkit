using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.Html4;

namespace ClrModeSamples.DeepClone
{
    [JsType(JsMode.Global)]
    public class HTMLPage1 : HtmlContext
    {
        static void Main()
        {
            var c = new Contact { Phones = new List<Phone> { new Phone{Number="213123"} } };
            var c2 = ObjectCloner.CloneObject(c);
            alert(c == c2);
            alert(c2.Phones[0].Number);
        }
    }

    [JsType]
    class Contact
    {
        public List<Phone> Phones { get; set; }
    }

    [JsType]
    class Phone
    {
        public string Number { get; set; }
    }
}