using SharpKit.JavaScript;
using SharpKit.Three;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class PolyhedronGeometry : Geometry
    {
        public PolyhedronGeometry(Vector3[] vertices, Face3[] faces, JsNumber radius, JsNumber detail) { }
    }
}