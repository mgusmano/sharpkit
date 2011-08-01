using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    public interface History
    {
        // History
        int length {get;}
        void go();
        void go(int delta);
        void back();
        void forward();
        void pushState(object data, JsString title);
        void pushState(object data, JsString title, JsString url);
        void replaceState(object data, JsString title);
        void replaceState(object data, JsString title, JsString url);
    }

}
