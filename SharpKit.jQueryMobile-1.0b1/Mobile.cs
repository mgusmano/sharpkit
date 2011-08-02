
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.jQueryMobile
{
    [JsType(JsMode.Prototype)]
    public partial class Mobile
    {
        
        /// <summary>
        /// Programmatically change from one page to another. 
        /// This method is used internally for the page loading and transitioning that occurs as a result of clicking a link or submitting a form, when those features are enabled.
        /// </summary>
        /// <param name="to">jQuery collection object. ($("#about"))</param>
        public void changePage(object to, ChangePageOptions options)
        {
        }
        /// <summary>
        /// Programmatically change from one page to another. 
        /// This method is used internally for the page loading and transitioning that occurs as a result of clicking a link or submitting a form, when those features are enabled.
        /// </summary>
        /// <param name="to">Absolute or relative URL. ("about/us.html")</param>
        public void changePage(JsString to, ChangePageOptions options)
        {
        }
        /// <summary>
        /// Programmatically change from one page to another. 
        /// This method is used internally for the page loading and transitioning that occurs as a result of clicking a link or submitting a form, when those features are enabled.
        /// </summary>
        /// <param name="to">Absolute or relative URL. ("about/us.html")</param>
        public void changePage(JsString to)
        {
        }
        /// <summary>
        /// Programmatically change from one page to another. 
        /// This method is used internally for the page loading and transitioning that occurs as a result of clicking a link or submitting a form, when those features are enabled.
        /// </summary>
        /// <param name="to">Absolute or relative URL. ("about/us.html")</param>
        public void changePage(object to)
        {
        }

        //TODO: can't find arguments in doc
        public void removeData()
        {
        }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames=true)]
    public enum LiveEvent
    {
        /// <summary>
        /// Triggers after a quick, complete touch event.
        /// </summary>
        tap,
//
//taphold
//Triggers after a held complete touch event (close to one second).
//swipe
//Triggers when a horizontal drag of 30px or more (and less than 20px vertically) occurs within 1 second duration.
//swipeleft
//Triggers when a swipe event occurred moving in the left direction.
//swiperight
//Triggers when a swipe event occurred moving in the right direction.
    }
    [JsType(JsMode.Prototype)]
    public class jQuery
    {
        public void live(JsString name, JsAction<Event, UI> handler)
        {
        }
        public void live(LiveEvent name, JsAction<Event, UI> handler)
        {
        }
    }

    public class Event
    {
    }
    public class UI
    {
    }
    [JsType(JsMode.Json)]
    public partial class ChangePageOptions
    {
        /// <summary>
        /// default:	$.mobile.defaultPageTransition)	The transition to use when showing the page.
        /// </summary>
        public JsString transition { get; set; }

        //        transition (JsString,	default:	$.mobile.defaultPageTransition)	The transition to use when showing the page.
        //reverse (boolean,	default:	false) Decides what direction the transition will run when showing the page.
        //changeHash (boolean,	default:	true) Decides if the hash in the location bar should be updated.
        //role (JsString,	default:	undefined) The data-role value to be used when displaying the page. By default this is undefined which means rely on the value of the @data-role attribute defined on the element.
        //pageContainer (jQuery collection,	default:	$.mobile.pageContainer) Specifies the element that should contain the page.
        //type (JsString, default: "get") Specifies the method ("get" or "post") to use when making a page request.
        //Used only when the 'to' argument of changePage() is a URL.
        //data (object or	JsString,	default: undefined) The data to send with an Ajax page request.
        //Used only when the 'to' argument of changePage() is a URL.
        //reloadPage (boolean, default: false) Forces a reload of a page, even if it is already in the DOM of the page container.
        //Used only when the 'to' argument of changePage() is a URL.
    }
}
