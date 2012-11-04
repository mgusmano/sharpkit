using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.spinner
{
    [JsType(JsMode.Global)]
    public class Default
    {
        //TODO: error in run time, ask dan-el.
        static Default()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            
		var spin = new jQuery( "#spinner" ).spinner();

		new jQuery( "#disable" ).click(() => 
        {
			if ( spin.spinner( "option", "disabled" ).As<bool>() ) {
				spin.spinner( "enable" );
			} else {
				spin.spinner( "disable" );
			}
		});
		new jQuery( "#destroy" ).click(() => {
			if ( spin.data( "ui-spinner" ).As<bool>() ) {
				spin.spinner( "destroy" );
			} else {
				spin.spinner();
			}
		});
		new jQuery( "#getvalue" ).click(() => {
			HtmlContext.window.alert( spin.spinner( "value" ) );
		});
		new jQuery( "#setvalue" ).click(() => {
			spin.spinner( "value", 5 );
		});

		new jQuery( "button" ).button();
        }
    }
}