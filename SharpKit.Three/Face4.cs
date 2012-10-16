using SharpKit.JavaScript;
using THREE;

namespace SharpKit.Three
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Face4
    {
        public Face4(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Vector3 normal, Color color, JsNumber materialIndex) { }

        public Face4 clone() { return null; }
    }
}
