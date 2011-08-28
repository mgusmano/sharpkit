
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.jQueryMobile
{
    //TODO: $(document).bind("mobileinit"


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

    public class MobileOptions
    {
        /// <summary>
        /// default: ""
        /// The namespace used in data- attributes, for example, data-role. Can be set to anything, including a blank string which is the default. When using, it's clearest if you include a trailing dash, such as "mynamespace-" which maps to data-mynamespace-foo="...".
        /// NOTE: if you're using data- namespacing, you'll need to manually update/override one selector in the theme CSS. The following data selectors should incorporate the namespace you're using:
        /// </summary>
        /// <example>
        /// This example shows how to....
        /// <code>
        /// .ui-mobile [data-mynamespace-role=page], .ui-mobile [data-mynamespace-role=dialog], .ui-page { ...
        /// </code>
        /// </example>
        public JsString ns { get; set; }
    }


    /*


    http://jquerymobile.com/demos/1.0b2/#/demos/1.0b2/docs/api/globalconfig.html
		
autoInitializePage boolean, default: true
When the DOM is ready, the framework should automatically call $.mobile.initializePage. If false, page will not initialize, and will be visually hidden until until $.mobile.initializePage is manually called.
subPageUrlKey string, default: "ui-page"
The url parameter used for referencing widget-generated sub-pages (such as those generated by nested listviews). Translates to to example.html&ui-page=subpageIdentifier. The hash segment before &ui-page= is used by the framework for making an Ajax request to the URL where the sub-page exists.
activePageClass string, default: "ui-page-active"
The class assigned to page currently in view, and during transitions
activeBtnClass string, default: "ui-page-active"
The class used for "active" button state, from CSS framework.
ajaxEnabled boolean, default: true
jQuery Mobile will automatically handle link clicks and form submissions through Ajax, when possible. If false, url hash listening will be disabled as well, and urls will load as regular http requests.
hashListeningEnabled boolean, default: true
jQuery Mobile will automatically listen and handle changes to the location.hash. Disabling this will prevent jQuery Mobile from handling hash changes, which allows you to handle them yourself, or simply to use simple deep-links within a document that scroll to a particular ID.
defaultPageTransition string, default: 'slide'
Set the default transition for page changes that use Ajax. Set to 'none' for no transitions by default.
defaultDialogTransition string, default: 'pop'
Set the default transition for dialog changes that use Ajax. Set to 'none' for no transitions by default.
minScrollBack string, default: 150
Minimum scroll distance that will be remembered when returning to a page.
loadingMessage string, default: "loading"
Set the text that appears when a page is loading. If set to false, the message will not appear at all.
pageLoadErrorMessage string, default: "Error Loading Page"
Set the text that appears when a page fails to load through Ajax.
gradeA function that returns a boolean, default: a function returning the value of $.support.mediaquery
Any support conditions that must be met in order to proceed.
     */
}
