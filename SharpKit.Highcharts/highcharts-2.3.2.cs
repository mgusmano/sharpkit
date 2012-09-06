
using SharpKit.JavaScript;

namespace SharpKit.Highcharts
{
    [JsType(JsMode.Prototype, Name = "Highcharts.Chart", Export = false)]
    public class Chart
    {

    }

    [JsType(JsMode.Json)]
    public class ChartConfiguration
    {
        /// <summary>
        /// Options regarding the chart area and plot area as well as general chart options.
        /// </summary>
        public ChartOptions chart { get; set; }

        /// <summary>
        ///An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again. Defaults to:
        /// colors: [
        /// 	'#4572A7', 
        /// 	'#AA4643', 
        /// 	'#89A54E', 
        /// 	'#80699B', 
        /// 	'#3D96AE', 
        /// 	'#DB843D', 
        /// 	'#92A8CD', 
        /// 	'#A47D7C', 
        /// 	'#B5CA92'
        /// ]
        /// </summary>
        public JsArray<JsString> colors { get; set; }
        //TODO: JsArray<JsString> OR JsArray?

        /// <summary>
        /// Highchart by default puts a credits label in the lower right corner of the chart. This can be changed using these options.
        /// </summary>
        public CreditsOptions credits { get; set; }

        /// <summary>
        /// Options for the exporting module.
        /// </summary>
        public ExportingOptions exporting { get; set; }

        /// <summary>
        /// Global options that don't apply to each chart. These options, like the lang options, must be set using the Highcharts.setOptions method.
        /// Highcharts.setOptions({
        /// 	global: {
        /// 		useUTC: false
        /// 	}
        /// });
        /// </summary>
        public GlobalOptions global { get; set; }

        /// <summary>
        /// HTML labels that can be positioined anywhere in the chart area.
        /// </summary>
        public LabelsOptions labels { get; set; }

        /// <summary>
        /// Language object. The language object is global and it can't be set on each chart initiation. Instead, use Highcharts.setOptions to set it before any chart is initiated.
        /// Highcharts.setOptions({
        /// 	lang: {
        /// 		months: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 
        /// 			'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],
        /// 		weekdays: ['Dimanche', 'Lundi', 'Mardi', 'Mercredi', 'Jeudi', 'Vendredi', 'Samedi']
        /// 	}
        /// });
        /// </summary>
        public LangOptions lang { get; set; }

        /// <summary>
        /// The legend is a box containing a symbol and name for each series item or point item in the chart.
        /// </summary>
        public LegendOptions legend { get; set; }
    }

    #region chart

    /// <summary>
    /// Options regarding the chart area and plot area as well as general chart options.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ChartOptions
    {
        /// <summary>
        /// When using multiple axis, the ticks of two or more opposite axes will automatically be aligned by adding ticks to the axis or axes with the least ticks.
        /// This can be prevented by setting alignTicks to false.
        /// If the grid lines look messy, it's a good idea to hide them for the secondary axis by setting gridLineWidth to 0. Defaults to true.
        /// </summary>
        public bool alignTicks { get; set; }

        /// <summary>
        /// Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the initial series animation, see plotOptions.series => animation.
        /// The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:
        /// duration
        /// The duration of the animation in milliseconds.
        /// easing
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.
        /// . Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the initial series animation, see plotOptions.series => animation.
        /// The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:
        /// duration
        /// The duration of the animation in milliseconds.
        /// easing
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.
        /// . Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the initial series animation, see plotOptions.series => animation.
        /// The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:
        /// duration
        /// The duration of the animation in milliseconds.
        /// easing
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.
        /// . Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The background color or gradient for the outer chart area. Defaults to "#FFFFFF".
        /// </summary>
        public JsString backgroundColor { get; set; }
        //TODO: type is color (?)

        /// <summary>
        /// The color of the outer chart border. The border is painted using vector graphic techniques to allow rounded corners. Defaults to "#4572A7".
        /// </summary>
        public JsString borderColor { get; set; }
        //TODO: type is color (?)

        /// <summary>
        /// The corner radius of the outer chart border. Defaults to 5.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The pixel width of the outer chart border. The border is painted using vector graphic techniques to allow rounded corners. Defaults to 0.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// A CSS class name to apply to the charts container div, allowing unique CSS styling for each chart. Defaults to "".
        /// </summary>
        public JsString className { get; set; }

        /// <summary>
        /// Alias of type.
        /// </summary>
        public JsString defaultSeriesType { get; set; }

        //TODO: events!

        /// <summary>
        /// An explicit height for the chart. By default the height is calculated from the offset height of the containing element. Defaults to null.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// If true, the axes will scale to the remaining visible series once one series is hidden.
        /// If false, hiding and showing a series will not affect the axes or the other series. For stacks,
        /// once one series within the stack is hidden, the rest of the stack will close in around it even if the axis is not affected. Defaults to true.
        /// </summary>
        public bool ignoreHiddenSeries { get; set; }

        /// <summary>
        /// Whether to invert the axes so that the x axis is horizontal and y axis is vertical.
        /// When true, the x axis is reversed by default. If a bar plot is present in the chart, it will be inverted automatically. Defaults to false.
        /// </summary>
        public bool inverted { get; set; }

        /// <summary>
        /// The margin between the outer edge of the chart and the plot area. The numbers in the array designate top, right, bottom and left respectively.
        /// Use the options marginTop, marginRight, marginBottom and marginLeft for shorthand setting of one option.
        /// Since version 2.1, the margin is 0 by default.
        /// The actual space is dynamically calculated from the offset of axis labels, axis title, title, subtitle and legend in addition to the spacingTop, spacingRight, spacingBottom and spacingLeft options.
        /// Defaults to [null]. Defaults to [null].
        /// </summary>
        public JsArray margin { get; set; }

        /// <summary>
        /// The margin between the bottom outer edge of the chart and the plot area.
        /// Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingBottom. Defaults to 70.
        /// </summary>
        public JsNumber marginBottom { get; set; }

        /// <summary>
        /// The margin between the left outer edge of the chart and the plot area.
        /// Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingLeft. Defaults to 80.
        /// </summary>
        public JsNumber marginLeft { get; set; }

        /// <summary>
        /// The margin between the right outer edge of the chart and the plot area.
        /// Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingRight. Defaults to 50.
        /// </summary>
        public JsNumber marginRight { get; set; }

        /// <summary>
        /// The margin between the top outer edge of the chart and the plot area.
        /// Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingTop. Defaults to null.
        /// </summary>
        public JsNumber marginTop { get; set; }

        /// <summary>
        /// The background color or gradient for the plot area. Defaults to null.
        /// </summary>
        public JsString plotBackgroundColor { get; set; }
        //TODO: type is color (?)

        /// <summary>
        /// The URL for an image to use as the plot background.
        /// To set an image as the background for the entire chart, set a CSS background image to the container element. Defaults to null.
        /// </summary>
        public JsString plotBackgroundImage { get; set; }

        /// <summary>
        /// The color of the inner chart or plot area border. Defaults to "#C0C0C0".
        /// </summary>
        public JsString plotBorderColor { get; set; }
        //TODO: type is color (?)

        /// <summary>
        /// The pixel width of the plot area border. Defaults to 0.
        /// </summary>
        public JsNumber plotBorderWidth { get; set; }

        /// <summary>
        /// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions plotShadow { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "plotShadow")]
        public bool plotShadowBoolean { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "plotShadow")]
        public object plotShadowObject { get; set; }

        /// <summary>
        /// When true, cartesian charts like line, spline, area and column are transformed into the polar coordinate system. Requires highcharts-more.js.
        /// </summary>
        public bool polar { get; set; }

        /// <summary>
        /// Whether to reflow the chart to fit the width of the container div on resizing the window. Defaults to true.
        /// </summary>
        public bool reflow { get; set; }

        /// <summary>
        /// The HTML element where the chart will be rendered.
        /// If it is a string, the element by that id is used. The HTML element can also be passed by direct reference. Defaults to null.
        /// </summary>
        public JsString renderTo { get; set; }
        /// <summary>
        /// The HTML element where the chart will be rendered.
        /// If it is a string, the element by that id is used. The HTML element can also be passed by direct reference. Defaults to null.
        /// </summary>
        [JsProperty(Name = "renderTo")]
        public object renderToObject { get; set; }

        /// <summary>
        /// The button that appears after a selection zoom, allowing the user to reset zoom.
        /// </summary>
        public ResetZoomButton resetZoomButton { get; set; }

        /// <summary>
        /// The background color of the marker square when selecting (zooming in on) an area of the chart. Defaults to rgba(69,114,167,0.25). Defaults to rgba(69114,167,0.25),.
        /// </summary>
        public object selectionMarkerFill { get; set; }
        //TODO: type is color (?)

        /// <summary>
        /// Whether to apply a drop shadow to the outer chart area. Requires that backgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the outer chart area. Requires that backgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the outer chart area. Requires that backgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }

        /// <summary>
        /// Whether to show the axes initially.
        /// This only applies to empty charts where series are added dynamically, as axes are automatically added to cartesian series. Defaults to false.
        /// </summary>
        public bool showAxes { get; set; }

        /// <summary>
        /// The space between the bottom edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).
        /// . Defaults to 10.
        /// </summary>
        public JsNumber spacingBottom { get; set; }

        /// <summary>
        /// The space between the left edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).
        /// . Defaults to 10.
        /// </summary>
        public JsNumber spacingLeft { get; set; }

        /// <summary>
        /// The space between the right edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).
        /// . Defaults to 10.
        /// </summary>
        public JsNumber spacingRight { get; set; }

        /// <summary>
        /// The space between the top edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).
        /// . Defaults to 10.
        /// </summary>
        public JsNumber spacingTop { get; set; }


        /// <summary>
        /// Additional CSS styles to apply inline to the container div. Note that since the default font styles are applied in the renderer, it is ignorant of the individual chart options and must be set globally. Defaults to:
        /// style: {
        /// 	fontFamily: '"Lucida Grande", "Lucida Sans Unicode", Verdana, Arial, Helvetica, sans-serif', // default font
        /// 	fontSize: '12px'
        /// }
        /// </summary>
        public object style { get; set; }
        //TODO: type?

        /// <summary>
        /// The default series type for the chart. Can be one of line, spline, area, areaspline, column, bar, pie and scatter.
        /// From version 2.3, arearange, areasplinerange and columnrange are supported with the highcharts-more.js component. Defaults to "line".
        /// </summary>
        public ChartType type { get; set; }


        /// <summary>
        /// An explicit width for the chart. By default the width is calculated from the offset width of the containing element. Defaults to null.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// Decides in what dimentions the user can zoom by dragging the mouse. Can be one of x, y or xy. Defaults to "".
        /// </summary>
        public ZoomType zoomType { get; set; }

    }

    /// <summary>
    /// The animation can either be set as a boolean or a configuration object.
    /// If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:
    /// </summary>
    [JsType(JsMode.Json)]
    public class AnimationOptions
    {
        /// <summary>
        /// The duration of the animation in milliseconds.
        /// </summary>
        public JsNumber duration { get; set; }

        /// <summary>
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs.
        /// When using MooTools as the general framework, use the property name transition instead of easing.
        /// </summary>
        public EasingType easing { get; set; }
        //TODO: More easing functions are available with the use of jQuery plug-ins, 
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum EasingType
    {
        linear,
        swing,
    }

    /// <summary>
    /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ShadowOptions
    {
        public JsString color { get; set; }

        public JsString offsetX { get; set; }
        [JsProperty(Name = "offsetX")]
        public JsNumber offsetXNumber { get; set; }

        public JsString offsetY { get; set; }
        [JsProperty(Name = "offsetY")]
        public JsNumber offsetYNumber { get; set; }

        public JsString opacity { get; set; }
        [JsProperty(Name = "opacity")]
        public JsNumber opacityNumber { get; set; }

        public JsString width { get; set; }
        [JsProperty(Name = "width")]
        public JsNumber widthNumber { get; set; }
    }

    /// <summary>
    /// The button that appears after a selection zoom, allowing the user to reset zoom.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ResetZoomButton
    {
        /// <summary>
        /// The position of the button.
        /// </summary>
        public object position { get; set; }

        /// <summary>
        /// What frame the button should be placed related to. Can be either "plot" or "chart". Defaults to "plot".
        /// </summary>
        public RelativeToType relativeTo { get; set; }

        /// <summary>
        /// A collection of attributes for the button. The object takes SVG attributes like fill, stroke, stroke-width or r, the border radius.
        /// The theme also supports style, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in theme.states.hover.
        /// </summary>
        public object theme { get; set; }
    }
    //TODO: check name

    /// <summary>
    /// What frame the button should be placed related to. Can be either "plot" or "chart".
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum RelativeToType
    {
        plot,
        chart,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ChartType
    {
        line,
        spline,
        area,
        areaspline,
        column,
        bar,
        pie,
        scatter,
        arearange,
        areasplinerange,
        columnrange,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ZoomType
    {
        x,
        y,
        xy,
    }

    #endregion

    #region credits

    /// <summary>
    /// Highchart by default puts a credits label in the lower right corner of the chart. This can be changed using these options.
    /// </summary>
    [JsType(JsMode.Json)]
    public class CreditsOptions
    {
        /// <summary>
        /// Whether to show the credits text. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// The URL for the credits label. Defaults to "http://www.highcharts.com".
        /// </summary>
        public JsString href { get; set; }

        /// <summary>
        /// Position configuration for the credtis label. Supported properties are align, verticalAlign, x and y. Defaults to
        /// position: {
        /// 	align: 'right',
        /// 	x: -10,
        /// 	verticalAlign: 'bottom',
        /// 	y: -5
        /// }
        /// </summary>
        public CreditsPositionOptions position { get; set; }

        /// <summary>
        /// CSS styles for the credits label. Defaults to:
        /// itemStyle: {
        /// 	cursor: 'pointer',
        /// 	color: '#909090',
        /// 	fontSize: '10px'
        /// 
        /// }
        /// </summary>
        public object style { get; set; }
        //TODO: type?

        /// <summary>
        /// The text for the credits label. Defaults to "Highcharts.com".
        /// </summary>
        public JsString text { get; set; }
    }

    /// <summary>
    /// Position configuration for the credtis label. Supported properties are align, verticalAlign, x and y.
    /// </summary>
    [JsType(JsMode.Json)]
    public class CreditsPositionOptions
    {
        public JsString align { get; set; }
        public JsNumber x { get; set; }
        public VerticalAlignType verticalAlign { get; set; }
        public JsNumber y { get; set; }
    }

    #endregion

    #region exporting

    /// <summary>
    /// Options for the exporting module.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ExportingOptions
    {
        /// <summary>
        /// Options for the export related buttons, print and export.
        /// </summary>
        public ButtonsOptions buttons { get; set; }

        /// <summary>
        /// Whether to enable images in the export. Including image point markers, background images etc. Defaults to false.
        /// </summary>
        public bool enableImages { get; set; }

        /// <summary>
        /// Whether to enable the exporting module. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// The filename, without extension, to use for the exported chart. Defaults to "chart".
        /// </summary>
        public JsString filename { get; set; }

        /// <summary>
        /// Default MIME type for exporting if chart.exportChart() is called without specifying a type option.
        /// Possible values are image/png, image/jpeg, application/pdf and image/svg+xml. Defaults to "image/png".
        /// </summary>
        public JsString type { get; set; }

        /// <summary>
        /// The URL for the server module converting the SVG string to an image format.
        /// By default this points to Highslide Software's free web service. Defaults to http://export.highcharts.com.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The pixel width of charts exported to PNG or JPG. . Defaults to 800.
        /// </summary>
        public JsNumber width { get; set; }
    }

    /// <summary>
    /// Options for the export related buttons, print and export.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ButtonsOptions
    {
        /// <summary>
        /// Options for the export button.
        /// </summary>
        public ExportButtonOptions exportButton { get; set; }

        /// <summary>
        /// Options for the print button.
        /// </summary>
        public PrintButtonOptions printButton { get; set; }

    }
    //TODO: check name

    /// <summary>
    /// Options for the export button.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ExportButtonOptions
    {
        /// <summary>
        /// Alignment for the buttons. Defaults to "right".
        /// </summary>
        public JsString align { get; set; }

        /// <summary>
        /// backgroundColor: ColorSince 2.0
        /// Background color or gradient for the buttons. Defaults to
        /// backgroundColor: {
        /// 	linearGradient: [0, 0, 0, 20],
        /// 	stops: [
        /// 		[0.4, '#F7F7F7'],
        /// 		[0.6, '#E3E3E3']
        /// 	]
        /// }
        /// </summary>
        public object backgroundColor { get; set; }

        /// <summary>
        /// The border color of the buttons. Defaults to "#B0B0B0".
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The border corner radius of the buttons. Defaults to 3.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The border width of the buttons. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// Whether to enable buttons. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Pixel height of the buttons. Defaults to 20.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// Color of the button border on hover. Defaults to #909090.
        /// </summary>
        public JsString hoverBorderColor { get; set; }

        /// <summary>
        /// See navigation.buttonOptions => hoverSymbolFill. Defaults to #768F3E.
        /// </summary>
        public JsString hoverSymbolFill { get; set; }

        /// <summary>
        /// Stroke (line) color for the symbol within the button on hover. Defaults to #4572A5.
        /// </summary>
        public JsString hoverSymbolStroke { get; set; }

        /// <summary>
        /// A collection of config options for the menu items.
        /// Each options object consists of a text option which is a string to show in the menu item, as well as an onclick parameter which is a callback function to run on click.
        /// By default, there is one menu item for each of the available export types.
        /// Menu items can be customized by defining a new array of items and assigning null to unwanted positions (see override example below).
        /// </summary>
        public JsArray<object> menuItems { get; set; }

        /// <summary>
        /// A click handler callback to use on the button directly instead of the popup menu.
        /// </summary>
        public JsAction onclick { get; set; }

        /// <summary>
        /// The symbol for the button. Points to a definition function in the Highcharts.Renderer.symbols collection.
        /// The default exportIcon function is part of the exporting module. Defaults to "exportIcon".
        /// </summary>
        public JsString symbol { get; set; }

        /// <summary>
        /// See navigation.buttonOptions => symbolFill. Defaults to #A8BF77.
        /// </summary>
        public JsString symbolFill { get; set; }

        /// <summary>
        /// The pixel size of the symbol on the button. Defaults to 12.
        /// </summary>
        public JsNumber symbolSize { get; set; }

        /// <summary>
        /// The color of the symbol's stroke or line. Defaults to "#A0A0A0".
        /// </summary>
        public JsString symbolStroke { get; set; }

        /// <summary>
        /// The pixel stroke width of the symbol on the button. Defaults to 1.
        /// </summary>
        public JsNumber symbolStrokeWidth { get; set; }

        /// <summary>
        /// The x position of the center of the symbol inside the button. Defaults to 11.5.
        /// </summary>
        public JsNumber symbolX { get; set; }

        /// <summary>
        /// The y position of the center of the symbol inside the button. Defaults to 10.5.
        /// </summary>
        public JsNumber symbolY { get; set; }

        /// <summary>
        /// The vertical alignment of the buttons. Can be one of "top", "middle" or "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The pixel width of the button. Defaults to 24.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The horizontal positioin of the button relative to the align option. Defaults to 10.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The vertical offset of the button's position relative to its verticalAlign.	 . Defaults to 10.
        /// </summary>
        public JsNumber y { get; set; }

    }
    //TODO: check name

    /// <summary>
    /// Options for the print button.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PrintButtonOptions
    {
        /// <summary>
        /// Alignment for the buttons. Defaults to "right".
        /// </summary>
        public JsString align { get; set; }

        /// <summary>
        /// backgroundColor: ColorSince 2.0
        /// Background color or gradient for the buttons. Defaults to
        /// backgroundColor: {
        /// 	linearGradient: [0, 0, 0, 20],
        /// 	stops: [
        /// 		[0.4, '#F7F7F7'],
        /// 		[0.6, '#E3E3E3']
        /// 	]
        /// }
        /// </summary>
        public object backgroundColor { get; set; }

        /// <summary>
        /// The border color of the buttons. Defaults to "#B0B0B0".
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The border corner radius of the buttons. Defaults to 3.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The border width of the buttons. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// Whether to enable buttons. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Pixel height of the buttons. Defaults to 20.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// Color of the button border on hover. Defaults to #909090.
        /// </summary>
        public JsString hoverBorderColor { get; set; }

        /// <summary>
        /// See navigation.buttonOptions => hoverSymbolFill. Defaults to #768F3E.
        /// </summary>
        public JsString hoverSymbolFill { get; set; }

        /// <summary>
        /// Stroke (line) color for the symbol within the button on hover. Defaults to #4572A5.
        /// </summary>
        public JsString hoverSymbolStroke { get; set; }

        /// <summary>
        /// A click handler callback to use on the button directly instead of the popup menu.
        /// </summary>
        public JsAction onclick { get; set; }

        /// <summary>
        /// The symbol for the button. Points to a definition function in the Highcharts.Renderer.symbols collection.
        /// The default exportIcon function is part of the exporting module. Defaults to "exportIcon".
        /// </summary>
        public JsString symbol { get; set; }

        /// <summary>
        /// See navigation.buttonOptions => symbolFill. Defaults to #A8BF77.
        /// </summary>
        public JsString symbolFill { get; set; }

        /// <summary>
        /// The pixel size of the symbol on the button. Defaults to 12.
        /// </summary>
        public JsNumber symbolSize { get; set; }

        /// <summary>
        /// The color of the symbol's stroke or line. Defaults to "#A0A0A0".
        /// </summary>
        public JsString symbolStroke { get; set; }

        /// <summary>
        /// The pixel stroke width of the symbol on the button. Defaults to 1.
        /// </summary>
        public JsNumber symbolStrokeWidth { get; set; }

        /// <summary>
        /// The x position of the center of the symbol inside the button. Defaults to 11.5.
        /// </summary>
        public JsNumber symbolX { get; set; }

        /// <summary>
        /// The y position of the center of the symbol inside the button. Defaults to 10.5.
        /// </summary>
        public JsNumber symbolY { get; set; }

        /// <summary>
        /// The vertical alignment of the buttons. Can be one of "top", "middle" or "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The pixel width of the button. Defaults to 24.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The horizontal positioin of the button relative to the align option. Defaults to 10.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The vertical offset of the button's position relative to its verticalAlign.	 . Defaults to 10.
        /// </summary>
        public JsNumber y { get; set; }

    }
    //TODO: check name

    /// <summary>
    /// The vertical alignment of the buttons. Can be one of "top", "middle" or "bottom". 
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum VerticalAlignType
    {
        top,
        middle,
        bottom,
    }

    #endregion

    #region global

    /// <summary>
    /// Global options that don't apply to each chart. These options, like the lang options, must be set using the Highcharts.setOptions method.
    /// Highcharts.setOptions({
    /// 	global: {
    /// 		useUTC: false
    /// 	}
    /// });
    /// </summary>
    [JsType(JsMode.Json)]
    public class GlobalOptions
    {
        /// <summary>
        /// Path to the pattern image required by VML browsers in order to draw radial gradients. Defaults to http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png.
        /// </summary>
        public JsString VMLRadialGradientURL { get; set; }

        /// <summary>
        /// The URL to the additional file to lazy load for Android 2.x devices.
        /// These devices don't support SVG, so we download a helper file that contains canvg, its dependecy rbcolor, and our own CanVG Renderer class.
        /// To avoid hotlinking to our site, you can install canvas-tools.js on your own server and change this option accordingly.
        /// Defaults to "http://www.highcharts.com/js/canvas-tools.js".
        /// </summary>
        public JsString canvasToolsURL { get; set; }

        /// <summary>
        /// Whether to use UTC time for axis scaling, tickmark placement and time display in Highcharts.dateFormat.
        /// Advantages of using UTC is that the time displays equally regardless of the user agent's time zone settings.
        /// Local time can be used when the data is loaded in real time or when correct Daylight Saving Time transitions are required. Defaults to true.
        /// </summary>
        public bool useUTC { get; set; }
    }

    #endregion

    #region labels

    /// <summary>
    /// HTML labels that can be positioined anywhere in the chart area.
    /// </summary>
    [JsType(JsMode.Json)]
    public class LabelsOptions
    {
        /// <summary>
        /// A HTML label that can be positioined anywhere in the chart area.
        /// </summary>
        public JsArray<ItemsOptions> items { get; set; }

        /// <summary>
        /// Shared CSS styles for all labels. Defaults to:
        /// style: {
        /// 	color: '#3E576F'
        /// }
        /// </summary>
        public object style { get; set; }
        //TODO: type?

    }

    /// <summary>
    /// A HTML label that can be positioined anywhere in the chart area.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ItemsOptions
    {

        /// <summary>
        /// Inner HTML or text for the label. Defaults to "".
        /// </summary>
        public JsString html { get; set; }

        /// <summary>
        /// CSS styles for each label. To position the label, use left and top like this:
        /// style: {
        /// 	left: '100px',
        /// 	top: '100px'
        /// }
        /// </summary>
        public object style { get; set; }
        //TODO: type?
    }

    #endregion

    #region lang

    /// <summary>
    /// Language object. The language object is global and it can't be set on each chart initiation. Instead, use Highcharts.setOptions to set it before any chart is initiated.
    /// Highcharts.setOptions({
    /// 	lang: {
    /// 		months: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 
    /// 			'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],
    /// 		weekdays: ['Dimanche', 'Lundi', 'Mardi', 'Mercredi', 'Jeudi', 'Vendredi', 'Samedi']
    /// 	}
    /// });
    /// </summary>
    [JsType(JsMode.Json)]
    public class LangOptions
    {
        /// <summary>
        /// The default decimal point used in the Highcharts.numberFormat method unless otherwise specified in the function arguments. Defaults to ".".
        /// </summary>
        public JsString decimalPoint { get; set; }

        /// <summary>
        /// Exporting module only. The text for the JPEG download menu item. Defaults to "Download JPEG image".
        /// </summary>
        public JsString downloadJPEG { get; set; }

        /// <summary>
        /// Exporting module only. The text for the PDF download menu item. Defaults to "Download PDF document".
        /// </summary>
        public JsString downloadPDF { get; set; }

        /// <summary>
        /// Exporting module only. The text for the PNG download menu item. Defaults to "Download PNG image".
        /// </summary>
        public JsString downloadPNG { get; set; }

        /// <summary>
        /// Exporting module only. The text for the SVG download menu item. Defaults to "Download SVG vector image".
        /// </summary>
        public JsString downloadSVG { get; set; }

        /// <summary>
        /// Exporting module only. The tooltip text for the export button. Defaults to "Export to raster or vector image".
        /// </summary>
        public JsString exportButtonTitle { get; set; }

        /// <summary>
        /// The loading text that appears when the chart is set into the loading state following a call to chart.showLoading. Defaults to Loading....
        /// </summary>
        public JsString loading { get; set; }

        /// <summary>
        /// An array containing the months names. Corresponds to the %B format in Highcharts.dateFormat().
        /// Defaults to ['January' 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],.
        /// </summary>
        public JsArray<JsString> months { get; set; }

        /// <summary>
        /// Metric prefixes used to shorten high numbers in axis labels. Defaults to ['k', 'M', 'G', 'T', 'P', 'E'].
        /// </summary>
        public JsArray<JsString> numericSymbols { get; set; }

        /// <summary>
        /// Exporting module only. The tooltip text for the print button. Defaults to "Print the chart".
        /// </summary>
        public JsString printButtonTitle { get; set; }

        /// <summary>
        /// The text for the label appearing when a chart is zoomed. Defaults to Reset zoom.
        /// </summary>
        public JsString resetZoom { get; set; }

        /// <summary>
        /// The tooltip title for the label appearing when a chart is zoomed. Defaults to Reset zoom level 1:1.
        /// </summary>
        public JsString resetZoomTitle { get; set; }

        /// <summary>
        /// An array containing the months names in abbreviated form. Corresponds to the %b format in Highcharts.dateFormat().
        /// Defaults to ['Jan' 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],.
        /// </summary>
        public JsArray<JsString> shortMonths { get; set; }

        /// <summary>
        /// The default thousands separator used in the Highcharts.numberFormat method unless otherwise specified in the function arguments. Defaults to ",". Defaults to "",.
        /// </summary>
        public JsString thousandsSep { get; set; }

        /// <summary>
        /// An array containing the weekday names. Defaults to ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'].
        /// Defaults to ['Sunday' 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'].
        /// </summary>
        public JsArray<JsString> Name { get; set; }
    }
    //TODO: danel- read class sammary!

    #endregion

    #region legend

    /// <summary>
    /// The legend is a box containing a symbol and name for each series item or point item in the chart.
    /// </summary>
    [JsType(JsMode.Json)]
    public class LegendOptions
    {
        /// <summary>
        /// The horizontal alignment of the legend box within the chart area. Defaults to "center".
        /// </summary>
        public JsString align { get; set; }

        /// <summary>
        /// The background color of the legend, filling the rounded corner border. Defaults to null.
        /// </summary>
        public JsString backgroundColor { get; set; }
        //TODO: type is color (?)

        /// <summary>
        /// The color of the drawn border around the legend. Defaults to #909090.
        /// </summary>
        public JsString borderColor { get; set; }
        //TODO: type is color (?)

        /// <summary>
        /// The border corner radius of the legend. Defaults to 5.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The width of the drawn border around the legend. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// Enable or disable the legend. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// When the legend is floating, the plot area ignores it and is allowed to be placed below it. Defaults to false.
        /// </summary>
        public bool floating { get; set; }

        /// <summary>
        /// CSS styles for each legend item when the corresponding series or point is hidden. Properties are inherited from style unless overridden here. Defaults to:
        /// itemHiddenStyle: {
        /// 	color: '#CCC'
        /// }
        /// </summary>
        public object itemHiddenStyle { get; set; }
        //TODO: type?

        /// <summary>
        /// CSS styles for each legend item in hover mode. Properties are inherited from style unless overridden here. Defaults to:
        /// itemHoverStyle: {
        /// 	color: '#000'
        /// }
        /// </summary>
        public object itemHoverStyle { get; set; }
        //TODO: type?

        /// <summary>
        /// The pixel bottom margin for each legend item. Defaults to 0.
        /// </summary>
        public JsNumber itemMarginBottom { get; set; }

        /// <summary>
        /// The pixel top margin for each legend item. Defaults to 0.
        /// </summary>
        public JsNumber itemMarginTop { get; set; }

        /// <summary>
        /// CSS styles for each legend item. Defaults to:
        /// itemStyle: {
        /// 	cursor: 'pointer',
        /// 	color: '#3E576F'
        /// }
        /// </summary>
        public object itemStyle { get; set; }
        //TODO: type?

        /// <summary>
        /// The width for each legend item. This is useful in a horizontal layout with many items when you want the items to align vertically. . Defaults to null.
        /// </summary>
        public JsNumber itemWidth { get; set; }

        /// <summary>
        /// Callback function to format each of the series' labels. The this keyword refers to the series object, or the point object in case of pie charts. Defaults to:
        /// labelFormatter: function() {
        /// 	return this.name
        /// }
        /// </summary>
        public JsAction labelFormatter { get; set; }

        /// <summary>
        /// The layout of the legend items. Can be one of "horizontal" or "vertical". Defaults to "horizontal".
        /// </summary>
        public LayoutType layout { get; set; }

        /// <summary>
        /// Line height for the legend items. Deprecated as of 2.1. Instead, the line height for each item can be set using itemStyle.lineHeight,
        /// and the padding between items using itemMarginTop and itemMarginBottom. Defaults to 16.
        /// </summary>
        public JsNumber lineHeight { get; set; }

        /// <summary>
        /// If the plot area sized is calculated automatically and the legend is not floating,
        /// the legend margin is the space between the legend and the axis labels or plot area. Defaults to 15.
        /// </summary>
        public JsNumber margin { get; set; }

        /// <summary>
        /// Maximum pixel height for the legend. When the maximum height is extended, navigation will show. Defaults to undefined.
        /// </summary>
        public JsNumber maxHeight { get; set; }

        /// <summary>
        /// Options for the paging or navigation appearing when the legend is overflown.
        /// </summary>
        public NavigationOptions navigation { get; set; }

        /// <summary>
        /// The inner padding of the legend box. Defaults to 8.
        /// </summary>
        public JsNumber padding { get; set; }

        /// <summary>
        /// Whether to reverse the order of the legend items compared to the order of the series or points as defined in the configuration object. Defaults to false.
        /// </summary>
        public bool reversed { get; set; }

        /// <summary>
        /// Whether to show the symbol on the right side of the text rather than the left side. This is common in Arabic and Hebraic. Defaults to false.
        /// </summary>
        public bool rtl { get; set; }

        /// <summary>
        /// Whether to apply a drop shadow to the legend. A backgroundColor also needs to be applied for this to take effect.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the legend. A backgroundColor also needs to be applied for this to take effect.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the legend. A backgroundColor also needs to be applied for this to take effect.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }

        /// <summary>
        /// CSS styles for the legend area. In the 1.x versions the position of the legend area was determined by CSS. In 2.x,
        /// the position is determined by properties like align, verticalAlign, x and y, but the styles are still parsed for backwards compatibility.
        /// </summary>
        public object style { get; set; }
        //TODO: type?

        /// <summary>
        /// The pixel padding between the legend item symbol and the legend item text. Defaults to 5.
        /// </summary>
        public JsNumber symbolPadding { get; set; }

        /// <summary>
        /// The pixel width of the legend item symbol. Defaults to 30.
        /// </summary>
        public JsNumber symbolWidth { get; set; }

        /// <summary>
        /// The vertical alignment of the legend box. Can be one of "top", "middle" or "bottom". Vertical position can be further determined by the y option. Defaults to "bottom".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The width of the legend box, not including style.padding. . Defaults to null.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The x offset of the legend relative to it's horizontal alignment align within chart.spacingLeft and chart.spacingRight.
        /// Negative x moves it to the left, positive x moves it to the right.
        /// The default value of 15 together with align: "center" puts it in the center of the plot area. Defaults to 0.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The vertical offset of the legend relative to it's vertical alignment verticalAlign within chart.spacingTop and chart.spacingBottom.
        /// Negative y moves it up, positive y moves it down. Defaults to 0.
        /// </summary>
        public JsNumber y { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum LayoutType
    {
        horizontal,
        vertical,
    }

    /// <summary>
    /// Options for the paging or navigation appearing when the legend is overflown.
    /// </summary>
    [JsType(JsMode.Json)]
    public class NavigationOptions
    {
        /// <summary>
        /// The color for the active up or down arrow in the legend page navigation. Defaults to #3E576F.
        /// </summary>
        public JsString activeColor { get; set; }

        /// <summary>
        /// How to animate the pages when navigating up or down. A value of true applies the default navigation given in the chart.animation option.
        /// Additional options can be given as an object containing values for easing and duration. . Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// How to animate the pages when navigating up or down. A value of true applies the default navigation given in the chart.animation option.
        /// Additional options can be given as an object containing values for easing and duration. . Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }
        /// <summary>
        /// How to animate the pages when navigating up or down. A value of true applies the default navigation given in the chart.animation option.
        /// Additional options can be given as an object containing values for easing and duration. . Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }

        /// <summary>
        /// The pixel size of the up and down arrows in the legend paging navigation. . Defaults to 12.
        /// </summary>
        public JsNumber arrowSize { get; set; }

        /// <summary>
        /// The color of the inactive up or down arrow in the legend page navigation. . Defaults to #CCC.
        /// </summary>
        public JsString inactiveColor { get; set; }

        /// <summary>
        /// Text styles for the legend page navigation.
        /// </summary>
        public object style { get; set; }
        //TODO: type?

    }

    #endregion

}
