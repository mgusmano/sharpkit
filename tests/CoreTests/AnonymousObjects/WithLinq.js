;;
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$AnonymousObjects$TestClasses = {
    fullname: "CoreTests.AnonymousObjects.TestClasses",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
            var result = System.Linq.Enumerable.Select$2$$IEnumerable$1$$Func$2(null, System.String.ctor, System.Linq.Enumerable.Select$2$$IEnumerable$1$$Func$2(System.String.ctor, null, ["Hello"], $CreateAnonymousDelegate(this, function (x){
                return $CreateAnonymousObject({
                    Greeting: x
                });
            })), $CreateAnonymousDelegate(this, function (x){
                return x.get_Greeting();
            }));
        }
    }
};
JsTypes.push(CoreTests$AnonymousObjects$TestClasses);

