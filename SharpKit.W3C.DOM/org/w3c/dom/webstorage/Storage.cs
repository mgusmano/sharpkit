using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.webstorage
{

    public interface Storage
    {
        // Storage
        int length {get;}
        JsString key(int index);
        object getItem(string key);
        void setItem(string key, object data);
        void removeItem(string key);
        void clear();
    }

}
