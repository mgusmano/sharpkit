using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    [JsType(JsMode.Prototype, Export = false, Name = "url")]
    public partial class Url
    {
        public static Url parse(JsString url, bool x) { return null; }
        public JsString query { get; set; }
        //TODO: add all properties
    }
    [JsType(JsMode.Prototype, Export = false, Name = "connection")]
    public partial class Connection
    {
        public static Connection query(JsString squery, JsAction<JsError, object, object> callback) { return null; }
    }

    public partial class Request
    {
        public JsString url { get; set; }
    }
}
