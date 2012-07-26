using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;
[assembly:JsType(JsMode.Prototype, Export=false)]

namespace SharpKit.KendoUI
{
    public class kendo
    {
        /// <summary>
        /// Binds a HTML View to a View-Model. Model View ViewModel (MVVM) is a design pattern which helps developers separate the Model from the View.
        /// The View-Model part of MVVM is responsible for exposing the data objects from the Model in such a way that those objects are easily consumed in the View.
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wraped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace(s) too look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. The default order is kendo.ui, kendo.dataviz.ui.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        ///  &lt;!-- View -->
        ///&lt;div id="view">
        ///  &lt;!-- The value of the INPUT element is bound to the "firstName" field of the View-Model.
        ///  When the value changes so will the "firstName" field and vice versa.  -->
        ///  &lt;label>First Name:&lt;input data-bind="value: firstName" />&lt;/label>
        ///  &lt;!-- The value of the INPUT element is bound to the "lastName" field of the View-Model.
        ///  When the value changes so will the "lastName" field and vice versa.   -->
        ///  &lt;label>Last Name:&lt;input data-bind="value: lastName" />&lt;/label>
        ///  &lt;!-- The click event of the BUTTON element is bound to the "displayGreeting" method of the View-Model.
        ///  When the user clicks the button the "displayGreeting" method will be invoked.  -->
        ///  &lt;button data-bind="click: displayGreeting">Display Greeting&lt;/button>
        ///&lt;/div>
        ///&lt;script>
        ///  // View-Model
        ///  var viewModel = kendo.observable({
        ///     firstName: "John",
        ///     lastName: "Doe",
        ///     displayGreeting: function() {
        ///         // Get the current values of "firstName" and "lastName"
        ///         var firstName = this.get("firstName");
        ///         var lastName = this.get("lastName");
        ///         alert("Hello, " + firstName + " " + lastName + "!!!");
        ///     }
        ///  });
        ///  // Bind the View to the View-Model
        ///  kendo.bind($("#view"), viewModel);
        ///</script>
        /// </code></example>
        public JsString bind(JsString element, object viewModel, object @namespace) { return null; }
        /// <summary>
        /// Binds a HTML View to a View-Model. Model View ViewModel (MVVM) is a design pattern which helps developers separate the Model from the View.
        /// The View-Model part of MVVM is responsible for exposing the data objects from the Model in such a way that those objects are easily consumed in the View.
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wraped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <returns></returns>
        ///  <example>
        /// usage
        /// <code>
        ///  &lt;!-- View -->
        ///&lt;div id="view">
        ///  &lt;!-- The value of the INPUT element is bound to the "firstName" field of the View-Model.
        ///  When the value changes so will the "firstName" field and vice versa.  -->
        ///  &lt;label>First Name:&lt;input data-bind="value: firstName" />&lt;/label>
        ///  &lt;!-- The value of the INPUT element is bound to the "lastName" field of the View-Model.
        ///  When the value changes so will the "lastName" field and vice versa.   -->
        ///  &lt;label>Last Name:&lt;input data-bind="value: lastName" />&lt;/label>
        ///  &lt;!-- The click event of the BUTTON element is bound to the "displayGreeting" method of the View-Model.
        ///  When the user clicks the button the "displayGreeting" method will be invoked.  -->
        ///  &lt;button data-bind="click: displayGreeting">Display Greeting&lt;/button>
        ///&lt;/div>
        ///&lt;script>
        ///  // View-Model
        ///  var viewModel = kendo.observable({
        ///     firstName: "John",
        ///     lastName: "Doe",
        ///     displayGreeting: function() {
        ///         // Get the current values of "firstName" and "lastName"
        ///         var firstName = this.get("firstName");
        ///         var lastName = this.get("lastName");
        ///         alert("Hello, " + firstName + " " + lastName + "!!!");
        ///     }
        ///  });
        ///  // Bind the View to the View-Model
        ///  kendo.bind($("#view"), viewModel);
        ///</script>
        /// </code></example>
        public JsString bind(JsString element, object viewModel) { return null; }
        /// <summary>
        /// Binds a HTML View to a View-Model. Model View ViewModel (MVVM) is a design pattern which helps developers separate the Model from the View.
        /// The View-Model part of MVVM is responsible for exposing the data objects from the Model in such a way that those objects are easily consumed in the View.
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wraped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace(s) too look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. The default order is kendo.ui, kendo.dataviz.ui.</param>
        /// <returns></returns>
        ///  <example>
        /// usage
        /// <code>
        ///  &lt;!-- View -->
        ///&lt;div id="view">
        ///  &lt;!-- The value of the INPUT element is bound to the "firstName" field of the View-Model.
        ///  When the value changes so will the "firstName" field and vice versa.  -->
        ///  &lt;label>First Name:&lt;input data-bind="value: firstName" />&lt;/label>
        ///  &lt;!-- The value of the INPUT element is bound to the "lastName" field of the View-Model.
        ///  When the value changes so will the "lastName" field and vice versa.   -->
        ///  &lt;label>Last Name:&lt;input data-bind="value: lastName" />&lt;/label>
        ///  &lt;!-- The click event of the BUTTON element is bound to the "displayGreeting" method of the View-Model.
        ///  When the user clicks the button the "displayGreeting" method will be invoked.  -->
        ///  &lt;button data-bind="click: displayGreeting">Display Greeting&lt;/button>
        ///&lt;/div>
        ///&lt;script>
        ///  // View-Model
        ///  var viewModel = kendo.observable({
        ///     firstName: "John",
        ///     lastName: "Doe",
        ///     displayGreeting: function() {
        ///         // Get the current values of "firstName" and "lastName"
        ///         var firstName = this.get("firstName");
        ///         var lastName = this.get("lastName");
        ///         alert("Hello, " + firstName + " " + lastName + "!!!");
        ///     }
        ///  });
        ///  // Bind the View to the View-Model
        ///  kendo.bind($("#view"), viewModel);
        ///</script>
        /// </code></example>
        public JsString bind(jQuery.jQuery element, object viewModel, object @namespace) { return null; }
        /// <summary>
        /// Binds a HTML View to a View-Model. Model View ViewModel (MVVM) is a design pattern which helps developers separate the Model from the View.
        /// The View-Model part of MVVM is responsible for exposing the data objects from the Model in such a way that those objects are easily consumed in the View.
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wraped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <returns></returns>
        ///  <example>
        /// usage
        /// <code>
        ///  &lt;!-- View -->
        ///&lt;div id="view">
        ///  &lt;!-- The value of the INPUT element is bound to the "firstName" field of the View-Model.
        ///  When the value changes so will the "firstName" field and vice versa.  -->
        ///  &lt;label>First Name:&lt;input data-bind="value: firstName" />&lt;/label>
        ///  &lt;!-- The value of the INPUT element is bound to the "lastName" field of the View-Model.
        ///  When the value changes so will the "lastName" field and vice versa.   -->
        ///  &lt;label>Last Name:&lt;input data-bind="value: lastName" />&lt;/label>
        ///  &lt;!-- The click event of the BUTTON element is bound to the "displayGreeting" method of the View-Model.
        ///  When the user clicks the button the "displayGreeting" method will be invoked.  -->
        ///  &lt;button data-bind="click: displayGreeting">Display Greeting&lt;/button>
        ///&lt;/div>
        ///&lt;script>
        ///  // View-Model
        ///  var viewModel = kendo.observable({
        ///     firstName: "John",
        ///     lastName: "Doe",
        ///     displayGreeting: function() {
        ///         // Get the current values of "firstName" and "lastName"
        ///         var firstName = this.get("firstName");
        ///         var lastName = this.get("lastName");
        ///         alert("Hello, " + firstName + " " + lastName + "!!!");
        ///     }
        ///  });
        ///  // Bind the View to the View-Model
        ///  kendo.bind($("#view"), viewModel);
        ///</script>
        /// </code></example>
        public JsString bind(jQuery.jQuery element, object viewModel) { return null; }
        /// <summary>
        /// Binds a HTML View to a View-Model. Model View ViewModel (MVVM) is a design pattern which helps developers separate the Model from the View.
        /// The View-Model part of MVVM is responsible for exposing the data objects from the Model in such a way that those objects are easily consumed in the View.
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wraped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <param name="namespace">Optional namespace(s) too look in when instantiating Kendo UI widgets. The valid namespaces are kendo.ui, kendo.dataviz.ui and kendo.mobile.ui. The default order is kendo.ui, kendo.dataviz.ui.</param>
        /// <returns></returns>
        ///  <example>
        /// usage
        /// <code>
        ///  &lt;!-- View -->
        ///&lt;div id="view">
        ///  &lt;!-- The value of the INPUT element is bound to the "firstName" field of the View-Model.
        ///  When the value changes so will the "firstName" field and vice versa.  -->
        ///  &lt;label>First Name:&lt;input data-bind="value: firstName" />&lt;/label>
        ///  &lt;!-- The value of the INPUT element is bound to the "lastName" field of the View-Model.
        ///  When the value changes so will the "lastName" field and vice versa.   -->
        ///  &lt;label>Last Name:&lt;input data-bind="value: lastName" />&lt;/label>
        ///  &lt;!-- The click event of the BUTTON element is bound to the "displayGreeting" method of the View-Model.
        ///  When the user clicks the button the "displayGreeting" method will be invoked.  -->
        ///  &lt;button data-bind="click: displayGreeting">Display Greeting&lt;/button>
        ///&lt;/div>
        ///&lt;script>
        ///  // View-Model
        ///  var viewModel = kendo.observable({
        ///     firstName: "John",
        ///     lastName: "Doe",
        ///     displayGreeting: function() {
        ///         // Get the current values of "firstName" and "lastName"
        ///         var firstName = this.get("firstName");
        ///         var lastName = this.get("lastName");
        ///         alert("Hello, " + firstName + " " + lastName + "!!!");
        ///     }
        ///  });
        ///  // Bind the View to the View-Model
        ///  kendo.bind($("#view"), viewModel);
        ///</script>
        /// </code></example>
        public JsString bind(HtmlElement element, object viewModel, object @namespace) { return null; }
        /// <summary>
        /// Binds a HTML View to a View-Model. Model View ViewModel (MVVM) is a design pattern which helps developers separate the Model from the View.
        /// The View-Model part of MVVM is responsible for exposing the data objects from the Model in such a way that those objects are easily consumed in the View.
        /// </summary>
        /// <param name="element">The root element(s) from which the binding starts. Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed</param>
        /// <param name="viewModel">The View-Model which the elements are bound to. Wraped as an instance of kendo.data.ObservableObject if not already.</param>
        /// <returns></returns>
        ///  <example>
        /// usage
        /// <code>
        ///  &lt;!-- View -->
        ///&lt;div id="view">
        ///  &lt;!-- The value of the INPUT element is bound to the "firstName" field of the View-Model.
        ///  When the value changes so will the "firstName" field and vice versa.  -->
        ///  &lt;label>First Name:&lt;input data-bind="value: firstName" />&lt;/label>
        ///  &lt;!-- The value of the INPUT element is bound to the "lastName" field of the View-Model.
        ///  When the value changes so will the "lastName" field and vice versa.   -->
        ///  &lt;label>Last Name:&lt;input data-bind="value: lastName" />&lt;/label>
        ///  &lt;!-- The click event of the BUTTON element is bound to the "displayGreeting" method of the View-Model.
        ///  When the user clicks the button the "displayGreeting" method will be invoked.  -->
        ///  &lt;button data-bind="click: displayGreeting">Display Greeting&lt;/button>
        ///&lt;/div>
        ///&lt;script>
        ///  // View-Model
        ///  var viewModel = kendo.observable({
        ///     firstName: "John",
        ///     lastName: "Doe",
        ///     displayGreeting: function() {
        ///         // Get the current values of "firstName" and "lastName"
        ///         var firstName = this.get("firstName");
        ///         var lastName = this.get("lastName");
        ///         alert("Hello, " + firstName + " " + lastName + "!!!");
        ///     }
        ///  });
        ///  // Bind the View to the View-Model
        ///  kendo.bind($("#view"), viewModel);
        ///</script>
        /// </code></example>
        public JsString bind(HtmlElement element, object viewModel) { return null; }

        /// <summary>
        /// Sets or gets the current culture. Uses the passed culture name to select a culture from the culture scripts that you have included and then sets the current culture.
        /// If there is no corresponding culture then the method will try to find culture which is equal to the country part of the culture name. If no culture is found the default one is used
        /// </summary>
        /// <param name="enGB"></param>
        public void culture(object enGB) { }
        //TODO: method is a mess. danel must chack

        /// <summary>
        /// Sets or gets the current culture. Uses the passed culture name to select a culture from the culture scripts that you have included and then sets the current culture.
        /// If there is no corresponding culture then the method will try to find culture which is equal to the country part of the culture name. If no culture is found the default one is used.
        /// </summary>
        /// <returns></returns>
        public JsString getCurrentCulture() { return null; }
        //TODO: method is a mess. danel must chack

        /// <summary>
        /// Replaces each format item in a specified string with the text equivalent of a corresponding object's value.
        /// </summary>
        /// <param name="value">The string that needs to be HTML encoded.</param>
        /// <returns></returns>
        public JsString format(JsString value) { return null; }

        /// <summary>
        /// Parses as a formatted string as a Date.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as date.</param>
        /// <param name="formats">The format(s) that will be used to parse the date. By default all standard date formats are used.</param>
        /// <param name="culture">The culture used to parse the number. The current culture is used by default.</param>
        /// <returns>the parsed date.</returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseDate("12/22/2000"); //Fri Dec 22 2000
        /// kendo.parseDate("2000/12/22", "yyyy/MM/dd"); //Fri Dec 22 2000
        /// </code>
        /// </example>
        public JsDate parseDate(JsString value, JsString formats, JsString culture) { return null; }
        /// <summary>
        /// Parses as a formatted string as a Date.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as date.</param>
        /// <param name="formats">The format(s) that will be used to parse the date. By default all standard date formats are used.</param>
        /// <param name="culture">The culture used to parse the number. The current culture is used by default.</param>
        /// <returns>the parsed date.</returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseDate("12/22/2000"); //Fri Dec 22 2000
        /// kendo.parseDate("2000/12/22", "yyyy/MM/dd"); //Fri Dec 22 2000
        /// </code>
        /// </example>
        public JsDate parseDate(JsString value, JsArray formats, JsString culture) { return null; }
        /// <summary>
        /// Parses as a formatted string as a Date.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as date.</param>
        /// <param name="formats">The format(s) that will be used to parse the date. By default all standard date formats are used.</param>
        /// <returns>the parsed date.</returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseDate("12/22/2000"); //Fri Dec 22 2000
        /// kendo.parseDate("2000/12/22", "yyyy/MM/dd"); //Fri Dec 22 2000
        /// </code>
        /// </example>
        public JsDate parseDate(JsString value, JsArray formats) { return null; }
        /// <summary>
        /// Parses as a formatted string as a Date.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as date.</param>
        /// <param name="culture">The culture used to parse the number. The current culture is used by default.</param>
        /// <returns>the parsed date.</returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseDate("12/22/2000"); //Fri Dec 22 2000
        /// kendo.parseDate("2000/12/22", "yyyy/MM/dd"); //Fri Dec 22 2000
        /// </code>
        /// </example>
        public JsDate parseDate(JsString value, JsString culture) { return null; }
        /// <summary>
        /// Parses as a formatted string as a Date.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as date.</param>
        /// <returns>the parsed date.</returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseDate("12/22/2000"); //Fri Dec 22 2000
        /// kendo.parseDate("2000/12/22", "yyyy/MM/dd"); //Fri Dec 22 2000
        /// </code>
        /// </example>
        public JsDate parseDate(JsString value) { return null; }

        /// <summary>
        /// Parses as a formatted string as a floating point number.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as number.</param>
        /// <param name="culture">The culture used to parse the number. The current culture is used by default.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseFloat("12.22"); //12.22
        ///kendo.culture("de-DE");
        ///kendo.parseFloat("1.212,22 €"); //1212.22
        /// </code>
        /// </example>
        public JsNumber parseFloat(JsString value, JsString culture) { return null; }
        /// <summary>
        /// Parses as a formatted string as a floating point number.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as number.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseFloat("12.22"); //12.22
        ///kendo.culture("de-DE");
        ///kendo.parseFloat("1.212,22 €"); //1212.22
        /// </code>
        /// </example>
        public JsNumber parseFloat(JsString value) { return null; }

        /// <summary>
        /// Parses as a formatted string as an integer.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as number.</param>
        /// <param name="culture">The culture used to parse the number. The current culture is used by default.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseInt("12.22"); //12.22
        ///kendo.culture("de-DE");
        ///kendo.parseFloat("1.212,22 €"); //1212.22
        /// </code>
        /// </example>
        public JsNumber parseInt(JsString value, JsString culture) { return null; }
        /// <summary>
        /// Parses as a formatted string as an integer.
        /// </summary>
        /// <param name="value">The formatted string which should be parsed as number.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// kendo.parseInt("12.22"); //12.22
        ///kendo.culture("de-DE");
        ///kendo.parseFloat("1.212,22 €"); //1212.22
        /// </code>
        /// </example>
        public JsNumber parseInt(JsString value) { return null; }

        /// <summary>
        /// Renders the specified template using the provided data
        /// </summary>
        /// <param name="template">The Kendo template which should be rendered.</param>
        /// <param name="data">Array of JavaScript objects which contains the data that the template will render.</param>
        /// <example>
        /// usage
        /// <code>
        /// var template = kendo.template("&lt;li>#: name #&lt;/li>");
        ///var data = [ { name: "John Doe" }, { name: "Jane Doe" }];
        ///$("ul").html(kendo.render(template, data)); // sets the html to <li>John Doe</li><li>Jane Doe</li>
        /// </code>
        /// </example>
        public void render(JsFunction template, JsArray data) { }
        
        /// <summary>
        /// Compiles a template to a function that builds HTML. Useful when a template will be used several times.
        /// Templates offer way of creating HTML chunks. Options such as HTML encoding and compilation for optimal performance are available.
        /// </summary>
        /// <param name="template">The template that will be compiled.</param>
        /// <param name="options">Template compilation options.</param>
        /// This allows the usage of unqualified fields in the template. Disabling the with block will improve the performance of the template.</param>
        /// <returns>(Function)the compiled template as a JavaScript function. When called this function will return the generated HTML string.</returns>
        /// <example>
        /// usage
        /// <code>
        /// var inlineTemplate = kendo.template("Hello, #= firstName # #= lastName #");
        ///var inlineData = { firstName: "John", lastName: "Doe" };
        ///$("#inline").html(inlineTemplate(inlineData));
        /// </code></example>
        public JsString template(JsString template, KendoObjectOptions options) { return null; }
        /// <summary>
        /// Compiles a template to a function that builds HTML. Useful when a template will be used several times.
        /// Templates offer way of creating HTML chunks. Options such as HTML encoding and compilation for optimal performance are available.
        /// </summary>
        /// <param name="template">The template that will be compiled.</param>
        /// This allows the usage of unqualified fields in the template. Disabling the with block will improve the performance of the template.</param>
        /// <returns>(Function)the compiled template as a JavaScript function. When called this function will return the generated HTML string.</returns>
        /// <example>
        /// usage
        /// <code>
        /// var inlineTemplate = kendo.template("Hello, #= firstName # #= lastName #");
        ///var inlineData = { firstName: "John", lastName: "Doe" };
        ///$("#inline").html(inlineTemplate(inlineData));
        /// </code></example>
        public JsString template(JsString template) { return null; }

        /// <summary>
        /// Enables kinetic scrolling on touch devices
        /// </summary>
        /// <param name="element">The container element to enable scrolling for.</param>
        public void touchScroller(JsString element) { }
        //TODO: element type?

        /// <summary>
        /// Formats a Number or Date using the specified format and the current culture.
        /// </summary>
        /// <param name="value">The Date or Number which should be formatted.</param>
        /// <param name="format">The format string which should be used to format the value.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///format a number using standard number formats and default culture en-US
        ///kendo.toString(10.12, "n"); //10.12
        ///kendo.toString(10.12, "n0"); //10
        ///kendo.toString(10.12, "n5"); //10.12000
        ///kendo.toString(10.12, "c"); //$10.12
        ///kendo.toString(0.12, "p"); //12.00 %
        /// //format a number using custom number formats
        ///kendo.toString(19.12, "00##"); //0019
        /// //format a date
        ///kendo.toString(new Date(2010, 9, 5), "yyyy/MM/dd" ); // "2010/10/05"
        ///kendo.toString(new Date(2010, 9, 5), "dddd MMMM d, yyyy" ); // "Tuesday October 5, 2010"
        ///kendo.toString(new Date(2010, 10, 10, 22, 12), "hh:mm tt" ); // "10:12 PM"
        ///</code>
        ///</example>
        public JsString toString(JsDate value, JsString format) { return null; }
        /// <summary>
        /// Formats a Number or Date using the specified format and the current culture.
        /// </summary>
        /// <param name="value">The Date or Number which should be formatted.</param>
        /// <param name="format">The format string which should be used to format the value.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///format a number using standard number formats and default culture en-US
        ///kendo.toString(10.12, "n"); //10.12
        ///kendo.toString(10.12, "n0"); //10
        ///kendo.toString(10.12, "n5"); //10.12000
        ///kendo.toString(10.12, "c"); //$10.12
        ///kendo.toString(0.12, "p"); //12.00 %
        /// //format a number using custom number formats
        ///kendo.toString(19.12, "00##"); //0019
        /// //format a date
        ///kendo.toString(new Date(2010, 9, 5), "yyyy/MM/dd" ); // "2010/10/05"
        ///kendo.toString(new Date(2010, 9, 5), "dddd MMMM d, yyyy" ); // "Tuesday October 5, 2010"
        ///kendo.toString(new Date(2010, 10, 10, 22, 12), "hh:mm tt" ); // "10:12 PM"
        ///</code>
        ///</example>
        public JsString toString(JsNumber value, JsString format) { return null; }

        /// <summary>
        /// A range of useful supported by the current browser capabilities and features.
        /// </summary>
        public class Support
        {
            /// <summary>
            /// Return true if the browser supports touch events.
            /// </summary>
            public bool touch { get; set; }

            /// <summary>
            /// Return true if the browser supports pointer events (IE10 and Metro apps currently).
            /// </summary>
            public bool pointers { get; set; }

            /// <summary>
            /// Checks for the browser scrollbar width, returns scrollbar width in pixels, 0 if no scrollbars available (e.g. in mobile).
            /// </summary>
            public JsFunction scrollbar { get; set; }

            /// <summary>
            /// Return true if the browser supports 3D transitions and transforms.
            /// </summary>
            public bool hasHW3D { get; set; }

            /// <summary>
            /// Returns true if the browser supports overflow-scrolling CSS property (currently only iOS 5+).
            /// </summary>
            public bool hasNativeScrolling { get; set; }

            /// <summary>
            /// (default: 1) Returns the current device Device to Pixel Ratio - works only in Android.
            /// </summary>
            public JsNumber devicePixelRatio { get; set; }

            /// <summary>
            /// Retruns true if the browser supports input placeholders.
            /// </summary>
            public bool placeHolder { get; set; }

            /// <summary>
            /// (default: 1) Returns the current zoom level on a mobile browser (returns 1 on desktop).
            /// </summary>
            public JsNumber zoomLevel { get; set; }

            /// <summary>
            /// Returns a number of browser specific transformation properties
            /// </summary>
            public class Transforms
            {
                /// <summary>
                /// Returns the CSS prefix of the current browser proprietary transform properties. E.g. "-webkit-", "-moz-", "-o-", "-ms-"
                /// </summary>
                public JsString css  { get; set; }

                /// <summary>
                /// Returns the JavaScript prefix of the current browser proprietary transform properties. E.g. "webkit", "Moz", "O", "ms"
                /// </summary>
                public JsString prefix { get; set; }
            }
            /// <summary>
            /// Returns a number of browser specific transformation properties
            /// </summary>
            public Transforms transforms { get; set; }

            /// <summary>
            /// Returns a number of browser specific transition properties
            /// </summary>
            public class Transitions
            {
                /// <summary>
                /// Returns the CSS prefix of the current browser proprietary transform properties. E.g. "-webkit-", "-moz-", "-o-", "-ms-"
                /// </summary>
                public JsString css { get; set; }

                /// <summary>
                /// Returns the JavaScript prefix of the current browser proprietary transform properties. E.g. "webkit", "Moz", "O", "ms"
                /// </summary>
                public JsString prefix { get; set; }

                /// <summary>
                /// Returns the transition end event name in the current browser. E.g. "webkitTransitionEnd", "transitionend", "oTransitionEnd"
                /// </summary>
                public JsString @event  { get; set; }

            }
            /// <summary>
            /// Returns a number of browser specific transition properties
            /// </summary>
            public Transitions transitions { get; set; }

            /// <summary>
            /// Returns a number of properties that identify the current mobile browser. Parses navigator.userAgent to do it. Undefined on desktop.
            /// </summary>
            public class MobileOS
            {
                /// <summary>
                /// Returns the current mobile device identificator, can be "fire", "android", "iphone", "ipad", "meego", "webos", "blackberry", "playbook", "winphone", "windows".
                /// </summary>
                public DeviceIdentificator device { get; set; }

                /// <summary>
                /// Returns the current tablet identificator or false if the current device is not a tablet, can be "fire", "ipad", "playbook" or false.
                /// </summary>
                public TabletIdentificator tablet { get; set; }

                /// <summary>
                /// Returns the current browser identificator or "default" if the browser is the native one, can be "omini", "omobile", "firefox", "mobilesafari", "webkit", "ie", "default".
                /// </summary>
                public BrowserIdentificator browser { get; set; }

                /// <summary>
                /// Returns the current os name identificator, can be "ios", "android", "blackberry", "windows", "webos", "meego".]
                /// For convenience a property with the os name is also initialized, for instance:
                /// </summary>
                public NameIdentificator name { get; set; }

                /// <summary>
                /// The current OS major version, e.g. "5" in iOS 5.1.
                /// </summary>
                public JsString majorVersion { get; set; }

                /// <summary>
                /// The current OS minor versions, e.g. "1.1" in iOS 5.1.1.
                /// </summary>
                public JsString minorVersion { get; set; }

                /// <summary>
                /// A convenience property to allow easier version checks, for instance:
                /// </summary>
                public JsNumber flatVersion { get; set; }

                /// <summary>
                /// Returns true if running in application mode - pinned to desktop in iOS or running in PhoneGap/WebView.
                /// </summary>
                public bool appMode { get; set; }
            }
            /// <summary>
            /// Returns a number of properties that identify the current mobile browser. Parses navigator.userAgent to do it. Undefined on desktop.
            /// </summary>
            public MobileOS mobileOS { get; set; }
        }
        /// <summary>
        /// A range of useful supported by the current browser capabilities and features.
        /// </summary>
        public Support support { get; set; }
        //TODO: really complicated. danel must check all support class

        /// <summary>
        /// Unbinds a tree of HTML elements from a View-Model.
        /// </summary>
        /// <param name="element">The root element(s) from which the unbinding starts.
        /// Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed.</param>
        /// <example>
        /// usage
        /// <code>
        /// kendo.unbind($("body"));
        /// </code>
        /// </example>
        public void unbind (JsString element) {}
        /// <summary>
        /// Unbinds a tree of HTML elements from a View-Model.
        /// </summary>
        /// <param name="element">The root element(s) from which the unbinding starts.
        /// Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed.</param>
        /// <example>
        /// usage
        /// <code>
        /// kendo.unbind($("body"));
        /// </code>
        /// </example>
        public void unbind (jQuery.jQuery element) {}
        /// <summary>
        /// Unbinds a tree of HTML elements from a View-Model.
        /// </summary>
        /// <param name="element">The root element(s) from which the unbinding starts.
        /// Can be a valid jQuery string selector, a DOM element or a jQuery object. All child elements are traversed.</param>
        /// <example>
        /// usage
        /// <code>
        /// kendo.unbind($("body"));
        /// </code>
        /// </example>
        public void unbind (HtmlElement element) {}



    }
    public class ObservableObject
    {
        /// <summary>
        /// Attaches an event handler for the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="handler">The function which will be invoked when the event is raised.</param>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ name: "John Doe" });
        ///observable.bind("change", function(e) {
        ///    console.log(e.field); // will output the changed field once the event is raised
        ///});
        ///observable.set("name", "Jane Doe"); // raises the "change" event and the handler outputs "name"
        ///        ///</code>
        ///</example>
        public void bind (JsString eventName, JsFunction handler) {}

        /// <summary>
        /// Gets the value of the specified field.
        /// </summary>
        /// <param name="name">The name of the field whose value is going to be returned.</param>
        /// <returns></returns>
        public object get(JsString name) {return null;}

        /// <summary>
        /// Returns the parent ObservableObject. If the current ObservableObject is not nested returns undefined;
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ person: { name: "John Doe" } });
        ///var person = observable.get("person");
        ///console.log(observable.parent()); // outputs "undefined"
        ///console.log(person.parent() === observable); // outputs "true"
        ///</code>
        ///</example>
        public ObservableObject parent () {return null;}

        /// <summary>
        /// Sets the value of the specified field.
        /// </summary>
        /// <param name="name">The name of the field whose value is going to be returned.</param>
        /// <param name="value">The new value of the field.</param>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ name: "John Doe" });
        ///observable.set("name", "Jane Doe"); // set the value
        ///console.log(observable.get("name")); //outputs the new value "Jane Doe"
        ///</code>
        ///</example>
        public void set (JsString name, JsNumber value ) {}
        /// <summary>
        /// Sets the value of the specified field.
        /// </summary>
        /// <param name="name">The name of the field whose value is going to be returned.</param>
        /// <param name="value">The new value of the field.</param>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ name: "John Doe" });
        ///observable.set("name", "Jane Doe"); // set the value
        ///console.log(observable.get("name")); //outputs the new value "Jane Doe"
        ///</code>
        ///</example>
        public void set (JsString name, JsString value ) {}
        /// <summary>
        /// Sets the value of the specified field.
        /// </summary>
        /// <param name="name">The name of the field whose value is going to be returned.</param>
        /// <param name="value">The new value of the field.</param>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ name: "John Doe" });
        ///observable.set("name", "Jane Doe"); // set the value
        ///console.log(observable.get("name")); //outputs the new value "Jane Doe"
        ///</code>
        ///</example>
        public void set (JsString name, JsDate value ) {}
        /// <summary>
        /// Sets the value of the specified field.
        /// </summary>
        /// <param name="name">The name of the field whose value is going to be returned.</param>
        /// <param name="value">The new value of the field.</param>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ name: "John Doe" });
        ///observable.set("name", "Jane Doe"); // set the value
        ///console.log(observable.get("name")); //outputs the new value "Jane Doe"
        ///</code>
        ///</example>
        public void set (JsString name, object value ) {}

        /// <summary>
        /// Creates a plain JavaScript object which contains all fields of the ObservableObject.
        /// </summary>
        /// <returns>An Object which contains only the fields of the ObservableObject.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ person: { name: "John Doe" } });
        ///var json = observable.toJSON();
        ///console.log(JSON.stringify(json)); // outputs {"person":{"name":"John Doe"}}
        ///</code>
        ///</example>
        public object toJSON () {return null;}

    }
    //TODO: Configuration, Fields, Events

    public class KendoObjectOptions
    {
        /// <summary>
        /// The name of the parameter used by the generated function. Useful when useWithBlock is set to false.
        /// </summary>
        public JsString paramName  { get; set; }
        /// <summary>
        /// Wraps the generated code in a with block.
        /// This allows the usage of unqualified fields in the template. Disabling the with block will improve the performance of the template.
        /// </summary>
        public bool useWithBlock  { get; set; }
    }
    //TODO: fix all objectOptions and create new ObjectOptions for eace class

    public enum DeviceIdentificator
    {
        fire,
        android,
        iphone,
        ipad,
        meego,
        webos,
        blackberry,
        playbook,
        winphone,
        windows,
    }
    public enum TabletIdentificator
    {
        fire,
        ipad,
        playbook,
        //false,
    }
    public enum BrowserIdentificator
    {
        omini,
        omobile,
        firefox,
        mobilesafari,
        webkit,
        ie,
        @default,
    }
    public enum NameIdentificator
    {
        ios,
        android,
        blackberry,
        windows,
        webos,
        meego,
    }

    public class DataSource
    {
        /// <summary>
        /// Adds a new Model instance to the DataSource
        /// </summary>
        /// <param name="model">Either a Model instance or raw object from which the Model will be created</param>
        /// <returns>The Model instance which has been added</returns>
        public object add(object model) { return null; }

        /// <summary>
        /// Get current aggregate descriptors or applies aggregates to the data.
        /// </summary>
        /// <param name="val">Aggregate(s) to be applied to the data.</param>
        /// <returns>Current aggregate descriptors</returns>
        ///<example>
        ///usage
        ///<code>
        ///dataSource.aggregate({ field: "orderId", aggregate: "sum" });
        ///</code>
        ///</example>
        public JsArray aggregate(object val) { return null; }
        /// <summary>
        /// Get current aggregate descriptors or applies aggregates to the data.
        /// </summary>
        /// <param name="val">Aggregate(s) to be applied to the data.</param>
        /// <returns>Current aggregate descriptors</returns>
        ///<example>
        ///usage
        ///<code>
        ///dataSource.aggregate({ field: "orderId", aggregate: "sum" });
        ///</code>
        ///</example>
        public JsArray aggregate(JsArray val) { return null; }

        /// <summary>
        /// Get result of aggregates calculation
        /// </summary>
        /// <returns>Array Aggregates result</returns>
        public JsArray aggregates() { return null; }

        /// <summary>
        /// Returns the raw data record at the specified index
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // returns the 4th item in the collection
        /// var order = dataSource.at(3);
        ///</code>
        ///</example>
        public object at(JsNumber index) { return null; }

        /// <summary>
        /// Cancel the changes made to the DataSource after the last sync. Any changes currently existing in the model will be discarded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // we have updated 2 items and deleted 1. All of those changes will be discarded.
        /// dataSource.cancelChanges();
        ///</code>
        ///</example>
        public void cancelChanges() { }
        //TODO: model ``

        /// <summary>
        /// Gets or sets the data of the DataSource.
        /// </summary>
        /// <param name="value">An Array of items to set as the current data of the DataSource. If omitted the current data will be returned.</param>
        /// <returns>An ObservableArray which contains all items of the DataSource</returns>
        ///<example>
        ///usage
        ///<code>
        /// //Getting the Data of a DataSource:
        /// var data = dataSource.data();
        ///for (var i = 0; i &lt; data.length; i++) {
        ///    var dataItem = data[i];
        ///    // use the dataItem
        ///}
        /// //Setting the Data of a DataSource:
        /// var data = [ { name: "John Doe" } ];
        /// dataSource.data(data);
        ///</code>
        ///</example>
        public ObservableObject data(JsArray value) { return null; }

        /// <summary>
        /// Fetches data using the current filter/sort/group/paging information.
        /// If data is not available or remote operations are enabled data is requested through the transport, otherwise operations are executed over the available data.
        /// </summary>
        /// <param name="callback"></param>
        public delegate void fetch();
        //TODO: callback ``

        /// <summary>
        /// Get current filters or filter the data.
        /// </summary>
        /// <param name="val">Supported filter operators/aliases are:
        ///Equal To
        ///"eq", "==", "isequalto", "equals", "equalto", "equal"
        ///Not Equal To
        ///"neq", "!=", "isnotequalto", "notequals", "notequalto", "notequal", "ne"
        ///Less Then
        ///"lt", "&lt;", "islessthan", "lessthan", "less"
        ///Less Then or Equal To
        ///"lte", "&lt;=", "islessthanorequalto", "lessthanequal", "le"
        ///Greater Then
        ///"gt", ">", "isgreaterthan", "greaterthan", "greater"
        ///Greater Then or Equal To
        ///"gte", ">=", "isgreaterthanorequalto", "greaterthanequal", "ge"
        ///Starts With
        ///"startswith"
        ///Ends With
        ///"endswith"
        ///Contains
        ///"contains", "substringof"</param>
        /// <returns>Current filter descriptors</returns>
        ///<example>
        ///usage
        ///<code>
        ///dataSource.filter({ field: "orderId", operator: "eq", value: 10428 });
        ///dataSource.filter([
        ///     { field: "orderId", operator: "neq", value: 42 },
        ///     { field: "unitPrice", operator: "ge", value: 3.14 }
        ///]);
        /// // returns data where orderId is equal to 10248 or customerName starts with Paul
        ///dataSource.filter({
        ///    logic: "or",
        ///    filters: [
        ///      { field: "orderId", operator: "eq", value: 10248 },
        ///      { field: "customerName", operator: "startswith", value: "Paul" }
        ///    ]
        ///});
        ///</code>
        ///</example>
        public JsArray filter(object val) { return null; }
        /// <summary>
        /// Get current filters or filter the data.
        /// </summary>
        /// <param name="val">Supported filter operators/aliases are:
        ///Equal To
        ///"eq", "==", "isequalto", "equals", "equalto", "equal"
        ///Not Equal To
        ///"neq", "!=", "isnotequalto", "notequals", "notequalto", "notequal", "ne"
        ///Less Then
        ///"lt", "&lt;", "islessthan", "lessthan", "less"
        ///Less Then or Equal To
        ///"lte", "&lt;=", "islessthanorequalto", "lessthanequal", "le"
        ///Greater Then
        ///"gt", ">", "isgreaterthan", "greaterthan", "greater"
        ///Greater Then or Equal To
        ///"gte", ">=", "isgreaterthanorequalto", "greaterthanequal", "ge"
        ///Starts With
        ///"startswith"
        ///Ends With
        ///"endswith"
        ///Contains
        ///"contains", "substringof"</param>
        /// <returns>Current filter descriptors</returns>
        ///<example>
        ///usage
        ///<code>
        ///dataSource.filter({ field: "orderId", operator: "eq", value: 10428 });
        ///dataSource.filter([
        ///     { field: "orderId", operator: "neq", value: 42 },
        ///     { field: "unitPrice", operator: "ge", value: 3.14 }
        ///]);
        /// // returns data where orderId is equal to 10248 or customerName starts with Paul
        ///dataSource.filter({
        ///    logic: "or",
        ///    filters: [
        ///      { field: "orderId", operator: "eq", value: 10248 },
        ///      { field: "customerName", operator: "startswith", value: "Paul" }
        ///    ]
        ///});
        ///</code>
        ///</example>
        public JsArray filter(JsArray val) { return null; }

        /// <summary>
        /// Retrieves a Model instance by given id.
        /// </summary>
        /// <param name="id">The id of the model to be retrieved</param>
        /// <returns>Model instance if found</returns>
        public object get(JsNumber id) { return null; }

        /// <summary>
        /// Retrieves a Model instance by its UID
        /// </summary>
        /// <param name="uid">The uid of the record to be retrieved</param>
        /// <returns>Model instance if found</returns>
        public object getByUid(JsString uid) { return null; }

        /// <summary>
        /// Get current group descriptors or group the data.
        /// </summary>
        /// <param name="val">_optional, default: _</param>
        /// <returns>Current grouping descriptors</returns>
        public JsArray group(object val) { return null; }
        /// <summary>
        /// Get current group descriptors or group the data.
        /// </summary>
        /// <param name="val">_optional, default: _</param>
        /// <returns>Current grouping descriptors</returns>
        public JsArray group(JsArray val) { return null; }

        /// <summary>
        /// Inserts a new Model instance to the DataSource.
        /// </summary>
        /// <param name="index">Index at which the Model will be inserted</param>
        /// <param name="model">Either a Model instance or raw object from which the Model will be created</param>
        /// <returns>The Model instance which has been inserted</returns>
        ///<example>
        ///usage
        ///<code>
        ///var model = kendo.data.Model.extend({
        ///    id: "orderId",
        ///    fields: {
        ///        name: "customerName",
        ///        description: "orderDescription",
        ///        address: "customerAddress"
        ///    }
        ///});
        /// // insert a new model item at the very front of the collection
        ///dataSource.insert(0, { name: "John Smith", description: "Product Description", address: "123 1st Street" });
        ///</code>
        ///</example>
        public object insert(JsNumber index, object model) { return null; }

        /// <summary>
        /// Get current page index or request a page with specified index.
        /// </summary>
        /// <param name="val">_optional, default: _</param>
        /// <returns>Current page index</returns>
        ///<example>
        ///usage
        ///<code>
        ///dataSource.page(2);
        ///</code>
        ///</example>
        public JsNumber page(JsNumber val) { return null; }

        /// <summary>
        /// Get current pageSize or request a page with specified number of records.
        /// </summary>
        /// <param name="val">_optional, default: _</param>
        /// <returns>Current page size</returns>
        ///<example>
        ///usage
        ///<code>
        ///dataSource.pageSize(25);
        ///</code>
        ///</example>
        public JsNumber pageSize(JsNumber val) { return null; }

        /// <summary>
        /// Executes a query over the data. Available operations are paging, sorting, filtering, grouping.
        /// If data is not available or remote operations are enabled, data is requested through the transport. Otherwise operations are executed over the available data.
        /// </summary>
        /// <param name="options">_optional, default: _</param>
        ///<example>
        ///usage
        ///<code>
        /// // create a view containing at most 20 records, taken from the
        /// // 5th page and sorted ascending by orderId field.
        ///dataSource.query({ page: 5, pageSize: 20, sort: { field: "orderId", dir: "asc" } });
        /// // moves the view to the first page returning at most 20 records
        /// // but without particular ordering.
        ///dataSource.query({ page: 1, pageSize: 20 });
        ///</code>
        ///</example>
        public void query(KendoObjectOptions options) { }

        /// <summary>
        /// Read the data into the DataSource using the transport read definition
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        read: "orders.json";
        ///    }
        ///});
        /// // the datasource will not contain any data until a read is called
        ///dataSource.read();
        ///</code>
        ///</example>
        public void read() { }
        //TODO: data ``

        /// <summary>
        /// Remove given Model instance from the DataSource.
        /// </summary>
        /// <param name="model">Model instance to be removed</param>
        ///<example>
        ///usage
        ///<code>
        /// // get the model item with an id of 1 from the DataSource
        ///var itemToRemove = dataSource.get(1);
        /// // remove the item from the DataSource
        ///dataSource.remove(itemToRemove);
        ///</code>
        ///</example>
        public void remove(object model) { }

        /// <summary>
        /// Get current sort descriptors or sorts the data.
        /// </summary>
        /// <param name="val">_optional, default: _</param>
        /// <returns>Current sort descriptors</returns>
        ///<example>
        ///usage
        ///<code>
        ///dataSource.sort({ field: "orderId", dir: "desc" });
        ///dataSource.sort([
        ///     { field: "orderId", dir: "desc" },
        ///     { field: "unitPrice", dir: "asc" }
        ///]);
        ///</code>
        ///</example>
        public JsArray sort(object val) { return null; }
        /// <summary>
        /// Get current sort descriptors or sorts the data.
        /// </summary>
        /// <param name="val">_optional, default: _</param>
        /// <returns>Current sort descriptors</returns>
        ///<example>
        ///usage
        ///<code>
        ///dataSource.sort({ field: "orderId", dir: "desc" });
        ///dataSource.sort([
        ///     { field: "orderId", dir: "desc" },
        ///     { field: "unitPrice", dir: "asc" }
        ///]);
        ///</code>
        ///</example>
        public JsArray sort(JsArray val) { return null; }

        /// <summary>
        /// Synchronizes changes through the transport. Any pending CRUD operations will be sent to the server.
        /// If the DataSource is in batch mode, only one call will be made for each type of operation.
        /// Otherwise, the DataSource will send one command per pending item change per change type.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // we have deleted 2 items and updated 1. If not in batch mode, this will send three commands to the server
        ///dataSource.sync();
        ///</code>
        ///</example>
        public void sync() { }

        /// <summary>
        /// Get the total number of records
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var total = dataSource.total();
        ///</code>
        ///</example>
        public void total() { }

        /// <summary>
        /// Get the number of available pages.
        /// </summary>
        /// <returns>Number of available pages</returns>
        ///<example>
        ///usage
        ///<code>
        ///var total = dataSource.total();
        ///</code>
        ///</example>
        public JsNumber totalPages() { return null; }

        /// <summary>
        /// Returns a view of the data with operation such as in-memory sorting, paring, grouping and filtering are applied.
        /// To ensure that data is available this method should be use from within change event of the dataSource.
        /// </summary>
        /// <returns>Array of items</returns>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        read: "orders.json"
        ///    }
        ///    change: function(e) {
        ///       // create a template instance
        ///       var template = kendo.template($("#template").html());
        ///       // render a view by passing the data to a template
        ///       kendo.render(template, dataSource.view());
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsArray view() { return null; }
    }
    //TODO: Configuration, Events

    /// <summary>
    /// See the DataSource methods for all inherited methods.
    /// The remove and getByUid methods are overridden and work with the hierarchical data (they will act on all child datasources that have been read).
    /// </summary>
    public class HierarchicalDataSource : DataSource
    {
    }
    //TODO: Configuration, Events

    /// <summary>
    /// The Model inherits from the ObservableObject and extends it with the ability to define schema - fields and methods.
    /// The DataSource contains instances of the Model when the schema.model setting is specified.
    /// </summary>
    public class Model : ObservableObject
    {
        /// <summary>
        /// Defines a new Model type using the provided options.
        /// </summary>
        /// <param name="options">Describes the configuration options of the new model type.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var Product = kendo.data.Model.define( {
        ///id: "id", // the identifier is the "id" field (declared below)
        ///fields: {
        ///    /* name of the field */ name: {
        ///        type: "string", // the field is a string
        ///        validation: { // validation rules
        ///            required: true // the field is required
        ///        },
        ///        defaultValue: "&lt:empty>" // default field value
        ///    },
        ///    /* name of the field */ price: {
        ///        type: "number", // the field is a number
        ///        validation: { // validation rules
        ///            required: true, // the field is required
        ///            min: 1 // the minimum value is 1
        ///        },
        ///        defaultValue: 99.99 // default field value
        ///    },
        ///    /* name of the field */ id: {
        ///        editable: false, // this field is not editable
        ///        nullable: true // a default value will not be assigned
        ///    }
        ///}
        ///</code>
        ///</example>
        public static Model define(ModelObjectOptions options) { return null; }

        /// <summary>
        /// Determines if the specified field is editable or not.
        /// </summary>
        /// <param name="field">The field to check.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var Product = kendo.data.Model.define({
        ///    fields: {
        ///        id: {
        ///            editable: false
        ///        },
        ///        name: {
        ///            editable: true
        ///        }
        ///    }
        ///});
        ///var product = new Product();
        ///console.log(product.editable("id")); // outputs "false"
        ///console.log(product.editable("name")); // outputs "true"
        ///</code>
        ///</example>
        public bool editable(JsString field) { return false; }

        /// <summary>
        /// Checks if the Model is new or not. The id field is used to determine if a model instance is new or existing one.
        /// If the value of the field specified is equal to the default value (specifed through the fields configuration) the model is considered as new.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var Product = kendo.data.Model.define({
        ///    id: "productId",
        ///    fields: {
        ///        productId: {
        ///            editable: false
        ///        }
        ///    }
        ///});
        ///var productOne = new Product();
        ///console.log(productOne.isNew()); // outputs "true"
        ///var productTwo = new Product({ productId: 1 });
        ///console.log(productTwo.isNew()); // outputs "false" because productId is set to 1
        ///</code>
        ///</example>
        public bool isNew() { return false; }
    }
    //TODO: Configuration, Fields, Events

    public class FieldConfig
    {
        /// <summary>
        /// Specifies the which will be used for the field when a new model instance is created.
        /// Default settings depend on the type of the field. Default for "string" is "", for "number" is 0 and for "date" is new Date() (today).
        /// </summary>
        public JsString defaultValue { get; set; }
        //TODO: type can be string number or date

        /// <summary>
        /// Specifies if the field is editable or not. The default value is true.
        /// </summary>
        public bool editable { get; set; }
        /// <summary>
        /// Specifies if the defaultValue setting should be used. The default is false.
        /// </summary>
        public bool nullable  { get; set; }

        /// <summary>
        /// Specifies the function which will parse the field value. If not set default parsers will be used.
        /// </summary>
        public JsFunction parse { get; set; }

        /// <summary>
        /// Specifies the the type of the field. The available options are "string", "number", "boolean", "date". The default is "string".
        /// </summary>
        public JsString type  { get; set; }
        //TODO: type can be string number bool or date

        /// <summary>
        /// Specifies the validation options which will be used by Kendo Validator.
        /// </summary>
        public object validation { get; set; }


    }

    public class ModelObjectOptions
    {
        /// <summary>
        /// The name of the field which acts as an identifier of the model. The identifier is used to determine if a model instance is new or existing one.
        /// If the value of the field specified is equal to the default value (specifed through the fields configuration) the model is considered as new.
        /// </summary>
        public JsString id { get; set; }

        public JsObject<FieldConfig> fields { get; set; }
    }

    /// <summary>
    /// The ObservableArray wrap an existing Array object with change tracking capabilities. It is used by Kendo MVVM and the Kendo DataSource.
    /// </summary>
    public class ObservableArray
    {
        /// <summary>
        /// Attaches an event handler for the specified event.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="handler">The function which will be invoked when the event is raised.</param>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ name: "John Doe" });
        ///observable.bind("change", function(e) {
        ///    console.log(e.field); // will output the changed field once the event is raised
        ///});
        ///observable.set("name", "Jane Doe"); // raises the "change" event and the handler outputs "name"
        ///        ///</code>
        ///</example>
        public void bind(JsString eventName, JsFunction handler) { }

        /// <summary>
        /// Joins all items of an ObservableArray into a string. Equivalent of Array.prototype.join.
        /// </summary>
        /// <param name="separator">Specifies the string to separate each item of the array. If omitted the array items are separated with a comma (,)</param>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([1, 2, 3]);
        ///console.log(array.join("-")); // outputs "1-2-3"
        ///</code>
        ///</example>
        public void join(JsString separator) { }

        /// <summary>
        /// Returns the parent ObservableObject. If the current ObservableArray is not nested returns undefined.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([1, 2]);
        ///console.log(array.parent()); // outputs "undefined"
        ///var observable = kendo.observable({ numbers: [1, 2] });
        ///var numbers = observable.get("numbers");
        ///console.log(numbersperson.parent() === observable); // outputs "true"
        ///</code>
        ///</example>
        public ObservableObject parent() { return null; }

        /// <summary>
        /// Removes the last item from an array and returns that item. Equivalent of Array.prototype.pop.
        /// Important: The pop method raises the change event. The action field of the event argument is set to "remove". The items field of the event argument is the array that contains the removed item.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([{ name: "John Doe" }]);
        ///var result = array.pop();
        ///console.log(array.length); // outputs "0"
        ///console.log(result.get("name")); // outputs "John Doe"
        ///</code>
        ///</example>
        public object pop() { return null; }

        /// <summary>
        /// Appends the given items to the array and returns the new length of the array.
        /// Equivalent of Array.prototype.push. The new items are wrapped as ObservableObject if they are complex objects.
        /// Important: The push method raises the change event. The action field of the event argument is set to "add". The items field of the event argument is the array that contains the appended items.
        /// </summary>
        /// <param name="item1">The item(s) to append to the array.</param>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([{ name: "John Doe" }]);
        ///var length = array.push({ name: "Jane Doe" });
        ///console.log(length); // outputs "2"
        ///console.log(array[1] instanceof kendo.data.ObservableObject); // outputs "true"
        ///console.log(array[1].get("name")); // outputs "Jane Doe"
        ///</code>
        ///</example>
        public void push(object item1) { }
        /// <summary>
        /// Appends the given items to the array and returns the new length of the array.
        /// Equivalent of Array.prototype.push. The new items are wrapped as ObservableObject if they are complex objects.
        /// Important: The push method raises the change event. The action field of the event argument is set to "add". The items field of the event argument is the array that contains the appended items.
        /// </summary>
        /// <param name="item1">The item(s) to append to the array.</param>
        /// <param name="item2">The item(s) to append to the array.</param>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([{ name: "John Doe" }]);
        ///var length = array.push({ name: "Jane Doe" });
        ///console.log(length); // outputs "2"
        ///console.log(array[1] instanceof kendo.data.ObservableObject); // outputs "true"
        ///console.log(array[1].get("name")); // outputs "Jane Doe"
        ///</code>
        ///</example>
        public void push(object item1, object item2) { }
        /// <summary>
        /// Appends the given items to the array and returns the new length of the array.
        /// Equivalent of Array.prototype.push. The new items are wrapped as ObservableObject if they are complex objects.
        /// Important: The push method raises the change event. The action field of the event argument is set to "add". The items field of the event argument is the array that contains the appended items.
        /// </summary>
        /// <param name="item1">The item(s) to append to the array.</param>
        /// <param name="item2">The item(s) to append to the array.</param>
        /// <param name="items">The item(s) to append to the array.</param>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([{ name: "John Doe" }]);
        ///var length = array.push({ name: "Jane Doe" });
        ///console.log(length); // outputs "2"
        ///console.log(array[1] instanceof kendo.data.ObservableObject); // outputs "true"
        ///console.log(array[1].get("name")); // outputs "Jane Doe"
        ///</code>
        ///</example>
        public void push(object item1, object item2, params object[] items) { }

        /// <summary>
        /// Returns a one-level deep copy of a portion of an array. Equivalent of Array.prototype.slice.
        /// The result of the slice method is not an instance of ObvservableArray. It is a regular JavaScript Array object.
        /// Important: The slice method does not modify the original ObservableArray.
        /// </summary>
        /// <param name="begin">Zero-based index at which to begin extraction.</param>
        /// <param name="end">Zero-based index at which to end extraction. If end is omitted, slice extracts to the end of the sequence.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([1, 2, 3]);
        ///var firstAndSecond = array.slice(0, 2);
        ///console.log(firstAndSecond); // outputs [1, 2]
        ///</code>
        ///</example>
        public JsArray slice(JsNumber begin, JsNumber end) { return null; }
        //TODO:end is optional?

        /// <summary>
        /// Changes an ObservableArray, by adding new items while removing old items. Equivalent of Array.prototype.splice
        /// Important: The splice method raises the change event once or twice depending on the change.The action field of the event argument is set to "add" (if items are added) or "remove (if items are removed).
        /// The items field of the event argument is the array that contains the appended items or removed items.
        /// In the above example the change event will be raised two times - first because "baseball" is removed and second because "tennis" and "hockey" are added.
        /// </summary>
        /// <param name="index">Index at which to start changing the array. If negative, will begin that many elements from the end.</param>
        /// <param name="howMany">An integer indicating the number of items to remove. If howMany is 0, no items are removed. In this case, you should specify at least one new item.</param>
        /// <param name="items">The item(s) to append to the array.</param>
        /// <returns>An Array containing the removed items. The result of the splice method is not an instance of ObvservableArray.</returns>
        public JsArray splice(JsNumber index, JsNumber howMany, params object[] items) { return null; }
        //TODO:? are they optional?

        /// <summary>
        /// Removes the first item from an ObvservableArray and returns that item. Equivalent of Array.prototype.shift.
        /// Important: The shift method raises the change event. The action field of the event argument is set to "remove".
        /// The items field of the event argument is an array that contains the removed 
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([1, 2, 3]);
        ///var removed = array.shift();
        ///console.log(removed); // outputs "1"
        ///console.log(array.length); // outputs "2"
        ///</code>
        ///</example>
        public object shift() { return null; }

        /// <summary>
        /// Returns a JavaScript Array which represents the contents of the ObservableArray.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var people = new kendo.data.ObservableArray([ { name: "John Doe" }, { name: "Jane Doe" }]);
        ///var json = people.toJSON();
        ///console.log(JSON.stringify(json)); // outputs [{"name":"John Doe"},{"name":"Jane Doe"}]
        ///</code>
        ///</example>
        public JsArray toJSON() { return null; }

        /// <summary>
        /// Adds one or more items to the beginning of an ObservableArray and returns the new length. Equivalent of Array.prototype.unshift.
        /// Important: The unshift method raises the change event. The action field of the event argument is set to "add". The items field of the event argument is an array that contains the new items.
        /// </summary>
        /// <param name="item1">The item(s) to append to the array.</param>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([2, 3]);
        ///var result = array.unshift(0, 1);
        ///console.log(result); // outputs "4"
        ///console.log(result); // outputs [0, 1, 2, 3]
        ///</code>
        ///</example>
        public void unshift(object item1) { }
        /// <summary>
        /// Adds one or more items to the beginning of an ObservableArray and returns the new length. Equivalent of Array.prototype.unshift.
        /// Important: The unshift method raises the change event. The action field of the event argument is set to "add". The items field of the event argument is an array that contains the new items.
        /// </summary>
        /// <param name="item1">The item(s) to append to the array.</param>
        /// <param name="item2">The item(s) to append to the array.</param>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([2, 3]);
        ///var result = array.unshift(0, 1);
        ///console.log(result); // outputs "4"
        ///console.log(result); // outputs [0, 1, 2, 3]
        ///</code>
        ///</example>
        public void unshift(object item1, object item2) { }
        /// <summary>
        /// Adds one or more items to the beginning of an ObservableArray and returns the new length. Equivalent of Array.prototype.unshift.
        /// Important: The unshift method raises the change event. The action field of the event argument is set to "add". The items field of the event argument is an array that contains the new items.
        /// </summary>
        /// <param name="item1">The item(s) to append to the array.</param>
        /// <param name="item2">The item(s) to append to the array.</param>
        /// <param name="items">The item(s) to append to the array.</param>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([2, 3]);
        ///var result = array.unshift(0, 1);
        ///console.log(result); // outputs "4"
        ///console.log(result); // outputs [0, 1, 2, 3]
        ///</code>
        ///</example>
        public void unshift(object item1, object item2, params object[] items) { }
    }
    //TODO: Configuration, Fields, Events. Make class generic


    public class Drag
    {
        /// <summary>
        /// Discard the current drag. Calling the cancel method will trigger the cancel event. The correct moment to call this method would be in the start event handler.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///new kendo.Drag($("#foo"), {
        /// start: function(e) {
        ///     e.cancel();
        /// }
        ///});
        ///</code>
        ///</example>
        public void cancel() { }

        /// <summary>
        /// Capture the current drag, so that Drag listeners bound to parent elements will not trigger.
        /// This method will not have any effect if the current drag instance is instantiated with the global option set to true.
        /// </summary>
        public void capture() { }
    }
    //TODO: Danel needs to chack

    //TODO: DragAxis

    public class Validator
    {
        /// <summary>
        /// Get the error messages if any.
        /// </summary>
        /// <returns>Messages for the failed validation rules.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the validatable form
        ///var validatable = $("#myform").kendoValidator().data("kendoValidator");
        ///$("#save").click(function() {
        ///    if (validatable.validate() === false) {
        ///        // get the errors and write them out to the "errors" html container
        ///        var errors = validatable.errors();
        ///        $(errors).each(function() {
        ///            $("#errors").html(this);
        ///        });
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsArray errors() { return null; }

        /// <summary>
        /// Validates the input element(s) against the declared validation rules.
        /// </summary>
        /// <returns>Boolean true if all validation rules passed successfully.
        /// Note that if a HTML form element is set as validation container, the form submits will be automatically prevented if validation fails.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the validatable form
        ///var validatable = $("#myform").kendoValidator().data("kendoValidator");
        /// // check validation on save button click
        ///$("#save").click(function() {
        ///    if (validatable.validate()) {
        ///        save();
        ///    }
        ///});
        ///</code>
        ///</example>
        public bool validate() { return false; }

        /// <summary>
        /// Validates the input element against the declared validation rules.
        /// </summary>
        /// <param name="input">Input element to be validated.</param>
        /// <returns>Boolean true if all validation rules passed successfully.</returns>
        public bool validateInput(HtmlElement input) { return false; }
    }
    //TODO: Configuration, kendo.ui.Validator means anything?




}
