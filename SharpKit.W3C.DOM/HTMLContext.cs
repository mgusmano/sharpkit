using SharpKit.JavaScript;
using org.w3c.dom.css;
using org.w3c.dom.webstorage;
using org.w3c.dom.webdatabase;

namespace org.w3c.dom.html
{
    [JsType(JsMode.Global, Export = false)]
    public class HTMLContext : JsContext
    {
        #region Window
        public static Window window { get; private set; }
        public static Window self { get; private set; }
        public static JsString name { get; set; }
        public static Location location { get; set; }
        public static History history { get; private set; }
        public static UndoManager undoManager { get; private set; }
        public static Selection selection { get; private set; }
        public static object locationbar { get; set; }
        public static object menubar { get; set; }
        public static object personalbar { get; set; }
        public static object scrollbars { get; set; }
        public static object statusbar { get; set; }
        public static object toolbar { get; set; }
        public static void close(){}
        public static void stop(){}
        public static void focus(){}
        public static void blur(){}
        public static object frames { get; set; }
        public static object length { get; set; }
        public static Window top { get; private set; }
        public static object opener { get; set; }
        public static Window parent { get; private set; }
        public static Element frameElement { get; private set; }
        public static Window open() { return null; }
        public static Window open(string url) { return null; }
        public static Window open(string url, JsString target) { return null; }
        public static Window open(string url, JsString target, JsString features) { return null; }
        public static Window open(string url, JsString target, JsString features, JsString replace) { return null; }
        public static Window getElement(int index) { return null; }
        public static object getElement(string name) { return null; }
        public static void setElement(string name, object value){}
        public static Navigator navigator { get; private set; }
        public static ApplicationCache applicationCache { get; private set; }
        public static void alert(string message){}
        public static bool confirm(string message) { return false; }
        public static JsString prompt(string message) { return null; }
        public static JsString prompt(string message, JsString _default) { return null; }
        public static void print(){}
        public static object showModalDialog(string url) { return null; }
        public static object showModalDialog(string url, object argument) { return null; }
        public static void postMessage(object message, JsString targetOrigin){}
        public static void postMessage(object message, JsString targetOrigin, MessagePort[] ports){}
        public static Function onabort { get; set; }
        public static Function onafterprint { get; set; }
        public static Function onbeforeprint { get; set; }
        public static Function onbeforeunload { get; set; }
        public static Function onblur { get; set; }
        public static Function oncanplay { get; set; }
        public static Function oncanplaythrough { get; set; }
        public static Function onchange { get; set; }
        public static Function onclick { get; set; }
        public static Function oncontextmenu { get; set; }
        public static Function ondblclick { get; set; }
        public static Function ondrag { get; set; }
        public static Function ondragend { get; set; }
        public static Function ondragenter { get; set; }
        public static Function ondragleave { get; set; }
        public static Function ondragover { get; set; }
        public static Function ondragstart { get; set; }
        public static Function ondrop { get; set; }
        public static Function ondurationchange { get; set; }
        public static Function onemptied { get; set; }
        public static Function onended { get; set; }
        public static Function onerror { get; set; }
        public static Function onfocus { get; set; }
        public static Function onformchange { get; set; }
        public static Function onforminput { get; set; }
        public static Function onhashchange { get; set; }
        public static Function oninput { get; set; }
        public static Function oninvalid { get; set; }
        public static Function onkeydown { get; set; }
        public static Function onkeypress { get; set; }
        public static Function onkeyup { get; set; }
        public static Function onload { get; set; }
        public static Function onloadeddata { get; set; }
        public static Function onloadedmetadata { get; set; }
        public static Function onloadstart { get; set; }
        public static Function onmessage { get; set; }
        public static Function onmousedown { get; set; }
        public static Function onmousemove { get; set; }
        public static Function onmouseout { get; set; }
        public static Function onmouseover { get; set; }
        public static Function onmouseup { get; set; }
        public static Function onmousewheel { get; set; }
        public static Function onoffline { get; set; }
        public static Function ononline { get; set; }
        public static Function onpause { get; set; }
        public static Function onplay { get; set; }
        public static Function onplaying { get; set; }
        public static Function onpagehide { get; set; }
        public static Function onpageshow { get; set; }
        public static Function onpopstate { get; set; }
        public static Function onprogress { get; set; }
        public static Function onratechange { get; set; }
        public static Function onreadystatechange { get; set; }
        public static Function onredo { get; set; }
        public static Function onresize { get; set; }
        public static Function onscroll { get; set; }
        public static Function onseeked { get; set; }
        public static Function onseeking { get; set; }
        public static Function onselect { get; set; }
        public static Function onshow { get; set; }
        public static Function onstalled { get; set; }
        public static Function onstorage { get; set; }
        public static Function onsubmit { get; set; }
        public static Function onsuspend { get; set; }
        public static Function ontimeupdate { get; set; }
        public static Function onundo { get; set; }
        public static Function onunload { get; set; }
        public static Function onvolumechange { get; set; }
        public static Function onwaiting { get; set; }
        // Window-1
        public static CSSStyleDeclaration getComputedStyle(Element elt) { return null; }
        public static CSSStyleDeclaration getComputedStyle(Element elt, JsString pseudoElt) { return null; }
        // Window-2
        public static HTMLDocument document { get; private set; }
        public static StyleMedia styleMedia { get; private set; }
        public static Screen screen { get; private set; }
        public static int innerWidth { get; private set; }
        public static int innerHeight { get; private set; }
        public static int pageXOffset { get; private set; }
        public static int pageYOffset { get; private set; }
        public static void scroll(int x, int y){}
        public static void scrollTo(int x, int y){}
        public static void scrollBy(int x, int y){}
        public static int screenX { get; private set; }
        public static int screenY { get; private set; }
        public static int outerWidth { get; private set; }
        public static int outerHeight { get; private set; }
        // WindowTimers
        public static int setTimeout(JsAction handler) { return 0; }
        public static int setTimeout(JsAction handler, object timeout, params object[] args) { return 0; }
        public static void clearTimeout(int handle){}
        public static int setInterval(JsAction handler) { return 0; }
        public static int setInterval(JsAction handler, object timeout, params object[] args) { return 0; }
        public static void clearInterval(int handle){}
        // WindowDatabase
        public static Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize) { return null; }
        public static Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback) { return null; }
        // WindowSessionStorage
        public static Storage sessionStorage { get; private set; }
        // WindowLocalStorage
        public static Storage localStorage { get; private set; }
        #endregion

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


    }


}
