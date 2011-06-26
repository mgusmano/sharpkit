using System;
using System.Collections;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.Html4
{

    #region HtmlAnchor
    [JsType(JsMode.Prototype, Export = false, Name = "A")]
    public partial class HtmlAnchor : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves a destination URL or an anchor point.
        ///</summary>
        public JsString href { get; set; }
        ///<summary>
        ///Sets or retrieves the window or frame at which to target content.
        ///</summary>
        public JsString target { get; set; }
        ///<summary>
        ///Sets or retrieves the character set used to encode the object.
        ///</summary>
        public JsString charset { get; set; }
        ///<summary>
        ///Sets or retrieves the coordinates of the object.
        ///</summary>
        public JsString coords { get; set; }
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        ///<summary>
        ///Sets or retrieves the subsection of the href property that follows the number sign (#).
        ///</summary>
        public JsString hash { get; set; }
        ///<summary>
        ///Sets or retrieves the hostname and port number of the location or URL.
        ///</summary>
        public JsString host { get; set; }
        ///<summary>
        ///Sets or retrieves the host name part of the location or URL.
        ///</summary>
        public JsString hostname { get; set; }
        ///<summary>
        ///Sets or retrieves the language code of the object.
        ///</summary>
        public JsString hreflang { get; set; }
        ///<summary>
        ///Sets or gets the list of HTTP methods supported by the object.
        ///</summary>
        public JsString Methods { get; set; }
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name { get; set; }
        ///<summary>
        ///Retrieves the file name specified in the href or src property of the object.
        ///</summary>
        public JsString nameProp { get; set; }
        ///<summary>
        ///Sets or retrieves the file name or path specified by the object.
        ///</summary>
        public JsString pathname { get; set; }
        ///<summary>
        ///Sets or retrieves the port number associated with a URL.
        ///</summary>
        public JsString port { get; set; }
        ///<summary>
        ///Sets or retrieves the protocol portion of a URL.
        ///</summary>
        public JsString protocol { get; set; }
        ///<summary>
        ///Sets or retrieves the relationship between the object and the destination of the link.
        ///</summary>
        public JsString rel { get; set; }
        ///<summary>
        ///Sets or retrieves the relationship between the object and the destination of the link.
        ///</summary>
        public JsString rev { get; set; }
        ///<summary>
        ///Sets or retrieves the substring of the href property that follows the question mark.
        ///</summary>
        public JsString search { get; set; }
        /// <summary>
        /// Sets or retrieves the shape of the object.
        /// Possible values:
        ///	circ		Circle
        /// circle		Circle
        /// poly		Polygon
        /// polygon		Polygon
        /// rect		Rectangle
        /// rectangle	Rectangle
        /// </summary>
        public JsString shape { get; set; }
        ///<summary>
        ///Sets or retrieves the MIME type of the object. e.g. 'text/css'
        ///</summary>
        public JsString type { get; set; }
        ///<summary>
        ///Sets or gets a Uniform Resource OriginalValue (URN) for a target document.
        ///</summary>
        public JsString urn { get; set; }
    }
    #endregion
    #region HtmlAppletElement
    ///<summary>
    ///The applet element is a Java-specific variant of the embed element. The applet element is now obsoleted so that all extension frameworks (Java, .NET, Flash, etc) are handled in a consistent manner.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlAppletElement : HtmlElement
    {
        public JsString align { get; set; }
        public JsString alt { get; set; }
        public JsString archive { get; set; }
        public JsString code { get; set; }
        public JsString codeBase { get; set; }
        public JsString height { get; set; }
        public ulong hspace { get; set; }
        public JsString name { get; set; }
        public JsString _object { get; set; }
        public ulong vspace { get; set; }
        public JsString width { get; set; }
    }
    #endregion
    #region HtmlAttribute
    ///<summary>
    ///Represents an HTML Attribute node
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ATTRIBUTE")]
    public partial class HtmlAttribute : HtmlNode
    {
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString name { get; set; }
    }
    #endregion
    #region HtmlBaseElement
    ///<summary>
    ///The base element allows authors to specify the document base URL for the purposes of resolving relative URLs , and the name of the default browsing context for the purposes of following hyperlinks . The element does not represent any content beyond this information.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlBaseElement : HtmlElement
    {
        public JsString href { get; set; }
        public JsString target { get; set; }
    }
    #endregion
    #region HtmlBaseFontElement
    ///<summary>
    ///User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlBaseFontElement : HtmlElement
    {
        public JsString color { get; set; }
        public JsString face { get; set; }
        public long size { get; set; }
    }
    #endregion
    #region HtmlBody
    ///<summary>
    ///Represents the root Body element of a HTML document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "BODY")]
    public partial class HtmlBody : HtmlElement
    {
        protected HtmlBody() { }
        ///<summary>
        ///Creates a TextRange object for the element
        ///</summary>
        ///<returns></returns>
        public HtmlTextRange createTextRange() { return null; }
        ///<summary>
        ///Fires on the object immediately after its associated document prints or previews for printing.
        ///</summary>		
        public HtmlDomEventHandler onafterprint;
        ///<summary>
        ///Fires on the object before its associated document prints or previews for printing.
        ///</summary>		
        public HtmlDomEventHandler onbeforeprint;
        ///<summary>
        ///Fires prior to a page being unloaded.
        ///</summary>		
        public HtmlDomEventHandler onbeforeunload;
        ///<summary>
        ///Raised when there are changes to the portion of a URL that follows the number sign (#).
        ///</summary>		
        public new HtmlDomEventHandler onhashchange;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
        ///<summary>
        ///Raised when Internet Explorer is working offline.
        ///</summary>		
        public HtmlDomEventHandler onoffline;
        ///<summary>
        ///Raised when Internet Explorer is working online.
        ///</summary>		
        public HtmlDomEventHandler ononline;
        ///<summary>
        ///Fires when the current selection changes.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public HtmlDomEventHandler onselect;
        ///<summary>
        ///Fires immediately before the object is unloaded.
        ///</summary>		
        public HtmlDomEventHandler onunload;
    }
    #endregion
    #region HtmlBr
    ///<summary>
    ///Inserts a line break.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "BR")]
    public partial class HtmlBr : HtmlElement
    {
        protected HtmlBr() { }
    }
    #endregion
    #region HtmlButton
    ///<summary>
    ///Specifies a container for rich HTML that is rendered as a button.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "BUTTON")]
    public partial class HtmlButton : HtmlElement
    {
        ///<summary>
        ///Sets the access key for the object.
        ///</summary>
        public new JsString accessKey { get; set; }
        /// <summary>
        /// Gets the classification and default behavior of the button.
        /// Possible values:
        ///	button	Default. Creates a Command button.
        /// reset	Creates a Reset button. If the button is in a form, it resets the fields in the form to their initial values.
        /// submit	Creates a Submit button. If the button is in a form, it submits the form.
        /// </summary>
        public JsString type { get; set; }
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name { get; set; }
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form { get; set; }
        /// <summary>
        /// Sets or retrieves the value indicating whether the control is selected.
        /// Possible values:
        ///	false	Default. Control is not selected.
        /// true	Control is selected.
        /// null	Control is not initialized.
        /// </summary>
        public JsBoolean status { get; set; }
        ///<summary>
        ///Sets or retrieves the default or selected value of the control.
        ///</summary>
        public JsString value { get; set; }
    }
    #endregion
    #region HtmlCaption
    ///<summary>
    ///Specifies a brief description for a table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "CAPTION")]
    public partial class HtmlCaption : HtmlElement
    {
        ///<summary>
        ///String that specifies or receives one of the following values.
        ///</summary>
        ///<remarks>
        ///<list type="table">
        ///<item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
        ///<item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
        ///<item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
        ///<item><term>top</term><description>Aligns the text at the top of the object.</description></item>
        ///</list>
        ///</remarks>
        public JsString vAlign { get; set; }
    }
    #endregion
    #region HtmlClipboardData
    ///<summary>
    ///Provides access to predefined clipboard formats for use in editing operations.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "CLIPBOARDDATA")]
    public partial class HtmlClipboardData
    {
        ///<summary>
        ///Assigns data in a specified format to the dataTransfer object or the clipboardData object.
        ///</summary>
        ///<param name="sDataFormat">Required. A String that specifies the format of the data to be transferred, using one of the following values. </param>
        ///<param name="sData">Required. A String that specifies the data supplied by the source object. This information can be descriptive text, a source path to an image, or a URL for an anchor. When you pass "URL" as the sDataFormat parameter, you must use the sData parameter to provide the location of the object that is transferred. </param>
        public void setData(JsString sDataFormat, JsString sData) { }
        ///<summary>
        ///Gets the data in the specified format from the clipboard through the dataTransfer object or the clipboardData object.
        ///</summary>
        ///<param name="sDataFormat">Required. A String that specifies one of the following data format values. </param>
        ///<returns>String. Returns the data in the format retrieved from the clipboard through the dataTransfer object or the clipboardData object. Depending on the information contained in setData, this variable can get a path to an image, text, or an anchor URL.</returns>
        public JsString getData(JsString sDataFormat) { return null; }
    }
    #endregion
    #region HtmlContext
    [JsType(JsMode.Global, Export = false)]
    public partial class HtmlContext : JsContext
    {
        ///<summary>
        ///Displays a dialog box containing an application-defined message. 
        ///</summary>
        ///<param name="message">Optional. String that specifies the message to display in the dialog box.</param>
        ///<remarks>You cannot change the title bar of the Alert dialog box.</remarks>
        public static void alert(object message) { }
        /// <summary>
        /// Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.
        /// </summary>
        /// <param name="message">Optional. String that specifies the message to display in the confirmation dialog box. If no value is provided, the dialog box does not contain a message.</param>
        /// <returns>Boolean. Returns one of the following possible values:
        ///	<list type="table">
        ///	<item>
        ///		<term>true</term>
        ///		<description>The user clicked the OK button.</description>
        ///	</item>
        ///	<item>
        ///		<term>false</term>
        ///		<description>The user clicked Cancel button.</description>
        /// </item>
        /// </list>
        /// </returns>
        public static JsBoolean confirm(JsString message) { return null; }
        ///<summary>
        ///Encodes String objects so they can be read on all computers.
        ///</summary>
        ///<param name="s">String object or literal to be encoded.</param>
        ///<returns>A JsString value (in Unicode format) that contains the contents of charstring. All spaces, punctuation, accented characters, and any other non-ASCII characters are replaced with %xx encoding, where xx is equivalent to the hexadecimal number representing the character. For example, a space is returned as "%20."</returns>
        public static JsString escape(JsString s) { return null; }
        ///<summary>
        ///Returns the unencoded version of an encoded component of a Uniform Resource Identifier (URI). 
        ///</summary>
        ///<param name="encodedURIString">A value representing an encoded URI component.</param>
        ///<returns>The required encodedURIString argument is a value representing an encoded 
        ///URI component.A URIComponent is part of a complete URI. If the encodedURIString is 
        ///not valid, a URIError occurs.</returns>
        public static JsString decodeURIComponent(JsString encodedURIString) { return null; }
        ///<summary>
        ///Encodes a text JsString as a valid component of a Uniform Resource Identifier (URI).
        ///</summary>
        ///<param name="encodedURIString">A value representing an encoded URI component.</param>
        ///<returns>A an encoded URI. If you pass the result to decodeURIComponent, 
        ///the original JsString is returned. Because the encodeURIComponent method encodes all 
        ///characters, be careful if the JsString represents a path such 
        ///as /folder1/folder2/default.html. The slash characters will be encoded and will 
        ///not be valid if sent as a request to a web server. Use the encodeURI method if the 
        ///JsString contains more than a single URI component.</returns>
        public static JsString encodeURIComponent(JsString encodedURIString) { return null; }
        ///<summary>
        ///Encodes a text JsString as a valid Uniform Resource Identifier (URI) 
        ///</summary>
        ///<param name="URIString">A value representing an encoded URI.</param>
        ///<returns>n encoded URI. If you pass the result to decodeURI, the original JsString is returned. The encodeURI method does not encode the following characters: ":", "/", ";", and "?". Use encodeURIComponent to encode these characters.</returns>
        public static JsString encodeURI(JsString URIString) { return null; }
        ///<summary>
        ///Returns the unencoded version of an encoded Uniform Resource Identifier (URI). 
        ///</summary>
        ///<param name="URIString"></param>
        ///<returns></returns>
        public static JsString decodeURI(JsString URIString) { return null; }
        ///<summary>
        ///Decodes String objects encoded with the escape method.
        ///</summary>
        ///<param name="charString">String object or literal to be decoded.</param>
        ///<returns>A JsString value that contains the contents of charstring. All characters encoded with the %xx hexadecimal form are replaced by their ASCII character set equivalents.</returns>
        public static JsString unescape(JsString charString) { return null; }
        ///<summary>
        ///Retrieves the HTML window
        ///</summary>
        public static HtmlWindow window { get; set; }
        ///<summary>
        ///Retrieves the HTML document
        ///</summary>
        public static HtmlDocument document { get; set; }
    }
    #endregion
    #region HtmlCssRule
    ///<summary>
    ///Represents a style within a Cascading Style Sheets (CSS) that consists of a selector and one or more declarations.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "CSSRULE")]
    public partial class HtmlCssRule
    {
        ///<summary>
        ///Retrieves whether the rule or style sheet is defined on the page or is imported.
        ///</summary>
        public JsBoolean readOnly { get; set; }
        ///<summary>
        ///Retrieves a JsString that identifies which elements the corresponding style sheet rule applies to.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString selectorText { get; set; }
        ///<summary>
        ///Represents the current settings of all possible inline styles for a given element.
        ///</summary>
        public HtmlElementStyle style { get; set; }
        ///<summary>
        ///Sets or retrieves the persisted representation of the style rule.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString cssText { get; set; }
        ///<summary>
        ///Returns the stylesheet object in which the current rule is defined.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlStyleElement parentStyleSheet { get; set; }
    }
    #endregion
    #region HtmlDiv
    ///<summary>
    ///Specifies a container that renders HTML.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DIV")]
    public partial class HtmlDiv : HtmlElement
    {
        protected HtmlDiv() { }
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        ///<summary>
        ///Sets or retrieves whether the browser automatically performs wordwrap.
        ///</summary>
        public JsBoolean noWrap { get; set; }
        /// <summary>
        /// Sets or retrieves the alignment of the object relative to the display or table.
        /// Possible Values:
        /// center	Aligns to the center.
        /// justify	Aligns to the left and right edge.
        ///	left		Default. Aligns to the left edge.
        ///	right		Aligns to the right edge.
        /// </summary>
        public JsString align { get; set; }
    }
    #endregion
    #region HtmlScript
    [JsType(JsMode.Prototype, Export = false, Name = "SCRIPT")]
    public partial class HtmlScript : HtmlElement
    {
        ///<summary>
        ///Retrieves the URL to an external file that contains the source code or data.
        ///</summary>
        public JsString src { get; set; }
        ///<summary>
        ///Sets or retrieves the MIME type for the associated scripting engine.
        ///</summary>
        public JsString type { get; set; }
        public JsString language { get; set; }
        ///<summary>
        ///Sets or retrieves the character set used to encode the object.
        ///</summary>
        public JsString charset { get; set; }
        /// <summary>
        /// Sets or retrieves the status of the script.
        /// Possible values:
        ///	false		Default. Inline executable function is not deferred.
        /// true		Inline executable function is deferred.
        /// </summary>
        public JsBoolean defer { get; set; }
        ///<summary>
        ///Sets or retrieves the event for which the script is written.
        ///</summary>
        public JsString @event { get; set; }
        ///<summary>
        ///Sets or retrieves the object that is bound to the event script.
        ///</summary>
        public JsString htmlFor { get; set; }
        ///<summary>
        ///Retrieves or sets the text of the object as a JsString.
        ///</summary>
        public JsString text { get; set; }
    }
    #endregion
    #region HtmlDocument
    ///<summary>
    ///Represents an HTML document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DOCUMENT")]
    public partial class HtmlDocument
    {
        ///<summary>
        ///Gets a collection of objects based on the value of the NAME or ID attribute.
        ///</summary>
        ///<param name="sNameValue"></param>
        ///<returns></returns>
        [SupportedBrowsers(BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, @"IE5-7 ignores the <p> and custom tags with name='test', but counts the <div> with id='test'
IE8 and Konqueror ignore the custom tag.
Opera counts the <div> with id='test'")]
        public HtmlElementCollection getElementsByName(JsString sNameValue) { return null; }
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void attachEvent(JsString eventName, HtmlDomEventHandler handler) { }
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void detachEvent(JsString eventName, HtmlDomEventHandler handler) { }
        ///<summary>
        ///Retrieves a value that indicates the current state of the object.
        ///uninitializedObject is not initialized with data.
        ///loadingObject is loading its data.
        ///loadedObject has finished loading its data.
        ///interactiveUser can interact with the object even though it is not fully loaded.
        ///completeObject is completely initialized.
        ///</summary>
        public JsString readyState
        {
            get;
            private set;
        }
        ///<summary>
        ///Retrieves a collection of HTML Elements and TextNode objects that are descendants of the specified object.
        ///</summary>
        public HtmlElementCollection all { get; set; }
        ///<summary>
        ///Gets the object that has the focus when the parent document has focus.
        ///</summary>
        public HtmlElement activeElement { get; set; }
        ///<summary>
        ///Gets or sets the HtmlWindow object that contains this HtmlDocument
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlWindow parentWindow { get; set; }
        ///<summary>
        ///Returns the root node for this HtmlDocument
        ///</summary>
        public HtmlDocumentElement documentElement { get; set; }
        public void appendChild(HtmlElement child) { }
        ///<summary>
        ///Creates a new TextNode
        ///</summary>
        ///<param name="text"></param>
        ///<returns></returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTextNode createTextNode(JsString text) { return null; }
        ///<summary>
        ///Creates a new HtmlElement
        ///</summary>
        ///<param name="name"></param>
        ///<returns></returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement createElement(JsString name) { return null; }
        ///<summary>
        ///Creates a new HtmlElement
        ///</summary>
        ///<param name="name"></param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public T createElement<T>(JsString name) { return default(T); }
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public T createElement<T>() { return default(T); }
        ///<summary>
        ///Retrieves a collection of objects based on the specified element name.
        ///</summary>
        ///<param name="sTagName">String that specifies the name of an element.</param>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"The * argument, which ought to select all elements in the document, doesn't work in IE 5.5. 
Custom tags are not returned in Konqueror.")]
        public HtmlElementCollection getElementsByTagName(JsString sTagName) { return null; }
        ///<summary>
        ///Creates a new Stylesheet node
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlStyleElement createStyleSheet() { return null; }
        ///<summary>
        ///Creates a new Stylesheet node
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlStyleElement createStyleSheet(JsString url) { return null; }
        ///<summary>
        ///Creates a new Stylesheet node
        ///</summary>
        public HtmlStyleElement createStyleSheet(JsNumber index) { return null; }
        ///<summary>
        ///Creates a new Stylesheet node.
        ///</summary>
        public HtmlStyleElement createStyleSheet(JsString url, JsNumber index) { return null; }
        ///<summary>
        ///Gets the HtmlSelection object of this HtmlDocument
        ///</summary>
        public HtmlSelection selection
        {
            get;
            private set;
        }
        ///<summary>
        ///Gets the HtmlBody root element of this HtmlDocument
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlBody body { get; set; }
        ///<summary>
        ///Gets the title of this HtmlDocument
        ///</summary>
        public JsString title { get; set; }
        public void open() { }
        public void close() { }
        public void write(JsString p) { }
        ///<summary>
        ///Returns a reference to the first object with the specified value of the ID or NAME attribute (in IE)
        ///</summary>
        ///<param name="sIDValue">A String that specifies the ID value. Case-insensitive.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement getElementById(JsString sIDValue) { return null; }
        ///<summary>
        ///Returns a reference to the first object with the specified value of the ID or NAME attribute (in IE)
        ///</summary>
        ///<param name="sIDValue">A String that specifies the ID value. Case-insensitive.</param>		
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public T getElementById<T>(JsString sIDValue) { return default(T); }
        ///<summary>
        ///Creates a new document.
        ///</summary>
        ///<returns>Returns the newly created document.</returns>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDocumentFragment createDocumentFragment() { return null; }
        ///<summary>
        ///Generates an event object to pass event context information when you use the fireEvent method.
        ///</summary>
        ///<returns>Returns an event object.</returns>
        public HtmlDomEventArgs createEventObject() { return null; }
        ///<summary>
        ///Generates an event object to pass event context information when you use the fireEvent method.
        ///</summary>
        ///<param name="existingEvent">A object that specifies an existing event object on which to base the new object. </param>
        ///<returns>Returns an event object.</returns>
        public HtmlDomEventArgs createEventObject(HtmlDomEventArgs existingEvent) { return null; }
        ///<summary>
        ///Sets or gets the JsString value of a cookie.
        ///</summary>
        public JsString cookie { get; set; }
        ///<summary>
        ///Gets a value that indicates whether standards-compliant mode is switched on for the object.
        ///</summary>
        ///<remarks>
        ///Possible Values
        ///BackCompat - Standards-compliant mode is not switched on.
        ///CSS1Compat Standards-compliant mode is switched on.
        ///</remarks>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE 5.5 doesn't support this property, but it doesn't need to. It's permanently locked in Quirks Mode.")]
        public JsString compatMode { get; set; }
        ///<summary>
        ///Returns a reference to the default AbstractView for the document, or null if none available
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDocument defaultView { get; set; }
        ///<summary>
        ///Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlNodeCollection<HtmlStyleElement> styleSheets { get; set; }
        [SupportedBrowsers(BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public HtmlElementCollection getElementsByClassName(JsString sClassName) { return null; }
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Opera10)]
        public HtmlElementCollection querySelectorAll(JsString selector) { return null; }
        ///<summary>
        ///Returns the element for the specified x coordinate and the specified y coordinate.
        ///</summary>
        ///<param name="iX">A Integer that specifies the X-offset, in pixels.</param>
        ///<param name="iY">A Integer that specifies the Y-offset, in pixels.</param>
        ///<returns>Returns an element object.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"IE and Firefox need clientX/Y, while Opera, Chrome and Safari need pageX/Y. Opera 9 reports a text node whenever possible, while this method should report the containing element node.")]
        public HtmlElement elementFromPoint(JsNumber iX, JsNumber iY) { return null; }
        [HtmlSpecificationVersion(5)]
        [JsProperty(NativeIndexer=true)]
        public object this[JsString name] { get { return null; } set { } }
        ///<summary>
        ///Creates a new comment node, and returns it.
        ///</summary>
        ///<param name="data">a JsString containing the data to be added to the Comment.</param>
        public HtmlNode createComment(JsString data) { return null; }
    }
    #endregion
    #region HtmlDocumentElement
    ///<summary>
    ///Tag: HTML. Represents the root element of a HTML document.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DOCUMENTELEMENT")]
    public partial class HtmlDocumentElement : HtmlElement
    {
        ///<summary>
        ///Gets the object that has the focus when the parent document has focus.
        ///</summary>
        public object activeElement { get; set; }
        ///<summary>
        ///Sets or gets the color of all active links in the document.
        ///</summary>
        public JsString alinkColor { get; set; }
        ///<summary>
        ///Sets or retrieves the character set used to encode the object.
        ///</summary>
        public JsString charset { get; set; }
        ///<summary>
        ///Retrieves the collection of user agents and versions declared in the X-UA-Compatible
        ///</summary>
        public object compatible { get; set; }
        /// <summary>
        /// Gets a value that indicates whether standards-compliant mode is switched on for the object.
        /// Possible values:
        ///	BackCompat	Standards-compliant mode is not switched on.
        /// CSS1Compat	Standards-compliant mode is switched on.
        /// </summary>
        public object compatMode { get; set; }
        ///<summary>
        ///Sets or gets the JsString value of a cookie.
        ///specifies or receives the name=value; pairs, plus any of the values listed in Possible Values.
        ///Possible Values: 
        ///expires=date;
        ///If you set no expiration date on a cookie, it expires when the browser closes. If you set an expiration date, the cookie is saved across browser sessions. If you set an expiration date in the past, the cookie is deleted. Use Greenwich Mean Time (GMT) format to specify the date.
        ///domain=domainname;
        ///If you set the domain of the cookie, pages on a domain made up of more than one server can share cookie information.
        ///path=path;
        ///If you set a path for the cookie, the current document can share cookie information with other pages within the same domain—that is, if the path is set to /thispathname, all pages in /thispathname and all pages in subfolders of /thispathname can access the same cookie information.
        ///secure;
        ///If you set a cookie as secure;, the stored cookie information can be accessed only from Secure Hypertext Transfer Protocol (HTTPS).
        ///</summary>
        public object cookie { get; set; }
        ///<summary>
        ///Gets the default character set from the current regional language settings.
        ///</summary>
        public JsString defaultCharset { get; set; }
        ///<summary>
        ///Sets or gets a value that indicates whether the document can be edited.	  
        ///Possible Values:
        ///On							Document can be edited.
        ///Off | Inherit		Default. Document cannot be edited.
        ///</summary>
        public JsString designMode { get; set; }
        ///<summary>
        ///Gets the document type declaration associated with the current document.
        ///Possible values:
        ///ltr		Default. Content flows from left to right.
        ///rtl		Content flows from right to left.
        ///</summary>
        public JsString doctype { get; set; }
        ///<summary>
        ///Gets a reference to the root node of the document.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement documentElement { get; set; }
        /// <summary>
        /// Retrieves the document compatibility mode of the document.
        /// Possible values:
        ///	5		Microsoft Internet Explorer 5 mode (also known as "quirks mode").
        /// 7		Internet Explorer 7 Standards mode.
        /// 8   Internet Explorer 8 Standards mode.
        /// </summary>
        public Double documentMode { get; set; }
        ///<summary>
        ///Sets or gets the security domain of the document.
        ///</summary>
        public object domain { get; set; }
        ///<summary>
        ///Sets or retrieves a value indicating whether arbitrary variables can be created within the object.
        ///Possible values:
        ///true	Default. Creation of arbitrary variables is allowed.
        ///false	Creation of arbitrary variables is not allowed.
        ///</summary>
        public JsBoolean expando { get; set; }
        ///<summary>
        ///Sets or gets the foreground (text) color of the document.
        ///</summary>
        public JsBoolean fgColor { get; set; }
        ///<summary>
        ///Retrieves the date the file was created.
        ///</summary>
        public JsString fileCreatedDate { get; set; }
        ///<summary>
        ///Retrieves the date the file was last modified.
        ///</summary>
        public JsString fileModifiedDate { get; set; }
        ///<summary>
        ///Retrieves the file size.
        ///</summary>
        public JsString fileSize { get; set; }
        ///<summary>
        ///Retrieves the date the file was last updated.
        ///</summary>
        public JsString fileUpdatedDate { get; set; }
        ///<summary>
        ///Gets the implementation object of the current document.
        ///</summary>
        public HtmlDomImplementation implementation { get; set; }
        ///<summary>
        ///Gets the date that the page was last modified, if the page supplies one.
        ///</summary>
        public JsString lastModified { get; set; }
        ///<summary>
        ///Sets or gets the color of the document links.
        ///</summary>
        public JsString linkColor { get; set; }
        ///<summary>
        ///Sets or retrieves the media type.
        ///Possible Values:
        ///screen		Output is intended for computer screens.
        ///print			Output is intended for printed material and for on-screen documents viewed in Print Preview mode.
        ///all				Default. Applies to all devices.
        ///</summary>
        public JsString media { get; set; }
        ///<summary>
        ///Retrieves the file name specified in the href or src property of the object.
        ///</summary>
        public JsString nameProp { get; set; }
        ///<summary>
        ///Gets a reference to the container object of the window.
        ///</summary>
        public object parentWindow { get; set; }
        ///<summary>
        ///Sets or retrieves the protocol portion of a URL.
        ///</summary>
        public JsString protocol { get; set; }
        ///<summary>
        ///Retrieves a value that indicates the current state of the object.	
        ///Possible Values:
        ///uninitialized		Object is not initialized with data.
        ///loading					Object is loading its data.
        ///loaded					Object has finished loading its data.
        ///interactive			User can interact with the object even though it is not fully loaded.
        ///complete				Object is completely initialized.
        ///</summary>
        public JsString readyState { get; set; }
        ///<summary>
        ///Gets the URL of the location that referred the user to the current page.
        ///</summary>
        public JsString referrer { get; set; }
        ///<summary>
        ///Sets or gets the URL for the current document.
        ///</summary>
        public JsString URL { get; set; }
        ///<summary>
        ///Gets the URL for the document, stripped of any character encoding.		 
        ///</summary>
        public JsString URLUnencoded { get; set; }
        ///<summary>
        ///Sets or gets the color of the links that the user has visited.
        ///</summary>
        public JsString vLinkColor { get; set; }
    }
    #endregion
    #region HtmlDocumentFragment
    ///<summary>
    ///Represents a fragment of a document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DOCUMENTFRAGMENT")]
    public partial class HtmlDocumentFragment : HtmlElement
    {
        protected HtmlDocumentFragment() { }
    }
    #endregion
    #region HtmlDomEventArgs
    ///<summary>
    ///Represents the state of an event, such as the element in which the event occurred, the state of the keyboard keys, the location of the mouse, and the state of the mouse buttons. 
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DOMEVENTARGS")]
    public partial class HtmlDomEventArgs
    {
        protected HtmlDomEventArgs() { }
        ///<summary>
        ///Sets or retrieves the Unicode key code associated with the key that caused the event. 
        ///</summary>
        public JsNumber keyCode;
        ///<summary>
        ///Sets or retrieves the x-coordinate, in pixels, of the mouse pointer's position relative to a relatively positioned parent element.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use clientX/clientY")]
        public JsNumber x { get; set; }
        ///<summary>
        ///Sets or retrieves the y-coordinate, in pixels, of the mouse pointer's position relative to a relatively positioned parent element.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use clientX/clientY")]
        public JsNumber y { get; set; }
        ///<summary>
        ///Sets or retrieves the state of the SHIFT key. 
        ///</summary>
        public JsBoolean shiftKey;
        ///<summary>
        ///Sets or retrieves the state of the CTRL key. 
        ///</summary>
        public JsBoolean ctrlKey;
        ///<summary>
        ///Sets or retrieves the name of the property that changes on the object.
        ///</summary>
        public JsString propertyName;
        ///<summary>
        ///Sets or retrieves the x-coordinate of the mouse pointer's position relative to the client area of the window, excluding window decorations and scroll bars.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber clientX { get; set; }
        ///<summary>
        ///Sets or retrieves the y-coordinate of the mouse pointer's position relative to the client area of the window, excluding window decorations and scroll bars.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber clientY { get; set; }
        ///<summary>
        ///Returns the horizontal coordinate of the event relative to whole document.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber pageX { get; set; }
        ///<summary>
        ///Returns the vertical coordinate of the event relative to the whole document.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber pageY { get; set; }
        ///<summary>
        ///Sets or retrieves the x-coordinate of the mouse pointer's position relative to the object firing the event. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber offsetX { get; set; }
        ///<summary>
        ///Sets or retrieves the y-coordinate of the mouse pointer's position relative to the object firing the event. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9, @"In IE the coordinates are calculated relative to the target element when that element is eligible to become an offsetParent. If that's not the case, the coordinates are calculated relative to the target's offsetParent.
Bug: When the element found by this rule has position: relative, IE moves on to the next offsetParent for the calculation of offsetY, but not of offsetX.")]
        public JsNumber offsetY { get; set; }
        ///<summary>
        ///Sets or retrieves the object that fired the event. 
        ///</summary>
        public HtmlElement srcElement { get; set; }
        ///<summary>
        ///Sets or retrieves the return value from the event. 
        ///</summary>
        public object returnValue { get; set; }
        ///<summary>
        ///Sets or retrieves whether the current event should bubble up the hierarchy of event handlers. 
        ///</summary>
        public JsBoolean cancelBubble { get; set; }
        ///<summary>
        ///Sets or retrieves the event name from the event object. 
        ///</summary>
        public JsString type { get; set; }
        /// <summary>
        /// Sets or retrieves the mouse button pressed by the user. 
        /// Values:
        /// <list type="table">
        ///		<listheader>
        ///			<term>Value</term>	
        ///			<description>Description</description>
        ///		</listheader>
        ///		<item>
        ///			<term>0</term>	
        ///			<description>Default. No button is pressed.</description>
        ///		</item>
        ///		<item>
        ///			<term>1</term>	
        ///			<description>Left button is pressed. </description>
        ///		</item>
        ///		<item>
        ///			<term>2</term>	
        ///			<description>Right button is pressed. </description>
        ///		</item>
        ///		<item>
        ///			<term>3</term>	
        ///			<description>Left and right buttons are both pressed. </description>
        ///		</item>
        ///		<item>
        ///			<term>4</term>	
        ///			<description>Middle button is pressed. </description>
        ///		</item>
        ///		<item>
        ///			<term>5</term>	
        ///			<description>Left and middle buttons both are pressed. </description>
        ///		</item>
        ///		<item>
        ///			<term>6</term>	
        ///			<description>Right and middle buttons are both pressed. </description>
        ///		</item>
        ///		<item>
        ///			<term>7</term>	
        ///			<description>All three buttons are pressed. </description>
        ///		</item>
        /// </list>
        /// </summary>
        public JsNumber button { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates the state of the ALT key. 
        ///</summary>
        public JsBoolean altKey { get; set; }
        ///<summary>
        ///Retrieves the state of the left CTRL key. 
        ///</summary>
        public JsBoolean ctrlLeft { get; set; }
        ///<summary>
        ///Retrieves the state of the right CTRL key. 
        ///</summary>
        public JsBoolean ctrlRight { get; set; }
        ///<summary>
        ///Retrieves the state of the left SHIFT key. 
        ///</summary>
        public JsBoolean shiftLeft { get; set; }
        ///<summary>
        ///Retrieves the state of the right SHIFT key. 
        ///</summary>
        public JsBoolean shiftRight { get; set; }
        ///<summary>
        ///Retrieves whether the onkeydown event is being repeated. 
        ///</summary>
        public JsBoolean repeat { get; set; }
        ///<summary>
        ///Sets or retrieves the x-coordinate of the mouse pointer's position relative to the user's screen. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber screenX { get; set; }
        ///<summary>
        ///Sets or retrieves the y-coordinate of the mouse pointer's position relative to the user's screen. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber screenY { get; set; }
        ///<summary>
        ///Retrieves the distance and direction the wheel button has rolled. 
        ///</summary>
        public JsNumber wheelDelta { get; set; }
    }
    #endregion
    #region HtmlDomImplementation
    [JsType(JsMode.Prototype, Export = false, Name = "DOMIMPLEMENTATION")]
    public partial class HtmlDomImplementation
    {
        ///<summary>
        ///Creates a DOM document.
        ///</summary>
        ///<param name="namespaceURI">namespace URI of the document to be created (use null if none)</param>
        ///<param name="qualifiedNameStr">qualified name (optional prefix and colon plus the local root element name) of the document to be created</param>
        ///<param name="documentType">the DocumentType to be created.</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDocument createDocument(JsString namespaceURI, JsString qualifiedNameStr, object documentType) { return null; }
        ///<summary>
        ///Creates an HTMLDocument object with the minimal tree made of the following elements: HTML, HEAD, TITLE, and BODY.
        ///</summary>
        ///<remarks>Introduced in DOM Level 2</remarks>
        ///<returns>A new HTMLDocument object.</returns>
        [SupportedBrowsers(BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public HtmlDocument createHTMLDocument() { return null; }
        ///<summary>
        ///Returns a DocumentType object which can either be used with DOMImplementation.createDocument upon document creation or they can be put into the document via Node.insertBefore() or Node.replaceChild()
        ///</summary>
        ///<param name="qualifiedNameStr"></param>
        ///<param name="publicId"></param>
        ///<param name="systemId"></param>
        ///<returns></returns>
        public object createDocumentType(JsString qualifiedNameStr, JsString publicId, JsString systemId) { return null; }
        public object getFeature(JsString feature, JsString version) { return null; }
        public JsBoolean hasFeature(JsString feature, JsString version) { return null; }
    }
    #endregion
    #region HtmlElement
    ///<summary>
    ///Retrieves the type of the requested node.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ELEMENT")]
    public partial class HtmlElement : HtmlNode
    {
        protected HtmlElement() { }
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, "IE incorrectly counts comment nodes, too.")]
        public HtmlElementCollection children
        {
            get;
            private set;
        }
        ///<summary>
        ///Removes the given attribute from the object.
        ///</summary>
        ///<param name="attName">String that specifies the attribute name. </param>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, @"IE5-7 and Opera don't remove event handlers.
Konqueror doesn't remove the align attribute.")]
        public void removeAttribute(JsString attName) { }
        ///<summary>
        ///Removes the given attribute from the object.
        ///</summary>
        ///<param name="attName">String that specifies the attribute name. </param>
        ///<param name="caseSensitive"> Integer that specifies whether to use a case-sensitive search to locate the attribute. By default, this value is set to 1 to indicate that the uppercase and lowercase letters in the specified sName parameter must exactly match those in the attribute name. If there are multiple attributes specified with different case sensitivity, the attribute returned might vary across platforms. </param>
        public void removeAttribute(JsString attName, JsNumber caseSensitive) { }
        ///<summary>
        ///Inserts the given HTML text into the element at the location
        ///</summary>
        ///<param name="where">
        ///String that specifies where to insert the HTML text, using one of the following values: 
        ///beforeBegin Inserts sText immediately before the object. 
        ///afterBegin Inserts sText after the start of the object but before all other content in the object. 
        ///beforeEnd Inserts sText immediately before the end of the object but after all other content in the object. 
        ///afterEnd Inserts sText immediately after the end of the object. 
        ///</param>
        ///<param name="html">String that specifies the HTML text to insert. The JsString can be a combination of text and HTML tags. This must be well-formed, valid HTML or this method will fail. </param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9, NotSupportedRemark = "Use innerHTML and insertBefore()")]
        public void insertAdjacentHTML(JsString where, JsString html) { }
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public void attachEvent(JsString eventName, HtmlDomEventHandler handler) { }
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        ///<param name="useCapture"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void addEventListener(JsString eventName, HtmlDomEventHandler handler, JsBoolean useCapture) { }
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public void detachEvent(JsString eventName, HtmlDomEventHandler handler) { }
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        ///<param name="useCapture"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void removeEventListener(JsString eventName, HtmlDomEventHandler handler, JsBoolean useCapture) { }
        ///<summary>
        ///Fires a specified event on the object.
        ///</summary>
        ///<param name="sEvent">String that specifies the name of the event to fire.</param>
        ///<param name="oEventObject">Object that specifies the event object from which to obtain event object properties.</param>
        public void fireEvent(JsString sEvent, HtmlDomEventArgs oEventObject) { }
        ///<summary>
        ///Fires a specified event on the object.
        ///</summary>
        ///<param name="sEvent">String that specifies the name of the event to fire.</param>
        public void fireEvent(JsString sEvent) { }
        ///<summary>
        ///Retrieves a collection of rectangles that describes the layout of the contents of an object or range within the client. Each rectangle describes a single line. 
        ///</summary>
        ///<returns>Returns the TextRectangle collection. Each rectangle has four integer properties (top, left, right, and bottom) that each represent a coordinate of the rectangle, in pixels.</returns>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"IE5-7 returns far too many rectangles for the first test paragraphs. The correct number is 5 (for 5 lines), but IE5.5 returns 9 and IE6/7 14. IE8b2 gets this right.
Furthermore, IE5-7 also split up a block-level element such as a <p> into one rectangle per line. This is incorrect: a block-level element should be reported as one rectangle.
Finally, in IE 5-7 the rectangles are off by about two pixels.", PartiallySupportedRemark = @"Firefox doesn't round the top/bottom coordinates.")]
        public HtmlTextRectangleCollection getClientRects() { return null; }
        ///<summary>
        ///Specifies that an element cannot be selected.
        ///</summary>
        public JsString unselectable { get; set; }
        ///<summary>
        ///Sets or retrieves the JsString identifying the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString id { get; set; }
        ///<summary>
        ///Retrieves an autogenerated, unique identifier for the object. 
        ///</summary>
        public JsString uniqueID { get; set; }
        ///<summary>
        ///Sets or retrieves the JsString that indicates whether the user can edit the content of the object.
        ///</summary>
        public JsString contentEditable { get; set; }
        ///<summary>
        ///Retrieves a reference to the last child in the childNodes collection of an object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNode lastChild { get; set; }
        ///<summary>
        ///Retrieves a reference to the container object that defines the offsetTop and offsetLeft properties of the object.
        ///</summary>
        public HtmlElement offsetParent { get; set; }
        ///<summary>
        ///Sets or retrieves the distance between the left edge of the object and the leftmost portion of the content currently visible in the window. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber scrollLeft { get; set; }
        ///<summary>
        ///Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber scrollTop { get; set; }
        ///<summary>
        ///Retrieves the calculated left position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber offsetLeft { get; set; }
        ///<summary>
        ///Retrieves the calculated top position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"When calculating offsetTop, IE5-7 does not count elements with position: relative as offsetParents, and moves on to the next offsetParent in the chain. offsetLeft is calculated correctly.")]
        public JsNumber offsetTop { get; set; }
        ///<summary>
        ///Retrieves the width of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber offsetWidth { get; set; }
        ///<summary>
        ///Retrieves the height of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        ///<remarks>When overflowY is Scroll, this is the physical height of the control, which is clientHeight + Vscrollbar size</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber offsetHeight { get; set; }
        ///<summary>
        ///Retrieves the distance between the offsetTop property and the true top of the client area.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public JsNumber clientTop { get; set; }
        ///<summary>
        ///Retrieves the distance between the offsetLeft property and the true left side of the client area.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public JsNumber clientLeft { get; set; }
        ///<summary>
        ///Retrieves the width of the object including padding, but not including margin, border, or scroll bar.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber clientWidth { get; set; }
        ///<summary>
        ///Retrieves the height of the object including padding, but not including margin, border, or scroll bar.
        ///</summary>
        ///<remarks>When overflowY is Scroll, this is the physical displayed height of the children w/o the scrollbar</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber clientHeight { get; set; }
        ///<summary>
        ///Retrieves the scrolling width of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"When the element has no scrollbars IE makes the scrollHeight equal to the actual height of the content; and not the height of the element. scrollWidth is correct, except in IE8, where it’s 5 pixels off.
Opera gives odd, incorrect values.")]
        public JsNumber scrollWidth { get; set; }
        ///<summary>
        ///Gets the namespace defined for the element.
        ///</summary>
        public JsString scopeName { get; set; }
        ///<summary>
        ///Retrieves the ordinal position of the object, in source order, as the object appears in the document's all collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber sourceIndex { get; set; }
        ///<summary>
        ///Retrieves the scrolling height of the object. 
        ///</summary>
        ///<remarks>When overflowY is Scroll, this is the virtual height of the scrollable region (without scrolling, this would be the physical height of the element)</remarks>
        public JsNumber scrollHeight { get; set; }
        ///<summary>
        ///Retrieves the document object associated with the node.
        ///</summary>
        public HtmlDocument document { get; set; }
        ///<summary>
        ///Retrieves a collection of HTML Elements and TextNode objects that are direct descendants of the specified object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNodeCollection childNodes { get; set; }
        ///<summary>
        ///Sets or retrieves advisory information (a ToolTip) for the object. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Safari 3.0 does’t show the title of an element in any way, so its compatibility is mostly untestable. However, the title property gets its value from the title attribute, so it works to some extent.")]
        public JsString title { get; set; }
        ///<summary>
        ///Sets or retrieves the HTML between the start and end tags of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"In IE and Konqueror innerHTML does not work correctly when you update tables. Solve this by using pure DOM methods instead. 
If you remove elements through innerHTML in IE, their content is wiped and only the element itself (i.e. opening and closing tags) remain. If you want to remove nodes that you may want to reinsert at a later time, use DOM methods such as removeChild().")]
        public JsString innerHTML { get; set; }
        ///<summary>
        ///Sets or retrieves the text between the start and end tags of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use document.createTextNode() and appendChild() in any browser, or textContent in FireFox")]
        public JsString innerText { get; set; }
        ///<summary>
        ///Sets or retrieves the text between the start and end tags of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use innerText in IE")]
        public JsString textContent { get; set; }
        ///<summary>
        ///Sets or retrieves the index that defines the tab order for the object.
        ///</summary>
        public JsNumber tabIndex { get; set; }
        ///<summary>
        ///Sets or gets the Uniform Resource OriginalValue (URN) specified in the namespace declaration.
        ///</summary>
        public JsString tagUrn { get; set; }
        ///<summary>
        ///Sets an inline style for the element.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElementStyle style { get; set; }
        ///<summary>
        ///Returns the current (calculated) style of the element
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"Use getComputedStyle()")]
        public HtmlElementStyle currentStyle { get; set; }
        [JsProperty(NativeIndexer = true)]
        public object this[JsString name] { get { return null; } set { } }
        ///<summary>
        ///Sets or retrieves the class of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString className { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates whether the user can interact with the object.
        ///</summary>
        public JsBoolean disabled { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates the reading order of the object.
        ///Possible values:
        ///ltr		Default. Content flows from left to right.
        ///rtl		Content flows from right to left.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"If the last character on a line is an interpunction character, IE, Safari, Chrome and Konqueror move it to the start of the line.")]
        public JsString dir { get; set; }
        ///<summary>
        ///Sets or retrieves the language to use.
        ///</summary>
        public JsString lang { get; set; }
        ///<summary>
        ///Retrieves the tag name of the object. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"In IE (all versions) the tagName of a comment node is !. 
Use nodeName instead.")]
        public JsString tagName { get; set; }
        ///<summary>
        ///Retrieves the parent object in the document hierarchy.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use parentNode")]
        public HtmlElement parentElement { get; set; }
        ///<summary>
        ///Appends an element as a child to the object.
        ///</summary>
        ///<param name="child"></param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void appendChild(HtmlNode child) { }
        ///<summary>
        ///Removes a child node from the object.
        ///</summary>
        ///<param name="oNode">Object that specifies the element to be removed from the document.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void removeChild(HtmlNode oNode) { }
        ///<summary>
        ///Sets the mouse capture to the object that belongs to the current document. 
        ///</summary>
        public void setCapture() { }
        /// <summary>
        /// Sets the mouse capture to the object that belongs to the current document. 
        /// </summary>
        /// <param name="containerCapture">A Boolean that specifies one of the following values. true Default. Events originating in a container are captured by the container. 
        ///false Events originating in a container are not captured by the container 
        ///</param>
        public void setCapture(JsBoolean containerCapture) { }
        ///<summary>
        ///Removes mouse capture from the object in the current document.
        ///</summary>
        public void releaseCapture() { }
        /// <summary>
        /// Inserts an element at the specified location.
        /// </summary>
        /// <param name="sWhere">A String that specifies where to insert the HTML element, using one of the following values. 
        ///		<list type="table">
        ///		<item><term>beforeBegin</term><description>Inserts oElement immediately before the object.</description></item>
        ///		<item><term>afterBegin</term><description></description>Inserts oElement after the start of the object, but before all other content in the object.</item>
        ///		<item><term>beforeEnd</term><description>Inserts oElement immediately before the end of the object, but after all other content in the object.</description></item>
        ///		<item><term>afterEnd</term><description>Inserts oElement immediately after the end of the object.</description></item>
        ///		</list>
        /// </param>
        /// <param name="oElement">Object that specifies the element to be inserted adjacent to the object that invoked the insertAdjacentElement method.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9, NotSupportedRemark = "Use insertBefore() or appendChild()")]
        public void insertAdjacentElement(JsString sWhere, HtmlElement oElement) { }
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void insertBefore(HtmlNode newNode) { }
        public void insertBefore(HtmlNode newNode, HtmlNode child) { }
        ///<summary>
        ///Retrieves a reference to the first child in the childNodes collection of the object. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNode firstChild
        {
            get;
            private set;
        }
        ///<summary>
        ///Sets or retrieves the text of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public JsString outerText { get; set; }
        ///<summary>
        ///Sets or retrieves the object and its content in HTML.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public JsString outerHTML { get; set; }
        /// <summary>
        /// Inserts the given text into the element at the specified location.
        /// </summary>
        /// <param name="sWhere">A String that specifies where to insert the HTML element, using one of the following values. 
        ///		<list type="table">
        ///		<item><term>beforeBegin</term><description>Inserts oElement immediately before the object.</description></item>
        ///		<item><term>afterBegin</term><description></description>Inserts oElement after the start of the object, but before all other content in the object.</item>
        ///		<item><term>beforeEnd</term><description>Inserts oElement immediately before the end of the object, but after all other content in the object.</description></item>
        ///		<item><term>afterEnd</term><description>Inserts oElement immediately after the end of the object.</description></item>
        ///		</list>
        /// </param>
        /// <param name="sText">String that specifies the text to insert.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9, NotSupportedRemark = "Use document.createTextNode() and insertBefore()")]
        public void insertAdjacentText(JsString sWhere, JsString sText) { }
        ///<summary>
        ///Removes the object from the document hierarchy.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public void removeNode() { }
        ///<summary>
        ///Removes the object from the document hierarchy.
        ///</summary>
        ///<param name="bRemoveChildren">A Boolean that specifies one of the following values. </param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public void removeNode(JsBoolean bRemoveChildren) { }
        ///<summary>
        ///Causes the element to lose focus and fires the onblur event.
        ///</summary>
        public void blur() { }
        ///<summary>
        ///Retrieves a collection of attributes of the object.
        ///</summary>
        public HtmlAttributeCollection attributes { get; set; }
        ///<summary>
        ///Sets the value of the specified attribute 
        ///</summary>
        ///<param name="name">String that specifies the name of the attribute.</param>
        ///<param name="value">Variant that specifies the JsString, number, or Boolean to assign to the attribute.</param>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE5-7 doesn't set styles and removes events when you try to set them.")]
        public void setAttribute(JsString name, object value) { }
        ///<summary>
        ///Copies a reference to the object from the document hierarchy. 
        ///</summary>
        ///<param name="includeChildren">Boolean that specifies one of the following values:
        ///FALSE Cloned objects do not include childNodes. 
        ///TRUE Cloned objects include childNodes. </param>
        ///<returns>Returns a reference to the newly created node.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement cloneNode(JsBoolean includeChildren) { return null; }
        ///<summary>
        ///Copies a reference to the object from the document hierarchy. 
        ///</summary>
        ///<returns>Returns a reference to the newly created node.</returns>
        public HtmlElement cloneNode() { return null; }
        ///<summary>
        ///Causes the element to receive the focus and executes the code specified by the onfocus event. 
        ///</summary>
        public void focus() { }
        ///<summary>
        ///Causes the object to scroll into view, aligning it either at the top or bottom of the window. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public void scrollIntoView() { }
        ///<summary>
        ///Causes the object to scroll into view, aligning it either at the top or bottom of the window. 
        ///</summary>
        ///<param name="alignToTop">Boolean that specifies one of the following values: 
        ///true Default. Scrolls the object so that top of the object is visible at the top of the window. 
        ///false Scrolls the object so that the bottom of the object is visible at the bottom of the window </param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari iPhone handles the Y-coordinate correctly, but it also scrolls to the left edge of the page, which can make this method hard to use when the user has zoomed in.")]
        public void scrollIntoView(JsBoolean alignToTop) { }
        ///<summary>
        ///Sets the object as active without setting focus to the object.
        ///</summary>
        public void setActive() { }
        ///<summary>
        ///Puts the specified node and all of its subtree into a "normalized" form. In a normalized subtree, no text nodes in the subtree are empty and there are no adjacent text nodes.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void normalize() { }
        ///<summary>
        ///Creates an attribute object with a specified name.
        ///</summary>
        ///<param name="sName">A String that sets the attribute object's name.</param>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlAttribute createAttribute(JsString sName) { return null; }
        ///<summary>
        ///Sets an attribute object node as part of the object.
        ///</summary>
        ///<param name="oSrcAttribute">attribute object to be assigned.</param>
        ///<returns>
        ///Returns a reference to the removed attribute object.
        ///</returns>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, "IE6-7 gives null for style values.")]
        public HtmlAttribute setAttributeNode(HtmlAttribute oSrcAttribute) { return null; }
        ///<summary>
        ///Retrieves the value of the specified attribute.
        ///</summary>
        ///<param name="sAttrName">String that specifies the name of the attribute.</param>
        ///<param name="iFlags">Integer that specifies one or more of the following flags:
        ///0 - Default. Performs a property search that is not case-sensitive, and returns an interpolated value if the property is found.
        ///1 - Performs a case-sensitive property search. To find a match, the uppercase and lowercase letters in sAttrName must exactly match those in the attribute name.
        ///2 - Returns attribute value as a String. This flag does not work for event properties.
        ///4 - Returns attribute value as a fully expanded URL. Only works for URL attributes.</param>
        ///<returns>Variant that returns a String, Integer, or Boolean value as defined by the attribute. If the attribute is not present, this method returns null.</returns>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"In IE5-7, accessing the style attribute gives an object, and accessing the onclick attribute gives an anonymous function wrapped around the actual content.")]
        public object getAttribute(JsString sAttrName, JsNumber iFlags) { return null; }
        ///<summary>
        ///Retrieves the value of the specified attribute.
        ///</summary>
        ///<param name="sAttrName">String that specifies the name of the attribute.</param>
        ///<returns>Variant that returns a String, Integer, or Boolean value as defined by the attribute. If the attribute is not present, this method returns null.</returns>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"In IE5-7, accessing the style attribute gives an object, and accessing the onclick attribute gives an anonymous function wrapped around the actual content.")]
        public object getAttribute(JsString sAttrName) { return null; }
        ///<summary>
        ///Retrieves an attribute object referenced by the attribute.name property.
        ///</summary>
        ///<param name="sName">String that specifies the name property of the requested attribute object.</param>
        ///<returns>Returns a reference to an attribute object.</returns>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE 6/7 don't allow you to access the value of x.getAttributeNode('style').")]
        public HtmlAttribute getAttributeNode(JsString sName) { return null; }
        ///<summary>
        ///Determines whether an attribute with the specified name exists.
        ///</summary>
        ///<param name="sAttrName">String that specifies the name of the attribute.</param>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsBoolean hasAttribute(JsString sAttrName) { return null; }
        ///<summary>
        ///returns a boolean value of true or false, indicating if the current element has any attributes or not.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsBoolean hasAttributes() { return null; }
        ///<summary>
        ///Removes an attribute object from the object.
        ///</summary>
        ///<param name="oSrcAttribute">attribute object to be removed.</param>
        ///<remarks>Returns a reference to the removed attribute object.</remarks>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE 6 does't remove anything, but doesn't give an error message either.
IE 7 doesn't remove styles and event handlers.
Opera doesn't remove event handlers.
Konqueror doesn't remove the align attribute.")]
        public HtmlAttribute removeAttributeNode(JsString oSrcAttribute) { return null; }
        ///<summary>
        ///Makes the element either a child or parent of another element.
        ///</summary>
        ///<param name="oNewElement">An object that becomes the child or parent of the current element.</param>
        ///<param name="oWhere">A String that specifies one of the following values.
        ///outside - Default. Specified element becomes a parent of the current element.
        ///inside - Specified element becomes a child of the current element, but contains all the child elements of the current element.
        ///</param>
        ///<returns>Returns a reference to the applied element.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlElement applyElement(HtmlElement oNewElement, JsString oWhere) { return null; }
        ///<summary>
        ///Makes the element either a child or parent of another element.
        ///</summary>
        ///<param name="oNewElement">An object that becomes the child or parent of the current element.</param>
        ///<returns>Returns a reference to the applied element.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlElement applyElement(HtmlElement oNewElement) { return null; }
        ///<summary>
        ///Removes all attributes and values from the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.None, NotSupportedRemark = @"IE doesn't clear event handlers and inline styles.")]
        public void clearAttributes() { }
        ///<summary>
        ///Copies all read/write attributes to the specified element.
        ///</summary>
        ///<param name="oSource">Pointer to an Object that specifies the attributes copied to the object that invokes mergeAttributes.</param>
        ///<param name="bPreserve">Available as of Microsoft Internet Explorer 5.5. Pointer to a Boolean that specifies one of the following values:
        ///true - Default. Preserve the identity of the object to which attributes are being merged.
        ///false - Do not preserve the identity of the object to which attributes are being merged.
        ///</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public void mergeAttributes(JsString oSource, JsBoolean bPreserve) { }
        ///<summary>
        ///Copies all read/write attributes to the specified element.
        ///</summary>
        ///<param name="oSource">Pointer to an Object that specifies the attributes copied to the object that invokes mergeAttributes.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public void mergeAttributes(JsString oSource) { }
        ///<summary>
        ///Replaces the object with another element.
        ///</summary>
        ///<param name="oNewNode">An Object that specifies the new element to replace the object.</param>
        ///<returns>Returns a reference to the object that is replaced.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlNode replaceNode(HtmlNode oNewNode) { return null; }
        ///<summary>
        ///Exchanges the location of two objects in the document hierarchy.
        ///</summary>
        ///<param name="oNode">Object that specifies the existing element.</param>
        ///<returns>Returns a reference to the object that invoked the method.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlNode swapNode(HtmlNode oNode) { return null; }
        ///<summary>
        ///Returns the number of element children
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber childElementCount { get; set; }
        ///<summary>
        ///Returns the first child that is an element node
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement firstElementChild { get; set; }
        ///<summary>
        ///Returns the last child that is an element node
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement lastElementChild { get; set; }
        ///<summary>
        ///Returns the next element node sibling
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement nextElementSibling { get; set; }
        ///<summary>
        ///Returns the previous  element node sibling
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement previousElementSibling { get; set; }
        ///<summary>
        ///Returns an object that contains the top, left, right, and bottom (all relative to the top left of the viewport) of the combined rectangle of element x. Essentially, the browser calculates all rectangles (see below getClientRects()), and getBoundingClientRect() returns the lowest (top, left) or highest (bottom, right) values found.
        ///</summary>
        ///<returns></returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = "Firefox doesn't round the top/bottom coordinates.")]
        public HtmlTextRectangle getBoundingClientRect() { return null; }
        ///<summary>
        ///Fires on a databound object after successfully updating the associated data in the data source object.
        ///</summary>		
        public HtmlDomEventHandler onafterupdate;
        ///<summary>
        ///Fires immediately before the object is set as the active element.
        ///</summary>		
        public HtmlDomEventHandler onbeforeactivate;
        ///<summary>
        ///Fires immediately before the activeElement is changed from the current object to another object in the parent document.
        ///</summary>		
        public HtmlDomEventHandler onbeforedeactivate;
        ///<summary>
        ///Fires before an object contained in an editable element enters a UI-activated state or when an editable container object is control selected.
        ///</summary>		
        public HtmlDomEventHandler onbeforeeditfocus;
        ///<summary>
        ///Fires on a databound object before updating the associated data in the data source object.
        ///</summary>		
        public HtmlDomEventHandler onbeforeupdate;
        ///<summary>
        ///Fires when the object loses the input focus.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.
Safari iPhone does not fire the event when the window loses the focus. ")]
        public HtmlDomEventHandler onblur;
        ///<summary>
        ///Fires when data changes in the data provider.
        ///</summary>		
        public HtmlDomEventHandler oncellchange;
        ///<summary>
        ///Fires when the user clicks the left mouse button on the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onclick;
        ///<summary>
        ///Fires when the user clicks the right mouse button in the client area, opening the context menu.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, PartiallySupportedRemark = @"To prevent the default in Firefox 3 you have to cancel the event bubbling.")]
        public HtmlDomEventHandler oncontextmenu;
        ///<summary>
        ///Fires when the user is about to make a control selection of the object.
        ///</summary>		
        public HtmlDomEventHandler oncontrolselect;
        ///<summary>
        ///Fires on the source element when the user copies the object or selection, adding it to the system clipboard.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, PartiallySupportedRemark = @"Firefox 3 has a lazy implementation.")]
        public HtmlDomEventHandler oncopy;
        ///<summary>
        ///Fires on the source element when the object or selection is removed from the document and added to the system clipboard.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, PartiallySupportedRemark = @"Firefox 3 has a lazy implementation.")]
        public HtmlDomEventHandler oncut;
        ///<summary>
        ///Fires periodically as data arrives from data source objects that asynchronously transmit their data.
        ///</summary>		
        public HtmlDomEventHandler ondataavailable;
        ///<summary>
        ///Fires when the data set exposed by a data source object changes.
        ///</summary>		
        public HtmlDomEventHandler ondatasetchanged;
        ///<summary>
        ///Fires to indicate that all data is available from the data source object.
        ///</summary>		
        public HtmlDomEventHandler ondatasetcomplete;
        ///<summary>
        ///Fires when the user double-clicks the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public HtmlDomEventHandler ondblclick;
        ///<summary>
        ///Fires on the source object continuously during a drag operation.
        ///</summary>		
        public HtmlDomEventHandler ondrag;
        ///<summary>
        ///Fires on the source object when the user releases the mouse at the close of a drag operation.
        ///</summary>		
        public HtmlDomEventHandler ondragend;
        ///<summary>
        ///Fires on the target element when the user drags the object to a valid drop target.
        ///</summary>		
        public HtmlDomEventHandler ondragenter;
        ///<summary>
        ///Fires on the target object when the user moves the mouse out of a valid drop target during a drag operation.
        ///</summary>		
        public HtmlDomEventHandler ondragleave;
        ///<summary>
        ///Fires on the target element continuously while the user drags the object over a valid drop target.
        ///</summary>		
        public HtmlDomEventHandler ondragover;
        ///<summary>
        ///Fires on the source object when the user starts to drag a text selection or selected object.
        ///</summary>		
        public HtmlDomEventHandler ondragstart;
        ///<summary>
        ///Fires on the target object when the mouse button is released during a drag-and-drop operation.
        ///</summary>		
        public HtmlDomEventHandler ondrop;
        ///<summary>
        ///Fires on a databound object when an error occurs while updating the associated data in the data source object.
        ///</summary>		
        public HtmlDomEventHandler onerrorupdate;
        ///<summary>
        ///Fires when a visual filter changes state or completes a transition.
        ///</summary>		
        public HtmlDomEventHandler onfilterchange;
        ///<summary>
        ///Fires when the object receives focus.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Firefox fires a focus event whenever you click on the document.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.")]
        public HtmlDomEventHandler onfocus;
        ///<summary>
        ///Fires when the user presses the F1 key while the browser is the active window.
        ///</summary>		
        public HtmlDomEventHandler onhelp;
        ///<summary>
        ///Fires when the user presses a key.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"The keydown event does not repeat in Opera and Konqueror.
You cannot prevent the default onkeydown in Opera.")]
        public HtmlDomEventHandler onkeydown;
        ///<summary>
        ///Fires when the user presses an alphanumeric key.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = "Firefox, Safari 3.0, Opera and Konqueror fire keypress events on any key. (The specification requires this event to be fired only if a keystroe leads to a character actually being added to an HTML element such as a text input.)")]
        public HtmlDomEventHandler onkeypress;
        ///<summary>
        ///Fires when the user releases a key.
        ///</summary>		
        public HtmlDomEventHandler onkeyup;
        ///<summary>
        ///Fires when the print or print preview layout process finishes filling the current LayoutRect object with content from the source document.
        ///</summary>		
        public HtmlDomEventHandler onlayoutcomplete;
        ///<summary>
        ///Fires when the object loses the mouse capture.
        ///</summary>		
        public HtmlDomEventHandler onlosecapture;
        ///<summary>
        ///Fires when the user clicks the object with either mouse button.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onmousedown;
        ///<summary>
        ///Fires when the user moves the mouse over the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onmousemove;
        ///<summary>
        ///Fires when the user moves the mouse pointer outside the boundaries of the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onmouseout;
        ///<summary>
        ///Fires when the user moves the mouse pointer into the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onmouseover;
        ///<summary>
        ///Fires when the user releases a mouse button while the mouse is over the object.
        ///</summary>		
        public HtmlDomEventHandler onmouseup;
        ///<summary>
        ///Fires when the wheel button is rotated.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public HtmlDomEventHandler onmousewheel;
        ///<summary>
        ///Fires when the object moves.
        ///</summary>		
        public HtmlDomEventHandler onmove;
        ///<summary>
        ///Fires when the object stops moving.
        ///</summary>		
        public HtmlDomEventHandler onmoveend;
        ///<summary>
        ///Fires when the object starts to move.
        ///</summary>		
        public HtmlDomEventHandler onmovestart;
        ///<summary>
        ///Fires on the target object when the user pastes data, transferring the data from the system clipboard to the document.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, @"Firefox 3 has a lazy implementation.")]
        public HtmlDomEventHandler onpaste;
        ///<summary>
        ///Fires when a property changes on the object.
        ///</summary>		
        public HtmlDomEventHandler onpropertychange;
        ///<summary>
        ///Fires when the state of the object has changed.
        ///</summary>		
        public HtmlDomEventHandler onreadystatechange;
        ///<summary>
        ///Fires when the size of the object is about to change.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onresize;
        ///<summary>
        ///Fires when the user finishes changing the dimensions of the object in a control selection.
        ///</summary>		
        public HtmlDomEventHandler onresizeend;
        ///<summary>
        ///Fires when the user begins to change the dimensions of the object in a control selection.
        ///</summary>		
        public HtmlDomEventHandler onresizestart;
        ///<summary>
        ///Fires to indicate that the current row has changed in the data source and new data values are available on the object.
        ///</summary>		
        public HtmlDomEventHandler onrowenter;
        ///<summary>
        ///Fires just before the data source control changes the current row in the object.
        ///</summary>		
        public HtmlDomEventHandler onrowexit;
        ///<summary>
        ///Fires when rows are about to be deleted from the recordset.
        ///</summary>		
        public HtmlDomEventHandler onrowsdelete;
        ///<summary>
        ///Fires just after new rows are inserted in the current recordset.
        ///</summary>		
        public HtmlDomEventHandler onrowsinserted;
        ///<summary>
        ///Fires when the user repositions the scroll box in the scroll bar on the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari probably monitors scrollTop access in order to determine whether the user has scrolled an element with overflow: auto.")]
        public HtmlDomEventHandler onscroll;
        ///<summary>
        ///Fires when the object is being selected.
        ///</summary>		
        public HtmlDomEventHandler onselectstart;
        ///<summary>
        ///Fires when the object is set as the active element.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlDomEventHandler onactivate;
        ///<summary>
        ///Fires on the source object before the selection is copied to the system clipboard.		
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3_1Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5)]
        public HtmlDomEventHandler onbeforecopy;
        ///<summary>
        ///Fires on the source object before the selection is deleted from the document.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3_1Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5)]
        public HtmlDomEventHandler onbeforecut;
        ///<summary>
        ///Fires on the target object before the selection is pasted from the system clipboard to the document.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3_1Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5, PartiallySupportedRemark = @"Safari 3.1 and Chrome do not fire this event before an actual paste action. It works fine on context menus.")]
        public HtmlDomEventHandler onbeforepaste;
        ///<summary>
        ///Fires when the activeElement is changed from the current object to another object in the parent document.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlDomEventHandler ondeactivate;
        ///<summary>
        ///Fires for an element just prior to setting focus on that element.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlDomEventHandler onfocusin;
        ///<summary>
        ///Fires for the current element with focus immediately after moving focus to another element.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlDomEventHandler onfocusout;
        ///<summary>
        ///Raised when there are changes to the portion of a URL that follows the number sign (#).
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlDomEventHandler onhashchange;
        ///<summary>
        ///Fires when the user moves the mouse pointer into the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlDomEventHandler onmouseenter;
        ///<summary>
        ///Fires when the user moves the mouse pointer outside the boundaries of the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlDomEventHandler onmouseleave;
        public void click() { }
        public JsString accessKey { get; set; }
    }
    #endregion
    #region HtmlElementStyle
    ///<summary>
    ///Represents the current settings of all possible inline styles for a given element.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ELEMENTSTYLE")]
    public partial class HtmlElementStyle
    {
        ///<summary>
        /// Sets or retrieves the bottom position of the object in the units specified by the bottom attribute.  
        ///</summary>
        public JsNumber posBottom;
        ///<summary>
        /// Sets or retrieves the height of the object in the units specified by the height attribute.  
        ///</summary>
        public JsNumber posHeight;
        ///<summary>
        ///Sets or retrieves the left position of the object in the units specified by the left attribute.  
        ///</summary>
        public JsNumber posLeft;
        ///<summary>
        ///Sets or retrieves the right position of the object in the units specified by the right attribute.  
        ///</summary>
        public JsNumber posRight;
        ///<summary>
        ///Sets or retrieves the top position of the object in the units specified by the top attribute.  
        ///</summary>
        public JsNumber posTop;
        ///<summary>
        ///Sets or retrieves the width of the object in the units specified by the width attribute.  
        ///</summary>
        public JsNumber posWidth;
        ///<summary>
        ///SSets or retrieves on which side of the object the text will flow.
        ///</summary>
        public JsString styleFloat;
        [JsProperty(NativeIndexer = true)]
        public object this[JsString s] { get { return null; } set { } }
        /// <summary>
        /// Sets or retrieves a value indicating how to manage the content of the object when the content exceeds the height or width of the object.
        ///	String that specifies or receives one of the following values.
        ///	visible		Default. Content is not clipped and scroll bars are not added. 
        ///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
        ///	hidden		Content that exceeds the dimensions of the object is not shown.
        ///	auto			Content is clipped and scrolling is added only when necessary.
        /// </summary>		
        public JsString overflow { get; set; }
        /// <summary>
        /// Sets or retrieves how to manage the content of the object when the content exceeds the width of the object.
        ///	String that specifies or receives one of the following values.
        ///	visible		Default. Content is not clipped and scroll bars are not added. Elements are clipped to the size of the containing window or frame.
        ///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
        ///	hidden		Content that exceeds the dimensions of the object is not shown.
        ///	auto			Content is clipped and scrolling is added only when necessary.
        /// </summary>		
        public JsString overflowX { get; set; }
        /// <summary>
        /// Sets or retrieves how to manage the content of the object when the content exceeds the height of the object.		
        ///	String that specifies or receives one of the following values.
        ///	visible		Default. Content is not clipped and scroll bars are not added. Elements are clipped to the size of the containing window or frame.
        ///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
        ///	hidden		Content that exceeds the dimensions of the object is not shown.
        ///	auto			Content is clipped and scrolling is added only when necessary.
        /// </summary>
        public JsString overflowY { get; set; }
        /// <summary>
        /// Sets or retrieves the type of positioning used for the object. 
        ///	String that specifies or receives one of the following values.
        ///	static		Default. Object has no special positioning; it follows the layout rules of HTML.
        ///	absolute	Object is positioned relative to parent element's position—or to the body object if its parent element is not positioned—using the top and left properties.
        ///	relative	Object is positioned according to the normal flow, and then offset by the top and left properties.
        ///	fixed			Windows Internet Explorer 7 and later. Object is positioned relative to the viewport containing the content.
        /// </summary>
        public JsString position { get; set; }
        ///<summary>
        ///Sets or retrieves the left position of the object. 
        ///</summary>
        public JsNumber pixelLeft { get; set; }
        ///<summary>
        ///Sets or retrieves the top position of the object. 
        ///</summary>
        public JsNumber pixelTop { get; set; }
        ///<summary>
        ///Opacity (supported by Mozilla Gecko and Apple WebKit)
        ///</summary>
        public double opacity { get; set; }
        ///<summary>
        ///Sets or retrieves the height of the object in the units specified by the height attribute. 
        ///</summary>
        public JsNumber pixelHeight { get; set; }
        ///<summary>
        ///Sets or retrieves the width of the object. 
        ///</summary>
        public JsNumber pixelWidth { get; set; }
        ///<summary>
        ///Sets or retrieves the height of the object. 
        ///String that specifies or receives one of the following values.
        ///auto				Default.  
        ///height			Floating-point number followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer followed by a percent sign (%). The value is a percentage of the height of the parent object, which must be specified explicitly. Negative values are not allowed.
        ///</summary>
        public JsString height { get; set; }
        ///<summary>
        ///Sets or retrieves the width of the object. 
        ///String that specifies or receives one of the following values.
        ///auto				Default. Default width of the object.
        ///width				Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units.
        ///percentage	Integer, followed by a %. The value is a percentage of the width of the parent object, whether or not it is specified explicitly. Negative values are not allowed.
        ///</summary>
        public JsString width { get; set; }
        ///<summary>
        ///Sets or retrieves the persisted representation of the style rule.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString cssText { get; set; }
        ///<summary>
        ///Sets or retrieves whether the content of the object is displayed. 
        ///String that specifies or receives one of the following values.
        ///inherit		Default. Object inherits the visibility of the next parent object.
        ///visible		Object is visible.
        ///hidden		Object is hidden.
        ///collapse  Internet Explorer 8. Used in tables to remove rows and columns; for all other elements, same as hidden.
        ///</summary>
        public JsString visibility { get; set; }
        /// <summary>
        /// Sets or retrieves whether the object is rendered.
        /// String that specifies or receives one of the following values.
        ///	blockObject is rendered as a block element.
        ///	inlineDefault. Object is rendered as an inline element sized by the dimensions of the content.
        ///	list-item Microsoft Internet Explorer 6 and later. Object is rendered as a block element, and a list-item marker is added.
        ///	none Object is not rendered.
        ///	table-header-group Object is rendered as tHead. Table header is always displayed before all other rows and row groups, and after any top captions. The header is displayed on each page spanned by a table. 
        ///	table-footer-group Object is rendered as tFoot. Table footer is always displayed after all other rows and row groups, and before any bottom captions. The footer is displayed on each page spanned by a table. 
        ///	inline-block Object is rendered inline, but the contents of the object are rendered as a block element. Adjacent inline elements are rendered on the same line, space permitting.
        ///	String that specifies or receives one of the following values.
        /// table  
        /// Internet Explorer 8. Object is rendered as table. 
        /// inline-table  
        /// Internet Explorer 8. Object is rendered as table within an inline-block. 
        /// table-row  
        /// Internet Explorer 8. Object is rendered as tr. 
        /// table-row-group  
        /// Internet Explorer 8. Object is rendered as tBody. Table body is always displayed after table-header-group objects and before table-footer-group objects. 
        /// table-column  
        /// Internet Explorer 8. Object is rendered as col. 
        /// table-column-group  
        /// Internet Explorer 8. Object is rendered as colGroup. 
        /// table-cell  
        /// Internet Explorer 8. Object is rendered as cell (td) or header cell (th), depending on location within the table. 
        /// table-caption  
        /// Internet Explorer 8. Object is rendered as caption. 
        /// run-in  
        /// Internet Explorer 8. If the run-in box contains a block element, object is rendered as a block. If not, and the following sibling is a block (which is neither floating nor absolutely positioned), object is rendered as the first inline-block of the sibling. Otherwise, same as block.
        /// ruby  
        /// Internet Explorer 8. Specifies that an element defines a ruby structure. This and the following values are from the CSS3 Ruby Module. 
        /// ruby-base  
        /// Internet Explorer 8. Specifies that an element defines a ruby base. 
        /// ruby-text  
        /// Internet Explorer 8. Specifies that an element defines a ruby text. 
        /// ruby-base-container  
        /// Internet Explorer 8. Specifies a container for one or more ruby base elements. 
        /// ruby-text-container  
        /// Internet Explorer 8. Specifies a container for one or more ruby text elements. 
        /// </summary>
        public JsString display { get; set; }
        ///<summary>
        ///Sets or retrieves the position of the object relative to the top of the next positioned object in the document hierarchy. 
        ///String that specifies or receives one of the following values:
        ///auto				Default. Default position according to the regular HTML layout of the page.
        ///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). This value is a percentage of the height of the parent object. 
        ///</summary>
        public JsString top { get; set; }
        ///<summary>
        ///Sets or retrieves the bottom position of the object in relation to the bottom of the next positioned object in the document hierarchy. 
        ///String that specifies or receives one of the following values:
        ///auto				Default. Default position according to the regular HTML layout of the page.
        ///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). This value is a percentage of the height of the parent object. 
        ///</summary>
        public JsString bottom { get; set; }
        ///<summary>
        ///Sets or retrieves the position of the object relative to the left edge of the next positioned object in the document hierarchy. 
        ///String that specifies or receives one of the following values:
        ///auto				Default. Position is determined by the regular HTML layout of the page.
        ///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). The value is a percentage of the width of the parent object.
        ///</summary>
        public JsString left { get; set; }
        ///<summary>
        ///Sets or retrieves the position of the object relative to the right edge of the next positioned object in the document hierarchy.
        ///String that specifies or receives one of the following values:
        ///auto				Default. Position is determined by the regular HTML layout of the page.
        ///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). The value is a percentage of the width of the parent object.
        ///</summary>
        public JsString right { get; set; }
        ///<summary>
        ///Sets or retrieves the stacking order of positioned objects. 
        ///String or Integer that specifies or receives one of the following values.
        ///auto. Default. String that specifies the stacking order of the positioned objects based on the order in which the objects appear in the HTML source.
        ///order. Integer that specifies the position of the object in the stacking order.		
        ///</summary>
        public JsString zIndex { get; set; }
        public StyleFilterCollection filters { get; set; }
        ///<summary>
        ///Sets or retrieves the filter or collection of filters applied to the object. 
        ///</summary>
        public JsString filter { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates whether the text in the object has blink, line-through, overline, or underline decorations. 
        ///String that specifies or receives one of the following values.
        ///none					Default. Text has no decoration.
        ///underline			Text is underlined.
        ///overline			Text has a line over it.
        ///line-through	Text has a line drawn through it.
        ///blink					Not implemented.
        ///</summary>
        public JsString textDecoration { get; set; }
        /// <summary>
        /// Sets or retrieves whether the text in the object is left-aligned, right-aligned, centered, or justified. 
        /// String that specifies or receives one of the following values.
        /// left		Default. Text is aligned to the left.
        ///	right		Text is aligned to the right.
        ///	center	Text is centered.
        ///	justify	Text is justified		
        /// </summary>
        public JsString textAlign { get; set; }
        /// <summary>
        /// Sets or retrieves the type of cursor to display as the mouse pointer moves over the object. 
        /// Default value is auto.
        /// String that specifies or receives one or more of the following possible values, separated by commas.
        ///	all-scroll		Microsoft Internet Explorer 6 and later. Arrows pointing up, down, left, and right with a dot in the middle, indicating that the page can be scrolled in any direction.
        ///	auto					Default. Browser determines which cursor to display based on the current context.
        ///	col-resize		Internet Explorer 6 and later. Arrows pointing left and right with a vertical bar separating them, indicating that the item/column can be resized horizontally.
        ///	crosshair			Simple cross hair.
        ///	default				Platform-dependent default cursor; usually an arrow.
        ///	hand					Hand with the first finger pointing up, as when the user moves the pointer over a link.
        ///	help					Arrow with question mark, indicating help is available.
        ///	move					Crossed arrows, indicating something is to be moved.
        ///	no-drop				Internet Explorer 6 and later. Hand with a small circle with a line through it, indicating that the dragged item cannot be dropped at the current cursor location.
        ///	not-allowed		Internet Explorer 6 and later. Circle with a line through it, indicating that the requested action will not be carried out.
        ///	pointer				Internet Explorer 6 and later. Hand with the first finger pointing up, as when the user moves the pointer over a link. Identical to hand.
        ///	progress			Internet Explorer 6 and later. Arrow with an hourglass next to it, indicating that a process is running in the background. User interaction with the page is unaffected.
        ///	row-resize		Internet Explorer 6 and later. Arrows pointing up and down with a horizontal bar separating them, indicating that the item/row can be resized vertically.
        ///	text					Editable text; usually an I-bar.
        ///	url(uri)			Internet Explorer 6 and later. Cursor is defined by the author, using a custom Uniform Resource Identifier (URI), such as url('mycursor.cur'). Cursors of type .CUR and .ANI are the only supported cursor types.
        ///	vertical-text	Internet Explorer 6 and later. Editable vertical text, indicated by a horizontal I-bar.
        ///	wait					Hourglass or watch, indicating that the program is busy and the user should wait.
        ///	*-resize			Arrows, indicating an edge is to be moved; the asterisk (*) can be N, NE, NW, S, SE, SW, E, or W—each representing a compass direction.
        /// </summary>
        public JsString cursor { get; set; }
        ///<summary>
        ///Sets or retrieves the vertical alignment of the object. 
        ///Default value is baseline.
        ///String that specifies or receives one of the following values.
        ///auto				Aligns the contents of an object according to the value of the layout-flow attribute.
        ///baseline		Default. Aligns the contents of an object supporting VALIGN to the base line.
        ///sub					Vertically aligns the text to subscript.
        ///super				Vertically aligns the text to superscript.
        ///top					Vertically aligns the contents of an object supporting VALIGN to the top of the object.
        ///middle			Vertically aligns the contents of an object supporting VALIGN to the middle of the object.
        ///bottom			Vertically aligns the contents of an object supporting VALIGN to the bottom of the object.
        ///text-top		Vertically aligns the text of an object supporting VALIGN to the top of the object.
        ///text-bottom	Vertically aligns the text of an object supporting VALIGN to the bottom of the object.
        ///</summary>
        public JsString verticalAlign { get; set; }
        /// <summary>
        /// Sets or retrieves a JsString that indicates whether the table layout is fixed.
        ///	auto		Default. Column width is set by the widest unbreakable content in the column cells.
        ///	fixed		Table and column widths are set either by the sum of the widths on the col objects or, if these are not specified, by the width of the first row of cells. If no width is specified for the table, it renders by default with width=100%.
        /// </summary>
        public JsString tableLayout { get; set; }
        public JsString margin;
        public JsString marginTop;
        public JsString marginBottom;
        public JsString marginLeft;
        public JsString marginRight;
        public JsString borderTop;
        public JsString borderBottom;
        public JsString borderLeft;
        public JsString borderRight;
        /// <summary>
        /// Sets or retrieves the amount of space to insert between the object and its margin or, if there is a border, between the object and its border. 
        ///	String that specifies or receives one of the following values.
        ///	length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units.
        ///	percentage	Integer, followed by a %. The value is a percentage of the width of the parent object.
        ///	The property has a default value of 0 for all objects with the following exceptions: TD -> 1, TH -> 1
        /// </summary>
        public JsString padding { get; set; }
        public JsString paddingTop;
        public JsString paddingBottom;
        public JsString paddingLeft;
        public JsString paddingRight;
        ///<summary>
        ///Sets or retrieves a value that indicates whether lines are automatically broken inside the object.
        ///String that specifies or receives one of the following values.
        ///normal		Default. Lines of text break automatically. Content wraps to the next line if it exceeds the width of the object.
        ///nowrap		Line breaks are suppressed. Content does not wrap to the next line.
        ///pre				Line breaks and other whitespace are preserved. This possible value is supported in Microsoft Internet Explorer 6 and later when the !DOCTYPE declaration specifies standards-compliant mode. When the !DOCTYPE declaration does not specify standards-compliant mode, you can retrieve this value, but it does not affect rendering—it functions like the normal value.
        ///pre-line (in IE8)  
        ///Sequences of line breaks are preserved. 
        ///pre-wrap (in IE8)
        ///Sequences of line breaks are collapsed. 
        ///</summary>
        public JsString whiteSpace { get; set; }
        ///<summary>
        ///Sets or retrieves the foreground color of the object's content. 
        ///</summary>
        public JsString color { get; set; }
        ///<summary>
        ///Sets or retrieves the color behind the content of the object. 
        ///String or Integer that specifies or receives one of the following values.
        ///transparent		Default. Color of the next parent object through which the background is visible.
        ///color					Any color value, including those specified in the Color Table.
        ///</summary>
        public JsString backgroundColor { get; set; }
        /// <summary>
        /// Sets or retrieves the background image of the object. 
        /// String that specifies or receives one of the following values.
        ///	none			Default. Color of the next parent through which the background is visible.
        ///	url(sUrl)	Location of the background image, where sUrl is an absolute or relative URL.
        /// </summary>
        public JsString backgroundImage { get; set; }
        ///<summary>
        ///Sets or retrieves how the backgroundImage property of the object is tiled.
        ///String that specifies or receives one of the following values.
        ///repeat		Default. Image is repeated horizontally and vertically.
        ///no-repeat	Image is not repeated.
        ///repeat-x	Image is repeated horizontally.
        ///repeat-y	Image is repeated vertically.
        ///</summary>
        public JsString backgroundRepeat { get; set; }
        /// <summary>
        /// Sets or retrieves how the background image is attached to the object within the document.
        /// String that specifies or receives one of the following values.
        ///	scroll	Default. Background image scrolls with the object as the document is scrolled.
        ///	fixed		Background image stays fixed within the viewable area of the object.
        /// </summary>
        public JsString backgroundAttachment { get; set; }
        /// <summary>
        /// Sets or retrieves the position of the background of the object. 
        /// String that specifies or receives one or two of the following values. 
        /// length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        /// percentage	Integer, followed by a percent sign (%). The value is a percentage of the width or height of the object.
        /// vAlignment Vertical alignment value. Possible values include the following: 
        ///			top					Vertical alignment is at the top.
        ///			center			Vertical alignment is centered.
        ///			bottom			Vertical alignment is at the bottom.
        /// hAlignment	Horizontal alignment value. Possible values include the following: 
        ///			left				Horizontal alignment is to the left.
        ///			center			Horizontal alignment is centered.
        ///			right				Horizontal alignment is to the right.
        /// </summary>
        public JsString backgroundPosition { get; set; }
        public JsString backgroundPositionX { get; set; }
        public JsString backgroundPositionY { get; set; }
        /// <summary>
        /// Sets or retrieves up to five separate background properties of the object.
        /// String that specifies or receives up to five of the following space-delimited values, in any order:
        ///	color Any of the range of color values available to the backgroundColor property. 
        /// image Any of the range of image values available to the backgroundImage property.
        ///	repeat Any of the range of repeat values available to the backgroundRepeat property.
        ///	attachment Any of the range of attachment values available to the backgroundAttachment property.
        ///	position Any of the range of position values available to the backgroundPosition property.
        /// </summary>
        public JsString background { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates the font size used for text in the object. 
        ///value = String that specifies or receives one of the following values.
        ///absolute-size Set of keywords that indicate predefined font sizes. Named font sizes scale according to the user's font setting preferences. Possible values include the following: xx-small, x-small, small, medium, large, x-large, xx-large.  
        ///relative-size Set of keywords that are interpreted as relative to the font size of the parent object. Possible values include the following: larger, smaller.  
        ///length Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see the CSS Length Units Reference. 
        ///percentage Integer, followed by a percent (%). The value is a percentage of the parent object's font size. In Microsoft Internet Explorer 3.0, the value is calculated as a percentage of the default font size. 
        ///Default - medium (of the absolute-size set).
        ///</summary>
        public JsString fontSize { get; set; }
        ///<summary>
        ///Sets or retrieves the font style of the object as italic, normal, or oblique.
        ///String that specifies or receives one of the following values.
        ///normal Default. Font is normal. 
        ///italic Font is italic. 
        ///oblique Font is italic.  
        ///</summary>
        public JsString fontStyle { get; set; }
        ///<summary>
        ///Sets or retrieves whether the text of the object is in small capital letters.
        ///String that specifies or receives one of the following values.
        ///normal Default. Font is normal. 
        ///small-caps Font is in small capital letters. 
        ///</summary>
        public JsString fontVariant { get; set; }
        ///<summary>
        ///Sets or retrieves the name of the font used for text in the object. 
        ///String that specifies or receives one of the following values.
        ///family-name Any of the available font families supported by the browser. For example, Times, Helvetica, Zapf-Chancery, Western, or Courier. 
        ///generic-name Any of the following font families: serif, sans-serif, cursive, fantasy, or monospace. 
        ///</summary>
        public JsString fontFamily { get; set; }
        ///<summary>
        ///Sets or retrieves the weight of the font of the object. 
        ///String that specifies or receives one of the following values.
        ///normal Font is normal. 
        ///bold Font is bold. 
        ///bolder Font is at least as bold as the default bold weight. 
        ///lighter Font is lighter than normal. 
        ///100 Font is at least as light as the 200 weight. 
        ///200 Font is at least as bold as the 100 weight and at least as light as the 300 weight. 
        ///300 Font is at least as bold as the 200 weight and at least as light as the 400 weight. 
        ///400 Font is normal. 
        ///500 Font is at least as bold as the 400 weight and at least as light as the 600 weight. 
        ///600 Font is at least as bold as the 500 weight and at least as light as the 700 weight. 
        ///700 Font is bold. 
        ///800 Font is at least as bold as the 700 weight and at least as light as the 900 weight. 
        ///900 Font is at least as bold as the 800 weight. 
        ///</summary>
        public JsString fontWeight { get; set; }
        ///<summary>
        ///Sets or retrieves the distance between lines in the object. 
        ///String that specifies or receives one of the following values.
        ///normal			Default. Default height.
        ///height			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). The value is a percentage of the height of the parent object. 
        ///</summary>
        public JsString lineHeight { get; set; }
        ///<summary>
        ///Sets or retrieves a combination of separate font properties of the object. Alternatively, sets or retrieves one or more of six user-preference fonts.
        ///String that specifies or receives up to six of the following space-delimited property values. Alternatively, sets or retrieves the six listed text fonts.
        ///font-style Any of the range of font-style values available to the fontStyle property. 
        ///font-variant Any of the range of font-variant values available to the fontVariant property. 
        ///font-weight Any of the range of font-weight values available to the fontWeight property. 
        ///font-size Any of the range of font-size values available to the fontSize property. When this value is an integer followed by a percent (%), the value is a percentage of the parent object's font size. In Microsoft Internet Explorer 3.0, a percentage value is calculated as a percentage of the default font size. 
        ///line-height Any of the range of line-height values available to the lineHeight property. When used with the font property, this attribute must include a slash (/) before the value. Line height percentage values are calculated as a percentage of the font size of the element itself, not of the parent. 
        ///font-family Any of the range of font-family values available to the fontFamily property. This property can be set to multiple comma-separated values. Its default value depends on user settings. 
        ///caption User-preference font used in objects that have captions—buttons, labels, and so on. 
        ///icon User-preference font used in icon labels. 
        ///menu User-preference font used in menus. 
        ///message-box User-preference font used in dialog boxes. 
        ///small-caption User-preference font used in small controls. 
        ///status-bar User-preference font used in window status bars. 
        ///</summary>
        public JsString font { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates whether the row and cell borders of a table are joined in a single border or detached as in standard HTML.
        ///String that specifies or receives one of the following values.
        ///separate Default. Borders are detached (standard HTML).  
        ///collapse Borders are collapsed, where adjacent, into a single border.  
        ///</summary>
        public JsString borderCollapse { get; set; }
        /// <summary>
        /// Sets or retrieves the properties to draw around the object.
        /// String that specifies or receives one or more of the following space-delimited values:
        ///	width. Any of the range of width values available to the borderWidth property.
        ///	style. Any of the range of style values available to the borderStyle property.
        ///	color. Any of the range of color values available to the borderColor property.
        /// </summary>
        public JsString border { get; set; }
        /// <summary>
        /// Sets or retrieves the style of the left, right, top, and bottom borders of the object. 
        /// String that specifies or receives one of the following values.
        /// none. Default. No border is drawn, regardless of any specified borderWidth.
        /// dotted. Border is a dotted line. This value is supported on the Macintosh platform, as of Microsoft Internet Explorer 4.01, and on the Microsoft Windows platform, as of Internet Explorer 5.5. It renders as a solid line on Unix platforms, and on Windows systems running earlier versions of Windows Internet Explorer.
        ///	dashed. Border is a dashed line. This value is supported on the Macintosh platform as of Internet Explorer 4.01 and on the Windows platform, as of Internet Explorer 5.5. It renders as a solid line on Unix platforms, and on Windows systems running earlier versions of Internet Explorer.
        ///	solid. Border is a solid line.
        ///	double. Border is a double line drawn on top of the background of the object. The sum of the two single lines and the space between equals the borderWidth value. The border width must be at least 3 pixels wide to draw a double border.
        ///	groove. 3-D groove is drawn in colors based on the value. The borderWidth property of the object must be specified for the style to render correctly.
        ///	ridge. 3-D ridge is drawn in colors based on the value.
        ///	inset. 3-D inset is drawn in colors based on the value.
        ///	window-inset. Border is the same as inset, but is surrounded by an additional single line, drawn in colors based on the value.
        ///	outset. 3-D outset is drawn in colors based on the value.
        /// window-inset. Internet Explorer 6 and later. Same as inset with a thin outside border. 
        /// </summary>
        public JsString borderStyle { get; set; }
        /// <summary>
        /// Sets or retrieves the width of the left, right, top, and bottom borders of the object. 
        /// String that specifies or receives up to four of the following values:
        ///	medium. Default.		
        /// thin. Width less than the default.
        /// thick. Width greater than the default.
        /// width. Width consisting of a floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px)
        /// </summary>
        public JsString borderWidth { get; set; }
        /// <summary>
        /// Sets or retrieves the border color of the object.
        ///	String that specifies or receives one or more of the following space-delimited values:
        /// transparent. Border is transparent.
        /// color. Up to four color names or RGB values in the Color Table. 
        /// </summary>
        public JsString borderColor { get; set; }
        ///<summary>
        ///Returns the optional priority, "important".
        ///</summary>
        ///<param name="propertyName">property name</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString getPropertyPriority(JsString propertyName) { return null; }
        ///<summary>
        ///Returns the property value.
        ///</summary>
        ///<param name="propertyName">property name</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString getPropertyValue(JsString propertyName) { return null; }
        ///<summary>
        ///Sets the property value.
        ///</summary>
        ///<param name="propertyName">property name</param>
        ///<param name="value">value</param>
        ///<param name="priority">'important' or null</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString setProperty(JsString propertyName, JsString value, JsString priority) { return null; }
        ///<summary>
        ///Removed a declaration from a stylesheet
        ///</summary>
        ///<param name="propertyName">property name</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"Opera refuses to remove the last remaining property of a rule.")]
        public void removeProperty(JsString propertyName) { }
    }
    #endregion
    #region HtmlEmbedElement
    ///<summary>
    ///Allows documents of any type to be embedded.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "EMBEDELEMENT")]
    public partial class HtmlEmbedElement : HtmlElement
    {
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
    }
    #endregion
    #region HtmlFieldSet
    [JsType(JsMode.Prototype, Export = false, Name = "FIELDSET")]
    public partial class HtmlFieldSet : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves how the object is aligned with adjacent text.
        ///</summary>
        public JsString align { get; set; }
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form { get; set; }
    }
    #endregion
    #region HtmlFontElement
    ///<summary>
    ///User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlFontElement : HtmlElement
    {
        public JsString color { get; set; }
        public JsString face { get; set; }
        public JsString size { get; set; }
    }
    #endregion
    #region HtmlForm
    ///<summary>
    ///Specifies that the contained controls take part in a form.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "FORM")]
    public partial class HtmlForm : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves a list of character encodings for input data that must be accepted by the server processing the form.
        ///</summary>
        public JsString acceptCharset { get; set; }
        ///<summary>
        ///Sets or retrieves the number of objects in a collection.
        ///</summary>
        public JsNumber length { get; set; }
        ///<summary>
        ///Sets or retrieves the URL to which the form content is sent for processing.
        ///</summary>
        public JsString action { get; set; }
        ///<summary>
        ///Sets or retrieves how to send the form data to the server.
        ///Receives one of the following values:
        ///<list type="table">
        ///<item><term>GET</term><description>Append the arguments to the action URL and open it as if it were an anchor.</description></item>
        ///<item><term>POST</term><description>Send the data through an HTTP post transaction.</description></item>
        ///</list>
        ///</summary>
        public JsString method { get; set; }
        ///<summary>
        ///Submits the form.
        ///</summary>
        public void submit() { }
        ///<summary>
        ///Fires when the user resets a form.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onreset;
        ///<summary>
        ///Fires when a FORM is about to be submitted.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public HtmlDomEventHandler onsubmit;
    }
    #endregion
    #region HtmlFrameElement
    ///<summary>
    ///Specifies an individual frame within a frameSet element.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "FRAMEELEMENT")]
    public partial class HtmlFrameElement : HtmlElement
    {
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
        public JsString frameBorder { get; set; }
        public JsString name { get; set; }
        public JsBoolean noResize { get; set; }
        public JsString scrolling { get; set; }
        public JsString src { get; set; }
        public HtmlDocument contentDocument { get; set; }
    }
    #endregion
    #region HtmlFrameSetElement
    ///<summary>
    ///Specifies a frameset, which is used to organize multiple frames and nested framesets.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "FRAMESETELEMENT")]
    public partial class HtmlFrameSetElement : HtmlElement
    {
        ///<summary>
        ///Fires on the object immediately after its associated document prints or previews for printing.
        ///</summary>		
        public HtmlDomEventHandler onafterprint;
        ///<summary>
        ///Fires on the object before its associated document prints or previews for printing.
        ///</summary>		
        public HtmlDomEventHandler onbeforeprint;
        ///<summary>
        ///Fires prior to a page being unloaded.
        ///</summary>		
        public HtmlDomEventHandler onbeforeunload;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
        ///<summary>
        ///Fires immediately before the object is unloaded.
        ///</summary>		
        public HtmlDomEventHandler onunload;
    }
    #endregion
    #region HtmlHead
    ///<summary>
    ///Represents the HEAD element of a HTML document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HEAD")]
    public partial class HtmlHead : HtmlElement
    {
        protected HtmlHead() { }
    }
    #endregion
    #region HtmlHeadingElement
    ///<summary>
    ///These elements represent headings for their sections.User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlHeadingElement : HtmlElement
    {
        public JsString align { get; set; }
    }
    #endregion
    #region HtmlHorizontalRule
    ///<summary>
    ///Draws a horizontal rule.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HORIZONTALRULE")]
    public partial class HtmlHorizontalRule : HtmlElement
    {
        protected HtmlHorizontalRule() { }
        public JsString align { get; set; }
        public JsString color { get; set; }
        public JsBoolean noShade { get; set; }
        public JsString size { get; set; }
    }
    #endregion
    #region HtmlHtmlElement
    ///<summary>
    ///The html element represents the root of an HTML document.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlHtmlElement : HtmlElement
    {
        public JsString version { get; set; }
    }
    #endregion
    #region HtmlIFrame
    ///<summary>
    ///Creates inline floating frames. 
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "IFRAME")]
    public partial class HtmlIFrame : HtmlElement
    {
        protected HtmlIFrame() { }
        public JsString readyState
        {
            get;
            private set;
        }
        /// <summary>
        /// Sets or retrieves whether to display a border for the frame.
        /// Possible values:
        ///	1		Default. Inset border is drawn.
        /// 0		No border is drawn.
        /// no		No border is drawn.
        /// yes		Inset border is drawn.
        /// </summary>
        public JsString frameBorder { get; set; }
        ///<summary>
        ///Sets or retrieves a URL to be loaded by the object.
        ///</summary>
        public JsString src { get; set; }
        ///<summary>
        ///Sets or retrieves whether the object can be transparent.
        ///</summary>
        public JsBoolean allowTransparency { get; set; }
        ///<summary>
        ///Sets or retrieves the space between the frames, including the 3-D border. 
        ///</summary>
        public JsString border { get; set; }
        ///<summary>
        ///Sets or retrieves the top and bottom margin heights before displaying the text in a frame. 
        ///</summary>
        public JsNumber marginHeight { get; set; }
        ///<summary>
        ///Sets or retrieves the left and right margin widths before displaying the text in a frame. 
        ///</summary>
        public JsNumber marginWidth { get; set; }
        ///<summary>
        ///Sets or retrieves the height of the object. 
        ///</summary>
        public JsString height { get; set; }
        ///<summary>
        ///Sets or retrieves the width of the object. 
        ///</summary>
        public JsString width { get; set; }
        ///<summary>
        ///Sets or retrieves the vertical margin for the object. 
        ///</summary>
        public JsNumber vspace { get; set; }
        ///<summary>
        ///Sets or retrieves whether the frame can be scrolled.
        ///</summary>
        public JsString scrolling { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates the table alignment.
        ///</summary>
        public JsString align { get; set; }
        ///<summary>
        ///Retrieves the window object of the specified frame or iframe.
        ///</summary>
        public HtmlWindow contentWindow { get; set; }
        ///<summary>
        ///Sets or retrieves the amount of additional space between the frames.
        ///</summary>
        public JsString frameSpacing { get; set; }
        ///<summary>
        ///Sets or retrieves the horizontal margin for the object.
        ///</summary>
        public JsString hspace { get; set; }
        ///<summary>
        ///Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
        ///</summary>
        public JsString longDesc { get; set; }
        ///<summary>
        ///Sets or retrieves the frame name.
        ///</summary>
        public JsString name { get; set; }
        ///<summary>
        ///Sets or retrieves whether the user can resize the frame.
        ///</summary>
        public JsBoolean noResize { get; set; }
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
    }
    #endregion
    #region HtmlImage
    ///<summary>
    ///Embeds an image or a video clip in the document.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "IMAGE")]
    public partial class HtmlImage : HtmlElement
    {
        public void main() { }
        ///<summary>
        ///Sets or retrieves how the object is aligned with adjacent text.
        ///</summary>
        public JsString align { get; set; }
        ///<summary>
        ///Sets or retrieves a text alternative to the graphic.
        ///</summary>
        public JsString alt { get; set; }
        ///<summary>
        ///Sets the properties to draw around the object.
        ///</summary>
        public JsString border { get; set; }
        ///<summary>
        ///Sets the height of the object.
        ///</summary>
        public JsString height { get; set; }
        ///<summary>
        ///Sets the horizontal margin for the object.
        ///</summary>
        public JsNumber hspace { get; set; }
        ///<summary>
        ///Sets a URL to be loaded by the object.
        ///</summary>
        public JsString src { get; set; }
        ///<summary>
        ///Sets the URL, often with a bookmark extension (#name), to use as a client-side image map.
        ///</summary>
        public JsString usemap { get; set; }
        ///<summary>
        ///Sets the vertical margin for the object.
        ///</summary>
        public JsNumber vspace { get; set; }
        ///<summary>
        ///Sets the width of the object.
        ///</summary>
        public JsString width { get; set; }
        ///<summary>
        ///Retrieves whether the object is fully loaded.
        ///</summary>
        public JsString complete { get; set; }
        ///<summary>
        ///Retrieves the date the file was created.
        ///</summary>
        public DateTime fileCreatedDate { get; set; }
        ///<summary>
        ///Retrieves the date the file was last modified.
        ///</summary>
        public DateTime fileModifiedDate { get; set; }
        ///<summary>
        ///Retrieves the file size.
        ///</summary>
        public JsNumber fileSize { get; set; }
        ///<summary>
        ///Retrieves the date the file was last updated.
        ///</summary>
        public DateTime fileUpdatedDate { get; set; }
        ///<summary>
        ///Sets or retrieves a destination URL or an anchor point.
        ///</summary>
        public JsString href { get; set; }
        ///<summary>
        ///Sets or retrieves whether the image is a server-side image map.
        ///</summary>
        public JsString isMap { get; set; }
        ///<summary>
        ///Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
        ///</summary>
        public JsString longDesc { get; set; }
        ///<summary>
        ///Sets or retrieves the number of times a sound or video clip will loop when activated.
        ///</summary>
        public JsString loop { get; set; }
        ///<summary>
        ///Sets or retrieves a lower resolution image to display.
        ///</summary>
        public JsString lowsrc { get; set; }
        ///<summary>
        ///Retrieves the file name specified in the href or src property of the object.
        ///</summary>
        public JsString nameProp { get; set; }
        ///<summary>
        ///Sets or retrieves the protocol portion of a URL.
        ///</summary>
        public JsString protocol { get; set; }
        ///<summary>
        ///Sets or retrieves when a video clip file should begin playing.
        ///</summary>
        public JsString start { get; set; }
        ///<summary>
        ///Sets or retrieves the URL of the virtual reality modeling language (VRML) world to be displayed in the window.
        ///</summary>
        public JsString vrml { get; set; }
        ///<summary>
        ///Fires when the user aborts the download of an image.
        ///</summary>		
        public HtmlDomEventHandler onabort;
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
    }
    #endregion
    #region HtmlInputCheckBox
    [JsType(JsMode.Prototype, Export = false, Name = "INPUTCHECKBOX")]
    public partial class HtmlInputCheckBox : HtmlInput
    {
        protected HtmlInputCheckBox() { }
    }
    #endregion
    #region HtmlInput
    ///<summary>
    ///Creates a variety of form input controls.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "INPUT")]
    public partial class HtmlInput : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves a comma-separated list of content types.
        ///</summary>
        public JsString accept { get; set; }
        ///<summary>
        ///Sets or retrieves how the object is aligned with adjacent text.
        ///</summary>
        public JsString align { get; set; }
        ///<summary>
        ///Sets or retrieves a text alternative to the graphic.
        ///</summary>
        public JsString alt { get; set; }
        ///<summary>
        ///Sets or retrieves the state of the check box or radio button.
        ///</summary>
        public JsBoolean @checked { get; set; }
        ///<summary>
        ///Retrieves whether the object is fully loaded.
        ///</summary>
        public JsString complete { get; set; }
        ///<summary>
        ///Sets or retrieves the initial contents of the object.
        ///</summary>
        public JsString defaultValue { get; set; }
        ///<summary>
        ///Sets or retrieves the state of the check box or radio button.
        ///</summary>
        public JsString defaultChecked { get; set; }
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form { get; set; }
        ///<summary>
        ///Sets or retrieves a lower resolution image to display.
        ///</summary>
        public JsString lowsrc { get; set; }
        ///<summary>
        ///Sets or retrieves the number of times a sound or video clip will loop when activated.
        ///</summary>
        public JsString loop { get; set; }
        ///<summary>
        ///Sets or retrieves the horizontal margin for the object.
        ///</summary>
        public JsString hspace { get; set; }
        ///<summary>
        ///Sets or retrieves the vertical margin for the object.
        ///</summary>
        public JsString vspace { get; set; }
        ///<summary>
        ///Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
        ///</summary>
        public JsString useMap { get; set; }
        ///<summary>
        ///Sets or retrieves the value indicated whether the content of the object is read-only.
        ///</summary>
        public JsString readOnly { get; set; }
        ///<summary>
        ///Sets or retrieves the size of the control.
        ///</summary>
        public JsString size { get; set; }
        ///<summary>
        ///Sets or retrieves a URL to be loaded by the object.
        ///</summary>
        public JsString src { get; set; }
        ///<summary>
        ///Sets or retrieves when a video clip file should begin playing.
        ///</summary>
        public JsString start { get; set; }
        ///<summary>
        ///Sets or retrieves the calculated width of the object.
        ///</summary>
        public JsString width { get; set; }
        /// <summary>
        /// Sets or retrieves the value indicating whether the control is selected.
        /// Possible values:
        ///	false	Default. Control is not selected.
        /// true	Control is selected.
        /// null	Control is not initialized.
        /// </summary>
        public JsBoolean status { get; set; }
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name { get; set; }
        ///<summary>
        ///Retrieves the file name of the input object after the text is set by user input.
        ///</summary>
        public JsString value { get; set; }
        ///<summary>
        ///Retrieves or initially sets the type of input control represented by the object.
        ///</summary>
        public JsString type { get; set; }
        ///<summary>
        ///Highlights the input area of a form element.
        ///</summary>
        public void select() { }
        ///<summary>
        ///Creates a TextRange object for the element.
        ///Use a text range to examine and modify the text within an object.
        ///</summary>
        ///<returns>Returns a TextRange object if successful, or null otherwise.</returns>
        public HtmlTextRange createTextRange() { return null; }
        ///<summary>
        ///Sets or retrieves the maximum number of characters that the user can enter in a text control. 
        ///</summary>
        public JsNumber maxLength { get; set; }
        ///<summary>
        ///Fires when the user aborts the download of an image.
        ///</summary>		
        public HtmlDomEventHandler onabort;
        ///<summary>
        ///Fires when the contents of the object or selection have changed.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select. IE has a serious bug in its handling of this event on checkboxes and radios.")]
        public HtmlDomEventHandler onchange;
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
        ///<summary>
        ///Fires when the current selection changes.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public HtmlDomEventHandler onselect;
    }
    #endregion
    #region HtmlLabelElement
    ///<summary>
    ///The label represents a caption in a user interface. The caption can be associated with a specific form control , known as the labelelement's labeled control , either using for attribute, or by putting the form control inside the label element itself.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlLabelElement : HtmlElement
    {
        public HtmlForm form { get; set; }
        public JsString htmlFor { get; set; }
        public HtmlElement control { get; set; }
    }
    #endregion
    #region HtmlLegend
    [JsType(JsMode.Prototype, Export = false, Name = "LEGEND")]
    public partial class HtmlLegend : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves the alignment of the caption or legend.
        ///</summary>
        public JsString align { get; set; }
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form { get; set; }
    }
    #endregion
    #region HtmlLineBreak
    ///<summary>
    ///Inserts a line break.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "LINEBREAK")]
    public partial class HtmlLineBreak : HtmlElement
    {
        protected HtmlLineBreak() { }
    }
    #endregion
    #region HtmlLink
    ///<summary>
    ///Represents a LINK html node
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "LINK")]
    public partial class HtmlLink : HtmlElement
    {
        protected HtmlLink() { }
        ///<summary>
        ///Sets or retrieves the destination URL or anchor point.
        ///</summary>
        public JsString href { get; set; }
        ///<summary>
        ///Sets or retrieves the relationship between the object and the destination of the link. e.g. 'stylesheet'
        ///</summary>
        public JsString rel { get; set; }
        ///<summary>
        ///Sets or retrieves the MIME type of the object. e.g. 'text/css'
        ///</summary>
        public JsString type { get; set; }
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
    }
    #endregion
    #region HtmlListItem
    ///<summary>
    ///Represents an HTML list item
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "LISTITEM")]
    public partial class HtmlListItem : HtmlElement
    {
    }
    #endregion
    #region HtmlMapElement
    ///<summary>
    ///The map element, in conjunction with any area element descendants, defines an image map . The element represents its children.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlMapElement : HtmlElement
    {
        public JsString name { get; set; }
        public HtmlElementCollection areas { get; set; }
        public HtmlElementCollection images { get; set; }
    }
    #endregion
    #region HtmlMarqueeElement
    ///<summary>
    ///Creates a scrolling text marquee.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "MARQUEEELEMENT")]
    public partial class HtmlMarqueeElement : HtmlElement
    {
        ///<summary>
        ///Fires when the behavior property of the marquee object is set to "alternate" and the contents of the marquee reach one side of the window.
        ///</summary>		
        public HtmlDomEventHandler onbounce;
        ///<summary>
        ///Fires when marquee looping is complete.
        ///</summary>		
        public HtmlDomEventHandler onfinish;
        ///<summary>
        ///Fires at the beginning of every loop of the marquee object.
        ///</summary>		
        public HtmlDomEventHandler onstart;
        public void start() { }
    }
    #endregion
    #region HtmlMetaElement
    ///<summary>
    ///The meta element represents various kinds of metadata that cannot be expressed using the title , base , link , style , and script elements.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlMetaElement : HtmlElement
    {
        public JsString name { get; set; }
        public JsString httpEquiv { get; set; }
        public JsString content { get; set; }
        public JsString scheme { get; set; }
    }
    #endregion
    #region HtmlNode
    ///<summary>
    ///Represents an HtmlNode
    ///</summary>
    [JsType(JsMode.Prototype, OmitCasts = true, Export = false)]
    public abstract partial class HtmlNode
    {
        ///<summary>
        ///Replaces an existing child element with a new child element.
        ///</summary>
        ///<param name="newNode"></param>
        ///<param name="existingChild"></param>
        ///<returns>Returns a reference to the object that is replaced.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlNode replaceChild(HtmlNode newNode, HtmlNode existingChild) { return null; }
        /// <summary>
        /// Returns the node type
        /// </summary>
        /// <remarks>
        /// <list type="table">
        ///		<item>
        ///			<term>1</term>
        ///			<description>Element node.</description>
        ///		</item>
        ///		<item>
        ///			<term>2</term>
        ///			<description>Attribute node.</description>
        ///		</item>
        ///		<item>
        ///			<term>3</term>
        ///			<description>Text node.</description>
        ///		</item>
        ///		<item>
        ///			<term>4</term>
        ///			<description>CDATA node.</description>
        ///		</item>
        ///		<item>
        ///			<term>5</term>
        ///			<description>Entity Reference node.</description>
        ///		</item>
        ///		<item>
        ///			<term>6</term>
        ///			<description>Entity node.</description>
        ///		</item>
        ///		<item>
        ///			<term>7</term>
        ///			<description>Processing instruction node.</description>
        ///		</item>
        ///		<item>
        ///			<term>8</term>
        ///			<description>Comment node.</description>
        ///		</item>
        ///		<item>
        ///			<term>9</term>
        ///			<description>HtmlDocument node.</description>
        ///		</item>
        ///		<item>
        ///			<term>10</term>
        ///			<description>Document type (DOCTYPE) node.</description>
        ///		</item>
        ///		<item>
        ///			<term>11</term>
        ///			<description>Document fragment node.</description>
        ///		</item>
        ///		<item>
        ///			<term>12</term>
        ///			<description>Notation node.</description>
        ///		</item>
        /// </list>
        /// </remarks>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"IE 5.5: attributes and document not defined; comment has nodeType 1.
		Konqueror doesn't see comment nodes.")]
        public JsNumber nodeType;
        ///<summary>
        ///Retrieves a reference to the previous child of the parent for the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNode previousSibling { get; set; }
        ///<summary>
        ///Retrieves a reference to the next child of the parent for the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNode nextSibling { get; set; }
        ///<summary>
        ///Retrieves the name of a particular type of node. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"IE 5.5 doesn't support a nodeName for attributes and the document. 
IE 5.5 reports the nodeName of a comment as !. 
Konqueror doesn't see comment nodes.")]
        public JsString nodeName { get; set; }
        ///<summary>
        ///Sets or retrieves the value of a node.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"IE 5.5 doesn't support nodeValue for attributes
		Konqueror doesn't see comment nodes.")]
        public JsString nodeValue { get; set; }
        ///<summary>
        ///Retrieves the parent object in the document hierarchy.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElement parentNode { get; set; }
        ///<summary>
        ///Compares the position of the current node against another node in any other document.
        ///</summary>
        ///<param name="otherNode ">the node that's being compared against.</param>
        ///<returns>a bitmask:
        ///1: Position disconnected
        ///2: Precedes
        ///4: Follows
        ///8: Contains
        ///16: Is contained by
        ///</returns>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public JsNumber compareDocumentPosition(HtmlNode otherNode) { return null; }
        ///<summary>
        ///Returns a value that indicates whether the object has children.
        ///</summary>
        ///<returns>Returns true if the object contains HTML Elements or TextNode objects, or false if the object does not contain HTML Elements or TextNodes.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsBoolean hasChildNodes() { return null; }
        ///<summary>
        ///Retrieves the document object associated with the node.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDocument ownerDocument { get; set; }
        public const JsNumber DOCUMENT_POSITION_DISCONNECTED = null;
        public const JsNumber DOCUMENT_POSITION_PRECEDING = null;
        public const JsNumber DOCUMENT_POSITION_FOLLOWING = null;
        public const JsNumber DOCUMENT_POSITION_CONTAINS = null;
        public const JsNumber DOCUMENT_POSITION_CONTAINED_BY = null;
    }
    #endregion
    #region HtmlObjectElement
    ///<summary>
    ///Inserts an object into the HTML page.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "OBJECTELEMENT")]
    public partial class HtmlObjectElement : HtmlElement
    {
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public HtmlDomEventHandler onerror;
    }
    #endregion
    #region HtmlOptGroupElement
    ///<summary>
    ///The optgroup element represents a group of option elements with a common label.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlOptGroupElement : HtmlElement
    {
        public new JsBoolean disabled { get; set; }
        public JsString label { get; set; }
    }
    #endregion
    #region HtmlOption
    ///<summary>
    ///Denotes one choice in a SELECT element.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "OPTION")]
    public partial class HtmlOption : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves the value which is returned to the server when the form control is submitted.
        ///</summary>
        public JsString value { get; set; }
        ///<summary>
        ///Sets or retrieves the text JsString specified by the option tag. 
        ///</summary>
        public JsString text { get; set; }
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        ///<summary>
        ///Sets or retrieves the status of an option.
        ///</summary>
        public JsBoolean defaultSelected { get; set; }
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form { get; set; }
        ///<summary>
        ///Sets or retrieves the ordinal position of an option in a list box.
        ///</summary>
        public JsString label { get; set; }
        ///<summary>
        ///Sets or retrieves whether the option in the list box is the default item.
        ///</summary>
        public JsBoolean selected { get; set; }
    }
    #endregion
    #region HtmlOrderedList
    ///<summary>
    ///Represents an ordered list
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ORDEREDLIST")]
    public partial class HtmlOrderedList : HtmlElement
    {
    }
    #endregion
    #region HtmlParagraph
    ///<summary>
    ///Denotes a paragraph.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "PARAGRAPH")]
    public partial class HtmlParagraph : HtmlDiv
    {
        protected HtmlParagraph() { }
        /// <summary>
        /// Sets or retrieves the side on which floating objects are not to be positioned when any IHTMLBlockElement is inserted into the document.
        /// Possible Values:
        /// all		Object is moved below any floating object.
        /// left	Object is moved below any floating object on the left side.
        ///	right Object is moved below any floating object on the right side.
        ///	none	Floating objects are allowed on all sides.
        /// </summary>
        public JsString clear { get; set; }
    }
    #endregion
    #region HtmlPre
    ///<summary>
    ///Renders text in a fixed-width font.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "PRE")]
    public partial class HtmlPre : HtmlElement
    {
        protected HtmlPre() { }
    }
    #endregion
    #region HtmlQuoteElement
    ///<summary>
    ///The blockquote element represents a section that is quoted from another source.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlQuoteElement : HtmlElement
    {
        public JsString cite { get; set; }
    }
    #endregion
    #region HtmlScreen
    [JsType(JsMode.Prototype, Export = false, Name = "SCREEN")]
    public partial class HtmlScreen
    {
        ///<summary>
        ///Retrieves the height of the working area of the system's screen, excluding the Microsoft Windows taskbar.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber availHeight { get; set; }
        ///<summary>
        ///Retrieves the width of the working area of the system's screen, excluding the Windows taskbar.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber availWidth { get; set; }
        ///<summary>
        ///Sets or retrieves the update interval for the screen.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public JsNumber updateInterval { get; set; }
        ///<summary>
        ///Retrieves whether the user has enabled font smoothing in the Display control panel.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public JsBoolean fontSmoothingEnabled { get; set; }
        ///<summary>
        ///Sets or retrieves the number of bits per pixel used for colors in the off-screen bitmap buffer.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public JsNumber bufferDepth { get; set; }
        ///<summary>
        ///The color depth (in bits) of the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber colorDepth { get; set; }
        ///<summary>
        ///The color depth (in bits) of the screen. (Same as colorDepth)
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use colorDepth.")]
        public JsNumber pixelDepth { get; set; }
        ///<summary>
        ///The width of the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber width { get; set; }
        ///<summary>
        ///The height of the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber height { get; set; }
    }
    #endregion
    #region HtmlScriptElement
    ///<summary>
    ///Specifies a script for the page that is interpreted by a script engine.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "SCRIPTELEMENT")]
    public partial class HtmlScriptElement : HtmlElement
    {
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
    }
    #endregion
    #region HtmlSelect
    ///<summary>
    ///Denotes a list box or drop-down list.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "SELECT")]
    public partial class HtmlSelect : HtmlElement
    {
        ///<summary>
        ///Fires when the contents of the object or selection have changed.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select.")]
        public HtmlDomEventHandler onchange;
        public HtmlNodeCollection<HtmlOption> options
        {
            get { return default(HtmlNodeCollection<HtmlOption>); }
        }
        ///<summary>
        ///Sets or retrieves the Boolean value indicating whether multiple items can be selected from a list.
        ///</summary>
        public JsBoolean multiple { get; set; }
        ///<summary>
        ///Sets or retrieves the index of the selected option in a select object.
        ///</summary>
        public JsNumber selectedIndex { get; set; }
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form { get; set; }
        ///<summary>
        ///Sets or retrieves the number of objects in a collection.
        ///</summary>
        public JsNumber length { get; set; }
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name { get; set; }
        ///<summary>
        ///Sets or retrieves the number of rows in the list box.
        ///</summary>
        public JsString size { get; set; }
        ///<summary>
        ///Retrieves the type of select control based on the value of the MULTIPLE attribute.
        ///</summary>
        public JsString type { get; set; }
        ///<summary>
        ///Sets or retrieves the value which is returned to the server when the form control is submitted.
        ///</summary>
        public JsString value { get; set; }
        ///<summary>
        ///Adds an option element to the options collection of a select object.
        ///</summary>
        ///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
        ///<param name="existingOption">An existing HTMLOptionElement within the collection used as a reference point for inserting the new element; the new element being inserted before the referenced element in the collection.  If this parameter is null, the new element is appended to the end of the collection.</param>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void add(HtmlOption newOption, HtmlOption existingOption) { }
        ///<summary>
        ///Adds an option element to the options collection of a select object.
        ///</summary>
        ///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void add(HtmlOption newOption) { }
        ///<summary>
        ///Adds an option element to the options collection of a select object.
        ///</summary>
        ///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
        ///<param name="index">Integer that specifies the index position in the collection where the element is placed. If no value is given, the method places the element at the end of the collection.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void add(HtmlOption newOption, JsNumber index) { }
        ///<summary>
        ///Removes an element from the collection.
        ///</summary>
        ///<param name="iIndex">Integer that specifies the zero-based index of the element to remove from the collection.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void remove(JsNumber iIndex) { }
    }
    #endregion
    #region HtmlSpan
    ///<summary>
    ///Specifies an inline text container.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "SPAN")]
    public partial class HtmlSpan : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        protected HtmlSpan() { }
    }
    #endregion
    #region HtmlStyleElement
    ///<summary>
    ///Represents a STYLE html node
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "STYLE")]
    public partial class HtmlStyleElement : HtmlElement
    {
        protected HtmlStyleElement() { }
        ///<summary>
        ///Sets or retrieves the MIME type of the object. e.g. 'text/css'
        ///</summary>
        public JsString type { get; set; }
        ///<summary>
        ///Sets or retrieves the media type.
        ///</summary>
        ///<remarks>Possible values:
        ///screen - Output is intended for computer screens.
        ///print - Output is intended for printed material and for on-screen documents viewed in Print Preview mode.
        ///all - Default. Applies to all devices.</remarks>
        public JsString media { get; set; }
        ///<summary>
        ///Retrieves the next object in the HTML hierarchy.
        ///</summary>
        public HtmlElement owningElement { get; set; }
        ///<summary>
        ///Retrieves the style sheet that imported the current style sheets.
        ///</summary>
        public HtmlStyleElement parentStyleSheet { get; set; }
        ///<summary>
        ///Retrieves whether the rule or style sheet is defined on the page or is imported.
        ///</summary>
        public JsBoolean readOnly { get; set; }
        ///<summary>
        ///Sets or retrieves the title of the style sheet.
        ///</summary>
        public new JsString title { get; set; }
        ///<summary>
        ///Retrieves a collection of all the imported style sheets defined for the respective styleSheet object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlNodeCollection<HtmlStyleElement> imports { get; set; }
        ///<summary>
        ///Retrieves a collection of page objects, which represent @page rules in a styleSheet.
        ///</summary>
        public HtmlGenericCollection<HtmlStyleSheetPage> pages { get; set; }
        ///<summary>
        ///Retrieves a collection of rules defined in a style sheet.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9, "Use cssRules in non-IE browsers.", PartiallySupportedRemark = "IE doesn't count @imports as rules, but splits up selectors like p#test, ul into two rules.")]
        public HtmlGenericCollection<HtmlCssRule> rules { get; set; }
        ///<summary>
        ///Retrieves a collection of rules defined in a style sheet.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Use rules in IE")]
        public HtmlGenericCollection<HtmlCssRule> cssRules { get; set; }
        ///<summary>
        ///Creates a new rule for a style sheet.
        ///</summary>
        ///<param name="cSelector">String that specifies the selector for the new rule. Single contextual selectors are valid. For example, "div p b" is a valid contextual selector.</param>
        ///<param name="cStyle">String that specifies the style assignments for this style rule. This style takes the same form as an inline style specification. For example, "color:blue" is a valid style parameter.</param>
        ///<param name="iIndex">Integer that specifies the zero-based position in the rules collection where the new style rule should be placed.
        ///-1 by Default. The rule is added to the end of the collection.</param>
        ///<returns>-1 (Reserved value)</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
        public JsNumber addRule(JsString cSelector, JsString cStyle, JsNumber iIndex) { return null; }
        ///<summary>
        ///Creates a new rule for a style sheet.
        ///</summary>
        ///<param name="cSelector">String that specifies the selector for the new rule. Single contextual selectors are valid. For example, "div p b" is a valid contextual selector.</param>
        ///<param name="cStyle">String that specifies the style assignments for this style rule. This style takes the same form as an inline style specification. For example, "color:blue" is a valid style parameter.</param>
        ///<returns>-1 (Reserved value)</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
        public JsNumber addRule(JsString cSelector, JsString cStyle) { return null; }
        ///<summary>
        ///Inserts a new style rule into the current style sheet.
        ///</summary>
        ///<param name="rule">a JsString containing the rule to be inserted (selector and declaration).</param>
        ///<param name="index">a number representing the position to be inserted.</param>
        ///<returns>The index within the style sheet's rule collection of the newly inserted rule.</returns>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber insertRule(JsString rule, JsNumber index) { return null; }
        ///<summary>
        ///Used to delete a rule from the style sheet.
        ///</summary>
        ///<param name="index">The index within the style sheet's rule list of the rule to remove.</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteRule(ulong index) { }
        ///<summary>
        ///Deletes an existing style rule for the styleSheet object, and adjusts the index of the rules collection accordingly.
        ///</summary>
        ///<param name="iIndex">Integer that specifies the index value of the rule to be deleted from the style sheet.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
        public void removeRule(JsNumber iIndex) { }
        ///<summary>
        ///Deletes the first style rule for the styleSheet object, and adjusts the index of the rules collection accordingly.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57)]
        public void removeRule() { }
        ///<summary>
        ///Sets or retrieves the persisted representation of the style rule.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public JsString cssText { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates whether the user can interact with the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public new JsBoolean disabled { get; set; }
        ///<summary>
        ///The URL of the linked style sheet.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString href { get; set; }
        ///<summary>
        ///Returns the node that associates this style sheet with the document. Usually a &lt;link&gt; or a &lt;style&gt; tag.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlNode ownerNode { get; set; }
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
    }
    #endregion
    #region HtmlStyleSheetPage
    ///<summary>
    ///Represents an @page rule within a styleSheet.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "STYLESHEETPAGE")]
    public partial class HtmlStyleSheetPage
    {
        ///<summary>
        ///Retrieves a JsString that identifies the pseudo class of the page or pages an @page rule applies to.
        ///</summary>
        public JsString pseudoClass { get; set; }
        ///<summary>
        ///Retrieves a JsString that identifies which page or pages an @page rule applies to.
        ///</summary>
        public JsString selector { get; set; }
    }
    #endregion
    #region HtmlTable
    ///<summary>
    ///Specifies that the contained content is organized into a table with rows and columns.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLE")]
    public partial class HtmlTable : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves the width of the object.
        ///Possible Values:
        ///Integer			that specifies the width of the object in pixels.
        ///percentage	String that specifies an integer value followed by a %. The value is a percentage of the width of the parent object.
        ///</summary>
        public JsString width { get; set; }
        ///<summary>
        ///Sets or retrieves a description and/or structure of the object.
        ///</summary>
        public JsString summary { get; set; }
        ///<summary>
        ///Sets or retrieves which dividing lines (inner borders) are displayed.			 
        ///Possible Values:
        ///all			Borders are displayed on all rows and columns.
        ///cols		Borders are displayed between all table columns.
        ///groups	Horizontal borders are displayed between all tHead, tBody, and tFoot objects; vertical borders are displayed between all colGroup objects.
        ///none		All interior table borders are removed.
        ///rows		Horizontal borders are displayed between all table rows.
        ///</summary>
        public JsString rules { get; set; }
        ///<summary>
        ///Sets or retrieves the height of the object.
        ///Possible Values:
        ///height			Integer that specifies the height of the object, in pixels.
        ///percentage	Integer, followed by a percent sign (%). The value is a percentage of the height of the parent object.
        ///</summary>
        public JsString height { get; set; }
        ///<summary>
        ///Sets or retrieves the way the border frame around the table is displayed.
        ///</summary>
        ///<remarks>Possible values: void, above, below, hsides, vsides, lhs, rhs, box, border</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString frame { get; set; }
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        /// <summary>
        ///	Sets or retrieves the number of columns in the table.
        /// </summary>
        public JsNumber cols { get; set; }
        /// <summary>
        ///	Sets or retrieves the amount of space between cells in a table.
        ///	Possible Values:
        ///	spacing			Integer that specifies the amount of space between cells, in pixels.
        ///	percentage	Integer, followed by a %. The value is a percentage of the available amount of space between the border and the content.
        /// </summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString cellSpacing { get; set; }
        /// <summary>
        ///	Sets or retrieves the amount of space between the border of the cell and the content of the cell.
        ///	Possible Values:
        ///	Integer			that specifies the amount of space between the border and the content, in pixels.
        ///	percentage	Integer, followed by a %. The value is a percentage of the available amount of space between the border and the content.
        /// </summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"Safari 3.0 and Konqueror don't react to the setting of cellPadding, but there's a subtle difference between doing the cellPadding test and then the cellSpacing one, and doing the cellSpacing one immediately. The results might be interpreted as the cellPadding only taking effect after the cellSpacing has been set, but I'm not sure if this interpretation is correct.")]
        public JsString cellPadding { get; set; }
        /// <summary>
        ///	Retrieves the caption object of a table.
        /// </summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString caption { get; set; }
        /// <summary>
        ///	Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
        /// </summary>
        public JsString borderColorLight { get; set; }
        /// <summary>
        ///	Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
        /// </summary>
        public JsString borderColorDark { get; set; }
        /// <summary>
        ///	Deprecated. Sets or retrieves the background color behind the object.
        /// </summary>
        public JsString bgColor { get; set; }
        ///<summary>
        ///Sets or retrieves a value that indicates the table alignment.
        ///Possible Values:
        ///left		Aligns to the left edge of the available space.
        ///center	Aligns to the center of the available space, which is not necessarily the same as the browser window.
        ///right		Aligns to the right edge of the available space.
        ///</summary>
        public JsString align { get; set; }
        public JsString border { get; set; }
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlNodeCollection<HtmlTableCell> cells { get; set; }
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlNodeCollection<HtmlTableBody> tBodies { get; set; }
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlNodeCollection<HtmlTableHead> tHeads { get; set; }
        ///<summary>
        ///Creates a new row (tr) in the table, and adds the row to the rows collection.
        ///</summary>
        ///<param name="iIndex">Integer that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
        ///<returns>Returns the tr element object if successful, or null otherwise.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTableRow insertRow(JsNumber iIndex) { return null; }
        public HtmlNodeCollection<HtmlTableRow> rows { get; set; }
        ///<summary>
        ///Creates an empty caption element in the table.
        ///</summary>
        ///<returns>Returns a caption object.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlCaption createCaption() { return null; }
        ///<summary>
        ///Creates an empty tFoot element in the table.
        ///</summary>
        ///<returns>Returns the tFoot element object if successful, or null otherwise.</returns>
        ///<remarks>If a tFoot already exists for the table, the createTFoot method returns the existing element. Otherwise, it returns a pointer to the element created.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTableFoot createTFoot() { return null; }
        ///<summary>
        ///Creates an empty tHead element in the table.
        ///</summary>
        ///<returns>Returns the tHead element object if successful, or null otherwise.</returns>
        ///<remarks>If a tHead already exists, createTHead returns the existing element. Otherwise, it returns a pointer to the element created.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTableFoot createTHead() { return null; }
        ///<summary>
        ///Deletes the caption element and its contents from the table.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteCaption() { }
        ///<summary>
        ///Removes the specified row (tr) from the element and from the rows collection.
        ///</summary>
        ///<param name="iRowIndex">Integer that specifies the zero-based position in the rows collection of the row to remove.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteRow(JsNumber iRowIndex) { }
        ///<summary>
        ///Removes the last row (tr) from the element and from the rows collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteRow() { }
        ///<summary>
        ///Deletes the tFoot element and its contents from the table.
        ///</summary>
        ///<remarks>If only one tFoot element exists in the source, the deleteTFoot method deletes the table footer. If multiple tFoot elements have been defined, the next tFoot element in the source order is promoted as the table footer.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteTFoot() { }
        ///<summary>
        ///Deletes the tHead element and its contents from the table.
        ///</summary>
        ///<remarks>If only one tHead element exists in the source, the deleteTHead method deletes the table header. If multiple tHead elements have been defined, the next tHead element in the source order is promoted as the table header.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteTHead() { }
        ///<summary>
        ///Moves a table row to a new position.
        ///</summary>
        ///<param name="iSource">Integer that specifies the index in the rows collection of the table row that is moved.</param>
        ///<param name="iTarget">Integer that specifies where the row is moved within the rows collection.</param>
        ///<returns>Object. Returns a reference to the table row that is moved.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlTableRow moveRow(JsNumber iSource, JsNumber iTarget) { return null; }
        ///<summary>
        ///Retrieves the tFoot object of the table.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTableFoot tFoot { get; set; }
        ///<summary>
        ///Retrieves the tHead object of the table.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTableHead tHead { get; set; }
    }
    #endregion
    #region HtmlTableBody
    ///<summary>
    ///Designates rows as the body of the table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TBODY")]
    public partial class HtmlTableBody : HtmlElement
    {
        ///<summary>
        ///Creates a new row (tr) in the table, and adds the row to the rows collection. 
        ///</summary>
        ///<param name="rowIndex">Integer that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
        ///<returns>Returns the tr element object if successful, or null otherwise. </returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTableRow insertRow(JsNumber rowIndex) { return null; }
        ///<summary>
        ///Creates a new row (tr) in the table, and adds the row to the rows collection. 
        ///</summary>
        ///<returns>Returns the tr element object if successful, or null otherwise. </returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTableRow insertRow() { return null; }
        public HtmlNodeCollection<HtmlTableRow> rows;
        ///<summary>
        ///String that specifies or receives one of the following values.
        ///</summary>
        ///<remarks>
        ///<list type="table">
        ///<item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
        ///<item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
        ///<item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
        ///<item><term>top</term><description>Aligns the text at the top of the object.</description></item>
        ///</list>
        ///</remarks>
        public JsString vAlign { get; set; }
        ///<summary>
        ///Removes the specified row (tr) from the element and from the rows collection.
        ///</summary>
        ///<param name="iRowIndex">Integer that specifies the zero-based position in the rows collection of the row to remove.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteRow(JsNumber iRowIndex) { }
        ///<summary>
        ///Removes the last row (tr) from the element and from the rows collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteRow() { }
        ///<summary>
        ///Deletes the tFoot element and its contents from the table.
        ///</summary>
        ///<remarks>If only one tFoot element exists in the source, the deleteTFoot method deletes the table footer. If multiple tFoot elements have been defined, the next tFoot element in the source order is promoted as the table footer.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteTFoot() { }
        ///<summary>
        ///Deletes the tHead element and its contents from the table.
        ///</summary>
        ///<remarks>If only one tHead element exists in the source, the deleteTHead method deletes the table header. If multiple tHead elements have been defined, the next tHead element in the source order is promoted as the table header.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteTHead() { }
        ///<summary>
        ///Moves a table row to a new position.
        ///</summary>
        ///<param name="iSource">Integer that specifies the index in the rows collection of the table row that is moved.</param>
        ///<param name="iTarget">Integer that specifies where the row is moved within the rows collection.</param>
        ///<returns>Object. Returns a reference to the table row that is moved.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9)]
        public HtmlTableRow moveRow(JsNumber iSource, JsNumber iTarget) { return null; }
    }
    #endregion
    #region HtmlTableCaptionElement
    ///<summary>
    ///The caption element represents the title of the table that is its parent, if it has a parent and that is a table element.User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class HtmlTableCaptionElement : HtmlElement
    {
        public JsString align { get; set; }
    }
    #endregion
    #region HtmlTableCell
    ///<summary>
    ///Specifies a cell in a table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TD")]
    public partial class HtmlTableCell : HtmlElement
    {
        protected HtmlTableCell() { }
        ///<summary>
        ///Sets or retrieves abbreviated text for the object.
        ///</summary>
        public JsString abbr { get; set; }
        ///<summary>
        ///Sets or retrieves a comma-delimited list of conceptual categories associated with the object.
        ///</summary>
        public JsString axis { get; set; }
        ///<summary>
        ///Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
        ///</summary>
        public JsString borderColorDark { get; set; }
        ///<summary>
        ///Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
        ///</summary>
        public JsString borderColorLight { get; set; }
        ///<summary>
        ///Sets or retrieves a value that you can use to implement your own ch functionality for the object.
        ///</summary>
        public JsString ch { get; set; }
        ///<summary>
        ///Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
        ///</summary>
        public JsString chOff { get; set; }
        ///<summary>
        ///Sets or retrieves the number columns in the table that the object should span.
        ///</summary>
        public JsNumber colSpan { get; set; }
        ///<summary>
        ///Sets or retrieves a list of header cells that provide information for the object.
        ///</summary>
        public JsString headers { get; set; }
        ///<summary>
        ///Sets or retrieves how many rows in a table the cell should span.
        ///</summary>
        public JsNumber rowSpan { get; set; }
        ///<summary>
        ///Sets or retrieves the group of cells in a table to which the object's information applies.
        ///Possible Values:
        ///row				The current cell provides header information for its row.
        ///col				The current cell provides header information for its column.
        ///rowgroup	The header cell provides header information for its row.
        ///colgroup	The header cell provides header information for its column.
        ///</summary>
        public JsString scope { get; set; }
        ///<summary>
        ///Sets or retrieves the width of the object.
        ///Possible Values:
        ///Integer			that specifies the width of the object in pixels.
        ///percentage	String that specifies an integer value followed by a %. The value is a percentage of the width of the parent object.
        ///</summary>
        public JsString width { get; set; }
        /// <summary>
        /// Sets or retrieves the alignment of the object relative to the display or table.
        /// Possible Values:
        /// center	Aligns to the center.
        /// justify	Aligns to the left and right edge.
        ///	left		Default. Aligns to the left edge.
        ///	right		Aligns to the right edge.
        /// </summary>
        public JsString align;
        ///<summary>
        ///Sets whether the browser automatically performs wordwrap.
        ///</summary>
        public JsBoolean noWrap { get; set; }
        ///<summary>
        ///Retrieves the position of the object in the cells collection of a row. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber cellIndex { get; set; }
        ///<summary>
        ///Deprecated. Sets or retrieves the background color behind the object.
        ///</summary>
        public JsString bgColor { get; set; }
        ///<summary>
        ///Sets the height of the object.
        ///</summary>
        public JsString height { get; set; }
        ///<summary>
        ///String that specifies or receives one of the following values.
        ///</summary>
        ///<remarks>
        ///<list type="table">
        ///<item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
        ///<item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
        ///<item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
        ///<item><term>top</term><description>Aligns the text at the top of the object.</description></item>
        ///</list>
        ///</remarks>
        public JsString vAlign { get; set; }
    }
    #endregion
    #region HtmlTableCol
    ///<summary>
    ///Specifies column-based defaults for the table properties.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "COL")]
    public partial class HtmlTableCol : HtmlElement
    {
        protected HtmlTableCol() { }
        ///<summary>
        ///Sets or retrieves the width of the object.
        ///</summary>
        public JsString width { get; set; }
        ///<summary>
        ///Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
        ///</summary>
        public JsString chOff { get; set; }
        ///<summary>
        ///Sets or retrieves how text and other content are vertically aligned within the object that contains them.
        ///</summary>
        ///<remarks>
        ///<list type="table">
        ///<item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
        ///<item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
        ///<item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
        ///<item><term>top</term><description>Aligns the text at the top of the object.</description></item>
        ///</list>
        ///</remarks>
        public JsString valign { get; set; }
        ///<summary>
        ///Sets or retrieves the number of columns in the group. 
        ///</summary>
        ///<remarks>
        ///Integer that specifies or receives the number of spanned columns. The default value is 1.
        ///</remarks>
        public JsNumber span { get; set; }
        ///<summary>
        ///Sets or retrieves a value that you can use to implement your own ch functionality for the object.
        ///</summary>
        public JsString ch { get; set; }
        /// <summary>
        /// Sets or retrieves the alignment of the object relative to the display or table.
        /// Possible Values:
        /// center	Aligns to the center.
        /// justify	Aligns to the left and right edge.
        ///	left		Default. Aligns to the left edge.
        ///	right		Aligns to the right edge.
        /// </summary>
        public JsString align { get; set; }
        public JsString vAlign { get; set; }
    }
    #endregion
    #region HtmlTableColGroup
    ///<summary>
    ///Specifies property defaults for a column or group of columns in a table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "COLGROUP")]
    public partial class HtmlTableColGroup : HtmlElement
    {
        protected HtmlTableColGroup() { }
        ///<summary>
        ///String that specifies or receives one of the following values.
        ///</summary>
        ///<remarks>
        ///<list type="table">
        ///<item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
        ///<item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
        ///<item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
        ///<item><term>top</term><description>Aligns the text at the top of the object.</description></item>
        ///</list>
        ///</remarks>
        public JsString vAlign { get; set; }
    }
    #endregion
    #region HtmlTableFoot
    ///<summary>
    ///Designates rows as the table's footer.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TFOOT")]
    public partial class HtmlTableFoot : HtmlTableBody
    {
        protected HtmlTableFoot() { }
    }
    #endregion
    #region HtmlTableHead
    ///<summary>
    ///Designates rows as the table's header.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "THEAD")]
    public partial class HtmlTableHead : HtmlTableBody
    {
        protected HtmlTableHead() { }
    }
    #endregion
    #region HtmlTableHeadCell
    ///<summary>
    ///Sets how text and other content are vertically aligned within the object that contains them.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TH")]
    public partial class HtmlTableHeadCell : HtmlTableCell
    {
        protected HtmlTableHeadCell() { }
    }
    #endregion
    #region HtmlTableRow
    ///<summary>
    ///Specifies a row in a table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TR")]
    public partial class HtmlTableRow : HtmlElement
    {
        protected HtmlTableRow() { }
        public HtmlNodeCollection<HtmlTableCell> cells { get; set; }
        ///<summary>
        ///Creates a new cell in the table row (tr), and adds the cell to the cells collection. 
        ///</summary>
        ///<param name="index">Integer that specifies where to insert the cell in the tr. The default value is -1, which appends the new cell to the end of the cells collection.</param>
        ///<returns>Returns the td element object if successful, or null otherwise.</returns>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlTableCell insertCell(JsNumber index) { return null; }
        /////<summary>
        /////Creates a new cell in the table row (tr), and adds the cell to the cells collection. 
        /////</summary>
        /////<returns>Returns the td element object if successful, or null otherwise.</returns>
        //[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        //public HtmlTableCell insertCell() { return null; }
        ///<summary>
        ///String that specifies or receives one of the following values.
        ///</summary>
        ///<remarks>
        ///<list type="table">
        ///<item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
        ///<item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
        ///<item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
        ///<item><term>top</term><description>Aligns the text at the top of the object.</description></item>
        ///</list>
        ///</remarks>
        public JsString vAlign { get; set; }
        ///<summary>
        ///Removes the specified cell (td) from the table row, as well as from the cells collection.
        ///</summary>
        ///<param name="iIndex">Integer that specifies the zero-based position of the cell to remove from the table row. If no value is provided, the last cell in the cells collection is deleted.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteCell(JsNumber iIndex) { }
        ///<summary>
        ///Removes the last cell (td) from the table row, as well as from the cells collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteCell() { }
        ///<summary>
        ///Retrieves the position of the object in the rows collection for the table.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"Opera keeps to the source code order (where the <tfoot> precedes the <tbody>.)")]
        public JsNumber rowIndex { get; set; }
        ///<summary>
        ///Retrieves the position of the object in the tBody, tHead, tFoot, or rows collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber sectionRowIndex { get; set; }
    }
    #endregion
    #region HtmlTextArea
    [JsType(JsMode.Prototype, Export = false, Name = "TEXTAREA")]
    public partial class HtmlTextArea : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves the number of horizontal rows contained in the object.
        ///</summary>
        public JsNumber rows { get; set; }
        ///<summary>
        ///Sets or retrieves the width of the object.
        ///</summary>
        public JsNumber cols { get; set; }
        /// <summary>
        /// Sets or retrieves how to handle wordwrapping in the object. 
        /// Possible values:
        ///	soft	Default. Text is displayed with wordwrapping and submitted without carriage returns and line feeds. 
        /// hard	Text is displayed with wordwrapping and submitted with soft returns and line feeds. 
        /// off		Wordwrapping is disabled. The lines appear exactly as the user types them. 
        /// </summary>
        public JsString wrap { get; set; }
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld { get; set; }
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc { get; set; }
        ///<summary>
        ///Sets or retrieves a comma-separated list of content types.
        ///</summary>
        public JsString accept { get; set; }
        ///<summary>
        ///Sets or retrieves how the object is aligned with adjacent text.
        ///</summary>
        public JsString align { get; set; }
        ///<summary>
        ///Sets or retrieves a text alternative to the graphic.
        ///</summary>
        public JsString alt { get; set; }
        ///<summary>
        ///Sets or retrieves the state of the check box or radio button.
        ///</summary>
        public JsBoolean @checked { get; set; }
        ///<summary>
        ///Retrieves whether the object is fully loaded.
        ///</summary>
        public JsString complete { get; set; }
        ///<summary>
        ///Sets or retrieves the initial contents of the object.
        ///</summary>
        public JsString defaultValue { get; set; }
        ///<summary>
        ///Sets or retrieves the state of the check box or radio button.
        ///</summary>
        public JsString defaultChecked { get; set; }
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form { get; set; }
        ///<summary>
        ///Sets or retrieves a lower resolution image to display.
        ///</summary>
        public JsString lowsrc { get; set; }
        ///<summary>
        ///Sets or retrieves the number of times a sound or video clip will loop when activated.
        ///</summary>
        public JsString loop { get; set; }
        ///<summary>
        ///Sets or retrieves the horizontal margin for the object.
        ///</summary>
        public JsString hspace { get; set; }
        ///<summary>
        ///Sets or retrieves the vertical margin for the object.
        ///</summary>
        public JsString vspace { get; set; }
        ///<summary>
        ///Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
        ///</summary>
        public JsString useMap { get; set; }
        ///<summary>
        ///Sets or retrieves the value indicated whether the content of the object is read-only.
        ///</summary>
        public JsString readOnly { get; set; }
        ///<summary>
        ///Sets or retrieves the size of the control.
        ///</summary>
        public JsString size { get; set; }
        ///<summary>
        ///Sets or retrieves a URL to be loaded by the object.
        ///</summary>
        public JsString src { get; set; }
        ///<summary>
        ///Sets or retrieves when a video clip file should begin playing.
        ///</summary>
        public JsString start { get; set; }
        ///<summary>
        ///Sets or retrieves the calculated width of the object.
        ///</summary>
        public JsString width { get; set; }
        /// <summary>
        /// Sets or retrieves the value indicating whether the control is selected.
        /// Possible values:
        ///	false	Default. Control is not selected.
        /// true	Control is selected.
        /// null	Control is not initialized.
        /// </summary>
        public JsBoolean status { get; set; }
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name { get; set; }
        ///<summary>
        ///Retrieves the file name of the input object after the text is set by user input.
        ///</summary>
        public JsString value { get; set; }
        ///<summary>
        ///Retrieves or initially sets the type of input control represented by the object.
        ///</summary>
        public JsString type { get; set; }
        ///<summary>
        ///Highlights the input area of a form element.
        ///</summary>
        public void select() { }
        ///<summary>
        ///Creates a TextRange object for the element.
        ///Use a text range to examine and modify the text within an object.
        ///</summary>
        ///<returns>Returns a TextRange object if successful, or null otherwise.</returns>
        public HtmlTextRange createTextRange() { return null; }
        ///<summary>
        ///Sets or retrieves the maximum number of characters that the user can enter in a text control. 
        ///</summary>
        public JsNumber maxLength { get; set; }
        ///<summary>
        ///Fires when the contents of the object or selection have changed.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = "IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select.")]
        public HtmlDomEventHandler onchange;
        ///<summary>
        ///Fires when the current selection changes.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public HtmlDomEventHandler onselect;
    }
    #endregion
    #region HtmlTextNode
    ///<summary>
    ///Represents a JsString of text as a node in the document hierarchy.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TEXTNODE")]
    public partial class HtmlTextNode : HtmlNode
    {
        ///<summary>
        ///Retrieves a reference to the first child in the childNodes collection of the object
        ///</summary>
        public JsString firstChild { get; set; }
        ///<summary>
        ///Retrieves a reference to the last child in the childNodes collection of an object.
        ///</summary>
        public JsString lastChild { get; set; }
        ///<summary>
        ///Gets the number of characters in a TextNode object.
        ///</summary>
        public JsNumber length { get; set; }
        ///<summary>
        ///Divides a text node at the specified index. 
        ///</summary>
        ///<param name="index">A Integer that specifies the index of the JsString that indicates where the separation occurs. If a value is not provided, a new text node with no value is created.</param>
        ///<returns>This function returns the node containing the text after the offset.
        ///The text before the offset remains in the original text node.</returns>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, "IE handles the first splitText() fine, but after you’ve normalized the text IE doesn’t split it any more.")]
        public HtmlTextNode splitText(JsNumber index) { return null; }
        ///<summary>
        ///Divides a text node at the specified index. 
        ///</summary>
        ///<returns>This function returns the node containing the text after the offset.
        ///The text before the offset remains in the original text node.</returns>
        public HtmlTextNode splitText() { return null; }
        ///<summary>
        ///Sets or gets the value of a TextNode object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsString data { get; set; }
        protected HtmlTextNode() { }
        ///<summary>
        ///Adds a new character JsString to the end of the object.
        ///</summary>
        ///<param name="sString"></param>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, "IE8 appends the text, but doesn’t show it until you click the element.")]
        public void appendData(JsString sString) { }
        ///<summary>
        ///Removes a specified range of characters from the object.
        ///</summary>
        ///<param name="nOffset">Integer that specifies the offset from which to start.</param>
        ///<param name="nCount">Integer that specifies the number of characters to remove.</param>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void deleteData(JsNumber nOffset, JsNumber nCount) { }
        ///<summary>
        ///Inserts a new character JsString in the object at a specified offset.
        ///</summary>
        ///<param name="nOffset">Integer that specifies the offset from which to start.</param>
        ///<param name="sString">String that specifies the new character JsString.</param>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void insertData(JsNumber nOffset, JsString sString) { }
        ///<summary>
        ///Replaces a specified range of characters in the object with a new character JsString.
        ///</summary>
        ///<param name="nOffset">Integer that specifies the offset from which to start.</param>
        ///<param name="nCount">Integer that specifies the number of characters to replace.</param>
        ///<param name="sString">String that specifies the new character JsString.</param>
        ///<remarks>
        ///f the sum of the nOffset and nCount parameters exceeds the number of characters in the object, then all the characters to the end of the data are replaced.
        ///</remarks>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void replaceData(JsNumber nOffset, JsNumber nCount, JsString sString) { }
        ///<summary>
        ///Extracts a range of characters from the object.
        ///</summary>
        ///<param name="nOffset">Integer that specifies the offset from which to start.</param>
        ///<param name="nCount">Integer that specifies the number of characters to extract.</param>
        [SupportedBrowsers(BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void substringData(JsNumber nOffset, JsNumber nCount) { }
        ///<summary>
        ///This read-only property is useful if you want to get the entire text at a certain point and don’t want to be bothered by borders between text nodes.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10)]
        public JsString wholeText { get; set; }
    }
    #endregion
    #region HtmlSelection
    ///<summary>
    ///Represents the active selection, which is a highlighted block of text or other elements in the document that a user or a script can carry out some action on.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "SELECTION")]
    public partial class HtmlSelection
    {
        ///<summary>
        ///Creates a TextRange object from the current text selection, or a controlRange collection from a control selection. 
        ///</summary>
        ///<returns>Returns the created TextRange object.</returns>
        public HtmlTextRange createRange() { return null; }
        ///<summary>
        ///Clears the contents of the selection. 
        ///</summary>
        public void clear() { }
    }
    #endregion
    #region HtmlTextRange
    ///<summary>
    ///Represents text in an HTML element. 
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TEXTRANGE")]
    public partial class HtmlTextRange
    {
        ///<summary>
        ///Searches for text in the document and positions the start and end points of the range to encompass the search JsString.
        ///</summary>
        ///<param name="text">String that specifies the text to find.</param>
        ///<returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
        public JsBoolean findText(JsString text) { return null; }
        ///<summary>
        ///Searches for text in the document and positions the start and end points of the range to encompass the search JsString.
        ///</summary>
        ///<param name="text">String that specifies the text to find.</param>
        ///<param name="searchScope">Integer that specifies the number of characters to search from the starting point of the range. A positive integer indicates a forward search; a negative integer indicates a backward search. </param>
        ///<returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
        public JsBoolean findText(JsString text, JsNumber searchScope) { return null; }
        ///<summary>
        ///Searches for text in the document and positions the start and end points of the range to encompass the search JsString.
        ///</summary>
        ///<param name="text">String that specifies the text to find.</param>
        ///<param name="searchScope">Integer that specifies the number of characters to search from the starting point of the range. A positive integer indicates a forward search; a negative integer indicates a backward search. </param>
        ///<param name="flags">Integer that specifies one or more of the following flags to indicate the type of search: 0 Default. Match partial words. 
        ///1 Match backwards. 
        ///2 Match whole words only. 
        ///4 Match case. 
        ///131072 Match bytes. 
        ///536870912 Match diacritical marks. 
        ///1073741824 Match Kashida character. 
        ///2147483648 Match AlefHamza character. 
        ///</param>
        ///<returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
        public JsBoolean findText(JsString text, JsNumber searchScope, JsNumber flags) { return null; }
        ///<summary>
        ///Retrieves the parent element for the given text range.
        ///</summary>
        ///<returns>Returns the parent element object if successful, or null otherwise.</returns>
        public HtmlElement parentElement() { return null; }
        ///<summary>
        ///Retrieves the distance between the left edge of the rectangle that bounds the TextRange object and the left side of the object that contains the TextRange.
        ///</summary>
        public JsNumber boundingLeft
        {
            get;
            private set;
        }
        ///<summary>
        ///Retrieves the width of the rectangle that bounds the TextRange object. 
        ///</summary>
        public JsNumber boundingWidth
        {
            get;
            private set;
        }
        ///<summary>
        ///Retrieves the distance between the top edge of the rectangle that bounds the TextRange object and the top side of the object that contains the TextRange. 
        ///</summary>
        public JsNumber boundingTop
        {
            get;
            private set;
        }
        ///<summary>
        ///Retrieves the height of the rectangle that bounds the TextRange object. 
        ///</summary>
        public JsNumber boundingHeight
        {
            get;
            private set;
        }
        ///<summary>
        ///Retrieves the calculated top position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        public JsNumber offsetTop
        {
            get;
            private set;
        }
        ///<summary>
        ///Retrieves the calculated left position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        public JsNumber offsetLeft
        {
            get;
            private set;
        }
        ///<summary>
        ///Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
        ///</summary>
        public JsNumber scrollTop
        {
            get;
            private set;
        }
        ///<summary>
        ///Makes the selection equal to the current object. 
        ///</summary>
        public void select() { }
        ///<summary>
        ///Moves the text range so that the start and end positions of the range encompass the text in the given element.
        ///</summary>
        ///<param name="p"></param>
        public void moveToElementText(HtmlElement p) { }
        /// <summary>
        /// Causes the object to scroll into view, aligning it either at the top or bottom of the window.
        /// </summary>
        /// <param name="bAlignToTop">Boolean that specifies one of the following values:
        ///														true - Default. Scrolls the object so that top of the object is visible at the top of the window.
        ///														false - Scrolls the object so that the bottom of the object is visible at the bottom of the window</param>
        public void scrollIntoView(JsBoolean bAlignToTop) { }
        ///<summary>
        ///Sets or retrieves the text contained within the range. 
        ///</summary>
        public JsString text { get; set; }
        ///<summary>
        ///Retrieves the HTML source as a valid HTML fragment. 
        ///</summary>
        public JsString htmlText
        {
            get;
            private set;
        }
        ///<summary>
        ///Collapses the given text range and moves the empty range by the given number of units
        ///</summary>
        ///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit.</param>
        ///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
        public JsNumber move(JsString sUnit, JsNumber iCount) { return null; }
        ///<summary>
        ///Returns a duplicate of the TextRange.
        ///</summary>
        ///<returns>Returns a TextRange object.</returns>
        public HtmlTextRange duplicate() { return null; }
        ///<summary>
        ///Sets the endpoint of one range based on the endpoint of another range.
        ///</summary>
        ///<param name="sType">Required. String that specifies the endpoint to transfer using one of the following values: startToEnd, startToStart, endToStart, endToEnd</param>
        ///<param name="oTextRange">Required. TextRange object from which the source endpoint is to be taken.</param>
        public void setEndPoint(JsString sType, HtmlTextRange oTextRange) { }
        ///<summary>
        ///Pastes HTML text into the given text range, replacing any previous text and HTML elements in the range.
        ///</summary>
        ///<param name="sHTMLText">Required. String that specifies the HTML text to paste. The JsString can contain text and any combination of the HTML tags described in HTML Elements.</param>
        public void pasteHTML(JsString sHTMLText) { }
        ///<summary>
        ///Moves the start and end positions of the text range to the given point.
        ///</summary>
        ///<param name="x">Required. Integer that specifies the horizontal offset relative to the upper-left corner of the window, in pixels.</param>
        ///<param name="y">Required. Integer that specifies the vertical offset relative to the upper-left corner of the window, in pixels.</param>
        public void moveToPoint(JsNumber x, JsNumber y) { }
        ///<summary>
        ///Returns a value indicating whether the specified range is equal to the current range.
        ///</summary>
        ///<param name="oCompareRange">Required. TextRange object to compare with the current TextRange object. </param>
        ///<returns>Boolean that returns true if oCompareRange is equal to the parent object, otherwise false.</returns>
        public JsBoolean isEqual(HtmlTextRange oCompareRange) { return null; }
        ///<summary>
        ///Changes the start position of the range.
        ///</summary>
        ///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit</param>
        ///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
        ///<returns></returns>
        public JsNumber moveEnd(JsString sUnit, JsNumber iCount) { return null; }
        ///<summary>
        ///Changes the end position of the range.
        ///</summary>
        ///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit</param>
        ///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
        ///<returns></returns>
        public JsNumber moveStart(JsString sUnit, JsNumber iCount) { return null; }
        /// <summary>
        /// Moves the insertion point to the beginning or end of the current range. 
        /// </summary>
        /// <param name="bStart">Optional. Boolean that specifies one of the following values: 
        /// <list type="table">
        /// <item>
        ///		<term>true</term>
        ///		<description>Default. Moves the insertion point to the beginning of the text range.</description>
        /// </item>
        /// <item>
        ///		<term>false</term>
        ///		<description>Moves the insertion point to the end of the text range.</description>
        /// </item>
        /// </list>
        /// </param>
        public void collapse(JsBoolean bStart) { }
        ///<summary>
        ///Moves the insertion point to the beginning or end of the current range. 
        ///</summary>
        public void collapse() { }
        ///<summary>
        ///Returns a value indicating whether one range is contained within another.
        ///</summary>
        ///<param name="range2">TextRange object that might be contained</param>
        ///<returns>Boolean that returns one of the following possible values.
        ///true oRange is contained within or is equal to the TextRange object on which the method is called. 
        ///false oRange is not contained within the TextRange object on which the method is called. 
        ///</returns>
        public JsBoolean inRange(HtmlTextRange range2) { return null; }
        ///<summary>
        ///Compares an end point of a TextRange object with an end point of another range. 
        ///</summary>
        ///<param name="type">String that specifies one of the following values: 
        ///StartToEnd Compare the start of the TextRange object with the end of the oRange parameter. 
        ///StartToStart Compare the start of the TextRange object with the start of the oRange parameter. 
        ///EndToStart Compare the end of the TextRange object with the start of the oRange parameter. 
        ///EndToEnd Compare the end of the TextRange object with the end of the oRange parameter 
        ///</param>
        ///<param name="range">TextRange object that specifies the range to compare with the object</param>
        ///<returns>Returns one of the following possible values:
        ///-1 The end point of the object is further to the left than the end point of oRange. 
        ///0 The end point of the object is at the same location as the end point of oRange. 
        ///1 The end point of the object is further to the right than the end point of oRange.</returns>
        public JsNumber compareEndPoints(JsString type, HtmlTextRange range) { return null; }
        ///<summary>
        ///Retrieves a bookmark (opaque JsString) that can be used with moveToBookmark to return to the same range. 
        ///</summary>
        ///<returns>String. Returns the bookmark if successfully retrieved, or null otherwise. </returns>
        public JsString getBookmark() { return null; }
        ///<summary>
        ///Moves to a bookmark.
        ///</summary>
        ///<param name="bookmark">String that specifies the bookmark to move to. </param>
        ///<returns>Boolean that returns one of the following possible values:
        ///true Successfully moved to the bookmark. 
        ///false Move to the bookmark failed. </returns>
        public JsBoolean moveToBookmark(JsString bookmark) { return null; }
    }
    #endregion
    #region HtmlTextRectangle
    ///<summary>
    ///Represents a rectangle, as returned by the <see cref="M:SharpKit.HtmlModel.HtmlElement.getClientRects"/> method.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TEXTRECTANGLE")]
    public partial class HtmlTextRectangle
    {
        public JsNumber top;
        public JsNumber left;
        public JsNumber bottom;
        public JsNumber right;
    }
    #endregion
    #region HtmlTitle
    ///<summary>
    ///Represents the TITLE element of a HTML document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TITLE")]
    public partial class HtmlTitle : HtmlElement
    {
        protected HtmlTitle() { }
    }
    #endregion
    #region HtmlUnorderedList
    ///<summary>
    ///Represents an unordered list
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "UNORDEREDLIST")]
    public partial class HtmlUnorderedList : HtmlElement
    {
    }
    #endregion
    #region HtmlWindow
    [JsType(JsMode.Prototype, Export = false)]
    public partial class HtmlWindow
    {
        public HtmlWindowNavigator navigator { get; private set; }
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8 | BrowserTypes.IE8AsIE7, "Use event handler's argument")]
        public HtmlDomEventArgs @event { get; set; }
        public void resizeBy(JsNumber x, JsNumber y) { }
        ///<summary>
        ///Causes the element to lose focus and fires the onblur event.
        ///</summary>
        public void blur() { }
        ///<summary>
        ///Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
        ///</summary>
        public JsNumber scrollTop;
        ///<summary>
        ///Retrieves the x-coordinate of the upper left-hand corner of the browser's client area, relative to the upper left-hand corner of the screen. 
        ///</summary>
        public JsNumber screenLeft
        {
            get;
            private set;
        }
        ///<summary>
        ///Retrieves the y-coordinate of the top corner of the browser's client area, relative to the top corner of the screen.
        ///</summary>
        public JsNumber screenTop
        {
            get;
            private set;
        }
        ///<summary>
        ///Retrieves the frame or iframe object that is hosting the window in the parent document.
        ///</summary>
        public HtmlIFrame frameElement;
        ///<summary>
        ///Retrieves the HtmlDocument object that is contained in this window object.
        ///</summary>
        public HtmlDocument document;
        ///<summary>
        ///Sets or retrieves a reference to the window that created the current window. 
        ///</summary>
        public HtmlWindow opener;
        ///<summary>
        ///Retrieves the topmost ancestor window.
        ///</summary>
        public HtmlWindow top;
        ///<summary>
        ///Retrieves the parent of the window in the object hierarchy. 
        ///</summary>
        public HtmlWindow parent;
        ///<summary>
        ///Displays a dialog box that prompts the user with a message and an input field.
        ///</summary>
        ///<param name="message">Optional. String that specifies the message to display in the dialog box. By default, this parameter is set to "".</param>
        ///<param name="defaultValue">Optional. String that specifies the default value of the input field. By default, this parameter is set to "undefined".</param>
        ///<returns>String or Integer. Returns the value typed in by the user.</returns>
        public JsString prompt(JsString message, JsString defaultValue) { return null; }
        ///<summary>
        ///Displays a dialog box that prompts the user with a message and an input field.
        ///</summary>
        ///<param name="message">Optional. String that specifies the message to display in the dialog box. By default, this parameter is set to "".</param>
        ///<returns>String or Integer. Returns the value typed in by the user.</returns>
        public JsString prompt(JsString message) { return null; }
        ///<summary>
        ///Displays a dialog box that prompts the user with a message and an input field.
        ///</summary>
        ///<returns>String or Integer. Returns the value typed in by the user.</returns>
        public JsString prompt() { return null; }
        ///<summary>
        ///Invokes a method after a specified number of milliseconds has elapsed. 
        ///</summary>
        ///<param name="action">a JsFunction to invoke</param>
        ///<param name="ms">Delay, in milliseconds, before invoking the method</param>
        ///<returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setTimeout(JsAction action, JsNumber ms) { return null; }
        ///<summary>
        ///Invokes a method after a specified number of milliseconds has elapsed. 
        ///</summary>
        ///<param name="code">a JsFunction to invoke</param>
        ///<param name="ms">Delay, in milliseconds, before invoking the method</param>
        ///<returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setTimeout(JsString code, JsNumber ms) { return null; }
        ///<summary>
        ///Cancels a time-out that was set with the setTimeout method. 
        ///</summary>
        ///<param name="id">Required. Integer that specifies the time-out setting returned by a previous call to the setTimeout method.</param>
        public void clearTimeout(JsNumber id) { }
        ///<summary>
        ///Opens a new window and loads the document specified by a given URL.
        ///</summary>
        ///<returns></returns>
        public HtmlWindow open() { return null; }
        ///<summary>
        ///Opens a new window and loads the document specified by a given URL.
        ///</summary>
        ///<param name="sURL">
        ///String that specifies the URL of the document to display. 
        ///If no URL is specified, a new window with about:blank is displayed.
        ///</param>
        ///<returns></returns>
        public HtmlWindow open(JsString sURL) { return null; }
        ///<summary>
        ///Opens a new window and loads the document specified by a given URL.
        ///</summary>
        ///<param name="sURL">
        ///String that specifies the URL of the document to display. 
        ///If no URL is specified, a new window with about:blank is displayed.
        ///</param>
        ///<param name="sName">
        ///Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
        ///</param>
        ///<returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
        public HtmlWindow open(JsString sURL, JsString sName) { return null; }
        ///<summary>
        ///Opens a new window and loads the document specified by a given URL.
        ///</summary>
        ///<param name="sURL">
        ///String that specifies the URL of the document to display. 
        ///If no URL is specified, a new window with about:blank is displayed.
        ///</param>
        ///<param name="sName">
        ///Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
        ///</param>
        ///<param name="sFeatures">
        ///Optional. String that contains a list of items separated by commas. Each item consists of an option and a value, separated by an equals sign (for example, "fullscreen=yes, toolbar=yes"). 
        ///</param>
        ///<returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
        public HtmlWindow open(JsString sURL, JsString sName, JsString sFeatures) { return null; }
        ///<summary>
        ///Opens a new window and loads the document specified by a given URL.
        ///</summary>
        ///<param name="sURL">
        ///String that specifies the URL of the document to display. 
        ///If no URL is specified, a new window with about:blank is displayed.
        ///</param>
        ///<param name="sName">
        ///Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
        ///</param>
        ///<param name="sFeatures">
        ///Optional. String that contains a list of items separated by commas. Each item consists of an option and a value, separated by an equals sign (for example, "fullscreen=yes, toolbar=yes"). 
        ///channelmode = { yes | no | 1 | 0 }Specifies whether to display the window in theater mode. The default is no. Internet Explorer 7. channelmode = { yes | 1 } overrides height, width, top, and left values. When active, the Navigation Bar is hidden and the Title Bar is visible. The Channel Band is no longer supported in Internet Explorer 7. Prior to Internet Explorer 7 channelmode = { yes | 1 } displays the Channel Band in theatre mode. 
        ///directories = { yes | no | 1 | 0 }Specifies whether to add directory buttons. The default is yes. Internet Explorer 7. This feature is no longer supported. 
        ///fullscreen = { yes | no | 1 | 0 }Specifies whether to display the browser in full-screen mode. The default is no. Use full-screen mode carefully. Because this mode hides the browser's title bar and menus, you should always provide a button or other visual clue to help the user close the window. ALT+F4 closes the new window. Internet Explorer 7. A window in full-screen mode does not need to be in theatre mode. Prior to Internet Explorer 7 a window in full-screen mode must also be in theater mode (channelmode).
        ///height = numberInternet Explorer 7. Sets the height of the window in pixels. The minimum value is 150, and specifies the minimum height of the browser content area. Prior to Internet Explorer 7 the minimum height value is 100. 
        ///left = numberSpecifies the left position, in pixels. This value is relative to the upper-left corner of the screen. The value must be greater than or equal to 0. 
        ///location = { yes | no | 1 | 0 }Internet Explorer 7. Specifies whether to display the navigation bar. The default is yes. Prior to Internet Explorer 7 this feature specifies whether to display the address bar. The Back, Forward, and Stop commands are now located in the Navigation bar. Prior to Internet Explorer 7 navigation commands were located in the toolbar.
        ///menubar = { yes | no | 1 | 0 } Specifies whether to display the menu bar. The default is yes. Internet Explorer 7. By default the menu bar is hidden unless revealed by the ALT key. menubar = { no | 0 } prohibits the menubar from appearing even when the Alt key is pressed. The combination of menubar = { no | 0 } and toolbar = { no | 0 } hides the toolbar and disables any additional third-party user interfaces. 
        ///resizable = { yes | no | 1 | 0 }Specifies whether to display resize handles at the corners of the window. The default is yes. Internet Explorer 7. resizable = { no | 0 } disables tabs in a new window.
        ///scrollbars = { yes | no | 1 | 0 }Specifies whether to display horizontal and vertical scroll bars. The default is yes.
        ///status = { yes | no | 1 | 0 }Specifies whether to add a Status Bar at the bottom of the window. The default is yes.
        ///titlebar = { yes | no | 1 | 0 }Specifies whether to display a Title Bar for the window. The default is yes. Internet Explorer 5.5 and later. This feature is no longer supported. The Title Bar remains visible unless the fullscreen sFeature is active. This parameter is ignored prior to Internet Explorer 5.5. It applies only if the calling application is an HTML Application or a trusted dialog box. 
        ///toolbar = { yes | no | 1 | 0 }Internet Explorer 7. Specifies whether to display the browser command bar, making buttons such as Favorites Center, Add to Favorites, and Tools available. The default is yes. The combination of menubar = { no | 0 } and toolbar = { no | 0 } turn off the Toolbar and any additional third-party user interfaces. Prior to Internet Explorer 7 the toolbar sFeature specifies whether to display the browser toolbar, making buttons such as Back, Forward, and Stop available. 
        ///top = numberSpecifies the top position, in pixels. This value is relative to the upper-left corner of the screen. The value must be greater than or equal to 0. 
        ///width = numberInternet Explorer 7. Sets the width of the window in pixels. The minimum value is 250, and specifies the minimum width of the browsers content area. Prior to Internet Explorer 7 the minimum height value is 100. 
        ///</param>
        ///<param name="bReplace">
        ///Optional. Boolean that specifies whether the sURL creates a new entry or replaces the current entry in the window's history list. This parameter only takes effect if the sURL is loaded into the same window. 
        ///</param>
        ///<returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
        public HtmlWindow open(JsString sURL, JsString sName, JsString sFeatures, JsBoolean bReplace) { return null; }
        ///<summary>
        ///Retrieves whether the referenced window is closed.
        ///</summary>
        public JsBoolean closed;
        ///<summary>
        ///Closes the current browser window.
        ///</summary>
        public void close() { }
        ///<summary>
        ///Contains information about the current URL. 
        ///</summary>
        public HtmlWindowLocation location;
        ///<summary>
        ///Displays a dialog box containing an application-defined message. 
        ///</summary>
        ///<param name="message">Optional. String that specifies the message to display in the dialog box.</param>
        ///<remarks>You cannot change the title bar of the Alert dialog box.</remarks>
        public void alert(object message) { }
        /// <summary>
        /// Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.
        /// </summary>
        /// <param name="message">Optional. String that specifies the message to display in the confirmation dialog box. If no value is provided, the dialog box does not contain a message.</param>
        /// <returns>Boolean. Returns one of the following possible values:
        ///	<list type="table">
        ///	<item>
        ///		<term>true</term>
        ///		<description>The user clicked the OK button.</description>
        ///	</item>
        ///	<item>
        ///		<term>false</term>
        ///		<description>The user clicked Cancel button.</description>
        /// </item>
        /// </list>
        /// </returns>
        public JsBoolean confirm(JsString message) { return null; }
        ///<summary>
        ///Provides access to predefined clipboard formats for use in editing operations.
        ///</summary>
        public HtmlClipboardData clipboardData
        {
            get;
            private set;
        }
        ///<summary>
        ///Scrolls the window to the specified x- and y-offset. 
        ///</summary>
        ///<param name="x">Required. Integer that specifies the horizontal scroll offset, in pixels.</param>
        ///<param name="y">Required. Integer that specifies the vertical scroll offset, in pixels.</param>
        public void scrollTo(double x, double y) { }
        ///<summary>
        ///Causes the window to scroll relative to the current scrolled position by the specified x- and y-pixel offset. 
        ///</summary>
        ///<param name="x">Required. Integer that specifies the horizontal scroll offset, in pixels. Positive values scroll the window right, and negative values scroll it left.</param>
        ///<param name="y">Required. Integer that specifies the vertical scroll offset, in pixels. Positive values scroll the window down, and negative values scroll it up.</param>
        public void scrollBy(double x, double y) { }
        ///<summary>
        ///Causes the element to receive the focus and executes the code specified by the onfocus event. 
        ///</summary>
        public void focus() { }
        ///<summary>
        ///Contains information about the client's screen and rendering capabilities.
        ///</summary>
        public HtmlScreen screen { get; set; }
        public JsNumber setInterval(JsFunction func, JsNumber ms) { return null; }
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setInterval(Action func, JsNumber ms) { return null; }
        public JsNumber clearInterval(JsNumber ms) { return null; }
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void attachEvent(JsString eventName, HtmlDomEventHandler handler) { }
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        ///<param name="useCapture"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void addEventListener(JsString eventName, HtmlDomEventHandler handler, JsBoolean useCapture) { }
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void detachEvent(JsString eventName, HtmlDomEventHandler handler) { }
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        ///<param name="useCapture"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public void removeEventListener(JsString eventName, HtmlDomEventHandler handler, JsBoolean useCapture) { }
        ///<summary>
        ///Returns the computed style of an element. Computed style represents the final computed values of all CSS properties for the element.
        ///</summary>
        ///<param name="el">an element</param>
        ///<param name="pseudoElt">a JsString specifying the pseudo-element to match. Must be null for regular elements.</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElementStyle getComputedStyle(HtmlElement el, JsString pseudoElt) { return null; }
        ///<summary>
        ///Returns the computed style of an element. Computed style represents the final computed values of all CSS properties for the element.
        ///</summary>
        ///<param name="el">an element</param>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlElementStyle getComputedStyle(HtmlElement el) { return null; }
        ///<summary>
        ///The dimensions of the viewport (interior of the browser window) 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber innerWidth { get; set; }
        ///<summary>
        ///The dimensions of the viewport (interior of the browser window) 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber innerHeight { get; set; }
        ///<summary>
        ///The dimensions of the entire browser window (including taskbars and such) 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber outerWidth { get; set; }
        ///<summary>
        ///The dimensions of the entire browser window (including taskbars and such) 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber outerHeight { get; set; }
        ///<summary>
        ///The amount of pixels the entire pages has been scrolled 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber pageXOffset { get; set; }
        ///<summary>
        ///The amount of pixels the entire pages has been scrolled 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public JsNumber pageYOffset { get; set; }
        ///<summary>
        ///The position of the browser window on the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"Opera calculates the coordinates of the specific tab window relative to the encompassing browser window. This is understandable given its way of working with windows, but strictly speaking it's a bug. It should give the coordinates of the encompassing browser window relative to the screen.")]
        public JsNumber screenX { get; set; }
        ///<summary>
        ///The position of the browser window on the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Konqueror3_57, @"Opera calculates the coordinates of the specific tab window relative to the encompassing browser window. This is understandable given its way of working with windows, but strictly speaking it's a bug. It should give the coordinates of the encompassing browser window relative to the screen.")]
        public JsNumber screenY { get; set; }
        ///<summary>
        ///Fires on the object immediately after its associated document prints or previews for printing.
        ///</summary>		
        public HtmlDomEventHandler onafterprint;
        ///<summary>
        ///Fires on the object before its associated document prints or previews for printing.
        ///</summary>		
        public HtmlDomEventHandler onbeforeprint;
        ///<summary>
        ///Fires prior to a page being unloaded.
        ///</summary>		
        public HtmlDomEventHandler onbeforeunload;
        ///<summary>
        ///Fires when the object loses the input focus.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.
Safari iPhone does not fire the event when the window loses the focus. ", NotSupportedRemark = "Konqueror doesn’t support these events on the browser window.")]
        public HtmlDomEventHandler onblur;
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires when the object receives focus.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, @"Konqueror doesn’t support these events on the browser window.", PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Firefox fires a focus event whenever you click on the document.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.")]
        public HtmlDomEventHandler onfocus;
        ///<summary>
        ///Raised when there are changes to the portion of a URL that follows the number sign (#).
        ///</summary>		
        public HtmlDomEventHandler onhashchange;
        ///<summary>
        ///Fires when the user presses the F1 key while the browser is the active window.
        ///</summary>		
        public HtmlDomEventHandler onhelp;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public HtmlDomEventHandler onload;
        ///<summary>
        ///Fires when the size of the object is about to change.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onresize;
        ///<summary>
        ///Fires when the user repositions the scroll box in the scroll bar on the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari probably monitors scrollTop access in order to determine whether the user has scrolled an element with overflow: auto.")]
        public HtmlDomEventHandler onscroll;
        ///<summary>
        ///Fires immediately before the object is unloaded.
        ///</summary>		
        public HtmlDomEventHandler onunload;
        public HtmlWindow self { get; set; }
        public JsString name { get; set; }
        public History history { get; set; }
        [JsProperty(NativeIndexer = true)]
        public object this[JsString name] { get { return null; } set { } }
        public JsString appVersion
        {
            get;
            private set;
        }
        public JsString platform
        {
            get;
            private set;
        }
        public JsString userAgent
        {
            get;
            private set;
        }
        public object dialogArguments
        {
            get;
            private set;
        }
        public JsString returnValue { get; set; }
        /// <summary>
        /// moves a window's left and top edge to the specified coordinates.
        /// </summary>
        /// <param name="numX"></param>
        /// <param name="numY"></param>
        public void moveTo(JsNumber numX, JsNumber numY) { }
        /// <summary>
        /// method moves a window a specified number of pixels relative to its current coordinates.
        /// </summary>
        /// <param name="numX"></param>
        /// <param name="numY"></param>
        public void moveBy(JsNumber numX, JsNumber numY) { }
    }
    #endregion
    #region HtmlWindowLocation
    ///<summary>
    ///Contains information about the current URL. 
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "WINDOWLOCATION")]
    public partial class HtmlWindowLocation
    {
        ///<summary>
        ///Sets or retrieves the entire URL as a JsString. 
        ///</summary>
        public JsString href { get; set; }
        ///<summary>
        ///reloads the current page.
        ///</summary>
        public void reload() { }
        ///<summary>
        ///Sets or retrieves the subsection of the href property that follows the number sign (#).
        ///</summary>
        public JsString hash { get; set; }
        ///<summary>
        ///Sets or retrieves the hostname and port number of the location or URL.
        ///</summary>
        public JsString host { get; set; }
        ///<summary>
        ///Sets or retrieves the host name part of the location or URL.
        ///</summary>
        public JsString hostname { get; set; }
        ///<summary>
        ///Sets or retrieves the file name or path specified by the object.
        ///</summary>
        public JsString pathname { get; set; }
        ///<summary>
        ///Sets or retrieves the port number associated with a URL.
        ///</summary>
        public JsString port { get; set; }
        ///<summary>
        ///Sets or retrieves the protocol portion of a URL.
        ///</summary>
        public JsString protocol { get; set; }
        ///<summary>
        ///Sets or retrieves the substring of the href property that follows the question mark.
        ///</summary>
        public JsString search { get; set; }
        ///<summary>
        ///Replaces the current document by loading another document at the specified URL.
        ///</summary>
        public void assign(JsString url) { }
        /// <summary>
        ///Replaces the current document by loading another document at the specified URL.
        /// </summary>
        public void replace(JsString url) { }
        public JsString resolveURL(JsString url) { return null; }
    }
    #endregion
    #region HtmlWindowNavigator
    [JsType(JsMode.Prototype, Export = false)]
    public partial class HtmlWindowNavigator
    {
        public JsString appVersion { get; private set; }
        public JsString platform { get; private set; }
        public JsString userAgent { get; private set; }
    }
    #endregion

    #region XMLHttpRequest
    [JsType(JsMode.Prototype, Name="XMLHttpRequest", Export=false)]
    public partial class XMLHttpRequest
    {
        public void open(JsString method, JsString address, JsBoolean async) { }
        public void send(JsString body) { }
        public JsString responseText { get; private set;}
        public JsAction onreadystatechange { get; set; }
        public JsNumber readyState { get; private set;}
        public JsNumber status { get; private set;}
        public JsString statusText { get; private set;}
        public void setRequestHeader(string name, string value) { }

    }
    #endregion

    #region Collections
    #region StyleFilterCollection
    [JsType(JsMode.Prototype, Export = false, Name = "StyleFilterCollection")]
    public partial class StyleFilterCollection
    {
        public StyleFilter item(JsString name) { return null; }
    }
    #endregion
    #region HtmlNodeCollection
    ///<summary>
    ///Represents a collection of HtmlNode objects
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "NODECOLLECTION")]
    public partial class HtmlNodeCollection : HtmlNodeCollection<HtmlNode>
    {
    }

    ///<summary>
    ///Represents a generic collection of HtmlNode objects
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "NODECOLLECTION")]
    public partial class HtmlNodeCollection<T> : IEnumerable, IEnumerable<T> where T : class
    {
        [JsProperty(NativeIndexer=true)]
        public T this[JsNumber index] { get { return null; } }
        [JsProperty(NativeIndexer = true)]
        public T this[JsString name] { get { return null; } }
        public IEnumerator<T> GetEnumerator() { return default(IEnumerator<T>); }
        IEnumerator IEnumerable.GetEnumerator() { return null; }
        public JsNumber length
        {
            get;
            private set;
        }
        ///<summary>
        ///Access an item in an array
        ///</summary>
        ///<returns></returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
        public T item(JsNumber index) { return null; }
    }

    #endregion
    #region HtmlElementCollection

    ///<summary>
    ///Represents a collection of HtmlElement objects
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ELEMENTCOLLECTION")]
    public partial class HtmlElementCollection : HtmlNodeCollection<HtmlElement>
    {
    }
    #endregion
    #region HtmlTextRectangleCollection
    ///<summary>
    ///Represents a collection of rectangles, as returned by the <see cref="M:SharpKit.HtmlModel.HtmlElement.getClientRects"/> method.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TEXTRECTANGLECOLLECTION")]
    public partial class HtmlTextRectangleCollection
    {
        ///<summary>
        ///Gets or sets the rectangle at the Nth position
        ///</summary>
        ///<param name="index"></param>
        ///<returns></returns>
        [JsProperty(NativeIndexer = true)]
        public HtmlTextRectangle this[JsNumber index] { get { return null; } set { } }
        public JsNumber length;
    }
    #endregion
    #region HtmlGenericCollection
    ///<summary>
    ///Represents a generic collection of HtmlNode objects
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "GENERICCOLLECTION")]
    public partial class HtmlGenericCollection<T> : IEnumerable, IEnumerable<T> where T : class
    {
        [JsProperty(NativeIndexer = true)]
        public T this[JsNumber index] { get { return null; } }
        [JsProperty(NativeIndexer = true)]
        public T this[JsString name] { get { return null; } }
        public IEnumerator<T> GetEnumerator() { return default(IEnumerator<T>); }
        IEnumerator IEnumerable.GetEnumerator() { return null; }
        public JsNumber length
        {
            get;
            private set;
        }
    }
    #endregion
    #region HtmlAttributeCollection
    ///<summary>
    ///A collection of attributes of an object.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public partial class HtmlAttributeCollection : IEnumerable, IEnumerable<HtmlAttribute>
    {
        public HtmlAttributeCollection() { }
        ///<summary>
        ///Sets or retrieves the number of objects in a collection.
        ///</summary>
        public JsNumber length
        {
            get;
            private set;
        }
        ///<summary>
        ///Gets an attribute for an element from the attributes collection.
        ///</summary>
        ///<param name="index">Integer that specifies the attribute. It is the zero-based index of the attribute to be retrieved from the attributes collection.</param>
        ///<returns>Returns an attribute for an element from the attributes collection</returns>
        [SupportedBrowsers(BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"Firefox and IE8 try to create a list in source code order, but the order is off.
IE5-7 takes the second possible attribute of node x (dataFld in the test), whether it's defined or not. Therefore it consists of all attributes that can possibly be defined on the node (84 all in all).
IE 5.5 initially gives the value of the attribute; not the attribute object.")]
        [JsProperty(NativeIndexer = true)]
        public HtmlAttribute this[JsNumber index] { get { return null; } set { } }
        ///<summary>
        ///Gets an attribute for an element from the attributes collection.
        ///</summary>
        ///<param name="name">String that specifies the attribute. The attribute whose name matches the JsString is retrieved.</param>
        ///<returns>Returns an attribute for an element from the attributes collection</returns>
        [SupportedBrowsers(BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.FireFox2 | BrowserTypes.FireFox3 | BrowserTypes.FireFox3_5 | BrowserTypes.FireFox4 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57, @"IE5-7 doesn't return the value of a style attribute.
IE 5.5 doesn't return custom attributes, and initially gives the attribute value instead of an attribute object.")]
        [JsProperty(NativeIndexer = true)]
        public HtmlAttribute this[JsString name] { get { return null; } set { } }
        public IEnumerator<HtmlAttribute> GetEnumerator() { return default(IEnumerator<HtmlAttribute>); }
        IEnumerator IEnumerable.GetEnumerator() { return null; }
    }
    #endregion
    #endregion

    #region Delegates
    public delegate void HtmlDomEventHandler(HtmlDomEventArgs e);
    #endregion

    #region Misc

    #region ActiveXObject
    [JsType(JsMode.Prototype, Name = "ActiveXObject", Export = false)]
    public partial class ActiveXObject
    {
        public ActiveXObject(JsString className) { }
    }
    #endregion
    #region History
    ///<summary>
    ///interface History { readonly attribute long length ; void go (in optional long delta); void back (); void forward (); void pushState (in any data, in DOMString title, in optional DOMString url); void replaceState (in any data, in DOMString title, in optional DOMString url); };
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class History
    {
        public long length { get; set; }
        public void go(long delta) { }
        public void back() { }
        public void forward() { }
        public void pushState(object data, JsString title, JsString url) { }
        public void replaceState(object data, JsString title, JsString url) { }
    }
    #endregion
    #region StyleFilter
    [JsType(JsMode.Prototype, Export = false, Name = "StyleFilter")]
    public partial class StyleFilter
    {
    }
    #endregion
    #region WindowModal
    [JsType(JsMode.Prototype, Export = false)]
    public partial interface WindowModal
    {
        object dialogArguments { get; }
        JsString returnValue { get; set; }
    }
    #endregion

    #endregion


}
