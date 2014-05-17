using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBKeyRange")]
    public partial class IDBKeyRange<K>
    {
        public  K lower { get; set; }

        public  K upper { get; set; }

        public  bool lowerOpen { get; set; }

        public  bool upperOpen { get; set; }

        public static IDBKeyRange<K> only(K value)
        {
            return default(IDBKeyRange<K>);
        }

        public static IDBKeyRange<K> lowerBound(K bound)
        {
            return default(IDBKeyRange<K>);
        }

        public static IDBKeyRange<K> lowerBound(K bound, bool open)
        {
            return default(IDBKeyRange<K>);
        }

        public static IDBKeyRange<K> upperBound(K bound)
        {
            return default(IDBKeyRange<K>);
        }

        public static IDBKeyRange<K> upperBound(K bound, bool open)
        {
            return default(IDBKeyRange<K>);
        }

        public static IDBKeyRange<K> bound(K lower, K upper)
        {
            return default(IDBKeyRange<K>);
        }

        public static IDBKeyRange<K> bound(K lower, K upper, bool lowerOpen)
        {
            return default(IDBKeyRange<K>);
        }

        public static IDBKeyRange<K> bound(K lower, K upper, bool lowerOpen, bool upperOpen)
        {
            return default(IDBKeyRange<K>);
        }
    }

}