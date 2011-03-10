using SharpKit.JavaScript;
using Ext.data;
using Ext.util;
using System;
using Ext.chart;
using Ext.menu;
using Ext.form;
using Ext.layout;
using Ext.dd;
using SharpKit.Html4;
namespace Ext
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Action
    {
        // Methods
        public Action() { throw new Exception(); }
        public Action(ActionConfig config) { throw new Exception(); }
        public Action(object config) { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void each() { throw new Exception(); }
        public void each(JsAction fn) { throw new Exception(); }
        public void each(JsAction fn, object scope) { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public void execute() { throw new Exception(); }
        public void execute(params object[] args) { throw new Exception(); }
        public void getIconClass() { throw new Exception(); }
        public void getText() { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public void isDisabled() { throw new Exception(); }
        public void isHidden() { throw new Exception(); }
        public void setDisabled() { throw new Exception(); }
        public void setDisabled(bool disabled) { throw new Exception(); }
        public void setHandler() { throw new Exception(); }
        public void setHandler(JsAction fn) { throw new Exception(); }
        public void setHandler(JsAction fn, object scope) { throw new Exception(); }
        public void setHidden() { throw new Exception(); }
        public void setHidden(bool hidden) { throw new Exception(); }
        public void setIconClass() { throw new Exception(); }
        public void setIconClass(string cls) { throw new Exception(); }
        public void setText() { throw new Exception(); }
        public void setText(string text) { throw new Exception(); }
        public void show() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool disabled { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction handler { get; set; }
        [JsProperty(NativeField = true)]
        public bool hidden { get; set; }
        [JsProperty(NativeField = true)]
        public string iconCls { get; set; }
        [JsProperty(NativeField = true)]
        public string itemId { get; set; }
        [JsProperty(NativeField = true)]
        public static JsAction prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public string text { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ActionConfig
    {
        // Methods
        public ActionConfig() { throw new Exception(); }

        // Properties
        public bool disabled { get; set; }
        public JsAction handler { get; set; }
        public bool hidden { get; set; }
        public string iconCls { get; set; }
        public string itemId { get; set; }
        public object scope { get; set; }
        public string text { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Ajax : Connection
    {
        // Methods
        public Ajax() { throw new Exception(); }
        public Ajax(AjaxConfig config) { throw new Exception(); }
        public Ajax(object config) { throw new Exception(); }
        public static void abort() { throw new Exception(); }
        public static void abort(double transactionId) { throw new Exception(); }
        public static void addEvents() { throw new Exception(); }
        public static void addEvents(object obj) { throw new Exception(); }
        public static void addListener() { throw new Exception(); }
        public static void addListener(string eventName) { throw new Exception(); }
        public static void addListener(string eventName, Delegate handler) { throw new Exception(); }
        public static void addListener(string eventName, Delegate handler, object scope) { throw new Exception(); }
        public static void addListener(string eventName, Delegate handler, object scope, object options) { throw new Exception(); }
        public static bool fireEvent() { throw new Exception(); }
        public static bool fireEvent(string eventName) { throw new Exception(); }
        public static bool fireEvent(string eventName, params object[] args) { throw new Exception(); }
        public static bool hasListener() { throw new Exception(); }
        public static bool hasListener(string eventName) { throw new Exception(); }
        public static bool isLoading() { throw new Exception(); }
        public static bool isLoading(double transactionId) { throw new Exception(); }
        public static void on() { throw new Exception(); }
        public static void on(string eventName) { throw new Exception(); }
        public static void on(string eventName, Delegate handler) { throw new Exception(); }
        public static void on(string eventName, Delegate handler, object scope) { throw new Exception(); }
        public static void on(string eventName, Delegate handler, object scope, object options) { throw new Exception(); }
        public static void purgeListeners() { throw new Exception(); }
        public static void removeListener() { throw new Exception(); }
        public static void removeListener(string eventName) { throw new Exception(); }
        public static void removeListener(string eventName, Delegate handler) { throw new Exception(); }
        public static void removeListener(string eventName, Delegate handler, object scope) { throw new Exception(); }
        public static double request(object options) { throw new Exception(); }
        public static void resumeEvents() { throw new Exception(); }
        public static string serializeForm() { throw new Exception(); }
        public static string serializeForm(HtmlElement form) { throw new Exception(); }
        public static string serializeForm(string form) { throw new Exception(); }
        public static void suspendEvents() { throw new Exception(); }
        public static void un() { throw new Exception(); }
        public static void un(string eventName) { throw new Exception(); }
        public static void un(string eventName, Delegate handler) { throw new Exception(); }
        public static void un(string eventName, Delegate handler, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static bool autoAbort { get; set; }
        [JsProperty(NativeField = true)]
        public static object defaultHeaders { get; set; }
        [JsProperty(NativeField = true)]
        public static bool disableCaching { get; set; }
        [JsProperty(NativeField = true)]
        public static object extraParams { get; set; }
        [JsProperty(NativeField = true)]
        public static string method { get; set; }
        [JsProperty(NativeField = true)]
        public static Ajax prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Connection superclass { get; set; }
        [JsProperty(NativeField = true)]
        public static double timeout { get; set; }
        [JsProperty(NativeField = true)]
        public static string url { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AjaxConfig
    {
        // Methods
        public AjaxConfig() { throw new Exception(); }

        // Properties
        public bool autoAbort { get; set; }
        public object defaultHeaders { get; set; }
        public bool disableCaching { get; set; }
        public string disableCachingParam { get; set; }
        public object extraParams { get; set; }
        public string method { get; set; }
        public double timeout { get; set; }
        public string url { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class BoxComponent : Component
    {
        // Methods
        public BoxComponent() { throw new Exception(); }
        public BoxComponent(BoxComponentConfig config) { throw new Exception(); }
        public BoxComponent(Element config) { throw new Exception(); }
        public BoxComponent(object config) { throw new Exception(); }
        public BoxComponent(string config) { throw new Exception(); }
        public object getBox() { throw new Exception(); }
        public object getBox(bool local) { throw new Exception(); }
        public double getHeight() { throw new Exception(); }
        public object getOuterSize() { throw new Exception(); }
        public Array getPosition() { throw new Exception(); }
        public Array getPosition(bool local) { throw new Exception(); }
        public Element getResizeEl() { throw new Exception(); }
        public object getSize() { throw new Exception(); }
        public double getWidth() { throw new Exception(); }
        public BoxComponent setAutoScroll() { throw new Exception(); }
        public BoxComponent setAutoScroll(bool scroll) { throw new Exception(); }
        public BoxComponent setHeight() { throw new Exception(); }
        public BoxComponent setHeight(double height) { throw new Exception(); }
        public BoxComponent setPagePosition() { throw new Exception(); }
        public BoxComponent setPagePosition(double x) { throw new Exception(); }
        public BoxComponent setPagePosition(double x, double y) { throw new Exception(); }
        public BoxComponent setPosition() { throw new Exception(); }
        public BoxComponent setPosition(double left) { throw new Exception(); }
        public BoxComponent setPosition(double left, double top) { throw new Exception(); }
        public BoxComponent setSize() { throw new Exception(); }
        public BoxComponent setSize(object width) { throw new Exception(); }
        public BoxComponent setSize(object width, object height) { throw new Exception(); }
        public BoxComponent setWidth() { throw new Exception(); }
        public BoxComponent setWidth(double width) { throw new Exception(); }
        public BoxComponent syncSize() { throw new Exception(); }
        public BoxComponent updateBox() { throw new Exception(); }
        public BoxComponent updateBox(object box) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool autoHeight { get; set; }
        [JsProperty(NativeField = true)]
        public bool autoScroll { get; set; }
        [JsProperty(NativeField = true)]
        public bool autoWidth { get; set; }
        [JsProperty(NativeField = true)]
        public double boxMaxHeight { get; set; }
        [JsProperty(NativeField = true)]
        public double boxMaxWidth { get; set; }
        [JsProperty(NativeField = true)]
        public double boxMinHeight { get; set; }
        [JsProperty(NativeField = true)]
        public double boxMinWidth { get; set; }
        [JsProperty(NativeField = true)]
        public double height { get; set; }
        [JsProperty(NativeField = true)]
        public object margins { get; set; }
        [JsProperty(NativeField = true)]
        public double pageX { get; set; }
        [JsProperty(NativeField = true)]
        public double pageY { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string region { get; set; }
        [JsProperty(NativeField = true)]
        public static Component superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string tabTip { get; set; }
        [JsProperty(NativeField = true)]
        public double width { get; set; }
        [JsProperty(NativeField = true)]
        public double x { get; set; }
        [JsProperty(NativeField = true)]
        public double y { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BoxComponentConfig
    {
        // Methods
        public BoxComponentConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class BoxComponentEvents
    {
        // Methods
        public BoxComponentEvents() { throw new Exception(); }

        // Properties
        public static string move { get { throw new Exception(); } }
        public static string resize { get { throw new Exception(); } }
    }

    public delegate void BoxComponentMoveDelegate(Component objthis, double x, double y);

    public delegate void BoxComponentResizeDelegate(Component objthis, double adjWidth, double adjHeight, double rawWidth, double rawHeight);

    [JsType(JsMode.Prototype, Export = false)]
    public class Button : BoxComponent
    {
        // Methods
        public Button() { throw new Exception(); }
        public Button(ButtonConfig config) { throw new Exception(); }
        public Button(Element config) { throw new Exception(); }
        public Button(object config) { throw new Exception(); }
        public Button(string config) { throw new Exception(); }
        public void focus() { throw new Exception(); }
        public Button getPressed() { throw new Exception(); }
        public Button getPressed(string group) { throw new Exception(); }
        public Array getTemplateArgs() { throw new Exception(); }
        public string getText() { throw new Exception(); }
        public bool hasVisibleMenu() { throw new Exception(); }
        public void hideMenu() { throw new Exception(); }
        public Button setHandler() { throw new Exception(); }
        public Button setHandler(JsAction handler) { throw new Exception(); }
        public Button setHandler(JsAction handler, object scope) { throw new Exception(); }
        public Button setIcon() { throw new Exception(); }
        public Button setIcon(string icon) { throw new Exception(); }
        public Button setIconClass() { throw new Exception(); }
        public Button setIconClass(string cls) { throw new Exception(); }
        public Button setText() { throw new Exception(); }
        public Button setText(string text) { throw new Exception(); }
        public Button setTooltip() { throw new Exception(); }
        public Button setTooltip(object tooltip) { throw new Exception(); }
        public Button setTooltip(string tooltip) { throw new Exception(); }
        public void showMenu() { throw new Exception(); }
        public Button toggle() { throw new Exception(); }
        public Button toggle(bool state) { throw new Exception(); }
        public Button toggle(bool state, bool supressEvent) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowDepress { get; set; }
        [JsProperty(NativeField = true)]
        public string arrowAlign { get; set; }
        [JsProperty(NativeField = true)]
        public Element btnEl { get; set; }
        [JsProperty(NativeField = true)]
        public string buttonSelector { get; set; }
        [JsProperty(NativeField = true)]
        public string clickEvent { get; set; }
        [JsProperty(NativeField = true)]
        public string cls { get; set; }
        [JsProperty(NativeField = true)]
        public bool disabled { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableToggle { get; set; }
        [JsProperty(NativeField = true)]
        public bool handleMouseEvents { get; set; }
        [JsProperty(NativeField = true)]
        public bool hidden { get; set; }
        [JsProperty(NativeField = true)]
        public string iconAlign { get; set; }
        [JsProperty(NativeField = true)]
        public string iconCls { get; set; }
        [JsProperty(NativeField = true)]
        public object menu { get; set; }
        [JsProperty(NativeField = true)]
        public string menuAlign { get; set; }
        [JsProperty(NativeField = true)]
        public string overflowText { get; set; }
        [JsProperty(NativeField = true)]
        public bool pressed { get; set; }
        [JsProperty(NativeField = true)]
        public static Button prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string scale { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double tabIndex { get; set; }
        [JsProperty(NativeField = true)]
        public Template template { get; set; }
        [JsProperty(NativeField = true)]
        public string text { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction toggleHandler { get; set; }
        [JsProperty(NativeField = true)]
        public string tooltipType { get; set; }
        [JsProperty(NativeField = true)]
        public string type { get; set; }
    }

    public delegate void ButtonClickDelegate(Button objthis, EventObject e);

    [JsType(JsMode.Json)]
    public class ButtonConfig
    {
        // Methods
        public ButtonConfig() { throw new Exception(); }

        // Properties
        public bool allowDepress { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public string arrowAlign { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string buttonSelector { get; set; }
        public string clearCls { get; set; }
        public string clickEvent { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool enableToggle { get; set; }
        public string fieldLabel { get; set; }
        public bool handleMouseEvents { get; set; }
        public JsAction handler { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string icon { get; set; }
        public string iconAlign { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object menu { get; set; }
        public string menuAlign { get; set; }
        public double minWidth { get; set; }
        public string overCls { get; set; }
        public string overflowText { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool pressed { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object repeat { get; set; }
        public string scale { get; set; }
        public object scope { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public Template template { get; set; }
        public string text { get; set; }
        public string toggleGroup { get; set; }
        public JsAction toggleHandler { get; set; }
        public object tooltip { get; set; }
        public string tooltipType { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string type { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class ButtonEvents
    {
        // Methods
        public ButtonEvents() { throw new Exception(); }

        // Properties
        public static string click { get { throw new Exception(); } }
        public static string menuhide { get { throw new Exception(); } }
        public static string menushow { get { throw new Exception(); } }
        public static string menutriggerout { get { throw new Exception(); } }
        public static string menutriggerover { get { throw new Exception(); } }
        public static string mouseout { get { throw new Exception(); } }
        public static string mouseover { get { throw new Exception(); } }
        public static string toggle { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ButtonGroup : Panel
    {
        // Methods
        public ButtonGroup() { throw new Exception(); }
        public ButtonGroup(ButtonGroupConfig config) { throw new Exception(); }
        public ButtonGroup(Element config) { throw new Exception(); }
        public ButtonGroup(object config) { throw new Exception(); }
        public ButtonGroup(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string baseCls { get; set; }
        [JsProperty(NativeField = true)]
        public double columns { get; set; }
        [JsProperty(NativeField = true)]
        public bool frame { get; set; }
        [JsProperty(NativeField = true)]
        public string layout { get; set; }
        [JsProperty(NativeField = true)]
        public static ButtonGroup prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ButtonGroupConfig
    {
        // Methods
        public ButtonGroupConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public double columns { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double minButtonWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool unstyled { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void ButtonMenuhideDelegate(Button objthis, Menu menu);

    public delegate void ButtonMenushowDelegate(Button objthis, Menu menu);

    public delegate void ButtonMenutriggeroutDelegate(Button objthis, Menu menu, EventObject e);

    public delegate void ButtonMenutriggeroverDelegate(Button objthis, Menu menu, EventObject e);

    public delegate void ButtonMouseoutDelegate(Button objthis, HtmlDomEventArgs e);

    public delegate void ButtonMouseoverDelegate(Button objthis, HtmlDomEventArgs e);

    public delegate void ButtonToggleDelegate(Button objthis, bool pressed);

    [JsType(JsMode.Prototype, Export = false)]
    public class ColorPalette : Component
    {
        // Methods
        public ColorPalette() { throw new Exception(); }
        public ColorPalette(ColorPaletteConfig config) { throw new Exception(); }
        public ColorPalette(Element config) { throw new Exception(); }
        public ColorPalette(object config) { throw new Exception(); }
        public ColorPalette(string config) { throw new Exception(); }
        public void select() { throw new Exception(); }
        public void select(string color) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowReselect { get; set; }
        [JsProperty(NativeField = true)]
        public string clickEvent { get; set; }
        [JsProperty(NativeField = true)]
        public Array colors { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction handler { get; set; }
        [JsProperty(NativeField = true)]
        public string itemCls { get; set; }
        [JsProperty(NativeField = true)]
        public static ColorPalette prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public static Component superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string tpl { get; set; }
        [JsProperty(NativeField = true)]
        public string value { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ColorPaletteConfig
    {
        // Methods
        public ColorPaletteConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public bool allowReselect { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public string clearCls { get; set; }
        public string clickEvent { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public JsAction handler { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string value { get; set; }
        public string xtype { get; set; }
    }

    public class ColorPaletteEvents
    {
        // Methods
        public ColorPaletteEvents() { throw new Exception(); }

        // Properties
        public static string select { get { throw new Exception(); } }
    }

    public delegate void ColorPaletteSelectDelegate(ColorPalette objthis, string color);

    [JsType(JsMode.Prototype, Export = false)]
    public class Component : Observable
    {
        // Methods
        public Component() { throw new Exception(); }
        public Component(ComponentConfig config) { throw new Exception(); }
        public Component(Element config) { throw new Exception(); }
        public Component(object config) { throw new Exception(); }
        public Component(string config) { throw new Exception(); }
        public Component addClass() { throw new Exception(); }
        public Component addClass(string cls) { throw new Exception(); }
        public void applyToMarkup() { throw new Exception(); }
        public void applyToMarkup(HtmlElement el) { throw new Exception(); }
        public void applyToMarkup(string el) { throw new Exception(); }
        public Component cloneConfig() { throw new Exception(); }
        public Component cloneConfig(object overrides) { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public Component disable() { throw new Exception(); }
        public Component enable() { throw new Exception(); }
        public Container findParentBy() { throw new Exception(); }
        public Container findParentBy(JsAction fn) { throw new Exception(); }
        public Container findParentByType() { throw new Exception(); }
        public Container findParentByType(object xtype) { throw new Exception(); }
        public Container findParentByType(string xtype) { throw new Exception(); }
        public Component focus() { throw new Exception(); }
        public Component focus(bool selectText) { throw new Exception(); }
        public Component focus(bool selectText, bool delay) { throw new Exception(); }
        public Component focus(bool selectText, double delay) { throw new Exception(); }
        public Container getBubbleTarget() { throw new Exception(); }
        public Element getEl() { throw new Exception(); }
        public string getId() { throw new Exception(); }
        public string getItemId() { throw new Exception(); }
        public string getXType() { throw new Exception(); }
        public string getXTypes() { throw new Exception(); }
        public Component hide() { throw new Exception(); }
        public bool isVisible() { throw new Exception(); }
        public bool isXType() { throw new Exception(); }
        public bool isXType(string xtype) { throw new Exception(); }
        public bool isXType(string xtype, bool shallow) { throw new Exception(); }
        public void mon() { throw new Exception(); }
        public void mon(object item) { throw new Exception(); }
        public void mon(object item, object ename) { throw new Exception(); }
        public void mon(object item, object ename, JsAction fn) { throw new Exception(); }
        public void mon(object item, object ename, JsAction fn, object scope) { throw new Exception(); }
        public void mon(object item, object ename, JsAction fn, object scope, object opt) { throw new Exception(); }
        public void mun() { throw new Exception(); }
        public void mun(object item) { throw new Exception(); }
        public void mun(object item, object ename) { throw new Exception(); }
        public void mun(object item, object ename, JsAction fn) { throw new Exception(); }
        public void mun(object item, object ename, JsAction fn, object scope) { throw new Exception(); }
        public Component nextSibling() { throw new Exception(); }
        public Component previousSibling() { throw new Exception(); }
        public Component removeClass() { throw new Exception(); }
        public Component removeClass(string cls) { throw new Exception(); }
        public void render() { throw new Exception(); }
        public void render(Element container) { throw new Exception(); }
        public void render(HtmlElement container) { throw new Exception(); }
        public void render(string container) { throw new Exception(); }
        public void render(Element container, double position) { throw new Exception(); }
        public void render(Element container, string position) { throw new Exception(); }
        public void render(HtmlElement container, double position) { throw new Exception(); }
        public void render(HtmlElement container, string position) { throw new Exception(); }
        public void render(string container, double position) { throw new Exception(); }
        public void render(string container, string position) { throw new Exception(); }
        public Component setDisabled() { throw new Exception(); }
        public Component setDisabled(bool disabled) { throw new Exception(); }
        public Component setVisible() { throw new Exception(); }
        public Component setVisible(bool visible) { throw new Exception(); }
        public Component show() { throw new Exception(); }
        public void update() { throw new Exception(); }
        public void update(object htmlOrData) { throw new Exception(); }
        public void update(object htmlOrData, bool loadScripts) { throw new Exception(); }
        public void update(object htmlOrData, bool loadScripts, JsAction callback) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowDomMove { get; set; }
        [JsProperty(NativeField = true)]
        public string anchor { get; set; }
        [JsProperty(NativeField = true)]
        public object applyTo { get; set; }
        [JsProperty(NativeField = true)]
        public object autoEl { get; set; }
        [JsProperty(NativeField = true)]
        public bool autoShow { get; set; }
        [JsProperty(NativeField = true)]
        public string clearCls { get; set; }
        [JsProperty(NativeField = true)]
        public string cls { get; set; }
        [JsProperty(NativeField = true)]
        public string contentEl { get; set; }
        [JsProperty(NativeField = true)]
        public string ctCls { get; set; }
        [JsProperty(NativeField = true)]
        public object data { get; set; }
        [JsProperty(NativeField = true)]
        public bool disabled { get; set; }
        [JsProperty(NativeField = true)]
        public string disabledClass { get; set; }
        [JsProperty(NativeField = true)]
        public Element el { get; set; }
        [JsProperty(NativeField = true)]
        public string fieldLabel { get; set; }
        [JsProperty(NativeField = true)]
        public bool hidden { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideLabel { get; set; }
        [JsProperty(NativeField = true)]
        public string hideMode { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideParent { get; set; }
        [JsProperty(NativeField = true)]
        public object html { get; set; }
        [JsProperty(NativeField = true)]
        public string id { get; set; }
        [JsProperty(NativeField = true)]
        public object initialConfig { get; set; }
        [JsProperty(NativeField = true)]
        public string itemCls { get; set; }
        [JsProperty(NativeField = true)]
        public string itemId { get; set; }
        [JsProperty(NativeField = true)]
        public string labelSeparator { get; set; }
        [JsProperty(NativeField = true)]
        public string labelStyle { get; set; }
        [JsProperty(NativeField = true)]
        public string overCls { get; set; }
        [JsProperty(NativeField = true)]
        public Container ownerCt { get; set; }
        [JsProperty(NativeField = true)]
        public object plugins { get; set; }
        [JsProperty(NativeField = true)]
        public static Component prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string ptype { get; set; }
        [JsProperty(NativeField = true)]
        public string @ref { get; set; }
        [JsProperty(NativeField = true)]
        public Container refOwner { get; set; }
        [JsProperty(NativeField = true)]
        public bool rendered { get; set; }
        [JsProperty(NativeField = true)]
        public object renderTo { get; set; }
        [JsProperty(NativeField = true)]
        public Array stateEvents { get; set; }
        [JsProperty(NativeField = true)]
        public bool stateful { get; set; }
        [JsProperty(NativeField = true)]
        public string stateId { get; set; }
        [JsProperty(NativeField = true)]
        public string style { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object tpl { get; set; }
        [JsProperty(NativeField = true)]
        public string tplWriteMode { get; set; }
        [JsProperty(NativeField = true)]
        public string xtype { get; set; }
    }

    public delegate void ComponentAddedDelegate(Component objthis, Container ownerCt, int index);

    public delegate void ComponentAfterrenderDelegate(Component objthis);

    public delegate void ComponentBeforedestroyDelegate(Component objthis);

    public delegate void ComponentBeforehideDelegate(Component objthis);

    public delegate void ComponentBeforerenderDelegate(Component objthis);

    public delegate void ComponentBeforeshowDelegate(Component objthis);

    public delegate void ComponentBeforestaterestoreDelegate(Component objthis, object state);

    public delegate void ComponentBeforestatesaveDelegate(Component objthis, object state);

    [JsType(JsMode.Json)]
    public class ComponentConfig
    {
        // Methods
        public ComponentConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string xtype { get; set; }
    }

    public delegate void ComponentDestroyDelegate(Component objthis);

    public delegate void ComponentDisableDelegate(Component objthis);

    public delegate void ComponentEnableDelegate(Component objthis);

    public class ComponentEvents
    {
        // Methods
        public ComponentEvents() { throw new Exception(); }

        // Properties
        public static string added { get { throw new Exception(); } }
        public static string afterrender { get { throw new Exception(); } }
        public static string beforedestroy { get { throw new Exception(); } }
        public static string beforehide { get { throw new Exception(); } }
        public static string beforerender { get { throw new Exception(); } }
        public static string beforeshow { get { throw new Exception(); } }
        public static string beforestaterestore { get { throw new Exception(); } }
        public static string beforestatesave { get { throw new Exception(); } }
        public static string destroy { get { throw new Exception(); } }
        public static string disable { get { throw new Exception(); } }
        public static string enable { get { throw new Exception(); } }
        public static string hide { get { throw new Exception(); } }
        public static string removed { get { throw new Exception(); } }
        public static string render { get { throw new Exception(); } }
        public static string show { get { throw new Exception(); } }
        public static string staterestore { get { throw new Exception(); } }
        public static string statesave { get { throw new Exception(); } }
    }

    public delegate void ComponentHideDelegate(Component objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class ComponentMgr
    {
        // Methods
        public ComponentMgr() { throw new Exception(); }
        public static Component create() { throw new Exception(); }
        public static Component create(object config) { throw new Exception(); }
        public static Component create(object config, JsAction defaultType) { throw new Exception(); }
        public static Component createPlugin() { throw new Exception(); }
        public static Component createPlugin(object config) { throw new Exception(); }
        public static Component createPlugin(object config, JsAction defaultType) { throw new Exception(); }
        public static Component get() { throw new Exception(); }
        public static Component get(string id) { throw new Exception(); }
        public static bool isRegistered() { throw new Exception(); }
        public static bool isRegistered(Component xtype) { throw new Exception(); }
        public static void onAvailable() { throw new Exception(); }
        public static void onAvailable(string id) { throw new Exception(); }
        public static void onAvailable(string id, JsAction fn) { throw new Exception(); }
        public static void onAvailable(string id, JsAction fn, object scope) { throw new Exception(); }
        public static void register() { throw new Exception(); }
        public static void register(Component c) { throw new Exception(); }
        public static void registerPlugin() { throw new Exception(); }
        public static void registerPlugin(string ptype) { throw new Exception(); }
        public static void registerPlugin(string ptype, JsAction cls) { throw new Exception(); }
        public static void registerType() { throw new Exception(); }
        public static void registerType(string xtype) { throw new Exception(); }
        public static void registerType(string xtype, JsAction cls) { throw new Exception(); }
        public static void unregister() { throw new Exception(); }
        public static void unregister(Component c) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static MixedCollection all { get; set; }
        [JsProperty(NativeField = true)]
        public static ComponentMgr prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ComponentMgrConfig
    {
        // Methods
        public ComponentMgrConfig() { throw new Exception(); }
    }

    public delegate void ComponentRemovedDelegate(Component objthis, Container ownerCt);

    public delegate void ComponentRenderDelegate(Component objthis);

    public delegate void ComponentShowDelegate(Component objthis);

    public delegate void ComponentStaterestoreDelegate(Component objthis, object state);

    public delegate void ComponentStatesaveDelegate(Component objthis, object state);

    [JsType(JsMode.Prototype, Export = false)]
    public class CompositeElement : CompositeElementLite
    {
        // Methods
        public CompositeElement() { throw new Exception(); }
        public Element addClass() { throw new Exception(); }
        public Element addClass(Array className) { throw new Exception(); }
        public Element addClass(string className) { throw new Exception(); }
        public Element addClassOnClick() { throw new Exception(); }
        public Element addClassOnClick(string className) { throw new Exception(); }
        public Element addClassOnFocus() { throw new Exception(); }
        public Element addClassOnFocus(string className) { throw new Exception(); }
        public Element addClassOnOver() { throw new Exception(); }
        public Element addClassOnOver(string className) { throw new Exception(); }
        public Element addClassOnOver(string className, bool preventFlicker) { throw new Exception(); }
        public KeyMap addKeyListener() { throw new Exception(); }
        public KeyMap addKeyListener(Array key) { throw new Exception(); }
        public KeyMap addKeyListener(int key) { throw new Exception(); }
        public KeyMap addKeyListener(object key) { throw new Exception(); }
        public KeyMap addKeyListener(string key) { throw new Exception(); }
        public KeyMap addKeyListener(Array key, JsAction fn) { throw new Exception(); }
        public KeyMap addKeyListener(int key, JsAction fn) { throw new Exception(); }
        public KeyMap addKeyListener(object key, JsAction fn) { throw new Exception(); }
        public KeyMap addKeyListener(string key, JsAction fn) { throw new Exception(); }
        public KeyMap addKeyListener(Array key, JsAction fn, object scope) { throw new Exception(); }
        public KeyMap addKeyListener(int key, JsAction fn, object scope) { throw new Exception(); }
        public KeyMap addKeyListener(object key, JsAction fn, object scope) { throw new Exception(); }
        public KeyMap addKeyListener(string key, JsAction fn, object scope) { throw new Exception(); }
        public KeyMap addKeyMap() { throw new Exception(); }
        public KeyMap addKeyMap(object config) { throw new Exception(); }
        public void addListener() { throw new Exception(); }
        public void addListener(string eventName) { throw new Exception(); }
        public void addListener(string eventName, JsAction fn) { throw new Exception(); }
        public void addListener(string eventName, JsAction fn, object scope) { throw new Exception(); }
        public void addListener(string eventName, JsAction fn, object scope, object options) { throw new Exception(); }
        public Element alignTo() { throw new Exception(); }
        public Element alignTo(object element) { throw new Exception(); }
        public Element alignTo(object element, string position) { throw new Exception(); }
        public Element alignTo(object element, string position, Array offsets) { throw new Exception(); }
        public Element alignTo(object element, string position, Array offsets, bool animate) { throw new Exception(); }
        public Element alignTo(object element, string position, Array offsets, object animate) { throw new Exception(); }
        public Element anchorTo() { throw new Exception(); }
        public Element anchorTo(object element) { throw new Exception(); }
        public Element anchorTo(object element, string position) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, bool animate) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, object animate) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, bool animate, bool monitorScroll) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, bool animate, int monitorScroll) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, object animate, bool monitorScroll) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, object animate, int monitorScroll) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, bool animate, bool monitorScroll, Delegate callback) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, bool animate, int monitorScroll, Delegate callback) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, object animate, bool monitorScroll, Delegate callback) { throw new Exception(); }
        public Element anchorTo(object element, string position, Array offsets, object animate, int monitorScroll, Delegate callback) { throw new Exception(); }
        public Element animate() { throw new Exception(); }
        public Element animate(object args) { throw new Exception(); }
        public Element animate(object args, double duration) { throw new Exception(); }
        public Element animate(object args, double duration, Delegate onComplete) { throw new Exception(); }
        public Element animate(object args, double duration, Delegate onComplete, string easing) { throw new Exception(); }
        public Element animate(object args, double duration, Delegate onComplete, string easing, string animType) { throw new Exception(); }
        public Element appendChild() { throw new Exception(); }
        public Element appendChild(CompositeElement el) { throw new Exception(); }
        public Element appendChild(Element el) { throw new Exception(); }
        public Element appendChild(HtmlElement el) { throw new Exception(); }
        public Element appendChild(Array el) { throw new Exception(); }
        public Element appendChild(string el) { throw new Exception(); }
        public Element appendTo() { throw new Exception(); }
        public Element appendTo(object el) { throw new Exception(); }
        public Element applyStyles() { throw new Exception(); }
        public Element applyStyles(Delegate styles) { throw new Exception(); }
        public Element applyStyles(object styles) { throw new Exception(); }
        public Element applyStyles(string styles) { throw new Exception(); }
        public Element autoHeight() { throw new Exception(); }
        public Element autoHeight(bool animate) { throw new Exception(); }
        public Element autoHeight(bool animate, double duration) { throw new Exception(); }
        public Element autoHeight(bool animate, double duration, Delegate onComplete) { throw new Exception(); }
        public Element autoHeight(bool animate, double duration, Delegate onComplete, string easing) { throw new Exception(); }
        public Element blur() { throw new Exception(); }
        public Element boxWrap() { throw new Exception(); }
        public Element boxWrap(string cls) { throw new Exception(); }
        public void center() { throw new Exception(); }
        public void center(object centerIn) { throw new Exception(); }
        public object child() { throw new Exception(); }
        public object child(string selector) { throw new Exception(); }
        public object child(string selector, bool returnDom) { throw new Exception(); }
        public void clean() { throw new Exception(); }
        public void clean(bool forceReclean) { throw new Exception(); }
        public Element clearOpacity() { throw new Exception(); }
        public Element clearPositioning() { throw new Exception(); }
        public Element clearPositioning(string value) { throw new Exception(); }
        public Element clip() { throw new Exception(); }
        public bool contains(HtmlElement el) { throw new Exception(); }
        public bool contains(string el) { throw new Exception(); }
        public Element createChild() { throw new Exception(); }
        public Element createChild(object config) { throw new Exception(); }
        public Element createChild(object config, HtmlElement insertBefore) { throw new Exception(); }
        public Element createChild(object config, HtmlElement insertBefore, bool returnDom) { throw new Exception(); }
        public Element createProxy() { throw new Exception(); }
        public Element createProxy(object config) { throw new Exception(); }
        public Element createProxy(string config) { throw new Exception(); }
        public Element createProxy(object config, HtmlElement renderTo) { throw new Exception(); }
        public Element createProxy(object config, string renderTo) { throw new Exception(); }
        public Element createProxy(string config, HtmlElement renderTo) { throw new Exception(); }
        public Element createProxy(string config, string renderTo) { throw new Exception(); }
        public Element createProxy(object config, HtmlElement renderTo, bool matchBox) { throw new Exception(); }
        public Element createProxy(object config, string renderTo, bool matchBox) { throw new Exception(); }
        public Element createProxy(string config, HtmlElement renderTo, bool matchBox) { throw new Exception(); }
        public Element createProxy(string config, string renderTo, bool matchBox) { throw new Exception(); }
        public Element createShim() { throw new Exception(); }
        public object down() { throw new Exception(); }
        public object down(string selector) { throw new Exception(); }
        public object down(string selector, bool returnDom) { throw new Exception(); }
        public Element enableDisplayMode() { throw new Exception(); }
        public Element enableDisplayMode(string display) { throw new Exception(); }
        public Element fadeIn(object options) { throw new Exception(); }
        public Element fadeOut(object options) { throw new Exception(); }
        public HtmlElement findParent() { throw new Exception(); }
        public HtmlElement findParent(string selector) { throw new Exception(); }
        public HtmlElement findParent(string selector, int maxDepth) { throw new Exception(); }
        public HtmlElement findParent(string selector, object maxDepth) { throw new Exception(); }
        public HtmlElement findParent(string selector, int maxDepth, bool returnEl) { throw new Exception(); }
        public HtmlElement findParent(string selector, object maxDepth, bool returnEl) { throw new Exception(); }
        public HtmlElement findParentNode() { throw new Exception(); }
        public HtmlElement findParentNode(string selector) { throw new Exception(); }
        public HtmlElement findParentNode(string selector, int maxDepth) { throw new Exception(); }
        public HtmlElement findParentNode(string selector, object maxDepth) { throw new Exception(); }
        public HtmlElement findParentNode(string selector, int maxDepth, bool returnEl) { throw new Exception(); }
        public HtmlElement findParentNode(string selector, object maxDepth, bool returnEl) { throw new Exception(); }
        public object first(string selector) { throw new Exception(); }
        public object first(string selector, bool returnDom) { throw new Exception(); }
        public static Element fly() { throw new Exception(); }
        public static Element fly(HtmlElement el) { throw new Exception(); }
        public static Element fly(string el) { throw new Exception(); }
        public static Element fly(HtmlElement el, string named) { throw new Exception(); }
        public static Element fly(string el, string named) { throw new Exception(); }
        public Element focus() { throw new Exception(); }
        public Element frame(string color, int count, object options) { throw new Exception(); }
        public static Element get() { throw new Exception(); }
        public static Element get(object el) { throw new Exception(); }
        public Array getAlignToXY() { throw new Exception(); }
        public Array getAlignToXY(object element) { throw new Exception(); }
        public Array getAlignToXY(object element, string position) { throw new Exception(); }
        public Array getAlignToXY(object element, string position, Array offsets) { throw new Exception(); }
        public Array getAnchorXY() { throw new Exception(); }
        public Array getAnchorXY(string anchor) { throw new Exception(); }
        public Array getAnchorXY(string anchor, object size) { throw new Exception(); }
        public Array getAnchorXY(string anchor, object size, bool local) { throw new Exception(); }
        public string getAttributeNS() { throw new Exception(); }
        public string getAttributeNS(string ns) { throw new Exception(); }
        public string getAttributeNS(string ns, string name) { throw new Exception(); }
        public int getBorderWidth() { throw new Exception(); }
        public int getBorderWidth(string side) { throw new Exception(); }
        public int getBottom() { throw new Exception(); }
        public int getBottom(bool local) { throw new Exception(); }
        public object getBox() { throw new Exception(); }
        public object getBox(bool contentBox) { throw new Exception(); }
        public object getBox(bool contentBox, bool local) { throw new Exception(); }
        public Array getCenterXY() { throw new Exception(); }
        public void getColor() { throw new Exception(); }
        public void getColor(string attr) { throw new Exception(); }
        public void getColor(string attr, string defaultValue) { throw new Exception(); }
        public void getColor(string attr, string defaultValue, string prefix) { throw new Exception(); }
        public int getComputedHeight() { throw new Exception(); }
        public int getComputedWidth() { throw new Exception(); }
        public int getFrameWidth() { throw new Exception(); }
        public int getFrameWidth(string sides) { throw new Exception(); }
        public int getHeight() { throw new Exception(); }
        public int getHeight(bool contentHeight) { throw new Exception(); }
        public int getLeft() { throw new Exception(); }
        public int getLeft(bool local) { throw new Exception(); }
        public object getMargins() { throw new Exception(); }
        public object getMargins(string sides) { throw new Exception(); }
        public Array getOffsetsTo() { throw new Exception(); }
        public Array getOffsetsTo(object element) { throw new Exception(); }
        public int getPadding() { throw new Exception(); }
        public int getPadding(string side) { throw new Exception(); }
        public object getPositioning() { throw new Exception(); }
        public object getRegion() { throw new Exception(); }
        public int getRight() { throw new Exception(); }
        public int getRight(bool local) { throw new Exception(); }
        public object getScroll() { throw new Exception(); }
        public object getSize() { throw new Exception(); }
        public object getSize(bool contentSize) { throw new Exception(); }
        public string getStyle() { throw new Exception(); }
        public string getStyle(string property) { throw new Exception(); }
        public object getStyles() { throw new Exception(); }
        public object getStyles(params string[] args) { throw new Exception(); }
        public int getTop() { throw new Exception(); }
        public int getTop(bool local) { throw new Exception(); }
        public Updater getUpdater() { throw new Exception(); }
        public object getValue() { throw new Exception(); }
        public object getValue(bool asNumber) { throw new Exception(); }
        public object getViewSize() { throw new Exception(); }
        public int getWidth() { throw new Exception(); }
        public int getWidth(bool contentWidth) { throw new Exception(); }
        public int getX() { throw new Exception(); }
        public Array getXY() { throw new Exception(); }
        public int getY() { throw new Exception(); }
        public Element ghost(string anchor, object options) { throw new Exception(); }
        public bool hasActiveFx() { throw new Exception(); }
        public bool hasClass() { throw new Exception(); }
        public bool hasClass(string className) { throw new Exception(); }
        public bool hasFxBlock() { throw new Exception(); }
        public Element hide() { throw new Exception(); }
        public Element hide(bool animate) { throw new Exception(); }
        public Element hide(object animate) { throw new Exception(); }
        public Element highlight(string color, object options) { throw new Exception(); }
        public Element hover() { throw new Exception(); }
        public Element hover(Delegate overFn) { throw new Exception(); }
        public Element hover(Delegate overFn, Delegate outFn) { throw new Exception(); }
        public Element hover(Delegate overFn, Delegate outFn, object scope) { throw new Exception(); }
        public DD initDD() { throw new Exception(); }
        public DD initDD(string group) { throw new Exception(); }
        public DD initDD(string group, object config) { throw new Exception(); }
        public DD initDD(string group, object config, object overrides) { throw new Exception(); }
        public DDProxy initDDProxy() { throw new Exception(); }
        public DDProxy initDDProxy(string group) { throw new Exception(); }
        public DDProxy initDDProxy(string group, object config) { throw new Exception(); }
        public DDProxy initDDProxy(string group, object config, object overrides) { throw new Exception(); }
        public DDTarget initDDTarget() { throw new Exception(); }
        public DDTarget initDDTarget(string group) { throw new Exception(); }
        public DDTarget initDDTarget(string group, object config) { throw new Exception(); }
        public DDTarget initDDTarget(string group, object config, object overrides) { throw new Exception(); }
        public Element insertAfter() { throw new Exception(); }
        public Element insertAfter(object el) { throw new Exception(); }
        public Element insertBefore() { throw new Exception(); }
        public Element insertBefore(object el) { throw new Exception(); }
        public Element insertFirst() { throw new Exception(); }
        public Element insertFirst(object el) { throw new Exception(); }
        public object insertHtml() { throw new Exception(); }
        public object insertHtml(string where) { throw new Exception(); }
        public object insertHtml(string where, string html) { throw new Exception(); }
        public object insertHtml(string where, string html, bool returnEl) { throw new Exception(); }
        public Element insertSibling() { throw new Exception(); }
        public Element insertSibling(Array el) { throw new Exception(); }
        public Element insertSibling(object el) { throw new Exception(); }
        public Element insertSibling(Array el, string where) { throw new Exception(); }
        public Element insertSibling(object el, string where) { throw new Exception(); }
        public Element insertSibling(Array el, string where, bool returnDom) { throw new Exception(); }
        public Element insertSibling(object el, string where, bool returnDom) { throw new Exception(); }
        public bool is_() { throw new Exception(); }
        public bool is_(string selector) { throw new Exception(); }
        public bool isBorderBox() { throw new Exception(); }
        public bool isDisplayed() { throw new Exception(); }
        public bool isMasked() { throw new Exception(); }
        public bool isScrollable() { throw new Exception(); }
        public bool isVisible() { throw new Exception(); }
        public bool isVisible(bool deep) { throw new Exception(); }
        public object last(string selector) { throw new Exception(); }
        public object last(string selector, bool returnDom) { throw new Exception(); }
        public Element load() { throw new Exception(); }
        public Element load(Delegate url) { throw new Exception(); }
        public Element load(string url) { throw new Exception(); }
        public Element load(Delegate url, object prms) { throw new Exception(); }
        public Element load(Delegate url, string prms) { throw new Exception(); }
        public Element load(string url, object prms) { throw new Exception(); }
        public Element load(string url, string prms) { throw new Exception(); }
        public Element load(Delegate url, object prms, Delegate callback) { throw new Exception(); }
        public Element load(Delegate url, string prms, Delegate callback) { throw new Exception(); }
        public Element load(string url, object prms, Delegate callback) { throw new Exception(); }
        public Element load(string url, string prms, Delegate callback) { throw new Exception(); }
        public Element load(Delegate url, object prms, Delegate callback, bool discardUrl) { throw new Exception(); }
        public Element load(Delegate url, string prms, Delegate callback, bool discardUrl) { throw new Exception(); }
        public Element load(string url, object prms, Delegate callback, bool discardUrl) { throw new Exception(); }
        public Element load(string url, string prms, Delegate callback, bool discardUrl) { throw new Exception(); }
        public Element mask() { throw new Exception(); }
        public Element mask(string msg) { throw new Exception(); }
        public Element mask(string msg, string msgCls) { throw new Exception(); }
        public Element move() { throw new Exception(); }
        public Element move(string direction) { throw new Exception(); }
        public Element move(string direction, int distance) { throw new Exception(); }
        public Element move(string direction, int distance, bool animate) { throw new Exception(); }
        public Element move(string direction, int distance, object animate) { throw new Exception(); }
        public Element moveTo() { throw new Exception(); }
        public Element moveTo(int x) { throw new Exception(); }
        public Element moveTo(int x, int y) { throw new Exception(); }
        public Element moveTo(int x, int y, bool animate) { throw new Exception(); }
        public Element moveTo(int x, int y, object animate) { throw new Exception(); }
        public object next() { throw new Exception(); }
        public object next(string selector) { throw new Exception(); }
        public object next(string selector, bool returnDom) { throw new Exception(); }
        public void on() { throw new Exception(); }
        public void on(string eventName) { throw new Exception(); }
        public void on(string eventName, JsAction fn) { throw new Exception(); }
        public void on(string eventName, JsAction fn, object scope) { throw new Exception(); }
        public void on(string eventName, JsAction fn, object scope, object options) { throw new Exception(); }
        public Element pause(int seconds) { throw new Exception(); }
        public void position() { throw new Exception(); }
        public void position(string pos) { throw new Exception(); }
        public void position(string pos, int zIndex) { throw new Exception(); }
        public void position(string pos, int zIndex, int x) { throw new Exception(); }
        public void position(string pos, int zIndex, int x, int y) { throw new Exception(); }
        public object prev() { throw new Exception(); }
        public object prev(string selector) { throw new Exception(); }
        public object prev(string selector, bool returnDom) { throw new Exception(); }
        public Element puff(object options) { throw new Exception(); }
        public Array query() { throw new Exception(); }
        public Array query(string selector) { throw new Exception(); }
        public Element radioClass() { throw new Exception(); }
        public Element radioClass(Array className) { throw new Exception(); }
        public Element radioClass(string className) { throw new Exception(); }
        public void remove() { throw new Exception(); }
        public Element removeAllListeners() { throw new Exception(); }
        public Element removeClass() { throw new Exception(); }
        public Element removeClass(Array className) { throw new Exception(); }
        public Element removeClass(string className) { throw new Exception(); }
        public Element removeListener() { throw new Exception(); }
        public Element removeListener(string eventName) { throw new Exception(); }
        public Element removeListener(string eventName, JsAction fn) { throw new Exception(); }
        public Element repaint() { throw new Exception(); }
        public Element replace() { throw new Exception(); }
        public Element replace(object el) { throw new Exception(); }
        public Element replaceClass() { throw new Exception(); }
        public Element replaceClass(string oldClassName) { throw new Exception(); }
        public Element replaceClass(string oldClassName, string newClassName) { throw new Exception(); }
        public Element replaceWith() { throw new Exception(); }
        public Element replaceWith(object el) { throw new Exception(); }
        public Element scale(int width, int height, object options) { throw new Exception(); }
        public bool scroll() { throw new Exception(); }
        public bool scroll(string direction) { throw new Exception(); }
        public bool scroll(string direction, int distance) { throw new Exception(); }
        public bool scroll(string direction, int distance, bool animate) { throw new Exception(); }
        public bool scroll(string direction, int distance, object animate) { throw new Exception(); }
        public Element scrollIntoView() { throw new Exception(); }
        public Element scrollIntoView(object container) { throw new Exception(); }
        public Element scrollIntoView(object container, bool hscroll) { throw new Exception(); }
        public Element scrollTo() { throw new Exception(); }
        public Element scrollTo(string side) { throw new Exception(); }
        public Element scrollTo(string side, int value) { throw new Exception(); }
        public Element scrollTo(string side, int value, bool animate) { throw new Exception(); }
        public Element scrollTo(string side, int value, object animate) { throw new Exception(); }
        public object select() { throw new Exception(); }
        public object select(string selector) { throw new Exception(); }
        public object select(string selector, bool unique) { throw new Exception(); }
        public Element sequenceFx() { throw new Exception(); }
        public Element set() { throw new Exception(); }
        public Element set(object o) { throw new Exception(); }
        public Element set(object o, bool useSet) { throw new Exception(); }
        public Element setBottom() { throw new Exception(); }
        public Element setBottom(string bottom) { throw new Exception(); }
        public Element setBounds() { throw new Exception(); }
        public Element setBounds(int x) { throw new Exception(); }
        public Element setBounds(int x, int y) { throw new Exception(); }
        public Element setBounds(int x, int y, int width) { throw new Exception(); }
        public Element setBounds(int x, int y, int width, int height) { throw new Exception(); }
        public Element setBounds(int x, int y, int width, int height, bool animate) { throw new Exception(); }
        public Element setBounds(int x, int y, int width, int height, object animate) { throw new Exception(); }
        public Element setBox() { throw new Exception(); }
        public Element setBox(object box) { throw new Exception(); }
        public Element setBox(object box, bool adjust) { throw new Exception(); }
        public Element setBox(object box, bool adjust, bool animate) { throw new Exception(); }
        public Element setBox(object box, bool adjust, object animate) { throw new Exception(); }
        public Element setDisplayed() { throw new Exception(); }
        public Element setDisplayed(bool value) { throw new Exception(); }
        public Element setHeight() { throw new Exception(); }
        public Element setHeight(int height) { throw new Exception(); }
        public Element setHeight(int height, bool animate) { throw new Exception(); }
        public Element setHeight(int height, object animate) { throw new Exception(); }
        public Element setLeft() { throw new Exception(); }
        public Element setLeft(string left) { throw new Exception(); }
        public Element setLeftTop() { throw new Exception(); }
        public Element setLeftTop(string left) { throw new Exception(); }
        public Element setLeftTop(string left, string top) { throw new Exception(); }
        public Element setLocation() { throw new Exception(); }
        public Element setLocation(int x) { throw new Exception(); }
        public Element setLocation(int x, int y) { throw new Exception(); }
        public Element setLocation(int x, int y, bool animate) { throw new Exception(); }
        public Element setLocation(int x, int y, object animate) { throw new Exception(); }
        public Element setOpacity() { throw new Exception(); }
        public Element setOpacity(double opacity) { throw new Exception(); }
        public Element setOpacity(double opacity, bool animate) { throw new Exception(); }
        public Element setOpacity(double opacity, object animate) { throw new Exception(); }
        public Element setPositioning() { throw new Exception(); }
        public Element setPositioning(object posCfg) { throw new Exception(); }
        public Element setRegion() { throw new Exception(); }
        public Element setRegion(object region) { throw new Exception(); }
        public Element setRegion(object region, bool animate) { throw new Exception(); }
        public Element setRegion(object region, object animate) { throw new Exception(); }
        public Element setRight() { throw new Exception(); }
        public Element setRight(string right) { throw new Exception(); }
        public Element setSize() { throw new Exception(); }
        public Element setSize(int width) { throw new Exception(); }
        public Element setSize(int width, int height) { throw new Exception(); }
        public Element setSize(int width, int height, bool animate) { throw new Exception(); }
        public Element setSize(int width, int height, object animate) { throw new Exception(); }
        public Element setStyle() { throw new Exception(); }
        public Element setStyle(object property) { throw new Exception(); }
        public Element setStyle(string property) { throw new Exception(); }
        public Element setStyle(object property, string value) { throw new Exception(); }
        public Element setStyle(string property, string value) { throw new Exception(); }
        public Element setTop() { throw new Exception(); }
        public Element setTop(string top) { throw new Exception(); }
        public Element setVisibilityMode() { throw new Exception(); }
        public Element setVisibilityMode(object visMode) { throw new Exception(); }
        public Element setVisible() { throw new Exception(); }
        public Element setVisible(bool visible) { throw new Exception(); }
        public Element setVisible(bool visible, bool animate) { throw new Exception(); }
        public Element setVisible(bool visible, object animate) { throw new Exception(); }
        public Element setWidth() { throw new Exception(); }
        public Element setWidth(int width) { throw new Exception(); }
        public Element setWidth(int width, bool animate) { throw new Exception(); }
        public Element setWidth(int width, object animate) { throw new Exception(); }
        public Element setX() { throw new Exception(); }
        public Element setX(int The) { throw new Exception(); }
        public Element setX(int The, bool animate) { throw new Exception(); }
        public Element setX(int The, object animate) { throw new Exception(); }
        public Element setXY() { throw new Exception(); }
        public Element setXY(Array pos) { throw new Exception(); }
        public Element setXY(Array pos, bool animate) { throw new Exception(); }
        public Element setXY(Array pos, object animate) { throw new Exception(); }
        public Element setY() { throw new Exception(); }
        public Element setY(int The) { throw new Exception(); }
        public Element setY(int The, bool animate) { throw new Exception(); }
        public Element setY(int The, object animate) { throw new Exception(); }
        public Element shift(object options) { throw new Exception(); }
        public Element show() { throw new Exception(); }
        public Element show(bool animate) { throw new Exception(); }
        public Element show(object animate) { throw new Exception(); }
        public Element slideIn(string anchor, object options) { throw new Exception(); }
        public Element slideOut(string anchor, object options) { throw new Exception(); }
        public Element stopFx() { throw new Exception(); }
        public Element swallowEvent() { throw new Exception(); }
        public Element swallowEvent(string eventName) { throw new Exception(); }
        public Element swallowEvent(string eventName, bool preventDefault) { throw new Exception(); }
        public Element switchOff(object options) { throw new Exception(); }
        public Element syncFx() { throw new Exception(); }
        public Element toggle() { throw new Exception(); }
        public Element toggle(bool animate) { throw new Exception(); }
        public Element toggle(object animate) { throw new Exception(); }
        public Element toggleClass() { throw new Exception(); }
        public Element toggleClass(string className) { throw new Exception(); }
        public object translatePoints() { throw new Exception(); }
        public object translatePoints(Array x) { throw new Exception(); }
        public object translatePoints(int x) { throw new Exception(); }
        public object translatePoints(Array x, int y) { throw new Exception(); }
        public object translatePoints(int x, int y) { throw new Exception(); }
        public Element un() { throw new Exception(); }
        public Element un(string eventName) { throw new Exception(); }
        public Element un(string eventName, JsAction fn) { throw new Exception(); }
        public Element unclip() { throw new Exception(); }
        public void unmask() { throw new Exception(); }
        public Element unselectable() { throw new Exception(); }
        public Element up() { throw new Exception(); }
        public Element up(string selector) { throw new Exception(); }
        public Element up(string selector, int maxDepth) { throw new Exception(); }
        public Element up(string selector, object maxDepth) { throw new Exception(); }
        public Element update() { throw new Exception(); }
        public Element update(string html) { throw new Exception(); }
        public Element update(string html, bool loadScripts) { throw new Exception(); }
        public Element update(string html, bool loadScripts, Delegate callback) { throw new Exception(); }
        public object wrap() { throw new Exception(); }
        public object wrap(object config) { throw new Exception(); }
        public object wrap(object config, bool returnDom) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static CompositeElement prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CompositeElementLite superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CompositeElementConfig
    {
        // Methods
        public CompositeElementConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CompositeElementLite
    {
        // Methods
        public CompositeElementLite() { throw new Exception(); }
        public CompositeElement add() { throw new Exception(); }
        public CompositeElement add(object els) { throw new Exception(); }
        public void clear() { throw new Exception(); }
        public CompositeElement each() { throw new Exception(); }
        public CompositeElement each(JsAction fn) { throw new Exception(); }
        public CompositeElement each(JsAction fn, object scope) { throw new Exception(); }
        public CompositeElement fill() { throw new Exception(); }
        public CompositeElement fill(object els) { throw new Exception(); }
        public CompositeElement filter() { throw new Exception(); }
        public CompositeElement filter(JsAction selector) { throw new Exception(); }
        public CompositeElement filter(string selector) { throw new Exception(); }
        public double getCount() { throw new Exception(); }
        public double indexOf() { throw new Exception(); }
        public double indexOf(object el) { throw new Exception(); }
        public Element item() { throw new Exception(); }
        public Element item(double index) { throw new Exception(); }
        public CompositeElement replaceElement() { throw new Exception(); }
        public CompositeElement replaceElement(object el) { throw new Exception(); }
        public CompositeElement replaceElement(object el, object replacement) { throw new Exception(); }
        public CompositeElement replaceElement(object el, object replacement, bool domReplace) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public Array elements { get; set; }
        [JsProperty(NativeField = true)]
        public static CompositeElementLite prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CompositeElementLiteConfig
    {
        // Methods
        public CompositeElementLiteConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Container : BoxComponent
    {
        // Methods
        public Container() { throw new Exception(); }
        public Container(ContainerConfig config) { throw new Exception(); }
        public Container(Element config) { throw new Exception(); }
        public Container(object config) { throw new Exception(); }
        public Container(string config) { throw new Exception(); }
        public Component add() { throw new Exception(); }
        public Component add(Array component) { throw new Exception(); }
        public Component add(object component) { throw new Exception(); }
        public Component add(Array component, object Optional) { throw new Exception(); }
        public Component add(object component, object Optional) { throw new Exception(); }
        public Component add(Array component, object Optional, object Optional2) { throw new Exception(); }
        public Component add(object component, object Optional, object Optional2) { throw new Exception(); }
        public Container bubble() { throw new Exception(); }
        public Container bubble(JsAction fn) { throw new Exception(); }
        public Container bubble(JsAction fn, object scope) { throw new Exception(); }
        public Container bubble(JsAction fn, object scope, Array args) { throw new Exception(); }
        public void canLayout() { throw new Exception(); }
        public Container cascade() { throw new Exception(); }
        public Container cascade(JsAction fn) { throw new Exception(); }
        public Container cascade(JsAction fn, object scope) { throw new Exception(); }
        public Container cascade(JsAction fn, object scope, Array args) { throw new Exception(); }
        public Container doLayout() { throw new Exception(); }
        public Container doLayout(bool shallow) { throw new Exception(); }
        public Container doLayout(bool shallow, bool force) { throw new Exception(); }
        public Array find() { throw new Exception(); }
        public Array find(string prop) { throw new Exception(); }
        public Array find(string prop, string value) { throw new Exception(); }
        public Array findBy() { throw new Exception(); }
        public Array findBy(JsAction fn) { throw new Exception(); }
        public Array findBy(JsAction fn, object scope) { throw new Exception(); }
        public Component findById() { throw new Exception(); }
        public Component findById(string id) { throw new Exception(); }
        public Array findByType() { throw new Exception(); }
        public Array findByType(object xtype) { throw new Exception(); }
        public Array findByType(string xtype) { throw new Exception(); }
        public Array findByType(object xtype, bool shallow) { throw new Exception(); }
        public Array findByType(string xtype, bool shallow) { throw new Exception(); }
        public Component get() { throw new Exception(); }
        public Component get(double key) { throw new Exception(); }
        public Component get(string key) { throw new Exception(); }
        public Component getComponent() { throw new Exception(); }
        public Component getComponent(double comp) { throw new Exception(); }
        public Component getComponent(string comp) { throw new Exception(); }
        public ContainerLayout getLayout() { throw new Exception(); }
        public Element getLayoutTarget() { throw new Exception(); }
        public Component insert() { throw new Exception(); }
        public Component insert(double index) { throw new Exception(); }
        public Component insert(double index, Component component) { throw new Exception(); }
        public Component remove() { throw new Exception(); }
        public Component remove(Component component) { throw new Exception(); }
        public Component remove(string component) { throw new Exception(); }
        public Component remove(Component component, bool autoDestroy) { throw new Exception(); }
        public Component remove(string component, bool autoDestroy) { throw new Exception(); }
        public Array removeAll() { throw new Exception(); }
        public Array removeAll(bool autoDestroy) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object activeItem { get; set; }
        [JsProperty(NativeField = true)]
        public Array bubbleEvents { get; set; }
        [JsProperty(NativeField = true)]
        public object bufferResize { get; set; }
        [JsProperty(NativeField = true)]
        public object defaults { get; set; }
        [JsProperty(NativeField = true)]
        public string defaultType { get; set; }
        [JsProperty(NativeField = true)]
        public object items { get; set; }
        [JsProperty(NativeField = true)]
        public object layout { get; set; }
        [JsProperty(NativeField = true)]
        public object layoutConfig { get; set; }
        [JsProperty(NativeField = true)]
        public bool monitorResize { get; set; }
        [JsProperty(NativeField = true)]
        public static Container prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
    }

    public delegate void ContainerAddDelegate(Container objthis, Component component, double index);

    public delegate void ContainerAfterlayoutDelegate(Container objthis, ContainerLayout layout);

    public delegate void ContainerBeforeaddDelegate(Container objthis, Component component, double index);

    public delegate void ContainerBeforeremoveDelegate(Container objthis, Component component);

    [JsType(JsMode.Json)]
    public class ContainerConfig
    {
        // Methods
        public ContainerConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class ContainerEvents
    {
        // Methods
        public ContainerEvents() { throw new Exception(); }

        // Properties
        public static string add { get { throw new Exception(); } }
        public static string afterlayout { get { throw new Exception(); } }
        public static string beforeadd { get { throw new Exception(); } }
        public static string beforeremove { get { throw new Exception(); } }
        public static string remove { get { throw new Exception(); } }
    }

    public delegate void ContainerRemoveDelegate(Container objthis, Component component);

    [JsType(JsMode.Prototype, Export = false)]
    public class CycleButton : SplitButton
    {
        // Methods
        public CycleButton() { throw new Exception(); }
        public CycleButton(CycleButtonConfig config) { throw new Exception(); }
        public CycleButton(Element config) { throw new Exception(); }
        public CycleButton(object config) { throw new Exception(); }
        public CycleButton(string config) { throw new Exception(); }
        public CheckItem getActiveItem() { throw new Exception(); }
        public void setActiveItem() { throw new Exception(); }
        public void setActiveItem(CheckItem item) { throw new Exception(); }
        public void setActiveItem(CheckItem item, bool suppressEvent) { throw new Exception(); }
        public void toggleSelected() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public JsAction changeHandler { get; set; }
        [JsProperty(NativeField = true)]
        public string forceIcon { get; set; }
        [JsProperty(NativeField = true)]
        public Array items { get; set; }
        [JsProperty(NativeField = true)]
        public Menu menu { get; set; }
        [JsProperty(NativeField = true)]
        public string prependText { get; set; }
        [JsProperty(NativeField = true)]
        public static CycleButton prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool showText { get; set; }
        [JsProperty(NativeField = true)]
        public static SplitButton superclass { get; set; }
    }

    public delegate void CycleButtonChangeDelegate(CycleButton objthis, CheckItem item);

    [JsType(JsMode.Json)]
    public class CycleButtonConfig
    {
        // Methods
        public CycleButtonConfig() { throw new Exception(); }

        // Properties
        public bool allowDepress { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public string arrowAlign { get; set; }
        public JsAction arrowHandler { get; set; }
        public string arrowTooltip { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string buttonSelector { get; set; }
        public JsAction changeHandler { get; set; }
        public string clearCls { get; set; }
        public string clickEvent { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool enableToggle { get; set; }
        public string fieldLabel { get; set; }
        public string forceIcon { get; set; }
        public bool handleMouseEvents { get; set; }
        public JsAction handler { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string icon { get; set; }
        public string iconAlign { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public Array items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object menu { get; set; }
        public string menuAlign { get; set; }
        public double minWidth { get; set; }
        public string overCls { get; set; }
        public string overflowText { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string prependText { get; set; }
        public bool pressed { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object repeat { get; set; }
        public string scale { get; set; }
        public object scope { get; set; }
        public bool showText { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public Template template { get; set; }
        public string text { get; set; }
        public string toggleGroup { get; set; }
        public JsAction toggleHandler { get; set; }
        public object tooltip { get; set; }
        public string tooltipType { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string type { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class CycleButtonEvents
    {
        // Methods
        public CycleButtonEvents() { throw new Exception(); }

        // Properties
        public static string change { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DataView : BoxComponent
    {
        // Methods
        public DataView() { throw new Exception(); }
        public DataView(DataViewConfig config) { throw new Exception(); }
        public DataView(Element config) { throw new Exception(); }
        public DataView(object config) { throw new Exception(); }
        public DataView(string config) { throw new Exception(); }
        public void bindStore() { throw new Exception(); }
        public void bindStore(Store store) { throw new Exception(); }
        public void clearSelections() { throw new Exception(); }
        public void clearSelections(bool suppressEvent) { throw new Exception(); }
        public Array collectData() { throw new Exception(); }
        public Array collectData(Array records) { throw new Exception(); }
        public Array collectData(Array records, double startIndex) { throw new Exception(); }
        public void deselect() { throw new Exception(); }
        public void deselect(HtmlElement node) { throw new Exception(); }
        public void deselect(double node) { throw new Exception(); }
        public HtmlElement findItemFromChild() { throw new Exception(); }
        public HtmlElement findItemFromChild(HtmlElement node) { throw new Exception(); }
        public HtmlElement getNode() { throw new Exception(); }
        public HtmlElement getNode(HtmlElement nodeInfo) { throw new Exception(); }
        public HtmlElement getNode(double nodeInfo) { throw new Exception(); }
        public HtmlElement getNode(string nodeInfo) { throw new Exception(); }
        public Array getNodes() { throw new Exception(); }
        public Array getNodes(double start) { throw new Exception(); }
        public Array getNodes(double start, double end) { throw new Exception(); }
        public Record getRecord() { throw new Exception(); }
        public Record getRecord(HtmlElement node) { throw new Exception(); }
        public Array getRecords() { throw new Exception(); }
        public Array getRecords(Array nodes) { throw new Exception(); }
        public Array getSelectedIndexes() { throw new Exception(); }
        public Array getSelectedNodes() { throw new Exception(); }
        public Array getSelectedRecords() { throw new Exception(); }
        public double getSelectionCount() { throw new Exception(); }
        public Store getStore() { throw new Exception(); }
        public double indexOf() { throw new Exception(); }
        public double indexOf(HtmlElement nodeInfo) { throw new Exception(); }
        public double indexOf(double nodeInfo) { throw new Exception(); }
        public double indexOf(string nodeInfo) { throw new Exception(); }
        public bool isSelected() { throw new Exception(); }
        public bool isSelected(HtmlElement node) { throw new Exception(); }
        public bool isSelected(double node) { throw new Exception(); }
        public object prepareData() { throw new Exception(); }
        public object prepareData(Array data) { throw new Exception(); }
        public object prepareData(object data) { throw new Exception(); }
        public object prepareData(Array data, double recordIndex) { throw new Exception(); }
        public object prepareData(object data, double recordIndex) { throw new Exception(); }
        public object prepareData(Array data, double recordIndex, Record record) { throw new Exception(); }
        public object prepareData(object data, double recordIndex, Record record) { throw new Exception(); }
        public void refresh() { throw new Exception(); }
        public void refreshNode() { throw new Exception(); }
        public void refreshNode(double index) { throw new Exception(); }
        public void select() { throw new Exception(); }
        public void select(HtmlElement nodeInfo) { throw new Exception(); }
        public void select(Array nodeInfo) { throw new Exception(); }
        public void select(double nodeInfo) { throw new Exception(); }
        public void select(string nodeInfo) { throw new Exception(); }
        public void select(HtmlElement nodeInfo, bool keepExisting) { throw new Exception(); }
        public void select(Array nodeInfo, bool keepExisting) { throw new Exception(); }
        public void select(double nodeInfo, bool keepExisting) { throw new Exception(); }
        public void select(string nodeInfo, bool keepExisting) { throw new Exception(); }
        public void select(HtmlElement nodeInfo, bool keepExisting, bool suppressEvent) { throw new Exception(); }
        public void select(Array nodeInfo, bool keepExisting, bool suppressEvent) { throw new Exception(); }
        public void select(double nodeInfo, bool keepExisting, bool suppressEvent) { throw new Exception(); }
        public void select(string nodeInfo, bool keepExisting, bool suppressEvent) { throw new Exception(); }
        public void selectRange() { throw new Exception(); }
        public void selectRange(double start) { throw new Exception(); }
        public void selectRange(double start, double end) { throw new Exception(); }
        public void selectRange(double start, double end, bool keepExisting) { throw new Exception(); }
        public void setStore() { throw new Exception(); }
        public void setStore(Store store) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool deferEmptyText { get; set; }
        [JsProperty(NativeField = true)]
        public string emptyText { get; set; }
        [JsProperty(NativeField = true)]
        public string itemSelector { get; set; }
        [JsProperty(NativeField = true)]
        public string loadingText { get; set; }
        [JsProperty(NativeField = true)]
        public bool multiSelect { get; set; }
        [JsProperty(NativeField = true)]
        public string overClass { get; set; }
        [JsProperty(NativeField = true)]
        public static DataView prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string selectedClass { get; set; }
        [JsProperty(NativeField = true)]
        public bool simpleSelect { get; set; }
        [JsProperty(NativeField = true)]
        public bool singleSelect { get; set; }
        [JsProperty(NativeField = true)]
        public Store store { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object tpl { get; set; }
        [JsProperty(NativeField = true)]
        public bool trackOver { get; set; }
    }

    public delegate void DataViewBeforeclickDelegate(DataView objthis, double index, HtmlElement node, EventObject e);

    public delegate void DataViewBeforeselectDelegate(DataView objthis, HtmlElement node, Array selections);

    public delegate void DataViewClickDelegate(DataView objthis, double index, HtmlElement node, EventObject e);

    [JsType(JsMode.Json)]
    public class DataViewConfig
    {
        // Methods
        public DataViewConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool deferEmptyText { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string emptyText { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string itemSelector { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string loadingText { get; set; }
        public object margins { get; set; }
        public bool multiSelect { get; set; }
        public string overClass { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public string selectedClass { get; set; }
        public bool simpleSelect { get; set; }
        public bool singleSelect { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public Store store { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool trackOver { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void DataViewContainerclickDelegate(DataView objthis, EventObject e);

    public delegate void DataViewContainercontextmenuDelegate(DataView objthis, EventObject e);

    public delegate void DataViewContextmenuDelegate(DataView objthis, double index, HtmlElement node, EventObject e);

    public delegate void DataViewDblclickDelegate(DataView objthis, double index, HtmlElement node, EventObject e);

    public class DataViewEvents
    {
        // Methods
        public DataViewEvents() { throw new Exception(); }

        // Properties
        public static string beforeclick { get { throw new Exception(); } }
        public static string beforeselect { get { throw new Exception(); } }
        public static string click { get { throw new Exception(); } }
        public static string containerclick { get { throw new Exception(); } }
        public static string containercontextmenu { get { throw new Exception(); } }
        public static string contextmenu { get { throw new Exception(); } }
        public static string dblclick { get { throw new Exception(); } }
        public static string mouseenter { get { throw new Exception(); } }
        public static string mouseleave { get { throw new Exception(); } }
        public static string selectionchange { get { throw new Exception(); } }
    }

    public delegate void DataViewMouseenterDelegate(DataView objthis, double index, HtmlElement node, EventObject e);

    public delegate void DataViewMouseleaveDelegate(DataView objthis, double index, HtmlElement node, EventObject e);

    public delegate void DataViewSelectionchangeDelegate(DataView objthis, Array selections);

    [JsType(JsMode.Prototype, Export = false)]
    public class DatePicker : Component
    {
        // Methods
        public DatePicker() { throw new Exception(); }
        public DatePicker(DatePickerConfig config) { throw new Exception(); }
        public DatePicker(Element config) { throw new Exception(); }
        public DatePicker(object config) { throw new Exception(); }
        public DatePicker(string config) { throw new Exception(); }
        public DateTime getValue() { throw new Exception(); }
        public void setDisabledDates() { throw new Exception(); }
        public void setDisabledDates(Array disabledDates) { throw new Exception(); }
        public void setDisabledDates(object disabledDates) { throw new Exception(); }
        public void setDisabledDays() { throw new Exception(); }
        public void setDisabledDays(Array disabledDays) { throw new Exception(); }
        public void setMaxDate() { throw new Exception(); }
        public void setMaxDate(DateTime value) { throw new Exception(); }
        public void setMinDate() { throw new Exception(); }
        public void setMinDate(DateTime value) { throw new Exception(); }
        public void setValue() { throw new Exception(); }
        public void setValue(DateTime value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string cancelText { get; set; }
        [JsProperty(NativeField = true)]
        public Array dayNames { get; set; }
        [JsProperty(NativeField = true)]
        public Array disabledDates { get; set; }
        [JsProperty(NativeField = true)]
        public object disabledDatesRE { get; set; }
        [JsProperty(NativeField = true)]
        public string disabledDatesText { get; set; }
        [JsProperty(NativeField = true)]
        public Array disabledDays { get; set; }
        [JsProperty(NativeField = true)]
        public string disabledDaysText { get; set; }
        [JsProperty(NativeField = true)]
        public string format { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction handler { get; set; }
        [JsProperty(NativeField = true)]
        public DateTime maxDate { get; set; }
        [JsProperty(NativeField = true)]
        public string maxText { get; set; }
        [JsProperty(NativeField = true)]
        public DateTime minDate { get; set; }
        [JsProperty(NativeField = true)]
        public string minText { get; set; }
        [JsProperty(NativeField = true)]
        public Array monthNames { get; set; }
        [JsProperty(NativeField = true)]
        public string monthYearText { get; set; }
        [JsProperty(NativeField = true)]
        public string nextText { get; set; }
        [JsProperty(NativeField = true)]
        public string okText { get; set; }
        [JsProperty(NativeField = true)]
        public string prevText { get; set; }
        [JsProperty(NativeField = true)]
        public static DatePicker prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public bool showToday { get; set; }
        [JsProperty(NativeField = true)]
        public double startDay { get; set; }
        [JsProperty(NativeField = true)]
        public static Component superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string todayText { get; set; }
        [JsProperty(NativeField = true)]
        public string todayTip { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DatePickerConfig
    {
        // Methods
        public DatePickerConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public string cancelText { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public Array dayNames { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public Array disabledDates { get; set; }
        public object disabledDatesRE { get; set; }
        public string disabledDatesText { get; set; }
        public Array disabledDays { get; set; }
        public string disabledDaysText { get; set; }
        public string fieldLabel { get; set; }
        public string format { get; set; }
        public JsAction handler { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public DateTime maxDate { get; set; }
        public string maxText { get; set; }
        public DateTime minDate { get; set; }
        public string minText { get; set; }
        public Array monthNames { get; set; }
        public string monthYearText { get; set; }
        public string nextText { get; set; }
        public string okText { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string prevText { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public bool showToday { get; set; }
        public double startDay { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string todayText { get; set; }
        public string todayTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string xtype { get; set; }
    }

    public class DatePickerEvents
    {
        // Methods
        public DatePickerEvents() { throw new Exception(); }

        // Properties
        public static string select { get { throw new Exception(); } }
    }

    public delegate void DatePickerSelectDelegate(DatePicker objthis, DateTime date);

    [JsType(JsMode.Prototype, Export = false)]
    public class Direct : Observable
    {
        // Methods
        public Direct() { throw new Exception(); }
        public static void addProvider() { throw new Exception(); }
        public static void addProvider(Array provider) { throw new Exception(); }
        public static void addProvider(object provider) { throw new Exception(); }
        public static void getProvider() { throw new Exception(); }
        public static void getProvider(string id) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static object eventTypes { get; set; }
        [JsProperty(NativeField = true)]
        public static object exceptions { get; set; }
        [JsProperty(NativeField = true)]
        public static Direct prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Transaction
        {
            // Methods
            public Transaction() { throw new Exception(); }
            public Transaction(object config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Direct.Transaction prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static object superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class TransactionConfig
        {
            // Methods
            public TransactionConfig() { throw new Exception(); }
        }
    }

    [JsType(JsMode.Json)]
    public class DirectConfig
    {
        // Methods
        public DirectConfig() { throw new Exception(); }
    }

    public delegate void DirectEventDelegate(EventObject e, Ext.direct.Provider provider);

    public class DirectEvents
    {
        // Methods
        public DirectEvents() { throw new Exception(); }

        // Properties
        public static string @event { get { throw new Exception(); } }
        public static string exception { get { throw new Exception(); } }
    }

    public delegate void DirectExceptionDelegate(EventObject e);

    [JsType(JsMode.Prototype, Export = false)]
    public class DomHelper
    {
        // Methods
        public DomHelper() { throw new Exception(); }
        public static object append() { throw new Exception(); }
        public static object append(object el) { throw new Exception(); }
        public static object append(object el, object o) { throw new Exception(); }
        public static object append(object el, string o) { throw new Exception(); }
        public static object append(object el, object o, bool returnElement) { throw new Exception(); }
        public static object append(object el, string o, bool returnElement) { throw new Exception(); }
        public static void applyStyles() { throw new Exception(); }
        public static void applyStyles(HtmlElement el) { throw new Exception(); }
        public static void applyStyles(string el) { throw new Exception(); }
        public static void applyStyles(HtmlElement el, JsAction styles) { throw new Exception(); }
        public static void applyStyles(HtmlElement el, object styles) { throw new Exception(); }
        public static void applyStyles(HtmlElement el, string styles) { throw new Exception(); }
        public static void applyStyles(string el, JsAction styles) { throw new Exception(); }
        public static void applyStyles(string el, object styles) { throw new Exception(); }
        public static void applyStyles(string el, string styles) { throw new Exception(); }
        public static object insertAfter() { throw new Exception(); }
        public static object insertAfter(object el) { throw new Exception(); }
        public static object insertAfter(object el, object o) { throw new Exception(); }
        public static object insertAfter(object el, object o, bool returnElement) { throw new Exception(); }
        public static object insertBefore() { throw new Exception(); }
        public static object insertBefore(object el) { throw new Exception(); }
        public static object insertBefore(object el, object o) { throw new Exception(); }
        public static object insertBefore(object el, string o) { throw new Exception(); }
        public static object insertBefore(object el, object o, bool returnElement) { throw new Exception(); }
        public static object insertBefore(object el, string o, bool returnElement) { throw new Exception(); }
        public static object insertFirst() { throw new Exception(); }
        public static object insertFirst(object el) { throw new Exception(); }
        public static object insertFirst(object el, object o) { throw new Exception(); }
        public static object insertFirst(object el, string o) { throw new Exception(); }
        public static object insertFirst(object el, object o, bool returnElement) { throw new Exception(); }
        public static object insertFirst(object el, string o, bool returnElement) { throw new Exception(); }
        public static HtmlElement insertHtml() { throw new Exception(); }
        public static HtmlElement insertHtml(string where) { throw new Exception(); }
        public static HtmlElement insertHtml(string where, HtmlElement el) { throw new Exception(); }
        public static HtmlElement insertHtml(string where, HtmlElement el, string html) { throw new Exception(); }
        public static string markup() { throw new Exception(); }
        public static string markup(object o) { throw new Exception(); }
        public static object overwrite() { throw new Exception(); }
        public static object overwrite(object el) { throw new Exception(); }
        public static object overwrite(object el, object o) { throw new Exception(); }
        public static object overwrite(object el, string o) { throw new Exception(); }
        public static object overwrite(object el, object o, bool returnElement) { throw new Exception(); }
        public static object overwrite(object el, string o, bool returnElement) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DomHelper prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DomHelperConfig
    {
        // Methods
        public DomHelperConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DomQuery
    {
        // Methods
        public DomQuery() { throw new Exception(); }
        public static JsAction compile() { throw new Exception(); }
        public static JsAction compile(string selector) { throw new Exception(); }
        public static JsAction compile(string selector, string type) { throw new Exception(); }
        public static Array filter() { throw new Exception(); }
        public static Array filter(Array el) { throw new Exception(); }
        public static Array filter(Array el, string selector) { throw new Exception(); }
        public static Array filter(Array el, string selector, bool nonMatches) { throw new Exception(); }
        public static bool is_() { throw new Exception(); }
        public static bool is_(HtmlElement el) { throw new Exception(); }
        public static bool is_(Array el) { throw new Exception(); }
        public static bool is_(string el) { throw new Exception(); }
        public static bool is_(HtmlElement el, string selector) { throw new Exception(); }
        public static bool is_(Array el, string selector) { throw new Exception(); }
        public static bool is_(string el, string selector) { throw new Exception(); }
        public static Array select() { throw new Exception(); }
        public static Array select(string selector) { throw new Exception(); }
        public static Array select(string selector, Node root) { throw new Exception(); }
        public static Element selectNode() { throw new Exception(); }
        public static Element selectNode(string selector) { throw new Exception(); }
        public static Element selectNode(string selector, Node root) { throw new Exception(); }
        public static double selectNumber() { throw new Exception(); }
        public static double selectNumber(string selector) { throw new Exception(); }
        public static double selectNumber(string selector, Node root) { throw new Exception(); }
        public static double selectNumber(string selector, Node root, double defaultValue) { throw new Exception(); }
        public static string selectValue() { throw new Exception(); }
        public static string selectValue(string selector) { throw new Exception(); }
        public static string selectValue(string selector, Node root) { throw new Exception(); }
        public static string selectValue(string selector, Node root, string defaultValue) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static object matchers { get; set; }
        [JsProperty(NativeField = true)]
        public static object operators { get; set; }
        [JsProperty(NativeField = true)]
        public static DomQuery prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static object pseudos { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DomQueryConfig
    {
        // Methods
        public DomQueryConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Editor : Component
    {
        // Methods
        public Editor() { throw new Exception(); }
        public Editor(EditorConfig config) { throw new Exception(); }
        public Editor(Element config) { throw new Exception(); }
        public Editor(object config) { throw new Exception(); }
        public Editor(string config) { throw new Exception(); }
        public void cancelEdit() { throw new Exception(); }
        public void cancelEdit(bool remainVisible) { throw new Exception(); }
        public void completeEdit() { throw new Exception(); }
        public void completeEdit(bool remainVisible) { throw new Exception(); }
        public object getValue() { throw new Exception(); }
        public void realign() { throw new Exception(); }
        public void realign(bool autoSize) { throw new Exception(); }
        public void setSize() { throw new Exception(); }
        public void setSize(double width) { throw new Exception(); }
        public void setSize(double width, double height) { throw new Exception(); }
        public void setValue() { throw new Exception(); }
        public void setValue(object value) { throw new Exception(); }
        public void startEdit() { throw new Exception(); }
        public void startEdit(object el) { throw new Exception(); }
        public void startEdit(object el, string value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string alignment { get; set; }
        [JsProperty(NativeField = true)]
        public bool allowBlur { get; set; }
        [JsProperty(NativeField = true)]
        public object autoSize { get; set; }
        [JsProperty(NativeField = true)]
        public bool cancelOnEsc { get; set; }
        [JsProperty(NativeField = true)]
        public bool completeOnEnter { get; set; }
        [JsProperty(NativeField = true)]
        public bool constrain { get; set; }
        [JsProperty(NativeField = true)]
        public Ext.form.Field field { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideEl { get; set; }
        [JsProperty(NativeField = true)]
        public bool ignoreNoChange { get; set; }
        [JsProperty(NativeField = true)]
        public Array offsets { get; set; }
        [JsProperty(NativeField = true)]
        public static Editor prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool revertInvalid { get; set; }
        [JsProperty(NativeField = true)]
        public object shadow { get; set; }
        [JsProperty(NativeField = true)]
        public static Component superclass { get; set; }
        [JsProperty(NativeField = true)]
        public bool swallowKeys { get; set; }
        [JsProperty(NativeField = true)]
        public bool updateEl { get; set; }
        [JsProperty(NativeField = true)]
        public object value { get; set; }
    }

    public delegate void EditorBeforecompleteDelegate(Editor objthis, object value, object startValue);

    public delegate void EditorBeforestarteditDelegate(Editor objthis, Element boundEl, object value);

    public delegate void EditorCanceleditDelegate(Editor objthis, object value, object startValue);

    public delegate void EditorCompleteDelegate(Editor objthis, object value, object startValue);

    [JsType(JsMode.Json)]
    public class EditorConfig
    {
        // Methods
        public EditorConfig() { throw new Exception(); }

        // Properties
        public string alignment { get; set; }
        public bool allowBlur { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public object autoSize { get; set; }
        public bool cancelOnEsc { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public bool completeOnEnter { get; set; }
        public bool constrain { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public Ext.form.Field field { get; set; }
        public string fieldLabel { get; set; }
        public bool hidden { get; set; }
        public bool hideEl { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public bool ignoreNoChange { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public Array offsets { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public bool revertInvalid { get; set; }
        public object shadow { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool swallowKeys { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool updateEl { get; set; }
        public object value { get; set; }
        public string xtype { get; set; }
    }

    public class EditorEvents
    {
        // Methods
        public EditorEvents() { throw new Exception(); }

        // Properties
        public static string beforecomplete { get { throw new Exception(); } }
        public static string beforestartedit { get { throw new Exception(); } }
        public static string canceledit { get { throw new Exception(); } }
        public static string complete { get { throw new Exception(); } }
        public static string specialkey { get { throw new Exception(); } }
        public static string startedit { get { throw new Exception(); } }
    }

    public delegate void EditorSpecialkeyDelegate(Ext.form.Field objthis, EventObject e);

    public delegate void EditorStarteditDelegate(Element boundEl, object value);

    [JsType(JsMode.Prototype, Export = false)]
    public class Element
    {
        // Methods
        public Element() { throw new Exception(); }
        public object child() { throw new Exception(); }
        public object child(string selector) { throw new Exception(); }
        public object child(string selector, bool returnDom) { throw new Exception(); }
        public object down() { throw new Exception(); }
        public object down(string selector) { throw new Exception(); }
        public object down(string selector, bool returnDom) { throw new Exception(); }
        public Element fadeIn(object options) { throw new Exception(); }
        public Element fadeOut(object options) { throw new Exception(); }
        public HtmlElement findParent() { throw new Exception(); }
        public HtmlElement findParent(string selector) { throw new Exception(); }
        public HtmlElement findParent(string selector, double maxDepth) { throw new Exception(); }
        public HtmlElement findParent(string selector, object maxDepth) { throw new Exception(); }
        public HtmlElement findParent(string selector, double maxDepth, bool returnEl) { throw new Exception(); }
        public HtmlElement findParent(string selector, object maxDepth, bool returnEl) { throw new Exception(); }
        public HtmlElement findParentNode() { throw new Exception(); }
        public HtmlElement findParentNode(string selector) { throw new Exception(); }
        public HtmlElement findParentNode(string selector, double maxDepth) { throw new Exception(); }
        public HtmlElement findParentNode(string selector, object maxDepth) { throw new Exception(); }
        public HtmlElement findParentNode(string selector, double maxDepth, bool returnEl) { throw new Exception(); }
        public HtmlElement findParentNode(string selector, object maxDepth, bool returnEl) { throw new Exception(); }
        public object first() { throw new Exception(); }
        public object first(string selector) { throw new Exception(); }
        public object first(string selector, bool returnDom) { throw new Exception(); }
        public Element frame(string color, int count, object options) { throw new Exception(); }
        public Element ghost(string anchor, object options) { throw new Exception(); }
        public bool hasActiveFx() { throw new Exception(); }
        public bool hasFxBlock() { throw new Exception(); }
        public Element highlight(string color, object options) { throw new Exception(); }
        public object last() { throw new Exception(); }
        public object last(string selector) { throw new Exception(); }
        public object last(string selector, bool returnDom) { throw new Exception(); }
        public object next() { throw new Exception(); }
        public object next(string selector) { throw new Exception(); }
        public object next(string selector, bool returnDom) { throw new Exception(); }
        public void on() { throw new Exception(); }
        public void on(string eventName) { throw new Exception(); }
        public void on(string eventName, JsAction fn) { throw new Exception(); }
        public void on(string eventName, JsAction fn, object scope) { throw new Exception(); }
        public void on(string eventName, JsAction fn, object scope, object options) { throw new Exception(); }
        public object parent() { throw new Exception(); }
        public object parent(string selector) { throw new Exception(); }
        public object parent(string selector, bool returnDom) { throw new Exception(); }
        public Element pause(int seconds) { throw new Exception(); }
        public object prev() { throw new Exception(); }
        public object prev(string selector) { throw new Exception(); }
        public object prev(string selector, bool returnDom) { throw new Exception(); }
        public Element puff(object options) { throw new Exception(); }
        public Array query() { throw new Exception(); }
        public Array query(string selector) { throw new Exception(); }
        public Element scale(int width, int height, object options) { throw new Exception(); }
        public object select() { throw new Exception(); }
        public object select(string selector) { throw new Exception(); }
        public Element sequenceFx() { throw new Exception(); }
        public Element shift(object options) { throw new Exception(); }
        public Element slideIn(string anchor, object options) { throw new Exception(); }
        public Element slideOut(string anchor, object options) { throw new Exception(); }
        public Element stopFx() { throw new Exception(); }
        public Element switchOff(object options) { throw new Exception(); }
        public Element syncFx() { throw new Exception(); }
        public Element un() { throw new Exception(); }
        public Element un(string eventName) { throw new Exception(); }
        public Element un(string eventName, JsAction fn) { throw new Exception(); }
        public Element up() { throw new Exception(); }
        public Element up(string selector) { throw new Exception(); }
        public Element up(string selector, double maxDepth) { throw new Exception(); }
        public Element up(string selector, object maxDepth) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Element prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ElementConfig
    {
        // Methods
        public ElementConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Error
    {
        // Methods
        public Error() { throw new Exception(); }
        public string getMessage() { throw new Exception(); }
        public string getName() { throw new Exception(); }
        public string toJson() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Error prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static object superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ErrorConfig
    {
        // Methods
        public ErrorConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class EventManager
    {
        // Methods
        public EventManager() { throw new Exception(); }
        public static void addListener() { throw new Exception(); }
        public static void addListener(HtmlElement el) { throw new Exception(); }
        public static void addListener(string el) { throw new Exception(); }
        public static void addListener(HtmlElement el, string eventName) { throw new Exception(); }
        public static void addListener(string el, string eventName) { throw new Exception(); }
        public static void addListener(HtmlElement el, string eventName, JsAction handler) { throw new Exception(); }
        public static void addListener(string el, string eventName, JsAction handler) { throw new Exception(); }
        public static void addListener(HtmlElement el, string eventName, JsAction handler, object scope) { throw new Exception(); }
        public static void addListener(string el, string eventName, JsAction handler, object scope) { throw new Exception(); }
        public static void addListener(HtmlElement el, string eventName, JsAction handler, object scope, object options) { throw new Exception(); }
        public static void addListener(string el, string eventName, JsAction handler, object scope, object options) { throw new Exception(); }
        public static void onDocumentReady() { throw new Exception(); }
        public static void onDocumentReady(JsAction fn) { throw new Exception(); }
        public static void onDocumentReady(JsAction fn, object scope) { throw new Exception(); }
        public static void onDocumentReady(JsAction fn, object scope, bool options) { throw new Exception(); }
        public static void removeAll() { throw new Exception(); }
        public static void removeAll(HtmlElement el) { throw new Exception(); }
        public static void removeAll(string el) { throw new Exception(); }
        public static void removeListener() { throw new Exception(); }
        public static void removeListener(HtmlElement el) { throw new Exception(); }
        public static void removeListener(string el) { throw new Exception(); }
        public static void removeListener(HtmlElement el, string eventName) { throw new Exception(); }
        public static void removeListener(string el, string eventName) { throw new Exception(); }
        public static void removeListener(HtmlElement el, string eventName, JsAction fn) { throw new Exception(); }
        public static void removeListener(string el, string eventName, JsAction fn) { throw new Exception(); }
        public static void removeListener(HtmlElement el, string eventName, JsAction fn, object scope) { throw new Exception(); }
        public static void removeListener(string el, string eventName, JsAction fn, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static EventManager prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class EventManagerConfig
    {
        // Methods
        public EventManagerConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class EventObject
    {
        // Methods
        public EventObject() { throw new Exception(); }
        public double getCharCode() { throw new Exception(); }
        public double getKey() { throw new Exception(); }
        public double getPageX() { throw new Exception(); }
        public double getPageY() { throw new Exception(); }
        public HtmlElement getRelatedTarget() { throw new Exception(); }
        public HtmlElement getTarget() { throw new Exception(); }
        public HtmlElement getTarget(string selector) { throw new Exception(); }
        public HtmlElement getTarget(string selector, double maxDepth) { throw new Exception(); }
        public HtmlElement getTarget(string selector, object maxDepth) { throw new Exception(); }
        public HtmlElement getTarget(string selector, double maxDepth, bool returnEl) { throw new Exception(); }
        public HtmlElement getTarget(string selector, object maxDepth, bool returnEl) { throw new Exception(); }
        public double getWheelDelta() { throw new Exception(); }
        public Array getXY() { throw new Exception(); }
        public void preventDefault() { throw new Exception(); }
        public void stopEvent() { throw new Exception(); }
        public void stopPropagation() { throw new Exception(); }
        public bool within() { throw new Exception(); }
        public bool within(object el) { throw new Exception(); }
        public bool within(object el, bool related) { throw new Exception(); }
        public bool within(object el, bool related, bool allowEl) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static EventObject prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class EventObjectConfig
    {
        // Methods
        public EventObjectConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Name = "Ext", Export = false)]
    public class ExtClass
    {
        // Methods
        public ExtClass() { throw new Exception(); }
        public static object apply(object obj, object config, object defaults) { throw new Exception(); }
        public static object applyIf() { throw new Exception(); }
        public static object applyIf(object obj) { throw new Exception(); }
        public static object applyIf(object obj, object config) { throw new Exception(); }
        public static object each() { throw new Exception(); }
        public static object each(Array array) { throw new Exception(); }
        public static object each(object array) { throw new Exception(); }
        public static object each(Array array, JsAction fn) { throw new Exception(); }
        public static object each(object array, JsAction fn) { throw new Exception(); }
        public static object each(Array array, JsAction fn, object scope) { throw new Exception(); }
        public static object each(object array, JsAction fn, object scope) { throw new Exception(); }
        public static JsAction extend() { throw new Exception(); }
        public static JsAction extend(JsAction superclass) { throw new Exception(); }
        public static JsAction extend(JsAction superclass, object overrides) { throw new Exception(); }
        public static Element fly(HtmlElement el) { throw new Exception(); }
        public static Element fly(string el) { throw new Exception(); }
        public static Element fly(HtmlElement el, string named) { throw new Exception(); }
        public static Element fly(string el, string named) { throw new Exception(); }
        public static Element get(Element el) { throw new Exception(); }
        public static Element get(HtmlElement el) { throw new Exception(); }
        public static Element get(string el) { throw new Exception(); }
        public static Element getBody() { throw new Exception(); }
        public static HtmlElement getDom() { throw new Exception(); }
        public static HtmlElement getDom(object el) { throw new Exception(); }
        public static string id() { throw new Exception(); }
        public static string id(object el) { throw new Exception(); }
        public static string id(object el, string prefix) { throw new Exception(); }
        public static bool isArray() { throw new Exception(); }
        public static bool isArray(object value) { throw new Exception(); }
        public static bool isBoolean() { throw new Exception(); }
        public static bool isBoolean(object value) { throw new Exception(); }
        public static bool isDate() { throw new Exception(); }
        public static bool isDate(object obj) { throw new Exception(); }
        public static bool isDefined() { throw new Exception(); }
        public static bool isDefined(object value) { throw new Exception(); }
        public static bool isElement() { throw new Exception(); }
        public static bool isElement(object value) { throw new Exception(); }
        public static bool isEmpty() { throw new Exception(); }
        public static bool isEmpty(object value) { throw new Exception(); }
        public static bool isEmpty(object value, bool allowBlank) { throw new Exception(); }
        public static bool isFunction() { throw new Exception(); }
        public static bool isFunction(object value) { throw new Exception(); }
        public static bool isNumber() { throw new Exception(); }
        public static bool isNumber(object value) { throw new Exception(); }
        public static bool isObject() { throw new Exception(); }
        public static bool isObject(object value) { throw new Exception(); }
        public static bool isPrimitive() { throw new Exception(); }
        public static bool isPrimitive(object value) { throw new Exception(); }
        public static bool isString() { throw new Exception(); }
        public static bool isString(object value) { throw new Exception(); }
        public static void iterate() { throw new Exception(); }
        public static void iterate(Array obj) { throw new Exception(); }
        public static void iterate(object obj) { throw new Exception(); }
        public static void iterate(Array obj, JsAction fn) { throw new Exception(); }
        public static void iterate(object obj, JsAction fn) { throw new Exception(); }
        public static void iterate(Array obj, JsAction fn, object scope) { throw new Exception(); }
        public static void iterate(object obj, JsAction fn, object scope) { throw new Exception(); }
        public static object namespace_() { throw new Exception(); }
        public static object namespace_(params string[] args) { throw new Exception(); }
        public static object ns() { throw new Exception(); }
        public static object ns(params string[] args) { throw new Exception(); }
        public static void onReady(JsAction fn) { throw new Exception(); }
        public static void onReady(JsAction fn, object scope) { throw new Exception(); }
        public static void onReady(JsAction fn, object scope, bool options) { throw new Exception(); }
        public static void override_() { throw new Exception(); }
        public static void override_(object origclass) { throw new Exception(); }
        public static void override_(object origclass, object overrides) { throw new Exception(); }
        public static void removeNode() { throw new Exception(); }
        public static void removeNode(HtmlElement node) { throw new Exception(); }
        public static CompositeElement select(Array selector) { throw new Exception(); }
        public static CompositeElement select(string selector) { throw new Exception(); }
        public static CompositeElement select(Array selector, bool unique) { throw new Exception(); }
        public static CompositeElement select(string selector, bool unique) { throw new Exception(); }
        public static CompositeElement select(Array selector, bool unique, HtmlElement root) { throw new Exception(); }
        public static CompositeElement select(Array selector, bool unique, string root) { throw new Exception(); }
        public static CompositeElement select(string selector, bool unique, HtmlElement root) { throw new Exception(); }
        public static CompositeElement select(string selector, bool unique, string root) { throw new Exception(); }
        public static Array toArray() { throw new Exception(); }
        public static Array toArray(object the) { throw new Exception(); }
        public static string urlAppend() { throw new Exception(); }
        public static string urlAppend(string url) { throw new Exception(); }
        public static string urlAppend(string url, string s) { throw new Exception(); }
        public static object urlDecode() { throw new Exception(); }
        public static object urlDecode(string str) { throw new Exception(); }
        public static object urlDecode(string str, bool overwrite) { throw new Exception(); }
        public static string urlEncode() { throw new Exception(); }
        public static string urlEncode(object o) { throw new Exception(); }
        public static string urlEncode(object o, string pre) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static bool enableFx { get; set; }
        [JsProperty(NativeField = true)]
        public static bool enableGarbageCollector { get; set; }
        [JsProperty(NativeField = true)]
        public static bool enableListenerCollection { get; set; }
        [JsProperty(NativeField = true)]
        public static bool enableNestedListenerRemoval { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isAir { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isBorderBox { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isChrome { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isGecko { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isGecko2 { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isGecko3 { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isIE { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isIE6 { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isIE7 { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isIE8 { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isLinux { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isMac { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isOpera { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isReady { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isSafari { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isSafari2 { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isSafari3 { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isSafari4 { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isSecure { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isStrict { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isWebKit { get; set; }
        [JsProperty(NativeField = true)]
        public static bool isWindows { get; set; }
        [JsProperty(NativeField = true)]
        public static ExtClass prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static string SSL_SECURE_URL { get; set; }
        [JsProperty(NativeField = true)]
        public static bool USE_NATIVE_JSON { get; set; }
        [JsProperty(NativeField = true)]
        public static string version { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ExtConfig
    {
        // Methods
        public ExtConfig() { throw new Exception(); }
    }

    [JsType(Mode = JsMode.Global, Export = false)]
    public class ExtContext : HtmlContext
    {
        // Methods
        public ExtContext() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class FlashComponent : BoxComponent
    {
        // Methods
        public FlashComponent() { throw new Exception(); }
        public FlashComponent(Element config) { throw new Exception(); }
        public FlashComponent(FlashComponentConfig config) { throw new Exception(); }
        public FlashComponent(object config) { throw new Exception(); }
        public FlashComponent(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string backgroundColor { get; set; }
        [JsProperty(NativeField = true)]
        public static string EXPRESS_INSTALL_URL { get; set; }
        [JsProperty(NativeField = true)]
        public bool expressInstall { get; set; }
        [JsProperty(NativeField = true)]
        public object flashParams { get; set; }
        [JsProperty(NativeField = true)]
        public object flashVars { get; set; }
        [JsProperty(NativeField = true)]
        public string flashVersion { get; set; }
        [JsProperty(NativeField = true)]
        public static FlashComponent prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
        [JsProperty(NativeField = true)]
        public string wmode { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FlashComponentConfig
    {
        // Methods
        public FlashComponentConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class FlashComponentEvents
    {
        // Methods
        public FlashComponentEvents() { throw new Exception(); }

        // Properties
        public static string initialize { get { throw new Exception(); } }
    }

    public delegate void FlashComponentInitializeDelegate(Chart objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class FlashProxy
    {
        // Methods
        public FlashProxy() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static FlashProxy prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FlashProxyConfig
    {
        // Methods
        public FlashProxyConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Fx
    {
        // Methods
        public Fx() { throw new Exception(); }
        public Fx(FxConfig config) { throw new Exception(); }
        public Element fadeIn() { throw new Exception(); }
        public Element fadeIn(object options) { throw new Exception(); }
        public Element fadeOut() { throw new Exception(); }
        public Element fadeOut(object options) { throw new Exception(); }
        public Element frame() { throw new Exception(); }
        public Element frame(string color) { throw new Exception(); }
        public Element frame(string color, double count) { throw new Exception(); }
        public Element frame(string color, double count, object options) { throw new Exception(); }
        public Element ghost() { throw new Exception(); }
        public Element ghost(string anchor) { throw new Exception(); }
        public Element ghost(string anchor, object options) { throw new Exception(); }
        public bool hasActiveFx() { throw new Exception(); }
        public bool hasFxBlock() { throw new Exception(); }
        public Element highlight() { throw new Exception(); }
        public Element highlight(string color) { throw new Exception(); }
        public Element highlight(string color, object options) { throw new Exception(); }
        public Element pause() { throw new Exception(); }
        public Element pause(double seconds) { throw new Exception(); }
        public Element puff() { throw new Exception(); }
        public Element puff(object options) { throw new Exception(); }
        public Element scale() { throw new Exception(); }
        public Element scale(double width) { throw new Exception(); }
        public Element scale(double width, double height) { throw new Exception(); }
        public Element scale(double width, double height, object options) { throw new Exception(); }
        public Element sequenceFx() { throw new Exception(); }
        public Element shift() { throw new Exception(); }
        public Element shift(object options) { throw new Exception(); }
        public Element slideIn() { throw new Exception(); }
        public Element slideIn(string anchor) { throw new Exception(); }
        public Element slideIn(string anchor, object options) { throw new Exception(); }
        public Element slideOut() { throw new Exception(); }
        public Element slideOut(string anchor) { throw new Exception(); }
        public Element slideOut(string anchor, object options) { throw new Exception(); }
        public Element stopFx() { throw new Exception(); }
        public Element switchOff() { throw new Exception(); }
        public Element switchOff(object options) { throw new Exception(); }
        public Element syncFx() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Fx prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FxConfig
    {
        // Methods
        public FxConfig() { throw new Exception(); }

        // Properties
        public bool stopFx { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class History : Observable
    {
        // Methods
        public History() { throw new Exception(); }
        public static void add() { throw new Exception(); }
        public static void add(string token) { throw new Exception(); }
        public static void add(string token, bool preventDuplicates) { throw new Exception(); }
        public static void back() { throw new Exception(); }
        public static void forward() { throw new Exception(); }
        public static string getToken() { throw new Exception(); }
        public static void init() { throw new Exception(); }
        public static void init(bool onReady) { throw new Exception(); }
        public static void init(bool onReady, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static string fieldId { get; set; }
        [JsProperty(NativeField = true)]
        public static string iframeId { get; set; }
        [JsProperty(NativeField = true)]
        public static History prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void HistoryChangeDelegate(string token);

    [JsType(JsMode.Json)]
    public class HistoryConfig
    {
        // Methods
        public HistoryConfig() { throw new Exception(); }
    }

    public class HistoryEvents
    {
        // Methods
        public HistoryEvents() { throw new Exception(); }

        // Properties
        public static string change { get { throw new Exception(); } }
        public static string ready { get { throw new Exception(); } }
    }

    public delegate void HistoryReadyDelegate(History The);

    [JsType(JsMode.Prototype, Export = false)]
    public class KeyMap
    {
        // Methods
        public KeyMap() { throw new Exception(); }
        public KeyMap(object el) { throw new Exception(); }
        public KeyMap(object el, object config) { throw new Exception(); }
        public KeyMap(object el, object config, string eventName) { throw new Exception(); }
        public void addBinding() { throw new Exception(); }
        public void addBinding(Array config) { throw new Exception(); }
        public void addBinding(object config) { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public bool isEnabled() { throw new Exception(); }
        public void on() { throw new Exception(); }
        public void on(Array key) { throw new Exception(); }
        public void on(double key) { throw new Exception(); }
        public void on(object key) { throw new Exception(); }
        public void on(Array key, JsAction fn) { throw new Exception(); }
        public void on(double key, JsAction fn) { throw new Exception(); }
        public void on(object key, JsAction fn) { throw new Exception(); }
        public void on(Array key, JsAction fn, object scope) { throw new Exception(); }
        public void on(double key, JsAction fn, object scope) { throw new Exception(); }
        public void on(object key, JsAction fn, object scope) { throw new Exception(); }
        public void setDisabled() { throw new Exception(); }
        public void setDisabled(bool disabled) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static KeyMap prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool stopEvent { get; set; }
    }

    [JsType(JsMode.Json)]
    public class KeyMapConfig
    {
        // Methods
        public KeyMapConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class KeyNav
    {
        // Methods
        public KeyNav() { throw new Exception(); }
        public KeyNav(KeyNavConfig config) { throw new Exception(); }
        public KeyNav(object el) { throw new Exception(); }
        public KeyNav(object el, object config) { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public void setDisabled() { throw new Exception(); }
        public void setDisabled(bool disabled) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string defaultEventAction { get; set; }
        [JsProperty(NativeField = true)]
        public bool disabled { get; set; }
        [JsProperty(NativeField = true)]
        public bool forceKeyDown { get; set; }
        [JsProperty(NativeField = true)]
        public static KeyNav prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class KeyNavConfig
    {
        // Methods
        public KeyNavConfig() { throw new Exception(); }

        // Properties
        public string defaultEventAction { get; set; }
        public bool disabled { get; set; }
        public bool forceKeyDown { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Layer : Element
    {
        // Methods
        public Layer() { throw new Exception(); }
        public Layer(LayerConfig config) { throw new Exception(); }
        public Layer(object config) { throw new Exception(); }
        public Layer(object config, HtmlElement existingEl) { throw new Exception(); }
        public Layer(object config, string existingEl) { throw new Exception(); }
        public Layer setZIndex() { throw new Exception(); }
        public Layer setZIndex(double zindex) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Layer prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Element superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class LayerConfig
    {
        // Methods
        public LayerConfig() { throw new Exception(); }

        // Properties
        public string cls { get; set; }
        public bool constrain { get; set; }
        public object dh { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public bool useDisplay { get; set; }
        public double zindex { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class LoadMask
    {
        // Methods
        public LoadMask() { throw new Exception(); }
        public LoadMask(LoadMaskConfig config) { throw new Exception(); }
        public LoadMask(object el) { throw new Exception(); }
        public LoadMask(object el, object config) { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public void show() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool disabled { get; set; }
        [JsProperty(NativeField = true)]
        public string msg { get; set; }
        [JsProperty(NativeField = true)]
        public string msgCls { get; set; }
        [JsProperty(NativeField = true)]
        public static LoadMask prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool removeMask { get; set; }
        [JsProperty(NativeField = true)]
        public Store store { get; set; }
    }

    [JsType(JsMode.Json)]
    public class LoadMaskConfig
    {
        // Methods
        public LoadMaskConfig() { throw new Exception(); }

        // Properties
        public string msg { get; set; }
        public string msgCls { get; set; }
        public bool removeMask { get; set; }
        public Store store { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class MessageBox
    {
        // Methods
        public MessageBox() { throw new Exception(); }
        public static MessageBox alert() { throw new Exception(); }
        public static MessageBox alert(string title) { throw new Exception(); }
        public static MessageBox alert(string title, string msg) { throw new Exception(); }
        public static MessageBox alert(string title, string msg, JsAction fn) { throw new Exception(); }
        public static MessageBox alert(string title, string msg, JsAction fn, object scope) { throw new Exception(); }
        public static MessageBox confirm() { throw new Exception(); }
        public static MessageBox confirm(string title) { throw new Exception(); }
        public static MessageBox confirm(string title, string msg) { throw new Exception(); }
        public static MessageBox confirm(string title, string msg, JsAction fn) { throw new Exception(); }
        public static MessageBox confirm(string title, string msg, JsAction fn, object scope) { throw new Exception(); }
        public static Window getDialog() { throw new Exception(); }
        public static MessageBox hide() { throw new Exception(); }
        public static bool isVisible() { throw new Exception(); }
        public static MessageBox progress() { throw new Exception(); }
        public static MessageBox progress(string title) { throw new Exception(); }
        public static MessageBox progress(string title, string msg) { throw new Exception(); }
        public static MessageBox progress(string title, string msg, string progressText) { throw new Exception(); }
        public static MessageBox prompt() { throw new Exception(); }
        public static MessageBox prompt(string title) { throw new Exception(); }
        public static MessageBox prompt(string title, string msg) { throw new Exception(); }
        public static MessageBox prompt(string title, string msg, JsAction fn) { throw new Exception(); }
        public static MessageBox prompt(string title, string msg, JsAction fn, object scope) { throw new Exception(); }
        public static MessageBox prompt(string title, string msg, JsAction fn, object scope, bool multiline) { throw new Exception(); }
        public static MessageBox prompt(string title, string msg, JsAction fn, object scope, double multiline) { throw new Exception(); }
        public static MessageBox prompt(string title, string msg, JsAction fn, object scope, bool multiline, string value) { throw new Exception(); }
        public static MessageBox prompt(string title, string msg, JsAction fn, object scope, double multiline, string value) { throw new Exception(); }
        public static MessageBox setIcon() { throw new Exception(); }
        public static MessageBox setIcon(string icon) { throw new Exception(); }
        public static MessageBox show() { throw new Exception(); }
        public static MessageBox show(object config) { throw new Exception(); }
        public static MessageBox updateProgress() { throw new Exception(); }
        public static MessageBox updateProgress(double value) { throw new Exception(); }
        public static MessageBox updateProgress(double value, string progressText) { throw new Exception(); }
        public static MessageBox updateProgress(double value, string progressText, string msg) { throw new Exception(); }
        public static MessageBox updateText() { throw new Exception(); }
        public static MessageBox updateText(string text) { throw new Exception(); }
        public static MessageBox wait() { throw new Exception(); }
        public static MessageBox wait(string msg) { throw new Exception(); }
        public static MessageBox wait(string msg, string title) { throw new Exception(); }
        public static MessageBox wait(string msg, string title, object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static object buttonText { get; set; }
        [JsProperty(NativeField = true)]
        public static object CANCEL { get; set; }
        [JsProperty(NativeField = true)]
        public static double defaultTextHeight { get; set; }
        [JsProperty(NativeField = true)]
        public static string ERROR { get; set; }
        [JsProperty(NativeField = true)]
        public static string INFO { get; set; }
        [JsProperty(NativeField = true)]
        public static double maxWidth { get; set; }
        [JsProperty(NativeField = true)]
        public static double minProgressWidth { get; set; }
        [JsProperty(NativeField = true)]
        public static double minWidth { get; set; }
        [JsProperty(NativeField = true)]
        public static object Msg { get; set; }
        [JsProperty(NativeField = true)]
        public static object OK { get; set; }
        [JsProperty(NativeField = true)]
        public static object OKCANCEL { get; set; }
        [JsProperty(NativeField = true)]
        public static MessageBox prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static string QUESTION { get; set; }
        [JsProperty(NativeField = true)]
        public static string WARNING { get; set; }
        [JsProperty(NativeField = true)]
        public static object YESNO { get; set; }
        [JsProperty(NativeField = true)]
        public static object YESNOCANCEL { get; set; }
    }

    [JsType(JsMode.Json)]
    public class MessageBoxConfig
    {
        // Methods
        public MessageBoxConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class PagingToolbar : Toolbar
    {
        // Methods
        public PagingToolbar() { throw new Exception(); }
        public PagingToolbar(Element config) { throw new Exception(); }
        public PagingToolbar(PagingToolbarConfig config) { throw new Exception(); }
        public PagingToolbar(Array config) { throw new Exception(); }
        public PagingToolbar(object config) { throw new Exception(); }
        public PagingToolbar(string config) { throw new Exception(); }
        public void bind() { throw new Exception(); }
        public void bind(Store store) { throw new Exception(); }
        public void bindStore() { throw new Exception(); }
        public void bindStore(Store store) { throw new Exception(); }
        public void bindStore(Store store, bool initial) { throw new Exception(); }
        public void changePage() { throw new Exception(); }
        public void changePage(int page) { throw new Exception(); }
        public void doRefresh() { throw new Exception(); }
        public void moveFirst() { throw new Exception(); }
        public void moveLast() { throw new Exception(); }
        public void moveNext() { throw new Exception(); }
        public void movePrevious() { throw new Exception(); }
        public void unbind() { throw new Exception(); }
        public void unbind(Store store) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string afterPageText { get; set; }
        [JsProperty(NativeField = true)]
        public string beforePageText { get; set; }
        [JsProperty(NativeField = true)]
        public double cursor { get; set; }
        [JsProperty(NativeField = true)]
        public bool displayInfo { get; set; }
        [JsProperty(NativeField = true)]
        public string displayMsg { get; set; }
        [JsProperty(NativeField = true)]
        public string emptyMsg { get; set; }
        [JsProperty(NativeField = true)]
        public string firstText { get; set; }
        [JsProperty(NativeField = true)]
        public string lastText { get; set; }
        [JsProperty(NativeField = true)]
        public string nextText { get; set; }
        [JsProperty(NativeField = true)]
        public double pageSize { get; set; }
        [JsProperty(NativeField = true)]
        public object paramNames { get; set; }
        [JsProperty(NativeField = true)]
        public bool prependButtons { get; set; }
        [JsProperty(NativeField = true)]
        public string prevText { get; set; }
        [JsProperty(NativeField = true)]
        public static PagingToolbar prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string refreshText { get; set; }
        [JsProperty(NativeField = true)]
        public Store store { get; set; }
        [JsProperty(NativeField = true)]
        public static Toolbar superclass { get; set; }
    }

    public delegate void PagingToolbarBeforechangeDelegate(PagingToolbar objthis, object prms);

    public delegate void PagingToolbarChangeDelegate(PagingToolbar objthis, object pageData);

    [JsType(JsMode.Json)]
    public class PagingToolbarConfig
    {
        // Methods
        public PagingToolbarConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public string afterPageText { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string beforePageText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool displayInfo { get; set; }
        public string displayMsg { get; set; }
        public string emptyMsg { get; set; }
        public bool enableOverflow { get; set; }
        public string fieldLabel { get; set; }
        public string firstText { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string lastText { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool monitorResize { get; set; }
        public string nextText { get; set; }
        public string overCls { get; set; }
        public double pageSize { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool prependButtons { get; set; }
        public string prevText { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string refreshText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public Store store { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class PagingToolbarEvents
    {
        // Methods
        public PagingToolbarEvents() { throw new Exception(); }

        // Properties
        public static string beforechange { get { throw new Exception(); } }
        public static string change { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Panel : Container
    {
        // Methods
        public Panel() { throw new Exception(); }
        public Panel(Element config) { throw new Exception(); }
        public Panel(PanelConfig config) { throw new Exception(); }
        public Panel(object config) { throw new Exception(); }
        public Panel(string config) { throw new Exception(); }
        public Button addButton() { throw new Exception(); }
        public Button addButton(object config) { throw new Exception(); }
        public Button addButton(string config) { throw new Exception(); }
        public Button addButton(object config, JsAction handler) { throw new Exception(); }
        public Button addButton(string config, JsAction handler) { throw new Exception(); }
        public Button addButton(object config, JsAction handler, object scope) { throw new Exception(); }
        public Button addButton(string config, JsAction handler, object scope) { throw new Exception(); }
        public Panel collapse() { throw new Exception(); }
        public Panel collapse(bool animate) { throw new Exception(); }
        public Panel expand() { throw new Exception(); }
        public Panel expand(bool animate) { throw new Exception(); }
        public Toolbar getBottomToolbar() { throw new Exception(); }
        public double getFrameHeight() { throw new Exception(); }
        public double getFrameWidth() { throw new Exception(); }
        public double getInnerHeight() { throw new Exception(); }
        public double getInnerWidth() { throw new Exception(); }
        public object getTool() { throw new Exception(); }
        public object getTool(string id) { throw new Exception(); }
        public Toolbar getTopToolbar() { throw new Exception(); }
        public Updater getUpdater() { throw new Exception(); }
        public Panel load() { throw new Exception(); }
        public Panel load(JsAction config) { throw new Exception(); }
        public Panel load(object config) { throw new Exception(); }
        public Panel load(string config) { throw new Exception(); }
        public void setIconClass() { throw new Exception(); }
        public void setIconClass(string cls) { throw new Exception(); }
        public void setTitle() { throw new Exception(); }
        public void setTitle(string title) { throw new Exception(); }
        public void setTitle(string title, string iconCls) { throw new Exception(); }
        public Panel toggleCollapse() { throw new Exception(); }
        public Panel toggleCollapse(bool animate) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool animCollapse { get; set; }
        [JsProperty(NativeField = true)]
        public object applyTo { get; set; }
        [JsProperty(NativeField = true)]
        public bool autoHeight { get; set; }
        [JsProperty(NativeField = true)]
        public object autoLoad { get; set; }
        [JsProperty(NativeField = true)]
        public string baseCls { get; set; }
        [JsProperty(NativeField = true)]
        public object bbar { get; set; }
        [JsProperty(NativeField = true)]
        public object bbarCfg { get; set; }
        [JsProperty(NativeField = true)]
        public Element body { get; set; }
        [JsProperty(NativeField = true)]
        public bool bodyBorder { get; set; }
        [JsProperty(NativeField = true)]
        public object bodyCfg { get; set; }
        [JsProperty(NativeField = true)]
        public object bodyCssClass { get; set; }
        [JsProperty(NativeField = true)]
        public object bodyStyle { get; set; }
        [JsProperty(NativeField = true)]
        public bool border { get; set; }
        [JsProperty(NativeField = true)]
        public string buttonAlign { get; set; }
        [JsProperty(NativeField = true)]
        public Array buttons { get; set; }
        [JsProperty(NativeField = true)]
        public Element bwrap { get; set; }
        [JsProperty(NativeField = true)]
        public object bwrapCfg { get; set; }
        [JsProperty(NativeField = true)]
        public bool closable { get; set; }
        [JsProperty(NativeField = true)]
        public bool collapsed { get; set; }
        [JsProperty(NativeField = true)]
        public string collapsedCls { get; set; }
        [JsProperty(NativeField = true)]
        public bool collapseFirst { get; set; }
        [JsProperty(NativeField = true)]
        public bool collapsible { get; set; }
        [JsProperty(NativeField = true)]
        public DragSource dd { get; set; }
        [JsProperty(NativeField = true)]
        public bool disabled { get; set; }
        [JsProperty(NativeField = true)]
        public object draggable { get; set; }
        [JsProperty(NativeField = true)]
        public string elements { get; set; }
        [JsProperty(NativeField = true)]
        public object floating { get; set; }
        [JsProperty(NativeField = true)]
        public Element footer { get; set; }
        [JsProperty(NativeField = true)]
        public object footerCfg { get; set; }
        [JsProperty(NativeField = true)]
        public bool frame { get; set; }
        [JsProperty(NativeField = true)]
        public Element header { get; set; }
        [JsProperty(NativeField = true)]
        public bool headerAsText { get; set; }
        [JsProperty(NativeField = true)]
        public object headerCfg { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideCollapseTool { get; set; }
        [JsProperty(NativeField = true)]
        public string iconCls { get; set; }
        [JsProperty(NativeField = true)]
        public object keys { get; set; }
        [JsProperty(NativeField = true)]
        public bool maskDisabled { get; set; }
        [JsProperty(NativeField = true)]
        public double minButtonWidth { get; set; }
        [JsProperty(NativeField = true)]
        public object padding { get; set; }
        [JsProperty(NativeField = true)]
        public bool preventBodyReset { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object shadow { get; set; }
        [JsProperty(NativeField = true)]
        public double shadowOffset { get; set; }
        [JsProperty(NativeField = true)]
        public bool shim { get; set; }
        [JsProperty(NativeField = true)]
        public static Container superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object tbar { get; set; }
        [JsProperty(NativeField = true)]
        public object tbarCfg { get; set; }
        [JsProperty(NativeField = true)]
        public string title { get; set; }
        [JsProperty(NativeField = true)]
        public bool titleCollapse { get; set; }
        [JsProperty(NativeField = true)]
        public Array tools { get; set; }
        [JsProperty(NativeField = true)]
        public object toolTemplate { get; set; }
        [JsProperty(NativeField = true)]
        public bool unstyled { get; set; }
    }

    public delegate void PanelActivateDelegate(Panel p);

    public delegate void PanelBeforecloseDelegate(Panel p);

    public delegate void PanelBeforecollapseDelegate(Panel p, bool animate);

    public delegate void PanelBeforeexpandDelegate(Panel p, bool animate);

    public delegate void PanelBodyresizeDelegate(Panel p, double width, double height);

    public delegate void PanelCloseDelegate(Panel p);

    public delegate void PanelCollapseDelegate(Panel p);

    [JsType(JsMode.Json)]
    public class PanelConfig
    {
        // Methods
        public PanelConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double minButtonWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool unstyled { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void PanelDeactivateDelegate(Panel p);

    public class PanelEvents
    {
        // Methods
        public PanelEvents() { throw new Exception(); }

        // Properties
        public static string activate { get { throw new Exception(); } }
        public static string beforeclose { get { throw new Exception(); } }
        public static string beforecollapse { get { throw new Exception(); } }
        public static string beforeexpand { get { throw new Exception(); } }
        public static string bodyresize { get { throw new Exception(); } }
        public static string close { get { throw new Exception(); } }
        public static string collapse { get { throw new Exception(); } }
        public static string deactivate { get { throw new Exception(); } }
        public static string expand { get { throw new Exception(); } }
        public static string iconchange { get { throw new Exception(); } }
        public static string titlechange { get { throw new Exception(); } }
    }

    public delegate void PanelExpandDelegate(Panel p);

    public delegate void PanelIconchangeDelegate(Panel p, string The, string The2);

    public delegate void PanelTitlechangeDelegate(Panel p, string The);

    [JsType(JsMode.Prototype, Export = false)]
    public class ProgressBar : BoxComponent
    {
        // Methods
        public ProgressBar() { throw new Exception(); }
        public ProgressBar(Element config) { throw new Exception(); }
        public ProgressBar(ProgressBarConfig config) { throw new Exception(); }
        public ProgressBar(object config) { throw new Exception(); }
        public ProgressBar(string config) { throw new Exception(); }
        public bool isWaiting() { throw new Exception(); }
        public ProgressBar reset() { throw new Exception(); }
        public ProgressBar reset(bool hide) { throw new Exception(); }
        public ProgressBar setSize() { throw new Exception(); }
        public ProgressBar setSize(double width) { throw new Exception(); }
        public ProgressBar setSize(double width, double height) { throw new Exception(); }
        public void syncProgressBar() { throw new Exception(); }
        public ProgressBar updateProgress() { throw new Exception(); }
        public ProgressBar updateProgress(double value) { throw new Exception(); }
        public ProgressBar updateProgress(double value, string text) { throw new Exception(); }
        public ProgressBar updateProgress(double value, string text, bool animate) { throw new Exception(); }
        public ProgressBar updateText() { throw new Exception(); }
        public ProgressBar updateText(string text) { throw new Exception(); }
        public ProgressBar wait() { throw new Exception(); }
        public ProgressBar wait(object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool animate { get; set; }
        [JsProperty(NativeField = true)]
        public string baseCls { get; set; }
        [JsProperty(NativeField = true)]
        public static ProgressBar prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ProgressBarConfig
    {
        // Methods
        public ProgressBarConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animate { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class ProgressBarEvents
    {
        // Methods
        public ProgressBarEvents() { throw new Exception(); }

        // Properties
        public static string update { get { throw new Exception(); } }
    }

    public delegate void ProgressBarUpdateDelegate(ProgressBar objthis, double The, string The2);

    [JsType(JsMode.Prototype, Export = false)]
    public class QuickTip : ToolTip
    {
        // Methods
        public QuickTip() { throw new Exception(); }
        public QuickTip(Element config) { throw new Exception(); }
        public QuickTip(QuickTipConfig config) { throw new Exception(); }
        public QuickTip(object config) { throw new Exception(); }
        public QuickTip(string config) { throw new Exception(); }
        public void cancelShow() { throw new Exception(); }
        public void cancelShow(Element el) { throw new Exception(); }
        public void cancelShow(HtmlElement el) { throw new Exception(); }
        public void cancelShow(string el) { throw new Exception(); }
        public void register() { throw new Exception(); }
        public void register(object config) { throw new Exception(); }
        public void unregister() { throw new Exception(); }
        public void unregister(Element el) { throw new Exception(); }
        public void unregister(HtmlElement el) { throw new Exception(); }
        public void unregister(string el) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool interceptTitles { get; set; }
        [JsProperty(NativeField = true)]
        public static QuickTip prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ToolTip superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object target { get; set; }
    }

    [JsType(JsMode.Json)]
    public class QuickTipConfig
    {
        // Methods
        public QuickTipConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public double anchorOffset { get; set; }
        public bool anchorToTarget { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoHide { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string defaultAlign { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public string @delegate { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public double dismissDelay { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public double hideDelay { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public bool interceptTitles { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double maxWidth { get; set; }
        public double minButtonWidth { get; set; }
        public double minWidth { get; set; }
        public bool monitorResize { get; set; }
        public Array mouseOffset { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public double showDelay { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object target { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool trackMouse { get; set; }
        public bool unstyled { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class QuickTips
    {
        // Methods
        public QuickTips() { throw new Exception(); }
        public static void disable() { throw new Exception(); }
        public static void enable() { throw new Exception(); }
        public static void getQuickTip() { throw new Exception(); }
        public static void init() { throw new Exception(); }
        public static void init(bool autoRender) { throw new Exception(); }
        public static bool isEnabled() { throw new Exception(); }
        public static void register() { throw new Exception(); }
        public static void register(object config) { throw new Exception(); }
        public static void tips() { throw new Exception(); }
        public static void tips(object config) { throw new Exception(); }
        public static void unregister() { throw new Exception(); }
        public static void unregister(Element el) { throw new Exception(); }
        public static void unregister(HtmlElement el) { throw new Exception(); }
        public static void unregister(string el) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static QuickTips prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class QuickTipsConfig
    {
        // Methods
        public QuickTipsConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Resizable : Observable
    {
        // Methods
        public Resizable() { throw new Exception(); }
        public Resizable(ResizableConfig config) { throw new Exception(); }
        public Resizable(object el) { throw new Exception(); }
        public Resizable(object el, object config) { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public void destroy(bool removeEl) { throw new Exception(); }
        public Element getEl() { throw new Exception(); }
        public Element getResizeChild() { throw new Exception(); }
        public void resizeElement() { throw new Exception(); }
        public void resizeTo() { throw new Exception(); }
        public void resizeTo(double width) { throw new Exception(); }
        public void resizeTo(double width, double height) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object adjustments { get; set; }
        [JsProperty(NativeField = true)]
        public bool animate { get; set; }
        [JsProperty(NativeField = true)]
        public object constrainTo { get; set; }
        [JsProperty(NativeField = true)]
        public bool disableTrackOver { get; set; }
        [JsProperty(NativeField = true)]
        public bool draggable { get; set; }
        [JsProperty(NativeField = true)]
        public double duration { get; set; }
        [JsProperty(NativeField = true)]
        public bool dynamic { get; set; }
        [JsProperty(NativeField = true)]
        public string easing { get; set; }
        [JsProperty(NativeField = true)]
        public bool enabled { get; set; }
        [JsProperty(NativeField = true)]
        public bool enabledWritable { get; set; }
        [JsProperty(NativeField = true)]
        public string handles { get; set; }
        [JsProperty(NativeField = true)]
        public double height { get; set; }
        [JsProperty(NativeField = true)]
        public double heightIncrement { get; set; }
        [JsProperty(NativeField = true)]
        public double maxHeight { get; set; }
        [JsProperty(NativeField = true)]
        public double maxWidth { get; set; }
        [JsProperty(NativeField = true)]
        public double minHeight { get; set; }
        [JsProperty(NativeField = true)]
        public double minWidth { get; set; }
        [JsProperty(NativeField = true)]
        public double minX { get; set; }
        [JsProperty(NativeField = true)]
        public double minY { get; set; }
        [JsProperty(NativeField = true)]
        public bool multiDirectional { get; set; }
        [JsProperty(NativeField = true)]
        public bool pinned { get; set; }
        [JsProperty(NativeField = true)]
        public bool preserveRatio { get; set; }
        [JsProperty(NativeField = true)]
        public static Resizable prototype { get; set; }
        [JsProperty(NativeField = true)]
        public Element proxy { get; set; }
        [JsProperty(NativeField = true)]
        public object resizeChild { get; set; }
        [JsProperty(NativeField = true)]
        public object resizeRegion { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public bool transparent { get; set; }
        [JsProperty(NativeField = true)]
        public double width { get; set; }
        [JsProperty(NativeField = true)]
        public double widthIncrement { get; set; }
        [JsProperty(NativeField = true)]
        public bool wrap { get; set; }
    }

    public delegate void ResizableBeforeresizeDelegate(Resizable objthis, EventObject e);

    [JsType(JsMode.Json)]
    public class ResizableConfig
    {
        // Methods
        public ResizableConfig() { throw new Exception(); }

        // Properties
        public object adjustments { get; set; }
        public bool animate { get; set; }
        public object constrainTo { get; set; }
        public bool disableTrackOver { get; set; }
        public bool draggable { get; set; }
        public double duration { get; set; }
        public bool dynamic { get; set; }
        public string easing { get; set; }
        public bool enabled { get; set; }
        public string handles { get; set; }
        public double height { get; set; }
        public double heightIncrement { get; set; }
        public double maxHeight { get; set; }
        public double maxWidth { get; set; }
        public double minHeight { get; set; }
        public double minWidth { get; set; }
        public double minX { get; set; }
        public double minY { get; set; }
        public bool multiDirectional { get; set; }
        public bool pinned { get; set; }
        public bool preserveRatio { get; set; }
        public object resizeChild { get; set; }
        public object resizeRegion { get; set; }
        public bool transparent { get; set; }
        public double width { get; set; }
        public double widthIncrement { get; set; }
        public bool wrap { get; set; }
    }

    public class ResizableEvents
    {
        // Methods
        public ResizableEvents() { throw new Exception(); }

        // Properties
        public static string beforeresize { get { throw new Exception(); } }
        public static string resize { get { throw new Exception(); } }
    }

    public delegate void ResizableResizeDelegate(Resizable objthis, double width, double height, EventObject e);

    [JsType(JsMode.Prototype, Export = false)]
    public class Shadow
    {
        // Methods
        public Shadow() { throw new Exception(); }
        public Shadow(ShadowConfig config) { throw new Exception(); }
        public Shadow(object config) { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public void isVisible() { throw new Exception(); }
        public void realign() { throw new Exception(); }
        public void realign(double left) { throw new Exception(); }
        public void realign(double left, double top) { throw new Exception(); }
        public void realign(double left, double top, double width) { throw new Exception(); }
        public void realign(double left, double top, double width, double height) { throw new Exception(); }
        public void setZIndex() { throw new Exception(); }
        public void setZIndex(double zindex) { throw new Exception(); }
        public void show() { throw new Exception(); }
        public void show(object targetEl) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string mode { get; set; }
        [JsProperty(NativeField = true)]
        public string offset { get; set; }
        [JsProperty(NativeField = true)]
        public static Shadow prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ShadowConfig
    {
        // Methods
        public ShadowConfig() { throw new Exception(); }

        // Properties
        public string mode { get; set; }
        public string offset { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Slider : BoxComponent
    {
        // Methods
        public Slider() { throw new Exception(); }
        public Slider(Element config) { throw new Exception(); }
        public Slider(SliderConfig config) { throw new Exception(); }
        public Slider(object config) { throw new Exception(); }
        public Slider(string config) { throw new Exception(); }
        public double getValue() { throw new Exception(); }
        public void setValue() { throw new Exception(); }
        public void setValue(double value) { throw new Exception(); }
        public void setValue(double value, bool animate) { throw new Exception(); }
        public void syncThumb() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool animate { get; set; }
        [JsProperty(NativeField = true)]
        public bool clickToChange { get; set; }
        [JsProperty(NativeField = true)]
        public object decimalPrecision { get; set; }
        [JsProperty(NativeField = true)]
        public bool dragging { get; set; }
        [JsProperty(NativeField = true)]
        public double increment { get; set; }
        [JsProperty(NativeField = true)]
        public double keyIncrement { get; set; }
        [JsProperty(NativeField = true)]
        public double maxValue { get; set; }
        [JsProperty(NativeField = true)]
        public double minValue { get; set; }
        [JsProperty(NativeField = true)]
        public static Slider prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double value { get; set; }
        [JsProperty(NativeField = true)]
        public bool vertical { get; set; }
    }

    public delegate void SliderBeforechangeDelegate(Slider slider, double newValue, double oldValue);

    public delegate void SliderChangecompleteDelegate(Slider slider, double newValue);

    public delegate void SliderChangeDelegate(Slider slider, double newValue);

    [JsType(JsMode.Json)]
    public class SliderConfig
    {
        // Methods
        public SliderConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animate { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public bool clickToChange { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object decimalPrecision { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public double increment { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public double keyIncrement { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public double maxValue { get; set; }
        public double minValue { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double value { get; set; }
        public bool vertical { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void SliderDragDelegate(Slider slider, EventObject e);

    public delegate void SliderDragendDelegate(Slider slider, EventObject e);

    public delegate void SliderDragstartDelegate(Slider slider, EventObject e);

    public class SliderEvents
    {
        // Methods
        public SliderEvents() { throw new Exception(); }

        // Properties
        public static string beforechange { get { throw new Exception(); } }
        public static string change { get { throw new Exception(); } }
        public static string changecomplete { get { throw new Exception(); } }
        public static string drag { get { throw new Exception(); } }
        public static string dragend { get { throw new Exception(); } }
        public static string dragstart { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Spacer : BoxComponent
    {
        // Methods
        public Spacer() { throw new Exception(); }
        public Spacer(Element config) { throw new Exception(); }
        public Spacer(SpacerConfig config) { throw new Exception(); }
        public Spacer(object config) { throw new Exception(); }
        public Spacer(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Spacer prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SpacerConfig
    {
        // Methods
        public SpacerConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class SplitBar : Observable
    {
        // Methods
        public SplitBar() { throw new Exception(); }
        public SplitBar(object dragElement) { throw new Exception(); }
        public SplitBar(object dragElement, object resizingElement) { throw new Exception(); }
        public SplitBar(object dragElement, object resizingElement, double orientation) { throw new Exception(); }
        public SplitBar(object dragElement, object resizingElement, double orientation, double placement) { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public void destroy(bool removeEl) { throw new Exception(); }
        public object getAdapter() { throw new Exception(); }
        public double getMaximumSize() { throw new Exception(); }
        public double getMinimumSize() { throw new Exception(); }
        public void setAdapter() { throw new Exception(); }
        public void setAdapter(object adapter) { throw new Exception(); }
        public void setCurrentSize() { throw new Exception(); }
        public void setCurrentSize(double size) { throw new Exception(); }
        public void setMaximumSize() { throw new Exception(); }
        public void setMaximumSize(double maxSize) { throw new Exception(); }
        public void setMinimumSize() { throw new Exception(); }
        public void setMinimumSize(double minSize) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool animate { get; set; }
        [JsProperty(NativeField = true)]
        public double maxSize { get; set; }
        [JsProperty(NativeField = true)]
        public double minSize { get; set; }
        [JsProperty(NativeField = true)]
        public static SplitBar prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double tickSize { get; set; }
        [JsProperty(NativeField = true)]
        public bool useShim { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class AbsoluteLayoutAdapter : SplitBar.BasicLayoutAdapter
        {
            // Methods
            public AbsoluteLayoutAdapter() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static double BOTTOM { get; set; }
            [JsProperty(NativeField = true)]
            public static double HORIZONTAL { get; set; }
            [JsProperty(NativeField = true)]
            public static double LEFT { get; set; }
            [JsProperty(NativeField = true)]
            public static SplitBar.AbsoluteLayoutAdapter prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static double RIGHT { get; set; }
            [JsProperty(NativeField = true)]
            public static SplitBar.BasicLayoutAdapter superclass { get; set; }
            [JsProperty(NativeField = true)]
            public static double TOP { get; set; }
            [JsProperty(NativeField = true)]
            public static double VERTICAL { get; set; }
        }

        [JsType(JsMode.Json)]
        public class AbsoluteLayoutAdapterConfig
        {
            // Methods
            public AbsoluteLayoutAdapterConfig() { throw new Exception(); }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class BasicLayoutAdapter
        {
            // Methods
            public BasicLayoutAdapter() { throw new Exception(); }
            public void getElementSize() { throw new Exception(); }
            public void getElementSize(SplitBar s) { throw new Exception(); }
            public void setElementSize() { throw new Exception(); }
            public void setElementSize(SplitBar s) { throw new Exception(); }
            public void setElementSize(SplitBar s, double newSize) { throw new Exception(); }
            public void setElementSize(SplitBar s, double newSize, JsAction onComplete) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static SplitBar.BasicLayoutAdapter prototype { get; set; }
        }

        [JsType(JsMode.Json)]
        public class BasicLayoutAdapterConfig
        {
            // Methods
            public BasicLayoutAdapterConfig() { throw new Exception(); }
        }
    }

    public delegate void SplitBarBeforeresizeDelegate(SplitBar objthis);

    [JsType(JsMode.Json)]
    public class SplitBarConfig
    {
        // Methods
        public SplitBarConfig() { throw new Exception(); }
    }

    public class SplitBarEvents
    {
        // Methods
        public SplitBarEvents() { throw new Exception(); }

        // Properties
        public static string beforeresize { get { throw new Exception(); } }
        public static string moved { get { throw new Exception(); } }
        public static string resize { get { throw new Exception(); } }
    }

    public delegate void SplitBarMovedDelegate(SplitBar objthis, double newSize);

    public delegate void SplitBarResizeDelegate(SplitBar objthis, double newSize);

    [JsType(JsMode.Prototype, Export = false)]
    public class SplitButton : Button
    {
        // Methods
        public SplitButton() { throw new Exception(); }
        public SplitButton(Element config) { throw new Exception(); }
        public SplitButton(SplitButtonConfig config) { throw new Exception(); }
        public SplitButton(object config) { throw new Exception(); }
        public SplitButton(string config) { throw new Exception(); }
        public void setArrowHandler() { throw new Exception(); }
        public void setArrowHandler(JsAction handler) { throw new Exception(); }
        public void setArrowHandler(JsAction handler, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static SplitButton prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Button superclass { get; set; }
    }

    public delegate void SplitButtonArrowclickDelegate(Button objthis, EventObject e);

    [JsType(JsMode.Json)]
    public class SplitButtonConfig
    {
        // Methods
        public SplitButtonConfig() { throw new Exception(); }

        // Properties
        public bool allowDepress { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public string arrowAlign { get; set; }
        public JsAction arrowHandler { get; set; }
        public string arrowTooltip { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string buttonSelector { get; set; }
        public string clearCls { get; set; }
        public string clickEvent { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool enableToggle { get; set; }
        public string fieldLabel { get; set; }
        public bool handleMouseEvents { get; set; }
        public JsAction handler { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string icon { get; set; }
        public string iconAlign { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object menu { get; set; }
        public string menuAlign { get; set; }
        public double minWidth { get; set; }
        public string overCls { get; set; }
        public string overflowText { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool pressed { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object repeat { get; set; }
        public string scale { get; set; }
        public object scope { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public Template template { get; set; }
        public string text { get; set; }
        public string toggleGroup { get; set; }
        public JsAction toggleHandler { get; set; }
        public object tooltip { get; set; }
        public string tooltipType { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string type { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class SplitButtonEvents
    {
        // Methods
        public SplitButtonEvents() { throw new Exception(); }

        // Properties
        public static string arrowclick { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class StoreMgr : MixedCollection
    {
        // Methods
        public StoreMgr() { throw new Exception(); }
        public StoreMgr(StoreMgrConfig config) { throw new Exception(); }
        public StoreMgr(bool allowFunctions) { throw new Exception(); }
        public StoreMgr(bool allowFunctions, JsAction keyFn) { throw new Exception(); }
        public static Store lookup() { throw new Exception(); }
        public static Store lookup(object id) { throw new Exception(); }
        public static Store lookup(string id) { throw new Exception(); }
        public static void register() { throw new Exception(); }
        public static void register(params Store[] args) { throw new Exception(); }
        public static void unregister() { throw new Exception(); }
        public static void unregister(params string[] args) { throw new Exception(); }
        public static void unregister(object id1) { throw new Exception(); }
        public static void unregister(object id1, object id2) { throw new Exception(); }
        public static void unregister(object id1, params string[] args) { throw new Exception(); }
        public static void unregister(string id1, object id2) { throw new Exception(); }
        public static void unregister(string id1, string id2) { throw new Exception(); }
        public static void unregister(object id1, object id2, params string[] args) { throw new Exception(); }
        public static void unregister(object id1, string id2, params object[] args) { throw new Exception(); }
        public static void unregister(string id1, object id2, params string[] args) { throw new Exception(); }
        public static void unregister(string id1, string id2, params object[] args) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static StoreMgr prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static MixedCollection superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class StoreMgrConfig
    {
        // Methods
        public StoreMgrConfig() { throw new Exception(); }

        // Properties
        public bool allowFunctions { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TabPanel : Panel
    {
        // Methods
        public TabPanel() { throw new Exception(); }
        public TabPanel(Element config) { throw new Exception(); }
        public TabPanel(TabPanelConfig config) { throw new Exception(); }
        public TabPanel(object config) { throw new Exception(); }
        public TabPanel(string config) { throw new Exception(); }
        public void activate() { throw new Exception(); }
        public void activate(Panel tab) { throw new Exception(); }
        public void activate(string tab) { throw new Exception(); }
        public void beginUpdate() { throw new Exception(); }
        public void endUpdate() { throw new Exception(); }
        public BoxComponent getActiveTab() { throw new Exception(); }
        public Panel getItem() { throw new Exception(); }
        public Panel getItem(string id) { throw new Exception(); }
        public HtmlElement getTabEl() { throw new Exception(); }
        public HtmlElement getTabEl(Panel tab) { throw new Exception(); }
        public HtmlElement getTabEl(double tab) { throw new Exception(); }
        public HtmlElement getTabEl(string tab) { throw new Exception(); }
        public object getTemplateArgs() { throw new Exception(); }
        public object getTemplateArgs(BoxComponent item) { throw new Exception(); }
        public void hideTabStripItem() { throw new Exception(); }
        public void hideTabStripItem(Panel item) { throw new Exception(); }
        public void hideTabStripItem(double item) { throw new Exception(); }
        public void hideTabStripItem(string item) { throw new Exception(); }
        public void readTabs() { throw new Exception(); }
        public void readTabs(bool removeExisting) { throw new Exception(); }
        public void setActiveTab() { throw new Exception(); }
        public void setActiveTab(double item) { throw new Exception(); }
        public void setActiveTab(string item) { throw new Exception(); }
        public void unhideTabStripItem() { throw new Exception(); }
        public void unhideTabStripItem(Panel item) { throw new Exception(); }
        public void unhideTabStripItem(double item) { throw new Exception(); }
        public void unhideTabStripItem(string item) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object activeTab { get; set; }
        [JsProperty(NativeField = true)]
        public bool animScroll { get; set; }
        [JsProperty(NativeField = true)]
        public bool autoTabs { get; set; }
        [JsProperty(NativeField = true)]
        public string autoTabSelector { get; set; }
        [JsProperty(NativeField = true)]
        public string baseCls { get; set; }
        [JsProperty(NativeField = true)]
        public bool deferredRender { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableTabScroll { get; set; }
        [JsProperty(NativeField = true)]
        public object itemTpl { get; set; }
        [JsProperty(NativeField = true)]
        public object layoutConfig { get; set; }
        [JsProperty(NativeField = true)]
        public bool layoutOnTabChange { get; set; }
        [JsProperty(NativeField = true)]
        public double minTabWidth { get; set; }
        [JsProperty(NativeField = true)]
        public bool monitorResize { get; set; }
        [JsProperty(NativeField = true)]
        public bool plain { get; set; }
        [JsProperty(NativeField = true)]
        public static TabPanel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool resizeTabs { get; set; }
        [JsProperty(NativeField = true)]
        public double scrollDuration { get; set; }
        [JsProperty(NativeField = true)]
        public double scrollIncrement { get; set; }
        [JsProperty(NativeField = true)]
        public double scrollRepeatInterval { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string tabCls { get; set; }
        [JsProperty(NativeField = true)]
        public double tabMargin { get; set; }
        [JsProperty(NativeField = true)]
        public string tabPosition { get; set; }
        [JsProperty(NativeField = true)]
        public double tabWidth { get; set; }
        [JsProperty(NativeField = true)]
        public double wheelIncrement { get; set; }
    }

    public delegate void TabPanelBeforetabchangeDelegate(TabPanel objthis, Panel newTab, Panel currentTab);

    [JsType(JsMode.Json)]
    public class TabPanelConfig
    {
        // Methods
        public TabPanelConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public object activeTab { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public bool animScroll { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoTabs { get; set; }
        public string autoTabSelector { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool deferredRender { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public bool enableTabScroll { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object itemTpl { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public bool layoutOnTabChange { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double minButtonWidth { get; set; }
        public double minTabWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public bool plain { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool resizeTabs { get; set; }
        public double scrollDuration { get; set; }
        public double scrollIncrement { get; set; }
        public double scrollRepeatInterval { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabCls { get; set; }
        public double tabMargin { get; set; }
        public string tabPosition { get; set; }
        public string tabTip { get; set; }
        public double tabWidth { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool unstyled { get; set; }
        public double wheelIncrement { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void TabPanelContextmenuDelegate(TabPanel objthis, Panel tab, EventObject e);

    public class TabPanelEvents
    {
        // Methods
        public TabPanelEvents() { throw new Exception(); }

        // Properties
        public static string beforetabchange { get { throw new Exception(); } }
        public static string contextmenu { get { throw new Exception(); } }
        public static string tabchange { get { throw new Exception(); } }
    }

    public delegate void TabPanelTabchangeDelegate(TabPanel objthis, Panel tab);

    [JsType(JsMode.Prototype, Export = false)]
    public class TaskMgr : TaskRunner
    {
        // Methods
        public TaskMgr() { throw new Exception(); }
        public TaskMgr(double interval) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static TaskMgr prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static TaskRunner superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TaskMgrConfig
    {
        // Methods
        public TaskMgrConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Template
    {
        // Methods
        public Template() { throw new Exception(); }
        public Template(TemplateConfig config) { throw new Exception(); }
        public Template(object config) { throw new Exception(); }
        public object append() { throw new Exception(); }
        public object append(object el) { throw new Exception(); }
        public object append(object el, Array values) { throw new Exception(); }
        public object append(object el, object values) { throw new Exception(); }
        public object append(object el, Array values, bool returnElement) { throw new Exception(); }
        public object append(object el, object values, bool returnElement) { throw new Exception(); }
        public string applyTemplate() { throw new Exception(); }
        public string applyTemplate(Array values) { throw new Exception(); }
        public string applyTemplate(object values) { throw new Exception(); }
        public Template compile() { throw new Exception(); }
        public static Template from() { throw new Exception(); }
        public static Template from(HtmlElement el) { throw new Exception(); }
        public static Template from(string el) { throw new Exception(); }
        public static Template from(HtmlElement el, object config) { throw new Exception(); }
        public static Template from(string el, object config) { throw new Exception(); }
        public object insertAfter() { throw new Exception(); }
        public object insertAfter(object el) { throw new Exception(); }
        public object insertAfter(object el, Array values) { throw new Exception(); }
        public object insertAfter(object el, object values) { throw new Exception(); }
        public object insertAfter(object el, Array values, bool returnElement) { throw new Exception(); }
        public object insertAfter(object el, object values, bool returnElement) { throw new Exception(); }
        public object insertBefore() { throw new Exception(); }
        public object insertBefore(object el) { throw new Exception(); }
        public object insertBefore(object el, Array values) { throw new Exception(); }
        public object insertBefore(object el, object values) { throw new Exception(); }
        public object insertBefore(object el, Array values, bool returnElement) { throw new Exception(); }
        public object insertBefore(object el, object values, bool returnElement) { throw new Exception(); }
        public object insertFirst() { throw new Exception(); }
        public object insertFirst(object el) { throw new Exception(); }
        public object insertFirst(object el, Array values) { throw new Exception(); }
        public object insertFirst(object el, object values) { throw new Exception(); }
        public object insertFirst(object el, Array values, bool returnElement) { throw new Exception(); }
        public object insertFirst(object el, object values, bool returnElement) { throw new Exception(); }
        public object overwrite() { throw new Exception(); }
        public object overwrite(object el) { throw new Exception(); }
        public object overwrite(object el, Array values) { throw new Exception(); }
        public object overwrite(object el, object values) { throw new Exception(); }
        public object overwrite(object el, Array values, bool returnElement) { throw new Exception(); }
        public object overwrite(object el, object values, bool returnElement) { throw new Exception(); }
        public Template set() { throw new Exception(); }
        public Template set(string html) { throw new Exception(); }
        public Template set(string html, bool compile) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool compiled { get; set; }
        [JsProperty(NativeField = true)]
        public static Template prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object re { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TemplateConfig
    {
        // Methods
        public TemplateConfig() { throw new Exception(); }

        // Properties
        public bool compiled { get; set; }
        public object re { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Tip : Panel
    {
        // Methods
        public Tip() { throw new Exception(); }
        public Tip(Element config) { throw new Exception(); }
        public Tip(TipConfig config) { throw new Exception(); }
        public Tip(object config) { throw new Exception(); }
        public Tip(string config) { throw new Exception(); }
        public void showAt() { throw new Exception(); }
        public void showAt(Array xy) { throw new Exception(); }
        public void showBy() { throw new Exception(); }
        public void showBy(object el) { throw new Exception(); }
        public void showBy(object el, string position) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool closable { get; set; }
        [JsProperty(NativeField = true)]
        public string defaultAlign { get; set; }
        [JsProperty(NativeField = true)]
        public double maxWidth { get; set; }
        [JsProperty(NativeField = true)]
        public double minWidth { get; set; }
        [JsProperty(NativeField = true)]
        public static Tip prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object shadow { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double width { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TipConfig
    {
        // Methods
        public TipConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string defaultAlign { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double maxWidth { get; set; }
        public double minButtonWidth { get; set; }
        public double minWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool unstyled { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Toolbar : Container
    {
        // Methods
        public Toolbar() { throw new Exception(); }
        public Toolbar(Element config) { throw new Exception(); }
        public Toolbar(ToolbarConfig config) { throw new Exception(); }
        public Toolbar(Array config) { throw new Exception(); }
        public Toolbar(object config) { throw new Exception(); }
        public Toolbar(string config) { throw new Exception(); }
        public void add() { throw new Exception(); }
        public void add(params object[] args) { throw new Exception(); }
        public object addButton() { throw new Exception(); }
        public object addButton(Array config) { throw new Exception(); }
        public object addButton(object config) { throw new Exception(); }
        public Item addDom() { throw new Exception(); }
        public Item addDom(object config) { throw new Exception(); }
        public Item addElement() { throw new Exception(); }
        public Item addElement(object el) { throw new Exception(); }
        public Item addField() { throw new Exception(); }
        public Item addField(Ext.form.Field field) { throw new Exception(); }
        public void addFill() { throw new Exception(); }
        public Item addItem() { throw new Exception(); }
        public Item addItem(Item item) { throw new Exception(); }
        public Item addSeparator() { throw new Exception(); }
        public Spacer addSpacer() { throw new Exception(); }
        public Item addText() { throw new Exception(); }
        public Item addText(string text) { throw new Exception(); }
        public object insertButton() { throw new Exception(); }
        public object insertButton(double index) { throw new Exception(); }
        public object insertButton(double index, Button item) { throw new Exception(); }
        public object insertButton(double index, Item item) { throw new Exception(); }
        public object insertButton(double index, Array item) { throw new Exception(); }
        public object insertButton(double index, object item) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool enableOverflow { get; set; }
        [JsProperty(NativeField = true)]
        public object layout { get; set; }
        [JsProperty(NativeField = true)]
        public static Toolbar prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Container superclass { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Fill : Toolbar.Spacer
        {
            // Methods
            public Fill() { throw new Exception(); }
            public Fill(Element config) { throw new Exception(); }
            public Fill(Toolbar.FillConfig config) { throw new Exception(); }
            public Fill(HtmlElement el) { throw new Exception(); }
            public Fill(object config) { throw new Exception(); }
            public Fill(string config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Toolbar.Fill prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Toolbar.Spacer superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class FillConfig
        {
            // Methods
            public FillConfig() { throw new Exception(); }

            // Properties
            public bool allowDomMove { get; set; }
            public string anchor { get; set; }
            public object applyTo { get; set; }
            public object autoEl { get; set; }
            public bool autoHeight { get; set; }
            public bool autoScroll { get; set; }
            public bool autoShow { get; set; }
            public bool autoWidth { get; set; }
            public double boxMaxHeight { get; set; }
            public double boxMaxWidth { get; set; }
            public double boxMinHeight { get; set; }
            public double boxMinWidth { get; set; }
            public string clearCls { get; set; }
            public string cls { get; set; }
            public string contentEl { get; set; }
            public string ctCls { get; set; }
            public object data { get; set; }
            public bool disabled { get; set; }
            public string disabledClass { get; set; }
            public string fieldLabel { get; set; }
            public double height { get; set; }
            public bool hidden { get; set; }
            public bool hideLabel { get; set; }
            public string hideMode { get; set; }
            public bool hideParent { get; set; }
            public object html { get; set; }
            public string id { get; set; }
            public string itemCls { get; set; }
            public string itemId { get; set; }
            public string labelSeparator { get; set; }
            public string labelStyle { get; set; }
            public object margins { get; set; }
            public string overCls { get; set; }
            public string overflowText { get; set; }
            public double pageX { get; set; }
            public double pageY { get; set; }
            public object plugins { get; set; }
            public string ptype { get; set; }
            public string @ref { get; set; }
            public string region { get; set; }
            public object renderTo { get; set; }
            public Array stateEvents { get; set; }
            public bool stateful { get; set; }
            public string stateId { get; set; }
            public string style { get; set; }
            public string tabTip { get; set; }
            public object tpl { get; set; }
            public string tplWriteMode { get; set; }
            public double width { get; set; }
            public double x { get; set; }
            public string xtype { get; set; }
            public double y { get; set; }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class Item : BoxComponent
        {
            // Methods
            public Item() { throw new Exception(); }
            public Item(Element config) { throw new Exception(); }
            public Item(Toolbar.ItemConfig config) { throw new Exception(); }
            public Item(HtmlElement el) { throw new Exception(); }
            public Item(object config) { throw new Exception(); }
            public Item(string config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public string overflowText { get; set; }
            [JsProperty(NativeField = true)]
            public static Toolbar.Item prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static BoxComponent superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class ItemConfig
        {
            // Methods
            public ItemConfig() { throw new Exception(); }

            // Properties
            public bool allowDomMove { get; set; }
            public string anchor { get; set; }
            public object applyTo { get; set; }
            public object autoEl { get; set; }
            public bool autoHeight { get; set; }
            public bool autoScroll { get; set; }
            public bool autoShow { get; set; }
            public bool autoWidth { get; set; }
            public double boxMaxHeight { get; set; }
            public double boxMaxWidth { get; set; }
            public double boxMinHeight { get; set; }
            public double boxMinWidth { get; set; }
            public string clearCls { get; set; }
            public string cls { get; set; }
            public string contentEl { get; set; }
            public string ctCls { get; set; }
            public object data { get; set; }
            public bool disabled { get; set; }
            public string disabledClass { get; set; }
            public string fieldLabel { get; set; }
            public double height { get; set; }
            public bool hidden { get; set; }
            public bool hideLabel { get; set; }
            public string hideMode { get; set; }
            public bool hideParent { get; set; }
            public object html { get; set; }
            public string id { get; set; }
            public string itemCls { get; set; }
            public string itemId { get; set; }
            public string labelSeparator { get; set; }
            public string labelStyle { get; set; }
            public object margins { get; set; }
            public string overCls { get; set; }
            public string overflowText { get; set; }
            public double pageX { get; set; }
            public double pageY { get; set; }
            public object plugins { get; set; }
            public string ptype { get; set; }
            public string @ref { get; set; }
            public string region { get; set; }
            public object renderTo { get; set; }
            public Array stateEvents { get; set; }
            public bool stateful { get; set; }
            public string stateId { get; set; }
            public string style { get; set; }
            public string tabTip { get; set; }
            public object tpl { get; set; }
            public string tplWriteMode { get; set; }
            public double width { get; set; }
            public double x { get; set; }
            public string xtype { get; set; }
            public double y { get; set; }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class Separator : Toolbar.Item
        {
            // Methods
            public Separator() { throw new Exception(); }
            public Separator(Element config) { throw new Exception(); }
            public Separator(Toolbar.SeparatorConfig config) { throw new Exception(); }
            public Separator(HtmlElement el) { throw new Exception(); }
            public Separator(object config) { throw new Exception(); }
            public Separator(string config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Toolbar.Separator prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Toolbar.Item superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class SeparatorConfig
        {
            // Methods
            public SeparatorConfig() { throw new Exception(); }

            // Properties
            public bool allowDomMove { get; set; }
            public string anchor { get; set; }
            public object applyTo { get; set; }
            public object autoEl { get; set; }
            public bool autoHeight { get; set; }
            public bool autoScroll { get; set; }
            public bool autoShow { get; set; }
            public bool autoWidth { get; set; }
            public double boxMaxHeight { get; set; }
            public double boxMaxWidth { get; set; }
            public double boxMinHeight { get; set; }
            public double boxMinWidth { get; set; }
            public string clearCls { get; set; }
            public string cls { get; set; }
            public string contentEl { get; set; }
            public string ctCls { get; set; }
            public object data { get; set; }
            public bool disabled { get; set; }
            public string disabledClass { get; set; }
            public string fieldLabel { get; set; }
            public double height { get; set; }
            public bool hidden { get; set; }
            public bool hideLabel { get; set; }
            public string hideMode { get; set; }
            public bool hideParent { get; set; }
            public object html { get; set; }
            public string id { get; set; }
            public string itemCls { get; set; }
            public string itemId { get; set; }
            public string labelSeparator { get; set; }
            public string labelStyle { get; set; }
            public object margins { get; set; }
            public string overCls { get; set; }
            public string overflowText { get; set; }
            public double pageX { get; set; }
            public double pageY { get; set; }
            public object plugins { get; set; }
            public string ptype { get; set; }
            public string @ref { get; set; }
            public string region { get; set; }
            public object renderTo { get; set; }
            public Array stateEvents { get; set; }
            public bool stateful { get; set; }
            public string stateId { get; set; }
            public string style { get; set; }
            public string tabTip { get; set; }
            public object tpl { get; set; }
            public string tplWriteMode { get; set; }
            public double width { get; set; }
            public double x { get; set; }
            public string xtype { get; set; }
            public double y { get; set; }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class Spacer : Toolbar.Item
        {
            // Methods
            public Spacer() { throw new Exception(); }
            public Spacer(Element config) { throw new Exception(); }
            public Spacer(Toolbar.SpacerConfig config) { throw new Exception(); }
            public Spacer(HtmlElement el) { throw new Exception(); }
            public Spacer(object config) { throw new Exception(); }
            public Spacer(string config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Toolbar.Spacer prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Toolbar.Item superclass { get; set; }
            [JsProperty(NativeField = true)]
            public double width { get; set; }
        }

        [JsType(JsMode.Json)]
        public class SpacerConfig
        {
            // Methods
            public SpacerConfig() { throw new Exception(); }

            // Properties
            public bool allowDomMove { get; set; }
            public string anchor { get; set; }
            public object applyTo { get; set; }
            public object autoEl { get; set; }
            public bool autoHeight { get; set; }
            public bool autoScroll { get; set; }
            public bool autoShow { get; set; }
            public bool autoWidth { get; set; }
            public double boxMaxHeight { get; set; }
            public double boxMaxWidth { get; set; }
            public double boxMinHeight { get; set; }
            public double boxMinWidth { get; set; }
            public string clearCls { get; set; }
            public string cls { get; set; }
            public string contentEl { get; set; }
            public string ctCls { get; set; }
            public object data { get; set; }
            public bool disabled { get; set; }
            public string disabledClass { get; set; }
            public string fieldLabel { get; set; }
            public double height { get; set; }
            public bool hidden { get; set; }
            public bool hideLabel { get; set; }
            public string hideMode { get; set; }
            public bool hideParent { get; set; }
            public object html { get; set; }
            public string id { get; set; }
            public string itemCls { get; set; }
            public string itemId { get; set; }
            public string labelSeparator { get; set; }
            public string labelStyle { get; set; }
            public object margins { get; set; }
            public string overCls { get; set; }
            public string overflowText { get; set; }
            public double pageX { get; set; }
            public double pageY { get; set; }
            public object plugins { get; set; }
            public string ptype { get; set; }
            public string @ref { get; set; }
            public string region { get; set; }
            public object renderTo { get; set; }
            public Array stateEvents { get; set; }
            public bool stateful { get; set; }
            public string stateId { get; set; }
            public string style { get; set; }
            public string tabTip { get; set; }
            public object tpl { get; set; }
            public string tplWriteMode { get; set; }
            public double width { get; set; }
            public double x { get; set; }
            public string xtype { get; set; }
            public double y { get; set; }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class TextItem : Toolbar.Item
        {
            // Methods
            public TextItem() { throw new Exception(); }
            public TextItem(Element config) { throw new Exception(); }
            public TextItem(Toolbar.TextItemConfig config) { throw new Exception(); }
            public TextItem(HtmlElement el) { throw new Exception(); }
            public TextItem(object text) { throw new Exception(); }
            public TextItem(string text) { throw new Exception(); }
            public void setText() { throw new Exception(); }
            public void setText(string t) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Toolbar.TextItem prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Toolbar.Item superclass { get; set; }
            [JsProperty(NativeField = true)]
            public string text { get; set; }
        }

        [JsType(JsMode.Json)]
        public class TextItemConfig
        {
            // Methods
            public TextItemConfig() { throw new Exception(); }

            // Properties
            public bool allowDomMove { get; set; }
            public string anchor { get; set; }
            public object applyTo { get; set; }
            public object autoEl { get; set; }
            public bool autoHeight { get; set; }
            public bool autoScroll { get; set; }
            public bool autoShow { get; set; }
            public bool autoWidth { get; set; }
            public double boxMaxHeight { get; set; }
            public double boxMaxWidth { get; set; }
            public double boxMinHeight { get; set; }
            public double boxMinWidth { get; set; }
            public string clearCls { get; set; }
            public string cls { get; set; }
            public string contentEl { get; set; }
            public string ctCls { get; set; }
            public object data { get; set; }
            public bool disabled { get; set; }
            public string disabledClass { get; set; }
            public string fieldLabel { get; set; }
            public double height { get; set; }
            public bool hidden { get; set; }
            public bool hideLabel { get; set; }
            public string hideMode { get; set; }
            public bool hideParent { get; set; }
            public object html { get; set; }
            public string id { get; set; }
            public string itemCls { get; set; }
            public string itemId { get; set; }
            public string labelSeparator { get; set; }
            public string labelStyle { get; set; }
            public object margins { get; set; }
            public string overCls { get; set; }
            public string overflowText { get; set; }
            public double pageX { get; set; }
            public double pageY { get; set; }
            public object plugins { get; set; }
            public string ptype { get; set; }
            public string @ref { get; set; }
            public string region { get; set; }
            public object renderTo { get; set; }
            public Array stateEvents { get; set; }
            public bool stateful { get; set; }
            public string stateId { get; set; }
            public string style { get; set; }
            public string tabTip { get; set; }
            public string text { get; set; }
            public object tpl { get; set; }
            public string tplWriteMode { get; set; }
            public double width { get; set; }
            public double x { get; set; }
            public string xtype { get; set; }
            public double y { get; set; }
        }
    }

    [JsType(JsMode.Json)]
    public class ToolbarConfig
    {
        // Methods
        public ToolbarConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool enableOverflow { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class ToolbarEvents
    {
        // Methods
        public ToolbarEvents() { throw new Exception(); }

        // Properties
        public static string overflowchange { get { throw new Exception(); } }
    }

    public delegate void ToolbarOverflowchangeDelegate(object c, bool lastOverflow);

    [JsType(JsMode.Prototype, Export = false)]
    public class ToolTip : Tip
    {
        // Methods
        public ToolTip() { throw new Exception(); }
        public ToolTip(Element config) { throw new Exception(); }
        public ToolTip(ToolTipConfig config) { throw new Exception(); }
        public ToolTip(object config) { throw new Exception(); }
        public ToolTip(string config) { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public void initTarget() { throw new Exception(); }
        public void initTarget(object t) { throw new Exception(); }
        public void show() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public double anchorOffset { get; set; }
        [JsProperty(NativeField = true)]
        public bool anchorToTarget { get; set; }
        [JsProperty(NativeField = true)]
        public bool autoHide { get; set; }
        [JsProperty(NativeField = true)]
        public string @delegate { get; set; }
        [JsProperty(NativeField = true)]
        public double dismissDelay { get; set; }
        [JsProperty(NativeField = true)]
        public double hideDelay { get; set; }
        [JsProperty(NativeField = true)]
        public Array mouseOffset { get; set; }
        [JsProperty(NativeField = true)]
        public static ToolTip prototype { get; set; }
        [JsProperty(NativeField = true)]
        public double showDelay { get; set; }
        [JsProperty(NativeField = true)]
        public static Tip superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object target { get; set; }
        [JsProperty(NativeField = true)]
        public bool trackMouse { get; set; }
        [JsProperty(NativeField = true)]
        public HtmlElement triggerElement { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ToolTipConfig
    {
        // Methods
        public ToolTipConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public double anchorOffset { get; set; }
        public bool anchorToTarget { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoHide { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string defaultAlign { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public string @delegate { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public double dismissDelay { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public double hideDelay { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double maxWidth { get; set; }
        public double minButtonWidth { get; set; }
        public double minWidth { get; set; }
        public bool monitorResize { get; set; }
        public Array mouseOffset { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public double showDelay { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object target { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool trackMouse { get; set; }
        public bool unstyled { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Updater : Observable
    {
        // Methods
        public Updater() { throw new Exception(); }
        public Updater(object el) { throw new Exception(); }
        public Updater(object el, bool forceNew) { throw new Exception(); }
        public void abort() { throw new Exception(); }
        public void formUpdate() { throw new Exception(); }
        public void formUpdate(HtmlElement form) { throw new Exception(); }
        public void formUpdate(string form) { throw new Exception(); }
        public void formUpdate(HtmlElement form, string url) { throw new Exception(); }
        public void formUpdate(string form, string url) { throw new Exception(); }
        public void formUpdate(HtmlElement form, string url, bool reset) { throw new Exception(); }
        public void formUpdate(string form, string url, bool reset) { throw new Exception(); }
        public void formUpdate(HtmlElement form, string url, bool reset, JsAction callback) { throw new Exception(); }
        public void formUpdate(string form, string url, bool reset, JsAction callback) { throw new Exception(); }
        public void formUpdateDelegate() { throw new Exception(); }
        public void getDefaultRenderer() { throw new Exception(); }
        public Element getEl() { throw new Exception(); }
        public object getRenderer() { throw new Exception(); }
        public void isAutoRefreshing() { throw new Exception(); }
        public bool isUpdating() { throw new Exception(); }
        public void refresh() { throw new Exception(); }
        public void refresh(JsAction callback) { throw new Exception(); }
        public void setDefaultUrl() { throw new Exception(); }
        public void setDefaultUrl(JsAction defaultUrl) { throw new Exception(); }
        public void setDefaultUrl(string defaultUrl) { throw new Exception(); }
        public void setRenderer() { throw new Exception(); }
        public void setRenderer(object renderer) { throw new Exception(); }
        public void showLoading() { throw new Exception(); }
        public void startAutoRefresh() { throw new Exception(); }
        public void startAutoRefresh(double interval) { throw new Exception(); }
        public void startAutoRefresh(double interval, JsAction url) { throw new Exception(); }
        public void startAutoRefresh(double interval, object url) { throw new Exception(); }
        public void startAutoRefresh(double interval, string url) { throw new Exception(); }
        public void startAutoRefresh(double interval, JsAction url, object prms) { throw new Exception(); }
        public void startAutoRefresh(double interval, JsAction url, string prms) { throw new Exception(); }
        public void startAutoRefresh(double interval, object url, object prms) { throw new Exception(); }
        public void startAutoRefresh(double interval, object url, string prms) { throw new Exception(); }
        public void startAutoRefresh(double interval, string url, object prms) { throw new Exception(); }
        public void startAutoRefresh(double interval, string url, string prms) { throw new Exception(); }
        public void startAutoRefresh(double interval, JsAction url, object prms, JsAction callback) { throw new Exception(); }
        public void startAutoRefresh(double interval, JsAction url, string prms, JsAction callback) { throw new Exception(); }
        public void startAutoRefresh(double interval, object url, object prms, JsAction callback) { throw new Exception(); }
        public void startAutoRefresh(double interval, object url, string prms, JsAction callback) { throw new Exception(); }
        public void startAutoRefresh(double interval, string url, object prms, JsAction callback) { throw new Exception(); }
        public void startAutoRefresh(double interval, string url, string prms, JsAction callback) { throw new Exception(); }
        public void startAutoRefresh(double interval, JsAction url, object prms, JsAction callback, bool refreshNow) { throw new Exception(); }
        public void startAutoRefresh(double interval, JsAction url, string prms, JsAction callback, bool refreshNow) { throw new Exception(); }
        public void startAutoRefresh(double interval, object url, object prms, JsAction callback, bool refreshNow) { throw new Exception(); }
        public void startAutoRefresh(double interval, object url, string prms, JsAction callback, bool refreshNow) { throw new Exception(); }
        public void startAutoRefresh(double interval, string url, object prms, JsAction callback, bool refreshNow) { throw new Exception(); }
        public void startAutoRefresh(double interval, string url, string prms, JsAction callback, bool refreshNow) { throw new Exception(); }
        public void stopAutoRefresh() { throw new Exception(); }
        public void update() { throw new Exception(); }
        public void update(object options) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string defaultUrl { get; set; }
        [JsProperty(NativeField = true)]
        public bool disableCaching { get; set; }
        [JsProperty(NativeField = true)]
        public Element el { get; set; }
        [JsProperty(NativeField = true)]
        public string indicatorText { get; set; }
        [JsProperty(NativeField = true)]
        public bool loadScripts { get; set; }
        [JsProperty(NativeField = true)]
        public static Updater prototype { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction refreshDelegate { get; set; }
        [JsProperty(NativeField = true)]
        public object renderer { get; set; }
        [JsProperty(NativeField = true)]
        public string showLoadIndicator { get; set; }
        [JsProperty(NativeField = true)]
        public string sslBlankUrl { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double timeout { get; set; }
        [JsProperty(NativeField = true)]
        public object transaction { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction updateDelegate { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class BasicRenderer
        {
            // Methods
            public BasicRenderer() { throw new Exception(); }
            public void render() { throw new Exception(); }
            public void render(Element el) { throw new Exception(); }
            public void render(Element el, object xhr) { throw new Exception(); }
            public void render(Element el, object xhr, Updater updateManager) { throw new Exception(); }
            public void render(Element el, object xhr, Updater updateManager, JsAction callback) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Updater.BasicRenderer prototype { get; set; }
        }

        [JsType(JsMode.Json)]
        public class BasicRendererConfig
        {
            // Methods
            public BasicRendererConfig() { throw new Exception(); }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class defaults
        {
            // Methods
            public defaults() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public bool disableCaching { get; set; }
            [JsProperty(NativeField = true)]
            public string indicatorText { get; set; }
            [JsProperty(NativeField = true)]
            public bool loadScripts { get; set; }
            [JsProperty(NativeField = true)]
            public static Updater.defaults prototype { get; set; }
            [JsProperty(NativeField = true)]
            public bool showLoadIndicator { get; set; }
            [JsProperty(NativeField = true)]
            public string sslBlankUrl { get; set; }
            [JsProperty(NativeField = true)]
            public double timeout { get; set; }
        }

        [JsType(JsMode.Json)]
        public class defaultsConfig
        {
            // Methods
            public defaultsConfig() { throw new Exception(); }
        }
    }

    public delegate void UpdaterBeforeupdateDelegate(Element el, object url, object prms);

    [JsType(JsMode.Json)]
    public class UpdaterConfig
    {
        // Methods
        public UpdaterConfig() { throw new Exception(); }
    }

    public class UpdaterEvents
    {
        // Methods
        public UpdaterEvents() { throw new Exception(); }

        // Properties
        public static string beforeupdate { get { throw new Exception(); } }
        public static string failure { get { throw new Exception(); } }
        public static string update { get { throw new Exception(); } }
    }

    public delegate void UpdaterFailureDelegate(Element el, object oResponseObject);

    public delegate void UpdaterUpdateDelegate(Element el, object oResponseObject);

    [JsType(JsMode.Prototype, Export = false)]
    public class Viewport : Container
    {
        // Methods
        public Viewport() { throw new Exception(); }
        public Viewport(Element config) { throw new Exception(); }
        public Viewport(ViewportConfig config) { throw new Exception(); }
        public Viewport(object config) { throw new Exception(); }
        public Viewport(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Viewport prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Container superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ViewportConfig
    {
        // Methods
        public ViewportConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Window : Panel
    {
        // Methods
        public Window() { throw new Exception(); }
        public Window(Element config) { throw new Exception(); }
        public Window(WindowConfig config) { throw new Exception(); }
        public Window(object config) { throw new Exception(); }
        public Window(string config) { throw new Exception(); }
        public Window alignTo() { throw new Exception(); }
        public Window alignTo(object element) { throw new Exception(); }
        public Window alignTo(object element, string position) { throw new Exception(); }
        public Window alignTo(object element, string position, Array offsets) { throw new Exception(); }
        public Window anchorTo() { throw new Exception(); }
        public Window anchorTo(object element) { throw new Exception(); }
        public Window anchorTo(object element, string position) { throw new Exception(); }
        public Window anchorTo(object element, string position, Array offsets) { throw new Exception(); }
        public Window anchorTo(object element, string position, Array offsets, bool monitorScroll) { throw new Exception(); }
        public Window anchorTo(object element, string position, Array offsets, double monitorScroll) { throw new Exception(); }
        public Window center() { throw new Exception(); }
        public void close() { throw new Exception(); }
        public void focus() { throw new Exception(); }
        public Window hide() { throw new Exception(); }
        public Window hide(Element animateTarget) { throw new Exception(); }
        public Window hide(string animateTarget) { throw new Exception(); }
        public Window hide(Element animateTarget, JsAction callback) { throw new Exception(); }
        public Window hide(string animateTarget, JsAction callback) { throw new Exception(); }
        public Window hide(Element animateTarget, JsAction callback, object scope) { throw new Exception(); }
        public Window hide(string animateTarget, JsAction callback, object scope) { throw new Exception(); }
        public Window maximize() { throw new Exception(); }
        public Window minimize() { throw new Exception(); }
        public Window restore() { throw new Exception(); }
        public void setActive() { throw new Exception(); }
        public void setActive(bool active) { throw new Exception(); }
        public void setAnimateTarget() { throw new Exception(); }
        public void setAnimateTarget(Element el) { throw new Exception(); }
        public void setAnimateTarget(string el) { throw new Exception(); }
        public Window show() { throw new Exception(); }
        public Window show(Element animateTarget) { throw new Exception(); }
        public Window show(string animateTarget) { throw new Exception(); }
        public Window show(Element animateTarget, JsAction callback) { throw new Exception(); }
        public Window show(string animateTarget, JsAction callback) { throw new Exception(); }
        public Window show(Element animateTarget, JsAction callback, object scope) { throw new Exception(); }
        public Window show(string animateTarget, JsAction callback, object scope) { throw new Exception(); }
        public Window toBack() { throw new Exception(); }
        public Window toFront() { throw new Exception(); }
        public Window toFront(bool e) { throw new Exception(); }
        public Window toggleMaximize() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object animateTarget { get; set; }
        [JsProperty(NativeField = true)]
        public string baseCls { get; set; }
        [JsProperty(NativeField = true)]
        public bool closable { get; set; }
        [JsProperty(NativeField = true)]
        public string closeAction { get; set; }
        [JsProperty(NativeField = true)]
        public bool collapsed { get; set; }
        [JsProperty(NativeField = true)]
        public bool constrain { get; set; }
        [JsProperty(NativeField = true)]
        public bool constrainHeader { get; set; }
        [JsProperty(NativeField = true)]
        public DD dd { get; set; }
        [JsProperty(NativeField = true)]
        public object defaultButton { get; set; }
        [JsProperty(NativeField = true)]
        public bool draggable { get; set; }
        [JsProperty(NativeField = true)]
        public bool expandOnShow { get; set; }
        [JsProperty(NativeField = true)]
        public bool hidden { get; set; }
        [JsProperty(NativeField = true)]
        public bool initHidden { get; set; }
        [JsProperty(NativeField = true)]
        public WindowGroup manager { get; set; }
        [JsProperty(NativeField = true)]
        public bool maximizable { get; set; }
        [JsProperty(NativeField = true)]
        public bool maximized { get; set; }
        [JsProperty(NativeField = true)]
        public double minHeight { get; set; }
        [JsProperty(NativeField = true)]
        public bool minimizable { get; set; }
        [JsProperty(NativeField = true)]
        public double minWidth { get; set; }
        [JsProperty(NativeField = true)]
        public bool modal { get; set; }
        [JsProperty(NativeField = true)]
        public object monitorResize { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction onEsc { get; set; }
        [JsProperty(NativeField = true)]
        public object onHide { get; set; }
        [JsProperty(NativeField = true)]
        public object onShow { get; set; }
        [JsProperty(NativeField = true)]
        public bool plain { get; set; }
        [JsProperty(NativeField = true)]
        public static Window prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool resizable { get; set; }
        [JsProperty(NativeField = true)]
        public string resizeHandles { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double x { get; set; }
        [JsProperty(NativeField = true)]
        public double y { get; set; }
    }

    public delegate void WindowActivateDelegate(Window objthis);

    [JsType(JsMode.Json)]
    public class WindowConfig
    {
        // Methods
        public WindowConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object animateTarget { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string closeAction { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public bool constrain { get; set; }
        public bool constrainHeader { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaultButton { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool draggable { get; set; }
        public string elements { get; set; }
        public bool expandOnShow { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public bool initHidden { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public WindowGroup manager { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public bool maximizable { get; set; }
        public bool maximized { get; set; }
        public double minButtonWidth { get; set; }
        public double minHeight { get; set; }
        public bool minimizable { get; set; }
        public double minWidth { get; set; }
        public bool modal { get; set; }
        public bool monitorResize { get; set; }
        public JsAction onEsc { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public bool plain { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool resizable { get; set; }
        public string resizeHandles { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool unstyled { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void WindowDeactivateDelegate(Window objthis);

    public class WindowEvents
    {
        // Methods
        public WindowEvents() { throw new Exception(); }

        // Properties
        public static string activate { get { throw new Exception(); } }
        public static string deactivate { get { throw new Exception(); } }
        public static string maximize { get { throw new Exception(); } }
        public static string minimize { get { throw new Exception(); } }
        public static string resize { get { throw new Exception(); } }
        public static string restore { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class WindowGroup
    {
        // Methods
        public WindowGroup() { throw new Exception(); }
        public bool bringToFront() { throw new Exception(); }
        public bool bringToFront(object win) { throw new Exception(); }
        public bool bringToFront(string win) { throw new Exception(); }
        public void each() { throw new Exception(); }
        public void each(JsAction fn) { throw new Exception(); }
        public void each(JsAction fn, object scope) { throw new Exception(); }
        public Window get() { throw new Exception(); }
        public Window get(object id) { throw new Exception(); }
        public Window get(string id) { throw new Exception(); }
        public Window getActive() { throw new Exception(); }
        public Array getBy() { throw new Exception(); }
        public Array getBy(JsAction fn) { throw new Exception(); }
        public Array getBy(JsAction fn, object scope) { throw new Exception(); }
        public void hideAll() { throw new Exception(); }
        public void register() { throw new Exception(); }
        public void register(Window win) { throw new Exception(); }
        public Window sendToBack() { throw new Exception(); }
        public Window sendToBack(object win) { throw new Exception(); }
        public Window sendToBack(string win) { throw new Exception(); }
        public void unregister() { throw new Exception(); }
        public void unregister(Window win) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static WindowGroup prototype { get; set; }
        [JsProperty(NativeField = true)]
        public double zseed { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WindowGroupConfig
    {
        // Methods
        public WindowGroupConfig() { throw new Exception(); }
    }

    public delegate void WindowMaximizeDelegate(Window objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class WindowMgr : WindowGroup
    {
        // Methods
        public WindowMgr() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static WindowMgr prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static WindowGroup superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WindowMgrConfig
    {
        // Methods
        public WindowMgrConfig() { throw new Exception(); }
    }

    public delegate void WindowMinimizeDelegate(Window objthis);

    public delegate void WindowResizeDelegate(Window objthis, double width, double height);

    public delegate void WindowRestoreDelegate(Window objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class XTemplate : Template
    {
        // Methods
        public XTemplate() { throw new Exception(); }
        public XTemplate(XTemplateConfig config) { throw new Exception(); }
        public XTemplate(object config) { throw new Exception(); }
        public string applyTemplate() { throw new Exception(); }
        public string applyTemplate(object values) { throw new Exception(); }
        public JsAction compile() { throw new Exception(); }
        public static Template from() { throw new Exception(); }
        public static Template from(HtmlElement el) { throw new Exception(); }
        public static Template from(string el) { throw new Exception(); }
        public void set() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static XTemplate prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Template superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class XTemplateConfig
    {
        // Methods
        public XTemplateConfig() { throw new Exception(); }

        // Properties
        public bool disableFormats { get; set; }
    }
}

namespace Ext.chart
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Axis
    {
        // Methods
        public Axis() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool hideOverlappingLabels { get; set; }
        [JsProperty(NativeField = true)]
        public string labelFunction { get; set; }
        [JsProperty(NativeField = true)]
        public string orientation { get; set; }
        [JsProperty(NativeField = true)]
        public static Axis prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool reverse { get; set; }
        [JsProperty(NativeField = true)]
        public string type { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AxisConfig
    {
        // Methods
        public AxisConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class BarChart : CartesianChart
    {
        // Methods
        public BarChart() { throw new Exception(); }
        public BarChart(BarChartConfig config) { throw new Exception(); }
        public BarChart(Element config) { throw new Exception(); }
        public BarChart(object config) { throw new Exception(); }
        public BarChart(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static BarChart prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CartesianChart superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BarChartConfig
    {
        // Methods
        public BarChartConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public object chartStyle { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disableCaching { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public object extraStyle { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object seriesStyles { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class BarSeries : CartesianSeries
    {
        // Methods
        public BarSeries() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static BarSeries prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CartesianSeries superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BarSeriesConfig
    {
        // Methods
        public BarSeriesConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CartesianChart : Chart
    {
        // Methods
        public CartesianChart() { throw new Exception(); }
        public CartesianChart(CartesianChartConfig config) { throw new Exception(); }
        public CartesianChart(Element config) { throw new Exception(); }
        public CartesianChart(object config) { throw new Exception(); }
        public CartesianChart(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static CartesianChart prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Chart superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CartesianChartConfig
    {
        // Methods
        public CartesianChartConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public object chartStyle { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disableCaching { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public object extraStyle { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object seriesStyles { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CartesianSeries : Series
    {
        // Methods
        public CartesianSeries() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static CartesianSeries prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Series superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string xField { get; set; }
        [JsProperty(NativeField = true)]
        public string yField { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CartesianSeriesConfig
    {
        // Methods
        public CartesianSeriesConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CategoryAxis : Axis
    {
        // Methods
        public CategoryAxis() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public Array categoryNames { get; set; }
        [JsProperty(NativeField = true)]
        public static CategoryAxis prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Axis superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CategoryAxisConfig
    {
        // Methods
        public CategoryAxisConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Chart : FlashComponent
    {
        // Methods
        public Chart() { throw new Exception(); }
        public Chart(ChartConfig config) { throw new Exception(); }
        public Chart(Element config) { throw new Exception(); }
        public Chart(object config) { throw new Exception(); }
        public Chart(string config) { throw new Exception(); }
        public void bindStore() { throw new Exception(); }
        public void bindStore(Store store) { throw new Exception(); }
        public void setSeriesStyles() { throw new Exception(); }
        public void setSeriesStyles(object styles) { throw new Exception(); }
        public void setStyle() { throw new Exception(); }
        public void setStyle(object name) { throw new Exception(); }
        public void setStyle(object name, object value) { throw new Exception(); }
        public void setStyles() { throw new Exception(); }
        public void setStyles(object styles) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static string CHART_URL { get; set; }
        [JsProperty(NativeField = true)]
        public object chartStyle { get; set; }
        [JsProperty(NativeField = true)]
        public bool disableCaching { get; set; }
        [JsProperty(NativeField = true)]
        public object extraStyle { get; set; }
        [JsProperty(NativeField = true)]
        public static Chart prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object seriesStyles { get; set; }
        [JsProperty(NativeField = true)]
        public static FlashComponent superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
    }

    public delegate void ChartBeforerefreshDelegate(Chart objthis);

    [JsType(JsMode.Json)]
    public class ChartConfig
    {
        // Methods
        public ChartConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public object chartStyle { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disableCaching { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public object extraStyle { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object seriesStyles { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class ChartEvents
    {
        // Methods
        public ChartEvents() { throw new Exception(); }

        // Properties
        public static string beforerefresh { get { throw new Exception(); } }
        public static string refresh { get { throw new Exception(); } }
    }

    public delegate void ChartRefreshDelegate(Chart objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class ColumnChart : CartesianChart
    {
        // Methods
        public ColumnChart() { throw new Exception(); }
        public ColumnChart(ColumnChartConfig config) { throw new Exception(); }
        public ColumnChart(Element config) { throw new Exception(); }
        public ColumnChart(object config) { throw new Exception(); }
        public ColumnChart(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static ColumnChart prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CartesianChart superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ColumnChartConfig
    {
        // Methods
        public ColumnChartConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public object chartStyle { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disableCaching { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public object extraStyle { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object seriesStyles { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ColumnSeries : CartesianSeries
    {
        // Methods
        public ColumnSeries() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static ColumnSeries prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CartesianSeries superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ColumnSeriesConfig
    {
        // Methods
        public ColumnSeriesConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class LineChart : CartesianChart
    {
        // Methods
        public LineChart() { throw new Exception(); }
        public LineChart(LineChartConfig config) { throw new Exception(); }
        public LineChart(Element config) { throw new Exception(); }
        public LineChart(object config) { throw new Exception(); }
        public LineChart(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static LineChart prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CartesianChart superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class LineChartConfig
    {
        // Methods
        public LineChartConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public object chartStyle { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disableCaching { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public object extraStyle { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object seriesStyles { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class LineSeries : CartesianSeries
    {
        // Methods
        public LineSeries() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static LineSeries prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CartesianSeries superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class LineSeriesConfig
    {
        // Methods
        public LineSeriesConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class NumericAxis : Axis
    {
        // Methods
        public NumericAxis() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool alwaysShowZero { get; set; }
        [JsProperty(NativeField = true)]
        public double majorUnit { get; set; }
        [JsProperty(NativeField = true)]
        public double maximum { get; set; }
        [JsProperty(NativeField = true)]
        public double minimum { get; set; }
        [JsProperty(NativeField = true)]
        public double minorUnit { get; set; }
        [JsProperty(NativeField = true)]
        public static NumericAxis prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string scale { get; set; }
        [JsProperty(NativeField = true)]
        public bool snapToUnits { get; set; }
        [JsProperty(NativeField = true)]
        public static Axis superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class NumericAxisConfig
    {
        // Methods
        public NumericAxisConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class PieChart : Chart
    {
        // Methods
        public PieChart() { throw new Exception(); }
        public PieChart(PieChartConfig config) { throw new Exception(); }
        public PieChart(Element config) { throw new Exception(); }
        public PieChart(object config) { throw new Exception(); }
        public PieChart(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static PieChart prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Chart superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PieChartConfig
    {
        // Methods
        public PieChartConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public object chartStyle { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disableCaching { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public object extraStyle { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object seriesStyles { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class PieSeries : Series
    {
        // Methods
        public PieSeries() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static PieSeries prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Series superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PieSeriesConfig
    {
        // Methods
        public PieSeriesConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Series
    {
        // Methods
        public Series() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string displayName { get; set; }
        [JsProperty(NativeField = true)]
        public static Series prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string type { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SeriesConfig
    {
        // Methods
        public SeriesConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class StackedBarChart : CartesianChart
    {
        // Methods
        public StackedBarChart() { throw new Exception(); }
        public StackedBarChart(StackedBarChartConfig config) { throw new Exception(); }
        public StackedBarChart(Element config) { throw new Exception(); }
        public StackedBarChart(object config) { throw new Exception(); }
        public StackedBarChart(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static StackedBarChart prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CartesianChart superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class StackedBarChartConfig
    {
        // Methods
        public StackedBarChartConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public object chartStyle { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disableCaching { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public object extraStyle { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object seriesStyles { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class StackedColumnChart : CartesianChart
    {
        // Methods
        public StackedColumnChart() { throw new Exception(); }
        public StackedColumnChart(StackedColumnChartConfig config) { throw new Exception(); }
        public StackedColumnChart(Element config) { throw new Exception(); }
        public StackedColumnChart(object config) { throw new Exception(); }
        public StackedColumnChart(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static StackedColumnChart prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CartesianChart superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class StackedColumnChartConfig
    {
        // Methods
        public StackedColumnChartConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string backgroundColor { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public object chartStyle { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disableCaching { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool expressInstall { get; set; }
        public object extraStyle { get; set; }
        public string fieldLabel { get; set; }
        public object flashParams { get; set; }
        public object flashVars { get; set; }
        public string flashVersion { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object seriesStyles { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string url { get; set; }
        public double width { get; set; }
        public string wmode { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TimeAxis : Axis
    {
        // Methods
        public TimeAxis() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string majorTimeUnit { get; set; }
        [JsProperty(NativeField = true)]
        public double majorUnit { get; set; }
        [JsProperty(NativeField = true)]
        public double maximum { get; set; }
        [JsProperty(NativeField = true)]
        public DateTime minimum { get; set; }
        [JsProperty(NativeField = true)]
        public static TimeAxis prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool snapToUnits { get; set; }
        [JsProperty(NativeField = true)]
        public static Axis superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TimeAxisConfig
    {
        // Methods
        public TimeAxisConfig() { throw new Exception(); }
    }
}


namespace Ext.data
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Api
    {
        // Methods
        public Api() { throw new Exception(); }
        public static object getVerb() { throw new Exception(); }
        public static object getVerb(string name) { throw new Exception(); }
        public static bool hasUniqueUrl() { throw new Exception(); }
        public static bool hasUniqueUrl(DataProxy proxy) { throw new Exception(); }
        public static bool hasUniqueUrl(DataProxy proxy, string verb) { throw new Exception(); }
        public static bool isAction() { throw new Exception(); }
        public static bool isAction(string action) { throw new Exception(); }
        public static bool isAction(string action, string Optional) { throw new Exception(); }
        public static object isValid() { throw new Exception(); }
        public static void prepare() { throw new Exception(); }
        public static void prepare(DataProxy proxy) { throw new Exception(); }
        public static void Response() { throw new Exception(); }
        public static void restify() { throw new Exception(); }
        public static void restify(DataProxy proxy) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static object actions { get; set; }
        [JsProperty(NativeField = true)]
        public static Api prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static object restActions { get; set; }
        [JsProperty(NativeField = true)]
        public static object superclass { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Error : Ext.Error
        {
            // Methods
            public Error() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Api.Error prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Error superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class ErrorConfig
        {
            // Methods
            public ErrorConfig() { throw new Exception(); }
        }
    }

    [JsType(JsMode.Json)]
    public class ApiConfig
    {
        // Methods
        public ApiConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ArrayReader : JsonReader
    {
        // Methods
        public ArrayReader() { throw new Exception(); }
        public ArrayReader(ArrayReaderConfig config) { throw new Exception(); }
        public ArrayReader(object meta) { throw new Exception(); }
        public ArrayReader(object meta, Array recordType) { throw new Exception(); }
        public ArrayReader(object meta, object recordType) { throw new Exception(); }
        public object readRecords() { throw new Exception(); }
        public object readRecords(object o) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public double id { get; set; }
        [JsProperty(NativeField = true)]
        public double idIndex { get; set; }
        [JsProperty(NativeField = true)]
        public static ArrayReader prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static JsonReader superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ArrayReaderConfig
    {
        // Methods
        public ArrayReaderConfig() { throw new Exception(); }

        // Properties
        public object fields { get; set; }
        public double id { get; set; }
        public double idIndex { get; set; }
        public string idProperty { get; set; }
        public string messageProperty { get; set; }
        public string root { get; set; }
        public string successProperty { get; set; }
        public string totalProperty { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ArrayStore : Store
    {
        // Methods
        public ArrayStore() { throw new Exception(); }
        public ArrayStore(ArrayStoreConfig config) { throw new Exception(); }
        public ArrayStore(object config) { throw new Exception(); }
        public void constructor() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static ArrayStore prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Store superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ArrayStoreConfig
    {
        // Methods
        public ArrayStoreConfig() { throw new Exception(); }

        // Properties
        public bool autoDestroy { get; set; }
        public object autoLoad { get; set; }
        public bool autoSave { get; set; }
        public object baseParams { get; set; }
        public bool batch { get; set; }
        public Array data { get; set; }
        public object defaultParamNames { get; set; }
        public FieldConfig[] fields { get; set; }
        public object paramNames { get; set; }
        public DataProxy proxy { get; set; }
        public bool pruneModifiedRecords { get; set; }
        public DataReader reader { get; set; }
        public bool remoteSort { get; set; }
        public bool restful { get; set; }
        public object sortInfo { get; set; }
        public string storeId { get; set; }
        public string url { get; set; }
        public DataWriter writer { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Connection : Observable
    {
        // Methods
        public Connection() { throw new Exception(); }
        public Connection(ConnectionConfig config) { throw new Exception(); }
        public Connection(object config) { throw new Exception(); }
        public void abort() { throw new Exception(); }
        public void abort(double transactionId) { throw new Exception(); }
        public bool isLoading() { throw new Exception(); }
        public bool isLoading(double transactionId) { throw new Exception(); }
        public double request() { throw new Exception(); }
        public double request(object options) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool autoAbort { get; set; }
        [JsProperty(NativeField = true)]
        public object defaultHeaders { get; set; }
        [JsProperty(NativeField = true)]
        public bool disableCaching { get; set; }
        [JsProperty(NativeField = true)]
        public string disableCachingParam { get; set; }
        [JsProperty(NativeField = true)]
        public object extraParams { get; set; }
        [JsProperty(NativeField = true)]
        public string method { get; set; }
        [JsProperty(NativeField = true)]
        public static Connection prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double timeout { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
    }

    public delegate void ConnectionBeforerequestDelegate(Connection conn, object options);

    [JsType(JsMode.Json)]
    public class ConnectionConfig
    {
        // Methods
        public ConnectionConfig() { throw new Exception(); }

        // Properties
        public bool autoAbort { get; set; }
        public object defaultHeaders { get; set; }
        public bool disableCaching { get; set; }
        public string disableCachingParam { get; set; }
        public object extraParams { get; set; }
        public string method { get; set; }
        public double timeout { get; set; }
        public string url { get; set; }
    }

    public class ConnectionEvents
    {
        // Methods
        public ConnectionEvents() { throw new Exception(); }

        // Properties
        public static string beforerequest { get { throw new Exception(); } }
        public static string requestcomplete { get { throw new Exception(); } }
        public static string requestexception { get { throw new Exception(); } }
    }

    public delegate void ConnectionRequestcompleteDelegate(Connection conn, object response, object options);

    public delegate void ConnectionRequestexceptionDelegate(Connection conn, object response, object options);

    [JsType(JsMode.Prototype, Export = false)]
    public class DataProxy : Observable
    {
        // Methods
        public DataProxy() { throw new Exception(); }
        public DataProxy(DataProxyConfig config) { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public void doRequest() { throw new Exception(); }
        public bool isApiAction() { throw new Exception(); }
        public bool isApiAction(string action) { throw new Exception(); }
        public void request() { throw new Exception(); }
        public void request(string action) { throw new Exception(); }
        public void request(string action, Record rs) { throw new Exception(); }
        public void request(string action, Record rs, object prms) { throw new Exception(); }
        public void request(string action, Record rs, object prms, DataReader reader) { throw new Exception(); }
        public void request(string action, Record rs, object prms, DataReader reader, JsAction callback) { throw new Exception(); }
        public void request(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope) { throw new Exception(); }
        public void request(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope, object options) { throw new Exception(); }
        public void setApi() { throw new Exception(); }
        public void setApi(object api) { throw new Exception(); }
        public void setApi(string api) { throw new Exception(); }
        public void setApi(object api, JsAction url) { throw new Exception(); }
        public void setApi(object api, string url) { throw new Exception(); }
        public void setApi(string api, JsAction url) { throw new Exception(); }
        public void setApi(string api, string url) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object api { get; set; }
        [JsProperty(NativeField = true)]
        public object load { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction onRead { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction onWrite { get; set; }
        [JsProperty(NativeField = true)]
        public static DataProxy prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool restful { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Error : Ext.Error
        {
            // Methods
            public Error() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static DataProxy.Error prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Error superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class ErrorConfig
        {
            // Methods
            public ErrorConfig() { throw new Exception(); }
        }
    }

    public delegate void DataProxyBeforeloadDelegate(DataProxy objthis, object prms);

    public delegate void DataProxyBeforewriteDelegate(DataProxy objthis, string action, object rs, object prms);

    [JsType(JsMode.Json)]
    public class DataProxyConfig
    {
        // Methods
        public DataProxyConfig() { throw new Exception(); }

        // Properties
        public object api { get; set; }
        public JsAction doRequest { get; set; }
        public JsAction onRead { get; set; }
        public JsAction onWrite { get; set; }
        public bool restful { get; set; }
    }

    public class DataProxyEvents
    {
        // Methods
        public DataProxyEvents() { throw new Exception(); }

        // Properties
        public static string beforeload { get { throw new Exception(); } }
        public static string beforewrite { get { throw new Exception(); } }
        public static string exception { get { throw new Exception(); } }
        public static string load { get { throw new Exception(); } }
        public static string loadexception { get { throw new Exception(); } }
        public static string write { get { throw new Exception(); } }
    }

    public delegate void DataProxyExceptionDelegate(DataProxy objthis, string type, string action, object options, object response, object arg);

    public delegate void DataProxyLoadDelegate(DataProxy objthis, object o, object options);

    public delegate void DataProxyLoadexceptionDelegate(object misc);

    public delegate void DataProxyWriteDelegate(DataProxy objthis, string action, object data, object response, object prm, object options);

    [JsType(JsMode.Prototype, Export = false)]
    public class DataReader
    {
        // Methods
        public DataReader() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DataReader prototype { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Error : Ext.Error
        {
            // Methods
            public Error() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static DataReader.Error prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Error superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class ErrorConfig
        {
            // Methods
            public ErrorConfig() { throw new Exception(); }
        }
    }

    [JsType(JsMode.Json)]
    public class DataReaderConfig
    {
        // Methods
        public DataReaderConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DataWriter
    {
        // Methods
        public DataWriter() { throw new Exception(); }
        public DataWriter(DataWriterConfig config) { throw new Exception(); }
        public DataWriter(object meta) { throw new Exception(); }
        public DataWriter(object meta, object recordType) { throw new Exception(); }
        public void apply() { throw new Exception(); }
        public void apply(object prms) { throw new Exception(); }
        public void apply(object prms, object baseParams) { throw new Exception(); }
        public void apply(object prms, object baseParams, string action) { throw new Exception(); }
        public void apply(object prms, object baseParams, string action, Record rs) { throw new Exception(); }
        public object toArray() { throw new Exception(); }
        public object toArray(object data) { throw new Exception(); }
        public object toHash() { throw new Exception(); }
        public object toHash(Record prm) { throw new Exception(); }
        public object toHash(Record prm, object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public JsAction createRecord { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction destroyRecord { get; set; }
        [JsProperty(NativeField = true)]
        public bool listful { get; set; }
        [JsProperty(NativeField = true)]
        public static DataWriter prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object render { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction updateRecord { get; set; }
        [JsProperty(NativeField = true)]
        public bool writeAllFields { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DataWriterConfig
    {
        // Methods
        public DataWriterConfig() { throw new Exception(); }

        // Properties
        public JsAction createRecord { get; set; }
        public JsAction destroyRecord { get; set; }
        public bool listful { get; set; }
        public JsAction updateRecord { get; set; }
        public bool writeAllFields { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DirectProxy : DataProxy
    {
        // Methods
        public DirectProxy() { throw new Exception(); }
        public DirectProxy(DirectProxyConfig config) { throw new Exception(); }
        public void doRequest() { throw new Exception(); }
        public void doRequest(string action) { throw new Exception(); }
        public void doRequest(string action, Record rs) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope, object arg) { throw new Exception(); }
        public void onRead() { throw new Exception(); }
        public void onRead(string action) { throw new Exception(); }
        public void onRead(string action, object trans) { throw new Exception(); }
        public void onRead(string action, object trans, object result) { throw new Exception(); }
        public void onRead(string action, object trans, object result, object res) { throw new Exception(); }
        public void onWrite() { throw new Exception(); }
        public void onWrite(string action) { throw new Exception(); }
        public void onWrite(string action, object trans) { throw new Exception(); }
        public void onWrite(string action, object trans, object result) { throw new Exception(); }
        public void onWrite(string action, object trans, object result, object res) { throw new Exception(); }
        public void onWrite(string action, object trans, object result, object res, Record rs) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public JsAction directFn { get; set; }
        [JsProperty(NativeField = true)]
        public object paramOrder { get; set; }
        [JsProperty(NativeField = true)]
        public bool paramsAsHash { get; set; }
        [JsProperty(NativeField = true)]
        public static DirectProxy prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DataProxy superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DirectProxyConfig
    {
        // Methods
        public DirectProxyConfig() { throw new Exception(); }

        // Properties
        public object api { get; set; }
        public JsAction directFn { get; set; }
        public JsAction doRequest { get; set; }
        public JsAction onRead { get; set; }
        public JsAction onWrite { get; set; }
        public object paramOrder { get; set; }
        public bool paramsAsHash { get; set; }
        public bool restful { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DirectStore : Store
    {
        // Methods
        public DirectStore() { throw new Exception(); }
        public DirectStore(DirectStoreConfig config) { throw new Exception(); }
        public DirectStore(object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DirectStore prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Store superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DirectStoreConfig
    {
        // Methods
        public DirectStoreConfig() { throw new Exception(); }

        // Properties
        public bool autoDestroy { get; set; }
        public object autoLoad { get; set; }
        public bool autoSave { get; set; }
        public object baseParams { get; set; }
        public bool batch { get; set; }
        public Array data { get; set; }
        public object defaultParamNames { get; set; }
        public object paramNames { get; set; }
        public DataProxy proxy { get; set; }
        public bool pruneModifiedRecords { get; set; }
        public DataReader reader { get; set; }
        public bool remoteSort { get; set; }
        public bool restful { get; set; }
        public object sortInfo { get; set; }
        public string storeId { get; set; }
        public string url { get; set; }
        public DataWriter writer { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Field
    {
        // Methods
        public Field() { throw new Exception(); }
        public Field(FieldConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowBlank { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction convert { get; set; }
        [JsProperty(NativeField = true)]
        public string dateFormat { get; set; }
        [JsProperty(NativeField = true)]
        public object defaultValue { get; set; }
        [JsProperty(NativeField = true)]
        public object mapping { get; set; }
        [JsProperty(NativeField = true)]
        public string name { get; set; }
        [JsProperty(NativeField = true)]
        public static Field prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string sortDir { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction sortType { get; set; }
        [JsProperty(NativeField = true)]
        public string type { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FieldConfig
    {
        // Methods
        public FieldConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public JsAction convert { get; set; }
        public string dateFormat { get; set; }
        public object defaultValue { get; set; }
        public object mapping { get; set; }
        public string name { get; set; }
        public string sortDir { get; set; }
        public JsAction sortType { get; set; }
        public string type { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class GroupingStore : Store
    {
        // Methods
        public GroupingStore() { throw new Exception(); }
        public GroupingStore(GroupingStoreConfig config) { throw new Exception(); }
        public GroupingStore(object config) { throw new Exception(); }
        public void clearGrouping() { throw new Exception(); }
        public void groupBy() { throw new Exception(); }
        public void groupBy(string field) { throw new Exception(); }
        public void groupBy(string field, bool forceRegroup) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string groupField { get; set; }
        [JsProperty(NativeField = true)]
        public bool groupOnSort { get; set; }
        [JsProperty(NativeField = true)]
        public static GroupingStore prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool remoteGroup { get; set; }
        [JsProperty(NativeField = true)]
        public static Store superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GroupingStoreConfig
    {
        // Methods
        public GroupingStoreConfig() { throw new Exception(); }

        // Properties
        public bool autoDestroy { get; set; }
        public object autoLoad { get; set; }
        public bool autoSave { get; set; }
        public object baseParams { get; set; }
        public bool batch { get; set; }
        public Array data { get; set; }
        public object defaultParamNames { get; set; }
        public string groupField { get; set; }
        public bool groupOnSort { get; set; }
        public object paramNames { get; set; }
        public DataProxy proxy { get; set; }
        public bool pruneModifiedRecords { get; set; }
        public DataReader reader { get; set; }
        public bool remoteGroup { get; set; }
        public bool remoteSort { get; set; }
        public bool restful { get; set; }
        public object sortInfo { get; set; }
        public string storeId { get; set; }
        public string url { get; set; }
        public DataWriter writer { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class HttpProxy : DataProxy
    {
        // Methods
        public HttpProxy() { throw new Exception(); }
        public HttpProxy(HttpProxyConfig config) { throw new Exception(); }
        public HttpProxy(object conn) { throw new Exception(); }
        public void doRequest() { throw new Exception(); }
        public void doRequest(string action) { throw new Exception(); }
        public void doRequest(string action, Record rs) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope, object arg) { throw new Exception(); }
        public Connection getConnection() { throw new Exception(); }
        public void onRead() { throw new Exception(); }
        public void onRead(string action) { throw new Exception(); }
        public void onRead(string action, object o) { throw new Exception(); }
        public void onRead(string action, object o, object res) { throw new Exception(); }
        public void onWrite() { throw new Exception(); }
        public void onWrite(string action) { throw new Exception(); }
        public void onWrite(string action, object trans) { throw new Exception(); }
        public void onWrite(string action, object trans, object res) { throw new Exception(); }
        public void setUrl() { throw new Exception(); }
        public void setUrl(string url) { throw new Exception(); }
        public void setUrl(string url, bool makePermanent) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object conn { get; set; }
        [JsProperty(NativeField = true)]
        public static HttpProxy prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DataProxy superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HttpProxyConfig
    {
        // Methods
        public HttpProxyConfig() { throw new Exception(); }

        // Properties
        public object api { get; set; }
        public JsAction doRequest { get; set; }
        public JsAction onRead { get; set; }
        public JsAction onWrite { get; set; }
        public bool restful { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class JsonReader : DataReader
    {
        // Methods
        public JsonReader() { throw new Exception(); }
        public JsonReader(JsonReaderConfig config) { throw new Exception(); }
        public JsonReader(object meta) { throw new Exception(); }
        public JsonReader(object meta, Array recordType) { throw new Exception(); }
        public JsonReader(object meta, object recordType) { throw new Exception(); }
        public object read() { throw new Exception(); }
        public object read(object response) { throw new Exception(); }
        public object readRecords() { throw new Exception(); }
        public object readRecords(object o) { throw new Exception(); }
        public void readResponse() { throw new Exception(); }
        public void readResponse(string action) { throw new Exception(); }
        public void readResponse(string action, object response) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string idProperty { get; set; }
        [JsProperty(NativeField = true)]
        public object jsonData { get; set; }
        [JsProperty(NativeField = true)]
        public object meta { get; set; }
        [JsProperty(NativeField = true)]
        public static JsonReader prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string root { get; set; }
        [JsProperty(NativeField = true)]
        public string successProperty { get; set; }
        [JsProperty(NativeField = true)]
        public static DataReader superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string totalProperty { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Error
        {
            // Methods
            public Error() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static JsonReader.Error prototype { get; set; }
        }

        [JsType(JsMode.Json)]
        public class ErrorConfig
        {
            // Methods
            public ErrorConfig() { throw new Exception(); }
        }
    }

    [JsType(JsMode.Json)]
    public class JsonReaderConfig
    {
        // Methods
        public JsonReaderConfig() { throw new Exception(); }

        // Properties
        public object fields { get; set; }
        public string idProperty { get; set; }
        public string messageProperty { get; set; }
        public string root { get; set; }
        public string successProperty { get; set; }
        public string totalProperty { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class JsonStore : Store
    {
        // Methods
        public JsonStore() { throw new Exception(); }
        public JsonStore(JsonStoreConfig config) { throw new Exception(); }
        public JsonStore(object config) { throw new Exception(); }
        public void constructor() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static JsonStore prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Store superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class JsonStoreConfig
    {
        // Methods
        public JsonStoreConfig() { throw new Exception(); }

        // Properties
        public bool autoDestroy { get; set; }
        public object autoLoad { get; set; }
        public bool autoSave { get; set; }
        public object baseParams { get; set; }
        public bool batch { get; set; }
        public Array data { get; set; }
        public object defaultParamNames { get; set; }
        public object paramNames { get; set; }
        public DataProxy proxy { get; set; }
        public bool pruneModifiedRecords { get; set; }
        public DataReader reader { get; set; }
        public bool remoteSort { get; set; }
        public bool restful { get; set; }
        public object sortInfo { get; set; }
        public string storeId { get; set; }
        public string url { get; set; }
        public DataWriter writer { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class JsonWriter : DataWriter
    {
        // Methods
        public JsonWriter() { throw new Exception(); }
        public JsonWriter(JsonWriterConfig config) { throw new Exception(); }
        public JsonWriter(object meta) { throw new Exception(); }
        public JsonWriter(object meta, object recordType) { throw new Exception(); }
        public object createRecord() { throw new Exception(); }
        public object createRecord(Record rec) { throw new Exception(); }
        public object destroyRecord() { throw new Exception(); }
        public object destroyRecord(Record rec) { throw new Exception(); }
        public void render() { throw new Exception(); }
        public void render(object http) { throw new Exception(); }
        public void render(object http, object baseParams) { throw new Exception(); }
        public void render(object http, object baseParams, object data) { throw new Exception(); }
        public object updateRecord() { throw new Exception(); }
        public object updateRecord(Record rec) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool encode { get; set; }
        [JsProperty(NativeField = true)]
        public static JsonWriter prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool returnJson { get; set; }
        [JsProperty(NativeField = true)]
        public static DataWriter superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class JsonWriterConfig
    {
        // Methods
        public JsonWriterConfig() { throw new Exception(); }

        // Properties
        public JsAction createRecord { get; set; }
        public JsAction destroyRecord { get; set; }
        public bool encode { get; set; }
        public bool listful { get; set; }
        public bool returnJson { get; set; }
        public JsAction updateRecord { get; set; }
        public bool writeAllFields { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class MemoryProxy : DataProxy
    {
        // Methods
        public MemoryProxy() { throw new Exception(); }
        public MemoryProxy(MemoryProxyConfig config) { throw new Exception(); }
        public MemoryProxy(object data) { throw new Exception(); }
        public void doRequest() { throw new Exception(); }
        public void doRequest(string action) { throw new Exception(); }
        public void doRequest(string action, Record rs) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope, object arg) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static MemoryProxy prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DataProxy superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class MemoryProxyConfig
    {
        // Methods
        public MemoryProxyConfig() { throw new Exception(); }

        // Properties
        public object api { get; set; }
        public JsAction doRequest { get; set; }
        public JsAction onRead { get; set; }
        public JsAction onWrite { get; set; }
        public bool restful { get; set; }
    }

    public class MemoryProxyEvents
    {
        // Methods
        public MemoryProxyEvents() { throw new Exception(); }

        // Properties
        public static string loadexception { get { throw new Exception(); } }
    }

    public delegate void MemoryProxyLoadexceptionDelegate(object objthis, object arg, object nul, object e);

    [JsType(JsMode.Prototype, Export = false)]
    public class Node : Observable
    {
        // Methods
        public Node() { throw new Exception(); }
        public Node(NodeConfig config) { throw new Exception(); }
        public Node(object attributes) { throw new Exception(); }
        public Node appendChild() { throw new Exception(); }
        public Node appendChild(Node node) { throw new Exception(); }
        public Node appendChild(Array node) { throw new Exception(); }
        public void bubble() { throw new Exception(); }
        public void bubble(JsAction fn) { throw new Exception(); }
        public void bubble(JsAction fn, object scope) { throw new Exception(); }
        public void bubble(JsAction fn, object scope, Array args) { throw new Exception(); }
        public void cascade() { throw new Exception(); }
        public void cascade(JsAction fn) { throw new Exception(); }
        public void cascade(JsAction fn, object scope) { throw new Exception(); }
        public void cascade(JsAction fn, object scope, Array args) { throw new Exception(); }
        public bool contains() { throw new Exception(); }
        public bool contains(Node node) { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public void eachChild() { throw new Exception(); }
        public void eachChild(JsAction fn) { throw new Exception(); }
        public void eachChild(JsAction fn, object scope) { throw new Exception(); }
        public void eachChild(JsAction fn, object scope, Array args) { throw new Exception(); }
        public Node findChild() { throw new Exception(); }
        public Node findChild(string attribute) { throw new Exception(); }
        public Node findChild(string attribute, object value) { throw new Exception(); }
        public Node findChildBy() { throw new Exception(); }
        public Node findChildBy(JsAction fn) { throw new Exception(); }
        public Node findChildBy(JsAction fn, object scope) { throw new Exception(); }
        public double getDepth() { throw new Exception(); }
        public Tree getOwnerTree() { throw new Exception(); }
        public string getPath() { throw new Exception(); }
        public string getPath(string attr) { throw new Exception(); }
        public bool hasChildNodes() { throw new Exception(); }
        public double indexOf() { throw new Exception(); }
        public double indexOf(Node node) { throw new Exception(); }
        public Node insertBefore() { throw new Exception(); }
        public Node insertBefore(Node node) { throw new Exception(); }
        public Node insertBefore(Node node, Node refNode) { throw new Exception(); }
        public bool isAncestor() { throw new Exception(); }
        public bool isAncestor(Node node) { throw new Exception(); }
        public bool isExpandable() { throw new Exception(); }
        public bool isFirst() { throw new Exception(); }
        public bool isLast() { throw new Exception(); }
        public bool isLeaf() { throw new Exception(); }
        public Node item() { throw new Exception(); }
        public Node item(double index) { throw new Exception(); }
        public Node remove() { throw new Exception(); }
        public Node remove(bool destroy) { throw new Exception(); }
        public Node removeChild() { throw new Exception(); }
        public Node removeChild(Node node) { throw new Exception(); }
        public Node removeChild(Node node, bool destroy) { throw new Exception(); }
        public Node replaceChild() { throw new Exception(); }
        public Node replaceChild(Node newChild) { throw new Exception(); }
        public Node replaceChild(Node newChild, Node oldChild) { throw new Exception(); }
        public void setId() { throw new Exception(); }
        public void setId(string id) { throw new Exception(); }
        public void sort() { throw new Exception(); }
        public void sort(JsAction fn) { throw new Exception(); }
        public void sort(JsAction fn, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object attributes { get; set; }
        [JsProperty(NativeField = true)]
        public object childNodes { get; set; }
        [JsProperty(NativeField = true)]
        public object firstChild { get; set; }
        [JsProperty(NativeField = true)]
        public object id { get; set; }
        [JsProperty(NativeField = true)]
        public object lastChild { get; set; }
        [JsProperty(NativeField = true)]
        public object nextSibling { get; set; }
        [JsProperty(NativeField = true)]
        public object parentNode { get; set; }
        [JsProperty(NativeField = true)]
        public object previousSibling { get; set; }
        [JsProperty(NativeField = true)]
        public static Node prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void NodeAppendDelegate(Tree tree, Node objthis, Node node, double index);

    public delegate void NodeBeforeappendDelegate(Tree tree, Node objthis, Node node);

    public delegate void NodeBeforeinsertDelegate(Tree tree, Node objthis, Node node, Node refNode);

    public delegate void NodeBeforemoveDelegate(Tree tree, Node objthis, Node oldParent, Node newParent, double index);

    public delegate void NodeBeforeremoveDelegate(Tree tree, Node objthis, Node node);

    [JsType(JsMode.Json)]
    public class NodeConfig
    {
        // Methods
        public NodeConfig() { throw new Exception(); }

        // Properties
        public string id { get; set; }
        public bool leaf { get; set; }
    }

    public class NodeEvents
    {
        // Methods
        public NodeEvents() { throw new Exception(); }

        // Properties
        public static string append { get { throw new Exception(); } }
        public static string beforeappend { get { throw new Exception(); } }
        public static string beforeinsert { get { throw new Exception(); } }
        public static string beforemove { get { throw new Exception(); } }
        public static string beforeremove { get { throw new Exception(); } }
        public static string insert { get { throw new Exception(); } }
        public static string move { get { throw new Exception(); } }
        public static string remove { get { throw new Exception(); } }
    }

    public delegate void NodeInsertDelegate(Tree tree, Node objthis, Node node, Node refNode);

    public delegate void NodeMoveDelegate(Tree tree, Node objthis, Node oldParent, Node newParent, double index);

    public delegate void NodeRemoveDelegate(Tree tree, Node objthis, Node node);

    [JsType(JsMode.Prototype, Export = false)]
    public class Record
    {
        // Methods
        public Record() { throw new Exception(); }
        public Record(object data) { throw new Exception(); }
        public Record(object data, object id) { throw new Exception(); }
        public void beginEdit() { throw new Exception(); }
        public void cancelEdit() { throw new Exception(); }
        public void commit() { throw new Exception(); }
        public void commit(bool silent) { throw new Exception(); }
        public Record copy() { throw new Exception(); }
        public Record copy(string id) { throw new Exception(); }
        public static JsAction create() { throw new Exception(); }
        public static JsAction create(Array o) { throw new Exception(); }
        public void endEdit() { throw new Exception(); }
        public object get() { throw new Exception(); }
        public object get(string name) { throw new Exception(); }
        public object getChanges() { throw new Exception(); }
        public bool isModified() { throw new Exception(); }
        public bool isModified(string fieldName) { throw new Exception(); }
        public bool isValid() { throw new Exception(); }
        public void markDirty() { throw new Exception(); }
        public void reject() { throw new Exception(); }
        public void reject(bool silent) { throw new Exception(); }
        public void set() { throw new Exception(); }
        public void set(string name) { throw new Exception(); }
        public void set(string name, Array value) { throw new Exception(); }
        public void set(string name, object value) { throw new Exception(); }
        public void set(string name, string value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object data { get; set; }
        [JsProperty(NativeField = true)]
        public bool dirty { get; set; }
        [JsProperty(NativeField = true)]
        public MixedCollection fields { get; set; }
        [JsProperty(NativeField = true)]
        public object id { get; set; }
        [JsProperty(NativeField = true)]
        public object json { get; set; }
        [JsProperty(NativeField = true)]
        public object modified { get; set; }
        [JsProperty(NativeField = true)]
        public HtmlElement node { get; set; }//TODO:XmlElement
        [JsProperty(NativeField = true)]
        public bool phantom { get; set; }
        [JsProperty(NativeField = true)]
        public static Record prototype { get; set; }
        [JsProperty(NativeField = true)]
        public Store store { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RecordConfig
    {
        // Methods
        public RecordConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Request
    {
        // Methods
        public Request() { throw new Exception(); }
        public Request(RequestConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string action { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction callback { get; set; }
        [JsProperty(NativeField = true)]
        public object params_ { get; set; }
        [JsProperty(NativeField = true)]
        public static Request prototype { get; set; }
        [JsProperty(NativeField = true)]
        public DataReader reader { get; set; }
        [JsProperty(NativeField = true)]
        public object rs { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RequestConfig
    {
        // Methods
        public RequestConfig() { throw new Exception(); }

        // Properties
        public string action { get; set; }
        public JsAction callback { get; set; }
        public object @params { get; set; }
        public DataReader reader { get; set; }
        public object rs { get; set; }
        public object scope { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Response
    {
        // Methods
        public Response() { throw new Exception(); }
        public Response(ResponseConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string action { get; set; }
        [JsProperty(NativeField = true)]
        public object data { get; set; }
        [JsProperty(NativeField = true)]
        public string message { get; set; }
        [JsProperty(NativeField = true)]
        public static Response prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object raw { get; set; }
        [JsProperty(NativeField = true)]
        public object records { get; set; }
        [JsProperty(NativeField = true)]
        public bool success { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ResponseConfig
    {
        // Methods
        public ResponseConfig() { throw new Exception(); }

        // Properties
        public string action { get; set; }
        public object data { get; set; }
        public string message { get; set; }
        public object raw { get; set; }
        public object records { get; set; }
        public bool success { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ScriptTagProxy : DataProxy
    {
        // Methods
        public ScriptTagProxy() { throw new Exception(); }
        public ScriptTagProxy(ScriptTagProxyConfig config) { throw new Exception(); }
        public ScriptTagProxy(object config) { throw new Exception(); }
        public void abort() { throw new Exception(); }
        public void doRequest() { throw new Exception(); }
        public void doRequest(string action) { throw new Exception(); }
        public void doRequest(string action, Record rs) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope) { throw new Exception(); }
        public void doRequest(string action, Record rs, object prms, DataReader reader, JsAction callback, object scope, object arg) { throw new Exception(); }
        public void onRead() { throw new Exception(); }
        public void onRead(string action) { throw new Exception(); }
        public void onRead(string action, object trans) { throw new Exception(); }
        public void onRead(string action, object trans, object res) { throw new Exception(); }
        public void onWrite() { throw new Exception(); }
        public void onWrite(string action) { throw new Exception(); }
        public void onWrite(string action, object trans) { throw new Exception(); }
        public void onWrite(string action, object trans, object res) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string callbackParam { get; set; }
        [JsProperty(NativeField = true)]
        public bool nocache { get; set; }
        [JsProperty(NativeField = true)]
        public static ScriptTagProxy prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DataProxy superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double timeout { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ScriptTagProxyConfig
    {
        // Methods
        public ScriptTagProxyConfig() { throw new Exception(); }

        // Properties
        public object api { get; set; }
        public string callbackParam { get; set; }
        public JsAction doRequest { get; set; }
        public bool nocache { get; set; }
        public JsAction onRead { get; set; }
        public JsAction onWrite { get; set; }
        public bool restful { get; set; }
        public double timeout { get; set; }
        public string url { get; set; }
    }

    public class ScriptTagProxyEvents
    {
        // Methods
        public ScriptTagProxyEvents() { throw new Exception(); }

        // Properties
        public static string loadexception { get { throw new Exception(); } }
    }

    public delegate void ScriptTagProxyLoadexceptionDelegate(object objthis, object options, object arg, object e);

    [JsType(JsMode.Prototype, Export = false)]
    public class SortTypes
    {
        // Methods
        public SortTypes() { throw new Exception(); }
        public static double asDate() { throw new Exception(); }
        public static double asDate(object s) { throw new Exception(); }
        public static double asFloat() { throw new Exception(); }
        public static double asFloat(object s) { throw new Exception(); }
        public static double asInt() { throw new Exception(); }
        public static double asInt(object s) { throw new Exception(); }
        public static string asText() { throw new Exception(); }
        public static string asText(object s) { throw new Exception(); }
        public static string asUCString() { throw new Exception(); }
        public static string asUCString(object s) { throw new Exception(); }
        public static string asUCText() { throw new Exception(); }
        public static string asUCText(object s) { throw new Exception(); }
        public static object none() { throw new Exception(); }
        public static object none(object s) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static SortTypes prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static object stripTagsRE { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SortTypesConfig
    {
        // Methods
        public SortTypesConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Store : Observable
    {
        // Methods
        public Store() { throw new Exception(); }
        public Store(StoreConfig config) { throw new Exception(); }
        public Store(object config) { throw new Exception(); }
        public void add() { throw new Exception(); }
        public void add(Record records) { throw new Exception(); }
        public void addSorted() { throw new Exception(); }
        public void addSorted(Record record) { throw new Exception(); }
        public Array clearFilter() { throw new Exception(); }
        public Array clearFilter(string dataIndex) { throw new Exception(); }
        public Array clearFilter(string dataIndex, bool allowNull) { throw new Exception(); }
        public Array clearFilter(string dataIndex, bool allowNull, bool bypassFilter) { throw new Exception(); }
        public void commitChanges() { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public void each() { throw new Exception(); }
        public void each(JsAction fn) { throw new Exception(); }
        public void each(JsAction fn, object scope) { throw new Exception(); }
        public void filter() { throw new Exception(); }
        public void filter(string field) { throw new Exception(); }
        public void filter(string field, object value) { throw new Exception(); }
        public void filter(string field, string value) { throw new Exception(); }
        public void filter(string field, object value, bool anyMatch) { throw new Exception(); }
        public void filter(string field, string value, bool anyMatch) { throw new Exception(); }
        public void filter(string field, object value, bool anyMatch, bool caseSensitive) { throw new Exception(); }
        public void filter(string field, string value, bool anyMatch, bool caseSensitive) { throw new Exception(); }
        public void filterBy() { throw new Exception(); }
        public void filterBy(JsAction fn) { throw new Exception(); }
        public void filterBy(JsAction fn, object scope) { throw new Exception(); }
        public MixedCollection find() { throw new Exception(); }
        public MixedCollection find(JsAction fn) { throw new Exception(); }
        public MixedCollection find(JsAction fn, object scope) { throw new Exception(); }
        public double findBy() { throw new Exception(); }
        public double findBy(JsAction fn) { throw new Exception(); }
        public double findBy(JsAction fn, object scope) { throw new Exception(); }
        public double findBy(JsAction fn, object scope, double startIndex) { throw new Exception(); }
        public double findExact() { throw new Exception(); }
        public double findExact(string fieldName) { throw new Exception(); }
        public double findExact(string fieldName, object value) { throw new Exception(); }
        public double findExact(string fieldName, object value, double startIndex) { throw new Exception(); }
        public Record getAt() { throw new Exception(); }
        public Record getAt(double index) { throw new Exception(); }
        public Record getById() { throw new Exception(); }
        public Record getById(string id) { throw new Exception(); }
        public double getCount() { throw new Exception(); }
        public Record getModifiedRecords() { throw new Exception(); }
        public Record getRange() { throw new Exception(); }
        public Record getRange(double startIndex) { throw new Exception(); }
        public Record getRange(double startIndex, double endIndex) { throw new Exception(); }
        public object getSortState() { throw new Exception(); }
        public double getTotalCount() { throw new Exception(); }
        public double indexOf() { throw new Exception(); }
        public double indexOf(Record record) { throw new Exception(); }
        public double indexOfId() { throw new Exception(); }
        public double indexOfId(string id) { throw new Exception(); }
        public void insert() { throw new Exception(); }
        public void insert(double index) { throw new Exception(); }
        public void insert(double index, Record records) { throw new Exception(); }
        public bool isFiltered() { throw new Exception(); }
        public bool load() { throw new Exception(); }
        public bool load(object options) { throw new Exception(); }
        public void loadData() { throw new Exception(); }
        public void loadData(object data) { throw new Exception(); }
        public void loadData(object data, bool append) { throw new Exception(); }
        public MixedCollection query() { throw new Exception(); }
        public MixedCollection query(string field) { throw new Exception(); }
        public MixedCollection query(string field, object value) { throw new Exception(); }
        public MixedCollection query(string field, string value) { throw new Exception(); }
        public MixedCollection query(string field, object value, bool anyMatch) { throw new Exception(); }
        public MixedCollection query(string field, string value, bool anyMatch) { throw new Exception(); }
        public MixedCollection query(string field, object value, bool anyMatch, bool caseSensitive) { throw new Exception(); }
        public MixedCollection query(string field, string value, bool anyMatch, bool caseSensitive) { throw new Exception(); }
        public void rejectChanges() { throw new Exception(); }
        public void reload() { throw new Exception(); }
        public void reload(object options) { throw new Exception(); }
        public void remove() { throw new Exception(); }
        public void remove(Record record) { throw new Exception(); }
        public void removeAll() { throw new Exception(); }
        public void removeAll(bool silent) { throw new Exception(); }
        public void removeAt() { throw new Exception(); }
        public void removeAt(double index) { throw new Exception(); }
        public double save() { throw new Exception(); }
        public void setDefaultSort() { throw new Exception(); }
        public void setDefaultSort(string fieldName) { throw new Exception(); }
        public void setDefaultSort(string fieldName, string dir) { throw new Exception(); }
        public void sort() { throw new Exception(); }
        public void sort(string fieldName) { throw new Exception(); }
        public void sort(string fieldName, string dir) { throw new Exception(); }
        public double sum() { throw new Exception(); }
        public double sum(string property) { throw new Exception(); }
        public double sum(string property, double start) { throw new Exception(); }
        public double sum(string property, double start, double end) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool autoDestroy { get; set; }
        [JsProperty(NativeField = true)]
        public object autoLoad { get; set; }
        [JsProperty(NativeField = true)]
        public bool autoSave { get; set; }
        [JsProperty(NativeField = true)]
        public object baseParams { get; set; }
        [JsProperty(NativeField = true)]
        public bool batch { get; set; }
        [JsProperty(NativeField = true)]
        public Array data { get; set; }
        [JsProperty(NativeField = true)]
        public object defaultParamNames { get; set; }
        [JsProperty(NativeField = true)]
        public MixedCollection fields { get; set; }
        [JsProperty(NativeField = true)]
        public object lastOptions { get; set; }
        [JsProperty(NativeField = true)]
        public object paramNames { get; set; }
        [JsProperty(NativeField = true)]
        public static Store prototype { get; set; }
        [JsProperty(NativeField = true)]
        public DataProxy proxy { get; set; }
        [JsProperty(NativeField = true)]
        public bool pruneModifiedRecords { get; set; }
        [JsProperty(NativeField = true)]
        public DataReader reader { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction recordType { get; set; }
        [JsProperty(NativeField = true)]
        public bool remoteSort { get; set; }
        [JsProperty(NativeField = true)]
        public bool restful { get; set; }
        [JsProperty(NativeField = true)]
        public object sortInfo { get; set; }
        [JsProperty(NativeField = true)]
        public string storeId { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
        [JsProperty(NativeField = true)]
        public DataWriter writer { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Error : Ext.Error
        {
            // Methods
            public Error() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Store.Error prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Error superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class ErrorConfig
        {
            // Methods
            public ErrorConfig() { throw new Exception(); }
        }
    }

    public delegate void StoreAddDelegate(Store objthis, Record records, double index);

    public delegate void StoreBeforeloadDelegate(Store objthis, object options);

    public delegate void StoreBeforesaveDelegate(Store store, object data);

    public delegate void StoreBeforewriteDelegate(Store store, string action, object rs, object options, object arg);

    public delegate void StoreClearDelegate(Store objthis, Record The);

    [JsType(JsMode.Json)]
    public class StoreConfig
    {
        // Methods
        public StoreConfig() { throw new Exception(); }

        // Properties
        public bool autoDestroy { get; set; }
        public object autoLoad { get; set; }
        public bool autoSave { get; set; }
        public object baseParams { get; set; }
        public bool batch { get; set; }
        public Array data { get; set; }
        public object defaultParamNames { get; set; }
        public object paramNames { get; set; }
        public DataProxy proxy { get; set; }
        public bool pruneModifiedRecords { get; set; }
        public DataReader reader { get; set; }
        public bool remoteSort { get; set; }
        public bool restful { get; set; }
        public object sortInfo { get; set; }
        public string storeId { get; set; }
        public string url { get; set; }
        public DataWriter writer { get; set; }
    }

    public delegate void StoreDatachangedDelegate(Store objthis);

    public class StoreEvents
    {
        // Methods
        public StoreEvents() { throw new Exception(); }

        // Properties
        public static string add { get { throw new Exception(); } }
        public static string beforeload { get { throw new Exception(); } }
        public static string beforesave { get { throw new Exception(); } }
        public static string beforewrite { get { throw new Exception(); } }
        public static string clear { get { throw new Exception(); } }
        public static string datachanged { get { throw new Exception(); } }
        public static string exception { get { throw new Exception(); } }
        public static string load { get { throw new Exception(); } }
        public static string loadexception { get { throw new Exception(); } }
        public static string metachange { get { throw new Exception(); } }
        public static string remove { get { throw new Exception(); } }
        public static string save { get { throw new Exception(); } }
        public static string update { get { throw new Exception(); } }
        public static string write { get { throw new Exception(); } }
    }

    public delegate void StoreExceptionDelegate(object misc);

    public delegate void StoreLoadDelegate(Store objthis, Record records, object options);

    public delegate void StoreLoadexceptionDelegate(object misc);

    public delegate void StoreMetachangeDelegate(Store objthis, object meta);

    public delegate void StoreRemoveDelegate(Store objthis, Record record, double index);

    public delegate void StoreSaveDelegate(Store store, double batch, object data);

    public delegate void StoreUpdateDelegate(Store objthis, Record record, string operation);

    public delegate void StoreWriteDelegate(Store store, string action, object result, Direct.Transaction res, object rs);

    [JsType(JsMode.Prototype, Export = false)]
    public class Tree : Observable
    {
        // Methods
        public Tree() { throw new Exception(); }
        public Tree(Node root) { throw new Exception(); }
        public Tree(TreeConfig config) { throw new Exception(); }
        public Node getNodeById() { throw new Exception(); }
        public Node getNodeById(string id) { throw new Exception(); }
        public Node getRootNode() { throw new Exception(); }
        public Node setRootNode() { throw new Exception(); }
        public Node setRootNode(Node node) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string pathSeparator { get; set; }
        [JsProperty(NativeField = true)]
        public static Tree prototype { get; set; }
        [JsProperty(NativeField = true)]
        public Node root { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void TreeAppendDelegate(Tree tree, Node parent, Node node, double index);

    public delegate void TreeBeforeappendDelegate(Tree tree, Node parent, Node node);

    public delegate void TreeBeforeinsertDelegate(Tree tree, Node parent, Node node, Node refNode);

    public delegate void TreeBeforemoveDelegate(Tree tree, Node node, Node oldParent, Node newParent, double index);

    public delegate void TreeBeforeremoveDelegate(Tree tree, Node parent, Node node);

    [JsType(JsMode.Json)]
    public class TreeConfig
    {
        // Methods
        public TreeConfig() { throw new Exception(); }

        // Properties
        public string pathSeparator { get; set; }
    }

    public class TreeEvents
    {
        // Methods
        public TreeEvents() { throw new Exception(); }

        // Properties
        public static string append { get { throw new Exception(); } }
        public static string beforeappend { get { throw new Exception(); } }
        public static string beforeinsert { get { throw new Exception(); } }
        public static string beforemove { get { throw new Exception(); } }
        public static string beforeremove { get { throw new Exception(); } }
        public static string insert { get { throw new Exception(); } }
        public static string move { get { throw new Exception(); } }
        public static string remove { get { throw new Exception(); } }
    }

    public delegate void TreeInsertDelegate(Tree tree, Node parent, Node node, Node refNode);

    public delegate void TreeMoveDelegate(Tree tree, Node node, Node oldParent, Node newParent, double index);

    public delegate void TreeRemoveDelegate(Tree tree, Node parent, Node node);

    [JsType(JsMode.Prototype, Export = false)]
    public class XmlReader : DataReader
    {
        // Methods
        public XmlReader() { throw new Exception(); }
        public XmlReader(XmlReaderConfig config) { throw new Exception(); }
        public XmlReader(object meta) { throw new Exception(); }
        public XmlReader(object meta, Array recordType) { throw new Exception(); }
        public XmlReader(object meta, object recordType) { throw new Exception(); }
        public object read() { throw new Exception(); }
        public object read(object response) { throw new Exception(); }
        public object readRecords() { throw new Exception(); }
        public object readRecords(object doc) { throw new Exception(); }
        public Response readResponse() { throw new Exception(); }
        public Response readResponse(string action) { throw new Exception(); }
        public Response readResponse(string action, object response) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static XmlReader prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DataReader superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object xmlData { get; set; }
    }

    [JsType(JsMode.Json)]
    public class XmlReaderConfig
    {
        // Methods
        public XmlReaderConfig() { throw new Exception(); }

        // Properties
        public object fields { get; set; }
        public string idPath { get; set; }
        public string messageProperty { get; set; }
        public string record { get; set; }
        public string successProperty { get; set; }
        public string totalProperty { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class XmlStore : Store
    {
        // Methods
        public XmlStore() { throw new Exception(); }
        public XmlStore(XmlStoreConfig config) { throw new Exception(); }
        public XmlStore(object config) { throw new Exception(); }
        public void constructor() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static XmlStore prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Store superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class XmlStoreConfig
    {
        // Methods
        public XmlStoreConfig() { throw new Exception(); }

        // Properties
        public bool autoDestroy { get; set; }
        public object autoLoad { get; set; }
        public bool autoSave { get; set; }
        public object baseParams { get; set; }
        public bool batch { get; set; }
        public Array data { get; set; }
        public object defaultParamNames { get; set; }
        public object paramNames { get; set; }
        public DataProxy proxy { get; set; }
        public bool pruneModifiedRecords { get; set; }
        public DataReader reader { get; set; }
        public bool remoteSort { get; set; }
        public bool restful { get; set; }
        public object sortInfo { get; set; }
        public string storeId { get; set; }
        public string url { get; set; }
        public DataWriter writer { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class XmlWriter : DataWriter
    {
        // Methods
        public XmlWriter() { throw new Exception(); }
        public XmlWriter(XmlWriterConfig config) { throw new Exception(); }
        public XmlWriter(object meta) { throw new Exception(); }
        public XmlWriter(object meta, object recordType) { throw new Exception(); }
        public Array createRecord() { throw new Exception(); }
        public Array createRecord(Record rec) { throw new Exception(); }
        public Array destroyRecord() { throw new Exception(); }
        public Array destroyRecord(Record rec) { throw new Exception(); }
        public void render() { throw new Exception(); }
        public void render(object prms) { throw new Exception(); }
        public void render(object prms, object baseParams) { throw new Exception(); }
        public void render(object prms, object baseParams, object data) { throw new Exception(); }
        public Array updateRecord() { throw new Exception(); }
        public Array updateRecord(Record rec) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string documentRoot { get; set; }
        [JsProperty(NativeField = true)]
        public bool forceDocumentRoot { get; set; }
        [JsProperty(NativeField = true)]
        public static XmlWriter prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string root { get; set; }
        [JsProperty(NativeField = true)]
        public static DataWriter superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object tpl { get; set; }
        [JsProperty(NativeField = true)]
        public string xmlEncoding { get; set; }
        [JsProperty(NativeField = true)]
        public string xmlVersion { get; set; }
    }

    [JsType(JsMode.Json)]
    public class XmlWriterConfig
    {
        // Methods
        public XmlWriterConfig() { throw new Exception(); }

        // Properties
        public JsAction createRecord { get; set; }
        public JsAction destroyRecord { get; set; }
        public string documentRoot { get; set; }
        public bool forceDocumentRoot { get; set; }
        public bool listful { get; set; }
        public string root { get; set; }
        public object tpl { get; set; }
        public JsAction updateRecord { get; set; }
        public bool writeAllFields { get; set; }
        public string xmlEncoding { get; set; }
        public string xmlVersion { get; set; }
    }
}


namespace Ext.dd
{
    [JsType(JsMode.Prototype, Export = false)]
    public class DD : DragDrop
    {
        // Methods
        public DD() { throw new Exception(); }
        public DD(string id) { throw new Exception(); }
        public DD(string id, string sGroup) { throw new Exception(); }
        public DD(string id, string sGroup, object config) { throw new Exception(); }
        public void alignElWithMouse() { throw new Exception(); }
        public void alignElWithMouse(HtmlElement el) { throw new Exception(); }
        public void alignElWithMouse(HtmlElement el, int iPageX) { throw new Exception(); }
        public void alignElWithMouse(HtmlElement el, int iPageX, int iPageY) { throw new Exception(); }
        public void applyConfig() { throw new Exception(); }
        public void autoOffset() { throw new Exception(); }
        public void autoOffset(int iPageX) { throw new Exception(); }
        public void autoOffset(int iPageX, int iPageY) { throw new Exception(); }
        public void b4Drag() { throw new Exception(); }
        public void b4MouseDown() { throw new Exception(); }
        public void cachePosition() { throw new Exception(); }
        public void cachePosition(object iPageX) { throw new Exception(); }
        public void cachePosition(object iPageX, object iPageY) { throw new Exception(); }
        public void setDelta() { throw new Exception(); }
        public void setDelta(int iDeltaX) { throw new Exception(); }
        public void setDelta(int iDeltaX, int iDeltaY) { throw new Exception(); }
        public void setDragElPos() { throw new Exception(); }
        public void setDragElPos(int iPageX) { throw new Exception(); }
        public void setDragElPos(int iPageX, int iPageY) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DD prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool scroll { get; set; }
        [JsProperty(NativeField = true)]
        public static DragDrop superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DDConfig
    {
        // Methods
        public DDConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DDProxy : DD
    {
        // Methods
        public DDProxy() { throw new Exception(); }
        public DDProxy(string id) { throw new Exception(); }
        public DDProxy(string id, string sGroup) { throw new Exception(); }
        public DDProxy(string id, string sGroup, object config) { throw new Exception(); }
        public void createFrame() { throw new Exception(); }
        public void initFrame() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool centerFrame { get; set; }
        [JsProperty(NativeField = true)]
        public static string Ext { get; set; }
        [JsProperty(NativeField = true)]
        public static DDProxy prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool resizeFrame { get; set; }
        [JsProperty(NativeField = true)]
        public static DD superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DDProxyConfig
    {
        // Methods
        public DDProxyConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DDTarget : DragDrop
    {
        // Methods
        public DDTarget() { throw new Exception(); }
        public DDTarget(string id) { throw new Exception(); }
        public DDTarget(string id, string sGroup) { throw new Exception(); }
        public DDTarget(string id, string sGroup, object config) { throw new Exception(); }
        public void addInvalidHandleClass() { throw new Exception(); }
        public void addInvalidHandleId() { throw new Exception(); }
        public void addInvalidHandleType() { throw new Exception(); }
        public void clearConstraints() { throw new Exception(); }
        public void clearTicks() { throw new Exception(); }
        public void endDrag() { throw new Exception(); }
        public void getDragEl() { throw new Exception(); }
        public void isValidHandleChild() { throw new Exception(); }
        public void onDrag() { throw new Exception(); }
        public void onDragDrop() { throw new Exception(); }
        public void onDragEnter() { throw new Exception(); }
        public void onDragOut() { throw new Exception(); }
        public void onDragOver() { throw new Exception(); }
        public void onInvalidDrop() { throw new Exception(); }
        public void onMouseDown() { throw new Exception(); }
        public void onMouseUp() { throw new Exception(); }
        public void removeInvalidHandleClass() { throw new Exception(); }
        public void removeInvalidHandleId() { throw new Exception(); }
        public void removeInvalidHandleType() { throw new Exception(); }
        public void resetConstraints() { throw new Exception(); }
        public void setDragElId() { throw new Exception(); }
        public void setHandleElId() { throw new Exception(); }
        public void setInitPosition() { throw new Exception(); }
        public void setOuterHandleElId() { throw new Exception(); }
        public void setXConstraint() { throw new Exception(); }
        public void setYConstraint() { throw new Exception(); }
        public void startDrag() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DDTarget prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DragDrop superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DDTargetConfig
    {
        // Methods
        public DDTargetConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DragDrop
    {
        // Methods
        public DragDrop() { throw new Exception(); }
        public DragDrop(string id) { throw new Exception(); }
        public DragDrop(string id, string sGroup) { throw new Exception(); }
        public DragDrop(string id, string sGroup, object config) { throw new Exception(); }
        public void addInvalidHandleClass() { throw new Exception(); }
        public void addInvalidHandleClass(string cssClass) { throw new Exception(); }
        public void addInvalidHandleId() { throw new Exception(); }
        public void addInvalidHandleId(string id) { throw new Exception(); }
        public void addInvalidHandleType() { throw new Exception(); }
        public void addInvalidHandleType(string tagName) { throw new Exception(); }
        public void addToGroup() { throw new Exception(); }
        public void addToGroup(object sGroup) { throw new Exception(); }
        public void applyConfig() { throw new Exception(); }
        public void clearConstraints() { throw new Exception(); }
        public void clearTicks() { throw new Exception(); }
        public void constrainTo() { throw new Exception(); }
        public void constrainTo(object constrainTo) { throw new Exception(); }
        public void constrainTo(object constrainTo, double pad) { throw new Exception(); }
        public void constrainTo(object constrainTo, object pad) { throw new Exception(); }
        public void constrainTo(object constrainTo, double pad, bool inContent) { throw new Exception(); }
        public void constrainTo(object constrainTo, object pad, bool inContent) { throw new Exception(); }
        public void endDrag() { throw new Exception(); }
        public void endDrag(HtmlDomEventArgs e) { throw new Exception(); }
        public HtmlElement getDragEl() { throw new Exception(); }
        public HtmlElement getEl() { throw new Exception(); }
        public void init() { throw new Exception(); }
        public void init(object id) { throw new Exception(); }
        public void init(object id, string sGroup) { throw new Exception(); }
        public void init(object id, string sGroup, object config) { throw new Exception(); }
        public void initTarget() { throw new Exception(); }
        public void initTarget(object id) { throw new Exception(); }
        public void initTarget(object id, string sGroup) { throw new Exception(); }
        public void initTarget(object id, string sGroup, object config) { throw new Exception(); }
        public bool isLocked() { throw new Exception(); }
        public bool isValidHandleChild() { throw new Exception(); }
        public bool isValidHandleChild(HtmlElement node) { throw new Exception(); }
        public void lock_() { throw new Exception(); }
        public void onAvailable() { throw new Exception(); }
        public void onDrag() { throw new Exception(); }
        public void onDrag(HtmlDomEventArgs e) { throw new Exception(); }
        public void onDragDrop() { throw new Exception(); }
        public void onDragDrop(HtmlDomEventArgs e) { throw new Exception(); }
        public void onDragDrop(HtmlDomEventArgs e, object id) { throw new Exception(); }
        public void onDragEnter() { throw new Exception(); }
        public void onDragEnter(HtmlDomEventArgs e) { throw new Exception(); }
        public void onDragEnter(HtmlDomEventArgs e, object id) { throw new Exception(); }
        public void onDragOut() { throw new Exception(); }
        public void onDragOut(HtmlDomEventArgs e) { throw new Exception(); }
        public void onDragOut(HtmlDomEventArgs e, object id) { throw new Exception(); }
        public void onDragOver() { throw new Exception(); }
        public void onDragOver(HtmlDomEventArgs e) { throw new Exception(); }
        public void onDragOver(HtmlDomEventArgs e, object id) { throw new Exception(); }
        public void onInvalidDrop() { throw new Exception(); }
        public void onInvalidDrop(HtmlDomEventArgs e) { throw new Exception(); }
        public void onMouseDown() { throw new Exception(); }
        public void onMouseDown(HtmlDomEventArgs e) { throw new Exception(); }
        public void onMouseUp() { throw new Exception(); }
        public void onMouseUp(HtmlDomEventArgs e) { throw new Exception(); }
        public void removeFromGroup() { throw new Exception(); }
        public void removeFromGroup(string sGroup) { throw new Exception(); }
        public void removeInvalidHandleClass() { throw new Exception(); }
        public void removeInvalidHandleClass(string cssClass) { throw new Exception(); }
        public void removeInvalidHandleId() { throw new Exception(); }
        public void removeInvalidHandleId(string id) { throw new Exception(); }
        public void removeInvalidHandleType() { throw new Exception(); }
        public void removeInvalidHandleType(string tagName) { throw new Exception(); }
        public void resetConstraints() { throw new Exception(); }
        public void resetConstraints(bool maintainOffset) { throw new Exception(); }
        public void setDragElId() { throw new Exception(); }
        public void setDragElId(object id) { throw new Exception(); }
        public void setHandleElId() { throw new Exception(); }
        public void setHandleElId(object id) { throw new Exception(); }
        public void setInitPosition() { throw new Exception(); }
        public void setInitPosition(int diffX) { throw new Exception(); }
        public void setInitPosition(int diffX, int diffY) { throw new Exception(); }
        public void setOuterHandleElId() { throw new Exception(); }
        public void setOuterHandleElId(object id) { throw new Exception(); }
        public void setPadding() { throw new Exception(); }
        public void setPadding(int iTop) { throw new Exception(); }
        public void setPadding(int iTop, int iRight) { throw new Exception(); }
        public void setPadding(int iTop, int iRight, int iBot) { throw new Exception(); }
        public void setPadding(int iTop, int iRight, int iBot, int iLeft) { throw new Exception(); }
        public void setXConstraint() { throw new Exception(); }
        public void setXConstraint(int iLeft) { throw new Exception(); }
        public void setXConstraint(int iLeft, int iRight) { throw new Exception(); }
        public void setXConstraint(int iLeft, int iRight, int iTickSize) { throw new Exception(); }
        public void setYConstraint() { throw new Exception(); }
        public void setYConstraint(int iUp) { throw new Exception(); }
        public void setYConstraint(int iUp, int iDown) { throw new Exception(); }
        public void setYConstraint(int iUp, int iDown, int iTickSize) { throw new Exception(); }
        public void startDrag() { throw new Exception(); }
        public void startDrag(int X) { throw new Exception(); }
        public void startDrag(int X, int Y) { throw new Exception(); }
        public string toString() { throw new Exception(); }
        public void unlock() { throw new Exception(); }
        public void unreg() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool available { get; set; }
        [JsProperty(NativeField = true)]
        public object config { get; set; }
        [JsProperty(NativeField = true)]
        public object defaultPadding { get; set; }
        [JsProperty(NativeField = true)]
        public object groups { get; set; }
        [JsProperty(NativeField = true)]
        public bool hasOuterHandles { get; set; }
        [JsProperty(NativeField = true)]
        public string id { get; set; }
        [JsProperty(NativeField = true)]
        public bool ignoreSelf { get; set; }
        [JsProperty(NativeField = true)]
        public Array invalidHandleClasses { get; set; }
        [JsProperty(NativeField = true)]
        public object invalidHandleIds { get; set; }
        [JsProperty(NativeField = true)]
        public object invalidHandleTypes { get; set; }
        [JsProperty(NativeField = true)]
        public bool isTarget { get; set; }
        [JsProperty(NativeField = true)]
        public bool maintainOffset { get; set; }
        [JsProperty(NativeField = true)]
        public bool moveOnly { get; set; }
        [JsProperty(NativeField = true)]
        public int padding { get; set; }
        [JsProperty(NativeField = true)]
        public bool primaryButtonOnly { get; set; }
        [JsProperty(NativeField = true)]
        public static DragDrop prototype { get; set; }
        [JsProperty(NativeField = true)]
        public int xTicks { get; set; }
        [JsProperty(NativeField = true)]
        public int yTicks { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DragDropConfig
    {
        // Methods
        public DragDropConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DragDropMgr
    {
        // Methods
        public DragDropMgr() { throw new Exception(); }
        public static DragDrop getBestMatch() { throw new Exception(); }
        public static DragDrop getBestMatch(DragDrop dds) { throw new Exception(); }
        public static object getCss() { throw new Exception(); }
        public static object getCss(string id) { throw new Exception(); }
        public static DragDrop getDDById() { throw new Exception(); }
        public static DragDrop getDDById(string id) { throw new Exception(); }
        public static object getElement() { throw new Exception(); }
        public static object getElement(string id) { throw new Exception(); }
        public static object getLocation() { throw new Exception(); }
        public static object getLocation(DragDrop oDD) { throw new Exception(); }
        public static DragDrop getRelated() { throw new Exception(); }
        public static DragDrop getRelated(DragDrop p_oDD) { throw new Exception(); }
        public static DragDrop getRelated(DragDrop p_oDD, bool bTargetsOnly) { throw new Exception(); }
        public static bool isDragDrop() { throw new Exception(); }
        public static bool isDragDrop(string id) { throw new Exception(); }
        public static bool isHandle() { throw new Exception(); }
        public static bool isHandle(string id) { throw new Exception(); }
        public static bool isLegalTarget() { throw new Exception(); }
        public static bool isLegalTarget(DragDrop the) { throw new Exception(); }
        public static bool isLegalTarget(DragDrop the, DragDrop the2) { throw new Exception(); }
        public static bool isLocked() { throw new Exception(); }
        public static bool isTypeOfDD() { throw new Exception(); }
        public static bool isTypeOfDD(object the) { throw new Exception(); }
        public static void lock_() { throw new Exception(); }
        public static void refreshCache() { throw new Exception(); }
        public static void refreshCache(object groups) { throw new Exception(); }
        public static void regDragDrop() { throw new Exception(); }
        public static void regDragDrop(DragDrop oDD) { throw new Exception(); }
        public static void regDragDrop(DragDrop oDD, string sGroup) { throw new Exception(); }
        public static void regHandle() { throw new Exception(); }
        public static void regHandle(string sDDId) { throw new Exception(); }
        public static void regHandle(string sDDId, string sHandleId) { throw new Exception(); }
        public static void startDrag() { throw new Exception(); }
        public static void startDrag(object x) { throw new Exception(); }
        public static void startDrag(object x, object y) { throw new Exception(); }
        public static void stopEvent() { throw new Exception(); }
        public static void stopEvent(HtmlDomEventArgs e) { throw new Exception(); }
        public static void unlock() { throw new Exception(); }
        public static bool verifyEl() { throw new Exception(); }
        public static bool verifyEl(HtmlElement el) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static int clickPixelThresh { get; set; }
        [JsProperty(NativeField = true)]
        public static int clickTimeThresh { get; set; }
        [JsProperty(NativeField = true)]
        public static int INTERSECT { get; set; }
        [JsProperty(NativeField = true)]
        public static int mode { get; set; }
        [JsProperty(NativeField = true)]
        public static int POINT { get; set; }
        [JsProperty(NativeField = true)]
        public static bool preventDefault { get; set; }
        [JsProperty(NativeField = true)]
        public static DragDropMgr prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static bool stopPropagation { get; set; }
        [JsProperty(NativeField = true)]
        public static bool useCache { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DragDropMgrConfig
    {
        // Methods
        public DragDropMgrConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DragSource : DDProxy
    {
        // Methods
        public DragSource() { throw new Exception(); }
        public DragSource(DragSourceConfig config) { throw new Exception(); }
        public DragSource(object el) { throw new Exception(); }
        public DragSource(string id) { throw new Exception(); }
        public DragSource(object el, object config) { throw new Exception(); }
        public DragSource(string id, string sGroup) { throw new Exception(); }
        public DragSource(string id, string sGroup, object config) { throw new Exception(); }
        public void afterDragDrop() { throw new Exception(); }
        public void afterDragDrop(DragDrop target) { throw new Exception(); }
        public void afterDragDrop(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public void afterDragDrop(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public void afterDragEnter() { throw new Exception(); }
        public void afterDragEnter(DragDrop target) { throw new Exception(); }
        public void afterDragEnter(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public void afterDragEnter(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public void afterDragOut() { throw new Exception(); }
        public void afterDragOut(DragDrop target) { throw new Exception(); }
        public void afterDragOut(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public void afterDragOut(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public void afterDragOver() { throw new Exception(); }
        public void afterDragOver(DragDrop target) { throw new Exception(); }
        public void afterDragOver(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public void afterDragOver(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public void afterInvalidDrop() { throw new Exception(); }
        public void afterInvalidDrop(HtmlDomEventArgs e) { throw new Exception(); }
        public void afterInvalidDrop(object target) { throw new Exception(); }
        public void afterInvalidDrop(HtmlDomEventArgs e, string id) { throw new Exception(); }
        public void afterInvalidDrop(object target, HtmlDomEventArgs e) { throw new Exception(); }
        public void afterInvalidDrop(object target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public bool beforeDragDrop() { throw new Exception(); }
        public bool beforeDragDrop(DragDrop target) { throw new Exception(); }
        public bool beforeDragDrop(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public bool beforeDragDrop(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public bool beforeDragEnter() { throw new Exception(); }
        public bool beforeDragEnter(DragDrop target) { throw new Exception(); }
        public bool beforeDragEnter(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public bool beforeDragEnter(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public bool beforeDragOut() { throw new Exception(); }
        public bool beforeDragOut(DragDrop target) { throw new Exception(); }
        public bool beforeDragOut(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public bool beforeDragOut(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public bool beforeDragOver() { throw new Exception(); }
        public bool beforeDragOver(DragDrop target) { throw new Exception(); }
        public bool beforeDragOver(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public bool beforeDragOver(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public bool beforeInvalidDrop() { throw new Exception(); }
        public bool beforeInvalidDrop(DragDrop target) { throw new Exception(); }
        public bool beforeInvalidDrop(DragDrop target, HtmlDomEventArgs e) { throw new Exception(); }
        public bool beforeInvalidDrop(DragDrop target, HtmlDomEventArgs e, string id) { throw new Exception(); }
        public object getDragData() { throw new Exception(); }
        public StatusProxy getProxy() { throw new Exception(); }
        public void hideProxy() { throw new Exception(); }
        public bool onBeforeDrag() { throw new Exception(); }
        public bool onBeforeDrag(object data) { throw new Exception(); }
        public bool onBeforeDrag(object data, HtmlDomEventArgs e) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string ddGroup { get; set; }
        [JsProperty(NativeField = true)]
        public string dropAllowed { get; set; }
        [JsProperty(NativeField = true)]
        public string dropNotAllowed { get; set; }
        [JsProperty(NativeField = true)]
        public object onStartDrag { get; set; }
        [JsProperty(NativeField = true)]
        public static DragSource prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DDProxy superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DragSourceConfig
    {
        // Methods
        public DragSourceConfig() { throw new Exception(); }

        // Properties
        public string ddGroup { get; set; }
        public string dropAllowed { get; set; }
        public string dropNotAllowed { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DragTracker : Observable
    {
        // Methods
        public DragTracker() { throw new Exception(); }
        public DragTracker(DragTrackerConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool active { get; set; }
        [JsProperty(NativeField = true)]
        public object autoStart { get; set; }
        [JsProperty(NativeField = true)]
        public static DragTracker prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double tolerance { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DragTrackerConfig
    {
        // Methods
        public DragTrackerConfig() { throw new Exception(); }

        // Properties
        public bool active { get; set; }
        public object autoStart { get; set; }
        public double tolerance { get; set; }
    }

    public delegate void DragTrackerDragDelegate(object objthis, object e);

    public delegate void DragTrackerDragendDelegate(object objthis, object e);

    public delegate void DragTrackerDragstartDelegate(object objthis, object startXY);

    public class DragTrackerEvents
    {
        // Methods
        public DragTrackerEvents() { throw new Exception(); }

        // Properties
        public static string drag { get { throw new Exception(); } }
        public static string dragend { get { throw new Exception(); } }
        public static string dragstart { get { throw new Exception(); } }
        public static string mousedown { get { throw new Exception(); } }
        public static string mousemove { get { throw new Exception(); } }
        public static string mouseup { get { throw new Exception(); } }
    }

    public delegate void DragTrackerMousedownDelegate(object objthis, object e);

    public delegate void DragTrackerMousemoveDelegate(object objthis, object e);

    public delegate void DragTrackerMouseupDelegate(object objthis, object e);

    [JsType(JsMode.Prototype, Export = false)]
    public class DragZone : DragSource
    {
        // Methods
        public DragZone() { throw new Exception(); }
        public DragZone(DragZoneConfig config) { throw new Exception(); }
        public DragZone(object el) { throw new Exception(); }
        public DragZone(string id) { throw new Exception(); }
        public DragZone(object el, object config) { throw new Exception(); }
        public DragZone(string id, string sGroup) { throw new Exception(); }
        public DragZone(string id, string sGroup, object config) { throw new Exception(); }
        public void afterRepair() { throw new Exception(); }
        public object getDragData() { throw new Exception(); }
        public object getDragData(EventObject e) { throw new Exception(); }
        public Array getRepairXY() { throw new Exception(); }
        public Array getRepairXY(EventObject e) { throw new Exception(); }
        public bool onInitDrag() { throw new Exception(); }
        public bool onInitDrag(double x) { throw new Exception(); }
        public bool onInitDrag(double x, double y) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool containerScroll { get; set; }
        [JsProperty(NativeField = true)]
        public object dragData { get; set; }
        [JsProperty(NativeField = true)]
        public string hlColor { get; set; }
        [JsProperty(NativeField = true)]
        public static DragZone prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DragSource superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DragZoneConfig
    {
        // Methods
        public DragZoneConfig() { throw new Exception(); }

        // Properties
        public bool containerScroll { get; set; }
        public string ddGroup { get; set; }
        public string dropAllowed { get; set; }
        public string dropNotAllowed { get; set; }
        public string hlColor { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DropTarget : DDTarget
    {
        // Methods
        public DropTarget() { throw new Exception(); }
        public DropTarget(DropTargetConfig config) { throw new Exception(); }
        public DropTarget(object el) { throw new Exception(); }
        public DropTarget(string id) { throw new Exception(); }
        public DropTarget(object el, object config) { throw new Exception(); }
        public DropTarget(string id, string sGroup) { throw new Exception(); }
        public DropTarget(string id, string sGroup, object config) { throw new Exception(); }
        public bool notifyDrop() { throw new Exception(); }
        public bool notifyDrop(DragSource source) { throw new Exception(); }
        public bool notifyDrop(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public bool notifyDrop(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public string notifyEnter() { throw new Exception(); }
        public string notifyEnter(DragSource source) { throw new Exception(); }
        public string notifyEnter(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public string notifyEnter(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public void notifyOut() { throw new Exception(); }
        public void notifyOut(DragSource source) { throw new Exception(); }
        public void notifyOut(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public void notifyOut(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public string notifyOver() { throw new Exception(); }
        public string notifyOver(DragSource source) { throw new Exception(); }
        public string notifyOver(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public string notifyOver(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string ddGroup { get; set; }
        [JsProperty(NativeField = true)]
        public string dropAllowed { get; set; }
        [JsProperty(NativeField = true)]
        public string dropNotAllowed { get; set; }
        [JsProperty(NativeField = true)]
        public string overClass { get; set; }
        [JsProperty(NativeField = true)]
        public static DropTarget prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DDTarget superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DropTargetConfig
    {
        // Methods
        public DropTargetConfig() { throw new Exception(); }

        // Properties
        public string ddGroup { get; set; }
        public string dropAllowed { get; set; }
        public string dropNotAllowed { get; set; }
        public string overClass { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DropZone : DropTarget
    {
        // Methods
        public DropZone() { throw new Exception(); }
        public DropZone(DropZoneConfig config) { throw new Exception(); }
        public DropZone(object el) { throw new Exception(); }
        public DropZone(string id) { throw new Exception(); }
        public DropZone(object el, object config) { throw new Exception(); }
        public DropZone(string id, string sGroup) { throw new Exception(); }
        public DropZone(string id, string sGroup, object config) { throw new Exception(); }
        public object getTargetFromEvent() { throw new Exception(); }
        public object getTargetFromEvent(HtmlDomEventArgs e) { throw new Exception(); }
        public bool notifyDrop() { throw new Exception(); }
        public bool notifyDrop(DragSource source) { throw new Exception(); }
        public bool notifyDrop(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public bool notifyDrop(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public string notifyEnter() { throw new Exception(); }
        public string notifyEnter(DragSource source) { throw new Exception(); }
        public string notifyEnter(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public string notifyEnter(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public void notifyOut() { throw new Exception(); }
        public void notifyOut(DragSource source) { throw new Exception(); }
        public void notifyOut(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public void notifyOut(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public string notifyOver() { throw new Exception(); }
        public string notifyOver(DragSource source) { throw new Exception(); }
        public string notifyOver(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public string notifyOver(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public bool onContainerDrop() { throw new Exception(); }
        public bool onContainerDrop(DragSource source) { throw new Exception(); }
        public bool onContainerDrop(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public bool onContainerDrop(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public string onContainerOver() { throw new Exception(); }
        public string onContainerOver(DragSource source) { throw new Exception(); }
        public string onContainerOver(DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public string onContainerOver(DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public bool onNodeDrop() { throw new Exception(); }
        public bool onNodeDrop(object nodeData) { throw new Exception(); }
        public bool onNodeDrop(object nodeData, DragSource source) { throw new Exception(); }
        public bool onNodeDrop(object nodeData, DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public bool onNodeDrop(object nodeData, DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public void onNodeEnter() { throw new Exception(); }
        public void onNodeEnter(object nodeData) { throw new Exception(); }
        public void onNodeEnter(object nodeData, DragSource source) { throw new Exception(); }
        public void onNodeEnter(object nodeData, DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public void onNodeEnter(object nodeData, DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public void onNodeOut() { throw new Exception(); }
        public void onNodeOut(object nodeData) { throw new Exception(); }
        public void onNodeOut(object nodeData, DragSource source) { throw new Exception(); }
        public void onNodeOut(object nodeData, DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public void onNodeOut(object nodeData, DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }
        public string onNodeOver() { throw new Exception(); }
        public string onNodeOver(object nodeData) { throw new Exception(); }
        public string onNodeOver(object nodeData, DragSource source) { throw new Exception(); }
        public string onNodeOver(object nodeData, DragSource source, HtmlDomEventArgs e) { throw new Exception(); }
        public string onNodeOver(object nodeData, DragSource source, HtmlDomEventArgs e, object data) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DropZone prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DropTarget superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DropZoneConfig
    {
        // Methods
        public DropZoneConfig() { throw new Exception(); }

        // Properties
        public string ddGroup { get; set; }
        public string dropAllowed { get; set; }
        public string dropNotAllowed { get; set; }
        public string overClass { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class PanelProxy
    {
        // Methods
        public PanelProxy() { throw new Exception(); }
        public PanelProxy(PanelProxyConfig config) { throw new Exception(); }
        public PanelProxy(object panel) { throw new Exception(); }
        public PanelProxy(object panel, object config) { throw new Exception(); }
        public Element getEl() { throw new Exception(); }
        public Element getGhost() { throw new Exception(); }
        public Element getProxy() { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public void moveProxy() { throw new Exception(); }
        public void moveProxy(HtmlElement parentNode) { throw new Exception(); }
        public void moveProxy(HtmlElement parentNode, HtmlElement before) { throw new Exception(); }
        public void show() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool insertProxy { get; set; }
        [JsProperty(NativeField = true)]
        public static PanelProxy prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PanelProxyConfig
    {
        // Methods
        public PanelProxyConfig() { throw new Exception(); }

        // Properties
        public bool insertProxy { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Registry
    {
        // Methods
        public Registry() { throw new Exception(); }
        public static object getHandle() { throw new Exception(); }
        public static object getHandle(HtmlElement id) { throw new Exception(); }
        public static object getHandle(string id) { throw new Exception(); }
        public static object getHandleFromEvent() { throw new Exception(); }
        public static object getHandleFromEvent(HtmlDomEventArgs e) { throw new Exception(); }
        public static object getTarget() { throw new Exception(); }
        public static object getTarget(HtmlElement id) { throw new Exception(); }
        public static object getTarget(string id) { throw new Exception(); }
        public static object getTargetFromEvent() { throw new Exception(); }
        public static object getTargetFromEvent(HtmlDomEventArgs e) { throw new Exception(); }
        public static void register() { throw new Exception(); }
        public static void register(HtmlElement element) { throw new Exception(); }
        public static void register(string element) { throw new Exception(); }
        public static void register(HtmlElement element, object data) { throw new Exception(); }
        public static void register(string element, object data) { throw new Exception(); }
        public static void unregister() { throw new Exception(); }
        public static void unregister(HtmlElement element) { throw new Exception(); }
        public static void unregister(string element) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Registry prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RegistryConfig
    {
        // Methods
        public RegistryConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ScrollManager
    {
        // Methods
        public ScrollManager() { throw new Exception(); }
        public static void refreshCache() { throw new Exception(); }
        public static void register() { throw new Exception(); }
        public static void register(Array el) { throw new Exception(); }
        public static void register(object el) { throw new Exception(); }
        public static void unregister() { throw new Exception(); }
        public static void unregister(Array el) { throw new Exception(); }
        public static void unregister(object el) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static bool animate { get; set; }
        [JsProperty(NativeField = true)]
        public static double animDuration { get; set; }
        [JsProperty(NativeField = true)]
        public static double frequency { get; set; }
        [JsProperty(NativeField = true)]
        public static double hthresh { get; set; }
        [JsProperty(NativeField = true)]
        public static double increment { get; set; }
        [JsProperty(NativeField = true)]
        public static ScrollManager prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static double vthresh { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ScrollManagerConfig
    {
        // Methods
        public ScrollManagerConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class StatusProxy
    {
        // Methods
        public StatusProxy() { throw new Exception(); }
        public StatusProxy(StatusProxyConfig config) { throw new Exception(); }
        public StatusProxy(object config) { throw new Exception(); }
        public Layer getEl() { throw new Exception(); }
        public Element getGhost() { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public void hide(bool clear) { throw new Exception(); }
        public void repair() { throw new Exception(); }
        public void repair(Array xy) { throw new Exception(); }
        public void repair(Array xy, JsAction callback) { throw new Exception(); }
        public void repair(Array xy, JsAction callback, object scope) { throw new Exception(); }
        public void reset() { throw new Exception(); }
        public void reset(bool clearGhost) { throw new Exception(); }
        public void setStatus() { throw new Exception(); }
        public void setStatus(string cssClass) { throw new Exception(); }
        public void show() { throw new Exception(); }
        public void stop() { throw new Exception(); }
        public void sync() { throw new Exception(); }
        public void update() { throw new Exception(); }
        public void update(HtmlElement html) { throw new Exception(); }
        public void update(string html) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string dropAllowed { get; set; }
        [JsProperty(NativeField = true)]
        public string dropNotAllowed { get; set; }
        [JsProperty(NativeField = true)]
        public static StatusProxy prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class StatusProxyConfig
    {
        // Methods
        public StatusProxyConfig() { throw new Exception(); }

        // Properties
        public string dropAllowed { get; set; }
        public string dropNotAllowed { get; set; }
    }
}


namespace Ext.direct
{
    [JsType(JsMode.Prototype, Export = false)]
    public class JsonProvider : Provider
    {
        // Methods
        public JsonProvider() { throw new Exception(); }
        public JsonProvider(JsonProviderConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static JsonProvider prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Provider superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class JsonProviderConfig
    {
        // Methods
        public JsonProviderConfig() { throw new Exception(); }

        // Properties
        public string id { get; set; }
        public double priority { get; set; }
        public string type { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class PollingProvider : JsonProvider
    {
        // Methods
        public PollingProvider() { throw new Exception(); }
        public PollingProvider(PollingProviderConfig config) { throw new Exception(); }
        public void connect() { throw new Exception(); }
        public void disconnect() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object baseParams { get; set; }
        [JsProperty(NativeField = true)]
        public double interval { get; set; }
        [JsProperty(NativeField = true)]
        public double priority { get; set; }
        [JsProperty(NativeField = true)]
        public static PollingProvider prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static JsonProvider superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object url { get; set; }
    }

    public delegate void PollingProviderBeforepollDelegate(PollingProvider prm);

    [JsType(JsMode.Json)]
    public class PollingProviderConfig
    {
        // Methods
        public PollingProviderConfig() { throw new Exception(); }

        // Properties
        public object baseParams { get; set; }
        public string id { get; set; }
        public double interval { get; set; }
        public double priority { get; set; }
        public string type { get; set; }
        public object url { get; set; }
    }

    public class PollingProviderEvents
    {
        // Methods
        public PollingProviderEvents() { throw new Exception(); }

        // Properties
        public static string beforepoll { get { throw new Exception(); } }
        public static string poll { get { throw new Exception(); } }
    }

    public delegate void PollingProviderPollDelegate(PollingProvider prm);

    [JsType(JsMode.Prototype, Export = false)]
    public class Provider : Observable
    {
        // Methods
        public Provider() { throw new Exception(); }
        public Provider(ProviderConfig config) { throw new Exception(); }
        public void isConnected() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object connect { get; set; }
        [JsProperty(NativeField = true)]
        public object disconnect { get; set; }
        [JsProperty(NativeField = true)]
        public string id { get; set; }
        [JsProperty(NativeField = true)]
        public double priority { get; set; }
        [JsProperty(NativeField = true)]
        public static Provider prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string type { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ProviderConfig
    {
        // Methods
        public ProviderConfig() { throw new Exception(); }

        // Properties
        public string id { get; set; }
        public double priority { get; set; }
        public string type { get; set; }
    }

    public delegate void ProviderConnectDelegate(Provider provider);

    public delegate void ProviderDataDelegate(Provider provider, EventObject e);

    public delegate void ProviderDisconnectDelegate(Provider provider);

    public class ProviderEvents
    {
        // Methods
        public ProviderEvents() { throw new Exception(); }

        // Properties
        public static string connect { get { throw new Exception(); } }
        public static string data { get { throw new Exception(); } }
        public static string disconnect { get { throw new Exception(); } }
        public static string exception { get { throw new Exception(); } }
    }

    public delegate void ProviderExceptionDelegate();

    [JsType(JsMode.Prototype, Export = false)]
    public class RemotingProvider : JsonProvider
    {
        // Methods
        public RemotingProvider() { throw new Exception(); }
        public RemotingProvider(RemotingProviderConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object actions { get; set; }
        [JsProperty(NativeField = true)]
        public object enableBuffer { get; set; }
        [JsProperty(NativeField = true)]
        public string enableUrlEncode { get; set; }
        [JsProperty(NativeField = true)]
        public double maxRetries { get; set; }
        [JsProperty(NativeField = true)]
        public object namespace_ { get; set; }
        [JsProperty(NativeField = true)]
        public static RemotingProvider prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static JsonProvider superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double timeout { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
    }

    public delegate void RemotingProviderBeforecallDelegate(RemotingProvider provider, Direct.Transaction transaction);

    public delegate void RemotingProviderCallDelegate(RemotingProvider provider, Direct.Transaction transaction);

    [JsType(JsMode.Json)]
    public class RemotingProviderConfig
    {
        // Methods
        public RemotingProviderConfig() { throw new Exception(); }

        // Properties
        public object actions { get; set; }
        public object enableBuffer { get; set; }
        public string enableUrlEncode { get; set; }
        public string id { get; set; }
        public double maxRetries { get; set; }
        public object @namespace { get; set; }
        public double priority { get; set; }
        public double timeout { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class RemotingProviderEvents
    {
        // Methods
        public RemotingProviderEvents() { throw new Exception(); }

        // Properties
        public static string beforecall { get { throw new Exception(); } }
        public static string call { get { throw new Exception(); } }
    }
}









namespace Ext.form
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Action
    {
        // Methods
        public Action() { throw new Exception(); }
        public Action(ActionConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static string CLIENT_INVALID { get; set; }
        [JsProperty(NativeField = true)]
        public static string CONNECT_FAILURE { get; set; }
        [JsProperty(NativeField = true)]
        public Action failure { get; set; }
        [JsProperty(NativeField = true)]
        public string failureType { get; set; }
        [JsProperty(NativeField = true)]
        public static string LOAD_FAILURE { get; set; }
        [JsProperty(NativeField = true)]
        public string method { get; set; }
        [JsProperty(NativeField = true)]
        public object params_ { get; set; }
        [JsProperty(NativeField = true)]
        public static Action prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool reset { get; set; }
        [JsProperty(NativeField = true)]
        public object response { get; set; }
        [JsProperty(NativeField = true)]
        public object result { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public static string SERVER_INVALID { get; set; }
        [JsProperty(NativeField = true)]
        public Action success { get; set; }
        [JsProperty(NativeField = true)]
        public double timeout { get; set; }
        [JsProperty(NativeField = true)]
        public string type { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
        [JsProperty(NativeField = true)]
        public string waitMsg { get; set; }
        [JsProperty(NativeField = true)]
        public string waitTitle { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class DirectLoad : Action.Load
        {
            // Methods
            public DirectLoad() { throw new Exception(); }
            public DirectLoad(Action.DirectLoadConfig config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Action.DirectLoad prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Action.Load superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class DirectLoadConfig
        {
            // Methods
            public DirectLoadConfig() { throw new Exception(); }

            // Properties
            public Action failure { get; set; }
            public string method { get; set; }
            public object @params { get; set; }
            public bool reset { get; set; }
            public object scope { get; set; }
            public Action success { get; set; }
            public double timeout { get; set; }
            public string url { get; set; }
            public string waitMsg { get; set; }
            public string waitTitle { get; set; }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class DirectSubmit : Action.Submit
        {
            // Methods
            public DirectSubmit() { throw new Exception(); }
            public DirectSubmit(Action.DirectSubmitConfig config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Action.DirectSubmit prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Action.Submit superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class DirectSubmitConfig
        {
            // Methods
            public DirectSubmitConfig() { throw new Exception(); }

            // Properties
            public bool clientValidation { get; set; }
            public DataReader errorReader { get; set; }
            public Action failure { get; set; }
            public string method { get; set; }
            public object @params { get; set; }
            public bool reset { get; set; }
            public object scope { get; set; }
            public Action success { get; set; }
            public double timeout { get; set; }
            public string url { get; set; }
            public string waitMsg { get; set; }
            public string waitTitle { get; set; }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class Load : Action
        {
            // Methods
            public Load() { throw new Exception(); }
            public Load(Action.LoadConfig config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public static Action.Load prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Action superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class LoadConfig
        {
            // Methods
            public LoadConfig() { throw new Exception(); }

            // Properties
            public Action failure { get; set; }
            public string method { get; set; }
            public object @params { get; set; }
            public bool reset { get; set; }
            public object scope { get; set; }
            public Action success { get; set; }
            public double timeout { get; set; }
            public string url { get; set; }
            public string waitMsg { get; set; }
            public string waitTitle { get; set; }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class Submit : Action
        {
            // Methods
            public Submit() { throw new Exception(); }
            public Submit(Action.SubmitConfig config) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public bool clientValidation { get; set; }
            [JsProperty(NativeField = true)]
            public DataReader errorReader { get; set; }
            [JsProperty(NativeField = true)]
            public static Action.Submit prototype { get; set; }
            [JsProperty(NativeField = true)]
            public static Action superclass { get; set; }
        }

        [JsType(JsMode.Json)]
        public class SubmitConfig
        {
            // Methods
            public SubmitConfig() { throw new Exception(); }

            // Properties
            public bool clientValidation { get; set; }
            public DataReader errorReader { get; set; }
            public Action failure { get; set; }
            public string method { get; set; }
            public object @params { get; set; }
            public bool reset { get; set; }
            public object scope { get; set; }
            public Action success { get; set; }
            public double timeout { get; set; }
            public string url { get; set; }
            public string waitMsg { get; set; }
            public string waitTitle { get; set; }
        }
    }

    [JsType(JsMode.Json)]
    public class ActionConfig
    {
        // Methods
        public ActionConfig() { throw new Exception(); }

        // Properties
        public Action failure { get; set; }
        public string method { get; set; }
        public object @params { get; set; }
        public bool reset { get; set; }
        public object scope { get; set; }
        public Action success { get; set; }
        public double timeout { get; set; }
        public string url { get; set; }
        public string waitMsg { get; set; }
        public string waitTitle { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class BasicForm : Observable
    {
        // Methods
        public BasicForm() { throw new Exception(); }
        public BasicForm(BasicFormConfig config) { throw new Exception(); }
        public BasicForm(object el) { throw new Exception(); }
        public BasicForm(object el, object config) { throw new Exception(); }
        public BasicForm add() { throw new Exception(); }
        public BasicForm add(params Field[] args) { throw new Exception(); }
        public BasicForm applyIfToFields() { throw new Exception(); }
        public BasicForm applyIfToFields(object values) { throw new Exception(); }
        public BasicForm applyToFields() { throw new Exception(); }
        public BasicForm applyToFields(object values) { throw new Exception(); }
        public BasicForm clearInvalid() { throw new Exception(); }
        public BasicForm doAction() { throw new Exception(); }
        public BasicForm doAction(object actionName) { throw new Exception(); }
        public BasicForm doAction(string actionName) { throw new Exception(); }
        public BasicForm doAction(object actionName, object options) { throw new Exception(); }
        public BasicForm doAction(string actionName, object options) { throw new Exception(); }
        public Field findField() { throw new Exception(); }
        public Field findField(string id) { throw new Exception(); }
        public Element getEl() { throw new Exception(); }
        public object getFieldValues() { throw new Exception(); }
        public object getFieldValues(bool dirtyOnly) { throw new Exception(); }
        public object getValues() { throw new Exception(); }
        public object getValues(bool asString) { throw new Exception(); }
        public bool isDirty() { throw new Exception(); }
        public bool isValid() { throw new Exception(); }
        public void items() { throw new Exception(); }
        public BasicForm load() { throw new Exception(); }
        public BasicForm load(object options) { throw new Exception(); }
        public BasicForm loadRecord() { throw new Exception(); }
        public BasicForm loadRecord(Record record) { throw new Exception(); }
        public BasicForm markInvalid() { throw new Exception(); }
        public BasicForm markInvalid(Array errors) { throw new Exception(); }
        public BasicForm markInvalid(object errors) { throw new Exception(); }
        public BasicForm remove() { throw new Exception(); }
        public BasicForm remove(Field field) { throw new Exception(); }
        public BasicForm render() { throw new Exception(); }
        public BasicForm reset() { throw new Exception(); }
        public BasicForm setValues() { throw new Exception(); }
        public BasicForm setValues(Array values) { throw new Exception(); }
        public BasicForm setValues(object values) { throw new Exception(); }
        public BasicForm submit() { throw new Exception(); }
        public BasicForm submit(object options) { throw new Exception(); }
        public BasicForm updateRecord() { throw new Exception(); }
        public BasicForm updateRecord(Record record) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object api { get; set; }
        [JsProperty(NativeField = true)]
        public object baseParams { get; set; }
        [JsProperty(NativeField = true)]
        public DataReader errorReader { get; set; }
        [JsProperty(NativeField = true)]
        public bool fileUpload { get; set; }
        [JsProperty(NativeField = true)]
        public string method { get; set; }
        [JsProperty(NativeField = true)]
        public object paramOrder { get; set; }
        [JsProperty(NativeField = true)]
        public bool paramsAsHash { get; set; }
        [JsProperty(NativeField = true)]
        public static BasicForm prototype { get; set; }
        [JsProperty(NativeField = true)]
        public DataReader reader { get; set; }
        [JsProperty(NativeField = true)]
        public bool standardSubmit { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double timeout { get; set; }
        [JsProperty(NativeField = true)]
        public bool trackResetOnLoad { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
        [JsProperty(NativeField = true)]
        public object waitMsgTarget { get; set; }
        [JsProperty(NativeField = true)]
        public string waitTitle { get; set; }
    }

    public delegate void BasicFormActioncompleteDelegate(BasicForm objthis, Action action);

    public delegate void BasicFormActionfailedDelegate(BasicForm objthis, Action action);

    public delegate void BasicFormBeforeactionDelegate(BasicForm objthis, Action action);

    [JsType(JsMode.Json)]
    public class BasicFormConfig
    {
        // Methods
        public BasicFormConfig() { throw new Exception(); }

        // Properties
        public object api { get; set; }
        public object baseParams { get; set; }
        public DataReader errorReader { get; set; }
        public bool fileUpload { get; set; }
        public string method { get; set; }
        public object paramOrder { get; set; }
        public bool paramsAsHash { get; set; }
        public DataReader reader { get; set; }
        public bool standardSubmit { get; set; }
        public double timeout { get; set; }
        public bool trackResetOnLoad { get; set; }
        public string url { get; set; }
        public string waitTitle { get; set; }
    }

    public class BasicFormEvents
    {
        // Methods
        public BasicFormEvents() { throw new Exception(); }

        // Properties
        public static string actioncomplete { get { throw new Exception(); } }
        public static string actionfailed { get { throw new Exception(); } }
        public static string beforeaction { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Checkbox : Field
    {
        // Methods
        public Checkbox() { throw new Exception(); }
        public Checkbox(Element config) { throw new Exception(); }
        public Checkbox(CheckboxConfig config) { throw new Exception(); }
        public Checkbox(object config) { throw new Exception(); }
        public Checkbox(string config) { throw new Exception(); }
        public void clearInvalid() { throw new Exception(); }
        public bool getValue() { throw new Exception(); }
        public void markInvalid() { throw new Exception(); }
        public Field setValue() { throw new Exception(); }
        public Field setValue(bool chckd) { throw new Exception(); }
        public Field setValue(string chckd) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object autoCreate { get; set; }
        [JsProperty(NativeField = true)]
        public string boxLabel { get; set; }
        [JsProperty(NativeField = true)]
        public bool checked_ { get; set; }
        [JsProperty(NativeField = true)]
        public string fieldClass { get; set; }
        [JsProperty(NativeField = true)]
        public string focusClass { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction handler { get; set; }
        [JsProperty(NativeField = true)]
        public string inputValue { get; set; }
        [JsProperty(NativeField = true)]
        public static Checkbox prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public static Field superclass { get; set; }
    }

    public delegate void CheckboxCheckDelegate(Checkbox objthis, bool chckd);

    [JsType(JsMode.Json)]
    public class CheckboxConfig
    {
        // Methods
        public CheckboxConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string boxLabel { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public bool @checked { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public JsAction handler { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string inputValue { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public object value { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class CheckboxEvents
    {
        // Methods
        public CheckboxEvents() { throw new Exception(); }

        // Properties
        public static string check { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CheckboxGroup : Field
    {
        // Methods
        public CheckboxGroup() { throw new Exception(); }
        public CheckboxGroup(Element config) { throw new Exception(); }
        public CheckboxGroup(CheckboxGroupConfig config) { throw new Exception(); }
        public CheckboxGroup(object config) { throw new Exception(); }
        public CheckboxGroup(string config) { throw new Exception(); }
        public void getRawValue() { throw new Exception(); }
        public Array getValue() { throw new Exception(); }
        public void setRawValue() { throw new Exception(); }
        public CheckboxGroup setValue() { throw new Exception(); }
        public CheckboxGroup setValue(object id) { throw new Exception(); }
        public CheckboxGroup setValue(object id, bool value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowBlank { get; set; }
        [JsProperty(NativeField = true)]
        public string blankText { get; set; }
        [JsProperty(NativeField = true)]
        public object columns { get; set; }
        [JsProperty(NativeField = true)]
        public Array items { get; set; }
        [JsProperty(NativeField = true)]
        public static CheckboxGroup prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Field superclass { get; set; }
        [JsProperty(NativeField = true)]
        public bool vertical { get; set; }
    }

    public delegate void CheckboxGroupChangeDelegate(CheckboxGroup objthis, Array chckd);

    [JsType(JsMode.Json)]
    public class CheckboxGroupConfig
    {
        // Methods
        public CheckboxGroupConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public object columns { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public Array items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public object value { get; set; }
        public bool vertical { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class CheckboxGroupEvents
    {
        // Methods
        public CheckboxGroupEvents() { throw new Exception(); }

        // Properties
        public static string change { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ComboBox : TriggerField
    {
        // Methods
        public ComboBox() { throw new Exception(); }
        public ComboBox(Element config) { throw new Exception(); }
        public ComboBox(ComboBoxConfig config) { throw new Exception(); }
        public ComboBox(object config) { throw new Exception(); }
        public ComboBox(string config) { throw new Exception(); }
        public void autoSize() { throw new Exception(); }
        public void clearValue() { throw new Exception(); }
        public void collapse() { throw new Exception(); }
        public void doQuery() { throw new Exception(); }
        public void doQuery(string query) { throw new Exception(); }
        public void doQuery(string query, bool forceAll) { throw new Exception(); }
        public void expand() { throw new Exception(); }
        public void getListParent() { throw new Exception(); }
        public Store getStore() { throw new Exception(); }
        public string getValue() { throw new Exception(); }
        public void isExpanded() { throw new Exception(); }
        public void onTriggerClick() { throw new Exception(); }
        public void select() { throw new Exception(); }
        public void select(double index) { throw new Exception(); }
        public void select(double index, bool scrollIntoView) { throw new Exception(); }
        public bool selectByValue() { throw new Exception(); }
        public bool selectByValue(string value) { throw new Exception(); }
        public bool selectByValue(string value, bool scrollIntoView) { throw new Exception(); }
        public Field setValue() { throw new Exception(); }
        public Field setValue(string value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string allQuery { get; set; }
        [JsProperty(NativeField = true)]
        public object autoCreate { get; set; }
        [JsProperty(NativeField = true)]
        public bool clearFilterOnReset { get; set; }
        [JsProperty(NativeField = true)]
        public string displayField { get; set; }
        [JsProperty(NativeField = true)]
        public bool forceSelection { get; set; }
        [JsProperty(NativeField = true)]
        public double handleHeight { get; set; }
        [JsProperty(NativeField = true)]
        public string hiddenId { get; set; }
        [JsProperty(NativeField = true)]
        public string hiddenName { get; set; }
        [JsProperty(NativeField = true)]
        public string hiddenValue { get; set; }
        [JsProperty(NativeField = true)]
        public string itemSelector { get; set; }
        [JsProperty(NativeField = true)]
        public string lastQuery { get; set; }
        [JsProperty(NativeField = true)]
        public bool lazyInit { get; set; }
        [JsProperty(NativeField = true)]
        public bool lazyRender { get; set; }
        [JsProperty(NativeField = true)]
        public string listAlign { get; set; }
        [JsProperty(NativeField = true)]
        public string listClass { get; set; }
        [JsProperty(NativeField = true)]
        public string listEmptyText { get; set; }
        [JsProperty(NativeField = true)]
        public double listWidth { get; set; }
        [JsProperty(NativeField = true)]
        public string loadingText { get; set; }
        [JsProperty(NativeField = true)]
        public double maxHeight { get; set; }
        [JsProperty(NativeField = true)]
        public double minChars { get; set; }
        [JsProperty(NativeField = true)]
        public double minHeight { get; set; }
        [JsProperty(NativeField = true)]
        public double minListWidth { get; set; }
        [JsProperty(NativeField = true)]
        public string mode { get; set; }
        [JsProperty(NativeField = true)]
        public double pageSize { get; set; }
        [JsProperty(NativeField = true)]
        public static ComboBox prototype { get; set; }
        [JsProperty(NativeField = true)]
        public double queryDelay { get; set; }
        [JsProperty(NativeField = true)]
        public string queryParam { get; set; }
        [JsProperty(NativeField = true)]
        public bool resizable { get; set; }
        [JsProperty(NativeField = true)]
        public string selectedClass { get; set; }
        [JsProperty(NativeField = true)]
        public bool selectOnFocus { get; set; }
        [JsProperty(NativeField = true)]
        public object shadow { get; set; }
        [JsProperty(NativeField = true)]
        public object store { get; set; }
        [JsProperty(NativeField = true)]
        public bool submitValue { get; set; }
        [JsProperty(NativeField = true)]
        public static TriggerField superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string title { get; set; }
        [JsProperty(NativeField = true)]
        public object tpl { get; set; }
        [JsProperty(NativeField = true)]
        public object transform { get; set; }
        [JsProperty(NativeField = true)]
        public string triggerAction { get; set; }
        [JsProperty(NativeField = true)]
        public string triggerClass { get; set; }
        [JsProperty(NativeField = true)]
        public bool typeAhead { get; set; }
        [JsProperty(NativeField = true)]
        public double typeAheadDelay { get; set; }
        [JsProperty(NativeField = true)]
        public string valueField { get; set; }
        [JsProperty(NativeField = true)]
        public string valueNotFoundText { get; set; }
        [JsProperty(NativeField = true)]
        public DataView view { get; set; }
    }

    public delegate void ComboBoxBeforequeryDelegate(object queryEvent);

    public delegate void ComboBoxBeforeselectDelegate(ComboBox combo, Record record, double index);

    public delegate void ComboBoxCollapseDelegate(ComboBox combo);

    [JsType(JsMode.Json)]
    public class ComboBoxConfig
    {
        // Methods
        public ComboBoxConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string allQuery { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public bool clearFilterOnReset { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableKeyFilter { get; set; }
        public string displayField { get; set; }
        public bool editable { get; set; }
        public string emptyClass { get; set; }
        public string emptyText { get; set; }
        public bool enableKeyEvents { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public bool forceSelection { get; set; }
        public bool grow { get; set; }
        public double growMax { get; set; }
        public double growMin { get; set; }
        public double handleHeight { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public string hiddenId { get; set; }
        public string hiddenName { get; set; }
        public string hiddenValue { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public bool hideTrigger { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string itemSelector { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public bool lazyInit { get; set; }
        public bool lazyRender { get; set; }
        public string listAlign { get; set; }
        public string listClass { get; set; }
        public string listEmptyText { get; set; }
        public double listWidth { get; set; }
        public string loadingText { get; set; }
        public object margins { get; set; }
        public object maskRe { get; set; }
        public double maxHeight { get; set; }
        public double maxLength { get; set; }
        public string maxLengthText { get; set; }
        public double minChars { get; set; }
        public double minHeight { get; set; }
        public double minLength { get; set; }
        public string minLengthText { get; set; }
        public double minListWidth { get; set; }
        public string mode { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageSize { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public double queryDelay { get; set; }
        public string queryParam { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public object regex { get; set; }
        public string regexText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool resizable { get; set; }
        public string selectedClass { get; set; }
        public bool selectOnFocus { get; set; }
        public object shadow { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public object store { get; set; }
        public object stripCharsRe { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public string title { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public object transform { get; set; }
        public string triggerAction { get; set; }
        public string triggerClass { get; set; }
        public object triggerConfig { get; set; }
        public bool typeAhead { get; set; }
        public double typeAheadDelay { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public Action validator { get; set; }
        public object value { get; set; }
        public string valueField { get; set; }
        public string valueNotFoundText { get; set; }
        public string vtype { get; set; }
        public string vtypeText { get; set; }
        public double width { get; set; }
        public string wrapFocusClass { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class ComboBoxEvents
    {
        // Methods
        public ComboBoxEvents() { throw new Exception(); }

        // Properties
        public static string beforequery { get { throw new Exception(); } }
        public static string beforeselect { get { throw new Exception(); } }
        public static string collapse { get { throw new Exception(); } }
        public static string expand { get { throw new Exception(); } }
        public static string select { get { throw new Exception(); } }
    }

    public delegate void ComboBoxExpandDelegate(ComboBox combo);

    public delegate void ComboBoxSelectDelegate(ComboBox combo, Record record, double index);

    [JsType(JsMode.Prototype, Export = false)]
    public class DateField : TriggerField
    {
        // Methods
        public DateField() { throw new Exception(); }
        public DateField(Element config) { throw new Exception(); }
        public DateField(DateFieldConfig config) { throw new Exception(); }
        public DateField(object config) { throw new Exception(); }
        public DateField(string config) { throw new Exception(); }
        public void autoSize() { throw new Exception(); }
        public DateTime getValue() { throw new Exception(); }
        public void onTriggerClick() { throw new Exception(); }
        public void setDisabledDates() { throw new Exception(); }
        public void setDisabledDates(Array disabledDates) { throw new Exception(); }
        public void setDisabledDays() { throw new Exception(); }
        public void setDisabledDays(Array disabledDays) { throw new Exception(); }
        public void setMaxValue() { throw new Exception(); }
        public void setMaxValue(DateTime value) { throw new Exception(); }
        public void setMinValue() { throw new Exception(); }
        public void setMinValue(DateTime value) { throw new Exception(); }
        public Field setValue() { throw new Exception(); }
        public Field setValue(DateTime date) { throw new Exception(); }
        public Field setValue(string date) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string altFormats { get; set; }
        [JsProperty(NativeField = true)]
        public object autoCreate { get; set; }
        [JsProperty(NativeField = true)]
        public Array disabledDates { get; set; }
        [JsProperty(NativeField = true)]
        public string disabledDatesText { get; set; }
        [JsProperty(NativeField = true)]
        public Array disabledDays { get; set; }
        [JsProperty(NativeField = true)]
        public string disabledDaysText { get; set; }
        [JsProperty(NativeField = true)]
        public string format { get; set; }
        [JsProperty(NativeField = true)]
        public string invalidText { get; set; }
        [JsProperty(NativeField = true)]
        public string maxText { get; set; }
        [JsProperty(NativeField = true)]
        public object maxValue { get; set; }
        [JsProperty(NativeField = true)]
        public string minText { get; set; }
        [JsProperty(NativeField = true)]
        public object minValue { get; set; }
        [JsProperty(NativeField = true)]
        public static DateField prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool showToday { get; set; }
        [JsProperty(NativeField = true)]
        public static TriggerField superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string triggerClass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DateFieldConfig
    {
        // Methods
        public DateFieldConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string altFormats { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public Array disabledDates { get; set; }
        public string disabledDatesText { get; set; }
        public Array disabledDays { get; set; }
        public string disabledDaysText { get; set; }
        public bool disableKeyFilter { get; set; }
        public bool editable { get; set; }
        public string emptyClass { get; set; }
        public string emptyText { get; set; }
        public bool enableKeyEvents { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public string format { get; set; }
        public bool grow { get; set; }
        public double growMax { get; set; }
        public double growMin { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public bool hideTrigger { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object maskRe { get; set; }
        public double maxLength { get; set; }
        public string maxLengthText { get; set; }
        public string maxText { get; set; }
        public object maxValue { get; set; }
        public double minLength { get; set; }
        public string minLengthText { get; set; }
        public string minText { get; set; }
        public object minValue { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public object regex { get; set; }
        public string regexText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool selectOnFocus { get; set; }
        public bool showToday { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public object stripCharsRe { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string triggerClass { get; set; }
        public object triggerConfig { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public Action validator { get; set; }
        public object value { get; set; }
        public string vtype { get; set; }
        public string vtypeText { get; set; }
        public double width { get; set; }
        public string wrapFocusClass { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class DateFieldEvents
    {
        // Methods
        public DateFieldEvents() { throw new Exception(); }

        // Properties
        public static string select { get { throw new Exception(); } }
    }

    public delegate void DateFieldSelectDelegate(DateField objthis, DateTime date);

    [JsType(JsMode.Prototype, Export = false)]
    public class DisplayField : Field
    {
        // Methods
        public DisplayField() { throw new Exception(); }
        public DisplayField(Element config) { throw new Exception(); }
        public DisplayField(DisplayFieldConfig config) { throw new Exception(); }
        public DisplayField(object config) { throw new Exception(); }
        public DisplayField(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string fieldClass { get; set; }
        [JsProperty(NativeField = true)]
        public bool htmlEncode { get; set; }
        [JsProperty(NativeField = true)]
        public static DisplayField prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Field superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DisplayFieldConfig
    {
        // Methods
        public DisplayFieldConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public bool htmlEncode { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public object value { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Field : BoxComponent
    {
        // Methods
        public Field() { throw new Exception(); }
        public Field(Element config) { throw new Exception(); }
        public Field(FieldConfig config) { throw new Exception(); }
        public Field(object config) { throw new Exception(); }
        public Field(string config) { throw new Exception(); }
        public void clearInvalid() { throw new Exception(); }
        public string getActiveError() { throw new Exception(); }
        public string getName() { throw new Exception(); }
        public object getRawValue() { throw new Exception(); }
        public object getValue() { throw new Exception(); }
        public bool isDirty() { throw new Exception(); }
        public bool isValid() { throw new Exception(); }
        public bool isValid(bool preventMark) { throw new Exception(); }
        public void markInvalid() { throw new Exception(); }
        public void markInvalid(string msg) { throw new Exception(); }
        public void processValue() { throw new Exception(); }
        public void processValue(object value) { throw new Exception(); }
        public void reset() { throw new Exception(); }
        public object setRawValue() { throw new Exception(); }
        public object setRawValue(object value) { throw new Exception(); }
        public void setReadOnly() { throw new Exception(); }
        public void setReadOnly(bool readOnly) { throw new Exception(); }
        public Field setValue() { throw new Exception(); }
        public Field setValue(object value) { throw new Exception(); }
        public bool validate() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object autoCreate { get; set; }
        [JsProperty(NativeField = true)]
        public string cls { get; set; }
        [JsProperty(NativeField = true)]
        public bool disabled { get; set; }
        [JsProperty(NativeField = true)]
        public string fieldClass { get; set; }
        [JsProperty(NativeField = true)]
        public string focusClass { get; set; }
        [JsProperty(NativeField = true)]
        public string inputType { get; set; }
        [JsProperty(NativeField = true)]
        public string invalidClass { get; set; }
        [JsProperty(NativeField = true)]
        public string invalidText { get; set; }
        [JsProperty(NativeField = true)]
        public Element label { get; set; }
        [JsProperty(NativeField = true)]
        public string msgFx { get; set; }
        [JsProperty(NativeField = true)]
        public string msgTarget_p_The { get; set; }
        [JsProperty(NativeField = true)]
        public string name { get; set; }
        [JsProperty(NativeField = true)]
        public object originalValue { get; set; }
        [JsProperty(NativeField = true)]
        public bool preventMark { get; set; }
        [JsProperty(NativeField = true)]
        public static Field prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool readOnly { get; set; }
        [JsProperty(NativeField = true)]
        public object startValue { get; set; }
        [JsProperty(NativeField = true)]
        public bool submitValue { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double tabIndex { get; set; }
        [JsProperty(NativeField = true)]
        public bool validateOnBlur { get; set; }
        [JsProperty(NativeField = true)]
        public double validationDelay { get; set; }
        [JsProperty(NativeField = true)]
        public object validationEvent { get; set; }
        [JsProperty(NativeField = true)]
        public object value { get; set; }
    }

    public delegate void FieldBlurDelegate(Field objthis);

    public delegate void FieldChangeDelegate(Field objthis, object newValue, object oldValue);

    [JsType(JsMode.Json)]
    public class FieldConfig
    {
        // Methods
        public FieldConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public object value { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class FieldEvents
    {
        // Methods
        public FieldEvents() { throw new Exception(); }

        // Properties
        public static string blur { get { throw new Exception(); } }
        public static string change { get { throw new Exception(); } }
        public static string focus { get { throw new Exception(); } }
        public static string invalid { get { throw new Exception(); } }
        public static string specialkey { get { throw new Exception(); } }
        public static string valid { get { throw new Exception(); } }
    }

    public delegate void FieldFocusDelegate(Field objthis);

    public delegate void FieldInvalidDelegate(Field objthis, string msg);

    [JsType(JsMode.Prototype, Export = false)]
    public class FieldSet : Panel
    {
        // Methods
        public FieldSet() { throw new Exception(); }
        public FieldSet(Element config) { throw new Exception(); }
        public FieldSet(FieldSetConfig config) { throw new Exception(); }
        public FieldSet(object config) { throw new Exception(); }
        public FieldSet(string config) { throw new Exception(); }
        public void focus() { throw new Exception(); }
        public void getBottomToolbar() { throw new Exception(); }
        public void getTopToolbar() { throw new Exception(); }
        public void onCheckClick() { throw new Exception(); }
        public void setIconClass() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool animCollapse { get; set; }
        [JsProperty(NativeField = true)]
        public string baseCls { get; set; }
        [JsProperty(NativeField = true)]
        public string checkboxName { get; set; }
        [JsProperty(NativeField = true)]
        public object checkboxToggle { get; set; }
        [JsProperty(NativeField = true)]
        public bool collapsible { get; set; }
        [JsProperty(NativeField = true)]
        public string itemCls { get; set; }
        [JsProperty(NativeField = true)]
        public double labelWidth { get; set; }
        [JsProperty(NativeField = true)]
        public string layout { get; set; }
        [JsProperty(NativeField = true)]
        public static FieldSet prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FieldSetConfig
    {
        // Methods
        public FieldSetConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string checkboxName { get; set; }
        public object checkboxToggle { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public double labelWidth { get; set; }
        public string layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double minButtonWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool unstyled { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void FieldSpecialkeyDelegate(Field objthis, EventObject e);

    public delegate void FieldValidDelegate(Field objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class FormPanel : Panel
    {
        // Methods
        public FormPanel() { throw new Exception(); }
        public FormPanel(Element config) { throw new Exception(); }
        public FormPanel(FormPanelConfig config) { throw new Exception(); }
        public FormPanel(object config) { throw new Exception(); }
        public FormPanel(string config) { throw new Exception(); }
        public BasicForm getForm() { throw new Exception(); }
        public void load() { throw new Exception(); }
        public void load(object options) { throw new Exception(); }
        public void startMonitoring() { throw new Exception(); }
        public void stopMonitoring() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public Array buttons { get; set; }
        [JsProperty(NativeField = true)]
        public BasicForm form { get; set; }
        [JsProperty(NativeField = true)]
        public string formId { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideLabels { get; set; }
        [JsProperty(NativeField = true)]
        public string itemCls { get; set; }
        [JsProperty(NativeField = true)]
        public string labelAlign { get; set; }
        [JsProperty(NativeField = true)]
        public double labelPad { get; set; }
        [JsProperty(NativeField = true)]
        public string labelSeparator { get; set; }
        [JsProperty(NativeField = true)]
        public double labelWidth { get; set; }
        [JsProperty(NativeField = true)]
        public string layout { get; set; }
        [JsProperty(NativeField = true)]
        public double minButtonWidth { get; set; }
        [JsProperty(NativeField = true)]
        public double monitorPoll { get; set; }
        [JsProperty(NativeField = true)]
        public bool monitorValid { get; set; }
        [JsProperty(NativeField = true)]
        public static FormPanel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel superclass { get; set; }
    }

    public delegate void FormPanelClientvalidationDelegate(FormPanel objthis, bool valid);

    [JsType(JsMode.Json)]
    public class FormPanelConfig
    {
        // Methods
        public FormPanelConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public string formId { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideLabel { get; set; }
        public bool hideLabels { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelAlign { get; set; }
        public double labelPad { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public double labelWidth { get; set; }
        public string layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double minButtonWidth { get; set; }
        public double monitorPoll { get; set; }
        public bool monitorResize { get; set; }
        public bool monitorValid { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool unstyled { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class FormPanelEvents
    {
        // Methods
        public FormPanelEvents() { throw new Exception(); }

        // Properties
        public static string clientvalidation { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Hidden : Field
    {
        // Methods
        public Hidden() { throw new Exception(); }
        public Hidden(Element config) { throw new Exception(); }
        public Hidden(HiddenConfig config) { throw new Exception(); }
        public Hidden(object config) { throw new Exception(); }
        public Hidden(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Hidden prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Field superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HiddenConfig
    {
        // Methods
        public HiddenConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public object value { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class HtmlEditor : Field
    {
        // Methods
        public HtmlEditor() { throw new Exception(); }
        public HtmlEditor(Element config) { throw new Exception(); }
        public HtmlEditor(HtmlEditorConfig config) { throw new Exception(); }
        public HtmlEditor(object config) { throw new Exception(); }
        public HtmlEditor(string config) { throw new Exception(); }
        public void applyToMarkup() { throw new Exception(); }
        public string cleanHtml() { throw new Exception(); }
        public string cleanHtml(string html) { throw new Exception(); }
        public void clearInvalid() { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public void execCmd() { throw new Exception(); }
        public void execCmd(string cmd) { throw new Exception(); }
        public void execCmd(string cmd, bool value) { throw new Exception(); }
        public void execCmd(string cmd, string value) { throw new Exception(); }
        public void getDocMarkup() { throw new Exception(); }
        public Toolbar getToolbar() { throw new Exception(); }
        public void insertAtCursor() { throw new Exception(); }
        public void insertAtCursor(string text) { throw new Exception(); }
        public void markInvalid() { throw new Exception(); }
        public void pushValue() { throw new Exception(); }
        public void relayCmd() { throw new Exception(); }
        public void relayCmd(string cmd) { throw new Exception(); }
        public void relayCmd(string cmd, bool value) { throw new Exception(); }
        public void relayCmd(string cmd, string value) { throw new Exception(); }
        public void setDisabled() { throw new Exception(); }
        public void syncValue() { throw new Exception(); }
        public void toggleSourceEdit() { throw new Exception(); }
        public void toggleSourceEdit(bool sourceEdit) { throw new Exception(); }
        public void updateToolbar() { throw new Exception(); }
        public void validate() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object buttonTips { get; set; }
        [JsProperty(NativeField = true)]
        public string createLinkText { get; set; }
        [JsProperty(NativeField = true)]
        public string defaultLinkValue { get; set; }
        [JsProperty(NativeField = true)]
        public string defaultValue { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableAlignments { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableColors { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableFont { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableFontSize { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableFormat { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableLinks { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableLists { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableSourceEdit { get; set; }
        [JsProperty(NativeField = true)]
        public Array fontFamilies { get; set; }
        [JsProperty(NativeField = true)]
        public static HtmlEditor prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Field superclass { get; set; }
    }

    public delegate void HtmlEditorActivateDelegate(HtmlEditor objthis);

    public delegate void HtmlEditorBeforepushDelegate(HtmlEditor objthis, string html);

    public delegate void HtmlEditorBeforesyncDelegate(HtmlEditor objthis, string html);

    [JsType(JsMode.Json)]
    public class HtmlEditorConfig
    {
        // Methods
        public HtmlEditorConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string createLinkText { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string defaultLinkValue { get; set; }
        public string defaultValue { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool enableAlignments { get; set; }
        public bool enableColors { get; set; }
        public bool enableFont { get; set; }
        public bool enableFontSize { get; set; }
        public bool enableFormat { get; set; }
        public bool enableLinks { get; set; }
        public bool enableLists { get; set; }
        public bool enableSourceEdit { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public Array fontFamilies { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public object value { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void HtmlEditorEditmodechangeDelegate(HtmlEditor objthis, bool sourceEdit);

    public class HtmlEditorEvents
    {
        // Methods
        public HtmlEditorEvents() { throw new Exception(); }

        // Properties
        public static string activate { get { throw new Exception(); } }
        public static string beforepush { get { throw new Exception(); } }
        public static string beforesync { get { throw new Exception(); } }
        public static string editmodechange { get { throw new Exception(); } }
        public static string initialize { get { throw new Exception(); } }
        public static string push { get { throw new Exception(); } }
        public static string sync { get { throw new Exception(); } }
    }

    public delegate void HtmlEditorInitializeDelegate(HtmlEditor objthis);

    public delegate void HtmlEditorPushDelegate(HtmlEditor objthis, string html);

    public delegate void HtmlEditorSyncDelegate(HtmlEditor objthis, string html);

    [JsType(JsMode.Prototype, Export = false)]
    public class Label : BoxComponent
    {
        // Methods
        public Label() { throw new Exception(); }
        public Label(Element config) { throw new Exception(); }
        public Label(LabelConfig config) { throw new Exception(); }
        public Label(object config) { throw new Exception(); }
        public Label(string config) { throw new Exception(); }
        public Label setText() { throw new Exception(); }
        public Label setText(string text) { throw new Exception(); }
        public Label setText(string text, bool encode) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string forId { get; set; }
        [JsProperty(NativeField = true)]
        public string html { get; set; }
        [JsProperty(NativeField = true)]
        public static Label prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxComponent superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string text { get; set; }
    }

    [JsType(JsMode.Json)]
    public class LabelConfig
    {
        // Methods
        public LabelConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public string forId { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public string html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public string text { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class NumberField : TextField
    {
        // Methods
        public NumberField() { throw new Exception(); }
        public NumberField(Element config) { throw new Exception(); }
        public NumberField(NumberFieldConfig config) { throw new Exception(); }
        public NumberField(object config) { throw new Exception(); }
        public NumberField(string config) { throw new Exception(); }
        public void setMaxValue() { throw new Exception(); }
        public void setMaxValue(double value) { throw new Exception(); }
        public void setMinValue() { throw new Exception(); }
        public void setMinValue(double value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowDecimals { get; set; }
        [JsProperty(NativeField = true)]
        public bool allowNegative { get; set; }
        [JsProperty(NativeField = true)]
        public string baseChars { get; set; }
        [JsProperty(NativeField = true)]
        public double decimalPrecision { get; set; }
        [JsProperty(NativeField = true)]
        public string decimalSeparator { get; set; }
        [JsProperty(NativeField = true)]
        public string fieldClass { get; set; }
        [JsProperty(NativeField = true)]
        public string maxText { get; set; }
        [JsProperty(NativeField = true)]
        public double maxValue { get; set; }
        [JsProperty(NativeField = true)]
        public string minText { get; set; }
        [JsProperty(NativeField = true)]
        public double minValue { get; set; }
        [JsProperty(NativeField = true)]
        public string nanText { get; set; }
        [JsProperty(NativeField = true)]
        public static NumberField prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static TextField superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class NumberFieldConfig
    {
        // Methods
        public NumberFieldConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDecimals { get; set; }
        public bool allowDomMove { get; set; }
        public bool allowNegative { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseChars { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public double decimalPrecision { get; set; }
        public string decimalSeparator { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableKeyFilter { get; set; }
        public string emptyClass { get; set; }
        public string emptyText { get; set; }
        public bool enableKeyEvents { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public bool grow { get; set; }
        public double growMax { get; set; }
        public double growMin { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object maskRe { get; set; }
        public double maxLength { get; set; }
        public string maxLengthText { get; set; }
        public string maxText { get; set; }
        public double maxValue { get; set; }
        public double minLength { get; set; }
        public string minLengthText { get; set; }
        public string minText { get; set; }
        public double minValue { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string nanText { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public object regex { get; set; }
        public string regexText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool selectOnFocus { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public object stripCharsRe { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public Action validator { get; set; }
        public object value { get; set; }
        public string vtype { get; set; }
        public string vtypeText { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Radio : Checkbox
    {
        // Methods
        public Radio() { throw new Exception(); }
        public Radio(Element config) { throw new Exception(); }
        public Radio(RadioConfig config) { throw new Exception(); }
        public Radio(object config) { throw new Exception(); }
        public Radio(string config) { throw new Exception(); }
        public void clearInvalid() { throw new Exception(); }
        public string getGroupValue() { throw new Exception(); }
        public void markInvalid() { throw new Exception(); }
        public Field setValue() { throw new Exception(); }
        public Field setValue(object value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Radio prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Checkbox superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RadioConfig
    {
        // Methods
        public RadioConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string boxLabel { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public bool @checked { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public JsAction handler { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string inputValue { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public object value { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class RadioGroup : CheckboxGroup
    {
        // Methods
        public RadioGroup() { throw new Exception(); }
        public RadioGroup(Element config) { throw new Exception(); }
        public RadioGroup(RadioGroupConfig config) { throw new Exception(); }
        public RadioGroup(object config) { throw new Exception(); }
        public RadioGroup(string config) { throw new Exception(); }
        public Radio getValue() { throw new Exception(); }
        public RadioGroup onSetValue() { throw new Exception(); }
        public RadioGroup onSetValue(Radio id) { throw new Exception(); }
        public RadioGroup onSetValue(string id) { throw new Exception(); }
        public RadioGroup onSetValue(Radio id, bool value) { throw new Exception(); }
        public RadioGroup onSetValue(string id, bool value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowBlank { get; set; }
        [JsProperty(NativeField = true)]
        public string blankText { get; set; }
        [JsProperty(NativeField = true)]
        public Array items { get; set; }
        [JsProperty(NativeField = true)]
        public static RadioGroup prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static CheckboxGroup superclass { get; set; }
    }

    public delegate void RadioGroupChangeDelegate(RadioGroup objthis, Radio chckd);

    [JsType(JsMode.Json)]
    public class RadioGroupConfig
    {
        // Methods
        public RadioGroupConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public object columns { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public Array items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public object value { get; set; }
        public bool vertical { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class RadioGroupEvents
    {
        // Methods
        public RadioGroupEvents() { throw new Exception(); }

        // Properties
        public static string change { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TextArea : TextField
    {
        // Methods
        public TextArea() { throw new Exception(); }
        public TextArea(Element config) { throw new Exception(); }
        public TextArea(TextAreaConfig config) { throw new Exception(); }
        public TextArea(object config) { throw new Exception(); }
        public TextArea(string config) { throw new Exception(); }
        public void autoSize() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object autoCreate { get; set; }
        [JsProperty(NativeField = true)]
        public double growMax { get; set; }
        [JsProperty(NativeField = true)]
        public double growMin { get; set; }
        [JsProperty(NativeField = true)]
        public bool preventScrollbars { get; set; }
        [JsProperty(NativeField = true)]
        public static TextArea prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static TextField superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TextAreaConfig
    {
        // Methods
        public TextAreaConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableKeyFilter { get; set; }
        public string emptyClass { get; set; }
        public string emptyText { get; set; }
        public bool enableKeyEvents { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public bool grow { get; set; }
        public double growMax { get; set; }
        public double growMin { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object maskRe { get; set; }
        public double maxLength { get; set; }
        public string maxLengthText { get; set; }
        public double minLength { get; set; }
        public string minLengthText { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public bool preventScrollbars { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public object regex { get; set; }
        public string regexText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool selectOnFocus { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public object stripCharsRe { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public Action validator { get; set; }
        public object value { get; set; }
        public string vtype { get; set; }
        public string vtypeText { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TextField : Field
    {
        // Methods
        public TextField() { throw new Exception(); }
        public TextField(Element config) { throw new Exception(); }
        public TextField(TextFieldConfig config) { throw new Exception(); }
        public TextField(object config) { throw new Exception(); }
        public TextField(string config) { throw new Exception(); }
        public void autoSize() { throw new Exception(); }
        public void reset() { throw new Exception(); }
        public void selectText() { throw new Exception(); }
        public void selectText(double start) { throw new Exception(); }
        public void selectText(double start, double end) { throw new Exception(); }
        public bool validateValue() { throw new Exception(); }
        public bool validateValue(object value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowBlank { get; set; }
        [JsProperty(NativeField = true)]
        public string blankText { get; set; }
        [JsProperty(NativeField = true)]
        public bool disableKeyFilter { get; set; }
        [JsProperty(NativeField = true)]
        public string emptyClass { get; set; }
        [JsProperty(NativeField = true)]
        public string emptyText { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableKeyEvents { get; set; }
        [JsProperty(NativeField = true)]
        public bool grow { get; set; }
        [JsProperty(NativeField = true)]
        public double growMax { get; set; }
        [JsProperty(NativeField = true)]
        public double growMin { get; set; }
        [JsProperty(NativeField = true)]
        public object maskRe { get; set; }
        [JsProperty(NativeField = true)]
        public double maxLength { get; set; }
        [JsProperty(NativeField = true)]
        public string maxLengthText { get; set; }
        [JsProperty(NativeField = true)]
        public double minLength { get; set; }
        [JsProperty(NativeField = true)]
        public string minLengthText { get; set; }
        [JsProperty(NativeField = true)]
        public static TextField prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object regex { get; set; }
        [JsProperty(NativeField = true)]
        public string regexText { get; set; }
        [JsProperty(NativeField = true)]
        public bool selectOnFocus { get; set; }
        [JsProperty(NativeField = true)]
        public object stripCharsRe { get; set; }
        [JsProperty(NativeField = true)]
        public static Field superclass { get; set; }
        [JsProperty(NativeField = true)]
        public Action validator { get; set; }
        [JsProperty(NativeField = true)]
        public string vtype { get; set; }
        [JsProperty(NativeField = true)]
        public string vtypeText { get; set; }
    }

    public delegate void TextFieldAutosizeDelegate(Field objthis, double width);

    [JsType(JsMode.Json)]
    public class TextFieldConfig
    {
        // Methods
        public TextFieldConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableKeyFilter { get; set; }
        public string emptyClass { get; set; }
        public string emptyText { get; set; }
        public bool enableKeyEvents { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public bool grow { get; set; }
        public double growMax { get; set; }
        public double growMin { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object maskRe { get; set; }
        public double maxLength { get; set; }
        public string maxLengthText { get; set; }
        public double minLength { get; set; }
        public string minLengthText { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public object regex { get; set; }
        public string regexText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool selectOnFocus { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public object stripCharsRe { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public Action validator { get; set; }
        public object value { get; set; }
        public string vtype { get; set; }
        public string vtypeText { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class TextFieldEvents
    {
        // Methods
        public TextFieldEvents() { throw new Exception(); }

        // Properties
        public static string autosize { get { throw new Exception(); } }
        public static string keydown { get { throw new Exception(); } }
        public static string keypress { get { throw new Exception(); } }
        public static string keyup { get { throw new Exception(); } }
    }

    public delegate void TextFieldKeydownDelegate(TextField objthis, EventObject e);

    public delegate void TextFieldKeypressDelegate(TextField objthis, EventObject e);

    public delegate void TextFieldKeyupDelegate(TextField objthis, EventObject e);

    [JsType(JsMode.Prototype, Export = false)]
    public class TimeField : ComboBox
    {
        // Methods
        public TimeField() { throw new Exception(); }
        public TimeField(Element config) { throw new Exception(); }
        public TimeField(TimeFieldConfig config) { throw new Exception(); }
        public TimeField(object config) { throw new Exception(); }
        public TimeField(string config) { throw new Exception(); }
        public void autoSize() { throw new Exception(); }
        public void setMaxValue() { throw new Exception(); }
        public void setMaxValue(DateTime value) { throw new Exception(); }
        public void setMaxValue(string value) { throw new Exception(); }
        public void setMinValue() { throw new Exception(); }
        public void setMinValue(DateTime value) { throw new Exception(); }
        public void setMinValue(string value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string altFormats { get; set; }
        [JsProperty(NativeField = true)]
        public string format { get; set; }
        [JsProperty(NativeField = true)]
        public double increment { get; set; }
        [JsProperty(NativeField = true)]
        public string invalidText { get; set; }
        [JsProperty(NativeField = true)]
        public string maxText { get; set; }
        [JsProperty(NativeField = true)]
        public object maxValue { get; set; }
        [JsProperty(NativeField = true)]
        public string minText { get; set; }
        [JsProperty(NativeField = true)]
        public object minValue { get; set; }
        [JsProperty(NativeField = true)]
        public static TimeField prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ComboBox superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TimeFieldConfig
    {
        // Methods
        public TimeFieldConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string allQuery { get; set; }
        public string altFormats { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public bool clearFilterOnReset { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableKeyFilter { get; set; }
        public string displayField { get; set; }
        public bool editable { get; set; }
        public string emptyClass { get; set; }
        public string emptyText { get; set; }
        public bool enableKeyEvents { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public bool forceSelection { get; set; }
        public string format { get; set; }
        public bool grow { get; set; }
        public double growMax { get; set; }
        public double growMin { get; set; }
        public double handleHeight { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public string hiddenId { get; set; }
        public string hiddenName { get; set; }
        public string hiddenValue { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public bool hideTrigger { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public double increment { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string itemSelector { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public bool lazyInit { get; set; }
        public bool lazyRender { get; set; }
        public string listAlign { get; set; }
        public string listClass { get; set; }
        public string listEmptyText { get; set; }
        public double listWidth { get; set; }
        public string loadingText { get; set; }
        public object margins { get; set; }
        public object maskRe { get; set; }
        public double maxHeight { get; set; }
        public double maxLength { get; set; }
        public string maxLengthText { get; set; }
        public string maxText { get; set; }
        public object maxValue { get; set; }
        public double minChars { get; set; }
        public double minHeight { get; set; }
        public double minLength { get; set; }
        public string minLengthText { get; set; }
        public double minListWidth { get; set; }
        public string minText { get; set; }
        public object minValue { get; set; }
        public string mode { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageSize { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public double queryDelay { get; set; }
        public string queryParam { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public object regex { get; set; }
        public string regexText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool resizable { get; set; }
        public string selectedClass { get; set; }
        public bool selectOnFocus { get; set; }
        public object shadow { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public object store { get; set; }
        public object stripCharsRe { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public string title { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public object transform { get; set; }
        public string triggerAction { get; set; }
        public string triggerClass { get; set; }
        public object triggerConfig { get; set; }
        public bool typeAhead { get; set; }
        public double typeAheadDelay { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public Action validator { get; set; }
        public object value { get; set; }
        public string valueField { get; set; }
        public string valueNotFoundText { get; set; }
        public string vtype { get; set; }
        public string vtypeText { get; set; }
        public double width { get; set; }
        public string wrapFocusClass { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TriggerField : TextField
    {
        // Methods
        public TriggerField() { throw new Exception(); }
        public TriggerField(Element config) { throw new Exception(); }
        public TriggerField(TriggerFieldConfig config) { throw new Exception(); }
        public TriggerField(object config) { throw new Exception(); }
        public TriggerField(string config) { throw new Exception(); }
        public void autoSize() { throw new Exception(); }
        public void onTriggerClick() { throw new Exception(); }
        public void onTriggerClick(EventObject e) { throw new Exception(); }
        public void setEditable() { throw new Exception(); }
        public void setEditable(bool value) { throw new Exception(); }
        public void setReadOnly() { throw new Exception(); }
        public void setReadOnly(bool value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object autoCreate { get; set; }
        [JsProperty(NativeField = true)]
        public bool editable { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideTrigger { get; set; }
        [JsProperty(NativeField = true)]
        public static TriggerField prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool readOnly { get; set; }
        [JsProperty(NativeField = true)]
        public static TextField superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string triggerClass { get; set; }
        [JsProperty(NativeField = true)]
        public object triggerConfig { get; set; }
        [JsProperty(NativeField = true)]
        public string wrapFocusClass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TriggerFieldConfig
    {
        // Methods
        public TriggerFieldConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableKeyFilter { get; set; }
        public bool editable { get; set; }
        public string emptyClass { get; set; }
        public string emptyText { get; set; }
        public bool enableKeyEvents { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public bool grow { get; set; }
        public double growMax { get; set; }
        public double growMin { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public bool hideTrigger { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object maskRe { get; set; }
        public double maxLength { get; set; }
        public string maxLengthText { get; set; }
        public double minLength { get; set; }
        public string minLengthText { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public object regex { get; set; }
        public string regexText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool selectOnFocus { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public object stripCharsRe { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string triggerClass { get; set; }
        public object triggerConfig { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public Action validator { get; set; }
        public object value { get; set; }
        public string vtype { get; set; }
        public string vtypeText { get; set; }
        public double width { get; set; }
        public string wrapFocusClass { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TwinTriggerField : TriggerField
    {
        // Methods
        public TwinTriggerField() { throw new Exception(); }
        public TwinTriggerField(Element config) { throw new Exception(); }
        public TwinTriggerField(TwinTriggerFieldConfig config) { throw new Exception(); }
        public TwinTriggerField(object config) { throw new Exception(); }
        public TwinTriggerField(string config) { throw new Exception(); }
        public void onTrigger1Click() { throw new Exception(); }
        public void onTrigger1Click(EventObject e) { throw new Exception(); }
        public void onTrigger2Click() { throw new Exception(); }
        public void onTrigger2Click(EventObject e) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static TwinTriggerField prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static TriggerField superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string trigger1Class { get; set; }
        [JsProperty(NativeField = true)]
        public string trigger2Class { get; set; }
        [JsProperty(NativeField = true)]
        public object triggerConfig { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TwinTriggerFieldConfig
    {
        // Methods
        public TwinTriggerFieldConfig() { throw new Exception(); }

        // Properties
        public bool allowBlank { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoCreate { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string blankText { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableKeyFilter { get; set; }
        public bool editable { get; set; }
        public string emptyClass { get; set; }
        public string emptyText { get; set; }
        public bool enableKeyEvents { get; set; }
        public string fieldClass { get; set; }
        public string fieldLabel { get; set; }
        public string focusClass { get; set; }
        public bool grow { get; set; }
        public double growMax { get; set; }
        public double growMin { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public bool hideTrigger { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string inputType { get; set; }
        public string invalidClass { get; set; }
        public string invalidText { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object margins { get; set; }
        public object maskRe { get; set; }
        public double maxLength { get; set; }
        public string maxLengthText { get; set; }
        public double minLength { get; set; }
        public string minLengthText { get; set; }
        public string msgFx { get; set; }
        public string msgTarget_p_The { get; set; }
        public string name { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventMark { get; set; }
        public string ptype { get; set; }
        public bool readOnly { get; set; }
        public string @ref { get; set; }
        public object regex { get; set; }
        public string regexText { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool selectOnFocus { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public object stripCharsRe { get; set; }
        public string style { get; set; }
        public bool submitValue { get; set; }
        public double tabIndex { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string trigger1Class { get; set; }
        public string trigger2Class { get; set; }
        public string triggerClass { get; set; }
        public object triggerConfig { get; set; }
        public bool validateOnBlur { get; set; }
        public double validationDelay { get; set; }
        public object validationEvent { get; set; }
        public Action validator { get; set; }
        public object value { get; set; }
        public string vtype { get; set; }
        public string vtypeText { get; set; }
        public double width { get; set; }
        public string wrapFocusClass { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class VTypes
    {
        // Methods
        public VTypes() { throw new Exception(); }
        public static bool alpha() { throw new Exception(); }
        public static bool alpha(string value) { throw new Exception(); }
        public static bool alphanum() { throw new Exception(); }
        public static bool alphanum(string value) { throw new Exception(); }
        public static bool email() { throw new Exception(); }
        public static bool email(string value) { throw new Exception(); }
        public static bool url() { throw new Exception(); }
        public static bool url(string value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static object alphaMask { get; set; }
        [JsProperty(NativeField = true)]
        public static object alphanumMask { get; set; }
        [JsProperty(NativeField = true)]
        public static string alphanumText { get; set; }
        [JsProperty(NativeField = true)]
        public static string alphaText { get; set; }
        [JsProperty(NativeField = true)]
        public static object emailMask { get; set; }
        [JsProperty(NativeField = true)]
        public static string emailText { get; set; }
        [JsProperty(NativeField = true)]
        public static VTypes prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static string urlText { get; set; }
    }

    [JsType(JsMode.Json)]
    public class VTypesConfig
    {
        // Methods
        public VTypesConfig() { throw new Exception(); }
    }
}


namespace Ext.grid
{
    [JsType(JsMode.Prototype, Export = false)]
    public class AbstractSelectionModel : Observable
    {
        // Methods
        public AbstractSelectionModel() { throw new Exception(); }
        public bool isLocked() { throw new Exception(); }
        public void lock_() { throw new Exception(); }
        public void unlock() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object grid { get; set; }
        [JsProperty(NativeField = true)]
        public static AbstractSelectionModel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AbstractSelectionModelConfig
    {
        // Methods
        public AbstractSelectionModelConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class BooleanColumn : Column
    {
        // Methods
        public BooleanColumn() { throw new Exception(); }
        public BooleanColumn(BooleanColumnConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string falseText { get; set; }
        [JsProperty(NativeField = true)]
        public static BooleanColumn prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Column superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string trueText { get; set; }
        [JsProperty(NativeField = true)]
        public string undefinedText { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BooleanColumnConfig
    {
        // Methods
        public BooleanColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string css { get; set; }
        public string dataIndex { get; set; }
        public bool editable { get; set; }
        public Ext.form.Field editor { get; set; }
        public string emptyGroupText { get; set; }
        public string falseText { get; set; }
        public bool @fixed { get; set; }
        public bool groupable { get; set; }
        public string groupName { get; set; }
        public JsAction groupRenderer { get; set; }
        public string header { get; set; }
        public bool hidden { get; set; }
        public bool hideable { get; set; }
        public string id { get; set; }
        public bool isColumn { get; set; }
        public bool menuDisabled { get; set; }
        public object renderer { get; set; }
        public bool resizable { get; set; }
        public object scope { get; set; }
        public bool sortable { get; set; }
        public string tooltip { get; set; }
        public string trueText { get; set; }
        public string undefinedText { get; set; }
        public double width { get; set; }
        public string xtype { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CellSelectionModel : AbstractSelectionModel
    {
        // Methods
        public CellSelectionModel() { throw new Exception(); }
        public CellSelectionModel(object config) { throw new Exception(); }
        public void clearSelections() { throw new Exception(); }
        public void clearSelections(bool preventNotify) { throw new Exception(); }
        public Array getSelectedCell() { throw new Exception(); }
        public bool hasSelection() { throw new Exception(); }
        public void select() { throw new Exception(); }
        public void select(double rowIndex) { throw new Exception(); }
        public void select(double rowIndex, double colIndex) { throw new Exception(); }
        public void select(double rowIndex, double colIndex, bool preventViewNotify) { throw new Exception(); }
        public void select(double rowIndex, double colIndex, bool preventViewNotify, bool preventFocus) { throw new Exception(); }
        public void select(double rowIndex, double colIndex, bool preventViewNotify, bool preventFocus, Record r) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static CellSelectionModel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static AbstractSelectionModel superclass { get; set; }
    }

    public delegate void CellSelectionModelBeforecellselectDelegate(object objthis, double rowIndex, double colIndex);

    public delegate void CellSelectionModelCellselectDelegate(object objthis, double rowIndex, double colIndex);

    [JsType(JsMode.Json)]
    public class CellSelectionModelConfig
    {
        // Methods
        public CellSelectionModelConfig() { throw new Exception(); }
    }

    public class CellSelectionModelEvents
    {
        // Methods
        public CellSelectionModelEvents() { throw new Exception(); }

        // Properties
        public static string beforecellselect { get { throw new Exception(); } }
        public static string cellselect { get { throw new Exception(); } }
        public static string selectionchange { get { throw new Exception(); } }
    }

    public delegate void CellSelectionModelSelectionchangeDelegate(object objthis, object selection);

    [JsType(JsMode.Prototype, Export = false)]
    public class CheckboxSelectionModel : RowSelectionModel
    {
        // Methods
        public CheckboxSelectionModel() { throw new Exception(); }
        public CheckboxSelectionModel(CheckboxSelectionModelConfig config) { throw new Exception(); }
        public CheckboxSelectionModel(object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool checkOnly { get; set; }
        [JsProperty(NativeField = true)]
        public string header { get; set; }
        [JsProperty(NativeField = true)]
        public static CheckboxSelectionModel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool sortable { get; set; }
        [JsProperty(NativeField = true)]
        public static RowSelectionModel superclass { get; set; }
        [JsProperty(NativeField = true)]
        public double width { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CheckboxSelectionModelConfig
    {
        // Methods
        public CheckboxSelectionModelConfig() { throw new Exception(); }

        // Properties
        public bool checkOnly { get; set; }
        public string header { get; set; }
        public bool moveEditorOnEnter { get; set; }
        public bool singleSelect { get; set; }
        public bool sortable { get; set; }
        public double width { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Column
    {
        // Methods
        public Column() { throw new Exception(); }
        public Column(ColumnConfig config) { throw new Exception(); }
        public Editor getCellEditor() { throw new Exception(); }
        public Editor getCellEditor(double rowIndex) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string align { get; set; }
        [JsProperty(NativeField = true)]
        public string css { get; set; }
        [JsProperty(NativeField = true)]
        public string dataIndex { get; set; }
        [JsProperty(NativeField = true)]
        public bool editable { get; set; }
        [JsProperty(NativeField = true)]
        public Ext.form.Field editor { get; set; }
        [JsProperty(NativeField = true)]
        public string emptyGroupText { get; set; }
        [JsProperty(NativeField = true)]
        public bool fixed_ { get; set; }
        [JsProperty(NativeField = true)]
        public bool groupable { get; set; }
        [JsProperty(NativeField = true)]
        public string groupName { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction groupRenderer { get; set; }
        [JsProperty(NativeField = true)]
        public string header { get; set; }
        [JsProperty(NativeField = true)]
        public bool hidden { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideable { get; set; }
        [JsProperty(NativeField = true)]
        public string id { get; set; }
        [JsProperty(NativeField = true)]
        public bool menuDisabled { get; set; }
        [JsProperty(NativeField = true)]
        public static Column prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object renderer { get; set; }
        [JsProperty(NativeField = true)]
        public bool resizable { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public bool sortable { get; set; }
        [JsProperty(NativeField = true)]
        public string tooltip { get; set; }
        [JsProperty(NativeField = true)]
        public double width { get; set; }
        [JsProperty(NativeField = true)]
        public string xtype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ColumnConfig
    {
        // Methods
        public ColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string css { get; set; }
        public string dataIndex { get; set; }
        public bool editable { get; set; }
        public Ext.form.Field editor { get; set; }
        public string emptyGroupText { get; set; }
        public bool @fixed { get; set; }
        public bool groupable { get; set; }
        public string groupName { get; set; }
        public JsAction groupRenderer { get; set; }
        public string header { get; set; }
        public bool hidden { get; set; }
        public bool hideable { get; set; }
        public string id { get; set; }
        public bool isColumn { get; set; }
        public bool menuDisabled { get; set; }
        public object renderer { get; set; }
        public bool resizable { get; set; }
        public object scope { get; set; }
        public bool sortable { get; set; }
        public string tooltip { get; set; }
        public double width { get; set; }
        public string xtype { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ColumnModel : Observable
    {
        // Methods
        public ColumnModel() { throw new Exception(); }
        public ColumnModel(ColumnModelConfig config) { throw new Exception(); }
        public ColumnModel(object config) { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public double findColumnIndex() { throw new Exception(); }
        public double findColumnIndex(string col) { throw new Exception(); }
        public Editor getCellEditor() { throw new Exception(); }
        public Editor getCellEditor(double colIndex) { throw new Exception(); }
        public Editor getCellEditor(double colIndex, double rowIndex) { throw new Exception(); }
        public object getColumnById() { throw new Exception(); }
        public object getColumnById(string id) { throw new Exception(); }
        public double getColumnCount() { throw new Exception(); }
        public double getColumnCount(bool visibleOnly) { throw new Exception(); }
        public string getColumnHeader() { throw new Exception(); }
        public string getColumnHeader(double col) { throw new Exception(); }
        public string getColumnId() { throw new Exception(); }
        public string getColumnId(double index) { throw new Exception(); }
        public Array getColumnsBy() { throw new Exception(); }
        public Array getColumnsBy(JsAction fn) { throw new Exception(); }
        public Array getColumnsBy(JsAction fn, object scope) { throw new Exception(); }
        public string getColumnTooltip() { throw new Exception(); }
        public string getColumnTooltip(double col) { throw new Exception(); }
        public double getColumnWidth() { throw new Exception(); }
        public double getColumnWidth(double col) { throw new Exception(); }
        public string getDataIndex() { throw new Exception(); }
        public string getDataIndex(double col) { throw new Exception(); }
        public double getIndexById() { throw new Exception(); }
        public double getIndexById(string id) { throw new Exception(); }
        public JsAction getRenderer() { throw new Exception(); }
        public JsAction getRenderer(double col) { throw new Exception(); }
        public double getTotalWidth() { throw new Exception(); }
        public double getTotalWidth(bool includeHidden) { throw new Exception(); }
        public bool isCellEditable() { throw new Exception(); }
        public bool isCellEditable(double colIndex) { throw new Exception(); }
        public bool isCellEditable(double colIndex, double rowIndex) { throw new Exception(); }
        public bool isFixed() { throw new Exception(); }
        public bool isFixed(double colIndex) { throw new Exception(); }
        public bool isHidden() { throw new Exception(); }
        public bool isHidden(double colIndex) { throw new Exception(); }
        public bool isMenuDisabled() { throw new Exception(); }
        public bool isMenuDisabled(double col) { throw new Exception(); }
        public bool isResizable() { throw new Exception(); }
        public bool isSortable() { throw new Exception(); }
        public bool isSortable(double col) { throw new Exception(); }
        public void moveColumn() { throw new Exception(); }
        public void moveColumn(double oldIndex) { throw new Exception(); }
        public void moveColumn(double oldIndex, double newIndex) { throw new Exception(); }
        public void setColumnHeader() { throw new Exception(); }
        public void setColumnHeader(double col) { throw new Exception(); }
        public void setColumnHeader(double col, string header) { throw new Exception(); }
        public void setColumnTooltip() { throw new Exception(); }
        public void setColumnTooltip(double col) { throw new Exception(); }
        public void setColumnTooltip(double col, string tooltip) { throw new Exception(); }
        public void setColumnWidth() { throw new Exception(); }
        public void setColumnWidth(double col) { throw new Exception(); }
        public void setColumnWidth(double col, double width) { throw new Exception(); }
        public void setColumnWidth(double col, double width, bool suppressEvent) { throw new Exception(); }
        public void setConfig() { throw new Exception(); }
        public void setConfig(Array config) { throw new Exception(); }
        public void setConfig(Array config, bool initial) { throw new Exception(); }
        public void setDataIndex() { throw new Exception(); }
        public void setDataIndex(double col) { throw new Exception(); }
        public void setDataIndex(double col, string dataIndex) { throw new Exception(); }
        public void setEditable() { throw new Exception(); }
        public void setEditable(double col) { throw new Exception(); }
        public void setEditable(double col, bool editable) { throw new Exception(); }
        public void setEditor() { throw new Exception(); }
        public void setEditor(double col) { throw new Exception(); }
        public void setEditor(double col, object editor) { throw new Exception(); }
        public void setHidden() { throw new Exception(); }
        public void setHidden(double colIndex) { throw new Exception(); }
        public void setHidden(double colIndex, bool hidden) { throw new Exception(); }
        public void setRenderer() { throw new Exception(); }
        public void setRenderer(double col) { throw new Exception(); }
        public void setRenderer(double col, JsAction fn) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public Array columns { get; set; }
        [JsProperty(NativeField = true)]
        public Array config { get; set; }
        [JsProperty(NativeField = true)]
        public object defaults { get; set; }
        [JsProperty(NativeField = true)]
        public bool defaultSortable { get; set; }
        [JsProperty(NativeField = true)]
        public double defaultWidth { get; set; }
        [JsProperty(NativeField = true)]
        public static ColumnModel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void ColumnModelColumnmovedDelegate(ColumnModel objthis, double oldIndex, double newIndex);

    [JsType(JsMode.Json)]
    public class ColumnModelConfig
    {
        // Methods
        public ColumnModelConfig() { throw new Exception(); }

        // Properties
        public Array columns { get; set; }
        public object defaults { get; set; }
        public bool defaultSortable { get; set; }
        public double defaultWidth { get; set; }
    }

    public delegate void ColumnModelConfigchangeDelegate(ColumnModel objthis);

    public class ColumnModelEvents
    {
        // Methods
        public ColumnModelEvents() { throw new Exception(); }

        // Properties
        public static string columnmoved { get { throw new Exception(); } }
        public static string configchange { get { throw new Exception(); } }
        public static string headerchange { get { throw new Exception(); } }
        public static string hiddenchange { get { throw new Exception(); } }
        public static string widthchange { get { throw new Exception(); } }
    }

    public delegate void ColumnModelHeaderchangeDelegate(ColumnModel objthis, double columnIndex, string newText);

    public delegate void ColumnModelHiddenchangeDelegate(ColumnModel objthis, double columnIndex, bool hidden);

    public delegate void ColumnModelWidthchangeDelegate(ColumnModel objthis, double columnIndex, double newWidth);

    [JsType(JsMode.Prototype, Export = false)]
    public class DateColumn : Column
    {
        // Methods
        public DateColumn() { throw new Exception(); }
        public DateColumn(DateColumnConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string format { get; set; }
        [JsProperty(NativeField = true)]
        public static DateColumn prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Column superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DateColumnConfig
    {
        // Methods
        public DateColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string css { get; set; }
        public string dataIndex { get; set; }
        public bool editable { get; set; }
        public Ext.form.Field editor { get; set; }
        public string emptyGroupText { get; set; }
        public bool @fixed { get; set; }
        public string format { get; set; }
        public bool groupable { get; set; }
        public string groupName { get; set; }
        public JsAction groupRenderer { get; set; }
        public string header { get; set; }
        public bool hidden { get; set; }
        public bool hideable { get; set; }
        public string id { get; set; }
        public bool isColumn { get; set; }
        public bool menuDisabled { get; set; }
        public object renderer { get; set; }
        public bool resizable { get; set; }
        public object scope { get; set; }
        public bool sortable { get; set; }
        public string tooltip { get; set; }
        public double width { get; set; }
        public string xtype { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class EditorGridPanel : GridPanel
    {
        // Methods
        public EditorGridPanel() { throw new Exception(); }
        public EditorGridPanel(Element config) { throw new Exception(); }
        public EditorGridPanel(EditorGridPanelConfig config) { throw new Exception(); }
        public EditorGridPanel(object config) { throw new Exception(); }
        public EditorGridPanel(string config) { throw new Exception(); }
        public void startEditing() { throw new Exception(); }
        public void startEditing(double rowIndex) { throw new Exception(); }
        public void startEditing(double rowIndex, double colIndex) { throw new Exception(); }
        public void stopEditing() { throw new Exception(); }
        public void stopEditing(bool cancel) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool autoEncode { get; set; }
        [JsProperty(NativeField = true)]
        public double clicksToEdit { get; set; }
        [JsProperty(NativeField = true)]
        public bool forceValidation { get; set; }
        [JsProperty(NativeField = true)]
        public static EditorGridPanel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object selModel { get; set; }
        [JsProperty(NativeField = true)]
        public static GridPanel superclass { get; set; }
    }

    public delegate void EditorGridPanelAftereditDelegate(object e);

    public delegate void EditorGridPanelBeforeeditDelegate(object e);

    [JsType(JsMode.Json)]
    public class EditorGridPanelConfig
    {
        // Methods
        public EditorGridPanelConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoEncode { get; set; }
        public string autoExpandColumn { get; set; }
        public double autoExpandMax { get; set; }
        public double autoExpandMin { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public double clicksToEdit { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public object cm { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public object colModel { get; set; }
        public bool columnLines { get; set; }
        public Array columns { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string ddGroup { get; set; }
        public string ddText { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool deferRowRender { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableSelection { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public bool enableColumnHide { get; set; }
        public bool enableColumnMove { get; set; }
        public bool enableColumnResize { get; set; }
        public bool enableDragDrop { get; set; }
        public bool enableHdMenu { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool forceValidation { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideHeaders { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object loadMask { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double maxHeight { get; set; }
        public double minButtonWidth { get; set; }
        public double minColumnWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object selModel { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public object sm { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public Store store { get; set; }
        public bool stripeRows { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool trackMouseOver { get; set; }
        public bool unstyled { get; set; }
        public object view { get; set; }
        public object viewConfig { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class EditorGridPanelEvents
    {
        // Methods
        public EditorGridPanelEvents() { throw new Exception(); }

        // Properties
        public static string afteredit { get { throw new Exception(); } }
        public static string beforeedit { get { throw new Exception(); } }
        public static string validateedit { get { throw new Exception(); } }
    }

    public delegate void EditorGridPanelValidateeditDelegate(object e);

    [JsType(JsMode.Prototype, Export = false)]
    public class GridDragZone : DragZone
    {
        // Methods
        public GridDragZone() { throw new Exception(); }
        public GridDragZone(GridDragZoneConfig config) { throw new Exception(); }
        public GridDragZone(object el) { throw new Exception(); }
        public GridDragZone(string id) { throw new Exception(); }
        public GridDragZone(object el, object config) { throw new Exception(); }
        public GridDragZone(string id, string sGroup) { throw new Exception(); }
        public GridDragZone(string id, string sGroup, object config) { throw new Exception(); }
        public void afterRepair() { throw new Exception(); }
        public void getDragData() { throw new Exception(); }
        public Array getRepairXY() { throw new Exception(); }
        public Array getRepairXY(EventObject e) { throw new Exception(); }
        public void onInitDrag() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static GridDragZone prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DragZone superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GridDragZoneConfig
    {
        // Methods
        public GridDragZoneConfig() { throw new Exception(); }

        // Properties
        public bool containerScroll { get; set; }
        public string ddGroup { get; set; }
        public string dropAllowed { get; set; }
        public string dropNotAllowed { get; set; }
        public string hlColor { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class GridPanel : Panel
    {
        // Methods
        public GridPanel() { throw new Exception(); }
        public GridPanel(Element config) { throw new Exception(); }
        public GridPanel(GridPanelConfig config) { throw new Exception(); }
        public GridPanel(object config) { throw new Exception(); }
        public GridPanel(string config) { throw new Exception(); }
        public void add() { throw new Exception(); }
        public void applyToMarkup() { throw new Exception(); }
        public void cascade() { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void doLayout() { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public void find() { throw new Exception(); }
        public void findBy() { throw new Exception(); }
        public void findById() { throw new Exception(); }
        public void findByType() { throw new Exception(); }
        public ColumnModel getColumnModel() { throw new Exception(); }
        public void getComponent() { throw new Exception(); }
        public string getDragDropText() { throw new Exception(); }
        public Element getGridEl() { throw new Exception(); }
        public void getLayout() { throw new Exception(); }
        public object getSelectionModel() { throw new Exception(); }
        public Store getStore() { throw new Exception(); }
        public void getUpdater() { throw new Exception(); }
        public GridView getView() { throw new Exception(); }
        public void insert() { throw new Exception(); }
        public void load() { throw new Exception(); }
        public void reconfigure() { throw new Exception(); }
        public void reconfigure(Store store) { throw new Exception(); }
        public void reconfigure(Store store, ColumnModel colModel) { throw new Exception(); }
        public void remove() { throw new Exception(); }
        public void setDisabled() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string autoExpandColumn { get; set; }
        [JsProperty(NativeField = true)]
        public double autoExpandMax { get; set; }
        [JsProperty(NativeField = true)]
        public double autoExpandMin { get; set; }
        [JsProperty(NativeField = true)]
        public Array bubbleEvents { get; set; }
        [JsProperty(NativeField = true)]
        public object cm { get; set; }
        [JsProperty(NativeField = true)]
        public object colModel { get; set; }
        [JsProperty(NativeField = true)]
        public bool columnLines { get; set; }
        [JsProperty(NativeField = true)]
        public Array columns { get; set; }
        [JsProperty(NativeField = true)]
        public string ddGroup { get; set; }
        [JsProperty(NativeField = true)]
        public string ddText { get; set; }
        [JsProperty(NativeField = true)]
        public bool deferRowRender { get; set; }
        [JsProperty(NativeField = true)]
        public bool disableSelection { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableColumnHide { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableColumnMove { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableColumnResize { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableDragDrop { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableHdMenu { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideHeaders { get; set; }
        [JsProperty(NativeField = true)]
        public object loadMask { get; set; }
        [JsProperty(NativeField = true)]
        public double maxHeight { get; set; }
        [JsProperty(NativeField = true)]
        public double minColumnWidth { get; set; }
        [JsProperty(NativeField = true)]
        public static GridPanel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object selModel { get; set; }
        [JsProperty(NativeField = true)]
        public object sm { get; set; }
        [JsProperty(NativeField = true)]
        public Array stateEvents { get; set; }
        [JsProperty(NativeField = true)]
        public Store store { get; set; }
        [JsProperty(NativeField = true)]
        public bool stripeRows { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel superclass { get; set; }
        [JsProperty(NativeField = true)]
        public bool trackMouseOver { get; set; }
        [JsProperty(NativeField = true)]
        public object view { get; set; }
        [JsProperty(NativeField = true)]
        public object viewConfig { get; set; }
    }

    public delegate void GridPanelBodyscrollDelegate(double scrollLeft, double scrollTop);

    public delegate void GridPanelCellclickDelegate(GridPanel objthis, double rowIndex, double columnIndex, EventObject e);

    public delegate void GridPanelCellcontextmenuDelegate(GridPanel objthis, double rowIndex, double cellIndex, EventObject e);

    public delegate void GridPanelCelldblclickDelegate(GridPanel objthis, double rowIndex, double columnIndex, EventObject e);

    public delegate void GridPanelCellmousedownDelegate(GridPanel objthis, double rowIndex, double columnIndex, EventObject e);

    public delegate void GridPanelClickDelegate(EventObject e);

    public delegate void GridPanelColumnmoveDelegate(double oldIndex, double newIndex);

    public delegate void GridPanelColumnresizeDelegate(double columnIndex, double newSize);

    [JsType(JsMode.Json)]
    public class GridPanelConfig
    {
        // Methods
        public GridPanelConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public string autoExpandColumn { get; set; }
        public double autoExpandMax { get; set; }
        public double autoExpandMin { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public object cm { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public object colModel { get; set; }
        public bool columnLines { get; set; }
        public Array columns { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string ddGroup { get; set; }
        public string ddText { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool deferRowRender { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableSelection { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public bool enableColumnHide { get; set; }
        public bool enableColumnMove { get; set; }
        public bool enableColumnResize { get; set; }
        public bool enableDragDrop { get; set; }
        public bool enableHdMenu { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideHeaders { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object loadMask { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double maxHeight { get; set; }
        public double minButtonWidth { get; set; }
        public double minColumnWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object selModel { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public object sm { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public Store store { get; set; }
        public bool stripeRows { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool trackMouseOver { get; set; }
        public bool unstyled { get; set; }
        public object view { get; set; }
        public object viewConfig { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void GridPanelContainerclickDelegate(GridPanel objthis, EventObject e);

    public delegate void GridPanelContainercontextmenuDelegate(GridPanel objthis, EventObject e);

    public delegate void GridPanelContainerdblclickDelegate(GridPanel objthis, EventObject e);

    public delegate void GridPanelContainermousedownDelegate(GridPanel objthis, EventObject e);

    public delegate void GridPanelContextmenuDelegate(EventObject e);

    public delegate void GridPanelDblclickDelegate(EventObject e);

    public class GridPanelEvents
    {
        // Methods
        public GridPanelEvents() { throw new Exception(); }

        // Properties
        public static string bodyscroll { get { throw new Exception(); } }
        public static string cellclick { get { throw new Exception(); } }
        public static string cellcontextmenu { get { throw new Exception(); } }
        public static string celldblclick { get { throw new Exception(); } }
        public static string cellmousedown { get { throw new Exception(); } }
        public static string click { get { throw new Exception(); } }
        public static string columnmove { get { throw new Exception(); } }
        public static string columnresize { get { throw new Exception(); } }
        public static string containerclick { get { throw new Exception(); } }
        public static string containercontextmenu { get { throw new Exception(); } }
        public static string containerdblclick { get { throw new Exception(); } }
        public static string containermousedown { get { throw new Exception(); } }
        public static string contextmenu { get { throw new Exception(); } }
        public static string dblclick { get { throw new Exception(); } }
        public static string groupclick { get { throw new Exception(); } }
        public static string groupcontextmenu { get { throw new Exception(); } }
        public static string groupdblclick { get { throw new Exception(); } }
        public static string groupmousedown { get { throw new Exception(); } }
        public static string headerclick { get { throw new Exception(); } }
        public static string headercontextmenu { get { throw new Exception(); } }
        public static string headerdblclick { get { throw new Exception(); } }
        public static string headermousedown { get { throw new Exception(); } }
        public static string keydown { get { throw new Exception(); } }
        public static string keypress { get { throw new Exception(); } }
        public static string mousedown { get { throw new Exception(); } }
        public static string mouseout { get { throw new Exception(); } }
        public static string mouseover { get { throw new Exception(); } }
        public static string mouseup { get { throw new Exception(); } }
        public static string reconfigure { get { throw new Exception(); } }
        public static string rowbodyclick { get { throw new Exception(); } }
        public static string rowbodycontextmenu { get { throw new Exception(); } }
        public static string rowbodydblclick { get { throw new Exception(); } }
        public static string rowbodymousedown { get { throw new Exception(); } }
        public static string rowclick { get { throw new Exception(); } }
        public static string rowcontextmenu { get { throw new Exception(); } }
        public static string rowdblclick { get { throw new Exception(); } }
        public static string rowmousedown { get { throw new Exception(); } }
        public static string sortchange { get { throw new Exception(); } }
        public static string viewready { get { throw new Exception(); } }
    }

    public delegate void GridPanelGroupclickDelegate(GridPanel objthis, string groupField, string groupValue, EventObject e);

    public delegate void GridPanelGroupcontextmenuDelegate(GridPanel objthis, string groupField, string groupValue, EventObject e);

    public delegate void GridPanelGroupdblclickDelegate(GridPanel objthis, string groupField, string groupValue, EventObject e);

    public delegate void GridPanelGroupmousedownDelegate(GridPanel objthis, string groupField, string groupValue, EventObject e);

    public delegate void GridPanelHeaderclickDelegate(GridPanel objthis, double columnIndex, EventObject e);

    public delegate void GridPanelHeadercontextmenuDelegate(GridPanel objthis, double columnIndex, EventObject e);

    public delegate void GridPanelHeaderdblclickDelegate(GridPanel objthis, double columnIndex, EventObject e);

    public delegate void GridPanelHeadermousedownDelegate(GridPanel objthis, double columnIndex, EventObject e);

    public delegate void GridPanelKeydownDelegate(EventObject e);

    public delegate void GridPanelKeypressDelegate(EventObject e);

    public delegate void GridPanelMousedownDelegate(EventObject e);

    public delegate void GridPanelMouseoutDelegate(EventObject e);

    public delegate void GridPanelMouseoverDelegate(EventObject e);

    public delegate void GridPanelMouseupDelegate(EventObject e);

    public delegate void GridPanelReconfigureDelegate(GridPanel objthis, Store store, ColumnModel colModel);

    public delegate void GridPanelRowbodyclickDelegate(GridPanel objthis, double rowIndex, EventObject e);

    public delegate void GridPanelRowbodycontextmenuDelegate(GridPanel objthis, double rowIndex, EventObject e);

    public delegate void GridPanelRowbodydblclickDelegate(GridPanel objthis, double rowIndex, EventObject e);

    public delegate void GridPanelRowbodymousedownDelegate(GridPanel objthis, double rowIndex, EventObject e);

    public delegate void GridPanelRowclickDelegate(GridPanel objthis, double rowIndex, EventObject e);

    public delegate void GridPanelRowcontextmenuDelegate(GridPanel objthis, double rowIndex, EventObject e);

    public delegate void GridPanelRowdblclickDelegate(GridPanel objthis, double rowIndex, EventObject e);

    public delegate void GridPanelRowmousedownDelegate(GridPanel objthis, double rowIndex, EventObject e);

    public delegate void GridPanelSortchangeDelegate(GridPanel objthis, object sortInfo);

    public delegate void GridPanelViewreadyDelegate(GridPanel objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class GridView : Observable
    {
        // Methods
        public GridView() { throw new Exception(); }
        public GridView(GridViewConfig config) { throw new Exception(); }
        public GridView(object config) { throw new Exception(); }
        public double findCellIndex() { throw new Exception(); }
        public double findCellIndex(HtmlElement el) { throw new Exception(); }
        public HtmlElement findRow() { throw new Exception(); }
        public HtmlElement findRow(HtmlElement el) { throw new Exception(); }
        public HtmlElement findRowBody() { throw new Exception(); }
        public HtmlElement findRowBody(HtmlElement el) { throw new Exception(); }
        public double findRowIndex() { throw new Exception(); }
        public double findRowIndex(HtmlElement el) { throw new Exception(); }
        public void focusCell() { throw new Exception(); }
        public void focusCell(double row) { throw new Exception(); }
        public void focusCell(double row, double col) { throw new Exception(); }
        public void focusRow() { throw new Exception(); }
        public void focusRow(double row) { throw new Exception(); }
        public HtmlElement getCell() { throw new Exception(); }
        public HtmlElement getCell(double row) { throw new Exception(); }
        public HtmlElement getCell(double row, double col) { throw new Exception(); }
        public HtmlElement getHeaderCell() { throw new Exception(); }
        public HtmlElement getHeaderCell(double index) { throw new Exception(); }
        public HtmlElement getRow() { throw new Exception(); }
        public HtmlElement getRow(double index) { throw new Exception(); }
        public string getRowClass() { throw new Exception(); }
        public string getRowClass(Record record) { throw new Exception(); }
        public string getRowClass(Record record, double index) { throw new Exception(); }
        public string getRowClass(Record record, double index, object rowParams) { throw new Exception(); }
        public string getRowClass(Record record, double index, object rowParams, Store store) { throw new Exception(); }
        public void refresh() { throw new Exception(); }
        public void refresh(bool headersToo) { throw new Exception(); }
        public void scrollToTop() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool autoFill { get; set; }
        [JsProperty(NativeField = true)]
        public string cellSelector { get; set; }
        [JsProperty(NativeField = true)]
        public double cellSelectorDepth { get; set; }
        [JsProperty(NativeField = true)]
        public string columnsText { get; set; }
        [JsProperty(NativeField = true)]
        public bool deferEmptyText { get; set; }
        [JsProperty(NativeField = true)]
        public GridDragZone dragZone { get; set; }
        [JsProperty(NativeField = true)]
        public string emptyText { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableRowBody { get; set; }
        [JsProperty(NativeField = true)]
        public bool forceFit { get; set; }
        [JsProperty(NativeField = true)]
        public bool headersDisabled { get; set; }
        [JsProperty(NativeField = true)]
        public Element mainBody { get; set; }
        [JsProperty(NativeField = true)]
        public static GridView prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string rowBodySelector { get; set; }
        [JsProperty(NativeField = true)]
        public double rowBodySelectorDepth { get; set; }
        [JsProperty(NativeField = true)]
        public string rowSelector { get; set; }
        [JsProperty(NativeField = true)]
        public double rowSelectorDepth { get; set; }
        [JsProperty(NativeField = true)]
        public double scrollOffset { get; set; }
        [JsProperty(NativeField = true)]
        public string selectedRowClass { get; set; }
        [JsProperty(NativeField = true)]
        public string sortAscText { get; set; }
        [JsProperty(NativeField = true)]
        public Array sortClasses { get; set; }
        [JsProperty(NativeField = true)]
        public string sortDescText { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void GridViewBeforerefreshDelegate(GridView view);

    public delegate void GridViewBeforerowremovedDelegate(GridView view, double rowIndex, Record record);

    public delegate void GridViewBeforerowsinsertedDelegate(GridView view, double firstRow, double lastRow);

    [JsType(JsMode.Json)]
    public class GridViewConfig
    {
        // Methods
        public GridViewConfig() { throw new Exception(); }

        // Properties
        public bool autoFill { get; set; }
        public string cellSelector { get; set; }
        public double cellSelectorDepth { get; set; }
        public string columnsText { get; set; }
        public bool deferEmptyText { get; set; }
        public string emptyText { get; set; }
        public bool enableRowBody { get; set; }
        public bool forceFit { get; set; }
        public bool headersDisabled { get; set; }
        public string rowBodySelector { get; set; }
        public double rowBodySelectorDepth { get; set; }
        public string rowSelector { get; set; }
        public double rowSelectorDepth { get; set; }
        public double scrollOffset { get; set; }
        public string selectedRowClass { get; set; }
        public string sortAscText { get; set; }
        public Array sortClasses { get; set; }
        public string sortDescText { get; set; }
    }

    public class GridViewEvents
    {
        // Methods
        public GridViewEvents() { throw new Exception(); }

        // Properties
        public static string beforerefresh { get { throw new Exception(); } }
        public static string beforerowremoved { get { throw new Exception(); } }
        public static string beforerowsinserted { get { throw new Exception(); } }
        public static string refresh { get { throw new Exception(); } }
        public static string rowremoved { get { throw new Exception(); } }
        public static string rowsinserted { get { throw new Exception(); } }
        public static string rowupdated { get { throw new Exception(); } }
    }

    public delegate void GridViewRefreshDelegate(GridView view);

    public delegate void GridViewRowremovedDelegate(GridView view, double rowIndex, Record record);

    public delegate void GridViewRowsinsertedDelegate(GridView view, double firstRow, double lastRow);

    public delegate void GridViewRowupdatedDelegate(GridView view, double firstRow, Record record);

    [JsType(JsMode.Prototype, Export = false)]
    public class GroupingView : GridView
    {
        // Methods
        public GroupingView() { throw new Exception(); }
        public GroupingView(GroupingViewConfig config) { throw new Exception(); }
        public GroupingView(object config) { throw new Exception(); }
        public void collapseAllGroups() { throw new Exception(); }
        public void expandAllGroups() { throw new Exception(); }
        public string getGroupId() { throw new Exception(); }
        public string getGroupId(string value) { throw new Exception(); }
        public void toggleAllGroups() { throw new Exception(); }
        public void toggleAllGroups(bool expanded) { throw new Exception(); }
        public void toggleGroup() { throw new Exception(); }
        public void toggleGroup(string groupId) { throw new Exception(); }
        public void toggleGroup(string groupId, bool expanded) { throw new Exception(); }
        public void toggleRowIndex() { throw new Exception(); }
        public void toggleRowIndex(double rowIndex) { throw new Exception(); }
        public void toggleRowIndex(double rowIndex, bool expanded) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string emptyGroupText { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableGrouping { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableGroupingMenu { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableNoGroups { get; set; }
        [JsProperty(NativeField = true)]
        public string groupByText { get; set; }
        [JsProperty(NativeField = true)]
        public string groupMode { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction groupRenderer { get; set; }
        [JsProperty(NativeField = true)]
        public string groupTextTpl { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideGroupedColumn { get; set; }
        [JsProperty(NativeField = true)]
        public bool ignoreAdd { get; set; }
        [JsProperty(NativeField = true)]
        public static GroupingView prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool showGroupName { get; set; }
        [JsProperty(NativeField = true)]
        public string showGroupsText { get; set; }
        [JsProperty(NativeField = true)]
        public bool startCollapsed { get; set; }
        [JsProperty(NativeField = true)]
        public static GridView superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GroupingViewConfig
    {
        // Methods
        public GroupingViewConfig() { throw new Exception(); }

        // Properties
        public bool autoFill { get; set; }
        public string cellSelector { get; set; }
        public double cellSelectorDepth { get; set; }
        public string columnsText { get; set; }
        public bool deferEmptyText { get; set; }
        public string emptyGroupText { get; set; }
        public string emptyText { get; set; }
        public bool enableGrouping { get; set; }
        public bool enableGroupingMenu { get; set; }
        public bool enableNoGroups { get; set; }
        public bool enableRowBody { get; set; }
        public bool forceFit { get; set; }
        public string groupByText { get; set; }
        public string groupMode { get; set; }
        public JsAction groupRenderer { get; set; }
        public string groupTextTpl { get; set; }
        public bool headersDisabled { get; set; }
        public bool hideGroupedColumn { get; set; }
        public bool ignoreAdd { get; set; }
        public string rowBodySelector { get; set; }
        public double rowBodySelectorDepth { get; set; }
        public string rowSelector { get; set; }
        public double rowSelectorDepth { get; set; }
        public double scrollOffset { get; set; }
        public string selectedRowClass { get; set; }
        public bool showGroupName { get; set; }
        public string showGroupsText { get; set; }
        public string sortAscText { get; set; }
        public Array sortClasses { get; set; }
        public string sortDescText { get; set; }
        public bool startCollapsed { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class NumberColumn : Column
    {
        // Methods
        public NumberColumn() { throw new Exception(); }
        public NumberColumn(NumberColumnConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string format { get; set; }
        [JsProperty(NativeField = true)]
        public static NumberColumn prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Column superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class NumberColumnConfig
    {
        // Methods
        public NumberColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string css { get; set; }
        public string dataIndex { get; set; }
        public bool editable { get; set; }
        public Ext.form.Field editor { get; set; }
        public string emptyGroupText { get; set; }
        public bool @fixed { get; set; }
        public string format { get; set; }
        public bool groupable { get; set; }
        public string groupName { get; set; }
        public JsAction groupRenderer { get; set; }
        public string header { get; set; }
        public bool hidden { get; set; }
        public bool hideable { get; set; }
        public string id { get; set; }
        public bool isColumn { get; set; }
        public bool menuDisabled { get; set; }
        public object renderer { get; set; }
        public bool resizable { get; set; }
        public object scope { get; set; }
        public bool sortable { get; set; }
        public string tooltip { get; set; }
        public double width { get; set; }
        public string xtype { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class PropertyColumnModel : ColumnModel
    {
        // Methods
        public PropertyColumnModel() { throw new Exception(); }
        public PropertyColumnModel(PropertyColumnModelConfig config) { throw new Exception(); }
        public PropertyColumnModel(object grid) { throw new Exception(); }
        public PropertyColumnModel(object grid, object source) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static PropertyColumnModel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ColumnModel superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PropertyColumnModelConfig
    {
        // Methods
        public PropertyColumnModelConfig() { throw new Exception(); }

        // Properties
        public Array columns { get; set; }
        public object defaults { get; set; }
        public bool defaultSortable { get; set; }
        public double defaultWidth { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class PropertyGrid : EditorGridPanel
    {
        // Methods
        public PropertyGrid() { throw new Exception(); }
        public PropertyGrid(Element config) { throw new Exception(); }
        public PropertyGrid(PropertyGridConfig config) { throw new Exception(); }
        public PropertyGrid(object config) { throw new Exception(); }
        public PropertyGrid(string config) { throw new Exception(); }
        public object getSource() { throw new Exception(); }
        public void setSource() { throw new Exception(); }
        public void setSource(object source) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object customEditors { get; set; }
        [JsProperty(NativeField = true)]
        public object propertyNames { get; set; }
        [JsProperty(NativeField = true)]
        public static PropertyGrid prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object source { get; set; }
        [JsProperty(NativeField = true)]
        public static EditorGridPanel superclass { get; set; }
    }

    public delegate void PropertyGridBeforepropertychangeDelegate(object source, string recordId, object value, object oldValue);

    [JsType(JsMode.Json)]
    public class PropertyGridConfig
    {
        // Methods
        public PropertyGridConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoEncode { get; set; }
        public string autoExpandColumn { get; set; }
        public double autoExpandMax { get; set; }
        public double autoExpandMin { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public double clicksToEdit { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public object cm { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public object colModel { get; set; }
        public bool columnLines { get; set; }
        public Array columns { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object customEditors { get; set; }
        public object data { get; set; }
        public string ddGroup { get; set; }
        public string ddText { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool deferRowRender { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool disableSelection { get; set; }
        public object draggable { get; set; }
        public string elements { get; set; }
        public bool enableColumnHide { get; set; }
        public bool enableColumnMove { get; set; }
        public bool enableColumnResize { get; set; }
        public bool enableDragDrop { get; set; }
        public bool enableHdMenu { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool forceValidation { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideHeaders { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object loadMask { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double maxHeight { get; set; }
        public double minButtonWidth { get; set; }
        public double minColumnWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public object propertyNames { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object selModel { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public object sm { get; set; }
        public object source { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public Store store { get; set; }
        public bool stripeRows { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool trackMouseOver { get; set; }
        public bool unstyled { get; set; }
        public object view { get; set; }
        public object viewConfig { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class PropertyGridEvents
    {
        // Methods
        public PropertyGridEvents() { throw new Exception(); }

        // Properties
        public static string beforepropertychange { get { throw new Exception(); } }
        public static string propertychange { get { throw new Exception(); } }
    }

    public delegate void PropertyGridPropertychangeDelegate(object source, string recordId, object value, object oldValue);

    [JsType(JsMode.Prototype, Export = false)]
    public class PropertyRecord
    {
        // Methods
        public PropertyRecord() { throw new Exception(); }
        public PropertyRecord(object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static PropertyRecord prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PropertyRecordConfig
    {
        // Methods
        public PropertyRecordConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class PropertyStore : Observable
    {
        // Methods
        public PropertyStore() { throw new Exception(); }
        public PropertyStore(object grid) { throw new Exception(); }
        public PropertyStore(object grid, object source) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static PropertyStore prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PropertyStoreConfig
    {
        // Methods
        public PropertyStoreConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class RowNumberer
    {
        // Methods
        public RowNumberer() { throw new Exception(); }
        public RowNumberer(RowNumbererConfig config) { throw new Exception(); }
        public RowNumberer(object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string header { get; set; }
        [JsProperty(NativeField = true)]
        public static RowNumberer prototype { get; set; }
        [JsProperty(NativeField = true)]
        public double width { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RowNumbererConfig
    {
        // Methods
        public RowNumbererConfig() { throw new Exception(); }

        // Properties
        public string header { get; set; }
        public double width { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class RowSelectionModel : AbstractSelectionModel
    {
        // Methods
        public RowSelectionModel() { throw new Exception(); }
        public RowSelectionModel(RowSelectionModelConfig config) { throw new Exception(); }
        public RowSelectionModel(object config) { throw new Exception(); }
        public void clearSelections() { throw new Exception(); }
        public void clearSelections(bool fast) { throw new Exception(); }
        public void deselectRange() { throw new Exception(); }
        public void deselectRange(double startRow) { throw new Exception(); }
        public void deselectRange(double startRow, double endRow) { throw new Exception(); }
        public void deselectRow() { throw new Exception(); }
        public void deselectRow(double row) { throw new Exception(); }
        public void deselectRow(double row, bool preventViewNotify) { throw new Exception(); }
        public bool each() { throw new Exception(); }
        public bool each(JsAction fn) { throw new Exception(); }
        public bool each(JsAction fn, object scope) { throw new Exception(); }
        public double getCount() { throw new Exception(); }
        public Record getSelected() { throw new Exception(); }
        public Array getSelections() { throw new Exception(); }
        public bool hasNext() { throw new Exception(); }
        public bool hasPrevious() { throw new Exception(); }
        public bool hasSelection() { throw new Exception(); }
        public bool isIdSelected() { throw new Exception(); }
        public bool isIdSelected(string id) { throw new Exception(); }
        public bool isSelected() { throw new Exception(); }
        public bool isSelected(Record index) { throw new Exception(); }
        public bool isSelected(double index) { throw new Exception(); }
        public void selectAll() { throw new Exception(); }
        public void selectFirstRow() { throw new Exception(); }
        public void selectLastRow() { throw new Exception(); }
        public void selectLastRow(bool keepExisting) { throw new Exception(); }
        public bool selectNext() { throw new Exception(); }
        public bool selectNext(bool keepExisting) { throw new Exception(); }
        public bool selectPrevious() { throw new Exception(); }
        public bool selectPrevious(bool keepExisting) { throw new Exception(); }
        public void selectRange() { throw new Exception(); }
        public void selectRange(double startRow) { throw new Exception(); }
        public void selectRange(double startRow, double endRow) { throw new Exception(); }
        public void selectRange(double startRow, double endRow, bool keepExisting) { throw new Exception(); }
        public void selectRecords() { throw new Exception(); }
        public void selectRecords(Array records) { throw new Exception(); }
        public void selectRecords(Array records, bool keepExisting) { throw new Exception(); }
        public void selectRow() { throw new Exception(); }
        public void selectRow(double row) { throw new Exception(); }
        public void selectRow(double row, bool keepExisting) { throw new Exception(); }
        public void selectRow(double row, bool keepExisting, bool preventViewNotify) { throw new Exception(); }
        public void selectRows() { throw new Exception(); }
        public void selectRows(Array rows) { throw new Exception(); }
        public void selectRows(Array rows, bool keepExisting) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool moveEditorOnEnter { get; set; }
        [JsProperty(NativeField = true)]
        public static RowSelectionModel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool singleSelect { get; set; }
        [JsProperty(NativeField = true)]
        public static AbstractSelectionModel superclass { get; set; }
    }

    public delegate void RowSelectionModelBeforerowselectDelegate(object objthis, double rowIndex, bool keepExisting, Record record);

    [JsType(JsMode.Json)]
    public class RowSelectionModelConfig
    {
        // Methods
        public RowSelectionModelConfig() { throw new Exception(); }

        // Properties
        public bool moveEditorOnEnter { get; set; }
        public bool singleSelect { get; set; }
    }

    public class RowSelectionModelEvents
    {
        // Methods
        public RowSelectionModelEvents() { throw new Exception(); }

        // Properties
        public static string beforerowselect { get { throw new Exception(); } }
        public static string rowdeselect { get { throw new Exception(); } }
        public static string rowselect { get { throw new Exception(); } }
        public static string selectionchange { get { throw new Exception(); } }
    }

    public delegate void RowSelectionModelRowdeselectDelegate(object objthis, double rowIndex, Record record);

    public delegate void RowSelectionModelRowselectDelegate(object objthis, double rowIndex, Record r);

    public delegate void RowSelectionModelSelectionchangeDelegate(object objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class TemplateColumn : Column
    {
        // Methods
        public TemplateColumn() { throw new Exception(); }
        public TemplateColumn(TemplateColumnConfig config) { throw new Exception(); }
        public void constructor() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static TemplateColumn prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Column superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TemplateColumnConfig
    {
        // Methods
        public TemplateColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string css { get; set; }
        public string dataIndex { get; set; }
        public bool editable { get; set; }
        public Ext.form.Field editor { get; set; }
        public string emptyGroupText { get; set; }
        public bool @fixed { get; set; }
        public bool groupable { get; set; }
        public string groupName { get; set; }
        public JsAction groupRenderer { get; set; }
        public string header { get; set; }
        public bool hidden { get; set; }
        public bool hideable { get; set; }
        public string id { get; set; }
        public bool isColumn { get; set; }
        public bool menuDisabled { get; set; }
        public object renderer { get; set; }
        public bool resizable { get; set; }
        public object scope { get; set; }
        public bool sortable { get; set; }
        public string tooltip { get; set; }
        public object tpl { get; set; }
        public double width { get; set; }
        public string xtype { get; set; }
    }
}


namespace Ext.layout
{
    [JsType(JsMode.Prototype, Export = false)]
    public class AbsoluteLayout : AnchorLayout
    {
        // Methods
        public AbsoluteLayout() { throw new Exception(); }
        public AbsoluteLayout(AbsoluteLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static AbsoluteLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static AnchorLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AbsoluteLayoutConfig
    {
        // Methods
        public AbsoluteLayoutConfig() { throw new Exception(); }

        // Properties
        public string anchor { get; set; }
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class AccordionLayout : FitLayout
    {
        // Methods
        public AccordionLayout() { throw new Exception(); }
        public AccordionLayout(AccordionLayoutConfig config) { throw new Exception(); }
        public void setActiveItem() { throw new Exception(); }
        public void setActiveItem(double item) { throw new Exception(); }
        public void setActiveItem(string item) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool activeOnTop { get; set; }
        [JsProperty(NativeField = true)]
        public bool animate { get; set; }
        [JsProperty(NativeField = true)]
        public bool autoWidth { get; set; }
        [JsProperty(NativeField = true)]
        public bool collapseFirst { get; set; }
        [JsProperty(NativeField = true)]
        public bool fill { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideCollapseTool { get; set; }
        [JsProperty(NativeField = true)]
        public static AccordionLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool sequence { get; set; }
        [JsProperty(NativeField = true)]
        public static FitLayout superclass { get; set; }
        [JsProperty(NativeField = true)]
        public bool titleCollapse { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AccordionLayoutConfig
    {
        // Methods
        public AccordionLayoutConfig() { throw new Exception(); }

        // Properties
        public bool activeOnTop { get; set; }
        public bool animate { get; set; }
        public bool autoWidth { get; set; }
        public bool collapseFirst { get; set; }
        public string extraCls { get; set; }
        public bool fill { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool renderHidden { get; set; }
        public bool sequence { get; set; }
        public bool titleCollapse { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class AnchorLayout : ContainerLayout
    {
        // Methods
        public AnchorLayout() { throw new Exception(); }
        public AnchorLayout(AnchorLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string anchor { get; set; }
        [JsProperty(NativeField = true)]
        public static AnchorLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AnchorLayoutConfig
    {
        // Methods
        public AnchorLayoutConfig() { throw new Exception(); }

        // Properties
        public string anchor { get; set; }
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class BorderLayout : ContainerLayout
    {
        // Methods
        public BorderLayout() { throw new Exception(); }
        public BorderLayout(BorderLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static BorderLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout superclass { get; set; }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Region
        {
            // Methods
            public Region() { throw new Exception(); }
            public Region(BorderLayout.RegionConfig config) { throw new Exception(); }
            public Region(object layout) { throw new Exception(); }
            public Region(object layout, object config) { throw new Exception(); }
            public Region(object layout, object config, string position) { throw new Exception(); }
            public object getMargins() { throw new Exception(); }
            public double getMinHeight() { throw new Exception(); }
            public double getMinWidth() { throw new Exception(); }
            public object getSize() { throw new Exception(); }
            public bool isVisible() { throw new Exception(); }
            public void setPanel() { throw new Exception(); }
            public void setPanel(Panel panel) { throw new Exception(); }
            public void slideIn() { throw new Exception(); }
            public void slideOut() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public bool animFloat { get; set; }
            [JsProperty(NativeField = true)]
            public bool autoHide { get; set; }
            [JsProperty(NativeField = true)]
            public object cmargins { get; set; }
            [JsProperty(NativeField = true)]
            public string collapseMode { get; set; }
            [JsProperty(NativeField = true)]
            public bool collapsible { get; set; }
            [JsProperty(NativeField = true)]
            public bool floatable { get; set; }
            [JsProperty(NativeField = true)]
            public bool isCollapsed { get; set; }
            [JsProperty(NativeField = true)]
            public object layout { get; set; }
            [JsProperty(NativeField = true)]
            public object margins { get; set; }
            [JsProperty(NativeField = true)]
            public double minHeight { get; set; }
            [JsProperty(NativeField = true)]
            public double minWidth { get; set; }
            [JsProperty(NativeField = true)]
            public Panel panel { get; set; }
            [JsProperty(NativeField = true)]
            public string position { get; set; }
            [JsProperty(NativeField = true)]
            public static BorderLayout.Region prototype { get; set; }
            [JsProperty(NativeField = true)]
            public bool split { get; set; }
        }

        [JsType(JsMode.Json)]
        public class RegionConfig
        {
            // Methods
            public RegionConfig() { throw new Exception(); }

            // Properties
            public bool animFloat { get; set; }
            public bool autoHide { get; set; }
            public object cmargins { get; set; }
            public string collapseMode { get; set; }
            public bool collapsible { get; set; }
            public bool floatable { get; set; }
            public object margins { get; set; }
            public double minHeight { get; set; }
            public double minWidth { get; set; }
            public bool split { get; set; }
        }

        [JsType(JsMode.Prototype, Export = false)]
        public class SplitRegion : BorderLayout.Region
        {
            // Methods
            public SplitRegion() { throw new Exception(); }
            public SplitRegion(BorderLayout.SplitRegionConfig config) { throw new Exception(); }
            public SplitRegion(object layout) { throw new Exception(); }
            public SplitRegion(object layout, object config) { throw new Exception(); }
            public SplitRegion(object layout, object config, string position) { throw new Exception(); }
            public SplitBar getSplitBar() { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public string collapsibleSplitTip { get; set; }
            [JsProperty(NativeField = true)]
            public static BorderLayout.SplitRegion prototype { get; set; }
            [JsProperty(NativeField = true)]
            public string splitTip { get; set; }
            [JsProperty(NativeField = true)]
            public static BorderLayout.Region superclass { get; set; }
            [JsProperty(NativeField = true)]
            public double tickSize { get; set; }
            [JsProperty(NativeField = true)]
            public bool useSplitTips { get; set; }
        }

        [JsType(JsMode.Json)]
        public class SplitRegionConfig
        {
            // Methods
            public SplitRegionConfig() { throw new Exception(); }

            // Properties
            public bool animFloat { get; set; }
            public bool autoHide { get; set; }
            public object cmargins { get; set; }
            public string collapseMode { get; set; }
            public bool collapsible { get; set; }
            public string collapsibleSplitTip { get; set; }
            public bool floatable { get; set; }
            public object margins { get; set; }
            public double minHeight { get; set; }
            public double minWidth { get; set; }
            public bool split { get; set; }
            public string splitTip { get; set; }
            public double tickSize { get; set; }
            public bool useSplitTips { get; set; }
        }
    }

    [JsType(JsMode.Json)]
    public class BorderLayoutConfig
    {
        // Methods
        public BorderLayoutConfig() { throw new Exception(); }

        // Properties
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class BoxLayout : ContainerLayout
    {
        // Methods
        public BoxLayout() { throw new Exception(); }
        public BoxLayout(BoxLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object defaultMargins { get; set; }
        [JsProperty(NativeField = true)]
        public string padding { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BoxLayoutConfig
    {
        // Methods
        public BoxLayoutConfig() { throw new Exception(); }

        // Properties
        public object defaultMargins { get; set; }
        public string extraCls { get; set; }
        public string padding { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CardLayout : FitLayout
    {
        // Methods
        public CardLayout() { throw new Exception(); }
        public CardLayout(CardLayoutConfig config) { throw new Exception(); }
        public void setActiveItem() { throw new Exception(); }
        public void setActiveItem(double item) { throw new Exception(); }
        public void setActiveItem(string item) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool deferredRender { get; set; }
        [JsProperty(NativeField = true)]
        public bool layoutOnCardChange { get; set; }
        [JsProperty(NativeField = true)]
        public static CardLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static FitLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CardLayoutConfig
    {
        // Methods
        public CardLayoutConfig() { throw new Exception(); }

        // Properties
        public bool deferredRender { get; set; }
        public string extraCls { get; set; }
        public bool layoutOnCardChange { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ColumnLayout : ContainerLayout
    {
        // Methods
        public ColumnLayout() { throw new Exception(); }
        public ColumnLayout(ColumnLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static ColumnLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ColumnLayoutConfig
    {
        // Methods
        public ColumnLayoutConfig() { throw new Exception(); }

        // Properties
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ContainerLayout
    {
        // Methods
        public ContainerLayout() { throw new Exception(); }
        public ContainerLayout(ContainerLayoutConfig config) { throw new Exception(); }
        public void fieldTpl() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public Component activeItem { get; set; }
        [JsProperty(NativeField = true)]
        public string extraCls { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ContainerLayoutConfig
    {
        // Methods
        public ContainerLayoutConfig() { throw new Exception(); }

        // Properties
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class FitLayout : ContainerLayout
    {
        // Methods
        public FitLayout() { throw new Exception(); }
        public FitLayout(FitLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static FitLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FitLayoutConfig
    {
        // Methods
        public FitLayoutConfig() { throw new Exception(); }

        // Properties
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class FormLayout : AnchorLayout
    {
        // Methods
        public FormLayout() { throw new Exception(); }
        public FormLayout(FormLayoutConfig config) { throw new Exception(); }
        public object getTemplateArgs() { throw new Exception(); }
        public object getTemplateArgs(object Ext_form_Field) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public Template fieldTpl { get; set; }
        [JsProperty(NativeField = true)]
        public string labelSeparator { get; set; }
        [JsProperty(NativeField = true)]
        public string labelStyle { get; set; }
        [JsProperty(NativeField = true)]
        public static FormLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static AnchorLayout superclass { get; set; }
        [JsProperty(NativeField = true)]
        public bool trackLabels { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FormLayoutConfig
    {
        // Methods
        public FormLayoutConfig() { throw new Exception(); }

        // Properties
        public string anchor { get; set; }
        public string extraCls { get; set; }
        public Template fieldTpl { get; set; }
        public string labelSeparator { get; set; }
        public bool renderHidden { get; set; }
        public bool trackLabels { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class HBoxLayout : BoxLayout
    {
        // Methods
        public HBoxLayout() { throw new Exception(); }
        public HBoxLayout(HBoxLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string align { get; set; }
        [JsProperty(NativeField = true)]
        public double flex { get; set; }
        [JsProperty(NativeField = true)]
        public string pack { get; set; }
        [JsProperty(NativeField = true)]
        public static HBoxLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HBoxLayoutConfig
    {
        // Methods
        public HBoxLayoutConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public object defaultMargins { get; set; }
        public string extraCls { get; set; }
        public double flex { get; set; }
        public string pack { get; set; }
        public string padding { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class MenuLayout : ContainerLayout
    {
        // Methods
        public MenuLayout() { throw new Exception(); }
        public MenuLayout(MenuLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static MenuLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class MenuLayoutConfig
    {
        // Methods
        public MenuLayoutConfig() { throw new Exception(); }

        // Properties
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TableLayout : ContainerLayout
    {
        // Methods
        public TableLayout() { throw new Exception(); }
        public TableLayout(TableLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public double columns { get; set; }
        [JsProperty(NativeField = true)]
        public static TableLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object tableAttrs { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TableLayoutConfig
    {
        // Methods
        public TableLayoutConfig() { throw new Exception(); }

        // Properties
        public double columns { get; set; }
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
        public object tableAttrs { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ToolbarLayout : ContainerLayout
    {
        // Methods
        public ToolbarLayout() { throw new Exception(); }
        public ToolbarLayout(ToolbarLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static ToolbarLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static ContainerLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ToolbarLayoutConfig
    {
        // Methods
        public ToolbarLayoutConfig() { throw new Exception(); }

        // Properties
        public string extraCls { get; set; }
        public bool renderHidden { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class VBoxLayout : BoxLayout
    {
        // Methods
        public VBoxLayout() { throw new Exception(); }
        public VBoxLayout(VBoxLayoutConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string align { get; set; }
        [JsProperty(NativeField = true)]
        public double flex { get; set; }
        [JsProperty(NativeField = true)]
        public string pack { get; set; }
        [JsProperty(NativeField = true)]
        public static VBoxLayout prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BoxLayout superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class VBoxLayoutConfig
    {
        // Methods
        public VBoxLayoutConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public object defaultMargins { get; set; }
        public string extraCls { get; set; }
        public double flex { get; set; }
        public string pack { get; set; }
        public string padding { get; set; }
        public bool renderHidden { get; set; }
    }
}


namespace Ext.list
{
    [JsType(JsMode.Prototype, Export = false)]
    public class BooleanColumn : Column
    {
        // Methods
        public BooleanColumn() { throw new Exception(); }
        public BooleanColumn(BooleanColumnConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string falseText { get; set; }
        [JsProperty(NativeField = true)]
        public static BooleanColumn prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Column superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string trueText { get; set; }
        [JsProperty(NativeField = true)]
        public string undefinedText { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BooleanColumnConfig
    {
        // Methods
        public BooleanColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string cls { get; set; }
        public string dataIndex { get; set; }
        public string falseText { get; set; }
        public string header { get; set; }
        public bool isColumn { get; set; }
        public string tpl { get; set; }
        public string trueText { get; set; }
        public string undefinedText { get; set; }
        public double width { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Column
    {
        // Methods
        public Column() { throw new Exception(); }
        public Column(ColumnConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string align { get; set; }
        [JsProperty(NativeField = true)]
        public string cls { get; set; }
        [JsProperty(NativeField = true)]
        public string dataIndex { get; set; }
        [JsProperty(NativeField = true)]
        public string header { get; set; }
        [JsProperty(NativeField = true)]
        public static Column prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string tpl { get; set; }
        [JsProperty(NativeField = true)]
        public double width { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ColumnConfig
    {
        // Methods
        public ColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string cls { get; set; }
        public string dataIndex { get; set; }
        public string header { get; set; }
        public bool isColumn { get; set; }
        public string tpl { get; set; }
        public double width { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ColumnResizer : Observable
    {
        // Methods
        public ColumnResizer() { throw new Exception(); }
        public ColumnResizer(ColumnResizerConfig config) { throw new Exception(); }
        public ColumnResizer(object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public double minPct { get; set; }
        [JsProperty(NativeField = true)]
        public static ColumnResizer prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ColumnResizerConfig
    {
        // Methods
        public ColumnResizerConfig() { throw new Exception(); }

        // Properties
        public double minPct { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DateColumn : Column
    {
        // Methods
        public DateColumn() { throw new Exception(); }
        public DateColumn(DateColumnConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DateColumn prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Column superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DateColumnConfig
    {
        // Methods
        public DateColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string cls { get; set; }
        public string dataIndex { get; set; }
        public string header { get; set; }
        public bool isColumn { get; set; }
        public string tpl { get; set; }
        public double width { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ListView : DataView
    {
        // Methods
        public ListView() { throw new Exception(); }
        public ListView(Element config) { throw new Exception(); }
        public ListView(ListViewConfig config) { throw new Exception(); }
        public ListView(object config) { throw new Exception(); }
        public ListView(string config) { throw new Exception(); }
        public object collectData() { throw new Exception(); }
        public object collectData(Array records) { throw new Exception(); }
        public object collectData(Array records, double startIndex) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object columnResize { get; set; }
        [JsProperty(NativeField = true)]
        public Array columns { get; set; }
        [JsProperty(NativeField = true)]
        public object columnSort { get; set; }
        [JsProperty(NativeField = true)]
        public bool disableHeaders { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideHeaders { get; set; }
        [JsProperty(NativeField = true)]
        public object internalTpl { get; set; }
        [JsProperty(NativeField = true)]
        public string itemSelector { get; set; }
        [JsProperty(NativeField = true)]
        public string overClass { get; set; }
        [JsProperty(NativeField = true)]
        public static ListView prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool reserveScrollOffset { get; set; }
        [JsProperty(NativeField = true)]
        public double scrollOffset { get; set; }
        [JsProperty(NativeField = true)]
        public string selectedClass { get; set; }
        [JsProperty(NativeField = true)]
        public static DataView superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ListViewConfig
    {
        // Methods
        public ListViewConfig() { throw new Exception(); }

        // Properties
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public object columnResize { get; set; }
        public Array columns { get; set; }
        public object columnSort { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool deferEmptyText { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string emptyText { get; set; }
        public string fieldLabel { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideHeaders { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public object internalTpl { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string itemSelector { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string loadingText { get; set; }
        public object margins { get; set; }
        public bool multiSelect { get; set; }
        public string overClass { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public bool reserveScrollOffset { get; set; }
        public double scrollOffset { get; set; }
        public string selectedClass { get; set; }
        public bool simpleSelect { get; set; }
        public bool singleSelect { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public Store store { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool trackOver { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class NumberColumn : Column
    {
        // Methods
        public NumberColumn() { throw new Exception(); }
        public NumberColumn(NumberColumnConfig config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string format { get; set; }
        [JsProperty(NativeField = true)]
        public static NumberColumn prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Column superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class NumberColumnConfig
    {
        // Methods
        public NumberColumnConfig() { throw new Exception(); }

        // Properties
        public string align { get; set; }
        public string cls { get; set; }
        public string dataIndex { get; set; }
        public string format { get; set; }
        public string header { get; set; }
        public bool isColumn { get; set; }
        public string tpl { get; set; }
        public double width { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Sorter : Observable
    {
        // Methods
        public Sorter() { throw new Exception(); }
        public Sorter(SorterConfig config) { throw new Exception(); }
        public Sorter(object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Sorter prototype { get; set; }
        [JsProperty(NativeField = true)]
        public Array sortClasses { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SorterConfig
    {
        // Methods
        public SorterConfig() { throw new Exception(); }

        // Properties
        public Array sortClasses { get; set; }
    }
}


namespace Ext.menu
{
    [JsType(JsMode.Prototype, Export = false)]
    public class BaseItem : Component
    {
        // Methods
        public BaseItem() { throw new Exception(); }
        public BaseItem(Element config) { throw new Exception(); }
        public BaseItem(BaseItemConfig config) { throw new Exception(); }
        public BaseItem(object config) { throw new Exception(); }
        public BaseItem(string config) { throw new Exception(); }
        public void setHandler() { throw new Exception(); }
        public void setHandler(JsAction handler) { throw new Exception(); }
        public void setHandler(JsAction handler, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string activeClass { get; set; }
        [JsProperty(NativeField = true)]
        public bool canActivate { get; set; }
        [JsProperty(NativeField = true)]
        public double clickHideDelay { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction handler { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideOnClick { get; set; }
        [JsProperty(NativeField = true)]
        public Menu parentMenu { get; set; }
        [JsProperty(NativeField = true)]
        public static BaseItem prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public static Component superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string text { get; set; }
    }

    public delegate void BaseItemActivateDelegate(BaseItem objthis);

    public delegate void BaseItemClickDelegate(BaseItem objthis, EventObject e);

    [JsType(JsMode.Json)]
    public class BaseItemConfig
    {
        // Methods
        public BaseItemConfig() { throw new Exception(); }

        // Properties
        public string activeClass { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public bool canActivate { get; set; }
        public string clearCls { get; set; }
        public double clickHideDelay { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public JsAction handler { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideOnClick { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string xtype { get; set; }
    }

    public delegate void BaseItemDeactivateDelegate(BaseItem objthis);

    public class BaseItemEvents
    {
        // Methods
        public BaseItemEvents() { throw new Exception(); }

        // Properties
        public static string activate { get { throw new Exception(); } }
        public static string click { get { throw new Exception(); } }
        public static string deactivate { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CheckItem : Item
    {
        // Methods
        public CheckItem() { throw new Exception(); }
        public CheckItem(Element config) { throw new Exception(); }
        public CheckItem(CheckItemConfig config) { throw new Exception(); }
        public CheckItem(object config) { throw new Exception(); }
        public CheckItem(string config) { throw new Exception(); }
        public void checkHandler() { throw new Exception(); }
        public void checkHandler(CheckItem objthis) { throw new Exception(); }
        public void checkHandler(CheckItem objthis, bool chckd) { throw new Exception(); }
        public void setChecked() { throw new Exception(); }
        public void setChecked(bool chckd) { throw new Exception(); }
        public void setChecked(bool chckd, bool suppressEvent) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool checked_ { get; set; }
        [JsProperty(NativeField = true)]
        public string group { get; set; }
        [JsProperty(NativeField = true)]
        public string groupClass { get; set; }
        [JsProperty(NativeField = true)]
        public string itemCls { get; set; }
        [JsProperty(NativeField = true)]
        public static CheckItem prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Item superclass { get; set; }
    }

    public delegate void CheckItemBeforecheckchangeDelegate(CheckItem objthis, bool chckd);

    public delegate void CheckItemCheckchangeDelegate(CheckItem objthis, bool chckd);

    [JsType(JsMode.Json)]
    public class CheckItemConfig
    {
        // Methods
        public CheckItemConfig() { throw new Exception(); }

        // Properties
        public string activeClass { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public bool canActivate { get; set; }
        public bool @checked { get; set; }
        public string clearCls { get; set; }
        public double clickHideDelay { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public string group { get; set; }
        public string groupClass { get; set; }
        public JsAction handler { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideOnClick { get; set; }
        public bool hideParent { get; set; }
        public string href { get; set; }
        public string hrefTarget { get; set; }
        public object html { get; set; }
        public string icon { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object menu { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public double showDelay { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string text { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string xtype { get; set; }
    }

    public class CheckItemEvents
    {
        // Methods
        public CheckItemEvents() { throw new Exception(); }

        // Properties
        public static string beforecheckchange { get { throw new Exception(); } }
        public static string checkchange { get { throw new Exception(); } }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ColorMenu : Menu
    {
        // Methods
        public ColorMenu() { throw new Exception(); }
        public ColorMenu(Element config) { throw new Exception(); }
        public ColorMenu(ColorMenuConfig config) { throw new Exception(); }
        public ColorMenu(object config) { throw new Exception(); }
        public ColorMenu(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public JsAction handler { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideOnClick { get; set; }
        [JsProperty(NativeField = true)]
        public ColorPalette palette { get; set; }
        [JsProperty(NativeField = true)]
        public string paletteId { get; set; }
        [JsProperty(NativeField = true)]
        public static ColorMenu prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public static Menu superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ColorMenuConfig
    {
        // Methods
        public ColorMenuConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public bool allowOtherMenus { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string defaultAlign { get; set; }
        public Array defaultOffsets { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool enableScrolling { get; set; }
        public string fieldLabel { get; set; }
        public bool floating { get; set; }
        public JsAction handler { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideOnClick { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public bool ignoreParentClicks { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public double maxHeight { get; set; }
        public double minWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public string paletteId { get; set; }
        public bool plain { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public double scrollIncrement { get; set; }
        public object shadow { get; set; }
        public bool showSeparator { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string subMenuAlign { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class ColorMenuEvents
    {
        // Methods
        public ColorMenuEvents() { throw new Exception(); }

        // Properties
        public static string select { get { throw new Exception(); } }
    }

    public delegate void ColorMenuSelectDelegate(ColorPalette palette, string color);

    [JsType(JsMode.Prototype, Export = false)]
    public class DateMenu : Menu
    {
        // Methods
        public DateMenu() { throw new Exception(); }
        public DateMenu(Element config) { throw new Exception(); }
        public DateMenu(DateMenuConfig config) { throw new Exception(); }
        public DateMenu(object config) { throw new Exception(); }
        public DateMenu(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public JsAction handler { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideOnClick { get; set; }
        [JsProperty(NativeField = true)]
        public DatePicker picker { get; set; }
        [JsProperty(NativeField = true)]
        public string pickerId { get; set; }
        [JsProperty(NativeField = true)]
        public static DateMenu prototype { get; set; }
        [JsProperty(NativeField = true)]
        public object scope { get; set; }
        [JsProperty(NativeField = true)]
        public static Menu superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DateMenuConfig
    {
        // Methods
        public DateMenuConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public bool allowOtherMenus { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string defaultAlign { get; set; }
        public Array defaultOffsets { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool enableScrolling { get; set; }
        public string fieldLabel { get; set; }
        public bool floating { get; set; }
        public JsAction handler { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideOnClick { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public bool ignoreParentClicks { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public double maxHeight { get; set; }
        public double minWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public string pickerId { get; set; }
        public bool plain { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public double scrollIncrement { get; set; }
        public object shadow { get; set; }
        public bool showSeparator { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string subMenuAlign { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class DateMenuEvents
    {
        // Methods
        public DateMenuEvents() { throw new Exception(); }

        // Properties
        public static string select { get { throw new Exception(); } }
    }

    public delegate void DateMenuSelectDelegate(DatePicker picker, DateTime date);

    [JsType(JsMode.Prototype, Export = false)]
    public class Item : BaseItem
    {
        // Methods
        public Item() { throw new Exception(); }
        public Item(Element config) { throw new Exception(); }
        public Item(ItemConfig config) { throw new Exception(); }
        public Item(object config) { throw new Exception(); }
        public Item(string config) { throw new Exception(); }
        public void setIconClass() { throw new Exception(); }
        public void setIconClass(string cls) { throw new Exception(); }
        public void setText() { throw new Exception(); }
        public void setText(string text) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool canActivate { get; set; }
        [JsProperty(NativeField = true)]
        public string href { get; set; }
        [JsProperty(NativeField = true)]
        public string hrefTarget { get; set; }
        [JsProperty(NativeField = true)]
        public string icon { get; set; }
        [JsProperty(NativeField = true)]
        public string iconCls { get; set; }
        [JsProperty(NativeField = true)]
        public string itemCls { get; set; }
        [JsProperty(NativeField = true)]
        public Menu menu { get; set; }
        [JsProperty(NativeField = true)]
        public static Item prototype { get; set; }
        [JsProperty(NativeField = true)]
        public double showDelay { get; set; }
        [JsProperty(NativeField = true)]
        public static BaseItem superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string text { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ItemConfig
    {
        // Methods
        public ItemConfig() { throw new Exception(); }

        // Properties
        public string activeClass { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public bool canActivate { get; set; }
        public string clearCls { get; set; }
        public double clickHideDelay { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public JsAction handler { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideOnClick { get; set; }
        public bool hideParent { get; set; }
        public string href { get; set; }
        public string hrefTarget { get; set; }
        public object html { get; set; }
        public string icon { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object menu { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public double showDelay { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string text { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string xtype { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Menu : Container
    {
        // Methods
        public Menu() { throw new Exception(); }
        public Menu(Element config) { throw new Exception(); }
        public Menu(MenuConfig config) { throw new Exception(); }
        public Menu(object config) { throw new Exception(); }
        public Menu(string config) { throw new Exception(); }
        public Item addElement() { throw new Exception(); }
        public Item addElement(object el) { throw new Exception(); }
        public Item addItem() { throw new Exception(); }
        public Item addItem(Item item) { throw new Exception(); }
        public Item addMenuItem() { throw new Exception(); }
        public Item addMenuItem(object config) { throw new Exception(); }
        public Item addSeparator() { throw new Exception(); }
        public Item addText() { throw new Exception(); }
        public Item addText(string text) { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public void hide(bool deep) { throw new Exception(); }
        public void show() { throw new Exception(); }
        public void show(object element) { throw new Exception(); }
        public void show(object element, string position) { throw new Exception(); }
        public void show(object element, string position, Menu parentMenu) { throw new Exception(); }
        public void showAt() { throw new Exception(); }
        public void showAt(Array xyPosition) { throw new Exception(); }
        public void showAt(Array xyPosition, Menu parentMenu) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowOtherMenus { get; set; }
        [JsProperty(NativeField = true)]
        public string defaultAlign { get; set; }
        [JsProperty(NativeField = true)]
        public Array defaultOffsets { get; set; }
        [JsProperty(NativeField = true)]
        public object defaults { get; set; }
        [JsProperty(NativeField = true)]
        public bool enableScrolling { get; set; }
        [JsProperty(NativeField = true)]
        public bool floating { get; set; }
        [JsProperty(NativeField = true)]
        public bool ignoreParentClicks { get; set; }
        [JsProperty(NativeField = true)]
        public object items { get; set; }
        [JsProperty(NativeField = true)]
        public object layout { get; set; }
        [JsProperty(NativeField = true)]
        public double maxHeight { get; set; }
        [JsProperty(NativeField = true)]
        public double minWidth { get; set; }
        [JsProperty(NativeField = true)]
        public bool plain { get; set; }
        [JsProperty(NativeField = true)]
        public static Menu prototype { get; set; }
        [JsProperty(NativeField = true)]
        public double scrollIncrement { get; set; }
        [JsProperty(NativeField = true)]
        public object shadow { get; set; }
        [JsProperty(NativeField = true)]
        public bool showSeparator { get; set; }
        [JsProperty(NativeField = true)]
        public string subMenuAlign { get; set; }
        [JsProperty(NativeField = true)]
        public static Container superclass { get; set; }
    }

    public delegate void MenuClickDelegate(Menu objthis, Item menuItem, EventObject e);

    [JsType(JsMode.Json)]
    public class MenuConfig
    {
        // Methods
        public MenuConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public bool allowOtherMenus { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public string defaultAlign { get; set; }
        public Array defaultOffsets { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public bool enableScrolling { get; set; }
        public string fieldLabel { get; set; }
        public bool floating { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public bool ignoreParentClicks { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public object margins { get; set; }
        public double maxHeight { get; set; }
        public double minWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public bool plain { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public double scrollIncrement { get; set; }
        public object shadow { get; set; }
        public bool showSeparator { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string subMenuAlign { get; set; }
        public string tabTip { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public class MenuEvents
    {
        // Methods
        public MenuEvents() { throw new Exception(); }

        // Properties
        public static string click { get { throw new Exception(); } }
        public static string itemclick { get { throw new Exception(); } }
        public static string mouseout { get { throw new Exception(); } }
        public static string mouseover { get { throw new Exception(); } }
    }

    public delegate void MenuItemclickDelegate(BaseItem baseItem, EventObject e);

    [JsType(JsMode.Prototype, Export = false)]
    public class MenuMgr
    {
        // Methods
        public MenuMgr() { throw new Exception(); }
        public static Menu get() { throw new Exception(); }
        public static Menu get(object menu) { throw new Exception(); }
        public static Menu get(string menu) { throw new Exception(); }
        public static bool hideAll() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static MenuMgr prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class MenuMgrConfig
    {
        // Methods
        public MenuMgrConfig() { throw new Exception(); }
    }

    public delegate void MenuMouseoutDelegate(Menu objthis, EventObject e, Item menuItem);

    public delegate void MenuMouseoverDelegate(Menu objthis, EventObject e, Item menuItem);

    [JsType(JsMode.Prototype, Export = false)]
    public class Separator : BaseItem
    {
        // Methods
        public Separator() { throw new Exception(); }
        public Separator(Element config) { throw new Exception(); }
        public Separator(SeparatorConfig config) { throw new Exception(); }
        public Separator(object config) { throw new Exception(); }
        public Separator(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool hideOnClick { get; set; }
        [JsProperty(NativeField = true)]
        public string itemCls { get; set; }
        [JsProperty(NativeField = true)]
        public static Separator prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BaseItem superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SeparatorConfig
    {
        // Methods
        public SeparatorConfig() { throw new Exception(); }

        // Properties
        public string activeClass { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public bool canActivate { get; set; }
        public string clearCls { get; set; }
        public double clickHideDelay { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public JsAction handler { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideOnClick { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string xtype { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TextItem : BaseItem
    {
        // Methods
        public TextItem() { throw new Exception(); }
        public TextItem(Element config) { throw new Exception(); }
        public TextItem(TextItemConfig config) { throw new Exception(); }
        public TextItem(object config) { throw new Exception(); }
        public TextItem(string config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool hideOnClick { get; set; }
        [JsProperty(NativeField = true)]
        public string itemCls { get; set; }
        [JsProperty(NativeField = true)]
        public static TextItem prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static BaseItem superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string text { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TextItemConfig
    {
        // Methods
        public TextItemConfig() { throw new Exception(); }

        // Properties
        public string activeClass { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public bool canActivate { get; set; }
        public string clearCls { get; set; }
        public double clickHideDelay { get; set; }
        public string cls { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public string fieldLabel { get; set; }
        public JsAction handler { get; set; }
        public bool hidden { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideOnClick { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public object scope { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string text { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public string xtype { get; set; }
    }
}


namespace Ext.state
{
    [JsType(JsMode.Prototype, Export = false)]
    public class CookieProvider : Provider
    {
        // Methods
        public CookieProvider() { throw new Exception(); }
        public CookieProvider(CookieProviderConfig config) { throw new Exception(); }
        public CookieProvider(object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static CookieProvider prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Provider superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CookieProviderConfig
    {
        // Methods
        public CookieProviderConfig() { throw new Exception(); }

        // Properties
        public string domain { get; set; }
        public DateTime expires { get; set; }
        public string path { get; set; }
        public bool secure { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Manager
    {
        // Methods
        public Manager() { throw new Exception(); }
        public static void clear() { throw new Exception(); }
        public static void clear(string name) { throw new Exception(); }
        public static object get() { throw new Exception(); }
        public static object get(string name) { throw new Exception(); }
        public static object get(string name, object defaultValue) { throw new Exception(); }
        public static Provider getProvider() { throw new Exception(); }
        public static void set() { throw new Exception(); }
        public static void set(string name) { throw new Exception(); }
        public static void set(string name, object value) { throw new Exception(); }
        public static void setProvider() { throw new Exception(); }
        public static void setProvider(Provider stateProvider) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Manager prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ManagerConfig
    {
        // Methods
        public ManagerConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Provider
    {
        // Methods
        public Provider() { throw new Exception(); }
        public void clear() { throw new Exception(); }
        public void clear(string name) { throw new Exception(); }
        public object decodeValue() { throw new Exception(); }
        public object decodeValue(string value) { throw new Exception(); }
        public string encodeValue() { throw new Exception(); }
        public string encodeValue(object value) { throw new Exception(); }
        public object get() { throw new Exception(); }
        public object get(string name) { throw new Exception(); }
        public object get(string name, object defaultValue) { throw new Exception(); }
        public void set() { throw new Exception(); }
        public void set(string name) { throw new Exception(); }
        public void set(string name, object value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Provider prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ProviderConfig
    {
        // Methods
        public ProviderConfig() { throw new Exception(); }
    }

    public class ProviderEvents
    {
        // Methods
        public ProviderEvents() { throw new Exception(); }

        // Properties
        public static string statechange { get { throw new Exception(); } }
    }

    public delegate void ProviderStatechangeDelegate(Provider objthis, string key, string value);
}


namespace Ext.tree
{
    [JsType(JsMode.Prototype, Export = false)]
    public class AsyncTreeNode : TreeNode
    {
        // Methods
        public AsyncTreeNode() { throw new Exception(); }
        public AsyncTreeNode(AsyncTreeNodeConfig config) { throw new Exception(); }
        public AsyncTreeNode(object attributes) { throw new Exception(); }
        public AsyncTreeNode(string attributes) { throw new Exception(); }
        public bool isLoaded() { throw new Exception(); }
        public bool isLoading() { throw new Exception(); }
        public void reload() { throw new Exception(); }
        public void reload(JsAction callback) { throw new Exception(); }
        public void reload(JsAction callback, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public TreeLoader loader { get; set; }
        [JsProperty(NativeField = true)]
        public static AsyncTreeNode prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static TreeNode superclass { get; set; }
    }

    public delegate void AsyncTreeNodeBeforeloadDelegate(Node objthis);

    [JsType(JsMode.Json)]
    public class AsyncTreeNodeConfig
    {
        // Methods
        public AsyncTreeNodeConfig() { throw new Exception(); }

        // Properties
        public bool allowChildren { get; set; }
        public bool allowDrag { get; set; }
        public bool allowDrop { get; set; }
        public bool @checked { get; set; }
        public string cls { get; set; }
        public bool disabled { get; set; }
        public bool draggable { get; set; }
        public bool editable { get; set; }
        public bool expandable { get; set; }
        public bool expanded { get; set; }
        public bool hidden { get; set; }
        public string href { get; set; }
        public string hrefTarget { get; set; }
        public string icon { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public bool isTarget { get; set; }
        public bool leaf { get; set; }
        public TreeLoader loader { get; set; }
        public string qtip { get; set; }
        public string qtipCfg { get; set; }
        public bool singleClickExpand { get; set; }
        public string text { get; set; }
        public JsAction uiProvider { get; set; }
    }

    public class AsyncTreeNodeEvents
    {
        // Methods
        public AsyncTreeNodeEvents() { throw new Exception(); }

        // Properties
        public static string beforeload { get { throw new Exception(); } }
        public static string load { get { throw new Exception(); } }
    }

    public delegate void AsyncTreeNodeLoadDelegate(Node objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class DefaultSelectionModel : Observable
    {
        // Methods
        public DefaultSelectionModel() { throw new Exception(); }
        public void clearSelections() { throw new Exception(); }
        public void clearSelections(bool silent) { throw new Exception(); }
        public TreeNode getSelectedNode() { throw new Exception(); }
        public bool isSelected() { throw new Exception(); }
        public bool isSelected(TreeNode node) { throw new Exception(); }
        public TreeNode select() { throw new Exception(); }
        public TreeNode select(TreeNode node) { throw new Exception(); }
        public TreeNode selectNext() { throw new Exception(); }
        public TreeNode selectPrevious() { throw new Exception(); }
        public void unselect() { throw new Exception(); }
        public void unselect(TreeNode node) { throw new Exception(); }
        public void unselect(TreeNode node, bool silent) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DefaultSelectionModel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void DefaultSelectionModelBeforeselectDelegate(DefaultSelectionModel objthis, TreeNode node, TreeNode node2);

    [JsType(JsMode.Json)]
    public class DefaultSelectionModelConfig
    {
        // Methods
        public DefaultSelectionModelConfig() { throw new Exception(); }
    }

    public class DefaultSelectionModelEvents
    {
        // Methods
        public DefaultSelectionModelEvents() { throw new Exception(); }

        // Properties
        public static string beforeselect { get { throw new Exception(); } }
        public static string selectionchange { get { throw new Exception(); } }
    }

    public delegate void DefaultSelectionModelSelectionchangeDelegate(DefaultSelectionModel objthis, TreeNode node);

    [JsType(JsMode.Prototype, Export = false)]
    public class MultiSelectionModel : Observable
    {
        // Methods
        public MultiSelectionModel() { throw new Exception(); }
        public void clearSelections() { throw new Exception(); }
        public Array getSelectedNodes() { throw new Exception(); }
        public bool isSelected() { throw new Exception(); }
        public bool isSelected(TreeNode node) { throw new Exception(); }
        public TreeNode select() { throw new Exception(); }
        public TreeNode select(TreeNode node) { throw new Exception(); }
        public TreeNode select(TreeNode node, EventObject e) { throw new Exception(); }
        public TreeNode select(TreeNode node, EventObject e, bool keepExisting) { throw new Exception(); }
        public void unselect() { throw new Exception(); }
        public void unselect(TreeNode node) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static MultiSelectionModel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class MultiSelectionModelConfig
    {
        // Methods
        public MultiSelectionModelConfig() { throw new Exception(); }
    }

    public class MultiSelectionModelEvents
    {
        // Methods
        public MultiSelectionModelEvents() { throw new Exception(); }

        // Properties
        public static string selectionchange { get { throw new Exception(); } }
    }

    public delegate void MultiSelectionModelSelectionchangeDelegate(MultiSelectionModel objthis, Array nodes);

    [JsType(JsMode.Prototype, Export = false)]
    public class RootTreeNodeUI
    {
        // Methods
        public RootTreeNodeUI() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static RootTreeNodeUI prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RootTreeNodeUIConfig
    {
        // Methods
        public RootTreeNodeUIConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TreeDragZone : DragZone
    {
        // Methods
        public TreeDragZone() { throw new Exception(); }
        public TreeDragZone(Element tree) { throw new Exception(); }
        public TreeDragZone(TreeDragZoneConfig config) { throw new Exception(); }
        public TreeDragZone(HtmlElement tree) { throw new Exception(); }
        public TreeDragZone(object el) { throw new Exception(); }
        public TreeDragZone(string tree) { throw new Exception(); }
        public TreeDragZone(Element tree, object config) { throw new Exception(); }
        public TreeDragZone(HtmlElement tree, object config) { throw new Exception(); }
        public TreeDragZone(object el, object config) { throw new Exception(); }
        public TreeDragZone(string tree, object config) { throw new Exception(); }
        public TreeDragZone(string id, string sGroup) { throw new Exception(); }
        public TreeDragZone(string id, string sGroup, object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string ddGroup { get; set; }
        [JsProperty(NativeField = true)]
        public static TreeDragZone prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DragZone superclass { get; set; }
        [JsProperty(NativeField = true)]
        public TreePanel tree { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeDragZoneConfig
    {
        // Methods
        public TreeDragZoneConfig() { throw new Exception(); }

        // Properties
        public bool containerScroll { get; set; }
        public string ddGroup { get; set; }
        public string dropAllowed { get; set; }
        public string dropNotAllowed { get; set; }
        public string hlColor { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TreeDropZone : DropZone
    {
        // Methods
        public TreeDropZone() { throw new Exception(); }
        public TreeDropZone(Element tree) { throw new Exception(); }
        public TreeDropZone(TreeDropZoneConfig config) { throw new Exception(); }
        public TreeDropZone(HtmlElement tree) { throw new Exception(); }
        public TreeDropZone(object el) { throw new Exception(); }
        public TreeDropZone(string tree) { throw new Exception(); }
        public TreeDropZone(Element tree, object config) { throw new Exception(); }
        public TreeDropZone(HtmlElement tree, object config) { throw new Exception(); }
        public TreeDropZone(object el, object config) { throw new Exception(); }
        public TreeDropZone(string tree, object config) { throw new Exception(); }
        public TreeDropZone(string id, string sGroup) { throw new Exception(); }
        public TreeDropZone(string id, string sGroup, object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string allowContainerDrop { get; set; }
        [JsProperty(NativeField = true)]
        public bool allowParentInsert { get; set; }
        [JsProperty(NativeField = true)]
        public string appendOnly { get; set; }
        [JsProperty(NativeField = true)]
        public string ddGroup { get; set; }
        [JsProperty(NativeField = true)]
        public TreePanel dragOverData { get; set; }
        [JsProperty(NativeField = true)]
        public string expandDelay { get; set; }
        [JsProperty(NativeField = true)]
        public static TreeDropZone prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static DropZone superclass { get; set; }
        [JsProperty(NativeField = true)]
        public TreePanel tree { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeDropZoneConfig
    {
        // Methods
        public TreeDropZoneConfig() { throw new Exception(); }

        // Properties
        public string allowContainerDrop { get; set; }
        public bool allowParentInsert { get; set; }
        public string appendOnly { get; set; }
        public string ddGroup { get; set; }
        public string dropAllowed { get; set; }
        public string dropNotAllowed { get; set; }
        public string expandDelay { get; set; }
        public string overClass { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TreeEditor : Editor
    {
        // Methods
        public TreeEditor() { throw new Exception(); }
        public TreeEditor(Element config) { throw new Exception(); }
        public TreeEditor(TreeEditorConfig config) { throw new Exception(); }
        public TreeEditor(TreePanel tree) { throw new Exception(); }
        public TreeEditor(object config) { throw new Exception(); }
        public TreeEditor(string config) { throw new Exception(); }
        public TreeEditor(TreePanel tree, object fieldConfig) { throw new Exception(); }
        public TreeEditor(TreePanel tree, object fieldConfig, object config) { throw new Exception(); }
        public void triggerEdit() { throw new Exception(); }
        public void triggerEdit(object node) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public string alignment { get; set; }
        [JsProperty(NativeField = true)]
        public string cls { get; set; }
        [JsProperty(NativeField = true)]
        public double editDelay { get; set; }
        [JsProperty(NativeField = true)]
        public TreeNode editNode { get; set; }
        [JsProperty(NativeField = true)]
        public bool hideEl { get; set; }
        [JsProperty(NativeField = true)]
        public double maxWidth { get; set; }
        [JsProperty(NativeField = true)]
        public static TreeEditor prototype { get; set; }
        [JsProperty(NativeField = true)]
        public bool shim { get; set; }
        [JsProperty(NativeField = true)]
        public static Editor superclass { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeEditorConfig
    {
        // Methods
        public TreeEditorConfig() { throw new Exception(); }

        // Properties
        public string alignment { get; set; }
        public bool allowBlur { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoShow { get; set; }
        public object autoSize { get; set; }
        public bool cancelOnEsc { get; set; }
        public string clearCls { get; set; }
        public string cls { get; set; }
        public bool completeOnEnter { get; set; }
        public bool constrain { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public double editDelay { get; set; }
        public Ext.form.Field field { get; set; }
        public string fieldLabel { get; set; }
        public bool hidden { get; set; }
        public bool hideEl { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public object html { get; set; }
        public string id { get; set; }
        public bool ignoreNoChange { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public double maxWidth { get; set; }
        public Array offsets { get; set; }
        public string overCls { get; set; }
        public object plugins { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public object renderTo { get; set; }
        public bool revertInvalid { get; set; }
        public object shadow { get; set; }
        public bool shim { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public bool swallowKeys { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool updateEl { get; set; }
        public object value { get; set; }
        public string xtype { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TreeFilter
    {
        // Methods
        public TreeFilter() { throw new Exception(); }
        public void clear() { throw new Exception(); }
        public void filter() { throw new Exception(); }
        public void filter(object value) { throw new Exception(); }
        public void filter(string value) { throw new Exception(); }
        public void filter(object value, string attr) { throw new Exception(); }
        public void filter(string value, string attr) { throw new Exception(); }
        public void filter(object value, string attr, TreeNode startNode) { throw new Exception(); }
        public void filter(string value, string attr, TreeNode startNode) { throw new Exception(); }
        public void filterBy() { throw new Exception(); }
        public void filterBy(JsAction fn) { throw new Exception(); }
        public void filterBy(JsAction fn, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static TreeFilter prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeFilterConfig
    {
        // Methods
        public TreeFilterConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TreeLoader : Observable
    {
        // Methods
        public TreeLoader() { throw new Exception(); }
        public TreeLoader(TreeLoaderConfig config) { throw new Exception(); }
        public TreeLoader(object config) { throw new Exception(); }
        public void createNode() { throw new Exception(); }
        public void createNode(object attr) { throw new Exception(); }
        public void load() { throw new Exception(); }
        public void load(TreeNode node) { throw new Exception(); }
        public void load(TreeNode node, JsAction callback) { throw new Exception(); }
        public void load(TreeNode node, JsAction callback, object Object) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object baseAttrs { get; set; }
        [JsProperty(NativeField = true)]
        public object baseParams { get; set; }
        [JsProperty(NativeField = true)]
        public bool clearOnLoad { get; set; }
        [JsProperty(NativeField = true)]
        public string dataUrl { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction directFn { get; set; }
        [JsProperty(NativeField = true)]
        public string nodeParameter { get; set; }
        [JsProperty(NativeField = true)]
        public object paramOrder { get; set; }
        [JsProperty(NativeField = true)]
        public bool paramsAsHash { get; set; }
        [JsProperty(NativeField = true)]
        public bool preloadChildren { get; set; }
        [JsProperty(NativeField = true)]
        public static TreeLoader prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string requestMethod { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
        [JsProperty(NativeField = true)]
        public object uiProviders { get; set; }
        [JsProperty(NativeField = true)]
        public string url { get; set; }
    }

    public delegate void TreeLoaderBeforeloadDelegate(object This, object node, object callback);

    [JsType(JsMode.Json)]
    public class TreeLoaderConfig
    {
        // Methods
        public TreeLoaderConfig() { throw new Exception(); }

        // Properties
        public object baseAttrs { get; set; }
        public object baseParams { get; set; }
        public bool clearOnLoad { get; set; }
        public string dataUrl { get; set; }
        public JsAction directFn { get; set; }
        public string nodeParameter { get; set; }
        public object paramOrder { get; set; }
        public bool paramsAsHash { get; set; }
        public bool preloadChildren { get; set; }
        public string requestMethod { get; set; }
        public object uiProviders { get; set; }
        public string url { get; set; }
    }

    public class TreeLoaderEvents
    {
        // Methods
        public TreeLoaderEvents() { throw new Exception(); }

        // Properties
        public static string beforeload { get { throw new Exception(); } }
        public static string load { get { throw new Exception(); } }
        public static string loadexception { get { throw new Exception(); } }
    }

    public delegate void TreeLoaderLoadDelegate(object This, object node, object response);

    public delegate void TreeLoaderLoadexceptionDelegate(object This, object node, object response);

    [JsType(JsMode.Prototype, Export = false)]
    public class TreeNode : Node
    {
        // Methods
        public TreeNode() { throw new Exception(); }
        public TreeNode(TreeNodeConfig config) { throw new Exception(); }
        public TreeNode(object attributes) { throw new Exception(); }
        public TreeNode(string attributes) { throw new Exception(); }
        public void collapse() { throw new Exception(); }
        public void collapse(bool deep) { throw new Exception(); }
        public void collapse(bool deep, bool anim) { throw new Exception(); }
        public void collapse(bool deep, bool anim, JsAction callback) { throw new Exception(); }
        public void collapse(bool deep, bool anim, JsAction callback, object scope) { throw new Exception(); }
        public void collapseChildNodes() { throw new Exception(); }
        public void collapseChildNodes(bool deep) { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public void ensureVisible() { throw new Exception(); }
        public void ensureVisible(JsAction callback) { throw new Exception(); }
        public void ensureVisible(JsAction callback, object scope) { throw new Exception(); }
        public void expand() { throw new Exception(); }
        public void expand(bool deep) { throw new Exception(); }
        public void expand(bool deep, bool anim) { throw new Exception(); }
        public void expand(bool deep, bool anim, JsAction callback) { throw new Exception(); }
        public void expand(bool deep, bool anim, JsAction callback, object scope) { throw new Exception(); }
        public void expandChildNodes() { throw new Exception(); }
        public void expandChildNodes(bool deep) { throw new Exception(); }
        public TreeNodeUI getUI() { throw new Exception(); }
        public bool isExpanded() { throw new Exception(); }
        public bool isSelected() { throw new Exception(); }
        public void select() { throw new Exception(); }
        public void setText() { throw new Exception(); }
        public void setText(string text) { throw new Exception(); }
        public void toggle() { throw new Exception(); }
        public void unselect() { throw new Exception(); }
        public void unselect(bool silent) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool disabled { get; set; }
        [JsProperty(NativeField = true)]
        public bool hidden { get; set; }
        [JsProperty(NativeField = true)]
        public static TreeNode prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Node superclass { get; set; }
        [JsProperty(NativeField = true)]
        public string text { get; set; }
        [JsProperty(NativeField = true)]
        public TreeNodeUI ui { get; set; }
    }

    public delegate void TreeNodeBeforechildrenrenderedDelegate(Node objthis);

    public delegate void TreeNodeBeforeclickDelegate(Node objthis, EventObject e);

    public delegate void TreeNodeBeforecollapseDelegate(Node objthis, bool deep, bool anim);

    public delegate void TreeNodeBeforedblclickDelegate(Node objthis, EventObject e);

    public delegate void TreeNodeBeforeexpandDelegate(Node objthis, bool deep, bool anim);

    public delegate void TreeNodeCheckchangeDelegate(Node objthis, bool chckd);

    public delegate void TreeNodeClickDelegate(Node objthis, EventObject e);

    public delegate void TreeNodeCollapseDelegate(Node objthis);

    [JsType(JsMode.Json)]
    public class TreeNodeConfig
    {
        // Methods
        public TreeNodeConfig() { throw new Exception(); }

        // Properties
        public bool allowChildren { get; set; }
        public bool allowDrag { get; set; }
        public bool allowDrop { get; set; }
        public bool @checked { get; set; }
        public string cls { get; set; }
        public bool disabled { get; set; }
        public bool draggable { get; set; }
        public bool editable { get; set; }
        public bool expandable { get; set; }
        public bool expanded { get; set; }
        public bool hidden { get; set; }
        public string href { get; set; }
        public string hrefTarget { get; set; }
        public string icon { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public bool isTarget { get; set; }
        public bool leaf { get; set; }
        public string qtip { get; set; }
        public string qtipCfg { get; set; }
        public bool singleClickExpand { get; set; }
        public string text { get; set; }
        public JsAction uiProvider { get; set; }
    }

    public delegate void TreeNodeContextmenuDelegate(Node objthis, EventObject e);

    public delegate void TreeNodeDblclickDelegate(Node objthis, EventObject e);

    public delegate void TreeNodeDisabledchangeDelegate(Node objthis, bool disabled);

    public class TreeNodeEvents
    {
        // Methods
        public TreeNodeEvents() { throw new Exception(); }

        // Properties
        public static string beforechildrenrendered { get { throw new Exception(); } }
        public static string beforeclick { get { throw new Exception(); } }
        public static string beforecollapse { get { throw new Exception(); } }
        public static string beforedblclick { get { throw new Exception(); } }
        public static string beforeexpand { get { throw new Exception(); } }
        public static string checkchange { get { throw new Exception(); } }
        public static string click { get { throw new Exception(); } }
        public static string collapse { get { throw new Exception(); } }
        public static string contextmenu { get { throw new Exception(); } }
        public static string dblclick { get { throw new Exception(); } }
        public static string disabledchange { get { throw new Exception(); } }
        public static string expand { get { throw new Exception(); } }
        public static string textchange { get { throw new Exception(); } }
    }

    public delegate void TreeNodeExpandDelegate(Node objthis);

    public delegate void TreeNodeTextchangeDelegate(Node objthis, string text, string oldText);

    [JsType(JsMode.Prototype, Export = false)]
    public class TreeNodeUI
    {
        // Methods
        public TreeNodeUI() { throw new Exception(); }
        public void addClass() { throw new Exception(); }
        public void addClass(Array className) { throw new Exception(); }
        public void addClass(string className) { throw new Exception(); }
        public HtmlElement getAnchor() { throw new Exception(); }
        public HtmlElement getEl() { throw new Exception(); }
        public HtmlElement getIconEl() { throw new Exception(); }
        public HtmlNode getTextEl() { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public bool isChecked() { throw new Exception(); }
        public void removeClass() { throw new Exception(); }
        public void removeClass(Array className) { throw new Exception(); }
        public void removeClass(string className) { throw new Exception(); }
        public void show() { throw new Exception(); }
        public void toggleCheck() { throw new Exception(); }
        public void toggleCheck(bool value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static TreeNodeUI prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeNodeUIConfig
    {
        // Methods
        public TreeNodeUIConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TreePanel : Panel
    {
        // Methods
        public TreePanel() { throw new Exception(); }
        public TreePanel(Element config) { throw new Exception(); }
        public TreePanel(TreePanelConfig config) { throw new Exception(); }
        public TreePanel(object config) { throw new Exception(); }
        public TreePanel(string config) { throw new Exception(); }
        public void applyToMarkup() { throw new Exception(); }
        public void cascade() { throw new Exception(); }
        public void collapseAll() { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void doLayout() { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public void expandAll() { throw new Exception(); }
        public void expandPath() { throw new Exception(); }
        public void expandPath(string path) { throw new Exception(); }
        public void expandPath(string path, string attr) { throw new Exception(); }
        public void expandPath(string path, string attr, JsAction callback) { throw new Exception(); }
        public void find() { throw new Exception(); }
        public void findBy() { throw new Exception(); }
        public void findById() { throw new Exception(); }
        public void findByType() { throw new Exception(); }
        public Array getChecked() { throw new Exception(); }
        public Array getChecked(string attribute) { throw new Exception(); }
        public Array getChecked(string attribute, TreeNode startNode) { throw new Exception(); }
        public void getComponent() { throw new Exception(); }
        public void getLayout() { throw new Exception(); }
        public TreeLoader getLoader() { throw new Exception(); }
        public Node getNodeById() { throw new Exception(); }
        public Node getNodeById(string id) { throw new Exception(); }
        public Node getRootNode() { throw new Exception(); }
        public object getSelectionModel() { throw new Exception(); }
        public Element getTreeEl() { throw new Exception(); }
        public void getUpdater() { throw new Exception(); }
        public void insert() { throw new Exception(); }
        public void load() { throw new Exception(); }
        public void remove() { throw new Exception(); }
        public void removeAll() { throw new Exception(); }
        public void selectPath() { throw new Exception(); }
        public void selectPath(string path) { throw new Exception(); }
        public void selectPath(string path, string attr) { throw new Exception(); }
        public void selectPath(string path, string attr, JsAction callback) { throw new Exception(); }
        public void setDisabled() { throw new Exception(); }
        public Node setRootNode() { throw new Exception(); }
        public Node setRootNode(Node node) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public Array bubbleEvents { get; set; }
        [JsProperty(NativeField = true)]
        public TreeDragZone dragZone { get; set; }
        [JsProperty(NativeField = true)]
        public TreeDropZone dropZone { get; set; }
        [JsProperty(NativeField = true)]
        public static TreePanel prototype { get; set; }
        [JsProperty(NativeField = true)]
        public TreeNode root { get; set; }
        [JsProperty(NativeField = true)]
        public static Panel superclass { get; set; }
    }

    public delegate void TreePanelAppendDelegate(Tree tree, Node parent, Node node, double index);

    public delegate void TreePanelBeforeappendDelegate(Tree tree, Node parent, Node node);

    public delegate void TreePanelBeforechildrenrenderedDelegate(Node node);

    public delegate void TreePanelBeforeclickDelegate(Node node, EventObject e);

    public delegate void TreePanelBeforecollapsenodeDelegate(Node node, bool deep, bool anim);

    public delegate void TreePanelBeforedblclickDelegate(Node node, EventObject e);

    public delegate void TreePanelBeforeexpandnodeDelegate(Node node, bool deep, bool anim);

    public delegate void TreePanelBeforeinsertDelegate(Tree tree, Node parent, Node node, Node refNode);

    public delegate void TreePanelBeforeloadDelegate(Node node);

    public delegate void TreePanelBeforemovenodeDelegate(Tree tree, Node node, Node oldParent, Node newParent, double index);

    public delegate void TreePanelBeforenodedropDelegate(object dropEvent);

    public delegate void TreePanelBeforeremoveDelegate(Tree tree, Node parent, Node node);

    public delegate void TreePanelCheckchangeDelegate(Node objthis, bool chckd);

    public delegate void TreePanelClickDelegate(Node node, EventObject e);

    public delegate void TreePanelCollapsenodeDelegate(Node node);

    [JsType(JsMode.Json)]
    public class TreePanelConfig
    {
        // Methods
        public TreePanelConfig() { throw new Exception(); }

        // Properties
        public object activeItem { get; set; }
        public bool allowDomMove { get; set; }
        public string anchor { get; set; }
        public bool animate { get; set; }
        public bool animCollapse { get; set; }
        public object applyTo { get; set; }
        public object autoEl { get; set; }
        public bool autoHeight { get; set; }
        public object autoLoad { get; set; }
        public bool autoScroll { get; set; }
        public bool autoShow { get; set; }
        public bool autoWidth { get; set; }
        public string baseCls { get; set; }
        public object bbar { get; set; }
        public object bbarCfg { get; set; }
        public bool bodyBorder { get; set; }
        public object bodyCfg { get; set; }
        public object bodyCssClass { get; set; }
        public object bodyStyle { get; set; }
        public bool border { get; set; }
        public double boxMaxHeight { get; set; }
        public double boxMaxWidth { get; set; }
        public double boxMinHeight { get; set; }
        public double boxMinWidth { get; set; }
        public Array bubbleEvents { get; set; }
        public object bufferResize { get; set; }
        public string buttonAlign { get; set; }
        public Array buttons { get; set; }
        public object bwrapCfg { get; set; }
        public string clearCls { get; set; }
        public bool closable { get; set; }
        public string cls { get; set; }
        public bool collapsed { get; set; }
        public string collapsedCls { get; set; }
        public bool collapseFirst { get; set; }
        public bool collapsible { get; set; }
        public bool containerScroll { get; set; }
        public string contentEl { get; set; }
        public string ctCls { get; set; }
        public object data { get; set; }
        public bool ddAppendOnly { get; set; }
        public string ddGroup { get; set; }
        public bool ddScroll { get; set; }
        public object defaults { get; set; }
        public string defaultType { get; set; }
        public bool disabled { get; set; }
        public string disabledClass { get; set; }
        public object dragConfig { get; set; }
        public object draggable { get; set; }
        public object dropConfig { get; set; }
        public string elements { get; set; }
        public bool enableDD { get; set; }
        public bool enableDrag { get; set; }
        public bool enableDrop { get; set; }
        public string fieldLabel { get; set; }
        public object floating { get; set; }
        public bool footer { get; set; }
        public object footerCfg { get; set; }
        public bool frame { get; set; }
        public bool header { get; set; }
        public bool headerAsText { get; set; }
        public object headerCfg { get; set; }
        public double height { get; set; }
        public bool hidden { get; set; }
        public bool hideCollapseTool { get; set; }
        public bool hideLabel { get; set; }
        public string hideMode { get; set; }
        public bool hideParent { get; set; }
        public string hlColor { get; set; }
        public bool hlDrop { get; set; }
        public object html { get; set; }
        public string iconCls { get; set; }
        public string id { get; set; }
        public string itemCls { get; set; }
        public string itemId { get; set; }
        public object items { get; set; }
        public object keys { get; set; }
        public string labelSeparator { get; set; }
        public string labelStyle { get; set; }
        public object layout { get; set; }
        public object layoutConfig { get; set; }
        public bool lines { get; set; }
        public TreeLoader loader { get; set; }
        public object margins { get; set; }
        public bool maskDisabled { get; set; }
        public double minButtonWidth { get; set; }
        public bool monitorResize { get; set; }
        public string overCls { get; set; }
        public object padding { get; set; }
        public double pageX { get; set; }
        public double pageY { get; set; }
        public string pathSeparator { get; set; }
        public object plugins { get; set; }
        public bool preventBodyReset { get; set; }
        public string ptype { get; set; }
        public string @ref { get; set; }
        public string region { get; set; }
        public object renderTo { get; set; }
        public string requestMethod { get; set; }
        public TreeNode root { get; set; }
        public bool rootVisible { get; set; }
        public object selModel { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public bool shim { get; set; }
        public bool singleExpand { get; set; }
        public Array stateEvents { get; set; }
        public bool stateful { get; set; }
        public string stateId { get; set; }
        public string style { get; set; }
        public string tabTip { get; set; }
        public object tbar { get; set; }
        public object tbarCfg { get; set; }
        public string title { get; set; }
        public bool titleCollapse { get; set; }
        public Array tools { get; set; }
        public object toolTemplate { get; set; }
        public object tpl { get; set; }
        public string tplWriteMode { get; set; }
        public bool trackMouseOver { get; set; }
        public bool unstyled { get; set; }
        public bool useArrows { get; set; }
        public double width { get; set; }
        public double x { get; set; }
        public string xtype { get; set; }
        public double y { get; set; }
    }

    public delegate void TreePanelContainerclickDelegate(Tree objthis, EventObject e);

    public delegate void TreePanelContainercontextmenuDelegate(Tree objthis, EventObject e);

    public delegate void TreePanelContainerdblclickDelegate(Tree objthis, EventObject e);

    public delegate void TreePanelContextmenuDelegate(Node node, EventObject e);

    public delegate void TreePanelDblclickDelegate(Node node, EventObject e);

    public delegate void TreePanelDisabledchangeDelegate(Node node, bool disabled);

    public delegate void TreePanelDragdropDelegate(TreePanel objthis, TreeNode node, DD dd, EventObject e);

    public delegate void TreePanelEnddragDelegate(TreePanel objthis, TreeNode node, EventObject e);

    public class TreePanelEvents
    {
        // Methods
        public TreePanelEvents() { throw new Exception(); }

        // Properties
        public static string append { get { throw new Exception(); } }
        public static string beforeappend { get { throw new Exception(); } }
        public static string beforechildrenrendered { get { throw new Exception(); } }
        public static string beforeclick { get { throw new Exception(); } }
        public static string beforecollapsenode { get { throw new Exception(); } }
        public static string beforedblclick { get { throw new Exception(); } }
        public static string beforeexpandnode { get { throw new Exception(); } }
        public static string beforeinsert { get { throw new Exception(); } }
        public static string beforeload { get { throw new Exception(); } }
        public static string beforemovenode { get { throw new Exception(); } }
        public static string beforenodedrop { get { throw new Exception(); } }
        public static string beforeremove { get { throw new Exception(); } }
        public static string checkchange { get { throw new Exception(); } }
        public static string click { get { throw new Exception(); } }
        public static string collapsenode { get { throw new Exception(); } }
        public static string containerclick { get { throw new Exception(); } }
        public static string containercontextmenu { get { throw new Exception(); } }
        public static string containerdblclick { get { throw new Exception(); } }
        public static string contextmenu { get { throw new Exception(); } }
        public static string dblclick { get { throw new Exception(); } }
        public static string disabledchange { get { throw new Exception(); } }
        public static string dragdrop { get { throw new Exception(); } }
        public static string enddrag { get { throw new Exception(); } }
        public static string expandnode { get { throw new Exception(); } }
        public static string insert { get { throw new Exception(); } }
        public static string load { get { throw new Exception(); } }
        public static string movenode { get { throw new Exception(); } }
        public static string nodedragover { get { throw new Exception(); } }
        public static string nodedrop { get { throw new Exception(); } }
        public static string remove { get { throw new Exception(); } }
        public static string startdrag { get { throw new Exception(); } }
        public static string textchange { get { throw new Exception(); } }
    }

    public delegate void TreePanelExpandnodeDelegate(Node node);

    public delegate void TreePanelInsertDelegate(Tree tree, Node parent, Node node, Node refNode);

    public delegate void TreePanelLoadDelegate(Node node);

    public delegate void TreePanelMovenodeDelegate(Tree tree, Node node, Node oldParent, Node newParent, double index);

    public delegate void TreePanelNodedragoverDelegate(object dragOverEvent);

    public delegate void TreePanelNodedropDelegate(object dropEvent);

    public delegate void TreePanelRemoveDelegate(Tree tree, Node parent, Node node);

    public delegate void TreePanelStartdragDelegate(TreePanel objthis, TreeNode node, EventObject e);

    public delegate void TreePanelTextchangeDelegate(Node node, string text, string oldText);

    [JsType(JsMode.Prototype, Export = false)]
    public class TreeSorter
    {
        // Methods
        public TreeSorter() { throw new Exception(); }
        public TreeSorter(TreePanel tree) { throw new Exception(); }
        public TreeSorter(TreeSorterConfig config) { throw new Exception(); }
        public TreeSorter(TreePanel tree, object config) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool caseSensitive { get; set; }
        [JsProperty(NativeField = true)]
        public string dir { get; set; }
        [JsProperty(NativeField = true)]
        public bool folderSort { get; set; }
        [JsProperty(NativeField = true)]
        public string leafAttr { get; set; }
        [JsProperty(NativeField = true)]
        public string property { get; set; }
        [JsProperty(NativeField = true)]
        public static TreeSorter prototype { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction sortType { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeSorterConfig
    {
        // Methods
        public TreeSorterConfig() { throw new Exception(); }

        // Properties
        public bool caseSensitive { get; set; }
        public string dir { get; set; }
        public bool folderSort { get; set; }
        public string leafAttr { get; set; }
        public string property { get; set; }
        public JsAction sortType { get; set; }
    }
}


namespace Ext.util
{
    [JsType(JsMode.Prototype, Export = false)]
    public class ClickRepeater : Observable
    {
        // Methods
        public ClickRepeater() { throw new Exception(); }
        public ClickRepeater(ClickRepeaterConfig config) { throw new Exception(); }
        public ClickRepeater(object el) { throw new Exception(); }
        public ClickRepeater(object el, object config) { throw new Exception(); }
        public void disable() { throw new Exception(); }
        public void enable() { throw new Exception(); }
        public void setDisabled() { throw new Exception(); }
        public void setDisabled(bool disabled) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static ClickRepeater prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void ClickRepeaterClickDelegate(ClickRepeater objthis);

    [JsType(JsMode.Json)]
    public class ClickRepeaterConfig
    {
        // Methods
        public ClickRepeaterConfig() { throw new Exception(); }

        // Properties
        public bool accelerate { get; set; }
        public double delay { get; set; }
        public object el { get; set; }
        public double interval { get; set; }
        public string pressClass { get; set; }
        public bool preventDefault { get; set; }
        public bool stopDefault { get; set; }
    }

    public class ClickRepeaterEvents
    {
        // Methods
        public ClickRepeaterEvents() { throw new Exception(); }

        // Properties
        public static string click { get { throw new Exception(); } }
        public static string mousedown { get { throw new Exception(); } }
        public static string mouseup { get { throw new Exception(); } }
    }

    public delegate void ClickRepeaterMousedownDelegate(ClickRepeater objthis);

    public delegate void ClickRepeaterMouseupDelegate(ClickRepeater objthis);

    [JsType(JsMode.Prototype, Export = false)]
    public class Cookies
    {
        // Methods
        public Cookies() { throw new Exception(); }
        public static void clear() { throw new Exception(); }
        public static void clear(string name) { throw new Exception(); }
        public static object get() { throw new Exception(); }
        public static object get(string name) { throw new Exception(); }
        public static void set() { throw new Exception(); }
        public static void set(string name) { throw new Exception(); }
        public static void set(string name, object value) { throw new Exception(); }
        public static void set(string name, object value, object expires) { throw new Exception(); }
        public static void set(string name, object value, object expires, string path) { throw new Exception(); }
        public static void set(string name, object value, object expires, string path, string domain) { throw new Exception(); }
        public static void set(string name, object value, object expires, string path, string domain, bool secure) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Cookies prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CookiesConfig
    {
        // Methods
        public CookiesConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class CSS
    {
        // Methods
        public CSS() { throw new Exception(); }
        public static object createStyleSheet() { throw new Exception(); }
        public static object createStyleSheet(string cssText) { throw new Exception(); }
        public static object createStyleSheet(string cssText, string id) { throw new Exception(); }
        public static object getRule() { throw new Exception(); }
        public static object getRule(Array selector) { throw new Exception(); }
        public static object getRule(string selector) { throw new Exception(); }
        public static object getRule(Array selector, bool refreshCache) { throw new Exception(); }
        public static object getRule(string selector, bool refreshCache) { throw new Exception(); }
        public static object getRules() { throw new Exception(); }
        public static object getRules(bool refreshCache) { throw new Exception(); }
        public static object refreshCache() { throw new Exception(); }
        public static void removeStyleSheet() { throw new Exception(); }
        public static void removeStyleSheet(string id) { throw new Exception(); }
        public static void swapStyleSheet() { throw new Exception(); }
        public static void swapStyleSheet(string id) { throw new Exception(); }
        public static void swapStyleSheet(string id, string url) { throw new Exception(); }
        public static bool updateRule() { throw new Exception(); }
        public static bool updateRule(Array selector) { throw new Exception(); }
        public static bool updateRule(string selector) { throw new Exception(); }
        public static bool updateRule(Array selector, string property) { throw new Exception(); }
        public static bool updateRule(string selector, string property) { throw new Exception(); }
        public static bool updateRule(Array selector, string property, string value) { throw new Exception(); }
        public static bool updateRule(string selector, string property, string value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static CSS prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CSSConfig
    {
        // Methods
        public CSSConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class DelayedTask
    {
        // Methods
        public DelayedTask() { throw new Exception(); }
        public DelayedTask(JsAction fn) { throw new Exception(); }
        public DelayedTask(JsAction fn, object scope) { throw new Exception(); }
        public DelayedTask(JsAction fn, object scope, Array args) { throw new Exception(); }
        public void cancel() { throw new Exception(); }
        public void delay() { throw new Exception(); }
        public void delay(double delay) { throw new Exception(); }
        public void delay(double delay, JsAction newFn) { throw new Exception(); }
        public void delay(double delay, JsAction newFn, object newScope) { throw new Exception(); }
        public void delay(double delay, JsAction newFn, object newScope, Array newArgs) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static DelayedTask prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DelayedTaskConfig
    {
        // Methods
        public DelayedTaskConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class Format
    {
        // Methods
        public Format() { throw new Exception(); }
        public static string capitalize() { throw new Exception(); }
        public static string capitalize(string value) { throw new Exception(); }
        public static string date() { throw new Exception(); }
        public static string date(DateTime value) { throw new Exception(); }
        public static string date(string value) { throw new Exception(); }
        public static string date(DateTime value, string format) { throw new Exception(); }
        public static string date(string value, string format) { throw new Exception(); }
        public static JsAction dateRenderer() { throw new Exception(); }
        public static JsAction dateRenderer(string format) { throw new Exception(); }
        public static string defaultValue() { throw new Exception(); }
        public static string defaultValue(object value) { throw new Exception(); }
        public static string defaultValue(object value, string defaultValue) { throw new Exception(); }
        public static string ellipsis() { throw new Exception(); }
        public static string ellipsis(string value) { throw new Exception(); }
        public static string ellipsis(string value, double length) { throw new Exception(); }
        public static string ellipsis(string value, double length, bool word) { throw new Exception(); }
        public static string fileSize() { throw new Exception(); }
        public static string fileSize(double size) { throw new Exception(); }
        public static string fileSize(string size) { throw new Exception(); }
        public static string htmlDecode() { throw new Exception(); }
        public static string htmlDecode(string value) { throw new Exception(); }
        public static string htmlEncode() { throw new Exception(); }
        public static string htmlEncode(string value) { throw new Exception(); }
        public static string lowercase() { throw new Exception(); }
        public static string lowercase(string value) { throw new Exception(); }
        public static JsAction math() { throw new Exception(); }
        public static string nl2br() { throw new Exception(); }
        public static string nl2br(string The) { throw new Exception(); }
        public static string number() { throw new Exception(); }
        public static string number(double v) { throw new Exception(); }
        public static string number(double v, string format) { throw new Exception(); }
        public static JsAction numberRenderer() { throw new Exception(); }
        public static JsAction numberRenderer(string format) { throw new Exception(); }
        public static void plural() { throw new Exception(); }
        public static void plural(double value) { throw new Exception(); }
        public static void plural(double value, string singular) { throw new Exception(); }
        public static void plural(double value, string singular, string plural) { throw new Exception(); }
        public static double round() { throw new Exception(); }
        public static double round(double value) { throw new Exception(); }
        public static double round(string value) { throw new Exception(); }
        public static double round(double value, double precision) { throw new Exception(); }
        public static double round(string value, double precision) { throw new Exception(); }
        public static string stripScripts() { throw new Exception(); }
        public static string stripScripts(object value) { throw new Exception(); }
        public static string stripTags() { throw new Exception(); }
        public static string stripTags(object value) { throw new Exception(); }
        public static string substr() { throw new Exception(); }
        public static string substr(string value) { throw new Exception(); }
        public static string substr(string value, double start) { throw new Exception(); }
        public static string substr(string value, double start, double length) { throw new Exception(); }
        public static string trim() { throw new Exception(); }
        public static string trim(string value) { throw new Exception(); }
        public static object undef() { throw new Exception(); }
        public static object undef(object value) { throw new Exception(); }
        public static string uppercase() { throw new Exception(); }
        public static string uppercase(string value) { throw new Exception(); }
        public static string usMoney() { throw new Exception(); }
        public static string usMoney(double value) { throw new Exception(); }
        public static string usMoney(string value) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static Format prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FormatConfig
    {
        // Methods
        public FormatConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class JSON
    {
        // Methods
        public JSON() { throw new Exception(); }
        public static object decode() { throw new Exception(); }
        public static object decode(string json) { throw new Exception(); }
        public static string encode() { throw new Exception(); }
        public static string encode(object o) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static JSON prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class JSONConfig
    {
        // Methods
        public JSONConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class MixedCollection : Observable
    {
        // Methods
        public MixedCollection() { throw new Exception(); }
        public MixedCollection(MixedCollectionConfig config) { throw new Exception(); }
        public MixedCollection(bool allowFunctions) { throw new Exception(); }
        public MixedCollection(bool allowFunctions, JsAction keyFn) { throw new Exception(); }
        public object add() { throw new Exception(); }
        public object add(string key) { throw new Exception(); }
        public object add(string key, object o) { throw new Exception(); }
        public void addAll() { throw new Exception(); }
        public void addAll(Array objs) { throw new Exception(); }
        public void addAll(object objs) { throw new Exception(); }
        public void clear() { throw new Exception(); }
        public MixedCollection clone() { throw new Exception(); }
        public bool contains() { throw new Exception(); }
        public bool contains(object o) { throw new Exception(); }
        public bool containsKey() { throw new Exception(); }
        public bool containsKey(string key) { throw new Exception(); }
        public void each() { throw new Exception(); }
        public void each(JsAction fn) { throw new Exception(); }
        public void each(JsAction fn, object scope) { throw new Exception(); }
        public void eachKey() { throw new Exception(); }
        public void eachKey(JsAction fn) { throw new Exception(); }
        public void eachKey(JsAction fn, object scope) { throw new Exception(); }
        public MixedCollection filter() { throw new Exception(); }
        public MixedCollection filter(string property) { throw new Exception(); }
        public MixedCollection filter(string property, object value) { throw new Exception(); }
        public MixedCollection filter(string property, string value) { throw new Exception(); }
        public MixedCollection filter(string property, object value, bool anyMatch) { throw new Exception(); }
        public MixedCollection filter(string property, string value, bool anyMatch) { throw new Exception(); }
        public MixedCollection filter(string property, object value, bool anyMatch, bool caseSensitive) { throw new Exception(); }
        public MixedCollection filter(string property, string value, bool anyMatch, bool caseSensitive) { throw new Exception(); }
        public MixedCollection filterBy() { throw new Exception(); }
        public MixedCollection filterBy(JsAction fn) { throw new Exception(); }
        public MixedCollection filterBy(JsAction fn, object scope) { throw new Exception(); }
        public object find() { throw new Exception(); }
        public object find(JsAction fn) { throw new Exception(); }
        public object find(JsAction fn, object scope) { throw new Exception(); }
        public double findIndex() { throw new Exception(); }
        public double findIndex(string property) { throw new Exception(); }
        public double findIndex(string property, object value) { throw new Exception(); }
        public double findIndex(string property, string value) { throw new Exception(); }
        public double findIndex(string property, object value, double start) { throw new Exception(); }
        public double findIndex(string property, string value, double start) { throw new Exception(); }
        public double findIndex(string property, object value, double start, bool anyMatch) { throw new Exception(); }
        public double findIndex(string property, string value, double start, bool anyMatch) { throw new Exception(); }
        public double findIndex(string property, object value, double start, bool anyMatch, bool caseSensitive) { throw new Exception(); }
        public double findIndex(string property, string value, double start, bool anyMatch, bool caseSensitive) { throw new Exception(); }
        public double findIndexBy() { throw new Exception(); }
        public double findIndexBy(JsAction fn) { throw new Exception(); }
        public double findIndexBy(JsAction fn, object scope) { throw new Exception(); }
        public double findIndexBy(JsAction fn, object scope, double start) { throw new Exception(); }
        public object first() { throw new Exception(); }
        public object get() { throw new Exception(); }
        public object get(double key) { throw new Exception(); }
        public object get(string key) { throw new Exception(); }
        public double getCount() { throw new Exception(); }
        public object getKey() { throw new Exception(); }
        public object getKey(object item) { throw new Exception(); }
        public Array getRange() { throw new Exception(); }
        public Array getRange(double startIndex) { throw new Exception(); }
        public Array getRange(double startIndex, double endIndex) { throw new Exception(); }
        public double indexOf() { throw new Exception(); }
        public double indexOf(object o) { throw new Exception(); }
        public double indexOfKey() { throw new Exception(); }
        public double indexOfKey(string key) { throw new Exception(); }
        public object insert() { throw new Exception(); }
        public object insert(double index) { throw new Exception(); }
        public object insert(double index, string key) { throw new Exception(); }
        public object insert(double index, string key, object o) { throw new Exception(); }
        public object item() { throw new Exception(); }
        public object item(double key) { throw new Exception(); }
        public object item(string key) { throw new Exception(); }
        public object itemAt() { throw new Exception(); }
        public object itemAt(double index) { throw new Exception(); }
        public object key() { throw new Exception(); }
        public object key(double key) { throw new Exception(); }
        public object key(string key) { throw new Exception(); }
        public void keySort() { throw new Exception(); }
        public void keySort(string direction) { throw new Exception(); }
        public void keySort(string direction, JsAction fn) { throw new Exception(); }
        public object last() { throw new Exception(); }
        public object remove() { throw new Exception(); }
        public object remove(object o) { throw new Exception(); }
        public object removeAt() { throw new Exception(); }
        public object removeAt(double index) { throw new Exception(); }
        public object removeKey() { throw new Exception(); }
        public object removeKey(string key) { throw new Exception(); }
        public object replace() { throw new Exception(); }
        public object replace(string key) { throw new Exception(); }
        public object replace(string key, object o) { throw new Exception(); }
        public void sort() { throw new Exception(); }
        public void sort(string direction) { throw new Exception(); }
        public void sort(string direction, JsAction fn) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool allowFunctions { get; set; }
        [JsProperty(NativeField = true)]
        public static MixedCollection prototype { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void MixedCollectionAddDelegate(double index, object o, string key);

    public delegate void MixedCollectionClearDelegate();

    [JsType(JsMode.Json)]
    public class MixedCollectionConfig
    {
        // Methods
        public MixedCollectionConfig() { throw new Exception(); }

        // Properties
        public bool allowFunctions { get; set; }
    }

    public class MixedCollectionEvents
    {
        // Methods
        public MixedCollectionEvents() { throw new Exception(); }

        // Properties
        public static string add { get { throw new Exception(); } }
        public static string clear { get { throw new Exception(); } }
        public static string remove { get { throw new Exception(); } }
        public static string replace { get { throw new Exception(); } }
    }

    public delegate void MixedCollectionRemoveDelegate(object o, string key);

    public delegate void MixedCollectionReplaceDelegate(string key, object old, object newItem);

    [JsType(JsMode.Prototype, Export = false)]
    public class Observable
    {
        // Methods
        public Observable() { throw new Exception(); }
        public Observable(ObservableConfig config) { throw new Exception(); }
        public void addEvents() { throw new Exception(); }
        public void addEvents(object o) { throw new Exception(); }
        public void addEvents(object o, string Optional) { throw new Exception(); }
        public void addListener() { throw new Exception(); }
        public void addListener(string eventName) { throw new Exception(); }
        public void addListener(string eventName, JsAction handler) { throw new Exception(); }
        public void addListener(string eventName, JsAction handler, object scope) { throw new Exception(); }
        public void addListener(string eventName, JsAction handler, object scope, object options) { throw new Exception(); }
        public bool fireEvent() { throw new Exception(); }
        public bool fireEvent(string eventName) { throw new Exception(); }
        public bool fireEvent(string eventName, params object[] args) { throw new Exception(); }
        public bool hasListener() { throw new Exception(); }
        public bool hasListener(string eventName) { throw new Exception(); }
        public void on() { throw new Exception(); }
        public void on(string eventName) { throw new Exception(); }
        public void on(string eventName, JsAction handler) { throw new Exception(); }
        public void on(string eventName, JsAction handler, object scope) { throw new Exception(); }
        public void on(string eventName, JsAction handler, object scope, object options) { throw new Exception(); }
        public void purgeListeners() { throw new Exception(); }
        public static void releaseCapture() { throw new Exception(); }
        public static void releaseCapture(Observable o) { throw new Exception(); }
        public void removeListener() { throw new Exception(); }
        public void removeListener(string eventName) { throw new Exception(); }
        public void removeListener(string eventName, JsAction handler) { throw new Exception(); }
        public void removeListener(string eventName, JsAction handler, object scope) { throw new Exception(); }
        public void resumeEvents() { throw new Exception(); }
        public void suspendEvents() { throw new Exception(); }
        public void suspendEvents(bool queueSuspended) { throw new Exception(); }
        public void un() { throw new Exception(); }
        public void un(string eventName) { throw new Exception(); }
        public void un(string eventName, JsAction handler) { throw new Exception(); }
        public void un(string eventName, JsAction handler, object scope) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public object listeners { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ObservableConfig
    {
        // Methods
        public ObservableConfig() { throw new Exception(); }

        // Properties
        public object listeners { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TaskRunner
    {
        // Methods
        public TaskRunner() { throw new Exception(); }
        public TaskRunner(double interval) { throw new Exception(); }
        public object start() { throw new Exception(); }
        public object start(object task) { throw new Exception(); }
        public object stop() { throw new Exception(); }
        public object stop(object task) { throw new Exception(); }
        public void stopAll() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static TaskRunner prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TaskRunnerConfig
    {
        // Methods
        public TaskRunnerConfig() { throw new Exception(); }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class TextMetrics
    {
        // Methods
        public TextMetrics() { throw new Exception(); }
        public static void bind() { throw new Exception(); }
        public static void bind(HtmlElement el) { throw new Exception(); }
        public static void bind(string el) { throw new Exception(); }
        public static TextMetrics createInstance() { throw new Exception(); }
        public static TextMetrics createInstance(HtmlElement el) { throw new Exception(); }
        public static TextMetrics createInstance(string el) { throw new Exception(); }
        public static TextMetrics createInstance(HtmlElement el, double fixedWidth) { throw new Exception(); }
        public static TextMetrics createInstance(string el, double fixedWidth) { throw new Exception(); }
        public static double getHeight() { throw new Exception(); }
        public static double getHeight(string text) { throw new Exception(); }
        public static object getSize() { throw new Exception(); }
        public static object getSize(string text) { throw new Exception(); }
        public static double getWidth() { throw new Exception(); }
        public static double getWidth(string text) { throw new Exception(); }
        public static object measure() { throw new Exception(); }
        public static object measure(HtmlElement el) { throw new Exception(); }
        public static object measure(string el) { throw new Exception(); }
        public static object measure(HtmlElement el, string text) { throw new Exception(); }
        public static object measure(string el, string text) { throw new Exception(); }
        public static object measure(HtmlElement el, string text, double fixedWidth) { throw new Exception(); }
        public static object measure(string el, string text, double fixedWidth) { throw new Exception(); }
        public static void setFixedWidth() { throw new Exception(); }
        public static void setFixedWidth(double width) { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public static TextMetrics prototype { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TextMetricsConfig
    {
        // Methods
        public TextMetricsConfig() { throw new Exception(); }
    }
}


namespace Ext.ux
{
    internal class Andrie
    {
        // Methods
        public Andrie() { throw new Exception(); }

        // Nested Types
        [JsType(JsMode.Prototype, Export = false)]
        public class Select : ComboBox
        {
            // Methods
            public Select() { throw new Exception(); }
            public Select(Element config) { throw new Exception(); }
            public Select(Andrie.SelectConfig config) { throw new Exception(); }
            public Select(object config) { throw new Exception(); }
            public Select(string config) { throw new Exception(); }
            public void addValue() { throw new Exception(); }
            public void addValue(string value) { throw new Exception(); }
            public void hover() { throw new Exception(); }
            public void hover(double index) { throw new Exception(); }
            public void hover(double index, bool scrollIntoView) { throw new Exception(); }
            public void removeValue() { throw new Exception(); }
            public void removeValue(string value) { throw new Exception(); }
            public void setValue() { throw new Exception(); }
            public void setValue(object value) { throw new Exception(); }

            // Properties
            [JsProperty(NativeField = true)]
            public bool clearTrigger { get; set; }
            [JsProperty(NativeField = true)]
            public string displaySeparator { get; set; }
            [JsProperty(NativeField = true)]
            public bool history { get; set; }
            [JsProperty(NativeField = true)]
            public int historyMaxLength { get; set; }
            [JsProperty(NativeField = true)]
            public int maxLength { get; set; }
            [JsProperty(NativeField = true)]
            public string maxLengthText { get; set; }
            [JsProperty(NativeField = true)]
            public int minLength { get; set; }
            [JsProperty(NativeField = true)]
            public string minLengthText { get; set; }
            [JsProperty(NativeField = true)]
            public bool multiSelect { get; set; }
            [JsProperty(NativeField = true)]
            public static Andrie.Select prototype { get; set; }
            [JsProperty(NativeField = true)]
            public string separator { get; set; }
            [JsProperty(NativeField = true)]
            public static ComboBox superclass { get; set; }
            [JsProperty(NativeField = true)]
            public DataView view { get; set; }
        }

        [JsType(JsMode.Json)]
        public class SelectConfig
        {
            // Methods
            public SelectConfig() { throw new Exception(); }

            // Properties
            public bool allowBlank { get; set; }
            public bool allowDomMove { get; set; }
            public string allQuery { get; set; }
            public string anchor { get; set; }
            public object applyTo { get; set; }
            public object autoCreate { get; set; }
            public object autoEl { get; set; }
            public bool autoHeight { get; set; }
            public bool autoScroll { get; set; }
            public bool autoShow { get; set; }
            public bool autoWidth { get; set; }
            public string blankText { get; set; }
            public double boxMaxHeight { get; set; }
            public double boxMaxWidth { get; set; }
            public double boxMinHeight { get; set; }
            public double boxMinWidth { get; set; }
            public string clearCls { get; set; }
            public bool clearFilterOnReset { get; set; }
            public bool clearTrigger { get; set; }
            public string cls { get; set; }
            public string contentEl { get; set; }
            public string ctCls { get; set; }
            public object data { get; set; }
            public bool disabled { get; set; }
            public string disabledClass { get; set; }
            public bool disableKeyFilter { get; set; }
            public string displayField { get; set; }
            public string displaySeparator { get; set; }
            public bool editable { get; set; }
            public string emptyClass { get; set; }
            public string emptyText { get; set; }
            public bool enableKeyEvents { get; set; }
            public string fieldClass { get; set; }
            public string fieldLabel { get; set; }
            public string focusClass { get; set; }
            public bool forceSelection { get; set; }
            public bool grow { get; set; }
            public double growMax { get; set; }
            public double growMin { get; set; }
            public double handleHeight { get; set; }
            public double height { get; set; }
            public bool hidden { get; set; }
            public string hiddenId { get; set; }
            public string hiddenName { get; set; }
            public string hiddenValue { get; set; }
            public bool hideLabel { get; set; }
            public string hideMode { get; set; }
            public bool hideParent { get; set; }
            public bool hideTrigger { get; set; }
            public bool history { get; set; }
            public int historyMaxLength { get; set; }
            public object html { get; set; }
            public string id { get; set; }
            public string inputType { get; set; }
            public string invalidClass { get; set; }
            public string invalidText { get; set; }
            public string itemCls { get; set; }
            public string itemId { get; set; }
            public string itemSelector { get; set; }
            public string labelSeparator { get; set; }
            public string labelStyle { get; set; }
            public bool lazyInit { get; set; }
            public bool lazyRender { get; set; }
            public string listAlign { get; set; }
            public string listClass { get; set; }
            public string listEmptyText { get; set; }
            public double listWidth { get; set; }
            public string loadingText { get; set; }
            public object margins { get; set; }
            public object maskRe { get; set; }
            public double maxHeight { get; set; }
            public int maxLength { get; set; }
            public string maxLengthText { get; set; }
            public double minChars { get; set; }
            public double minHeight { get; set; }
            public int minLength { get; set; }
            public string minLengthText { get; set; }
            public double minListWidth { get; set; }
            public string mode { get; set; }
            public string msgFx { get; set; }
            public string msgTarget_p_The { get; set; }
            public bool multiSelect { get; set; }
            public string name { get; set; }
            public string overCls { get; set; }
            public double pageSize { get; set; }
            public double pageX { get; set; }
            public double pageY { get; set; }
            public object plugins { get; set; }
            public bool preventMark { get; set; }
            public string ptype { get; set; }
            public double queryDelay { get; set; }
            public string queryParam { get; set; }
            public bool readOnly { get; set; }
            public string @ref { get; set; }
            public object regex { get; set; }
            public string regexText { get; set; }
            public string region { get; set; }
            public object renderTo { get; set; }
            public bool resizable { get; set; }
            public string selectedClass { get; set; }
            public bool selectOnFocus { get; set; }
            public string separator { get; set; }
            public object shadow { get; set; }
            public Array stateEvents { get; set; }
            public bool stateful { get; set; }
            public string stateId { get; set; }
            public object store { get; set; }
            public object stripCharsRe { get; set; }
            public string style { get; set; }
            public bool submitValue { get; set; }
            public double tabIndex { get; set; }
            public string tabTip { get; set; }
            public string title { get; set; }
            public object tpl { get; set; }
            public string tplWriteMode { get; set; }
            public object transform { get; set; }
            public string triggerAction { get; set; }
            public string triggerClass { get; set; }
            public object triggerConfig { get; set; }
            public bool typeAhead { get; set; }
            public double typeAheadDelay { get; set; }
            public bool validateOnBlur { get; set; }
            public double validationDelay { get; set; }
            public object validationEvent { get; set; }
            public JsAction validator { get; set; }
            public object value { get; set; }
            public string valueField { get; set; }
            public string valueNotFoundText { get; set; }
            public string vtype { get; set; }
            public string vtypeText { get; set; }
            public double width { get; set; }
            public string wrapFocusClass { get; set; }
            public double x { get; set; }
            public string xtype { get; set; }
            public double y { get; set; }
        }
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class WindowBlind : Observable
    {
        // Methods
        public WindowBlind() { throw new Exception(); }
        public WindowBlind(Element el) { throw new Exception(); }
        public WindowBlind(WindowBlindConfig config) { throw new Exception(); }
        public WindowBlind(HtmlElement el) { throw new Exception(); }
        public WindowBlind(string el) { throw new Exception(); }
        public WindowBlind(Element el, Window win) { throw new Exception(); }
        public WindowBlind(HtmlElement el, Window win) { throw new Exception(); }
        public WindowBlind(string el, Window win) { throw new Exception(); }
        public WindowBlind(Element el, Window win, object config) { throw new Exception(); }
        public WindowBlind(HtmlElement el, Window win, object config) { throw new Exception(); }
        public WindowBlind(string el, Window win, object config) { throw new Exception(); }
        public Button addButton() { throw new Exception(); }
        public Button addButton(object config) { throw new Exception(); }
        public Button addButton(string config) { throw new Exception(); }
        public Button addButton(object config, JsAction handler) { throw new Exception(); }
        public Button addButton(string config, JsAction handler) { throw new Exception(); }
        public Button addButton(object config, JsAction handler, object scope) { throw new Exception(); }
        public Button addButton(string config, JsAction handler, object scope) { throw new Exception(); }
        public void afterHide() { throw new Exception(); }
        public void afterShow() { throw new Exception(); }
        public void animate() { throw new Exception(); }
        public void animate(JsAction fx) { throw new Exception(); }
        public void animate(JsAction fx, object options) { throw new Exception(); }
        public void beforeHide() { throw new Exception(); }
        public void beforeShow() { throw new Exception(); }
        public void destroy() { throw new Exception(); }
        public void dismiss() { throw new Exception(); }
        public void focus() { throw new Exception(); }
        public void getButtonConfig() { throw new Exception(); }
        public void hide() { throw new Exception(); }
        public void isMotionFx() { throw new Exception(); }
        public void isMotionFx(JsAction fn) { throw new Exception(); }
        public void registerButton() { throw new Exception(); }
        public void setDefaultButton() { throw new Exception(); }
        public void setDefaultButton(Button btn) { throw new Exception(); }
        public void show() { throw new Exception(); }
        public void syncHeight() { throw new Exception(); }
        public void syncSize() { throw new Exception(); }
        public void syncWidth() { throw new Exception(); }

        // Properties
        [JsProperty(NativeField = true)]
        public bool autoCreate { get; set; }
        [JsProperty(NativeField = true)]
        public double fxDuration { get; set; }
        [JsProperty(NativeField = true)]
        public string hideEasing { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction hideFx { get; set; }
        [JsProperty(NativeField = true)]
        public object onBeforeHide { get; set; }
        [JsProperty(NativeField = true)]
        public object onBeforeShow { get; set; }
        [JsProperty(NativeField = true)]
        public object onHide { get; set; }
        [JsProperty(NativeField = true)]
        public object onShow { get; set; }
        [JsProperty(NativeField = true)]
        public static WindowBlind prototype { get; set; }
        [JsProperty(NativeField = true)]
        public string showEasing { get; set; }
        [JsProperty(NativeField = true)]
        public JsAction showFx { get; set; }
        [JsProperty(NativeField = true)]
        public static Observable superclass { get; set; }
    }

    public delegate void WindowBlindBeforehideDelegate(WindowBlind objthis);

    public delegate void WindowBlindBeforeshowDelegate(WindowBlind objthis);

    [JsType(JsMode.Json)]
    public class WindowBlindConfig
    {
        // Methods
        public WindowBlindConfig() { throw new Exception(); }

        // Properties
        public bool autoCreate { get; set; }
        public string buttonAlign { get; set; }
        public double fxDuration { get; set; }
        public string hideEasing { get; set; }
        public JsAction hideFx { get; set; }
        public double minButtonWidth { get; set; }
        public object shadow { get; set; }
        public double shadowOffset { get; set; }
        public string showEasing { get; set; }
        public JsAction showFx { get; set; }
        public string text { get; set; }
    }

    public class WindowBlindEvents
    {
        // Methods
        public WindowBlindEvents() { throw new Exception(); }

        // Properties
        public static string beforehide { get { throw new Exception(); } }
        public static string beforeshow { get { throw new Exception(); } }
        public static string hide { get { throw new Exception(); } }
        public static string show { get { throw new Exception(); } }
    }

    public delegate void WindowBlindHideDelegate(WindowBlind objthis);

    public delegate void WindowBlindShowDelegate(WindowBlind objthis);
}











