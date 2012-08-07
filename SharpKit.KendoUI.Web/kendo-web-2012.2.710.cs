using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.KendoUI.Web;


namespace SharpKit.jQuery
{
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class KendoUIWebExtensions
    {

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoAutoComplete(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoAutoComplete(this jQuery query, AutoCompleteConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoCalendar(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoCalendar(this jQuery query, ComboBoxConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoComboBox(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoComboBox(this jQuery query, CalendarConfiguration configuration) { return null; }
    }

}

namespace SharpKit.KendoUI.Web
{

    public class AutoComplete
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        ///autocomplete.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var autocomplete = $("#autocomplete").data("kendoAutoComplete");
        /// // get the dataItem corresponding to the passed index.
        ///var dataItem = autocomplete.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enable/Disable the autocomplete widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI AutoComplete
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // re-render the items in drop-down list.
        ///autocomplete.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Filters dataSource using the provided parameter and rebinds drop-down list.
        /// </summary>
        /// <param name="word">The filter value.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // Searches for item which has "Inception" in the name.
        ///autocomplete.search("Inception");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the text of the autocomplete.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // selects by jQuery object
        ///autocomplete.select(autocomplete.ul.children().eq(0));
        ///</code>
        ///</example>
        public void select(jQuery.jQuery li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"
        /// <summary>
        /// Selects drop-down list item and sets the text of the autocomplete.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // selects by jQuery object
        ///autocomplete.select(autocomplete.ul.children().eq(0));
        ///</code>
        ///</example>
        public void select(object li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"

        /// <summary>
        /// Forces a suggestion onto the text of the AutoComplete.
        /// </summary>
        /// <param name="value">Characters to force a suggestion.</param>
        ///<example>
        ///usage
        ///<code>
        /// // note that this suggest is not the same as the configuration method
        /// // suggest which enables/disables auto suggesting for the AutoComplete
        /// //
        /// // get a referenence to the Kendo UI AutoComplete
        ///var autoComplete = $("#autoComplete").data("kendoAutoComplete");
        /// // force a suggestion to the item with the name "Inception"
        ///autoComplete.suggest("Inception");
        ///</code>
        ///</example>
        public void suggest(JsString value) { }

        /// <summary>
        /// Gets/Sets the value of the autocomplete.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The value of the autocomplete.</returns>
        public JsString value(JsString value) { return null; }

        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var autoComplete = $("#autoComplete").data("kendoAutoComplete");
        ///$("#autoComplete").data("kendoAutoComplete").bind("change", function(e) {
        ///    // handle event
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    open: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> open { add { } remove { } }


        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        ///var onSelect = function(e) {
        ///    // access the selected item via e.item (jQuery object)
        ///};
        ///
        /// // attach select event handler during initialization
        ///var autocomplete = $("#autocomplete").kendoAutoComplete({
        ///    select: onSelect
        ///});
        ///
        /// // detach select event handler via unbind()
        ///autocomplete.data("kendoAutoComplete").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<AutoCompleteSelectEventData> selectEvent { add { } remove { } }
        //TODO: event name is select

    }

    public class AutoCompleteConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn of the animation.
        /// </summary>
        public AutoCompleteAnimationConfiguration animation { get; set; }

        /// <summary>
        /// The set of data that the AutoComplete will be bound to. Either a local JavaScript object, or an instance of the Kendo UI DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }
        /// <summary>
        /// The set of data that the AutoComplete will be bound to. Either a local JavaScript object, or an instance of the Kendo UI DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: null) Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { ID: 1, Name: "Item 1" }, { ID: 2, Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({
        ///    dataSource: items,
        ///    dataTextField: "Name"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        ///(default: 200) Specifies the delay in ms after which the AutoComplete will start filtering the dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the delay to 500 milliseconds
        ///$("#autoComplete").kendoAutoComplete({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the AutoComplete should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // disable the autocomplete when it is created (enabled by default)
        ///$("#autoComplete").kendoAutoComplete({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: "startswith") Defines the type of filtration. This value is handled by the remote data source.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // send a filter value of 'contains' to the server
        ///$("#autoComplete").kendoAutoComplete({
        ///    filter: 'contains'
        ///});
        ///</code>
        ///</example>
        public JsString filter { get; set; }

        /// <summary>
        /// (default: 200) Sets the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the height of the drop-down list that appears when the autocomplete is activated to 500px
        ///$("#autoComplete").kendoAutoComplete({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Controls whether the first item will be automatically highlighted.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autocomplete").kendoAutoComplete({
        ///    highlightFirst: false //no of the suggested items will be highlighted
        ///});
        ///</code>
        ///</example>
        public bool highlightFirst { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public JsString ignoreCase { get; set; }
        //TODO: seems like they have a mistake. if default: true should it be boolean?

        /// <summary>
        /// (default: 1) Specifies the minimum number of characters that should be typed before the AutoComplete queries the dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // wait until the user types 3 characters before querying the server
        ///$("#autoComplete").kendoAutoComplete({
        ///    minLength: 3
        ///});
        ///</code>
        ///</example>
        public JsNumber minLength { get; set; }

        /// <summary>
        /// (default: "")A string that appears in the textbox when it has no value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //autocomplete initialization
        ///&lt;script>
        ///    $("#autocomplete").kendoAutoComplete({
        ///        dataSource: dataSource,
        ///        placeholder: "Enter value..."
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: "")Sets the separator for completion. Empty by default, allowing for only one completion.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set completion separator to ,
        ///$("#autoComplete").kendoAutoComplete({
        ///    separator: ", "
        ///});
        ///</code>
        ///</example> 
        public JsString separator { get; set; }

        /// <summary>
        /// (default: false)Controls whether the AutoComplete should automatically auto-type the rest of text.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // turn on auto-typing (off by default)
        ///$("#autoComplete").kendoAutoComplete({
        ///    suggest: true
        ///});
        ///</code>
        ///</example>
        public bool suggest { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        /// //autocomplete initialization
        /// &lt;script>
        ///     $("#autocomplete").kendoAutoComplete({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         template: kendo.template($("#template").html())
        ///     });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

    }
    public class AutoCompleteAnimationConfiguration
    {
        /// <summary>
        /// Animation to be used for closing of the popup.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //autocomplete initialization
        ///&lt;script>
        ///    $("#autocomplete").kendoAutoComplete({
        ///        dataSource: dataSource,
        ///        animation: {
        ///           close: {
        ///               effects: "fadeOut",
        ///               duration: 300,
        ///               hide: true
        ///               show: false
        ///           }
        ///        }
        ///    });
        ///</script>
        ///</code>
        ///</example>
        public object close { get; set; }

        /// <summary>
        /// Animation to be used for opening of the popup.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //autocomplete initialization
        ///&lt;script>
        ///    $("#autocomplete").kendoAutoComplete({
        ///        dataSource: dataSource,
        ///        animation: {
        ///           open: {
        ///               effects: "fadeIn",
        ///               duration: 300,
        ///               show: true
        ///           }
        ///        }
        ///    });
        ///</script>
        ///</code>
        ///</example>
        public object open { get; set; }
    }

    public class EmptyEventData
    {
    }

    public class AutoCompleteSelectEventData
    {
        /// <summary>
        /// The selected item chosen by a user.
        /// </summary>
        public jQuery.jQuery item { get; set; }
    }

    public class Calendar
    {
        /// <summary>
        /// Sets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Navigates to view
        /// </summary>
        /// <param name="value">Desired date</param>
        /// <param name="view">Desired view</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to the desired date
        ///calendar.navigate(value, view);
        ///</code>
        ///</example>
        public void navigate(JsDate value, JsString view) { }

        /// <summary>
        /// Navigates to the lower view
        /// </summary>
        /// <param name="value">Desired date</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate down
        ///calendar.navigateDown(value);
        ///</code>
        ///</example>
        public void navigateDown(JsDate value) { }

        /// <summary>
        /// Navigates to the future
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to future
        ///calendar.navigateToFuture();
        ///</code>
        ///</example>
        public void navigateToFuture() { }

        /// <summary>
        /// Navigates to the past
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to past
        ///calendar.navigateToPast();
        ///</code>
        ///</example>
        public void navigateToPast() { }

        /// <summary>
        /// Navigates to the upper view
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate up
        ///calendar.navigateUp();
        ///</code>
        ///</example>
        public void navigateUp() { }

        /// <summary>
        /// Sets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void value(JsDate value) { }

        /// <summary>
        /// Sets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the value of the calendar.
        ///var value = calendar.value();
        /// // set the value of the calendar.
        ///calendar.value(new Date());
        ///</code>
        ///</example>
        public JsDate value() { return null; }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the Kendo UI calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // bind to the change event
        ///calendar.bind("change", function(e) {
        ///     // handle event
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when navigate
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    navigate: function(e) {
        ///         // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> navigateEvent { add { } remove { } }
        //TODO: event name is navigate
    }

    public class CalendarConfiguration
    {

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    dates: [new Date(2000, 10, 10, 10, 0, 0), new Date(2000, 10, 10, 30, 0)] //can manipulate month template depending on this array.
        ///});
        ///</code>
        ///</example>
        public JsArray dates { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    depth: "year"
        ///});
        ///</code>
        ///</example>
        public JsString depth { get; set; }

        /// <summary>
        /// Can be boolean or string. Specifies the content of the footer. If false, the footer will not be rendered.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // change the footer text from the default current date
        ///$("#calendar").kendoCalendar({
        ///    footer = "My Custom Footer"
        ///});
        ///</code>
        ///</example>
        public object footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public CalendarMonthConfiguration month { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    start: "year"
        ///});
        ///</code>
        ///</example>\
        public JsString start { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected date to Jan 1st. 2012
        ///$("#calendar").kendoCalendar({
        ///    value: new Date(2012, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }
    }

    public class CalendarMonthConfiguration
    {
        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are in range.
        /// </summary>
        public JsString content { get; set; }

        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are not in the min/max range.
        /// </summary>
        public JsString empty { get; set; }
    }


    public class ComboBox
    {
    }

    public class ComboBoxConfiguration
    {

    }

}
