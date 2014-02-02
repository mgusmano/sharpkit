
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.OperatorOverloads) == "undefined")
    CoreTests.OperatorOverloads = {};
CoreTests.OperatorOverloads.Test = function (){
    this._MyBigNumber = null;
};
CoreTests.OperatorOverloads.Test.prototype.foo = function (){
    var x = new CoreTests.OperatorOverloads.BigNumber();
    var y = new CoreTests.OperatorOverloads.BigNumber();
    x = CoreTests.OperatorOverloads.BigNumber.op_Addition(x, y);
    var z = CoreTests.OperatorOverloads.BigNumber.op_Addition(x, y);
    var a = CoreTests.OperatorOverloads.BigNumber.op_Addition(this.get_MyBigNumber(), x);
    this.set_MyBigNumber(CoreTests.OperatorOverloads.BigNumber.op_Addition(this.get_MyBigNumber(), a));
};
CoreTests.OperatorOverloads.Test.prototype.get_MyBigNumber = function (){
    return this._MyBigNumber;
};
CoreTests.OperatorOverloads.Test.prototype.set_MyBigNumber = function (value){
    this._MyBigNumber = value;
};
CoreTests.OperatorOverloads.BigNumber = function (){
};
CoreTests.OperatorOverloads.BigNumber.op_Addition = function (x, y){
    return new CoreTests.OperatorOverloads.BigNumber();
};

