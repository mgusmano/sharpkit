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
    /// Allows for the insertion of methods that are executed before or after
    /// a specified method
    /// </summary>
    public partial class Do
    {
        /// <summary>
        /// <p>Execute the supplied method after the specified function.  Wrapping
        /// function may optionally return an instance of the following classes to
        /// further alter runtime behavior:</p>
        /// <dl>
        /// <dt></code>Y.Do.Halt(message, returnValue)</code></dt>
        /// <dd>Immediatly stop execution and return
        /// <code>returnValue</code>.  No other wrapping functions will be
        /// executed.</dd>
        /// <dt></code>Y.Do.AlterReturn(message, returnValue)</code></dt>
        /// <dd>Return <code>returnValue</code> instead of the wrapped
        /// method's original return value.  This can be further altered by
        /// other after phase wrappers.</dd>
        /// </dl>
        /// <p>The static properties <code>Y.Do.originalRetVal</code> and
        /// <code>Y.Do.currentRetVal</code> will be populated for reference.</p>
        /// </summary>
        public object after(JsAction fn, object obj, object sFn, object c, object arg){return null;}
        /// <summary>
        /// <p>Execute the supplied method before the specified function.  Wrapping
        /// function may optionally return an instance of the following classes to
        /// further alter runtime behavior:</p>
        /// <dl>
        /// <dt></code>Y.Do.Halt(message, returnValue)</code></dt>
        /// <dd>Immediatly stop execution and return
        /// <code>returnValue</code>.  No other wrapping functions will be
        /// executed.</dd>
        /// <dt></code>Y.Do.AlterArgs(message, newArgArray)</code></dt>
        /// <dd>Replace the arguments that the original function will be
        /// called with.</dd>
        /// <dt></code>Y.Do.Prevent(message)</code></dt>
        /// <dd>Don't execute the wrapped function.  Other before phase
        /// wrappers will be executed.</dd>
        /// </dl>
        /// </summary>
        public object before(JsAction fn, object obj, object sFn, object c, object arg){return null;}
        /// <summary>
        /// Detach a before or after subscription.
        /// </summary>
        public void detach(object handle){}
    }
}