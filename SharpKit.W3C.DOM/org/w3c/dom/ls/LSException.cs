//AutoGenerated

namespace org.w3c.dom.ls
{

    public class LSException : Exception
    {
        public LSException(short code, string message) : base(message)
        {
            this.code = code;
        }
        public const short PARSE_ERR = 81;
        public const short SERIALIZE_ERR = 82;
        public short code;
    }

}