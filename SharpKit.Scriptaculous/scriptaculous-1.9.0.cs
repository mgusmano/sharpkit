using SharpKit.JavaScript;
using SharpKit.Html4;

namespace SharpKit.Scriptaculous
{
    #region Ajax

    [JsType(JsMode.Prototype, Name = "Ajax.Autocompleter", Export = false)]
    public class Autocompleter
    {
        public static void test(JsString con) { }
    }

    /// <summary>
    /// Ajax.Autocompleter allows for server-powered autocompleting text fields.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AutocompleterOptions : AjaxOptions
    {
        /// <summary>
        /// Name of the parameter for the string typed by the user on the autocompletion field
        /// </summary>
        public JsString paramName { get; set; }

        /// <summary>
        /// Tokenized incremental autocompletion is enabled automatically when an autocompleter is instantiated with the ‘tokens’ option in the options parameter:
        /// See Also Autocompleter.Base
        /// </summary>
        public JsArray tokens { get; set; }

        /// <summary>
        /// Default : 0.4
        /// How frequently (in seconds) the input field should be polled for changes before firing an Ajax request.
        /// </summary>
        public JsNumber frequency { get; set; }

        /// <summary>
        /// Default : 1
        /// The minimum number of characters that must be entered in the input field before an Ajax request is made.
        /// </summary>
        public JsNumber minChars { get; set; }

        /// <summary>
        /// The class name of the element that contains the text to be placed into the input box. By default all text will be used.
        /// </summary>
        public JsString select { get; set; }

        /// <summary>
        /// The HTML id of an element to display (using Element.show) while the Ajax request is in progress.
        /// This element will be hidden with Element.hide when the request is completed.
        /// This is useful for displaying an animated spinner during processing. See Ajaxload for some image examples.
        /// </summary>
        public JsString indicator { get; set; }

        /// <summary>
        /// Hook for a custom function to replace the built-in function that adds the list item text to the input field.
        /// The custom function is called after the element has been updated (i.e. when the user has selected an entry).
        /// The function receives one parameter only: the selected item (the <li> item selected)
        /// </summary>
        public JsString updateElement { get; set; }

        /// <summary>
        /// Hook for a custom function that’s called following the execution of the built-in function that adds the list item text to the input field,
        /// which happens after a user has selected an entry.
        /// (The difference between updateElement and afterUpdateElement is that updateElement replaces the built-in Autocompleter function; afterUpdateElement supplements that built-in function.)
        /// The function receives two parameters, the input field specified for autocompletion, and the selected item (the &lt;li> item selected)
        /// </summary>
        public JsString afterUpdateElement { get; set; }

        /// <summary>
        /// This function is called just before the Request is actually made, allowing you to modify the querystring that is sent to the server.
        /// The function receives the completer’s input field and the default querystring (‘value=XXX’) as parameters.
        /// You should return the querystring you want used, including the default part.
        /// </summary>
        public JsAction<JsString, object> callback { get; set; }
        //TODO: must check

        /// <summary>
        /// To send additional parameters to the server, add them here in the format: 'field=value&another=value'.
        /// Errata/bug: The hash format {field: 'value',another: 'value'} was noted in this wiki to work, but it does not,
        /// as the Ruby on Rails project has separately documented and fixed in their codebase.
        /// </summary>
        public JsString parameters { get; set; }
        //TODO: must check
    }


    /// <summary>
    /// This constructor generates a Flickr-style AJAX-based “on-the-fly” fields with a select box instead of Ajax.InPlaceEditor text fields.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.InPlaceCollectionEditor", Export = false)]
    public class InPlaceCollectionEditor
    {
        /// <summary>
        /// The constructor takes three parameters. The first is the element that should support in-place editing.
        /// The second is the url to submit the changed value to. The server should respond with the updated value
        /// (the server might have post-processed it or validation might have prevented it from changing).
        /// The third is a hash of options. Within that hash of options should be a field called collection that is an array of values to place inside your select box.
        /// The server side component gets the new value as the parameter ‘value’ (POST method), and should send the new value as the body of the response.
        /// If the collection parameter (or the result of the loadCollectionURL) is a one-dimensional array,
        /// the option tag’s value attribute will be the same as the label. For explicit value attributes,
        /// use a two dimensional array for the collection where the second dimension is a key value pair such as [['key', 'value'], ['key', 'value']].
        /// </summary>
        /// <param name="element"> The first is the element that should support in-place editing.</param>
        /// <param name="url"> The second is the url to submit the changed value to.</param>
        /// <param name="config"> The third is a hash of options.
        /// Within that hash of options should be a field called collection that is an array of values to place inside your select box.</param>
        public InPlaceCollectionEditor(HtmlElement element, JsString url, InPlaceCollectionEditorOptions config) { }
    }

    [JsType(JsMode.Json)]
    public class InPlaceCollectionEditorOptions : InPlaceEditorOptions
    {
        /// <summary>
        /// Array of static elements to be displayed as options (in JSON format)
        /// </summary>
        public JsArray<HtmlElement> collection { get; set; }

        /// <summary>
        /// Loads values and tag texts for the <option> tags
        /// </summary>
        public JsString loadCollectionURL { get; set; }

        /// <summary>
        /// Text to be displayed while the collection is loading
        /// </summary>
        public JsString loadingCollectionText { get; set; }

        /// <summary>
        /// Class applied to form while the collection is loading
        /// </summary>
        public JsString loadingClassName { get; set; }

        ///// <summary>
        /////  Within that hash of options should be a field called collection that is an array of values to place inside your select box.
        ///// </summary>
        //public JsArray<JsArray<JsString>> collection { get; set; }
        //TODO: there is allreay a propertye named collection. wich is the reight one?
    }


    /// <summary>
    /// The in-place “text edit” testing allows for Flickr-style AJAX-backed “on-the-fly” textfields.
    /// See the documentation on Ajax.InPlaceEditor and Ajax.InPlaceCollectionEditor
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.InPlaceEditor", Export = false)]
    public class InPlaceEditor
    {
        /// <summary>
        /// The constructor takes three parameters.
        /// The first is the element that should support in-place editing.
        /// The second is the url to submit the changed value to. The server should respond with the updated value
        /// (the server might have post-processed it or validation might have prevented it from changing).
        /// The third is a hash of options.
        /// The server side component gets the new value as the parameter ‘value’ (POST method), and should send the new value as the body of the response.
        /// </summary>
        /// <param name="element">The first is the element that should support in-place editing.</param>
        /// <param name="url">The second is the url to submit the changed value to. The server should respond with the updated value</param>
        /// <param name="options">The third is a hash of options.</param>
        public InPlaceEditor(HtmlElement element, JsString url, InPlaceEditorOptions options) { }
    }

    [JsType(JsMode.Json)]
    public class InPlaceEditorOptions
    {
        /// <summary>
        /// Default : “button”
        /// What type of ok button to use in edit mode, or none at all (button, link, false)
        /// </summary>
        public JsString okControl { get; set; }

        /// <summary>
        /// Default : “link”
        /// What type of cancel button to use in edit mode, or none at all (button, link, false)
        /// </summary>
        public JsString cancelControl { get; set; }

        /// <summary>
        /// Default : “ok”
        /// The text of the submit button that submits the changed value to the server
        /// </summary>
        public JsString okText { get; set; }

        /// <summary>
        /// Default : “cancel”
        /// The text of the link that cancels editing
        /// </summary>
        public JsString cancelText { get; set; }

        /// <summary>
        /// Default : “Saving…”
        /// The text shown while the text is sent to the server
        /// </summary>
        public JsString savingText { get; set; }

        /// <summary>
        /// Default : “Click to edit”
        /// The text shown during mouseover the editable text
        /// </summary>
        public JsString clickToEditText { get; set; }

        /// <summary>
        /// Default : id of the element to edit plus ‘InPlaceForm’
        /// The id given to the element
        /// </summary>
        public object formId { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : null
        /// ID of an element that acts as an external control used to enter edit mode.
        /// The external control will be hidden when entering edit mode and shown again when leaving edit mode.
        /// </summary>
        public JsString externalControl { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : false
        /// Whether or not to disable onclick editing so that only an external control can activate editable mode
        /// </summary>
        public bool externalControlOnly { get; set; }

        /// <summary>
        /// Default : 1
        /// The row height of the input field (anything greater than 1 uses a multiline textarea for input)
        /// </summary>
        public JsNumber rows { get; set; }

        /// <summary>
        /// Default : “function(transport, element) {new Effect.Highlight(element, {startcolor: this.options.highlightColor});}”
        /// Code run if update successful with server. Also if user cancels the form. See bug.
        /// </summary>
        public JsCode onComplete { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : “function(transport) {alert(“Error communicating with the server: ” + transport.responseText.stripTags());}”
        /// Code run if update failed with server
        /// </summary>
        public JsCode onFailure { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : none
        /// The number of columns the text area should span (works for both single line or multi line)
        /// </summary>
        public JsNumber cols { get; set; }

        /// <summary>
        /// Default : none
        /// Synonym for ‘cols’ when using single-line (rows=1) input
        /// </summary>
        public JsNumber size { get; set; }

        /// <summary>
        /// Default : Ajax.InPlaceEditor.defaultHighlightColor
        /// The highlight color. Must be six hex digits, not 3.
        /// </summary>
        public object highlightColor { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : ”#FFFFFF”
        /// The color which the highlight fades to. Must be six hex digits, not 3.
        /// </summary>
        public JsString highlightEndColor { get; set; }

        /// <summary>
        /// Default : “inplaceeditor-saving”
        /// CSS class added to the element while displaying “Saving…” (removed when server responds)
        /// </summary>
        public JsString savingClassName { get; set; }

        /// <summary>
        /// Default : “inplaceeditor-form”
        /// CSS class used for the in place edit form
        /// </summary>
        public JsString formClassName { get; set; }

        /// <summary>
        /// Default : ?
        /// </summary>
        public JsString hoverClassName { get; set; }

        /// <summary>
        /// Default : null
        /// Will cause the text to be loaded from the server (useful if your text is actually textile and formatted on the server)
        /// </summary>
        public JsString loadTextURL { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : “Loading…”
        /// If the loadText URL option is specified then this text is displayed while the text is being loaded from the server
        /// </summary>
        public JsString loadingText { get; set; }

        /// <summary>
        /// Default : function(form) {Form.serialize(form)}
        /// A function that will get executed just before the request is sent to the server, should return the parameters to be sent in the URL.
        /// Will get two parameters, the entire form and the value of the text control.
        /// </summary>
        public JsFunc<object, object, object> callback { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : “false”
        /// This option if true will submit the in_place_edit form when the input tag loses focus.
        /// </summary>
        public bool submitOnBlur { get; set; }

        /// <summary>
        /// Default : Options specified to all AJAX calls (loading and saving text), these options are passed through to the prototype AJAX classes.
        /// </summary>
        public AjaxOptions ajaxOptions { get; set; }
    }


    /// <summary>
    /// All Ajax classes share a common set of options and callbacks.
    /// Callbacks are called at various points in the life-cycle of a request, and always feature the same list of arguments.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AjaxOptions
    {
        /// <summary>
        /// (Boolean; default true): Determines whether XMLHttpRequest is used asynchronously or not.
        /// Synchronous usage is strongly discouraged — it halts all script execution for the duration of the request and blocks the browser UI.
        /// </summary>
        public bool asynchronous { get; set; }

        /// <summary>
        /// (String; default application/x-www-form-urlencoded): The Content-type header for your request.
        /// Change this header if you want to send data in another format (like XML).
        /// </summary>
        public JsString contentType { get; set; }

        /// <summary>
        /// (String; default UTF-8): The encoding for the contents of your request.
        /// It is best left as-is, but should weird encoding issues arise, you may have to tweak this.
        /// </summary>
        public JsString encoding { get; set; }

        /// <summary>
        /// (String; default post): The HTTP method to use for the request. The other common possibility is get.
        /// Abiding by Rails conventions,
        /// Prototype also reacts to other HTTP verbs(such as put and delete) by submitting via post and adding a extra _method parameter with the originally-requested method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The parameters for the request, which will be encoded into the URL for a get method, or into the request body for the other methods.
        /// This can be provided either as a URL-encoded string, a Hash, or a plain Object.
        /// </summary>
        public object parameters { get; set; }

        /// <summary>
        /// Specific contents for the request body on a post method. If it is not provided, the contents of the parameters option will be used instead.
        /// </summary>
        public JsString postBody { get; set; }

        /// <summary>
        /// A set of key-value pairs, with properties representing header names.
        /// </summary>
        public object requestHeaders { get; set; }
        //TODO: type?

        /// <summary>
        /// (Boolean | String; default true):
        /// Automatically evals the content of Ajax.Response#responseText and populates Ajax.Response#responseJSON with it if the Content-type returned by the server is set to application/json.
        /// If the request doesn't obey same-origin policy, the content is sanitized before evaluation.
        /// If you need to force evalutation, pass 'force'. To prevent it altogether, pass false.
        /// </summary>
        public bool evalJS { get; set; }
        /// <summary>
        /// (Boolean | String; default true):
        /// Automatically evals the content of Ajax.Response#responseText and populates Ajax.Response#responseJSON with it if the Content-type returned by the server is set to application/json.
        /// If the request doesn't obey same-origin policy, the content is sanitized before evaluation.
        /// If you need to force evalutation, pass 'force'. To prevent it altogether, pass false.
        /// </summary>
        [JsProperty(Name = "evalJS")]
        public JsString evalJSString { get; set; }

        /// <summary>
        /// (Boolean; default is false for same-origin requests, true otherwise): Sanitizes the contents of Ajax.Response#responseText before evaluating it.
        /// </summary>
        public bool sanitizeJSON { get; set; }

        //TODO: callbacks
    }

    #endregion

    #region Autocompleter

    //TODO: Autocompleter.Base


    /// <summary>
    /// The local array autocompleter. Used when you’d prefer to inject an array of autocompletion options into the page, rather than sending out Ajax queries.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Autocompleter.Local", Export = false)]
    public class Local
    {
        /// <summary>
        /// The constructor takes four parameters.
        /// The first two are, as usual, the id of the monitored textbox, and id of the autocompletion menu.
        /// The third is an array of strings that you want to autocomplete from, and the fourth is the options block.
        /// </summary>
        /// <param name="id_of_text_field"></param>
        /// <param name="id_of_div_to_populate"></param>
        /// <param name="array_of_strings"></param>
        /// <param name="options"></param>
        public Local(JsString id_of_text_field, JsString id_of_div_to_populate, JsArray<JsString> array_of_strings, LocalOptions options) { }
    }

    [JsType(JsMode.Json)]
    public class LocalOptions : AjaxOptions
    {
        /// <summary>
        /// Default : 10
        /// How many autocompletion choices to offer
        /// </summary>
        public JsNumber choices { get; set; }

        /// <summary>
        /// Default :true
        /// If false, the autocompleter will match entered text only at the beginning of strings in the autocomplete array.
        /// Defaults to true, which will match text at the beginning of any word in the strings in the autocomplete array.
        /// If you want to search anywhere in the string, additionally set the option fullSearch to true
        /// </summary>
        public bool partialSearch { get; set; }

        /// <summary>
        /// Default :false
        /// Search anywhere in autocomplete array strings.
        /// </summary>
        public bool fullSearch { get; set; }

        /// <summary>
        /// Default :2
        /// How many characters to enter before triggering a partial match (unlike minChars, which defines how many characters are required to do any match at all).
        /// </summary>
        public JsNumber partialChars { get; set; }

        /// <summary>
        /// Default : true
        /// Whether to ignore case when autocompleting
        /// </summary>
        public bool ignoreCase { get; set; }

        /// <summary>
        /// It’s possible to pass in a custom function as the ‘selector’ option, if you prefer to write your own autocompletion logic.
        /// In that case, the other options above will not apply unless you support them.
        /// </summary>
        public JsAction selector { get; set; }
    }
    //TOSO: not sure it Inherite from AjaxOptions

    #endregion

    #region Behaviours

    /// <summary>
    /// To make an element draggable, create a new instance of class Draggable.
    /// For additional built-in functionality, make a Sortable instead.
    /// There is also a class named Draggables that exposes functions for observing drag actions.
    /// Draggables become much more useful when you use them with droppables, which are the areas that you can drag draggables to.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Behaviours.Draggable", Export = false)]
    public class Draggable
    {
        public Draggable(JsString id_of_element, DraggableOptions options) { }
        public Draggable(JsString id_of_element) { }

    }

    [JsType(JsMode.Json)]
    public class DraggableOptions
    {
        /// <summary>
        /// string or DOM reference, not set by default. As above, except now the value may be a string referencing a CSS class value.
        /// The first child/grandchild/etc. element found within the element that has this CSS class value will be used as the handle.
        /// </summary>
        [JsProperty(Name = "handle")]
        public JsString handleString { get; set; }
        /// <summary>
        /// string or DOM reference, not set by default. As above, except now the value may be a string referencing a CSS class value.
        /// The first child/grandchild/etc. element found within the element that has this CSS class value will be used as the handle.
        /// </summary>
        public HtmlElement handle { get; set; }

        /// <summary>
        /// boolean or function reference, defaults to false.
        /// Revert can also be an arbitrary function reference, called when the drag ends.
        /// Specifying 'failure' will instruct the draggable not to revert if successfully dropped in a droppable.
        /// </summary>
        public bool revert { get; set; }
        /// <summary>
        /// boolean or function reference, defaults to false.
        /// Revert can also be an arbitrary function reference, called when the drag ends.
        /// Specifying 'failure' will instruct the draggable not to revert if successfully dropped in a droppable.
        /// </summary>
        [JsProperty(Name = "revert")]
        public JsAction revertFunction { get; set; }
        //TODO: check

        /// <summary>
        /// If set to false no snapping occurs.
        /// Otherwise takes one of the following forms – Δi: one delta value for both horizontal and vertical snap, [Δx, Δy]: delta values for horizontal and vertical snap,
        /// function(x, y, draggable_object) { return [x, y]; }: a function that receives the proposed new top left
        /// coordinate pair and returns the coordinate pair to actually be used.
        /// </summary>
        public bool snap { get; set; }

        /// <summary>
        /// integer value, defaults to 1000. The css z-index of the draggable item.
        /// </summary>
        public JsNumber zindex { get; set; }

        /// <summary>
        /// string, not set by default. If set to 'horizontal' or 'vertical' the drag will be constrained to take place only horizontally or vertically.
        /// </summary>
        public JsString constraint { get; set; }

        /// <summary>
        /// boolean, defaults to false. Clones the element and drags the clone, leaving the original in place until the clone is dropped.
        /// </summary>
        public bool ghosting { get; set; }

        /// <summary>
        /// Effect, defaults to Effect.Opacity. Defines the effect to use when the draggable starts being dragged.
        /// </summary>
        public Effect starteffect { get; set; }

        /// <summary>
        /// Effect, default to Effect.Move. Defines the effect to use when the draggable reverts back to its starting position.
        /// </summary>
        public Effect reverteffect { get; set; }

        /// <summary>
        /// Effect, defaults to Effect.Opacity. Defines the effect to use when the draggable stops being dragged.
        /// </summary>
        public Effect endeffect { get; set; }

        /// <summary>
        /// string or DOM reference, not set by default. Specifies the element which will scroll when you get to the boundary. By default this is turned off.
        /// </summary>
        [JsProperty(Name = "scroll")]
        public JsString scrollString { get; set; }
        /// <summary>
        /// string or DOM reference, not set by default. Specifies the element which will scroll when you get to the boundary. By default this is turned off.
        /// </summary>
        public HtmlElement scroll { get; set; }

        /// <summary>
        /// integer value, defaults to 20 pixels. Minimum distance from the element boundary to start scrolling.
        /// </summary>
        public JsNumber scrollSensitivity { get; set; }

        //TODO: callbacks

    }


    /// <summary>
    /// To make an element react when a Draggable is dropped onto it, you’ll add it to the Droppables of the page with the Droppables.add class method.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Behaviours.Droppables", Export = false)]
    public class Droppables
    {
        public static Droppables add(JsString id_of_element, DroppablesOptions options) { return null; }
        public static Droppables add(JsString id_of_element) { return null; }
    }

    [JsType(JsMode.Json)]
    public class DroppablesOptions
    {
        /// <summary>
        /// Set accept to a string or an array of strings describing CSS classes.
        /// The Droppable will only accept Draggables that have one or more of these CSS classes.
        /// </summary>
        public JsString accept { get; set; }
        /// <summary>
        /// Set accept to a string or an array of strings describing CSS classes.
        /// The Droppable will only accept Draggables that have one or more of these CSS classes.
        /// </summary>
        [JsProperty(Name = "accept")]
        public JsArray<JsString> acceptArray { get; set; }

        /// <summary>
        /// The droppable will only accept the Draggable if the Draggable is contained in the given elements (or element ids).
        /// Can be a single element or an array of elements. This option is used by Sortables to control Drag-and-Drop between Sortables.
        /// </summary>
        public HtmlElement containment { get; set; }
        /// <summary>
        /// The droppable will only accept the Draggable if the Draggable is contained in the given elements (or element ids).
        /// Can be a single element or an array of elements. This option is used by Sortables to control Drag-and-Drop between Sortables.
        /// </summary>
        [JsProperty(Name = "containment")]
        public JsArray<JsString> containmentArray { get; set; }

        /// <summary>
        /// if set, the Droppable will have this additional CSS class when an accepted Draggable is hovered over it.
        /// </summary>
        public object hoverclass { get; set; }
        //TODO: type?

        /// <summary>
        /// If set to ‘horizontal’ or ‘vertical’ the droppable will only react to a Draggable if its overlapping by more than 50% in the given direction. Used by Sortables.
        /// </summary>
        public object overlap { get; set; }
        //TODO: type?

        /// <summary>
        /// OBSOLETE starting at v1.6.1 (mid-2006) boolean, defaults to true, stops processing hovering (don’t look for other Droppables that are under the Draggable)
        /// </summary>
        public bool greedy { get; set; }

        //TODO: callback
    }


    [JsType(JsMode.Prototype, Name = "Behaviours.Sortable", Export = false)]
    public class Sortable
    {
        /// <summary>
        /// Use Sortable.create('id_of_container',[options]); to create new Sortables.
        /// See Sortable.create. Furthermore, there are special requirements to get sortables to work in FF3 which are also covered in Sortable.create.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Sortable create(JsString id_of_container, SortableCreateOptions options) { return null; }
        /// <summary>
        /// Use Sortable.create('id_of_container',[options]); to create new Sortables.
        /// See Sortable.create. Furthermore, there are special requirements to get sortables to work in FF3 which are also covered in Sortable.create.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <returns></returns>
        public static Sortable create(JsString id_of_container) { return null; }

        public object sortables { get; set; }

        public void options(HtmlElement element) { }

        public void destroy(HtmlElement element) { }

        public void create(HtmlElement element, SortableCreateOptions options) { }

        /// <summary>
        /// Internal function, which may be overridden through the options parameter on creation
        /// </summary>
        /// <param name="element"></param>
        /// <param name="dropon"></param>
        /// <param name="overlap"></param>
        public void findElements(HtmlElement element, object dropon, object overlap) { }
        //TODO: ?

        public void onHover(HtmlElement element, object dropon, object overlap) { }
        //TODO: ?

        public void onEmptyHover(HtmlElement element, object dropon, object overlap) { }
        //TODO: ?

        public void unmark() { }

        public void mark() { }

        public void tree(HtmlElement element) { }

        //TODO: sequence (element)	
        //setSequence (element, new_sequence)	
        //serialize (element)

        /// <summary>
        /// The Sortable object also provides a function to serialize the Sortable in a format suitable for HTTP GET or POST requests.
        /// This can be used to submit the order of the Sortable via an Ajax call:
        /// Important: For this to work, the elements contained in your Sortable must have id attributes in the following form:
        /// id="string_identifier" 
        /// 
        /// //Example
        /// &lt;ol id="container_id">
        ///   &lt;li id="image_1">Item 1&lt;/li>
        ///   &lt;li id="image_2">Item 1&lt;/li>
        ///   &lt;li id="image_3">Item 1&lt;/li>
        /// &lt;/ol>
        /// Only the identifier part of the id attribute will be serialized. If you want to use an other form of id attributes, you need to implement your own serialization.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static JsString serialize(JsString id_of_container, SortableSerializeOptions options) { return null; }
        /// <summary>
        /// The Sortable object also provides a function to serialize the Sortable in a format suitable for HTTP GET or POST requests.
        /// This can be used to submit the order of the Sortable via an Ajax call:
        /// Important: For this to work, the elements contained in your Sortable must have id attributes in the following form:
        /// id="string_identifier" 
        /// 
        /// //Example
        /// &lt;ol id="container_id">
        ///   &lt;li id="image_1">Item 1&lt;/li>
        ///   &lt;li id="image_2">Item 1&lt;/li>
        ///   &lt;li id="image_3">Item 1&lt;/li>
        /// &lt;/ol>
        /// Only the identifier part of the id attribute will be serialized. If you want to use an other form of id attributes, you need to implement your own serialization.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <returns></returns>
        public static JsString serialize(JsString id_of_container) { return null; }

        /// <summary>
        /// The Sortable object also provides a function to get a sequence array of the id’s.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <returns></returns>
        public static JsArray<JsString> sequence(JsString id_of_container) { return null; }

    }

    [JsType(JsMode.Json)]
    public class SortableCreateOptions
    {
        /// <summary>
        /// Default: ‘li’
        /// The kind of tag (of the child elements of the container) that will be made sortable. For UL and OL containers, this is ‘LI’, you have to provide the tag kind for other sorts of child tags.
        /// </summary>
        public object tag { get; set; }
        //TODO: type?

        /// <summary>
        /// Default: (none)
        /// Further restricts the selection of child elements to only encompass elements with the given CSS class
        /// (or, if you provide an array of strings, on any of the classes).
        /// </summary>
        public object only { get; set; }
        //TODO: type?

        /// <summary>
        /// Default: ‘vertical’
        /// Either ‘vertical’ or ‘horizontal’. For floating sortables or horizontal lists, choose ‘horizontal’. Vertical lists should use ‘vertical’.
        /// </summary>
        public JsString overlap { get; set; }

        /// <summary>
        /// string, not set by default. If set to 'horizontal' or 'vertical' the drag will be constrained to take place only horizontally or vertically.
        /// </summary>
        public JsString constraint { get; set; }

        /// <summary>
        /// Default: (only within container)
        /// Enables dragging and dropping between Sortables. Takes an array of elements or element-ids (of the containers).
        /// Important note: To ensure that two way dragging between containers is possible, place all Sortable.create calls after the container elements
        /// </summary>
        public HtmlElement containment { get; set; }
        /// <summary>
        /// Default: (only within container)
        /// Enables dragging and dropping between Sortables. Takes an array of elements or element-ids (of the containers).
        /// Important note: To ensure that two way dragging between containers is possible, place all Sortable.create calls after the container elements
        /// </summary>
        [JsProperty(Name = "containment")]
        public JsArray<JsString> containmentArray { get; set; }

        /// <summary>
        /// Default:
        /// /^[^_\-](?:[A-Za-z0-9\-\_]*)[_](.*)$/
        /// The format that the id is computed from each item-id
        /// </summary>
        public object format { get; set; }
        //TODO: type?

        /// <summary>
        /// string or DOM reference, not set by default. As above, except now the value may be a string referencing a CSS class value.
        /// The first child/grandchild/etc. element found within the element that has this CSS class value will be used as the handle.
        /// </summary>
        [JsProperty(Name = "handle")]
        public JsString handleString { get; set; }
        /// <summary>
        /// string or DOM reference, not set by default. As above, except now the value may be a string referencing a CSS class value.
        /// The first child/grandchild/etc. element found within the element that has this CSS class value will be used as the handle.
        /// </summary>
        public HtmlElement handle { get; set; }

        /// <summary>
        /// Default: (none)
        /// Gives the created Droppables a hoverclass (see there).
        /// </summary>
        public object hoverclass { get; set; }
        //TODO: type?

        /// <summary>
        /// If set to true, dragged elements of the Sortable will be cloned and appear as “ghost”, i.e. a representation of their original element,
        /// instead of directly dragging the original element. See below for more details.
        /// </summary>
        public bool ghosting { get; set; }

        /// <summary>
        /// f set to true, the Sortable container will be made into a Droppable,
        /// that can receive a Draggable (as according to the containment rules) as a child element when there are no more elements inside.
        /// </summary>
        public bool dropOnEmpty { get; set; }

        /// <summary>
        /// Default: none
        /// When the sortable is contained in an element with style overflow:scroll, this value can be set to the ID of that container (or the container’s DOM object).
        /// The scroll position of the container will now move along when the sortable is dragged out of the viewable area.
        /// The container must have overflow:scroll set to include scroll bars. Does not yet work for scrolling the entire document.
        /// To get this to work correctly, include this line in your code before creating the sortable: Position.includeScrollOffsets = true;
        /// Update: Scrolling the whole document does work (at least on Safari 3.2 (Mac), IE7 and Firefox). Use scroll: window
        /// </summary>
        public object scroll { get; set; }
        //TODO: type?

        /// <summary>
        /// Default: 20
        /// Will start scrolling when element is x pixels from the bottom, where x is the scrollSensitivity.
        /// </summary>
        public JsNumber scrollSensitivity { get; set; }

        /// <summary>
        /// Default: 15
        /// Will scroll the element in increments of scrollSpeed pixels.
        /// </summary>
        public JsNumber scrollSpeed { get; set; }

        /// <summary>
        /// Default: false
        /// If true, sets sortable functionality to elements listed in treeTag
        /// </summary>
        public bool tree { get; set; }

        /// <summary>
        /// Default: ul
        /// The element type tree nodes are contained in.
        /// </summary>
        public object treeTag { get; set; }
        //TODO: type?

        //TODO: Callbacks

    }

    [JsType(JsMode.Json)]
    public class SortableSerializeOptions
    {

        /// <summary>
        /// The kind of tag (of the child elements of the container) that will be serialized.
        /// </summary>
        public object tag { get; set; }

        /// <summary>
        /// The name of the key that will be used to create the key/value pairs for serializing in HTTP GET/POST format (that is, key[]=value&key[]=value …)
        /// </summary>
        public JsString name { get; set; }
    }

    #endregion

    public class Builder
    {
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <returns></returns>
        public static Builder node(JsString elementName) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="attributes">Object, Typical attributes are id, className, style, onclick, etc.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, object attributes) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, JsArray children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, JsNumber children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, JsString children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="attributes">Object, Typical attributes are id, className, style, onclick, etc.</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, object attributes, JsArray children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="attributes">Object, Typical attributes are id, className, style, onclick, etc.</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, object attributes, JsNumber children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="attributes">Object, Typical attributes are id, className, style, onclick, etc.</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, object attributes, JsString children) { return null; }
    }

    public class Effect
    {
        //TODO: what should be in this class?
    }
}
