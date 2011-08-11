using SharpKit.JavaScript;
using org.w3c.dom.html;

namespace SharpKit.W3C.DOM.Samples
{

    [JsType(JsMode.Global, Filename = "Canvas.js", OrderInFile = 1)]
    public class Canvas : HTMLContext
    {
        static Canvas()
        {
            var spinner = new Spinner(new SpinnerData { x = 50, y = 50, size = 20, degrees = 30 });
        }
    }

    [JsType(JsMode.Json)]
    class SpinnerData
    {
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber size { get; set; }
        public JsNumber degrees { get; set; }
    }

    [JsType(JsMode.Prototype, Filename = "Canvas.js", Name = "Spinner")]
    class Spinner : HTMLContext
    {
        SpinnerData spinnerData { get; set; }
        JsNumber canvasTimer { get; set; }
        CanvasRenderingContext2D ctx { get; set; }
        JsNumber index { get; set; }
        JsArray<JsNumber> degreesList { get; set; }
        JsNumber degrees { get; set; }

        public Spinner(SpinnerData sd)
        {
            buildSpinner(sd);
        }
        void buildSpinner(SpinnerData sd)
        {
            spinnerData = sd;
            var canvas = document.getElementsByTagName("canvas")[0].As<HTMLCanvasElement>();
            ctx = canvas.getContext("2d").As<CanvasRenderingContext2D>();
            index = 0;
            degrees = spinnerData.degrees;
            degreesList = new JsArray<JsNumber>();
            for (var x = 0; x < degrees; x++)
                degreesList.push(x);
            // reset
            index = 0;
            // so I can kill it later
            canvasTimer = setInterval(draw, 1000 / degrees);
        }

        void reset()
        {
            ctx.clearRect(0, 0, 100, 100); // clear canvas
            var left = degreesList.slice(0, 1);
            var right = degreesList.slice(1, degreesList.length);
            degreesList = right.concat(left);
        }

        void draw()
        {
            if (index == 0)
                reset();

            ctx.save();

            var degree = degreesList[index];
            var color = JsMath.floor(255 / degrees * index);
            ctx.strokeStyle = "rgb(" + color + ", " + color + ", " + color + ")";
            ctx.lineWidth = spinnerData.size;
            ctx.beginPath();
            var startAngle = JsMath.floor(360 / degrees * (degree));
            var endAngle = JsMath.floor(360 / degrees * (degree + 1)) - 1;

            ctx.arc(spinnerData.x, spinnerData.y, spinnerData.size, (JsMath.PI / 180) * startAngle, (JsMath.PI / 180) * endAngle, false);
            ctx.stroke();

            ctx.restore();

            index++;
            if (index >= degrees)
                index = 0;
        }

    }

}