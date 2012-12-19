if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Properties_) == "undefined")
    CoreTests.Properties_ = {};
CoreTests.Properties_.CustomPropertyName = function ()
{
    this._jsName = null;
    this.set_jsName("Bar");
};
CoreTests.Properties_.CustomPropertyName.prototype.get_jsName = function ()
{
    return this._jsName;
};
CoreTests.Properties_.CustomPropertyName.prototype.set_jsName = function (value)
{
    this._jsName = value;
};
