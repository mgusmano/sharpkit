//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.toolbar
namespace Ext.toolbar
{
    #region Toolbar
    /// <summary>
    /// Basic Toolbar class. Although the defaultType for Toolbar is button, Toolbar
    /// elements (child items for the Toolbar container) may be virtually any type of Component. Toolbar elements can be created explicitly via their
    /// constructors, or implicitly via their xtypes, and can be added dynamically. Some items have shortcut strings for creation:      Shortcut   xtype           Class                           Description                                               -&amp;gt;   tbspacer   Ext.toolbar.Fill   begin using the right-justified button container   |     -   tbseparator   Ext.toolbar.Separator   add a vertical separator bar between toolbar items |        tbspacer   Ext.toolbar.Spacer   add horiztonal space between elements              |
    /// Example usage: Ext.create(&#39;Ext.toolbar.Toolbar&#39;, {
    /// renderTo: document.body,
    /// width   : 500,
    /// items: [
    /// {
    /// // xtype: &#39;button&#39;, // default for Toolbars
    /// text: &#39;Button&#39;
    /// },
    /// {
    /// xtype: &#39;splitbutton&#39;,
    /// text : &#39;Split Button&#39;
    /// },
    /// // begin using the right-justified button container
    /// &#39;-&amp;gt;&#39;, // same as {xtype: &#39;tbfill&#39;}, // Ext.toolbar.Fill
    /// {
    /// xtype    : &#39;textfield&#39;,
    /// name     : &#39;field1&#39;,
    /// emptyText: &#39;enter search term&#39;
    /// },
    /// // add a vertical separator bar between toolbar items
    /// &#39;-&#39;, // same as {xtype: &#39;tbseparator&#39;} to create Ext.toolbar.Separator
    /// &#39;text 1&#39;, // same as {xtype: &#39;tbtext&#39;, text: &#39;text1&#39;} to create Ext.toolbar.TextItem
    /// {xtype: &#39;tbspacer&#39;},// same as &#39; &#39; to create Ext.toolbar.Spacer
    /// &#39;text 2&#39;,
    /// {xtype: &#39;tbspacer&#39;, width: 50}, // add a 50px space
    /// &#39;text 3&#39;
    /// ]
    /// });
    /// Toolbars have enable and disable methods which when called, will enable/disable all items within your toolbar.
    /// Example usage: Ext.create(&#39;Ext.toolbar.Toolbar&#39;, {
    /// renderTo: document.body,
    /// width   : 400,
    /// items: [
    /// {
    /// text: &#39;Button&#39;
    /// },
    /// {
    /// xtype: &#39;splitbutton&#39;,
    /// text : &#39;Split Button&#39;
    /// },
    /// &#39;-&amp;gt;&#39;,
    /// {
    /// xtype    : &#39;textfield&#39;,
    /// name     : &#39;field1&#39;,
    /// emptyText: &#39;enter search term&#39;
    /// }
    /// ]
    /// });
    /// Example usage: var enableBtn = Ext.create(&#39;Ext.button.Button&#39;, {
    /// text    : &#39;Enable All Items&#39;,
    /// disabled: true,
    /// scope   : this,
    /// handler : function() {
    /// //disable the enable button and enable the disable button
    /// enableBtn.disable();
    /// disableBtn.enable();
    /// //enable the toolbar
    /// toolbar.enable();
    /// }
    /// });
    /// var disableBtn = Ext.create(&#39;Ext.button.Button&#39;, {
    /// text    : &#39;Disable All Items&#39;,
    /// scope   : this,
    /// handler : function() {
    /// //enable the enable button and disable button
    /// disableBtn.disable();
    /// enableBtn.enable();
    /// //disable the toolbar
    /// toolbar.disable();
    /// }
    /// });
    /// var toolbar = Ext.create(&#39;Ext.toolbar.Toolbar&#39;, {
    /// renderTo: document.body,
    /// width   : 400,
    /// margin  : &#39;5 0 0 0&#39;,
    /// items   : [enableBtn, disableBtn]
    /// });
    /// Adding items to and removing items from a toolbar is as simple as calling the add and remove methods. There is also a removeAll method
    /// which remove all items within the toolbar.
    /// Example usage: var toolbar = Ext.create(&#39;Ext.toolbar.Toolbar&#39;, {
    /// renderTo: document.body,
    /// width   : 700,
    /// items: [
    /// {
    /// text: &#39;Example Button&#39;
    /// }
    /// ]
    /// });
    /// var addedItems = [];
    /// Ext.create(&#39;Ext.toolbar.Toolbar&#39;, {
    /// renderTo: document.body,
    /// width   : 700,
    /// margin  : &#39;5 0 0 0&#39;,
    /// items   : [
    /// {
    /// text   : &#39;Add a button&#39;,
    /// scope  : this,
    /// handler: function() {
    /// var text = prompt(&#39;Please enter the text for your button:&#39;);
    /// addedItems.push(toolbar.add({
    /// text: text
    /// }));
    /// }
    /// },
    /// {
    /// text   : &#39;Add a text item&#39;,
    /// scope  : this,
    /// handler: function() {
    /// var text = prompt(&#39;Please enter the text for your item:&#39;);
    /// addedItems.push(toolbar.add(text));
    /// }
    /// },
    /// {
    /// text   : &#39;Add a toolbar seperator&#39;,
    /// scope  : this,
    /// handler: function() {
    /// addedItems.push(toolbar.add(&#39;-&#39;));
    /// }
    /// },
    /// {
    /// text   : &#39;Add a toolbar spacer&#39;,
    /// scope  : this,
    /// handler: function() {
    /// addedItems.push(toolbar.add(&#39;-&amp;gt;&#39;));
    /// }
    /// },
    /// &#39;-&amp;gt;&#39;,
    /// {
    /// text   : &#39;Remove last inserted item&#39;,
    /// scope  : this,
    /// handler: function() {
    /// if (addedItems.length) {
    /// toolbar.remove(addedItems.pop());
    /// } else if (toolbar.items.length) {
    /// toolbar.remove(toolbar.items.last());
    /// } else {
    /// alert(&#39;No items in the toolbar&#39;);
    /// }
    /// }
    /// },
    /// {
    /// text   : &#39;Remove all items&#39;,
    /// scope  : this,
    /// handler: function() {
    /// toolbar.removeAll();
    /// }
    /// }
    /// ]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Toolbar : Ext.container.Container, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Creates a new Toolbar ...
        /// </summary>
        public new object constructor(object config){return null;}
        /// <summary>
        /// Adds element(s) to the toolbar -- this function takes a variable number of
        /// arguments of mixed type and adds them to t...
        /// </summary>
        public object add(object arg1, object arg2, object etc){return null;}
    }
    #endregion
    #region ToolbarConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ToolbarConfig
    {
        /// <summary>
        /// Defaults to false. ...
        /// </summary>
        public bool enableOverflow{get;set;}
        /// <summary>
        /// This class assigns a default layout (layout:'hbox'). ...
        /// </summary>
        public object layout{get;set;}
        /// <summary>
        /// Set to true to make the toolbar vertical. ...
        /// </summary>
        public bool vertical{get;set;}
    }
    #endregion
    #region ToolbarEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ToolbarEvents
    {
        /// <summary>
        /// Fires after the overflow state has changed. ...
        /// </summary>
        public static JsString overflowchange="overflowchange";
    }
    #endregion
}
#endregion
