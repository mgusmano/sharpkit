using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace log4javascript
{
    /// <summary>
    /// Logs messages to a pop-up console window (note: you will need to disable pop-up blockers to use it).
    /// </summary>
    public class PopUpAppender : Appender
    {
        public override JsString toString() { return default(JsString); }
        public override void append(LoggingEvent loggingEvent) { }
    }
}
