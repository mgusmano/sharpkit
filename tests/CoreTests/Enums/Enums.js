if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Enums) == "undefined")
    CoreTests.Enums = {};
CoreTests.Enums.Enums = function ()
{
    this.Enum1 = CoreTests.Enums.Enum1Proto.a;
    this.Enum2 = CoreTests.Enums.Enum2ProtoName.a;
    this.Enum3 = "a";
    this.Enum4 = 1;
    this.Enum5 = CoreTests.Enums.Enum5ClrName.a;
};
CoreTests.Enums.Enums.prototype.foo = function ()
{
    var proto = CoreTests.Enums.Enum1Proto.a;
    var protoName = CoreTests.Enums.Enum2ProtoName.b;
    var jsonName = "c";
    var json = 1;
    var clrName = CoreTests.Enums.Enum5ClrName.b;
    var clr = CoreTests.Enums.Enum6Clr.b;
};
CoreTests.Enums.Enums.prototype.WithDefault = function ()
{
    var a = 0;
    var b = CoreTests.Enums.Enum2ProtoName.a;
    var c = 0;
    var d = 0;
    var e = 0;
    var f = 0;
};
CoreTests.Enums.Enums.prototype.Reflect = function ()
{
    var type =  CoreTests.Enums.Enum1Proto;
    for (var name in type)
    {
        var value = type[name];
        this.alert(name + "=" + value);
    }
};
CoreTests.Enums.Enums.prototype.alert = function (p)
{
    var x = CoreTests.Enums.Enum1Proto.b;
    var y = CoreTests.Enums.Enum2ProtoName.c;
};
CoreTests.Enums.Enum1Proto = {a: 1, b: 2, c: 3};
CoreTests.Enums.Enum2ProtoName = {a: "a", b: "b", c: "c"};
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Enums$Enum5ClrName =
{
    fullname: "CoreTests.Enums.Enum5ClrName",
    staticDefinition: {a: "a", b: "b", c: "c"},
    Kind: "Enum"
};
JsTypes.push(CoreTests$Enums$Enum5ClrName);
var CoreTests$Enums$Enum6Clr =
{
    fullname: "CoreTests.Enums.Enum6Clr",
    staticDefinition: {a: 1, b: 2, c: 3},
    Kind: "Enum"
};
JsTypes.push(CoreTests$Enums$Enum6Clr);
if (typeof(System) == "undefined")
    var System = {};
if (typeof(System.ComponentModel) == "undefined")
    System.ComponentModel = {};
System.ComponentModel.RefreshProperties = {None: 0, All: 1, Repaint: 2};
