if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Enums) == "undefined")
    CoreTests.Enums = {};
CoreTests.Enums.Enums = function ()
{
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
    var x = 2;
    var y = 3;
};
CoreTests.Enums.Enum1 = {a: 1, b: 2, c: 3};
CoreTests.Enums.Enum2 = {a: "a", b: "b", c: "c"};
if (typeof(System) == "undefined")
    var System = {};
if (typeof(System.ComponentModel) == "undefined")
    System.ComponentModel = {};
System.ComponentModel.RefreshProperties = {None: 0, All: 1, Repaint: 2};
