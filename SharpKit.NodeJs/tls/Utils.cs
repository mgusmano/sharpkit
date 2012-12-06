using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.tls
{
    public partial class Utils
    {
        public object createServer(CreateServerOptions options) { return null; }
        public object createServer(CreateServerOptions options, JsAction secureConnectionListener) { return null; }
        public object connect(ConnectOptions option) { return null; }
        public object connect(ConnectOptions options, JsAction callback) { return null; }
        public object connect(JsNumber port) { return null; }
        public object connect(JsNumber port, JsNumber host) { return null; }
        public object connect(JsNumber port, ConnectOptions options, JsAction callback) { return null; }
        public object connect(JsNumber port, JsNumber host, ConnectOptions options, JsAction callback) { return null; }
    }
    public partial class ConnectOptions
    {
    }
    [JsType(JsMode.Json)]
    public partial class CreateServerOptions
    {
        /// <summary>
        ///  A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format. (Mutually exclusive with the key, cert and ca options.)
        /// </summary>
        [JsProperty(Name = "pfx")]
        public JsString pfxString { get; set; }
        /// <summary>
        ///  A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format. (Mutually exclusive with the key, cert and ca options.)
        /// </summary>
        [JsProperty(Name = "pfx")]
        public Buffer pfxBuffer { get; set; }
        /// <summary>
        ///  A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format. (Mutually exclusive with the key, cert and ca options.)
        ///  Please use the correct type.
        /// </summary>
        public object pfx { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "key")]
        public JsString keyString { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "key")]
        public Buffer keyBuffer { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// Please use the correct type.
        /// </summary>
        public object key { get; set; }
        /// <summary>
        ///  A string of passphrase for the private key or pfx.
        /// </summary>
        public JsString passphrase { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "cert")]
        public JsString certString { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "cert")]
        public Buffer certBuffer { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        ///  Please use the correct type.
        /// </summary>
        public object cert { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// </summary>
        [JsProperty(Name = "ca")]
        public JsArray<JsString> caArrayString { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// </summary>
        public JsArray<Buffer> caArrayBuffer { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// Please use the correct Array type.
        /// </summary>
        public JsArray ca { get; set; }
        /// <summary>
        ///  Either a string or list of strings of PEM encoded CRLs (Certificate Revocation List)
        /// </summary>
        [JsProperty(Name = "crl")]
        public List<JsString> crlList { get; set; }
        /// <summary>
        ///  Either a string or list of strings of PEM encoded CRLs (Certificate Revocation List)
        /// </summary>
        public JsString crl { get; set; }
        /// <summary>
        /// A string describing the ciphers to use or exclude.
        /// </summary>
        public JsString ciphers { get; set; }

        //TODO: ask about honorCipherOrder 

    }
}
