using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.BackboneJs
{
    [JsType(JsMode.Clr, NativeJsons = true, OmitDefaultConstructor = true,
        PostCode = @"Backbone.Model.extend(JsTypes[JsTypes.length-1].definition);")]
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

    }


    [JsType(JsMode.Json)]
    class TodoObject
    {
        public JsString title { get; set; }
    }
}
