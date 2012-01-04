using Ext;
using SharpKit.JavaScript;

namespace SharpKit.ExtJs
{
    /// <summary>
    /// This class is designed to allow JsMode.Clr runtime conversion to ExtJs native types, in order to use it, 
    /// mark your classes in JsType(JsMode.Clr)
    /// copy this file to your project, include the generated js file
    /// and call SharpKit.ExtJs.ExtJsCompiler.CompileExtJs() after all of your script includes
    /// </summary>
    [JsType(JsMode.Prototype)]
    public class ExtJsCompiler
    {
        public void CompileExtJs()
        {
            foreach (var ce in JsClrContext.JsTypes)
            {
                ce.definition.As<ClassConfig>().extend = ce.baseTypeName;
                ExtContext.define(ce.name, ce.definition);
            }
        }
    }


    #region JsClr Model
    
    [JsType(JsMode.Global, Export = false)]
    class JsClrContext
    {
        public static JsArray<JsType> JsTypes { get; set; }
    }

    [JsTypeAttribute(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    enum JsTypeKind
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
    class JsType
    {
        public JsFunc<JsString, object> tryParse { get; set; }
        public bool isCompiled { get; set; }
        public JsObject ctors { get; set; }
        public JsObject definition { get; set; }
        public JsObject staticDefinition { get; set; }
        public JsType baseType { get; set; }
        public JsArray<JsAttribute> customAttributes { get; set; }
        public JsArray<JsType> interfaces { get; set; }
        public JsArray<JsString> interfaceNames { get; set; }
        public JsArray<JsType> derivedTypes { get; set; }
        public JsString assemblyName { get; set; }
        public JsString fullname { get; set; }
        public JsString name { get; set; }
        public JsString ns { get; set; }
        public JsString baseTypeName { get; set; }
        public JsTypeKind Kind { get; set; }
        public JsFunction cctor { get; set; }
        public bool isPartial { get; set; }
        public JsType realType { get; set; }
        public JsFunction ctor { get; set; }
        public JsString _AssemblyQualifiedName { get; set; }

    }

    [JsType(JsMode.Json)]
    class JsAttribute
    {
        public JsString targetType { get; set; }
        public JsString targetMemberName { get; set; }
        public JsString typeName { get; set; }
        public JsString ctorName { get; set; }
        public JsArray positionalArguments { get; set; }
        public JsObject namedArguments { get; set; }
    }

    [JsType(JsMode.Json, Name = "Namespace", Export = false)]
    class JsNamespace : JsObject
    {
        public JsString name { get; set; }
    }
        #endregion

}