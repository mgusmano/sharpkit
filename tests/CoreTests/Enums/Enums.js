if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Enums) == "undefined")
    CoreTests.Enums = {};
CoreTests.Enums.Enums = function ()
{
};
CoreTests.Enums.Enums.prototype.foo = function ()
{
    var a = CoreTests.Enums.Enum1.a;
    var b = CoreTests.Enums.Enum2.b;
    var c = "c";
    var d = 1;
    var e = CoreTests.Enums.Enum5.b;
    var f = CoreTests.Enums.Enum6.b;
};
CoreTests.Enums.Enums.prototype.Reflect = function ()
{
    var type =  CoreTests.Enums.Enum1;
    for (var name in type)
    {
        var value = type[name];
        this.alert(name + "=" + value);
    }
};
CoreTests.Enums.Enums.prototype.alert = function (p)
{
    var x = CoreTests.Enums.Enum1.b;
    var y = CoreTests.Enums.Enum2.c;
};
CoreTests.Enums.Enum1 = {a: 1, b: 2, c: 3};
CoreTests.Enums.Enum2 = {a: "a", b: "b", c: "c"};
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Enums$Enum5 =
{
    fullname: "CoreTests.Enums.Enum5",
    staticDefinition: {a: "a", b: "b", c: "c"},
    Kind: "Enum"
};
JsTypes.push(CoreTests$Enums$Enum5);
var CoreTests$Enums$Enum6 =
{
    fullname: "CoreTests.Enums.Enum6",
    staticDefinition: {a: "a", b: "b", c: "c"},
    Kind: "Enum"
};
JsTypes.push(CoreTests$Enums$Enum6);
if (typeof(System) == "undefined")
    var System = {};
if (typeof(System.ComponentModel) == "undefined")
    System.ComponentModel = {};
System.ComponentModel.RefreshProperties = {None: 0, All: 1, Repaint: 2};
