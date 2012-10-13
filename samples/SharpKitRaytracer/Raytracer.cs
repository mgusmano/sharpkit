using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.Html4;
using SharpKit.jQuery;
using SharpKit.Html;

namespace SharpKitRaytracer
{
    [JsType(JsMode.Clr)]
    public class Vector 
    {
        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z) 
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector times(double k, Vector v) 
        {
            return new Vector(k * v.x, k * v.y, k * v.z);
        }

        public static Vector minus(Vector v1, Vector v2) 
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector plus(Vector v1, Vector v2) 
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static double dot(Vector v1, Vector v2) 
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public static double mag(Vector v) 
        {
            return Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
        }

        public static Vector norm(Vector v) 
        {
            var mag = Vector.mag(v);
            var div = (mag == 0) ? double.PositiveInfinity : 1.0 / mag;
            return Vector.times(div, v);
        }

        public static Vector cross(Vector v1, Vector v2) 
        {
            return new Vector(v1.y * v2.z - v1.z * v2.y,
                          v1.z * v2.x - v1.x * v2.z,
                          v1.x * v2.y - v1.y * v2.x);
        }
    }

    [JsType(JsMode.Clr)]
    public class Color 
    {
        public double r;
        public double g;
        public double b;
        public Color(double r, double g, double b) 
        { 
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static Color scale(double k, Color v) 
        {
            return new Color(k * v.r, k * v.g, k * v.b);
        }

        public static Color plus(Color v1, Color v2) 
        {
            return new Color(v1.r + v2.r, v1.g + v2.g, v1.b + v2.b);
        }

        public static Color times(Color v1, Color v2) 
        {
            return new Color(v1.r * v2.r, v1.g * v2.g, v1.b * v2.b);
        }

        public static Color white = new Color(1.0, 1.0, 1.0);
        public static Color grey = new Color(0.5, 0.5, 0.5);
        public static Color black = new Color(0.0, 0.0, 0.0);
        public static Color background = Color.black;
        public static Color defaultColor = Color.black;

        public static double legalize(double d)
        {
            return d > 1 ? 1 : d;
        }

        public static Color toDrawingColor(Color c) 
        {
            return new Color(
                r: Math.Floor(legalize(c.r) * 255),
                g: Math.Floor(legalize(c.g) * 255),
                b: Math.Floor(legalize(c.b) * 255)
            );
        }
    }

    [JsType(JsMode.Clr)]
    public class Camera 
    {
        public Vector pos;
        public Vector forward;
        public Vector right;
        public Vector up;

        public Camera (Vector pos, Vector lookAt) 
        {
            this.pos = pos;
            var down = new Vector(0.0, -1.0, 0.0);
            this.forward = Vector.norm(Vector.minus(lookAt, pos));
            this.right = Vector.times(1.5, Vector.norm(Vector.cross(this.forward, down)));
            this.up = Vector.times(1.5, Vector.norm(Vector.cross(this.forward, this.right)));
        }
    }

    [JsType(JsMode.Clr)]
    public class Ray 
    {
        public Ray(Vector start, Vector dir)
        {
            this.start = start;
            this.dir = dir;
        }

        public Vector start;
        public Vector dir;
    }

    [JsType(JsMode.Clr)]
    public class Intersection 
    {
        public Intersection(Thing thing, Ray ray, double dist)
        {
            this.thing = thing;
            this.ray = ray;
            this.dist = dist;
        }

        public Thing thing;
        public Ray ray;
        public double dist;
    }

    [JsType(JsMode.Clr)]
    public abstract class Surface 
    {
        abstract public Color diffuse(Vector pos);
        abstract public Color specular(Vector pos);
        abstract public double reflect(Vector pos);
        public double roughness;
    }

    [JsType(JsMode.Clr)]
    public abstract class Thing 
    {
        abstract public Intersection intersect(Ray ray);
        abstract public Vector normal(Vector pos);
        public Surface surface;
    }

    [JsType(JsMode.Clr)]
    public class Light 
    {
        public Light(Vector pos, Color color)
        {
            this.pos = pos;
            this.color = color;
        }

        public Vector pos;
        public Color color;
    }

    [JsType(JsMode.Clr)]
    public class Scene 
    {
        public Scene(List<Thing> things, List<Light> lights, Camera camera)
        {
            this.things = things;
            this.lights = lights;
            this.camera = camera;
        }

        public List<Thing> things;
        public List<Light> lights;
        public Camera camera;
    }

    [JsType(JsMode.Clr)]
    class Sphere : Thing 
    {
        double radius2;
        Vector center;
        Surface surface;

        public Sphere(Vector center, double radius, Surface surface) 
        {
            this.center = center;
            this.radius2 = radius * radius;
            this.surface = surface;
        }

        public override Vector normal(Vector pos) 
        {
            return Vector.norm(Vector.minus(pos, this.center));
        }

        public override Intersection intersect(Ray ray) 
        {
            var eo = Vector.minus(this.center, ray.start);
            var v = Vector.dot(eo, ray.dir);
            var dist = 0.0;
            if (v >= 0) 
            {
                var disc = this.radius2 - (Vector.dot(eo, eo) - v * v);
                if (disc >= 0) 
                {
                    dist = v - Math.Sqrt(disc);
                }
            }
            if (dist == 0) 
            {
                return null;
            } 
            else 
            {
                return new Intersection(this, ray, dist);
            }
        }

    }

    [JsType(JsMode.Clr)]
    class Plane : Thing 
    {
        Vector norm;
        double offset;
        Surface surface;

        public override Intersection intersect(Ray ray)
        {
            var denom = Vector.dot(norm, ray.dir);
            if (denom > 0) 
            {
                return null;
            } 
            else 
            {
                var dist = (Vector.dot(norm, ray.start) + offset) / (-denom);
                return new Intersection(this, ray, dist);
            }
        }

        public override Vector normal(Vector pos)
        {
            return norm;
        }

        public Plane(Vector norm, double offset, Surface surface) 
        {
            this.norm = norm;
            this.offset = offset;
            this.surface = surface;
        }
    }

    namespace Surfaces
    {
        [JsType(JsMode.Clr)]
        public class shiny : Surface 
        {
            public override Color diffuse(Vector pos)
            {
                return Color.white; 
            }

            public override Color specular(Vector pos)
            {
                return Color.grey;
            }

            public override double reflect(Vector pos)
            {
                return 0.7;
            }

            new public double roughness = 250;
        }

        [JsType(JsMode.Clr)]
        public class checkerboard : Surface 
        {
            public override Color diffuse(Vector pos)
            {
               if ((Math.Floor(pos.z) + Math.Floor(pos.x)) % 2 != 0) 
                {
                    return Color.white;
                } 
                else 
                {
                    return Color.black;
                }
            }

            public override Color specular(Vector pos)
            {
                return Color.white;
            }

            public override double reflect(Vector pos)
            {
                if ((Math.Floor(pos.z) + Math.Floor(pos.x)) % 2 != 0) 
                {
                    return 0.1;
                } 
                else 
                {
                    return 0.7;
                }
            }
            
            new public double roughness = 150;
        }
    }

    [JsType(JsMode.Clr)]
    public class RayTracer 
    {
        private int maxDepth = 5;

        private Intersection intersections(Ray ray, Scene scene) 
        {
            var closest = double.PositiveInfinity;
            Intersection closestInter = null;
            foreach (var i in scene.things) 
            {
                var inter = i.intersect(ray);
                if (inter != null && inter.dist < closest) 
                {
                    closestInter = inter;
                    closest = inter.dist;
                }
            }
            return closestInter;
        }

        private double? testRay(Ray ray, Scene scene) 
        {
            var isect = this.intersections(ray, scene);
            if (isect != null) 
            {
                return isect.dist;
            } 
            else 
            {
                return null;
            }
        }

        private Color traceRay(Ray ray, Scene scene, double depth) 
        {
            var isect = this.intersections(ray, scene);
            if (isect == null) 
            {
                return Color.background;
            } 
            else 
            {
                return this.shade(isect, scene, depth);
            }
        }

        private Color shade(Intersection isect, Scene scene, double depth) 
        {
            var d = isect.ray.dir;
            var pos = Vector.plus(Vector.times(isect.dist, d), isect.ray.start);
            var normal = isect.thing.normal(pos);
            var reflectDir = Vector.minus(d, Vector.times(2, Vector.times(Vector.dot(normal, d), normal)));
            var naturalColor = Color.plus(Color.background, this.getNaturalColor(isect.thing, pos, normal, reflectDir, scene));
            var reflectedColor = (depth >= this.maxDepth) ? Color.grey : this.getReflectionColor(isect.thing, pos, normal, reflectDir, scene, depth);
            return Color.plus(naturalColor, reflectedColor);
        }

        private Color getReflectionColor(Thing thing, Vector pos, Vector normal, Vector rd, Scene scene, double depth) 
        {
            return Color.scale(thing.surface.reflect(pos), this.traceRay(new Ray (pos, rd), scene, depth + 1));
        }

        Thing thing;
        Vector pos;
        Vector norm;
        Vector rd;
        Scene scene;

        Color addLight(Color col, Light light)
        {
            var ldis = Vector.minus(light.pos, pos);
            var livec = Vector.norm(ldis);
            var neatIsect = this.testRay(new Ray(pos, livec), scene);
            var isInShadow = (neatIsect == null) ? false : (neatIsect <= Vector.mag(ldis));
            if (isInShadow)
            {
                return col;
            }
            else
            {
                var illum = Vector.dot(livec, norm);
                var lcolor = (illum > 0) ? Color.scale(illum, light.color)
                                          : Color.defaultColor;
                var specular = Vector.dot(livec, Vector.norm(rd));
                var scolor = (specular > 0) ? Color.scale(Math.Pow(specular, thing.surface.roughness), light.color)
                                          : Color.defaultColor;
                return Color.plus(col, Color.plus(Color.times(thing.surface.diffuse(pos), lcolor),
                                                  Color.times(thing.surface.specular(pos), scolor)));
            }
        }

        public Color Reduce(List<Light> list, Color initial)
        {
            Color aggregate = initial;
            foreach (var item in list)
                aggregate = addLight(aggregate, item);

            return aggregate;
        }

        private Color getNaturalColor(Thing thing, Vector pos, Vector norm, Vector rd, Scene scene) 
        {
            this.thing = thing;
            this.pos = pos;
            this.norm = norm;
            this.rd = rd;
            this.scene = scene;
            return Reduce(scene.lights, Color.defaultColor);
        }

        double screenWidth;
        double screenHeight;

        double recenterX(double x)
        {
            return (x - (screenWidth / 2.0)) / 2.0 / screenWidth;
        } 

        double recenterY(double y)
        {
            return -(y - (screenHeight / 2.0)) / 2.0 / screenHeight;
        }

        Vector getPoint(double x, double y, Camera camera)
        {
            return Vector.norm(Vector.plus(camera.forward, Vector.plus(Vector.times(recenterX(x), camera.right), Vector.times(recenterY(y), camera.up))));
        }

        public void render(Scene scene, CanvasRenderingContext2D ctx, double screenWidth, double screenHeight) 
        {
            this.screenWidth = screenWidth;   
            this.screenHeight = screenHeight;   

            for (var y = 0; y < screenHeight; y++) 
            {
                for (var x = 0; x < screenWidth; x++) 
                {
                    var color = this.traceRay( new Ray(scene.camera.pos, getPoint(x, y, scene.camera)), scene, 0);
                    var c = Color.toDrawingColor(color);
                    ctx.fillStyle = "rgb(" + c.r + ", " + c.g + ", " + c.b + ")";
                    ctx.fillRect(x, y, x + 1, y + 1);
                }
            }
        }

    }

    [JsType(JsMode.Clr)]
    public class RaytracerRunner : jQueryContextBase
    {
        Scene defaultScene()
        {
            return new Scene(new List<Thing> {
                                new Plane(new Vector(0.0, 1.0, 0.0), 0.0, new Surfaces.checkerboard()),
                                new Sphere(new Vector(0.0, 1.0, -0.25), 1.0, new Surfaces.shiny()),
                                new Sphere(new Vector(-1.0, 0.5, 1.5), 0.5, new Surfaces.shiny()),
                             },
                             new List<Light> { 
                                new Light( new Vector(-2.0, 2.5, 0.0), new Color(0.49, 0.07, 0.07)),
                                new Light( new Vector(1.5, 2.5, 1.5), new Color(0.07, 0.07, 0.49)),
                                new Light( new Vector(1.5, 2.5, -1.5), new Color(0.07, 0.49, 0.071)),
                                new Light( new Vector(0.0, 3.5, 0.0), new Color(0.21, 0.21, 0.35))
                             },
                             new Camera(new Vector(3.0, 2.0, 4.0), new Vector(-1.0, 0.5, 0.0))
                            );
        }

        public void exec() 
        {
            J(document.body).append("<canvas></canvas");
            var canv = document.getElementsByTagName("canvas")[0].As<HtmlCanvasElement>();
            canv.width = 256;
            canv.height = 256;
            var ctx = canv.getContext("2d").As<CanvasRenderingContext2D>();
            var rayTracer = new RayTracer();
            rayTracer.render(defaultScene(), ctx, canv.width, canv.height);
        }
    }
}