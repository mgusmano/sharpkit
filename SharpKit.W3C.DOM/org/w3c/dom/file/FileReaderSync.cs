using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.file
{

    public interface FileReaderSync
    {
        // FileReaderSync
        JsString readAsBinaryString(Blob fileBlob);
        JsString readAsText(Blob fileBlob);
        JsString readAsText(Blob fileBlob, JsString encoding);
        JsString readAsDataURL(File file);
    }

}
