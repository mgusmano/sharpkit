using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;

namespace QooxDooTest
{
    [JsType(JsMode.Json)]
    public class LayoutProperties
    {
        [JsProperty(Name="left")]
        public object Left { get; set; }
        [JsProperty(Name = "top")]
        public object Top { get; set; }
        [JsProperty(Name = "right")]
        public object Right { get; set; }
        [JsProperty(Name = "bottom")]
        public object Bottom { get; set; }
        [JsProperty(Name = "width")]
        public JsString Width { get; set; }
        [JsProperty(Name = "height")]
        public JsString Height { get; set; }
    }
}