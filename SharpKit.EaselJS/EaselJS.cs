using SharpKit.JavaScript;
using SharpKit.Html;

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
        public object alphaMap { get; set; }
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

    /// <summary>
    /// (extends DisplayObject) A Bitmap represents an Image, Canvas, or Video in the display list.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Bitmap", Export = false)]
    public class Bitmap : DisplayObject
    {
        /// <summary>
        /// Bitmap Constructor
        /// </summary>
        /// <param name="imageOrUri">The source object or URI to an image to display.
        /// This can be either an Image, Canvas, or Video object, or a string URI to an image file to load and use.
        /// If it is a URI, a new Image object will be constructed and assigned to the .image property.</param>
        public Bitmap(HtmlImageElement imageOrUri) { }
        /// <summary>
        /// Bitmap Constructor
        /// </summary>
        /// <param name="imageOrUri">The source object or URI to an image to display.
        /// This can be either an Image, Canvas, or Video object, or a string URI to an image file to load and use.
        /// If it is a URI, a new Image object will be constructed and assigned to the .image property.</param>
        public Bitmap(HtmlCanvasElement imageOrUri) { }
        /// <summary>
        /// Bitmap Constructor
        /// </summary>
        /// <param name="imageOrUri">The source object or URI to an image to display.
        /// This can be either an Image, Canvas, or Video object, or a string URI to an image file to load and use.
        /// If it is a URI, a new Image object will be constructed and assigned to the .image property.</param>
        public Bitmap(HtmlVideoElement imageOrUri) { }
        /// <summary>
        /// Bitmap Constructor
        /// </summary>
        /// <param name="imageOrUri">The source object or URI to an image to display.
        /// This can be either an Image, Canvas, or Video object, or a string URI to an image file to load and use.
        /// If it is a URI, a new Image object will be constructed and assigned to the .image property.</param>
        public Bitmap(JsString imageOrUri) { }

        /// <summary>
        ///The image to render. This can be an Image, a Canvas, or a Video.
        /// </summary>
        public HtmlImageElement image { get; set; }
        /// <summary>
        ///The image to render. This can be an Image, a Canvas, or a Video.
        /// </summary>
        [JsProperty(Name = "image")]
        public HtmlCanvasElement imageCanvas { get; set; }
        /// <summary>
        ///The image to render. This can be an Image, a Canvas, or a Video.
        /// </summary>
        [JsProperty(Name = "image")]
        public HtmlVideoElement imageVideo { get; set; }

        /// <summary>
        /// Whether or not the Bitmap should be draw to the canvas at whole pixel coordinates.
        /// </summary>
        public bool snapToPixel { get; set; }

        /// <summary>
        /// (Rectangle) Specifies an area of the source image to draw. If omitted, the whole image will be drawn.
        /// </summary>
        public Rectangle sourceRect { get; set; }

        /// <summary>
        /// Because the content of a Bitmap is already in a simple format, cache is unnecessary for Bitmap instances.
        /// You should not cache Bitmap instances as it can degrade performance.
        /// </summary>
        public void cache() { }

        /// <summary>
        /// Returns a clone of the Bitmap instance.
        /// </summary>
        /// <returns>a clone of the Bitmap instance.</returns>
        public Bitmap clone() { return null; }

        /// <summary>
        /// Draws the display object into the specified context ignoring it's visible, alpha, shadow, and transform.
        /// Returns true if the draw was handled (useful for overriding functionality). NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <param name="ctx">The canvas 2D context object to draw into.</param>
        /// <param name="ignoreCache">Indicates whether the draw operation should ignore any current cache.
        /// For example, used for drawing the cache (to prevent it from simply drawing an existing cache back into itself).</param>
        public bool draw(CanvasRenderingContext2D ctx, bool ignoreCache) { return false; }

        /// <summary>
        /// Returns true or false indicating whether the display object would be visible if drawn to a canvas.
        /// This does not account for whether it would be visible within the boundaries of the stage.
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <returns>Boolean indicating whether the display object would be visible if drawn to a canvas</returns>
        public bool isVisible() { return false; }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>a string representation of the instance.</returns>
        public JsString toString() { return null; }

        /// <summary>
        /// Because the content of a Bitmap is already in a simple format, cache is unnecessary for Bitmap instances.
        /// You should not cache Bitmap instances as it can degrade performance.
        /// </summary>
        public void uncache() { }

        /// <summary>
        /// Because the content of a Bitmap is already in a simple format, cache is unnecessary for Bitmap instances.
        /// You should not cache Bitmap instances as it can degrade performance.
        /// </summary>
        public void updateCache() { }
    }

    /// <summary>
    /// (extends DisplayObject) Displays frames or sequences of frames (ie. animations) from a sprite sheet image.
    /// A sprite sheet is a series of images (usually animation frames) combined into a single image.
    /// For example, an animation consisting of 8 100x100 images could be combined into a 400x200 sprite sheet (4 frames across by 2 high).
    /// You can display individual frames, play frames as an animation, and even sequence animations together.
    /// See the SpriteSheet class for more information on setting up frames and animations.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "BitmapAnimation", Export = false)]
    public class BitmapAnimation : DisplayObject
    {
        /// <summary>
        /// BitmapAnimation  Constructor
        /// </summary>
        /// <param name="imageOrUri">The SpriteSheet instance to play back.
        /// This includes the source image(s), frame dimensions, and frame data. See SpriteSheet for more information.</param>
        public BitmapAnimation(SpriteSheet spriteSheet) { }

        /// <summary>
        /// Returns the currently playing animation. READ-ONLY.
        /// </summary>
        public JsString currentAnimation { get; private set; }

        /// <summary>
        /// Specifies the current frame index within the current playing animation.
        /// When playing normally, this will increase successively from 0 to n-1, where n is the number of frames in the current animation.
        /// Default Value: 0
        /// </summary>
        public JsNumber currentAnimationFrame { get; set; }

        /// <summary>
        /// The frame that will be drawn when draw is called. Note that with some SpriteSheet data, this will advance non-sequentially. READ-ONLY.
        /// Default Value: -1
        /// </summary>
        public JsNumber currentFrame { get; private set; }

        /// <summary>
        /// When used in conjunction with animations having an frequency greater than 1, this lets you offset which tick the playhead will advance on.
        /// For example, you could create two BitmapAnimations, both playing an animation with a frequency of 2, but one having offset set to 1.
        /// Both instances would advance every second tick, but they would advance on alternating ticks (effectively, one instance would advance on odd ticks, the other on even ticks).
        /// Default Value: 0
        /// </summary>
        public JsNumber offset { get; set; }

        /// <summary>
        /// Specifies a function to call whenever any animation reaches its end.
        /// It will be called with two params: the first will be a reference to this instance, the second will be the name of the animation that just ended.
        /// </summary>
        public JsAction<object, object> onAnimationEnd { get; set; }

        /// <summary>
        /// Prevents the animation from advancing each tick automatically.
        /// For example, you could create a sprite sheet of icons, set paused to true, and display the appropriate icon by setting currentFrame.
        /// Default Value: false
        /// </summary>
        public bool paused { get; set; }

        /// <summary>
        /// Whether or not the Bitmap should be draw to the canvas at whole pixel coordinates.
        /// Default Value: true
        /// </summary>
        public bool snapToPixel { get; set; }

        /// <summary>
        /// The SpriteSheet instance to play back. This includes the source image, frame dimensions, and frame data. See SpriteSheet for more information.
        /// </summary>
        public SpriteSheet spriteSheet { get; set; }

        /// <summary>
        /// Advances the playhead. This occurs automatically each tick by default.
        /// </summary>
        public void advance() { }

        /// <summary>
        /// Because the content of a Bitmap is already in a simple format, cache is unnecessary for Bitmap instances.
        /// You should not cache Bitmap instances as it can degrade performance.
        /// </summary>
        public void cache() { }

        /// <summary>
        /// Returns a clone of the Point instance.
        /// </summary>
        /// <returns>a clone of the Point instance.</returns>
        public Point clone() { return null; }

        /// <summary>
        /// Draws the display object into the specified context ignoring it's visible, alpha, shadow, and transform.
        /// Returns true if the draw was handled (useful for overriding functionality).
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <param name="ctx">The canvas 2D context object to draw into.</param>
        /// <param name="ignoreCache">Indicates whether the draw operation should ignore any current cache.
        /// For example, used for drawing the cache (to prevent it from simply drawing an existing cache back into itself).</param>
        public bool draw(CanvasRenderingContext2D ctx, bool ignoreCache) { return false; }

        /// <summary>
        /// Sets paused to false and plays the specified animation name, named frame, or frame number.
        /// </summary>
        /// <param name="frameOrAnimation">The frame number or animation name that the playhead should move to and begin playing.</param>
        public void gotoAndPlay(JsNumber frameOrAnimation) { }
        /// <summary>
        /// Sets paused to false and plays the specified animation name, named frame, or frame number.
        /// </summary>
        /// <param name="frameOrAnimation">The frame number or animation name that the playhead should move to and begin playing.</param>
        public void gotoAndPlay(JsString frameOrAnimation) { }

        /// <summary>
        /// Sets paused to true and seeks to the specified animation name, named frame, or frame number.
        /// </summary>
        /// <param name="frameOrAnimation">The frame number or animation name that the playhead should move to and stop.</param>
        public void gotoAndStop(JsNumber frameOrAnimation) { }
        /// <summary>
        /// Sets paused to true and seeks to the specified animation name, named frame, or frame number.
        /// </summary>
        /// <param name="frameOrAnimation">The frame number or animation name that the playhead should move to and stop.</param>
        public void gotoAndStop(JsString frameOrAnimation) { }

        /// <summary>
        /// Returns true or false indicating whether the display object would be visible if drawn to a canvas.
        /// This does not account for whether it would be visible within the boundaries of the stage.
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <returns>Boolean indicating whether the display object would be visible if drawn to a canvas</returns>
        public bool isVisible() { return false; }

        /// <summary>
        /// no Doc.
        /// </summary>
        public void play() { }

        /// <summary>
        /// no Doc.
        /// </summary>
        public void stop() { }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>a string representation of the instance.</returns>
        public JsString toString() { return null; }

        /// <summary>
        /// Because the content of a Bitmap is already in a simple format, cache is unnecessary for Bitmap instances.
        /// You should not cache Bitmap instances as it can degrade performance.
        /// </summary>
        public void uncache() { }

        /// <summary>
        /// Because the content of a Bitmap is already in a simple format, cache is unnecessary for Bitmap instances.
        /// You should not cache Bitmap instances as it can degrade performance.
        /// </summary>
        public void updateCache() { }
    }

    /// <summary>
    /// BoxBlurFilter applies a box blur to DisplayObjects
    /// </summary>
    [JsType(JsMode.Prototype, Name = "BoxBlurFilter", Export = false)]
    public class BoxBlurFilter
    {
        /// <summary>
        /// BoxBlurFilter Constructor
        /// </summary>
        /// <param name="blurX"></param>
        /// <param name="blurY"></param>
        /// <param name="quality"></param>
        public BoxBlurFilter(JsNumber blurX, JsNumber blurY, JsNumber quality) { }

        /// <summary>
        /// Horizontal blur radius
        /// </summary>
        public JsNumber blurX { get; set; }

        /// <summary>
        /// Vertical blur radius
        /// </summary>
        public JsNumber blurY { get; set; }

        /// <summary>
        /// Number of blur iterations. For example, a value of 1 will produce a rough blur. A value of 2 will produce a smoother blur, but take twice as long to run.
        /// </summary>
        public JsNumber quality { get; set; }

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
        /// <returns></returns>
        public BoxBlurFilter clone() { return null; }

        /// <summary>
        /// Returns a rectangle with values indicating the margins required to draw the filter.
        /// For example, a filter that will extend the drawing area 4 pixels to the left, and 7 pixels to the right (but no pixels up or down) would return a rectangle with (x=-4, y=0, width=11, height=0).
        /// </summary>
        /// <returns>a rectangle object indicating the margins required to draw the filter.</returns>
        public Rectangle getBounds() { return null; }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns></returns>
        public JsString toString() { return null; }
    }

    /// <summary>
    /// Applies color transforms.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "ColorFilter", Export = false)]
    public class ColorFilter
    {

        public ColorFilter(JsNumber redMultiplier, JsNumber greenMultiplier, JsNumber blueMultiplier, JsNumber alphaMultiplier, JsNumber redOffset, JsNumber greenOffset, JsNumber blueOffset, JsNumber alphaOffset) { }

        /// <summary>
        /// Alpha channel offset (added to value).
        /// </summary>
        public JsNumber alphaOffset { get; set; }

        /// <summary>
        /// Blue channel multiplier.
        /// </summary>
        public JsNumber blueMultiplier { get; set; }

        /// <summary>
        /// Blue channel offset (added to value).
        /// </summary>
        public JsNumber blueOffset { get; set; }

        /// <summary>
        /// Green channel multiplier.
        /// </summary>
        public JsNumber greenMultiplier { get; set; }

        /// <summary>
        /// Green channel offset (added to value).
        /// </summary>
        public JsNumber greenOffset { get; set; }

        /// <summary>
        /// Red channel multiplier.
        /// </summary>
        public JsNumber redMultiplier { get; set; }

        /// <summary>
        /// Red channel offset
        /// </summary>
        public JsNumber redOffset { get; set; }

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
        /// Returns a clone of this ColorFilter instance.
        /// </summary>
        /// <returns>A clone of the current ColorFilter instance.</returns>
        public ColorFilter clone() { return null; }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns></returns>
        public JsString toString() { return null; }
    }

    /// <summary>
    /// Provides helper functions for assembling a matrix for use with the ColorMatrixFilter. Can be used directly as the matrix for a ColorMatrixFilter.
    /// Most methods return the instance to facilitate chained calls. Ex. myColorMatrix.adjustHue(20).adjustBrightness(50);
    /// </summary>
    [JsType(JsMode.Prototype, Name = "ColorMatrix", Export = false)]
    public class ColorMatrix
    {
        public ColorMatrix(JsNumber brightness, JsNumber contrast, JsNumber saturation, JsNumber hue) { }

        /// <summary>
        /// Array of delta values for contrast calculations.
        /// </summary>
        public static JsNumber DELTA_INDEX { get; set; }

        /// <summary>
        /// Identity matrix values.
        /// </summary>
        public static JsArray IDENTITY_MATRIX { get; set; }

        /// <summary>
        /// The constant length of a color matrix.
        /// </summary>
        public static JsNumber LENGTH { get; set; }

        /// <summary>
        /// Adjusts the brightness of pixel color by adding the specified value to the red, green and blue channels.
        /// Positive values will make the image brighter, negative values will make it darker.
        /// </summary>
        /// <param name="value">A value between -255 & 255 that will be added to the RGB channels.</param>
        /// <returns>The ColorMatrix instance the method is called on (useful for chaining calls.)</returns>
        public ColorMatrix adjustBrightness(JsNumber value) { return null; }

        /// <summary>
        /// Shortcut method to adjust brightness, contrast, saturation and hue.
        /// Equivalent to calling adjustHue(hue), adjustContrast(contrast), adjustBrightness(brightness), adjustSaturation(saturation), in that order.
        /// </summary>
        /// <param name="brightness"></param>
        /// <param name="contrast"></param>
        /// <param name="saturation"></param>
        /// <param name="hue"></param>
        /// <returns>The ColorMatrix instance the method is called on (useful for chaining calls.)</returns>
        public ColorMatrix adjustColor(JsNumber brightness, JsNumber contrast, JsNumber saturation, JsNumber hue) { return null; }

        /// <summary>
        /// Adjusts the contrast of pixel color. Positive values will increase contrast, negative values will decrease contrast.
        /// </summary>
        /// <param name="value">A value between -100 & 100.</param>
        /// <returns>The ColorMatrix instance the method is called on (useful for chaining calls.)</returns>
        public ColorMatrix adjustContrast(JsNumber value) { return null; }

        /// <summary>
        /// Adjusts the hue of the pixel color.
        /// </summary>
        /// <param name="value">A value between -180 & 180.</param>
        /// <returns>The ColorMatrix instance the method is called on (useful for chaining calls.)</returns>
        public ColorMatrix adjustHue(JsNumber value) { return null; }

        /// <summary>
        /// Adjusts the color saturation of the pixel. Positive values will increase saturation, negative values will decrease saturation (trend towards greyscale).
        /// </summary>
        /// <param name="value">A value between -100 & 100.</param>
        /// <returns>The ColorMatrix instance the method is called on (useful for chaining calls.)</returns>
        public ColorMatrix adjustSaturation(JsNumber value) { return null; }

        /// <summary>
        /// Returns a clone of this ColorMatrix.
        /// </summary>
        /// <returns>A clone of this ColorMatrix.</returns>
        public ColorMatrix clone() { return null; }

        /// <summary>
        /// Concatenates (multiplies) the specified matrix with this one.
        /// </summary>
        /// <param name="matrix">An array or ColorMatrix instance.</param>
        /// <returns>The ColorMatrix instance the method is called on (useful for chaining calls.)</returns>
        public ColorMatrix concat(JsArray matrix) { return null; }

        /// <summary>
        /// Copy the specified matrix's values to this matrix.
        /// </summary>
        /// <param name="matrix">An array or ColorMatrix instance.</param>
        /// <returns>The ColorMatrix instance the method is called on (useful for chaining calls.)</returns>
        public ColorMatrix copyMatrix(JsArray matrix) { return null; }

        /// <summary>
        /// Resets the matrix to identity values.
        /// </summary>
        /// <returns>The ColorMatrix instance the method is called on (useful for chaining calls.)</returns>
        public ColorMatrix reset() { return null; }

        /// <summary>
        /// Return a length 25 (5x5) array instance containing this matrix's values.
        /// </summary>
        /// <returns>An array holding this matrix's values.</returns>
        public JsArray toArray() { return null; }
    }

    /// <summary>
    /// Allows you to carry out complex color operations such as modifying saturation, brightness, or inverting.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "ColorMatrixFilter", Export = false)]
    public class ColorMatrixFilter
    {
        public ColorMatrixFilter(object matrix) { }

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
        /// Returns a clone of this ColorMatrixFilter instance.
        /// </summary>
        /// <returns>A clone of the current ColorMatrixFilter instance.</returns>
        public ColorMatrixFilter clone() { return null; }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>a string representation of the instance.</returns>
        public JsString toString() { return null; }
    }

    /// <summary>
    /// Inner class used by the Graphics class. Used to create the instruction lists used in Graphics:
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Command", Export = false)]
    public class Command
    {
        public Command() { }

        public void exec(object scope) { }
    }

    /// <summary>
    /// Class Container - extends DisplayObject
    /// Known Subclasses: MovieClip Stage
    /// A Container is a nestable display lists that allows you to work with compound display elements.
    /// For example you could group arm, leg, torso and head Bitmaps together into a Person Container, and transform them as a group,
    /// while still being able to move the individual parts relative to each other.
    /// Children of containers have their transform and alpha properties concatenated with their parent Container.
    /// For example, a Shape with x=100 and alpha=0.5, placed in a Container with x=50 and alpha=0.7 will be rendered to the canvas at x=150 and alpha=0.35.
    /// Containers have some overhead, so you generally shouldn't create a Container to hold a single child.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Container", Export = false)]
    public class Container : DisplayObject
    {
        public Container() { }

        /// <summary>
        /// The array of children in the display list.
        /// You should usually use the child management methods, rather than accessing this directly, but it is included for advanced users.
        /// Default Value: null
        /// </summary>
        public JsArray<DisplayObject> children { get; set; }

        /// <summary>
        /// Adds a child to the top of the display list. You can also add multiple children, such as "addChild(child1, child2, ...);".
        /// Returns the child that was added, or the last child if multiple children were added.
        /// </summary>
        /// <param name="child">The display object to add.</param>
        /// <returns>The child that was added, or the last child if multiple children were added.</returns>
        public DisplayObject addChild(DisplayObject child) { return null; }

        /// <summary>
        /// Adds a child to the display list at the specified index, bumping children at equal or greater indexes up one, and setting its parent to this Container.
        /// You can also add multiple children, such as "addChildAt(child1, child2, ..., index);". The index must be between 0 and numChildren.
        /// For example, to add myShape under otherShape in the display list, you could use: container.addChildAt(myShape, container.getChildIndex(otherShape)).
        /// This would also bump otherShape's index up by one.
        /// Returns the last child that was added, or the last child if multiple children were added. Fails silently if the index is out of range.
        /// </summary>
        /// <param name="child">The display object to add.</param>
        /// <param name="index">The index to add the child at.</param>
        /// <returns>The child that was added, or the last child if multiple children were added.</returns>
        public DisplayObject addChildAt(DisplayObject child, JsNumber index) { return null; }

        /// <summary>
        /// Returns a clone of this Container. Some properties that are specific to this instance's current context are reverted to their defaults (for example .parent).
        /// </summary>
        /// <param name="recursive">If true, all of the descendants of this container will be cloned recursively.
        /// If false, the properties of the container will be cloned, but the new instance will not have any children.</param>
        /// <returns>A clone of the current Container instance.</returns>
        public Container clone(bool recursive) { return null; }

        /// <summary>
        /// Returns true if the specified display object either is this container or is a descendent. (child, grandchild, etc) of this container.
        /// </summary>
        /// <param name="child">The DisplayObject to be checked.</param>
        /// <returns>true if the specified display object either is this container or is a descendent.</returns>
        public bool contains(DisplayObject child) { return false; }

        /// <summary>
        /// Draws the display object into the specified context ignoring it's visible, alpha, shadow, and transform.
        /// Returns true if the draw was handled (useful for overriding functionality).
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <param name="ctx">The canvas 2D context object to draw into.</param>
        /// <param name="ignoreCache">Indicates whether the draw operation should ignore any current cache.
        /// For example, used for drawing the cache (to prevent it from simply drawing an existing cache back into itself).</param>
        public void draw(CanvasRenderingContext2D ctx, bool ignoreCache) { }

        /// <summary>
        /// Returns the child at the specified index.
        /// </summary>
        /// <param name="index">The index of the child to return.</param>
        /// <returns>The child at the specified index.</returns>
        public DisplayObject getChildAt(JsNumber index) { return null; }

        /// <summary>
        /// Returns the index of the specified child in the display list, or -1 if it is not in the display list.
        /// </summary>
        /// <param name="child">The child to return the index of.</param>
        /// <returns>The index of the specified child. -1 if the child is not found.</returns>
        public JsNumber getChildIndex(DisplayObject child) { return null; }

        /// <summary>
        /// Returns the number of children in the display list.
        /// </summary>
        /// <returns>The number of children in the display list.</returns>
        public JsNumber getNumChildren() { return null; }

        /// <summary>
        /// Returns an array of all display objects under the specified coordinates that are in this container's display list.
        /// This routine ignores any display objects with mouseEnabled set to false.
        /// The array will be sorted in order of visual depth, with the top-most display object at index 0.
        /// This uses shape based hit detection, and can be an expensive operation to run, so it is best to use it carefully.
        /// For example, if testing for objects under the mouse, test on tick (instead of on mousemove), and only if the mouse's position has changed.
        /// </summary>
        /// <param name="x">The x position in the container to test.</param>
        /// <param name="y">The y position in the container to test.</param>
        /// <returns>An Array of DisplayObjects under the specified coordinates.</returns>
        public JsArray<DisplayObject> getObjectsUnderPoint(JsNumber x, JsNumber y) { return null; }

        /// <summary>
        /// Similar to getObjectsUnderPoint(), but returns only the top-most display object.
        /// This runs significantly faster than getObjectsUnderPoint(), but is still an expensive operation. See getObjectsUnderPoint() for more information.
        /// </summary>
        /// <param name="x">The x position in the container to test.</param>
        /// <param name="y">The y position in the container to test.</param>
        /// <returns>The top-most display object under the specified coordinates.</returns>
        public DisplayObject getObjectUnderPoint(JsNumber x, JsNumber y) { return null; }

        /// <summary>
        /// Tests whether the display object intersects the specified local point (ie. draws a pixel with alpha > 0 at the specified position).
        /// This ignores the alpha, shadow and compositeOperation of the display object, and all transform properties including regX/Y.
        /// </summary>
        /// <param name="x">The x position to check in the display object's local coordinates.</param>
        /// <param name="y">The y position to check in the display object's local coordinates.</param>
        /// <returns>A Boolean indicating whether there is a visible section of a DisplayObject that overlaps the specified coordinates.</returns>
        public bool hitTest(object x, object y) { return false; }

        /// <summary>
        /// Returns true or false indicating whether the display object would be visible if drawn to a canvas.
        /// This does not account for whether it would be visible within the boundaries of the stage.
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <returns>Boolean indicating whether the display object would be visible if drawn to a canvas</returns>
        public bool isVisible() { return false; }

        /// <summary>
        /// Removes all children from the display list.
        /// </summary>
        public void removeAllChildren() { }

        /// <summary>
        /// Removes the specified child from the display list. Note that it is faster to use removeChildAt() if the index is already known.
        /// You can also remove multiple children, such as "removeChild(child1, child2, ...);".
        /// Returns true if the child (or children) was removed, or false if it was not in the display list.
        /// </summary>
        /// <param name="child">The child to remove.</param>
        /// <returns>true if the child (or children) was removed, or false if it was not in the display list.</returns>
        public bool removeChild(DisplayObject child) { return false; }

        /// <summary>
        /// Removes the child at the specified index from the display list, and sets its parent to null.
        /// You can also remove multiple children, such as "removeChildAt(2, 7, ...);".
        /// Returns true if the child (or children) was removed, or false if any index was out of range.
        /// </summary>
        /// <param name="index">The index of the child to remove.</param>
        /// <returns></returns>
        public bool removeChildAt(JsNumber index) { return false; }

        /// <summary>
        /// Changes the depth of the specified child. Fails silently if the child is not a child of this container, or the index is out of range.
        /// </summary>
        /// <param name="child"></param>
        /// <param name="index"></param>
        public void setChildIndex(object child, object index) { }

        /// <summary>
        /// Performs an array sort operation on the child list.
        /// </summary>
        /// <param name="sortFunction">the function to use to sort the child list. See javascript's Array.sort documentation for details.</param>
        public void sortChildren(JsAction sortFunction) { }

        /// <summary>
        /// Swaps the specified children's depth in the display list. Fails silently if either child is not a child of this Container.
        /// </summary>
        /// <param name="child1"></param>
        /// <param name="child2"></param>
        public void swapChildren(object child1, object child2) { }

        /// <summary>
        /// Swaps the children at the specified indexes. Fails silently if either index is out of range.
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public void swapChildrenAt(object index1, object index2) { }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>a string representation of the instance.</returns>
        public JsString toString() { return null; }



    }

    /// <summary>
    /// Known Subclasses:
    /// Container, BitmapAnimation, DOMElement, Text, Bitmap and Shape
    /// DisplayObject is an abstract class that should not be constructed directly. Instead construct subclasses such as Container, Bitmap, and Shape. DisplayObject is the base class for all display classes in the EaselJS library. It defines the core properties and methods that are shared between all display objects.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "DisplayObject", Export = false)]
    public class DisplayObject
    {
        public DisplayObject() { }

        /// <summary>
        /// The alpha (transparency) for this display object. 0 is fully transparent, 1 is fully opaque.
        /// Default Value: 1
        /// </summary>
        public JsNumber alpha { get; set; }

        /// <summary>
        /// If a cache is active, this returns the canvas that holds the cached version of this display object. See cache() for more information. READ-ONLY.
        /// Default Value: null
        /// </summary>
        public HtmlCanvasElement cacheCanvas { get; set; }

        /// <summary>
        /// Returns an ID number that uniquely identifies the current cache for this display object.
        /// This can be used to determine if the cache has changed since a previous check.
        /// Default Value: 0
        /// </summary>
        public JsNumber cacheID { get; set; }

        /// <summary>
        /// The composite operation indicates how the pixels of this display object will be composited with the elements behind it.
        /// If null, this property is inherited from the parent container. For more information, read the whatwg spec on compositing.
        /// Default Value: null
        /// </summary>
        public JsString compositeOperation { get; set; }

        /// <summary>
        /// An array of Filter objects to apply to this display object.
        /// Filters are only applied / updated when cache() or updateCache() is called on the display object, and only apply to the area that is cached.
        /// Default Value: null
        /// </summary>
        public JsArray<Filter> filters { get; set; }

        /// <summary>
        /// A display object that will be tested when checking mouse interactions or testing getObjectsUnderPoint.
        /// The hit area will have its transformation applied relative to this display object's coordinate space
        /// (as though the hit test object were a child of this display object and relative to its regX/Y). It is NOT used for hitTest().
        /// Default Value: null
        /// </summary>
        public DisplayObject hitArea { get; set; }

        /// <summary>
        /// Unique ID for this display object. Makes display objects easier for some uses.
        /// Default Value: -1
        /// </summary>
        public JsNumber id { get; set; }

        /// <summary>
        /// A Shape instance that defines a vector mask (clipping path) for this display object.
        /// The shape's transformation will be applied relative to the display object's parent coordinates (as if it were a child of the parent).
        /// Default Value: null
        /// </summary>
        public Shape mask { get; set; }

        /// <summary>
        /// Indicates whether to include this object when running Stage.getObjectsUnderPoint(), and thus for mouse interactions.
        /// Setting this to true for Containers will cause the Container to be returned (not its children) regardless of whether it's mouseChildren property is true.
        /// Default Value: true
        /// </summary>
        public bool mouseEnabled { get; set; }

        /// <summary>
        /// An optional name for this display object. Included in toString(). Useful for debugging.
        /// Default Value: null
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// A reference to the Container or Stage object that contains this display object, or null if it has not been added to one. READ-ONLY.
        /// Default Value: null
        /// </summary>
        public DisplayObject parent { get; set; }
        //TODO: final

        /// <summary>
        /// The x offset for this display object's registration point. For example, to make a 100x100px Bitmap rotate around it's center, you would set regX and regY to 50.
        /// Default Value: 0
        /// </summary>
        public JsNumber regX { get; set; }

        /// <summary>
        /// The y offset for this display object's registration point. For example, to make a 100x100px Bitmap rotate around it's center, you would set regX and regY to 50.
        /// Default Value: 0
        /// </summary>
        public JsNumber regY { get; set; }

        /// <summary>
        /// The rotation in degrees for this display object.
        /// Default Value: 0
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// The factor to stretch this display object horizontally. For example, setting scaleX to 2 will stretch the display object to twice it's nominal width.
        /// Default Value: 1
        /// </summary>
        public JsNumber scaleX { get; set; }

        /// <summary>
        /// The factor to stretch this display object vertically. For example, setting scaleY to 0.5 will stretch the display object to half it's nominal height.
        /// Default Value: 1
        /// </summary>
        public JsNumber scaleY { get; set; }

        /// <summary>
        /// A shadow object that defines the shadow to render on this display object. Set to null to remove a shadow. If null, this property is inherited from the parent container.
        /// Default Value: null
        /// </summary>
        public Shadow shadow { get; set; }

        /// <summary>
        /// The factor to skew this display object horizontally.
        /// Default Value: 0
        /// </summary>
        public JsNumber skewX { get; set; }

        /// <summary>
        /// The factor to skew this display object vertically.
        /// Default Value: 0
        /// </summary>
        public JsNumber skewY { get; set; }

        /// <summary>
        /// Indicates whether the display object should have it's x & y position rounded prior to drawing it to stage.
        /// Snapping to whole pixels can result in a sharper and faster draw for images (ex. Bitmap & cached objects).
        /// This only applies if the enclosing stage has snapPixelsEnabled set to true.
        /// The snapToPixel property is true by default for Bitmap and BitmapAnimation instances, and false for all other display objects. 
        /// Note that this applies only rounds the display object's local position.
        /// You should ensure that all of the display object's ancestors (parent containers) are also on a whole pixel.
        /// You can do this by setting the ancestors' snapToPixel property to true.
        /// Default Value: false
        /// </summary>
        public bool snapToPixel { get; set; }

        /// <summary>
        /// Suppresses errors generated when using features like hitTest, onPress/onClick, and getObjectsUnderPoint with cross domain content
        /// Default Value: false
        /// </summary>
        public static bool suppressCrossDomainErrors { get; set; }

        /// <summary>
        /// Indicates whether this display object should be rendered to the canvas and included when running Stage.getObjectsUnderPoint().
        /// Default Value: true
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// The x (horizontal) position of the display object, relative to its parent.
        /// Default Value: 0
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y (vertical) position of the display object, relative to its parent.
        /// Default Value: 0
        /// </summary>
        public JsNumber y { get; set; }

        /// <summary>
        /// Draws the display object into a new canvas, which is then used for subsequent draws.
        /// For complex content that does not change frequently (ex. a Container with many children that do not move, or a complex vector Shape),
        /// this can provide for much faster rendering because the content does not need to be re-rendered each tick. The cached display object can be moved, rotated,
        /// faded, etc freely, however if it's content changes, you must manually update the cache by calling updateCache() or cache() again.
        /// You must specify the cache area via the x, y, w, and h parameters.
        /// This defines the rectangle that will be rendered and cached using this display object's coordinates.
        /// For example if you defined a Shape that drew a circle at 0, 0 with a radius of 25, you could call myShape.cache(-25, -25, 50, 50) to cache the full shape.
        /// </summary>
        /// <param name="x">The x coordinate origin for the cache region.</param>
        /// <param name="y"> The y coordinate origin for the cache region.</param>
        /// <param name="width">The width of the cache region.</param>
        /// <param name="height"></param>
        /// <param name="scale">Optional. The scale at which the cache will be created.
        /// For example, if you cache a vector shape using myShape.cache(0,0,100,100,2) then the resulting cacheCanvas will be 200x200 px.
        /// This lets you scale and rotate cached elements with greater fidelity. Default is 1.</param>
        public void cache(JsNumber x, JsNumber y, JsNumber width, JsNumber height, JsNumber scale) { }
        /// <summary>
        /// Draws the display object into a new canvas, which is then used for subsequent draws.
        /// For complex content that does not change frequently (ex. a Container with many children that do not move, or a complex vector Shape),
        /// this can provide for much faster rendering because the content does not need to be re-rendered each tick. The cached display object can be moved, rotated,
        /// faded, etc freely, however if it's content changes, you must manually update the cache by calling updateCache() or cache() again.
        /// You must specify the cache area via the x, y, w, and h parameters.
        /// This defines the rectangle that will be rendered and cached using this display object's coordinates.
        /// For example if you defined a Shape that drew a circle at 0, 0 with a radius of 25, you could call myShape.cache(-25, -25, 50, 50) to cache the full shape.
        /// </summary>
        /// <param name="x">The x coordinate origin for the cache region.</param>
        /// <param name="y"> The y coordinate origin for the cache region.</param>
        /// <param name="width">The width of the cache region.</param>
        /// <param name="height"></param>
        public void cache(JsNumber x, JsNumber y, JsNumber width, JsNumber height) { }

        /// <summary>
        /// Returns a clone of this DisplayObject. Some properties that are specific to this instance's current context are reverted to their defaults (for example .parent).
        /// </summary>
        /// <returns>A clone of the current DisplayObject instance.</returns>
        public DisplayObject clone() { return null; }

        /// <summary>
        /// Draws the display object into the specified context ignoring it's visible, alpha, shadow, and transform.
        /// Returns true if the draw was handled (useful for overriding functionality).
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <param name="ctx">The canvas 2D context object to draw into.</param>
        /// <param name="ignoreCache">Indicates whether the draw operation should ignore any current cache.
        /// For example, used for drawing the cache (to prevent it from simply drawing an existing cache back into itself).</param>
        /// <returns></returns>
        public bool draw(CanvasRenderingContext2D ctx, bool ignoreCache) { return false; }

        /// <summary>
        /// Returns a data URL for the cache, or null if this display object is not cached. Uses cacheID to ensure a new data URL is not generated if the cache has not changed.
        /// </summary>
        /// <returns></returns>
        public JsString getCacheDataURL() { return null; }

        /// <summary>
        /// Generates a concatenated Matrix2D object representing the combined transform of the display object and all of its parent Containers up to the highest level ancestor (usually the stage).
        /// This can be used to transform positions between coordinate spaces, such as with localToGlobal and globalToLocal.
        /// </summary>
        /// <param name="mtx">Optional. A Matrix2D object to populate with the calculated values. If null, a new Matrix object is returned.</param>
        /// <returns>a concatenated Matrix2D object representing the combined transform of the display object and all of its parent Containers up to the highest level ancestor (usually the stage).</returns>
        public Matrix2D getConcatenatedMatrix(Matrix2D mtx) { return null; }
        /// <summary>
        /// Generates a concatenated Matrix2D object representing the combined transform of the display object and all of its parent Containers up to the highest level ancestor (usually the stage).
        /// This can be used to transform positions between coordinate spaces, such as with localToGlobal and globalToLocal.
        /// </summary>
        /// <returns>a concatenated Matrix2D object representing the combined transform of the display object and all of its parent Containers up to the highest level ancestor (usually the stage).</returns>
        public Matrix2D getConcatenatedMatrix() { return null; }

        /// <summary>
        /// Returns a matrix based on this object's transform.
        /// </summary>
        /// <param name="matrix">Optional. A Matrix2D object to populate with the calculated values. If null, a new Matrix object is returned.</param>
        /// <returns>A matrix representing this display object's transform.</returns>
        public Matrix2D getMatrix(Matrix2D matrix) { return null; }
        /// <summary>
        /// Returns a matrix based on this object's transform.
        /// </summary>
        /// <returns>A matrix representing this display object's transform.</returns>
        public Matrix2D getMatrix() { return null; }

        /// <summary>
        /// Returns the stage that this display object will be rendered on, or null if it has not been added to one.
        /// </summary>
        /// <returns>The Stage instance that the display object is a descendent of. null if the DisplayObject has not been added to a Stage.</returns>
        public Stage getStage() { return null; }

        /// <summary>
        /// Transforms the specified x and y position from the global (stage) coordinate space to the coordinate space of the display object.
        /// For example, this could be used to determine the current mouse position within the display object.
        /// Returns a Point instance with x and y properties correlating to the transformed position in the display object's coordinate space.
        /// </summary>
        /// <param name="x">The x position on the stage to transform.</param>
        /// <param name="y">The y position on the stage to transform.</param>
        /// <returns>A Point instance with x and y properties correlating to the transformed position in the display object's coordinate space.</returns>
        public Point globalToLocal(JsNumber x, JsNumber y) { return null; }

        /// <summary>
        /// Tests whether the display object intersects the specified local point (ie. draws a pixel with alpha > 0 at the specified position).
        /// This ignores the alpha, shadow and compositeOperation of the display object, and all transform properties including regX/Y.
        /// </summary>
        /// <param name="x">The x position to check in the display object's local coordinates.</param>
        /// <param name="y">The y position to check in the display object's local coordinates.</param>
        /// <returns>A Boolean indicting whether a visible portion of the DisplayObject intersect the specified local Point.</returns>
        public bool hitTest(JsNumber x, JsNumber y) { return false; }

        /// <summary>
        /// Returns true or false indicating whether the display object would be visible if drawn to a canvas.
        /// This does not account for whether it would be visible within the boundaries of the stage.
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <returns>Boolean indicating whether the display object would be visible if drawn to a canvas</returns>
        public bool isVisible() { return false; }

        /// <summary>
        /// Transforms the specified x and y position from the coordinate space of the display object to the global (stage) coordinate space.
        /// For example, this could be used to position an HTML label over a specific point on a nested display object.
        /// Returns a Point instance with x and y properties correlating to the transformed coordinates on the stage.
        /// </summary>
        /// <param name="x">The x position in the source display object to transform.</param>
        /// <param name="y">The y position in the source display object to transform.</param>
        /// <returns>A Point instance with x and y properties correlating to the transformed coordinates on the stage.</returns>
        public Point localToGlobal(JsNumber x, JsNumber y) { return null; }

        /// <summary>
        /// Transforms the specified x and y position from the coordinate space of this display object to the coordinate space of the target display object.
        /// Returns a Point instance with x and y properties correlating to the transformed position in the target's coordinate space.
        /// Effectively the same as calling var pt = this.localToGlobal(x, y); pt = target.globalToLocal(pt.x, pt.y);
        /// </summary>
        /// <param name="x">The x position in the source display object to transform.</param>
        /// <param name="y">The y position in the source display object to transform.</param>
        /// <param name="target">The target display object to which the coordinates will be transformed.</param>
        /// <returns>Returns a Point instance with x and y properties correlating to the transformed position in the target's coordinate space.</returns>
        public Point localToLocal(JsNumber x, JsNumber y, DisplayObject target) { return null; }

        /// <summary>
        /// Shortcut method to quickly set the transform properties on the display object. All parameters are optional.
        /// Omitted parameters will have the default value set (ex. 0 for x/y, 1 for scaleX/Y).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="scaleX"></param>
        /// <param name="scaleY"></param>
        /// <param name="rotation"></param>
        /// <param name="skewX"></param>
        /// <param name="skewY"></param>
        /// <param name="regX"></param>
        /// <param name="regY"></param>
        /// <returns>Returns this instance. Useful for chaining commands.</returns>
        public DisplayObject setTransform(JsNumber x, JsNumber y, JsNumber scaleX, JsNumber scaleY, JsNumber rotation, JsNumber skewX, JsNumber skewY, JsNumber regX, JsNumber regY) { return null; }

        /// <summary>
        /// Applies this display object's transformation, alpha, globalCompositeOperation, clipping path (mask), and shadow to the specified context.
        /// This is typically called prior to draw.
        /// </summary>
        /// <param name="ctx">The canvas 2D to update.</param>
        public void setupContext(CanvasRenderingContext2D ctx) { }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>a string representation of the instance.</returns>
        public JsString toString() { return null; }

        /// <summary>
        /// Clears the current cache. See cache() for more information.
        /// </summary>
        public void uncache() { }

        /// <summary>
        /// Redraws the display object to its cache. Calling updateCache without an active cache will throw an error.
        /// If compositeOperation is null the current cache will be cleared prior to drawing.
        /// Otherwise the display object will be drawn over the existing cache using the specified compositeOperation.
        /// </summary>
        /// <param name="compositeOperation">The compositeOperation to use, or null to clear the cache and redraw it. whatwg spec on compositing.</param>
        public void updateCache(JsString compositeOperation) { }

        /// <summary>
        /// The onClick callback is called when the user presses down on and then releases the mouse button over this display object.
        /// The handler is passed a single param containing the corresponding MouseEvent instance.
        /// If an onClick handler is set on a container, it will receive the event if any of its children are clicked.
        /// </summary>
        public JsAction<MouseEvent> onClick { get; set; }

        /// <summary>
        /// The onDoubleClick callback is called when the user double clicks over this display object.
        /// The handler is passed a single param containing the corresponding MouseEvent instance.
        /// If an onDoubleClick handler is set on a container, it will receive the event if any of its children are clicked.
        /// </summary>
        public JsAction<MouseEvent> onDoubleClick { get; set; }

        /// <summary>
        /// The onMouseOut callback is called when the user rolls off of the display object.
        /// You must enable this event using stage.enableMouseOver(). The handler is passed a single param containing the corresponding MouseEvent instance.
        /// </summary>
        public JsAction<MouseEvent> onMouseOut { get; set; }

        /// <summary>
        /// The onMouseOver callback is called when the user rolls over the display object.
        /// You must enable this event using stage.enableMouseOver(). The handler is passed a single param containing the corresponding MouseEvent instance.
        /// </summary>
        public JsAction<MouseEvent> onMouseOver { get; set; }

        /// <summary>
        /// The onPress callback is called when the user presses down on their mouse over this display object.
        /// The handler is passed a single param containing the corresponding MouseEvent instance.
        /// You can subscribe to the onMouseMove and onMouseUp callbacks of the event object to receive these events until the user releases the mouse button.
        /// If an onPress handler is set on a container, it will receive the event if any of its children are clicked.
        /// </summary>
        public JsAction<MouseEvent> onPress { get; set; }

        /// <summary>
        /// The onTick callback is called on each display object on a stage whenever the stage updates.
        /// This occurs immediately before the rendering (draw) pass.
        /// When stage.update() is called, first all display objects on the stage have onTick called, then all of the display objects are drawn to stage.
        /// Children will have their onTick called in order of their depth prior to onTick being called on their parent. 
        /// Any parameters passed in to stage.update() are passed on to the onTick() handlers.
        /// For example, if you call stage.update("hello"), all of the display objects with a handler will have onTick("hello") called.
        /// </summary>
        public JsAction onTick { get; set; }

    }

    /// <summary>
    /// extends DisplayObject
    /// This class is still experimental, and more advanced use is likely to be buggy. Please report bugs.
    /// A DOMElement allows you to associate a HTMLElement with the display list.
    /// It will be transformed within the DOM as though it is child of the Container it is added to.
    /// However, it is not rendered to canvas, and as such will retain whatever z-index it has relative to the canvas (ie. it will be drawn in front of or behind the canvas).
    /// The position of a DOMElement is relative to their parent node in the DOM.
    /// It is recommended that the DOM Object be added to a div that also contains the canvas so that they share the same position on the page.
    /// DOMElement is useful for positioning HTML elements over top of canvas content, and for elements that you want to display outside the bounds of the canvas.
    /// For example, a tooltip with rich HTML content.
    /// DOMElement instances are not full EaselJS display objects, and do not participate in EaselJS mouse events or support methods like hitTest.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "DOMElement", Export = false)]
    public class DOMElement : DisplayObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlElement">A reference or id for the DOM element to manage.</param>
        public DOMElement(HtmlElement htmlElement) { }

        /// <summary>
        /// The DOM object to manage.
        /// </summary>
        public HtmlElement htmlElement { get; set; }

        /// <summary>
        /// Not applicable to DOMElement.
        /// </summary>
        public void cache() { }

        /// <summary>
        /// This presently clones the DOMElement instance, but not the associated HTMLElement.
        /// </summary>
        /// <returns>a clone of the DOMElement instance.</returns>
        public HtmlElement clone() { return null; }

        /// <summary>
        /// Draws the display object into the specified context ignoring it's visible, alpha, shadow, and transform.
        /// Returns true if the draw was handled (useful for overriding functionality).
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <param name="ctx">The canvas 2D context object to draw into.</param>
        /// <param name="ignoreCache">Indicates whether the draw operation should ignore any current cache.
        /// For example, used for drawing the cache (to prevent it from simply drawing an existing cache back into itself).</param>
        public bool draw(CanvasRenderingContext2D ctx, bool ignoreCache) { return false; }

        /// <summary>
        /// Not applicable to DOMElement.
        /// </summary>
        public void globalToLocal() { }

        /// <summary>
        /// Returns true or false indicating whether the display object would be visible if drawn to a canvas.
        /// This does not account for whether it would be visible within the boundaries of the stage.
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <returns>Boolean indicating whether the display object would be visible if drawn to a canvas</returns>
        public bool isVisible() { return false; }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>a string representation of the instance.</returns>
        public JsString toString() { return null; }

        /// <summary>
        /// Not applicable to DOMElement.
        /// </summary>
        public void uncache() { }

        /// <summary>
        /// Not applicable to DOMElement.
        /// </summary>
        public void updateCache() { }
    }

    /// <summary>
    /// Base class that all filters should inherit from.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Filter", Export = false)]
    public class Filter
    {
        public Filter() { }

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
        /// Returns a clone of this Filter instance.
        /// </summary>
        /// <returns>A clone of the current Filter instance.</returns>
        public Filter clone() { return null; }

        /// <summary>
        /// Returns a rectangle with values indicating the margins required to draw the filter.
        /// For example, a filter that will extend the drawing area 4 pixels to the left,
        /// and 7 pixels to the right (but no pixels up or down) would return a rectangle with (x=-4, y=0, width=11, height=0).
        /// </summary>
        /// <returns></returns>
        public Rectangle getBounds() { return null; }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>a string representation of the instance.</returns>
        public JsString toString() { return null; }
    }

    /// <summary>
    /// The Graphics class exposes an easy to use API for generating vector drawing instructions and drawing them to a specified context.
    /// Note that you can use Graphics without any dependency on the Easel framework by calling draw() directly,
    /// or it can be used with the Shape object to draw vector graphics within the context of an Easel display list.
    /// Note that all drawing methods in Graphics return the Graphics instance, so they can be chained together.
    /// For example, the following line of code would generate the instructions to draw a rectangle with a red stroke and blue fill, then render it to the specified context2D:
    /// myGraphics.beginStroke("#F00").beginFill("#00F").drawRect(20, 20, 100, 50).draw(myContext2D);
    /// </summary>
    /// <example>
    /// <code>
    /// var g = new Graphics();
    /// g.setStrokeStyle(1);
    /// g.beginStroke(Graphics.getRGB(0,0,0));
    /// g.beginFill(Graphics.getRGB(255,0,0));
    /// g.drawCircle(0,0,3);
    /// var s = new Shape(g);
    /// s.x = 100;
    /// s.y = 100;
    /// stage.addChild(s);
    /// stage.update();
    /// </code>
    /// </example>
    [JsType(JsMode.Prototype, Name = "Graphics", Export = false)]
    public class Graphics
    {
        public Graphics() { }

        /// <summary>
        /// Map of Base64 characters to values. Used by decodePath().
        /// </summary>
        public static object BASE_64 { get; private set; }

        /// <summary>
        /// Maps the familiar ActionScript curveTo() method to the functionally similar quatraticCurveTo() method.
        /// </summary>
        public JsAction curveTo { get; set; }

        /// <summary>
        /// Maps the familiar ActionScript drawRect() method to the functionally similar rect() method.
        /// </summary>
        public JsAction drawRect { get; set; }

        /// <summary>
        /// Maps numeric values for the caps parameter of setStrokeStyle to corresponding string values. This is primarily for use with the tiny API.
        /// The mappings are as follows: 0 to "butt", 1 to "round", and 2 to "square". For example, myGraphics.ss(16, 2) would set the line caps to "square".
        /// </summary>
        public static JsArray<JsString> STROKE_CAPS_MAP { get; private set; }

        /// <summary>
        /// Maps numeric values for the joints parameter of setStrokeStyle to corresponding string values.
        /// This is primarily for use with the tiny API. The mappings are as follows: 0 to "miter", 1 to "round", and 2 to "bevel".
        /// For example, myGraphics.ss(16, 0, 2) would set the line joints to "bevel".
        /// </summary>
        public static JsArray<JsString> STROKE_JOINTS_MAP { get; private set; }

        /// <summary>
        /// Draws an arc defined by the radius, startAngle and endAngle arguments, centered at the position (x, y).
        /// For example arc(100, 100, 20, 0, Math.PI*2) would draw a full circle with a radius of 20 centered at (100, 100). For detailed information, read the whatwg spec.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        /// <param name="startAngle">Measured in radians.</param>
        /// <param name="endAngle">Measured in radians.</param>
        /// <param name="anticlockwise"></param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics arc(JsNumber x, JsNumber y, JsNumber radius, JsNumber startAngle, JsNumber endAngle, bool anticlockwise) { return null; }

        /// <summary>
        /// Draws an arc with the specified control points and radius. For detailed information, read the whatwg spec.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="radius"></param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics arcTo(JsNumber x1, JsNumber y1, JsNumber x2, JsNumber y2, JsNumber radius) { return null; }

        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <param name="repetition">Optional. Indicates whether to repeat the image in the fill area. One of "repeat", "repeat-x", "repeat-y", or "no-repeat". Defaults to "repeat".</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapFill(object image, JsString repetition) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapFill(object image) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <param name="repetition">Optional. Indicates whether to repeat the image in the fill area. One of "repeat", "repeat-x", "repeat-y", or "no-repeat". Defaults to "repeat".</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapFill(HtmlImageElement image, JsString repetition) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapFill(HtmlImageElement image) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <param name="repetition">Optional. Indicates whether to repeat the image in the fill area. One of "repeat", "repeat-x", "repeat-y", or "no-repeat". Defaults to "repeat".</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapFill(HtmlCanvasElement image, JsString repetition) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapFill(HtmlCanvasElement image) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <param name="repetition">Optional. Indicates whether to repeat the image in the fill area. One of "repeat", "repeat-x", "repeat-y", or "no-repeat". Defaults to "repeat".</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapFill(HtmlVideoElement image, JsString repetition) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapFill(HtmlVideoElement image) { return null; }

        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <param name="repetition">Optional. Indicates whether to repeat the image in the fill area. One of "repeat", "repeat-x", "repeat-y", or "no-repeat". Defaults to "repeat".</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapStroke(object image, JsString repetition) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapStroke(object image) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <param name="repetition">Optional. Indicates whether to repeat the image in the fill area. One of "repeat", "repeat-x", "repeat-y", or "no-repeat". Defaults to "repeat".</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapStroke(HtmlImageElement image, JsString repetition) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapStroke(HtmlImageElement image) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <param name="repetition">Optional. Indicates whether to repeat the image in the fill area. One of "repeat", "repeat-x", "repeat-y", or "no-repeat". Defaults to "repeat".</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapStroke(HtmlCanvasElement image, JsString repetition) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapStroke(HtmlCanvasElement image) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <param name="repetition">Optional. Indicates whether to repeat the image in the fill area. One of "repeat", "repeat-x", "repeat-y", or "no-repeat". Defaults to "repeat".</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapStroke(HtmlVideoElement image, JsString repetition) { return null; }
        /// <summary>
        /// Begins a pattern fill using the specified image. This ends the current subpath.
        /// </summary>
        /// <param name="image">The Image, Canvas, or Video object to use as the pattern.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginBitmapStroke(HtmlVideoElement image) { return null; }

        /// <summary>
        /// Begins a fill with the specified color. This ends the current subpath.
        /// </summary>
        /// <param name="color">A CSS compatible color value (ex. "#FF0000" or "rgba(255,0,0,0.5)"). Setting to null will result in no fill.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginFill(JsString color) { return null; }

        /// <summary>
        /// Begins a linear gradient fill defined by the line (x0, y0) to (x1, y1). This ends the current subpath.
        /// For example, the following code defines a black to white vertical gradient ranging from 20px to 120px, and draws a square to display it:
        /// myGraphics.beginLinearGradientFill(["#000","#FFF"], [0, 1], 0, 20, 0, 120).drawRect(20, 20, 120, 120);
        /// </summary>
        /// <param name="colors">An array of CSS compatible color values. For example, ["#F00","#00F"] would define a gradient drawing from red to blue.</param>
        /// <param name="ratios">An array of gradient positions which correspond to the colors.
        /// For example, [0.1, 0.9] would draw the first color to 10% then interpolating to the second color at 90%.</param>
        /// <param name="x0">The position of the first point defining the line that defines the gradient direction and size.</param>
        /// <param name="y0">The position of the first point defining the line that defines the gradient direction and size.</param>
        /// <param name="x1">The position of the second point defining the line that defines the gradient direction and size.</param>
        /// <param name="y1">The position of the second point defining the line that defines the gradient direction and size.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginLinearGradientFill(JsArray<JsString> colors, JsArray<JsNumber> ratios, JsNumber x0, JsNumber y0, JsNumber x1, JsNumber y1) { return null; }

        /// <summary>
        /// Begins a linear gradient stroke defined by the line (x0, y0) to (x1, y1). This ends the current subpath.
        /// For example, the following code defines a black to white vertical gradient ranging from 20px to 120px, and draws a square to display it:
        /// myGraphics.setStrokeStyle(10).beginLinearGradientStroke(["#000","#FFF"], [0, 1], 0, 20, 0, 120).drawRect(20, 20, 120, 120);
        /// </summary>
        /// <param name="colors">An array of CSS compatible color values. For example, ["#F00","#00F"] would define a gradient drawing from red to blue.</param>
        /// <param name="ratios">An array of gradient positions which correspond to the colors.
        /// For example, [0.1, 0.9] would draw the first color to 10% then interpolating to the second color at 90%.</param>
        /// <param name="x0">The position of the first point defining the line that defines the gradient direction and size.</param>
        /// <param name="y0">The position of the first point defining the line that defines the gradient direction and size.</param>
        /// <param name="x1">The position of the second point defining the line that defines the gradient direction and size.</param>
        /// <param name="y1">The position of the second point defining the line that defines the gradient direction and size.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginLinearGradientStroke(object colors, object ratios, object x0, object y0, object x1, object y1) { return null; }

        /// <summary>
        /// Begins a radial gradient fill.
        /// This ends the current subpath. For example, the following code defines a red to blue radial gradient centered at (100, 100),
        /// with a radius of 50, and draws a circle to display it:
        /// myGraphics.beginRadialGradientFill(["#F00","#00F"], [0, 1], 100, 100, 0, 100, 100, 50).drawCircle(100, 100, 50);
        /// </summary>
        /// <param name="colors">An array of CSS compatible color values. For example, ["#F00","#00F"] would define a gradient drawing from red to blue.</param>
        /// <param name="ratios">An array of gradient positions which correspond to the colors.
        /// For example, [0.1, 0.9] would draw the first color to 10% then interpolating to the second color at 90%.</param>
        /// <param name="x0">Center position of the inner circle that defines the gradient.</param>
        /// <param name="y0">Center position of the inner circle that defines the gradient.</param>
        /// <param name="r0">Radius of the inner circle that defines the gradient.</param>
        /// <param name="x1">Center position of the outer circle that defines the gradient.</param>
        /// <param name="y1">Center position of the outer circle that defines the gradient.</param>
        /// <param name="r1">Radius of the outer circle that defines the gradient.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginRadialGradientFill(JsArray<JsString> colors, JsArray<JsNumber> ratios, JsNumber x0, JsNumber y0, JsNumber r0, JsNumber x1, JsNumber y1, JsNumber r1) { return null; }

        /// <summary>
        /// Begins a radial gradient fill.
        /// This ends the current subpath. For example, the following code defines a red to blue radial gradient centered at (100, 100),
        /// with a radius of 50, and draws a circle to display it:
        /// myGraphics.beginRadialGradientFill(["#F00","#00F"], [0, 1], 100, 100, 0, 100, 100, 50).drawCircle(100, 100, 50);
        /// </summary>
        /// <param name="colors">An array of CSS compatible color values. For example, ["#F00","#00F"] would define a gradient drawing from red to blue.</param>
        /// <param name="ratios">An array of gradient positions which correspond to the colors.
        /// For example, [0.1, 0.9] would draw the first color to 10% then interpolating to the second color at 90%.</param>
        /// <param name="x0">Center position of the inner circle that defines the gradient.</param>
        /// <param name="y0">Center position of the inner circle that defines the gradient.</param>
        /// <param name="r0">Radius of the inner circle that defines the gradient.</param>
        /// <param name="x1">Center position of the outer circle that defines the gradient.</param>
        /// <param name="y1">Center position of the outer circle that defines the gradient.</param>
        /// <param name="r1">Radius of the outer circle that defines the gradient.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginRadialGradientStroke(object colors, object ratios, object x0, object y0, object r0, object x1, object y1, object r1) { return null; }

        /// <summary>
        /// Begins a stroke with the specified color. This ends the current subpath.
        /// </summary>
        /// <param name="color">A CSS compatible color value (ex. "#FF0000" or "rgba(255,0,0,0.5)"). Setting to null will result in no stroke.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics beginStroke(object color) { return null; }

        /// <summary>
        /// Draws a bezier curve from the current drawing point to (x, y) using the control points (cp1x, cp1y) and (cp2x, cp2y).
        /// For detailed information, read the whatwg spec. method @bezierCurveTo
        /// </summary>
        /// <param name="cp1x"></param>
        /// <param name="cp1y"></param>
        /// <param name="cp2x"></param>
        /// <param name="cp2y"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics bezierCurveTo(JsNumber cp1x, JsNumber cp1y, JsNumber cp2x, JsNumber cp2y, JsNumber x, JsNumber y) { return null; }

        /// <summary>
        /// Clears all drawing instructions, effectively reseting this Graphics instance.
        /// </summary>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics clear() { return null; }

        /// <summary>
        /// Returns a clone of this Graphics instance.
        /// </summary>
        /// <returns>A clone of the current Graphics instance.</returns>
        public Graphics clone() { return null; }

        /// <summary>
        /// Closes the current path, effectively drawing a line from the current drawing point to the first drawing point specified since the fill or stroke was last set.
        /// </summary>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics closePath() { return null; }

        /// <summary>
        /// Decodes a compact encoded path string into a series of draw instructions.
        /// This format is not intended to be human readable, and is meant for use by authoring tools.
        /// The format uses a base64 character set, with each character representing 6 bits, to define a series of draw commands. 
        /// Each command is comprised of a single "header" character followed by a variable number of alternating x and y position values.
        /// Reading the header bits from left to right (most to least significant): bits 1 to 3 specify the type of operation (0-moveTo, 1-lineTo, 2-quadraticCurveTo, 3-bezierCurveTo, 4-7 unused).
        /// Bit 4 indicates whether position values use 12 bits (2 characters) or 18 bits (3 characters), with a one indicating the latter. Bits 5 and 6 are currently unused. 
        /// Following the header is a series of 2 (moveTo, lineTo), 4 (quadraticCurveTo), or 6 (bezierCurveTo) parameters.
        /// These parameters are alternating x/y positions represented by 2 or 3 characters (as indicated by the 4th bit in the command char).
        /// These characters consist of a 1 bit sign (1 is negative, 0 is positive), followed by an 11 (2 char) or 17 (3 char) bit integer value.
        /// All position values are in tenths of a pixel. Except in the case of move operations, this value is a delta from the previous x or y position (as appropriate). 
        /// For example, the string "A3cAAMAu4AAA" represents a line starting at -150,0 and ending at 150,0. A - bits 000000.
        /// First 3 bits (000) indicate a moveTo operation. 4th bit (0) indicates 2 chars per parameter. n0 - 110111011100.
        /// Absolute x position of -150.0px. First bit indicates a negative value, remaining bits indicate 1500 tenths of a pixel. AA - 000000000000.
        /// Absolute y position of 0. I - 001100. First 3 bits (001) indicate a lineTo operation. 4th bit (1) indicates 3 chars per parameter.
        /// Au4 - 000000101110111000. An x delta of 300.0px, which is added to the previous x value of -150.0px to provide an absolute position of +150.0px. AAA - 000000000000000000. A y delta value of 0.
        /// </summary>
        /// <param name="str">The path string to decode.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics decodePath(JsString str) { return null; }

        /// <summary>
        /// Draws the display object into the specified context ignoring it's visible, alpha, shadow, and transform. Returns true if the draw was handled (useful for overriding functionality).
        /// NOTE: This method is mainly for internal use, though it may be useful for advanced uses.
        /// </summary>
        /// <param name="ctx"> The canvas 2D context object to draw into.</param>
        public void draw(CanvasRenderingContext2D ctx) { }

        /// <summary>
        /// Draws only the path described for this Graphics instance, skipping any non-path instructions, including fill and stroke descriptions.
        /// Used by DisplayObject.clippingPath to draw the clipping path, for example.
        /// </summary>
        /// <param name="ctx">The canvas 2D context object to draw into.</param>
        public void drawAsPath(CanvasRenderingContext2D ctx) { }

        /// <summary>
        /// Draws a circle with the specified radius at (x, y).
        /// </summary>
        /// <param name="x">x coordinate center point of circle.</param>
        /// <param name="y">y coordinate center point of circle.</param>
        /// <param name="radius">Radius of circle.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        /// <example>
        /// <code>
        /// var g = new Graphics();
        /// g.setStrokeStyle(1);
        /// g.beginStroke(Graphics.getRGB(0,0,0));
        /// g.beginFill(Graphics.getRGB(255,0,0));
        /// g.drawCircle(0,0,3);
        /// var s = new Shape(g);
        /// s.x = 100;
        /// s.y = 100;
        /// stage.addChild(s);
        /// stage.update();
        /// </code>
        /// </example>
        public Graphics drawCircle(JsNumber x, JsNumber y, JsNumber radius) { return null; }

        /// <summary>
        /// Draws an ellipse (oval).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics drawEllipse(JsNumber x, JsNumber y, JsNumber w, JsNumber h) { return null; }

        /// <summary>
        /// Draws a star if pointSize is greater than 0 or a regular polygon if pointSize is 0 with the specified number of points.
        /// For example, the following code will draw a familiar 5 pointed star shape centered at 100,
        /// 100 and with a radius of 50: myGraphics.beginFill("#FF0").drawPolyStar(100, 100, 50, 5, 0.6, -90); // -90 makes the first point vertical
        /// </summary>
        /// <param name="x">Position of the center of the shape.</param>
        /// <param name="y">Position of the center of the shape.</param>
        /// <param name="radius">The outer radius of the shape.</param>
        /// <param name="sides">The number of points on the star or sides on the polygon.</param>
        /// <param name="pointSize">The depth or "pointy-ness" of the star points. A pointSize of 0 will draw a regular polygon (no points),
        /// a pointSize of 1 will draw nothing because the points are infinitely pointy.</param>
        /// <param name="angle">The angle of the first point / corner. For example a value of 0 will draw the first point directly to the right of the center.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics drawPolyStar(JsNumber x, JsNumber y, JsNumber radius, JsNumber sides, JsNumber pointSize, JsNumber angle) { return null; }

        /// <summary>
        /// Draws a rounded rectangle with all corners with the specified radius.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="radius">Corner radius.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics drawRoundRect(JsNumber x, JsNumber y, JsNumber w, JsNumber h, JsNumber radius) { return null; }

        /// <summary>
        /// Draws a rounded rectangle with different corner radii. Supports positive and negative corner radii.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="radiusTL">Top left corner radius.</param>
        /// <param name="radiusTR">Top right corner radius.</param>
        /// <param name="radiusBR">Bottom right corner radius.</param>
        /// <param name="radiusBL">Bottom left corner radius.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics drawRoundRectComplex(JsNumber x, JsNumber y, JsNumber w, JsNumber h, JsNumber radiusTL, JsNumber radiusTR, JsNumber radiusBR, JsNumber radiusBL) { return null; }

        /// <summary>
        /// Ends the current subpath, and begins a new one with no fill. Functionally identical to beginFill(null).
        /// </summary>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics endFill() { return null; }

        /// <summary>
        /// Ends the current subpath, and begins a new one with no stroke. Functionally identical to beginStroke(null).
        /// </summary>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics endStroke() { return null; }

        /// <summary>
        /// Returns a CSS compatible color string based on the specified HSL numeric color values in the format "hsla(360,100,100,1.0)",
        /// or if alpha is null then in the format "hsl(360,100,100)". For example, Graphics.getHSL(150, 100, 70) will return "hsl(150,100,70)".
        /// </summary>
        /// <param name="hue">The hue component for the color, between 0 and 360.</param>
        /// <param name="saturation">The saturation component for the color, between 0 and 100.</param>
        /// <param name="lightness">The lightness component for the color, between 0 and 100.</param>
        /// <param name="alpha">Optional. The alpha component for the color where 0 is fully transparent and 1 is fully opaque.</param>
        /// <returns></returns>
        public static JsString getHSL(JsNumber hue, JsNumber saturation, JsNumber lightness, JsNumber alpha) { return null; }
        /// <summary>
        /// Returns a CSS compatible color string based on the specified HSL numeric color values in the format "hsla(360,100,100,1.0)",
        /// or if alpha is null then in the format "hsl(360,100,100)". For example, Graphics.getHSL(150, 100, 70) will return "hsl(150,100,70)".
        /// </summary>
        /// <param name="hue">The hue component for the color, between 0 and 360.</param>
        /// <param name="saturation">The saturation component for the color, between 0 and 100.</param>
        /// <param name="lightness">The lightness component for the color, between 0 and 100.</param>
        /// <returns></returns>
        public static JsString getHSL(JsNumber hue, JsNumber saturation, JsNumber lightness) { return null; }

        /// <summary>
        /// Returns a CSS compatible color string based on the specified RGB numeric color values in the format "rgba(255,255,255,1.0)",
        /// or if alpha is null then in the format "rgb(255,255,255)". For example, Graphics.getRGB(50, 100, 150, 0.5) will return "rgba(50,100,150,0.5)".
        /// It also supports passing a single hex color value as the first param, and an optional alpha value as the second param.
        /// For example, Graphics.getRGB(0xFF00FF, 0.2) will return "rgba(255,0,255,0.2)".
        /// </summary>
        /// <param name="r">The red component for the color, between 0 and 0xFF (255).</param>
        /// <param name="g">The green component for the color, between 0 and 0xFF (255).</param>
        /// <param name="b">The blue component for the color, between 0 and 0xFF (255).</param>
        /// <param name="alpha">Optional. The alpha component for the color where 0 is fully transparent and 1 is fully opaque.</param>
        /// <returns></returns>
        public static JsString getRGB(JsNumber r, JsNumber g, JsNumber b, JsNumber alpha) { return null; }
        /// <summary>
        /// Returns a CSS compatible color string based on the specified RGB numeric color values in the format "rgba(255,255,255,1.0)",
        /// or if alpha is null then in the format "rgb(255,255,255)". For example, Graphics.getRGB(50, 100, 150, 0.5) will return "rgba(50,100,150,0.5)".
        /// It also supports passing a single hex color value as the first param, and an optional alpha value as the second param.
        /// For example, Graphics.getRGB(0xFF00FF, 0.2) will return "rgba(255,0,255,0.2)".
        /// </summary>
        /// <param name="r">The red component for the color, between 0 and 0xFF (255).</param>
        /// <param name="g">The green component for the color, between 0 and 0xFF (255).</param>
        /// <param name="b">The blue component for the color, between 0 and 0xFF (255).</param>
        /// <returns></returns>
        public static JsString getRGB(JsNumber r, JsNumber g, JsNumber b) { return null; }

        /// <summary>
        /// Draws a line from the current drawing point to the specified position, which become the new current drawing point. For detailed information, read the whatwg spec.
        /// </summary>
        /// <param name="x">The x coordinate the drawing point should draw to.</param>
        /// <param name="y">The y coordinate the drawing point should draw to.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics lineTo(JsNumber x, JsNumber y) { return null; }

        /// <summary>
        /// Moves the drawing point to the specified position.
        /// </summary>
        /// <param name="x">The x coordinate the drawing point should move to.</param>
        /// <param name="y">The y coordinate the drawing point should move to.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics moveTo(JsNumber x, JsNumber y) { return null; }

        /// <summary>
        /// Draws a quadratic curve from the current drawing point to (x, y) using the control point (cpx, cpy). For detailed information, read the whatwg spec.
        /// </summary>
        /// <param name="cpx"></param>
        /// <param name="cpy"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics quadraticCurveTo(JsNumber cpx, JsNumber cpy, JsNumber x, JsNumber y) { return null; }

        /// <summary>
        /// Draws a rectangle at (x, y) with the specified width and height using the current fill and/or stroke. For detailed information, read the whatwg spec.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w">Width of the rectangle</param>
        /// <param name="h">Height of the rectangle</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics rect(JsNumber x, JsNumber y, JsNumber w, JsNumber h) { return null; }

        /// <summary>
        /// Sets the stroke style for the current subpath. Like all drawing methods, this can be chained,
        /// so you can define the stroke style and color in a single line of code like so: myGraphics.setStrokeStyle(8,"round").beginStroke("#F00");
        /// </summary>
        /// <param name="thickness">The width of the stroke.</param>
        /// <param name="caps">Optional. Indicates the type of caps to use at the end of lines. One of butt, round, or square.
        /// Defaults to "butt". Also accepts the values 0 (butt), 1 (round), and 2 (square) for use with the tiny API.</param>
        /// <param name="joints">Optional. Specifies the type of joints that should be used where two lines meet. One of bevel, round, or miter.
        /// Defaults to "miter". Also accepts the values 0 (miter), 1 (round), and 2 (bevel) for use with the tiny API.</param>
        /// <param name="miter"> Optional. If joints is set to "miter", then you can specify a miter limit ratio which controls at what point a mitered joint will be clipped.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics setStrokeStyle(object thickness, object caps, object joints, object miter) { return null; }
        /// <summary>
        /// Sets the stroke style for the current subpath. Like all drawing methods, this can be chained,
        /// so you can define the stroke style and color in a single line of code like so: myGraphics.setStrokeStyle(8,"round").beginStroke("#F00");
        /// </summary>
        /// <param name="thickness">The width of the stroke.</param>
        /// <param name="caps">Optional. Indicates the type of caps to use at the end of lines. One of butt, round, or square.
        /// Defaults to "butt". Also accepts the values 0 (butt), 1 (round), and 2 (square) for use with the tiny API.</param>
        /// <param name="joints">Optional. Specifies the type of joints that should be used where two lines meet. One of bevel, round, or miter.
        /// Defaults to "miter". Also accepts the values 0 (miter), 1 (round), and 2 (bevel) for use with the tiny API.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics setStrokeStyle(object thickness, object caps, object joints) { return null; }
        /// <summary>
        /// Sets the stroke style for the current subpath. Like all drawing methods, this can be chained,
        /// so you can define the stroke style and color in a single line of code like so: myGraphics.setStrokeStyle(8,"round").beginStroke("#F00");
        /// </summary>
        /// <param name="thickness">The width of the stroke.</param>
        /// <param name="caps">Optional. Indicates the type of caps to use at the end of lines. One of butt, round, or square.
        /// Defaults to "butt". Also accepts the values 0 (butt), 1 (round), and 2 (square) for use with the tiny API.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics setStrokeStyle(object thickness, object caps) { return null; }
        /// <summary>
        /// Sets the stroke style for the current subpath. Like all drawing methods, this can be chained,
        /// so you can define the stroke style and color in a single line of code like so: myGraphics.setStrokeStyle(8,"round").beginStroke("#F00");
        /// </summary>
        /// <param name="thickness">The width of the stroke.</param>
        /// <returns>The Graphics instance the method is called on (useful for chaining calls.)</returns>
        public Graphics setStrokeStyle(object thickness) { return null; }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>a string representation of the instance.</returns>
        public JsString toString() { return null; }
    }

    /// <summary>
    /// Represents an affine transformation matrix, and provides tools for constructing and concatenating matrixes.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Matrix2D", Export = false)]
    public class Matrix2D
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Specifies the a property for the new matrix.</param>
        /// <param name="b">Specifies the b property for the new matrix.</param>
        /// <param name="c">Specifies the c property for the new matrix.</param>
        /// <param name="d">Specifies the d property for the new matrix.</param>
        /// <param name="tx">Specifies the tx property for the new matrix.</param>
        /// <param name="ty">Specifies the ty property for the new matrix.</param>
        public Matrix2D(JsNumber a, JsNumber b, JsNumber c, JsNumber d, JsNumber tx, JsNumber ty) { }

        /// <summary>
        /// Position (0, 0) in a 3x3 affine transformation matrix.
        /// </summary>
        public JsNumber a { get; set; }

        /// <summary>
        /// Property representing the alpha that will be applied to a display object.
        /// This is not part of matrix operations, but is used for operations like getConcatenatedMatrix to provide concatenated alpha values.
        /// </summary>
        public JsNumber alpha { get; set; }

        /// <summary>
        /// Position (2, 0) in a 3x3 affine transformation matrix.
        /// </summary>
        public JsNumber atx { get; set; }

        /// <summary>
        /// Position (0, 1) in a 3x3 affine transformation matrix.
        /// </summary>
        public JsNumber b { get; set; }

        /// <summary>
        /// Position (1, 0) in a 3x3 affine transformation matrix.
        /// </summary>
        public JsNumber c { get; set; }

        /// <summary>
        /// Property representing the compositeOperation that will be applied to a display object.
        /// This is not part of matrix operations, but is used for operations like getConcatenatedMatrix to provide concatenated compositeOperation values.
        /// You can find a list of valid composite operations at: https://developer.mozilla.org/en/Canvas_tutorial/Compositing
        /// </summary>
        public JsString compositeOperation { get; set; }

        /// <summary>
        /// Position (1, 1) in a 3x3 affine transformation matrix.
        /// </summary>
        public JsNumber d { get; set; }

        /// <summary>
        /// Multiplier for converting degrees to radians. Used internally by Matrix2D. Read-only.
        /// </summary>
        public static JsNumber DEG_TO_RAD { get; private set; }

        /// <summary>
        /// An identity matrix, representing a null transformation. Read-only.
        /// </summary>
        public static Matrix2D identity { get; private set; }

        /// <summary>
        /// Property representing the shadow that will be applied to a display object.
        /// This is not part of matrix operations, but is used for operations like getConcatenatedMatrix to provide concatenated shadow values.
        /// </summary>
        public Shadow shadow { get; set; }

        /// <summary>
        /// Position (2, 1) in a 3x3 affine transformation matrix.
        /// </summary>
        public JsNumber ty { get; set; }

        /// <summary>
        /// Appends the specified matrix properties with this matrix. All parameters are required.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="tx"></param>
        /// <param name="ty"></param>
        /// <returns>This matrix. Useful for chaining method calls.</returns>
        public Matrix2D append(JsNumber a, JsNumber b, JsNumber c, JsNumber d, JsNumber tx, JsNumber ty) { return null; }

        /// <summary>
        /// Appends the specified matrix with this matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns>This matrix. Useful for chaining method calls.</returns>
        public Matrix2D appendMatrix(Matrix2D matrix) { return null; }

        /// <summary>
        /// Reinitializes all matrix properties to those specified.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="tx"></param>
        /// <param name="ty"></param>
        /// <param name="alpha">desired alpha value</param>
        /// <param name="shadow">desired shadow value</param>
        /// <param name="compositeOperation">desired composite operation value</param>
        /// <returns>This matrix. Useful for chaining method calls.</returns>
        public Matrix2D appendProperties (JsNumber a, JsNumber b, JsNumber c, JsNumber d, JsNumber tx, JsNumber ty,JsNumber alpha ,Shadow shadow ,JsString compositeOperation ) { return null; }

        /// <summary>
        /// Generates matrix properties from the specified display object transform properties, and appends them with this matrix. For example,
        /// you can use this to generate a matrix from a display object: var mtx = new Matrix2D(); mtx.appendTransform(o.x, o.y, o.scaleX, o.scaleY, o.rotation);
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="scaleX"></param>
        /// <param name="scaleY"></param>
        /// <param name="rotation"></param>
        /// <param name="skewX"></param>
        /// <param name="skewY"></param>
        /// <param name="regX">Optional</param>
        /// <param name="regY">Optional</param>
        /// <returns>This matrix. Useful for chaining method calls.</returns>
        public Matrix2D appendTransform(JsNumber x, JsNumber y, JsNumber scaleX, JsNumber scaleY, JsNumber rotation, JsNumber skewX, JsNumber skewY, JsNumber regX, JsNumber regY) { return null; }
        /// <summary>
        /// Generates matrix properties from the specified display object transform properties, and appends them with this matrix. For example,
        /// you can use this to generate a matrix from a display object: var mtx = new Matrix2D(); mtx.appendTransform(o.x, o.y, o.scaleX, o.scaleY, o.rotation);
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="scaleX"></param>
        /// <param name="scaleY"></param>
        /// <param name="rotation"></param>
        /// <param name="skewX"></param>
        /// <param name="skewY"></param>
        /// <param name="regX">Optional</param>
        /// <returns>This matrix. Useful for chaining method calls.</returns>
        public Matrix2D appendTransform(JsNumber x, JsNumber y, JsNumber scaleX, JsNumber scaleY, JsNumber rotation, JsNumber skewX, JsNumber skewY, JsNumber regX) { return null; }
        /// <summary>
        /// Generates matrix properties from the specified display object transform properties, and appends them with this matrix. For example,
        /// you can use this to generate a matrix from a display object: var mtx = new Matrix2D(); mtx.appendTransform(o.x, o.y, o.scaleX, o.scaleY, o.rotation);
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="scaleX"></param>
        /// <param name="scaleY"></param>
        /// <param name="rotation"></param>
        /// <param name="skewX"></param>
        /// <param name="skewY"></param>
        /// <returns>This matrix. Useful for chaining method calls.</returns>
        public Matrix2D appendTransform(JsNumber x, JsNumber y, JsNumber scaleX, JsNumber scaleY, JsNumber rotation, JsNumber skewX, JsNumber skewY) { return null; }

        /// <summary>
        /// Returns a clone of the Matrix2D instance.
        /// </summary>
        /// <returns>a clone of the Matrix2D instance.</returns>
        public Matrix2D clone() { return null; }

        /// <summary>
        /// Decomposes the matrix into transform properties (x, y, scaleX, scaleY, and rotation).
        /// Note that this these values may not match the transform properties you used to generate the matrix, though they will produce the same visual results.
        /// </summary>
        /// <param name="target">The object to apply the transform properties to. If null, then a new object will be returned.</param>
        /// <returns>This matrix. Useful for chaining method calls.</returns>
        public Matrix2D decompose (object target ) { return null; }


    }

    [JsType(JsMode.Prototype, Name = "Shape", Export = false)]
    public class Shape
    {

    }

    [JsType(JsMode.Prototype, Name = "Shadow", Export = false)]
    public class Shadow
    {

    }

    [JsType(JsMode.Prototype, Name = "SpriteSheet", Export = false)]
    public class SpriteSheet
    {

    }

    [JsType(JsMode.Prototype, Name = "Stage", Export = false)]
    public class Stage
    {

    }

    [JsType(JsMode.Prototype, Name = "Rectangle", Export = false)]
    public class Rectangle
    {

    }

    [JsType(JsMode.Prototype, Name = "Point", Export = false)]
    public class Point
    {

    }



    [JsType(JsMode.Prototype, Name = "MouseEvent", Export = false)]
    public class MouseEvent
    {

    }

}
