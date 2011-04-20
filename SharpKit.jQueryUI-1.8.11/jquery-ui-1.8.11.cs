using SharpKit.JavaScript;

namespace SharpKit.jQuery.UI
{
    public static class Accordion
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery accordion(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery accordion(this jQuery query, AccordionOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery accordion(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class AccordionOptions
    {
        // Methods
        public AccordionOptions(){}

        // Properties
        public object active { get; set; }
        public object animated { get; set; }
        public bool autoHeight { get; set; }
        public JsAction change { get; set; }
        public JsAction changestart { get; set; }
        public bool clearStyle { get; set; }
        public bool collapsible { get; set; }
        public string @event { get; set; }
        public bool fillSpace { get; set; }
        public object header { get; set; }
        public object icons { get; set; }
        public bool navigation { get; set; }
        public JsAction navigationFilter { get; set; }
    }

    public static class AddClass
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery addclass(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery addclass(this jQuery query, AddClassOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery addclass(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class AddClassOptions
    {
        // Methods
        public AddClassOptions(){}

        // Properties
        public string @class { get; set; }
        public object duration { get; set; }
    }

    public static class Datepicker
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery datepicker(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery datepicker(this jQuery query, DatepickerOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery datepicker(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class DatepickerOptions
    {
        // Methods
        public DatepickerOptions(){}

        // Properties
        public string altField { get; set; }
        public string altFormat { get; set; }
        public string appendText { get; set; }
        public JsAction beforeShow { get; set; }
        public JsAction beforeShowDay { get; set; }
        public string buttonImage { get; set; }
        public bool buttonImageOnly { get; set; }
        public string buttonText { get; set; }
        public bool changeMonth { get; set; }
        public bool changeYear { get; set; }
        public string closeText { get; set; }
        public bool constrainInput { get; set; }
        public string currentText { get; set; }
        public string dateFormat { get; set; }
        public JsArray dayNames { get; set; }
        public JsArray dayNamesMin { get; set; }
        public JsArray dayNamesShort { get; set; }
        public object defaultDate { get; set; }
        public object duration { get; set; }
        public int firstDay { get; set; }
        public bool gotoCurrent { get; set; }
        public bool hideIfNoPrevNext { get; set; }
        public bool isRTL { get; set; }
        public object maxDate { get; set; }
        public object minDate { get; set; }
        public JsArray monthNames { get; set; }
        public JsArray monthNamesShort { get; set; }
        public bool navigationAsDateFormat { get; set; }
        public string nextText { get; set; }
        public object numberOfMonths { get; set; }
        public JsAction onChangeMonthYear { get; set; }
        public JsAction onClose { get; set; }
        public JsAction onSelect { get; set; }
        public string prevText { get; set; }
        public object shortYearCutoff { get; set; }
        public string showAnim { get; set; }
        public bool showButtonPanel { get; set; }
        public int showCurrentAtPos { get; set; }
        public bool showMonthAfterYear { get; set; }
        public string showOn { get; set; }
        public JsObject showOptions { get; set; }
        public bool showOtherMonths { get; set; }
        public int stepMonths { get; set; }
        public string yearRange { get; set; }
    }

    public static class Dialog
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery dialog(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery dialog(this jQuery query, DialogOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery dialog(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class DialogOptions
    {
        // Methods
        public DialogOptions(){}

        // Properties
        public bool autoOpen { get; set; }
        public JsAction beforeclose { get; set; }
        public bool bgiframe { get; set; }
        public object buttons { get; set; }
        public JsAction close { get; set; }
        public bool closeOnEscape { get; set; }
        public string dialogClass { get; set; }
        public JsAction drag { get; set; }
        public bool draggable { get; set; }
        public JsAction dragStart { get; set; }
        public JsAction dragStop { get; set; }
        public JsAction focus { get; set; }
        public int height { get; set; }
        public string hide { get; set; }
        public int maxHeight { get; set; }
        public int maxWidth { get; set; }
        public int minHeight { get; set; }
        public int minWidth { get; set; }
        public bool modal { get; set; }
        public JsAction open { get; set; }
        public object position { get; set; }
        public bool resizable { get; set; }
        public JsAction resize { get; set; }
        public JsAction resizeStart { get; set; }
        public JsAction resizeStop { get; set; }
        public string show { get; set; }
        public bool stack { get; set; }
        public string title { get; set; }
        public int width { get; set; }
        public int zIndex { get; set; }
    }

    public static class Draggable
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery draggable(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery draggable(this jQuery query, DraggableOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery draggable(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class DraggableOptions
    {
        // Methods
        public DraggableOptions(){}

        // Properties
        public bool addClasses { get; set; }
        public object appendTo { get; set; }
        public string axis { get; set; }
        public string cancel { get; set; }
        public string connectToSortable { get; set; }
        public object containment { get; set; }
        public string cursor { get; set; }
        public object cursorAt { get; set; }
        public int delay { get; set; }
        public int distance { get; set; }
        public JsAction drag { get; set; }
        public JsArray grid { get; set; }
        public object handle { get; set; }
        public object helper { get; set; }
        public object iframeFix { get; set; }
        public float opacity { get; set; }
        public bool refreshPositions { get; set; }
        public object revert { get; set; }
        public int revertDuration { get; set; }
        public string scope { get; set; }
        public bool scroll { get; set; }
        public int scrollSensitivity { get; set; }
        public int scrollSpeed { get; set; }
        public object snap { get; set; }
        public string snapMode { get; set; }
        public int snapTolerance { get; set; }
        public object stack { get; set; }
        public JsAction start { get; set; }
        public JsAction stop { get; set; }
        public int zIndex { get; set; }
    }

    public static class Droppable
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery droppable(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery droppable(this jQuery query, DroppableOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery droppable(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class DroppableOptions
    {
        // Methods
        public DroppableOptions(){}

        // Properties
        public object accept { get; set; }
        public JsAction activate { get; set; }
        public string activeClass { get; set; }
        public bool addClasses { get; set; }
        public JsAction deactivate { get; set; }
        public JsAction drop { get; set; }
        public bool greedy { get; set; }
        public string hoverClass { get; set; }
        public JsAction @out { get; set; }
        public JsAction over { get; set; }
        public string scope { get; set; }
        public string tolerance { get; set; }
    }

    public static class Effect
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery effect(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery effect(this jQuery query, EffectOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery effect(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class EffectOptions
    {
        // Methods
        public EffectOptions(){}

        // Properties
        public JsAction callback { get; set; }
        public string effect { get; set; }
        public object options { get; set; }
        public object speed { get; set; }
    }

    public static class Hide
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery hide(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery hide(this jQuery query, HideOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery hide(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class HideOptions
    {
        // Methods
        public HideOptions(){}

        // Properties
        public JsAction callback { get; set; }
        public string effect { get; set; }
        public object options { get; set; }
        public object speed { get; set; }
    }

    public static class Progressbar
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery progressbar(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery progressbar(this jQuery query, ProgressbarOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery progressbar(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class ProgressbarOptions
    {
        // Methods
        public ProgressbarOptions(){}

        // Properties
        public JsAction change { get; set; }
        public int value { get; set; }
    }

    public static class RemoveClass
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery removeclass(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery removeclass(this jQuery query, RemoveClassOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery removeclass(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class RemoveClassOptions
    {
        // Methods
        public RemoveClassOptions(){}

        // Properties
        public string @class { get; set; }
        public object duration { get; set; }
    }

    public static class Resizable
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery resizable(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery resizable(this jQuery query, ResizableOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery resizable(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class ResizableOptions
    {
        // Methods
        public ResizableOptions(){}

        // Properties
        public object alsoResize { get; set; }
        public bool animate { get; set; }
        public object animateDuration { get; set; }
        public string animateEasing { get; set; }
        public object aspectRatio { get; set; }
        public bool autoHide { get; set; }
        public string cancel { get; set; }
        public object containment { get; set; }
        public int delay { get; set; }
        public int distance { get; set; }
        public bool ghost { get; set; }
        public JsArray grid { get; set; }
        public object handles { get; set; }
        public string helper { get; set; }
        public int maxHeight { get; set; }
        public int maxWidth { get; set; }
        public int minHeight { get; set; }
        public int minWidth { get; set; }
        public JsAction resize { get; set; }
        public JsAction start { get; set; }
        public JsAction stop { get; set; }
    }

    public static class Selectable
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery selectable(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery selectable(this jQuery query, SelectableOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery selectable(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class SelectableOptions
    {
        // Methods
        public SelectableOptions(){}

        // Properties
        public bool autoRefresh { get; set; }
        public string cancel { get; set; }
        public int delay { get; set; }
        public int distance { get; set; }
        public string filter { get; set; }
        public JsAction selected { get; set; }
        public JsAction selecting { get; set; }
        public JsAction start { get; set; }
        public JsAction stop { get; set; }
        public string tolerance { get; set; }
        public JsAction unselected { get; set; }
        public JsAction unselecting { get; set; }
    }

    public static class Show
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery show(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery show(this jQuery query, ShowOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery show(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class ShowOptions
    {
        // Methods
        public ShowOptions(){}

        // Properties
        public JsAction callback { get; set; }
        public string effect { get; set; }
        public object options { get; set; }
        public object speed { get; set; }
    }

    public static class Slider
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery slider(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery slider(this jQuery query, SliderOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery slider(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class SliderOptions
    {
        // Methods
        public SliderOptions(){}

        // Properties
        public bool animate { get; set; }
        public JsAction change { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public string orientation { get; set; }
        public object range { get; set; }
        public JsAction slide { get; set; }
        public JsAction start { get; set; }
        public int step { get; set; }
        public JsAction stop { get; set; }
        public int value { get; set; }
        public JsArray values { get; set; }
    }

    public static class Sortable
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery sortable(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery sortable(this jQuery query, SortableOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery sortable(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class SortableOptions
    {
        // Methods
        public SortableOptions(){}

        // Properties
        public JsAction activate { get; set; }
        public string appendTo { get; set; }
        public string axis { get; set; }
        public JsAction beforeStop { get; set; }
        public string cancel { get; set; }
        public JsAction change { get; set; }
        public string connectWith { get; set; }
        public object containment { get; set; }
        public string cursor { get; set; }
        public object cursorAt { get; set; }
        public JsAction deactivate { get; set; }
        public int delay { get; set; }
        public int distance { get; set; }
        public bool dropOnEmpty { get; set; }
        public bool forceHelperSize { get; set; }
        public bool forcePlaceholderSize { get; set; }
        public JsArray grid { get; set; }
        public object handle { get; set; }
        public object helper { get; set; }
        public string items { get; set; }
        public float opacity { get; set; }
        public JsAction @out { get; set; }
        public JsAction over { get; set; }
        public string placeholder { get; set; }
        public JsAction receive { get; set; }
        public JsAction remove { get; set; }
        public bool revert { get; set; }
        public bool scroll { get; set; }
        public int scrollSensitivity { get; set; }
        public int scrollSpeed { get; set; }
        public JsAction sort { get; set; }
        public JsAction start { get; set; }
        public JsAction stop { get; set; }
        public string tolerance { get; set; }
        public JsAction update { get; set; }
        public int zIndex { get; set; }
    }

    public static class SwitchClass
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery switchclass(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery switchclass(this jQuery query, SwitchClassOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery switchclass(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class SwitchClassOptions
    {
        // Methods
        public SwitchClassOptions(){}

        // Properties
        public string add { get; set; }
        public object duration { get; set; }
        public string remove { get; set; }
    }

    public static class Tabs
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery tabs(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery tabs(this jQuery query, TabsOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery tabs(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class TabsOptions
    {
        // Methods
        public TabsOptions(){}

        // Properties
        public JsObject ajaxOptions { get; set; }
        public bool cache { get; set; }
        public bool collapsible { get; set; }
        public object cookie { get; set; }
        public bool deselectable { get; set; }
        public JsArray<int> disabled { get; set; }
        public string @event { get; set; }
        public object fx { get; set; }
        public string idPrefix { get; set; }
        public string panelTemplate { get; set; }
        public int selected { get; set; }
        public string spinner { get; set; }
        public string tabTemplate { get; set; }
    }

    public static class Toggle
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery toggle(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery toggle(this jQuery query, ToggleOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery toggle(this jQuery query, string methodName, params object[] args){return null;}
    }

    public static class ToggleClass
    {
        // Methods
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery toggleclass(this jQuery query){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery toggleclass(this jQuery query, ToggleClassOptions options){return null;}
        [JsMethod(ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static jQuery toggleclass(this jQuery query, string methodName, params object[] args){return null;}
    }

    [JsType(JsMode.Json)]
    public class ToggleClassOptions
    {
        // Methods
        public ToggleClassOptions(){}

        // Properties
        public string @class { get; set; }
        public object duration { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ToggleOptions
    {
        // Methods
        public ToggleOptions(){}

        // Properties
        public JsAction callback { get; set; }
        public string effect { get; set; }
        public object options { get; set; }
        public object speed { get; set; }
    }
}

 
 
