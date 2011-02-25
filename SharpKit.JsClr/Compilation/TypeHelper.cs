using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.Web.JavaScript.Compilation
{
	[JsType(Native = true, Name = "typeHelper", Filename = "~/Internal/Core.js")]
	public class TypeHelper
	{
		//static  JsArray _interfaces;
		//static string _primitiveTypes;
		//    [JsMethod(GlobalCode=true)]
		//static void Global()
		//    {
		//  //_interfaces = new JsArray();
		//  //_primitiveTypes = "string;number;boolean";//date doesn't work that way
		//    }

		//public static string convertToString(object value)
		//{
		//  if(value!=null)
		//  {
		//    var typeName = getTypeName(value);
		//    switch(typeName)
		//    {
		//      case "string":
		//        return value.As<string>();
		//      case "number":
		//        return value.As<JsObject>().toString();
		//      case "boolean":
		//        return value.As<JsObject>().toString();
		//      case "date":
		//        return dateHelper.format("dd/MM/yyyy HH:mm:ss", value);
		//      default:
		//        throw new Error("unknown primitive value "+value);
		//    }
		//  }
		//  return null;
		//}

		//public static bool isFunction(object value) 
		//{ 
		//  return JsScript.Typeof(value)=="function";
		//}

		[JsMethod(Code = @"  var typeName = typeof(value);
  if(typeName!='object')
    return typeName;
  if(value instanceof Date)
    return 'date';
  throw new Error('unknown type');", NativeOverloads=true)]
		public static string getTypeName(object value)
		{
			throw new NotImplementedException();
		}

		//    [JsMethod(Code=@"  var typeName = typeof(value);
		//  return _primitiveTypes.search(typeName)!=-1 || value instanceof Date;");
		//public static bool isPrimitive(object value) 
		//{ 
		//  throw new NotImplementedException();
		//}

		//public static object getFormatter(object propertyElement) 
		//{ 
		//  var typeName = propertyElement.getValue("PropertyType").Name;
		//  if(typeName=="NullableDateTime")
		//    return dateHelper;
		//  //throw new Error("Formatter not implemeneted for type " + typeName);
		//  return null;
		//}

		//public static void registerInterface(string className, string interfaceName) 
		//{
		//  _interfaces.push(className + "." + interfaceName);
		//}

		//public static bool @is(string className, string interfaceName) 
		//{
		//  //TODO: This does not work propely withy inheritance
		//  return _interfaces.indexOf(className + "." + interfaceName)>-1;
		//}

		//var typeHelper = new TypeHelper();

	}
}
