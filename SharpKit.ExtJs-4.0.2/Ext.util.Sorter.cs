//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Sorter
    /// <summary>
    /// Represents a single sorter that can be applied to a Store. The sorter is used
    /// to compare two values against each other for the purpose of ordering them. Ordering
    /// is achieved by specifying either:
    /// - A sorting property
    /// - A sorting function As a contrived example, we can specify a custom sorter that sorts by rank: Ext.define(&#39;Person&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [&#39;name&#39;, &#39;rank&#39;]
    /// });
    /// Ext.create(&#39;Ext.data.Store&#39;, {
    /// model: &#39;Person&#39;,
    /// proxy: &#39;memory&#39;,
    /// sorters: [{
    /// sorterFn: function(o1, o2){
    /// var getRank = function(o){
    /// var name = o.get(&#39;rank&#39;);
    /// if (name === &#39;first&#39;) {
    /// return 1;
    /// } else if (name === &#39;second&#39;) {
    /// return 2;
    /// } else {
    /// return 3;
    /// }
    /// },
    /// rank1 = getRank(o1),
    /// rank2 = getRank(o2);
    /// if (rank1 === rank2) {
    /// return 0;
    /// }
    /// return rank1 &amp;lt; rank2 ? -1 : 1;
    /// }
    /// }],
    /// data: [{
    /// name: &#39;Person1&#39;,
    /// rank: &#39;second&#39;
    /// }, {
    /// name: &#39;Person2&#39;,
    /// rank: &#39;third&#39;
    /// }, {
    /// name: &#39;Person3&#39;,
    /// rank: &#39;first&#39;
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Sorter
    {
        /// <summary>
        /// Toggles the sorting direction for this sorter. ...
        /// </summary>
        public object toggle(){return null;}
    }
    #endregion
    #region SorterConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class SorterConfig
    {
        /// <summary>
        /// The direction to sort by. ...
        /// </summary>
        public JsString direction{get;set;}
        /// <summary>
        /// The property to sort by. ...
        /// </summary>
        public JsString property{get;set;}
        /// <summary>
        /// Optional root property. ...
        /// </summary>
        public JsString root{get;set;}
        /// <summary>
        /// A specific sorter function to execute. ...
        /// </summary>
        public JsAction sorterFn{get;set;}
        /// <summary>
        /// A function that will be run on each value before
        /// it is compared in the sorter. ...
        /// </summary>
        public JsAction transform{get;set;}
    }
    #endregion
    #region SorterEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class SorterEvents
    {
    }
    #endregion
}
#endregion
