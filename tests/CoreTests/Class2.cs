using SharpKit.JavaScript;

namespace SharpKitWebApp5
{
    [JsType]
    public class Class2
    {
        void foo()
        {
            var x = new int[7, 8];
            x[4, 5] = 9;
        }
    }
}