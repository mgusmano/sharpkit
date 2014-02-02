
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Default$Default = {
    fullname: "CoreTests.Default.Default",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        },
        foo: function (){
            var y = CoreTests.Default.MyEnum.A;
        }
    }
};
JsTypes.push(CoreTests$Default$Default);
var CoreTests$Default$MyEnum = {
    fullname: "CoreTests.Default.MyEnum",
    staticDefinition: {
        A: 0,
        B: 1,
        C: 2
    },
    Kind: "Enum"
};
JsTypes.push(CoreTests$Default$MyEnum);

