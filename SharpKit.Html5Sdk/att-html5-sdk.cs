using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;

namespace SharpKit.Html5Sdk
{
    public class att_html5_sdk
    {
        public partial class Provider
        {
            public void authorizeApp(AuthorizeAppOptions options) { }
        }
        [JsType(JsMode.Json)]
        public partial class AuthorizeAppOptions
        {
            public JsString authScope { get; set; }
            public JsFunction success { get; set; }
            public JsFunction failure { get; set; }
        }

        /// <summary>
        /// Error Handling:
        ///In case an exception or an error happens, detailed information on the exception/error is available in the error property of the response
        /// </summary>
        [JsType(JsMode.Json)]
        public partial class ProviderOptions
        {
            /// <summary>
            ///  (Default: "att") 
            ///  The base uri path to be prepended to all API calls. 
            /// </summary>
            public JsString apiBasePath { get; set; }
            /// <summary>
            /// (Default: "TL,MOBO,MIM,DC")
            /// This is the default authorization scope used to authorize transactions that require scope and it is not provided.
            /// </summary>
            public JsString authScope { get; set; }
        }
    }
}