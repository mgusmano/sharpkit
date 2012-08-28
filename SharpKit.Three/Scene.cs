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
    public class Scene : Object3D
    {
        public Scene() { }

        //fill in correct properties
	    //this.fog = null;
	    //this.overrideMaterial = null;
        public JsBoolean matrixAutoUpdate {get; set; }

        //only contains private methods
    }
}