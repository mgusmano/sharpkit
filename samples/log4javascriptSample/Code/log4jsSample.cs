using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.Html;

[assembly: JsExport(UseStrict = true)]

namespace log4javascriptSample.Code
{
    [JsType(JsMode.Global, Filename = "~/Scripts/sample.js")]
    public static class log4jsSample
    {
        static log4jsSample()
        {
            var log = log4javascript.log4javascriptContext.getDefaultLogger();
            log.removeAllAppenders();
            log.setLevel(log4javascript.Level.INFO);
        }

        public static void InitSampleInPageAppender(string elementId)
        {
            var container = HtmlContext.window.document.getElementById(elementId);
            var appender = new log4javascript.InPageAppender(elementId.As<HtmlElement>(), false, false, true, container.clientWidth.As<JsString>(), container.clientHeight.As<JsString>());
            var log = log4javascript.log4javascriptContext.getDefaultLogger();
            log.addAppender(appender);
        }

        public static void InitSampleSelectAppender(string elementId)
        {
            var select = HtmlContext.window.document.getElementById(elementId).As<HtmlSelectElement>();
            var appender = new SelectAppender(select);
            var log = log4javascript.log4javascriptContext.getDefaultLogger();
            log.addAppender(appender);
        }

        public static void AddSampleAll()
        {
            var log = log4javascript.log4javascriptContext.getDefaultLogger();
            log.trace("Trace activated");
            log.debug("Debug activated");
            log.info("Info activated");
            log.warn("Warn activated");
            log.error("Error activated");
            log.fatal("Fatal activated");
        }

        public static void AddSampleText()
        {
            log4javascript.log4javascriptContext.getDefaultLogger().warn("Hello logger !");
        }
    }
}