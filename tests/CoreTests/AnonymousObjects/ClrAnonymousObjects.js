if (typeof($CreateAnonymousObject)=='undefined') 
{
    var $CreateAnonymousObject = function(json)
    {
        var obj = new System.Object.ctor();
        obj.d = json;
        for(var p in json){
            obj['get_'+p] = new Function('return this.d.'+p+';');
        }
        return obj;
    }
}


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

