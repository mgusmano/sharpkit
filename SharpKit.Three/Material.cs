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
    public class Material
    {
        public Material() { }
        public Material(MaterialOptions parameters) { }

        //enums
        //todo missing enums

        //properties
        public JsNumber opacity { get; set; }
        public JsBoolean transparent { get; set; }

        public BlendingMode blending { get; set; }
        public JsBoolean depthTest { get; set; }
        public JsBoolean depthWrite { get; set; }

        public JsBoolean polygonOffset { get; set; }
        public JsNumber polygonOffsetFactor { get; set; }
        public JsNumber polygonOffsetUnits { get; set; }
        public JsNumber alphaTest { get; set; }
        public JsNumber overdraw { get; set; }

        //methods
        //todo missing methods

    }
}