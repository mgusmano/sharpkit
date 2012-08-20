using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SharpKit.Html4;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export=false)] 
    public class Camera : Object3D 
    { 
        public Camera() {}
        public Matrix4  matrixWorldInverse  {get;set;} 
        public Matrix4  projectionMatrix  {get;set;} 
        public Matrix4  projectionMatrixInverse  {get;set;} 
        public void lookAt (Vector3 target) {}
    }
}