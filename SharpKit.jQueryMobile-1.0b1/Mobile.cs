
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
    [JsEnum(ValuesAsNames = true)]
    public enum TouchEvents
    {
        /// <summary>
        /// Triggers after a quick, complete touch event.
        /// </summary>
        tap,
        /// <summary>
        ///Triggers after a held complete touch event (close to one second).
        /// </summary>
        taphold,
        /// <summary>
        /// Triggers when a horizontal drag of 30px or more (and less than 20px vertically) occurs within 1 second duration but these can be configured:
        /// <list type="bullet">
        /// <item>scrollSupressionThreshold (default: 10px) – More than this horizontal displacement, and we will suppress scrolling</item>
        /// <item>durationThreshold (default: 1000ms) – More time than this, and it isn’t a swipe</item>
        /// <item>horizontalDistanceThreshold (default: 30px) – Swipe horizontal displacement must be more than this.</item>
        /// <item>verticalDistanceThreshold (default: 75px) – Swipe vertical displacement must be less than this.</item>
        /// </list>
        /// </summary>
        swipe,
        /// <summary>
        /// Triggers when a swipe event occurred moving in the left direction.
        /// </summary>
        swipeleft,
        /// <summary>
        /// Triggers when a swipe event occurred moving in the right direction.
        /// </summary>
        swiperight,
    }
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum OrientationChangeEvent
    {
        /// <summary>
        /// Triggers when a device orientation changes (by turning it vertically or horizontally). When bound to this event, your callback function can leverage a second argument, which contains an orientation property equal to either "portrait" or "landscape". These values are also added as classes to the HTML element, allowing you to leverage them in your CSS selectors. Note that we currently bind to the resize event when orientationChange is not natively supported.
        /// </summary>
        orientationchange,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ScrollEvents
    {
        /// <summary>
        /// Triggers when a scroll begins. Note that iOS devices freeze DOM manipulation during scroll, queuing them to apply when the scroll finishes. We're currently investigating ways to allow DOM manipulations to apply before a scroll starts.
        /// </summary>
        scrollstart,
        /// <summary>
        /// Triggers when a scroll finishes.
        /// </summary>
        scrollstop,
    }

    /// <summary>
    /// Whenever a page is shown or hidden in jQuery Mobile, two events are triggered on that page. The events triggered depend on whether that page is being shown or hidden, so when a page transition occurs, there are actually 4 events triggered: 2 for each page.
    /// Note that all four of these events expose a reference to either the next page (nextPage) or previous page (prevPage), depending on whether the page is being shown or hidden, and whether that next or previous page exists (the first ever page shown does not have a previous page to reference, but an empty jQuery object is provided just the same). You can access this reference via the second argument of a bound callback function.
    /// </summary>
    /// <example>
    /// <code>
    /// $('div').live('pageshow',function(event, ui){alert('This page was just hidden: '+ ui.prevPage);});
    /// $('div').live('pagehide',function(event, ui){alert('This page was just shown: '+ ui.nextPage);});
    /// </code>
    /// </example>
    /// <remarks>
    /// Also, for these handlers to be invoked during the initial page load, you must bind them before jQuery Mobile executes. This can be done in the mobileinit handler, as described on the global config page.
    /// </remarks>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum PageShowHideEvents
    {
        /// <summary>
        /// Triggered on the page being shown, before its transition begins.
        /// </summary>
        pagebeforeshow,
        /// <summary>
        /// Triggered on the page being hidden, before its transition begins.
        /// </summary>
        pagebeforehide,
        /// <summary>
        /// Triggered on the page being shown, after its transition completes.
        /// </summary>
        pageshow,
        /// <summary>
        /// Triggered on the page being hidden, after its transition completes.
        /// </summary>
        pagehide
    }
    /// <summary>
    /// Internally, jQuery Mobile auto-initializes plugins based on the markup conventions found in a given "page". For example, an input element with a type of range will automatically generate a custom slider control.
    ///This auto-initialization is controlled by the "page" plugin, which dispatches events before and after it executes, allowing you to manipulate a page either pre-or-post initialization, or even provide your own intialization behavior and prevent the auto-initializations from occuring. Note that these events will only fire once per "page", as opposed to the show/hide events, which fire every time a page is shown and hidden.
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum PageInitializationEvents
    {
        /// <summary>
        /// Triggered on the page being initialized, before initialization occurs.
        /// </summary>
        /// <example>
        /// <code>
        /// $('#aboutPage').live('pagebeforecreate',function(event){alert('This page was just inserted into the dom!');});
        /// <remarks>
        /// Note that by binding to pagebeforecreate and returning false, you can prevent the page plugin from making its manipulations.
        /// </remarks>
        /// </code>
        /// <code>
        /// $('#aboutPage').live('pagebeforecreate',function(event){//run your own enhancement scripting here...return false;});
        /// </code>
        /// </example>
        pagebeforecreate,
        /// <summary>
        /// Triggered on the page being initialized, after initialization occurs. We recommend binding to this event instead of DOM ready() because this will work regardless of whether the page is loaded directly or if the content is pulled into another page as part of the Ajax navigation system.
        /// </summary>
        /// <example>
        /// <code>
        /// $('#aboutPage').live('pagecreate',function(event){alert('This page was just enhanced by jQuery Mobile!');});
        /// </code>
        /// </example>
        pagecreate,
    }
    /// <summary>
    /// We provide a set of "virtual" click events that normalize mouse and touch events. This allows the developer to register listeners for the basic mouse events, such as mousedown, mousemove, mouseup, and click, and the plugin will take care of registering the correct listeners behind the scenes to invoke the listener at the fastest possible time for that device. This still retains the order of event firing in the traditional mouse environment, should multiple handlers be registered on the same element for different events.
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum VirtualMouseEvents
    {
        /// <summary>
        /// Normalized event for handling touch or mouse mouseover events
        /// </summary>
        vmouseover,
        /// <summary>
        /// Normalized event for handling touch or mouse mousedown events 
        /// </summary>
        vmousedown,
        /// <summary>
        /// Normalized event for handling touch or mouse mousemove events
        /// </summary>
        vmousemove,
        /// <summary>
        /// Normalized event for handling touch or mouse mouseup events 
        /// </summary>
        vmouseup,
        /// <summary>
        /// Normalized event for handling touch or mouse click events
        /// </summary>
        vclick,
        /// <summary>
        /// Normalized event for handling touch or mouse mousecancel events
        /// </summary>
        vmousecancel,
        //TODO: AnimationEvents- jQuery Mobile exposes the animationComplete plugin, which you can utilize after adding or removing a class that applies a CSS transition. 
    }
}
[JsType(JsMode.Prototype)]
public class jQuery
{
    public void live(JsString name, JsAction<Event, UI> handler)
    {
    }
    //TODOpublic void live(LiveEvent name, JsAction<Event, UI> handler)
    //{
    //}
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

/// <summary>
/// The following defaults are configurable via the $.mobile object:
/// </summary>
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
    /// <summary>
    ///default: true
    ///When the DOM is ready, the framework should automatically call $.mobile.initializePage. If false, page will not initialize, and will be visually hidden until until $.mobile.initializePage is manually called.
    /// </summary>
    public bool autoInitializePage { get; set; }
    /// <summary>
    /// default: "ui-page"
    ///The url parameter used for referencing widget-generated sub-pages (such as those generated by nested listviews). Translates to to example.html&ui-page=subpageIdentifier. The hash segment before &ui-page= is used by the framework for making an Ajax request to the URL where the sub-page exists.
    /// </summary>
    public JsString subPageUrlKey { get; set; }
    /// <summary>
    /// default: "ui-page-active"
    /// The class assigned to page currently in view, and during transitions
    /// activeBtnClass string, default: "ui-page-active"
    /// The class used for "active" button state, from CSS framework.
    /// </summary>
    public JsString activePageClass { get; set; }
    /// <summary>
    /// default: "ui-page-active"
    /// The class used for "active" button state, from CSS framework.
    /// </summary>
    public JsString activeBtnClass { get; set; }
    /// <summary>
    /// default: true
    /// jQuery Mobile will automatically handle link clicks and form submissions through Ajax, when possible. If false, url hash listening will be disabled as well, and urls will load as regular http requests.
    /// </summary>
    public bool ajaxEnabled { get; set; }
    /// <summary>
    /// default: true
    /// jQuery Mobile will automatically listen and handle changes to the location.hash. Disabling this will prevent jQuery Mobile from handling hash changes, which allows you to handle them yourself, or simply to use simple deep-links within a document that scroll to a particular ID.
    /// </summary>
    public bool hashListeningEnabled { get; set; }
    /// <summary>
    /// default: 'slide'
    /// Set the default transition for page changes that use Ajax. Set to 'none' for no transitions by default.
    /// </summary>
    public JsString defaultPageTransition { get; set; }
    /// <summary>
    ///  default: 'pop'
    ///  Set the default transition for dialog changes that use Ajax. Set to 'none' for no transitions by default.
    /// </summary>
    public JsString defaultDialogTransition { get; set; }
    /// <summary>
    /// string, default: 150
    /// Minimum scroll distance that will be remembered when returning to a page.
    /// </summary>
    public JsString minScrollBack { get; set; }
    /// <summary>
    /// default: "loading"
    /// Set the text that appears when a page is loading. If set to false, the message will not appear at all.
    /// </summary>
    public JsString loadingMessage { get; set; }
    /// <summary>
    /// default: "Error Loading Page"
    /// Set the text that appears when a page fails to load through Ajax.
    /// </summary>
    public JsString pageLoadErrorMessage { get; set; }
    /// <summary>
    ///  default: a function returning the value of $.support.mediaquery
    ///  Any support conditions that must be met in order to proceed.
    /// </summary>
    public JsFunc<bool> gradeA { get; set; }
}



