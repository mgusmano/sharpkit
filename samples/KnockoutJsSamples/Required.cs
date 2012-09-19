using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.KnockoutJs;

namespace KnockoutJsSamples
{
    [JsType(JsMode.Prototype, Name="ko.extenders", OmitDefaultConstructor=true)]
    public static class extensions
    {
        public static object required(Target target, string overrideMessage)
        {
            //add some sub-observables to our observable
            target.hasError = Knockout.observable<bool>();
            target.validationMessage = Knockout.observable<JsString>();

            //define a function to do validation
            JsAction<object> validate = (newValue) =>
            {
                target.hasError.Value = newValue.As<bool>() ? false : true;
                target.validationMessage.Value = newValue.As<bool>() ? "" : overrideMessage ?? "This field is required";
            };

            //initial validation
            validate(target.Value);

            //validate whenever the value changes
            target.subscribe(validate);

            //return the original observable
            return target;
        }
    }

    [JsType(JsMode.Prototype, Export=false)]
    public class Target : Observable<object>
    {
        public Observable<bool> hasError { get; set; }

        public Observable<JsString> validationMessage { get; set; }

    }
}