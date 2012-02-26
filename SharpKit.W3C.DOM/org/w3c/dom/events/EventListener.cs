namespace org.w3c.dom.events
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, OmitCasts = true)]
    public delegate void EventListener(Event evt);
}