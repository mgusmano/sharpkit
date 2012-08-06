using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;
[assembly: JsType(JsMode.Prototype, Export = false)]

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
        public void culture(JsString enGB) { }

        /// <summary>
        /// Sets or gets the current culture. Uses the passed culture name to select a culture from the culture scripts that you have included and then sets the current culture.
        /// If there is no corresponding culture then the method will try to find culture which is equal to the country part of the culture name. If no culture is found the default one is used
        /// </summary>
        /// <param name="enGB"></param>
        public JsString culture() { return null; }


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
        public void unbind(JsString element) { }
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
        public void unbind(jQuery.jQuery element) { }
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
        public void unbind(HtmlElement element) { }



    }

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
            public JsString @event { get; set; }

        }
        /// <summary>
        /// Returns a number of browser specific transition properties
        /// </summary>
        public Transitions transitions { get; set; }

        /// <summary>
        /// Returns a number of properties that identify the current mobile browser. Parses navigator.userAgent to do it. Undefined on desktop.
        /// </summary>
        public MobileOS mobileOS { get; set; }
    }

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
    /// Returns a number of browser specific transformation properties
    /// </summary>
    public class Transforms
    {
        /// <summary>
        /// Returns the CSS prefix of the current browser proprietary transform properties. E.g. "-webkit-", "-moz-", "-o-", "-ms-"
        /// </summary>
        public JsString css { get; set; }

        /// <summary>
        /// Returns the JavaScript prefix of the current browser proprietary transform properties. E.g. "webkit", "Moz", "O", "ms"
        /// </summary>
        public JsString prefix { get; set; }
    }

    public class ObservableObject
    {
        public ObservableObject(object Configurations) { }
        public ObservableObject() { }

        /// <summary>
        /// The unique identifier of the ObservableObject.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var observable = new kendo.data.ObservableObject({ name: "John Doe" });
        ///console.log(observable.uid); // outputs "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" where "x" is a number or letter
        ///</code>
        ///</example>
        public JsString uid { get; set; }

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
        /// Gets the value of the specified field.
        /// </summary>
        /// <param name="name">The name of the field whose value is going to be returned.</param>
        /// <returns></returns>
        public object get(JsString name) { return null; }

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
        public ObservableObject parent() { return null; }

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
        public void set(JsString name, JsNumber value) { }
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
        public void set(JsString name, JsString value) { }
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
        public void set(JsString name, JsDate value) { }
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
        public void set(JsString name, object value) { }

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
        public object toJSON() { return null; }

        /// <summary>
        /// Raised when a field value is updated via the set method.
        /// </summary>
        public event JsAction<ObservableObjectChangeEventData> changeEvent { add { } remove { } }
        //TODO: event name?

        /// <summary>
        /// Raised when the get method is invoked.
        /// </summary>
        public event JsAction<ObservableObjectChangeEventData> getEvent { add { } remove { } }
        //TODO: event name?

        /// <summary>
        /// Raised when the set method is invoked.
        /// The set event is raised before the field value is updated. Calling the get method from the event handler will return the old value.
        /// Calling e.preventDefault will prevent the update of the field and the change event will not be raised.
        /// </summary>
        public event JsAction<ObservableObjectSetEventData> setEvent { add { } remove { } }
        //TODO: event name?

    }
    //TODO:danel chack Events, get/set meth and the Configuration

    public class ObservableObjectChangeEventData
    {
        /// <summary>
        /// The name of the field which has changed.
        /// </summary>
        public JsString field  { get; set; }
    }

    public class ObservableObjectGetEventData
    {
        /// <summary>
        /// The name of the field which is retrieved.
        /// </summary>
        public JsString field { get; set; }
    }
    public class ObservableObjectSetEventData
    {
        /// <summary>
        /// The name of the field which is retrieved.
        /// </summary>
        public JsString field { get; set; }

        /// <summary>
        /// The new value.
        /// </summary>
        public object value { get; set; }
        //TODO: type can be Number|String|Data|Object

        /// <summary>
        /// A function which may prevent the update of the value. Can be used to perform validation.
        /// </summary>
        public JsFunction preventDefault { get; set; }
    }

    public class KendoObjectOptions
    {
        /// <summary>
        /// The name of the parameter used by the generated function. Useful when useWithBlock is set to false.
        /// </summary>
        public JsString paramName { get; set; }
        /// <summary>
        /// Wraps the generated code in a with block.
        /// This allows the usage of unqualified fields in the template. Disabling the with block will improve the performance of the template.
        /// </summary>
        public bool useWithBlock { get; set; }
    }
    //TODO: make sure there are no mistakes with ObjectOptions/KendoObjectOptions

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
        public DataSource() { }

        public DataSource(DataSourceConfiguration DataSourceConfiguration) { }

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

        /// <summary>
        /// Fires when data is changed or read from the transport.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<DataSourceChangeEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when an error occurs during data read or sync. The event arguments are the same as the ones of the error event of $.ajax().
        /// Important: If schema.errors is specified and the server response contains that field then the error event will be raised.
        /// The errors field of the event argument will contain the errors returned by the server.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    error: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<DataSourceErrorEventData> error { add { } remove { } }

        /// <summary>
        /// Fires when data request is to be made.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    requestStart: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<DataSourceRequestStartEventData> requestStart { add { } remove { } }
    }
    public class DataSourceChangeEventData
    {
    }
    //TODO: empty (?) is it ok?
    public class DataSourceErrorEventData
    {
    }
    //TODO: empty (?) is it ok?
    public class DataSourceRequestStartEventData
    {
        /// <summary>
        /// Reference to the dataSource object instance.
        /// </summary>
        public DataSource sender { get; set; }
    }

    public class DataSourceConfiguration
    {
        /// <summary>
        /// Sets fields on which initial aggregates should be calculated
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // calculates total sum of unitPrice field's values.
        ///[{ field: "unitPrice", aggregate: "sum" }]
        ///</code>
        ///</example>
        public object aggregate { get; set; }

        /// <summary>
        /// Specifies the local JavaScript object to use for the data source.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var orders = [ { orderId: 10248, customerName: "Paul Smith" }, { orderId: 10249, customerName: "Jane Jones" }];
        ///var dataSource = new kendo.data.DataSource({
        ///     data: orders
        ///});
        ///</code>
        ///</example>
        public JsArray data { get; set; }

        /// <summary>
        /// Sets initial filter
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // returns only data where orderId is equal to 10248
        ///filter: { field: "orderId", operator: "eq", value: 10248 }
        /// // returns only data where orderId is equal to 10248 and customerName starts with Paul
        ///filter: [ { field: "orderId", operator: "eq", value: 10248 },
        ///          { field: "customerName", operator: "startswith", value: "Paul" } ]
        /// // returns data where orderId is equal to 10248 or customerName starts with Paul
        ///filter: {
        ///    logic: "or",
        ///    filters: [
        ///      { field: "orderId", operator: "eq", value: 10248 },
        ///      { field: "customerName", operator: "startswith", value: "Paul" }
        ///    ]
        ///}
        ///</code>
        ///</example>
        public object filter { get; set; }

        /// <summary>
        /// Sets initial grouping
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // groups data by orderId field
        ///group: { field: "orderId" }
        /// // groups data by orderId and customerName fields
        ///group: [ { field: "orderId", dir: "desc" }, { field: "customerName", dir: "asc" } ]
        ///</code>
        ///</example>
        public object group { get; set; }

        /// <summary>
        /// Sets the index of the displayed page of data.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    page: 2 // displays the second page of data in the bound widget
        ///});
        ///</code>
        ///</example>
        public JsNumber page { get; set; }

        /// <summary>
        /// Sets the number of records which contains a given page of data.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    pageSize: 5 // 5 records per page of data
        ///});
        ///</code>
        ///</example>
        public JsNumber pageSize { get; set; }

        /// <summary>
        /// Set the object responsible for describing the raw data format.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///     transport: {
        ///         read: "Catalog/Titles",
        ///     },
        ///     schema: {
        ///         errors: function(response) {
        ///            return response.errors;
        ///         },
        ///         aggregates: function(response) {
        ///            response.aggregates;
        ///         },
        ///         data: function(response) {
        ///             return response.data;
        ///         },
        ///         total: function(response) {
        ///             return response.totalCount;
        ///         },
        ///         parse: function(response) {
        ///             return response.data;
        ///         }
        ///     }
        ///});
        ///</code>
        ///</example>
        public DataSourceSchemaConfiguration schema { get; set; }


        /// <summary>
        /// Determines if aggregates are calculated on the server or not. By default aggregates are calculated client-side.(default: false)
        /// Important: When serverAggregates is set to true the developer is responsible for calculating the aggregate results.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        read: "/orders"
        ///    },
        ///    serverAggregates: true,
        ///    aggregate: { field: "orderId", operator: "eq", value: 10248 } // return only data where orderId equals 10248
        ///});
        ///</code>
        ///</example>
        public bool serverAggregates { get; set; }

        /// <summary>
        /// Determines if filtering of the data is handled on the server. By default filtering is performed client-side.
        /// Important: When serverFiltering is set to true the developer is responsible for filtering the data.
        /// By default, a filter object is sent to the server with the query string in the following form:
        ///filter[logic]: and
        ///filter[filters][0][field]: orderId
        ///filter[filters][0][operator]: desc
        ///filter[filters][0][value]: 10248
        ///Possible values for operator include:
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
        ///"contains"
        ///It is possible to modify these parameters by using the parameterMap function found in the transport.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        read: "/orders"
        ///    },
        ///    serverFiltering: true,
        ///    filter: { field: "orderId", operator: "eq", value: 10248 } // return only data where orderId equals 10248
        ///});
        ///</code>
        ///</example>
        public bool serverFiltering { get; set; }

        /// <summary>
        /// Determines if grouping of the data is handled on the server. By default grouping is performed client-side.
        /// Important: When serverGrouping is set to true the developer is responsible for grouping the data.
        /// By default, a group object is sent to the server with the query string in the following form:
        ///group[0][field]: orderId
        ///group[0][dir]: desc
        ///It is possible to modify these parameters by using the parameterMap function found on the transport.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        read: "/orders"
        ///    },
        ///    serverGrouping: true,
        ///    sort: { field: "orderId", dir: "asc" } // group by orderId descending
        ///});
        ///</code>
        ///</example>
        public bool serverGrouping { get; set; }

        /// <summary>
        /// Determines if paging of the data is on the server. By default paging is performed client-side.
        /// If serverPaging is enabled the total number of data items should also be returned in the response. Use the schema.total setting to customize that.
        /// Important: When serverPaging is set to true the developer is responsible for paging the data.
        /// The following options are sent to the server as part of the query string by default:
        ///take
        ///contains the number of records to retreive
        ///skip
        ///how many records from the front of the dataset to begin reading
        ///page
        ///the index of the current page of data
        ///pageSize
        ///the number of records per page
        ///It is possible to modify these parameters by using the parameterMap function found on the transport.
        /// </summary>]
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        read: "/orders"
        ///    },
        ///    serverPaging: true,
        ///    pageSize: 5 // 5 records per page
        ///});
        ///</code>
        ///</example>
        public bool serverPaging { get; set; }

        /// <summary>
        /// Determines if sorting of the data should is handled on the server. By default sorting is performed client-side.
        /// Important: When serverSorting is set to true the developer is responsible for sorting the data.
        /// By default, a sort object is sent to the server with the query string in the following form:
        ///sort[0][field]: orderId
        ///sort[0][dir]: asc
        ///It is possible to modify these parameters by using the parameterMap function found on the transport.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        read: "/orders"
        ///    },
        ///    serverSorting: true,
        ///    sort: { field: "orderId", dir: "asc" }
        ///});
        ///</code>
        ///</example>
        public bool serverSorting { get; set; }

        /// <summary>
        /// Sets initial sort order
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // sorts data ascending by orderId field
        ///sort: { field: "orderId", dir: "asc" }
        /// // sorts data ascending by orderId field and then descending by shipmentDate
        ///sort: [ { field: "orderId", dir: "asc" }, { field: "shipmentDate", dir: "desc" } ]
        ///</code>
        ///</example>
        public object sort { get; set; }

        /// <summary>
        /// Specifies the settings for loading and saving data. This can be a remote or local/in-memory data.
        /// </summary>
        public object transport { get; set; }


        /// <summary>
        /// Loads transport with preconfigured settings. Currently supports only "odata" (Requires kendo.data.odata.js to be included).
        /// </summary>
        public JsString type { get; set; }


    }

    public class DataSourceSchemaConfiguration
    {
        /// <summary>
        /// Specifies the field from the response which contains the aggregate results.
        /// If set to a function - the function will be called to return the aggregate results for the current response.
        /// Result should have the following format:
        /// {
        ///FIEL1DNAME: {
        ///    FUNCTON1NAME: FUNCTION1VALUE,
        ///    FUNCTON2NAME: FUNCTION2VALUE
        ///},
        ///FIELD2NAME: {
        ///    FUNCTON1NAME: FUNCTION1VALUE
        ///}
        ///}
        ///i.e.:
        ///{
        ///unitPrice: {
        ///max: 100,
        ///min: 1
        ///},
        ///productName: {
        ///count: 42
        ///}
        ///}
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///schema: {
        ///    aggregates: "aggregates" // aggregate results are returned in the "aggregates" field of the response
        ///}
        ///</code>
        ///</example>
        public object aggregates { get; set; }
        //TODO: type can be string or function

        /// <summary>
        /// Specifies the field from the response which contains the data items.
        /// If set to a function - the function will be called to return the data items for the current response.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///schema: {
        ///    data: "items" // data items are returned in the "items" field of the response
        ///}
        ///</code>
        ///</example>
        public object data { get; set; }
        //TODO: Returns An Array which contains the data items from the response.

        /// <summary>
        /// Specifies the field from the response which contains any errors. If set to a function - the function will be called to return the errors for the current response (if present).
        /// If there are any errors the error event of the DataSource will be raised.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///schema: {
        ///    errors: "exceptions" // errors are returned in the "exceptions" field of the response
        ///}
        ///</code>
        ///</example>
        public object errors { get; set; }

        /// <summary>
        /// Specifies the field from the response which contains the groups. If set to a function - the function will be called to return the groups for the current response.
        ///Used instead of the schema.data setting if remote grouping operation is executed.
        ///The result should have the following format:
        ///[{
        ///  aggregates: {
        ///      FIEL1DNAME: {
        ///          FUNCTON1NAME: FUNCTION1VALUE,
        ///          FUNCTON2NAME: FUNCTION2VALUE
        ///      },
        ///      FIELD2NAME: {
        ///          FUNCTON1NAME: FUNCTION1VALUE
        ///      }
        ///  },
        ///  field: FIELDNAME, // the field name on which is grouped
        ///  hasSubgroups: true, // false if there are not sub group items and this is the top most group
        ///  items: [
        ///  // either the inner group items (if hasSubgroups is true) or the data records
        ///     {
        ///         aggregates: {
        ///             //nested group aggregates
        ///         },
        ///         field: NESTEDGROUPFIELDNAME,
        ///         hasSubgroups: false,
        ///         items: [
        ///         // data records
        ///         ],
        ///         value: NESTEDGROUPVALUE
        ///     },
        ///     //nestedgroup2, nestedgroup3, etc.
        ///  ],
        ///  value: VALUE // value of the field on which is grouped
        ///}
        /// // group2, group3, etc.
        ///]
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///schema: {
        ///    groups: "groups" // groups are returned in the "groups" field of the response
        ///}
        ///</code>
        ///</example>
        public object groups { get; set; }
        //TODO: type can be string or function

        /// <summary>
        /// Describes the Model of the DataSource. If set to Object the Model.define method will be used to create the model.
        /// Check the documentation of Model.define for the available configuration options.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///     schema: {
        ///         model: {
        ///             id: "ProductID",
        ///             fields: {
        ///                  ProductID: {
        ///                     //this field will not be editable (default value is true)
        ///                     editable: false,
        ///                     // a defaultValue will not be assigned (default value is false)
        ///                     nullable: true
        ///                  },
        ///                  ProductName: {
        ///                      validation: { //set validation rules
        ///                          required: true
        ///                      }
        ///                  },
        ///                  UnitPrice: {
        ///                    //data type of the field {Number|String|Boolean|Date} default is String
        ///                    type: "number",
        ///                    // used when new model is created
        ///                    defaultValue: 42,
        ///                    validation: {
        ///                        required: true,
        ///                        min: 1
        ///                    }
        ///                }
        ///            }
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public Model model { get; set; }

        /// <summary>
        /// Executed before the server response is used. Appropriate for preprocessing or parsing of the server response.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///schema: {
        ///    parse: function(response) {
        ///        // perform some processing over the response
        ///        return processResponse(response);
        ///    }
        ///}
        ///</code>
        ///</example>
        public JsFunction parse { get; set; }

        /// <summary>
        /// Specifies the field from the response which contains the total number of data items.
        /// If set to a function - the function will be called to return the total number of data items for the current response.
        /// Note: If schema.total is not specified the length of the Array returned by schema.data will be used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///schema: {
        ///    total: "count" // total number of data items is returned in the "count" field of the response
        ///}
        ///</code>
        ///</example>
        public object total { get; set; }
        //TODO: Returns A Number which denotes the total number of data items.

        /// <summary>
        /// Specify the type of the response - XML or JSON. The only supported values are "xml" and "json".(default: "json")
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///schema: {
        ///    type: "xml"
        ///}
        ///</code>
        ///</example>
        public SchemaResponseType type { get; set; }

        public enum SchemaResponseType
        {
            XML,
            JSON,
        }
    }

    public enum TransportType
    {
        POST,
        GET,
        PUT,
        DELETE,
    }

    public class DataSourceTransportConfiguration
    {
        /// <summary>
        /// Options for remote create data operation, or the URL of the remote service.
        /// Important: The value of transport.create is passed to jQuery.ajax.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        create: {
        ///            url: "/orders/create",
        ///            data: {
        ///                orderId: $("#input").val() // sends the value of the input as the orderId
        ///            }
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public DataSourceTransportCreateConfiguration create { get; set; }

        /// <summary>
        /// Options for remote destroy data operation, or the URL of the remote service.
        /// Important: The value of transport.destroy is passed to jQuery.ajax.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        destroy: {
        ///            url: "/orders/destroy",
        ///            data: {
        ///                orderId: $("#input").val() // sends the value of the input as the orderId
        ///            }
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public DataSourceTransportDestroyConfiguration destroy { get; set; }

        /// <summary>
        /// Convert the request parameters from dataSource format to remote service specific format.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///      read: "Catalog/Titles",
        ///      parameterMap: function(options, type) {
        ///         return {
        ///            pageIndex: options.page,
        ///            size: options.pageSize,
        ///            orderBy: convertSort(options.sort)
        ///         }
        ///      }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsFunction parameterMap { get; set; }

        /// <summary>
        /// Object|String|Function 
        /// Options for remote read data operation, or the URL of the remote service.
        /// Important: The value of transport.read is passed to jQuery.ajax.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        read: {
        ///            url: "/orders/read",
        ///            data: {
        ///                orderId: $("#input").val() // sends the value of the input as the orderId
        ///            }
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public DataSourceTransportReadConfiguration read { get; set; }


        /// <summary>
        /// Object|String|Function 
        /// Options for remote update data operation, or the URL of the remote service.
        /// Important: The value of transport.update is passed to jQuery.ajax.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var dataSource = new kendo.data.DataSource({
        ///    transport: {
        ///        update: {
        ///            url: "/orders/update",
        ///            data: {
        ///                orderId: $("#input").val() // sends the value of the input as the orderId
        ///            }
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public DataSourceTransportUpdateConfiguration update { get; set; }

    }
    public class DataSourceTransportDestroyConfiguration : DataSourceTransportCreateConfiguration
    {
    }

    public class DataSourceTransportCreateConfiguration
    {
        /// <summary>
        /// If set to false, it will force requested pages not to be cached by the browser.
        /// Setting cache to false also appends a query string parameter, "_=[TIMESTAMP]", to the URL. Refer to the jQuery.ajax documentation for further info.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///transport: {
        ///    create: {
        ///        cache: false
        ///    }
        ///}
        ///</code>
        ///</example>
        public bool cache { get; set; }

        /// <summary>
        /// The content-type HTTP header sent to the server. Default is "application/x-www-form-urlencoded".
        /// Use "application/json" if the content is JSON. Refer to the jQuery.ajax documentation for further info.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///transport: {
        ///    create: {
        ///        contentType: "application/json"
        ///    }
        ///}
        ///</code>
        ///</example>
        public JsString contentType { get; set; }

        /// <summary>
        /// Data to be send to the server. Refer to the jQuery.ajax documentation for further info.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///transport: {
        ///    create: {
        ///        data: {
        ///            id: 42,
        ///            name: "John Doe"
        ///        }
        ///    }
        ///}
        ///</code>
        ///</example>
        public object data { get; set; }

        /// <summary>
        /// The type of data that you're expecting back from the server.
        /// Commonly used values are "json" and "jsonp". Refer to the jQuery.ajax documentation for further info.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///transport: {
        ///    create: {
        ///        dataType: "json"
        ///    }
        ///}
        ///</code>
        ///</example>
        public JsString dataType { get; set; }

        /// <summary>
        /// The type of request to make ("POST", "GET", "PUT" or "DELETE"), default is "GET". Refer to the jQuery.ajax documentation for further info.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///transport: {
        ///    create: {
        ///        type: "POST"
        ///    }
        ///}
        ///</code>
        ///</example>
        public TransportType type { get; set; }

        /// <summary>
        /// The remote url to call when creating a new record.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///transport: {
        ///    create: {
        ///        url: "/create"
        ///    }
        ///}
        ///</code>
        ///</example>
        public JsString url { get; set; }

    }

    public class DataSourceTransportReadConfiguration : DataSourceTransportCreateConfiguration
    {
    }

    public class DataSourceTransportUpdateConfiguration : DataSourceTransportCreateConfiguration
    {
    }


    /// <summary>
    /// See the DataSource methods for all inherited methods.
    /// The remove and getByUid methods are overridden and work with the hierarchical data (they will act on all child datasources that have been read).
    /// </summary>
    public class HierarchicalDataSource : DataSource
    {
        public HierarchicalDataSource() { }

        public HierarchicalDataSource(HierarchicalDataSourceConfiguration HierarchicalDataSourceConfiguration) { }

        /// <summary>
        /// Fires when data is changed. In addition to the standard change event,
        /// the HierarchicalDataSource includes additional data when the event has been triggered from a child DataSource.
        /// </summary>
        public new event JsAction<HierarchicalDataSourceChangeEventData> change { add { } remove { } }

    }


    public class HierarchicalDataSourceChangeEventData
    {
        /// <summary>
        /// If the event was triggered by a child datasource, this field holds a reference to the parent node.
        /// </summary>
        public HtmlNode node { get; set; }
    }

    public class HierarchicalDataSourceConfiguration : DataSourceConfiguration
    {
        public new HierarchicalDataSourceSchemaConfiguration schema { get; set; }
    }
    public class HierarchicalDataSourceSchemaConfiguration : DataSourceSchemaConfiguration
    {
        public new HierarchicalDataSourceSchemaModelConfiguration model { get; set; }
    }

    public class HierarchicalDataSourceSchemaModelConfiguration : Model
    {
        /// <summary>
        /// Specifies whether the model might have children and might be loaded.
        /// Applicable when the rendering of a widget needs to have different states for items that have no children (e.g. the toggle button of the TreeView).
        /// </summary>
        public object hasChildren { get; set; }

        /// <summary>
        /// DataSource object or configuration for fetching child nodes. Through examples of that can be found in the Getting started section above.
        /// For static HierarchicalDataSource (local data), this field may be a String, indicating which field holds the nested data.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var localDataSource = new kendo.data.HierarchicalDataSource({
        ///    data: [ {
        ///          categoryName: "SciFi",
        ///          movies: [
        ///            { title: "Star Wars: A New Hope", year: 1977 },
        ///            { title: "Star Wars: The Empire Strikes Back", year: 1980 },
        ///            { title: "Star Wars: Return of the Jedi", year: 1983 }
        ///          ]
        ///      }, {
        ///          categoryName: "Drama",
        ///          movies: [
        ///            { title: "The Shawshenk Redemption", year: 1994 },
        ///            { title: "Fight Club", year: 1999 },
        ///            { title: "The Usual Suspects", year: 1995 }
        ///          ]
        ///      }
        ///    ],
        ///    schema: {
        ///        model: {
        ///            children: "movies"
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public object children { get; set; }
    }

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

    public class FieldConfig
    {
        /// <summary>
        /// Specifies the which will be used for the field when a new model instance is created.
        /// Default settings depend on the type of the field. Default for "string" is "", for "number" is 0 and for "date" is new Date() (today).
        /// </summary>
        public DefaultValueType defaultValue { get; set; }

        /// <summary>
        /// Specifies if the field is editable or not. The default value is true.
        /// </summary>
        public bool editable { get; set; }
        /// <summary>
        /// Specifies if the defaultValue setting should be used. The default is false.
        /// </summary>
        public bool nullable { get; set; }

        /// <summary>
        /// Specifies the function which will parse the field value. If not set default parsers will be used.
        /// </summary>
        public JsFunction parse { get; set; }

        /// <summary>
        /// Specifies the the type of the field. The available options are "string", "number", "boolean", "date". The default is "string".
        /// </summary>
        public JsString type { get; set; }

        /// <summary>
        /// Specifies the validation options which will be used by Kendo Validator.
        /// </summary>
        public object validation { get; set; }


    }

    public enum DefaultValueType
    {
        @string,
        number,
        date,
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
    public class ObservableArray<T>
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
        public void push(T item1) { }
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
        public void push(T item1, T item2) { }
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
        public void push(T item1, T item2, params T[] items) { }

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
        public JsArray slice(JsNumber begin) { return null; }

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
        public JsArray splice(JsNumber index, JsNumber howMany, params T[] items) { return null; }

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
        public void unshift(T item1) { }
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
        public void unshift(T item1, T item2) { }
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
        public void unshift(T item1, T item2, params T[] items) { }

        /// <summary>
        /// An unsigned, 32-bit integer that specifies the number of items in an ObservableArray.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([1, 2, 3]);
        ///for (var i = 0; i < array.length; i++) {
        ///    console.log(array[i]); // outputs the current item
        ///}
        ///</code>
        ///</example>
        public JsNumber length { get; set; }

        /// <summary>
        /// Raised when the items of the ObservableArray change in some way.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var array = new kendo.data.ObservableArray([1, 2, 3]);
        ///array.bind("change", function(e) {
        ///    console.log(e.action, e.index, e.items);
        ///});
        ///array.push(4, 5); // outputs "add", 3, [4, 5]
        ///array.pop(); // outputs "remove", 4, [5]
        ///var people = new kendo.data.ObservableArray([{ name: "John Doe" }]);
        ///people.bind("change", function(e) {
        ///    console.log(e.action, e.field, e.items[0].get("name"));
        ///});
        ///people[0].set("name", "Jane Doe"); // outputs "itemchange", "name", "Jane Doe"
        ///</code>
        ///</example>
        public event JsAction<ObservableArrayChangeEventData<T>> change { add { } remove { } }

    }

    public class ObservableArrayChangeEventData<T>
    {
        /// <summary>
        /// Specifies the type of change. Possible values are: "add"- items are added to the ObservableArray,
        /// "itemchange" - a field of an item changed, "remove" - items are removed from the ObservableArray.
        /// </summary>
        public JsString action { get; set; }

        /// <summary>
        /// The index at which items are removed or added. Set to undefined if e.action is "itemchange".
        /// </summary>
        public JsNumber index { get; set; }

        /// <summary>
        /// The items which were changed.
        /// </summary>
        public JsArray<T> items  { get; set; }

        /// <summary>
        /// The name of the field of an item that changed. Available only when e.action is "itemchange".
        /// </summary>
        public JsString field { get; set; }
    }

    public class Drag
    {
        public Drag(jQuery.jQuery el, DragConfiguration config)
        {
        }

        ///// <summary>
        ///// Discard the current drag. Calling the cancel method will trigger the cancel event. The correct moment to call this method would be in the start event handler.
        ///// </summary>
        /////<example>
        /////usage
        /////<code>
        /////new kendo.Drag($("#foo"), {
        ///// start: function(e) {
        /////     e.cancel();
        ///// }
        /////});
        /////</code>
        /////</example>
        //public void cancel() { }

        ///// <summary>
        ///// Capture the current drag, so that Drag listeners bound to parent elements will not trigger.
        ///// This method will not have any effect if the current drag instance is instantiated with the global option set to true.
        ///// </summary>
        //public void capture() { }
        //TODO: unmarke, move to the right place

        /// <summary>
        /// Fires when the drag is canceled. This when the cancel method is called.
        /// </summary>
        public event JsAction<DragEventData> cancel { add { } remove { } }

        /// <summary>
        /// Fires when the drag ends.
        /// </summary>
        public event JsAction<DragEventData> end { add { } remove { } }

        /// <summary>
        /// Fires while dragging.
        /// </summary>
        public event JsAction<DragEventData> move { add { } remove { } }

        /// <summary>
        /// Fires when the user starts dragging the element.
        /// </summary>
        public event JsAction<DragEventData> start { add { } remove { } }

        /// <summary>
        /// Fires when the user presses and releases the element without any movement or with a movement below the threshold specified.
        /// </summary>
        public event JsAction<DragEventData> tap { add { } remove { } }
    }

    public class DragEventData
    {
        /// <summary>
        /// Reference to the horizontal drag axis instance.
        /// </summary>
        public DragAxis x { get; set; }

        /// <summary>
        /// Reference to the vertical drag axis instance.
        /// </summary>
        public DragAxis y { get; set; }

        /// <summary>
        /// Reference to the jQuery event object.
        /// </summary>
        public object @event { get; set; }
        //TODO: type is  jQueryEvent

        /// <summary>
        /// Reference to the DOM element from which the Drag started. It is different from the element only if filter option is specified.
        /// </summary>
        public HtmlElement target { get; set; }
    }

    public class DragEndEventData
    {

    }

    public class DragConfiguration
    {
        /// <summary>
        /// If set to true, the mousedown and selectstart events will not be prevented.
        /// </summary>
        public bool allowSelection  { get; set; }

        /// <summary>
        /// If passed, the filter limits the child elements that will trigger the event sequence.
        /// </summary>
        public JsString filter { get; set; }

        /// <summary>
        /// If set to true, the drag event will be tracked beyond the element boundaries.
        /// </summary>
        public bool global { get; set; }

        /// <summary>
        /// If set to true, the mousedown event propagation will stopped, disabling drag capturing at parent elements.
        /// If set to false, dragging outside of the element boundaries will trigger the end event.
        /// </summary>
        public bool stopPropagation { get; set; }

        /// <summary>
        /// If set, the drag event will be tracked for the surface boundaries. By default, leaving the element boundaries will end the drag.
        /// </summary>
        public HtmlElement surface { get; set; }

        /// <summary>
        /// The minimum distance the mouse/touch should move before the event is triggered.
        /// </summary>
        public JsNumber threshold { get; set; }

    }

    /// <summary>
    /// The DragAxis is used internally by the kendo.Drag component to store and calculate event data.
    /// The Drag component contains two DragAxis instances: x for the horizontal coordinates, and y for the vertical.
    /// The two DragAxis instances are available in each Drag event parameter.
    /// </summary>
    public class DragAxis
    {
        /// <summary>
        ///  the offset of the mouse/touch relative to the entire document (pageX/Y);
        /// </summary>
        public JsNumber location { get; set; }

        /// <summary>
        /// the offset of the mouse/touch relative to the document when the drag started;
        /// </summary>
        public JsNumber startLocation { get; set; }

        /// <summary>
        /// the offset of the mouse/touch relative to the viewport (clientX/Y);
        /// </summary>
        public JsNumber client { get; set; }

        /// <summary>
        /// the change from the previous event location
        /// </summary>
        public JsNumber delta { get; set; }

        /// <summary>
        /// the pixels per millisecond speed of the current move.
        /// For instance, the mobile ScrollView widget considers a drag with velocity below 0.8 a slow one, while velocity above 1.6 is a fast one.
        /// </summary>
        public JsNumber velocity { get; set; }
    }

    //TODO: kendo.ui.Validator means anything?
    public class Validator
    {
        public Validator() { }

        public Validator(ValidatorConfiguration ValidatorConfiguration) { }

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

    public class ValidatorConfiguration
    {
        /// <summary>
        /// Set of messages (either strings or functions) which will be shown when given validation rule fails.
        /// By setting already existing key the appropriate built-in message will be overridden.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#myform").kendoValidator({
        ///     messages: {
        ///         // defines a message for the 'custom' validation rule
        ///         custom: "Please enter valid value for my custom rule",
        ///         // overrides the built-in message for the required rule
        ///         required: "My custom required message",
        ///         // overrides the built-in message for the email rule
        ///         // with a custom function that returns the actual message
        ///         email: function(input) {
        ///             return getMessage(input);
        ///         }
        ///     }
        ///});
        ///</code>
        ///</example>
        public object messages { get; set; }

        /// <summary>
        /// Set of custom validation rules. Those rules will extend the built-in ones.
        /// This configuration can be tested live using this JSBin example.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#myform").kendoValidator({
        ///     rules: {
        ///         custom: function(input) {
        ///             // Only "Tom" will be a valid value for the FirstName input
        ///             return input.is("[name=firstname]") && input.val() === "Tom";
        ///         },
        ///         alsoCustom: function(input) {
        ///            return $.trim(input.val()) !== "";
        ///         }
        ///     }
        ///});
        ///</code>
        ///</example>
        public object rules { get; set; }

        /// <summary>
        /// Determines if validation will be triggered when element loses focus. Default value is true.
        /// </summary>
        public bool validateOnBlur { get; set; }
    }


}
