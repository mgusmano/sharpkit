//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region Shadow
    /// <inheritdocs />
    /// <summary>
    /// <p>Simple class that can provide a shadow effect for any element.  Note that the element
    /// MUST be absolutely positioned, and the shadow does not provide any shimming.  This
    /// should be used only in simple cases - for more advanced functionality that can also
    /// provide the same shadow effect, see the <see cref="Ext.Layer">Ext.Layer</see> class.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Shadow : Ext.Base
    {
        /// <summary>
        /// The shadow display mode.  Supports the following options:
        /// <li>sides : Shadow displays on both sides and bottom only</li>
        /// <li>frame : Shadow displays equally on all four sides</li>
        /// <li>drop : Traditional bottom-right drop shadow</li>
        /// </summary>
        public JsString mode;
        /// <summary>
        /// The number of pixels to offset the shadow from the element
        /// Defaults to: <c>4</c>
        /// </summary>
        public JsNumber offset;
        /// <summary>
        /// Creates new Shadow.
        /// </summary>
        /// <param name="config"><p>Config object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Shadow(object config=null){}
        /// <summary>
        /// Returns the shadow size on each side of the element in standard CSS order: top, right, bottom, left;
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see>[]</span><div><p>Top, right, bottom and left shadow size.</p>
        /// </div>
        /// </returns>
        private JsNumber[] getShadowSize(){return null;}
        /// <summary>
        /// Hides this shadow
        /// </summary>
        public void hide(){}
        /// <summary>
        /// Returns true if the shadow is visible, else false
        /// </summary>
        public void isVisible(){}
        /// <summary>
        /// Direct alignment when values are already available. Show must be called at least once before
        /// calling this method to ensure it is initialized.
        /// </summary>
        /// <param name="left"><p>The target element left position</p>
        /// </param>
        /// <param name="top"><p>The target element top position</p>
        /// </param>
        /// <param name="width"><p>The target element width</p>
        /// </param>
        /// <param name="height"><p>The target element height</p>
        /// </param>
        public void realign(JsNumber left, JsNumber top, JsNumber width, JsNumber height){}
        /// <summary>
        /// Sets the opacity of the shadow
        /// </summary>
        /// <param name="opacity"><p>The opacity</p>
        /// </param>
        public void setOpacity(JsNumber opacity){}
        /// <summary>
        /// Adjust the z-index of this shadow
        /// </summary>
        /// <param name="zindex"><p>The new z-index</p>
        /// </param>
        public void setZIndex(JsNumber zindex){}
        /// <summary>
        /// Displays the shadow under the target element
        /// </summary>
        /// <param name="targetEl"><p>The id or element under which the shadow should display</p>
        /// </param>
        public void show(object targetEl){}
        public Shadow(ShadowConfig config){}
        public Shadow(params object[] args){}
    }
    #endregion
    #region ShadowConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ShadowConfig : Ext.BaseConfig
    {
        /// <summary>
        /// The shadow display mode.  Supports the following options:
        /// <li>sides : Shadow displays on both sides and bottom only</li>
        /// <li>frame : Shadow displays equally on all four sides</li>
        /// <li>drop : Traditional bottom-right drop shadow</li>
        /// </summary>
        public JsString mode;
        /// <summary>
        /// The number of pixels to offset the shadow from the element
        /// Defaults to: <c>4</c>
        /// </summary>
        public JsNumber offset;
        public ShadowConfig(params object[] args){}
    }
    #endregion
    #region ShadowEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ShadowEvents : Ext.BaseEvents
    {
        public ShadowEvents(params object[] args){}
    }
    #endregion
}
