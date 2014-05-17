using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBCursorWithValue")]
    public partial class IDBCursorWithValue<K,V> : IDBCursor<K>
    {
        public  V value { get; set; }
    }

}