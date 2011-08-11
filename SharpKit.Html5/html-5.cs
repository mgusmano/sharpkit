using SharpKit.JavaScript;
using System;
using System.Collections;
using System.Collections.Generic;
namespace SharpKit.Html5
{
    #region ActiveXObject
    [JsType(JsMode.Prototype, Name = "ActiveXObject")]
    public partial class ActiveXObject
    {
        public  ActiveXObject(JsString className){}
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
    #region HtmlNodeCollection
    ///<summary>
    ///Represents a generic collection of HtmlNode objects
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "NODECOLLECTION")]
    public partial class HtmlNodeCollection<T> : IEnumerable, IEnumerable<T>
    {
        public  HtmlNodeCollection(){}
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        internal void Append(T node){}
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        internal void InsertBefore(T newNode, T beforeNode){}
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        internal void AddFirstNode(T node){}
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        internal void Remove(T node){}
        [JsProperty(NativeIndexer = true)]
        public T this[JsNumber index]{get{return default(T);}}
        [JsProperty(NativeIndexer = true)]
        public T this[JsString name]{get{return default(T);}}
        public IEnumerator<T> GetEnumerator(){return default(IEnumerator<T>);}
        IEnumerator IEnumerable.GetEnumerator(){return default(IEnumerator);}
        public JsNumber length{get{return default(JsNumber);}
        }
        ///<summary>
        ///Access an item in an array
        ///</summary>
        ///<returns></returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public T item(JsNumber index){return default(T);}
    }
    #endregion
    #region HtmlGenericCollection
    ///<summary>
    ///Represents a generic collection of HtmlNode objects
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "GENERICCOLLECTION")]
    public partial class HtmlGenericCollection<T> : IEnumerable, IEnumerable<T>
    {
        public  HtmlGenericCollection(){}
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        internal void Append(T node){}
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        internal void InsertBefore(T newNode, T beforeNode){}
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        internal void AddFirstNode(T node){}
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        internal void Remove(T node){}
        [JsProperty(NativeIndexer = true)]
        public T this[JsNumber index]{get{return default(T);}}
        [JsProperty(NativeIndexer = true)]
        public T this[JsString name]{get{return default(T);}}
        public IEnumerator<T> GetEnumerator(){return default(IEnumerator<T>);}
        IEnumerator IEnumerable.GetEnumerator(){return default(IEnumerator);}
        public JsNumber length{get{return default(JsNumber);}
        }
    }
    #endregion
    #region HtmlAnchor
    [JsType(JsMode.Prototype, Export = false, Name = "ANCHOR")]
    public partial class HtmlAnchor : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves a destination URL or an anchor point.
        ///</summary>
        public JsString href{get;set;}
        ///<summary>
        ///Sets or retrieves the window or frame at which to target content.
        ///</summary>
        public JsString target{get;set;}
        ///<summary>
        ///Sets or retrieves the character set used to encode the object.
        ///</summary>
        public JsString charset{get;set;}
        ///<summary>
        ///Sets or retrieves the coordinates of the object.
        ///</summary>
        public JsString coords{get;set;}
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        ///<summary>
        ///Sets or retrieves the subsection of the href property that follows the number sign (#).
        ///</summary>
        public JsString hash{get;set;}
        ///<summary>
        ///Sets or retrieves the hostname and port number of the location or URL.
        ///</summary>
        public JsString host{get;set;}
        ///<summary>
        ///Sets or retrieves the host name part of the location or URL.
        ///</summary>
        public JsString hostname{get;set;}
        ///<summary>
        ///Sets or retrieves the language code of the object.
        ///</summary>
        public JsString hreflang{get;set;}
        ///<summary>
        ///Sets or gets the list of HTTP methods supported by the object.
        ///</summary>
        public JsString Methods{get;set;}
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name{get;set;}
        ///<summary>
        ///Retrieves the file name specified in the href or src property of the object.
        ///</summary>
        public JsString nameProp{get;set;}
        ///<summary>
        ///Sets or retrieves the file name or path specified by the object.
        ///</summary>
        public JsString pathname{get;set;}
        ///<summary>
        ///Sets or retrieves the port number associated with a URL.
        ///</summary>
        public JsString port{get;set;}
        ///<summary>
        ///Sets or retrieves the protocol portion of a URL.
        ///</summary>
        public JsString protocol{get;set;}
        ///<summary>
        ///Sets or retrieves the relationship between the object and the destination of the link.
        ///</summary>
        public JsString rel{get;set;}
        ///<summary>
        ///Sets or retrieves the relationship between the object and the destination of the link.
        ///</summary>
        public JsString rev{get;set;}
        ///<summary>
        ///Sets or retrieves the substring of the href property that follows the question mark.
        ///</summary>
        public JsString search{get;set;}
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
        public JsString shape{get;set;}
        ///<summary>
        ///Sets or retrieves the MIME type of the object. e.g. 'text/css'
        ///</summary>
        public JsString type{get;set;}
        ///<summary>
        ///Sets or gets a Uniform Resource Name (URN) for a target document.
        ///</summary>
        public JsString urn{get;set;}
        [HtmlSpecificationVersion(5)]
        public DOMTokenList relList{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString media{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString ping{get;set;}
    }
    #endregion
    #region HtmlAppletElement
    ///<summary>
    ///The applet element is a Java-specific variant of the embed element. The applet element is now obsoleted so that all extension frameworks (Java, .NET, Flash, etc) are handled in a consistent manner.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLAppletElement")]
    public abstract partial class HtmlAppletElement : HtmlElement
    {
        public JsString align{get;set;}
        public JsString alt{get;set;}
        public JsString archive{get;set;}
        public JsString code{get;set;}
        public JsString codeBase{get;set;}
        public JsString height{get;set;}
        public ulong hspace{get;set;}
        public JsString name{get;set;}
        public JsString _object{get;set;}
        public ulong vspace{get;set;}
        public JsString width{get;set;}
    }
    #endregion
    #region HtmlAttribute
    ///<summary>
    ///Represents an HTML Attribute node
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ATTRIBUTE")]
    public partial class HtmlAttribute : HtmlNode
    {
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString name{get;set;}
    }
    #endregion
    #region HtmlAttributeCollection
    ///<summary>
    ///A collection of attributes of an object.
    ///</summary>
    [JsType(NativeEnumerator = true)]
    public partial class HtmlAttributeCollection : IEnumerable, IEnumerable<HtmlAttribute>
    {
        public  HtmlAttributeCollection(){}
        ///<summary>
        ///Sets or retrieves the number of objects in a collection.
        ///</summary>
        public JsNumber length{get{return default(JsNumber);}
        }
        internal void Add(HtmlAttribute attribute){}
        ///<summary>
        ///Gets an attribute for an element from the attributes collection.
        ///</summary>
        ///<param name="index">Integer that specifies the attribute. It is the zero-based index of the attribute to be retrieved from the attributes collection.</param>
        ///<returns>Returns an attribute for an element from the attributes collection</returns>
        [JsProperty(NativeIndexer = true)]
        [SupportedBrowsers(BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Firefox and IE8 try to create a list in source code order, but the order is off.
IE5-7 takes the second possible attribute of node x (dataFld in the test), whether it's defined or not. Therefore it consists of all attributes that can possibly be defined on the node (84 all in all).
IE 5.5 initially gives the value of the attribute; not the attribute object.")]
        public HtmlAttribute this[JsNumber index]{get{return default(HtmlAttribute);}set{}}
        ///<summary>
        ///Gets an attribute for an element from the attributes collection.
        ///</summary>
        ///<param name="name">String that specifies the attribute. The attribute whose name matches the JsString is retrieved.</param>
        ///<returns>Returns an attribute for an element from the attributes collection</returns>
        [JsProperty(NativeIndexer = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"IE5-7 doesn't return the value of a style attribute.
IE 5.5 doesn't return custom attributes, and initially gives the attribute value instead of an attribute object.")]
        public HtmlAttribute this[JsString name]{get{return default(HtmlAttribute);}set{}}
        public IEnumerator<HtmlAttribute> GetEnumerator(){return default(IEnumerator<HtmlAttribute>);}
        IEnumerator IEnumerable.GetEnumerator(){return default(IEnumerator);}
    }
    #endregion
    #region HtmlBaseElement
    ///<summary>
    ///The base element allows authors to specify the document base URL for the purposes of resolving relative URLs , and the name of the default browsing context for the purposes of following hyperlinks . The element does not represent any content beyond this information.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLBaseElement")]
    public abstract partial class HtmlBaseElement : HtmlElement
    {
        public JsString href{get;set;}
        public JsString target{get;set;}
    }
    #endregion
    #region HtmlBaseFontElement
    ///<summary>
    ///User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLBaseFontElement")]
    public abstract partial class HtmlBaseFontElement : HtmlElement
    {
        public JsString color{get;set;}
        public JsString face{get;set;}
        public long size{get;set;}
    }
    #endregion
    #region HtmlBody
    ///<summary>
    ///Represents the root Body element of a HTML document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "BODY")]
    public partial class HtmlBody : HtmlElement
    {
        internal  HtmlBody(){}
        ///<summary>
        ///Creates a TextRange object for the element
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public HtmlTextRange createTextRange(){return default(HtmlTextRange);}
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
        public new HtmlDomEventHandler onload;
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public new HtmlDomEventHandler onselect;
        ///<summary>
        ///Fires immediately before the object is unloaded.
        ///</summary>		
        public HtmlDomEventHandler onunload;
        [HtmlSpecificationVersion(5)]
        public new HtmlDomEventHandler onerror{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmessage{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpopstate{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpagehide{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpageshow{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onredo{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onstorage{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onundo{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString text{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString bgColor{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString background{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString link{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString vLink{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString aLink{get;set;}
    }
    #endregion
    #region HtmlBr
    ///<summary>
    ///Inserts a line break.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "BR")]
    public partial class HtmlBr : HtmlElement
    {
        internal  HtmlBr(){}
        [HtmlSpecificationVersion(5)]
        public JsString clear{get;set;}
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
        public new JsString accessKey{get;set;}
        /// <summary>
        /// Gets the classification and default behavior of the button.
        /// Possible values:
        ///	button	Default. Creates a Command button.
        /// reset	Creates a Reset button. If the button is in a form, it resets the fields in the form to their initial values.
        /// submit	Creates a Submit button. If the button is in a form, it submits the form.
        /// </summary>
        public JsString type{get;set;}
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name{get;set;}
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld{get;set;}
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form{get;set;}
        /// <summary>
        /// Sets or retrieves the value indicating whether the control is selected.
        /// Possible values:
        ///	false	Default. Control is not selected.
        /// true	Control is selected.
        /// null	Control is not initialized.
        /// </summary>
        public bool status{get;set;}
        ///<summary>
        ///Sets or retrieves the default or selected value of the control.
        ///</summary>
        public JsString value{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool autofocus{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formAction{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formEnctype{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formMethod{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formNoValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formTarget{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool willValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public ValidityState validity{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString validationMessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setCustomValidity(JsString error){}
        [HtmlSpecificationVersion(5)]
        public NodeList labels{get;set;}
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
        public JsString vAlign{get;set;}
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
        [JsMethod(NativeOverloads = true)]
        public void setData(JsString sDataFormat, JsString sData){}
        ///<summary>
        ///Gets the data in the specified format from the clipboard through the dataTransfer object or the clipboardData object.
        ///</summary>
        ///<param name="sDataFormat">Required. A String that specifies one of the following data format values. </param>
        ///<returns>String. Returns the data in the format retrieved from the clipboard through the dataTransfer object or the clipboardData object. Depending on the information contained in setData, this variable can get a path to an image, text, or an anchor URL.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString getData(JsString sDataFormat){return default(JsString);}
    }
    #endregion
    #region HtmlContext
    [JsType(GlobalObject = true, Export = false)]
    public partial class HtmlContext : JsContext
    {
        ///<summary>
        ///Displays a dialog box containing an application-defined message. 
        ///</summary>
        ///<param name="message">Optional. String that specifies the message to display in the dialog box.</param>
        ///<remarks>You cannot change the title bar of the Alert dialog box.</remarks>
        [JsMethod(NativeOverloads = true)]
        public static void alert(object message){}
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
        [JsMethod(NativeOverloads = true)]
        public static bool confirm(JsString message){return default(bool);}
        ///<summary>
        ///Encodes String objects so they can be read on all computers.
        ///</summary>
        ///<param name="s">String object or literal to be encoded.</param>
        ///<returns>A JsString value (in Unicode format) that contains the contents of charstring. All spaces, punctuation, accented characters, and any other non-ASCII characters are replaced with %xx encoding, where xx is equivalent to the hexadecimal number representing the character. For example, a space is returned as "%20."</returns>
        public static JsString escape(JsString s){return default(JsString);}
        ///<summary>
        ///Returns the unencoded version of an encoded component of a Uniform Resource Identifier (URI). 
        ///</summary>
        ///<param name="encodedURIString">A value representing an encoded URI component.</param>
        ///<returns>The required encodedURIString argument is a value representing an encoded 
        ///URI component.A URIComponent is part of a complete URI. If the encodedURIString is 
        ///not valid, a URIError occurs.</returns>
        public static JsString decodeURIComponent(JsString encodedURIString){return default(JsString);}
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
        public static JsString encodeURIComponent(JsString encodedURIString){return default(JsString);}
        ///<summary>
        ///Encodes a text JsString as a valid Uniform Resource Identifier (URI) 
        ///</summary>
        ///<param name="URIString">A value representing an encoded URI.</param>
        ///<returns>n encoded URI. If you pass the result to decodeURI, the original JsString is returned. The encodeURI method does not encode the following characters: ":", "/", ";", and "?". Use encodeURIComponent to encode these characters.</returns>
        public static JsString encodeURI(JsString URIString){return default(JsString);}
        ///<summary>
        ///Returns the unencoded version of an encoded Uniform Resource Identifier (URI). 
        ///</summary>
        ///<param name="URIString"></param>
        ///<returns></returns>
        public static JsString decodeURI(JsString URIString){return default(JsString);}
        ///<summary>
        ///Decodes String objects encoded with the escape method.
        ///</summary>
        ///<param name="charString">String object or literal to be decoded.</param>
        ///<returns>A JsString value that contains the contents of charstring. All characters encoded with the %xx hexadecimal form are replaced by their ASCII character set equivalents.</returns>
        public static JsString unescape(JsString charString){return default(JsString);}
        ///<summary>
        ///Retrieves the HTML window
        ///</summary>
        public static HtmlWindow window{get;set;}
        ///<summary>
        ///Retrieves the HTML document
        ///</summary>
        public static HtmlDocument document{get;set;}
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
        public bool readOnly{get;set;}
        ///<summary>
        ///Retrieves a JsString that identifies which elements the corresponding style sheet rule applies to.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString selectorText{get;set;}
        ///<summary>
        ///Represents the current settings of all possible inline styles for a given element.
        ///</summary>
        public HtmlElementStyle style{get;set;}
        ///<summary>
        ///Sets or retrieves the persisted representation of the style rule.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString cssText{get;set;}
        ///<summary>
        ///Returns the stylesheet object in which the current rule is defined.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlStyleElement parentStyleSheet{get;set;}
    }
    #endregion
    #region HtmlDiv
    ///<summary>
    ///Specifies a container that renders HTML.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DIV")]
    public partial class HtmlDiv : HtmlElement
    {
        protected  HtmlDiv(){}
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld{get;set;}
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        ///<summary>
        ///Sets or retrieves whether the browser automatically performs wordwrap.
        ///</summary>
        public bool noWrap{get;set;}
        /// <summary>
        /// Sets or retrieves the alignment of the object relative to the display or table.
        /// Possible Values:
        /// center	Aligns to the center.
        /// justify	Aligns to the left and right edge.
        ///	left		Default. Aligns to the left edge.
        ///	right		Aligns to the right edge.
        /// </summary>
        public JsString align{get;set;}
    }
    #endregion
    #region HtmlScript
    [JsType(JsMode.Prototype, Export = false, Name = "SCRIPT")]
    public partial class HtmlScript : HtmlElement
    {
        ///<summary>
        ///Retrieves the URL to an external file that contains the source code or data.
        ///</summary>
        public JsString src{get;set;}
        ///<summary>
        ///Sets or retrieves the MIME type for the associated scripting engine.
        ///</summary>
        public JsString type{get;set;}
        public JsString language{get;set;}
        ///<summary>
        ///Sets or retrieves the character set used to encode the object.
        ///</summary>
        public JsString charset{get;set;}
        /// <summary>
        /// Sets or retrieves the status of the script.
        /// Possible values:
        ///	false		Default. Inline executable function is not deferred.
        /// true		Inline executable function is deferred.
        /// </summary>
        public bool defer{get;set;}
        ///<summary>
        ///Sets or retrieves the event for which the script is written.
        ///</summary>
        public JsString @event{get;set;}
        ///<summary>
        ///Sets or retrieves the object that is bound to the event script.
        ///</summary>
        public JsString htmlFor{get;set;}
        ///<summary>
        ///Retrieves or sets the text of the object as a JsString.
        ///</summary>
        public JsString text{get;set;}
    }
    #endregion
    #region HtmlDocument
    ///<summary>
    ///Represents an HTML document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DOCUMENT")]
    public partial class HtmlDocument
    {
        [HtmlSpecificationVersion(5)]
        public WindowProxy this[ulong index] { get { return default(WindowProxy); } set { } }

        ///<summary>
        ///Gets a collection of objects based on the value of the NAME or ID attribute.
        ///</summary>
        ///<param name="sNameValue"></param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5, @"IE5-7 ignores the <p> and custom tags with name='test', but counts the <div> with id='test'
IE8 and Konqueror ignore the custom tag.
Opera counts the <div> with id='test'")]
        public HtmlElementCollection getElementsByName(JsString sNameValue){return default(HtmlElementCollection);}
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void attachEvent(JsString eventName, HtmlDomEventHandler handler){}
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void detachEvent(JsString eventName, HtmlDomEventHandler handler){}
        ///<summary>
        ///Retrieves a value that indicates the current state of the object.
        ///uninitializedObject is not initialized with data.
        ///loadingObject is loading its data.
        ///loadedObject has finished loading its data.
        ///interactiveUser can interact with the object even though it is not fully loaded.
        ///completeObject is completely initialized.
        ///</summary>
        public JsString readyState{get{return default(JsString);}
        }
        ///<summary>
        ///Retrieves a collection of HTML Elements and TextNode objects that are descendants of the specified object.
        ///</summary>
        public HtmlElementCollection all{get;set;}
        ///<summary>
        ///Gets the object that has the focus when the parent document has focus.
        ///</summary>
        public HtmlElement activeElement{get;set;}
        ///<summary>
        ///Gets or sets the HtmlWindow object that contains this HtmlDocument
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlWindow parentWindow{get;set;}
        ///<summary>
        ///Returns the root node for this HtmlDocument
        ///</summary>
        public HtmlDocumentElement documentElement{get;set;}
        [JsMethod(NativeOverloads = true)]
        public void appendChild(HtmlElement child){}
        ///<summary>
        ///Creates a new TextNode
        ///</summary>
        ///<param name="text"></param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlTextNode createTextNode(JsString text){return default(HtmlTextNode);}
        ///<summary>
        ///Creates a new HtmlElement
        ///</summary>
        ///<param name="name"></param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement createElement(JsString name){return default(HtmlElement);}
        ///<summary>
        ///Creates a new HtmlElement
        ///</summary>
        ///<param name="name"></param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public T createElement<T>(JsString name){return default(T);}
        ///<summary>
        ///Retrieves a collection of objects based on the specified element name.
        ///</summary>
        ///<param name="sTagName">String that specifies the name of an element.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera9|BrowserTypes.Opera10, @"The * argument, which ought to select all elements in the document, doesn't work in IE 5.5. 
Custom tags are not returned in Konqueror.")]
        public HtmlElementCollection getElementsByTagName(JsString sTagName){return default(HtmlElementCollection);}
        ///<summary>
        ///Creates a new Stylesheet node
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlStyleElement createStyleSheet(){return default(HtmlStyleElement);}
        ///<summary>
        ///Creates a new Stylesheet node
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlStyleElement createStyleSheet(JsString url){return default(HtmlStyleElement);}
        ///<summary>
        ///Creates a new Stylesheet node
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public HtmlStyleElement createStyleSheet(JsNumber index){return default(HtmlStyleElement);}
        ///<summary>
        ///Creates a new Stylesheet node.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public HtmlStyleElement createStyleSheet(JsString url, JsNumber index){return default(HtmlStyleElement);}
        ///<summary>
        ///Gets the HtmlSelection object of this HtmlDocument
        ///</summary>
        public HtmlSelection selection{get{return default(HtmlSelection);}
        }
        ///<summary>
        ///Gets the HtmlBody root element of this HtmlDocument
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlBody body{get;set;}
        ///<summary>
        ///Gets the title of this HtmlDocument
        ///</summary>
        public JsString title{get;set;}
        public void open(){}
        public void close(){}
        [JsMethod(NativeOverloads = true)]
        public void write(JsString p){}
        ///<summary>
        ///Returns a reference to the first object with the specified value of the ID or NAME attribute (in IE)
        ///</summary>
        ///<param name="sIDValue">A String that specifies the ID value. Case-insensitive.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement getElementById(JsString sIDValue){return default(HtmlElement);}
        ///<summary>
        ///Returns a reference to the first object with the specified value of the ID or NAME attribute (in IE)
        ///</summary>
        ///<param name="sIDValue">A String that specifies the ID value. Case-insensitive.</param>		
        [JsMethod(NativeOverloads = true, IgnoreGenericArguments = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public T getElementById<T>(JsString sIDValue){return default(T);}
        ///<summary>
        ///Creates a new document.
        ///</summary>
        ///<returns>Returns the newly created document.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDocumentFragment createDocumentFragment(){return default(HtmlDocumentFragment);}
        ///<summary>
        ///Generates an event object to pass event context information when you use the fireEvent method.
        ///</summary>
        ///<returns>Returns an event object.</returns>
        [JsMethod(NativeOverloads = true)]
        public HtmlDomEventArgs createEventObject(){return default(HtmlDomEventArgs);}
        ///<summary>
        ///Generates an event object to pass event context information when you use the fireEvent method.
        ///</summary>
        ///<param name="existingEvent">A object that specifies an existing event object on which to base the new object. </param>
        ///<returns>Returns an event object.</returns>
        [JsMethod(NativeOverloads = true)]
        public HtmlDomEventArgs createEventObject(HtmlDomEventArgs existingEvent){return default(HtmlDomEventArgs);}
        ///<summary>
        ///Sets or gets the JsString value of a cookie.
        ///</summary>
        public JsString cookie{get;set;}
        ///<summary>
        ///Gets a value that indicates whether standards-compliant mode is switched on for the object.
        ///</summary>
        ///<remarks>
        ///Possible Values
        ///BackCompat - Standards-compliant mode is not switched on.
        ///CSS1Compat Standards-compliant mode is switched on.
        ///</remarks>
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"IE 5.5 doesn't support this property, but it doesn't need to. It's permanently locked in Quirks Mode.")]
        public JsString compatMode{get;set;}
        ///<summary>
        ///Returns a reference to the default AbstractView for the document, or null if none available
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDocument defaultView{get;set;}
        ///<summary>
        ///Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlNodeCollection<HtmlStyleElement> styleSheets{get;set;}
        [SupportedBrowsers(BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        [JsMethod(NativeOverloads = true)]
        public HtmlElementCollection getElementsByClassName(JsString sClassName){return default(HtmlElementCollection);}
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Opera10)]
        [JsMethod(NativeOverloads = true)]
        public HtmlElementCollection querySelectorAll(JsString selector){return default(HtmlElementCollection);}
        ///<summary>
        ///Returns the element for the specified x coordinate and the specified y coordinate.
        ///</summary>
        ///<param name="iX">A Integer that specifies the X-offset, in pixels.</param>
        ///<param name="iY">A Integer that specifies the Y-offset, in pixels.</param>
        ///<returns>Returns an element object.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, PartiallySupportedRemark = @"IE and Firefox need clientX/Y, while Opera, Chrome and Safari need pageX/Y. Opera 9 reports a text node whenever possible, while this method should report the containing element node.")]
        public HtmlElement elementFromPoint(JsNumber iX, JsNumber iY){return default(HtmlElement);}
        [HtmlSpecificationVersion(5)]
        public HtmlWindowLocation location{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString URL{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString domain{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString referrer{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString lastModified{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString charset{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString characterSet{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString defaultCharset{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString dir{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlHead head{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection images{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection embeds{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection plugins{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection links{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection forms{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection scripts{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public NodeList getItems(JsString typeNames){return default(NodeList);}
        [HtmlSpecificationVersion(5)]
        public object this[JsString name]{get{return default(object);}set{}}
        [HtmlSpecificationVersion(5)]
        public JsString innerHTML{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void writeln(params JsString[] text){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public Selection getSelection(){return default(Selection);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool hasFocus(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        public JsString designMode{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool execCommand(JsString commandId){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool execCommand(JsString commandId, bool showUI){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool execCommand(JsString commandId, bool showUI, JsString value){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool queryCommandEnabled(JsString commandId){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool queryCommandIndeterm(JsString commandId){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool queryCommandState(JsString commandId){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool queryCommandSupported(JsString commandId){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public JsString queryCommandValue(JsString commandId){return default(JsString);}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection commands{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onabort{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onblur{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncanplay{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncanplaythrough{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onclick{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncontextmenu{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondblclick{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondrag{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragend{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragenter{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragleave{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragover{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragstart{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondrop{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondurationchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onemptied{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onended{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onerror{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onfocus{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onformchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onforminput{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oninput{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oninvalid{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onkeydown{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onkeypress{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onkeyup{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onload{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadeddata{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadedmetadata{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadstart{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmousedown{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmousemove{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmouseout{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmouseover{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmouseup{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmousewheel{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpause{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onplay{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onplaying{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onprogress{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onratechange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onreadystatechange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onscroll{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onseeked{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onseeking{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onselect{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onshow{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onstalled{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onsubmit{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onsuspend{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ontimeupdate{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onvolumechange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onwaiting{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString fgColor{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString bgColor{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString linkColor{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString vlinkColor{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString alinkColor{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection anchors{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection applets{get;set;}
        ///<summary>
        ///Creates a new comment node, and returns it.
        ///</summary>
        ///<param name="data">a JsString containing the data to be added to the Comment.</param>
        public HtmlNode createComment(JsString data){return default(HtmlNode);}
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
        public object activeElement{get;set;}
        ///<summary>
        ///Sets or gets the color of all active links in the document.
        ///</summary>
        public JsString alinkColor{get;set;}
        ///<summary>
        ///Sets or retrieves the character set used to encode the object.
        ///</summary>
        public JsString charset{get;set;}
        ///<summary>
        ///Retrieves the collection of user agents and versions declared in the X-UA-Compatible
        ///</summary>
        public object compatible{get;set;}
        /// <summary>
        /// Gets a value that indicates whether standards-compliant mode is switched on for the object.
        /// Possible values:
        ///	BackCompat	Standards-compliant mode is not switched on.
        /// CSS1Compat	Standards-compliant mode is switched on.
        /// </summary>
        public object compatMode{get;set;}
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
        public object cookie{get;set;}
        ///<summary>
        ///Gets the default character set from the current regional language settings.
        ///</summary>
        public JsString defaultCharset{get;set;}
        ///<summary>
        ///Sets or gets a value that indicates whether the document can be edited.	  
        ///Possible Values:
        ///On							Document can be edited.
        ///Off | Inherit		Default. Document cannot be edited.
        ///</summary>
        public JsString designMode{get;set;}
        ///<summary>
        ///Gets the document type declaration associated with the current document.
        ///Possible values:
        ///ltr		Default. Content flows from left to right.
        ///rtl		Content flows from right to left.
        ///</summary>
        public JsString doctype{get;set;}
        ///<summary>
        ///Gets a reference to the root node of the document.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement documentElement{get;set;}
        /// <summary>
        /// Retrieves the document compatibility mode of the document.
        /// Possible values:
        ///	5		Microsoft Internet Explorer 5 mode (also known as "quirks mode").
        /// 7		Internet Explorer 7 Standards mode.
        /// 8   Internet Explorer 8 Standards mode.
        /// </summary>
        public Double documentMode{get;set;}
        ///<summary>
        ///Sets or gets the security domain of the document.
        ///</summary>
        public object domain{get;set;}
        ///<summary>
        ///Sets or retrieves a value indicating whether arbitrary variables can be created within the object.
        ///Possible values:
        ///true	Default. Creation of arbitrary variables is allowed.
        ///false	Creation of arbitrary variables is not allowed.
        ///</summary>
        public bool expando{get;set;}
        ///<summary>
        ///Sets or gets the foreground (text) color of the document.
        ///</summary>
        public bool fgColor{get;set;}
        ///<summary>
        ///Retrieves the date the file was created.
        ///</summary>
        public JsString fileCreatedDate{get;set;}
        ///<summary>
        ///Retrieves the date the file was last modified.
        ///</summary>
        public JsString fileModifiedDate{get;set;}
        ///<summary>
        ///Retrieves the file size.
        ///</summary>
        public JsString fileSize{get;set;}
        ///<summary>
        ///Retrieves the date the file was last updated.
        ///</summary>
        public JsString fileUpdatedDate{get;set;}
        ///<summary>
        ///Gets the implementation object of the current document.
        ///</summary>
        public HtmlDomImplementation implementation{get;set;}
        ///<summary>
        ///Gets the date that the page was last modified, if the page supplies one.
        ///</summary>
        public JsString lastModified{get;set;}
        ///<summary>
        ///Sets or gets the color of the document links.
        ///</summary>
        public JsString linkColor{get;set;}
        ///<summary>
        ///Sets or retrieves the media type.
        ///Possible Values:
        ///screen		Output is intended for computer screens.
        ///print			Output is intended for printed material and for on-screen documents viewed in Print Preview mode.
        ///all				Default. Applies to all devices.
        ///</summary>
        public JsString media{get;set;}
        ///<summary>
        ///Retrieves the file name specified in the href or src property of the object.
        ///</summary>
        public JsString nameProp{get;set;}
        ///<summary>
        ///Gets a reference to the container object of the window.
        ///</summary>
        public object parentWindow{get;set;}
        ///<summary>
        ///Sets or retrieves the protocol portion of a URL.
        ///</summary>
        public JsString protocol{get;set;}
        ///<summary>
        ///Retrieves a value that indicates the current state of the object.	
        ///Possible Values:
        ///uninitialized		Object is not initialized with data.
        ///loading					Object is loading its data.
        ///loaded					Object has finished loading its data.
        ///interactive			User can interact with the object even though it is not fully loaded.
        ///complete				Object is completely initialized.
        ///</summary>
        public JsString readyState{get;set;}
        ///<summary>
        ///Gets the URL of the location that referred the user to the current page.
        ///</summary>
        public JsString referrer{get;set;}
        ///<summary>
        ///Sets or gets the URL for the current document.
        ///</summary>
        public JsString URL{get;set;}
        ///<summary>
        ///Gets the URL for the document, stripped of any character encoding.		 
        ///</summary>
        public JsString URLUnencoded{get;set;}
        ///<summary>
        ///Sets or gets the color of the links that the user has visited.
        ///</summary>
        public JsString vLinkColor{get;set;}
    }
    #endregion
    #region HtmlDocumentFragment
    ///<summary>
    ///Represents a fragment of a document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DOCUMENTFRAGMENT")]
    public partial class HtmlDocumentFragment : HtmlElement
    {
        internal  HtmlDocumentFragment(){}
    }
    #endregion
    public delegate void HtmlDomEventHandler(HtmlDomEventArgs e);
    #region HtmlDomEventArgs
    ///<summary>
    ///Represents the state of an event, such as the element in which the event occurred, the state of the keyboard keys, the location of the mouse, and the state of the mouse buttons. 
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "DOMEVENTARGS")]
    public partial class HtmlDomEventArgs
    {
        protected  HtmlDomEventArgs(){}
        ///<summary>
        ///Sets or retrieves the Unicode key code associated with the key that caused the event. 
        ///</summary>
        public JsNumber keyCode;
        ///<summary>
        ///Sets or retrieves the x-coordinate, in pixels, of the mouse pointer's position relative to a relatively positioned parent element.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Use clientX/clientY")]
        public JsNumber x{get;set;}
        ///<summary>
        ///Sets or retrieves the y-coordinate, in pixels, of the mouse pointer's position relative to a relatively positioned parent element.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Use clientX/clientY")]
        public JsNumber y{get;set;}
        ///<summary>
        ///Sets or retrieves the state of the SHIFT key. 
        ///</summary>
        public bool shiftKey;
        ///<summary>
        ///Sets or retrieves the state of the CTRL key. 
        ///</summary>
        public bool ctrlKey;
        ///<summary>
        ///Sets or retrieves the name of the property that changes on the object.
        ///</summary>
        public JsString propertyName;
        ///<summary>
        ///Sets or retrieves the x-coordinate of the mouse pointer's position relative to the client area of the window, excluding window decorations and scroll bars.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber clientX{get;set;}
        ///<summary>
        ///Sets or retrieves the y-coordinate of the mouse pointer's position relative to the client area of the window, excluding window decorations and scroll bars.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber clientY{get;set;}
        ///<summary>
        ///Returns the horizontal coordinate of the event relative to whole document.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber pageX{get;set;}
        ///<summary>
        ///Returns the vertical coordinate of the event relative to the whole document.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber pageY{get;set;}
        ///<summary>
        ///Sets or retrieves the x-coordinate of the mouse pointer's position relative to the object firing the event. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber offsetX{get;set;}
        ///<summary>
        ///Sets or retrieves the y-coordinate of the mouse pointer's position relative to the object firing the event. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9, @"In IE the coordinates are calculated relative to the target element when that element is eligible to become an offsetParent. If that's not the case, the coordinates are calculated relative to the target's offsetParent.
Bug: When the element found by this rule has position: relative, IE moves on to the next offsetParent for the calculation of offsetY, but not of offsetX.")]
        public JsNumber offsetY{get;set;}
        ///<summary>
        ///Sets or retrieves the object that fired the event. 
        ///</summary>
        public HtmlElement srcElement{get;set;}
        ///<summary>
        ///Sets or retrieves the return value from the event. 
        ///</summary>
        public object returnValue{get;set;}
        ///<summary>
        ///Sets or retrieves whether the current event should bubble up the hierarchy of event handlers. 
        ///</summary>
        public bool cancelBubble{get;set;}
        ///<summary>
        ///Sets or retrieves the event name from the event object. 
        ///</summary>
        public JsString type{get;set;}
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
        public JsNumber button{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates the state of the ALT key. 
        ///</summary>
        public bool altKey{get;set;}
        ///<summary>
        ///Retrieves the state of the left CTRL key. 
        ///</summary>
        public bool ctrlLeft{get;set;}
        ///<summary>
        ///Retrieves the state of the right CTRL key. 
        ///</summary>
        public bool ctrlRight{get;set;}
        ///<summary>
        ///Retrieves the state of the left SHIFT key. 
        ///</summary>
        public bool shiftLeft{get;set;}
        ///<summary>
        ///Retrieves the state of the right SHIFT key. 
        ///</summary>
        public bool shiftRight{get;set;}
        ///<summary>
        ///Retrieves whether the onkeydown event is being repeated. 
        ///</summary>
        public bool repeat{get;set;}
        ///<summary>
        ///Sets or retrieves the x-coordinate of the mouse pointer's position relative to the user's screen. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber screenX{get;set;}
        ///<summary>
        ///Sets or retrieves the y-coordinate of the mouse pointer's position relative to the user's screen. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber screenY{get;set;}
        ///<summary>
        ///Retrieves the distance and direction the wheel button has rolled. 
        ///</summary>
        public JsNumber wheelDelta{get;set;}
        [HtmlSpecificationVersion(5)]
        public DataTransfer dataTransfer{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void initDragEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, AbstractView viewArg, long detailArg, long screenXArg, long screenYArg, long clientXArg, long clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, ushort buttonArg, EventTarget relatedTargetArg, DataTransfer dataTransferArg){}
        [HtmlSpecificationVersion(5)]
        public object data{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void initUndoManagerEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, object dataArg){}
        [HtmlSpecificationVersion(5)]
        public JsString origin{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString lastEventId{get;set;}
        [HtmlSpecificationVersion(5)]
        public WindowProxy source{get;set;}
        [HtmlSpecificationVersion(5)]
        public MessagePortArray ports{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public void initMessageEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, object dataArg, JsString originArg, JsString lastEventIdArg, WindowProxy sourceArg, MessagePortArray portsArg){}
        [HtmlSpecificationVersion(5)]
        public object state{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public void initPopStateEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, object stateArg){}
        [HtmlSpecificationVersion(5)]
        public JsString key{get;set;}
        [HtmlSpecificationVersion(5)]
        public object oldValue{get;set;}
        [HtmlSpecificationVersion(5)]
        public object newValue{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString url{get;set;}
        [HtmlSpecificationVersion(5)]
        public Storage storageArea{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public void initStorageEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, JsString keyArg, object oldValueArg, object newValueArg, JsString urlArg, Storage storageAreaArg){}
        [HtmlSpecificationVersion(5)]
        public JsString message{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString filename{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong lineno{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public void initErrorEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, JsString messageArg, JsString filenameArg, ulong linenoArg){}
    }
    #endregion
    #region HtmlDomImplementation
    [JsType(JsMode.Prototype, Export = false, Name = "DOMIMPLEMENTATION")]
    public partial class HtmlDomImplementation
    {
        /////<summary>
        /////Creates a DOM document.
        /////</summary>
        /////<param name="namespaceURI">namespace URI of the document to be created (use null if none)</param>
        /////<param name="qualifiedNameStr">qualified name (optional prefix and colon plus the local root element name) of the document to be created</param>
        /////<param name="documentType">the DocumentType to be created.</param>
        //[SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        //public XmlDocument createDocument(JsString namespaceURI, JsString qualifiedNameStr, XmlDocumentType documentType){return default(XmlDocument);}
        ///<summary>
        ///Creates an HTMLDocument object with the minimal tree made of the following elements: HTML, HEAD, TITLE, and BODY.
        ///</summary>
        ///<remarks>Introduced in DOM Level 2</remarks>
        ///<returns>A new HTMLDocument object.</returns>
        [SupportedBrowsers(BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public HtmlDocument createHTMLDocument(){return default(HtmlDocument);}
        /////<summary>
        /////Returns a DocumentType object which can either be used with DOMImplementation.createDocument upon document creation or they can be put into the document via Node.insertBefore() or Node.replaceChild()
        /////</summary>
        /////<param name="qualifiedNameStr"></param>
        /////<param name="publicId"></param>
        /////<param name="systemId"></param>
        /////<returns></returns>
        //public XmlDocumentType createDocumentType(JsString qualifiedNameStr, JsString publicId, JsString systemId){return default(XmlDocumentType);}
        public object getFeature(JsString feature, JsString version){return default(object);}
        public bool hasFeature(JsString feature, JsString version){return default(bool);}
    }
    #endregion
    #region HtmlElement
    ///<summary>
    ///Retrieves the type of the requested node.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ELEMENT")]
    public partial class HtmlElement : HtmlNode
    {
        protected  HtmlElement(){}
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, "IE incorrectly counts comment nodes, too.")]
        public HtmlElementCollection children{get{return default(HtmlElementCollection);}
        }
        ///<summary>
        ///Removes the given attribute from the object.
        ///</summary>
        ///<param name="attName">String that specifies the attribute name. </param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5, @"IE5-7 and Opera don't remove event handlers.
Konqueror doesn't remove the align attribute.")]
        public void removeAttribute(JsString attName){}
        ///<summary>
        ///Removes the given attribute from the object.
        ///</summary>
        ///<param name="attName">String that specifies the attribute name. </param>
        ///<param name="caseSensitive"> Integer that specifies whether to use a case-sensitive search to locate the attribute. By default, this value is set to 1 to indicate that the uppercase and lowercase letters in the specified sName parameter must exactly match those in the attribute name. If there are multiple attributes specified with different case sensitivity, the attribute returned might vary across platforms. </param>
        [JsMethod(NativeOverloads = true)]
        public void removeAttribute(JsString attName, JsNumber caseSensitive){}
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
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9, NotSupportedRemark = "Use innerHTML and insertBefore()")]
        public void insertAdjacentHTML(JsString where, JsString html){}
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public void attachEvent(JsString eventName, HtmlDomEventHandler handler){}
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        ///<param name="useCapture"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void addEventListener(JsString eventName, HtmlDomEventHandler handler, bool useCapture){}
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public void detachEvent(JsString eventName, HtmlDomEventHandler handler){}
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        ///<param name="useCapture"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void removeEventListener(JsString eventName, HtmlDomEventHandler handler, bool useCapture){}
        ///<summary>
        ///Fires a specified event on the object.
        ///</summary>
        ///<param name="sEvent">String that specifies the name of the event to fire.</param>
        ///<param name="oEventObject">Object that specifies the event object from which to obtain event object properties.</param>
        [JsMethod(NativeOverloads = true)]
        public void fireEvent(JsString sEvent, HtmlDomEventArgs oEventObject){}
        ///<summary>
        ///Fires a specified event on the object.
        ///</summary>
        ///<param name="sEvent">String that specifies the name of the event to fire.</param>
        [JsMethod(NativeOverloads = true)]
        public void fireEvent(JsString sEvent){}
        ///<summary>
        ///Retrieves a collection of rectangles that describes the layout of the contents of an object or range within the client. Each rectangle describes a single line. 
        ///</summary>
        ///<returns>Returns the TextRectangle collection. Each rectangle has four integer properties (top, left, right, and bottom) that each represent a coordinate of the rectangle, in pixels.</returns>
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Opera9|BrowserTypes.Opera10, @"IE5-7 returns far too many rectangles for the first test paragraphs. The correct number is 5 (for 5 lines), but IE5.5 returns 9 and IE6/7 14. IE8b2 gets this right.
Furthermore, IE5-7 also split up a block-level element such as a <p> into one rectangle per line. This is incorrect: a block-level element should be reported as one rectangle.
Finally, in IE 5-7 the rectangles are off by about two pixels.", PartiallySupportedRemark = @"Firefox doesn't round the top/bottom coordinates.")]
        public HtmlTextRectangleCollection getClientRects(){return default(HtmlTextRectangleCollection);}
        ///<summary>
        ///Specifies that an element cannot be selected.
        ///</summary>
        public JsString unselectable{get;set;}
        ///<summary>
        ///Sets or retrieves the JsString identifying the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString id{get;set;}
        ///<summary>
        ///Retrieves an autogenerated, unique identifier for the object. 
        ///</summary>
        public JsString uniqueID{get;set;}
        ///<summary>
        ///Sets or retrieves the JsString that indicates whether the user can edit the content of the object.
        ///</summary>
        public JsString contentEditable{get;set;}
        ///<summary>
        ///Retrieves a reference to the last child in the childNodes collection of an object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNode lastChild{get;set;}
        ///<summary>
        ///Retrieves a reference to the container object that defines the offsetTop and offsetLeft properties of the object.
        ///</summary>
        public HtmlElement offsetParent{get;set;}
        ///<summary>
        ///Sets or retrieves the distance between the left edge of the object and the leftmost portion of the content currently visible in the window. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber scrollLeft{get;set;}
        ///<summary>
        ///Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber scrollTop{get;set;}
        ///<summary>
        ///Retrieves the calculated left position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber offsetLeft{get;set;}
        ///<summary>
        ///Retrieves the calculated top position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"When calculating offsetTop, IE5-7 does not count elements with position: relative as offsetParents, and moves on to the next offsetParent in the chain. offsetLeft is calculated correctly.")]
        public JsNumber offsetTop{get;set;}
        ///<summary>
        ///Retrieves the width of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber offsetWidth{get;set;}
        ///<summary>
        ///Retrieves the height of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        ///<remarks>When overflowY is Scroll, this is the physical height of the control, which is clientHeight + Vscrollbar size</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber offsetHeight{get;set;}
        ///<summary>
        ///Retrieves the distance between the offsetTop property and the true top of the client area.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public JsNumber clientTop{get;set;}
        ///<summary>
        ///Retrieves the distance between the offsetLeft property and the true left side of the client area.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public JsNumber clientLeft{get;set;}
        ///<summary>
        ///Retrieves the width of the object including padding, but not including margin, border, or scroll bar.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber clientWidth{get;set;}
        ///<summary>
        ///Retrieves the height of the object including padding, but not including margin, border, or scroll bar.
        ///</summary>
        ///<remarks>When overflowY is Scroll, this is the physical displayed height of the children w/o the scrollbar</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber clientHeight{get;set;}
        ///<summary>
        ///Retrieves the scrolling width of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57, @"When the element has no scrollbars IE makes the scrollHeight equal to the actual height of the content; and not the height of the element. scrollWidth is correct, except in IE8, where it’s 5 pixels off.
Opera gives odd, incorrect values.")]
        public JsNumber scrollWidth{get;set;}
        ///<summary>
        ///Gets the namespace defined for the element.
        ///</summary>
        public JsString scopeName{get;set;}
        ///<summary>
        ///Retrieves the ordinal position of the object, in source order, as the object appears in the document's all collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber sourceIndex{get;set;}
        ///<summary>
        ///Retrieves the scrolling height of the object. 
        ///</summary>
        ///<remarks>When overflowY is Scroll, this is the virtual height of the scrollable region (without scrolling, this would be the physical height of the element)</remarks>
        public JsNumber scrollHeight{get;set;}
        ///<summary>
        ///Retrieves the document object associated with the node.
        ///</summary>
        public HtmlDocument document{get;set;}
        ///<summary>
        ///Retrieves a collection of HTML Elements and TextNode objects that are direct descendants of the specified object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNodeCollection childNodes{get;set;}
        ///<summary>
        ///Sets or retrieves advisory information (a ToolTip) for the object. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Safari 3.0 does’t show the title of an element in any way, so its compatibility is mostly untestable. However, the title property gets its value from the title attribute, so it works to some extent.")]
        public JsString title{get;set;}
        ///<summary>
        ///Sets or retrieves the HTML between the start and end tags of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, @"In IE and Konqueror innerHTML does not work correctly when you update tables. Solve this by using pure DOM methods instead. 
If you remove elements through innerHTML in IE, their content is wiped and only the element itself (i.e. opening and closing tags) remain. If you want to remove nodes that you may want to reinsert at a later time, use DOM methods such as removeChild().")]
        public JsString innerHTML{get;set;}
        ///<summary>
        ///Sets or retrieves the text between the start and end tags of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Use document.createTextNode() and appendChild() in any browser, or textContent in FireFox")]
        public JsString innerText{get;set;}
        ///<summary>
        ///Sets or retrieves the text between the start and end tags of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Use innerText in IE")]
        public JsString textContent{get;set;}
        ///<summary>
        ///Sets or retrieves the index that defines the tab order for the object.
        ///</summary>
        public JsNumber tabIndex{get;set;}
        ///<summary>
        ///Sets or gets the Uniform Resource Name (URN) specified in the namespace declaration.
        ///</summary>
        public JsString tagUrn{get;set;}
        ///<summary>
        ///Sets an inline style for the element.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElementStyle style{get;set;}
        ///<summary>
        ///Returns the current (calculated) style of the element
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Opera9|BrowserTypes.Opera10, @"Use getComputedStyle()")]
        public HtmlElementStyle currentStyle{get;set;}
        [JsProperty(NativeIndexer = true)]
        public object this[JsString name]{get{return default(object);}set{}}
        ///<summary>
        ///Sets or retrieves the class of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString className{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates whether the user can interact with the object.
        ///</summary>
        public bool disabled{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates the reading order of the object.
        ///Possible values:
        ///ltr		Default. Content flows from left to right.
        ///rtl		Content flows from right to left.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Opera9|BrowserTypes.Opera10, @"If the last character on a line is an interpunction character, IE, Safari, Chrome and Konqueror move it to the start of the line.")]
        public JsString dir{get;set;}
        ///<summary>
        ///Sets or retrieves the language to use.
        ///</summary>
        public JsString lang{get;set;}
        ///<summary>
        ///Retrieves the tag name of the object. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"In IE (all versions) the tagName of a comment node is !. 
Use nodeName instead.")]
        public JsString tagName{get;set;}
        ///<summary>
        ///Retrieves the parent object in the document hierarchy.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Use parentNode")]
        public HtmlElement parentElement{get;set;}
        ///<summary>
        ///Appends an element as a child to the object.
        ///</summary>
        ///<param name="child"></param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void appendChild(HtmlNode child){}
        ///<summary>
        ///Removes a child node from the object.
        ///</summary>
        ///<param name="oNode">Object that specifies the element to be removed from the document.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void removeChild(HtmlNode oNode){}
        ///<summary>
        ///Sets the mouse capture to the object that belongs to the current document. 
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public void setCapture(){}
        /// <summary>
        /// Sets the mouse capture to the object that belongs to the current document. 
        /// </summary>
        /// <param name="containerCapture">A Boolean that specifies one of the following values. true Default. Events originating in a container are captured by the container. 
        ///false Events originating in a container are not captured by the container 
        ///</param>
        [JsMethod(NativeOverloads = true)]
        public void setCapture(bool containerCapture){}
        ///<summary>
        ///Removes mouse capture from the object in the current document.
        ///</summary>
        public void releaseCapture(){}
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
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9, NotSupportedRemark = "Use insertBefore() or appendChild()")]
        public void insertAdjacentElement(JsString sWhere, HtmlElement oElement){}
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void insertBefore(HtmlNode newNode){}
        [JsMethod(NativeOverloads = true)]
        public void insertBefore(HtmlNode newNode, HtmlNode child){}
        ///<summary>
        ///Retrieves a reference to the first child in the childNodes collection of the object. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNode firstChild{get{return default(HtmlNode);}
        }
        ///<summary>
        ///Sets or retrieves the text of the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public JsString outerText{get;set;}
        ///<summary>
        ///Sets or retrieves the object and its content in HTML.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public JsString outerHTML{get;set;}
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
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9, NotSupportedRemark = "Use document.createTextNode() and insertBefore()")]
        public void insertAdjacentText(JsString sWhere, JsString sText){}
        ///<summary>
        ///Removes the object from the document hierarchy.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public void removeNode(){}
        ///<summary>
        ///Removes the object from the document hierarchy.
        ///</summary>
        ///<param name="bRemoveChildren">A Boolean that specifies one of the following values. </param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public void removeNode(bool bRemoveChildren){}
        ///<summary>
        ///Causes the element to lose focus and fires the onblur event.
        ///</summary>
        public void blur(){}
        ///<summary>
        ///Retrieves a collection of attributes of the object.
        ///</summary>
        public HtmlAttributeCollection attributes{get;set;}
        ///<summary>
        ///Sets the value of the specified attribute 
        ///</summary>
        ///<param name="name">String that specifies the name of the attribute.</param>
        ///<param name="value">Variant that specifies the JsString, number, or Boolean to assign to the attribute.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"IE5-7 doesn't set styles and removes events when you try to set them.")]
        public void setAttribute(JsString name, object value){}
        ///<summary>
        ///Copies a reference to the object from the document hierarchy. 
        ///</summary>
        ///<param name="includeChildren">Boolean that specifies one of the following values:
        ///FALSE Cloned objects do not include childNodes. 
        ///TRUE Cloned objects include childNodes. </param>
        ///<returns>Returns a reference to the newly created node.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement cloneNode(bool includeChildren){return default(HtmlElement);}
        ///<summary>
        ///Copies a reference to the object from the document hierarchy. 
        ///</summary>
        ///<returns>Returns a reference to the newly created node.</returns>
        [JsMethod(NativeOverloads = true)]
        public HtmlElement cloneNode(){return default(HtmlElement);}
        ///<summary>
        ///Causes the element to receive the focus and executes the code specified by the onfocus event. 
        ///</summary>
        public void focus(){}
        ///<summary>
        ///Causes the object to scroll into view, aligning it either at the top or bottom of the window. 
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public void scrollIntoView(){}
        ///<summary>
        ///Causes the object to scroll into view, aligning it either at the top or bottom of the window. 
        ///</summary>
        ///<param name="alignToTop">Boolean that specifies one of the following values: 
        ///true Default. Scrolls the object so that top of the object is visible at the top of the window. 
        ///false Scrolls the object so that the bottom of the object is visible at the bottom of the window </param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari iPhone handles the Y-coordinate correctly, but it also scrolls to the left edge of the page, which can make this method hard to use when the user has zoomed in.")]
        public void scrollIntoView(bool alignToTop){}
        ///<summary>
        ///Sets the object as active without setting focus to the object.
        ///</summary>
        public void setActive(){}
        ///<summary>
        ///Puts the specified node and all of its subtree into a "normalized" form. In a normalized subtree, no text nodes in the subtree are empty and there are no adjacent text nodes.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void normalize(){}
        ///<summary>
        ///Creates an attribute object with a specified name.
        ///</summary>
        ///<param name="sName">A String that sets the attribute object's name.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlAttribute createAttribute(JsString sName){return default(HtmlAttribute);}
        ///<summary>
        ///Sets an attribute object node as part of the object.
        ///</summary>
        ///<param name="oSrcAttribute">attribute object to be assigned.</param>
        ///<returns>
        ///Returns a reference to the removed attribute object.
        ///</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, "IE6-7 gives null for style values.")]
        public HtmlAttribute setAttributeNode(HtmlAttribute oSrcAttribute){return default(HtmlAttribute);}
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
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"In IE5-7, accessing the style attribute gives an object, and accessing the onclick attribute gives an anonymous function wrapped around the actual content.")]
        public object getAttribute(JsString sAttrName, JsNumber iFlags){return default(object);}
        ///<summary>
        ///Retrieves the value of the specified attribute.
        ///</summary>
        ///<param name="sAttrName">String that specifies the name of the attribute.</param>
        ///<returns>Variant that returns a String, Integer, or Boolean value as defined by the attribute. If the attribute is not present, this method returns null.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"In IE5-7, accessing the style attribute gives an object, and accessing the onclick attribute gives an anonymous function wrapped around the actual content.")]
        public object getAttribute(JsString sAttrName){return default(object);}
        ///<summary>
        ///Retrieves an attribute object referenced by the attribute.name property.
        ///</summary>
        ///<param name="sName">String that specifies the name property of the requested attribute object.</param>
        ///<returns>Returns a reference to an attribute object.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"IE 6/7 don't allow you to access the value of x.getAttributeNode('style').")]
        public HtmlAttribute getAttributeNode(JsString sName){return default(HtmlAttribute);}
        ///<summary>
        ///Determines whether an attribute with the specified name exists.
        ///</summary>
        ///<param name="sAttrName">String that specifies the name of the attribute.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public bool hasAttribute(JsString sAttrName){return default(bool);}
        ///<summary>
        ///returns a boolean value of true or false, indicating if the current element has any attributes or not.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public bool hasAttributes(){return default(bool);}
        ///<summary>
        ///Removes an attribute object from the object.
        ///</summary>
        ///<param name="oSrcAttribute">attribute object to be removed.</param>
        ///<remarks>Returns a reference to the removed attribute object.</remarks>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"IE 6 does't remove anything, but doesn't give an error message either.
IE 7 doesn't remove styles and event handlers.
Opera doesn't remove event handlers.
Konqueror doesn't remove the align attribute.")]
        public HtmlAttribute removeAttributeNode(JsString oSrcAttribute){return default(HtmlAttribute);}
        ///<summary>
        ///Makes the element either a child or parent of another element.
        ///</summary>
        ///<param name="oNewElement">An object that becomes the child or parent of the current element.</param>
        ///<param name="oWhere">A String that specifies one of the following values.
        ///outside - Default. Specified element becomes a parent of the current element.
        ///inside - Specified element becomes a child of the current element, but contains all the child elements of the current element.
        ///</param>
        ///<returns>Returns a reference to the applied element.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlElement applyElement(HtmlElement oNewElement, JsString oWhere){return default(HtmlElement);}
        ///<summary>
        ///Makes the element either a child or parent of another element.
        ///</summary>
        ///<param name="oNewElement">An object that becomes the child or parent of the current element.</param>
        ///<returns>Returns a reference to the applied element.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlElement applyElement(HtmlElement oNewElement){return default(HtmlElement);}
        ///<summary>
        ///Removes all attributes and values from the object.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.None, NotSupportedRemark = @"IE doesn't clear event handlers and inline styles.")]
        public void clearAttributes(){}
        ///<summary>
        ///Copies all read/write attributes to the specified element.
        ///</summary>
        ///<param name="oSource">Pointer to an Object that specifies the attributes copied to the object that invokes mergeAttributes.</param>
        ///<param name="bPreserve">Available as of Microsoft Internet Explorer 5.5. Pointer to a Boolean that specifies one of the following values:
        ///true - Default. Preserve the identity of the object to which attributes are being merged.
        ///false - Do not preserve the identity of the object to which attributes are being merged.
        ///</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public void mergeAttributes(JsString oSource, bool bPreserve){}
        ///<summary>
        ///Copies all read/write attributes to the specified element.
        ///</summary>
        ///<param name="oSource">Pointer to an Object that specifies the attributes copied to the object that invokes mergeAttributes.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public void mergeAttributes(JsString oSource){}
        ///<summary>
        ///Replaces the object with another element.
        ///</summary>
        ///<param name="oNewNode">An Object that specifies the new element to replace the object.</param>
        ///<returns>Returns a reference to the object that is replaced.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlNode replaceNode(HtmlNode oNewNode){return default(HtmlNode);}
        ///<summary>
        ///Exchanges the location of two objects in the document hierarchy.
        ///</summary>
        ///<param name="oNode">Object that specifies the existing element.</param>
        ///<returns>Returns a reference to the object that invoked the method.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlNode swapNode(HtmlNode oNode){return default(HtmlNode);}
        ///<summary>
        ///Returns the number of element children
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber childElementCount{get;set;}
        ///<summary>
        ///Returns the first child that is an element node
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement firstElementChild{get;set;}
        ///<summary>
        ///Returns the last child that is an element node
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement lastElementChild{get;set;}
        ///<summary>
        ///Returns the next element node sibling
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement nextElementSibling{get;set;}
        ///<summary>
        ///Returns the previous  element node sibling
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement previousElementSibling{get;set;}
        ///<summary>
        ///Returns an object that contains the top, left, right, and bottom (all relative to the top left of the viewport) of the combined rectangle of element x. Essentially, the browser calculates all rectangles (see below getClientRects()), and getBoundingClientRect() returns the lowest (top, left) or highest (bottom, right) values found.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Opera9|BrowserTypes.Opera10, PartiallySupportedRemark = "Firefox doesn't round the top/bottom coordinates.")]
        public HtmlTextRectangle getBoundingClientRect(){return default(HtmlTextRectangle);}
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onclick;
        ///<summary>
        ///Fires when the user clicks the right mouse button in the client area, opening the context menu.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5, PartiallySupportedRemark = @"To prevent the default in Firefox 3 you have to cancel the event bubbling.")]
        public HtmlDomEventHandler oncontextmenu;
        ///<summary>
        ///Fires when the user is about to make a control selection of the object.
        ///</summary>		
        public HtmlDomEventHandler oncontrolselect;
        ///<summary>
        ///Fires on the source element when the user copies the object or selection, adding it to the system clipboard.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5, PartiallySupportedRemark = @"Firefox 3 has a lazy implementation.")]
        public HtmlDomEventHandler oncopy;
        ///<summary>
        ///Fires on the source element when the object or selection is removed from the document and added to the system clipboard.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5, PartiallySupportedRemark = @"Firefox 3 has a lazy implementation.")]
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"The keydown event does not repeat in Opera and Konqueror.
You cannot prevent the default onkeydown in Opera.")]
        public HtmlDomEventHandler onkeydown;
        ///<summary>
        ///Fires when the user presses an alphanumeric key.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = "Firefox, Safari 3.0, Opera and Konqueror fire keypress events on any key. (The specification requires this event to be fired only if a keystroe leads to a character actually being added to an HTML element such as a text input.)")]
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onmousedown;
        ///<summary>
        ///Fires when the user moves the mouse over the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onmousemove;
        ///<summary>
        ///Fires when the user moves the mouse pointer outside the boundaries of the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onmouseout;
        ///<summary>
        ///Fires when the user moves the mouse pointer into the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onmouseover;
        ///<summary>
        ///Fires when the user releases a mouse button while the mouse is over the object.
        ///</summary>		
        public HtmlDomEventHandler onmouseup;
        ///<summary>
        ///Fires when the wheel button is rotated.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5, @"Firefox 3 has a lazy implementation.")]
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari probably monitors scrollTop access in order to determine whether the user has scrolled an element with overflow: auto.")]
        public HtmlDomEventHandler onscroll;
        ///<summary>
        ///Fires when the object is being selected.
        ///</summary>		
        public HtmlDomEventHandler onselectstart;
        ///<summary>
        ///Fires when the object is set as the active element.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlDomEventHandler onactivate;
        ///<summary>
        ///Fires on the source object before the selection is copied to the system clipboard.		
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3_1Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5)]
        public HtmlDomEventHandler onbeforecopy;
        ///<summary>
        ///Fires on the source object before the selection is deleted from the document.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3_1Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5)]
        public HtmlDomEventHandler onbeforecut;
        ///<summary>
        ///Fires on the target object before the selection is pasted from the system clipboard to the document.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3_1Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5, PartiallySupportedRemark = @"Safari 3.1 and Chrome do not fire this event before an actual paste action. It works fine on context menus.")]
        public HtmlDomEventHandler onbeforepaste;
        ///<summary>
        ///Fires when the activeElement is changed from the current object to another object in the parent document.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlDomEventHandler ondeactivate;
        ///<summary>
        ///Fires for an element just prior to setting focus on that element.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlDomEventHandler onfocusin;
        ///<summary>
        ///Fires for the current element with focus immediately after moving focus to another element.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlDomEventHandler onfocusout;
        ///<summary>
        ///Raised when there are changes to the portion of a URL that follows the number sign (#).
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlDomEventHandler onhashchange;
        ///<summary>
        ///Fires when the user moves the mouse pointer into the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlDomEventHandler onmouseenter;
        ///<summary>
        ///Fires when the user moves the mouse pointer outside the boundaries of the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlDomEventHandler onmouseleave;
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public NodeList getElementsByClassName(JsString classNames){return default(NodeList);}
        [HtmlSpecificationVersion(5)]
        public DOMTokenList classList{get;set;}
        [HtmlSpecificationVersion(5)]
        public DOMStringMap dataset{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool itemScope{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString itemType{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString itemId{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString itemRef{get;set;}
        [HtmlSpecificationVersion(5)]
        public DOMSettableTokenList itemProp{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlPropertiesCollection properties{get;set;}
        [HtmlSpecificationVersion(5)]
        public object itemValue{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool hidden{get;set;}
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void click(){}
        public JsString accessKey{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString accessKeyLabel{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool draggable{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool isContentEditable{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlMenuElement contextMenu{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString spellcheck{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString commandType{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString label{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString icon{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool @checked{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onabort{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncanplay{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncanplaythrough{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondurationchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onemptied{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onended{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onerror{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onformchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onforminput{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oninput{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oninvalid{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onload{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadeddata{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadedmetadata{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadstart{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpause{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onplay{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onplaying{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onprogress{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onratechange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onseeked{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onseeking{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onselect{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onshow{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onstalled{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onsubmit{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onsuspend{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ontimeupdate{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onvolumechange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onwaiting{get;set;}
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
        public object this[JsString s]{get{return default(object);}set{}}
        /// <summary>
        /// Sets or retrieves a value indicating how to manage the content of the object when the content exceeds the height or width of the object.
        ///	String that specifies or receives one of the following values.
        ///	visible		Default. Content is not clipped and scroll bars are not added. 
        ///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
        ///	hidden		Content that exceeds the dimensions of the object is not shown.
        ///	auto			Content is clipped and scrolling is added only when necessary.
        /// </summary>		
        public JsString overflow{get;set;}
        /// <summary>
        /// Sets or retrieves how to manage the content of the object when the content exceeds the width of the object.
        ///	String that specifies or receives one of the following values.
        ///	visible		Default. Content is not clipped and scroll bars are not added. Elements are clipped to the size of the containing window or frame.
        ///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
        ///	hidden		Content that exceeds the dimensions of the object is not shown.
        ///	auto			Content is clipped and scrolling is added only when necessary.
        /// </summary>		
        public JsString overflowX{get;set;}
        /// <summary>
        /// Sets or retrieves how to manage the content of the object when the content exceeds the height of the object.		
        ///	String that specifies or receives one of the following values.
        ///	visible		Default. Content is not clipped and scroll bars are not added. Elements are clipped to the size of the containing window or frame.
        ///	scroll		Content is clipped and scroll bars are added, even if the content does not exceed the dimensions of the object.
        ///	hidden		Content that exceeds the dimensions of the object is not shown.
        ///	auto			Content is clipped and scrolling is added only when necessary.
        /// </summary>
        public JsString overflowY{get;set;}
        /// <summary>
        /// Sets or retrieves the type of positioning used for the object. 
        ///	String that specifies or receives one of the following values.
        ///	static		Default. Object has no special positioning; it follows the layout rules of HTML.
        ///	absolute	Object is positioned relative to parent element's position—or to the body object if its parent element is not positioned—using the top and left properties.
        ///	relative	Object is positioned according to the normal flow, and then offset by the top and left properties.
        ///	fixed			Windows Internet Explorer 7 and later. Object is positioned relative to the viewport containing the content.
        /// </summary>
        public JsString position{get;set;}
        ///<summary>
        ///Sets or retrieves the left position of the object. 
        ///</summary>
        public JsNumber pixelLeft{get;set;}
        ///<summary>
        ///Sets or retrieves the top position of the object. 
        ///</summary>
        public JsNumber pixelTop{get;set;}
        ///<summary>
        ///Opacity (supported by Mozilla Gecko and Apple WebKit)
        ///</summary>
        public double opacity{get;set;}
        ///<summary>
        ///Sets or retrieves the height of the object in the units specified by the height attribute. 
        ///</summary>
        public JsNumber pixelHeight{get;set;}
        ///<summary>
        ///Sets or retrieves the width of the object. 
        ///</summary>
        public JsNumber pixelWidth{get;set;}
        ///<summary>
        ///Sets or retrieves the height of the object. 
        ///String that specifies or receives one of the following values.
        ///auto				Default.  
        ///height			Floating-point number followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer followed by a percent sign (%). The value is a percentage of the height of the parent object, which must be specified explicitly. Negative values are not allowed.
        ///</summary>
        public JsString height{get;set;}
        ///<summary>
        ///Sets or retrieves the width of the object. 
        ///String that specifies or receives one of the following values.
        ///auto				Default. Default width of the object.
        ///width				Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units.
        ///percentage	Integer, followed by a %. The value is a percentage of the width of the parent object, whether or not it is specified explicitly. Negative values are not allowed.
        ///</summary>
        public JsString width{get;set;}
        ///<summary>
        ///Sets or retrieves the persisted representation of the style rule.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString cssText{get;set;}
        ///<summary>
        ///Sets or retrieves whether the content of the object is displayed. 
        ///String that specifies or receives one of the following values.
        ///inherit		Default. Object inherits the visibility of the next parent object.
        ///visible		Object is visible.
        ///hidden		Object is hidden.
        ///collapse  Internet Explorer 8. Used in tables to remove rows and columns; for all other elements, same as hidden.
        ///</summary>
        public JsString visibility{get;set;}
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
        public JsString display{get;set;}
        ///<summary>
        ///Sets or retrieves the position of the object relative to the top of the next positioned object in the document hierarchy. 
        ///String that specifies or receives one of the following values:
        ///auto				Default. Default position according to the regular HTML layout of the page.
        ///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). This value is a percentage of the height of the parent object. 
        ///</summary>
        public JsString top{get;set;}
        ///<summary>
        ///Sets or retrieves the bottom position of the object in relation to the bottom of the next positioned object in the document hierarchy. 
        ///String that specifies or receives one of the following values:
        ///auto				Default. Default position according to the regular HTML layout of the page.
        ///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). This value is a percentage of the height of the parent object. 
        ///</summary>
        public JsString bottom{get;set;}
        ///<summary>
        ///Sets or retrieves the position of the object relative to the left edge of the next positioned object in the document hierarchy. 
        ///String that specifies or receives one of the following values:
        ///auto				Default. Position is determined by the regular HTML layout of the page.
        ///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). The value is a percentage of the width of the parent object.
        ///</summary>
        public JsString left{get;set;}
        ///<summary>
        ///Sets or retrieves the position of the object relative to the right edge of the next positioned object in the document hierarchy.
        ///String that specifies or receives one of the following values:
        ///auto				Default. Position is determined by the regular HTML layout of the page.
        ///length			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). The value is a percentage of the width of the parent object.
        ///</summary>
        public JsString right{get;set;}
        ///<summary>
        ///Sets or retrieves the stacking order of positioned objects. 
        ///String or Integer that specifies or receives one of the following values.
        ///auto. Default. String that specifies the stacking order of the positioned objects based on the order in which the objects appear in the HTML source.
        ///order. Integer that specifies the position of the object in the stacking order.		
        ///</summary>
        public JsString zIndex{get;set;}
        public StyleFilterCollection filters{get;set;}
        ///<summary>
        ///Sets or retrieves the filter or collection of filters applied to the object. 
        ///</summary>
        public JsString filter{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates whether the text in the object has blink, line-through, overline, or underline decorations. 
        ///String that specifies or receives one of the following values.
        ///none					Default. Text has no decoration.
        ///underline			Text is underlined.
        ///overline			Text has a line over it.
        ///line-through	Text has a line drawn through it.
        ///blink					Not implemented.
        ///</summary>
        public JsString textDecoration{get;set;}
        /// <summary>
        /// Sets or retrieves whether the text in the object is left-aligned, right-aligned, centered, or justified. 
        /// String that specifies or receives one of the following values.
        /// left		Default. Text is aligned to the left.
        ///	right		Text is aligned to the right.
        ///	center	Text is centered.
        ///	justify	Text is justified		
        /// </summary>
        public JsString textAlign{get;set;}
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
        public JsString cursor{get;set;}
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
        public JsString verticalAlign{get;set;}
        /// <summary>
        /// Sets or retrieves a JsString that indicates whether the table layout is fixed.
        ///	auto		Default. Column width is set by the widest unbreakable content in the column cells.
        ///	fixed		Table and column widths are set either by the sum of the widths on the col objects or, if these are not specified, by the width of the first row of cells. If no width is specified for the table, it renders by default with width=100%.
        /// </summary>
        public JsString tableLayout{get;set;}
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
        public JsString padding{get;set;}
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
        public JsString whiteSpace{get;set;}
        ///<summary>
        ///Sets or retrieves the foreground color of the object's content. 
        ///</summary>
        public JsString color{get;set;}
        ///<summary>
        ///Sets or retrieves the color behind the content of the object. 
        ///String or Integer that specifies or receives one of the following values.
        ///transparent		Default. Color of the next parent object through which the background is visible.
        ///color					Any color value, including those specified in the Color Table.
        ///</summary>
        public JsString backgroundColor{get;set;}
        /// <summary>
        /// Sets or retrieves the background image of the object. 
        /// String that specifies or receives one of the following values.
        ///	none			Default. Color of the next parent through which the background is visible.
        ///	url(sUrl)	Location of the background image, where sUrl is an absolute or relative URL.
        /// </summary>
        public JsString backgroundImage{get;set;}
        ///<summary>
        ///Sets or retrieves how the backgroundImage property of the object is tiled.
        ///String that specifies or receives one of the following values.
        ///repeat		Default. Image is repeated horizontally and vertically.
        ///no-repeat	Image is not repeated.
        ///repeat-x	Image is repeated horizontally.
        ///repeat-y	Image is repeated vertically.
        ///</summary>
        public JsString backgroundRepeat{get;set;}
        /// <summary>
        /// Sets or retrieves how the background image is attached to the object within the document.
        /// String that specifies or receives one of the following values.
        ///	scroll	Default. Background image scrolls with the object as the document is scrolled.
        ///	fixed		Background image stays fixed within the viewable area of the object.
        /// </summary>
        public JsString backgroundAttachment{get;set;}
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
        public JsString backgroundPosition{get;set;}
        public JsString backgroundPositionX{get;set;}
        public JsString backgroundPositionY{get;set;}
        /// <summary>
        /// Sets or retrieves up to five separate background properties of the object.
        /// String that specifies or receives up to five of the following space-delimited values, in any order:
        ///	color Any of the range of color values available to the backgroundColor property. 
        /// image Any of the range of image values available to the backgroundImage property.
        ///	repeat Any of the range of repeat values available to the backgroundRepeat property.
        ///	attachment Any of the range of attachment values available to the backgroundAttachment property.
        ///	position Any of the range of position values available to the backgroundPosition property.
        /// </summary>
        public JsString background{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates the font size used for text in the object. 
        ///value = String that specifies or receives one of the following values.
        ///absolute-size Set of keywords that indicate predefined font sizes. Named font sizes scale according to the user's font setting preferences. Possible values include the following: xx-small, x-small, small, medium, large, x-large, xx-large.  
        ///relative-size Set of keywords that are interpreted as relative to the font size of the parent object. Possible values include the following: larger, smaller.  
        ///length Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see the CSS Length Units Reference. 
        ///percentage Integer, followed by a percent (%). The value is a percentage of the parent object's font size. In Microsoft Internet Explorer 3.0, the value is calculated as a percentage of the default font size. 
        ///Default - medium (of the absolute-size set).
        ///</summary>
        public JsString fontSize{get;set;}
        ///<summary>
        ///Sets or retrieves the font style of the object as italic, normal, or oblique.
        ///String that specifies or receives one of the following values.
        ///normal Default. Font is normal. 
        ///italic Font is italic. 
        ///oblique Font is italic.  
        ///</summary>
        public JsString fontStyle{get;set;}
        ///<summary>
        ///Sets or retrieves whether the text of the object is in small capital letters.
        ///String that specifies or receives one of the following values.
        ///normal Default. Font is normal. 
        ///small-caps Font is in small capital letters. 
        ///</summary>
        public JsString fontVariant{get;set;}
        ///<summary>
        ///Sets or retrieves the name of the font used for text in the object. 
        ///String that specifies or receives one of the following values.
        ///family-name Any of the available font families supported by the browser. For example, Times, Helvetica, Zapf-Chancery, Western, or Courier. 
        ///generic-name Any of the following font families: serif, sans-serif, cursive, fantasy, or monospace. 
        ///</summary>
        public JsString fontFamily{get;set;}
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
        public JsString fontWeight{get;set;}
        ///<summary>
        ///Sets or retrieves the distance between lines in the object. 
        ///String that specifies or receives one of the following values.
        ///normal			Default. Default height.
        ///height			Floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px). For more information about the supported length units, see CSS Length Units Reference.
        ///percentage	Integer, followed by a percent sign (%). The value is a percentage of the height of the parent object. 
        ///</summary>
        public JsString lineHeight{get;set;}
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
        public JsString font{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates whether the row and cell borders of a table are joined in a single border or detached as in standard HTML.
        ///String that specifies or receives one of the following values.
        ///separate Default. Borders are detached (standard HTML).  
        ///collapse Borders are collapsed, where adjacent, into a single border.  
        ///</summary>
        public JsString borderCollapse{get;set;}
        /// <summary>
        /// Sets or retrieves the properties to draw around the object.
        /// String that specifies or receives one or more of the following space-delimited values:
        ///	width. Any of the range of width values available to the borderWidth property.
        ///	style. Any of the range of style values available to the borderStyle property.
        ///	color. Any of the range of color values available to the borderColor property.
        /// </summary>
        public JsString border{get;set;}
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
        public JsString borderStyle{get;set;}
        /// <summary>
        /// Sets or retrieves the width of the left, right, top, and bottom borders of the object. 
        /// String that specifies or receives up to four of the following values:
        ///	medium. Default.		
        /// thin. Width less than the default.
        /// thick. Width greater than the default.
        /// width. Width consisting of a floating-point number, followed by an absolute units designator (cm, mm, in, pt, or pc) or a relative units designator (em, ex, or px)
        /// </summary>
        public JsString borderWidth{get;set;}
        /// <summary>
        /// Sets or retrieves the border color of the object.
        ///	String that specifies or receives one or more of the following space-delimited values:
        /// transparent. Border is transparent.
        /// color. Up to four color names or RGB values in the Color Table. 
        /// </summary>
        public JsString borderColor{get;set;}
        ///<summary>
        ///Returns the optional priority, "important".
        ///</summary>
        ///<param name="propertyName">property name</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString getPropertyPriority(JsString propertyName){return default(JsString);}
        ///<summary>
        ///Returns the property value.
        ///</summary>
        ///<param name="propertyName">property name</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString getPropertyValue(JsString propertyName){return default(JsString);}
        ///<summary>
        ///Sets the property value.
        ///</summary>
        ///<param name="propertyName">property name</param>
        ///<param name="value">value</param>
        ///<param name="priority">'important' or null</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString setProperty(JsString propertyName, JsString value, JsString priority){return default(JsString);}
        ///<summary>
        ///Removed a declaration from a stylesheet
        ///</summary>
        ///<param name="propertyName">property name</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57, @"Opera refuses to remove the last remaining property of a rule.")]
        public void removeProperty(JsString propertyName){}
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
        public new HtmlDomEventHandler onload;
        [HtmlSpecificationVersion(5)]
        public JsString src{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString width{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString height{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString align{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
    }
    #endregion
    #region HtmlFieldSet
    [JsType(JsMode.Prototype, Export = false, Name = "FIELDSET")]
    public partial class HtmlFieldSet : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves how the object is aligned with adjacent text.
        ///</summary>
        public JsString align{get;set;}
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlFormControlsCollection elements{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool willValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public ValidityState validity{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString validationMessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setCustomValidity(JsString error){}
    }
    #endregion
    #region HtmlFontElement
    ///<summary>
    ///User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLFontElement")]
    public abstract partial class HtmlFontElement : HtmlElement
    {
        public JsString color{get;set;}
        public JsString face{get;set;}
        public JsString size{get;set;}
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
        public JsString acceptCharset{get;set;}
        ///<summary>
        ///Sets or retrieves the number of objects in a collection.
        ///</summary>
        public JsNumber length{get;set;}
        ///<summary>
        ///Sets or retrieves the URL to which the form content is sent for processing.
        ///</summary>
        public JsString action{get;set;}
        ///<summary>
        ///Sets or retrieves how to send the form data to the server.
        ///Receives one of the following values:
        ///<list type="table">
        ///<item><term>GET</term><description>Append the arguments to the action URL and open it as if it were an anchor.</description></item>
        ///<item><term>POST</term><description>Send the data through an HTTP post transaction.</description></item>
        ///</list>
        ///</summary>
        public JsString method{get;set;}
        ///<summary>
        ///Submits the form.
        ///</summary>
        public void submit(){}
        ///<summary>
        ///Fires when the user resets a form.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onreset;
        ///<summary>
        ///Fires when a FORM is about to be submitted.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public new HtmlDomEventHandler onsubmit;
        [HtmlSpecificationVersion(5)]
        public bool autocomplete{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString enctype{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool noValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString target{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlFormControlsCollection elements{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public object item(ulong index){return default(object);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public object namedItem(JsString name){return default(object);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void reset(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void dispatchFormInput(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void dispatchFormChange(){}
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
        public new HtmlDomEventHandler onload;
        public JsString frameBorder{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString longDesc{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString marginHeight{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString marginWidth{get;set;}
        public JsString name{get;set;}
        public bool noResize{get;set;}
        public JsString scrolling{get;set;}
        public JsString src{get;set;}
        public Document contentDocument{get;set;}
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
        public new HtmlDomEventHandler onload;
        ///<summary>
        ///Fires immediately before the object is unloaded.
        ///</summary>		
        public HtmlDomEventHandler onunload;
        [HtmlSpecificationVersion(5)]
        public JsString cols{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString rows{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmessage{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onoffline{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ononline{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpagehide{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpageshow{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpopstate{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onredo{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onstorage{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onundo{get;set;}
    }
    #endregion
    #region HtmlHead
    ///<summary>
    ///Represents the HEAD element of a HTML document
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HEAD")]
    public partial class HtmlHead : HtmlElement
    {
        internal  HtmlHead(){}
        [HtmlSpecificationVersion(5)]
        public JsString profile{get;set;}
    }
    #endregion
    #region HtmlHeadingElement
    ///<summary>
    ///These elements represent headings for their sections.User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLHeadingElement")]
    public abstract partial class HtmlHeadingElement : HtmlElement
    {
        public JsString align{get;set;}
    }
    #endregion
    #region HtmlHorizontalRule
    ///<summary>
    ///Draws a horizontal rule.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HORIZONTALRULE")]
    public partial class HtmlHorizontalRule : HtmlElement
    {
        internal  HtmlHorizontalRule(){}
        public JsString align{get;set;}
        public JsString color{get;set;}
        public bool noShade{get;set;}
        public JsString size{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString width{get;set;}
    }
    #endregion
    #region HtmlHtmlElement
    ///<summary>
    ///The html element represents the root of an HTML document.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLHtmlElement")]
    public abstract partial class HtmlHtmlElement : HtmlElement
    {
        public JsString version{get;set;}
    }
    #endregion
    #region HtmlIFrame
    ///<summary>
    ///Creates inline floating frames. 
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "IFRAME")]
    public partial class HtmlIFrame : HtmlElement
    {
        internal  HtmlIFrame(){}
        public JsString readyState{get{return default(JsString);}
        }
        /// <summary>
        /// Sets or retrieves whether to display a border for the frame.
        /// Possible values:
        ///	1		Default. Inset border is drawn.
        /// 0		No border is drawn.
        /// no		No border is drawn.
        /// yes		Inset border is drawn.
        /// </summary>
        public JsString frameBorder{get;set;}
        ///<summary>
        ///Sets or retrieves a URL to be loaded by the object.
        ///</summary>
        public JsString src{get;set;}
        ///<summary>
        ///Sets or retrieves whether the object can be transparent.
        ///</summary>
        public bool allowTransparency{get;set;}
        ///<summary>
        ///Sets or retrieves the space between the frames, including the 3-D border. 
        ///</summary>
        public JsString border{get;set;}
        ///<summary>
        ///Sets or retrieves the top and bottom margin heights before displaying the text in a frame. 
        ///</summary>
        public JsNumber marginHeight{get;set;}
        ///<summary>
        ///Sets or retrieves the left and right margin widths before displaying the text in a frame. 
        ///</summary>
        public JsNumber marginWidth{get;set;}
        ///<summary>
        ///Sets or retrieves the height of the object. 
        ///</summary>
        public JsString height{get;set;}
        ///<summary>
        ///Sets or retrieves the width of the object. 
        ///</summary>
        public JsString width{get;set;}
        ///<summary>
        ///Sets or retrieves the vertical margin for the object. 
        ///</summary>
        public JsNumber vspace{get;set;}
        ///<summary>
        ///Sets or retrieves whether the frame can be scrolled.
        ///</summary>
        public JsString scrolling{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates the table alignment.
        ///</summary>
        public JsString align{get;set;}
        ///<summary>
        ///Retrieves the window object of the specified frame or iframe.
        ///</summary>
        public HtmlWindow contentWindow{get;set;}
        ///<summary>
        ///Sets or retrieves the amount of additional space between the frames.
        ///</summary>
        public JsString frameSpacing{get;set;}
        ///<summary>
        ///Sets or retrieves the horizontal margin for the object.
        ///</summary>
        public JsString hspace{get;set;}
        ///<summary>
        ///Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
        ///</summary>
        public JsString longDesc{get;set;}
        ///<summary>
        ///Sets or retrieves the frame name.
        ///</summary>
        public JsString name{get;set;}
        ///<summary>
        ///Sets or retrieves whether the user can resize the frame.
        ///</summary>
        public bool noResize{get;set;}
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public new HtmlDomEventHandler onload;
        [HtmlSpecificationVersion(5)]
        public JsString sandbox{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool seamless{get;set;}
        [HtmlSpecificationVersion(5)]
        public Document contentDocument{get;set;}
    }
    #endregion
    #region HtmlImage
    ///<summary>
    ///Embeds an image or a video clip in the document.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Image")]
    public partial class HtmlImage : HtmlElement
    {
        public void main(){}
        ///<summary>
        ///Sets or retrieves how the object is aligned with adjacent text.
        ///</summary>
        public JsString align{get;set;}
        ///<summary>
        ///Sets or retrieves a text alternative to the graphic.
        ///</summary>
        public JsString alt{get;set;}
        ///<summary>
        ///Sets the properties to draw around the object.
        ///</summary>
        public JsString border{get;set;}
        ///<summary>
        ///Sets the height of the object.
        ///</summary>
        public JsString height{get;set;}
        ///<summary>
        ///Sets the horizontal margin for the object.
        ///</summary>
        public JsNumber hspace{get;set;}
        ///<summary>
        ///Sets a URL to be loaded by the object.
        ///</summary>
        public JsString src{get;set;}
        ///<summary>
        ///Sets the URL, often with a bookmark extension (#name), to use as a client-side image map.
        ///</summary>
        public JsString usemap{get;set;}
        ///<summary>
        ///Sets the vertical margin for the object.
        ///</summary>
        public JsNumber vspace{get;set;}
        ///<summary>
        ///Sets the width of the object.
        ///</summary>
        public JsString width{get;set;}
        ///<summary>
        ///Retrieves whether the object is fully loaded.
        ///</summary>
        public JsString complete{get;set;}
        ///<summary>
        ///Retrieves the date the file was created.
        ///</summary>
        public JsDate fileCreatedDate{get;set;}
        ///<summary>
        ///Retrieves the date the file was last modified.
        ///</summary>
        public JsDate fileModifiedDate{get;set;}
        ///<summary>
        ///Retrieves the file size.
        ///</summary>
        public JsNumber fileSize{get;set;}
        ///<summary>
        ///Retrieves the date the file was last updated.
        ///</summary>
        public JsDate fileUpdatedDate{get;set;}
        ///<summary>
        ///Sets or retrieves a destination URL or an anchor point.
        ///</summary>
        public JsString href{get;set;}
        ///<summary>
        ///Sets or retrieves whether the image is a server-side image map.
        ///</summary>
        public JsString isMap{get;set;}
        ///<summary>
        ///Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
        ///</summary>
        public JsString longDesc{get;set;}
        ///<summary>
        ///Sets or retrieves the number of times a sound or video clip will loop when activated.
        ///</summary>
        public JsString loop{get;set;}
        ///<summary>
        ///Sets or retrieves a lower resolution image to display.
        ///</summary>
        public JsString lowsrc{get;set;}
        ///<summary>
        ///Retrieves the file name specified in the href or src property of the object.
        ///</summary>
        public JsString nameProp{get;set;}
        ///<summary>
        ///Sets or retrieves the protocol portion of a URL.
        ///</summary>
        public JsString protocol{get;set;}
        ///<summary>
        ///Sets or retrieves when a video clip file should begin playing.
        ///</summary>
        public JsString start{get;set;}
        ///<summary>
        ///Sets or retrieves the URL of the virtual reality modeling language (VRML) world to be displayed in the window.
        ///</summary>
        public JsString vrml{get;set;}
        ///<summary>
        ///Fires when the user aborts the download of an image.
        ///</summary>		
        public new HtmlDomEventHandler onabort;
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public new HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public new HtmlDomEventHandler onload;
        [HtmlSpecificationVersion(5)]
        public JsString useMap{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong naturalWidth{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong naturalHeight{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
    }
    #endregion
    #region HtmlInputCheckBox
    [JsType(JsMode.Prototype, Export = false, Name = "INPUTCHECKBOX")]
    public partial class HtmlInputCheckBox : HtmlInput
    {
        internal  HtmlInputCheckBox(){}
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
        public JsString accept{get;set;}
        ///<summary>
        ///Sets or retrieves how the object is aligned with adjacent text.
        ///</summary>
        public JsString align{get;set;}
        ///<summary>
        ///Sets or retrieves a text alternative to the graphic.
        ///</summary>
        public JsString alt{get;set;}
        ///<summary>
        ///Sets or retrieves the state of the check box or radio button.
        ///</summary>
        public new bool @checked{get;set;}
        ///<summary>
        ///Retrieves whether the object is fully loaded.
        ///</summary>
        public JsString complete{get;set;}
        ///<summary>
        ///Sets or retrieves the initial contents of the object.
        ///</summary>
        public JsString defaultValue{get;set;}
        ///<summary>
        ///Sets or retrieves the state of the check box or radio button.
        ///</summary>
        public JsString defaultChecked{get;set;}
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form{get;set;}
        ///<summary>
        ///Sets or retrieves a lower resolution image to display.
        ///</summary>
        public JsString lowsrc{get;set;}
        ///<summary>
        ///Sets or retrieves the number of times a sound or video clip will loop when activated.
        ///</summary>
        public JsString loop{get;set;}
        ///<summary>
        ///Sets or retrieves the horizontal margin for the object.
        ///</summary>
        public JsString hspace{get;set;}
        ///<summary>
        ///Sets or retrieves the vertical margin for the object.
        ///</summary>
        public JsString vspace{get;set;}
        ///<summary>
        ///Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
        ///</summary>
        public JsString useMap{get;set;}
        ///<summary>
        ///Sets or retrieves the value indicated whether the content of the object is read-only.
        ///</summary>
        public JsString readOnly{get;set;}
        ///<summary>
        ///Sets or retrieves the size of the control.
        ///</summary>
        public JsString size{get;set;}
        ///<summary>
        ///Sets or retrieves a URL to be loaded by the object.
        ///</summary>
        public JsString src{get;set;}
        ///<summary>
        ///Sets or retrieves when a video clip file should begin playing.
        ///</summary>
        public JsString start{get;set;}
        ///<summary>
        ///Sets or retrieves the calculated width of the object.
        ///</summary>
        public JsString width{get;set;}
        /// <summary>
        /// Sets or retrieves the value indicating whether the control is selected.
        /// Possible values:
        ///	false	Default. Control is not selected.
        /// true	Control is selected.
        /// null	Control is not initialized.
        /// </summary>
        public bool status{get;set;}
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name{get;set;}
        ///<summary>
        ///Retrieves the file name of the input object after the text is set by user input.
        ///</summary>
        public JsString value{get;set;}
        ///<summary>
        ///Retrieves or initially sets the type of input control represented by the object.
        ///</summary>
        public JsString type{get;set;}
        ///<summary>
        ///Highlights the input area of a form element.
        ///</summary>
        public void select(){}
        ///<summary>
        ///Creates a TextRange object for the element.
        ///Use a text range to examine and modify the text within an object.
        ///</summary>
        ///<returns>Returns a TextRange object if successful, or null otherwise.</returns>
        public HtmlTextRange createTextRange(){return default(HtmlTextRange);}
        ///<summary>
        ///Sets or retrieves the maximum number of characters that the user can enter in a text control. 
        ///</summary>
        public JsNumber maxLength{get;set;}
        ///<summary>
        ///Fires when the user aborts the download of an image.
        ///</summary>		
        public new HtmlDomEventHandler onabort;
        ///<summary>
        ///Fires when the contents of the object or selection have changed.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select. IE has a serious bug in its handling of this event on checkboxes and radios.")]
        public new HtmlDomEventHandler onchange;
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public new HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public new HtmlDomEventHandler onload;
        ///<summary>
        ///Fires when the current selection changes.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public new HtmlDomEventHandler onselect;
        [HtmlSpecificationVersion(5)]
        public bool autocomplete{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool autofocus{get;set;}
        [HtmlSpecificationVersion(5)]
        public FileList files{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formAction{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formEnctype{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formMethod{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool formNoValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString formTarget{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString height{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool indeterminate{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlElement list{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString max{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString min{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool multiple{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString pattern{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString placeholder{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool required{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString step{get;set;}
        [HtmlSpecificationVersion(5)]
        public Date valueAsDate{get;set;}
        [HtmlSpecificationVersion(5)]
        public float valueAsNumber{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlOption selectedOption{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void stepUp(long n){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void stepDown(long n){}
        [HtmlSpecificationVersion(5)]
        public bool willValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public ValidityState validity{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString validationMessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setCustomValidity(JsString error){}
        [HtmlSpecificationVersion(5)]
        public NodeList labels{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong selectionStart{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong selectionEnd{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setSelectionRange(ulong start, ulong end){}
    }
    #endregion
    #region HtmlLabelElement
    ///<summary>
    ///The label represents a caption in a user interface. The caption can be associated with a specific form control , known as the labelelement's labeled control , either using for attribute, or by putting the form control inside the label element itself.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLLabelElement")]
    public abstract partial class HtmlLabelElement : HtmlElement
    {
        public HtmlForm form{get;set;}
        public JsString htmlFor{get;set;}
        public HtmlElement control{get;set;}
    }
    #endregion
    #region HtmlLegend
    [JsType(JsMode.Prototype, Export = false, Name = "LEGEND")]
    public partial class HtmlLegend : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves the alignment of the caption or legend.
        ///</summary>
        public JsString align{get;set;}
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld{get;set;}
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form{get;set;}
    }
    #endregion
    #region HtmlLineBreak
    ///<summary>
    ///Inserts a line break.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "LINEBREAK")]
    public partial class HtmlLineBreak : HtmlElement
    {
        internal  HtmlLineBreak(){}
    }
    #endregion
    #region HtmlLink
    ///<summary>
    ///Represents a LINK html node
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "LINK")]
    public partial class HtmlLink : HtmlElement
    {
        internal  HtmlLink(){}
        ///<summary>
        ///Sets or retrieves the destination URL or anchor point.
        ///</summary>
        public JsString href{get;set;}
        ///<summary>
        ///Sets or retrieves the relationship between the object and the destination of the link. e.g. 'stylesheet'
        ///</summary>
        public JsString rel{get;set;}
        ///<summary>
        ///Sets or retrieves the MIME type of the object. e.g. 'text/css'
        ///</summary>
        public JsString type{get;set;}
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public new HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public new HtmlDomEventHandler onload;
        [HtmlSpecificationVersion(5)]
        public DOMTokenList relList{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString media{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString hreflang{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString sizes{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString charset{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString rev{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString target{get;set;}
    }
    #endregion
    #region HtmlListItem
    ///<summary>
    ///Represents an HTML list item
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "LISTITEM")]
    public partial class HtmlListItem : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public long value{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
    }
    #endregion
    #region HtmlMapElement
    ///<summary>
    ///The map element, in conjunction with any area element descendants, defines an image map . The element represents its children.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLMapElement")]
    public abstract partial class HtmlMapElement : HtmlElement
    {
        public JsString name{get;set;}
        public HtmlElementCollection areas{get;set;}
        public HtmlElementCollection images{get;set;}
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
        [HtmlSpecificationVersion(5)]
        public JsString behavior{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString bgColor{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString direction{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString height{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong hspace{get;set;}
        [HtmlSpecificationVersion(5)]
        public long loop{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong scrollAmount{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong scrollDelay{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString trueSpeed{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong vspace{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString width{get;set;}
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void start(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void stop(){}
    }
    #endregion
    #region HtmlMetaElement
    ///<summary>
    ///The meta element represents various kinds of metadata that cannot be expressed using the title , base , link , style , and script elements.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLMetaElement")]
    public abstract partial class HtmlMetaElement : HtmlElement
    {
        public JsString name{get;set;}
        public JsString httpEquiv{get;set;}
        public JsString content{get;set;}
        public JsString scheme{get;set;}
    }
    #endregion
    #region HtmlNode
    ///<summary>
    ///Represents an HtmlNode
    ///</summary>
    [JsType(OmitCasts = true, Export = false, NativeOverloads = true)]
    public abstract partial class HtmlNode
    {
        ///<summary>
        ///Replaces an existing child element with a new child element.
        ///</summary>
        ///<param name="newNode"></param>
        ///<param name="existingChild"></param>
        ///<returns>Returns a reference to the object that is replaced.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlNode replaceChild(HtmlNode newNode, HtmlNode existingChild){return default(HtmlNode);}
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
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, @"IE 5.5: attributes and document not defined; comment has nodeType 1.
		Konqueror doesn't see comment nodes.")]
        public JsNumber nodeType;
        ///<summary>
        ///Retrieves a reference to the previous child of the parent for the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNode previousSibling{get;set;}
        ///<summary>
        ///Retrieves a reference to the next child of the parent for the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, "Konqueror ignores comment nodes.")]
        public HtmlNode nextSibling{get;set;}
        ///<summary>
        ///Retrieves the name of a particular type of node. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, @"IE 5.5 doesn't support a nodeName for attributes and the document. 
IE 5.5 reports the nodeName of a comment as !. 
Konqueror doesn't see comment nodes.")]
        public JsString nodeName{get;set;}
        ///<summary>
        ///Sets or retrieves the value of a node.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, @"IE 5.5 doesn't support nodeValue for attributes
		Konqueror doesn't see comment nodes.")]
        public JsString nodeValue{get;set;}
        ///<summary>
        ///Retrieves the parent object in the document hierarchy.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlElement parentNode{get;set;}
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
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public JsNumber compareDocumentPosition(HtmlNode otherNode){return default(JsNumber);}
        ///<summary>
        ///Returns a value that indicates whether the object has children.
        ///</summary>
        ///<returns>Returns true if the object contains HTML Elements or TextNode objects, or false if the object does not contain HTML Elements or TextNodes.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public bool hasChildNodes(){return default(bool);}
        ///<summary>
        ///Retrieves the document object associated with the node.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDocument ownerDocument{get;set;}
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public new HtmlDomEventHandler onerror;
        [HtmlSpecificationVersion(5)]
        public JsString data{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString useMap{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlForm form{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString width{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString height{get;set;}
        [HtmlSpecificationVersion(5)]
        public Document contentDocument{get;set;}
        [HtmlSpecificationVersion(5)]
        public WindowProxy contentWindow{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool willValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public ValidityState validity{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString validationMessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setCustomValidity(JsString error){}
        [HtmlSpecificationVersion(5)]
        public JsString align{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString archive{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString border{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString code{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString codeBase{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString codeType{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool declare{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong hspace{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString standby{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong vspace{get;set;}
    }
    #endregion
    #region HtmlOptGroupElement
    ///<summary>
    ///The optgroup element represents a group of option elements with a common label.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLOptGroupElement")]
    public abstract partial class HtmlOptGroupElement : HtmlElement
    {
        public new bool disabled{get;set;}
        public new JsString label{get;set;}
    }
    #endregion
    #region HtmlOption
    ///<summary>
    ///Denotes one choice in a SELECT element.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Option")]
    public partial class HtmlOption : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves the value which is returned to the server when the form control is submitted.
        ///</summary>
        public JsString value{get;set;}
        ///<summary>
        ///Sets or retrieves the text JsString specified by the option tag. 
        ///</summary>
        public JsString text{get;set;}
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        ///<summary>
        ///Sets or retrieves the status of an option.
        ///</summary>
        public bool defaultSelected{get;set;}
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form{get;set;}
        ///<summary>
        ///Sets or retrieves the ordinal position of an option in a list box.
        ///</summary>
        public new JsString label{get;set;}
        ///<summary>
        ///Sets or retrieves whether the option in the list box is the default item.
        ///</summary>
        public bool selected{get;set;}
        [HtmlSpecificationVersion(5)]
        public long index{get;set;}
    }
    #endregion
    #region HtmlOrderedList
    ///<summary>
    ///Represents an ordered list
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ORDEREDLIST")]
    public partial class HtmlOrderedList : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public bool reversed{get;set;}
        [HtmlSpecificationVersion(5)]
        public long start{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString compact{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
    }
    #endregion
    #region HtmlParagraph
    ///<summary>
    ///Denotes a paragraph.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "PARAGRAPH")]
    public partial class HtmlParagraph : HtmlDiv
    {
        internal  HtmlParagraph(){}
        /// <summary>
        /// Sets or retrieves the side on which floating objects are not to be positioned when any IHTMLBlockElement is inserted into the document.
        /// Possible Values:
        /// all		Object is moved below any floating object.
        /// left	Object is moved below any floating object on the left side.
        ///	right Object is moved below any floating object on the right side.
        ///	none	Floating objects are allowed on all sides.
        /// </summary>
        public JsString clear{get;set;}
    }
    #endregion
    #region HtmlPre
    ///<summary>
    ///Renders text in a fixed-width font.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "PRE")]
    public partial class HtmlPre : HtmlElement
    {
        internal  HtmlPre(){}
        [HtmlSpecificationVersion(5)]
        public ulong width{get;set;}
    }
    #endregion
    #region HtmlQuoteElement
    ///<summary>
    ///The blockquote element represents a section that is quoted from another source.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLQuoteElement")]
    public abstract partial class HtmlQuoteElement : HtmlElement
    {
        public JsString cite{get;set;}
    }
    #endregion
    #region HtmlScreen
    [JsType(JsMode.Prototype, Export = false, Name = "SCREEN")]
    public partial class HtmlScreen
    {
        ///<summary>
        ///Retrieves the height of the working area of the system's screen, excluding the Microsoft Windows taskbar.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber availHeight{get;set;}
        ///<summary>
        ///Retrieves the width of the working area of the system's screen, excluding the Windows taskbar.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber availWidth{get;set;}
        ///<summary>
        ///Sets or retrieves the update interval for the screen.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public JsNumber updateInterval{get;set;}
        ///<summary>
        ///Retrieves whether the user has enabled font smoothing in the Display control panel.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public bool fontSmoothingEnabled{get;set;}
        ///<summary>
        ///Sets or retrieves the number of bits per pixel used for colors in the off-screen bitmap buffer.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public JsNumber bufferDepth{get;set;}
        ///<summary>
        ///The color depth (in bits) of the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber colorDepth{get;set;}
        ///<summary>
        ///The color depth (in bits) of the screen. (Same as colorDepth)
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Use colorDepth.")]
        public JsNumber pixelDepth{get;set;}
        ///<summary>
        ///The width of the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber width{get;set;}
        ///<summary>
        ///The height of the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber height{get;set;}
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public new HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public new HtmlDomEventHandler onload;
        [HtmlSpecificationVersion(5)]
        public bool async{get;set;}
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select.")]
        public new HtmlDomEventHandler onchange;
        public HtmlNodeCollection<HtmlOption> options{get{return default(HtmlNodeCollection<HtmlOption>);}
        }
        ///<summary>
        ///Sets or retrieves the Boolean value indicating whether multiple items can be selected from a list.
        ///</summary>
        public bool multiple{get;set;}
        ///<summary>
        ///Sets or retrieves the index of the selected option in a select object.
        ///</summary>
        public JsNumber selectedIndex{get;set;}
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld{get;set;}
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form{get;set;}
        ///<summary>
        ///Sets or retrieves the number of objects in a collection.
        ///</summary>
        public JsNumber length{get;set;}
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name{get;set;}
        ///<summary>
        ///Sets or retrieves the number of rows in the list box.
        ///</summary>
        public JsString size{get;set;}
        ///<summary>
        ///Retrieves the type of select control based on the value of the MULTIPLE attribute.
        ///</summary>
        public JsString type{get;set;}
        ///<summary>
        ///Sets or retrieves the value which is returned to the server when the form control is submitted.
        ///</summary>
        public JsString value{get;set;}
        ///<summary>
        ///Adds an option element to the options collection of a select object.
        ///</summary>
        ///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
        ///<param name="existingOption">An existing HTMLOptionElement within the collection used as a reference point for inserting the new element; the new element being inserted before the referenced element in the collection.  If this parameter is null, the new element is appended to the end of the collection.</param>
        [SupportedBrowsers(BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void add(HtmlOption newOption, HtmlOption existingOption){}
        ///<summary>
        ///Adds an option element to the options collection of a select object.
        ///</summary>
        ///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void add(HtmlOption newOption){}
        ///<summary>
        ///Adds an option element to the options collection of a select object.
        ///</summary>
        ///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
        ///<param name="index">Integer that specifies the index position in the collection where the element is placed. If no value is given, the method places the element at the end of the collection.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void add(HtmlOption newOption, JsNumber index){}
        ///<summary>
        ///Removes an element from the collection.
        ///</summary>
        ///<param name="iIndex">Integer that specifies the zero-based index of the element to remove from the collection.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void remove(JsNumber iIndex){}
        [HtmlSpecificationVersion(5)]
        public bool autofocus{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public object item(ulong index){return default(object);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public object namedItem(JsString name){return default(object);}
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection selectedOptions{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool willValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public ValidityState validity{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString validationMessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setCustomValidity(JsString error){}
        [HtmlSpecificationVersion(5)]
        public NodeList labels{get;set;}
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
        public JsString dataFld{get;set;}
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        internal  HtmlSpan(){}
    }
    #endregion
    #region HtmlStyleElement
    ///<summary>
    ///Represents a STYLE html node
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "STYLEELEMENT")]
    public partial class HtmlStyleElement : HtmlElement
    {
        internal  HtmlStyleElement(){}
        ///<summary>
        ///Sets or retrieves the MIME type of the object. e.g. 'text/css'
        ///</summary>
        public JsString type{get;set;}
        ///<summary>
        ///Sets or retrieves the media type.
        ///</summary>
        ///<remarks>Possible values:
        ///screen - Output is intended for computer screens.
        ///print - Output is intended for printed material and for on-screen documents viewed in Print Preview mode.
        ///all - Default. Applies to all devices.</remarks>
        public JsString media{get;set;}
        ///<summary>
        ///Retrieves the next object in the HTML hierarchy.
        ///</summary>
        public HtmlElement owningElement{get;set;}
        ///<summary>
        ///Retrieves the style sheet that imported the current style sheets.
        ///</summary>
        public HtmlStyleElement parentStyleSheet{get;set;}
        ///<summary>
        ///Retrieves whether the rule or style sheet is defined on the page or is imported.
        ///</summary>
        public bool readOnly{get;set;}
        ///<summary>
        ///Sets or retrieves the title of the style sheet.
        ///</summary>
        public new JsString title{get;set;}
        ///<summary>
        ///Retrieves a collection of all the imported style sheets defined for the respective styleSheet object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public HtmlNodeCollection<HtmlStyleElement> imports{get;set;}
        ///<summary>
        ///Retrieves a collection of page objects, which represent @page rules in a styleSheet.
        ///</summary>
        public HtmlGenericCollection<HtmlStyleSheetPage> pages{get;set;}
        ///<summary>
        ///Retrieves a collection of rules defined in a style sheet.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9, "Use cssRules in non-IE browsers.", PartiallySupportedRemark = "IE doesn't count @imports as rules, but splits up selectors like p#test, ul into two rules.")]
        public HtmlGenericCollection<HtmlCssRule> rules{get;set;}
        ///<summary>
        ///Retrieves a collection of rules defined in a style sheet.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, @"Use rules in IE")]
        public HtmlGenericCollection<HtmlCssRule> cssRules{get;set;}
        ///<summary>
        ///Creates a new rule for a style sheet.
        ///</summary>
        ///<param name="cSelector">String that specifies the selector for the new rule. Single contextual selectors are valid. For example, "div p b" is a valid contextual selector.</param>
        ///<param name="cStyle">String that specifies the style assignments for this style rule. This style takes the same form as an inline style specification. For example, "color:blue" is a valid style parameter.</param>
        ///<param name="iIndex">Integer that specifies the zero-based position in the rules collection where the new style rule should be placed.
        ///-1 by Default. The rule is added to the end of the collection.</param>
        ///<returns>-1 (Reserved value)</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57)]
        public JsNumber addRule(JsString cSelector, JsString cStyle, JsNumber iIndex){return default(JsNumber);}
        ///<summary>
        ///Creates a new rule for a style sheet.
        ///</summary>
        ///<param name="cSelector">String that specifies the selector for the new rule. Single contextual selectors are valid. For example, "div p b" is a valid contextual selector.</param>
        ///<param name="cStyle">String that specifies the style assignments for this style rule. This style takes the same form as an inline style specification. For example, "color:blue" is a valid style parameter.</param>
        ///<returns>-1 (Reserved value)</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57)]
        public JsNumber addRule(JsString cSelector, JsString cStyle){return default(JsNumber);}
        ///<summary>
        ///Inserts a new style rule into the current style sheet.
        ///</summary>
        ///<param name="rule">a JsString containing the rule to be inserted (selector and declaration).</param>
        ///<param name="index">a number representing the position to be inserted.</param>
        ///<returns>The index within the style sheet's rule collection of the newly inserted rule.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public ulong insertRule(JsString rule, JsNumber index){return default(ulong);}
        ///<summary>
        ///Used to delete a rule from the style sheet.
        ///</summary>
        ///<param name="index">The index within the style sheet's rule list of the rule to remove.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void deleteRule(ulong index){}
        ///<summary>
        ///Deletes an existing style rule for the styleSheet object, and adjusts the index of the rules collection accordingly.
        ///</summary>
        ///<param name="iIndex">Integer that specifies the index value of the rule to be deleted from the style sheet.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57)]
        public void removeRule(JsNumber iIndex){}
        ///<summary>
        ///Deletes the first style rule for the styleSheet object, and adjusts the index of the rules collection accordingly.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57)]
        public void removeRule(){}
        ///<summary>
        ///Sets or retrieves the persisted representation of the style rule.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        public JsString cssText{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates whether the user can interact with the object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public new bool disabled{get;set;}
        ///<summary>
        ///The URL of the linked style sheet.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString href{get;set;}
        ///<summary>
        ///Returns the node that associates this style sheet with the document. Usually a &lt;link&gt; or a &lt;style&gt; tag.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlNode ownerNode{get;set;}
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public new HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires immediately after the browser loads the object.
        ///</summary>		
        public new HtmlDomEventHandler onload;
        [HtmlSpecificationVersion(5)]
        public bool scoped{get;set;}
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
        public JsString pseudoClass{get;set;}
        ///<summary>
        ///Retrieves a JsString that identifies which page or pages an @page rule applies to.
        ///</summary>
        public JsString selector{get;set;}
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
        public JsString width{get;set;}
        ///<summary>
        ///Sets or retrieves a description and/or structure of the object.
        ///</summary>
        public JsString summary{get;set;}
        ///<summary>
        ///Sets or retrieves which dividing lines (inner borders) are displayed.			 
        ///Possible Values:
        ///all			Borders are displayed on all rows and columns.
        ///cols		Borders are displayed between all table columns.
        ///groups	Horizontal borders are displayed between all tHead, tBody, and tFoot objects; vertical borders are displayed between all colGroup objects.
        ///none		All interior table borders are removed.
        ///rows		Horizontal borders are displayed between all table rows.
        ///</summary>
        public JsString rules{get;set;}
        ///<summary>
        ///Sets or retrieves the height of the object.
        ///Possible Values:
        ///height			Integer that specifies the height of the object, in pixels.
        ///percentage	Integer, followed by a percent sign (%). The value is a percentage of the height of the parent object.
        ///</summary>
        public JsString height{get;set;}
        ///<summary>
        ///Sets or retrieves the way the border frame around the table is displayed.
        ///</summary>
        ///<remarks>Possible values: void, above, below, hsides, vsides, lhs, rhs, box, border</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString frame{get;set;}
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld{get;set;}
        /// <summary>
        /// Sets or retrieves the rendering format for the data supplied to the object.
        /// Possible values:
        ///	text						Default. Data is rendered as text.
        /// html						Data is rendered as HTML.
        /// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
        /// </summary>
        public JsString dataFormatAs{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        /// <summary>
        ///	Sets or retrieves the number of columns in the table.
        /// </summary>
        public JsNumber cols{get;set;}
        /// <summary>
        ///	Sets or retrieves the amount of space between cells in a table.
        ///	Possible Values:
        ///	spacing			Integer that specifies the amount of space between cells, in pixels.
        ///	percentage	Integer, followed by a %. The value is a percentage of the available amount of space between the border and the content.
        /// </summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString cellSpacing{get;set;}
        /// <summary>
        ///	Sets or retrieves the amount of space between the border of the cell and the content of the cell.
        ///	Possible Values:
        ///	Integer			that specifies the amount of space between the border and the content, in pixels.
        ///	percentage	Integer, followed by a %. The value is a percentage of the available amount of space between the border and the content.
        /// </summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, @"Safari 3.0 and Konqueror don't react to the setting of cellPadding, but there's a subtle difference between doing the cellPadding test and then the cellSpacing one, and doing the cellSpacing one immediately. The results might be interpreted as the cellPadding only taking effect after the cellSpacing has been set, but I'm not sure if this interpretation is correct.")]
        public JsString cellPadding{get;set;}
        /// <summary>
        ///	Retrieves the caption object of a table.
        /// </summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString caption{get;set;}
        /// <summary>
        ///	Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
        /// </summary>
        public JsString borderColorLight{get;set;}
        /// <summary>
        ///	Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
        /// </summary>
        public JsString borderColorDark{get;set;}
        /// <summary>
        ///	Deprecated. Sets or retrieves the background color behind the object.
        /// </summary>
        public JsString bgColor{get;set;}
        ///<summary>
        ///Sets or retrieves a value that indicates the table alignment.
        ///Possible Values:
        ///left		Aligns to the left edge of the available space.
        ///center	Aligns to the center of the available space, which is not necessarily the same as the browser window.
        ///right		Aligns to the right edge of the available space.
        ///</summary>
        public JsString align{get;set;}
        public JsString border{get;set;}
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlNodeCollection<HtmlTableCell> cells{get;set;}
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlNodeCollection<HtmlTableBody> tBodies{get;set;}
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlNodeCollection<HtmlTableHead> tHeads{get;set;}
        ///<summary>
        ///Creates a new row (tr) in the table, and adds the row to the rows collection.
        ///</summary>
        ///<param name="iIndex">Integer that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
        ///<returns>Returns the tr element object if successful, or null otherwise.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlTableRow insertRow(JsNumber iIndex){return default(HtmlTableRow);}
        public HtmlNodeCollection<HtmlTableRow> rows{get;set;}
        ///<summary>
        ///Creates an empty caption element in the table.
        ///</summary>
        ///<returns>Returns a caption object.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public HtmlCaption createCaption(){return default(HtmlCaption);}
        ///<summary>
        ///Creates an empty tFoot element in the table.
        ///</summary>
        ///<returns>Returns the tFoot element object if successful, or null otherwise.</returns>
        ///<remarks>If a tFoot already exists for the table, the createTFoot method returns the existing element. Otherwise, it returns a pointer to the element created.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public HtmlTableFoot createTFoot(){return default(HtmlTableFoot);}
        ///<summary>
        ///Creates an empty tHead element in the table.
        ///</summary>
        ///<returns>Returns the tHead element object if successful, or null otherwise.</returns>
        ///<remarks>If a tHead already exists, createTHead returns the existing element. Otherwise, it returns a pointer to the element created.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public HtmlTableFoot createTHead(){return default(HtmlTableFoot);}
        ///<summary>
        ///Deletes the caption element and its contents from the table.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteCaption(){}
        ///<summary>
        ///Removes the specified row (tr) from the element and from the rows collection.
        ///</summary>
        ///<param name="iRowIndex">Integer that specifies the zero-based position in the rows collection of the row to remove.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteRow(JsNumber iRowIndex){}
        ///<summary>
        ///Removes the last row (tr) from the element and from the rows collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteRow(){}
        ///<summary>
        ///Deletes the tFoot element and its contents from the table.
        ///</summary>
        ///<remarks>If only one tFoot element exists in the source, the deleteTFoot method deletes the table footer. If multiple tFoot elements have been defined, the next tFoot element in the source order is promoted as the table footer.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteTFoot(){}
        ///<summary>
        ///Deletes the tHead element and its contents from the table.
        ///</summary>
        ///<remarks>If only one tHead element exists in the source, the deleteTHead method deletes the table header. If multiple tHead elements have been defined, the next tHead element in the source order is promoted as the table header.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteTHead(){}
        ///<summary>
        ///Moves a table row to a new position.
        ///</summary>
        ///<param name="iSource">Integer that specifies the index in the rows collection of the table row that is moved.</param>
        ///<param name="iTarget">Integer that specifies where the row is moved within the rows collection.</param>
        ///<returns>Object. Returns a reference to the table row that is moved.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        [JsMethod(NativeOverloads = true)]
        public HtmlTableRow moveRow(JsNumber iSource, JsNumber iTarget){return default(HtmlTableRow);}
        ///<summary>
        ///Retrieves the tFoot object of the table.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlTableFoot tFoot{get;set;}
        ///<summary>
        ///Retrieves the tHead object of the table.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlTableHead tHead{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public HtmlElement createTBody(){return default(HtmlElement);}
    }
    #endregion
    #region HtmlTableBody
    ///<summary>
    ///Designates rows as the body of the table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLEBODY")]
    public partial class HtmlTableBody : HtmlElement
    {
        ///<summary>
        ///Creates a new row (tr) in the table, and adds the row to the rows collection. 
        ///</summary>
        ///<param name="rowIndex">Integer that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
        ///<returns>Returns the tr element object if successful, or null otherwise. </returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlTableRow insertRow(JsNumber rowIndex){return default(HtmlTableRow);}
        ///<summary>
        ///Creates a new row (tr) in the table, and adds the row to the rows collection. 
        ///</summary>
        ///<returns>Returns the tr element object if successful, or null otherwise. </returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlTableRow insertRow(){return default(HtmlTableRow);}
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
        public JsString vAlign{get;set;}
        ///<summary>
        ///Removes the specified row (tr) from the element and from the rows collection.
        ///</summary>
        ///<param name="iRowIndex">Integer that specifies the zero-based position in the rows collection of the row to remove.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteRow(JsNumber iRowIndex){}
        ///<summary>
        ///Removes the last row (tr) from the element and from the rows collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteRow(){}
        ///<summary>
        ///Deletes the tFoot element and its contents from the table.
        ///</summary>
        ///<remarks>If only one tFoot element exists in the source, the deleteTFoot method deletes the table footer. If multiple tFoot elements have been defined, the next tFoot element in the source order is promoted as the table footer.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteTFoot(){}
        ///<summary>
        ///Deletes the tHead element and its contents from the table.
        ///</summary>
        ///<remarks>If only one tHead element exists in the source, the deleteTHead method deletes the table header. If multiple tHead elements have been defined, the next tHead element in the source order is promoted as the table header.</remarks>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteTHead(){}
        ///<summary>
        ///Moves a table row to a new position.
        ///</summary>
        ///<param name="iSource">Integer that specifies the index in the rows collection of the table row that is moved.</param>
        ///<param name="iTarget">Integer that specifies where the row is moved within the rows collection.</param>
        ///<returns>Object. Returns a reference to the table row that is moved.</returns>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9)]
        [JsMethod(NativeOverloads = true)]
        public HtmlTableRow moveRow(JsNumber iSource, JsNumber iTarget){return default(HtmlTableRow);}
    }
    #endregion
    #region HtmlTableCaptionElement
    ///<summary>
    ///The caption element represents the title of the table that is its parent, if it has a parent and that is a table element.User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLTableCaptionElement")]
    public abstract partial class HtmlTableCaptionElement : HtmlElement
    {
        public JsString align{get;set;}
    }
    #endregion
    #region HtmlTableCell
    ///<summary>
    ///Specifies a cell in a table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLECELL")]
    public partial class HtmlTableCell : HtmlElement
    {
        internal  HtmlTableCell(){}
        ///<summary>
        ///Sets or retrieves abbreviated text for the object.
        ///</summary>
        public JsString abbr{get;set;}
        ///<summary>
        ///Sets or retrieves a comma-delimited list of conceptual categories associated with the object.
        ///</summary>
        public JsString axis{get;set;}
        ///<summary>
        ///Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
        ///</summary>
        public JsString borderColorDark{get;set;}
        ///<summary>
        ///Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
        ///</summary>
        public JsString borderColorLight{get;set;}
        ///<summary>
        ///Sets or retrieves a value that you can use to implement your own ch functionality for the object.
        ///</summary>
        public JsString ch{get;set;}
        ///<summary>
        ///Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
        ///</summary>
        public JsString chOff{get;set;}
        ///<summary>
        ///Sets or retrieves the number columns in the table that the object should span.
        ///</summary>
        public JsNumber colSpan{get;set;}
        ///<summary>
        ///Sets or retrieves a list of header cells that provide information for the object.
        ///</summary>
        public JsString headers{get;set;}
        ///<summary>
        ///Sets or retrieves how many rows in a table the cell should span.
        ///</summary>
        public JsNumber rowSpan{get;set;}
        ///<summary>
        ///Sets or retrieves the group of cells in a table to which the object's information applies.
        ///Possible Values:
        ///row				The current cell provides header information for its row.
        ///col				The current cell provides header information for its column.
        ///rowgroup	The header cell provides header information for its row.
        ///colgroup	The header cell provides header information for its column.
        ///</summary>
        public JsString scope{get;set;}
        ///<summary>
        ///Sets or retrieves the width of the object.
        ///Possible Values:
        ///Integer			that specifies the width of the object in pixels.
        ///percentage	String that specifies an integer value followed by a %. The value is a percentage of the width of the parent object.
        ///</summary>
        public JsString width{get;set;}
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
        public bool noWrap{get;set;}
        ///<summary>
        ///Retrieves the position of the object in the cells collection of a row. 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber cellIndex{get;set;}
        ///<summary>
        ///Deprecated. Sets or retrieves the background color behind the object.
        ///</summary>
        public JsString bgColor{get;set;}
        ///<summary>
        ///Sets the height of the object.
        ///</summary>
        public JsString height{get;set;}
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
        public JsString vAlign{get;set;}
    }
    #endregion
    #region HtmlTableCol
    ///<summary>
    ///Specifies column-based defaults for the table properties.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLECOL")]
    public partial class HtmlTableCol : HtmlElement
    {
        internal  HtmlTableCol(){}
        ///<summary>
        ///Sets or retrieves the width of the object.
        ///</summary>
        public JsString width{get;set;}
        ///<summary>
        ///Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
        ///</summary>
        public JsString chOff{get;set;}
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
        public JsString valign{get;set;}
        ///<summary>
        ///Sets or retrieves the number of columns in the group. 
        ///</summary>
        ///<remarks>
        ///Integer that specifies or receives the number of spanned columns. The default value is 1.
        ///</remarks>
        public JsNumber span{get;set;}
        ///<summary>
        ///Sets or retrieves a value that you can use to implement your own ch functionality for the object.
        ///</summary>
        public JsString ch{get;set;}
        /// <summary>
        /// Sets or retrieves the alignment of the object relative to the display or table.
        /// Possible Values:
        /// center	Aligns to the center.
        /// justify	Aligns to the left and right edge.
        ///	left		Default. Aligns to the left edge.
        ///	right		Aligns to the right edge.
        /// </summary>
        public JsString align{get;set;}
        public JsString vAlign{get;set;}
    }
    #endregion
    #region HtmlTableColGroup
    ///<summary>
    ///Specifies property defaults for a column or group of columns in a table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLECOLGROUP")]
    public partial class HtmlTableColGroup : HtmlElement
    {
        internal  HtmlTableColGroup(){}
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
        public JsString vAlign{get;set;}
    }
    #endregion
    #region HtmlTableFoot
    ///<summary>
    ///Designates rows as the table's footer.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLEFOOT")]
    public partial class HtmlTableFoot : HtmlTableBody
    {
        internal  HtmlTableFoot(){}
    }
    #endregion
    #region HtmlTableHead
    ///<summary>
    ///Designates rows as the table's header.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLEHEAD")]
    public partial class HtmlTableHead : HtmlTableBody
    {
        internal  HtmlTableHead(){}
    }
    #endregion
    #region HtmlTableHeadCell
    ///<summary>
    ///Sets how text and other content are vertically aligned within the object that contains them.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLEHEADCELL")]
    public partial class HtmlTableHeadCell : HtmlTableCell
    {
        internal  HtmlTableHeadCell(){}
    }
    #endregion
    #region HtmlTableRow
    ///<summary>
    ///Specifies a row in a table.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "TABLEROW")]
    public partial class HtmlTableRow : HtmlElement
    {
        internal  HtmlTableRow(){}
        public HtmlNodeCollection<HtmlTableCell> cells{get;set;}
        ///<summary>
        ///Creates a new cell in the table row (tr), and adds the cell to the cells collection. 
        ///</summary>
        ///<param name="index">Integer that specifies where to insert the cell in the tr. The default value is -1, which appends the new cell to the end of the cells collection.</param>
        ///<returns>Returns the td element object if successful, or null otherwise.</returns>		
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlTableCell insertCell(JsNumber index){return default(HtmlTableCell);}
        ///<summary>
        ///Creates a new cell in the table row (tr), and adds the cell to the cells collection. 
        ///</summary>
        ///<returns>Returns the td element object if successful, or null otherwise.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlTableCell insertCell(){return default(HtmlTableCell);}
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
        public JsString vAlign{get;set;}
        ///<summary>
        ///Removes the specified cell (td) from the table row, as well as from the cells collection.
        ///</summary>
        ///<param name="iIndex">Integer that specifies the zero-based position of the cell to remove from the table row. If no value is provided, the last cell in the cells collection is deleted.</param>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteCell(JsNumber iIndex){}
        ///<summary>
        ///Removes the last cell (td) from the table row, as well as from the cells collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public void deleteCell(){}
        ///<summary>
        ///Retrieves the position of the object in the rows collection for the table.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57, @"Opera keeps to the source code order (where the <tfoot> precedes the <tbody>.)")]
        public JsNumber rowIndex{get;set;}
        ///<summary>
        ///Retrieves the position of the object in the tBody, tHead, tFoot, or rows collection.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber sectionRowIndex{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString align{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString bgColor{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString ch{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString chOff{get;set;}
    }
    #endregion
    #region HtmlTextArea
    [JsType(JsMode.Prototype, Export = false, Name = "TEXTAREA")]
    public partial class HtmlTextArea : HtmlElement
    {
        ///<summary>
        ///Sets or retrieves the number of horizontal rows contained in the object.
        ///</summary>
        public JsNumber rows{get;set;}
        ///<summary>
        ///Sets or retrieves the width of the object.
        ///</summary>
        public JsNumber cols{get;set;}
        /// <summary>
        /// Sets or retrieves how to handle wordwrapping in the object. 
        /// Possible values:
        ///	soft	Default. Text is displayed with wordwrapping and submitted without carriage returns and line feeds. 
        /// hard	Text is displayed with wordwrapping and submitted with soft returns and line feeds. 
        /// off		Wordwrapping is disabled. The lines appear exactly as the user types them. 
        /// </summary>
        public JsString wrap{get;set;}
        ///<summary>
        ///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
        ///</summary>
        public JsString dataFld{get;set;}
        ///<summary>
        ///Sets or retrieves the source of the data for data binding.
        ///</summary>
        public JsString dataSrc{get;set;}
        ///<summary>
        ///Sets or retrieves a comma-separated list of content types.
        ///</summary>
        public JsString accept{get;set;}
        ///<summary>
        ///Sets or retrieves how the object is aligned with adjacent text.
        ///</summary>
        public JsString align{get;set;}
        ///<summary>
        ///Sets or retrieves a text alternative to the graphic.
        ///</summary>
        public JsString alt{get;set;}
        ///<summary>
        ///Sets or retrieves the state of the check box or radio button.
        ///</summary>
        public new bool @checked{get;set;}
        ///<summary>
        ///Retrieves whether the object is fully loaded.
        ///</summary>
        public JsString complete{get;set;}
        ///<summary>
        ///Sets or retrieves the initial contents of the object.
        ///</summary>
        public JsString defaultValue{get;set;}
        ///<summary>
        ///Sets or retrieves the state of the check box or radio button.
        ///</summary>
        public JsString defaultChecked{get;set;}
        ///<summary>
        ///Retrieves a reference to the form that the object is embedded in.
        ///</summary>
        public JsString form{get;set;}
        ///<summary>
        ///Sets or retrieves a lower resolution image to display.
        ///</summary>
        public JsString lowsrc{get;set;}
        ///<summary>
        ///Sets or retrieves the number of times a sound or video clip will loop when activated.
        ///</summary>
        public JsString loop{get;set;}
        ///<summary>
        ///Sets or retrieves the horizontal margin for the object.
        ///</summary>
        public JsString hspace{get;set;}
        ///<summary>
        ///Sets or retrieves the vertical margin for the object.
        ///</summary>
        public JsString vspace{get;set;}
        ///<summary>
        ///Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
        ///</summary>
        public JsString useMap{get;set;}
        ///<summary>
        ///Sets or retrieves the value indicated whether the content of the object is read-only.
        ///</summary>
        public JsString readOnly{get;set;}
        ///<summary>
        ///Sets or retrieves the size of the control.
        ///</summary>
        public JsString size{get;set;}
        ///<summary>
        ///Sets or retrieves a URL to be loaded by the object.
        ///</summary>
        public JsString src{get;set;}
        ///<summary>
        ///Sets or retrieves when a video clip file should begin playing.
        ///</summary>
        public JsString start{get;set;}
        ///<summary>
        ///Sets or retrieves the calculated width of the object.
        ///</summary>
        public JsString width{get;set;}
        /// <summary>
        /// Sets or retrieves the value indicating whether the control is selected.
        /// Possible values:
        ///	false	Default. Control is not selected.
        /// true	Control is selected.
        /// null	Control is not initialized.
        /// </summary>
        public bool status{get;set;}
        ///<summary>
        ///Sets or retrieves the name of the object.
        ///</summary>
        public JsString name{get;set;}
        ///<summary>
        ///Retrieves the file name of the input object after the text is set by user input.
        ///</summary>
        public JsString value{get;set;}
        ///<summary>
        ///Retrieves or initially sets the type of input control represented by the object.
        ///</summary>
        public JsString type{get;set;}
        ///<summary>
        ///Highlights the input area of a form element.
        ///</summary>
        public void select(){}
        ///<summary>
        ///Creates a TextRange object for the element.
        ///Use a text range to examine and modify the text within an object.
        ///</summary>
        ///<returns>Returns a TextRange object if successful, or null otherwise.</returns>
        public HtmlTextRange createTextRange(){return default(HtmlTextRange);}
        ///<summary>
        ///Sets or retrieves the maximum number of characters that the user can enter in a text control. 
        ///</summary>
        public JsNumber maxLength{get;set;}
        ///<summary>
        ///Fires when the contents of the object or selection have changed.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = "IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select.")]
        public new HtmlDomEventHandler onchange;
        ///<summary>
        ///Fires when the current selection changes.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public new HtmlDomEventHandler onselect;
        [HtmlSpecificationVersion(5)]
        public bool autofocus{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString placeholder{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool required{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong textLength{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool willValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public ValidityState validity{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString validationMessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setCustomValidity(JsString error){}
        [HtmlSpecificationVersion(5)]
        public NodeList labels{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong selectionStart{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong selectionEnd{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setSelectionRange(ulong start, ulong end){}
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
        public JsString firstChild{get;set;}
        ///<summary>
        ///Retrieves a reference to the last child in the childNodes collection of an object.
        ///</summary>
        public JsString lastChild{get;set;}
        ///<summary>
        ///Gets the number of characters in a TextNode object.
        ///</summary>
        public JsNumber length{get;set;}
        ///<summary>
        ///Divides a text node at the specified index. 
        ///</summary>
        ///<param name="index">A Integer that specifies the index of the JsString that indicates where the separation occurs. If a value is not provided, a new text node with no value is created.</param>
        ///<returns>This function returns the node containing the text after the offset.
        ///The text before the offset remains in the original text node.</returns>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, "IE handles the first splitText() fine, but after you’ve normalized the text IE doesn’t split it any more.")]
        public HtmlTextNode splitText(JsNumber index){return default(HtmlTextNode);}
        ///<summary>
        ///Divides a text node at the specified index. 
        ///</summary>
        ///<returns>This function returns the node containing the text after the offset.
        ///The text before the offset remains in the original text node.</returns>
        [JsMethod(NativeOverloads = true)]
        public HtmlTextNode splitText(){return default(HtmlTextNode);}
        ///<summary>
        ///Sets or gets the value of a TextNode object.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsString data{get;set;}
        internal  HtmlTextNode(){}
        ///<summary>
        ///Adds a new character JsString to the end of the object.
        ///</summary>
        ///<param name="sString"></param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, "IE8 appends the text, but doesn’t show it until you click the element.")]
        public void appendData(JsString sString){}
        ///<summary>
        ///Removes a specified range of characters from the object.
        ///</summary>
        ///<param name="nOffset">Integer that specifies the offset from which to start.</param>
        ///<param name="nCount">Integer that specifies the number of characters to remove.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void deleteData(JsNumber nOffset, JsNumber nCount){}
        ///<summary>
        ///Inserts a new character JsString in the object at a specified offset.
        ///</summary>
        ///<param name="nOffset">Integer that specifies the offset from which to start.</param>
        ///<param name="sString">String that specifies the new character JsString.</param>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void insertData(JsNumber nOffset, JsString sString){}
        ///<summary>
        ///Replaces a specified range of characters in the object with a new character JsString.
        ///</summary>
        ///<param name="nOffset">Integer that specifies the offset from which to start.</param>
        ///<param name="nCount">Integer that specifies the number of characters to replace.</param>
        ///<param name="sString">String that specifies the new character JsString.</param>
        ///<remarks>
        ///f the sum of the nOffset and nCount parameters exceeds the number of characters in the object, then all the characters to the end of the data are replaced.
        ///</remarks>
        [JsMethod(NativeOverloads = true)]
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void replaceData(JsNumber nOffset, JsNumber nCount, JsString sString){}
        ///<summary>
        ///Extracts a range of characters from the object.
        ///</summary>
        ///<param name="nOffset">Integer that specifies the offset from which to start.</param>
        ///<param name="nCount">Integer that specifies the number of characters to extract.</param>
        [SupportedBrowsers(BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void substringData(JsNumber nOffset, JsNumber nCount){}
        ///<summary>
        ///This read-only property is useful if you want to get the entire text at a certain point and don’t want to be bothered by borders between text nodes.
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10)]
        public JsString wholeText{get;set;}
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
        [JsMethod(NativeOverloads = true)]
        public HtmlTextRange createRange(){return default(HtmlTextRange);}
        ///<summary>
        ///Clears the contents of the selection. 
        ///</summary>
        public void clear(){}
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
        [JsMethod(NativeOverloads = true)]
        public bool findText(JsString text){return default(bool);}
        ///<summary>
        ///Searches for text in the document and positions the start and end points of the range to encompass the search JsString.
        ///</summary>
        ///<param name="text">String that specifies the text to find.</param>
        ///<param name="searchScope">Integer that specifies the number of characters to search from the starting point of the range. A positive integer indicates a forward search; a negative integer indicates a backward search. </param>
        ///<returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
        [JsMethod(NativeOverloads = true)]
        public bool findText(JsString text, JsNumber searchScope){return default(bool);}
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
        [JsMethod(NativeOverloads = true)]
        public bool findText(JsString text, JsNumber searchScope, JsNumber flags){return default(bool);}
        ///<summary>
        ///Retrieves the parent element for the given text range.
        ///</summary>
        ///<returns>Returns the parent element object if successful, or null otherwise.</returns>
        public HtmlElement parentElement(){return default(HtmlElement);}
        ///<summary>
        ///Retrieves the distance between the left edge of the rectangle that bounds the TextRange object and the left side of the object that contains the TextRange.
        ///</summary>
        public JsNumber boundingLeft{get{return default(JsNumber);}
        }
        ///<summary>
        ///Retrieves the width of the rectangle that bounds the TextRange object. 
        ///</summary>
        public JsNumber boundingWidth{get{return default(JsNumber);}
        }
        ///<summary>
        ///Retrieves the distance between the top edge of the rectangle that bounds the TextRange object and the top side of the object that contains the TextRange. 
        ///</summary>
        public JsNumber boundingTop{get{return default(JsNumber);}
        }
        ///<summary>
        ///Retrieves the height of the rectangle that bounds the TextRange object. 
        ///</summary>
        public JsNumber boundingHeight{get{return default(JsNumber);}
        }
        ///<summary>
        ///Retrieves the calculated top position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        public JsNumber offsetTop{get{return default(JsNumber);}
        }
        ///<summary>
        ///Retrieves the calculated left position of the object relative to the layout or coordinate parent, as specified by the offsetParent property. 
        ///</summary>
        public JsNumber offsetLeft{get{return default(JsNumber);}
        }
        ///<summary>
        ///Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
        ///</summary>
        public JsNumber scrollTop{get{return default(JsNumber);}
        }
        ///<summary>
        ///Makes the selection equal to the current object. 
        ///</summary>
        public void select(){}
        ///<summary>
        ///Moves the text range so that the start and end positions of the range encompass the text in the given element.
        ///</summary>
        ///<param name="p"></param>
        [JsMethod(NativeOverloads = true)]
        public void moveToElementText(HtmlElement p){}
        /// <summary>
        /// Causes the object to scroll into view, aligning it either at the top or bottom of the window.
        /// </summary>
        /// <param name="bAlignToTop">Boolean that specifies one of the following values:
        ///														true - Default. Scrolls the object so that top of the object is visible at the top of the window.
        ///														false - Scrolls the object so that the bottom of the object is visible at the bottom of the window</param>
        [JsMethod(NativeOverloads = true)]
        public void scrollIntoView(bool bAlignToTop){}
        ///<summary>
        ///Sets or retrieves the text contained within the range. 
        ///</summary>
        public JsString text{get;set;}
        ///<summary>
        ///Retrieves the HTML source as a valid HTML fragment. 
        ///</summary>
        public JsString htmlText{get{return default(JsString);}
        }
        ///<summary>
        ///Collapses the given text range and moves the empty range by the given number of units
        ///</summary>
        ///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit.</param>
        ///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
        [JsMethod(NativeOverloads = true)]
        public JsNumber move(JsString sUnit, JsNumber iCount){return default(JsNumber);}
        ///<summary>
        ///Returns a duplicate of the TextRange.
        ///</summary>
        ///<returns>Returns a TextRange object.</returns>
        public HtmlTextRange duplicate(){return default(HtmlTextRange);}
        ///<summary>
        ///Sets the endpoint of one range based on the endpoint of another range.
        ///</summary>
        ///<param name="sType">Required. String that specifies the endpoint to transfer using one of the following values: startToEnd, startToStart, endToStart, endToEnd</param>
        ///<param name="oTextRange">Required. TextRange object from which the source endpoint is to be taken.</param>
        [JsMethod(NativeOverloads = true)]
        public void setEndPoint(JsString sType, HtmlTextRange oTextRange){}
        ///<summary>
        ///Pastes HTML text into the given text range, replacing any previous text and HTML elements in the range.
        ///</summary>
        ///<param name="sHTMLText">Required. String that specifies the HTML text to paste. The JsString can contain text and any combination of the HTML tags described in HTML Elements.</param>
        [JsMethod(NativeOverloads = true)]
        public void pasteHTML(JsString sHTMLText){}
        ///<summary>
        ///Moves the start and end positions of the text range to the given point.
        ///</summary>
        ///<param name="x">Required. Integer that specifies the horizontal offset relative to the upper-left corner of the window, in pixels.</param>
        ///<param name="y">Required. Integer that specifies the vertical offset relative to the upper-left corner of the window, in pixels.</param>
        [JsMethod(NativeOverloads = true)]
        public void moveToPoint(JsNumber x, JsNumber y){}
        ///<summary>
        ///Returns a value indicating whether the specified range is equal to the current range.
        ///</summary>
        ///<param name="oCompareRange">Required. TextRange object to compare with the current TextRange object. </param>
        ///<returns>Boolean that returns true if oCompareRange is equal to the parent object, otherwise false.</returns>
        [JsMethod(NativeOverloads = true)]
        public bool isEqual(HtmlTextRange oCompareRange){return default(bool);}
        ///<summary>
        ///Changes the start position of the range.
        ///</summary>
        ///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit</param>
        ///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber moveEnd(JsString sUnit, JsNumber iCount){return default(JsNumber);}
        ///<summary>
        ///Changes the end position of the range.
        ///</summary>
        ///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit</param>
        ///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public JsNumber moveStart(JsString sUnit, JsNumber iCount){return default(JsNumber);}
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
        [JsMethod(NativeOverloads = true)]
        public void collapse(bool bStart){}
        ///<summary>
        ///Moves the insertion point to the beginning or end of the current range. 
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public void collapse(){}
        ///<summary>
        ///Returns a value indicating whether one range is contained within another.
        ///</summary>
        ///<param name="range2">TextRange object that might be contained</param>
        ///<returns>Boolean that returns one of the following possible values.
        ///true oRange is contained within or is equal to the TextRange object on which the method is called. 
        ///false oRange is not contained within the TextRange object on which the method is called. 
        ///</returns>
        [JsMethod(NativeOverloads = true)]
        public bool inRange(HtmlTextRange range2){return default(bool);}
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
        [JsMethod(NativeOverloads = true)]
        public JsNumber compareEndPoints(JsString type, HtmlTextRange range){return default(JsNumber);}
        ///<summary>
        ///Retrieves a bookmark (opaque JsString) that can be used with moveToBookmark to return to the same range. 
        ///</summary>
        ///<returns>String. Returns the bookmark if successfully retrieved, or null otherwise. </returns>
        public JsString getBookmark(){return default(JsString);}
        ///<summary>
        ///Moves to a bookmark.
        ///</summary>
        ///<param name="bookmark">String that specifies the bookmark to move to. </param>
        ///<returns>Boolean that returns one of the following possible values:
        ///true Successfully moved to the bookmark. 
        ///false Move to the bookmark failed. </returns>
        [JsMethod(NativeOverloads = true)]
        public bool moveToBookmark(JsString bookmark){return default(bool);}
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
        public HtmlTextRectangle this[JsNumber index]{get{return default(HtmlTextRectangle);}set{}}
        public JsNumber length;
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
        internal  HtmlTitle(){}
        [HtmlSpecificationVersion(5)]
        public JsString text{get;set;}
    }
    #endregion
    #region HtmlUnorderedList
    ///<summary>
    ///Represents an unordered list
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "UNORDEREDLIST")]
    public partial class HtmlUnorderedList : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString compact{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
    }
    #endregion
    #region HtmlWindow
    [JsType(JsMode.Prototype, Export = false, NativeOverloads = true, PropertiesAsFields = true)]
    public partial class HtmlWindow : Navigator, WindowModal, WindowTimers
    {
        [HtmlSpecificationVersion(5)]
        public WindowProxy this[ulong index] { get { return default(WindowProxy); } set { } }

        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8|BrowserTypes.IE8AsIE7, "Use event handler's argument")]
        public HtmlDomEventArgs @event{get;set;}
        [JsMethod(NativeOverloads = true)]
        public void resizeBy(JsNumber x, JsNumber y){}
        ///<summary>
        ///Causes the element to lose focus and fires the onblur event.
        ///</summary>
        public void blur(){}
        ///<summary>
        ///Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window. 
        ///</summary>
        public JsNumber scrollTop;
        ///<summary>
        ///Retrieves the x-coordinate of the upper left-hand corner of the browser's client area, relative to the upper left-hand corner of the screen. 
        ///</summary>
        public JsNumber screenLeft{get{return default(JsNumber);}
        }
        ///<summary>
        ///Retrieves the y-coordinate of the top corner of the browser's client area, relative to the top corner of the screen.
        ///</summary>
        public JsNumber screenTop{get{return default(JsNumber);}
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
        [JsMethod(NativeOverloads = true)]
        public JsString prompt(JsString message, JsString defaultValue){return default(JsString);}
        ///<summary>
        ///Displays a dialog box that prompts the user with a message and an input field.
        ///</summary>
        ///<param name="message">Optional. String that specifies the message to display in the dialog box. By default, this parameter is set to "".</param>
        ///<returns>String or Integer. Returns the value typed in by the user.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString prompt(JsString message){return default(JsString);}
        ///<summary>
        ///Displays a dialog box that prompts the user with a message and an input field.
        ///</summary>
        ///<returns>String or Integer. Returns the value typed in by the user.</returns>
        [JsMethod(NativeOverloads = true)]
        public JsString prompt(){return default(JsString);}
        ///<summary>
        ///Invokes a method after a specified number of milliseconds has elapsed. 
        ///</summary>
        ///<param name="action">a JsFunction to invoke</param>
        ///<param name="ms">Delay, in milliseconds, before invoking the method</param>
        ///<returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setTimeout(JsFunction action, JsNumber ms){return default(JsNumber);}
        ///<summary>
        ///Invokes a method after a specified number of milliseconds has elapsed. 
        ///</summary>
        ///<param name="action">a JsFunction to invoke</param>
        ///<param name="ms">Delay, in milliseconds, before invoking the method</param>
        ///<returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setTimeout(JsAction action, JsNumber ms){return default(JsNumber);}
        ///<summary>
        ///Cancels a time-out that was set with the setTimeout method. 
        ///</summary>
        ///<param name="id">Required. Integer that specifies the time-out setting returned by a previous call to the setTimeout method.</param>
        [JsMethod(NativeOverloads = true)]
        public void clearTimeout(JsNumber id){}
        ///<summary>
        ///Opens a new window and loads the document specified by a given URL.
        ///</summary>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public HtmlWindow open(){return default(HtmlWindow);}
        ///<summary>
        ///Opens a new window and loads the document specified by a given URL.
        ///</summary>
        ///<param name="sURL">
        ///String that specifies the URL of the document to display. 
        ///If no URL is specified, a new window with about:blank is displayed.
        ///</param>
        ///<returns></returns>
        [JsMethod(NativeOverloads = true)]
        public HtmlWindow open(JsString sURL){return default(HtmlWindow);}
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
        [JsMethod(NativeOverloads = true)]
        public HtmlWindow open(JsString sURL, JsString sName){return default(HtmlWindow);}
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
        [JsMethod(NativeOverloads = true)]
        public HtmlWindow open(JsString sURL, JsString sName, JsString sFeatures){return default(HtmlWindow);}
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
        [JsMethod(NativeOverloads = true)]
        public HtmlWindow open(JsString sURL, JsString sName, JsString sFeatures, bool bReplace){return default(HtmlWindow);}
        ///<summary>
        ///Retrieves whether the referenced window is closed.
        ///</summary>
        public bool closed;
        ///<summary>
        ///Closes the current browser window.
        ///</summary>
        public void close(){}
        ///<summary>
        ///Contains information about the current URL. 
        ///</summary>
        public HtmlWindowLocation location;
        ///<summary>
        ///Displays a dialog box containing an application-defined message. 
        ///</summary>
        ///<param name="message">Optional. String that specifies the message to display in the dialog box.</param>
        ///<remarks>You cannot change the title bar of the Alert dialog box.</remarks>
        [JsMethod(NativeOverloads = true)]
        public void alert(object message){}
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
        [JsMethod(NativeOverloads = true)]
        public bool confirm(JsString message){return default(bool);}
        ///<summary>
        ///Provides access to predefined clipboard formats for use in editing operations.
        ///</summary>
        public HtmlClipboardData clipboardData{get{return default(HtmlClipboardData);}
        }
        ///<summary>
        ///Scrolls the window to the specified x- and y-offset. 
        ///</summary>
        ///<param name="x">Required. Integer that specifies the horizontal scroll offset, in pixels.</param>
        ///<param name="y">Required. Integer that specifies the vertical scroll offset, in pixels.</param>
        [JsMethod(NativeOverloads = true)]
        public void scrollTo(double x, double y){}
        ///<summary>
        ///Causes the window to scroll relative to the current scrolled position by the specified x- and y-pixel offset. 
        ///</summary>
        ///<param name="x">Required. Integer that specifies the horizontal scroll offset, in pixels. Positive values scroll the window right, and negative values scroll it left.</param>
        ///<param name="y">Required. Integer that specifies the vertical scroll offset, in pixels. Positive values scroll the window down, and negative values scroll it up.</param>
        [JsMethod(NativeOverloads = true)]
        public void scrollBy(double x, double y){}
        ///<summary>
        ///Causes the element to receive the focus and executes the code specified by the onfocus event. 
        ///</summary>
        public void focus(){}
        ///<summary>
        ///Contains information about the client's screen and rendering capabilities.
        ///</summary>
        public HtmlScreen screen{get;set;}
        [JsMethod(NativeOverloads = true)]
        public JsNumber setInterval(JsFunction func, JsNumber ms){return default(JsNumber);}
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setInterval(JsAction func, JsNumber ms){return default(JsNumber);}
        [JsMethod(NativeOverloads = true)]
        public JsNumber clearInterval(JsNumber ms){return default(JsNumber);}
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void attachEvent(JsString eventName, HtmlDomEventHandler handler){}
        ///<summary>
        ///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        ///<param name="useCapture"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void addEventListener(JsString eventName, HtmlDomEventHandler handler, bool useCapture){}
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void detachEvent(JsString eventName, HtmlDomEventHandler handler){}
        ///<summary>
        ///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
        ///</summary>
        ///<param name="eventName"></param>
        ///<param name="handler"></param>
        ///<param name="useCapture"></param>
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public void removeEventListener(JsString eventName, HtmlDomEventHandler handler, bool useCapture){}
        ///<summary>
        ///Returns the computed style of an element. Computed style represents the final computed values of all CSS properties for the element.
        ///</summary>
        ///<param name="el">an element</param>
        ///<param name="pseudoElt">a JsString specifying the pseudo-element to match. Must be null for regular elements.</param>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public HtmlElementStyle getComputedStyle(HtmlElement el, JsString pseudoElt){return default(HtmlElementStyle);}
        ///<summary>
        ///Returns the computed style of an element. Computed style represents the final computed values of all CSS properties for the element.
        ///</summary>
        ///<param name="el">an element</param>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        [JsMethod(NativeOverloads = true)]
        public HtmlElementStyle getComputedStyle(HtmlElement el){return default(HtmlElementStyle);}
        ///<summary>
        ///The dimensions of the viewport (interior of the browser window) 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber innerWidth{get;set;}
        ///<summary>
        ///The dimensions of the viewport (interior of the browser window) 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber innerHeight{get;set;}
        ///<summary>
        ///The dimensions of the entire browser window (including taskbars and such) 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber outerWidth{get;set;}
        ///<summary>
        ///The dimensions of the entire browser window (including taskbars and such) 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber outerHeight{get;set;}
        ///<summary>
        ///The amount of pixels the entire pages has been scrolled 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber pageXOffset{get;set;}
        ///<summary>
        ///The amount of pixels the entire pages has been scrolled 
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public JsNumber pageYOffset{get;set;}
        ///<summary>
        ///The position of the browser window on the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57, @"Opera calculates the coordinates of the specific tab window relative to the encompassing browser window. This is understandable given its way of working with windows, but strictly speaking it's a bug. It should give the coordinates of the encompassing browser window relative to the screen.")]
        public JsNumber screenX{get;set;}
        ///<summary>
        ///The position of the browser window on the screen
        ///</summary>
        [SupportedBrowsers(BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Konqueror3_57, @"Opera calculates the coordinates of the specific tab window relative to the encompassing browser window. This is understandable given its way of working with windows, but strictly speaking it's a bug. It should give the coordinates of the encompassing browser window relative to the screen.")]
        public JsNumber screenY{get;set;}
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
Safari and Chrome don’t support these events on links and/or form fields in all circumstances.
Safari iPhone does not fire the event when the window loses the focus. ", NotSupportedRemark = "Konqueror doesn’t support these events on the browser window.")]
        public HtmlDomEventHandler onblur;
        ///<summary>
        ///Fires when an error occurs during object loading.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57, PartiallySupportedRemark = @"IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.")]
        public HtmlDomEventHandler onerror;
        ///<summary>
        ///Fires when the object receives focus.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, @"Konqueror doesn’t support these events on the browser window.", PartiallySupportedRemark = @"Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
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
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10|BrowserTypes.Konqueror3_57)]
        public HtmlDomEventHandler onresize;
        ///<summary>
        ///Fires when the user repositions the scroll box in the scroll bar on the object.
        ///</summary>		
        [SupportedBrowsers(BrowserTypes.IE5_5|BrowserTypes.IE6|BrowserTypes.IE7|BrowserTypes.IE8AsIE7|BrowserTypes.IE8|BrowserTypes.IE9|BrowserTypes.FireFox2|BrowserTypes.FireFox3|BrowserTypes.FireFox3_5|BrowserTypes.FireFox4|BrowserTypes.Saf3Win|BrowserTypes.Saf3_1Win|BrowserTypes.Saf4Win|BrowserTypes.Chrome2|BrowserTypes.Chrome3|BrowserTypes.Chrome4|BrowserTypes.Chrome5|BrowserTypes.Opera9|BrowserTypes.Opera10, PartiallySupportedRemark = @"Safari probably monitors scrollTop access in order to determine whether the user has scrolled an element with overflow: auto.")]
        public HtmlDomEventHandler onscroll;
        ///<summary>
        ///Fires immediately before the object is unloaded.
        ///</summary>		
        public HtmlDomEventHandler onunload;
        [HtmlSpecificationVersion(5)]
        public WindowProxy window{get;set;}
        public WindowProxy self{get;set;}
        public JsString name{get;set;}
        public History history{get;set;}
        [HtmlSpecificationVersion(5)]
        public UndoManager undoManager{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public Selection getSelection(){return default(Selection);}
        [HtmlSpecificationVersion(5)]
        public BarProp locationbar{get;set;}
        [HtmlSpecificationVersion(5)]
        public BarProp menubar{get;set;}
        [HtmlSpecificationVersion(5)]
        public BarProp personalbar{get;set;}
        [HtmlSpecificationVersion(5)]
        public BarProp scrollbars{get;set;}
        [HtmlSpecificationVersion(5)]
        public BarProp statusbar{get;set;}
        [HtmlSpecificationVersion(5)]
        public BarProp toolbar{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsArray<WindowProxy> frames{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong length{get;set;}
        [JsProperty(NativeIndexer = true)]
        public object this[JsString name]{get{return default(object);}set{}}
        [HtmlSpecificationVersion(5)]
        public Navigator navigator{get;set;}
        [HtmlSpecificationVersion(5)]
        public ApplicationCache applicationCache{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void print(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public object showModalDialog(JsString url, object argument){return default(object);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void postMessage(object message, JsString targetOrigin){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void postMessage(object message, MessagePortArray ports, JsString targetOrigin){}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onabort{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncanplay{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncanplaythrough{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onclick{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncontextmenu{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondblclick{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondrag{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragend{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragenter{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragleave{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragover{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondragstart{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondrop{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondurationchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onemptied{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onended{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onformchange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onforminput{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oninput{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oninvalid{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onkeydown{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onkeypress{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onkeyup{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadeddata{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadedmetadata{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onloadstart{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmessage{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmousedown{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmousemove{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmouseout{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmouseover{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmouseup{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmousewheel{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onoffline{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ononline{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpause{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onplay{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onplaying{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpagehide{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpageshow{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onpopstate{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onprogress{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onratechange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onreadystatechange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onredo{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onseeked{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onseeking{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onselect{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onshow{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onstalled{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onstorage{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onsubmit{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onsuspend{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ontimeupdate{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onundo{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onvolumechange{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onwaiting{get;set;}
        public JsString appVersion{get{return default(JsString);}
        }
        public JsString platform{get{return default(JsString);}
        }
        public JsString userAgent{get{return default(JsString);}
        }
        [HtmlSpecificationVersion(5)]
        public bool onLine{get{return default(bool);}
        }
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void registerProtocolHandler(JsString scheme, JsString url, JsString title){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void registerContentHandler(JsString mimeType, JsString url, JsString title){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void yieldForStorageUpdates(){}
        public object dialogArguments{get{return default(object);}
        }
        public JsString returnValue{get;set;}
    }
    #endregion
    #region History
    ///<summary>
    ///interface History { readonly attribute long length ; void go (in optional long delta); void back (); void forward (); void pushState (in any data, in DOMString title, in optional DOMString url); void replaceState (in any data, in DOMString title, in optional DOMString url); };
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "History")]
    public abstract partial class History
    {
        public long length{get;set;}
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void go(long delta){}
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void back(){}
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void forward(){}
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void pushState(object data, JsString title, JsString url){}
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void replaceState(object data, JsString title, JsString url){}
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
        public JsString href{get;set;}
        ///<summary>
        ///reloads the current page.
        ///</summary>
        public void reload(){}
        ///<summary>
        ///Sets or retrieves the subsection of the href property that follows the number sign (#).
        ///</summary>
        public JsString hash{get;set;}
        ///<summary>
        ///Sets or retrieves the hostname and port number of the location or URL.
        ///</summary>
        public JsString host{get;set;}
        ///<summary>
        ///Sets or retrieves the host name part of the location or URL.
        ///</summary>
        public JsString hostname{get;set;}
        ///<summary>
        ///Sets or retrieves the file name or path specified by the object.
        ///</summary>
        public JsString pathname{get;set;}
        ///<summary>
        ///Sets or retrieves the port number associated with a URL.
        ///</summary>
        public JsString port{get;set;}
        ///<summary>
        ///Sets or retrieves the protocol portion of a URL.
        ///</summary>
        public JsString protocol{get;set;}
        ///<summary>
        ///Sets or retrieves the substring of the href property that follows the question mark.
        ///</summary>
        public JsString search{get;set;}
        ///<summary>
        ///Replaces the current document by loading another document at the specified URL.
        ///</summary>
        [JsMethod(NativeOverloads = true)]
        public void assign(JsString url){}
        /// <summary>
        ///Replaces the current document by loading another document at the specified URL.
        /// </summary>
        [JsMethod(NativeOverloads = true)]
        public void replace(JsString url){}
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public JsString resolveURL(JsString url){return default(JsString);}
    }
    #endregion
    #region Navigator
    [JsType(JsMode.Prototype, Export = false, Name = "Navigator")]
    public partial interface Navigator : NavigatorID, NavigatorOnLine, NavigatorAbilities
    {
    }
    #endregion
    #region NavigatorAbilities
    [JsType(JsMode.Prototype, Export = false, Name = "NavigatorAbilities")]
    public partial interface NavigatorAbilities
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        void registerProtocolHandler(JsString scheme, JsString url, JsString title);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        void registerContentHandler(JsString mimeType, JsString url, JsString title);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        void yieldForStorageUpdates();
    }
    #endregion
    #region NavigatorID
    [JsType(JsMode.Prototype, Export = false, Name = "NavigatorID")]
    public partial interface NavigatorID
    {
        JsString appVersion{get;}
        JsString platform{get;}
        JsString userAgent{get;}
    }
    #endregion
    #region StyleFilter
    [JsType(JsMode.Prototype, Export = false, Name = "StyleFilter")]
    public partial class StyleFilter
    {
    }
    #endregion
    #region StyleFilterCollection
    [JsType(JsMode.Prototype, Export = false, Name = "StyleFilterCollection")]
    public partial class StyleFilterCollection
    {
        [JsMethod(NativeOverloads = true)]
        public StyleFilter item(JsString name){return default(StyleFilter);}
    }
    #endregion
    #region WindowModal
    ///<summary>
    ///6.5.6.1 Event handlers
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "WindowModal")]
    public partial interface WindowModal
    {
        object dialogArguments{get;}
        JsString returnValue{get;set;}
    }
    #endregion
    #region WindowTimers
    [JsType(JsMode.Prototype, Export = false, Name = "WindowTimers")]
    public partial interface WindowTimers
    {
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        JsNumber setTimeout(JsFunction action, JsNumber ms);
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        JsNumber setTimeout(JsAction action, JsNumber ms);
        [JsMethod(NativeOverloads = true)]
        void clearTimeout(JsNumber id);
        [JsMethod(NativeOverloads = true)]
        JsNumber setInterval(JsFunction func, JsNumber ms);
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        JsNumber setInterval(JsAction func, JsNumber ms);
        [JsMethod(NativeOverloads = true)]
        JsNumber clearInterval(JsNumber ms);
    }
    #endregion
    #region XmlHttpRequest
    public partial interface XmlHttpRequest
    {
        [JsMethod(NativeOverloads = true)]
        void open(JsString method, JsString address, bool async);
        [JsMethod(NativeOverloads = true)]
        void send(JsString body);
        JsString responseText{get;}
        JsFunction onreadystatechange{get;set;}
        JsNumber readyState{get;}
        JsNumber status{get;}
        JsString statusText{get;}
    }
    #endregion
    #region ApplicationCache
    ///<summary>
    ///interface ApplicationCache { // update status const unsigned short UNCACHED = 0; const unsigned short IDLE = 1; const unsigned short CHECKING = 2; const unsigned short DOWNLOADING = 3; const unsigned short UPDATEREADY = 4; const unsigned short OBSOLETE = 5; readonly attribute unsigned short status ; // updates void update (); void swapCache (); // events attribute Function onchecking ; attribute Function onerror ; attribute Function onnoupdate ; attribute Function ondownloading ; attribute Function onprogress ; attribute Function onupdateready ; attribute Function oncached ; attribute Function onobsolete ; }; ApplicationCache implements EventTarget ;
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "ApplicationCache")]
    public abstract partial class ApplicationCache : EventTarget
    {
        const ushort UNCACHED = 0;
        const ushort IDLE = 1;
        const ushort CHECKING = 2;
        const ushort DOWNLOADING = 3;
        const ushort UPDATEREADY = 4;
        const ushort OBSOLETE = 5;
        [HtmlSpecificationVersion(5)]
        public ushort status{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void update(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void swapCache(){}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onchecking{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onerror{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onnoupdate{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler ondownloading{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onprogress{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onupdateready{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler oncached{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onobsolete{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void addEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void removeEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool dispatchEvent(HtmlDomEventArgs evt){return default(bool);}
    }
    #endregion
    #region BarProp
    ///<summary>
    ///To allow Web pages to integrate with Web browsers, certain Web browser interface elements are exposed in a limited way to scripts in Web pages.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "BarProp")]
    public abstract partial class BarProp
    {
        [HtmlSpecificationVersion(5)]
        public bool visible{get;set;}
    }
    #endregion
    #region CanvasGradient
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "CanvasGradient")]
    public abstract partial class CanvasGradient
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void addColorStop(float offset, JsString color){}
    }
    #endregion
    #region CanvasPattern
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "CanvasPattern")]
    public abstract partial class CanvasPattern
    {
    }
    #endregion
    #region CanvasPixelArray
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "CanvasPixelArray")]
    public abstract partial class CanvasPixelArray
    {
        [HtmlSpecificationVersion(5)]
        public ulong length{get;set;}
        [HtmlSpecificationVersion(5)]
        public ushort this[ulong index]{get{return default(ushort);}set{}}
    }
    #endregion
    #region CanvasRenderingContext2D
    ///<summary>
    ///This section is non-normative.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "CanvasRenderingContext2D")]
    public abstract partial class CanvasRenderingContext2D
    {
        [HtmlSpecificationVersion(5)]
        public HtmlCanvasElement canvas{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void save(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void restore(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void scale(float x, float y){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void rotate(float angle){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void translate(float x, float y){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void transform(float m11, float m12, float m21, float m22, float dx, float dy){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setTransform(float m11, float m12, float m21, float m22, float dx, float dy){}
        [HtmlSpecificationVersion(5)]
        public float globalAlpha{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString globalCompositeOperation{get;set;}
        [HtmlSpecificationVersion(5)]
        public object strokeStyle{get;set;}
        [HtmlSpecificationVersion(5)]
        public object fillStyle{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public CanvasGradient createLinearGradient(float x0, float y0, float x1, float y1){return default(CanvasGradient);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public CanvasGradient createRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1){return default(CanvasGradient);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public CanvasPattern createPattern(HtmlImage image, JsString repetition){return default(CanvasPattern);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public CanvasPattern createPattern(HtmlCanvasElement image, JsString repetition){return default(CanvasPattern);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public CanvasPattern createPattern(HtmlVideoElement image, JsString repetition){return default(CanvasPattern);}
        [HtmlSpecificationVersion(5)]
        public float lineWidth{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString lineCap{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString lineJoin{get;set;}
        [HtmlSpecificationVersion(5)]
        public float miterLimit{get;set;}
        [HtmlSpecificationVersion(5)]
        public float shadowOffsetX{get;set;}
        [HtmlSpecificationVersion(5)]
        public float shadowOffsetY{get;set;}
        [HtmlSpecificationVersion(5)]
        public float shadowBlur{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString shadowColor{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void clearRect(float x, float y, float w, float h){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void fillRect(float x, float y, float w, float h){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void strokeRect(float x, float y, float w, float h){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void beginPath(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void closePath(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void moveTo(float x, float y){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void lineTo(float x, float y){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void quadraticCurveTo(float cpx, float cpy, float x, float y){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void bezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void arcTo(float x1, float y1, float x2, float y2, float radius){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void rect(float x, float y, float w, float h){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void arc(float x, float y, float radius, float startAngle, float endAngle, bool anticlockwise){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void fill(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void stroke(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void clip(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool isPointInPath(float x, float y){return default(bool);}
        [HtmlSpecificationVersion(5)]
        public JsString font{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString textAlign{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString textBaseline{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void fillText(JsString text, float x, float y, float maxWidth){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void strokeText(JsString text, float x, float y, float maxWidth){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public TextMetrics measureText(JsString text){return default(TextMetrics);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void drawImage(HtmlImage image, float dx, float dy, float dw, float dh){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void drawImage(HtmlImage image, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void drawImage(HtmlCanvasElement image, float dx, float dy, float dw, float dh){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void drawImage(HtmlCanvasElement image, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void drawImage(HtmlVideoElement image, float dx, float dy, float dw, float dh){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void drawImage(HtmlVideoElement image, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public ImageData createImageData(float sw, float sh){return default(ImageData);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public ImageData createImageData(ImageData imagedata){return default(ImageData);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public ImageData getImageData(float sx, float sy, float sw, float sh){return default(ImageData);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void putImageData(ImageData imagedata, float dx, float dy, float dirtyX, float dirtyY, float dirtyWidth, float dirtyHeight){}
    }
    #endregion
    #region DataTransfer
    ///<summary>
    ///The drag-and-drop processing model involves several events. They all use the DragEvent interface.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "DataTransfer")]
    public abstract partial class DataTransfer
    {
        [HtmlSpecificationVersion(5)]
        public JsString dropEffect{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString effectAllowed{get;set;}
        [HtmlSpecificationVersion(5)]
        public DOMStringList types{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void clearData(JsString format){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setData(JsString format, JsString data){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public JsString getData(JsString format){return default(JsString);}
        [HtmlSpecificationVersion(5)]
        public FileList files{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setDragImage(Element image, long x, long y){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void addElement(Element element){}
    }
    #endregion
    #region DOMSettableTokenList
    ///<summary>
    ///The DOMSettableTokenList interface is the same as the DOMTokenList interface, except that it allows the underlying JsString to be directly changed.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "DOMSettableTokenList")]
    public abstract partial class DOMSettableTokenList : DOMTokenList
    {
        [HtmlSpecificationVersion(5)]
        public JsString value{get;set;}
    }
    #endregion
    #region DOMStringMap
    ///<summary>
    ///The DOMStringMap interface represents a set of name-value pairs. It exposes these using the scripting language's native mechanisms for property access.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "DOMStringMap")]
    public abstract partial class DOMStringMap
    {
        [HtmlSpecificationVersion(5)]
        public JsString this[JsString name]{get{return default(JsString);}set{}}
    }
    #endregion
    #region DOMTokenList
    ///<summary>
    ///The DOMTokenList interface represents an interface to an underlying JsString that consists of a set of space-separated tokens .
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "DOMTokenList")]
    public abstract partial class DOMTokenList
    {
        [HtmlSpecificationVersion(5)]
        public ulong length{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString this[ulong index]{get{return default(JsString);}set{}}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool contains(JsString token){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void add(JsString token){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void remove(JsString token){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool toggle(JsString token){return default(bool);}
    }
    #endregion
    #region HtmlAreaElement
    ///<summary>
    ///The area element represents either a hyperlink with some text and a corresponding area on an image map , or a dead area on an image map.User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLAreaElement")]
    public abstract partial class HtmlAreaElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString alt{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString coords{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString shape{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString href{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString target{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString ping{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString rel{get;set;}
        [HtmlSpecificationVersion(5)]
        public DOMTokenList relList{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString media{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString hreflang{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString protocol{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString host{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString hostname{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString port{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString pathname{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString search{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString hash{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool noHref{get;set;}
    }
    #endregion
    #region HtmlAudioElement
    ///<summary>
    ///An audio element represents a sound or audio stream.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "Audio")]
    public abstract partial class HtmlAudioElement : HtmlMediaElement
    {
        public  HtmlAudioElement(){}
        public  HtmlAudioElement(JsString src){}
    }
    #endregion
    #region HtmlCanvasElement
    ///<summary>
    ///The canvas element provides scripts with a resolution-dependent bitmap canvas, which can be used for rendering graphs, game graphics, or other visual images on the fly.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "CANVAS")]
    public abstract partial class HtmlCanvasElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public ulong width{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong height{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public JsString toDataURL(JsString type, params object[] args){return default(JsString);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public object getContext(JsString contextId){return default(object);}
    }
    #endregion
    #region HtmlCommandElement
    ///<summary>
    ///The command element represents a command that the user can invoke.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLCommandElement")]
    public abstract partial class HtmlCommandElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public new JsString label{get;set;}
        [HtmlSpecificationVersion(5)]
        public new JsString icon{get;set;}
        [HtmlSpecificationVersion(5)]
        public new bool disabled{get;set;}
        [HtmlSpecificationVersion(5)]
        public new bool @checked{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString radiogroup{get;set;}
    }
    #endregion
    #region HtmlDataListElement
    ///<summary>
    ///The datalist element represents a set of option elements that represent predefined options for other controls. The contents of the element represents fallback content for legacy user agents, intermixed with option elements that represent the predefined options. In the rendering, the datalist element represents nothing and it, along with its children, should be hidden .
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLDataListElement")]
    public abstract partial class HtmlDataListElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection options{get;set;}
    }
    #endregion
    #region HtmlDetailsElement
    ///<summary>
    ///The details element represents a disclosure widget from which the user can obtain additional information or controls.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLDetailsElement")]
    public abstract partial class HtmlDetailsElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public bool open{get;set;}
    }
    #endregion
    #region HtmlDeviceElement
    ///<summary>
    ///The device element represents a device selector, to allow the user to give the page access to a device, for example a video camera.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLDeviceElement")]
    public abstract partial class HtmlDeviceElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public object data{get;set;}
    }
    #endregion
    #region HtmlDirectoryElement
    ///<summary>
    ///User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLDirectoryElement")]
    public abstract partial class HtmlDirectoryElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString compact{get;set;}
    }
    #endregion
    #region HtmlDListElement
    ///<summary>
    ///The dl element represents an association list consisting of zero or more name-value groups (a description list). Each group must consist of one or more names ( dt elements) followed by one or more values ( dd elements). Within a single dl element, there should not be more than one dt element for each name.User agents must treat acronym elements in a manner equivalent to abbr elements.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLDListElement")]
    public abstract partial class HtmlDListElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString compact{get;set;}
    }
    #endregion
    #region HtmlFormControlsCollection
    ///<summary>
    ///The HTMLCollection , HTMLAllCollection , HTMLFormControlsCollection , HTMLOptionsCollection , and HTMLPropertiesCollection interfaces represent various lists of DOM nodes. Collectively, objects implementing these interfaces are called collections.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLFormControlsCollection")]
    public abstract partial class HtmlFormControlsCollection : HtmlElementCollection
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public object namedItem(JsString name){return default(object);}
    }
    #endregion
    #region HtmlKeygenElement
    ///<summary>
    ///The keygen element represents a key pair generator control. When the control's form is submitted, the private key is stored in the local keystore, and the public key is packaged and sent to the server.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLKeygenElement")]
    public abstract partial class HtmlKeygenElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public bool autofocus{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString challenge{get;set;}
        [HtmlSpecificationVersion(5)]
        public new bool disabled{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlForm form{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString keytype{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool willValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public ValidityState validity{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString validationMessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setCustomValidity(JsString error){}
        [HtmlSpecificationVersion(5)]
        public NodeList labels{get;set;}
    }
    #endregion
    #region HtmlMediaElement
    ///<summary>
    ///Media elements implement the following interface:
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLMediaElement")]
    public abstract partial class HtmlMediaElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public MediaError error{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString src{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString currentSrc{get;set;}
        const ushort NETWORK_EMPTY = 0;
        const ushort NETWORK_IDLE = 1;
        const ushort NETWORK_LOADING = 2;
        const ushort NETWORK_NO_SOURCE = 3;
        [HtmlSpecificationVersion(5)]
        public ushort networkState{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool autobuffer{get;set;}
        [HtmlSpecificationVersion(5)]
        public TimeRanges buffered{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void load(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public JsString canPlayType(JsString type){return default(JsString);}
        const ushort HAVE_NOTHING = 0;
        const ushort HAVE_METADATA = 1;
        const ushort HAVE_CURRENT_DATA = 2;
        const ushort HAVE_FUTURE_DATA = 3;
        const ushort HAVE_ENOUGH_DATA = 4;
        [HtmlSpecificationVersion(5)]
        public ushort readyState{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool seeking{get;set;}
        [HtmlSpecificationVersion(5)]
        public float currentTime{get;set;}
        [HtmlSpecificationVersion(5)]
        public float startTime{get;set;}
        [HtmlSpecificationVersion(5)]
        public float duration{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool paused{get;set;}
        [HtmlSpecificationVersion(5)]
        public float defaultPlaybackRate{get;set;}
        [HtmlSpecificationVersion(5)]
        public float playbackRate{get;set;}
        [HtmlSpecificationVersion(5)]
        public TimeRanges played{get;set;}
        [HtmlSpecificationVersion(5)]
        public TimeRanges seekable{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool ended{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool autoplay{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool loop{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void play(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void pause(){}
        [HtmlSpecificationVersion(5)]
        public bool controls{get;set;}
        [HtmlSpecificationVersion(5)]
        public float volume{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool muted{get;set;}
    }
    #endregion
    #region HtmlMenuElement
    ///<summary>
    ///The menu element represents a list of commands.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLMenuElement")]
    public abstract partial class HtmlMenuElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public new JsString label{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString compact{get;set;}
    }
    #endregion
    #region HtmlMeterElement
    ///<summary>
    ///The meter element represents a scalar measurement within a known range, or a fractional value; for example disk usage, the relevance of a query result, or the fraction of a voting population to have selected a particular candidate.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLMeterElement")]
    public abstract partial class HtmlMeterElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public float value{get;set;}
        [HtmlSpecificationVersion(5)]
        public float min{get;set;}
        [HtmlSpecificationVersion(5)]
        public float max{get;set;}
        [HtmlSpecificationVersion(5)]
        public float low{get;set;}
        [HtmlSpecificationVersion(5)]
        public float high{get;set;}
        [HtmlSpecificationVersion(5)]
        public float optimum{get;set;}
    }
    #endregion
    #region HtmlModElement
    ///<summary>
    ///The cite attribute may be used to specify the address of a document that explains the change. When that document is long, for instance the minutes of a meeting, authors are encouraged to include a fragment identifier pointing to the specific part of that document that discusses the change.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLModElement")]
    public abstract partial class HtmlModElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString cite{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString dateTime{get;set;}
    }
    #endregion
    #region HtmlOptionsCollection
    ///<summary>
    ///The HTMLCollection , HTMLAllCollection , HTMLFormControlsCollection , HTMLOptionsCollection , and HTMLPropertiesCollection interfaces represent various lists of DOM nodes. Collectively, objects implementing these interfaces are called collections.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLOptionsCollection")]
    public abstract partial class HtmlOptionsCollection : HtmlElementCollection
    {
        [HtmlSpecificationVersion(5)]
        public new ulong length{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public object namedItem(JsString name){return default(object);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void add(HtmlElement element, HtmlElement before){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void add(HtmlElement element, long before){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void remove(long index){}
    }
    #endregion
    #region HtmlOutputElement
    ///<summary>
    ///The output element represents the result of a calculation.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLOutputElement")]
    public abstract partial class HtmlOutputElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString htmlFor{get;set;}
        [HtmlSpecificationVersion(5)]
        public HtmlForm form{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString defaultValue{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString value{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool willValidate{get;set;}
        [HtmlSpecificationVersion(5)]
        public ValidityState validity{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString validationMessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool checkValidity(){return default(bool);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void setCustomValidity(JsString error){}
    }
    #endregion
    #region HtmlParamElement
    ///<summary>
    ///The param element defines parameters for plugins invoked by object elements. It does not represent anything on its own.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLParamElement")]
    public abstract partial class HtmlParamElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString value{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString valueType{get;set;}
    }
    #endregion
    #region HtmlProgressElement
    ///<summary>
    ///The progress element represents the completion progress of a task. The progress is either indeterminate, indicating that progress is being made but that it is not clear how much more work remains to be done before the task is complete (e.g. because the task is waiting for a remote host to respond), or the progress is a number in the range zero to a maximum, giving the fraction of work that has so far been completed.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLProgressElement")]
    public abstract partial class HtmlProgressElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public float value{get;set;}
        [HtmlSpecificationVersion(5)]
        public float max{get;set;}
        [HtmlSpecificationVersion(5)]
        public float position{get;set;}
    }
    #endregion
    #region HtmlPropertiesCollection
    ///<summary>
    ///The HTMLCollection , HTMLAllCollection , HTMLFormControlsCollection , HTMLOptionsCollection , and HTMLPropertiesCollection interfaces represent various lists of DOM nodes. Collectively, objects implementing these interfaces are called collections.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLPropertiesCollection")]
    public abstract partial class HtmlPropertiesCollection : HtmlElementCollection
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public PropertyNodeList namedItem(JsString name){return default(PropertyNodeList);}
        [HtmlSpecificationVersion(5)]
        public DOMStringList names{get;set;}
    }
    #endregion
    #region HtmlSourceElement
    ///<summary>
    ///The source element allows authors to specify multiple media resources for media elements . It does not represent anything on its own.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLSourceElement")]
    public abstract partial class HtmlSourceElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString src{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString type{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString media{get;set;}
    }
    #endregion
    #region HtmlTableSectionElement
    ///<summary>
    ///The tbody element represents a block of rows that consist of a body of data for the parent table element, if the tbody element has a parent and it is a table .The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLTableSectionElement")]
    public abstract partial class HtmlTableSectionElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public HtmlElementCollection rows{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public HtmlElement insertRow(long index){return default(HtmlElement);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void deleteRow(long index){}
        [HtmlSpecificationVersion(5)]
        public JsString align{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString ch{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString chOff{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString vAlign{get;set;}
    }
    #endregion
    #region HtmlTimeElement
    ///<summary>
    ///The time element represents either a time on a 24 hour clock, or a precise date in the proleptic Gregorian calendar, optionally with a time and a time-zone offset. [GREGORIAN]
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLTimeElement")]
    public abstract partial class HtmlTimeElement : HtmlElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString dateTime{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool pubDate{get;set;}
        [HtmlSpecificationVersion(5)]
        public Date valueAsDate{get;set;}
    }
    #endregion
    #region HtmlUnknownElement
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLUnknownElement")]
    public abstract partial class HtmlUnknownElement : HtmlElement
    {
    }
    #endregion
    #region HtmlVideoElement
    ///<summary>
    ///A video element is used for playing videos or movies.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "HTMLVideoElement")]
    public abstract partial class HtmlVideoElement : HtmlMediaElement
    {
        [HtmlSpecificationVersion(5)]
        public JsString width{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString height{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong videoWidth{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong videoHeight{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString poster{get;set;}
    }
    #endregion
    #region ImageData
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "ImageData")]
    public abstract partial class ImageData
    {
        [HtmlSpecificationVersion(5)]
        public ulong width{get;set;}
        [HtmlSpecificationVersion(5)]
        public ulong height{get;set;}
        [HtmlSpecificationVersion(5)]
        public CanvasPixelArray data{get;set;}
    }
    #endregion
    #region MediaError
    ///<summary>
    ///Media elements implement the following interface:
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "MediaError")]
    public abstract partial class MediaError
    {
        const ushort MEDIA_ERR_ABORTED = 1;
        const ushort MEDIA_ERR_NETWORK = 2;
        const ushort MEDIA_ERR_DECODE = 3;
        const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
        [HtmlSpecificationVersion(5)]
        public ushort code{get;set;}
    }
    #endregion
    #region MessageChannel
    ///<summary>
    ///[ Constructor ] interface MessageChannel { readonly attribute MessagePort port1 ; readonly attribute MessagePort port2 ; };
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "MessageChannel")]
    public abstract partial class MessageChannel
    {
        [HtmlSpecificationVersion(5)]
        public MessagePort port1{get;set;}
        [HtmlSpecificationVersion(5)]
        public MessagePort port2{get;set;}
    }
    #endregion
    #region MessageEvent
    ///<summary>
    ///interface UndoManagerEvent : Event { readonly attribute any data ; void initUndoManagerEvent (in DOMString typeArg, in boolean canBubbleArg, in boolean cancelableArg, in any dataArg); };
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "MessageEvent")]
    public abstract partial class MessageEvent : EventArgs
    {
        [HtmlSpecificationVersion(5)]
        public object data{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString origin{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString lastEventId{get;set;}
        [HtmlSpecificationVersion(5)]
        public WindowProxy source{get;set;}
        [HtmlSpecificationVersion(5)]
        public MessagePortArray ports{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void initMessageEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, object dataArg, JsString originArg, JsString lastEventIdArg, WindowProxy sourceArg, MessagePortArray portsArg){}
    }
    #endregion
    #region MessagePort
    ///<summary>
    ///Each channel has two message ports. Data sent through one port is received by the other port, and vice versa.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "MessagePort")]
    public abstract partial class MessagePort : EventTarget
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void postMessage(object message, MessagePortArray ports){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void start(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void close(){}
        [HtmlSpecificationVersion(5)]
        public HtmlDomEventHandler onmessage{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void addEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void removeEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool dispatchEvent(HtmlDomEventArgs evt){return default(bool);}
    }
    #endregion
    #region MouseEvent
    [JsType(JsMode.Prototype, Export = false, Name = "MouseEvent")]
    public abstract partial class MouseEvent
    {
    }
    #endregion
    #region Element
    [JsType(JsMode.Prototype, Export = false, Name = "Element")]
    public abstract partial class Element
    {
    }
    #endregion
    #region WindowProxy
    [JsType(JsMode.Prototype, Export = false, Name = "WindowProxy")]
    public abstract partial class WindowProxy : HtmlWindow
    {
    }
    #endregion
    #region File
    [JsType(JsMode.Prototype, Export = false, Name = "File")]
    public abstract partial class File
    {
    }
    #endregion
    #region Document
    [JsType(JsMode.Prototype, Export = false, Name = "Document")]
    public abstract partial class Document
    {
    }
    #endregion
    #region Node
    [JsType(JsMode.Prototype, Export = false, Name = "Node")]
    public abstract partial class Node
    {
    }
    #endregion
    #region Date
    [JsType(JsMode.Prototype, Export = false, Name = "Date")]
    public abstract partial class Date : JsDate
    {
    }
    #endregion
    #region Range
    [JsType(JsMode.Prototype, Export = false, Name = "Range")]
    public abstract partial class Range
    {
    }
    #endregion
    #region NodeList
    [JsType(JsMode.Prototype, Export = false, Name = "NodeList")]
    public abstract partial class NodeList
    {
    }
    #endregion
    #region PropertyValueArray
    [JsType(JsMode.Prototype, Export = false, Name = "PropertyValueArray")]
    public abstract partial class PropertyValueArray : JsArray
    {
    }
    #endregion
    #region EventTarget
    public partial interface EventTarget
    {
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        void addEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture);
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        void removeEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture);
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        bool dispatchEvent(HtmlDomEventArgs evt);
    }
    #endregion
    #region LinkStyle
    public partial interface LinkStyle
    {
    }
    #endregion
    #region MessagePortArray
    [JsType(JsMode.Prototype, Export = false, Name = "MessagePortArray")]
    public partial class MessagePortArray : JsArray<MessagePort>
    {
    }
    #endregion
    #region DOMStringList
    [JsType(JsMode.Prototype, Export = false, Name = "DOMStringList")]
    public partial class DOMStringList : JsArray<JsString>
    {
    }
    #endregion
    #region AbstractView
    public partial interface AbstractView
    {
    }
    #endregion
    #region FileList
    public partial interface FileList
    {
    }
    #endregion
    #region NavigatorOnLine
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "NavigatorOnLine")]
    public partial interface NavigatorOnLine
    {
        [HtmlSpecificationVersion(5)]
        bool onLine{get;}
    }
    #endregion
    #region PopStateEvent
    ///<summary>
    ///When an entry in the session history is activated (which happens during session history traversal), the user agent must run the following steps: If the entry is a state object entry, let statebe a structured clone of that state object. Otherwise, let statebe null. Run the appropriate steps according to the conditions described:If the current document readiness is set to the JsString "complete"Synchronously fire a popstate event on the Windowobject of the Document, using the PopStateEventinterface, with the stateattribute set to the value of state. This event must bubble but not be cancelable and has no default action.OtherwiseLet the Document's pending state object be state. (If there was already a pending state object, the previous one is discarded.)The event will then be fired just after the load event.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "PopStateEvent")]
    public abstract partial class PopStateEvent : EventArgs
    {
        [HtmlSpecificationVersion(5)]
        public object state{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void initPopStateEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, object stateArg){}
    }
    #endregion
    #region PropertyNodeList
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "PropertyNodeList")]
    public abstract partial class PropertyNodeList : NodeList
    {
        [HtmlSpecificationVersion(5)]
        public PropertyValueArray values{get;set;}
    }
    #endregion
    #region RadioNodeList
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "RadioNodeList")]
    public abstract partial class RadioNodeList : NodeList
    {
        [HtmlSpecificationVersion(5)]
        public JsString value{get;set;}
    }
    #endregion
    #region Selection
    ///<summary>
    ///window. getSelection() document. getSelection() Returns the Selectionobject for the window, which stringifies to the text of the current selection.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "Selection")]
    public abstract partial class Selection
    {
        [HtmlSpecificationVersion(5)]
        public Node anchorNode{get;set;}
        [HtmlSpecificationVersion(5)]
        public long anchorOffset{get;set;}
        [HtmlSpecificationVersion(5)]
        public Node focusNode{get;set;}
        [HtmlSpecificationVersion(5)]
        public long focusOffset{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool isCollapsed{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void collapse(Node parentNode, long offset){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void collapseToStart(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void collapseToEnd(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void selectAllChildren(Node parentNode){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void deleteFromDocument(){}
        [HtmlSpecificationVersion(5)]
        public long rangeCount{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public Range getRangeAt(long index){return default(Range);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void addRange(Range range){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void removeRange(Range range){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void removeAllRanges(){}
    }
    #endregion
    #region Stream
    ///<summary>
    ///Categories Flow content. Phrasing content. Interactive content. Contexts in which this element may be used: Where phrasing content is expected. Content model: Empty. Content attributes: Global attributes type DOM interface: interface HTMLDeviceElement : HTMLElement { attribute DOMString type; readonly attribute any data; };
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "Stream")]
    public abstract partial class Stream
    {
        [HtmlSpecificationVersion(5)]
        public JsString URL{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public StreamRecorder record(){return default(StreamRecorder);}
    }
    #endregion
    #region StreamRecorder
    ///<summary>
    ///Categories Flow content. Phrasing content. Interactive content. Contexts in which this element may be used: Where phrasing content is expected. Content model: Empty. Content attributes: Global attributes type DOM interface: interface HTMLDeviceElement : HTMLElement { attribute DOMString type; readonly attribute any data; };
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "StreamRecorder")]
    public abstract partial class StreamRecorder
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public File stop(){return default(File);}
    }
    #endregion
    #region TextMetrics
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "TextMetrics")]
    public abstract partial class TextMetrics
    {
        [HtmlSpecificationVersion(5)]
        public float width{get;set;}
    }
    #endregion
    #region TimeRanges
    ///<summary>
    ///This section is non-normative.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "TimeRanges")]
    public abstract partial class TimeRanges
    {
        [HtmlSpecificationVersion(5)]
        public ulong length{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public float start(ulong index){return default(float);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public float end(ulong index){return default(float);}
    }
    #endregion
    #region UndoManager
    ///<summary>
    ///To manage undo object entries in the undo transaction history , the UndoManager interface can be used:
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "UndoManager")]
    public abstract partial class UndoManager
    {
        [HtmlSpecificationVersion(5)]
        public ulong length{get;set;}
        [HtmlSpecificationVersion(5)]
        public object this[ulong index]{get{return default(object);}set{}}
        [HtmlSpecificationVersion(5)]
        public ulong position{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public ulong add(object data, JsString title){return default(ulong);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void remove(ulong index){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void clearUndo(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void clearRedo(){}
    }
    #endregion
    #region UndoManagerEvent
    ///<summary>
    ///interface UndoManagerEvent : Event { readonly attribute any data ; void initUndoManagerEvent (in DOMString typeArg, in boolean canBubbleArg, in boolean cancelableArg, in any dataArg); };
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "UndoManagerEvent")]
    public abstract partial class UndoManagerEvent : EventArgs
    {
        [HtmlSpecificationVersion(5)]
        public object data{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void initUndoManagerEvent(JsString typeArg, bool canBubbleArg, bool cancelableArg, object dataArg){}
    }
    #endregion
    #region ValidityState
    ///<summary>
    ///Categories Flow content. Phrasing content. If the typeattribute is not in the Hidden state: Interactive content. Listed, labelable, submittable, and resettableform-associated element. Contexts in which this element may be used: Where phrasing content is expected. Content model: Empty. Content attributes: Global attributes accept alt autocomplete autofocus checked disabled form formaction formenctype formmethod formnovalidate formtarget height list max maxlength min multiple name pattern placeholder readonly required size src step type value width DOM interface: interface HTMLInputElement : HTMLElement { attribute DOMString accept; attribute DOMString alt; attribute boolean autocomplete; attribute boolean autofocus; attribute boolean defaultChecked; attribute boolean checked; attribute boolean disabled; readonly attribute HTMLFormElement form; readonly attribute FileListfiles; attribute DOMString formAction; attribute DOMString formEnctype; attribute DOMString formMethod; attribute boolean formNoValidate; attribute DOMString formTarget; attribute DOMString height; attribute boolean indeterminate; readonly attribute HTMLElement list; attribute DOMString max; attribute long maxLength; attribute DOMString min; attribute boolean multiple; attribute DOMString name; attribute DOMString pattern; attribute DOMString placeholder; attribute boolean readOnly; attribute boolean required; attribute unsigned long size; attribute DOMString src; attribute DOMString step; attribute DOMString type; attribute DOMString defaultValue; attribute DOMString value; attribute DatevalueAsDate; attribute float valueAsNumber; readonly attribute HTMLOptionElement selectedOption; attribute DOMString width; void stepUp(in optional long n); void stepDown(in optional long n); readonly attribute boolean willValidate; readonly attribute ValidityState validity; readonly attribute DOMString validationMessage; boolean checkValidity(); void setCustomValidity(in DOMString error); readonly attribute NodeListlabels; void select(); attribute unsigned long selectionStart; attribute unsigned long selectionEnd; void setSelectionRange(in unsigned long start, in unsigned long end); };
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "ValidityState")]
    public abstract partial class ValidityState
    {
        [HtmlSpecificationVersion(5)]
        public bool valueMissing{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool typeMismatch{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool patternMismatch{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool tooLong{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool rangeUnderflow{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool rangeOverflow{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool stepMismatch{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool customError{get;set;}
        [HtmlSpecificationVersion(5)]
        public bool valid{get;set;}
    }
    #endregion
    #region Database
    [JsType(JsMode.Prototype, Export = false, Name = "Database")]
    public partial interface Database
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void transaction(SQLTransactionCallback callback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void transaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void transaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void readTransaction(SQLTransactionCallback callback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void readTransaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void readTransaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);
        [HtmlSpecificationVersion(5)]
        JsString version{get;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void changeVersion(JsString oldVersion, JsString newVersion);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void changeVersion(JsString oldVersion, JsString newVersion, SQLTransactionCallback callback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void changeVersion(JsString oldVersion, JsString newVersion, SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void changeVersion(JsString oldVersion, JsString newVersion, SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, SQLVoidCallback successCallback);
    }
    #endregion
    #region DatabaseSync
    [JsType(JsMode.Prototype, Export = false, Name = "DatabaseSync")]
    public partial interface DatabaseSync
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void transaction(SQLTransactionSyncCallback callback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void readTransaction(SQLTransactionSyncCallback callback);
        [HtmlSpecificationVersion(5)]
        JsString version{get;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void changeVersion(JsString oldVersion, JsString newVersion);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void changeVersion(JsString oldVersion, JsString newVersion, SQLTransactionSyncCallback callback);
    }
    #endregion
    [JsType(JsMode.Prototype, Export = false, Name = "SQLTransactionSyncCallback")]
    [HtmlSpecificationVersion(5)]
    [JsDelegate(NativeDelegates = true)]
    public delegate void SQLTransactionSyncCallback(SQLTransactionSync transaction);
    [HtmlSpecificationVersion(5)]
    [JsDelegate(NativeDelegates = true)]
    [JsType(JsMode.Prototype, Export = false, Name = "SQLStatementCallback")]
    public delegate void SQLStatementCallback(SQLTransaction transaction, SQLResultSet resultSet);
    [HtmlSpecificationVersion(5)]
    [JsDelegate(NativeDelegates = true)]
    [JsType(JsMode.Prototype, Export = false, Name = "SQLStatementErrorCallback")]
    public delegate void SQLStatementErrorCallback(SQLTransaction transaction, SQLError error);
    [JsType(JsMode.Prototype, Export = false, Name = "DatabaseCallback")]
    [HtmlSpecificationVersion(5)]
    public delegate void DatabaseCallback(Database database);
    [JsType(JsMode.Prototype, Export = false, Name = "SQLVoidCallback")]
    [HtmlSpecificationVersion(5)]
    [JsDelegate(NativeDelegates = true)]
    public delegate void SQLVoidCallback();
    [JsType(JsMode.Prototype, Export = false, Name = "SQLTransactionCallback")]
    [HtmlSpecificationVersion(5)]
    [JsDelegate(NativeDelegates = true)]
    public delegate void SQLTransactionCallback(SQLTransaction transaction);
    [JsType(JsMode.Prototype, Export = false, Name = "SQLTransactionErrorCallback")]
    [HtmlSpecificationVersion(5)]
    [JsDelegate(NativeDelegates = true)]
    public delegate void SQLTransactionErrorCallback(SQLError error);
    #region HtmlWindow
    public partial class HtmlWindow : WindowDatabase
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public Database openDatabase(JsString name, JsString version, JsString displayName, ulong estimatedSize){return default(Database);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public Database openDatabase(JsString name, JsString version, JsString displayName, ulong estimatedSize, DatabaseCallback creationCallback){return default(Database);}
    }
    #endregion
    #region SQLError
    ///<summary>
    ///Errors in the asynchronous database API are reported using callbacks that have a SQLError object as one of their arguments.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "SQLError")]
    public partial class SQLError
    {
        ///<summary>
        ///The transaction failed for reasons unrelated to the database itself and not covered by any other error code.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort UNKNOWN_ERR = 0;
        ///<summary>
        ///The statement failed for database reasons not covered by any other error code.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort DATABASE_ERR = 1;
        ///<summary>
        ///The operation failed because the actual database version was not what it should be. For example, a statement found that the actual database version no longer matched the expected version of the Database or DatabaseSync object, or the Database.changeVersion() or DatabaseSync.changeVersion() methods were passed a version that doesn't match the actual database version.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort VERSION_ERR = 2;
        ///<summary>
        ///The statement failed because the data returned from the database was too large. The SQL "LIMIT" modifier might be useful to reduce the size of the result set.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort TOO_LARGE_ERR = 3;
        ///<summary>
        ///The statement failed because there was not enough remaining storage space, or the storage quota was reached and the user declined to give more space to the database.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort QUOTA_ERR = 4;
        ///<summary>
        ///The statement failed because of a syntax error, or the number of arguments did not match the number of ? placeholders in the statement, or the statement tried to use a statement that is not allowed, such as BEGIN, COMMIT, or ROLLBACK, or the statement tried to use a verb that could modify the database but the transaction was read-only.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort SYNTAX_ERR = 5;
        ///<summary>
        ///An INSERT, UPDATE, or REPLACE statement failed due to a constraint failure. For example, because a row was being inserted and the value given for the primary key column duplicated the value of an existing row.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort CONSTRAINT_ERR = 6;
        ///<summary>
        ///A lock for the transaction could not be obtained in a reasonable time.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort TIMEOUT_ERR = 7;
        ///<summary>
        ///See SQLError constants
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public ushort code{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsString message{get;set;}
    }
    #endregion
    #region SQLException
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "SQLException")]
    public partial class SQLException : Exception
    {
        ///<summary>
        ///The transaction failed for reasons unrelated to the database itself and not covered by any other error code.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort UNKNOWN_ERR = 0;
        ///<summary>
        ///The statement failed for database reasons not covered by any other error code.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort DATABASE_ERR = 1;
        ///<summary>
        ///The operation failed because the actual database version was not what it should be. For example, a statement found that the actual database version no longer matched the expected version of the Database or DatabaseSync object, or the Database.changeVersion() or DatabaseSync.changeVersion() methods were passed a version that doesn't match the actual database version.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort VERSION_ERR = 2;
        ///<summary>
        ///The statement failed because the data returned from the database was too large. The SQL "LIMIT" modifier might be useful to reduce the size of the result set.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort TOO_LARGE_ERR = 3;
        ///<summary>
        ///The statement failed because there was not enough remaining storage space, or the storage quota was reached and the user declined to give more space to the database.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort QUOTA_ERR = 4;
        ///<summary>
        ///The statement failed because of a syntax error, or the number of arguments did not match the number of ? placeholders in the statement, or the statement tried to use a statement that is not allowed, such as BEGIN, COMMIT, or ROLLBACK, or the statement tried to use a verb that could modify the database but the transaction was read-only.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort SYNTAX_ERR = 5;
        ///<summary>
        ///An INSERT, UPDATE, or REPLACE statement failed due to a constraint failure. For example, because a row was being inserted and the value given for the primary key column duplicated the value of an existing row.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort CONSTRAINT_ERR = 6;
        ///<summary>
        ///A lock for the transaction could not be obtained in a reasonable time.
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public const ushort TIMEOUT_ERR = 7;
        ///<summary>
        ///see SQLException constants
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public ushort code{get;set;}
        ///<summary>
        ///an error message describing the error encountered
        ///</summary>
        [HtmlSpecificationVersion(5)]
        public JsString message{get;set;}
    }
    #endregion
    #region SQLResultSet
    [JsType(JsMode.Prototype, Export = false, Name = "SQLResultSet")]
    [HtmlSpecificationVersion(5)]
    public partial interface SQLResultSet
    {
        [HtmlSpecificationVersion(5)]
        long insertId{get;}
        [HtmlSpecificationVersion(5)]
        long rowsAffected{get;}
        [HtmlSpecificationVersion(5)]
        SQLResultSetRowList rows{get;}
    }
    #endregion
    #region SQLResultSetRowList
    [JsType(JsMode.Prototype, Export = false, Name = "SQLResultSetRowList")]
    [HtmlSpecificationVersion(5)]
    public partial class SQLResultSetRowList : JsArray<object>
    {
    }
    #endregion
    #region SQLTransaction
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "SQLTransaction")]
    public partial interface SQLTransaction
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void executeSql(JsString sqlStatement);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void executeSql(JsString sqlStatement, object[] arguments);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void executeSql(JsString sqlStatement, object[] arguments, SQLStatementCallback callback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void executeSql(JsString sqlStatement, object[] arguments, SQLStatementCallback callback, SQLStatementErrorCallback errorCallback);
    }
    #endregion
    #region SQLTransactionSync
    [JsType(JsMode.Prototype, Export = false, Name = "SQLTransactionSync")]
    [HtmlSpecificationVersion(5)]
    public partial interface SQLTransactionSync
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        SQLResultSet executeSql(JsString sqlStatement);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        SQLResultSet executeSql(JsString sqlStatement, object[] arguments);
    }
    #endregion
    #region WindowDatabase
    [JsType(JsMode.Prototype, Export = false, Name = "WindowDatabase")]
    [HtmlSpecificationVersion(5)]
    public partial interface WindowDatabase
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        Database openDatabase(JsString name, JsString version, JsString displayName, ulong estimatedSize);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        Database openDatabase(JsString name, JsString version, JsString displayName, ulong estimatedSize, DatabaseCallback creationCallback);
    }
    #endregion
    #region WorkerUtils
    public partial class WorkerUtils : WorkerUtilsDatabase
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public Database openDatabase(JsString name, JsString version, JsString displayName, ulong estimatedSize){return default(Database);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public Database openDatabase(JsString name, JsString version, JsString displayName, ulong estimatedSize, DatabaseCallback creationCallback){return default(Database);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public DatabaseSync openDatabaseSync(JsString name, JsString version, JsString displayName, ulong estimatedSize){return default(DatabaseSync);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public DatabaseSync openDatabaseSync(JsString name, JsString version, JsString displayName, ulong estimatedSize, DatabaseCallback creationCallback){return default(DatabaseSync);}
    }
    #endregion
    #region WorkerUtilsDatabase
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "WorkerUtilsDatabase")]
    public partial interface WorkerUtilsDatabase
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        Database openDatabase(JsString name, JsString version, JsString displayName, ulong estimatedSize);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        Database openDatabase(JsString name, JsString version, JsString displayName, ulong estimatedSize, DatabaseCallback creationCallback);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        DatabaseSync openDatabaseSync(JsString name, JsString version, JsString displayName, ulong estimatedSize);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        DatabaseSync openDatabaseSync(JsString name, JsString version, JsString displayName, ulong estimatedSize, DatabaseCallback creationCallback);
    }
    #endregion
    #region AbstractWorker
    [JsType(JsMode.Prototype, Export = false, Name = "AbstractWorker")]
    [HtmlSpecificationVersion(5)]
    public abstract partial class AbstractWorker : EventTarget
    {
        [HtmlSpecificationVersion(5)]
        JsFunction onerror{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void addEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void removeEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool dispatchEvent(HtmlDomEventArgs evt){return default(bool);}
    }
    #endregion
    #region DedicatedWorkerGlobalScope
    [JsType(JsMode.Prototype, Export = false, Name = "DedicatedWorkerGlobalScope")]
    [HtmlSpecificationVersion(5)]
    public partial interface DedicatedWorkerGlobalScope
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void postMessage(object message);
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        void postMessage(object message, MessagePortArray ports);
        [HtmlSpecificationVersion(5)]
        JsFunction onmessage{get;set;}
    }
    #endregion
    #region SharedWorker
    [HtmlSpecificationVersion(5)]
    [JsType(NativeConstructors = true, Name = "SharedWorker")]
    public partial class SharedWorker : AbstractWorker
    {
        public  SharedWorker(JsString scriptURL){}
        public  SharedWorker(JsString scriptURL, JsString name){}
        [HtmlSpecificationVersion(5)]
        public MessagePort port{get;set;}
    }
    #endregion
    #region SharedWorkerGlobalScope
    [JsType(JsMode.Prototype, Export = false, Name = "SharedWorkerGlobalScope")]
    [HtmlSpecificationVersion(5)]
    public partial class SharedWorkerGlobalScope : WorkerGlobalScope
    {
        [HtmlSpecificationVersion(5)]
        public JsString name{get;set;}
        [HtmlSpecificationVersion(5)]
        public ApplicationCache applicationCache{get;set;}
        [HtmlSpecificationVersion(5)]
        public JsFunction onconnect{get;set;}
    }
    #endregion
    #region Worker
    [JsType(JsMode.Prototype, Export = false, Name = "Worker")]
    [HtmlSpecificationVersion(5)]
    public abstract partial class Worker : AbstractWorker
    {
        [HtmlSpecificationVersion(5)]
        public void terminate(){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public void postMessage(object message){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public void postMessage(object message, MessagePortArray ports){}
        [HtmlSpecificationVersion(5)]
        public JsFunction onmessage{get;set;}
    }
    #endregion
    #region WorkerGlobalScope
    [JsType(JsMode.Prototype, Export = false, Name = "WorkerGlobalScope")]
    [HtmlSpecificationVersion(5)]
    public partial class WorkerGlobalScope : WorkerUtils, EventTarget
    {
        [HtmlSpecificationVersion(5)]
        public WorkerGlobalScope self{get;set;}
        [HtmlSpecificationVersion(5)]
        public WorkerLocation location{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public void close(){}
        [HtmlSpecificationVersion(5)]
        JsFunction onerror{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void addEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public void removeEventListener(JsString type, HtmlDomEventHandler listener, bool useCapture){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeDelegates = true, NativeOverloads = true)]
        public bool dispatchEvent(HtmlDomEventArgs evt){return default(bool);}
    }
    #endregion
    #region WorkerLocation
    [JsType(JsMode.Prototype, Export = false, Name = "WorkerLocation")]
    [HtmlSpecificationVersion(5)]
    public partial interface WorkerLocation
    {
        [HtmlSpecificationVersion(5)]
        JsString href{get;}
        [HtmlSpecificationVersion(5)]
        JsString protocol{get;}
        [HtmlSpecificationVersion(5)]
        JsString host{get;}
        [HtmlSpecificationVersion(5)]
        JsString hostname{get;}
        [HtmlSpecificationVersion(5)]
        JsString port{get;}
        [HtmlSpecificationVersion(5)]
        JsString pathname{get;}
        [HtmlSpecificationVersion(5)]
        JsString search{get;}
        [HtmlSpecificationVersion(5)]
        JsString hash{get;}
    }
    #endregion
    #region WorkerNavigator
    [JsType(JsMode.Prototype, Export = false, Name = "WorkerNavigator")]
    [HtmlSpecificationVersion(5)]
    public partial interface WorkerNavigator : NavigatorID, NavigatorOnLine
    {
    }
    #endregion
    #region WorkerUtils
    [JsType(JsMode.Prototype, Export = false, Name = "WorkerUtils")]
    [HtmlSpecificationVersion(5)]
    public partial class WorkerUtils : WindowTimers
    {
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true)]
        public void importScripts(params JsString[] urls){}
        [HtmlSpecificationVersion(5)]
        public WorkerNavigator navigator{get;set;}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setTimeout(JsFunction action, JsNumber ms){return default(JsNumber);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setTimeout(JsAction action, JsNumber ms){return default(JsNumber);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public void clearTimeout(JsNumber id){}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setInterval(JsFunction func, JsNumber ms){return default(JsNumber);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber setInterval(JsAction func, JsNumber ms){return default(JsNumber);}
        [HtmlSpecificationVersion(5)]
        [JsMethod(NativeOverloads = true, NativeDelegates = true)]
        public JsNumber clearInterval(JsNumber ms){return default(JsNumber);}
    }
    #endregion
    #region HtmlWindow
    public partial class HtmlWindow : WindowSessionStorage, WindowLocalStorage
    {
        [HtmlSpecificationVersion(5)]
        public Storage sessionStorage{get{return default(Storage);}
        }
        [HtmlSpecificationVersion(5)]
        public Storage localStorage{get{return default(Storage);}
        }
    }
    #endregion
    #region Storage
    ///<summary>
    ///Each Storage object provides access to a list of key/value pairs, which are sometimes called items. Keys are strings. Any JsString (including the empty JsString) is a valid key. Values can be any data type supported by the structured clone algorithm.
    ///</summary>
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "Storage")]
    public partial interface Storage
    {
        [HtmlSpecificationVersion(5)]
        ulong length{get;}
        [JsMethod(NativeOverloads = true)]
        [HtmlSpecificationVersion(5)]
        JsString key(ulong index);
        [JsMethod(NativeOverloads = true)]
        [HtmlSpecificationVersion(5)]
        object getItem(JsString key);
        [JsMethod(NativeOverloads = true)]
        [HtmlSpecificationVersion(5)]
        void setItem(JsString key, object data);
        [JsMethod(NativeOverloads = true)]
        [HtmlSpecificationVersion(5)]
        void removeItem(JsString key);
        [JsMethod(NativeOverloads = true)]
        [HtmlSpecificationVersion(5)]
        void clear();
    }
    #endregion
    #region WindowLocalStorage
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "WindowLocalStorage")]
    public partial interface WindowLocalStorage
    {
        [HtmlSpecificationVersion(5)]
        Storage localStorage{get;}
    }
    #endregion
    #region WindowSessionStorage
    [HtmlSpecificationVersion(5)]
    [JsType(JsMode.Prototype, Export = false, Name = "WindowSessionStorage")]
    public partial interface WindowSessionStorage
    {
        [HtmlSpecificationVersion(5)]
        Storage sessionStorage{get;}
    }
    #endregion


}
