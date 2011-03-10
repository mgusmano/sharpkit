using System;
using SharpKit.JavaScript;
using SharpKit.Html4;
using System.Diagnostics;
using Sys.Net;
namespace SharpKit.AspNetAjax3_5
{
    [JsType(JsMode.Global, Export=false)]
    public partial class AspNetAjaxContext : HtmlContext
    {
    }
}
namespace Sys
{
    #region Application
    ///<summary>
    ///Provides members that support client-component development.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class Application
    {
        ///<summary>
        ///Raised after all scripts have been loaded but before objects are created.
        ///</summary>
        public static event EventHandler init
        {
            add { }
            remove { }
        }
        ///<summary>
        ///Raised after all scripts have been loaded and the objects in the application have been
        ///created and initialized.
        ///</summary>
        public static event ApplicationLoadEventHandler load
        {
            add { }
            remove { }
        }
        ///<summary>
        ///Occurs when the user clicks the browser's Back or Forward button.
        ///</summary>
        public static event HistoryEventHandler navigate
        {
            add { }
            remove { }
        }
        ///<summary>
        ///Raised before all objects in the client application are disposed, typically when the DOM
        ///window.unload event is raised.
        ///</summary>
        public static event EventHandler unload
        {
            add { }
            remove { }
        }
        ///<summary>
        ///Registers a component with the application and initializes it if the component is not
        ///already initialized.
        ///</summary>
        ///<param name="component">An instance of a type derived from the <see cref="T:Sys.Component" /> class to register with the client application.</param>
        public static void addComponent(Component component) { }
        ///<summary>
        ///Creates a history point and adds it to the browser's history stack.
        ///</summary>
        ///<param name="state">A collection of key/value pairs that represent the state data. This data will be added to the main state to form the global state of the new history point.</param>
        public static void addHistoryPoint(JsObject state) { }
        ///<summary>
        ///Creates a history point and adds it to the browser's history stack.
        ///</summary>
        ///<param name="state">A collection of key/value pairs that represent the state data. This data will be added to the main state to form the global state of the new history point.</param>
        ///<param name="title">The title for the new history point.</param>
        public static void addHistoryPoint(JsObject state, string title) { }
        public static void beginCreateComponents() { }
        public static void endCreateComponents() { }
        ///<summary>
        ///Returns the specified <see cref="T:Sys.Component" /> object.
        ///</summary>
        ///<param name="id">A string that contains the ID of the component to find.</param>
        ///<returns>A Component object that contains the component requested by ID, if found; otherwise, null.</returns>
        public static Component findComponent(string id) { return default(Component); }
        ///<summary>
        ///Returns the specified <see cref="T:Sys.Component" /> object.
        ///</summary>
        ///<param name="id">A string that contains the ID of the component to find.</param>
        ///<param name="parent">The component or element that contains the component to find.</param>
        ///<returns>A Component object that contains the component requested by ID, if found; otherwise, null.</returns>
        public static Component findComponent(string id, IContainer parent) { return default(Component); }
        ///<summary>
        ///Returns an array of all components that have been registered with the application by
        ///using the <see cref="M:Sys.Application.AddComponent(Sys.Component)" /> method.
        ///</summary>
        ///<returns>An array of all components that have been registered with the application by using the AddComponent method.</returns>
        public static Component[] getComponents() { return default(Component[]); }
        ///<summary>
        ///Initializes the application and raises the <see cref="E:Sys.Application.Load" /> event.
        ///</summary>
        public static void initialize() { }
        ///<summary>
        ///Called by a referenced script to indicate that it has been loaded.
        ///</summary>
        public static void notifyScriptLoaded() { }
        ///<summary>
        ///Sequentially queues the scripts to be loaded in the queued order.
        ///</summary>
        ///<param name="scriptUrl">The URL for the referenced script.</param>
        public static void queueScriptReference(string scriptUrl) { }
        ///<summary>
        ///Registers with the application an object that will require disposing.
        ///</summary>
        ///<param name="disposableObject">The object to register.</param>
        public static void registerDisposableObject(Sys.IDisposable disposableObject) { }
        ///<summary>
        ///Removes the object from the application and disposes the object if it is disposable.
        ///</summary>
        ///<param name="component">The component to remove.</param>
        public static void removeComponent(Component component) { }
        ///<summary>
        ///Unregisters a disposable object from the application.
        ///</summary>
        ///<param name="disposableObject">The object to unregister.</param>
        public static void unregisterDisposableObject(Sys.IDisposable disposableObject) { }
        ///<summary>
        ///Gets or sets a value that indicates whether the Web application supports history point management.
        ///</summary>
        public static bool enableHistory { get; set; }
        ///<summary>
        ///Gets a value that indicates whether the application is in the process of creating components.
        ///</summary>
        public static bool isCreatingComponents
        {
            get { return default(bool); }
        }
    }
    #endregion
    #region ApplicationLoadEventArgs
    ///<summary>
    ///Provides a specialized event arguments collection for the <see cref="E:Sys.Application.Load">Load</see>
    ///event of the <see cref="T:Sys.Application" /> class.
    ///</summary>
    public partial class ApplicationLoadEventArgs : EventArgs
    {
        internal ApplicationLoadEventArgs() { }
        ///<summary>
        ///Gets an array of all the components that were created since the last time the
        ///<see cref="E:Sys.Application.Load">Load</see> event was raised.
        ///</summary>
        public Component[] components
        {
            get { return default(Component[]); }
        }
        ///<summary>
        ///Returns a value that indicates whether the page is engaged in a partial-page update.
        ///</summary>
        public bool isPartialLoad
        {
            get { return default(bool); }
        }
    }
    #endregion
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void ApplicationLoadEventHandler(object sender, ApplicationLoadEventArgs e);
    #region Browser
    ///<summary>
    ///Contains information about the browser.
    ///</summary>
    public static partial class Browser
    {
        ///<summary>
        ///Represents the Firefox browsers.
        ///</summary>
        public readonly static object Firefox;
        ///<summary>
        ///Represents the Internet Explorer browsers.
        ///</summary>
        public readonly static object InternetExplorer;
        ///<summary>
        ///Represents the Opera browser.
        ///</summary>
        public readonly static object Opera;
        ///<summary>
        ///Represents the Safari browser.
        ///</summary>
        public readonly static object Safari;
        ///<summary>
        ///Gets the current <see cref="T:Sys.Browser" /> object (usage: Browser.Agent == Browser.InternetExplorer)
        ///</summary>
        [JsProperty(NativeField = true)]
        public static object agent
        {
            get { return default(object); }
        }
        ///<summary>
        ///Returns a value that indicates whether the browser supports a "debugger" statement,
        ///which suspends execution of the script and acts like a breakpoint.
        ///</summary>
        [JsProperty(NativeField = true)]
        public static bool hasDebuggerStatement
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Gets the name of the browser.
        ///</summary>
        [JsProperty(NativeField = true)]
        public static string name
        {
            get { return default(string); }
        }
        ///<summary>
        ///Gets the version of the browser.
        ///</summary>
        [JsProperty(NativeField = true)]
        public static float version
        {
            get { return default(float); }
        }
    }
    #endregion
    #region CancelEventArgs
    ///<summary>
    ///Used by event sources that enable the handler to cancel the operation in progress.
    ///</summary>
    public partial class CancelEventArgs : EventArgs
    {
        ///<summary>
        ///Gets or sets a value that specifies whether the event source should cancel the operation that caused the event.
        ///</summary>
        ///<value>true to request that the event be canceled; otherwise, false. The default is false.</value>
        public bool cancel { get; set; }
    }
    #endregion
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void cancelEventHandler(object sender, CancelEventArgs e);
    #region Component
    ///<summary>
    ///Provides the base class for the <see cref="T:Sys.UI.Control" /> and <see cref="T:Sys.UI.Behavior" /> classes,
    ///and for any other object whose lifetime should be managed by Microsoft ASP.NET AJAX.
    ///</summary>
    public abstract partial class Component : Sys.IDisposable, INotifyDisposing, INotifyPropertyChange
    {
        ///<summary>
        ///Raised when the <see cref="M:Sys.Component.Dispose" /> method is called for a component.
        ///</summary>
        public event EventHandler disposing
        {
            add { }
            remove { }
        }
        ///<summary>
        ///Raised when a property changes.
        ///</summary>
        public event PropertyChangedEventHandler propertyChanged
        {
            add { }
            remove { }
        }
        protected Component() { }
        ///<summary>
        ///Sets the <see cref="P:Sys.Component.IsUpdating" /> property of the current <see cref="T:Sys.Component" /> object to true.
        ///</summary>
        public virtual void beginUpdate() { }
        ///<summary>
        ///Returns a new instance of the <see cref="T:Sys.Component" /> class that uses the specified
        ///parameters and calls the <see cref="M:Sys.Component.Initialize" /> method.
        ///</summary>
        ///<param name="type">The type of the component to create.</param>
        ///<returns>A new instance of the Component class that uses the specified parameters.</returns>
        public static Component create(Type type) { return default(Component); }
        ///<summary>
        ///Returns a new instance of the <see cref="T:Sys.Component" /> class that uses the specified
        ///parameters and calls the <see cref="M:Sys.Component.Initialize" /> method.
        ///</summary>
        ///<param name="type">The type of the component to create.</param>
        ///<param name="properties">A JSON object that describes the properties and their values.</param>
        ///<param name="events">A JSON object that describes the events and their handlers.</param>
        ///<param name="references">A JSON object that describes the properties that are references to other components.</param>
        ///<param name="element">The DOM element the component must be attached to.</param>
        ///<returns>A new instance of the Component class that uses the specified parameters.</returns>
        public static Component create(Type type, JsObject properties, JsObject events, JsObject references, HtmlElement element) { return default(Component); }
        ///<summary>
        ///Raises the <see cref="E:Sys.Component.Disposing" /> event of the current <see cref="T:Sys.Component" /> object
        ///and removes the component from the application.
        ///</summary>
        public virtual void dispose() { }
        ///<summary>
        ///Sets the <see cref="P:Sys.Component.IsUpdating" /> property of the current <see cref="T:Sys.Component" /> object
        ///to false, calls the <see cref="M:Sys.Component.Initialize" /> method if it has not already been called,
        ///and then calls the <see cref="M:Sys.Component.Updated" /> method.
        ///</summary>
        public virtual void endUpdate() { }
        ///<summary>
        ///Sets the <see cref="P:Sys.Component.IsInitialized" /> property of the current <see cref="T:Sys.Component" />
        ///object to true.
        ///</summary>
        public virtual void initialize() { }
        ///<summary>
        ///Raises the <see cref="E:Sys.Component.PropertyChanged" /> event for the specified property.
        ///</summary>
        ///<param name="propertyName">The name of the property that changed.</param>
        protected void raisePropertyChanged(string propertyName) { }
        ///<summary>
        ///Has no built-in functionality; the Updated method is a placeholder for post-update logic
        ///in derived classes.
        ///</summary>
        protected virtual void updated() { }
        ///<summary>
        ///Gets an <see cref="T:Sys.EventHandlerList" /> object that contains references to all the events
        ///and handlers for the current <see cref="T:Sys.Component" /> object.
        ///</summary>
        protected EventHandlerList events
        {
            get { return default(EventHandlerList); }
        }
        ///<summary>
        ///Gets or sets the ID of the current <see cref="T:Sys.Component" /> object.
        ///</summary>
        public string id { get; set; }
        ///<summary>
        ///Gets a value indicating whether the current <see cref="T:Sys.Component" /> object is initialized.
        ///</summary>
        protected bool isInitialized
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Gets a value indicating whether the current <see cref="T:Sys.Component" /> object is updating.
        ///</summary>
        protected bool isUpdating
        {
            get { return default(bool); }
        }
    }
    #endregion
    #region CultureInfo
    ///<summary>
    ///Represents a culture definition that can be applied to other objects that accept a culture-related setting.
    ///</summary>
    public sealed partial class CultureInfo
    {
        internal CultureInfo() { }
        ///<summary>
        ///Applies the current culture when you create a <see cref="T:Sys.CultureInfo" /> object.
        ///</summary>
        [JsProperty(NativeField = true)]
        public static CultureInfo CurrentCulture
        {
            get { return default(CultureInfo); }
        }
        ///<summary>
        ///Gets an object that contains an array of culture-sensitive formatting strings that can be applied to Date type extensions.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsObject dateTimeFormat
        {
            get { return default(JsObject); }
        }
        ///<summary>
        ///Applies the invariant (culture-independent) culture when you create a <see cref="T:Sys.CultureInfo" /> object.
        ///</summary>
        [JsProperty(NativeField = true)]
        public static CultureInfo InvariantCulture
        {
            get { return default(CultureInfo); }
        }
        ///<summary>
        ///Gets the culture value (locale) that represents a language and region.
        ///</summary>
        [JsProperty(NativeField = true)]
        public string name
        {
            get { return default(string); }
        }
        ///<summary>
        ///Gets an object that contains an array of culture-sensitive formatting strings that can be applied to Number type extensions.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsObject numberFormat
        {
            get { return default(JsObject); }
        }
    }
    #endregion
    #region Debug
    ///<summary>
    ///Provides debugging and tracing functionality for client code. This is a static class that
    ///is invoked directly without creating an instance of the class.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class Debug
    {
        ///<summary>
        ///Checks for a condition, and if false, displays a message and prompts the user to break into the debugger.
        ///</summary>
        ///<param name="condition">true to continue to execute code; false to display message and break into the debugger.</param>
        [Conditional("DEBUG")]
        public static void assert(bool condition) { }
        ///<summary>
        ///Checks for a condition, and if false, displays a message and prompts the user to break into the debugger.
        ///</summary>
        ///<param name="condition">true to continue to execute code; false to display message and break into the debugger.</param>
        ///<param name="message">The message to display. The default is an empty string ("").</param>
        [Conditional("DEBUG")]
        public static void assert(bool condition, string message) { }
        ///<summary>
        ///Checks for a condition, and if false, displays a message and prompts the user to break into the debugger.
        ///</summary>
        ///<param name="condition">true to continue to execute code; false to display message and break into the debugger.</param>
        ///<param name="message">The message to display. The default is an empty string ("").</param>
        ///<param name="displayCaller">true to indicate that the name of the function that is calling assert should be displayed in the message. The default is false.</param>
        [Conditional("DEBUG")]
        public static void assert(bool condition, string message, bool displayCaller) { }
        ///<summary>
        ///Clears all trace messages from the debugger output console.
        ///</summary>
        [Conditional("DEBUG")]
        public static void clearTrace() { }
        ///<summary>
        ///Displays a message in the debugger's output window and breaks into the debugger.
        ///</summary>
        ///<param name="message">The message to display.</param>
        [Conditional("DEBUG")]
        public static void fail(string message) { }
        ///<summary>
        ///Appends a text line to the debugger console and to the <c>TraceConsole&lt;textarea&gt;</c> element, if available.
        ///</summary>
        ///<param name="text">The text to display.</param>
        [Conditional("DEBUG")]
        public static void Trace(string text) { }
        ///<summary>
        ///Dumps an object to the debugger console and to the <c>TraceConsole&lt;textarea&gt;</c> element, if available.
        ///</summary>
        ///<param name="obj">The object to dump.</param>
        [Conditional("DEBUG")]
        public static void traceDump(object obj) { }
        ///<summary>
        ///Dumps an object to the debugger console and to the <c>TraceConsole&lt;textarea&gt;</c> element, if available.
        ///</summary>
        ///<param name="obj">The object to dump.</param>
        ///<param name="name">The name of the object.</param>
        [Conditional("DEBUG")]
        public static void traceDump(object obj, string name) { }
    }
    #endregion
    #region EventArgs
    ///<summary>
    ///Used by event sources to pass event argument information.
    ///</summary>
    [JsType(Export = false, NativeOverloads = true, NativeConstructors = true)]
    public partial class EventArgs
    {
        ///<summary>
        ///A static object of type <see cref="T:Sys.EventArgs" /> that is used as a convenient way to
        ///specify an empty EventArgs instance.
        ///</summary>
        public readonly static EventArgs Empty;
    }
    #endregion
    ///<summary>
    ///Delegate for handling generic events.
    ///</summary>
    ///<param name="sender">The object that raised the event.</param>
    ///<param name="e">The <see cref="T:Sys.EventArgs" /> object that contains the event data.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void EventHandler(object sender, EventArgs e);
    #region EventHandlerList
    ///<summary>
    ///Creates a dictionary to hold client-script events and their associated handlers.
    ///</summary>
    [JsType(Export = false, NativeOverloads = true, NativeConstructors = true)]
    public sealed partial class EventHandlerList
    {
        ///<summary>
        ///Attaches a handler to a specified event in an <see cref="T:Sys.EventHandlerList" /> instance
        ///and adds the specified event to the list if not already present.
        ///</summary>
        ///<param name="id">The string literal that will be used as the ID for the event.</param>
        ///<param name="handler">The delegate to handle the event.</param>
        public void addHandler(string id, Delegate handler) { }
        ///<summary>
        ///Returns a single method that can be invoked to call all handlers sequentially for the specified event.
        ///</summary>
        ///<param name="id">The ID for the specified event.</param>
        ///<returns>A single method that can be invoked to call all handlers sequentially for the specified event.</returns>
        public Delegate getHandler(string id) { return default(Delegate); }
        ///<summary>
        ///Removes an event handler from the specified event in a <see cref="T:Sys.EventHandlerList" /> instance.
        ///</summary>
        ///<param name="id">The ID for the event.</param>
        ///<param name="handler">The handler to remove from the event.</param>
        public void removeHandler(string id, Delegate handler) { }
    }
    #endregion
    #region Globals
    [JsType(Export = false, GlobalObject = true)]
    public static partial class Globals
    {
        public static void __doPostBack(string target, string argument) { }
    }
    #endregion
    #region HistoryEventArgs
    ///<summary>
    ///This class is used by the Sys.Application class to hold event arguments for the Navigate event.
    ///</summary>
    public partial class HistoryEventArgs : EventArgs
    {
        internal HistoryEventArgs() { }
        ///<summary>
        ///Retrieves a collection of name/value pairs that represent the state of the page.
        ///</summary>
        public JsObject state
        {
            get { return default(JsObject); }
        }
    }
    #endregion
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void HistoryEventHandler(object sender, HistoryEventArgs e);
    #region IContainer
    ///<summary>
    ///Provides a common interface for all components that can contain other components.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public partial interface IContainer
    {
        void addComponent(Component component);
        Component findComponent(string id);
        Component[] getComponents();
        void removeComponent(Component component);
    }
    #endregion
    #region IDisposable
    ///<summary>
    ///Provides a common interface for application-defined tasks associated with closing,
    ///releasing, or resetting resources held by instances of a registered Microsoft AJAX
    ///Library class.
    ///</summary>
    public partial interface IDisposable
    {
        void dispose();
    }
    #endregion
    #region INotifyDisposing
    ///<summary>
    ///Defines the <see cref="E:Sys.INotifyDisposing.Disposing">Disposing</see> event.
    ///</summary>
    public partial interface INotifyDisposing
    {
        event EventHandler disposing;
    }
    #endregion
    #region INotifyPropertyChange
    ///<summary>
    ///Defines the <see cref="E:Sys.INotifyPropertyChange.PropertyChanged">PropertyChanged</see> event.
    ///</summary>
    public partial interface INotifyPropertyChange
    {
        event PropertyChangedEventHandler propertyChanged;
    }
    #endregion
    #region PropertyChangedEventArgs
    ///<summary>
    ///Describes property changes.
    ///</summary>
    public partial class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(string propertyName) { }
        ///<summary>
        ///Gets the name of the property that changed.
        ///</summary>
        public string propertyName
        {
            get { return default(string); }
        }
    }
    #endregion
    ///<summary>
    ///Delegate for the <see cref="E:Sys.INotifyPropertyChange.PropertyChanged" /> event.
    ///</summary>
    ///<param name="sender">The object that raised the event.</param>
    ///<param name="e">The <see cref="T:Sys.PropertyChangedEventArgs" /> object that contains the event data.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);
    #region StringBuilder
    ///<summary>
    ///Provides an optimized mechanism to concatenate strings.
    ///</summary>
    [JsType(Export = false, NativeOverloads = true, NativeConstructors = true)]
    public sealed partial class StringBuilder
    {
        public StringBuilder() { }
        public StringBuilder(string initialText) { }
        ///<summary>
        ///Appends a copy of a specified string to the end of the <see cref="T:Sys.StringBuilder" /> instance.
        ///</summary>
        ///<param name="text">The string to append to the end of the StringBuilder instance.</param>
        public void append(string text) { }
        ///<summary>
        ///Appends a string with a line terminator to the end of the <see cref="T:Sys.StringBuilder" /> instance.
        ///</summary>
        public void appendLine() { }
        ///<summary>
        ///Appends a string with a line terminator to the end of the <see cref="T:Sys.StringBuilder" /> instance.
        ///</summary>
        ///<param name="text">The string to append with a line terminator to the end fo the StringBuilder instance.</param>
        public void appendLine(string text) { }
        ///<summary>
        ///Clears the contents of the <see cref="T:Sys.StringBuilder" /> instance.
        ///</summary>
        public void clear() { }
        ///<summary>
        ///Determines whether the <see cref="T:Sys.StringBuilder" /> object has any content.
        ///</summary>
        ///<returns>true if the StringBuilder instance contains no elements; otherwise, false.</returns>
        public bool isEmpty() { return default(bool); }
        ///<summary>
        ///Creates a string from the contents of a <see cref="T:Sys.StringBuilder" /> instance.
        ///</summary>
        ///<returns>A string representation of the StringBuilder instance.</returns>
        public override string ToString() { return default(string); }
        ///<summary>
        ///Creates a string from the contents of a <see cref="T:Sys.StringBuilder" /> instance, and
        ///optionally inserts a delimeter between each element of the created string.
        ///</summary>
        ///<param name="separator">A string to append between each element of the string that is returned.</param>
        ///<returns>
        ///A string representation of the StringBuilder instance. If <paramref name="separator" />
        ///is specified, the delimeter string is inserted between each element of the returned string.
        ///</returns>
        public string toString(string separator) { return default(string); }
    }
    #endregion
}
namespace Sys.Net
{
    #region NetworkRequestEventArgs
    ///<summary>
    ///Contains information about a Web request that is ready to be sent to the current
    ///<see cref="T:Sys.Net.WebRequestExecutor" /> instance.
    ///</summary>
    public sealed partial class NetworkRequestEventArgs : CancelEventArgs
    {
        internal NetworkRequestEventArgs() { }
        ///<summary>
        ///Gets the Web request to be routed to the current <see cref="T:Sys.Net.WebRequestExecutor" /> instance.
        ///</summary>
        public Sys.Net.WebRequest webRequest
        {
            get { return default(Sys.Net.WebRequest); }
        }
    }
    #endregion
    ///<summary>
    ///Delegate for responding to the <see cref="E:Sys.Net.WebRequestManager.InvokingRequest" /> event.
    ///</summary>
    ///<param name="sender">The <see cref="T:Sys.Net.WebRequestManager" /> instance that raised the event.</param>
    ///<param name="e">The <see cref="T:Sys.Net.NetworkRequestEventArgs" /> object that contains the event data.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void NetworkRequestEventHandler(object sender, NetworkRequestEventArgs e);
    #region WebRequest
    ///<summary>
    ///Provides an API to make Web requests.
    ///</summary>
    public sealed partial class WebRequest
    {
        ///<summary>
        ///Occurs when the work being performed by the associated executor is finished. An executor
        ///finishes its work in one of three states: completed, aborted, or timed out.
        ///</summary>
        public event WebRequestCompletedCallback completed
        {
            add { }
            remove { }
        }
        ///<summary>
        ///Gets the resolved URL of the <see cref="T:Sys.Net.WebRequest" /> instance.
        ///</summary>
        ///<returns>
        ///The absolute URL representation of the URL associated with the WebRequest instance.
        ///The URL includes the protocol identifier and the fully qualified domain name.
        ///</returns>
        public string getResolvedUrl() { return default(string); }
        ///<summary>
        ///Executes the Web request.
        ///</summary>
        public void invoke() { }
        ///<summary>
        ///Gets or sets the HTTP body of the WebRequest.
        ///</summary>
        public string body { get; set; }
        ///<summary>
        ///Gets the executor of the associated <see cref="T:Sys.Net.WebRequest" /> instance.
        ///</summary>
        public WebRequestExecutor Executor
        {
            get { return default(WebRequestExecutor); }
        }
        ///<summary>
        ///Gets the dictionary of name/value pairs that contains the HTTP headers that are sent with the Web request.
        ///</summary>
        public JsObject headers
        {
            get { return default(JsObject); }
        }
        ///<summary>
        ///Gets or sets the HTTP verb for the Web request, which must be an HTTP verb that is recognized by the Web server, such as "GET" or "POST".
        ///</summary>
        public string httpVerb { get; set; }
        ///<summary>
        ///Gets or sets the time-out value in milliseconds for the <see cref="T:Sys.Net.WebRequest" /> instance.
        ///</summary>
        public JsNumber timeout { get; set; }
        ///<summary>
        ///Gets or sets the URL of the <see cref="T:Sys.Net.WebRequest" /> instance.
        ///</summary>
        public string url { get; set; }
        ///<summary>
        ///Gets or sets the user context associated with the <see cref="T:Sys.Net.WebRequest" /> instance.
        ///</summary>
        public object userContext { get; set; }
    }
    #endregion
    ///<summary>
    ///Delegate for handling the completed event raised by the WebRequest class.
    ///</summary>
    ///<param name="executor">The executor instance associated with the completed request.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void WebRequestCompletedCallback(WebRequestExecutor executor);
    #region WebRequestExecutor
    ///<summary>
    ///Provides the abstract base class from which network executors derive.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class WebRequestExecutor
    {
        protected WebRequestExecutor() { }
        ///<summary>
        ///Stops the pending network request issued by the executor.
        ///</summary>
        public abstract void abort();
        ///<summary>
        ///Instructs the executor to execute a Web request.
        ///</summary>
        protected abstract void executeRequest();
        ///<summary>
        ///Gets all the response headers for the current request.
        ///</summary>
        ///<returns>All the response headers for the current request.</returns>
        public abstract string getAllResponseHeaders();
        ///<summary>
        ///Gets the value of the specified response header.
        ///</summary>
        ///<returns>The specified response header.</returns>
        public abstract string getResponseHeader(string header);
        ///<summary>
        ///Gets a value indicating whether the request associated with the executor was aborted.
        ///</summary>
        public abstract bool aborted { get; }
        ///<summary>
        ///Gets the result object by JSON deserializing the response data.
        ///</summary>
        public virtual object get_object() { return default(object); }
        ///<summary>
        ///Gets a value indicating whether the request completed successfully.
        ///</summary>
        public abstract bool responseAvailable { get; }
        ///<summary>
        ///Gets the text representation of the response body.
        ///</summary>
        public abstract string responseData { get; }
        ///<summary>
        ///Returns a value indicating whether the executor has started processing the request.
        ///</summary>
        public abstract bool started { get; }
        ///<summary>
        ///Gets the status code of the response associated with the request being processed.
        ///</summary>
        public abstract JsNumber statusCode { get; }
        ///<summary>
        ///Gets the status text of the response associated with the request being processed.
        ///</summary>
        public abstract string statusText { get; }
        ///<summary>
        ///Gets a value indicating whether the request timed out.
        ///</summary>
        public abstract bool timedOut { get; }
        ///<summary>
        ///Gets the associated <see cref="P:Sys.Net.WebRequestExecutor.WebRequest" /> object.
        ///</summary>
        public Sys.Net.WebRequest webRequest
        {
            get { return default(Sys.Net.WebRequest); }
        }
        ///<summary>
        ///Attempts to get the response to the current request as an XMLDOM object.
        ///</summary>
        public abstract HtmlDocument xml { get; }
    }
    #endregion
    #region WebRequestManager
    ///<summary>
    ///Manages the flow of Web requests between the <see cref="T:Sys.Net.WebRequest" /> object and the
    ///executor instance that makes the network requests.
    ///</summary>
    public static partial class WebRequestManager
    {
        ///<summary>
        ///Occurs after a web request has executed.
        ///</summary>
        public static event Sys.EventHandler completedRequest
        {
            add { }
            remove { }
        }
        ///<summary>
        ///Occurs before the Web request has executed.
        ///</summary>
        public static event NetworkRequestEventHandler invokingRequest
        {
            add { }
            remove { }
        }
        ///<summary>
        ///Gets or sets the default network executor type that is used to make network requests.
        ///</summary>
        public static string defaultExecutorType { get; set; }
        ///<summary>
        ///Gets or sets the time-out for the default network executor.
        ///</summary>
        ///<value>The time in milliseconds that the default executor should wait before timing out a Web request. This value must be 0 or a positive integer.</value>
        public static JsNumber defaultTimeout { get; set; }
    }
    #endregion
    #region WebServiceError
    ///<summary>
    ///Represents the object type returned to the browser when a Web service issues an error.
    ///</summary>
    public sealed partial class WebServiceError
    {
        internal WebServiceError() { }
        ///<summary>
        ///Gets the error exception type.
        ///</summary>
        public string exceptionType
        {
            get { return default(string); }
        }
        ///<summary>
        ///Gets the error message.
        ///</summary>
        public string message
        {
            get { return default(string); }
        }
        ///<summary>
        ///Gets the error stack trace.
        ///</summary>
        public string stackTrace
        {
            get { return default(string); }
        }
        ///<summary>
        ///Gets the underlying HTTP error status code for the Web request.
        ///</summary>
        public JsNumber statusCode
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets a value that indicates whether the Web service failed because of a time-out.
        ///</summary>
        public bool timedOut
        {
            get { return default(bool); }
        }
    }
    #endregion
    ///<summary>
    ///Delegate for handling the <see cref="M:Sys.Net.WebServiceProxy.Invoke(System.String,System.String,System.Boolean,System.Dictionary,Sys.Net.WebServiceSuccessCallback,Sys.Net.WebServiceFailureCallback,System.Object,System.Int32)">
    ///WebServiceProxy.Invoke</see> failure callback.
    ///</summary>
    ///<param name="error">A <see cref="T:Sys.Net.WebServiceError" /> object that contains details of the error.</param>
    ///<param name="userContext">Any user-specific information. userContext can be any JavaScript primitive type, array, or object.</param>
    ///<param name="methodName">The name of the Web service method that was invoked.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void WebServiceFailureCallback(WebServiceError error, object userContext, JsString methodName);
    #region WebServiceProxy
    ///<summary>
    ///Enables calling a method of a specified Web service asynchronously.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class WebServiceProxy
    {
        protected WebServiceProxy() { }
        ///<summary>
        ///Invokes the specified Web service method.
        ///</summary>
        ///<param name="servicePath">The Web service URL.</param>
        ///<param name="methodName">The name of the Web service method to invoke.</param>
        ///<param name="useGet">false if the Web request HTTP verb is POST; otherwise, true. The default is false.</param>
        ///<param name="parameters">A dictionary that contains name/value pairs that correspond to the parameters of the method to call.</param>
        ///<returns>The <see cref="T:Sys.Net.WebRequest" /> that was created to invoke the method.</returns>
        public static WebRequest invoke(string servicePath, string methodName, bool useGet, JsObject parameters) { return default(WebRequest); }
        ///<summary>
        ///Invokes the specified Web service method.
        ///</summary>
        ///<param name="servicePath">The Web service URL.</param>
        ///<param name="methodName">The name of the Web service method to invoke.</param>
        ///<param name="useGet">false if the Web request HTTP verb is POST; otherwise, true. The default is false.</param>
        ///<param name="parameters">A dictionary that contains name/value pairs that correspond to the parameters of the method to call.</param>
        ///<param name="successCallback">The function invoked as a callback if the Web service method call returns successfully. If no callback function is provided, no action is taken when the Web service method finishes successfully.</param>
        ///<param name="failedCallback">The function invoked as a callback if the Web service method call fails. If no callback function is provided, no action is taken if an error occurs during the Web service method call.</param>
        ///<param name="userContext">Any user-specific information to be passed to either callback.</param>
        ///<returns>The <see cref="T:Sys.Net.WebRequest" /> that was created to invoke the method.</returns>
        public static WebRequest invoke(string servicePath, string methodName, bool useGet, JsObject parameters, WebServiceSuccessCallback successCallback, WebServiceFailureCallback failedCallback, object userContext) { return default(WebRequest); }
        ///<summary>
        ///Invokes the specified Web service method.
        ///</summary>
        ///<param name="servicePath">The Web service URL.</param>
        ///<param name="methodName">The name of the Web service method to invoke.</param>
        ///<param name="useGet">false if the Web request HTTP verb is POST; otherwise, true. The default is false.</param>
        ///<param name="parameters">A dictionary that contains name/value pairs that correspond to the parameters of the method to call.</param>
        ///<param name="successCallback">The function invoked as a callback if the Web service method call returns successfully. If no callback function is provided, no action is taken when the Web service method finishes successfully.</param>
        ///<param name="failedCallback">The function invoked as a callback if the Web service method call fails. If no callback function is provided, no action is taken if an error occurs during the Web service method call.</param>
        ///<param name="userContext">Any user-specific information to be passed to either callback.</param>
        ///<param name="timeout">The time in milliseconds after which the request is timed out and aborted.</param>
        ///<returns>The <see cref="T:Sys.Net.WebRequest" /> that was created to invoke the method.</returns>
        public static WebRequest invoke(string servicePath, string methodName, bool useGet, JsObject parameters, WebServiceSuccessCallback successCallback, WebServiceFailureCallback failedCallback, object userContext, JsNumber timeout) { return default(WebRequest); }
        ///<summary>
        ///Gets or sets the default failed callback function for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
        ///</summary>
        public WebServiceFailureCallback defaultFailedCallback { get; set; }
        ///<summary>
        ///Gets or sets the default succeeded callback function for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
        ///</summary>
        public WebServiceSuccessCallback defaultSucceededCallback { get; set; }
        ///<summary>
        ///Gets or sets the default user context for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
        ///</summary>
        public object defaultUserContext { get; set; }
        ///<summary>
        ///Gets or sets the path to the Web service for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
        ///</summary>
        public string path { get; set; }
        ///<summary>
        ///Gets or sets the time-out value in milliseconds for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
        ///</summary>
        public JsNumber timeout { get; set; }
    }
    #endregion
    ///<summary>
    ///Delegate for handling the <see cref="M:Sys.Net.WebServiceProxy.Invoke(System.String,System.String,System.Boolean,System.Dictionary,Sys.Net.WebServiceSuccessCallback,Sys.Net.WebServiceFailureCallback,System.Object,System.Int32)">
    ///WebServiceProxy.Invoke</see> success callback.
    ///</summary>
    ///<param name="result">The result of the Web service call: either JSON, XML, or text.</param>
    ///<param name="userContext">Any user-specific information. userContext can be any JavaScript primitive type, array, or object.</param>
    ///<param name="methodName">The name of the Web service method that was invoked.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void WebServiceSuccessCallback(object result, object userContext, string methodName);
    #region XMLHttpExecutor
    ///<summary>
    ///Makes asynchronous network requests by using the browser's XMLHTTP support.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public sealed partial class XMLHttpExecutor : WebRequestExecutor
    {
        internal XMLHttpExecutor() { }
        ///<summary>
        ///Stops the pending network request issued by the executor.
        ///</summary>
        public override void abort() { }
        ///<summary>
        ///Instructs the executor to execute a Web request.
        ///</summary>
        protected override void executeRequest() { }
        ///<summary>
        ///Gets all the response headers for the current request.
        ///</summary>
        ///<returns>All the response headers for the current request.</returns>
        public override string getAllResponseHeaders() { return default(string); }
        ///<summary>
        ///Gets the value of the specified response header.
        ///</summary>
        ///<returns>The specified response header.</returns>
        public override string getResponseHeader(string header) { return default(string); }
        ///<summary>
        ///Gets a value indicating whether the request associated with the executor was aborted.
        ///</summary>
        public override bool aborted
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Gets a value indicating whether the request completed successfully.
        ///</summary>
        public override bool responseAvailable
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Gets the text representation of the response body.
        ///</summary>
        public override string responseData
        {
            get { return default(string); }
        }
        ///<summary>
        ///Returns a value indicating whether the executor has started processing the request.
        ///</summary>
        public override bool started
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Gets a success status code.
        ///</summary>
        public override JsNumber statusCode
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets status information about a request that completed successfully.
        ///</summary>
        public override string statusText
        {
            get { return default(string); }
        }
        ///<summary>
        ///Gets a value indicating whether the request timed out.
        ///</summary>
        public override bool timedOut
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Attempts to get the response to the current request as an XMLDOM object.
        ///</summary>
        public override HtmlDocument xml
        {
            get { return default(HtmlDocument); }
        }
    }
    #endregion
}
namespace Sys.Serialization
{
    #region JavaScriptSerializer
    ///<summary>
    ///Serializes ECMAScript (JavaScript) types into JSON-formatted data and deserializes
    ///JSON-formatted data into JavaScript types.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class JavaScriptSerializer
    {
        ///<summary>
        ///Converts a JSON string into an ECMAScript (JavaScript) object graph.
        ///</summary>
        ///<param name="s">The JSON string to deserialize.</param>
        ///<returns></returns>
        public static object deserialize(string s) { return default(object); }
        ///<summary>
        ///Converts an ECMAScript (JavaScript) object graph into a JSON string.
        ///</summary>
        ///<param name="o">The JavaScript object graph to serialize.</param>
        ///<returns>A JSON string representation of the JavaScript object graph.</returns>
        public static string serialize(object o) { return default(string); }
    }
    #endregion
}
namespace Sys.Services
{
    #region AuthenticationService
    ///<summary>
    ///Provides the client proxy class for the authentication service.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class AuthenticationService
    {
        ///<summary>
        ///Authenticates the user's credentials.
        ///</summary>
        ///<param name="username">The user name to authenticate.</param>
        ///<param name="password">The user's password. The default is null.</param>
        public static void login(string username, string password) { }
        ///<summary>
        ///Authenticates the user's credentials.
        ///</summary>
        ///<param name="username">The user name to authenticate.</param>
        ///<param name="password">The user's password. The default is null.</param>
        ///<param name="isPersistent">true if the issued authentication ticket should be persistent across browser sessions; otherwise, false. The default is false.</param>
        ///<param name="customInfo">Reserved for future use. The default is null.</param>
        ///<param name="redirectUrl">The URL to redirect the browser to on successful authentication. If null, no redirect occurs. The default is null.</param>
        ///<param name="loginCompletedCallback">The function to call when the login has finished successfully. The default is null.</param>
        ///<param name="failedCallback">The function to call if the login fails. The default is null.</param>
        ///<param name="userContext">User context information that you are passing to the callback functions.</param>
        public static void login(string username, string password, bool isPersistent, string customInfo, string redirectUrl, AuthenticationServiceLoginCallback loginCompletedCallback, WebServiceFailureCallback failedCallback, object userContext) { }
        ///<summary>
        ///Logs out the currently authenticated user.
        ///</summary>
        public static void logout() { }
        ///<summary>
        ///Logs out the currently authenticated user.
        ///</summary>
        ///<param name="redirectUrl">The URL to redirect the browser to on successful logout. The default is null.</param>
        ///<param name="logoutCompletedCallback">The function that is called when the logout has finished. The default is null.</param>
        ///<param name="failedCallback">The function that is called if the logout has failed. The default is null.</param>
        ///<param name="userContext">User context information that you are passing to the callback functions.</param>
        public static void logout(string redirectUrl, WebServiceSuccessCallback logoutCompletedCallback, WebServiceFailureCallback failedCallback, object userContext) { }
        ///<summary>
        ///Gets or sets the name of the default failure callback function.
        ///</summary>
        public static WebServiceFailureCallback defaultFailedCallback { get; set; }
        ///<summary>
        ///Gets or sets the name of the default login-completed callback function.
        ///</summary>
        public static AuthenticationServiceLoginCallback defaultLoginCompletedCallback { get; set; }
        ///<summary>
        ///Gets or sets the name of the default logout-completed callback function.
        ///</summary>
        public static WebServiceSuccessCallback defaultLogoutCompletedCallback { get; set; }
        ///<summary>
        ///Gets the authentication state of the current user.
        ///</summary>
        public static bool isLoggedIn
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Gets or sets the authentication service path.
        ///</summary>
        public static string path { get; set; }
        ///<summary>
        ///Gets or sets the authentication service time-out value in milliseconds.
        ///</summary>
        public static JsNumber timeout { get; set; }
    }
    #endregion
    ///<summary>
    ///Delegate for responding to the <see cref="M:Sys.Services.AuthenticationService.Login(System.String,System.String,System.Boolean,System.String,System.String,Sys.Services.AuthenticationServiceLoginCallback,Sys.Net.WebServiceFailureCallback,System.Object)">AuthenticationService.Login</see> events.
    ///</summary>
    ///<param name="validCredentials">Returns true if the user was authenticated.</param>
    ///<param name="userContext">Any user-specific information. userContext can be any JavaScript primitive type, array, or object.</param>
    ///<param name="methodName">The name of the Web service method that was invoked.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void AuthenticationServiceLoginCallback(bool validCredentials, object userContext, string methodName);
    #region ProfileGroup
    ///<summary>
    ///Defines the type of an element as a group in the <see cref="P:Sys.Services.ProfileService.Properties">Properties</see>
    ///collection of the <see cref="T:Sys.Services.ProfileService" /> class.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public sealed partial class ProfileGroup
    {
        public ProfileGroup(JsObject properties) { }
        [JsProperty(NativeIndexer = true)]
        public object this[string name] { get { return default(object); } set { } }
    }
    #endregion
    #region ProfileService
    ///<summary>
    ///Provides the client proxy class for the profile service.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class ProfileService
    {
        ///<summary>
        ///Loads all profile properties enabled for read access.
        ///</summary>
        public static void load() { }
        ///<summary>
        ///Loads the specified profile properties.
        ///</summary>
        ///<param name="propertyNames">A string array that contains the profile properties to load.</param>
        ///<param name="loadCompletedCallback">The function that is called when loading has completed. The default is null.</param>
        ///<param name="failedCallback">The function that is called when loading has failed. The default is null.</param>
        ///<param name="userContext">User context information passed to the callback functions.</param>
        public static void load(string[] propertyNames, ProfileServiceCompletedCallback loadCompletedCallback, WebServiceFailureCallback failedCallback, object userContext) { }
        ///<summary>
        ///Saves all profile properties.
        ///</summary>
        public static void save() { }
        ///<summary>
        ///Saves the specified profile properties.
        ///</summary>
        ///<param name="propertyNames">A string array that contains the profile properties to save.</param>
        ///<param name="saveCompletedCallback">The function that is called when the save method has finished. The default is null.</param>
        ///<param name="failedCallback">The function that is called if the save method has failed. The default is null.</param>
        ///<param name="userContext">User context information passed to the callback functions.</param>
        public static void save(string[] propertyNames, ProfileServiceCompletedCallback saveCompletedCallback, WebServiceFailureCallback failedCallback, object userContext) { }
        ///<summary>
        ///Gets or sets the name of the default failure callback function.
        ///</summary>
        public static WebServiceFailureCallback defaultFailedCallback { get; set; }
        ///<summary>
        ///Gets or sets the name of the default load-completed callback function.
        ///</summary>
        public static ProfileServiceCompletedCallback defaultLoadCompletedCallback { get; set; }
        ///<summary>
        ///Gets or sets the name of the default save-completed callback function.
        ///</summary>
        public static ProfileServiceCompletedCallback defaultSaveCompletedCallback { get; set; }
        ///<summary>
        ///Gets or sets the profile service path.
        ///</summary>
        public static string path { get; set; }
        ///<summary>
        ///Contains the loaded profile data.
        ///</summary>
        public static JsObject properties
        {
            get { return default(JsObject); }
        }
        ///<summary>
        ///Gets or sets the profile service time-out value in milliseconds.
        ///</summary>
        public static JsNumber timeout { get; set; }
    }
    #endregion
    ///<summary>
    ///Delegate for responding to the <see cref="M:Sys.Services.ProfileService.Load(System.String[],Sys.Services.ProfileServiceCompletedCallback,Sys.Net.WebServiceFailureCallback,System.Object)" /> and <see cref="M:Sys.Services.ProfileService.Save(System.String[],Sys.Services.ProfileServiceCompletedCallback,Sys.Net.WebServiceFailureCallback,System.Object)">
    ///ProfileService.Save</see> success events.
    ///</summary>
    ///<param name="propertyCount">Indicates the number of properties returned by the profile service.</param>
    ///<param name="userContext">Any user-specific information. userContext can be any JavaScript primitive type, array, or object.</param>
    ///<param name="methodName">The name of the Web service method that was invoked.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void ProfileServiceCompletedCallback(JsNumber propertyCount, object userContext, string methodName);
}
namespace Sys.UI
{
    #region Behavior
    ///<summary>
    ///Provides a base class for all Microsoft ASP.NET AJAX behaviors.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class Behavior : Component
    {
        protected Behavior(HtmlElement element) { }
        ///<summary>
        ///Gets a <see cref="T:Sys.UI.Behavior" /> instance that has the specified <see cref="P:Sys.UI.Behavior.Name" />
        ///property from the specified <see cref="T:Sys.UI.DomElement" /> object.
        ///</summary>
        ///<param name="element">The DOM element to search.</param>
        ///<param name="name">The name property of the Behavior instance to look for.</param>
        ///<returns>The specified Behavior object, if found; otherwise, null.</returns>
        public static Behavior getBehaviorByName(HtmlElement element, string name) { return default(Behavior); }
        ///<summary>
        ///Gets a collection that contains the behaviors associated with the specified <see cref="T:Sys.UI.DomElement" /> object.
        ///</summary>
        ///<param name="element">The DOM element to search.</param>
        ///<returns>An array of <see cref="T:Sys.UI.Behavior" /> objects.</returns>
        public static Behavior[] getBehaviors(HtmlElement element) { return default(Behavior[]); }
        ///<summary>
        ///Gets an array of behaviors that are of the specified <see cref="T:System.Type" /> from the
        ///specified <see cref="T:System.DHTML.HtmlElement" /> instance.
        ///</summary>
        ///<param name="element">The DOM element to search.</param>
        ///<param name="type">The type of the <see cref="T:Sys.UI.Behavior" /> object to look for.</param>
        ///<returns>An array of all Behavior objects of the specified type associated with the specified DOM element instance, if found; otherwise, an empty array.</returns>
        public static Behavior[] getBehaviorsByType(HtmlElement element, Type type) { return default(Behavior[]); }
        ///<summary>
        ///Gets the <see cref="T:System.DHTML.HtmlElement" /> instance that the current <see cref="T:Sys.UI.Behavior" />
        ///object is associated with.
        ///</summary>
        public HtmlElement element
        {
            get { return default(HtmlElement); }
        }
        ///<summary>
        ///Gets or sets the name of the <see cref="T:Sys.UI.Behavior" /> object.
        ///</summary>
        public string name { get; set; }
    }
    #endregion
    #region Bounds
    ///<summary>
    ///Creates an object that contains a set of integer coordinates representing position, width, and height.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public sealed partial class Bounds
    {
        public Bounds(JsNumber x, JsNumber y, JsNumber width, JsNumber height) { }
        ///<summary>
        ///Gets the height of a <see cref="T:Sys.UI.Bounds" /> object in pixels.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsNumber height { get; set; }
        ///<summary>
        ///Gets the width of a <see cref="T:Sys.UI.Bounds" /> object in pixels.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsNumber width { get; set; }
        ///<summary>
        ///Gets the x-coordinate of a <see cref="T:Sys.UI.Bounds" /> object in pixels.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsNumber x { get; set; }
        ///<summary>
        ///Gets the y-coordinate of a <see cref="T:Sys.UI.Bounds" /> object in pixels.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsNumber Y { get; set; }
    }
    #endregion
    #region Control
    ///<summary>
    ///Provides the base class for all Microsoft ASP.NET AJAX controls.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public abstract partial class Control : Component
    {
        protected Control(HtmlElement element) { }
        ///<summary>
        ///Adds a CSS class to a <see cref="T:Sys.UI.Control" /> object.
        ///</summary>
        ///<param name="className">A string that contains the name of the CSS class to add.</param>
        public void addCssClass(string className) { }
        ///<summary>
        ///Handles events raised by the <see cref="M:Sys.UI.Control.RaiseBubbleEvent(System.Object,Sys.EventArgs)" /> method.
        ///</summary>
        ///<param name="sender">The object that triggered the event.</param>
        ///<param name="e">The <see cref="T:Sys.EventArgs" /> object that contains the event data.</param>
        ///<returns>true if the event was handled; false otherwise.</returns>
        protected virtual bool onBubbleEvent(object sender, EventArgs e) { return default(bool); }
        ///<summary>
        ///Bubbles an event to the parent control.
        ///</summary>
        ///<param name="sender">The object that triggered the event.</param>
        ///<param name="e">The <see cref="T:Sys.EventArgs" /> object that contains the event data.</param>
        protected void raiseBubbleEvent(object sender, EventArgs e) { }
        ///<summary>
        ///Removes a CSS class from a <see cref="T:Sys.UI.Control" /> object.
        ///</summary>
        ///<param name="className">A string that contains the name of the CSS class to remove.</param>
        public void removeCssClass(string className) { }
        ///<summary>
        ///Toggles a CSS class of a <see cref="T:Sys.UI.Control" /> object.
        ///</summary>
        ///<param name="className">A string that contains the name of the CSS class to toggle.</param>
        public void toggleCssClass(string className) { }
        ///<summary>
        ///Gets the <see cref="T:System.DHTML.HtmlElement" /> instance that the current <see cref="T:Sys.UI.Control" />
        ///object is associated with.
        ///</summary>
        public HtmlElement element
        {
            get { return default(HtmlElement); }
        }
        ///<summary>
        ///Gets or sets the parent control associated with the current control.
        ///</summary>
        public Control parent { get; set; }
        ///<summary>
        ///Gets or sets the <see cref="T:Sys.UI.VisibilityMode" /> value for the current <see cref="T:Sys.UI.Control" /> object.
        ///</summary>
        public Sys.UI.VisibilityMode visibilityMode { get; set; }
        ///<summary>
        ///Gets or sets the visibility of the current <see cref="T:Sys.UI.Control" /> object.
        ///</summary>
        public bool visible { get; set; }
    }
    #endregion
    #region DomElement
    ///<summary>
    ///Defines static methods and properties that set attributes and provide information about DOM elements.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class DomElement
    {
        ///<summary>
        ///Adds a CSS class to an element if the element does not already have it CSS class.
        ///</summary>
        ///<param name="element">The <see cref="T:Sys.UI.DomElement" /> object to add the CSS class to.</param>
        ///<param name="className">The name of the CSS class to add.</param>
        public static void addCssClass(HtmlElement element, string className) { }
        ///<summary>
        ///Returns a value that indicates whether the element contains the specified CSS class.
        ///</summary>
        ///<param name="element">The <see cref="T:Sys.UI.DomElement" /> object to test for the CSS class.</param>
        ///<param name="className">The name of the CSS class to test for.</param>
        public static bool containsCssClass(HtmlElement element, string className) { return default(bool); }
        ///<summary>
        ///Gets a set of integer coordinates that represent the position, width, and height of an element.
        ///</summary>
        ///<param name="element">The <see cref="T:Sys.UI.DomElement" /> instance to get the coordinates of.</param>
        ///<returns>A JSON-formatted object that contains the x-coordinate and y-coordinate of the upper-left corner, the width, and the height of the element in pixels.</returns>
        public static Bounds getBounds(HtmlElement element) { return default(Bounds); }
        ///<summary>
        ///Gets an element that has the specified id attribute.
        ///</summary>
        ///<param name="id">The ID of the element to find.</param>
        ///<returns>The element with the specified ID.</returns>
        public static HtmlElement getElementById(string id) { return default(HtmlElement); }
        ///<summary>
        ///Gets an element that has the specified id attribute.
        ///</summary>
        ///<param name="id">The ID of the element to find.</param>
        ///<param name="element">The parent element to search in. The default is the document element.</param>
        ///<returns>The element with the specified ID.</returns>
        public static HtmlElement getElementById(string id, HtmlElement element) { return default(HtmlElement); }
        ///<summary>
        ///Gets the absolute position of an element relative to the upper-left corner of the browser window.
        ///</summary>
        ///<param name="element">The target element.</param>
        ///<returns>A JSON-formatted object that contains the x-coordinate and y-coordinate of the element in pixels.</returns>
        public static Point getLocation(HtmlElement element) { return default(Point); }
        ///<summary>
        ///Removes a CSS class from an element.
        ///</summary>
        ///<param name="element">The <see cref="T:Sys.UI.DomElement" /> object to remove the CSS class from.</param>
        ///<param name="className">The name of the CSS class to remove.</param>
        public static void removeCssClass(HtmlElement element, string className) { }
        ///<summary>
        ///Sets the position of an element.
        ///</summary>
        ///<param name="element">The target element.</param>
        ///<param name="x">The x-coordinate in pixels.</param>
        ///<param name="y">The y-coordinate in pixels.</param>
        public static void setLocation(HtmlElement element, JsNumber x, JsNumber y) { }
        ///<summary>
        ///Toggles a CSS class in an element.
        ///</summary>
        ///<param name="element">The element to toggle.</param>
        ///<param name="className">The name of the CSS class to toggle.</param>
        public static void toggleCssClass(HtmlElement element, string className) { }
    }
    #endregion
    #region DomEvent
    ///<summary>
    ///Provides access to client event handlers and event properties.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public sealed partial class DomEvent
    {
        public DomEvent(HtmlElement domElement) { }
        ///<summary>
        ///Adds a DOM event handler to the element that exposes the event.
        ///</summary>
        ///<param name="element">The element that exposes the event.</param>
        ///<param name="eventName">The name of the event. Do not include the "on" prefix. For example, specify "click" instead of "onclick".</param>
        ///<param name="handler">The client function that is called when the event occurs.</param>
        public static void addHandler(HtmlElement element, string eventName, DomEventHandler handler) { }
        ///<summary>
        ///Adds a DOM event handler to a singleton object represented by a type.
        ///(Eg. Window and Document)
        ///</summary>
        ///<param name="type">The singleton object represented by its type.</param>
        ///<param name="eventName">The name of the event. Do not include the "on" prefix. For example, specify "click" instead of "onclick".</param>
        ///<param name="handler">The client function that is called when the event occurs.</param>
        public static void addHandler(System.Type type, string eventName, DomEventHandler handler) { }
        ///<summary>
        ///Adds a list of DOM event handlers to the element that exposes the event.
        ///</summary>
        ///<param name="element">The element that exposes the event.</param>
        ///<param name="events">A dictionary of event handlers.</param>
        public static void addHandlers(HtmlElement element, JsObject events) { }
        ///<summary>
        ///Adds a list of DOM event handler to a singleton object represented by a type.
        ///(Eg. Window and Document)
        ///</summary>
        ///<param name="type">The singleton object represented by its type.</param>
        ///<param name="events">A dictionary of event handlers.</param>
        public static void addHandlers(System.Type type, JsObject events) { }
        ///<summary>
        ///Adds a list of DOM event handlers to the element that exposes the event.
        ///</summary>
        ///<param name="element">The element that exposes the event.</param>
        ///<param name="events">A dictionary of event handlers.</param>
        ///<param name="handleOwner">The object instance that is the context for the delegates that should be created from the handlers.</param>
        public static void addHandlers(HtmlElement element, JsObject events, object handleOwner) { }
        ///<summary>
        ///Adds a list of DOM event handlers to a singleton object represented by a type.
        ///(Eg. Window and Document)
        ///</summary>
        ///<param name="type">The element that exposes the event.</param>
        ///<param name="events">A dictionary of event handlers.</param>
        ///<param name="handleOwner">The object instance that is the context for the delegates that should be created from the handlers.</param>
        public static void addHandlers(System.Type type, JsObject events, object handleOwner) { }
        ///<summary>
        ///Removes all event handlers from the specified element.
        ///</summary>
        ///<param name="element">The element that exposes the events.</param>
        public static void clearHandlers(HtmlElement element) { }
        ///<summary>
        ///Prevents the default event action from happening.
        ///</summary>
        public void preventDefault() { }
        ///<summary>
        ///Removes a DOM event handler from the element that exposes the event.
        ///</summary>
        ///<param name="element">The element that exposes the event.</param>
        ///<param name="eventName">The name of the event. Do not include the "on" prefix. For example, specify "click" instead of "onclick".</param>
        ///<param name="handler">The client function that is called when the event occurs.</param>
        public static void removeHandler(HtmlElement element, string eventName, DomEventHandler handler) { }
        ///<summary>
        ///Removes a DOM event handler from the singleton object represented by a type.
        ///(Eg. Window and Document)
        ///</summary>
        ///<param name="type">The element that exposes the event.</param>
        ///<param name="eventName">The name of the event. Do not include the "on" prefix. For example, specify "click" instead of "onclick".</param>
        ///<param name="handler">The client function that is called when the event occurs.</param>
        public static void removeHandler(System.Type type, string eventName, DomEventHandler handler) { }
        ///<summary>
        ///Prevents an event from being propagated (bubbled) to parent elements.
        ///</summary>
        public void stopPropagation() { }
        ///<summary>
        ///Gets a Boolean value that indicates the state of the ALT key when the associated event occurred.
        ///</summary>
        [JsProperty(NativeField = true)]
        public bool altKey
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Gets a <see cref="T:Sys.UI.MouseButton" /> enumeration value that indicates the button
        ///state of the mouse when the related event occurred.
        ///</summary>
        [JsProperty(NativeField = true)]
        public MouseButton button
        {
            get { return default(MouseButton); }
        }
        ///<summary>
        ///Gets the character code of the key that raised the associated event.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsNumber charCode
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets the x-coordinate of the mouse pointer's position relative to the client area of
        ///the browser window, excluding window scroll bars.
        ///</summary>
        ///<value>An integer that represents the x-coordinate in pixels.</value>
        [JsProperty(NativeField = true)]
        public JsNumber clientX
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets the y-coordinate of the mouse pointer's position relative to the client area of
        ///the browser window, excluding window scroll bars.
        ///</summary>
        ///<value>An integer that represents the y-coordinate in pixels.</value>
        [JsProperty(NativeField = true)]
        public JsNumber clientY
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets a Boolean value that indicates the state of the CTRL key when the associated event occurred.
        ///</summary>
        [JsProperty(NativeField = true)]
        public bool ctrlKey
        {
            get { return default(bool); }
        }
        [JsProperty(NativeField = true)]
        public JsNumber keyCode
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets the x-coordinate of the mouse pointer's position relative to the object that raised the event.
        ///</summary>
        ///<value>An integer that represents the x-coordinate in pixels.</value>
        [JsProperty(NativeField = true)]
        public JsNumber offsetX
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets the y-coordinate of the mouse pointer's position relative to the object that raised the event.
        ///</summary>
        ///<value>An integer that represents the y-coordinate in pixels.</value>
        [JsProperty(NativeField = true)]
        public JsNumber offsetY
        {
            get { return default(JsNumber); }
        }
        [JsProperty(NativeField = true)]
        public HtmlDomEventArgs rawEvent
        {
            get { return default(HtmlDomEventArgs); }
        }
        ///<summary>
        ///Gets the x-coordinate of the mouse pointer's position relative to the screen top left.
        ///</summary>
        ///<value>An integer that represents the x-coordinate in pixels.</value>
        [JsProperty(NativeField = true)]
        public JsNumber screenX
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets the y-coordinate of the mouse pointer's position relative to the screen top left.
        ///</summary>
        ///<value>An integer that represents the y-coordinate in pixels.</value>
        [JsProperty(NativeField = true)]
        public JsNumber screenY
        {
            get { return default(JsNumber); }
        }
        ///<summary>
        ///Gets a value that indicates the state of the SHIFT key when the associated event occurred.
        ///</summary>
        [JsProperty(NativeField = true)]
        public bool shiftKey
        {
            get { return default(bool); }
        }
        ///<summary>
        ///Gets the object that the event acted upon.
        ///</summary>
        [JsProperty(NativeField = true)]
        public HtmlElement target
        {
            get { return default(HtmlElement); }
        }
        ///<summary>
        ///Gets the name of the event that was raised.
        ///</summary>
        [JsProperty(NativeField = true)]
        public string type
        {
            get { return default(string); }
        }
    }
    #endregion
    ///<summary>
    ///Event handler for DOM events.
    ///</summary>
    ///<param name="e">The <see cref="T:Sys.UI.DomEvent" /> object that contains the event data.</param>
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void DomEventHandler(DomEvent e);
    ///<summary>
    ///Describes common key codes.
    ///</summary>
    public enum Key { backspace = 8, del = 0x7f, down = 40, end = 0x23, enter = 13, esc = 0x1b, home = 0x24, left = 0x25, pageDown = 0x22, pageUp = 0x21, right = 0x27, space = 0x20, tab = 9, up = 0x26 }
    ///<summary>
    ///Describes mouse buttons.
    ///</summary>
    public enum MouseButton { leftButton, middleButton, rightButton }
    #region Point
    ///<summary>
    ///Creates an object that contains a set of integer coordinates representing a position.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false)]
    public sealed partial class Point
    {
        public Point(JsNumber x, JsNumber y) { }
        ///<summary>
        ///Gets the x-coordinate of a <see cref="T:Sys.UI.Point" /> object in pixels.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsNumber x { get; set; }
        ///<summary>
        ///Gets the y-coordinate of a <see cref="T:Sys.UI.Point" /> object in pixels.
        ///</summary>
        [JsProperty(NativeField = true)]
        public JsNumber y { get; set; }
    }
    #endregion
    ///<summary>
    ///Describes the layout of a DOM element in the page when the element's
    ///<see cref="P:Sys.UI.Control.Visible">Visible</see> property is set to false.
    ///</summary>
    public enum VisibilityMode { hide, collapse }
}
namespace Sys.WebForms
{
    #region BeginRequestEventArgs
    public sealed partial class BeginRequestEventArgs : Sys.EventArgs
    {
        internal BeginRequestEventArgs() { }
        public HtmlElement postBackElement
        {
            get { return default(HtmlElement); }
        }
        public object request
        {
            get { return default(object); }
        }
    }
    #endregion
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void BeginRequestEventHandler(object sender, BeginRequestEventArgs e);
    #region EndRequestEventArgs
    public sealed partial class EndRequestEventArgs : Sys.EventArgs
    {
        internal EndRequestEventArgs() { }
        public JsObject dataItems
        {
            get { return default(JsObject); }
        }
        public JsError error
        {
            get { return default(JsError); }
        }
        public bool errorHandled { get; set; }
        public WebRequestExecutor response
        {
            get { return default(WebRequestExecutor); }
        }
    }
    #endregion
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void EndRequestEventHandler(object sender, EndRequestEventArgs e);
    #region InitializeRequestEventArgs
    public sealed partial class InitializeRequestEventArgs : CancelEventArgs
    {
        internal InitializeRequestEventArgs() { }
        public HtmlElement postBackElement
        {
            get { return default(HtmlElement); }
        }
        public object request
        {
            get { return default(object); }
        }
    }
    #endregion
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void InitializeRequestEventHandler(object sender, InitializeRequestEventArgs e);
    #region PageLoadedEventArgs
    public sealed partial class PageLoadedEventArgs : Sys.EventArgs
    {
        internal PageLoadedEventArgs() { }
        public JsObject dataItems
        {
            get { return default(JsObject); }
        }
        public HtmlElement[] panelsCreated
        {
            get { return default(HtmlElement[]); }
        }
        public HtmlElement[] panelsUpdated
        {
            get { return default(HtmlElement[]); }
        }
    }
    #endregion
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void PageLoadedEventHandler(object sender, PageLoadedEventArgs e);
    #region PageLoadingEventArgs
    public sealed partial class PageLoadingEventArgs : Sys.EventArgs
    {
        internal PageLoadingEventArgs() { }
        public JsObject dataItems
        {
            get { return default(JsObject); }
        }
        public HtmlElement[] panelsDeleting
        {
            get { return default(HtmlElement[]); }
        }
        public HtmlElement[] panelsUpdating
        {
            get { return default(HtmlElement[]); }
        }
    }
    #endregion
    [JsDelegate(NativeDelegates = true, NativeFunction=true)]
    [JsType(Export = false, Name = "System.MulticastDelegate")]
    public delegate void PageLoadingEventHandler(object sender, PageLoadingEventArgs e);
    #region PageRequestManager
    public sealed partial class PageRequestManager
    {
        public event BeginRequestEventHandler beginRequest
        {
            add { }
            remove { }
        }
        public event EndRequestEventHandler endRequest
        {
            add { }
            remove { }
        }
        public event InitializeRequestEventHandler initializeRequest
        {
            add { }
            remove { }
        }
        public event PageLoadedEventHandler pageLoaded
        {
            add { }
            remove { }
        }
        public event PageLoadingEventHandler pageLoading
        {
            add { }
            remove { }
        }
        private PageRequestManager() { }
        public void abortPostBack() { }
        public static PageRequestManager getInstance() { return default(PageRequestManager); }
        public bool isInAsyncPostBack
        {
            get { return default(bool); }
        }
    }
    #endregion
}
