;;
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
CoreTests.ExtensionMethods = function (){
};
CoreTests.ExtensionMethods.ExtensionMethod = function (x){
};
CoreTests.ExtensionMethods.foo = function (){
    var xx = new CoreTests.Test.ctor();
    var action = $CreateExtensionDelegate(xx, CoreTests.ExtensionMethods.ExtensionMethod);
    var action2 = $CreateDelegate(xx, xx.InstanceMethod);
    var list = new System.Collections.Generic.List$1.ctor(CoreTests.Test.ctor);
    list.ForEach(CoreTests.ExtensionMethods.ExtensionMethod);
    CoreTests.ExtensionMethods.ExtensionMethod(xx);
    CoreTests.ExtensionMethods.ExtensionMethod(xx);
};

