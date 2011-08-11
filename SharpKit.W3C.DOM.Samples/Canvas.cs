using SharpKit.JavaScript;
using org.w3c.dom.html;

namespace SharpKit.W3C.DOM.Samples
{
    [JsType(JsMode.Json)]
    class SpinnerData
    {
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber size { get; set; }
        public JsNumber degrees { get; set; }
    }

    [JsType(JsMode.Global, Filename = "Canvas.js")]
    public class Canvas : HTMLContext
    {
        static Canvas()
        {
            buildSpinner(new SpinnerData { x = 50, y = 50, size = 20, degrees = 30 });
        }
        static JsNumber canvasTimer;
        static CanvasRenderingContext2D ctx;
        static JsNumber i = 0;
        static JsArray<JsNumber> degreesList;
        static JsNumber degrees;
        static SpinnerData data;
        static void buildSpinner(SpinnerData d)
        {
            data = d;
            var canvas = document.getElementsByTagName("canvas")[0].As<HTMLCanvasElement>();
            canvas.height = 100;
            canvas.width = 300;
            document.getElementsByTagName("article")[0].appendChild(canvas);
            ctx = canvas.getContext("2d").As<CanvasRenderingContext2D>();
            i = 0;
            degrees = data.degrees;
            degreesList = new JsArray<JsNumber>();

            for (i = 0; i < degrees; i++)
            {
                degreesList.push(i);
            }

            // reset
            i = 0;

            // so I can kill it later
            canvasTimer = setInterval(draw, 1000 / degrees);
        }

        static void reset()
        {
            ctx.clearRect(0, 0, 100, 100); // clear canvas

            var left = degreesList.slice(0, 1);
            var right = degreesList.slice(1, degreesList.length);
            degreesList = right.concat(left);
        }

        static void draw()
        {
            JsNumber c, s, e;

            var d = 0;

            if (i == 0)
            {
                reset();
            }

            ctx.save();

            d = degreesList[i];
            c = JsMath.floor(255 / degrees * i);
            ctx.strokeStyle = "rgb(" + c + ", " + c + ", " + c + ")";
            ctx.lineWidth = data.size;
            ctx.beginPath();
            s = JsMath.floor(360 / degrees * (d));
            e = JsMath.floor(360 / degrees * (d + 1)) - 1;

            ctx.arc(data.x, data.y, data.size, (JsMath.PI / 180) * s, (JsMath.PI / 180) * e, false);
            ctx.stroke();

            ctx.restore();

            i++;
            if (i >= degrees)
            {
                i = 0;
            }
        }
    }

}