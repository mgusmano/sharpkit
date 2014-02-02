
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Methods) == "undefined")
    CoreTests.Methods = {};
CoreTests.Methods.NamedParameters = function (){
};
CoreTests.Methods.NamedParameters.prototype.Foo = function (prm1, prm2, prm3){
};
CoreTests.Methods.NamedParameters.prototype.Foo2 = function (){
    this.Foo("prm1", "prm2", "prm3");
};

