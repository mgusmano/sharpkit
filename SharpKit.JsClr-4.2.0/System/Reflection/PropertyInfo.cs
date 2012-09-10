using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

    [JsType(Name = "System.Reflection.PropertyInfo", Filename = "~/res/System.Reflection/PropertyInfo .js")]
	internal class JsImplPropertyInfo : JsImplMemberInfo
	{
		internal JsImplType _PropertyType;



		protected override JsImplMemberInfo GetBaseMember()
		{
			return null;
		}
		internal bool _IsStatic;
		internal JsFunction _Getter;
		internal JsFunction _Setter;

		//[JsMethod(UseNativeOverloads = true)]
		public object GetValue(object obj, object[] indexes)
		{
			if (_Getter == null)
				throw new Exception("Property " + _Name + " doesn't have a getter");
			var value = _Getter.apply(obj, indexes ?? new JsArray().As<object[]>());
			return value;
		}

		//[JsMethod(UseNativeOverloads = true)]
		public void SetValue(object obj, object value, object[] indexes)
		{
			if (_Setter == null)
				throw new Exception("Property " + _Name + " doesn't have a setter");
			if (indexes == null || indexes.Length == 0)
			{
				_Setter.call(obj, value);
			}
			else
			{
				var arr = new JsArray(indexes);
				arr.push(value);
				_Setter.apply(obj, indexes ?? new JsArray().As<object[]>());
			}
		}

		public override string Name
		{
			get { return _Name; }
		}

		public JsImplType PropertyType
		{
			get
			{
				return _PropertyType;
			}
		}
	}
}
