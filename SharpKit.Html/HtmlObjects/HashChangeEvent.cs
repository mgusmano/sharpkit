//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class HashChangeEvent : DOMEvent
{

	// HashChangeEvent
	public object oldURL {get; private set; }
	public object newURL {get; private set; }
	public void initHashChangeEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string oldURLArg, string newURLArg) {}
}

}