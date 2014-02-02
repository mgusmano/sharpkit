
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.GenericMethods) == "undefined")
    CoreTests.GenericMethods = {};
CoreTests.GenericMethods.GenericMethods = function (){
};
CoreTests.GenericMethods.GenericMethods.prototype.Foo = function (){
    var x = this.Create(CoreTests.GenericMethods.GenericMethods);
    var div = this.Create("div");
};
CoreTests.GenericMethods.GenericMethods.prototype.Create = function (T){
    return new T();
};
CoreTests.GenericMethods.DivElement = function (){
};

