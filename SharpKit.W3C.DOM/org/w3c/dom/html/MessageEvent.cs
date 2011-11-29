//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using Event = org.w3c.dom.events.Event;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class MessageEvent : Event
{

	// MessageEvent
	public object data {get { return default(object); } }
	public string origin {get { return default(string); } }
	public string lastEventId {get { return default(string); } }
	public Window source {get { return default(Window); } }
	public MessagePort ports {get { return default(MessagePort); } }
	public void initMessageEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object dataArg, string originArg, string lastEventIdArg, Window sourceArg, MessagePort[] portsArg) {}
}

}