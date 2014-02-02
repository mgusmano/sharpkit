
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.For) == "undefined")
    CoreTests.For = {};
CoreTests.For.HasNext = function (){
    this.Next = null;
};
CoreTests.For.Bug249 = function (){
};
CoreTests.For.Bug249.Foo = function (){
    var p = new CoreTests.For.HasNext();
    var count = 0;
    for (; p != null; p = p.Next, count++){
    }
    var x = 0,y = 0;
    for (x = 7, y = 8; x < 7 && y < 8; x++, y++){
    }
    for (var a = 7,b = 8; x < 7 && y < 8; x++, y++){
    }
};

