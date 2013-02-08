if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Methods$Params =
{
    fullname: "CoreTests.Methods.Params",
    baseTypeName: "System.Object",
    staticDefinition:
    {
        CallMethodWithManyParams: function (arr)
        {
            return arr.length;
        }
    },
    assemblyName: "CoreTests",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.Object.ctor.call(this);
        },
        alert: function (obj)
        {
        },
        foo: function ()
        {
            if (CoreTests.Methods.Params.CallMethodWithManyParams([]) != 0)
                this.alert("params error");
            if (CoreTests.Methods.Params.CallMethodWithManyParams(["aa"]) != 1)
                this.alert("params error");
            if (CoreTests.Methods.Params.CallMethodWithManyParams(["a", "b"]) != 2)
                this.alert("params error");
            if (CoreTests.Methods.Params.CallMethodWithManyParams(["a", "b", 1230]) != 3)
                this.alert("params error");
            if (CoreTests.Methods.Params.CallMethodWithManyParams(["a", "b", 1230, "sss"]) != 4)
                this.alert("params error");
        }
    }
};
JsTypes.push(CoreTests$Methods$Params);
