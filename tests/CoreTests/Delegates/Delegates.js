;
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Delegates) == "undefined")
    CoreTests.Delegates = {};
CoreTests.Delegates.Delegates = function (){
};
CoreTests.Delegates.Delegates.prototype.foo = function (){
    var x = this.foo;
};
CoreTests.Delegates.Class1 = function (){
    this.DelegateProp2 = $CreateAnonymousDelegate(this, function (){
        return "test";
    });
};
CoreTests.Delegates.Class1.DelegateProp = function (){
    return "test";
};
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Delegates$Circle$1 = {
    fullname: "CoreTests.Delegates.Circle$1",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (T, func){
            this.T = T;
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(CoreTests$Delegates$Circle$1);
var CoreTests$Delegates$Boxes = {
    fullname: "CoreTests.Delegates.Boxes",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            this.circle = new CoreTests.Delegates.Circle$1.ctor(System.Int32.ctor, $CreateAnonymousDelegate(this, function (a, b){
                return a + b;
            }));
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(CoreTests$Delegates$Boxes);

