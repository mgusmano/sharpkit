using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Mesh : Object3D
    {
        public Mesh(Geometry geometry) { }
        public Mesh(Geometry geometry, Material material) { }

        //properties
        public JsNumber boundRadius { get; set; }

        //methods
        public Mesh getMorphTargetIndexByName(JsString name) { return null; }
    }
}