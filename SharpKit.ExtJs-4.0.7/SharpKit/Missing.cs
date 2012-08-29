using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

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