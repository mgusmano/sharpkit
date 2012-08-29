//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.draw.engine
{
    #region Svg
    /// <inheritdocs />
    /// <summary>
    /// <p>Provides specific methods to draw with SVG.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Svg : Surface
    {
        /// <summary>
        /// Insert or move a given sprite's element to the correct place in the DOM list for its zIndex
        /// </summary>
        /// <param name="sprite">
        /// </param>
        public void applyZIndex(Ext.draw.Sprite sprite){}
        /// <summary>
        /// Get the region for the surface's canvas area
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.util.Region">Ext.util.Region</see></span><div>
        /// </div>
        /// </returns>
        public Ext.util.Region getRegion(){return null;}
        /// <summary>
        /// Checks if the specified CSS class exists on this element's DOM node.
        /// </summary>
        /// <param name="sprite"><p>The sprite to look into.</p>
        /// </param>
        /// <param name="className"><p>The CSS class to check for</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the class exists, else false</p>
        /// </div>
        /// </returns>
        public bool hasCls(Ext.draw.Sprite sprite, JsString className){return false;}
        public Svg(SvgConfig config){}
        public Svg(){}
        public Svg(params object[] args){}
    }
    #endregion
    #region SvgConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SvgConfig : SurfaceConfig
    {
        public SvgConfig(params object[] args){}
    }
    #endregion
    #region SvgEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SvgEvents : SurfaceEvents
    {
        public SvgEvents(params object[] args){}
    }
    #endregion
}
