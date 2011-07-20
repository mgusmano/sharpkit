//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region ComboBox
    /// <summary>
    /// A combobox control with support for autocomplete, remote loading, and many other features. A ComboBox is like a combination of a traditional HTML text &amp;lt;input&amp;gt; field and a &amp;lt;select&amp;gt;
    /// field; the user is able to type freely into the field, and/or pick values from a dropdown selection
    /// list. The user can input any value by default, even if it does not appear in the selection list;
    /// to prevent free-form values and restrict them to items in the list, set forceSelection to true. The selection list&#39;s options are populated from any Ext.data.Store, including remote
    /// stores. The data items in the store are mapped to each option&#39;s displayed text and backing value via
    /// the valueField and displayField configurations, respectively. If your store is not remote, i.e. it depends only on local data and is loaded up front, you should be
    /// sure to set the queryMode to &#39;local&#39;, as this will improve responsiveness for the user.  Example usage: // The data store containing the list of states
    /// var states = Ext.create(&#39;Ext.data.Store&#39;, {
    /// fields: [&#39;abbr&#39;, &#39;name&#39;],
    /// data : [
    /// {&quot;abbr&quot;:&quot;AL&quot;, &quot;name&quot;:&quot;Alabama&quot;},
    /// {&quot;abbr&quot;:&quot;AK&quot;, &quot;name&quot;:&quot;Alaska&quot;},
    /// {&quot;abbr&quot;:&quot;AZ&quot;, &quot;name&quot;:&quot;Arizona&quot;}
    /// //...
    /// ]
    /// });
    /// // Create the combo box, attached to the states data store
    /// Ext.create(&#39;Ext.form.ComboBox&#39;, {
    /// fieldLabel: &#39;Choose State&#39;,
    /// store: states,
    /// queryMode: &#39;local&#39;,
    /// displayField: &#39;name&#39;,
    /// valueField: &#39;abbr&#39;,
    /// renderTo: Ext.getBody()
    /// });
    /// Events To do something when something in ComboBox is selected, configure the select event: var cb = Ext.create(&#39;Ext.form.ComboBox&#39;, {
    /// // all of your config options
    /// listeners:{
    /// scope: yourScope,
    /// &#39;select&#39;: yourFunction
    /// }
    /// });
    /// // Alternatively, you can assign events after the object is created:
    /// var cb = new Ext.form.field.ComboBox(yourOptions);
    /// cb.on(&#39;select&#39;, yourFunction, yourScope);
    /// Multiple Selection ComboBox also allows selection of multiple items from the list; to enable multi-selection set the
    /// multiSelect config to true.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ComboBox : Picker, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Clears any value currently set in the ComboBox. ...
        /// </summary>
        public object clearValue(){return null;}
        /// <summary>
        /// Executes a query to filter the dropdown list. ...
        /// </summary>
        public bool doQuery(JsString queryString, bool forceAll){return false;}
        /// <summary>
        /// Selects an item by a Model, or by a key value. ...
        /// </summary>
        public object select(object r){return null;}
        /// <summary>
        /// Sets the specified value(s) into the field. ...
        /// </summary>
        public Ext.form.field.Field setValue(object value, object doSelect){return null;}
        /// <summary>
        /// The value of the match string used to filter the store. ...
        /// </summary>
        public JsString lastQuery{get;set;}
    }
    #endregion
    #region ComboBoxConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ComboBoxConfig : PickerConfig
    {
        public JsString allQuery{get;set;}
        /// <summary>
        /// true to automatically highlight the first result gathered by the data store
        /// in the dropdown list when it is opened. ...
        /// </summary>
        public bool autoSelect{get;set;}
        public object defaultListConfig{get;set;}
        /// <summary>
        /// The character(s) used to separate the display values of multiple selected items
        /// when multiSelect = true. ...
        /// </summary>
        public JsString delimiter{get;set;}
        /// <summary>
        /// The underlying data field name to bind to this
        /// ComboBox (defaults to 'text'). ...
        /// </summary>
        public JsString displayField{get;set;}
        /// <summary>
        /// true to restrict the selected value to one of the values in the list,
        /// false to allow the user to set arbitrary text i...
        /// </summary>
        public bool forceSelection{get;set;}
        /// <summary>
        /// An optional set of configuration properties that will be passed to the Ext.view.BoundList's
        /// constructor. ...
        /// </summary>
        public object listConfig{get;set;}
        /// <summary>
        /// The minimum number of characters the user must type before autocomplete and
        /// typeAhead activate (defaults to 4 if quer...
        /// </summary>
        public JsNumber minChars{get;set;}
        /// <summary>
        /// If set to true, allows the combo field to hold more than one value at a time, and allows selecting
        /// multiple items fro...
        /// </summary>
        public bool multiSelect{get;set;}
        /// <summary>
        /// If greater than 0, a Ext.toolbar.Paging is displayed in the
        /// footer of the dropdown list and the filter queries will e...
        /// </summary>
        public JsNumber pageSize{get;set;}
        /// <summary>
        /// The length of time in milliseconds to delay between the start of typing and
        /// sending the query to filter the dropdown ...
        /// </summary>
        public JsNumber queryDelay{get;set;}
        /// <summary>
        /// The mode in which the ComboBox uses the configured Store. ...
        /// </summary>
        public JsString queryMode{get;set;}
        /// <summary>
        /// Name of the parameter used by the Store to pass the typed string when the ComboBox is configured with
        /// queryMode: 'rem...
        /// </summary>
        public JsString queryParam{get;set;}
        /// <summary>
        /// Whether the Tab key should select the currently highlighted item. ...
        /// </summary>
        public bool selectOnTab{get;set;}
        /// <summary>
        /// The data source to which this combo is bound (defaults to undefined). ...
        /// </summary>
        public object store{get;set;}
        /// <summary>
        /// The id, DOM node or Ext.core.Element of an existing HTML &lt;select&gt; element to
        /// convert into a ComboBox. ...
        /// </summary>
        public object transform{get;set;}
        /// <summary>
        /// The action to execute when the trigger is clicked. ...
        /// </summary>
        public JsString triggerAction{get;set;}
        /// <summary>
        /// An additional CSS class used to style the trigger button. ...
        /// </summary>
        public new JsString triggerCls{get;set;}
        /// <summary>
        /// true to populate and autoselect the remainder of the text being
        /// typed after a configurable delay (typeAheadDelay) if ...
        /// </summary>
        public bool typeAhead{get;set;}
        public JsNumber typeAheadDelay{get;set;}
        /// <summary>
        /// @required
        /// The underlying data value name to bind to this ComboBox (defaults to match
        /// the value of the displayField co...
        /// </summary>
        public JsString valueField{get;set;}
        /// <summary>
        /// When using a name/value combo, if the value passed to setValue is not found in
        /// the store, valueNotFoundText will be d...
        /// </summary>
        public JsString valueNotFoundText{get;set;}
    }
    #endregion
    #region ComboBoxEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ComboBoxEvents : PickerEvents
    {
        /// <summary>
        /// Fires before all queries are processed. ...
        /// </summary>
        public static JsString beforequery="beforequery";
    }
    #endregion
}
#endregion
