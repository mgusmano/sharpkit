//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Function
    /// <summary>
    /// <p>A collection of useful static methods to deal with function callbacks</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Function
    {
        /// <summary>
        /// Create an alias to the provided method property with name methodName of object.
        /// Note that the execution scope will still be bound to the provided object itself.
        /// </summary>
        /// <param name="object">
        /// </param>
        /// <param name="methodName">
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>aliasFn</p>
        /// </div>
        /// </returns>
        public static System.Delegate alias(object @object, JsString methodName){return null;}
        /// <summary>
        /// Create a new function from the provided fn, change this to the provided scope, optionally
        /// overrides arguments for the call. (Defaults to the arguments passed by the caller)
        /// <see cref="Ext.ExtContext.bind">Ext.bind</see> is alias for <see cref="Ext.Function.bind">Ext.Function.bind</see>
        /// </summary>
        /// <param name="fn"><p>The function to delegate.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the function is executed.
        /// <strong>If omitted, defaults to the default global environment object (usually the browser window).</strong></p>
        /// </param>
        /// <param name="args"><p>Overrides arguments for the call. (Defaults to the arguments passed by the caller)</p>
        /// </param>
        /// <param name="appendArgs"><p>if True args are appended to call args instead of overriding,
        /// if a number the args are inserted at the specified position</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>The new function</p>
        /// </div>
        /// </returns>
        public static System.Delegate bind(System.Delegate fn, object scope=null, object args=null, object appendArgs=null){return null;}
        /// <summary>
        /// Create a "clone" of the provided method. The returned method will call the given
        /// method passing along all arguments and the "this" pointer and return its result.
        /// </summary>
        /// <param name="method">
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>cloneFn</p>
        /// </div>
        /// </returns>
        public static System.Delegate clone(System.Delegate method){return null;}
        /// <summary>
        /// Creates a delegate function, optionally with a bound scope which, when called, buffers
        /// the execution of the passed function for the configured number of milliseconds.
        /// If called again within that period, the impending invocation will be canceled, and the
        /// timeout period will begin again.
        /// </summary>
        /// <param name="fn"><p>The function to invoke on a buffered timer.</p>
        /// </param>
        /// <param name="buffer"><p>The number of milliseconds by which to buffer the invocation of the
        /// function.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which
        /// the passed function is executed. If omitted, defaults to the scope specified by the caller.</p>
        /// </param>
        /// <param name="args"><p>Override arguments for the call. Defaults to the arguments
        /// passed by the caller.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>A function which invokes the passed function after buffering for the specified time.</p>
        /// </div>
        /// </returns>
        public static System.Delegate createBuffered(System.Delegate fn, JsNumber buffer, object scope=null, object args=null){return null;}
        /// <summary>
        /// Creates a delegate (callback) which, when called, executes after a specific delay.
        /// </summary>
        /// <param name="fn"><p>The function which will be called on a delay when the returned function is called.
        /// Optionally, a replacement (or additional) argument list may be specified.</p>
        /// </param>
        /// <param name="delay"><p>The number of milliseconds to defer execution by whenever called.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) used by the function at execution time.</p>
        /// </param>
        /// <param name="args"><p>Override arguments for the call. (Defaults to the arguments passed by the caller)</p>
        /// </param>
        /// <param name="appendArgs"><p>if True args are appended to call args instead of overriding,
        /// if a number the args are inserted at the specified position.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>A function which, when called, executes the original function after the specified delay.</p>
        /// </div>
        /// </returns>
        public static System.Delegate createDelayed(System.Delegate fn=null, object delay=null, object scope=null, object args=null, object appendArgs=null){return null;}
        /// <summary>
        /// Creates an interceptor function. The passed function is called before the original one. If it returns false,
        /// the original one is not called. The resulting function returns the results of the original function.
        /// The passed function is called with the parameters of the original function. Example usage:
        /// <code>var sayHi = function(name){
        /// alert('Hi, ' + name);
        /// }
        /// sayHi('Fred'); // alerts "Hi, Fred"
        /// // create a new function that validates input without
        /// // directly modifying the original function:
        /// var sayHiToFriend = <see cref="Ext.Function.createInterceptor">Ext.Function.createInterceptor</see>(sayHi, function(name){
        /// return name == 'Brian';
        /// });
        /// sayHiToFriend('Fred');  // no alert
        /// sayHiToFriend('Brian'); // alerts "Hi, Brian"
        /// </code>
        /// </summary>
        /// <param name="origFn"><p>The original function.</p>
        /// </param>
        /// <param name="newFn"><p>The function to call before the original</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the passed function is executed.
        /// <strong>If omitted, defaults to the scope in which the original function is called or the browser window.</strong></p>
        /// </param>
        /// <param name="returnValue"><p>The value to return if the passed function return false (defaults to null).</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>The new function</p>
        /// </div>
        /// </returns>
        public static System.Delegate createInterceptor(System.Delegate origFn, System.Delegate newFn, object scope=null, object returnValue=null){return null;}
        /// <summary>
        /// Create a combined function call sequence of the original function + the passed function.
        /// The resulting function returns the results of the original function.
        /// The passed function is called with the parameters of the original function. Example usage:
        /// <code>var sayHi = function(name){
        /// alert('Hi, ' + name);
        /// }
        /// sayHi('Fred'); // alerts "Hi, Fred"
        /// var sayGoodbye = <see cref="Ext.Function.createSequence">Ext.Function.createSequence</see>(sayHi, function(name){
        /// alert('Bye, ' + name);
        /// });
        /// sayGoodbye('Fred'); // both alerts show
        /// </code>
        /// </summary>
        /// <param name="originalFn"><p>The original function.</p>
        /// </param>
        /// <param name="newFn"><p>The function to sequence</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the passed function is executed.
        /// If omitted, defaults to the scope in which the original function is called or the default global environment object (usually the browser window).</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>The new function</p>
        /// </div>
        /// </returns>
        public static System.Delegate createSequence(System.Delegate originalFn, System.Delegate newFn, object scope=null){return null;}
        /// <summary>
        /// Creates a throttled version of the passed function which, when called repeatedly and
        /// rapidly, invokes the passed function only after a certain interval has elapsed since the
        /// previous invocation.
        /// This is useful for wrapping functions which may be called repeatedly, such as
        /// a handler of a mouse move event when the processing is expensive.
        /// </summary>
        /// <param name="fn"><p>The function to execute at a regular time interval.</p>
        /// </param>
        /// <param name="interval"><p>The interval <strong>in milliseconds</strong> on which the passed function is executed.</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which
        /// the passed function is executed. If omitted, defaults to the scope specified by the caller.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>A function which invokes the passed function at the specified interval.</p>
        /// </div>
        /// </returns>
        public static System.Delegate createThrottled(System.Delegate fn, JsNumber interval, object scope=null){return null;}
        /// <summary>
        /// Calls this function after the number of millseconds specified, optionally in a specific scope. Example usage:
        /// <code>var sayHi = function(name){
        /// alert('Hi, ' + name);
        /// }
        /// // executes immediately:
        /// sayHi('Fred');
        /// // executes after 2 seconds:
        /// <see cref="Ext.Function.defer">Ext.Function.defer</see>(sayHi, 2000, this, ['Fred']);
        /// // this syntax is sometimes useful for deferring
        /// // execution of an anonymous function:
        /// <see cref="Ext.Function.defer">Ext.Function.defer</see>(function(){
        /// alert('Anonymous');
        /// }, 100);
        /// </code>
        /// <see cref="Ext.ExtContext.defer">Ext.defer</see> is alias for <see cref="Ext.Function.defer">Ext.Function.defer</see>
        /// </summary>
        /// <param name="fn"><p>The function to defer.</p>
        /// </param>
        /// <param name="millis"><p>The number of milliseconds for the setTimeout call
        /// (if less than or equal to 0 the function is executed immediately)</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the function is executed.
        /// <strong>If omitted, defaults to the browser window.</strong></p>
        /// </param>
        /// <param name="args"><p>Overrides arguments for the call. (Defaults to the arguments passed by the caller)</p>
        /// </param>
        /// <param name="appendArgs"><p>if True args are appended to call args instead of overriding,
        /// if a number the args are inserted at the specified position</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The timeout id that can be used with clearTimeout</p>
        /// </div>
        /// </returns>
        public static JsNumber defer(System.Delegate fn, JsNumber millis, object scope=null, object args=null, object appendArgs=null){return null;}
        /// <summary>
        /// A very commonly used method throughout the framework. It acts as a wrapper around another method
        /// which originally accepts 2 arguments for name and value.
        /// The wrapped function then allows "flexible" value setting of either:
        /// <li><c>name</c> and <c>value</c> as 2 arguments</li>
        /// <li>one single object argument with multiple key - value pairs</li>
        /// For example:
        /// <code>var setValue = <see cref="Ext.Function.flexSetter">Ext.Function.flexSetter</see>(function(name, value) {
        /// this[name] = value;
        /// });
        /// // Afterwards
        /// // Setting a single name - value
        /// setValue('name1', 'value1');
        /// // Settings multiple name - value pairs
        /// setValue({
        /// name1: 'value1',
        /// name2: 'value2',
        /// name3: 'value3'
        /// });
        /// </code>
        /// </summary>
        /// <param name="setter">
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>flexSetter</p>
        /// </div>
        /// </returns>
        public static System.Delegate flexSetter(System.Delegate setter){return null;}
        /// <summary>
        /// Adds behavior to an existing method that is executed after the
        /// original behavior of the function.  For example:
        /// <code>var soup = {
        /// contents: [],
        /// add: function(ingredient) {
        /// this.contents.push(ingredient);
        /// }
        /// };
        /// <see cref="Ext.Function.interceptAfter">Ext.Function.interceptAfter</see>(soup, "add", function(ingredient){
        /// // Always add a bit of extra salt
        /// this.contents.push("salt");
        /// });
        /// soup.add("water");
        /// soup.add("onions");
        /// soup.contents; // will contain: water, salt, onions, salt
        /// </code>
        /// </summary>
        /// <param name="object"><p>The target object</p>
        /// </param>
        /// <param name="methodName"><p>Name of the method to override</p>
        /// </param>
        /// <param name="fn"><p>Function with the new behavior.  It will
        /// be called with the same arguments as the original method.  The
        /// return value of this function will be the return value of the
        /// new method.</p>
        /// </param>
        /// <param name="scope"><p>The scope to execute the interceptor function. Defaults to the object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>The new function just created.</p>
        /// </div>
        /// </returns>
        public static System.Delegate interceptAfter(object @object, JsString methodName, System.Delegate fn, object scope=null){return null;}
        /// <summary>
        /// Adds behavior to an existing method that is executed before the
        /// original behavior of the function.  For example:
        /// <code>var soup = {
        /// contents: [],
        /// add: function(ingredient) {
        /// this.contents.push(ingredient);
        /// }
        /// };
        /// <see cref="Ext.Function.interceptBefore">Ext.Function.interceptBefore</see>(soup, "add", function(ingredient){
        /// if (!this.contents.length &amp;&amp; ingredient !== "water") {
        /// // Always add water to start with
        /// this.contents.push("water");
        /// }
        /// });
        /// soup.add("onions");
        /// soup.add("salt");
        /// soup.contents; // will contain: water, onions, salt
        /// </code>
        /// </summary>
        /// <param name="object"><p>The target object</p>
        /// </param>
        /// <param name="methodName"><p>Name of the method to override</p>
        /// </param>
        /// <param name="fn"><p>Function with the new behavior.  It will
        /// be called with the same arguments as the original method.  The
        /// return value of this function will be the return value of the
        /// new method.</p>
        /// </param>
        /// <param name="scope"><p>The scope to execute the interceptor function. Defaults to the object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>The new function just created.</p>
        /// </div>
        /// </returns>
        public static System.Delegate interceptBefore(object @object, JsString methodName, System.Delegate fn, object scope=null){return null;}
        /// <summary>
        /// Create a new function from the provided fn, the arguments of which are pre-set to args.
        /// New arguments passed to the newly created callback when it's invoked are appended after the pre-set ones.
        /// This is especially useful when creating callbacks.
        /// For example:
        /// <code>var originalFunction = function(){
        /// alert(<see cref="Ext.Array.from">Ext.Array.from</see>(arguments).join(' '));
        /// };
        /// var callback = <see cref="Ext.Function.pass">Ext.Function.pass</see>(originalFunction, ['Hello', 'World']);
        /// callback(); // alerts 'Hello World'
        /// callback('by Me'); // alerts 'Hello World by Me'
        /// </code>
        /// <see cref="Ext.ExtContext.pass">Ext.pass</see> is alias for <see cref="Ext.Function.pass">Ext.Function.pass</see>
        /// </summary>
        /// <param name="fn"><p>The original function</p>
        /// </param>
        /// <param name="args"><p>The arguments to pass to new callback</p>
        /// </param>
        /// <param name="scope"><p>The scope (<c>this</c> reference) in which the function is executed.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>The new callback function</p>
        /// </div>
        /// </returns>
        public static System.Delegate pass(System.Delegate fn, object args=null, object scope=null){return null;}
        public Function(FunctionConfig config){}
        public Function(){}
        public Function(params object[] args){}
    }
    #endregion
    #region FunctionConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FunctionConfig
    {
        public FunctionConfig(params object[] args){}
    }
    #endregion
    #region FunctionEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FunctionEvents
    {
        public FunctionEvents(params object[] args){}
    }
    #endregion
}
#endregion
