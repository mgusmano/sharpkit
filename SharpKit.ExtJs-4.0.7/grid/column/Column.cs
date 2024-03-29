//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.column
namespace Ext.grid.column
{
    #region Column
    /// <summary>
    /// This class specifies the definition for a column inside a Ext.grid.Panel. It encompasses
    /// both the grid header configuration as well as displaying data within the grid itself. If the
    /// columns configuration is specified, this column will become a column group and can
    /// container other columns inside. In general, this class will not be created directly, rather
    /// an array of column configurations will be passed to the grid:  Code Ext.create(&#39;Ext.data.Store&#39;, {
    /// storeId:&#39;employeeStore&#39;,
    /// fields:[&#39;firstname&#39;, &#39;lastname&#39;, &#39;senority&#39;, &#39;dep&#39;, &#39;hired&#39;],
    /// data:[
    /// {firstname:&quot;Michael&quot;, lastname:&quot;Scott&quot;, senority:7, dep:&quot;Manangement&quot;, hired:&quot;01/10/2004&quot;},
    /// {firstname:&quot;Dwight&quot;, lastname:&quot;Schrute&quot;, senority:2, dep:&quot;Sales&quot;, hired:&quot;04/01/2004&quot;},
    /// {firstname:&quot;Jim&quot;, lastname:&quot;Halpert&quot;, senority:3, dep:&quot;Sales&quot;, hired:&quot;02/22/2006&quot;},
    /// {firstname:&quot;Kevin&quot;, lastname:&quot;Malone&quot;, senority:4, dep:&quot;Accounting&quot;, hired:&quot;06/10/2007&quot;},
    /// {firstname:&quot;Angela&quot;, lastname:&quot;Martin&quot;, senority:5, dep:&quot;Accounting&quot;, hired:&quot;10/21/2008&quot;}
    /// ]
    /// });
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// title: &#39;Column Demo&#39;,
    /// store: Ext.data.StoreManager.lookup(&#39;employeeStore&#39;),
    /// columns: [
    /// {text: &#39;First Name&#39;,  dataIndex:&#39;firstname&#39;},
    /// {text: &#39;Last Name&#39;,  dataIndex:&#39;lastname&#39;},
    /// {text: &#39;Hired Month&#39;,  dataIndex:&#39;hired&#39;, xtype:&#39;datecolumn&#39;, format:&#39;M&#39;},
    /// {text: &#39;Deparment (Yrs)&#39;, xtype:&#39;templatecolumn&#39;, tpl:&#39;{dep} ({senority})&#39;}
    /// ],
    /// width: 400,
    /// renderTo: Ext.getBody()
    /// });
    /// Convenience Subclasses There are several column subclasses that provide default rendering for various data types  Ext.grid.column.Action: Renders icons that can respond to click events inline Ext.grid.column.Boolean: Renders for boolean values Ext.grid.column.Date: Renders for date values Ext.grid.column.Number: Renders for numeric values Ext.grid.column.Template: Renders a value using an Ext.XTemplate using the record data  Setting Sizes The columns are laid out by a Ext.layout.container.HBox layout, so a column can either
    /// be given an explicit width value or a flex configuration. If no width is specified the grid will
    /// automatically the size the column to 100px. For column groups, the size is calculated by measuring
    /// the width of the child columns, so a width option should not be specified in that case. Header Options  text: Sets the header text for the column sortable: Specifies whether the column can be sorted by clicking the header or using the column menu hideable: Specifies whether the column can be hidden using the column menu menuDisabled: Disables the column header menu draggable: Specifies whether the column header can be reordered by dragging groupable: Specifies whether the grid can be grouped by the column dataIndex. See also Ext.grid.feature.Grouping  Data Options  dataIndex: The dataIndex is the field in the underlying Ext.data.Store to use as the value for the column. renderer: Allows the underlying store value to be transformed before being displayed in the grid
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Column : Ext.grid.header.Container, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Retrieves the editing field for editing associated with this header. ...
        /// </summary>
        public Ext.form.field.Field getEditor(object record, object defaultField){return null;}
        /// <summary>
        /// Returns the true grid column index assiciated with this Column only if this column is a base level Column. ...
        /// </summary>
        public object getIndex(){return null;}
        /// <summary>
        /// Returns the parameter to sort upon when sorting this header. ...
        /// </summary>
        public object getSortParam(){return null;}
        /// <summary>
        /// A renderer is an 'interceptor' method which can be used transform data (value, appearance, etc.) before it
        /// is rendered. ...
        /// </summary>
        public JsString renderer(object value, object metaData, Ext.data.Model record, JsNumber rowIndex, JsNumber colIndex, Ext.data.Store store, Ext.view.View view){return null;}
        /// <summary>
        /// Sets the form field to be used for editing. ...
        /// </summary>
        public object setEditor(object field){return null;}
        /// <summary>
        /// Sets the header text for this Column. ...
        /// </summary>
        public object setText(object text){return null;}
        public Ext.core.Element textEl{get;set;}
        public Ext.core.Element triggerEl{get;set;}
        public Column(Ext.grid.column.ColumnConfig config){}
        public Column(){}
    }
    #endregion
    #region ColumnConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ColumnConfig : Ext.grid.header.ContainerConfig
    {
        /// <summary>
        /// Sets the alignment of the header and rendered columns. ...
        /// </summary>
        public JsString align{get;set;}
        /// <summary>
        /// An optional array of sub-column definitions. ...
        /// </summary>
        public JsArray columns{get;set;}
        /// <summary>
        /// Required. ...
        /// </summary>
        public JsString dataIndex{get;set;}
        /// <summary>
        /// Indicates whether or not the header can be drag and drop re-ordered. ...
        /// </summary>
        public new bool draggable{get;set;}
        public bool @fixed{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public bool groupable{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public bool hideable{get;set;}
        /// <summary>
        /// True to disabled the column header menu containing sort/hide options. ...
        /// </summary>
        public bool menuDisabled{get;set;}
        public new bool resizable{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public new bool sortable{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public JsString tdCls{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public JsString text{get;set;}
        /// <summary>
        /// A renderer is an 'interceptor' method which can be used transform data (value, appearance, etc.) before it is rendered
        /// </summary>
        public object renderer { get; set; }
        public object editor { get; set; }
    }
    #endregion
    #region ColumnEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ColumnEvents : Ext.grid.header.ContainerEvents
    {
    }
    #endregion
}
#endregion
