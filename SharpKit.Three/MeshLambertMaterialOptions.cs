using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SharpKit.Html4;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Json, Export = false)]
    public class MeshLambertMaterialOptions
    {
        public JsNumber color { get; set; }
    }
}