using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.jQuery;

namespace SharpKit.BackboneJs
{

    //[JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.Model")]
    //public class BackboneModel<T>
    //{
    //    public T defaults { get; set; }

    //    [JsMethod(Name = "defaults")]
    //    public virtual T createDefaults()
    //    {
    //        return default(T);
    //    }
    //    public virtual void initialize()
    //    {
    //    }
    //    public virtual void save(T obj)
    //    {
    //    }
    //    public P get<P>(JsString name) { return default(P); }
    //    public void set<T>(T values) { }

    //    public virtual void bind(JsString eventName, Func<object> function, object @this)
    //    {

    //    }
    //}

    //[JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.Collection")]
    //public class BackboneCollection<T>
    //{

    //}

    //[JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.View")]
    //public class BackboneView<T>
    //{
    //    public T defaults { get; set; }
    //    [JsMethod(Name = "defaults")]
    //    public virtual T createDefaults()
    //    {
    //        return default(T);
    //    }

    //    //public virtual JsString tagName { get; set; }

    //    public virtual void initialize()
    //    {
    //    }
    //    public virtual void save(T obj)
    //    {
    //    }
    //    public P get<P>(JsString name) { return default(P); }
    //    public void set<T>(T values) { }




    //    public virtual T render()
    //    {
    //        return default(T);
    //    }

    //    public virtual T remove()
    //    {
    //        return default(T);
    //    }
    //}

    /// <summary>
    /// Models are the heart of any JavaScript application, containing the interactive data as well as a large part of the logic surrounding it: conversions, validations, computed properties, and access control.
    /// You extend Backbone.Model with your domain-specific methods, and Model provides a basic set of functionality for managing changes.
    /// The following is a contrived example, but it demonstrates defining a model with a custom method, setting an attribute, and firing an event keyed to changes in that specific attribute.
    /// After running this code once, sidebar will be available in your browser's console, so you can play around with it.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Backbone.Model", Export = false)]
    public class Model
    {
        /// <summary>
        /// When creating an instance of a model, you can pass in the initial values of the attributes, which will be set on the model.
        /// If you define an initialize function, it will be invoked when the model is created.
        /// In rare cases, if you're looking to get fancy, you may want to override constructor, which allows you to replace the actual constructor function for your model.
        /// </summary>
        public Model() { }
        /// <summary>
        /// When creating an instance of a model, you can pass in the initial values of the attributes, which will be set on the model.
        /// If you define an initialize function, it will be invoked when the model is created.
        /// In rare cases, if you're looking to get fancy, you may want to override constructor, which allows you to replace the actual constructor function for your model.
        /// </summary>
        public Model(JsArray<ModelAttribute> attributes) { }

        /// <summary>
        /// To create a Model class of your own, you extend Backbone.Model and provide instance properties,
        /// as well as optional classProperties to be attached directly to the constructor function.
        /// extend correctly sets up the prototype chain, so subclasses created with extend can be further extended and subclassed as far as you like.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="classProperties"></param>
        ///<example>
        ///usage
        ///<code>
        ///var Note = Backbone.Model.extend({
        /// 
        ///   initialize: function() { ... },
        /// 
        ///   author: function() { ... },
        /// 
        ///   coordinates: function() { ... },
        /// 
        ///   allowedToEdit: function(account) {
        ///     return true;
        ///   }
        /// 
        /// });
        /// 
        /// var PrivateNote = Note.extend({
        /// 
        ///   allowedToEdit: function(account) {
        ///     return account.owns(this);
        ///   }
        /// 
        /// });
        ///</code>
        ///</example>
        public void extend(object properties, object classProperties) { }
        /// <summary>
        /// To create a Model class of your own, you extend Backbone.Model and provide instance properties,
        /// as well as optional classProperties to be attached directly to the constructor function.
        /// extend correctly sets up the prototype chain, so subclasses created with extend can be further extended and subclassed as far as you like.
        /// </summary>
        /// <param name="properties"></param>
        ///<example>
        ///usage
        ///<code>
        ///var Note = Backbone.Model.extend({
        /// 
        ///   initialize: function() { ... },
        /// 
        ///   author: function() { ... },
        /// 
        ///   coordinates: function() { ... },
        /// 
        ///   allowedToEdit: function(account) {
        ///     return true;
        ///   }
        /// 
        /// });
        /// 
        /// var PrivateNote = Note.extend({
        /// 
        ///   allowedToEdit: function(account) {
        ///     return account.owns(this);
        ///   }
        /// 
        /// });
        ///</code>
        ///</example>
        public void extend(object properties) { }

        /// <summary>
        /// Get the current value of an attribute from the model. For example: note.get("title")
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public object get(ModelAttribute attribute) { return null; }

        /// <summary>
        /// Set a hash of attributes (one or many) on the model.
        /// If any of the attributes change the models state,a "change" event will be triggered, unless {silent: true} is passed as an option.
        /// Change events for specific attributes are also triggered, and you can bind to those as well,
        /// for example: change:title, and change:content. You may also pass individual keys and values.
        /// If the model has a validate method, it will be validated before the attributes are set, no changes will occur if the validation fails, and set will return false.
        /// Otherwise, set returns a reference to the model. You may also pass an error callback in the options, which will be invoked instead of triggering an "error" event,
        /// should validation fail. If {silent: true} is passed as an option, the validation is deferred until the next change.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="options"></param>
        public void set(JsArray<ModelAttribute> attributes, object options) { }
        /// <summary>
        /// Set a hash of attributes (one or many) on the model.
        /// If any of the attributes change the models state,a "change" event will be triggered, unless {silent: true} is passed as an option.
        /// Change events for specific attributes are also triggered, and you can bind to those as well,
        /// for example: change:title, and change:content. You may also pass individual keys and values.
        /// If the model has a validate method, it will be validated before the attributes are set, no changes will occur if the validation fails, and set will return false.
        /// Otherwise, set returns a reference to the model. You may also pass an error callback in the options, which will be invoked instead of triggering an "error" event,
        /// should validation fail. If {silent: true} is passed as an option, the validation is deferred until the next change.
        /// </summary>
        /// <param name="attributes"></param>
        public void set(JsArray<ModelAttribute> attributes) { }
        /// <summary>
        /// Set a hash of attributes (one or many) on the model.
        /// If any of the attributes change the models state,a "change" event will be triggered, unless {silent: true} is passed as an option.
        /// Change events for specific attributes are also triggered, and you can bind to those as well,
        /// for example: change:title, and change:content. You may also pass individual keys and values.
        /// If the model has a validate method, it will be validated before the attributes are set, no changes will occur if the validation fails, and set will return false.
        /// Otherwise, set returns a reference to the model. You may also pass an error callback in the options, which will be invoked instead of triggering an "error" event,
        /// should validation fail. If {silent: true} is passed as an option, the validation is deferred until the next change.
        /// </summary>
        /// <param name="attributes"></param>
        public void set(ModelAttribute attributes) { }

        /// <summary>
        /// Similar to get, but returns the HTML-escaped version of a model's attribute.
        /// If you're interpolating data from the model into HTML, using escape to retrieve attributes will prevent XSS attacks.
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var hacker = new Backbone.Model({
        ///   name: "<script>alert('xss')</script>"
        /// });
        /// 
        /// alert(hacker.escape('name'));
        ///</code>
        ///</example>
        public object escape(ModelAttribute attribute) { return null; }
        //TODO: return type?

        /// <summary>
        /// Returns true if the attribute is set to a non-null or non-undefined value
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///if (note.has("title")) {
        ///   ...
        /// }
        ///</code>
        ///</example>
        public bool has(ModelAttribute attribute) { return false; }

        /// <summary>
        /// Remove an attribute by deleting it from the internal attributes hash. Fires a "change" event unless silent is passed as an option.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="options"></param>
        public void unsetmodel(ModelAttribute attribute, object options) { }
        /// <summary>
        /// Remove an attribute by deleting it from the internal attributes hash. Fires a "change" event unless silent is passed as an option.
        /// </summary>
        /// <param name="attribute"></param>
        public void unsetmodel(ModelAttribute attribute) { }

        /// <summary>
        /// Removes all attributes from the model. Fires a "change" event unless silent is passed as an option.
        /// </summary>
        /// <param name="options"></param>
        public void clear(object options) { }
        /// <summary>
        /// Removes all attributes from the model. Fires a "change" event unless silent is passed as an option.
        /// </summary>
        public void clear() { }

        /// <summary>
        ///A special property of models, the id is an arbitrary string (integer id or UUID).
        ///If you set the id in the attributes hash, it will be copied onto the model as a direct property.
        ///Models can be retrieved by id from collections, and the id is used to generate model URLs by default.
        /// </summary>
        [JsProperty(Name = "id")]
        public static JsString idString { get; set; }
        /// <summary>
        ///A special property of models, the id is an arbitrary string (integer id or UUID).
        ///If you set the id in the attributes hash, it will be copied onto the model as a direct property.
        ///Models can be retrieved by id from collections, and the id is used to generate model URLs by default.
        /// </summary>
        public static JsNumber id { get; set; }

        /// <summary>
        /// A model's unique identifier is stored under the id attribute.
        /// If you're directly communicating with a backend (CouchDB, MongoDB) that uses a different unique key,
        /// you may set a Model's idAttribute to transparently map from that key to id.
        /// </summary>
        public static JsString idAttribute { get; set; }

        /// <summary>
        /// A special property of models, the cid or client id is a unique identifier automatically assigned to all models when they're first created.
        /// Client ids are handy when the model has not yet been saved to the server, and does not yet have its eventual true id, but already needs to be visible in the UI.
        /// Client ids take the form: c1, c2, c3 ...
        /// </summary>
        public static JsString cid { get; set; }

        /// <summary>
        /// The attributes property is the internal hash containing the model's state. Please use set to update the attributes instead of modifying them directly.
        /// If you'd like to retrieve and munge a copy of the model's attributes, use toJSON instead.
        /// </summary>
        public static object attributes { get; set; }

        /// <summary>
        /// The changed property is the internal hash containing all the attributes that have changed since the last "change" event was triggered.
        /// Please do not update changed directly.
        /// Its state is maintained internally by set and change. A copy of changed can be acquired from changedAttributes.
        /// </summary>
        public static JsArray<ModelAttribute> changedmodel { get; set; }

        /// <summary>
        /// The defaults hash (or function) can be used to specify the default attributes for your model.
        /// When creating an instance of the model, any unspecified attributes will be set to their default value.
        /// Remember that in JavaScript, objects are passed by reference, so if you include an object as a default value, it will be shared among all instances.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var Meal = Backbone.Model.extend({
        ///   defaults: {
        ///     "appetizer":  "caesar salad",
        ///     "entree":     "ravioli",
        ///     "dessert":    "cheesecake"
        ///   }
        /// });
        /// 
        /// alert("Dessert will be " + (new Meal).get('dessert'));
        ///</code>
        ///</example>
        public static object defaults { get; set; }
        //TODO: 

        /// <summary>
        /// Return a copy of the model's attributes for JSON stringification.
        /// This can be used for persistence, serialization, or for augmentation before being handed off to a view.
        /// The name of this method is a bit confusing, as it doesn't actually return a JSON string —
        /// but I'm afraid that it's the way that the JavaScript API for JSON.stringify works.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var artist = new Backbone.Model({
        ///   firstName: "Wassily",
        ///   lastName: "Kandinsky"
        /// });
        /// 
        /// artist.set({birthday: "December 16, 1866"});
        /// 
        /// alert(JSON.stringify(artist));
        ///</code>
        ///</example>
        public object toJSON() { return null; }
        //TODO: return type

        /// <summary>
        /// Resets the model's state from the server by delegating to Backbone.sync. Returns a jqXHR.
        /// Useful if the model has never been populated with data, or if you'd like to ensure that you have the latest server state.
        /// A "change" event will be triggered if the server's state differs from the current attributes.
        /// Accepts success and error callbacks in the options hash, which are passed (model, response) as arguments.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // Poll every 10 seconds to keep the channel model up-to-date.
        /// setInterval(function() {
        ///   channel.fetch();
        /// }, 10000);
        ///</code>
        ///</example>
        public jqXHR fetch(object options) { return null; }


    }

    public class ModelAttribute
    {

        public JsString title { get; set; }
        public JsString content { get; set; }

    }
}


/*
 * // Our basic **Todo** model has `title`, `order`, and `done` attributes.
  var Todo = Backbone.Model.extend({

    // Default attributes for the todo item.
    defaults: function() {
      return {
        title: "empty todo...",
        order: Todos.nextOrder(),
        done: false
      };
    },

    // Ensure that each todo created has `title`.
    initialize: function() {
      if (!this.get("title")) {
        this.set({"title": this.defaults.title});
      }
    },

    // Toggle the `done` state of this todo item.
    toggle: function() {
      this.save({done: !this.get("done")});
    },

    // Remove this Todo from *localStorage* and delete its view.
    clear: function() {
      this.destroy();
    }

  });*/
