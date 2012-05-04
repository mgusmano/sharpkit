//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// Console creates a visualization for messages logged through calls to a YUI
    /// instance's <code>Y.log( message, category, source )</code> method.  The
    /// debug versions of YUI modules will include logging statements to offer some
    /// insight into the steps executed during that module's operation.  Including
    /// log statements in your code will cause those messages to also appear in the
    /// Console.  Use Console to aid in developing your page or application.
    /// Entry categories &quot;info&quot;, &quot;warn&quot;, and &quot;error&quot;
    /// are also referred to as the log level, and entries are filtered against the
    /// configured logLevel.
    /// </summary>
    public partial class Console
    {
        /// <summary>
        /// Updates the className of the contentBox, which should trigger CSS to
        /// hide or show the body and footer sections depending on the new value.
        /// </summary>
        protected void _afterCollapsedChange(Event e){}
        /// <summary>
        /// Calls this._trimOldEntries() in response to changes in the configured
        /// consoleLimit attribute.
        /// </summary>
        protected void _afterConsoleLimitChange(Event e){}
        /// <summary>
        /// Updates the UI and schedules or cancels the print loop.
        /// </summary>
        protected void _afterPausedChange(Event e){}
        /// <summary>
        /// Updates the UI if changes are made to any of the strings in the strings
        /// attribute.
        /// </summary>
        protected void _afterStringsChange(Event e){}
        /// <summary>
        /// Makes adjustments to the UI if needed when the Console is hidden or shown
        /// </summary>
        protected void _afterVisibleChange(Event e){}
        /// <summary>
        /// Clears the timeout for printing buffered messages.
        /// </summary>
        protected void _cancelPrintLoop(){}
        /// <summary>
        /// Translates message meta into the markup for a console entry.
        /// </summary>
        protected object _createEntryHTML(object m){return null;}
        /// <summary>
        /// Buffers incoming message objects and schedules the printing.
        /// </summary>
        protected void _defEntryFn(Event e){}
        /// <summary>
        /// Clears the console, resets the startTime attribute, enables and
        /// unpauses the widget.
        /// </summary>
        protected void _defResetFn(){}
        /// <summary>
        /// Returns the input string with ampersands (&amp;), &lt, and &gt; encoded
        /// as HTML entities.
        /// </summary>
        protected object _encodeHTML(object s){return null;}
        /// <summary>
        /// Getter method for useBrowserConsole attribute.  Just a pass through to
        /// the YUI instance configuration setting.
        /// </summary>
        protected object _getUseBrowserConsole(){return null;}
        /// <summary>
        /// Performs HTML escaping on strings in the message object.
        /// </summary>
        protected object _htmlEscapeMessage(object m){return null;}
        /// <summary>
        /// Create the DOM structure for the console body&#8212;where messages are
        /// rendered.
        /// </summary>
        protected void _initBody(){}
        /// <summary>
        /// Create the DOM structure for the footer elements.
        /// </summary>
        protected void _initFoot(){}
        /// <summary>
        /// Create the DOM structure for the header elements.
        /// </summary>
        protected void _initHead(){}
        /// <summary>
        /// Determine if incoming log messages are within the configured logLevel
        /// to be buffered for printing.
        /// </summary>
        protected void _isInLogLevel(){}
        /// <summary>
        /// Create a log entry message from the inputs including the following keys:
        /// <ul>
        /// <li>time - this moment</li>
        /// <li>message - leg message</li>
        /// <li>category - logLevel or custom category for the message</li>
        /// <li>source - when provided, the widget or util calling Y.log</li>
        /// <li>sourceAndDetail - same as source but can include instance info</li>
        /// <li>localTime - readable version of time</li>
        /// <li>elapsedTime - ms since last entry</li>
        /// <li>totalTime - ms since Console was instantiated or reset</li>
        /// </ul>
        /// </summary>
        protected object _normalizeMessage(Event e){return null;}
        /// <summary>
        /// Event handler for clicking on the Clear button.  Pass-through to
        /// <code>this.clearConsole()</code>.
        /// </summary>
        protected void _onClearClick(Event e){}
        /// <summary>
        /// Event handler for clicking on the Collapse/Expand button. Sets the
        /// &quot;collapsed&quot; attribute accordingly.
        /// </summary>
        protected void _onCollapseClick(Event e){}
        /// <summary>
        /// Responds to log events by normalizing qualifying messages and passing
        /// them along through the entry event for buffering etc.
        /// </summary>
        protected void _onLogEvent(object msg, object cat, object src){}
        /// <summary>
        /// Event handler for clicking on the Pause checkbox to update the paused
        /// attribute.
        /// </summary>
        protected void _onPauseClick(Event e){}
        /// <summary>
        /// Sets an interval for buffered messages to be output to the console.
        /// </summary>
        protected void _schedulePrint(){}
        /// <summary>
        /// Setter method for logLevel attribute.  Acceptable values are
        /// &quot;error&quot, &quot;warn&quot, and &quot;info&quot (case
        /// insensitive).  Other values are treated as &quot;info&quot;.
        /// </summary>
        protected object _setLogLevel(object v){return null;}
        /// <summary>
        /// Setter method for useBrowserConsole attributes.  Only functional if the
        /// logSource attribute points to a YUI instance.  Passes the value down to
        /// the YUI instance.  NOTE: multiple Console instances cannot maintain
        /// independent useBrowserConsole values, since it is just a pass through to
        /// the YUI instance configuration.
        /// </summary>
        protected object _setUseBrowserConsole(object v){return null;}
        /// <summary>
        /// Removes the oldest message entries from the UI to maintain the limit
        /// specified in the consoleLimit configuration.
        /// </summary>
        protected void _trimOldEntries(){}
        /// <summary>
        /// Set the height of the Console container.  Set the body height to the
        /// difference between the configured height and the calculated heights of
        /// the header and footer.
        /// Overrides Widget.prototype._uiSetHeight.
        /// </summary>
        protected void _uiSetHeight(object v){}
        /// <summary>
        /// Over-ride default content box sizing to do nothing, since we're sizing
        /// the body section to fill out height ourselves.
        /// </summary>
        protected void _uiSizeCB(){}
        /// <summary>
        /// Updates the UI to reflect the new Collapsed state
        /// </summary>
        protected void _uiUpdateCollapsed(object v){}
        /// <summary>
        /// Recalculates dimensions and updates appropriately when shown
        /// </summary>
        protected void _uiUpdateFromHideShow(object v){}
        /// <summary>
        /// Checks or unchecks the paused checkbox
        /// </summary>
        protected void _uiUpdatePaused(object on){}
        /// <summary>
        /// Validator for logSource attribute.
        /// </summary>
        protected object _validateLogSource(object v){return null;}
        /// <summary>
        /// Validates input value for style attribute.  Accepts only values 'inline',
        /// 'block', and 'separate'.
        /// </summary>
        protected object _validateStyle(object style){return null;}
        /// <summary>
        /// Set up event listeners to wire up the UI to the internal state.
        /// </summary>
        protected void bindUI(){}
        /// <summary>
        /// Clear the console of messages and flush the buffer of pending messages.
        /// </summary>
        public void clearConsole(){}
        /// <summary>
        /// Collapses the body and footer.
        /// </summary>
        public void collapse(){}
        /// <summary>
        /// Tears down the instance, flushing event subscriptions and purging the UI.
        /// </summary>
        protected void destructor(){}
        /// <summary>
        /// Expands the body and footer if collapsed.
        /// </summary>
        public void expand(){}
        /// <summary>
        /// Constructor code.  Set up the buffer and entry template, publish
        /// internal events, and subscribe to the configured logEvent.
        /// </summary>
        protected void initializer(){}
        /// <summary>
        /// Wrapper for <code>Y.log</code>.
        /// </summary>
        public void log(object arg){}
        /// <summary>
        /// Outputs buffered messages to the console UI.  This is typically called
        /// from a scheduled interval until the buffer is empty (referred to as the
        /// print loop).  The number of buffered messages output to the Console is
        /// limited to the number provided as an argument.  If no limit is passed,
        /// all buffered messages are rendered.
        /// </summary>
        public void printBuffer(YUI_.DataType_.Number limit){}
        /// <summary>
        /// Generate the Console UI.
        /// </summary>
        protected void renderUI(){}
        /// <summary>
        /// Clears the console and resets internal timers.
        /// </summary>
        public void reset(){}
        /// <summary>
        /// Scrolls to the most recent entry
        /// </summary>
        public void scrollToLatest(){}
        /// <summary>
        /// Sync the UI state to the current attribute state.
        /// </summary>
        public void syncUI(){}
        /// <summary>
        /// Reference to the Node instance that will house the console messages.
        /// </summary>
        protected Node _body{get;set;}
        /// <summary>
        /// Category to prefix all event subscriptions to allow for ease of detach
        /// during destroy.
        /// </summary>
        protected string _evtCat{get;set;}
        /// <summary>
        /// Reference to the Node instance containing the footer contents.
        /// </summary>
        protected Node _foot{get;set;}
        /// <summary>
        /// Reference to the Node instance containing the header contents.
        /// </summary>
        protected Node _head{get;set;}
        /// <summary>
        /// Holds the object API returned from <code>Y.later</code> for the print
        /// loop interval.
        /// </summary>
        protected object _printLoop{get;set;}
        /// <summary>
        /// Static property used to define the default attribute configuration of
        /// the Widget.
        /// </summary>
        public object ATTRS{get;set;}
        /// <summary>
        /// Array of normalized message objects awaiting printing.
        /// </summary>
        protected YUI_.Array buffer{get;set;}
        /// <summary>
        /// Map (object) of classNames used to populate the placeholders in the
        /// Console.HEADER_TEMPLATE, Console.BODY_TEMPLATE, and
        /// Console.FOOTER_TEMPLATE markup when rendering the Console UI.
        /// <p>By default, the keys contained in the object are:</p>
        /// <ul>
        /// <li>console_hd_class</li>
        /// <li>console_bd_class</li>
        /// <li>console_ft_class</li>
        /// <li>console_controls_class</li>
        /// <li>console_checkbox_class</li>
        /// <li>console_pause_class</li>
        /// <li>console_pause_label_class</li>
        /// <li>console_button_class</li>
        /// <li>console_clear_class</li>
        /// <li>console_collapse_class</li>
        /// <li>console_title_class</li>
        /// </ul>
        /// </summary>
        public object CHROME_CLASSES{get;set;}
        /// <summary>
        /// Maximum number of Console entries allowed in the Console body at one
        /// time.  This is used to keep acquired messages from exploding the
        /// DOM tree and impacting page performance.
        /// </summary>
        public YUI_.DataType_.Number consoleLimit{get;set;}
        /// <summary>
        /// Map (object) of classNames used to populate the placeholders in the
        /// Console.ENTRY_TEMPLATE markup when rendering a new Console entry.
        /// <p>By default, the keys contained in the object are:</p>
        /// <ul>
        /// <li>entry_class</li>
        /// <li>entry_meta_class</li>
        /// <li>entry_cat_class</li>
        /// <li>entry_src_class</li>
        /// <li>entry_time_class</li>
        /// <li>entry_content_class</li>
        /// </ul>
        /// </summary>
        public object ENTRY_CLASSES{get;set;}
        /// <summary>
        /// The precise time the last entry was logged.  Used to measure elapsed
        /// time between log messages.
        /// </summary>
        public YUI_.DataType_.Date lastTime{get;set;}
        /// <summary>
        /// Object that will emit the log events.  By default the YUI instance.
        /// To have a single Console capture events from all YUI instances, set
        /// this to the Y.Global object.
        /// </summary>
        public YUI_.EventTarget logSource{get;set;}
        /// <summary>
        /// Maximum number of entries printed in each iteration of the print
        /// loop. This is used to prevent excessive logging locking the page UI.
        /// </summary>
        public YUI_.DataType_.Number printLimit{get;set;}
        /// <summary>
        /// Millisecond timeout between iterations of the print loop, moving
        /// entries from the buffer to the UI.
        /// </summary>
        public YUI_.DataType_.Number printTimeout{get;set;}
        /// <summary>
        /// The baseline time for this Console instance, used to measure elapsed
        /// time from the moment the console module is <code>use</code>d to the
        /// moment each new entry is logged (not rendered).
        /// This value is reset by the instance method myConsole.reset().
        /// </summary>
        public YUI_.DataType_.Date startTime{get;set;}
        /// <summary>
        /// Collection of strings used to label elements in the Console UI.
        /// Default collection contains the following name:value pairs:
        /// <ul>
        /// <li>title : &quot;Log Console&quot;</li>
        /// <li>pause : &quot;Pause&quot;</li>
        /// <li>clear : &quot;Clear&quot;</li>
        /// <li>collapse : &quot;Collapse&quot;</li>
        /// <li>expand : &quot;Expand&quot;</li>
        /// </ul>
        /// </summary>
        public object strings{get;set;}
    }
}
