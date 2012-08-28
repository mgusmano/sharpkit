using System;
using System.Collections.Generic;
using System.Linq;

using SharpKit.JavaScript;

#if HTML4
using SharpKit.Html4;
#else
using SharpKit.Html;
#endif

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class PointLight : Light
    {
        public PointLight(JsNumber hex) { }
        public PointLight(JsNumber hex, JsNumber intensity) { }
        public PointLight(JsNumber hex, JsNumber intensity, JsNumber distance) { }
    }

}