using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.w3c.dom;
using org.w3c.dom.html;
using SharpKit.JavaScript;
namespace org.w3c.dom
{
    [JsType(JsMode.Prototype, Export = false, OmitCasts = true, PropertiesAsFields = true)]
    public abstract class NodeClass : Node
    {
        public JsString nodeName { get; private set; }
        public JsString nodeValue { get; set; }
        public short nodeType { get; private set; }
        public Node parentNode { get; private set; }
        public NodeList childNodes { get; private set; }
        public Node firstChild { get; private set; }
        public Node lastChild { get; private set; }
        public Node previousSibling { get; private set; }
        public Node nextSibling { get; private set; }
        public NamedNodeMap attributes { get; private set; }
        public Document ownerDocument { get; private set; }
        public Node insertBefore(Node newChild, Node refChild) { throw new NotImplementedException(); }
        public Node replaceChild(Node newChild, Node oldChild) { throw new NotImplementedException(); }
        public Node removeChild(Node oldChild) { throw new NotImplementedException(); }
        public Node appendChild(Node newChild) { throw new NotImplementedException(); }
        public bool hasChildNodes() { throw new NotImplementedException(); }
        public Node cloneNode(bool deep) { throw new NotImplementedException(); }
        public void normalize() { throw new NotImplementedException(); }
        public bool isSupported(string feature, JsString version) { throw new NotImplementedException(); }
        public JsString namespaceURI { get; private set; }
        public JsString prefix { get; set; }
        public JsString localName { get; private set; }
        public bool hasAttributes() { throw new NotImplementedException(); }
        public JsString baseURI { get; private set; }
        public short compareDocumentPosition(Node other) { throw new NotImplementedException(); }
        public JsString textContent { get; set; }
        public bool isSameNode(Node other) { throw new NotImplementedException(); }
        public JsString lookupPrefix(string namespaceURI) { throw new NotImplementedException(); }
        public bool isDefaultNamespace(string namespaceURI) { throw new NotImplementedException(); }
        public JsString lookupNamespaceURI(string prefix) { throw new NotImplementedException(); }
        public bool isEqualNode(Node arg) { throw new NotImplementedException(); }
        public object getFeature(string feature, JsString version) { throw new NotImplementedException(); }
        public object setUserData(string key, object data, UserDataHandler handler) { throw new NotImplementedException(); }
        public object getUserData(string key) { throw new NotImplementedException(); }
    }
    [JsType(JsMode.Prototype, Export = false, OmitCasts = true, PropertiesAsFields = true)]
    public abstract class ElementClass : NodeClass, Element
    {
        public JsString tagName { get; private set; }
        public JsString getAttribute(string name) { throw new NotImplementedException(); }
        public void setAttribute(string name, JsString value) { throw new NotImplementedException(); }
        public void removeAttribute(string name) { throw new NotImplementedException(); }
        public Attr getAttributeNode(string name) { throw new NotImplementedException(); }
        public Attr setAttributeNode(Attr newAttr) { throw new NotImplementedException(); }
        public Attr removeAttributeNode(Attr oldAttr) { throw new NotImplementedException(); }
        public NodeList getElementsByTagName(string name) { throw new NotImplementedException(); }
        public JsString getAttributeNS(string namespaceURI, JsString localName) { throw new NotImplementedException(); }
        public void setAttributeNS(string namespaceURI, JsString qualifiedName, JsString value) { throw new NotImplementedException(); }
        public void removeAttributeNS(string namespaceURI, JsString localName) { throw new NotImplementedException(); }
        public Attr getAttributeNodeNS(string namespaceURI, JsString localName) { throw new NotImplementedException(); }
        public Attr setAttributeNodeNS(Attr newAttr) { throw new NotImplementedException(); }
        public NodeList getElementsByTagNameNS(string namespaceURI, JsString localName) { throw new NotImplementedException(); }
        public bool hasAttribute(string name) { throw new NotImplementedException(); }
        public bool hasAttributeNS(string namespaceURI, JsString localName) { throw new NotImplementedException(); }
        public TypeInfo schemaTypeInfo { get; private set; }
        public void setIdAttribute(string name, bool isId) { throw new NotImplementedException(); }
        public void setIdAttributeNS(string namespaceURI, JsString localName, bool isId) { throw new NotImplementedException(); }
        public void setIdAttributeNode(Attr idAttr, bool isId) { throw new NotImplementedException(); }
        public views.ClientRectList clientRects { get; private set; }
        public views.ClientRect boundingClientRect { get; private set; }
        public int scrollTop { get; set; }
        public int scrollLeft { get; set; }
        public int scrollWidth { get; private set; }
        public int scrollHeight { get; private set; }
        public int clientTop { get; private set; }
        public int clientLeft { get; private set; }
        public int clientWidth { get; private set; }
        public int clientHeight { get; private set; }
        public Element querySelector(string selectors) { throw new NotImplementedException(); }
        public NodeList querySelectorAll(string selectors) { throw new NotImplementedException(); }
    }
    [JsType(JsMode.Prototype, Export = false, OmitCasts = true, PropertiesAsFields = true)]
    public abstract class HtmlElementClass : ElementClass, HTMLElement
    {
        public NodeList getElementsByClassName(string classNames) { throw new NotImplementedException(); }
        public JsString innerHTML { get; set; }
        public JsString outerHTML { get; set; }
        public void insertAdjacentHTML(string position, JsString text) { throw new NotImplementedException(); }
        public JsString id { get; set; }
        public JsString title { get; set; }
        public JsString lang { get; set; }
        public JsString dir { get; set; }
        public JsString className { get; set; }
        public DOMTokenList classList { get; private set; }
        public DOMStringMap dataset { get; private set; }
        public bool hidden { get; set; }
        public void click() { throw new NotImplementedException(); }
        public void scrollIntoView() { throw new NotImplementedException(); }
        public void scrollIntoView(bool top) { throw new NotImplementedException(); }
        public int tabIndex { get; set; }
        public void focus() { throw new NotImplementedException(); }
        public void blur() { throw new NotImplementedException(); }
        public JsString accessKey { get; set; }
        public JsString accessKeyLabel { get; private set; }
        public bool draggable { get; set; }
        public JsString contentEditable { get; set; }
        public bool isContentEditable { get; private set; }
        public HTMLMenuElement contextMenu { get; set; }
        public JsString spellcheck { get; set; }
        public JsString commandType { get; private set; }
        public JsString label { get; private set; }
        public JsString icon { get; private set; }
        public bool disabled { get; private set; }
        public bool @checked { get; private set; }
        public css.CSSStyleDeclaration style { get; private set; }
        public Function onabort { get; set; }
        public Function onblur { get; set; }
        public Function oncanplay { get; set; }
        public Function oncanplaythrough { get; set; }
        public Function onchange { get; set; }
        public Function onclick { get; set; }
        public Function oncontextmenu { get; set; }
        public Function ondblclick { get; set; }
        public Function ondrag { get; set; }
        public Function ondragend { get; set; }
        public Function ondragenter { get; set; }
        public Function ondragleave { get; set; }
        public Function ondragover { get; set; }
        public Function ondragstart { get; set; }
        public Function ondrop { get; set; }
        public Function ondurationchange { get; set; }
        public Function onemptied { get; set; }
        public Function onended { get; set; }
        public Function onerror { get; set; }
        public Function onfocus { get; set; }
        public Function onformchange { get; set; }
        public Function onforminput { get; set; }
        public Function oninput { get; set; }
        public Function oninvalid { get; set; }
        public Function onkeydown { get; set; }
        public Function onkeypress { get; set; }
        public Function onkeyup { get; set; }
        public Function onload { get; set; }
        public Function onloadeddata { get; set; }
        public Function onloadedmetadata { get; set; }
        public Function onloadstart { get; set; }
        public Function onmousedown { get; set; }
        public Function onmousemove { get; set; }
        public Function onmouseout { get; set; }
        public Function onmouseover { get; set; }
        public Function onmouseup { get; set; }
        public Function onmousewheel { get; set; }
        public Function onpause { get; set; }
        public Function onplay { get; set; }
        public Function onplaying { get; set; }
        public Function onprogress { get; set; }
        public Function onratechange { get; set; }
        public Function onreadystatechange { get; set; }
        public Function onscroll { get; set; }
        public Function onseeked { get; set; }
        public Function onseeking { get; set; }
        public Function onselect { get; set; }
        public Function onshow { get; set; }
        public Function onstalled { get; set; }
        public Function onsubmit { get; set; }
        public Function onsuspend { get; set; }
        public Function ontimeupdate { get; set; }
        public Function onvolumechange { get; set; }
        public Function onwaiting { get; set; }
        public Element offsetParent { get; private set; }
        public int offsetTop { get; private set; }
        public int offsetLeft { get; private set; }
        public int offsetWidth { get; private set; }
        public int offsetHeight { get; private set; }
        public bool itemScope { get; set; }
        public JsString itemType { get; set; }
        public JsString itemId { get; set; }
        public DOMSettableTokenList itemRef { get; set; }
        public DOMSettableTokenList itemProp { get; set; }
        public HTMLPropertiesCollection properties { get; private set; }
        public object itemValue { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false, Name = "Image", PropertiesAsFields = true)]
    public class HtmlImageClass : HtmlElementClass, HTMLImageElement
    {
        public JsString alt { get; set; }
        public JsString src { get; set; }
        public JsString useMap { get; set; }
        public bool isMap { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int naturalWidth { get; private set; }
        public int naturalHeight { get; private set; }
        public bool complete { get; private set; }
        public JsString name { get; set; }
        public JsString align { get; set; }
        public JsString border { get; set; }
        public int hspace { get; set; }
        public JsString longDesc { get; set; }
        public int vspace { get; set; }
    }
}
