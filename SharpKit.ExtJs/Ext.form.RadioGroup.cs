//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form
{
    #region RadioGroup
    /// <inheritdocs />
    /// <summary>
    /// <p>A <see cref="Ext.form.FieldContainer">field container</see> which has a specialized layout for arranging
    /// <see cref="Ext.form.field.Radio">Ext.form.field.Radio</see> controls into columns, and provides convenience <see cref="Ext.form.field.Field">Ext.form.field.Field</see>
    /// methods for <see cref="Ext.form.RadioGroup.getValue">getting</see>, <see cref="Ext.form.RadioGroup.setValue">setting</see>, and <see cref="Ext.form.RadioGroup.validate">validating</see> the
    /// group of radio buttons as a whole.</p>
    /// <h1>Validation</h1>
    /// <p>Individual radio buttons themselves have no default validation behavior, but
    /// sometimes you want to require a user to select one of a group of radios. RadioGroup
    /// allows this by setting the config <c><see cref="Ext.form.RadioGroupConfig.allowBlank">allowBlank</see>:false</c>; when the user does not check at
    /// one of the radio buttons, the entire group will be highlighted as invalid and the
    /// <see cref="Ext.form.RadioGroupConfig.blankText">error message</see> will be displayed according to the <see cref="Ext.form.RadioGroupConfig.msgTarget">msgTarget</see> config.</p>
    /// <h1>Layout</h1>
    /// <p>The default layout for RadioGroup makes it easy to arrange the radio buttons into
    /// columns; see the <see cref="Ext.form.RadioGroupConfig.columns">columns</see> and <see cref="Ext.form.RadioGroupConfig.vertical">vertical</see> config documentation for details. You may also
    /// use a completely different layout by setting the <see cref="Ext.form.RadioGroupConfig.layout">layout</see> to one of the other supported layout
    /// types; for instance you may wish to use a custom arrangement of hbox and vbox containers. In that case
    /// the Radio components at any depth will still be managed by the RadioGroup's validation.</p>
    /// <h1>Example usage</h1>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.Panel</see>', {
    /// title: 'RadioGroup Example',
    /// width: 300,
    /// height: 125,
    /// bodyPadding: 10,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// items:[{
    /// xtype: 'radiogroup',
    /// fieldLabel: 'Two Columns',
    /// // Arrange radio buttons into two columns, distributed vertically
    /// columns: 2,
    /// vertical: true,
    /// items: [
    /// { boxLabel: 'Item 1', name: 'rb', inputValue: '1' },
    /// { boxLabel: 'Item 2', name: 'rb', inputValue: '2', checked: true},
    /// { boxLabel: 'Item 3', name: 'rb', inputValue: '3' },
    /// { boxLabel: 'Item 4', name: 'rb', inputValue: '4' },
    /// { boxLabel: 'Item 5', name: 'rb', inputValue: '5' },
    /// { boxLabel: 'Item 6', name: 'rb', inputValue: '6' }
    /// ]
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class RadioGroup : Ext.form.CheckboxGroup
    {
        public RadioGroup(RadioGroupConfig config){}
        public RadioGroup(){}
        public RadioGroup(params object[] args){}
    }
    #endregion
    #region RadioGroupConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class RadioGroupConfig : Ext.form.CheckboxGroupConfig
    {
        public RadioGroupConfig(params object[] args){}
    }
    #endregion
    #region RadioGroupEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class RadioGroupEvents : Ext.form.CheckboxGroupEvents
    {
        public RadioGroupEvents(params object[] args){}
    }
    #endregion
}
