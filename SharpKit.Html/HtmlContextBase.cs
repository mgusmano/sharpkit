using SharpKit.JavaScript;

namespace SharpKit.Html
{
    [JsType(JsMode.Global, Export = false)]
    public class HtmlContextBase : JsContext
    {
        #region Window
        protected static Window window { get; private set; }
        protected static Window self { get; private set; }
        protected static JsString name { get; set; }
        protected static Location location { get; set; }
        protected static History history { get; private set; }
        protected static UndoManager undoManager { get; private set; }
        protected static Selection selection { get; private set; }
        protected static object locationbar { get; set; }
        protected static object menubar { get; set; }
        protected static object personalbar { get; set; }
        protected static object scrollbars { get; set; }
        protected static object statusbar { get; set; }
        protected static object toolbar { get; set; }
        protected static void close() { }
        protected static void stop() { }
        protected static void focus() { }
        protected static void blur() { }
        protected static object frames { get; set; }
        protected static object length { get; set; }
        protected static Window top { get; private set; }
        protected static object opener { get; set; }
        protected static Window parent { get; private set; }
        protected static Element frameElement { get; private set; }
        protected static Window open() { return null; }
        protected static Window open(string url) { return null; }
        protected static Window open(string url, JsString target) { return null; }
        protected static Window open(string url, JsString target, JsString features) { return null; }
        protected static Window open(string url, JsString target, JsString features, JsString replace) { return null; }
        protected static Window getElement(int index) { return null; }
        protected static object getElement(string name) { return null; }
        protected static void setElement(string name, object value) { }
        protected static Navigator navigator { get; private set; }
        protected static ApplicationCache applicationCache { get; private set; }
        protected static void alert(string message) { }
        protected static void alert(object obj) { }
        protected static bool confirm(string message) { return false; }
        protected static JsString prompt(string message) { return null; }
        protected static JsString prompt(string message, JsString _default) { return null; }
        protected static void print() { }
        protected static object showModalDialog(string url) { return null; }
        protected static object showModalDialog(string url, object argument) { return null; }
        protected static void postMessage(object message, JsString targetOrigin) { }
        protected static void postMessage(object message, JsString targetOrigin, MessagePort[] ports) { }
        protected static JsAction onabort { get; set; }
        protected static JsAction onafterprint { get; set; }
        protected static JsAction onbeforeprint { get; set; }
        protected static JsAction onbeforeunload { get; set; }
        protected static JsAction onblur { get; set; }
        protected static JsAction oncanplay { get; set; }
        protected static JsAction oncanplaythrough { get; set; }
        protected static JsAction onchange { get; set; }
        protected static JsAction onclick { get; set; }
        protected static JsAction oncontextmenu { get; set; }
        protected static JsAction ondblclick { get; set; }
        protected static JsAction ondrag { get; set; }
        protected static JsAction ondragend { get; set; }
        protected static JsAction ondragenter { get; set; }
        protected static JsAction ondragleave { get; set; }
        protected static JsAction ondragover { get; set; }
        protected static JsAction ondragstart { get; set; }
        protected static JsAction ondrop { get; set; }
        protected static JsAction ondurationchange { get; set; }
        protected static JsAction onemptied { get; set; }
        protected static JsAction onended { get; set; }
        protected static JsAction onerror { get; set; }
        protected static JsAction onfocus { get; set; }
        protected static JsAction onformchange { get; set; }
        protected static JsAction onforminput { get; set; }
        protected static JsAction onhashchange { get; set; }
        protected static JsAction oninput { get; set; }
        protected static JsAction oninvalid { get; set; }
        protected static JsAction onkeydown { get; set; }
        protected static JsAction onkeypress { get; set; }
        protected static JsAction onkeyup { get; set; }
        protected static JsAction onload { get; set; }
        protected static JsAction onloadeddata { get; set; }
        protected static JsAction onloadedmetadata { get; set; }
        protected static JsAction onloadstart { get; set; }
        protected static JsAction onmessage { get; set; }
        protected static JsAction onmousedown { get; set; }
        protected static JsAction onmousemove { get; set; }
        protected static JsAction onmouseout { get; set; }
        protected static JsAction onmouseover { get; set; }
        protected static JsAction onmouseup { get; set; }
        protected static JsAction onmousewheel { get; set; }
        protected static JsAction onoffline { get; set; }
        protected static JsAction ononline { get; set; }
        protected static JsAction onpause { get; set; }
        protected static JsAction onplay { get; set; }
        protected static JsAction onplaying { get; set; }
        protected static JsAction onpagehide { get; set; }
        protected static JsAction onpageshow { get; set; }
        protected static JsAction onpopstate { get; set; }
        protected static JsAction onprogress { get; set; }
        protected static JsAction onratechange { get; set; }
        protected static JsAction onreadystatechange { get; set; }
        protected static JsAction onredo { get; set; }
        protected static JsAction onresize { get; set; }
        protected static JsAction onscroll { get; set; }
        protected static JsAction onseeked { get; set; }
        protected static JsAction onseeking { get; set; }
        protected static JsAction onselect { get; set; }
        protected static JsAction onshow { get; set; }
        protected static JsAction onstalled { get; set; }
        protected static JsAction onstorage { get; set; }
        protected static JsAction onsubmit { get; set; }
        protected static JsAction onsuspend { get; set; }
        protected static JsAction ontimeupdate { get; set; }
        protected static JsAction onundo { get; set; }
        protected static JsAction onunload { get; set; }
        protected static JsAction onvolumechange { get; set; }
        protected static JsAction onwaiting { get; set; }
        // Window-1
        protected static CSSStyleDeclaration getComputedStyle(Element elt) { return null; }
        protected static CSSStyleDeclaration getComputedStyle(Element elt, JsString pseudoElt) { return null; }
        // Window-2
        protected static HtmlDocument document { get; private set; }
        protected static StyleMedia styleMedia { get; private set; }
        protected static Screen screen { get; private set; }
        protected static int innerWidth { get; private set; }
        protected static int innerHeight { get; private set; }
        protected static int pageXOffset { get; private set; }
        protected static int pageYOffset { get; private set; }
        protected static void scroll(int x, int y) { }
        protected static void scrollTo(int x, int y) { }
        protected static void scrollBy(int x, int y) { }
        protected static int screenX { get; private set; }
        protected static int screenY { get; private set; }
        protected static int outerWidth { get; private set; }
        protected static int outerHeight { get; private set; }
        // WindowTimers
        protected static int setTimeout(JsAction handler) { return 0; }
        protected static int setTimeout(JsAction handler, object timeout, params object[] args) { return 0; }
        protected static void clearTimeout(int handle) { }
        protected static int setInterval(JsAction handler) { return 0; }
        protected static int setInterval(JsAction handler, object timeout, params object[] args) { return 0; }
        protected static void clearInterval(int handle) { }
        // WindowDatabase
        protected static Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize) { return null; }
        protected static Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback) { return null; }
        // WindowSessionStorage
        protected static Storage sessionStorage { get; private set; }
        // WindowLocalStorage
        protected static Storage localStorage { get; private set; }
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
        protected static JsString encodeURIComponent(JsString encodedURIString) { return null; }


    }


}
