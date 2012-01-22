using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace Ext
{

    public partial class ExtContext
    {
        public static T create<T>(object config) { return default(T); }
        public static Ext.window.MessageBox Msg { get; set; }
        public static Ext.window.MessageBox MessageBox { get; set; }
    }
}
namespace Ext.panel
{
    public partial class TableConfig
    {
        /// <summary>
        /// The Store the grid should use as its data source (required).
        /// </summary>
        public Ext.data.Store store { get; set; }
        /// <summary>
        /// A config object that will be applied to the grid's UI view. Any of the config options available for Ext.view.Table can be specified here. This option is ignored if view is specified.
        /// </summary>
        public object viewConfig { get; set; }
    }

}
namespace Ext.grid.column
{
    public partial class ColumnConfig
    {
        /// <summary>
        /// A renderer is an 'interceptor' method which can be used transform data (value, appearance, etc.) before it is rendered
        /// </summary>
        public object renderer{ get; set; }
    }

}
