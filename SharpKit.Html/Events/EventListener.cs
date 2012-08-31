namespace SharpKit.Html
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, OmitCasts = true)]
    public delegate void EventListener(DOMEvent evt);

}