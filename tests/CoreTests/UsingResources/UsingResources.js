;
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.UsingResources) == "undefined")
    CoreTests.UsingResources = {};
CoreTests.UsingResources.UsingResources = function (){
};
CoreTests.UsingResources.UsingResources.prototype.Foo = function (){
    var $r1 = this.Moo();
    try{
    }
    finally{
        $r1.Dispose();
    }
    var $r2 = this.Moo();
    try{
        System.Console.WriteLine();
    }
    finally{
        $r2.Dispose();
    }
    var x = this.Moo(),y = this.Bar();
    try{
    }
    finally{
        x.Dispose();
        y.Dispose();
    }
};
CoreTests.UsingResources.UsingResources.prototype.Moo = function (){
    throw $CreateException(new System.NotImplementedException.ctor(), new Error());
};
CoreTests.UsingResources.UsingResources.prototype.Bar = function (){
    throw $CreateException(new System.NotImplementedException.ctor(), new Error());
};

