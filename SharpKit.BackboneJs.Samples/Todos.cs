using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.BackboneJs
{
    [JsType(JsMode.Clr, NativeJsons = true, OmitDefaultConstructor = true,
        PostCode = @"window.Todo = Backbone.Model.extend(JsTypes[JsTypes.length-1].definition);")]
    class Todo : BackboneModel<TodoObject>
    {

        public override TodoObject createDefaults()
        {
            return new TodoObject { title = "empty" };
        }
        public override void initialize()
        {
            if (!this.get<bool>("title"))
            {
                this.set(new TodoObject { title = this.defaults.title });
            }

        }

        public void toggle()
        {
            this.save(new TodoObject { done = !this.get<bool>("done") });
        }

    }

    [JsType(JsMode.Clr, NativeJsons = true, OmitDefaultConstructor = true,
        PostCode = @"window.TodoList = Backbone.Collection.extend(JsTypes[JsTypes.length-1].definition);")
    ]
    class TodoCollection : BackboneCollection<Todo>
    {
      
    }

    [JsType(JsMode.Clr, NativeJsons = true, OmitDefaultConstructor = true,
        PostCode = @"window.TodoView = Backbone.View.extend(JsTypes[JsTypes.length-1].definition);")
    ]
    class TodoView : BackboneView<TodoViewObject>
    {
        private Todo model;

        public JsString tagName = "foo";

        public override void initialize()
        {
            //if (!this.get<bool>("tagName"))
            //{
            //    this.set(new TodoViewObject { tagName = this.defaults.tagName });
            //}
            this.model.bind("change", this.render, this);
            this.model.bind("destroy", this.remove, this);


        }



        //    public override TodoObject createDefaults()
        //    {
        //        return new TodoObject { title = "empty" };
        //    }
        //    public override void initialize()
        //    {
        //        if (!this.get<bool>("title"))
        //        {
        //            this.set(new TodoObject { title = this.defaults.title });
        //        }

        //    }



    }

    //public  JsFunction render { get; set; }
    //public  JsFunction remove { get; set; }}

    [JsType(JsMode.Json)]
    class TodoObject
    {
        public JsString title { get; set; }
        public JsBoolean done { get; set; }
    }

 

    [JsType(JsMode.Json)]
    class TodoViewObject
    {
        public JsString tagName { get; set; }

    }
}
