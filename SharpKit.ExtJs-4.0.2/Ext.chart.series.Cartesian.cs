//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.series
namespace Ext.chart.series
{
    #region Cartesian
    /// <summary>
    /// Common base class for series implementations which plot values using x/y coordinates.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Cartesian : Series, Ext.util.Observable, Ext.chart.Label, Highlight, Ext.chart.Tip, Callout
    {
        public JsString axis{get;set;}
        public JsString xField{get;set;}
        public JsString yField{get;set;}
        public Cartesian(CartesianConfig config){}
        public Cartesian(){}
    }
    #endregion
    #region CartesianConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CartesianConfig : SeriesConfig
    {
    }
    #endregion
    #region CartesianEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CartesianEvents : SeriesEvents
    {
    }
    #endregion
}
#endregion
