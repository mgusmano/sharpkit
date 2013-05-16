using SharpKit.JavaScript;

namespace SharpKitWebApp5
{
    [JsType(JsMode.Prototype)]
    public class Class2
    {
        void foo()
        {
            var list = new JsArray<object>();
            list.push(new byte[7]);
            list.push(new short[7]);
            list.push(new ushort[7]);
            list.push(new int[7]);
            list.push(new uint[7]);
            list.push(new float[7]);
            list.push(new double[7]);


            list.push(new byte[] { 7, 8, 9 });
            list.push(new short[] { 7, 8, 9 });
            list.push(new ushort[] { 7, 8, 9 });
            list.push(new int[] { 7, 8, 9 });
            list.push(new uint[] { 7, 8, 9 });
            list.push(new float[] { 7, 8, 9 });
            list.push(new double[] { 7, 8, 9 });


            list.push(new[] { 7, 8, 9 });
            list.push(new[] { 7.7, 8.8, 9.9 });
            list.push(new[] { 7d, 8d, 9d });

            int[] a = { 0, 2, 4, 6, 8 };

        }
    }
}