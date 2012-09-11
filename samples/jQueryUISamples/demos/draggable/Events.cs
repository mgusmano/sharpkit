using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.draggable
{
    [JsType(JsMode.Global)]
    public class Events
    {
        static Events()
        {
            new jQuery(OnReady);
        }

        //TODO
        static void OnReady()
        {

            var start_counter = new jQuery("#event-start");
            var drag_counter = new jQuery("#event-drag");
            var stop_counter = new jQuery("#event-stop");
            var counts = new JsNumber[3] { 0, 0, 0 };
            new jQuery("#draggable").draggable(new DraggableOptions
            {
                start = (e, ui) =>
                {
                    counts[0]++;
                    updateCounterStatus(drag_counter, counts[0]);
                },
                drag = (e, ui) =>
                    {
                        counts[1]++;
                        updateCounterStatus(drag_counter, counts[1]);
                    },
                stop = (e, ui) =>
                    {
                        counts[2]++;
                        updateCounterStatus(drag_counter, counts[2]);
                    }
            });
        }
        
        static void updateCounterStatus(jQuery event_counter, JsNumber new_count)
        {
            if (!event_counter.hasClass("ui-state-hover"))
            {
                event_counter.addClass("ui-state-hover")
                    .siblings().removeclass("ui-state-hover");
            }
            		// ...then update the numbersKD
			// TODO: $( "span.count", $event_counter ).text( new_count ); - text doesn't get jsNumber
             // new jQuery("span.count", event_counter).text(new_count);
        }
    }
}
