
if (typeof(SharpKitWebApp5) == "undefined")
    var SharpKitWebApp5 = {};
SharpKitWebApp5.Class6 = function (){
    this._MyProperty = 0;
};
SharpKitWebApp5.Class6._MyStaticProperty = 0;
SharpKitWebApp5.Class6.prototype.get_MyProperty = function (){
    return this._MyProperty;
};
SharpKitWebApp5.Class6.prototype.set_MyProperty = function (value){
    this._MyProperty = value;
};
SharpKitWebApp5.Class6.get_MyStaticProperty = function (){
    return SharpKitWebApp5.Class6._MyStaticProperty;
};
SharpKitWebApp5.Class6.set_MyStaticProperty = function (value){
    SharpKitWebApp5.Class6._MyStaticProperty = value;
};
SharpKitWebApp5.Class6.prototype.Foo = function (){
    this.set_MyProperty(1);
    SharpKitWebApp5.Class6.set_MyStaticProperty(4);
    this.set_MyProperty(this.get_MyProperty() + 1);
    this.set_MyProperty(this.get_MyProperty() + 2);
    this.set_MyProperty(this.get_MyProperty() - 1);
    this.set_MyProperty(this.get_MyProperty() - 2);
    this.set_MyProperty(this.get_MyProperty() + 1);
    this.set_MyProperty(this.get_MyProperty() - 1);
};

