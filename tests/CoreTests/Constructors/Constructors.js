if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Constructors) == "undefined")
    CoreTests.Constructors = {};
CoreTests.Constructors.Constructors = function ()
{
};
var x = 7;
CoreTests.Constructors.Constructors.prototype.foo = function ()
{
    var ctor =  CoreTests.Constructors.Constructors;
    var obj =  new ctor();
};
