;
if (typeof(SharpKitWebApp5) == "undefined")
    var SharpKitWebApp5 = {};
SharpKitWebApp5.Class8_Base = function (){
    this.prop = 10;
};
SharpKitWebApp5.Class8_Base.prototype.get_MyProperty = function (){
    return this.prop;
};
SharpKitWebApp5.Class8_Base.prototype.set_MyProperty = function (value){
    this.prop = value;
};
Object.defineProperty(SharpKitWebApp5.Class8_Base.prototype, "MyProperty", {
    get: SharpKitWebApp5.Class8_Base.prototype.get_MyProperty,
    set: SharpKitWebApp5.Class8_Base.prototype.set_MyProperty
});
SharpKitWebApp5.Class8_Inherit = function (){
    this.prop = 10;
    SharpKitWebApp5.Class8_Base.call(this);
};
SharpKitWebApp5.Class8_Inherit.prototype.get_MyProperty = function (){
    return SharpKitWebApp5.Class8_Base.prototype.get_MyProperty.call(this);
};
SharpKitWebApp5.Class8_Inherit.prototype.set_MyProperty = function (value){
    SharpKitWebApp5.Class8_Base.prototype.set_MyProperty.call(this, value);
};
Object.defineProperty(SharpKitWebApp5.Class8_Inherit.prototype, "MyProperty", {
    get: SharpKitWebApp5.Class8_Inherit.prototype.get_MyProperty,
    set: SharpKitWebApp5.Class8_Inherit.prototype.set_MyProperty
});
$Inherit(SharpKitWebApp5.Class8_Inherit, SharpKitWebApp5.Class8_Base);
SharpKitWebApp5.Class8_GetSetProp = function (){
};
SharpKitWebApp5.Class8_GetSetProp.prototype.Main = function (){
    var bar = null;
    var foo = bar.get_MyProperty();
    bar.set_MyProperty(bar.get_MyProperty());
};

