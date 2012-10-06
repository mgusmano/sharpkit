using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.KendoUI.Web;


namespace KendoUISamples.examples.web.datepicker
{

    [JsType(JsMode.Global)]
    public class Rangeselection
    {
        static Rangeselection()
        {
       
        }
        //how to use global variable?
        static void OnReady()
        {
           
            DatePickerGlobals.start.max(DatePickerGlobals.end.value());
            DatePickerGlobals.end.min(DatePickerGlobals.start.value());
        }
     
        static void startChange()
        {
            var startDate = DatePickerGlobals.start.value().As<JsDate>();

            if (startDate.As<JsBoolean>())
            {
                startDate = new JsDate(startDate.As<JsString>());
                startDate.setDate(startDate.getDate() + 1);
                DatePickerGlobals.end.min(startDate);
            }
        }
        static void endChange()
        {
            var endDate = DatePickerGlobals.end.value().As<JsDate>();

            if (endDate.As<JsBoolean>())
            {
                endDate = new JsDate(endDate.As<JsString>());
                endDate.setDate(endDate.getDate() + 1);
                DatePickerGlobals.start.min(endDate);
            }
        }

        public class DatePickerGlobals
        {
            //public static DatePicker start { get; set; }
            public static DatePicker start = new jQuery("#start").kendoDatePicker(new DatePickerConfiguration
            {
                change = startChange
            }).data("kendoDatePicker").As<DatePicker>();
         
            public static DatePicker end = new jQuery("#end").kendoDatePicker(new DatePickerConfiguration
           {
               change = endChange
           }).data("kendoDatePicker").As<DatePicker>();
      

        }
    }
}