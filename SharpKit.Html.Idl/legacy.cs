using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

namespace SharpKit.Html.Legacy
{

	#region missing

	partial class HtmlNode : Node { }
	partial class HtmlAnchor : HtmlAnchorElement { }
	partial class HtmlAttribute : Attr { }
	partial class HtmlBody : HtmlBodyElement { }
	partial class HtmlBr : HtmlBRElement { }
	partial class HtmlButton : HtmlButtonElement { }
	partial class HtmlCaption : object { }
	partial class HtmlClipboardData : object { }
	partial class HtmlContextBase : object { }
	partial class HtmlCssRule : CssRule { }
	partial class HtmlDiv : HtmlDivElement { }
	partial class HtmlDocumentElement : object { }
	partial class HtmlDocumentFragment : DocumentFragment { }
	partial class HtmlDomEventArgs : object { }
	partial class HtmlDomImplementation : object { }
	partial class HtmlElementStyle : object { }
	partial class HtmlFieldSet : HtmlFieldSetElement { }
	partial class HtmlForm : HtmlFormElement { }
	partial class HtmlHead : HtmlHeadElement { }
	partial class HtmlHorizontalRule : HtmlHRElement { }
	partial class HtmlIFrame : HtmlIFrameElement { }
	partial class HtmlImage : HtmlImageElement { }
	partial class HtmlInput : HtmlInputElement { }
	partial class HtmlInputCheckBox : HtmlInputElement { }
	partial class HtmlLegend : HtmlLegendElement { }
	partial class HtmlLineBreak : HtmlBRElement { }
	partial class HtmlLink : HtmlLinkElement { }
	partial class HtmlListItem : object { }
	partial class HtmlOption : HtmlOptionElement
	{
		HtmlOption(string data, string value, bool defaultSelected, bool selected)
			: base(data, value, defaultSelected, selected) {
		}
	}
	partial class HtmlOrderedList : object { }
	partial class HtmlParagraph : HtmlParagraphElement { }
	partial class HtmlPre : HtmlPreElement { }
	partial class HtmlScreen : Screen { }
	partial class HtmlSelect : HtmlSelectElement { }
	partial class HtmlSpan : HtmlSpanElement { }
	partial class HtmlStyleSheetPage : object { }
	partial class HtmlTable : HtmlTableElement { }
	partial class HtmlTableBody : HtmlTableSectionElement { }
	partial class HtmlTableCell : HtmlTableCellElement { }
	partial class HtmlTableCol : HtmlTableColElement { }
	partial class HtmlTableColGroup : object { }
	partial class HtmlTableFoot : object { }
	partial class HtmlTableHead : object { }
	partial class HtmlTableHeadCell : object { }
	partial class HtmlTableRow : HtmlTableRowElement { }
	partial class HtmlTextArea : HtmlTextAreaElement { }
	partial class HtmlTextNode : Text { }
	partial class HtmlSelection : Selection { }
	partial class HtmlTextRange : Range { }
	partial class HtmlTextRectangle : HtmlTextRectangleCollection { }
	partial class HtmlTitle : HtmlTitleElement { }
	partial class HtmlUnorderedList : object { }
	partial class HtmlWindow : Window { }
	partial class HtmlWindowLocation : Location { }
	partial class HtmlWindowNavigator : Navigator { }
	partial class StyleFilterCollection : object { }
	partial class HtmlNodeCollection<T> : NodeList { }
	partial class HtmlNodeCollection : NodeList { }
	partial class HtmlNodeToAppend : object { }
	partial class HtmlElementCollection : NodeList { }
	partial class HtmlTextRectangleCollection : object { }
	partial class HtmlGenericCollection<T> : object { }
	partial class HtmlAttributeCollection : NamedNodeMap { }
	partial class HtmlDomEventHandler : object { }
	partial class ActiveXObject : HtmlObjectElement { }
	partial class StyleFilter : object { }
	partial class WindowModal : object { }
	partial class HtmlInputText : HtmlInputElement { }
	partial class HtmlInputPassword : HtmlInputElement { }
	partial class HtmlInputImage : HtmlInputElement { }
	partial class HtmlInputRadio : HtmlInputElement { }
	partial class HtmlInputFile : HtmlInputElement { }
	partial class HtmlInputSubmit : HtmlInputElement { }
	partial class HtmlInputReset : HtmlInputElement { }
	partial class HtmlInputHidden : HtmlInputElement { }
	partial class HtmlInputButton : HtmlInputElement { }
	partial class JSON : object { }
	partial class A : HtmlAnchorElement { }
	partial class BODY : HtmlBodyElement { }
	partial class BR : HtmlBRElement { }
	partial class BUTTON : HtmlButtonElement { }
	partial class CAPTION : HtmlCaption { }
	partial class DIV : HtmlDivElement { }
	partial class EMBED : HtmlEmbedElement { }
	partial class FIELDSET : HtmlFieldSetElement { }
	partial class FORM : HtmlFormElement { }
	partial class FRAME : HtmlFrameElement { }
	partial class FRAMESET : HtmlFrameSetElement { }
	partial class HEAD : HtmlHeadElement { }
	partial class HR : HtmlHRElement { }
	partial class IFRAME : HtmlIFrame { }
	partial class INPUT : HtmlInput { }
	partial class LEGEND : HtmlLegendElement { }
	partial class LINK : HtmlLinkElement { }
	partial class LI : HtmlLIElement { }
	partial class MARQUEE : HtmlMarqueeElement { }
	partial class OBJECT : HtmlObjectElement { }
	partial class OL : HtmlOListElement { }
	partial class P : HtmlParagraphElement { }
	partial class PRE : HtmlPreElement { }
	partial class SCRIPT : HtmlScriptElement { }
	partial class SELECT : HtmlSelectElement { }
	partial class SPAN : HtmlSpanElement { }
	partial class TABLE : HtmlTableElement { }
	partial class TBODY : HtmlTableSectionElement { }
	partial class TD : HtmlTableCellElement { }
	partial class COL : HtmlTableColElement { }
	partial class COLGROUP : object { }
	partial class TFOOT : object { }
	partial class THEAD : object { }
	partial class TH : object { }
	partial class TR : HtmlTableRowElement { }
	partial class TEXTAREA : HtmlTextAreaElement { }
	partial class TITLE : HtmlTitleElement { }
	partial class UL : HtmlUListElement { }
	partial class JsBinder : object { }

	#endregion

	#region Constructors

	partial class HtmlAnchor
	{
		[JsMethod(Name = "document.createElement('A')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlAnchor() { }
	}
	partial class HtmlBody
	{
		[JsMethod(Name = "document.createElement('BODY')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlBody() { }
	}
	partial class HtmlBr
	{
		[JsMethod(Name = "document.createElement('BR')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlBr() { }
	}
	partial class HtmlButton
	{
		[JsMethod(Name = "document.createElement('BUTTON')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlButton() { }
	}
	partial class HtmlCaption
	{
		[JsMethod(Name = "document.createElement('CAPTION')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlCaption() { }
	}
	partial class HtmlDiv
	{
		[JsMethod(Name = "document.createElement('DIV')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlDiv() { }
	}
	partial class HtmlDocumentElement
	{
		[JsMethod(Name = "document.createElement('HTML')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlDocumentElement() { }
	}
	partial class HtmlDocumentFragment
	{
		[JsMethod(Name = "document.createDocumentFragment", OmitNewOperator = true)]
		public HtmlDocumentFragment() { }
	}
	partial class HtmlEmbedElement
	{
		[JsMethod(Name = "document.createElement('EMBED')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlEmbedElement() { }
	}
	partial class HtmlFieldSet
	{
		[JsMethod(Name = "document.createElement('FIELDSET')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlFieldSet() { }
	}
	partial class HtmlForm
	{
		[JsMethod(Name = "document.createElement('FORM')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlForm() { }
	}
	partial class HtmlFrameElement
	{
		[JsMethod(Name = "document.createElement('FRAME')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlFrameElement() { }
	}
	partial class HtmlFrameSetElement
	{
		[JsMethod(Name = "document.createElement('FRAMESET')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlFrameSetElement() { }
	}
	partial class HtmlHead
	{
		[JsMethod(Name = "document.createElement('HEAD')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlHead() { }
	}
	partial class HtmlHorizontalRule
	{
		[JsMethod(Name = "document.createElement('HR')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlHorizontalRule() { }
	}
	partial class HtmlIFrame
	{
		[JsMethod(Name = "document.createElement('IFRAME')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlIFrame() { }
	}
	partial class HtmlInput
	{
		[JsMethod(Name = "document.createElement('INPUT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlInput() { }
	}
	public partial class HtmlInputText
	{
		[JsMethod(Name = "document.createElement('INPUT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlInputText() { }
	}
	partial class HtmlInputCheckBox
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
	partial class HtmlLegend
	{
		[JsMethod(Name = "document.createElement('LEGEND')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlLegend() { }
	}
	partial class HtmlLineBreak
	{
		[JsMethod(Name = "document.createElement('BR')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlLineBreak() { }
	}
	partial class HtmlLink
	{
		[JsMethod(Name = "document.createElement('LINK')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlLink() { }
	}
	partial class HtmlListItem
	{
		[JsMethod(Name = "document.createElement('LI')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlListItem() { }
	}
	partial class HtmlMarqueeElement
	{
		[JsMethod(Name = "document.createElement('MARQUEE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlMarqueeElement() { }
	}
	partial class HtmlObjectElement
	{
		[JsMethod(Name = "document.createElement('OBJECT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlObjectElement() { }
	}
	partial class HtmlOrderedList
	{
		[JsMethod(Name = "document.createElement('OL')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlOrderedList() { }
	}
	partial class HtmlParagraph
	{
		[JsMethod(Name = "document.createElement('P')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlParagraph() { }
	}
	partial class HtmlPre
	{
		[JsMethod(Name = "document.createElement('PRE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlPre() { }
	}

	public class HtmlScript : HtmlScriptElement
	{
		[JsMethod(Name = "document.createElement('SCRIPT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlScript() { }
	}
	partial class HtmlSelect
	{
		[JsMethod(Name = "document.createElement('SELECT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlSelect() { }
	}
	partial class HtmlSpan
	{
		[JsMethod(Name = "document.createElement('SPAN')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlSpan() { }
	}
	partial class HtmlStyleElement
	{
		[JsMethod(Name = "document.createElement('STYLE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlStyleElement() { }
	}
	partial class HtmlStyleSheetPage
	{
		[JsMethod(Name = "document.createElement('STYLESHEETPAGE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlStyleSheetPage() { }
	}
	partial class HtmlTable
	{
		[JsMethod(Name = "document.createElement('TABLE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTable() { }
	}
	partial class HtmlTableBody
	{
		[JsMethod(Name = "document.createElement('TBODY')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableBody() { }
	}
	partial class HtmlTableCell
	{
		[JsMethod(Name = "document.createElement('TD')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableCell() { }
	}
	partial class HtmlTableCol
	{
		[JsMethod(Name = "document.createElement('COL')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableCol() { }
	}
	partial class HtmlTableColGroup
	{
		[JsMethod(Name = "document.createElement('COLGROUP')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableColGroup() { }
	}
	partial class HtmlTableFoot
	{
		[JsMethod(Name = "document.createElement('TFOOT')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableFoot() { }
	}
	partial class HtmlTableHead
	{
		[JsMethod(Name = "document.createElement('THEAD')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableHead() { }
	}
	partial class HtmlTableHeadCell
	{
		[JsMethod(Name = "document.createElement('TH')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableHeadCell() { }
	}
	partial class HtmlTableRow
	{
		[JsMethod(Name = "document.createElement('TR')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTableRow() { }
	}
	partial class HtmlTextArea
	{
		[JsMethod(Name = "document.createElement('TEXTAREA')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTextArea() { }
	}
	partial class HtmlTextNode
	{
		[JsMethod(Name = "document.createTextNode", OmitNewOperator = true)]
		public HtmlTextNode(JsString s) { }
	}
	partial class HtmlTitle
	{
		[JsMethod(Name = "document.createElement('TITLE')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlTitle() { }
	}
	partial class HtmlUnorderedList
	{
		[JsMethod(Name = "document.createElement('UL')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlUnorderedList() { }
	}
	partial class HtmlWindowLocation
	{
		[JsMethod(Name = "document.createElement('WINDOWLOCATION')", OmitParanthesis = true, OmitNewOperator = true)]
		public HtmlWindowLocation() { }
	}

	#endregion

}