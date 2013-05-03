if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Default$Default =
{
    fullname: "CoreTests.Default.Default",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.Object.ctor.call(this);
        },
        foo: function ()
        {
            var y = CoreTests.Default.MyEnum.A;
        }
    }
};
JsTypes.push(CoreTests$Default$Default);
var CoreTests$Default$MyEnum =
{
    fullname: "CoreTests.Default.MyEnum",
    staticDefinition: {A: "A", B: "B", C: "C"},
    Kind: "Enum"
};
JsTypes.push(CoreTests$Default$MyEnum);
