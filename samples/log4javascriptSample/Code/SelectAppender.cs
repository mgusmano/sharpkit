using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace log4javascriptSample.Code
{
    #region Hackish
    //This is a hackish-way to create an appender recognized by log4javascript
    // Need to add "OmitInheritance = true" and "public static object prototype"
    // https://groups.google.com/d/msg/sharpkit/aDITxYLV0oI/a7yB2902FIgJ
    [JsType(JsMode.Prototype, Filename = "~/Scripts/sample.js", OmitInheritance = true)]
    public class SelectAppender : log4javascript.Appender
    {
        public static object prototype = new log4javascript.Appender();
    #endregion
        #region Normal code
        //[JsType(JsMode.Prototype, Filename = "~/Scripts/sample.js")]
        //public class SelectAppender : log4javascript.Appender
        //{
        #endregion
        private readonly HtmlSelectElement _el;

        public SelectAppender(HtmlSelectElement select)
        {
            this._el = select;
            this.setLayout(new log4javascript.SimpleLayout());
        }

        public override void append(log4javascript.LoggingEvent loggingEvent)
        {
            string messag = this.getFormatedMessage(loggingEvent);
            HtmlOptionElement opt = new HtmlOptionElement(messag, "", false, true);
            this._el.options.add(opt);
        }

        private string getFormatedMessage(log4javascript.LoggingEvent loggingEvent)
        {
            var layout = this.getLayout();
            var formattedMessage = layout.format(loggingEvent);
            if (layout.ignoresThrowable() && loggingEvent.exception != null)
            {
                formattedMessage += loggingEvent.getThrowableStrRep();
            }
            return formattedMessage;
        }

        public override JsString toString()
        {
            return "SelectAppender[" + this._el.id + "]";
        }
    }
}