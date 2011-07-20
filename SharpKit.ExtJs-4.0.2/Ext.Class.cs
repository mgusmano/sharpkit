//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:24
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Class
    /// <summary>
    /// Handles class creation throughout the whole framework. Note that most of the time Ext.define should
    /// be used instead, since it&#39;s a higher level wrapper that aliases to Ext.ClassManager.create
    /// to enable namespacing and dynamic dependency resolution. Basic syntax: Ext.define(className, properties);
    /// in which properties is an object represent a collection of properties that apply to the class. See
    /// Ext.ClassManager.create for more detailed instructions. Ext.define(&#39;Person&#39;, {
    /// name: &#39;Unknown&#39;,
    /// constructor: function(name) {
    /// if (name) {
    /// this.name = name;
    /// }
    /// return this;
    /// },
    /// eat: function(foodType) {
    /// alert(&quot;I&#39;m eating: &quot; + foodType);
    /// return this;
    /// }
    /// });
    /// var aaron = new Person(&quot;Aaron&quot;);
    /// aaron.eat(&quot;Sandwich&quot;); // alert(&quot;I&#39;m eating: Sandwich&quot;);
    /// Ext.Class has a powerful set of extensible pre-processors which takes care of
    /// everything related to class creation, including but not limited to inheritance, mixins, configuration, statics, etc. Inheritance: Ext.define(&#39;Developer&#39;, {
    /// extend: &#39;Person&#39;,
    /// constructor: function(name, isGeek) {
    /// this.isGeek = isGeek;
    /// // Apply a method from the parent class&#39; prototype
    /// this.callParent([name]);
    /// return this;
    /// },
    /// code: function(language) {
    /// alert(&quot;I&#39;m coding in: &quot; + language);
    /// this.eat(&quot;Bugs&quot;);
    /// return this;
    /// }
    /// });
    /// var jacky = new Developer(&quot;Jacky&quot;, true);
    /// jacky.code(&quot;JavaScript&quot;); // alert(&quot;I&#39;m coding in: JavaScript&quot;);
    /// // alert(&quot;I&#39;m eating: Bugs&quot;);
    /// See Ext.Base.callParent for more details on calling superclass&#39; methods Mixins: Ext.define(&#39;CanPlayGuitar&#39;, {
    /// playGuitar: function() {
    /// alert(&quot;F#...G...D...A&quot;);
    /// }
    /// });
    /// Ext.define(&#39;CanComposeSongs&#39;, {
    /// composeSongs: function() { ... }
    /// });
    /// Ext.define(&#39;CanSing&#39;, {
    /// sing: function() {
    /// alert(&quot;I&#39;m on the highway to hell...&quot;)
    /// }
    /// });
    /// Ext.define(&#39;Musician&#39;, {
    /// extend: &#39;Person&#39;,
    /// mixins: {
    /// canPlayGuitar: &#39;CanPlayGuitar&#39;,
    /// canComposeSongs: &#39;CanComposeSongs&#39;,
    /// canSing: &#39;CanSing&#39;
    /// }
    /// })
    /// Ext.define(&#39;CoolPerson&#39;, {
    /// extend: &#39;Person&#39;,
    /// mixins: {
    /// canPlayGuitar: &#39;CanPlayGuitar&#39;,
    /// canSing: &#39;CanSing&#39;
    /// },
    /// sing: function() {
    /// alert(&quot;Ahem....&quot;);
    /// this.mixins.canSing.sing.call(this);
    /// alert(&quot;[Playing guitar at the same time...]&quot;);
    /// this.playGuitar();
    /// }
    /// });
    /// var me = new CoolPerson(&quot;Jacky&quot;);
    /// me.sing(); // alert(&quot;Ahem...&quot;);
    /// // alert(&quot;I&#39;m on the highway to hell...&quot;);
    /// // alert(&quot;[Playing guitar at the same time...]&quot;);
    /// // alert(&quot;F#...G...D...A&quot;);
    /// Config: Ext.define(&#39;SmartPhone&#39;, {
    /// config: {
    /// hasTouchScreen: false,
    /// operatingSystem: &#39;Other&#39;,
    /// price: 500
    /// },
    /// isExpensive: false,
    /// constructor: function(config) {
    /// this.initConfig(config);
    /// return this;
    /// },
    /// applyPrice: function(price) {
    /// this.isExpensive = (price &amp;gt; 500);
    /// return price;
    /// },
    /// applyOperatingSystem: function(operatingSystem) {
    /// if (!(/^(iOS|Android|BlackBerry)$/i).test(operatingSystem)) {
    /// return &#39;Other&#39;;
    /// }
    /// return operatingSystem;
    /// }
    /// });
    /// var iPhone = new SmartPhone({
    /// hasTouchScreen: true,
    /// operatingSystem: &#39;iOS&#39;
    /// });
    /// iPhone.getPrice(); // 500;
    /// iPhone.getOperatingSystem(); // &#39;iOS&#39;
    /// iPhone.getHasTouchScreen(); // true;
    /// iPhone.hasTouchScreen(); // true
    /// iPhone.isExpensive; // false;
    /// iPhone.setPrice(600);
    /// iPhone.getPrice(); // 600
    /// iPhone.isExpensive; // true;
    /// iPhone.setOperatingSystem(&#39;AlienOS&#39;);
    /// iPhone.getOperatingSystem(); // &#39;Other&#39;
    /// Statics: Ext.define(&#39;Computer&#39;, {
    /// statics: {
    /// factory: function(brand) {
    /// // &#39;this&#39; in static methods refer to the class itself
    /// return new this(brand);
    /// }
    /// },
    /// constructor: function() { ... }
    /// });
    /// var dellComputer = Computer.factory(&#39;Dell&#39;);
    /// Also see Ext.Base.statics and Ext.Base.self for more details on accessing
    /// static properties within class methods
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Class
    {
        /// <summary>
        /// Creates new class. ...
        /// </summary>
        public Ext.Base constructor(object classData, JsAction createdFn){return null;}
        /// <summary>
        /// Retrieve the array stack of default pre-processors ...
        /// </summary>
        public JsAction getDefaultPreprocessors(){return null;}
        /// <summary>
        /// Retrieve a pre-processor callback function by its name, which has been registered before ...
        /// </summary>
        public JsAction getPreprocessor(JsString name){return null;}
        /// <summary>
        /// Register a new pre-processor to be used during the class creation process registerPreprocessor ...
        /// </summary>
        public Ext.Class registerPreprocessor(JsString name, JsAction fn, object always){return null;}
        /// <summary>
        /// Insert this pre-processor at a specific position in the stack, optionally relative to
        /// any existing pre-processor. ...
        /// </summary>
        public Ext.Class setDefaultPreprocessorPosition(JsString name, JsString offset, JsString relativeName){return null;}
        /// <summary>
        /// Set the default array stack of default pre-processors ...
        /// </summary>
        public Ext.Class setDefaultPreprocessors(JsArray preprocessors){return null;}
    }
    #endregion
    #region ClassConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ClassConfig
    {
        /// <summary>
        /// List of short aliases for class names. ...
        /// </summary>
        public JsString alias{get;set;}
        /// <summary>
        /// Defines alternate names for this class. ...
        /// </summary>
        public object alternateClassName{get;set;}
        /// <summary>
        /// List of configuration options with their default values, for which automatically
        /// accessor methods are generated. ...
        /// </summary>
        public object config{get;set;}
        /// <summary>
        /// The parent class that this class extends. ...
        /// </summary>
        public JsString extend{get;set;}
        /// <summary>
        /// List of inheritable static methods for this class. ...
        /// </summary>
        public object inheritableStatics{get;set;}
        /// <summary>
        /// List of classes to mix into this class. ...
        /// </summary>
        public object mixins{get;set;}
        /// <summary>
        /// List of classes that have to be loaded before instanciating this class. ...
        /// </summary>
        public JsString requires{get;set;}
        /// <summary>
        /// When set to true, the class will be instanciated as singleton. ...
        /// </summary>
        public bool singleton{get;set;}
        /// <summary>
        /// List of static methods for this class. ...
        /// </summary>
        public object statics{get;set;}
        /// <summary>
        /// List of classes to load together with this class. ...
        /// </summary>
        public JsString uses{get;set;}
    }
    #endregion
    #region ClassEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ClassEvents
    {
    }
    #endregion
}
#endregion
