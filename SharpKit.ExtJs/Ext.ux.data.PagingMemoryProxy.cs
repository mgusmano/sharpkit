//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux.data
{
    #region PagingMemoryProxy
    /// <inheritdocs />
    /// <summary>
    /// <p>Paging Memory Proxy, allows to use paging grid with in memory dataset</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class PagingMemoryProxy : Ext.data.proxy.Memory
    {
        public PagingMemoryProxy(PagingMemoryProxyConfig config){}
        public PagingMemoryProxy(){}
        public PagingMemoryProxy(params object[] args){}
    }
    #endregion
    #region PagingMemoryProxyConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PagingMemoryProxyConfig : Ext.data.proxy.MemoryConfig
    {
        public PagingMemoryProxyConfig(params object[] args){}
    }
    #endregion
    #region PagingMemoryProxyEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PagingMemoryProxyEvents : Ext.data.proxy.MemoryEvents
    {
        public PagingMemoryProxyEvents(params object[] args){}
    }
    #endregion
}
