if (typeof ($CreateAnonymousDelegate) == 'undefined') {
    var $CreateAnonymousDelegate = function (target, func) {
        if (target == null || func == null)
            return func;
        var delegate = function () {
            return func.apply(target, arguments);
        };
        delegate.func = func;
        delegate.target = target;
        delegate.isDelegate = true;
        return delegate;
    }
}
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
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$AnonymousObjects$TestClasses =
{
    fullname: "CoreTests.AnonymousObjects.TestClasses",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.Object.ctor.call(this);
            var result = System.Linq.Enumerable.Select$2$$IEnumerable$1$$Func$2(null , System.String.ctor, System.Linq.Enumerable.Select$2$$IEnumerable$1$$Func$2(System.String.ctor, null , ["Hello"], $CreateAnonymousDelegate(this, function (x)
            {
                return $CreateAnonymousObject( {Greeting: x});
            })), $CreateAnonymousDelegate(this, function (x)
            {
                return x.get_Greeting();
            }));
        }
    }
};
JsTypes.push(CoreTests$AnonymousObjects$TestClasses);
