if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$GenericsInheritance$Class1$1 =
{
    fullname: "CoreTests.GenericsInheritance.Class1$1",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition:
    {
        ctor: function (T)
        {
            this.T = T;
            System.Object.ctor.call(this);
        },
        Hello2$$T: function (prm)
        {
        },
        Hello2$$T$$T: function (prm, prm2)
        {
        },
        Hello$$List$1: function (prm)
        {
        },
        Hello$$List$1$$List$1: function (prm, prm2)
        {
        }
    }
};
JsTypes.push(CoreTests$GenericsInheritance$Class1$1);
var CoreTests$GenericsInheritance$Class2 =
{
    fullname: "CoreTests.GenericsInheritance.Class2",
    baseTypeName: "CoreTests.GenericsInheritance.Class1$1",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            CoreTests.GenericsInheritance.Class1$1.ctor.call(this, System.String.ctor);
        },
        Hello2$$String: function (prm)
        {
            CoreTests.GenericsInheritance.Class1$1.commonPrototype.Hello2$$T.call(this, prm);
        },
        Hello2$$String$$String: function (prm, prm2)
        {
            CoreTests.GenericsInheritance.Class1$1.commonPrototype.Hello2$$T$$T.call(this, prm, prm2);
        },
        Hello$$List$1$String: function (prm)
        {
            CoreTests.GenericsInheritance.Class1$1.commonPrototype.Hello$$List$1.call(this, prm);
        },
        Hello$$List$1$String$$List$1$String: function (prm, prm2)
        {
            CoreTests.GenericsInheritance.Class1$1.commonPrototype.Hello$$List$1$$List$1.call(this, prm, prm2);
        }
    }
};
JsTypes.push(CoreTests$GenericsInheritance$Class2);
