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
    public class SpotLight : Light
    {
        SpotLight(JsNumber hex, JsNumber intensity, JsNumber distance, JsBoolean castShadow) { }
    }
}