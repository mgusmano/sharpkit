/*Generated by SharpKit 5 v4.29.8000*/
if(typeof(JsTypes) == "undefined")
    var JsTypes=[];
var System$Linq$Enumerable$WhereListIterator=
{
    fullname:"System.Linq.Enumerable.WhereListIterator",
    baseTypeName:"System.Linq.Enumerable.Iterator",
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function(TSource,source,predicate)
        {
            this.TSource = TSource;
            this.source = null;
            this.predicate = null;
            this.enumerator = null;
            System.Linq.Enumerable.Iterator.ctor.call(this,this.TSource);
            this.source = source;
            this.predicate = predicate;
        },
        Clone:function()
        {
            return new System.Linq.Enumerable.WhereListIterator.ctor(this.TSource,this.source,this.predicate);
        },
        MoveNext:function()
        {
            switch(this.state)
            {
                case 1:
                    this.enumerator = this.source.GetEnumerator();
                    this.state = 2;
                    break;
                case 2:
                    break;
                default:
                    return false;
            }
            while(this.enumerator.MoveNext())
            {
                var current=this.enumerator.get_Current();
                if(this.predicate(current))
                {
                    this.current = current;
                    return true;
                }
            }
            this.Dispose();
            return false;
        },
        Select$1:function(TResult,selector)
        {
            return new System.Linq.Enumerable.WhereSelectListIterator.ctor(this.TSource,TResult,this.source,this.predicate,selector);
        },
        Where:function(predicate)
        {
            return new System.Linq.Enumerable.WhereListIterator.ctor(this.TSource,this.source,System.Linq.Enumerable.CombinePredicates$1(this.TSource,this.predicate,predicate));
        }
    }
};
JsTypes.push(System$Linq$Enumerable$WhereListIterator);
