using SharpKit.JavaScript;
using SharpKit.jQuery;
namespace jQueryUISamples.demos.position
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            
		

		new jQuery( ".positionable" ).css( "opacity", 0.5 );

		new jQuery( " :input" ).bind( "click keyup change", position );

		new jQuery( "#parent" ).draggable(new DraggableOptions {
			dragAction = position
		});

		position();
        }
        static void position() {
			new jQuery( ".positionable" ).position(new PositionOptions {
				of = new jQuery( "#parent" ),
				my = new jQuery( "#my_horizontal" ).val() + " " + new jQuery( "#my_vertical" ).val(),
				at = new jQuery( "#at_horizontal" ).val() + " " + new jQuery( "#at_vertical" ).val(),
				offset = new jQuery( "#offset" ).val().As<JsString>(),
				collision = new jQuery( "#collision_horizontal" ).val() + " " + new jQuery( "#collision_vertical" ).val()

			});
            
		}
    }
}