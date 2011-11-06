using SharpKit.JavaScript;
#region Ext.selection

namespace Ext.selection
{
    #region CellModel

    [JsType( JsMode.Prototype, Export = false )]
    public partial class CellModel : Ext.selection.Model
    {
        /// <summary>
        /// Returns the current position in the format {row: row, column: column}
        /// </summary>
        /// <returns>Position in the format {row: row, column: column}</returns>
        public Position getCurrentPosition() { return null; }

        /// <summary>
        /// Sets the current position
        /// </summary>
        /// <param name="pos">Position in the format {row: row, column: column}</param>
        public void setCurrentPosition( object pos ) { }

        [JsType( JsMode.Json, Export = false )]
        public class Position
        {
            public int row { get; set; }
            public int column { get; set; }
        }
    }

    #endregion

    #region CellModelConfig

    [JsType( JsMode.Json, Export = false )]
    public class CellModelConfig
    {
        /// <summary>
        /// Turns on/off keyboard navigation within the grid.
        /// </summary>
        public bool enableKeyNav { get; set; }

        /// <summary>
        /// Set this configuration to true to prevent wrapping around of selection as a user navigates to the first or last column.
        /// </summary>
        public bool preventWrap { get; set; }
    }

    #endregion

    #region CellModelEvents
    
    [JsType( JsMode.Json, Export = false )]
    public partial class CellModelEvents : Ext.selection.ModelEvents
    {
        /// <summary>
        /// Fired after a cell is deselected
        /// </summary>
        public static JsString deselect = "deselect";

        /// <summary>
        /// Fired after a cell is selected
        /// </summary>
        public static JsString select = "select";
    }
    
    #endregion
}

#endregion