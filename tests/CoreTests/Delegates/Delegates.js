if (typeof ($CreateAnonymousDelegate) == 'undefined') {
    var $CreateAnonymousDelegate = function (target, func) {
        if (target == null || func == null)
            return func;
        var delegate = function () {
            return func.apply(target, arguments);
        };
        delegate.func = func;
        delegate.target = target;
        delegate.isDelegate = true;
        return delegate;
    }
}
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
CoreTests.Delegates.Class1 = function ()
{
    this.DelegateProp2 = $CreateAnonymousDelegate(this, function ()
    {
        return "test";
    });
};
CoreTests.Delegates.Class1.DelegateProp = function ()
{
    return "test";
};
