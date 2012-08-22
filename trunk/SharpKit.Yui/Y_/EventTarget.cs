//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// EventTarget provides the implementation for any object to
    /// publish, subscribe and fire to custom events, and also
    /// alows other EventTargets to target the object with events
    /// sourced from the other object.
    /// EventTarget is designed to be used with Y.augment to wrap
    /// EventCustom in an interface that allows events to be listened to
    /// and fired by name.  This makes it possible for implementing code to
    /// subscribe to an event that either has not been created yet, or will
    /// not be created at all.
    /// </summary>
    public partial class EventTarget
    {
        /// <summary>
        /// Registers another EventTarget as a bubble target.  Bubble order
        /// is determined by the order registered.  Multiple targets can
        /// be specified.
        /// Events can only bubble if emitFacade is true.
        /// Included in the event-custom-complex submodule.
        /// </summary>
        public void addTarget(Y_.EventTarget o){}
        /// <summary>
        /// Subscribe to a custom event hosted by this object.  The
        /// supplied callback will execute after any listeners add
        /// via the subscribe method, and after the default function,
        /// if configured for the event, has executed.
        /// </summary>
        public EventHandle after(object type, JsAction fn){return null;}
        /// <summary>
        /// Subscribe to a custom event hosted by this object.  The
        /// supplied callback will execute after any listeners add
        /// via the subscribe method, and after the default function,
        /// if configured for the event, has executed.
        /// </summary>
        public EventHandle after(object type, JsAction fn, object arg_){return null;}
        /// <summary>
        /// Subscribe to a custom event hosted by this object.  The
        /// supplied callback will execute after any listeners add
        /// via the subscribe method, and after the default function,
        /// if configured for the event, has executed.
        /// </summary>
        public EventHandle after(object type, JsAction fn, object context, object arg_){return null;}
        /// <summary>
        /// Executes the callback before a DOM event, custom event
        /// or method.  If the first argument is a function, it
        /// is assumed the target is a method.  For DOM and custom
        /// events, this is an alias for Y.on.
        /// For DOM and custom events:
        /// type, callback, context, 0-n arguments
        /// For methods:
        /// callback, object (method host), methodName, context, 0-n arguments
        /// </summary>
        public object before(){return null;}
        /// <summary>
        /// Propagate an event.  Requires the event-custom-complex module.
        /// </summary>
        public object bubble(CustomEvent evt){return null;}
        /// <summary>
        /// Detach one or more listeners the from the specified event
        /// </summary>
        public Y_.EventTarget detach(object type, JsAction fn, object context){return null;}
        /// <summary>
        /// Removes all listeners from the specified event.  If the event type
        /// is not specified, all listeners from all hosted custom events will
        /// be removed.
        /// </summary>
        public void detachAll(object type){}
        /// <summary>
        /// Fire a custom event by name.  The callback functions will be executed
        /// from the context specified when the event was created, and with the
        /// following parameters.
        /// If the custom event object hasn't been created, then the event hasn't
        /// been published and it has no subscribers.  For performance sake, we
        /// immediate exit in this case.  This means the event won't bubble, so
        /// if the intention is that a bubble target be notified, the event must
        /// be published on this object first.
        /// The first argument is the event type, and any additional arguments are
        /// passed to the listeners as parameters.  If the first of these is an
        /// object literal, and the event is configured to emit an event facade,
        /// that object is mixed into the event facade and the facade is provided
        /// in place of the original object.
        /// </summary>
        public Y_.EventTarget fire(object type, object arguments){return null;}
        /// <summary>
        /// Returns the custom event of the provided type has been created, a
        /// falsy value otherwise
        /// </summary>
        public CustomEvent getEvent(object type, object prefixed){return null;}
        /// <summary>
        /// Returns an array of bubble targets for this object.
        /// </summary>
        public object getTargets(){return null;}
        /// <summary>
        /// Subscribe a callback function to a custom event fired by this object or
        /// from an object that bubbles its events to this object.
        /// Callback functions for events published with `emitFacade = true` will
        /// receive an `EventFacade` as the first argument (typically named "e").
        /// These callbacks can then call `e.preventDefault()` to disable the
        /// behavior published to that event's `defaultFn`.  See the `EventFacade`
        /// API for all available properties and methods. Subscribers to
        /// non-`emitFacade` events will receive the arguments passed to `fire()`
        /// after the event name.
        /// To subscribe to multiple events at once, pass an object as the first
        /// argument, where the key:value pairs correspond to the eventName:callback,
        /// or pass an array of event names as the first argument to subscribe to
        /// all listed events with the same callback.
        /// Returning `false` from a callback is supported as an alternative to
        /// calling `e.preventDefault(); e.stopPropagation();`.  However, it is
        /// recommended to use the event methods whenever possible.
        /// </summary>
        public EventHandle on(object type, JsAction fn){return null;}
        /// <summary>
        /// Subscribe a callback function to a custom event fired by this object or
        /// from an object that bubbles its events to this object.
        /// Callback functions for events published with `emitFacade = true` will
        /// receive an `EventFacade` as the first argument (typically named "e").
        /// These callbacks can then call `e.preventDefault()` to disable the
        /// behavior published to that event's `defaultFn`.  See the `EventFacade`
        /// API for all available properties and methods. Subscribers to
        /// non-`emitFacade` events will receive the arguments passed to `fire()`
        /// after the event name.
        /// To subscribe to multiple events at once, pass an object as the first
        /// argument, where the key:value pairs correspond to the eventName:callback,
        /// or pass an array of event names as the first argument to subscribe to
        /// all listed events with the same callback.
        /// Returning `false` from a callback is supported as an alternative to
        /// calling `e.preventDefault(); e.stopPropagation();`.  However, it is
        /// recommended to use the event methods whenever possible.
        /// </summary>
        public EventHandle on(object type, JsAction fn, object arg_){return null;}
        /// <summary>
        /// Subscribe a callback function to a custom event fired by this object or
        /// from an object that bubbles its events to this object.
        /// Callback functions for events published with `emitFacade = true` will
        /// receive an `EventFacade` as the first argument (typically named "e").
        /// These callbacks can then call `e.preventDefault()` to disable the
        /// behavior published to that event's `defaultFn`.  See the `EventFacade`
        /// API for all available properties and methods. Subscribers to
        /// non-`emitFacade` events will receive the arguments passed to `fire()`
        /// after the event name.
        /// To subscribe to multiple events at once, pass an object as the first
        /// argument, where the key:value pairs correspond to the eventName:callback,
        /// or pass an array of event names as the first argument to subscribe to
        /// all listed events with the same callback.
        /// Returning `false` from a callback is supported as an alternative to
        /// calling `e.preventDefault(); e.stopPropagation();`.  However, it is
        /// recommended to use the event methods whenever possible.
        /// </summary>
        public EventHandle on(object type, JsAction fn, object context, object arg_){return null;}
        /// <summary>
        /// Listen to a custom event hosted by this object one time.
        /// This is the equivalent to <code>on</code> except the
        /// listener is immediatelly detached when it is executed.
        /// </summary>
        public EventHandle once(object type, JsAction fn){return null;}
        /// <summary>
        /// Listen to a custom event hosted by this object one time.
        /// This is the equivalent to <code>on</code> except the
        /// listener is immediatelly detached when it is executed.
        /// </summary>
        public EventHandle once(object type, JsAction fn, object arg_){return null;}
        /// <summary>
        /// Listen to a custom event hosted by this object one time.
        /// This is the equivalent to <code>on</code> except the
        /// listener is immediatelly detached when it is executed.
        /// </summary>
        public EventHandle once(object type, JsAction fn, object context, object arg_){return null;}
        /// <summary>
        /// Listen to a custom event hosted by this object one time.
        /// This is the equivalent to <code>after</code> except the
        /// listener is immediatelly detached when it is executed.
        /// </summary>
        public EventHandle onceAfter(object type, JsAction fn){return null;}
        /// <summary>
        /// Listen to a custom event hosted by this object one time.
        /// This is the equivalent to <code>after</code> except the
        /// listener is immediatelly detached when it is executed.
        /// </summary>
        public EventHandle onceAfter(object type, JsAction fn, object arg_){return null;}
        /// <summary>
        /// Listen to a custom event hosted by this object one time.
        /// This is the equivalent to <code>after</code> except the
        /// listener is immediatelly detached when it is executed.
        /// </summary>
        public EventHandle onceAfter(object type, JsAction fn, object context, object arg_){return null;}
        /// <summary>
        /// Takes the type parameter passed to 'on' and parses out the
        /// various pieces that could be included in the type.  If the
        /// event type is passed without a prefix, it will be expanded
        /// to include the prefix one is supplied or the event target
        /// is configured with a default prefix.
        /// </summary>
        public Y_.Array parseType(object type){return null;}
        /// <summary>
        /// Takes the type parameter passed to 'on' and parses out the
        /// various pieces that could be included in the type.  If the
        /// event type is passed without a prefix, it will be expanded
        /// to include the prefix one is supplied or the event target
        /// is configured with a default prefix.
        /// </summary>
        public Y_.Array parseType(object type, object pre){return null;}
        /// <summary>
        /// Creates a new custom event of the specified type.  If a custom event
        /// by that name already exists, it will not be re-created.  In either
        /// case the custom event is returned.
        /// </summary>
        public CustomEvent publish(object type, object opts){return null;}
        /// <summary>
        /// Removes a bubble target
        /// </summary>
        public void removeTarget(Y_.EventTarget o){}
        /// <summary>
        /// subscribe to an event
        /// </summary>
        public void subscribe(){}
        /// <summary>
        /// detach a listener
        /// </summary>
        public void unsubscribe(){}
        /// <summary>
        /// Removes all listeners from the specified event.  If the event type
        /// is not specified, all listeners from all hosted custom events will
        /// be removed.
        /// </summary>
        public void unsubscribeAll(object type){}
    }
}