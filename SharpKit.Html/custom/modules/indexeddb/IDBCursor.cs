using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBCursor")]
    public partial class IDBCursor<K>
    {
        public  JsString direction { get; set; }

        public  K key { get; set; }

        public  K primaryKey { get; set; }

        public  IDBAny source { get; set; }

        public  IDBRequest update(object value)
        {
            return default(IDBRequest);
        }

        public  void advance(int count)
        {
        }

        public  void @continue()
        {
        }

        public  void @continue(K key)
        {
        }

        public  IDBRequest delete()
        {
            return default(IDBRequest);
        }
    }

}