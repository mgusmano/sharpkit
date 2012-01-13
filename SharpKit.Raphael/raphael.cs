using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.Raphael
{
    #region Animation

    [JsType(JsMode.Prototype)]
    public class Animation
    {
        /// <summary>
        /// Creates a copy of existing animation object with given delay.
        /// </summary>
        /// <param name="delay">number of ms to pass between animation start and actual animation</param>
        /// <returns>new altered Animation object</returns>
        /// <example>
        /// <code>
        /// var anim = Raphael.animation({cx: 10, cy: 20}, 2e3);
        /// circle1.animate(anim); // run the given animation immediately
        /// circle2.animate(anim.delay(500)); // run the given animation after 500 ms
        /// </code>
        /// </example>
        public static object delay(JsNumber delay) { return null; }
        /// <summary>
        /// Creates a copy of existing animation object with given repetition.
        /// </summary>
        /// <param name="repeat">number iterations of animation. For infinite animation pass Infinity</param>
        /// <returns>new altered Animation object</returns>
        public static object repeat(JsNumber repeat) { return null; }
    }

    #endregion

    #region Element

    [JsType(JsMode.Prototype)]
    public class Element
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="params">final attributes for the element, see also Element.attr</param>
        /// <param name="ms">number of milliseconds for animation to run</param>
        /// <param name="easing"></param>
        /// <param name="callback"></param>
        /// <returns>original element</returns>
        public static object animate(object @params, JsNumber ms, string easing, JsFunction callback)
        {
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="params">final attributes for the element, see also Element.attr</param>
        /// <param name="ms">number of milliseconds for animation to run</param>
        /// <param name="easing"></param>
        /// <param name="animation"></param>
        /// <returns>original element</returns>
        public static object animate(object @params, JsNumber ms, string easing, object animation)
        {
            return null;
        }
        /// <summary>
        /// Acts similar to Element.animate, but ensure that given animation runs in sync with another given element.
        /// </summary>
        /// <param name="element">element to sync with</param>
        /// <param name="anim">animation to sync with</param>
        /// <param name="params">final attributes for the element, see also Element.attr</param>
        /// <param name="ms">number of milliseconds for animation to run</param>
        /// <param name="easing">easing type. Accept on of Raphael.easing_formulas or CSS format: cubic‐bezier(XX, XX, XX, XX)</param>
        /// <param name="callback">callback function. Will be called at the end of animation.</param>
        /// <returns></returns>
        public static object animateWith(object element, object anim, object @params, JsNumber ms, string easing, JsFunction callback)
        {
            return null;
        }
        /// <summary>
        /// Acts similar to Element.animate, but ensure that given animation runs in sync with another given element.
        /// </summary>
        /// <param name="element">element to sync with</param>
        /// <param name="anim">animation to sync with</param>
        /// <param name="animation">animation object, see Raphael.animation</param>
        /// <returns></returns>
        public static object animateWith(object element, object anim, object animation)
        {
            return null;
        }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="attrName">attribute’s name</param>
        /// <param name="value">value</param>
        /// <returns></returns>
        public static Element attr(string attrName, string value)
        {
            return null;
        }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="params">object of name/value pairs</param>
        /// <returns></returns>
        public static Element attr(object @params)
        {
            return null;
        }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="params">object of name/value pairs</param>
        /// <returns></returns>
        public static Element attr(ElementAttributes @params)
        {
            return null;
        }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="attrName">attribute’s name</param>
        /// <returns></returns>
        public static object attr(string attrName)
        {
            return null;
        }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="attrNames">in this case method returns array of current values for given attribute names</param>
        /// <returns></returns>
        public static JsArray attr(JsArray attrNames)
        {
            return null;
        }

        /// <summary>
        /// Adds event handler for click for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object click(JsAction handler)
        {
            return null;
        }
        public static object clone()
        {
            return null;
        }
        /// <summary>
        /// Adds or retrieves given value asociated with given key. See also Element.removeData
        /// </summary>
        /// <param name="key">any, key to store data</param>
        /// <param name="value">value to store</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// for (var i = 0, i &lt; 5, i++) {
        /// paper.circle(10 + 15 * i, 10, 10)
        /// .attr({fill: "#000"})
        /// .data("i", i)
        /// .click(function () {
        /// alert(this.data("i"));
        /// });
        /// </code>
        /// </example>
        public static object data(string key, object value)
        {
            return null;
        }
        //there is anathor return for specipic case. how should i write it? olso there is a function for exemple - what should i do with it?
        /// <summary>
        /// Adds event handler for double click for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object dblclick(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handlers for drag of the element.
        /// </summary>
        /// <param name="onmove">handler for moving</param>
        /// <param name="onstart">handler for drag start</param>
        /// <param name="onend">handler for drag end</param>
        /// <param name="mcontext">context for moving handler</param>
        /// <param name="scontext">context for drag start handler</param>
        /// <param name="econtext">context for drag end handler</param>
        /// <returns></returns>
        public static object drag(JsAction onmove, JsAction onstart, JsAction onend, object mcontext, object scontext, object econtext)
        {
            return null;
        }
        //there are some X&Y stuff what should i do with them?
        /// <summary>
        /// Return bounding box for a given element
        /// </summary>
        /// <param name="isWithoutTransform">flag, true if you want to have bounding box before transformations. Default is false.</param>
        /// <returns></returns>
        public static object getBBox(object isWithoutTransform)
        {
            return null;
        }
        // object=boolean

        //grey box
        /// <summary>
        /// Return coordinates of the point located at the given length on the given path. Only works for element of “path” type.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static object getPointAtLength(JsNumber length)
        {
            return null;
        }
        //grey box
        /// <summary>
        /// Return subpath of a given element from given length to given length. Only works for element of “path” type.
        /// </summary>
        /// <param name="from">position of the start of the segment</param>
        /// <param name="to">position of the end of the segment</param>
        /// <returns></returns>
        public static string getSubpath(JsNumber from, JsNumber to)
        {
            return null;
        }
        /// <summary>
        /// Returns length of the path in pixels. Only works for element of “path” type.
        /// </summary>
        /// <returns></returns>
        public static JsNumber getTotalLength()
        {
            return null;
        }
        /// <summary>
        /// Return set of elements that create glow-like effect around given element. See Paper.set. Note: Glow is not connected to the element. If you change element attributes it won’t adjust itself.
        /// </summary>
        /// <param name="glow">parameters object with all properties optional:</param>
        /// <returns></returns>
        public static object glow(object glow)
        {
            return null;
        }
        // grey box
        /// <summary>
        /// Makes element invisible. See Element.show.
        /// </summary>
        /// <returns></returns>
        public static object hide()
        {
            return null;
        }
        /// <summary>
        /// Adds event handlers for hover for the element.
        /// </summary>
        /// <param name="f_in">handler for hover in</param>
        /// <param name="f_out">handler for hover out</param>
        /// <param name="icontext">context for hover in handler</param>
        /// <param name="ocontext">context for hover out handler</param>
        /// <returns></returns>
        public static object hover(JsAction f_in, JsAction f_out, object icontext, object ocontext)
        {
            return null;
        }
        //elemnt.id?!?!
        /// <summary>
        /// Inserts current object after the given one.
        /// </summary>
        /// <returns></returns>
        public static object insertAfter()
        {
            return null;
        }
        /// <summary>
        /// Inserts current object before the given one.
        /// </summary>
        /// <returns></returns>
        public static object insertBefore()
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mousedown for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object mousedown(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mousemove for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object mousemove(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mouseout for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object mouseout(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mouseover for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object mouseover(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mouseup for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object mouseup(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Shortcut for assigning event handler for drag.over.[id] event, where id is id of the element (see Element.id).
        /// </summary>
        /// <param name="F">handler for event, first argument would be the element you are dragging over</param>
        public static void OnDragOver(JsAction F) { }
        /// <summary>
        /// Internal reference to “paper” where object drawn. Mainly for use in plugins and element extensions.
        /// </summary> 
        ///<example>
        ///usage
        ///<code>
        ///Raphael.el.cross = function () {
        ///this.attr({fill: "red"});
        ///this.paper.path("M10,10L50,50M50,10L10,50")
        /// .attr({stroke: "red"});
        /// </code>
        /// </example>
        public static Paper paper { get; set; }
        /// <summary>
        /// Reference to the next element in the hierarchy.
        /// </summary>
        public static Next next { get; set; }
        /// <summary>
        /// Gives you a reference to the DOM object, so you can assign event handlers or just mess around. Note: Don’t mess with it.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // draw a circle at coordinate 10,10 with radius of 10
        /// var c = paper.circle(10, 10, 10);
        /// c.node.onclick = function () {
        /// c.attr("fill", "red");};
        /// </code>
        /// </example>
        public static Node node { get; set; }

        /// <summary>
        /// Stops animation of the element with ability to resume it later on.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <returns></returns>
        public static object pause(object anim)
        {
            return null;
        }
        /// <summary>
        /// Reference to the previous element in the hierarchy.
        /// </summary>
        public static Prev prev { get; set; }
        /// <summary>
        /// Internal reference to Raphael object. In case it is not available.
        /// </summary>
        public static Raphael rapheal { get; set; }

        /// <summary>
        /// Resumes animation if it was paused with Element.pause method.
        /// </summary>
        /// <param name="key">animation object</param>
        /// <returns></returns>
        public static object removeData(string key)
        {
            return null;
        }
        /// <summary>
        /// Adds rotation by given angle around given point to the list of transformations of the element.
        /// </summary>
        /// <param name="deg">angle in degrees</param>
        /// <param name="cx">x coordinate of the centre of rotation</param>
        /// <param name="cy">y coordinate of the centre of rotation</param>
        /// <returns></returns>
        public static object rotate(JsNumber deg, JsNumber cx, JsNumber cy)
        {
            return null;
        }
        /// <summary>
        /// Adds scale by given amount relative to given point to the list of transformations of the element.
        /// </summary>
        /// <param name="sx">horisontal scale amount</param>
        /// <param name="sy">vertical scale amount</param>
        /// <param name="cx">x coordinate of the centre of scale</param>
        /// <param name="cy">y coordinate of the centre of scale</param>
        /// <returns></returns>
        public static object scale(JsNumber sx, JsNumber sy, JsNumber cx, JsNumber cy)
        {
            return null;
        }
        //If cx & cy aren’t specified centre of the shape is used instead.
        /// <summary>
        /// Sets the status of animation of the element in milliseconds. Similar to Element.status method.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <param name="value">number of milliseconds from the beginning of the animation</param>
        /// <returns>number of milliseconds from the beginning of the animation</returns>
        public static object setTime(object anim, JsNumber value)
        {
            return null;
        }
        /// <summary>
        /// Makes element visible. See Element.hide.
        /// </summary>
        /// <returns></returns>
        public static object show()
        {
            return null;
        }
        /// <summary>
        /// Gets or sets the status of animation of the element.
        /// </summary>
        /// <returns>status if anim is not specified. Array of objects in format:</returns>
        public static JsArray<AnimationStatus> status()
        {
            return null;
        }
        /// <summary>
        /// Gets or sets the status of animation of the element.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <returns>status if anim is not specified. Array of objects in format:</returns>
        public static AnimationStatus status(Animation anim)
        {
            return null;
        }

        /// <summary>
        /// Gets or sets the status of animation of the element.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <param name="value">0 – 1. If specified, method works like a setter and sets the status of a given animation to the value. This will cause animation to jump to the given position.</param>
        /// <returns>status</returns>
        public static JsNumber status(Animation anim, JsNumber value)
        {
            return null;
        }
        /// <summary>
        /// Stops animation of the element.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <returns>original element</returns>
        public static object stop(object anim)
        {
            return null;
        }
        /// <summary>
        /// Moves the element so it is the furthest from the viewer’s eyes, behind other elements.
        /// </summary>
        /// <returns></returns>
        public static object toBack()
        {
            return null;
        }
        /// <summary>
        /// Moves the element so it is the closest to the viewer’s eyes, on top of other elements.
        /// </summary>
        /// <returns></returns>
        public static object toFront()
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for touchcancel for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object touchcancel(JsFunction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for touchend for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object touchend(JsFunction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for touchmove for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object touchmove(JsFunction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for touchstart for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object touchstart(JsFunction handler)
        {
            return null;
        }

        // Element.transform([tstr])??

        /// <summary>
        /// Adds translation by given amount to the list of transformations of the element.
        /// </summary>
        /// <param name="dx">horisontal shift</param>
        /// <param name="dy">vertical shift</param>
        /// <returns></returns>
        public static object translate(JsNumber dx, JsNumber dy)
        {
            return null;
        }
        /// <summary>
        /// Removes event handler for click for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object unclick(JsFunction handler)
        {
            return null;
        }
        /// <summary>
        /// Removes event handler for double click for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object undblclick(JsFunction handler)
        {
            return null;
        }
        /// <summary>
        /// Removes event handlers for hover for the element.
        /// </summary>
        /// <param name="f_in">handler for hover in</param>
        /// <param name="f_out">handler for hover out</param>
        /// <returns></returns>
        public static object unhover(JsFunction f_in, JsFunction f_out)
        {
            return null;
        }
        /// <summary>
        /// Removes all drag event handlers from given element.
        /// </summary>
        public static void undrag() { }

        /// <summary>
        /// Removes event handler for mousedown for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object unmousedown(JsFunction handler)
        {
            return null;
        }
        /// <summary>
        ///Removes event handler for mousemove for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object unmousemove(JsFunction handler)
        {
            return null;
        }
        /// <summary>
        //Removes event handler for mouseout for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object unmouseout(JsFunction handler)
        {
            return null;
        }

        /// <summary>
        //Removes event handler for unmouseover for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object unmouseover(JsFunction handler)
        {
            return null;
        }

        /// <summary>
        //Removes event handler for unmouseup for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object unmouseup(JsFunction handler)
        {
            return null;
        }

        /// <summary>
        //Removes event handler for untouchcancel for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object untouchcancel(JsFunction handler)
        {
            return null;
        }

        /// <summary>
        //Removes event handler for untouchend for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object untouchend(JsFunction handler)
        {
            return null;
        }

        /// <summary>
        //Removes event handler for untouchmove for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object untouchmove(JsFunction handler)
        {
            return null;
        }

        /// <summary>
        //Removes event handler for untouchstart for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public static object untouchstart(JsFunction handler)
        {
            return null;
        }



    }
    #endregion

    #region AnimationStatus

    [JsType(JsMode.Json)]
    public class AnimationStatus
    {
        public Animation anim { get; set; }
        public JsNumber status { get; set; }
    }
    #endregion

    #region ElementAttributes

    [JsType(JsMode.Json)]
    public class ElementAttributes
    {
        /// <summary>
        /// arrowhead on the end of the path. The format for string is &lt;type&gt;[-&lt;width>[-&lt;length&gt;]]. Possible types: classic, block, open, oval, diamond, none, width: wide, narrow, midium, length: long, short, midium.
        /// </summary>
        [JsProperty(Name = "'arrow-end'")]
        public string arrow_end { get; set; }
        /// <summary>
        /// comma or space separated values: x, y, width and height
        /// </summary>
        [JsProperty(Name = "'clip-rect'")]
        public string clip_rect { get; set; }
        /// <summary>
        /// CSS type of the cursor
        /// </summary>
        public string cursor { get; set; }
        /// <summary>
        /// the x-axis coordinate of the center of the circle, or ellipse
        /// </summary>
        public JsNumber cx { get; set; }
        /// <summary>
        /// the y-axis coordinate of the center of the circle, or ellipse
        /// </summary>
        public JsNumber cy { get; set; }
        /// <summary>
        /// colour, gradient or image
        /// </summary>
        public string fill { get; set; }
        [JsProperty(Name = "'fill-opacity'")]
        public JsNumber fill_opacity { get; set; }
        public string font { get; set; }
        [JsProperty(Name = "'font-family'")]
        public string font_family { get; set; }
        /// <summary>
        /// font size in pixels
        /// </summary>
        [JsProperty(Name = "'font-size'")]
        public JsNumber font_size { get; set; }
        [JsProperty(Name = "'font-weight'")]
        public string font_weight { get; set; }
        public JsNumber height { get; set; }
        /// <summary>
        /// URL, if specified element behaves as hyperlink
        /// </summary>
        public string href { get; set; }
        public JsNumber opacity { get; set; }
        /// <summary>
        /// SVG path string format
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// radius of the circle, ellipse or rounded corner on the rect
        /// </summary>
        public JsNumber r { get; set; }
        /// <summary>
        /// horisontal radius of the ellipse
        /// </summary>
        public JsNumber rx { get; set; }
        /// <summary>
        /// vertical radius of the ellipse
        /// </summary>
        public JsNumber ry { get; set; }
        /// <summary>
        /// image URL, only works for Element.image element
        /// </summary>
        public string src { get; set; }
        /// <summary>
        /// stroke colour
        /// </summary>
        public string stroke { get; set; }
        /// <summary>
        /// [“”, “-”, “.”, “-.”, “-..”, “. ”, “- ”, “--”, “- .”, “--.”, “--..”]
        /// </summary>
        [JsProperty(Name = "'stroke-dasharray'")]
        public string stroke_dasharray { get; set; }
        /// <summary>
        /// [“butt”, “square”, “round”]
        /// </summary>
        [JsProperty(Name = "'stroke-linecap'")]
        public string stroke_linecap { get; set; }
        /// <summary>
        /// [“bevel”, “round”, “miter”]
        /// </summary>
        [JsProperty(Name = "'stroke-linejoin'")]
        public string stroke_linejoin { get; set; }
        [JsProperty(Name = "'stroke-miterlimit'")]
        public JsNumber stroke_miterlimit { get; set; }
        [JsProperty(Name = "'stroke-opacity'")]
        public JsNumber stroke_opacity { get; set; }
        /// <summary>
        /// stroke width in pixels, default is '1'
        /// </summary>
        [JsProperty(Name = "'stroke-width'")]
        public JsNumber stroke_width { get; set; }
        /// <summary>
        /// used with href
        /// </summary>
        public string target { get; set; }
        /// <summary>
        /// contents of the text element. Use \n for multiline text
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// [“start”, “middle”, “end”], default is “middle”
        /// </summary>
        [JsProperty(Name = "'text-anchor'")]
        public string text_anchor { get; set; }
        /// <summary>
        /// will create tooltip with a given text
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// see Element.transform
        /// </summary>
        public string transform { get; set; }
        public JsNumber width { get; set; }
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }

    }
    #endregion

    #region dragOptions

    [JsType(JsMode.Json)]
    public class DragOptions
    {
        /// <summary>
        /// x position of the mouse
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// DOM event object
        /// </summary>
        public object JsEvent { get; set; }
    }
    #endregion

    #region DragOptions2

    [JsType(JsMode.Json)]
    public class DragOptions2
    {
        /// <summary>
        /// shift by x from the start point
        /// </summary>
        public JsNumber dx { get; set; }
        /// <summary>
        /// shift by y from the start point
        /// </summary>
        public JsNumber dy { get; set; }
        /// <summary>
        /// x position of the mouse
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// y position of the mouse
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// DOM event object
        /// </summary>
        public object JsEvent { get; set; }
    }
    #endregion

    #region DragOptions3

    [JsType(JsMode.Json)]
    public class DragOptions3
    {
        /// <summary>
        /// DOM event object
        /// </summary>
        public object JsEvent { get; set; }
    }
    #endregion

    #region GetBBoxOptions

    [JsType(JsMode.Json)]
    public class GetBBoxOptions
    {
        /// <summary>
        /// top left corner x
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// top left corner y
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// width
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        /// height
        /// </summary>
        public JsNumber height { get; set; }
    }
    #endregion

    #region GetPointAtLengthOptions

    [JsType(JsMode.Json)]
    public class GetPointAtLengthOptions
    {
        /// <summary>
        /// x coordinate
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// y coordinate
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// angle of derivative
        /// </summary>
        public JsNumber alpha { get; set; }
    }
    #endregion

    #region GlowOptions

    [JsType(JsMode.Json)]
    public class GlowOptions
    {
        /// <summary>
        /// size of the glow, default is 10
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        /// will it be filled, default is false
        /// </summary>
        public bool fill { get; set; }

        /// <summary>
        /// opacity, default is 0.5
        /// </summary>
        public JsNumber opacity { get; set; }
        /// <summary>
        /// horizontal offset, default is 0
        /// </summary>
        public JsNumber offsetx { get; set; }
        /// <summary>
        /// vertical offset, default is 0
        /// </summary>
        public JsNumber offsety { get; set; }
        /// <summary>
        /// glow colour, default is black
        /// </summary>
        public string color { get; set; }



    }
    #endregion

    #region Matrix

    [JsType(JsMode.Prototype)]
    public class Matrix
    {
        /// <summary>
        /// Adds given matrix to existing one.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="matrix"></param>
        public static void add(JsNumber a, JsNumber b, JsNumber c, JsNumber d, JsNumber e, JsNumber f, object matrix) { }
        /// <summary>
        /// Returns copy of the matrix
        /// </summary>
        /// <returns></returns>
        public static object clone()
        {
            return null;
        }
        /// <summary>
        /// Returns inverted version of the matrix
        /// </summary>
        /// <returns></returns>
        public static object invert()
        {
            return null;
        }
        /// <summary>
        /// Rotates the matrix
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void rotate(JsNumber a, JsNumber x, JsNumber y) { }
        /// <summary>
        /// Scales the matrix
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        public static void scale(JsNumber x, JsNumber y, JsNumber cx, JsNumber cy) { }

        public static object split()
        {
            return null;
        }
        /// <summary>
        /// Return transform string that represents given matrix
        /// </summary>
        /// <returns></returns>
        public static string toTransformString()
        {
            return null;
        }

        /// <summary>
        /// translate the matrix
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void translate(JsNumber x, JsNumber y) { }
        /// <summary>
        /// Return x coordinate for given point after transformation described by the matrix. See also Matrix.y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x</returns>
        public static JsNumber x(JsNumber x, JsNumber y)
        {
            return null;
        }
        /// <summary>
        /// Return x coordinate for given point after transformation described by the matrix. See also Matrix.y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>y</returns>
        public static JsNumber y(JsNumber x, JsNumber y)
        {
            return null;
        }

    }
    #endregion

    #region SplitOptions

    [JsType(JsMode.Prototype)]
    public class SplitOptions
    {
        /// <summary>
        /// translation by x
        /// </summary>
        public JsNumber dx { get; set; }
        /// <summary>
        /// translation by y
        /// </summary>
        public JsNumber dy { get; set; }
        /// <summary>
        /// scale by x
        /// </summary>
        public JsNumber scalex { get; set; }
        /// <summary>
        /// scale by y
        /// </summary>
        public JsNumber scaley { get; set; }
        /// <summary>
        /// shear
        /// </summary>
        public JsNumber shear { get; set; }
        /// <summary>
        /// rotation in deg
        /// </summary>
        public JsNumber rotate { get; set; }
        /// <summary>
        /// could it be represented via simple transformations
        /// </summary>
        public bool isSimple { get; set; }

    }
    #endregion

    #region Paper

    [JsType(JsMode.Prototype)]
    public class Paper
    {
        /// <summary>d<attributes>}s
        /// </summary>
        /// <param name="json"></param>
        /// <returns>resulting set of imported elements</returns>
        /// <example>
        /// usage
        /// <code>
        /// paper.add([
        /// {
        /// type: "circle",
        /// cx: 10,
        /// cy: 10,
        /// r: 5
        /// },
        /// {
        /// type: "rect",
        /// x: 10,
        /// y: 10,
        /// width: 10,
        /// height: 10,
        /// fill: "#fc0"
        /// }
        /// ]);
        /// </code>
        /// </example>
        public static object add(Array json)
        {
            return null;
        }
        /// <summary>
        /// Points to the bottom element on the paper
        /// </summary>
        public static void bottom() { }
        /// <summary>
        /// Shortcut for Paper.customAttributes
        /// </summary>
        public static JsObject<JsFunc<object, JsNumber>> ca { get; set; }

        /// <summary>
        /// Draws a circle.
        /// </summary>
        /// <param name="x">x coordinate of the centre</param>
        /// <param name="y">y coordinate of the centre</param>
        /// <param name="r">radius</param>
        /// <returns>Raphaël element object with type “circle”</returns>
        /// <example>
        /// usage
        /// <code>
        /// var c = paper.circle(50, 50, 40);
        /// </code>
        /// </example>
        public static object circle(JsNumber x, JsNumber y, JsNumber r)
        {
            return null;
        }
        /// <summary>
        /// Clears the paper, i.e. removes all the elements.
        /// </summary>
        public static void clear() { }
        /// <summary>
        /// If you have a set of attributes that you would like to represent as a function of some number you can do it easily with custom attributes
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// paper.customAttributes.hue = function (num) {
        /// num = num % 1;
        /// return {fill: "hsb(" + num + ", 0.75, 1)"};
        /// };
        /// // Custom attribute “hue” will change fill
        /// // to be given hue with fixed saturation and brightness.
        /// // Now you can use it like this:
        ///var c = paper.circle(10, 10, 10).attr({hue: .45});
        /// // or even like this:
        ///c.animate({hue: 1}, 1e3);
        /// // You could also create custom attribute
        /// // with multiple parameters:
        ///paper.customAttributes.hsb = function (h, s, b) {
        ///return {fill: "hsb(" + [h, s, b].join(",") + ")"};
        ///};
        ///c.attr({hsb: "0.5 .8 1"});
        ///c.animate({hsb: [1, 0, 0.5]}, 1e3);
        /// </code>
        /// </example>
        public static JsObject<JsFunc<object, JsNumber>> customAttributes { get; set; }


        /// <summary>
        /// Draws an ellipse.
        /// </summary>
        /// <param name="x">x coordinate of the centre</param>
        /// <param name="y">y coordinate of the centre</param>
        /// <param name="rx">horizontal radius</param>
        /// <param name="ry">vertical radius</param>
        /// <returns>Raphaël element object with type “ellipse”</returns>
        /// <example>
        /// usage
        /// <code>
        /// var c = paper.ellipse(50, 50, 40, 20);
        /// </code>
        /// </example>
        public static object ellipse(JsNumber x, JsNumber y, JsNumber rx, JsNumber ry)
        {
            return null;
        }
        /// <summary>
        /// Executes given function for each element on the paper
        /// If callback function returns false it will stop loop running.
        /// </summary>
        /// <param name="callback">function to run</param>
        /// <param name="thisArg">context object for the callback</param>
        /// <returns>Paper object</returns>
        public static object forEach(JsFunction callback, object thisArg)
        {
            return null;
        }
        /// <summary>
        /// Returns you element by its internal ID.
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Raphaël element object</returns>
        public static object getById(JsNumber id)
        {
            return null;
        }
        /// <summary>
        /// Returns you topmost element under given point.
        /// </summary>
        /// <param name="x">x coordinate from the top left corner of the window</param>
        /// <param name="y">y coordinate from the top left corner of the window</param>
        /// <returns>Raphaël element object</returns>
        /// <example>
        /// usage
        /// <code>
        /// paper.getElementByPoint(mouseX, mouseY).attr({stroke: "#f00"});
        /// </code>
        /// </example>
        public static object getElementByPoint(JsNumber x, JsNumber y)
        {
            return null;
        }
        /// <summary>
        /// Finds font object in the registered fonts by given parameters. You could specify only one word from the font name, like “Myriad” for “Myriad Pro”.
        /// </summary>
        /// <param name="family">font family name or any word from it</param>
        /// <param name="weight">font weight</param>
        /// <param name="style">font style</param>
        /// <param name="stretch">font stretch</param>
        /// <returns>the font object</returns>
        /// <example>
        /// usage
        /// <code>
        /// paper.print(100, 100, "Test string", paper.getFont("Times", 800), 30);
        /// </code>
        /// </example>
        public static object getFont(string family, string weight, string style, string stretch)
        {
            return null;
        }
        /// <summary>
        /// Embeds an image into the surface.
        /// </summary>
        /// <param name="src">URI of the source image</param>
        /// <param name="x">x coordinate position</param>
        /// <param name="y">y coordinate position</param>
        /// <param name="width">width of the image</param>
        /// <param name="height">height of the image</param>
        /// <returns>Raphaël element object with type “image”</returns>
        /// <example>
        /// usage
        /// <code>
        /// var c = paper.image("apple.png", 10, 10, 80, 80);
        /// </code>
        /// </example>
        public static object image(string src, JsNumber x, JsNumber y, JsNumber width, JsNumber height)
        {
            return null;
        }
        /// <summary>
        /// Creates a path element by given path data string.
        /// </summary>
        /// <param name="pathString">path string in SVG format.</param>
        /// <example>
        /// usage
        /// <code>
        /// "M10,20L30,40"
        /// </code>
        /// </example>
        /// 
        public static void path(string pathString) { }
        // not done!!!! 

        /// <summary>
        /// Creates set of shapes to represent given font at given position with given size. Result of the method is set object (see Paper.set) which contains each letter as separate path object.
        /// </summary>
        /// <param name="x">x position of the text</param>
        /// <param name="y">y position of the text</param>
        /// <param name="text">text to print</param>
        /// <param name="font">font object, see Paper.getFont</param>
        /// <param name="size">size of the font, default is 16</param>
        /// <param name="origin">could be "baseline" or "middle", default is "middle"</param>
        /// <param name="letter_spacing">number in range -1..1, default is 0</param>
        /// <returns>resulting set of letters</returns>
        /// <example>
        /// usage
        /// <code>
        /// var txt = r.print(10, 50, "print", r.getFont("Museo"), 30).attr({fill: "#fff"});
        /// // following line will paint first letter in red
        /// txt[0].attr({fill: "#f00"});
        /// </code>
        /// </example>
        public static object print(JsNumber x, JsNumber y, string text, object font, JsNumber size, string origin, JsNumber letter_spacing)
        {
            return null;
        }
        /// <summary>
        /// Points to the Raphael object/function
        /// </summary>
        public static Raphael rapheal { get; set; }
        /// <summary>
        /// Draws a rectangle.
        /// </summary>
        /// <param name="x">x coordinate of the top left corner</param>
        /// <param name="y">y coordinate of the top left corner</param>
        /// <param name="width">width</param>
        /// <param name="height">height</param>
        /// <param name="r">radius for rounded corners, default is 0</param>
        /// <returns>Raphaël element object with type “rect”</returns>
        /// <example>
        /// usage
        /// <code>
        /// // regular rectangle
        /// var c = paper.rect(10, 10, 50, 50);
        /// // rectangle with rounded corners
        /// var c = paper.rect(40, 40, 50, 50, 10);
        /// </code>
        /// </example>
        public static object rect(JsNumber x, JsNumber y, JsNumber width, JsNumber height, JsNumber r)
        {
            return null;
        }
        /// <summary>
        /// Removes the paper from the DOM.
        /// </summary>
        public static void remove() { }
        /// <summary>
        /// Fixes the issue of Firefox and IE9 regarding subpixel rendering. If paper is dependant on other elements after reflow it could shift half pixel which cause for lines to lost their crispness. This method fixes the issue.
        /// </summary>
        public static void renderfix() { }
        /// <summary>
        /// There is an inconvenient rendering bug in Safari (WebKit): sometimes the rendering should be forced. This method should help with dealing with this bug.
        /// </summary>
        public static void safari() { }
        /// <summary>
        /// Creates array-like object to keep and operate several elements at once. Warning: it doesn’t create any elements for itself in the page, it just groups existing elements. Sets act as pseudo elements — all methods available to an element can be used on a set.
        /// </summary>
        /// <returns>array-like object that represents set of elements</returns>
        /// <example>
        /// usage
        /// <code>
        /// var st = paper.set();
        /// st.push(
        /// paper.circle(10, 10, 5),
        /// paper.circle(30, 10, 5)
        /// );
        /// st.attr({fill: "red"}); // changes the fill of both circles
        /// </code>
        /// </example>
        public static object set()
        {
            return null;
        }
        /// <summary>
        /// See Paper.setStart. This method finishes catching and returns resulting set.
        /// </summary>
        /// <returns>set</returns>
        public static object setFinish()
        {
            return null;
        }
        /// <summary>
        /// If you need to change dimensions of the canvas call this method
        /// </summary>
        /// <param name="width">new width of the canvas</param>
        /// <param name="height">new height of the canvas</param>
        public static void setSize(JsNumber width, JsNumber height) { }
        /// <summary>
        /// Creates Paper.set. All elements that will be created after calling this method and before calling Paper.setFinish will be added to the set.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// paper.setStart();
        /// paper.circle(10, 10, 5),
        /// paper.circle(30, 10, 5)
        /// var st = paper.setFinish();
        /// st.attr({fill: "red"}); // changes the fill of both circles
        /// </code>
        /// </example>
        public static void setStart() { }
        /// <summary>
        /// Sets the view box of the paper. Practically it gives you ability to zoom and pan whole paper surface by specifying new boundaries.
        /// </summary>
        /// <param name="x">new x position, default is 0</param>
        /// <param name="y">new y position, default is 0</param>
        /// <param name="w">new width of the canvas</param>
        /// <param name="h">new height of the canvas</param>
        /// <param name="fit">true if you want graphics to fit into new boundary box</param>
        public static void setViewBox(JsNumber x, JsNumber y, JsNumber w, JsNumber h, bool fit) { }
        /// <summary>
        /// Draws a text string. If you need line breaks, put “\n” in the string.
        /// </summary>
        /// <param name="x">x coordinate position</param>
        /// <param name="y">y coordinate position</param>
        /// <param name="text">The text string to draw</param>
        /// <returns>Raphaël element object with type “text”</returns>
        /// <example>
        /// usage
        /// <code>
        /// var t = paper.text(50, 50, "Raphaël\nkicks\nbutt!");
        /// </code>
        /// </example>
        public static object text(JsNumber x, JsNumber y, string text)
        {
            return null;
        }
        /// <summary>
        /// Points to the topmost element on the paper
        /// </summary>
        public static Top top { get; set; }
    }
    #endregion

    #region Raphael

    [JsType(JsMode.Prototype)]
    public class Raphael
    {
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="callback">callback function which is going to be executed in the context of newly created paper</param>
        public Raphael(JsNumber x, JsNumber y, JsNumber width, JsNumber height, JsFunction callback) { }
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="all">(first 3 or 4 elements in the array are equal to [containerID, width, height] or [x, y, width, height]. The rest are element descriptions in format {type: type, <attributes>}). See Paper.add.</param>
        /// <param name="callback">callback function which is going to be executed in the context of newly created paper</param>
        public Raphael(Array all, JsFunction callback) { }
        //raphael (...) ?!?!

        /// <summary>
        /// Returns angle between two or three points
        /// </summary>
        /// <param name="x1">x coord of first point</param>
        /// <param name="y1">y coord of first point</param>
        /// <param name="x2">x coord of second point</param>
        /// <param name="y2">y coord of second point</param>
        /// <param name="x3">x coord of third point</param>
        /// <param name="y3">y coord of third point</param>
        /// <returns>angle in degrees.</returns>
        public static JsNumber angle(JsNumber x1, JsNumber y1, JsNumber x2, JsNumber y2, JsNumber x3, JsNumber y3)
        {
            return null;
        }
        /// <summary>
        /// Creates an animation object that can be passed to the Element.animate or Element.animateWith methods. See also Animation.delay and Animation.repeat methods.
        /// </summary>
        /// <param name="params">final attributes for the element, see also Element.attr</param>
        /// <param name="ms">number of milliseconds for animation to run</param>
        /// <param name="easing">easing type. Accept one of Raphael.easing_formulas or CSS format: cubic‐bezier(XX, XX, XX, XX)</param>
        /// <param name="callback">callback function. Will be called at the end of animation.</param>
        /// <returns>Animation</returns>
        public static object animation(object @params, JsNumber ms, string easing, JsFunction callback)
        {
            return null;
        }
        //dubble check @params

        /// <summary>
        /// Parses the color string and returns object with all values for the given color.
        /// </summary>
        /// <param name="clr">color string in one of the supported formats (see Raphael.getRGB)</param>
        /// <returns>Combined RGB & HSB object in format:</returns>
        public static object color(string clr)
        {
            return null;
        }
        /// <summary>
        /// Returns RFC4122, version 4 ID
        /// </summary>
        public static void createUUID() { }
        /// <summary>
        /// Transform angle to degrees
        /// </summary>
        /// <param name="deg">angle in radians</param>
        /// <returns>angle in radians</returns>
        public static JsNumber deg(JsNumber deg)
        {
            return null;
        }

        //Raphael.easing_formulas (?!)
        /// <summary>
        /// You can add your own method to elements. This is usefull when you want to hack default functionality or want to wrap some common transformation or attributes in one method. In difference to canvas methods, you can redefine element method at any time. Expending element methods wouldn’t affect set.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// Raphael.el.red = function () {
        /// this.attr({fill: "#f00"});
        /// };
        /// // then use it
        /// paper.circle(100, 100, 20).red();
        /// </code>
        /// </example>
        public object el { get; set; }

        /// <summary>
        /// Utility method Find dot coordinates on the given cubic bezier curve at the given t.
        /// </summary>
        /// <param name="p1x">x of the first point of the curve</param>
        /// <param name="p1y">y of the first point of the curve</param>
        /// <param name="c1x">x of the first anchor of the curve</param>
        /// <param name="c1y">y of the first anchor of the curve</param>
        /// <param name="c2x">x of the second anchor of the curve</param>
        /// <param name="c2y">y of the second anchor of the curve</param>
        /// <param name="p2x">x of the second point of the curve</param>
        /// <param name="p2y">y of the second point of the curve</param>
        /// <param name="t">position on the curve (0..1)</param>
        /// <returns>point information in format:</returns>
        public static object findDotsAtSegment(JsNumber p1x, JsNumber p1y, JsNumber c1x, JsNumber c1y, JsNumber c2x, JsNumber c2y, JsNumber p2x, JsNumber p2y, JsNumber t)
        {
            return null;
        }
        //grey box information (?)
        /// <summary>
        /// You can add your own method to the canvas. For example if you want to draw a pie chart, you can create your own pie chart function and ship it as a Raphaël plugin. To do this you need to extend the Raphael.fn object. You should modify the fn object before a Raphaël instance is created, otherwise it will take no effect. Please note that the ability for namespaced plugins was removed in Raphael 2.0. It is up to the plugin to ensure any namespacing ensures proper context.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// Raphael.fn.arrow = function (x1, y1, x2, y2, size) {
        /// return this.path( ... );
        /// };
        /// // or create namespace
        /// Raphael.fn.mystuff = {
        /// arrow: function () {…},
        /// star: function () {…},
        /// // etc…
        /// };
        /// var paper = Raphael(10, 10, 630, 480);
        /// // then use it
        /// paper.arrow(10, 10, 30, 30, 5).attr({fill: "#f00"});
        /// paper.mystuff.arrow();
        /// paper.mystuff.star();
        /// </code>
        /// </example>
        public object fn { get; set; }


        //Raphael.format(token, …) what should i do with "..."?

        /// <summary>
        /// A little bit more advanced format function than Raphael.format. Replaces construction of type “{<name>}” to the corresponding argument.
        /// </summary>
        /// <param name="token">string to format</param>
        /// <param name="json">object which properties will be used as a replacement</param>
        /// <returns>formated string</returns>
        /// <example>
        /// usage
        /// <code>
        /// // this will draw a rectangular shape equivalent to "M10,20h40v50h-40z"
        /// paper.path(Raphael.format("M{x},{y}h{dim.width}v{dim.height}h{dim['negative width']}z", {
        /// x: 10,
        /// y: 20,
        /// dim: {
        /// width: 40,
        /// height: 50,
        /// "negative width": -40
        /// }
        /// }));
        /// </code>
        /// </example>
        public static string fullfill(string token, object json)
        {
            return null;
        }

        /// <summary>
        /// On each call returns next colour in the spectrum. To reset it back to red call Raphael.getColor.reset
        /// </summary>
        /// <param name="value">brightness, default is 0.75</param>
        /// <returns>hex representation of the colour.</returns>
        public static string getColor(JsNumber value)
        {
            return null;
        }
        /// <summary>
        /// Resets spectrum position for Raphael.getColor back to red
        /// </summary>
        /// [JsProperty(Name = "'getColor.reset'")]
        public static void getColor_reset() { }
        //dubble chack with danel

        /// <summary>
        /// Return coordinates of the point located at the given length on the given path.
        /// </summary>
        /// <param name="path">SVG path string</param>
        /// <param name="length"></param>
        /// <returns>representation of the point:</returns>
        public static object getPointAtLength(string path, JsNumber length)
        {
            return null;
        }

        //Raphael.getRGB(colour) (?!)

        /// <summary>
        /// Return subpath of a given path from given length to given length.
        /// </summary>
        /// <param name="path">SVG path string</param>
        /// <param name="from">position of the start of the segment</param>
        /// <param name="to">position of the end of the segment</param>
        /// <returns>pathstring for the segment</returns>
        public static string getSubpath(string path, JsNumber from, JsNumber to)
        {
            return null;
        }
        /// <summary>
        /// Returns length of the given path in pixels.
        /// </summary>
        /// <param name="path">SVG path string.</param>
        /// <returns>length.</returns>
        public static JsNumber getTotalLength(string path)
        {
            return null;
        }
        /// <summary>
        /// Converts HSB values to hex representation of the colour.
        /// </summary>
        /// <param name="h">hue</param>
        /// <param name="s">saturation</param>
        /// <param name="b">value or brightness</param>
        /// <returns>hex representation of the colour.</returns>
        public static string hsb(JsNumber h, JsNumber s, JsNumber b)
        {
            return null;
        }
        /// <summary>
        /// Converts HSB values to RGB object.
        /// </summary>
        /// <param name="h">hue</param>
        /// <param name="s">saturation</param>
        /// <param name="v">value or brightness</param>
        /// <returns>RGB object in format:</returns>
        public static object hsb2rgb(JsNumber h, JsNumber s, JsNumber v)
        {
            return null;
        }
        /// <summary>
        /// Converts HSL values to hex representation of the colour.
        /// </summary>
        /// <param name="h">hue</param>
        /// <param name="s">saturation</param>
        /// <param name="l">luminosity</param>
        /// <returns>hex representation of the colour.</returns>
        public static string hsl(JsNumber h, JsNumber s, JsNumber l)
        {
            return null;
        }
        /// <summary>
        /// Converts HSL values to RGB object.
        /// </summary>
        /// <param name="h">hue</param>
        /// <param name="s">saturation</param>
        /// <param name="l">luminosity</param>
        /// <returns>RGB object in format:</returns>
        public static object hsl2rgb(JsNumber h, JsNumber s, JsNumber l)
        {
            return null;
        }

        //Raphael.is(o, type) (is is not good+what should i do with the "..."

        /// <summary>
        /// Utility method Returns matrix based on given parameters.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <returns>Matrix</returns>
        public static object matrix(JsNumber a, JsNumber b, JsNumber c, JsNumber d, JsNumber e, JsNumber f)
        {
            return null;
        }
        /// <summary>
        /// If you want to leave no trace of Raphaël (Well, Raphaël creates only one global variable Raphael, but anyway.) You can use ninja method. Beware, that in this case plugins could stop working, because they are depending on global variable existance.
        /// </summary>
        /// <returns>Raphael object</returns>
        /// <example>
        /// usage
        /// <code>
        /// (function (local_raphael) {
        /// var paper = local_raphael(10, 10, 320, 200);
        /// …
        /// })(Raphael.ninja());
        /// </code>
        /// </example>
        public static object ninja()
        {
            return null;
        }










    }
    #endregion

    #region ColorOptions

    [JsType(JsMode.Prototype)]
    public class ColorOptions
    {
        /// <summary>
        /// red
        /// </summary>
        public JsNumber r { get; set; }
        /// <summary>
        /// green
        /// </summary>
        public JsNumber g { get; set; }
        /// <summary>
        /// blue
        /// </summary>
        public JsNumber b { get; set; }
        /// <summary>
        /// color in HTML/CSS format: #••••••,
        /// </summary>
        public string hex { get; set; }
        /// <summary>
        /// true if string can’t be parsed,
        /// </summary>
        public bool error { get; set; }
        /// <summary>
        /// hue
        /// </summary>
        public JsNumber h { get; set; }
        /// <summary>
        /// saturation
        /// </summary>
        public JsNumber s { get; set; }
        /// <summary>
        /// value (brightness),
        /// </summary>
        public JsNumber v { get; set; }
        /// <summary>
        /// lightness
        /// </summary>
        public JsNumber l { get; set; }
    }
    #endregion


    #region Hsb2RgbOptions


    [JsType(JsMode.Prototype)]
    public class Hsb2RgbOptions
    {
        /// <summary>
        /// red
        /// </summary>
        public JsNumber r { get; set; }
        /// <summary>
        /// green
        /// </summary>
        public JsNumber g { get; set; }
        /// <summary>
        /// blue
        /// </summary>
        public JsNumber b { get; set; }
        /// <summary>
        /// color in HTML/CSS format: #••••••
        /// </summary>
        public string hex { get; set; }
    }
    #endregion

    #region Hsl2RgbOptions

    [JsType(JsMode.Prototype)]
    public class Hsl2RgbOptions
    {
        /// <summary>
        /// red
        /// </summary>
        public JsNumber r { get; set; }
        /// <summary>
        /// green
        /// </summary>
        public JsNumber g { get; set; }
        /// <summary>
        /// blue
        /// </summary>
        public JsNumber b { get; set; }
        /// <summary>
        /// color in HTML/CSS format: #••••••
        /// </summary>
        public string hex { get; set; }
    }
    #endregion

    #region Animation


    public class Prev
    {
    }
    public class Next
    {
    }
    public class Node
    {
    }
    public class Top
    {
    }
    #endregion
}