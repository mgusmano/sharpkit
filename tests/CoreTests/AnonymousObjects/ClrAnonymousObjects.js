;
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.AnonymousObjects) == "undefined")
    CoreTests.AnonymousObjects = {};
CoreTests.AnonymousObjects.NonNativeJsons = function (){
};
CoreTests.AnonymousObjects.NonNativeJsons.prototype.F = function (){
    var xx = new System.Object.ctor();
    var x = $CreateAnonymousObject({
        a: "b"
    });
    var a = x.get_a();
};

