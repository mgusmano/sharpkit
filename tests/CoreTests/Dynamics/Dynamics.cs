using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Dynamics
{
    [JsType(JsMode.Prototype)]
    class Dynamics
    {
        private JsArray data;
        private int selectedIndex;
        private object HOW_LONG;
        void TestMethod() { dynamic d; }


        public void parse(dynamic dateNode)
        {
            JsString dateString = dateNode["$t"];
            dateNode("asdas");
            var x = dateNode.ggg.aaa;
            dateNode.aa.bb = "dd";

        }

        public static bool ContainsIgnoreCase(string str, string other)
        {
            return (str.As<dynamic>().ToLower().IndexOf(other.As<dynamic>().ToLower())) > -1;
        }


        public void selectByURL(JsString url)
        {
            JsArray dataRef = data;
            dynamic item;

            for (int i = 0; i < dataRef.length; i++)
            {
                item = dataRef[i];

                if (item.url == url)
                {
                    if (selectedIndex != i)
                    {
                        selectedIndex = i;
                    }
                    break;
                }
            }

        }


        void foo()
        {
            dynamic arrivingViewProps = new JsObject();
            arrivingViewProps.left = 0;
            arrivingViewProps.leaveTransforms = true;
 
            animate(arrivingViewProps, HOW_LONG);
    }

        private void animate(dynamic arrivingViewProps, object HOW_LONG)
        {
            throw new NotImplementedException();
        }

    }
}
