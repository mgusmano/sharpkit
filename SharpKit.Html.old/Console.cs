using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.Html
{
    [JsType(JsMode.Prototype, Export = false)]
    public partial class Console
    {

        // Console
        public void log(object format, params object[] arguments) { }
        public void debug(object format, params object[] arguments) { }
        public void info(object format, params object[] arguments) { }
        public void warn(object format, params object[] arguments) { }
        public void error(object format, params object[] arguments) { }
        public void _assert(bool expression, params object[] arguments) { }
        public void dir(object obj) { }
        public void dirxml(Node node) { }
        public void trace() { }
        public void group(object format, params object[] arguments) { }
        public void groupCollapsed(object format, params object[] arguments) { }
        public void groupEnd() { }
        public void time(string name) { }
        public void timeEnd(string name) { }
        public void profile() { }
        public void profile(string title) { }
        public void profileEnd() { }
        public void count() { }
        public void count(string title) { }
    }
}
