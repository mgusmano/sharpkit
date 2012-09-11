using SharpKit.JavaScript;

namespace SharpKitWebApp5
{
    [JsType(JsMode.Prototype, NativeOverloads = false, NativeConstructors = true)]
    public class Foo2
    {
        public void test()
        {
            JsNumber b;
            foo1(1, out b);
        }

        public void foo1(JsNumber a, out JsNumber outB)
        {
            foo2(1, out outB);
            outB = 7;
        }

        public void foo2(JsNumber a, out JsNumber outC)
        {
            outC = 2;
        }
    }
}