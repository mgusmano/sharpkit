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
    [JsType(JsMode.Prototype, Export=false)] 
    public class SphereGeometry: Geometry
    {
        public SphereGeometry(JsNumber radius, JsNumber segmentsWidth, JsNumber segmentsHeight) { }
        public SphereGeometry(JsNumber radius, JsNumber segmentsWidth, JsNumber segmentsHeight, JsNumber phiStart, JsNumber phiLength) { }
        public SphereGeometry(JsNumber radius, JsNumber segmentsWidth, JsNumber segmentsHeight, JsNumber phiStart, JsNumber phiLength, JsNumber thetaStart, JsNumber thetaLength) { }
    }
}