
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$GenericInheritance$SQParams$1 = {
    fullname: "CoreTests.GenericInheritance.SQParams$1",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (TSerialize){
            this.TSerialize = TSerialize;
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(CoreTests$GenericInheritance$SQParams$1);
var CoreTests$GenericInheritance$SQParamCollection$1 = {
    fullname: "CoreTests.GenericInheritance.SQParamCollection$1",
    baseTypeName: "CoreTests.GenericInheritance.SQParams$1",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (T){
            this.T = T;
            CoreTests.GenericInheritance.SQParams$1.ctor.call(this, CoreTests.GenericInheritance.SQParamCollection$1.ctor);
        }
    }
};
JsTypes.push(CoreTests$GenericInheritance$SQParamCollection$1);
var CoreTests$GenericInheritance$KCat = {
    fullname: "CoreTests.GenericInheritance.KCat",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(CoreTests$GenericInheritance$KCat);
var CoreTests$GenericInheritance$KCatCollection = {
    fullname: "CoreTests.GenericInheritance.KCatCollection",
    baseTypeName: "CoreTests.GenericInheritance.SQParams$1",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            CoreTests.GenericInheritance.SQParams$1.ctor.call(this, CoreTests.GenericInheritance.KCat.ctor);
        }
    }
};
JsTypes.push(CoreTests$GenericInheritance$KCatCollection);
var CoreTests$GenericInheritance$KCatCollection2 = {
    fullname: "CoreTests.GenericInheritance.KCatCollection2",
    baseTypeName: "System.Collections.Generic.List$1",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Collections.Generic.List$1.ctor.call(this, CoreTests.GenericInheritance.KCat.ctor);
        }
    }
};
JsTypes.push(CoreTests$GenericInheritance$KCatCollection2);

