using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.BackboneJs
{
    [JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.Model")]
    public class BackboneModel<T>
    {
        public T defaults { get; set; }

        [JsMethod(Name = "defaults")]
        public virtual T createDefaults()
        {
            return default(T);
        }
        public virtual void initialize()
        {
        }
        public virtual void save(T obj)
        {
        }
        public P get<P>(JsString name) { return default(P); }
        public void set<T>(T values) { }

        public virtual void bind(JsString eventName, Func<object> function, object @this)
        {

        }
    }

    [JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.Collection")]
    public class BackboneCollection<T>
    {
       
    }

    [JsType(JsMode.Clr, Export = false, IgnoreGenericMethodArguments = true, IgnoreGenericTypeArguments = true, NativeOverloads = true, AutomaticPropertiesAsFields = true, Name = "Backbone.View")]
    public class BackboneView<T>
    {
        public T defaults { get; set; }
        [JsMethod(Name = "defaults")]
        public virtual T createDefaults()
        {
            return default(T);
        }

        //public virtual JsString tagName { get; set; }

        public virtual void initialize()
        {
        }
        public virtual void save(T obj)
        {
        }
        public P get<P>(JsString name) { return default(P); }
        public void set<T>(T values) { }




        public virtual T render()
        {
            return default(T);
        }

        public virtual T remove()
        {
            return default(T);
        }
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
