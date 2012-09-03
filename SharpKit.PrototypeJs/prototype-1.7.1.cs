using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html4;

namespace SharpKit.PrototypeJs
{
    #region Prototype

    //TODO: Prototype namespace

    /// <summary>
    /// A collection of Boolean values indicating the browser which is currently in use.
    /// Available properties are IE, Opera, WebKit, MobileSafari and Gecko.
    /// </summary>
    ///<example>
    ///usage
    ///<code>
    ///Prototype.Browser.WebKit;
    /// //-> true, when executed in any WebKit-based browser.
    ///</code>
    ///</example>
    [JsType(JsMode.Prototype, Name = "Prototype.Browser", Export = false)]
    public class Browser
    {
        public bool IE { get; set; }
        public bool Opera { get; set; }
        public bool WebKit { get; set; }
        public bool MobileSafari { get; set; }
        public bool Gecko { get; set; }
    }
    //TODO: think it is a namespace, not sure i did it right. maybe shuld have an eunm?

    /// <summary>
    /// A collection of Boolean values indicating the presence of specific browser features.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Prototype.BrowserFeatures", Export = false)]
    public class BrowserFeatures
    {
        /// <summary>
        /// Used internally to detect if the browser supports extending html element prototypes.
        /// </summary>
        public bool ElementExtensions { get; set; }
        /// <summary>
        /// Used internally to detect if the browser supports the NodeSelector API.
        /// </summary>
        public bool SelectorsAPI { get; set; }
        /// <summary>
        /// Used internally to detect if the browser supports DOM Level 3 XPath.
        /// </summary>
        public bool XPath { get; set; }
    }
    //TODO: think it is a namespace

    /// <summary>
    /// A namespace that acts as a wrapper around the choosen selector engine (Sizzle by default).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Prototype.Selector", Export = false)]
    public class Selector
    {
        /// <summary>
        /// Alias of: Element.extend
        /// Extends the given element instance with all of the Prototype goodness and syntactic sugar, as well as any extensions added via Element.addMethods.
        /// (If the element instance was already extended, this is a no-op.)
        /// You only need to use Element.extend on element instances you've acquired directly from the DOM;
        /// all Prototype methods that return element instances (such as $, Element.down, etc.) will pre-extend the element before returning it.
        /// Check out "How Prototype extends the DOM" for more about element extensions.
        /// Specifically, Element.extend extends the given instance with the methods contained in Element.Methods and Element.Methods.Simulated.
        /// If element is an input, textarea, or select element, it will also be extended with the methods from Form.Element.Methods.
        /// If it is a form element, it will also be extended with the methods from Form.Methods.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public HtmlElement extendElement(HtmlElement element) { return null; }

        /// <summary>
        /// If necessary, extends the elements contained in elements and returns elements untouched.
        /// This is provided as a convenience method for selector engine wrapper implementors.
        /// </summary>
        /// <param name="elements">elements (Enumerable) – a collection of DOM elements.</param>
        /// <returns></returns>
        public Enumerable extendElements(Enumerable elements) { return null; }
        //TODO: check

        /// <summary>
        /// Filters the given collection of elements with expression and returns the first matching element (or the indexth matching element if index is specified).
        /// </summary>
        /// <param name="elements">(Enumerable) – a collection of DOM elements.</param>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="index">Numeric index of the match to return, defaults to 0.</param>
        /// <returns></returns>
        public HtmlElement find(Enumerable elements, JsString expression, JsNumber index) { return null; }
        //TODO: check
        /// <summary>
        /// Filters the given collection of elements with expression and returns the first matching element (or the indexth matching element if index is specified).
        /// </summary>
        /// <param name="elements">(Enumerable) – a collection of DOM elements.</param>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <returns></returns>
        public HtmlElement find(Enumerable elements, JsString expression) { return null; }
        //TODO: check

        /// <summary>
        /// Tests whether element matches the CSS selector.
        /// </summary>
        /// <param name="element">(Element) – a DOM element.</param>
        /// <param name="expression"> (String) – A CSS selector.</param>
        /// <returns></returns>
        public bool match(HtmlElement element, JsString expression) { return false; }

        /// <summary>
        /// Searches root for elements that match the provided CSS selector and returns an array of extended Element objects.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="root">(Element | document) – A "scope" to search within. All results will be descendants of this node.</param>
        /// <returns></returns>
        public JsArray<HtmlElement> select(JsString expression, HtmlElement root) { return null; }
        //TODO: check return type
        /// <summary>
        /// Searches root for elements that match the provided CSS selector and returns an array of extended Element objects.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="root">(Element | document) – A "scope" to search within. All results will be descendants of this node.</param>
        /// <returns></returns>
        public JsArray<HtmlElement> select(JsString expression, HtmlDocument root) { return null; }
        //TODO: check return type
    }

    public class Enumerable
    {
        /// <summary>
        /// Determines whether all the elements are "truthy" (boolean-equivalent to true), either directly or through computation by the provided iterator.
        /// Stops on the first falsy element found (e.g., the first element that is boolean-equivalent to false, such as undefined, 0, or indeed false);
        /// </summary>
        /// <param name="iterator">iterator (Function) – An optional function to use to evaluate each element in the enumeration;
        /// the function should return the value to test. If this is not provided, the element itself is tested.
        /// context (Object) – An optional object to use as this within calls to the iterator.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///[].all();
        /// // -> true (empty arrays have no elements that could be falsy)
        ///  $R(1, 5).all();
        /// // -> true (all values in [1..5] are truthy)
        ///  [0, 1, 2].all();
        /// // -> false (with only one loop cycle: 0 is falsy)
        ///  [9, 10, 15].all(function(n) { return n >= 10; });
        /// // -> false (the iterator returns false on 9)
        ///</code>
        ///</example>
        public bool all(JsFunc<object, JsNumber> iterator) { return false; }
        //TODO: must check.
        /// <summary>
        /// Determines whether all the elements are "truthy" (boolean-equivalent to true), either directly or through computation by the provided iterator.
        /// Stops on the first falsy element found (e.g., the first element that is boolean-equivalent to false, such as undefined, 0, or indeed false);
        /// </summary>
        /// <param name="iterator">iterator (Function) – An optional function to use to evaluate each element in the enumeration;
        /// the function should return the value to test. If this is not provided, the element itself is tested.
        /// context (Object) – An optional object to use as this within calls to the iterator.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///[].all();
        /// // -> true (empty arrays have no elements that could be falsy)
        ///  $R(1, 5).all();
        /// // -> true (all values in [1..5] are truthy)
        ///  [0, 1, 2].all();
        /// // -> false (with only one loop cycle: 0 is falsy)
        ///  [9, 10, 15].all(function(n) { return n >= 10; });
        /// // -> false (the iterator returns false on 9)
        ///</code>
        ///</example>
        public bool all(JsFunc<JsNumber> iterator) { return false; }
        //TODO: must check.
        /// <summary>
        /// Determines whether all the elements are "truthy" (boolean-equivalent to true), either directly or through computation by the provided iterator.
        /// Stops on the first falsy element found (e.g., the first element that is boolean-equivalent to false, such as undefined, 0, or indeed false);
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///[].all();
        /// // -> true (empty arrays have no elements that could be falsy)
        ///  $R(1, 5).all();
        /// // -> true (all values in [1..5] are truthy)
        ///  [0, 1, 2].all();
        /// // -> false (with only one loop cycle: 0 is falsy)
        ///  [9, 10, 15].all(function(n) { return n >= 10; });
        /// // -> false (the iterator returns false on 9)
        ///</code>
        ///</example>
        public bool all() { return false; }
        //TODO: must check.

        //TODO: finish the class: http://api.prototypejs.org/language/Enumerable/
    }

    public class Prototype
    {
        /// <summary>
        /// The Prototype.emptyFunction does nothing... and returns nothing!
        /// It is used thoughout the framework to provide a fallback function in order to cut down on conditionals.
        /// Typically you'll find it as a default value for optional callback functions.
        /// </summary>
        /// <param name="argument"></param>
        public void emptyFunction(object argument) { }
        /// <summary>
        /// The Prototype.emptyFunction does nothing... and returns nothing!
        /// It is used thoughout the framework to provide a fallback function in order to cut down on conditionals.
        /// Typically you'll find it as a default value for optional callback functions.
        /// </summary>
        public void emptyFunction() { }

        /// <summary>
        /// Prototype.K is Prototype's very own identity function, i.e. it returns its argument untouched.
        /// This is used throughout the framework, most notably in the Enumerable module as a default value for iterators.
        /// </summary>
        /// <param name="argument">(Object) – Optional argument...</param>
        /// <returns></returns>
        public object K(object argument) { return null; }
        /// <summary>
        /// Prototype.K is Prototype's very own identity function, i.e. it returns its argument untouched.
        /// This is used throughout the framework, most notably in the Enumerable module as a default value for iterators.
        /// </summary>
        /// <returns></returns>
        public object K() { return null; }

        /// <summary>
        /// The version of the Prototype library you are using (e.g. "&lt;%= PROTOTYPE_VERSION %>").
        /// </summary>
        public JsString Version { get; set; }
    }

    #endregion
    //TODO: fix all elements!!!

    #region DOM section

    [JsType(JsMode.Global)]
    public class PrototypeContext
    {
        /// <summary>
        /// If provided with a string, returns the element in the document with matching ID; otherwise returns the passed element.
        /// Takes in an arbitrary number of arguments. Returns one Element if given one argument; otherwise returns an Array of Elements.
        /// All elements returned by the function are "extended" with Element instance methods.
        /// </summary>
        /// <param name="el">(String | Element) – A DOM node or a string that references a node's ID.</param>
        /// <returns></returns>
        [JsMethod(Name = "$")]
        public static Element D(HtmlElement el) { return null; }
        /// <summary>
        /// If provided with a string, returns the element in the document with matching ID; otherwise returns the passed element.
        /// Takes in an arbitrary number of arguments. Returns one Element if given one argument; otherwise returns an Array of Elements.
        /// All elements returned by the function are "extended" with Element instance methods.
        /// </summary>
        /// <param name="el">(String | Element) – A DOM node or a string that references a node's ID.</param>
        /// <returns></returns>
        [JsMethod(Name = "$")]
        public static Element D(JsString el) { return null; }
        /// <summary>
        /// If provided with a string, returns the element in the document with matching ID; otherwise returns the passed element.
        /// Takes in an arbitrary number of arguments. Returns one Element if given one argument; otherwise returns an Array of Elements.
        /// All elements returned by the function are "extended" with Element instance methods.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        [JsMethod(Name = "$")]
        public static JsArray<Element> D(params HtmlElement[] elements) { return null; }
        /// <summary>
        /// If provided with a string, returns the element in the document with matching ID; otherwise returns the passed element.
        /// Takes in an arbitrary number of arguments. Returns one Element if given one argument; otherwise returns an Array of Elements.
        /// All elements returned by the function are "extended" with Element instance methods.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        [JsMethod(Name = "$")]
        public static JsArray<Element> D(params JsString[] elements) { return null; }

        /// <summary>
        /// Takes an arbitrary number of CSS selectors (strings) and returns a document-order array of extended DOM elements that match any of them.
        /// Sometimes the usual tools from your DOM arsenal -- document.getElementById encapsulated by $,
        /// getElementsByTagName and even Prototype's very own getElementsByClassName extensions -- just aren't enough to quickly find elements or collections of elements.
        /// If you know the DOM tree structure, you can simply resort to CSS selectors to get the job done.
        /// </summary>
        /// <param name="cssRule"></param>
        /// <returns></returns>
        [JsMethod(Name = "$$")]
        public static JsArray<Element> DD(params JsString[] cssRule) { return null; }

        /// <summary>
        /// Returns the value of a form control. This is a convenience alias of Form.Element.getValue. Refer to it for full details.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        [JsMethod(Name = "$F")]
        public static JsString DF(HtmlElement element) { return null; }
        /// <summary>
        /// Returns the value of a form control. This is a convenience alias of Form.Element.getValue. Refer to it for full details.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        //[JsProperty(Name = "$F")]
        //public static JsArray<JsString> DF(HtmlElement element) { return null; }
        //TODO: "only multiple select boxes return an array of values."

    }

    #endregion

    #region document

    /// <summary>
    /// Prototype extends the built-in document object with several convenience methods related to events.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "document", Export = false)]
    public class document : HtmlElement
    {
        /// <summary>
        /// Fires a custom event of name eventName with document as the target.
        /// document.fire is the document-wide version of Element.fire.
        /// Custom events must include a colon (:) in their names.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="memo">Metadata for the event. Will be accessible through the event's memo property.</param>
        /// <param name="bubble">Whether the event will bubble.</param>
        /// <returns></returns>
        public Event fire(JsString eventName, object memo, bool bubble) { return null; }
        /// <summary>
        /// Fires a custom event of name eventName with document as the target.
        /// document.fire is the document-wide version of Element.fire.
        /// Custom events must include a colon (:) in their names.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="memo">Metadata for the event. Will be accessible through the event's memo property.</param>
        /// <returns></returns>
        public Event fire(JsString eventName, object memo) { return null; }
        /// <summary>
        /// Fires a custom event of name eventName with document as the target.
        /// document.fire is the document-wide version of Element.fire.
        /// Custom events must include a colon (:) in their names.
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public Event fire(JsString eventName) { return null; }

        /// <summary>
        /// Listens for the given event over the entire document. Can also be used for listening to "dom:loaded" event.
        /// document.observe is the document-wide version of Element#observe. Using document.observe is equivalent to Event.observe(document, eventName, handler).
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public Element observe(JsString eventName, JsAction handler) { return null; }

        /// <summary>
        /// Unregisters an event handler from the document.
        /// document.stopObserving is the document-wide version of Element.stopObserving.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public Element stopObserving(JsString eventName, JsAction handler) { return null; }

        /// <summary>
        /// Whether the full DOM tree is ready for manipulation.
        /// </summary>
        public bool loaded { get; set; }
    }

    /// <summary>
    /// The document.viewport namespace contains methods that return information about the viewport — the rectangle that represents the portion of a web page within view.
    /// In other words, it's the browser window minus all chrome.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "document.viewport", Export = false)]
    public class viewport
    {
        /// <summary>
        /// Returns an object containing viewport dimensions in the form { width: Number, height: Number }.
        /// The viewport is the subset of the browser window that a page occupies — the "usable" space in a browser window.
        /// </summary>
        /// <returns></returns>
        public DimensionsOptions getDimensions() { return null; }

        /// <summary>
        /// Returns the height of the viewport.
        /// Equivalent to document.viewport.getDimensions().height.
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// Returns the viewport's horizontal and vertical scroll offsets.
        /// Returns an array in the form of [leftValue, topValue]. Also accessible as properties: { left: leftValue, top: topValue }.
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "getScrollOffsets")]
        public JsArray getScrollOffsetsArray() { return null; }
        /// <summary>
        /// Returns the viewport's horizontal and vertical scroll offsets.
        /// Returns an array in the form of [leftValue, topValue]. Also accessible as properties: { left: leftValue, top: topValue }.
        /// </summary>
        /// <returns></returns>
        public ScrollOffsetsOptions getScrollOffsets() { return null; }

        /// <summary>
        /// Returns the width of the viewport.
        /// Equivalent to calling document.viewport.getDimensions().width.
        /// </summary>
        /// <returns></returns>
        public JsNumber getWidth() { return null; }

    }
    [JsType(JsMode.Json)]
    public class DimensionsOptions
    {
        public JsNumber width { get; set; }

        public JsNumber height { get; set; }
    }
    [JsType(JsMode.Json)]
    public class ScrollOffsetsOptions
    {
        public JsNumber left { get; set; }

        public JsNumber top { get; set; }
    }

    #endregion

    /// <summary>
    /// The Element object provides a variety of powerful DOM methods for interacting with DOM elements — creating them, updating them, traversing them, etc.
    /// You can access these either as methods of Element itself, passing in the element to work with as the first argument, or as methods on extended element instances
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Element", Export = false)]
    public class Element
    {
        /// <summary>
        /// Creates an HTML element with tagName as the tag name, optionally with the given attributes.
        /// This can be markedly more concise than working directly with the DOM methods,
        /// and takes advantage of Prototype's workarounds for various browser issues with certain attributes:
        /// </summary>
        /// <param name="tagName"> (String) – The name of the HTML element to create.</param>
        /// <param name="attributes">(Object) – An optional group of attribute/value pairs to set on the element.</param>
        ///<example>
        ///usage
        ///<code>
        /// // The old way:
        /// var a = document.createElement('a');
        /// a.setAttribute('class', 'foo');
        /// a.setAttribute('href', '/foo.html');
        /// a.appendChild(document.createTextNode("Next page"));
        ///  // The new way:
        /// var a = new Element('a', {'class': 'foo', href: '/foo.html'}).update("Next page");
        ///</code>
        ///</example>
        public Element(JsString tagName, object attributes) { }
        /// <summary>
        /// Creates an HTML element with tagName as the tag name, optionally with the given attributes.
        /// This can be markedly more concise than working directly with the DOM methods,
        /// and takes advantage of Prototype's workarounds for various browser issues with certain attributes:
        /// </summary>
        /// <param name="tagName"> (String) – The name of the HTML element to create.</param>
        ///<example>
        ///usage
        ///<code>
        /// // The old way:
        /// var a = document.createElement('a');
        /// a.setAttribute('class', 'foo');
        /// a.setAttribute('href', '/foo.html');
        /// a.appendChild(document.createTextNode("Next page"));
        ///  // The new way:
        /// var a = new Element('a', {'class': 'foo', href: '/foo.html'}).update("Next page");
        ///</code>
        ///</example>
        public Element(JsString tagName) { }

        //TODO: Element.Methods http://api.prototypejs.org/dom/Element/Methods/

        //TODO: Class methods (static methods)

        /// <summary>
        /// Turns element into an absolutely-positioned element without changing its position in the page layout.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element absolutize() { return null; }

        /// <summary>
        /// Adds the given CSS class to element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="className"> (String) – The class name to add.</param>
        /// <returns></returns>
        public Element addClassName(JsString className) { return null; }

        /// <summary>
        /// Finds all siblings of the current element that match the given selector(s). If you provide multiple selectors, siblings matching any of the selectors are included.
        /// If a sibling matches multiple selectors, it is only included once. The order of the returned array is not defined.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="selector">(String) – A CSS selector.</param>
        /// <returns></returns>
        public Element adjacent(params JsString selector) { return null; }

        /// <summary>
        /// Collects all of element's ancestor elements and returns them as an array of extended elements.
        /// The returned array's first element is element's direct ancestor (its parentNode), the second one is its grandparent, and so on until the &lt;html> element is reached.
        /// &lt;html> will always be the last member of the array. Calling ancestors on the &lt;html> element will return an empty array.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> ancestors() { return null; }

        /// <summary>
        /// Collects all of the element's children and returns them as an array of Element.extended elements, in document order.
        /// The first entry in the array is the topmost child of element, the next is the child after that, etc.
        /// Like all of Prototype's DOM traversal methods, Element.childElements ignores text nodes and returns element nodes only.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> childElements() { return null; }

        /// <summary>
        /// Returns a new instance of Element.ClassNames, an Enumerable object used to read and write CSS class names of element.
        /// Deprecated, please see Element.addClassName, Element.removeClassName, and Element.hasClassName.
        /// If you want an array of classnames, you can use $w(element.className).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<JsString> classNames() { return null; }

        /// <summary>
        /// Removes all of element's child text nodes that contain only whitespace. Returns element.
        /// This can be very useful when using standard properties like nextSibling, previousSibling, firstChild or lastChild to walk the DOM.
        /// Usually you'd only do that if you are interested in all of the DOM nodes, not just Elements (since if you just need to traverse the Elements in the DOM tree,
        /// you can use Element.up, Element.down, Element.next, and Element.previous instead).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element cleanWhitespace() { return null; }

        /// <summary>
        /// Returns a duplicate of element.
        /// A wrapper around DOM Level 2 Node#cloneNode, Element.clone cleans up any expando properties defined by Prototype.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="deep"> (Boolean) – Whether to clone element's descendants as well.</param>
        /// <returns></returns>
        public Element clone(bool deep) { return null; }

        /// <summary>
        /// Clones the position and/or dimensions of source onto the element as defined by options, with an optional offset for the left and top properties.
        /// Note that the element will be positioned exactly like source whether or not it is part of the same CSS containing block.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="source"> (Element | String) – The source element (or its ID).</param>
        /// <param name="options">(Object) – The position fields to clone.</param>
        /// <returns></returns>
        public Element clonePosition(HtmlElement source, PositionOptions options) { return null; }
        /// <summary>
        /// Clones the position and/or dimensions of source onto the element as defined by options, with an optional offset for the left and top properties.
        /// Note that the element will be positioned exactly like source whether or not it is part of the same CSS containing block.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="source"> (Element | String) – The source element (or its ID).</param>
        /// <returns></returns>
        public Element clonePosition(HtmlElement source) { return null; }
        /// <summary>
        /// Clones the position and/or dimensions of source onto the element as defined by options, with an optional offset for the left and top properties.
        /// Note that the element will be positioned exactly like source whether or not it is part of the same CSS containing block.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="source"> (Element | String) – The source element (or its ID).</param>
        /// <param name="options">(Object) – The position fields to clone.</param>
        /// <returns></returns>
        public Element clonePosition(JsString source, PositionOptions options) { return null; }
        /// <summary>
        /// Clones the position and/or dimensions of source onto the element as defined by options, with an optional offset for the left and top properties.
        /// Note that the element will be positioned exactly like source whether or not it is part of the same CSS containing block.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="source"> (Element | String) – The source element (or its ID).</param>
        /// <returns></returns>
        public Element clonePosition(JsString source) { return null; }

        /// <summary>
        /// Returns the offsets of element from the top left corner of the document.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Offset cumulativeOffset() { return null; }

        /// <summary>
        /// Calculates the cumulative scroll offset of an element in nested scrolling containers.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Offset cumulativeScrollOffset() { return null; }

        //TODO: you are here

    }

    [JsType(JsMode.Json)]
    public class PositionOptions
    {
        /// <summary>
        /// Default:true. Clones source's left CSS property onto element.
        /// </summary>
        public bool setLeft { get; set; }
        /// <summary>
        /// Default:true. Clones source's top CSS property onto element.
        /// </summary>
        public bool setTop { get; set; }
        /// <summary>
        /// Default: true.Clones source's width onto element.
        /// </summary>
        public bool setWidth { get; set; }
        /// <summary>
        /// Default:true. Clones source's width onto element.
        /// </summary>
        public bool setHeight { get; set; }
        /// <summary>
        /// Default: 0. Number by which to offset element's left CSS property.
        /// </summary>
        public bool offsetLeft { get; set; }
        /// <summary>
        /// Default: 0. Number by which to offset element's top CSS property.
        /// </summary>
        public bool offsetTop { get; set; }
    }

    /// <summary>
    /// A set of key/value pairs representing measurements of various dimensions of an element.
    /// The Element.Layout class is a specialized way to measure elements. It helps mitigate:
    /// The convoluted steps often needed to get common measurements for elements.
    /// The tendency of browsers to report measurements in non-pixel units.
    /// The quirks that lead some browsers to report inaccurate measurements.
    /// The difficulty of measuring elements that are hidden.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Element.Layout", Export = false)]
    public class Layout : Hash
    {
        /// <summary>
        /// Declare a new layout hash.
        /// The preCompute argument determines whether measurements will be lazy-loaded or not.
        /// If you plan to use many different measurements, it's often more performant to pre-compute, as it minimizes the amount of overhead needed to measure.
        /// If you need only one or two measurements, it's probably not worth it.
        /// </summary>
        /// <param name="element">(Element) – The element to be measured.</param>
        /// <param name="preCompute">(Boolean) – Whether to compute all values at once. Default is false.</param>
        public Layout(Element element, bool preCompute) { }
        /// <summary>
        /// Declare a new layout hash.
        /// The preCompute argument determines whether measurements will be lazy-loaded or not.
        /// If you plan to use many different measurements, it's often more performant to pre-compute, as it minimizes the amount of overhead needed to measure.
        /// If you need only one or two measurements, it's probably not worth it.
        /// </summary>
        /// <param name="element">(Element) – The element to be measured.</param>
        public Layout(Element element) { }

        /// <summary>
        /// Retrieve the measurement specified by property. Will throw an error if the property is invalid.
        /// </summary>
        /// <param name="property">(String) – One of the properties defined in Element.Layout.PROPERTIES.</param>
        /// <returns></returns>
        public static JsNumber get(JsString property) { return null; }

        /// <summary>
        /// Converts the layout hash to a plain object of CSS property/value pairs, optionally  including only the given keys.
        /// Keys can be passed into this method as individual arguments or separated by spaces within a string.
        /// </summary>
        /// <param name="keys"> (String) – A space-separated list of keys to include.</param>
        /// <returns></returns>
        public static object toCSS(params JsString[] keys) { return null; }
        //TODO: must check

        /// <summary>
        /// Converts the layout hash to an ordinary hash of key/value pairs, optionally including only the given keys.
        /// Keys can be passed into this method as individual arguments or separated by spaces within a string.
        /// </summary>
        /// <param name="keys"> (String) – A space-separated list of keys to include.</param>
        /// <returns></returns>
        public static Hash toHash(params JsString[] keys) { return null; }
        //TODO: must check

        /// <summary>
        ///Converts the layout hash to a plain object of key/value pairs, optionally including only the given keys.
        ///Keys can be passed into this method as individual arguments or separated by spaces within a string.
        /// </summary>
        /// <param name="keys"> (String) – A space-separated list of keys to include.</param>
        /// <returns></returns>
        public static object toObject(params JsString[] keys) { return null; }
        //TODO: must check

        public JsNumber height
        {
            [JsMethod(Name = "get", InsertArg0 = "'height'")]
            get;
            private set;
        }
        public JsNumber width
        {
            [JsMethod(Name = "get", InsertArg0 = "'width'")]
            get;
            private set;
        }
        public JsNumber top
        {
            [JsMethod(Name = "get", InsertArg0 = "'top'")]
            get;
            private set;
        }
        public JsNumber left
        {
            [JsMethod(Name = "get", InsertArg0 = "'left'")]
            get;
            private set;
        }
        public JsNumber right
        {
            [JsMethod(Name = "get", InsertArg0 = "'right'")]
            get;
            private set;
        }
        public JsNumber bottom
        {
            [JsMethod(Name = "get", InsertArg0 = "'bottom'")]
            get;
            private set;
        }
        public JsNumber border_left
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-left'")]
            get;
            private set;
        }
        public JsNumber border_right
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-right'")]
            get;
            private set;
        }
        public JsNumber border_top
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-top'")]
            get;
            private set;
        }
        public JsNumber border_bottom
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-bottom'")]
            get;
            private set;
        }
        public JsNumber padding_left
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-left'")]
            get;
            private set;
        }
        public JsNumber padding_right
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-right'")]
            get;
            private set;
        }
        public JsNumber padding_top
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-top'")]
            get;
            private set;
        }
        public JsNumber padding_bottom
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-bottom'")]
            get;
            private set;
        }
        public JsNumber margin_top
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-top'")]
            get;
            private set;
        }
        public JsNumber margin_bottom
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-bottom'")]
            get;
            private set;
        }
        public JsNumber margin_left
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-left'")]
            get;
            private set;
        }
        public JsNumber margin_right
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-right'")]
            get;
            private set;
        }

        //COMPOSITE_PROPERTIES:
        /// <summary>
        /// (width of the content area, from the beginning of the left padding to the end of the right padding)
        /// </summary>
        public JsNumber padding_box_width
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-box-width'")]
            get;
            private set;
        }
        /// <summary>
        /// (height of the content area, from the beginning of the top padding to the end of the bottom padding)
        /// </summary>
        public JsNumber padding_box_height
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-box-height'")]
            get;
            private set;
        }
        /// <summary>
        /// (width of the content area, from the outer edge of the left border to the outer edge of the right border)
        /// </summary>
        public JsNumber border_box_width
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-box-width'")]
            get;
            private set;
        }
        /// <summary>
        /// (height of the content area, from the outer edge of the top border to the outer edge of the bottom border)
        /// </summary>
        public JsNumber border_box_height
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-box-height'")]
            get;
            private set;
        }
        /// <summary>
        /// (width of the content area, from the beginning of the left margin to the end of the right margin)
        /// </summary>
        public JsNumber margin_box_width
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-box-width'")]
            get;
            private set;
        }
        /// <summary>
        /// (height of the content area, from the beginning of the top margin to the end of the bottom margin)
        /// </summary>
        public JsNumber margin_box_height
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-box-height'")]
            get;
            private set;
        }

    }

    /// <summary>
    /// A representation of the top- and left-offsets of an element relative to another.
    /// All methods that compute offsets return an instance of Element.Offset.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Element.Offset", Export = false)]
    public class Offset
    {
        /// <summary>
        /// Instantiates an Element.Offset. You shouldn't need to call this directly.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public Offset(JsNumber left, JsNumber top) { }

        /// <summary>
        /// Returns a debug-friendly representation of the offset.
        /// </summary>
        /// <returns></returns>
        public static JsString inspect() { return null; }

        /// <summary>
        /// Returns a new Element.Offset with its origin at the given offset. Useful for determining an element's distance from another arbitrary element.
        /// </summary>
        /// <param name="offset"> (Element.Offset) – Another offset to compare to.</param>
        /// <returns></returns>
        public static Offset relativeTo(Offset offset) { return null; }

        /// <summary>
        /// Returns an array representation fo the offset in [x, y] format.
        /// </summary>
        /// <returns></returns>
        public static JsArray toArray() { return null; }

        public JsString toString { get; set; }
    }

}

namespace SharpKit.PrototypeJs.Ajax
{
    [JsType(JsMode.Prototype, Name = "Ajax", Export = false)]
    public class Ajax
    {
        /// <summary>
        /// Represents the number of active XHR requests triggered through Ajax.Request, Ajax.Updater, or Ajax.PeriodicalUpdater.
        /// </summary>
        public JsNumber activeRequestCount { get; set; }
    }
    //TODO: May invented the class

    /// <summary>
    /// Prototype's APIs around the XmlHttpRequest object.
    /// The Prototype framework enables you to deal with Ajax calls in a manner that is both easy and compatible with all modern browsers.
    /// Actual requests are made by creating instances of Ajax.Request.
    /// Request headers:
    /// The following headers are sent with all Ajax requests (and can be overridden with the requestHeaders option described below):
    /// X-Requested-With is set to XMLHttpRequest.
    /// X-Prototype-Version is set to Prototype's current version (e.g., <%= PROTOTYPE_VERSION %>).
    /// Accept is set to text/javascript, text/html, application/xml, text/xml, * / *
    /// Content-type is automatically determined based on the contentType and encoding options.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AjaxOptions
    {
        /// <summary>
        /// (Boolean; default true): Determines whether XMLHttpRequest is used asynchronously or not.
        /// Synchronous usage is strongly discouraged — it halts all script execution for the duration of the request and blocks the browser UI.
        /// </summary>
        public bool asynchronous { get; set; }

        /// <summary>
        /// (String; default application/x-www-form-urlencoded): The Content-type header for your request.
        /// Change this header if you want to send data in another format (like XML).
        /// </summary>
        public JsString contentType { get; set; }

        /// <summary>
        /// (String; default UTF-8): The encoding for the contents of your request.
        /// It is best left as-is, but should weird encoding issues arise, you may have to tweak this.
        /// </summary>
        public JsString encoding { get; set; }

        /// <summary>
        /// (String; default post): The HTTP method to use for the request. The other common possibility is get.
        /// Abiding by Rails conventions,
        /// Prototype also reacts to other HTTP verbs(such as put and delete) by submitting via post and adding a extra _method parameter with the originally-requested method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// (String): The parameters for the request, which will be encoded into the URL for a get method, or into the request body for the other methods.
        /// This can be provided either as a URL-encoded string, a Hash, or a plain Object.
        /// </summary>
        public JsString parameters { get; set; }

        /// <summary>
        /// Specific contents for the request body on a post method. If it is not provided, the contents of the parameters option will be used instead.
        /// </summary>
        public JsString postBody { get; set; }

        /// <summary>
        /// A set of key-value pairs, with properties representing header names.
        /// </summary>
        public object requestHeaders { get; set; }

        /// <summary>
        /// (Boolean | String; default true):
        /// Automatically evals the content of Ajax.Response#responseText and populates Ajax.Response#responseJSON with it if the Content-type returned by the server is set to application/json.
        /// If the request doesn't obey same-origin policy, the content is sanitized before evaluation.
        /// If you need to force evalutation, pass 'force'. To prevent it altogether, pass false.
        /// </summary>
        public bool evalJS { get; set; }
        /// <summary>
        /// (Boolean | String; default true):
        /// Automatically evals the content of Ajax.Response#responseText and populates Ajax.Response#responseJSON with it if the Content-type returned by the server is set to application/json.
        /// If the request doesn't obey same-origin policy, the content is sanitized before evaluation.
        /// If you need to force evalutation, pass 'force'. To prevent it altogether, pass false.
        /// </summary>
        [JsProperty(Name = "evalJS")]
        public JsString evalJSString { get; set; }

        /// <summary>
        /// (Boolean; default is false for same-origin requests, true otherwise): Sanitizes the contents of Ajax.Response#responseText before evaluating it.
        /// </summary>
        public bool sanitizeJSON { get; set; }

        /// <summary>
        /// Triggered when the Ajax.Request object is initialized.
        /// This is after the parameters and the URL have been processed, but before opening the connection via the XHR object.
        /// </summary>
        public JsAction<Response, object> onCreate { get; set; }

        /// <summary>
        /// (Not guaranteed): Invoked just after the XHR object is created.
        /// </summary>
        public JsAction<Response, object> onUninitialized { get; set; }

        /// <summary>
        ///  (Not guaranteed): Triggered when the underlying XHR object is being setup, and its connection opened.
        /// </summary>
        public JsAction<Response, object> onLoading { get; set; }

        /// <summary>
        /// (Not guaranteed): Triggered once the underlying XHR object is setup, the connection is open, and it is ready to send its actual request.
        /// </summary>
        public JsAction<Response, object> onLoaded { get; set; }

        /// <summary>
        ///  (Not guaranteed): Triggered whenever the requester receives a part of the response (but not the final part), should it be sent in several packets.
        /// </summary>
        public JsAction<Response, object> onInteractive { get; set; }

        /// <summary>
        /// Invoked when a request completes and its status code is undefined or belongs in the 2xy family.
        /// This is skipped if a code-specific callback is defined (e.g., on200), and happens before onComplete.
        /// </summary>
        public JsAction<Response, object> onSuccess { get; set; }

        /// <summary>
        ///  Invoked when a request completes and its status code exists but is not in the 2xy family.
        ///  This is skipped if a code-specific callback is defined (e.g. on403), and happens before onComplete.
        /// </summary>
        public JsAction<Response, object> onFailure { get; set; }

        /// <summary>
        /// (with XYZ representing any HTTP status code): Invoked just after the response is complete if the status code is the exact code used in the callback name.
        /// Prevents execution of onSuccess and onFailure. Happens before onComplete.
        /// </summary>
        public JsAction<Response, object> onXYZ { get; set; }

        /// <summary>
        /// Triggered whenever an XHR error arises.
        /// Has a custom signature: the first argument is the requester (i.e. an Ajax.Request instance), and the second is the exception object.
        /// </summary>
        public JsAction<Response, object> onException { get; set; }

        /// <summary>
        /// Triggered at the very end of a request's life-cycle, after the request completes, status-specific callbacks are called,
        /// and possible automatic behaviors are processed. Guaranteed to run regardless of what happened during the request.
        /// </summary>
        public JsAction<Response, object> onComplete { get; set; }

    }

    /// <summary>
    /// Periodically performs an Ajax request and updates a container's contents based on the response text.
    /// Ajax.PeriodicalUpdater behaves like Ajax.Updater, but performs the update at a prescribed interval, rather than only once.
    /// (Note that it is not a subclass of Ajax.Updater; it's a wrapper around it.)
    /// This class addresses the common need of periodical update, as required by all sorts of "polling" mechanisms (e.g., an online chatroom or an online mail client).
    /// The basic idea is to run a regular Ajax.Updater at regular intervals,
    /// keeping track of the response text so it can (optionally) react to receiving the exact same response consecutively.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.PeriodicalUpdater", Export = false)]
    public class PeriodicalUpdater
    {
        /// <summary>
        /// Creates a new Ajax.PeriodicalUpdater.
        /// Periodically performs an AJAX request and updates a container's contents based on the response text.
        /// Offers a mechanism for "decay," which lets it trigger at widening intervals while the response is unchanged.
        /// This object addresses the common need of periodical update, which is used by all sorts of "polling" mechanisms (e.g. in an online chatroom or an online mail client).
        /// The basic idea is to run a regular Ajax.Updater at regular intervals, monitoring changes in the response text if the decay option (see below) is active.
        /// </summary>
        /// <param name="container">(String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options"> Configuration for the request. See the Ajax for more information.</param>
        public PeriodicalUpdater(JsString container, JsString url, PeriodicalUpdaterOptions options) { }
        /// <summary>
        /// Creates a new Ajax.PeriodicalUpdater.
        /// Periodically performs an AJAX request and updates a container's contents based on the response text.
        /// Offers a mechanism for "decay," which lets it trigger at widening intervals while the response is unchanged.
        /// This object addresses the common need of periodical update, which is used by all sorts of "polling" mechanisms (e.g. in an online chatroom or an online mail client).
        /// The basic idea is to run a regular Ajax.Updater at regular intervals, monitoring changes in the response text if the decay option (see below) is active.
        /// </summary>
        /// <param name="container">(String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        public PeriodicalUpdater(JsString container, JsString url) { }
        /// <summary>
        /// Creates a new Ajax.PeriodicalUpdater.
        /// Periodically performs an AJAX request and updates a container's contents based on the response text.
        /// Offers a mechanism for "decay," which lets it trigger at widening intervals while the response is unchanged.
        /// This object addresses the common need of periodical update, which is used by all sorts of "polling" mechanisms (e.g. in an online chatroom or an online mail client).
        /// The basic idea is to run a regular Ajax.Updater at regular intervals, monitoring changes in the response text if the decay option (see below) is active.
        /// </summary>
        /// <param name="container">(String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options"> Configuration for the request. See the Ajax for more information.</param>
        public PeriodicalUpdater(Element container, JsString url, PeriodicalUpdaterOptions options) { }
        /// <summary>
        /// Creates a new Ajax.PeriodicalUpdater.
        /// Periodically performs an AJAX request and updates a container's contents based on the response text.
        /// Offers a mechanism for "decay," which lets it trigger at widening intervals while the response is unchanged.
        /// This object addresses the common need of periodical update, which is used by all sorts of "polling" mechanisms (e.g. in an online chatroom or an online mail client).
        /// The basic idea is to run a regular Ajax.Updater at regular intervals, monitoring changes in the response text if the decay option (see below) is active.
        /// </summary>
        /// <param name="container">(String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        public PeriodicalUpdater(Element container, JsString url) { }

        /// <summary>
        /// Starts the periodical updater (if it had previously been stopped with Ajax.PeriodicalUpdater#stop).
        /// </summary>
        public static void start() { }

        /// <summary>
        /// Stops the periodical updater.
        /// Also calls the onComplete callback, if one has been defined.
        /// </summary>
        public static void stop() { }
    }

    /// <summary>
    /// Ajax.PeriodicalUpdater features all the common options and callbacks described in the Ajax — plus those added by Ajax.Updater.
    /// It also provides two new options:
    /// </summary>
    [JsType(JsMode.Json)]
    public class PeriodicalUpdaterOptions : UpdaterOptions
    {
        /// <summary>
        ///  (Number; default is 2): How long, in seconds, to wait between the end of one request and the beginning of the next.
        /// </summary>
        public JsNumber frequency { get; set; }

        /// <summary>
        /// (Number; default is 1): The rate at which the frequency grows when the response received is exactly the same as the previous.
        /// The default of 1 means frequency will never grow; override the default if a stale response implies it's worthwhile to poll less often.
        /// If decay is set to 2, for instance, frequency will double (2 seconds, 4 seconds, 8 seconds...) each consecutive time the result is the same;
        /// when the result is different once again, frequency will revert to its original value.
        /// </summary>
        public JsNumber decay { get; set; }
    }

    /// <summary>
    /// Initiates and processes an Ajax request.
    /// Ajax.Request is a general-purpose class for making HTTP requests which handles the life-cycle of the request, handles the boilerplate,
    /// and lets you plug in callback functions for your custom needs.
    /// In the optional options hash, you usually provide an onComplete and/or onSuccess callback,
    /// unless you're in the edge case where you're getting a JavaScript-typed response, that will automatically be eval'd.
    /// For a full list of common options and callbacks, see "Ajax options" heading of the Ajax.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.Request", Export = false)]
    public class Request
    {
        /// <summary>
        /// Creates a new Ajax.Request.
        /// </summary>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options"> (Object) – Configuration for the request. See the Ajax for more information.</param>
        public Request(JsString url, AjaxOptions options) { }
        /// <summary>
        /// Creates a new Ajax.Request.
        /// </summary>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        public Request(JsString url) { }

        /// <summary>
        /// Returns the value of the given response header, or null if that header was not found.
        /// </summary>
        /// <param name="name"> The name of an HTTP header that may have been part of the response.</param>
        /// <returns></returns>
        public static JsString getHeader(JsString name) { return null; }
        //TODO: can also return null

        /// <summary>
        /// Tests whether the request was successful.
        /// </summary>
        /// <returns></returns>
        public static bool success() { return false; }

    }

    /// <summary>
    /// A wrapper class around XmlHttpRequest for dealing with HTTP responses of Ajax requests.
    /// An instance of Ajax.Response is passed as the first argument of all Ajax requests' callbacks. You will not need to create instances of Ajax.Response yourself.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.Response", Export = false)]
    public class Response
    {
        /// <summary>
        /// Returns a String containing all headers separated by line breaks. Does not throw errors if no headers are present the way its native counterpart does.
        /// </summary>
        /// <returns></returns>
        public static JsString getAllHeaders() { return null; }
        //TODO: can also return null

        /// <summary>
        /// Returns a String containing all headers separated by line breaks; throws an error if no headers exist.
        /// This is just a wrapper around the XmlHttpRequest method of the same name. Prefer it's shorter counterpart: Ajax.Response#getAllHeaders.
        /// </summary>
        /// <returns></returns>
        public static JsString getAllResponseHeaders() { return null; }

        /// <summary>
        /// See Ajax.Request#getHeader.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static JsString getHeader(JsString name) { return null; }
        //TODO: can also return null

        /// <summary>
        /// Returns the value of the requested header if present; throws an error otherwise.
        /// This is just a wrapper around the XmlHttpRequest method of the same name. Prefer it's shorter counterpart: Ajax.Response#getHeader.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static JsString getResponseHeader(JsString name) { return null; }

        //TODO: the following propertyes should be here or in an optios class?

        /// <summary>
        /// Auto-evaluated content of the X-JSON header if present; null otherwise. This is useful to transfer small amounts of data.
        /// </summary>
        public object headerJSON { get; set; }
        /// <summary>
        /// Auto-evaluated content of the X-JSON header if present; null otherwise. This is useful to transfer small amounts of data.
        /// </summary>
        [JsProperty(Name = "headerJSON")]
        public JsArray headerJSONArray { get; set; }
        //TODO: can also be null type

        /// <summary>
        /// A Number corresponding to the request's current state.
        /// 0 : "Uninitialized"
        /// 1 : "Loading"
        /// 2 : "Loaded"
        /// 3 : "Interactive"
        /// 4 : "Complete"
        /// </summary>
        public JsNumber readyState { get; set; }
        //TODO: maybe eunm?

        /// <summary>
        /// The request object itself (an instance of Ajax.Request or Ajax.Updater).
        /// </summary>
        public Request request { get; set; }
        /// <summary>
        /// The request object itself (an instance of Ajax.Request or Ajax.Updater).
        /// </summary>
        [JsProperty(Name = "request")]
        public Updater requestUpdater { get; set; }

        /// <summary>
        /// The JSON body of the response if the Content-type of the request is set to application/json; null otherwise.
        /// </summary>
        public object responseJSON { get; set; }
        /// <summary>
        /// The JSON body of the response if the Content-type of the request is set to application/json; null otherwise.
        /// </summary>
        [JsProperty(Name = "responseJSON")]
        public JsArray responseJSONArray { get; set; }

        /// <summary>
        /// The XML body of the response if the Content-type of the request is set to application/xml; null otherwise.
        /// </summary>
        public document responseXML { get; set; }
        //TODO: type can be null

        /// <summary>
        /// The HTTP status code sent by the server.
        /// </summary>
        public JsNumber status { get; set; }

        /// <summary>
        /// The HTTP status text sent by the server.
        /// </summary>
        public JsString statusText { get; set; }

        /// <summary>
        /// The native XmlHttpRequest object itself.
        /// </summary>
        public XMLHttpRequest transport { get; set; }
    }

    /// <summary>
    /// A class that performs an Ajax request and updates a container's contents with the contents of the response.
    /// Ajax.Updater is a subclass of Ajax.Request built for a common use-case.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.Response", Export = false)]
    public class Updater : Request
    {
        /// <summary>
        /// Creates a new Ajax.Updater.
        /// </summary>
        /// <param name="container"> (String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url"> (String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options">(Object) – Configuration for the request. See the Ajax for more information.</param>
        public Updater(JsString container, JsString url, UpdaterOptions options) : base(url, options) { }
        /// <summary>
        /// Creates a new Ajax.Updater.
        /// </summary>
        /// <param name="container"> (String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url"> (String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options">(Object) – Configuration for the request. See the Ajax for more information.</param>
        public Updater(JsString container, JsString url) : base(url, null) { }
        /// <summary>
        /// Creates a new Ajax.Updater.
        /// </summary>
        /// <param name="container"> (String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url"> (String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options">(Object) – Configuration for the request. See the Ajax for more information.</param>
        public Updater(Element container, JsString url, UpdaterOptions options) : base(url, options) { }
        /// <summary>
        /// Creates a new Ajax.Updater.
        /// </summary>
        /// <param name="container"> (String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url"> (String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options">(Object) – Configuration for the request. See the Ajax for more information.</param>
        public Updater(Element container, JsString url) : base(url, null) { }
    }

    /// <summary>
    /// Ajax.Updater has some options of its own apart from the common options described in the Ajax:
    /// </summary>
    [JsType(JsMode.Json)]
    public class UpdaterOptions : AjaxOptions
    {
        /// <summary>
        /// (Boolean; defaults to false): Whether <script> elements in the response text should be evaluated.
        /// </summary>
        public bool evalScripts { get; set; }

        /// <summary>
        ///  (String): By default, Element.update is used, meaning the contents of the response will replace the entire contents of the container.
        ///  You may instead insert the response text without disrupting existing contents.
        ///  The insertion option takes one of four strings — top, bottom, before, or after — and inserts the contents of the response in the manner described by Element#insert.
        /// </summary>
        public JsString insertion { get; set; }
    }
}
namespace SharpKit.PrototypeJs.Ajax.Responders
{
    /// <summary>
    /// A repository of global listeners notified about every step of Prototype-based Ajax requests.
    /// Sometimes, you need to provide generic behaviors over all Ajax operations happening on the page (through Ajax.Request, Ajax.Updater or Ajax.PeriodicalUpdater).
    /// For instance, you might want to automatically show an indicator when an Ajax request is ongoing, and hide it when none are.
    /// You may well want to factor out exception handling as well, logging those somewhere on the page in a custom fashion. The possibilities are myriad.
    /// To achieve this, Prototype provides Ajax.Responders, which lets you register (and, if you wish, unregister later) responders, which are objects with specially-named methods.
    /// These names come from a set of general callbacks corresponding to different points in time (or outcomes) of an Ajax request's life cycle.
    /// For instance, Prototype automatically registers a responder that maintains a nifty variable: Ajax.activeRequestCount.
    /// This represents, at a given time, the number of currently active Ajax requests — by monitoring their onCreate and onComplete events. 
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.Responders", Export = false)]
    public class Responders
    {
        /// <summary>
        /// Add a group of responders to all Ajax requests.
        /// </summary>
        /// <param name="responder"> A list of functions with keys corresponding to the names of possible callbacks.</param>
        public void register(object responder) { }

        /// <summary>
        /// Remove a previously-added group of responders.
        /// As always, unregistering something requires you to use the very same object you used at registration.
        /// If you plan to use unregister, be sure to assign your responder to a variable before passing it into Ajax.Responders#register — don't pass it an object literal.
        /// </summary>
        /// <param name="responder">  A list of functions with keys corresponding to the names of possible callbacks.</param>
        public void unregister(object responder) { }
    }
    //TODO: think it is a namespce not a class

    /// <summary>
    /// The callbacks for responders are similar to the callbacks described in the Ajax, but take a different signature.
    /// They're invoked with three parameters: the requester object (i.e., the corresponding "instance" of Ajax.Request),
    /// the XMLHttpRequest object, and the result of evaluating the X-JSON response header, if any (can be null).
    /// They also execute in the context of the responder, bound to the this reference.
    /// </summary>
    [JsType(JsMode.Json)]
    public class RespondersOptions
    {

        /// <summary>
        /// Triggered whenever a requester object from the Ajax namespace is created, after its parameters are adjusted and before its XHR connection is opened.
        /// This takes two arguments: the requester object and the underlying XHR object.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onCreate { get; set; }

        /// <summary>
        /// (Not guaranteed): Invoked just after the XHR object is created.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onUninitialized { get; set; }

        /// <summary>
        /// (Not guaranteed): Triggered when the underlying XHR object is being setup, and its connection opened.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onLoading { get; set; }

        /// <summary>
        /// (Not guaranteed): Triggered once the underlying XHR object is setup, the connection is open, and it is ready to send its actual request.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onLoaded { get; set; }

        /// <summary>
        /// (Not guaranteed): Triggered whenever the requester receives a part of the response (but not the final part), should it be sent in several packets.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onInteractive { get; set; }

        /// <summary>
        /// Triggered whenever an XHR error arises.
        /// Has a custom signature: the first argument is the requester (i.e. an Ajax.Request instance), and the second is the exception object.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onException { get; set; }

        /// <summary>
        /// Triggered at the very end of a request's life-cycle, after the request completes, status-specific callbacks are called, and possible automatic behaviors are processed.
        /// Guaranteed to run regardless of what happened during the request.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onComplete { get; set; }

    }
}
//TODO: make sure namespce is OK

namespace SharpKit.PrototypeJs.Abstract
{
    [JsType(JsMode.Prototype, Name = "Abstract.EventObserver", Export = false)]
    public class EventObserver
    {
    }

    /// <summary>
    /// An abstract DOM element observer class, subclasses of which can be used to periodically check a value and trigger a callback when the value has changed.
    /// A TimedObserver object will try to check a value using the getValue() instance method which must be defined by the subclass.
    /// There are two out-of-the-box subclasses: Form.Observer, which serializes a form and triggers when the result has changed;
    /// and Form.Element.Observer, which triggers when the value of a given form field changes.
    /// Using TimedObserver implementations is straightforward; simply instantiate them with appropriate arguments.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Abstract.TimedObserver", Export = false)]
    public class TimedObserver
    {
        /// <summary>
        /// Initializes an Abstract.TimedObserver; used by subclasses.
        /// </summary>
        /// <param name="element">(String | Element) – The DOM element to watch. Can be an element instance or an ID.</param>
        /// <param name="frequency">(Number) – The frequency, in seconds — e.g., 0.33 to check for changes every third of a second.</param>
        /// <param name="callback"> (Function) – The callback to trigger when the value changes.</param>
        public TimedObserver(JsString element, JsNumber frequency, JsAction callback) { }
        /// <summary>
        /// Initializes an Abstract.TimedObserver; used by subclasses.
        /// </summary>
        /// <param name="element">(String | Element) – The DOM element to watch. Can be an element instance or an ID.</param>
        /// <param name="frequency">(Number) – The frequency, in seconds — e.g., 0.33 to check for changes every third of a second.</param>
        /// <param name="callback"> (Function) – The callback to trigger when the value changes.</param>
        public TimedObserver(HtmlElement element, JsNumber frequency, JsAction callback) { }

    }
}

public class Template
{
    //TODO: http://api.prototypejs.org/language/Template/
}



public class Event
{
}

public class Hash
{
}


public static class JsStringExtensions
{

    //TODO: interpret

    /// <summary>
    /// Check if the string is "blank" — either empty (length of 0) or containing only whitespace.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static bool blank(this JsString s) { return false; }

    /// <summary>
    /// Converts a string separated by dashes into a camelCase equivalent. For instance, 'foo-bar' would be converted to 'fooBar'.
    /// Prototype uses this internally for translating CSS properties into their DOM style property equivalents.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString camelize(this JsString s) { return null; }

    /// <summary>
    /// Capitalizes the first letter of a string and downcases all the others.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString capitalize(this JsString s) { return null; }

    /// <summary>
    /// Replaces every instance of the underscore character "_" by a dash "-".
    /// Note: Used in conjunction with String#underscore, String#dasherize converts a DOM style into its CSS equivalent.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString dasherize(this JsString s) { return null; }

    /// <summary>
    /// Checks if the string is empty.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static bool empty(this JsString s) { return false; }

    /// <summary>
    /// Checks if the string ends with substring.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString endsWith(this JsString s) { return null; }

    /// <summary>
    /// Converts HTML special characters to their entity equivalents.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString escapeHTML(this JsString s) { return null; }

    /// <summary>
    /// Evaluates the JSON in the string and returns the resulting object.
    /// If the optional sanitize parameter is set to true, the string is checked for possible malicious attempts; if one is detected, eval is not called.
    /// Warning:
    /// If the JSON string is not well formated or if a malicious attempt is detected a SyntaxError is thrown.
    /// Note:
    /// Always set the sanitize parameter to true for data coming from externals sources to prevent XSS attacks.
    /// As String#evalJSON internally calls String#unfilterJSON, optional security comment delimiters (defined in Prototype.JSONFilter) are automatically removed.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="sanitize"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static object evalJSON(this JsString s, bool sanitize) { return null; }
    /// <summary>
    /// Evaluates the JSON in the string and returns the resulting object.
    /// If the optional sanitize parameter is set to true, the string is checked for possible malicious attempts; if one is detected, eval is not called.
    /// Warning:
    /// If the JSON string is not well formated or if a malicious attempt is detected a SyntaxError is thrown.
    /// Note:
    /// Always set the sanitize parameter to true for data coming from externals sources to prevent XSS attacks.
    /// As String#evalJSON internally calls String#unfilterJSON, optional security comment delimiters (defined in Prototype.JSONFilter) are automatically removed.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static object evalJSON(this JsString s) { return null; }

    /// <summary>
    /// Evaluates the content of any inline &lt;script> block present in the string.
    /// Returns an array containing the value returned by each script. &lt;script> blocks referencing external files will be treated as though they were empty
    /// (the result for that position in the array will be undefined);
    /// external files are not loaded and processed by String#evalScripts.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsArray evalScripts(this JsString s) { return null; }

    /// <summary>
    /// Extracts the content of any &lt;script> blocks present in the string and returns them as an array of strings.
    /// This method is used internally by String#evalScripts. It does not evaluate the scripts (use String#evalScripts to do that),
    /// but can be usefull if you need to evaluate the scripts at a later date.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsArray extractScripts(this JsString s) { return null; }

    /// <summary>
    /// Returns the string with every occurence of a given pattern replaced by either a regular string, the returned value of a function or a Template string.
    /// The pattern can be a string or a regular expression.
    /// If its second argument is a string String#gsub works just like the native JavaScript method replace() set to global match.
    /// If you pass it a function, it will be invoked for every occurrence of the pattern with the match of the current pattern as its unique argument.
    /// Note that this argument is the returned value of the match() method called on the current pattern.
    /// It is in the form of an array where the first element is the entire match and every subsequent one corresponds to a parenthesis group in the regex.
    /// Lastly, you can pass String#gsub a Template string in which you can also access the returned value of the match() method using the ruby inspired notation:
    /// #{0} for the first element of the array, #{1} for the second one, and so on. So our last example could be easily re-written as:
    /// If you need an equivalent to String#gsub but without global match set on, try String#sub.
    /// Note: Do not use the "g" flag on the regex as this will create an infinite loop.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="pattern"></param>
    /// <param name="replacement"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString gsub(this JsString s, JsString pattern, JsFunc<JsString> replacement) { return null; }
    /// <summary>
    /// Returns the string with every occurence of a given pattern replaced by either a regular string, the returned value of a function or a Template string.
    /// The pattern can be a string or a regular expression.
    /// If its second argument is a string String#gsub works just like the native JavaScript method replace() set to global match.
    /// If you pass it a function, it will be invoked for every occurrence of the pattern with the match of the current pattern as its unique argument.
    /// Note that this argument is the returned value of the match() method called on the current pattern.
    /// It is in the form of an array where the first element is the entire match and every subsequent one corresponds to a parenthesis group in the regex.
    /// Lastly, you can pass String#gsub a Template string in which you can also access the returned value of the match() method using the ruby inspired notation:
    /// #{0} for the first element of the array, #{1} for the second one, and so on. So our last example could be easily re-written as:
    /// If you need an equivalent to String#gsub but without global match set on, try String#sub.
    /// Note: Do not use the "g" flag on the regex as this will create an infinite loop.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="pattern"></param>
    /// <param name="replacement"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString gsub(this JsString s, JsString pattern, JsString replacement) { return null; }
    /// <summary>
    /// Returns the string with every occurence of a given pattern replaced by either a regular string, the returned value of a function or a Template string.
    /// The pattern can be a string or a regular expression.
    /// If its second argument is a string String#gsub works just like the native JavaScript method replace() set to global match.
    /// If you pass it a function, it will be invoked for every occurrence of the pattern with the match of the current pattern as its unique argument.
    /// Note that this argument is the returned value of the match() method called on the current pattern.
    /// It is in the form of an array where the first element is the entire match and every subsequent one corresponds to a parenthesis group in the regex.
    /// Lastly, you can pass String#gsub a Template string in which you can also access the returned value of the match() method using the ruby inspired notation:
    /// #{0} for the first element of the array, #{1} for the second one, and so on. So our last example could be easily re-written as:
    /// If you need an equivalent to String#gsub but without global match set on, try String#sub.
    /// Note: Do not use the "g" flag on the regex as this will create an infinite loop.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="pattern"></param>
    /// <param name="replacement"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString gsub(this JsString s, JsString pattern, Template replacement) { return null; }

    /// <summary>
    /// Checks if the string contains substring.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="substring"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static bool include(this JsString s, JsString substring) { return false; }

    /// <summary>
    /// Returns a debug-oriented version of the string (i.e. wrapped in single or double quotes, with backslashes and quotes escaped).
    /// For more information on inspect methods, see Object.inspect.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="useDoubleQuotes"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString inspect(this JsString s, bool useDoubleQuotes) { return null; }
    /// <summary>
    /// Returns a debug-oriented version of the string (i.e. wrapped in single or double quotes, with backslashes and quotes escaped).
    /// For more information on inspect methods, see Object.inspect.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString inspect(this JsString s) { return null; }

    /// <summary>
    /// Treats the string as a Template and fills it with object's properties.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="object"></param>
    /// <param name="pattern"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString interpolate(this JsString s, object @object, JsString pattern) { return null; }
    /// <summary>
    /// Treats the string as a Template and fills it with object's properties.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="object"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString interpolate(this JsString s, object @object) { return null; }

    /// <summary>
    /// Check if the string is valid JSON by the use of regular expressions. This security method is called internally.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static bool isJSON(this JsString s) { return false; }

    /// <summary>
    /// Aliased as: String#toQueryParams:
    /// Parses a URI-like query string and returns an object composed of parameter/value pairs.
    /// This method is realy targeted at parsing query strings (hence the default value of"&" for the separator argument).
    /// For this reason, it does not consider anything that is either before a question mark (which signals the beginning of a query string)
    /// or beyond the hash symbol ("#"), and runs decodeURIComponent() on each parameter/value pair.
    /// String#toQueryParams also aggregates the values of identical keys into an array of values.
    /// Note that parameters which do not have a specified value will be set to undefined.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static object parseQuery(this JsString s, JsString separator) { return null; }

    /// <summary>
    /// Allows iterating over every occurrence of the given pattern (which can be a string or a regular expression). Returns the original string.
    /// Internally just calls String#gsub passing it pattern and iterator as arguments.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="pattern"></param>
    /// <param name="iterator"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString scan(this JsString s, JsString pattern, JsAction<JsRegExpResult> iterator) { return null; }
    /// <summary>
    /// Allows iterating over every occurrence of the given pattern (which can be a string or a regular expression). Returns the original string.
    /// Internally just calls String#gsub passing it pattern and iterator as arguments.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="pattern"></param>
    /// <param name="iterator"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString scan(this JsString s, JsRegExp pattern, JsAction<JsRegExpResult> iterator) { return null; }

    /// <summary>
    /// Checks if the string starts with substring.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="substring"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static bool startsWith(this JsString s, JsString substring) { return false; }

    /// <summary>
    /// Strips all leading and trailing whitespace from a string.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString strip(this JsString s) { return null; }

    /// <summary>
    /// Strips a string of things that look like an HTML script blocks.
    /// Note that the processing String#stripScripts does is good enough for most purposes, but you cannot rely on it for security purposes.
    /// If you're processing end-user-supplied content, String#stripScripts is probably not sufficiently robust to prevent hack attacks.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    ///<example>
    ///usage
    ///<code>
    ///&quot;&lt;p&gt;This is a test.&lt;script&gt;alert(&quot;Look, a test!&quot;);&lt;/script&gt;End of test&lt;/p&gt;&quot;.stripScripts();
    /// // =&gt; &quot;&lt;p&gt;This is a test.End of test&lt;/p&gt;&quot;
    ///</code>
    ///</example>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString stripScripts(this JsString s) { return null; }

    /// <summary>
    /// Strips a string of any HTML tags.
    /// Note that String#stripTags will only strip HTML 4.01 tags — like div, span, and abbr. It will not strip namespace-prefixed tags such as h:table or xsl:template.
    /// Watch out for &lt;script> tags in your string, as String#stripTags will not remove their content. Use String#stripScripts to do so.
    /// Caveat User:
    /// Note that the processing String#stripTags does is good enough for most purposes, but you cannot rely on it for security purposes.
    /// If you're processing end-user-supplied content, String#stripTags is not sufficiently robust to ensure that the content is completely
    /// devoid of HTML tags in the case of a user intentionally trying to circumvent tag restrictions.
    /// But then, you'll be running them through String#escapeHTML anyway, won't you?
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    ///<example>
    ///usage
    ///<code>
    ///&#39;a &lt;a href=&quot;#&quot;&gt;link&lt;/a&gt;&#39;.stripTags();
    ///  // -&gt; &#39;a link&#39;
    ///  &#39;a &lt;a href=&quot;#&quot;&gt;link&lt;/a&gt;&lt;script&gt;alert(&quot;hello world!&quot;);&lt;/script&gt;&#39;.stripTags();
    /// // -&gt; &#39;a linkalert(&quot;hello world!&quot;);&#39;
    ///  &#39;a &lt;a href=&quot;#&quot;&gt;link&lt;/a&gt;&lt;script&gt;alert(&quot;hello world!&quot;);&lt;/script&gt;&#39;.stripScripts().stripTags();
    /// // -&gt; &#39;a link&#39;
    ///</code>
    ///</example>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString stripTags(this JsString s) { return null; }

    /// <summary>
    /// Returns a string with the first count occurrences of pattern replaced by either a regular string, the returned value of a function or a Template string.
    /// pattern can be a string or a regular expression.
    /// Unlike String#gsub, String#sub takes a third optional parameter which specifies the number of occurrences of the pattern which will be replaced.
    /// If not specified, it will default to 1.
    /// Apart from that, String#sub works just like String#gsub. Please refer to it for a complete explanation.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="pattern"></param>
    /// <param name="replacement"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString sub(this JsString s, JsString pattern, object replacement, JsNumber count) { return null; }
    /// <summary>
    /// Returns a string with the first count occurrences of pattern replaced by either a regular string, the returned value of a function or a Template string.
    /// pattern can be a string or a regular expression.
    /// Unlike String#gsub, String#sub takes a third optional parameter which specifies the number of occurrences of the pattern which will be replaced.
    /// If not specified, it will default to 1.
    /// Apart from that, String#sub works just like String#gsub. Please refer to it for a complete explanation.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="pattern"></param>
    /// <param name="replacement"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString sub(this JsString s, JsRegExp pattern, object replacement, JsNumber count) { return null; }

    /// <summary>
    /// Used internally by ObjectRange.
    /// Converts the last character of the string to the following character in the Unicode alphabet.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString succ(this JsString s) { return null; }

    /// <summary>
    /// Concatenates the string count times.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString times(this JsString s, JsNumber count) { return null; }

    /// <summary>
    /// Splits the string character-by-character and returns an array with the result.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsArray toArray(this JsString s) { return null; }

    /// <summary>
    /// Parses a URI-like query string and returns an object composed of parameter/value pairs.
    /// This method is realy targeted at parsing query strings (hence the default value of"&" for the separator argument).
    /// For this reason, it does not consider anything that is either before a question mark (which signals the beginning of a query string) or beyond the hash symbol ("#"),
    /// and runs decodeURIComponent() on each parameter/value pair.
    /// String#toQueryParams also aggregates the values of identical keys into an array of values.
    /// Note that parameters which do not have a specified value will be set to undefined.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static object toQueryParams(this JsString s, JsString separator) { return null; }
    /// <summary>
    /// Parses a URI-like query string and returns an object composed of parameter/value pairs.
    /// This method is realy targeted at parsing query strings (hence the default value of"&" for the separator argument).
    /// For this reason, it does not consider anything that is either before a question mark (which signals the beginning of a query string) or beyond the hash symbol ("#"),
    /// and runs decodeURIComponent() on each parameter/value pair.
    /// String#toQueryParams also aggregates the values of identical keys into an array of values.
    /// Note that parameters which do not have a specified value will be set to undefined.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static object toQueryParams(this JsString s) { return null; }

    /// <summary>
    /// Truncates a string to given length and appends suffix to it (indicating that it is only an excerpt).
    /// </summary>
    /// <param name="s"></param>
    /// <param name="length"></param>
    /// <param name="suffix"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString truncate(this JsString s, JsNumber length, JsString suffix) { return null; }
    /// <summary>
    /// Truncates a string to given length and appends suffix to it (indicating that it is only an excerpt).
    /// </summary>
    /// <param name="s"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString truncate(this JsString s, JsNumber length) { return null; }
    /// <summary>
    /// Truncates a string to given length and appends suffix to it (indicating that it is only an excerpt).
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString truncate(this JsString s) { return null; }

    /// <summary>
    /// Converts a camelized string into a series of words separated by an underscore (_).
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString underscore(this JsString s) { return null; }

    /// <summary>
    /// Strips tags and converts the entity forms of special HTML characters to their normal form.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString unescapeHTML(this JsString s) { return null; }

    /// <summary>
    /// Strips comment delimiters around Ajax JSON or JavaScript responses. This security method is called internally.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="filter"></param>
    /// <returns></returns>
    [JsMethod(ExtensionImplementedInInstance = true)]
    public static JsString unfilterJSON(this JsString s, object filter) { return null; }
}



