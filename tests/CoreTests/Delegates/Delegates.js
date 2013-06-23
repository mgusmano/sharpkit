if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Delegates) == "undefined")
    CoreTests.Delegates = {};
CoreTests.Delegates.Delegates = function ()
{
};
CoreTests.Delegates.Delegates.prototype.foo = function ()
{
    var x = this.foo;
};
