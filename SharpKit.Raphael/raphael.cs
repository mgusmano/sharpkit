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


}