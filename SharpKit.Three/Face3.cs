using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Face3
    {
        public Face3(Vector3 a, Vector3 b, Vector3 c, Vector3 normal, Color color, JsNumber materialIndex) { }

        public Face3 clone() { return null; }
    }
}
