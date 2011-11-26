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
		public SharpKit.JavaScript.JsString nodeName {
			get { throw new NotImplementedException(); }
		}

		public SharpKit.JavaScript.JsString nodeValue {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public short nodeType {
			get { throw new NotImplementedException(); }
		}

		public Node parentNode {
			get { throw new NotImplementedException(); }
		}

		public NodeList childNodes {
			get { throw new NotImplementedException(); }
		}

		public Node firstChild {
			get { throw new NotImplementedException(); }
		}

		public Node lastChild {
			get { throw new NotImplementedException(); }
		}

		public Node previousSibling {
			get { throw new NotImplementedException(); }
		}

		public Node nextSibling {
			get { throw new NotImplementedException(); }
		}

		public NamedNodeMap attributes {
			get { throw new NotImplementedException(); }
		}

		public Document ownerDocument {
			get { throw new NotImplementedException(); }
		}

		public Node insertBefore(Node newChild, Node refChild) {
			throw new NotImplementedException();
		}

		public Node replaceChild(Node newChild, Node oldChild) {
			throw new NotImplementedException();
		}

		public Node removeChild(Node oldChild) {
			throw new NotImplementedException();
		}

		public Node appendChild(Node newChild) {
			throw new NotImplementedException();
		}

		public bool hasChildNodes() {
			throw new NotImplementedException();
		}

		public Node cloneNode(bool deep) {
			throw new NotImplementedException();
		}

		public void normalize() {
			throw new NotImplementedException();
		}

		public bool isSupported(string feature, SharpKit.JavaScript.JsString version) {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString namespaceURI {
			get { throw new NotImplementedException(); }
		}

		public SharpKit.JavaScript.JsString prefix {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString localName {
			get { throw new NotImplementedException(); }
		}

		public bool hasAttributes() {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString baseURI {
			get { throw new NotImplementedException(); }
		}

		public short compareDocumentPosition(Node other) {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString textContent {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public bool isSameNode(Node other) {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString lookupPrefix(string namespaceURI) {
			throw new NotImplementedException();
		}

		public bool isDefaultNamespace(string namespaceURI) {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString lookupNamespaceURI(string prefix) {
			throw new NotImplementedException();
		}

		public bool isEqualNode(Node arg) {
			throw new NotImplementedException();
		}

		public object getFeature(string feature, SharpKit.JavaScript.JsString version) {
			throw new NotImplementedException();
		}

		public object setUserData(string key, object data, UserDataHandler handler) {
			throw new NotImplementedException();
		}

		public object getUserData(string key) {
			throw new NotImplementedException();
		}
	}

	[JsType(JsMode.Prototype, Export = false, OmitCasts = true, PropertiesAsFields = true)]
	public abstract class ElementClass : NodeClass, Element
	{

		public SharpKit.JavaScript.JsString tagName {
			get { throw new NotImplementedException(); }
		}

		public SharpKit.JavaScript.JsString getAttribute(string name) {
			throw new NotImplementedException();
		}

		public void setAttribute(string name, SharpKit.JavaScript.JsString value) {
			throw new NotImplementedException();
		}

		public void removeAttribute(string name) {
			throw new NotImplementedException();
		}

		public Attr getAttributeNode(string name) {
			throw new NotImplementedException();
		}

		public Attr setAttributeNode(Attr newAttr) {
			throw new NotImplementedException();
		}

		public Attr removeAttributeNode(Attr oldAttr) {
			throw new NotImplementedException();
		}

		public NodeList getElementsByTagName(string name) {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString getAttributeNS(string namespaceURI, SharpKit.JavaScript.JsString localName) {
			throw new NotImplementedException();
		}

		public void setAttributeNS(string namespaceURI, SharpKit.JavaScript.JsString qualifiedName, SharpKit.JavaScript.JsString value) {
			throw new NotImplementedException();
		}

		public void removeAttributeNS(string namespaceURI, SharpKit.JavaScript.JsString localName) {
			throw new NotImplementedException();
		}

		public Attr getAttributeNodeNS(string namespaceURI, SharpKit.JavaScript.JsString localName) {
			throw new NotImplementedException();
		}

		public Attr setAttributeNodeNS(Attr newAttr) {
			throw new NotImplementedException();
		}

		public NodeList getElementsByTagNameNS(string namespaceURI, SharpKit.JavaScript.JsString localName) {
			throw new NotImplementedException();
		}

		public bool hasAttribute(string name) {
			throw new NotImplementedException();
		}

		public bool hasAttributeNS(string namespaceURI, SharpKit.JavaScript.JsString localName) {
			throw new NotImplementedException();
		}

		public TypeInfo schemaTypeInfo {
			get { throw new NotImplementedException(); }
		}

		public void setIdAttribute(string name, bool isId) {
			throw new NotImplementedException();
		}

		public void setIdAttributeNS(string namespaceURI, SharpKit.JavaScript.JsString localName, bool isId) {
			throw new NotImplementedException();
		}

		public void setIdAttributeNode(Attr idAttr, bool isId) {
			throw new NotImplementedException();
		}

		public views.ClientRectList clientRects {
			get { throw new NotImplementedException(); }
		}

		public views.ClientRect boundingClientRect {
			get { throw new NotImplementedException(); }
		}

		public int scrollTop {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public int scrollLeft {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public int scrollWidth {
			get { throw new NotImplementedException(); }
		}

		public int scrollHeight {
			get { throw new NotImplementedException(); }
		}

		public int clientTop {
			get { throw new NotImplementedException(); }
		}

		public int clientLeft {
			get { throw new NotImplementedException(); }
		}

		public int clientWidth {
			get { throw new NotImplementedException(); }
		}

		public int clientHeight {
			get { throw new NotImplementedException(); }
		}

		public Element querySelector(string selectors) {
			throw new NotImplementedException();
		}

		public NodeList querySelectorAll(string selectors) {
			throw new NotImplementedException();
		}
	}

	[JsType(JsMode.Prototype, Export = false, OmitCasts = true, PropertiesAsFields = true)]
	public abstract class HtmlElementClass : ElementClass, HTMLElement
	{
		public NodeList getElementsByClassName(string classNames) {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString innerHTML {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString outerHTML {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public void insertAdjacentHTML(string position, SharpKit.JavaScript.JsString text) {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString id {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString title {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString lang {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString dir {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString className {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public DOMTokenList classList {
			get { throw new NotImplementedException(); }
		}

		public DOMStringMap dataset {
			get { throw new NotImplementedException(); }
		}

		public bool hidden {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public void click() {
			throw new NotImplementedException();
		}

		public void scrollIntoView() {
			throw new NotImplementedException();
		}

		public void scrollIntoView(bool top) {
			throw new NotImplementedException();
		}

		public int tabIndex {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public void focus() {
			throw new NotImplementedException();
		}

		public void blur() {
			throw new NotImplementedException();
		}

		public SharpKit.JavaScript.JsString accessKey {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString accessKeyLabel {
			get { throw new NotImplementedException(); }
		}

		public bool draggable {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString contentEditable {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public bool isContentEditable {
			get { throw new NotImplementedException(); }
		}

		public HTMLMenuElement contextMenu {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString spellcheck {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString commandType {
			get { throw new NotImplementedException(); }
		}

		public SharpKit.JavaScript.JsString label {
			get { throw new NotImplementedException(); }
		}

		public SharpKit.JavaScript.JsString icon {
			get { throw new NotImplementedException(); }
		}

		public bool disabled {
			get { throw new NotImplementedException(); }
		}

		public bool @checked {
			get { throw new NotImplementedException(); }
		}

		public css.CSSStyleDeclaration style {
			get { throw new NotImplementedException(); }
		}

		public Function onabort {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onblur {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function oncanplay {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function oncanplaythrough {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onchange {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onclick {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function oncontextmenu {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondblclick {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondrag {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondragend {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondragenter {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondragleave {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondragover {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondragstart {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondrop {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ondurationchange {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onemptied {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onended {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onerror {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onfocus {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onformchange {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onforminput {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function oninput {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function oninvalid {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onkeydown {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onkeypress {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onkeyup {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onload {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onloadeddata {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onloadedmetadata {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onloadstart {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onmousedown {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onmousemove {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onmouseout {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onmouseover {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onmouseup {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onmousewheel {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onpause {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onplay {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onplaying {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onprogress {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onratechange {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onreadystatechange {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onscroll {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onseeked {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onseeking {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onselect {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onshow {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onstalled {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onsubmit {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onsuspend {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function ontimeupdate {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onvolumechange {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Function onwaiting {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public Element offsetParent {
			get { throw new NotImplementedException(); }
		}

		public int offsetTop {
			get { throw new NotImplementedException(); }
		}

		public int offsetLeft {
			get { throw new NotImplementedException(); }
		}

		public int offsetWidth {
			get { throw new NotImplementedException(); }
		}

		public int offsetHeight {
			get { throw new NotImplementedException(); }
		}

		public bool itemScope {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString itemType {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString itemId {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public DOMSettableTokenList itemRef {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public DOMSettableTokenList itemProp {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public HTMLPropertiesCollection properties {
			get { throw new NotImplementedException(); }
		}

		public object itemValue {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}
	}

	[JsType(JsMode.Prototype, Export = false, Name = "Image", PropertiesAsFields = true)]
	public class HtmlImageClass : HtmlElementClass, HTMLImageElement
	{

		public SharpKit.JavaScript.JsString alt {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString src {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString useMap {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public bool isMap {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public int width {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public int height {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public int naturalWidth {
			get { throw new NotImplementedException(); }
		}

		public int naturalHeight {
			get { throw new NotImplementedException(); }
		}

		public bool complete {
			get { throw new NotImplementedException(); }
		}

		public SharpKit.JavaScript.JsString name {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString align {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString border {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public int hspace {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public SharpKit.JavaScript.JsString longDesc {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public int vspace {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}
	}

	//Alias
	[JsType(JsMode.Prototype, Export = false, Name = "Image", PropertiesAsFields = true)]
	public class HtmlImage : HtmlImageClass
	{
	}

}
