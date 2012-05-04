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
    /// Attribute-based data model with APIs for getting, setting, validating, and
    /// syncing attribute values, as well as events for being notified of model changes.
    /// In most cases, you'll want to create your own subclass of `Y.Model` and
    /// customize it to meet your needs. In particular, the `sync()` and `validate()`
    /// methods are meant to be overridden by custom implementations. You may also want
    /// to override the `parse()` method to parse non-generic server responses.
    /// </summary>
    public partial class Model : YUI_.Base
    {
        /// <summary>
        /// Duckpunches the `_defAttrChangeFn()` provided by `Y.Attribute` so we can
        /// have a single global notification when a change event occurs.
        /// </summary>
        protected void _defAttrChangeFn(EventFacade e){}
        /// <summary>
        /// Calls the public, overridable `validate()` method and fires an `error` event
        /// if validation fails.
        /// </summary>
        protected void _validate(object attributes, JsAction callback){}
        /// <summary>
        /// Duckpunches the `addAttr` method provided by `Y.Attribute` to keep the
        /// `id` attribute’s value and a custom id attribute’s (if provided) value
        /// in sync when adding the attributes to the model instance object.
        /// Marked as protected to hide it from Model's public API docs, even though
        /// this is a public method in Attribute.
        /// </summary>
        protected object addAttr(object name, object config, object lazy){return null;}
        /// <summary>
        /// Destroys this model instance and removes it from its containing lists, if
        /// any.
        /// The _callback_, if one is provided, will be called after the model is
        /// destroyed.
        /// If `options.remove` is `true`, then this method delegates to the `sync()`
        /// method to delete the model from the persistence layer, which is an
        /// asynchronous action. In this case, the _callback_ (if provided) will be
        /// called after the sync layer indicates success or failure of the delete
        /// operation.
        /// </summary>
        public void destroy(){}
        /// <summary>
        /// Destroys this model instance and removes it from its containing lists, if
        /// any.
        /// The _callback_, if one is provided, will be called after the model is
        /// destroyed.
        /// If `options.remove` is `true`, then this method delegates to the `sync()`
        /// method to delete the model from the persistence layer, which is an
        /// asynchronous action. In this case, the _callback_ (if provided) will be
        /// called after the sync layer indicates success or failure of the delete
        /// operation.
        /// </summary>
        public void destroy(object callback){}
        /// <summary>
        /// Destroys this model instance and removes it from its containing lists, if
        /// any.
        /// The _callback_, if one is provided, will be called after the model is
        /// destroyed.
        /// If `options.remove` is `true`, then this method delegates to the `sync()`
        /// method to delete the model from the persistence layer, which is an
        /// asynchronous action. In this case, the _callback_ (if provided) will be
        /// called after the sync layer indicates success or failure of the delete
        /// operation.
        /// </summary>
        public void destroy(object options, object callback){}
        /// <summary>
        /// Returns a clientId string that's unique among all models on the current page
        /// (even models in other YUI instances). Uniqueness across pageviews is
        /// unlikely.
        /// </summary>
        public object generateClientId(){return null;}
        /// <summary>
        /// Returns the value of the specified attribute.
        /// If the attribute's value is an object, _name_ may use dot notation to
        /// specify the path to a specific property within the object, and the value of
        /// that property will be returned.
        /// </summary>
        public object get(object name){return null;}
        /// <summary>
        /// Returns an HTML-escaped version of the value of the specified string
        /// attribute. The value is escaped using `Y.Escape.html()`.
        /// </summary>
        public object getAsHTML(object name){return null;}
        /// <summary>
        /// Returns a URL-encoded version of the value of the specified string
        /// attribute. The value is encoded using the native `encodeURIComponent()`
        /// function.
        /// </summary>
        public object getAsURL(object name){return null;}
        /// <summary>
        /// Returns `true` if any attribute of this model has been changed since the
        /// model was last saved.
        /// New models (models for which `isNew()` returns `true`) are implicitly
        /// considered to be "modified" until the first time they're saved.
        /// </summary>
        public object isModified(){return null;}
        /// <summary>
        /// Returns `true` if this model is "new", meaning it hasn't been saved since it
        /// was created.
        /// Newness is determined by checking whether the model's `id` attribute has
        /// been set. An empty id is assumed to indicate a new model, whereas a
        /// non-empty id indicates a model that was either loaded or has been saved
        /// since it was created.
        /// </summary>
        public object isNew(){return null;}
        /// <summary>
        /// Loads this model from the server.
        /// This method delegates to the `sync()` method to perform the actual load
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// A successful load operation will fire a `load` event, while an unsuccessful
        /// load operation will fire an `error` event with the `src` value "load".
        /// If the load operation succeeds and one or more of the loaded attributes
        /// differ from this model's current attributes, a `change` event will be fired.
        /// </summary>
        public void load(){}
        /// <summary>
        /// Loads this model from the server.
        /// This method delegates to the `sync()` method to perform the actual load
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// A successful load operation will fire a `load` event, while an unsuccessful
        /// load operation will fire an `error` event with the `src` value "load".
        /// If the load operation succeeds and one or more of the loaded attributes
        /// differ from this model's current attributes, a `change` event will be fired.
        /// </summary>
        public void load(object callback){}
        /// <summary>
        /// Loads this model from the server.
        /// This method delegates to the `sync()` method to perform the actual load
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// A successful load operation will fire a `load` event, while an unsuccessful
        /// load operation will fire an `error` event with the `src` value "load".
        /// If the load operation succeeds and one or more of the loaded attributes
        /// differ from this model's current attributes, a `change` event will be fired.
        /// </summary>
        public void load(object options, object callback){}
        /// <summary>
        /// Called to parse the _response_ when the model is loaded from the server.
        /// This method receives a server _response_ and is expected to return an
        /// attribute hash.
        /// The default implementation assumes that _response_ is either an attribute
        /// hash or a JSON string that can be parsed into an attribute hash. If
        /// _response_ is a JSON string and either `Y.JSON` or the native `JSON` object
        /// are available, it will be parsed automatically. If a parse error occurs, an
        /// `error` event will be fired and the model will not be updated.
        /// You may override this method to implement custom parsing logic if necessary.
        /// </summary>
        public object parse(object response){return null;}
        /// <summary>
        /// Saves this model to the server.
        /// This method delegates to the `sync()` method to perform the actual save
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// A successful save operation will fire a `save` event, while an unsuccessful
        /// save operation will fire an `error` event with the `src` value "save".
        /// If the save operation succeeds and one or more of the attributes returned in
        /// the server's response differ from this model's current attributes, a
        /// `change` event will be fired.
        /// </summary>
        public void save(){}
        /// <summary>
        /// Saves this model to the server.
        /// This method delegates to the `sync()` method to perform the actual save
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// A successful save operation will fire a `save` event, while an unsuccessful
        /// save operation will fire an `error` event with the `src` value "save".
        /// If the save operation succeeds and one or more of the attributes returned in
        /// the server's response differ from this model's current attributes, a
        /// `change` event will be fired.
        /// </summary>
        public void save(JsAction callback){}
        /// <summary>
        /// Saves this model to the server.
        /// This method delegates to the `sync()` method to perform the actual save
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// A successful save operation will fire a `save` event, while an unsuccessful
        /// save operation will fire an `error` event with the `src` value "save".
        /// If the save operation succeeds and one or more of the attributes returned in
        /// the server's response differ from this model's current attributes, a
        /// `change` event will be fired.
        /// </summary>
        public void save(object options){}
        /// <summary>
        /// Saves this model to the server.
        /// This method delegates to the `sync()` method to perform the actual save
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// A successful save operation will fire a `save` event, while an unsuccessful
        /// save operation will fire an `error` event with the `src` value "save".
        /// If the save operation succeeds and one or more of the attributes returned in
        /// the server's response differ from this model's current attributes, a
        /// `change` event will be fired.
        /// </summary>
        public void save(object options, JsAction callback){}
        /// <summary>
        /// Sets the value of a single attribute. If model validation fails, the
        /// attribute will not be set and an `error` event will be fired.
        /// Use `setAttrs()` to set multiple attributes at once.
        /// </summary>
        public void set(object name, object value){}
        /// <summary>
        /// Sets the value of a single attribute. If model validation fails, the
        /// attribute will not be set and an `error` event will be fired.
        /// Use `setAttrs()` to set multiple attributes at once.
        /// </summary>
        public void set(object name, object value, object options){}
        /// <summary>
        /// Sets the values of multiple attributes at once. If model validation fails,
        /// the attributes will not be set and an `error` event will be fired.
        /// </summary>
        public void setAttrs(object attributes){}
        /// <summary>
        /// Sets the values of multiple attributes at once. If model validation fails,
        /// the attributes will not be set and an `error` event will be fired.
        /// </summary>
        public void setAttrs(object attributes, object options){}
        /// <summary>
        /// Override this method to provide a custom persistence implementation for this
        /// model. The default just calls the callback without actually doing anything.
        /// This method is called internally by `load()`, `save()`, and `destroy()`.
        /// </summary>
        public void sync(object action){}
        /// <summary>
        /// Override this method to provide a custom persistence implementation for this
        /// model. The default just calls the callback without actually doing anything.
        /// This method is called internally by `load()`, `save()`, and `destroy()`.
        /// </summary>
        public void sync(object action, JsAction callback){}
        /// <summary>
        /// Override this method to provide a custom persistence implementation for this
        /// model. The default just calls the callback without actually doing anything.
        /// This method is called internally by `load()`, `save()`, and `destroy()`.
        /// </summary>
        public void sync(object action, object options){}
        /// <summary>
        /// Override this method to provide a custom persistence implementation for this
        /// model. The default just calls the callback without actually doing anything.
        /// This method is called internally by `load()`, `save()`, and `destroy()`.
        /// </summary>
        public void sync(object action, object options, JsAction callback){}
        /// <summary>
        /// Returns a copy of this model's attributes that can be passed to
        /// `Y.JSON.stringify()` or used for other nefarious purposes.
        /// The `clientId` attribute is not included in the returned object.
        /// If you've specified a custom attribute name in the `idAttribute` property,
        /// the default `id` attribute will not be included in the returned object.
        /// Note: The ECMAScript 5 specification states that objects may implement a
        /// `toJSON` method to provide an alternate object representation to serialize
        /// when passed to `JSON.stringify(obj)`.  This allows class instances to be
        /// serialized as if they were plain objects.  This is why Model's `toJSON`
        /// returns an object, not a JSON string.
        /// See <http://es5.github.com/#x15.12.3> for details.
        /// </summary>
        public object toJSON(){return null;}
        /// <summary>
        /// Reverts the last change to the model.
        /// If an _attrNames_ array is provided, then only the named attributes will be
        /// reverted (and only if they were modified in the previous change). If no
        /// _attrNames_ array is provided, then all changed attributes will be reverted
        /// to their previous values.
        /// Note that only one level of undo is available: from the current state to the
        /// previous state. If `undo()` is called when no previous state is available,
        /// it will simply do nothing.
        /// </summary>
        public void undo(){}
        /// <summary>
        /// Reverts the last change to the model.
        /// If an _attrNames_ array is provided, then only the named attributes will be
        /// reverted (and only if they were modified in the previous change). If no
        /// _attrNames_ array is provided, then all changed attributes will be reverted
        /// to their previous values.
        /// Note that only one level of undo is available: from the current state to the
        /// previous state. If `undo()` is called when no previous state is available,
        /// it will simply do nothing.
        /// </summary>
        public void undo(YUI_.Array attrNames){}
        /// <summary>
        /// Reverts the last change to the model.
        /// If an _attrNames_ array is provided, then only the named attributes will be
        /// reverted (and only if they were modified in the previous change). If no
        /// _attrNames_ array is provided, then all changed attributes will be reverted
        /// to their previous values.
        /// Note that only one level of undo is available: from the current state to the
        /// previous state. If `undo()` is called when no previous state is available,
        /// it will simply do nothing.
        /// </summary>
        public void undo(YUI_.Array attrNames, object options){}
        /// <summary>
        /// Reverts the last change to the model.
        /// If an _attrNames_ array is provided, then only the named attributes will be
        /// reverted (and only if they were modified in the previous change). If no
        /// _attrNames_ array is provided, then all changed attributes will be reverted
        /// to their previous values.
        /// Note that only one level of undo is available: from the current state to the
        /// previous state. If `undo()` is called when no previous state is available,
        /// it will simply do nothing.
        /// </summary>
        public void undo(object options){}
        /// <summary>
        /// Override this method to provide custom validation logic for this model.
        /// While attribute-specific validators can be used to validate individual
        /// attributes, this method gives you a hook to validate a hash of all
        /// attributes before the model is saved. This method is called automatically
        /// before `save()` takes any action. If validation fails, the `save()` call
        /// will be aborted.
        /// In your validation method, call the provided `callback` function with no
        /// arguments to indicate success. To indicate failure, pass a single argument,
        /// which may contain an error message, an array of error messages, or any other
        /// value. This value will be passed along to the `error` event.
        /// </summary>
        public void validate(object attrs, JsAction callback){}
        /// <summary>
        /// Hash of attributes that have changed since the last time this model was
        /// saved.
        /// </summary>
        public object changed{get;set;}
        /// <summary>
        /// Hash of attributes that were changed in the last `change` event. Each item
        /// in this hash is an object with the following properties:
        /// * `newVal`: The new value of the attribute after it changed.
        /// * `prevVal`: The old value of the attribute before it changed.
        /// * `src`: The source of the change, or `null` if no source was specified.
        /// </summary>
        public object lastChange{get;set;}
    }
}
