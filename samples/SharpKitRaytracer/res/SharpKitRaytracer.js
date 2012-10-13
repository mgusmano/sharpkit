/*Generated by SharpKit 5 v4.30.0000*/
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var SharpKitRaytracer$Vector =
{
    fullname: "SharpKitRaytracer.Vector",
    baseTypeName: "System.Object",
    staticDefinition:
    {
        times: function (k, v)
        {
            return new SharpKitRaytracer.Vector.ctor(k * v.x, k * v.y, k * v.z);
        },
        minus: function (v1, v2)
        {
            return new SharpKitRaytracer.Vector.ctor(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        },
        plus: function (v1, v2)
        {
            return new SharpKitRaytracer.Vector.ctor(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        },
        dot: function (v1, v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        },
        mag: function (v)
        {
            return System.Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
        },
        norm: function (v)
        {
            var mag = SharpKitRaytracer.Vector.mag(v);
            var div = (mag == 0) ? System.Double.PositiveInfinity : 1 / mag;
            return SharpKitRaytracer.Vector.times(div, v);
        },
        cross: function (v1, v2)
        {
            return new SharpKitRaytracer.Vector.ctor(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }
    },
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (x, y, z)
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
            System.Object.ctor.call(this);
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
};
JsTypes.push(SharpKitRaytracer$Vector);
var SharpKitRaytracer$Color =
{
    fullname: "SharpKitRaytracer.Color",
    baseTypeName: "System.Object",
    staticDefinition:
    {
        cctor: function ()
        {
            SharpKitRaytracer.Color.white = new SharpKitRaytracer.Color.ctor(1, 1, 1);
            SharpKitRaytracer.Color.grey = new SharpKitRaytracer.Color.ctor(0.5, 0.5, 0.5);
            SharpKitRaytracer.Color.black = new SharpKitRaytracer.Color.ctor(0, 0, 0);
            SharpKitRaytracer.Color.background = SharpKitRaytracer.Color.black;
            SharpKitRaytracer.Color.defaultColor = SharpKitRaytracer.Color.black;
        },
        scale: function (k, v)
        {
            return new SharpKitRaytracer.Color.ctor(k * v.r, k * v.g, k * v.b);
        },
        plus: function (v1, v2)
        {
            return new SharpKitRaytracer.Color.ctor(v1.r + v2.r, v1.g + v2.g, v1.b + v2.b);
        },
        times: function (v1, v2)
        {
            return new SharpKitRaytracer.Color.ctor(v1.r * v2.r, v1.g * v2.g, v1.b * v2.b);
        },
        legalize: function (d)
        {
            return d > 1 ? 1 : d;
        },
        toDrawingColor: function (c)
        {
            return new SharpKitRaytracer.Color.ctor(System.Math.Floor$$Double(SharpKitRaytracer.Color.legalize(c.r) * 255), System.Math.Floor$$Double(SharpKitRaytracer.Color.legalize(c.g) * 255), System.Math.Floor$$Double(SharpKitRaytracer.Color.legalize(c.b) * 255));
        }
    },
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (r, g, b)
        {
            this.r = 0;
            this.g = 0;
            this.b = 0;
            System.Object.ctor.call(this);
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
};
JsTypes.push(SharpKitRaytracer$Color);
var SharpKitRaytracer$Camera =
{
    fullname: "SharpKitRaytracer.Camera",
    baseTypeName: "System.Object",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (pos, lookAt)
        {
            this.pos = null;
            this.forward = null;
            this.right = null;
            this.up = null;
            System.Object.ctor.call(this);
            this.pos = pos;
            var down = new SharpKitRaytracer.Vector.ctor(0, -1, 0);
            this.forward = SharpKitRaytracer.Vector.norm(SharpKitRaytracer.Vector.minus(lookAt, pos));
            this.right = SharpKitRaytracer.Vector.times(1.5, SharpKitRaytracer.Vector.norm(SharpKitRaytracer.Vector.cross(this.forward, down)));
            this.up = SharpKitRaytracer.Vector.times(1.5, SharpKitRaytracer.Vector.norm(SharpKitRaytracer.Vector.cross(this.forward, this.right)));
        }
    }
};
JsTypes.push(SharpKitRaytracer$Camera);
var SharpKitRaytracer$Ray =
{
    fullname: "SharpKitRaytracer.Ray",
    baseTypeName: "System.Object",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (start, dir)
        {
            this.start = null;
            this.dir = null;
            System.Object.ctor.call(this);
            this.start = start;
            this.dir = dir;
        }
    }
};
JsTypes.push(SharpKitRaytracer$Ray);
var SharpKitRaytracer$Intersection =
{
    fullname: "SharpKitRaytracer.Intersection",
    baseTypeName: "System.Object",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (thing, ray, dist)
        {
            this.thing = null;
            this.ray = null;
            this.dist = 0;
            System.Object.ctor.call(this);
            this.thing = thing;
            this.ray = ray;
            this.dist = dist;
        }
    }
};
JsTypes.push(SharpKitRaytracer$Intersection);
var SharpKitRaytracer$Surface =
{
    fullname: "SharpKitRaytracer.Surface",
    baseTypeName: "System.Object",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            this.roughness = 0;
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKitRaytracer$Surface);
var SharpKitRaytracer$Thing =
{
    fullname: "SharpKitRaytracer.Thing",
    baseTypeName: "System.Object",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            this.surface = null;
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKitRaytracer$Thing);
var SharpKitRaytracer$Light =
{
    fullname: "SharpKitRaytracer.Light",
    baseTypeName: "System.Object",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (pos, color)
        {
            this.pos = null;
            this.color = null;
            System.Object.ctor.call(this);
            this.pos = pos;
            this.color = color;
        }
    }
};
JsTypes.push(SharpKitRaytracer$Light);
var SharpKitRaytracer$Scene =
{
    fullname: "SharpKitRaytracer.Scene",
    baseTypeName: "System.Object",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (things, lights, camera)
        {
            this.things = null;
            this.lights = null;
            this.camera = null;
            System.Object.ctor.call(this);
            this.things = things;
            this.lights = lights;
            this.camera = camera;
        }
    }
};
JsTypes.push(SharpKitRaytracer$Scene);
var SharpKitRaytracer$Sphere =
{
    fullname: "SharpKitRaytracer.Sphere",
    baseTypeName: "SharpKitRaytracer.Thing",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (center, radius, surface)
        {
            this.radius2 = 0;
            this.center = null;
            this.surface = null;
            SharpKitRaytracer.Thing.ctor.call(this);
            this.center = center;
            this.radius2 = radius * radius;
            this.surface = surface;
        },
        normal: function (pos)
        {
            return SharpKitRaytracer.Vector.norm(SharpKitRaytracer.Vector.minus(pos, this.center));
        },
        intersect: function (ray)
        {
            var eo = SharpKitRaytracer.Vector.minus(this.center, ray.start);
            var v = SharpKitRaytracer.Vector.dot(eo, ray.dir);
            var dist = 0;
            if (v >= 0)
            {
                var disc = this.radius2 - (SharpKitRaytracer.Vector.dot(eo, eo) - v * v);
                if (disc >= 0)
                {
                    dist = v - System.Math.Sqrt(disc);
                }
            }
            if (dist == 0)
            {
                return null;
            }
            else
            {
                return new SharpKitRaytracer.Intersection.ctor(this, ray, dist);
            }
        }
    }
};
JsTypes.push(SharpKitRaytracer$Sphere);
var SharpKitRaytracer$Plane =
{
    fullname: "SharpKitRaytracer.Plane",
    baseTypeName: "SharpKitRaytracer.Thing",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function (norm, offset, surface)
        {
            this.norm = null;
            this.offset = 0;
            this.surface = null;
            SharpKitRaytracer.Thing.ctor.call(this);
            this.norm = norm;
            this.offset = offset;
            this.surface = surface;
        },
        intersect: function (ray)
        {
            var denom = SharpKitRaytracer.Vector.dot(this.norm, ray.dir);
            if (denom > 0)
            {
                return null;
            }
            else
            {
                var dist = (SharpKitRaytracer.Vector.dot(this.norm, ray.start) + this.offset) / (-denom);
                return new SharpKitRaytracer.Intersection.ctor(this, ray, dist);
            }
        },
        normal: function (pos)
        {
            return this.norm;
        }
    }
};
JsTypes.push(SharpKitRaytracer$Plane);
var SharpKitRaytracer$Surfaces$shiny =
{
    fullname: "SharpKitRaytracer.Surfaces.shiny",
    baseTypeName: "SharpKitRaytracer.Surface",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            this.roughness = 250;
            SharpKitRaytracer.Surface.ctor.call(this);
        },
        diffuse: function (pos)
        {
            return SharpKitRaytracer.Color.white;
        },
        specular: function (pos)
        {
            return SharpKitRaytracer.Color.grey;
        },
        reflect: function (pos)
        {
            return 0.7;
        }
    }
};
JsTypes.push(SharpKitRaytracer$Surfaces$shiny);
var SharpKitRaytracer$Surfaces$checkerboard =
{
    fullname: "SharpKitRaytracer.Surfaces.checkerboard",
    baseTypeName: "SharpKitRaytracer.Surface",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            this.roughness = 150;
            SharpKitRaytracer.Surface.ctor.call(this);
        },
        diffuse: function (pos)
        {
            if ((System.Math.Floor$$Double(pos.z) + System.Math.Floor$$Double(pos.x)) % 2 != 0)
            {
                return SharpKitRaytracer.Color.white;
            }
            else
            {
                return SharpKitRaytracer.Color.black;
            }
        },
        specular: function (pos)
        {
            return SharpKitRaytracer.Color.white;
        },
        reflect: function (pos)
        {
            if ((System.Math.Floor$$Double(pos.z) + System.Math.Floor$$Double(pos.x)) % 2 != 0)
            {
                return 0.1;
            }
            else
            {
                return 0.7;
            }
        }
    }
};
JsTypes.push(SharpKitRaytracer$Surfaces$checkerboard);
var SharpKitRaytracer$RayTracer =
{
    fullname: "SharpKitRaytracer.RayTracer",
    baseTypeName: "System.Object",
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            this.maxDepth = 5;
            this.thing = null;
            this.pos = null;
            this.norm = null;
            this.rd = null;
            this.scene = null;
            this.screenWidth = 0;
            this.screenHeight = 0;
            System.Object.ctor.call(this);
        },
        intersections: function (ray, scene)
        {
            var closest = System.Double.PositiveInfinity;
            var closestInter = null;
            var $it1 = scene.things.GetEnumerator();
            while ($it1.MoveNext())
            {
                var i = $it1.get_Current();
                var inter = i.intersect(ray);
                if (inter != null && inter.dist < closest)
                {
                    closestInter = inter;
                    closest = inter.dist;
                }
            }
            return closestInter;
        },
        testRay: function (ray, scene)
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
        },
        traceRay: function (ray, scene, depth)
        {
            var isect = this.intersections(ray, scene);
            if (isect == null)
            {
                return SharpKitRaytracer.Color.background;
            }
            else
            {
                return this.shade(isect, scene, depth);
            }
        },
        shade: function (isect, scene, depth)
        {
            var d = isect.ray.dir;
            var pos = SharpKitRaytracer.Vector.plus(SharpKitRaytracer.Vector.times(isect.dist, d), isect.ray.start);
            var normal = isect.thing.normal(pos);
            var reflectDir = SharpKitRaytracer.Vector.minus(d, SharpKitRaytracer.Vector.times(2, SharpKitRaytracer.Vector.times(SharpKitRaytracer.Vector.dot(normal, d), normal)));
            var naturalColor = SharpKitRaytracer.Color.plus(SharpKitRaytracer.Color.background, this.getNaturalColor(isect.thing, pos, normal, reflectDir, scene));
            var reflectedColor = (depth >= this.maxDepth) ? SharpKitRaytracer.Color.grey : this.getReflectionColor(isect.thing, pos, normal, reflectDir, scene, depth);
            return SharpKitRaytracer.Color.plus(naturalColor, reflectedColor);
        },
        getReflectionColor: function (thing, pos, normal, rd, scene, depth)
        {
            return SharpKitRaytracer.Color.scale(thing.surface.reflect(pos), this.traceRay(new SharpKitRaytracer.Ray.ctor(pos, rd), scene, depth + 1));
        },
        addLight: function (col, light)
        {
            var ldis = SharpKitRaytracer.Vector.minus(light.pos, this.pos);
            var livec = SharpKitRaytracer.Vector.norm(ldis);
            var neatIsect = this.testRay(new SharpKitRaytracer.Ray.ctor(this.pos, livec), this.scene);
            var isInShadow = (neatIsect == null) ? false : (neatIsect <= SharpKitRaytracer.Vector.mag(ldis));
            if (isInShadow)
            {
                return col;
            }
            else
            {
                var illum = SharpKitRaytracer.Vector.dot(livec, this.norm);
                var lcolor = (illum > 0) ? SharpKitRaytracer.Color.scale(illum, light.color) : SharpKitRaytracer.Color.defaultColor;
                var specular = SharpKitRaytracer.Vector.dot(livec, SharpKitRaytracer.Vector.norm(this.rd));
                var scolor = (specular > 0) ? SharpKitRaytracer.Color.scale(System.Math.Pow(specular, this.thing.surface.roughness), light.color) : SharpKitRaytracer.Color.defaultColor;
                return SharpKitRaytracer.Color.plus(col, SharpKitRaytracer.Color.plus(SharpKitRaytracer.Color.times(this.thing.surface.diffuse(this.pos), lcolor), SharpKitRaytracer.Color.times(this.thing.surface.specular(this.pos), scolor)));
            }
        },
        Reduce: function (list, initial)
        {
            var aggregate = initial;
            var $it2 = list.GetEnumerator();
            while ($it2.MoveNext())
            {
                var item = $it2.get_Current();
                aggregate = this.addLight(aggregate, item);
            }
            return aggregate;
        },
        getNaturalColor: function (thing, pos, norm, rd, scene)
        {
            this.thing = thing;
            this.pos = pos;
            this.norm = norm;
            this.rd = rd;
            this.scene = scene;
            return this.Reduce(scene.lights, SharpKitRaytracer.Color.defaultColor);
        },
        recenterX: function (x)
        {
            return (x - (this.screenWidth / 2)) / 2 / this.screenWidth;
        },
        recenterY: function (y)
        {
            return -(y - (this.screenHeight / 2)) / 2 / this.screenHeight;
        },
        getPoint: function (x, y, camera)
        {
            return SharpKitRaytracer.Vector.norm(SharpKitRaytracer.Vector.plus(camera.forward, SharpKitRaytracer.Vector.plus(SharpKitRaytracer.Vector.times(this.recenterX(x), camera.right), SharpKitRaytracer.Vector.times(this.recenterY(y), camera.up))));
        },
        render: function (scene, ctx, screenWidth, screenHeight)
        {
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            for (var y = 0; y < screenHeight; y++)
            {
                for (var x = 0; x < screenWidth; x++)
                {
                    var color = this.traceRay(new SharpKitRaytracer.Ray.ctor(scene.camera.pos, this.getPoint(x, y, scene.camera)), scene, 0);
                    var c = SharpKitRaytracer.Color.toDrawingColor(color);
                    ctx.fillStyle = "rgb(" + c.r + ", " + c.g + ", " + c.b + ")";
                    ctx.fillRect(x, y, x + 1, y + 1);
                }
            }
        }
    }
};
JsTypes.push(SharpKitRaytracer$RayTracer);
var SharpKitRaytracer$RaytracerRunner =
{
    fullname: "SharpKitRaytracer.RaytracerRunner",
    baseTypeName: "System.Object",
    staticDefinition:
    {
        cctor: function ()
        {
        }
    },
    assemblyName: "SharpKitRaytracer",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.Object.ctor.call(this);
        },
        defaultScene: function ()
        {
            return new SharpKitRaytracer.Scene.ctor((function ()
            {
                var $v1 = new System.Collections.Generic.List$1.ctor(SharpKitRaytracer.Thing.ctor);
                $v1.Add(new SharpKitRaytracer.Plane.ctor(new SharpKitRaytracer.Vector.ctor(0, 1, 0), 0, new SharpKitRaytracer.Surfaces.checkerboard.ctor()));
                $v1.Add(new SharpKitRaytracer.Sphere.ctor(new SharpKitRaytracer.Vector.ctor(0, 1, -0.25), 1, new SharpKitRaytracer.Surfaces.shiny.ctor()));
                $v1.Add(new SharpKitRaytracer.Sphere.ctor(new SharpKitRaytracer.Vector.ctor(-1, 0.5, 1.5), 0.5, new SharpKitRaytracer.Surfaces.shiny.ctor()));
                return $v1;
            }).call(this), (function ()
            {
                var $v2 = new System.Collections.Generic.List$1.ctor(SharpKitRaytracer.Light.ctor);
                $v2.Add(new SharpKitRaytracer.Light.ctor(new SharpKitRaytracer.Vector.ctor(-2, 2.5, 0), new SharpKitRaytracer.Color.ctor(0.49, 0.07, 0.07)));
                $v2.Add(new SharpKitRaytracer.Light.ctor(new SharpKitRaytracer.Vector.ctor(1.5, 2.5, 1.5), new SharpKitRaytracer.Color.ctor(0.07, 0.07, 0.49)));
                $v2.Add(new SharpKitRaytracer.Light.ctor(new SharpKitRaytracer.Vector.ctor(1.5, 2.5, -1.5), new SharpKitRaytracer.Color.ctor(0.07, 0.49, 0.071)));
                $v2.Add(new SharpKitRaytracer.Light.ctor(new SharpKitRaytracer.Vector.ctor(0, 3.5, 0), new SharpKitRaytracer.Color.ctor(0.21, 0.21, 0.35)));
                return $v2;
            }).call(this), new SharpKitRaytracer.Camera.ctor(new SharpKitRaytracer.Vector.ctor(3, 2, 4), new SharpKitRaytracer.Vector.ctor(-1, 0.5, 0)));
        },
        exec: function ()
        {
            $(document.body).append("<canvas></canvas");
            var canv = document.getElementsByTagName("canvas")[0];
            canv.width = 256;
            canv.height = 256;
            var ctx = canv.getContext("2d");
            var rayTracer = new SharpKitRaytracer.RayTracer.ctor();
            rayTracer.render(this.defaultScene(), ctx, canv.width, canv.height);
        }
    }
};
JsTypes.push(SharpKitRaytracer$RaytracerRunner);
