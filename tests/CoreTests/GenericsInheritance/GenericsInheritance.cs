using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.GenericInheritance
{
    [JsType(JsMode.Clr)]
    public class SQParams<TSerialize>
    {
        //this create SQParams$1
    }

    [JsType(JsMode.Clr)]
    public class SQParamCollection<T> : SQParams<SQParamCollection<T>>//, IList<T>
    {
        //this creates SQParamCollection$1 and SQParamCollection$2
    }

    [JsType(JsMode.Clr)]
    public class KCat //data object
    {

    }

    //[JsType(JsMode.Clr)]
    //public class KCatCollection : SQParams<KCat>
    //{
    //    //it creates the proper function to the base
    //    //        ctor:function()
    //    //    {
    //    //      NGShared.SQParams$1.ctor.call(this,NGMobileShared.KCat);
    //    // }
    //}

    [JsType(JsMode.Clr)]
    public class KCatCollection : SQParamCollection<KCat>
    {
        //it does not create the proper function to the base
        //
        //    baseTypeName:"NGShared.SQParamCollection",
        //   definition:
        //   {
        //       ctor:function()
        //       {
        //       }
        //   }
    }
}
