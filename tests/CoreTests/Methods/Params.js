
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Methods$Params = {
    fullname: "CoreTests.Methods.Params",
    baseTypeName: "System.Object",
    staticDefinition: {
        CallMethodWithManyParams: function (arr){
            return arr.length;
        }
    },
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        },
        alert: function (obj){
        },
        foo: function (){
            var a = System.String.Format$$String$$Object$Array("{0} {1} {2} {3}", ["a", "b", "c", "d"]);
            var b = System.String.Format$$String$$Object$$Object$$Object("{0} {1} {2} {3}", "a", "b", "c");
            var c = System.String.Format$$String$$Object$$Object("{0} {1} {2} {3}", "a", "b");
            var d = System.String.Format$$String$$Object("{0} {1} {2} {3}", "a");
            var e = System.String.Format$$String$$Object$Array("{0} {1} {2} {3}", new Array(0));
            if (CoreTests.Methods.Params.CallMethodWithManyParams(new Array(0)) != 0)
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

