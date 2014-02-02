;
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Exceptions) == "undefined")
    CoreTests.Exceptions = {};
CoreTests.Exceptions.Class1 = function (){
};
CoreTests.Exceptions.Class1.prototype.Foo = function (){
    try{
    }
    catch($$e1){
        throw $CreateException($$e1, new Error());
    }
    try{
    }
    catch($$e2){
        throw $CreateException($$e2, new Error());
    }
    try{
    }
    catch(e){
        throw $CreateException(e, new Error());
    }
    try{
    }
    catch(e){
        throw $CreateException(e, new Error());
    }
};

