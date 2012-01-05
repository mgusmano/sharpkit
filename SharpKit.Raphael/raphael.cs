using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.Raphael
{
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
        /// for (var i = 0, i < 5, i++) {
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
        /// Shortcut for assigning event handler for drag.over.<id> event, where id is id of the element (see Element.id).
        /// </summary>
        /// <param name="F">handler for event, first argument would be the element you are dragging over</param>
        public static void OnDragOver(JsAction F) { }
        /// <summary>
        /// Stops animation of the element with ability to resume it later on.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <returns></returns>
        public static object pause(object anim)
        {
            return null;
        }


    }

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

    [JsType(JsMode.Json)]
    public class dragOptions
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

    [JsType(JsMode.Json)]
    public class dragOptions2
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

    [JsType(JsMode.Json)]
    public class dragOptions3
    {
        /// <summary>
        /// DOM event object
        /// </summary>
        public object JsEvent { get; set; }
    }

    [JsType(JsMode.Json)]
    public class getBBoxOptions
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

    [JsType(JsMode.Json)]
    public class getPointAtLengthOptions
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

    [JsType(JsMode.Json)]
    public class glowOptions
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

}