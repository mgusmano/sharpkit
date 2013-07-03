if (typeof(NoClrTests) == "undefined")
    var NoClrTests = {};
NoClrTests.Test = function ()
{
    this.list = null;
};
NoClrTests.Test.prototype.Test2 = function ()
{
    var x = this.list.length;
};
