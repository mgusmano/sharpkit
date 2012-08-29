//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.plugin
namespace Ext.grid.plugin
{
    #region CellEditing
    /// <inheritdocs />
    /// <summary>
    /// <p>The <see cref="Ext.grid.plugin.CellEditing">Ext.grid.plugin.CellEditing</see> plugin injects editing at a cell level for a Grid. Only a single
    /// cell will be editable at a time. The field that will be used for the editor is defined at the
    /// <see cref="Ext.grid.column.ColumnConfig.editor">editor</see>. The editor can be a field instance or a field configuration.</p>
    /// <p>If an editor is not specified for a particular column then that cell will not be editable and it will
    /// be skipped when activated via the mouse or the keyboard.</p>
    /// <p>The editor may be shared for each column in the grid, or a different one may be specified for each column.
    /// An appropriate field type should be chosen to match the data structure that it will be editing. For example,
    /// to edit a date, it would be useful to specify <see cref="Ext.form.field.Date">Ext.form.field.Date</see> as the editor.</p>
    /// <h2>Example</h2>
    /// <p>A grid with editor for the name and the email columns:</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// storeId:'simpsonsStore',
    /// fields:['name', 'email', 'phone'],
    /// data:{'items':[
    /// {"name":"Lisa", "email":"lisa@simpsons.com", "phone":"555-111-1224"},
    /// {"name":"Bart", "email":"bart@simpsons.com", "phone":"555-222-1234"},
    /// {"name":"Homer", "email":"home@simpsons.com", "phone":"555-222-1244"},
    /// {"name":"Marge", "email":"marge@simpsons.com", "phone":"555-222-1254"}
    /// ]},
    /// proxy: {
    /// type: 'memory',
    /// reader: {
    /// type: 'json',
    /// root: 'items'
    /// }
    /// }
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// title: 'Simpsons',
    /// store: <see cref="Ext.data.StoreManager.lookup">Ext.data.StoreManager.lookup</see>('simpsonsStore'),
    /// columns: [
    /// {header: 'Name',  dataIndex: 'name', editor: 'textfield'},
    /// {header: 'Email', dataIndex: 'email', flex:1,
    /// editor: {
    /// xtype: 'textfield',
    /// allowBlank: false
    /// }
    /// },
    /// {header: 'Phone', dataIndex: 'phone'}
    /// ],
    /// selType: 'cellmodel',
    /// plugins: [
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.plugin.CellEditing">Ext.grid.plugin.CellEditing</see>', {
    /// clicksToEdit: 1
    /// })
    /// ],
    /// height: 200,
    /// width: 400,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// <p>This requires a little explanation. We're passing in <c>store</c> and <c>columns</c> as normal, but
    /// we also specify a <see cref="Ext.grid.column.ColumnConfig.field">field</see> on two of our columns. For the
    /// Name column we just want a default textfield to edit the value, so we specify 'textfield'.
    /// For the Email column we customized the editor slightly by passing allowBlank: false, which
    /// will provide inline validation.</p>
    /// <p>To support cell editing, we also specified that the grid should use the 'cellmodel'
    /// <see cref="Ext.grid.PanelConfig.selType">selType</see>, and created an instance of the CellEditing plugin,
    /// which we configured to activate each editor after a single click.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class CellEditing : Editing
    {
        /// <summary>
        /// Gets the cell (td) for a particular record and column.
        /// </summary>
        /// <param name="record">
        /// </param>
        /// <param name="column">
        /// </param>
        private void getCell(Ext.data.Model record, Ext.grid.column.Column column){}
        /// <summary>
        /// Starts editing by position (row/column)
        /// </summary>
        /// <param name="position"><p>A position with keys of row and column.</p>
        /// </param>
        public void startEditByPosition(object position){}
        public CellEditing(CellEditingConfig config){}
        public CellEditing(){}
        public CellEditing(params object[] args){}
    }
    #endregion
    #region CellEditingConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CellEditingConfig : EditingConfig
    {
        public CellEditingConfig(params object[] args){}
    }
    #endregion
    #region CellEditingEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CellEditingEvents : EditingEvents
    {
        public CellEditingEvents(params object[] args){}
    }
    #endregion
}
#endregion
