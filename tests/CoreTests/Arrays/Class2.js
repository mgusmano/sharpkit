if (typeof(Int8Array) == "undefined")
    var Int8Array = Array;
if (typeof(Int16Array) == "undefined")
    var Int16Array = Array;
if (typeof(Uint16Array) == "undefined")
    var Uint16Array = Array;
if (typeof(Int32Array) == "undefined")
    var Int32Array = Array;
if (typeof(Uint32Array) == "undefined")
    var Uint32Array = Array;
if (typeof(Float32Array) == "undefined")
    var Float32Array = Array;
if (typeof(Float64Array) == "undefined")
    var Float64Array = Array;
if (typeof(SharpKitWebApp5) == "undefined")
    var SharpKitWebApp5 = {};
SharpKitWebApp5.Class2 = function ()
{
};
SharpKitWebApp5.Class2.prototype.foo = function ()
{
    var list =  [];
    list.push(new Int8Array(7));
    list.push(new Int16Array(7));
    list.push(new Uint16Array(7));
    list.push(new Int32Array(7));
    list.push(new Uint32Array(7));
    list.push(new Float32Array(7));
    list.push(new Float64Array(7));
    list.push(new Int8Array(7, 8, 9));
    list.push(new Int16Array(7, 8, 9));
    list.push(new Uint16Array(7, 8, 9));
    list.push(new Int32Array(7, 8, 9));
    list.push(new Uint32Array(7, 8, 9));
    list.push(new Float32Array(7, 8, 9));
    list.push(new Float64Array(7, 8, 9));
    list.push(new Int32Array(7, 8, 9));
    list.push(new Float64Array(7.7, 8.8, 9.9));
    list.push(new Float64Array(7, 8, 9));
    var a = new Int32Array(0, 2, 4, 6, 8);
};
