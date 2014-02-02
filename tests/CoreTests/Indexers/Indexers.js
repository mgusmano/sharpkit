
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Indexers) == "undefined")
    CoreTests.Indexers = {};
CoreTests.Indexers.Indexers = function (){
};
CoreTests.Indexers.Indexers.prototype.foo = function (){
    var stringToInt = new System.Collections.Generic.Dictionary$2.ctor(System.String.ctor, System.Int32.ctor);
    var res = (function ($p1){
        stringToInt.set_Item$$TKey("seven", $p1);
        return $p1;
    }).call(this, 7);
    System.Console.WriteLine$$String("Result: " + res.toString());
};

