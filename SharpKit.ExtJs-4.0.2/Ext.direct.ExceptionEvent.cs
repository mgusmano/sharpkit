//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.direct
namespace Ext.direct
{
    #region ExceptionEvent
    /// <summary>
    /// An event that is fired when an exception is received from a Ext.direct.RemotingProvider
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ExceptionEvent : RemotingEvent
    {
        public ExceptionEvent(ExceptionEventConfig config){}
        public ExceptionEvent(){}
    }
    #endregion
    #region ExceptionEventConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ExceptionEventConfig : RemotingEventConfig
    {
    }
    #endregion
    #region ExceptionEventEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ExceptionEventEvents : RemotingEventEvents
    {
    }
    #endregion
}
#endregion
