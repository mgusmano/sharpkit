//AutoGenerated

namespace org.w3c.dom
{

    public interface DOMConfiguration
    {
        // DOMConfiguration
//TODO:
//ORIGINAL LINE: public void setParameter(String name, Object value) throws DOMException;
        void setParameter(string name, object value);
//TODO:
//ORIGINAL LINE: public Object getParameter(String name) throws DOMException;
        object getParameter(string name);
        bool canSetParameter(string name, object value);
        DOMStringList parameterNames {get;}
    }

}