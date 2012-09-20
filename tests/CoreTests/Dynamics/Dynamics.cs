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
        private int HOW_LONG;
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

        void foo2()
        {
            FakeQuery arrivingView = null;


            dynamic arrivingViewProps = new JsObject();
            arrivingViewProps.left = 0;
            arrivingViewProps.leaveTransforms = true;
            var newLeftSide = 7;

            arrivingView.show();
            arrivingView.css("left", newLeftSide);
            arrivingView.animate(arrivingViewProps, HOW_LONG);
        }

        void foo3()
        {
            dynamic reminders = null;
            foreach (dynamic item in reminders)
            {
            }
        }

        void foo4()
        {

            JsAction<object> parseResult = foo5;
            //delegate(object o)
            // {
            //     dynamic result = o;
            //     JsArray data = new JsArray();
            //     JsArray reminders = new JsArray();// DataUtils.toArray(result.PatientReminder);
            //     JsObject reminder;
            //     JsDate now = new JsDate();
            //     JsDate startOfToday = new JsDate(now.getFullYear(), now.getMonth(), now.getDate(), 0, 0, 0, 0);
            //     JsDate dueDate;
            //     foreach (dynamic item in reminders)
            //     {
            //         dueDate = new JsDate(item.DueDate["$t"]);
            //         reminder = new JsObject();
            //         reminder["Due"] = item.DueDate["$t"];
            //         reminder["Done"] = item.PrevDate["$t"];
            //         reminder["Subject"] = item.Description["$t"];
            //         reminder["PastDue"] = dueDate.getTime() < startOfToday.getTime() ? "red" : "";
            //         data.push(reminder);
            //     }
            //     //bool success = true;
            //     //if (success != null)
            //     //{
            //     //    success(data);
            //     //}
            // };

            // send(json, "query", parseResult);

        }

        void foo5(object obj)
        {
            //dynamic result = obj;
            //JsArray data = new JsArray();
            JsArray reminders = new JsArray();// DataUtils.toArray(result.PatientReminder);
            JsObject reminder;
            JsDate now = new JsDate();
            JsDate startOfToday = new JsDate(now.getFullYear(), now.getMonth(), now.getDate(), 0, 0, 0, 0);
            JsDate dueDate;
            foreach (dynamic item in reminders)
            {
                dueDate = new JsDate(item.DueDate["$t"]);
                reminder = new JsObject();
                reminder["Due"] = item.DueDate["$t"];
                reminder["Done"] = item.PrevDate["$t"];
                reminder["Subject"] = item.Description["$t"];
                reminder["PastDue"] = dueDate.getTime() < startOfToday.getTime() ? "red" : "";
                data.push(reminder);
            }
            //bool success = true;
            //if (success != null)
            //{
            //    success(data);
            //}
        }
    }

    [JsType(JsMode.Prototype, Export = false)]
    class FakeQuery
    {
        internal void show()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsAction callback) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsNumber duration) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsString easing) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, object options) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsNumber duration, JsAction callback) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsNumber duration, JsString easing) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsString easing, JsAction callback) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsString duration, JsString easing) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsNumber duration, JsString easing, JsAction callback) { return null; }
        //
        // Summary:
        //     Perform a custom animation of a set of CSS properties.
        public FakeQuery animate(object properties, JsString duration, JsString easing, JsAction callback) { return null; }

        internal void css(string p, int newLeftSide)
        {
            throw new NotImplementedException();
        }
    }

    [JsType(JsMode.Clr)]
    public class Bug1
    {

        private void send()
        {
            send(new { cmd = 5 });
        }

        private void send(dynamic json)
        {
        }

    }

}
