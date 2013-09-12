using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Events
{
    [JsType(JsMode.Prototype)]
    class CustomEvents
    {
        public event Action MyEvent2;
        public event JsAction MyEvent
        {
            [JsMethod(Name="MyEvent.add")]
            add
            {
            }
            [JsMethod(Name = "MyEvent.remove")]
            remove
            {
            }
        }
        public event JsAction MyEvent3
        {
            add
            {
            }
            remove
            {
            }
        }
    }

    [JsType(JsMode.Prototype)]
    class CustomEventsTest
    {
        void foo()
        {
            var x = new CustomEvents();
            x.MyEvent += new JsAction(x_MyEvent);
            x.MyEvent -= new JsAction(x_MyEvent);
            x.MyEvent2 += x_MyEvent;
            x.MyEvent2 -= x_MyEvent;
        }

        void x_MyEvent()
        {
            throw new NotImplementedException();
        }
    }
}
