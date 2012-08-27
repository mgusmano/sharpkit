using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;
using System;

namespace SharpKit.Html.Legacy
{

	#region missing

	public partial class HtmlNode : Node { }
	public partial class HtmlAnchor : HtmlAnchorElement { }
	public partial class HtmlAttribute : Attr { }
	public partial class HtmlBody : HtmlBodyElement { }
	public partial class HtmlBr : HtmlBRElement { }
	public partial class HtmlButton : HtmlButtonElement { }
	public partial class HtmlCaption : HtmlTableCaptionElement { }
	public partial class HtmlClipboardData : Clipboard { }
	public partial class HtmlCssRule : CssRule { }
	public partial class HtmlDiv : HtmlDivElement { }
	public partial class HtmlDocumentElement : HtmlDocument { }
	public partial class HtmlDocumentFragment : DocumentFragment { }
	public partial class HtmlDomEventArgs : UIEvent { }
	public partial class HtmlDomImplementation : DOMImplementation { }
	public partial class HtmlElementStyle : CssStyleDeclaration { }
	public partial class HtmlFieldSet : HtmlFieldSetElement { }
	public partial class HtmlForm : HtmlFormElement { }
	public partial class HtmlHead : HtmlHeadElement { }
	public partial class HtmlHorizontalRule : HtmlHRElement { }
	public partial class HtmlIFrame : HtmlIFrameElement { }
	public partial class HtmlImage : HtmlImageElement { }
	public partial class HtmlInput : HtmlInputElement { }
	public partial class HtmlInputCheckBox : HtmlInputElement { }
	public partial class HtmlLegend : HtmlLegendElement { }
	public partial class HtmlLineBreak : HtmlBRElement { }
	public partial class HtmlLink : HtmlLinkElement { }
	public partial class HtmlListItem : HtmlLIElement { }
	public partial class HtmlOption : HtmlOptionElement
	{
		HtmlOption(string data, string value, bool defaultSelected, bool selected)
			: base(data, value, defaultSelected, selected) {
		}
	}
	public partial class HtmlOrderedList : object { }
	public partial class HtmlParagraph : HtmlParagraphElement { }
	public partial class HtmlPre : HtmlPreElement { }
	public partial class HtmlScreen : Screen { }
	public partial class HtmlSelect : HtmlSelectElement { }
	public partial class HtmlSpan : HtmlSpanElement { }
	public partial class HtmlStyleSheetPage : object { }
	public partial class HtmlTable : HtmlTableElement { }
	public partial class HtmlTableBody : HtmlTableSectionElement { }
	public partial class HtmlTableCell : HtmlTableCellElement { }
	public partial class HtmlTableCol : HtmlTableColElement { }
	public partial class HtmlTableColGroup : object { }
	public partial class HtmlTableFoot : HtmlTableSectionElement { }
	public partial class HtmlTableHead : HtmlTableSectionElement { }
	public partial class HtmlTableHeadCell : HtmlTableCellElement { }
	public partial class HtmlTableRow : HtmlTableRowElement { }
	public partial class HtmlTextArea : HtmlTextAreaElement { }
	public partial class HtmlTextNode : Text { }
	public partial class HtmlSelection : Selection { }
	public partial class HtmlTextRange : Range { }
	public partial class HtmlTextRectangle : HtmlTextRectangleCollection { }
	public partial class HtmlTitle : HtmlTitleElement { }
	public partial class HtmlUnorderedList : HtmlUListElement { }
	public partial class HtmlWindow : Window { }
	public partial class HtmlWindowLocation : Location { }
	public partial class HtmlWindowNavigator : Navigator { }
	public partial class StyleFilterCollection : object { }
	public partial class HtmlNodeCollection<T> : NodeList { }
	public partial class HtmlNodeCollection : NodeList { }
	public partial class HtmlNodeToAppend : object { }
	public partial class HtmlElementCollection : NodeList { }
	public partial class HtmlTextRectangleCollection : object { }
	public partial class HtmlGenericCollection<T> : object { }
	public partial class HtmlAttributeCollection : NamedNodeMap { }
	public partial class HtmlDomEventHandler : object { }
	public partial class ActiveXObject : HtmlObjectElement { }

	[JsType(JsMode.Json, Export = false, Name = "StyleFilter")]
	public partial class StyleFilter
	{
	}

	[JsType(JsMode.Json, Export = false)]
	public partial interface WindowModal
	{
		object dialogArguments { get; }
		JsString returnValue { get; set; }
	}

	public partial class HtmlInputText : HtmlInputElement { }
	public partial class HtmlInputPassword : HtmlInputElement { }
	public partial class HtmlInputImage : HtmlInputElement { }
	public partial class HtmlInputRadio : HtmlInputElement { }
	public partial class HtmlInputFile : HtmlInputElement { }
	public partial class HtmlInputSubmit : HtmlInputElement { }
	public partial class HtmlInputReset : HtmlInputElement { }
	public partial class HtmlInputHidden : HtmlInputElement { }
	public partial class HtmlInputButton : HtmlInputElement { }

	[JsType(JsMode.Prototype, Name = "JSON", Export = false)]
	public class JSON
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="replacer">If replacer is a function, JSON.stringify calls the function, passing in the key and value of each member. The return value is serialized instead of the original value. If the function returns undefined, the member will be excluded from the serialization. The key for the root object is an empty string: "".
		/// If replacer is an array, only members with key values in the array will be serialized. The order of serialization is the same as the order of the keys in the array. The replacer array is ignored when the value argument is also an array.</param>
		/// <returns></returns>
		public static string stringify(object obj, JsFunc<object, object, object> replacer) { return null; }

		public static string stringify(object obj) { return null; }

		public static object parse(JsString json) { return null; }

	}

	public partial class A : HtmlAnchorElement { }
	public partial class BODY : HtmlBodyElement { }
	public partial class BR : HtmlBRElement { }
	public partial class BUTTON : HtmlButtonElement { }
	public partial class CAPTION : HtmlCaption { }
	public partial class DIV : HtmlDivElement { }
	public partial class EMBED : HtmlEmbedElement { }
	public partial class FIELDSET : HtmlFieldSetElement { }
	public partial class FORM : HtmlFormElement { }
	public partial class FRAME : HtmlFrameElement { }
	public partial class FRAMESET : HtmlFrameSetElement { }
	public partial class HEAD : HtmlHeadElement { }
	public partial class HR : HtmlHRElement { }
	public partial class IFRAME : HtmlIFrame { }
	public partial class INPUT : HtmlInput { }
	public partial class LEGEND : HtmlLegendElement { }
	public partial class LINK : HtmlLinkElement { }
	public partial class LI : HtmlLIElement { }
	public partial class MARQUEE : HtmlMarqueeElement { }
	public partial class OBJECT : HtmlObjectElement { }
	public partial class OL : HtmlOListElement { }
	public partial class P : HtmlParagraphElement { }
	public partial class PRE : HtmlPreElement { }
	public partial class SCRIPT : HtmlScriptElement { }
	public partial class SELECT : HtmlSelectElement { }
	public partial class SPAN : HtmlSpanElement { }
	public partial class TABLE : HtmlTableElement { }
	public partial class TBODY : HtmlTableSectionElement { }
	public partial class TD : HtmlTableCellElement { }
	public partial class COL : HtmlTableColElement { }
	public partial class COLGROUP : object { }
	public partial class TFOOT : HtmlTableSectionElement { }
	public partial class THEAD : HtmlTableSectionElement { }
	public partial class TH : HtmlTableCell { }
	public partial class TR : HtmlTableRowElement { }
	public partial class TEXTAREA : HtmlTextAreaElement { }
	public partial class TITLE : HtmlTitleElement { }
	public partial class UL : HtmlUListElement { }

	namespace Server
	{
		using System.Reflection;
		using SharpKit.Html.Legacy;

		public class JsBinder : SharpKit.JavaScript.Server.JsBinder
		{
			public string HandleEvent(Action<HtmlDomEventArgs> handler) {
				return MethodOf(handler.Method) + "(event);";
			}
			public string HandleEvent(Action<object, HtmlDomEventArgs> handler) {
				return MethodOf(handler.Method) + "(this, event);";
			}
		}

	}

	#endregion

	#region Constructors

	public partial class HtmlAnchor
	{
		[JsMethod(Name = "document.createElement('A')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlAnchor() { }
	}
	public partial class HtmlBody
	{
		[JsMethod(Name = "document.createElement('BODY')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlBody() { }
	}
	public partial class HtmlBr
	{
		[JsMethod(Name = "document.createElement('BR')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlBr() { }
	}
	public partial class HtmlButton
	{
		[JsMethod(Name = "document.createElement('BUTTON')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlButton() { }
	}
	public partial class HtmlCaption
	{
		[JsMethod(Name = "document.createElement('CAPTION')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlCaption() { }
	}
	public partial class HtmlDiv
	{
		[JsMethod(Name = "document.createElement('DIV')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlDiv() { }
	}
	public partial class HtmlDocumentElement
	{
		[JsMethod(Name = "document.createElement('HTML')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlDocumentElement() { }
	}
	public partial class HtmlDocumentFragment
	{
		[JsMethod(Name = "document.createDocumentFragment", OmitNewOperator = true)]
		public HtmlDocumentFragment() { }
	}
	public partial class HtmlEmbedElement
	{
		[JsMethod(Name = "document.createElement('EMBED')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlEmbedElement() { }
	}
	public partial class HtmlFieldSet
	{
		[JsMethod(Name = "document.createElement('FIELDSET')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlFieldSet() { }
	}
	public partial class HtmlForm
	{
		[JsMethod(Name = "document.createElement('FORM')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlForm() { }
	}
	public partial class HtmlFrameElement
	{
		[JsMethod(Name = "document.createElement('FRAME')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlFrameElement() { }
	}
	public partial class HtmlFrameSetElement
	{
		[JsMethod(Name = "document.createElement('FRAMESET')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlFrameSetElement() { }
	}
	public partial class HtmlHead
	{
		[JsMethod(Name = "document.createElement('HEAD')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlHead() { }
	}
	public partial class HtmlHorizontalRule
	{
		[JsMethod(Name = "document.createElement('HR')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlHorizontalRule() { }
	}
	public partial class HtmlIFrame
	{
		[JsMethod(Name = "document.createElement('IFRAME')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlIFrame() { }
	}
	public partial class HtmlInput
	{
		[JsMethod(Name = "document.createElement('INPUT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlInput() { }
	}
	public partial class HtmlInputText
	{
		[JsMethod(Name = "document.createElement('INPUT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlInputText() { }
	}
	public partial class HtmlInputCheckBox
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'checkbox';return x;}", OmitNewOperator = true)]
		public HtmlInputCheckBox() { }
	}
	public partial class HtmlInputPassword
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'password';return x;}", OmitNewOperator = true)]
		public HtmlInputPassword() { }
	}
	public partial class HtmlInputImage
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'image';return x;}", OmitNewOperator = true)]
		public HtmlInputImage() { }
	}
	public partial class HtmlInputRadio
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'radio';return x;}", OmitNewOperator = true)]
		public HtmlInputRadio() { }
	}
	public partial class HtmlInputFile
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'file';return x;}", OmitNewOperator = true)]
		public HtmlInputFile() { }
	}
	public partial class HtmlInputSubmit
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'submit';return x;}", OmitNewOperator = true)]
		public HtmlInputSubmit() { }
	}
	public partial class HtmlInputReset
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'reset';return x;}", OmitNewOperator = true)]
		public HtmlInputReset() { }
	}
	public partial class HtmlInputHidden
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'hidden';return x;}", OmitNewOperator = true)]
		public HtmlInputHidden() { }
	}
	public partial class HtmlInputButton
	{
		[JsMethod(Name = "function(){var x = document.createElement('INPUT');x.type = 'button';return x;}", OmitNewOperator = true)]
		public HtmlInputButton() { }
	}
	public partial class HtmlLegend
	{
		[JsMethod(Name = "document.createElement('LEGEND')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlLegend() { }
	}
	public partial class HtmlLineBreak
	{
		[JsMethod(Name = "document.createElement('BR')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlLineBreak() { }
	}
	public partial class HtmlLink
	{
		[JsMethod(Name = "document.createElement('LINK')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlLink() { }
	}
	public partial class HtmlListItem
	{
		[JsMethod(Name = "document.createElement('LI')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlListItem() { }
	}
	public partial class HtmlMarqueeElement
	{
		[JsMethod(Name = "document.createElement('MARQUEE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlMarqueeElement() { }
	}
	public partial class HtmlObjectElement
	{
		[JsMethod(Name = "document.createElement('OBJECT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlObjectElement() { }
	}
	public partial class HtmlOrderedList
	{
		[JsMethod(Name = "document.createElement('OL')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlOrderedList() { }
	}
	public partial class HtmlParagraph
	{
		[JsMethod(Name = "document.createElement('P')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlParagraph() { }
	}
	public partial class HtmlPre
	{
		[JsMethod(Name = "document.createElement('PRE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlPre() { }
	}

	public class HtmlScript : HtmlScriptElement
	{
		[JsMethod(Name = "document.createElement('SCRIPT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlScript() { }
	}
	public partial class HtmlSelect
	{
		[JsMethod(Name = "document.createElement('SELECT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlSelect() { }
	}
	public partial class HtmlSpan
	{
		[JsMethod(Name = "document.createElement('SPAN')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlSpan() { }
	}
	public partial class HtmlStyleElement
	{
		[JsMethod(Name = "document.createElement('STYLE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlStyleElement() { }
	}
	public partial class HtmlStyleSheetPage
	{
		[JsMethod(Name = "document.createElement('STYLESHEETPAGE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlStyleSheetPage() { }
	}
	public partial class HtmlTable
	{
		[JsMethod(Name = "document.createElement('TABLE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTable() { }
	}
	public partial class HtmlTableBody
	{
		[JsMethod(Name = "document.createElement('TBODY')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableBody() { }
	}
	public partial class HtmlTableCell
	{
		[JsMethod(Name = "document.createElement('TD')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableCell() { }
	}
	public partial class HtmlTableCol
	{
		[JsMethod(Name = "document.createElement('COL')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableCol() { }
	}
	public partial class HtmlTableColGroup
	{
		[JsMethod(Name = "document.createElement('COLGROUP')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableColGroup() { }
	}
	public partial class HtmlTableFoot
	{
		[JsMethod(Name = "document.createElement('TFOOT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableFoot() { }
	}
	public partial class HtmlTableHead
	{
		[JsMethod(Name = "document.createElement('THEAD')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableHead() { }
	}
	public partial class HtmlTableHeadCell
	{
		[JsMethod(Name = "document.createElement('TH')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableHeadCell() { }
	}
	public partial class HtmlTableRow
	{
		[JsMethod(Name = "document.createElement('TR')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableRow() { }
	}
	public partial class HtmlTextArea
	{
		[JsMethod(Name = "document.createElement('TEXTAREA')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTextArea() { }
	}
	public partial class HtmlTextNode
	{
		[JsMethod(Name = "document.createTextNode", OmitNewOperator = true)]
		public HtmlTextNode(JsString s) { }
	}
	public partial class HtmlTitle
	{
		[JsMethod(Name = "document.createElement('TITLE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTitle() { }
	}
	public partial class HtmlUnorderedList
	{
		[JsMethod(Name = "document.createElement('UL')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlUnorderedList() { }
	}
	public partial class HtmlWindowLocation
	{
		[JsMethod(Name = "document.createElement('WINDOWLOCATION')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlWindowLocation() { }
	}

	#endregion

	#region HtmlContext
	[JsType(JsMode.Global, Export = false)]
	public partial class HtmlContext : JsContext
	{
		public static Console console { get; private set; }

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
	#region HtmlContextBase
	[JsType(JsMode.Global, Export = false)]
	public partial class HtmlContextBase : JsContextBase
	{
		protected static Console console { get; private set; }

		///<summary>
		///Displays a dialog box containing an application-defined message. 
		///</summary>
		///<param name="message">Optional. String that specifies the message to display in the dialog box.</param>
		///<remarks>You cannot change the title bar of the Alert dialog box.</remarks>
		protected static void alert(object message) { }
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
		protected static JsBoolean confirm(JsString message) { return null; }
		///<summary>
		///Encodes String objects so they can be read on all computers.
		///</summary>
		///<param name="s">String object or literal to be encoded.</param>
		///<returns>A JsString value (in Unicode format) that contains the contents of charstring. All spaces, punctuation, accented characters, and any other non-ASCII characters are replaced with %xx encoding, where xx is equivalent to the hexadecimal number representing the character. For example, a space is returned as "%20."</returns>
		protected static JsString escape(JsString s) { return null; }
		///<summary>
		///Returns the unencoded version of an encoded component of a Uniform Resource Identifier (URI). 
		///</summary>
		///<param name="encodedURIString">A value representing an encoded URI component.</param>
		///<returns>The required encodedURIString argument is a value representing an encoded 
		///URI component.A URIComponent is part of a complete URI. If the encodedURIString is 
		///not valid, a URIError occurs.</returns>
		protected static JsString decodeURIComponent(JsString encodedURIString) { return null; }
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
		///<summary>
		///Encodes a text JsString as a valid Uniform Resource Identifier (URI) 
		///</summary>
		///<param name="URIString">A value representing an encoded URI.</param>
		///<returns>n encoded URI. If you pass the result to decodeURI, the original JsString is returned. The encodeURI method does not encode the following characters: ":", "/", ";", and "?". Use encodeURIComponent to encode these characters.</returns>
		protected static JsString encodeURI(JsString URIString) { return null; }
		///<summary>
		///Returns the unencoded version of an encoded Uniform Resource Identifier (URI). 
		///</summary>
		///<param name="URIString"></param>
		///<returns></returns>
		protected static JsString decodeURI(JsString URIString) { return null; }
		///<summary>
		///Decodes String objects encoded with the escape method.
		///</summary>
		///<param name="charString">String object or literal to be decoded.</param>
		///<returns>A JsString value that contains the contents of charstring. All characters encoded with the %xx hexadecimal form are replaced by their ASCII character set equivalents.</returns>
		protected static JsString unescape(JsString charString) { return null; }
		///<summary>
		///Retrieves the HTML window
		///</summary>
		protected static HtmlWindow window { get; set; }
		///<summary>
		///Retrieves the HTML document
		///</summary>
		protected static HtmlDocument document { get; set; }
	}
	#endregion

}