if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Properties_$ClrParameterizedTest =
{
    fullname: "CoreTests.Properties_.ClrParameterizedTest",
    baseTypeName: "System.Object",
    staticDefinition:
    {
        CreateColorFromExpression: function ()
        {
            var obj = (function ()
            {
                var $v1 = new CoreTests.Properties_.ClrClass.ctor();
                $v1.set_Property(5);
                return $v1;
            }).call(this);
        }
    },
    assemblyName: "CoreTests",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(CoreTests$Properties_$ClrParameterizedTest);
var CoreTests$Properties_$ClrClass =
{
    fullname: "CoreTests.Properties_.ClrClass",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            this._Property = 0;
            System.Object.ctor.call(this);
        },
        Property$$: "System.Int32",
        get_Property: function ()
        {
            return this._Property;
        },
        set_Property: function (value)
        {
            this._Property = value;
        }
    }
};
JsTypes.push(CoreTests$Properties_$ClrClass);
