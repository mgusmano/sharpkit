//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form
namespace Ext.form
{
    #region Labelable
    /// <summary>
    /// A mixin which allows a component to be configured and decorated with a label and/or error message as is
    /// common for form fields. This is used by e.g. Ext.form.field.Base and Ext.form.FieldContainer
    /// to let them be managed by the Field layout. *NOTE**: This mixin is mainly for internal library use and most users should not need to use it directly. It
    /// is more likely you will want to use one of the component classes that import this mixin, such as
    /// Ext.form.field.Base or Ext.form.FieldContainer. Use of this mixin does not make a component a field in the logical sense, meaning it does not provide any
    /// logic or state related to values or validation; that is handled by the related Ext.form.field.Field
    /// mixin. These two mixins may be used separately (for example Ext.form.FieldContainer is Labelable but not a
    /// Field), or in combination (for example Ext.form.field.Base implements both and has logic for connecting the
    /// two.) Component classes which use this mixin should use the Field layout
    /// or a derivation thereof to properly size and position the label and message according to the component config.
    /// They must also call the initLabelable method during component initialization to ensure the mixin gets
    /// set up correctly.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial interface Labelable
    {
        /// <summary>
        /// Gets the active error message for this component, if any. ...
        /// </summary>
        JsString getActiveError();
        /// <summary>
        /// Gets an Array of any active error messages currently applied to the field. ...
        /// </summary>
        JsArray getActiveErrors();
        /// <summary>
        /// Calculate and return the natural width of the bodyEl. ...
        /// </summary>
        object getBodyNaturalWidth();
        /// <summary>
        /// Returns the label for the field. ...
        /// </summary>
        JsString getFieldLabel();
        /// <summary>
        /// Get the input id, if any, for this component. ...
        /// </summary>
        JsString getInputId();
        /// <summary>
        /// Generates the arguments for the field decorations rendering template. ...
        /// </summary>
        object getLabelableRenderData();
        /// <summary>
        /// Returns the additional Ext.AbstractComponent.renderSelectors for selecting the field
        /// decoration elements from the ren...
        /// </summary>
        object getLabelableSelectors();
        /// <summary>
        /// Gets the markup to be inserted into the outer template's bodyEl. ...
        /// </summary>
        JsString getSubTplMarkup();
        /// <summary>
        /// Tells whether the field currently has an active error message. ...
        /// </summary>
        bool hasActiveError();
        /// <summary>
        /// Performs initialization of this mixin. ...
        /// </summary>
        object initLabelable();
        /// <summary>
        /// Sets the active error message to the given string. ...
        /// </summary>
        object setActiveError(JsString msg);
        /// <summary>
        /// Set the active error message to an Array of error messages. ...
        /// </summary>
        object setActiveErrors(JsArray errors);
        /// <summary>
        /// Applies a set of default configuration values to this Labelable instance. ...
        /// </summary>
        object setFieldDefaults(object defaults);
        /// <summary>
        /// Clears the active error message(s). ...
        /// </summary>
        object unsetActiveError();
        /// <summary>
        /// The div Element wrapping the component's contents. ...
        /// </summary>
        Ext.core.Element bodyEl{get;set;}
        /// <summary>
        /// The div Element that will contain the component's error message(s). ...
        /// </summary>
        Ext.core.Element errorEl{get;set;}
        /// <summary>
        /// Flag denoting that this object is labelable as a field. ...
        /// </summary>
        bool isFieldLabelable{get;set;}
        /// <summary>
        /// The label Element for this component. ...
        /// </summary>
        Ext.core.Element labelEl{get;set;}
    }
    #endregion
    #region LabelableConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class LabelableConfig : Ext.BaseConfig
    {
        /// <summary>
        /// If specified, then the component will be displayed with this value as its active error when
        /// first rendered. ...
        /// </summary>
        public JsString activeError{get;set;}
        /// <summary>
        /// The template used to format the Array of error messages passed to setActiveErrors
        /// into a single HTML string. ...
        /// </summary>
        public XTemplate activeErrorsTpl{get;set;}
        /// <summary>
        /// Whether to adjust the component's body area to make room for 'side' or 'under'
        /// error messages. ...
        /// </summary>
        public bool autoFitErrors{get;set;}
        /// <summary>
        /// The CSS class to be applied to the body content element. ...
        /// </summary>
        public JsString baseBodyCls{get;set;}
        /// <summary>
        /// The CSS class to be applied to the special clearing div rendered directly after the field
        /// contents wrapper to provide...
        /// </summary>
        public JsString clearCls{get;set;}
        /// <summary>
        /// The CSS class to be applied to the error message element. ...
        /// </summary>
        public JsString errorMsgCls{get;set;}
        /// <summary>
        /// An extra CSS class to be applied to the body content element in addition to fieldBodyCls. ...
        /// </summary>
        public JsString fieldBodyCls{get;set;}
        /// <summary>
        /// The label for the field. ...
        /// </summary>
        public JsString fieldLabel{get;set;}
        /// <summary>
        /// A CSS class to be applied to the outermost element to denote that it is participating in the form
        /// field layout. ...
        /// </summary>
        public JsString formItemCls{get;set;}
        /// <summary>
        /// When set to true, the label element (fieldLabel and labelSeparator) will be
        /// automatically hidden if the fieldLabel is...
        /// </summary>
        public bool hideEmptyLabel{get;set;}
        /// <summary>
        /// Set to true to completely hide the label element (fieldLabel and labelSeparator). ...
        /// </summary>
        public bool hideLabel{get;set;}
        public JsString invalidCls{get;set;}
        /// <summary>
        /// Controls the position and alignment of the fieldLabel. ...
        /// </summary>
        public JsString labelAlign{get;set;}
        /// <summary>
        /// The CSS class to be applied to the label element. ...
        /// </summary>
        public JsString labelCls{get;set;}
        /// <summary>
        /// The amount of space in pixels between the fieldLabel and the input field. ...
        /// </summary>
        public JsNumber labelPad{get;set;}
        public JsString labelSeparator{get;set;}
        /// <summary>
        /// A CSS style specification string to apply directly to this field's label. ...
        /// </summary>
        public JsString labelStyle{get;set;}
        /// <summary>
        /// The width of the fieldLabel in pixels. ...
        /// </summary>
        public JsNumber labelWidth{get;set;}
        /// <summary>
        /// The rendering template for the field decorations. ...
        /// </summary>
        public object labelableRenderTpl{get;set;}
        /// <summary>
        /// The location where the error message text should display. ...
        /// </summary>
        public JsString msgTarget{get;set;}
        /// <summary>
        /// true to disable displaying any error message set on this object. ...
        /// </summary>
        public bool preventMark{get;set;}
    }
    #endregion
    #region LabelableEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class LabelableEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when the active error message is changed via setActiveError. ...
        /// </summary>
        public static JsString errorchange="errorchange";
    }
    #endregion
}
#endregion
