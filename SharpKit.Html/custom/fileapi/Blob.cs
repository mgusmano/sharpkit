using SharpKit.JavaScript;

namespace SharpKit.Html.fileapi
{
    public partial class Blob
    {
        public Blob() { }
        public Blob(ArrayBuffer arrayBuffer, object propertyBag = null) { }
        public Blob(ArrayBufferView arrayBufferView, object propertyBag = null) { }
        public Blob(string value, object propertyBag = null) { }

        [JsMethod(Name = "slice")]
        public Blob Slice(long start=0, long end=0, string contentType="") { return null; }

        [JsMethod(Name = "close")]
        public void Close() {}
    }
}