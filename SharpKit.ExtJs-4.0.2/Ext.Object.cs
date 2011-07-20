//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Object
    /// <summary>
    /// A collection of useful static methods to deal with objects
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Object
    {
        /// <summary>
        /// Iterate through an object and invoke the given callback function for each iteration. ...
        /// </summary>
        public object each(object @object, JsAction fn, object scope){return null;}
        /// <summary>
        /// Converts a query string back into an object. ...
        /// </summary>
        public object fromQueryString(JsString queryString, bool recursive){return null;}
        /// <summary>
        /// Returns the first matching key corresponding to the given value. ...
        /// </summary>
        public object getKey(object @object, object value){return null;}
        /// <summary>
        /// Gets all keys of the given object as an array. ...
        /// </summary>
        public JsArray getKeys(object @object){return null;}
        /// <summary>
        /// Gets the total number of this object's own properties
        /// var size = Ext.Object.getSize({
        /// name: 'Jacky',
        /// loves: ...
        /// </summary>
        public JsNumber getSize(object @object){return null;}
        /// <summary>
        /// Gets all values of the given object as an array. ...
        /// </summary>
        public JsArray getValues(object @object){return null;}
        /// <summary>
        /// Merges any number of objects recursively without referencing them or their children. ...
        /// </summary>
        public object merge(object @object, object key, object value){return null;}
        /// <summary>
        /// Convert a name - value pair to an array of objects with support for nested structures; useful to construct
        /// query stri...
        /// </summary>
        public object toQueryObjects(JsString name, object value, bool recursive){return null;}
        /// <summary>
        /// Takes an object and converts it to an encoded query string
        /// Non-recursive:
        /// Ext.Object.toQueryString({foo: 1, bar:...
        /// </summary>
        public JsString toQueryString(object @object, bool recursive=false){return null;}
        public Object(ObjectConfig config){}
        public Object(){}
    }
    #endregion
    #region ObjectConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ObjectConfig
    {
    }
    #endregion
    #region ObjectEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ObjectEvents
    {
    }
    #endregion
}
#endregion
