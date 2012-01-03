using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace SharpKitGridSample
{
    /// <summary>
    /// Grid control, features:
    /// <list>
    /// <item>Highly optimized for legacy browser (IE7+8)</item>
    /// </list>
    /// <para>Flat mode design: single HTML Table, TableRow for every row</para>
    /// </summary>
    /// <example>
    /// HTML
    /// <code>
    /// &lt;table id="tblGrid">
    /// &lt;tbody style="display:none">
    ///     &lt;tr id="RowTemplate">
    ///        &lt;td>&lt;a onmousedown="AttJs.WCM.Controls.Grid.btnExpander_click(this, event);">&lt;/a>&lt;/td>
    ///        &lt;td>My Row Tempalte&lt;/td>
    ///      &lt;/tr>
    ///&lt;/tbody>
    ///&lt;/table>
    ///</code>
    ///C#
    ///<code>
    ///var grid = new Grid{Element=document.getElementById("tblGrid")};
    ///grid.Render();
    ///grid.AddRow(new GridRow{Element=grid.CreateRow(document.getElementById("RowTemplate")});
    /// </code>
    /// </example>
    [JsType(JsMode.Prototype, Filename = "Grid.js")]
    public class Grid : HtmlContext
    {
        /// <summary>
        /// Creates a new instance of Grid, Element property must be set to a TABLE element, Render() must be called
        /// </summary>
        public Grid()
        {
             Rows = new JsArray<GridRow>();
        }
        /// <summary>
        /// Topmost container element (TABLE) for the grid, needs to be set when creating a new grid
        /// </summary>
        public HtmlElement Element { get; set; }
        /// <summary>
        /// A TBody element for the grid rows
        /// </summary>
        public HtmlElement GridBody { get; set; }
        /// <summary>
        /// Gets the collection of rows contained in the grid, in hierarchial mode, only parent rows will be here.
        /// </summary>
        public JsArray<GridRow> Rows { get; set; }
        /// <summary>
        /// Renders the grid for the first time, this method needs to be called after initializing all values on a new grid
        /// </summary>
        public void Render()
        {
            if (Element == null)
                return;
            Element["_Grid"] = this;
            if (GridBody == null || GridBody.nodeName != "TBODY")
            {
                GridBody = document.createElement("TBODY");
                Element.appendChild(GridBody);
            }
        }
        /// <summary>
        /// Finds the closest GridRow object to this element (moves up the element DOM)
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        public static GridRow FindGridRow(HtmlElement el)
        {
            var row = el.FindExtension<GridRow>("_GridRow");
            return row;
        }
        /// <summary>
        /// Deletes all rows in the grid
        /// </summary>
        public void DeleteAllRows()
        {
            if (GridBody != null)
                GridBody.EmptyFast();
            if (Rows != null)
            {
                foreach (var gr in Rows)
                {
                    if (gr.Element != null)
                        gr.Element["_GridRow"] = null;
                }
                Rows.Clear();
            }
        }
        /// <summary>
        /// Creates a row from a row template to assign in GridRow.Element property
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public HtmlElement CreateRowElement(HtmlElement template)
        {
            return template.cloneNode(true);
        }
        /// <summary>
        /// Adds a new row to the grid
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="grParent"></param>
        public void AddRow(GridRow gr)
        {
            var body = GridBody;
            var lastRow = Rows.GetLast();
            var lastChild = lastRow != null ? lastRow.Element : null;
            body.AppendChildFast(gr.Element, lastChild);
            gr.Element["_GridRow"] = gr;
            Rows.push(gr);
            gr.IsVisible = true;
        }
        /// <summary>
        /// Deletes a row from the grid
        /// </summary>
        /// <param name="gr"></param>
        public void DeleteRow(GridRow gr)
        {
                gr.Element.parentNode.removeChild(gr.Element);
            Rows.Remove(gr);
            gr.Element["_GridRow"] = null;
        }
        /// <summary>
        /// Shows and hides rows
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="isVisible"></param>
        public void ShowHideRows(JsArray<GridRow> rows, bool isVisible)
        {
            for (int i = 0; i < rows.length; i++)
            {
                var row = rows[i];
                if (row.IsVisible == isVisible)
                    continue;
                row.IsVisible = isVisible;
                if (isVisible)
                    row.Element.style.display = "";
                else
                    row.Element.style.display = "none";
            }
        }
    }

    /// <summary>
    /// A json object containing all data and DOM information related to a row in a Grid control
    /// </summary>
    [JsType(JsMode.Json)]
    public class GridRow
    {
        /// <summary>
        /// The element containing the GridRow, should be a TableRow (TR) element
        /// </summary>
        public HtmlElement Element { get; set; }
        /// <summary>
        /// A data object associated with this GridRow
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// Gets a value indicating if the current row is visible
        /// </summary>
        public bool IsVisible { get; set; }
    }

    [JsType(JsMode.Prototype, Filename = "Grid.js")]
    static class Extensions
    {
        static bool HasInnerText;
        static bool HasInsertAdjacentElement;
        static Extensions()
        {
            HtmlContext.window.setTimeout(() =>
            {
                var el = HtmlContext.document.createElement("a");
                HasInsertAdjacentElement = new JsNativeAction<JsString, HtmlElement>(el.insertAdjacentElement) != null;
                HasInnerText = JsContext.@typeof(el.innerText) != "undefined";
            }, 0);
        }
        public static void SetExtension<T>(this HtmlElement el, string name, T value)
        {
            el[name] = value;
        }
        public static T GetExtension<T>(this HtmlElement el, string name)
        {
            return el[name].As<T>();
        }
        public static T FindExtension<T>(this HtmlElement el, string name)
        {
            var el2 = el.FindParent(t => t[name] != null);
            if (el2 == null)
                return el2.As<T>();
            return el2[name].As<T>();
        }

        public static void InnerTextFast(this HtmlElement el, JsString text)
        {
            if (HasInnerText)
                el.innerText = text;
            else
                el.textContent = text;
        }
        /// <summary>
        /// deletes all children fast
        /// </summary>
        /// <param name="el"></param>
        /// <param name="text"></param>
        public static void EmptyFast(this HtmlElement el)
        {
            var ch = el.firstChild;
            // Remove any remaining nodes
            while (ch != null)
            {
                el.removeChild(ch);
                ch = el.firstChild;
            }
        }

        public static void AppendChildFast(this HtmlElement el, HtmlElement newElement, HtmlElement lastChild)
        {
            if (lastChild != null && HasInsertAdjacentElement)
                lastChild.insertAdjacentElement("afterEnd", newElement);
            else
                el.appendChild(newElement);
        }

        public static void AppendAfterSelf(this HtmlElement el, HtmlElement newElement)
        {
            el.parentNode.insertBefore(newElement, el.nextSibling);
            //el.insertAdjacentElement("afterEnd", newElement);
        }
        public static void AppendBeforeSelf(this HtmlElement el, HtmlElement newElement)
        {
            el.parentNode.insertBefore(newElement, el);
            //el.insertAdjacentElement("beforeStart", newElement);
        }

        public static HtmlElement FindParent(this HtmlElement el, JsFunc<HtmlElement, bool> selector)
        {
            while (el != null)
            {
                if (selector(el))
                    return el;
                el = el.parentNode;
            }
            return null;
        }
        public static T GetLast<T>(this JsArray<T> list) where T : class
        {
            var length = list.length;
            if (length == 0)
                return null;
            return list[length - 1];
        }
        public static void Insert<T>(this JsArray<T> list, JsNumber index, T item) where T : class
        {
            list.splice(index, 0, item);
        }
        public static JsNumber Remove<T>(this JsArray<T> list, T item) where T : class
        {
            for (var i = 0; i < list.length; i++)
            {
                if (list[i] == item)
                {
                    list.splice(i, 1);
                    return i;
                }
            }
            return -1;
        }
        public static JsNumber IndexOf<T>(this JsArray<T> list, T item) where T : class
        {
            for (var i = 0; i < list.length; i++)
            {
                if (list[i] == item)
                    return i;
            }
            return -1;
        }
        public static void Clear<T>(this JsArray<T> list) where T : class
        {
            list.splice(0, list.length);
        }

    }

}