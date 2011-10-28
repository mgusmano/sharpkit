using System;
using System.Collections.Generic;
using System.Text;
using SharpKit.JavaScript.Private;
using SharpKit.JavaScript;


namespace SharpKit.JavaScript.Compilation
{


    [JsTypeAttribute(JsMode.Json)]
    [JsEnum(ValuesAsNames=true)]
    public enum JsTypeKind
    {
        Class,
        Struct,
        Interface,
        Enum,
        Delegate,
    }

    /// <summary>
    /// A type used internally by the Js Type System
    /// </summary>
    [JsTypeAttribute(JsMode.Json)]
    public class JsType
    {
        public JsFunc<JsString, object> tryParse{get;set;}
        internal JsCompilerPrototype commonPrototype{get;set;}
        public bool isCompiled{get;set;}
        public JsObject ctors{get;set;}
        public JsObject definition{get;set;}
        public JsObject staticDefinition{get;set;}
        public JsType baseType{get;set;}
        public JsArray<JsAttribute> customAttributes{get;set;}
        public JsArray<JsType> interfaces{get;set;}
        public JsArray<JsString> interfaceNames{get;set;}
        internal JsImplType _ClrType { get; set; }
        public JsArray<JsType> derivedTypes{get;set;}
        public string assemblyName{get;set;}
        public string fullname{get;set;}
        public string name{get;set;}
        public string ns{get;set;}
        public string baseTypeName{get;set;}
        public JsTypeKind Kind { get; set; }
        public JsFunction cctor { get; set; }
        public bool isPartial{get;set;}
        public JsType realType{get;set;}
        public JsFunction ctor{get;set;}
        public string _AssemblyQualifiedName{get;set;}

    }

    [JsType(JsMode.Json)]
    public class JsAttribute
    {
        public string targetType{get;set;}
        public string targetMemberName{get;set;}
        public string typeName{get;set;}
        public string ctorName{get;set;}
        public JsArray positionalArguments{get;set;}
        public JsObject namedArguments{get;set;}
    }

    [JsType(JsMode.Json, Name = "Namespace", Export = false)]
    public class JsNamespace : JsObject
    {
        public JsString name { get; set; }
    }
}

