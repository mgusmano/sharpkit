using System;
using System.Collections.Generic;
using System.Linq;
using SharpKit.JavaScript;

namespace SharpKitWebApp5
{

    [JsType(JsMode.Prototype)]
    public class Class8_Base
    {

        private int prop = 10;

        [JsProperty(NativeProperty = true)]
        public virtual int MyProperty
        {
            get
            {
                return prop;
            }
            set
            {
                prop = value;
            }
        }

    }

    [JsType(JsMode.Prototype)]
    public class Class8_Inherit : Class8_Base
    {

        private int prop = 10;

        [JsProperty(NativeProperty = true)]
        public override int MyProperty
        {
            get
            {
                return base.MyProperty;
            }
            set
            {
                base.MyProperty = value;
            }
        }
         
    }

    [JsType(JsMode.Prototype)]
    public class Class8_GetSetProp
    {

        public void Main()
        {
            Class8_Inherit bar = null;
            var foo = bar.MyProperty;
            bar.MyProperty = bar.MyProperty;
        }

    }

}