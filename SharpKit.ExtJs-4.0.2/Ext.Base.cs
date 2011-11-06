//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Base
    /// <summary>
    /// The root of all classes created with Ext.define
    /// All prototype and static members of this class are inherited by any other class
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Base
    {
        /// <summary>
        /// Call the original method that was previously overridden with override
        /// Ext.define('My.Cat', {
        /// constructor: functi...
        /// </summary>
        public object callOverridden(object args){return null;}
        /// <summary>
        /// Call the original method that was previously overridden with override
        /// Ext.define('My.Cat', {
        /// constructor: functi...
        /// </summary>
        public object callOverridden() { return null; }
        /// <summary>
        /// Call the parent's overridden method. ...
        /// </summary>
        public object callParent(object args){return null;}
        /// <summary>
        /// Get the current class' name in string format. ...
        /// </summary>
        public JsString getName(){return null;}
        /// <summary>
        /// Initialize configuration for this class. ...
        /// </summary>
        public object initConfig(object config){return null;}
        /// <summary>
        /// Get the reference to the class from which this object was instantiated. ...
        /// </summary>
        public Class statics(){return null;}
        /// <summary>
        /// Get the reference to the current class from which this object was instantiated. ...
        /// </summary>
        public Class self{get;set;}
        public Base(Ext.BaseConfig config){}
        public Base(){}

        public Class create() { return null; }

        public static Base implement(object members) { return null; }
    }
    #endregion
    #region BaseConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BaseConfig
    {
    }
    #endregion
    #region BaseEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BaseEvents
    {
    }
    #endregion
}
#endregion
