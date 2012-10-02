using SharpKit.JavaScript;

namespace SharpKit.EaselJS
{
    /// <summary>
    /// Applies a greyscale alpha map image (or canvas) to the target, such that the alpha channel of the result will be copied from the red channel of the map,
    /// and the RGB channels will be copied from the target. 
    /// Generally, it is recommended that you use AlphaMaskFilter, because it has much better performance.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "AlphaMapFilter", Export = false)]
    public class AlphaMapFilter
    {
        /// <summary>
        /// AlphaMapFilter Constructor
        /// </summary>
        /// <param name="alphaMap">alphaMap &lt;Image> The greyscale image (or canvas) to use as the alpha value for the result.
        /// This should be exactly the same dimensions as the target.</param>
        public AlphaMapFilter(object alphaMap) { }
        //TODO: parameter type is image

        /// <summary>
        /// The greyscale image (or canvas) to use as the alpha value for the result. This should be exactly the same dimensions as the target.
        /// </summary>
        public object alphaMap  { get; set; }
        //TODO: return type is image

        /// <summary>
        /// Applies the filter to the specified context.
        /// </summary>
        /// <param name="ctx">The 2D context to use as the source.</param>
        /// <param name="x">The x position to use for the source rect.</param>
        /// <param name="y">The y position to use for the source rect.</param>
        /// <param name="width">The width to use for the source rect.</param>
        /// <param name="height">The height to use for the source rect.</param>
        /// <param name="targetCtx"> Optional. The 2D context to draw the result to. Defaults to the context passed to ctx.</param>
        /// <param name="targetX">Optional. The x position to draw the result to. Defaults to the value passed to x.</param>
        /// <param name="targetY">Optional. The y position to draw the result to. Defaults to the value passed to y.</param>
        public void applyFilter(object ctx, object x, object y, object width, object height, object targetCtx, object targetX, object targetY) { }
        /// <summary>
        /// Applies the filter to the specified context.
        /// </summary>
        /// <param name="ctx">The 2D context to use as the source.</param>
        /// <param name="x">The x position to use for the source rect.</param>
        /// <param name="y">The y position to use for the source rect.</param>
        /// <param name="width">The width to use for the source rect.</param>
        /// <param name="height">The height to use for the source rect.</param>
        /// <param name="targetCtx"> Optional. The 2D context to draw the result to. Defaults to the context passed to ctx.</param>
        /// <param name="targetX">Optional. The x position to draw the result to. Defaults to the value passed to x.</param>
        public void applyFilter(object ctx, object x, object y, object width, object height, object targetCtx, object targetX) { }
        /// <summary>
        /// Applies the filter to the specified context.
        /// </summary>
        /// <param name="ctx">The 2D context to use as the source.</param>
        /// <param name="x">The x position to use for the source rect.</param>
        /// <param name="y">The y position to use for the source rect.</param>
        /// <param name="width">The width to use for the source rect.</param>
        /// <param name="height">The height to use for the source rect.</param>
        /// <param name="targetCtx"> Optional. The 2D context to draw the result to. Defaults to the context passed to ctx.</param>
        public void applyFilter(object ctx, object x, object y, object width, object height, object targetCtx) { }
        /// <summary>
        /// Applies the filter to the specified context.
        /// </summary>
        /// <param name="ctx">The 2D context to use as the source.</param>
        /// <param name="x">The x position to use for the source rect.</param>
        /// <param name="y">The y position to use for the source rect.</param>
        /// <param name="width">The width to use for the source rect.</param>
        /// <param name="height">The height to use for the source rect.</param>
        public void applyFilter(object ctx, object x, object y, object width, object height) { }

        /// <summary>
        /// Returns a clone of this object.
        /// </summary>
        public void clone() { }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns></returns>
        public JsString toString() { return null; }
    }

    /// <summary>
    /// Applies the alpha from the mask image (or canvas) to the target, such that the alpha channel of the result will be derived from the mask,
    /// and the RGB channels will be copied from the target. This can be used, for example, to apply an alpha mask to a display object.
    /// This can also be used to combine a JPG compressed RGB image with a PNG32 alpha mask, which can result in a much smaller file size than a single PNG32 containing ARGB.
    /// IMPORTANT NOTE: This filter currently does not support the targetCtx, or targetX/Y parameters correctly.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "AlphaMaskFilter", Export = false)]
    public class AlphaMaskFilter
    {
        /// <summary>
        /// AlphaMaskFilter Constructor
        /// </summary>
        /// <param name="mask ">The image (or canvas) to use as the mask.
        /// This should be exactly the same dimensions as the target.</param>
        public AlphaMaskFilter(object mask) { }
        //TODO: parameter type is image

        /// <summary>
        /// The image (or canvas) to use as the mask.
        /// </summary>
        public object mask { get; set; }
        //TODO: return type is image

        /// <summary>
        /// Applies the filter to the specified context.
        /// IMPORTANT NOTE: This filter currently does not support the targetCtx, or targetX/Y parameters correctly.
        /// </summary>
        /// <param name="ctx">The 2D context to use as the source.</param>
        /// <param name="x">The x position to use for the source rect.</param>
        /// <param name="y">The y position to use for the source rect.</param>
        /// <param name="width">The width to use for the source rect.</param>
        /// <param name="height">The height to use for the source rect.</param>
        /// <param name="targetCtx"> Optional. The 2D context to draw the result to. Defaults to the context passed to ctx.</param>
        /// <param name="targetX">Optional. The x position to draw the result to. Defaults to the value passed to x.</param>
        /// <param name="targetY">Optional. The y position to draw the result to. Defaults to the value passed to y.</param>
        public void applyFilter(object ctx, object x, object y, object width, object height, object targetCtx, object targetX, object targetY) { }
        /// <summary>
        /// Applies the filter to the specified context.
        /// IMPORTANT NOTE: This filter currently does not support the targetCtx, or targetX/Y parameters correctly.
        /// </summary>
        /// <param name="ctx">The 2D context to use as the source.</param>
        /// <param name="x">The x position to use for the source rect.</param>
        /// <param name="y">The y position to use for the source rect.</param>
        /// <param name="width">The width to use for the source rect.</param>
        /// <param name="height">The height to use for the source rect.</param>
        /// <param name="targetCtx"> Optional. The 2D context to draw the result to. Defaults to the context passed to ctx.</param>
        /// <param name="targetX">Optional. The x position to draw the result to. Defaults to the value passed to x.</param>
        public void applyFilter(object ctx, object x, object y, object width, object height, object targetCtx, object targetX) { }
        /// <summary>
        /// Applies the filter to the specified context.
        /// IMPORTANT NOTE: This filter currently does not support the targetCtx, or targetX/Y parameters correctly.
        /// </summary>
        /// <param name="ctx">The 2D context to use as the source.</param>
        /// <param name="x">The x position to use for the source rect.</param>
        /// <param name="y">The y position to use for the source rect.</param>
        /// <param name="width">The width to use for the source rect.</param>
        /// <param name="height">The height to use for the source rect.</param>
        /// <param name="targetCtx"> Optional. The 2D context to draw the result to. Defaults to the context passed to ctx.</param>
        public void applyFilter(object ctx, object x, object y, object width, object height, object targetCtx) { }
        /// <summary>
        /// Applies the filter to the specified context.
        /// IMPORTANT NOTE: This filter currently does not support the targetCtx, or targetX/Y parameters correctly.
        /// </summary>
        /// <param name="ctx">The 2D context to use as the source.</param>
        /// <param name="x">The x position to use for the source rect.</param>
        /// <param name="y">The y position to use for the source rect.</param>
        /// <param name="width">The width to use for the source rect.</param>
        /// <param name="height">The height to use for the source rect.</param>
        public void applyFilter(object ctx, object x, object y, object width, object height) { }

        /// <summary>
        /// Returns a clone of this object.
        /// </summary>
        public void clone() { }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns></returns>
        public JsString toString() { return null; }
    }
}
