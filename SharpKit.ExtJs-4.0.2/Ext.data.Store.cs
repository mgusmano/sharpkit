//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region Store
    /// <summary>
    /// The Store class encapsulates a client side cache of Model objects. Stores load
    /// data via a Proxy, and also provide functions for sorting,
    /// filtering and querying the model instances contained within it. Creating a Store is easy - we just tell it the Model and the Proxy to use to load and save its data: // Set up a model to use in our Store
    /// Ext.define(&#39;User&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// {name: &#39;firstName&#39;, type: &#39;string&#39;},
    /// {name: &#39;lastName&#39;,  type: &#39;string&#39;},
    /// {name: &#39;age&#39;,       type: &#39;int&#39;},
    /// {name: &#39;eyeColor&#39;,  type: &#39;string&#39;}
    /// ]
    /// });
    /// var myStore = new Ext.data.Store({
    /// model: &#39;User&#39;,
    /// proxy: {
    /// type: &#39;ajax&#39;,
    /// url : &#39;/users.json&#39;,
    /// reader: {
    /// type: &#39;json&#39;,
    /// root: &#39;users&#39;
    /// }
    /// },
    /// autoLoad: true
    /// });
    /// In the example above we configured an AJAX proxy to load data from the url &#39;/users.json&#39;. We told our Proxy
    /// to use a JsonReader to parse the response from the server into Model object -
    /// see the docs on JsonReader for details. Inline data Stores can also load data inline. Internally, Store converts each of the objects we pass in as data
    /// into Model instances: new Ext.data.Store({
    /// model: &#39;User&#39;,
    /// data : [
    /// {firstName: &#39;Ed&#39;,    lastName: &#39;Spencer&#39;},
    /// {firstName: &#39;Tommy&#39;, lastName: &#39;Maintz&#39;},
    /// {firstName: &#39;Aaron&#39;, lastName: &#39;Conran&#39;},
    /// {firstName: &#39;Jamie&#39;, lastName: &#39;Avins&#39;}
    /// ]
    /// });
    /// Loading inline data using the method above is great if the data is in the correct format already (e.g. it doesn&#39;t need
    /// to be processed by a reader). If your inline data requires processing to decode the data structure,
    /// use a MemoryProxy instead (see the MemoryProxy docs for an example). Additional data can also be loaded locally using add. Loading Nested Data Applications often need to load sets of associated data - for example a CRM system might load a User and her Orders.
    /// Instead of issuing an AJAX request for the User and a series of additional AJAX requests for each Order, we can load a nested dataset
    /// and allow the Reader to automatically populate the associated models. Below is a brief example, see the Ext.data.reader.Reader intro
    /// docs for a full explanation: var store = new Ext.data.Store({
    /// autoLoad: true,
    /// model: &quot;User&quot;,
    /// proxy: {
    /// type: &#39;ajax&#39;,
    /// url : &#39;users.json&#39;,
    /// reader: {
    /// type: &#39;json&#39;,
    /// root: &#39;users&#39;
    /// }
    /// }
    /// });
    /// Which would consume a response like this: {
    /// &quot;users&quot;: [
    /// {
    /// &quot;id&quot;: 1,
    /// &quot;name&quot;: &quot;Ed&quot;,
    /// &quot;orders&quot;: [
    /// {
    /// &quot;id&quot;: 10,
    /// &quot;total&quot;: 10.76,
    /// &quot;status&quot;: &quot;invoiced&quot;
    /// },
    /// {
    /// &quot;id&quot;: 11,
    /// &quot;total&quot;: 13.45,
    /// &quot;status&quot;: &quot;shipped&quot;
    /// }
    /// ]
    /// }
    /// ]
    /// }
    /// See the Ext.data.reader.Reader intro docs for a full explanation. Filtering and Sorting Stores can be sorted and filtered - in both cases either remotely or locally. The sorters and filters are
    /// held inside MixedCollection instances to make them easy to manage. Usually it is sufficient to
    /// either just specify sorters and filters in the Store configuration or call sort or filter:
    /// var store = new Ext.data.Store({
    /// model: &#39;User&#39;,
    /// sorters: [
    /// {
    /// property : &#39;age&#39;,
    /// direction: &#39;DESC&#39;
    /// },
    /// {
    /// property : &#39;firstName&#39;,
    /// direction: &#39;ASC&#39;
    /// }
    /// ],
    /// filters: [
    /// {
    /// property: &#39;firstName&#39;,
    /// value   : /Ed/
    /// }
    /// ]
    /// });
    /// The new Store will keep the configured sorters and filters in the MixedCollection instances mentioned above. By default, sorting
    /// and filtering are both performed locally by the Store - see remoteSort and remoteFilter to allow the server to
    /// perform these operations instead. Filtering and sorting after the Store has been instantiated is also easy. Calling filter adds another filter to the Store
    /// and automatically filters the dataset (calling filter with no arguments simply re-applies all existing filters). Note that by
    /// default sortOnFilter is set to true, which means that your sorters are automatically reapplied if using local sorting. store.filter(&#39;eyeColor&#39;, &#39;Brown&#39;);
    /// Change the sorting at any time by calling sort: store.sort(&#39;height&#39;, &#39;ASC&#39;);
    /// Note that all existing sorters will be removed in favor of the new sorter data (if sort is called with no arguments,
    /// the existing sorters are just reapplied instead of being removed). To keep existing sorters and add new ones, just add them
    /// to the MixedCollection: store.sorters.add(new Ext.util.Sorter({
    /// property : &#39;shoeSize&#39;,
    /// direction: &#39;ASC&#39;
    /// }));
    /// store.sort();
    /// Registering with StoreManager Any Store that is instantiated with a storeId will automatically be registed with the StoreManager.
    /// This makes it easy to reuse the same store in multiple views: //this store can be used several times
    /// new Ext.data.Store({
    /// model: &#39;User&#39;,
    /// storeId: &#39;usersStore&#39;
    /// });
    /// new Ext.List({
    /// store: &#39;usersStore&#39;,
    /// //other config goes here
    /// });
    /// new Ext.view.View({
    /// store: &#39;usersStore&#39;,
    /// //other config goes here
    /// });
    /// Further Reading Stores are backed up by an ecosystem of classes that enables their operation. To gain a full understanding of these
    /// pieces and how they fit together, see:  Proxy - overview of what Proxies are and how they are used Model - the core class in the data package Reader - used by any subclass of ServerProxy to read a response
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Store : AbstractStore, Ext.util.Observable, Ext.util.Sortable
    {
        /// <summary>
        /// Creates the store. ...
        /// </summary>
        public object constructor(object config=null){return null;}
        /// <summary>
        /// Clear any groupers in the store ...
        /// </summary>
        public object clearGrouping(){return null;}
        /// <summary>
        /// Collects unique values for a particular dataIndex from this store. ...
        /// </summary>
        public JsArray collect(JsString dataIndex, bool allowNull=false, bool bypassFilter=false){return null;}
        /// <summary>
        /// Calls the specified function for each of the Records in the cache. ...
        /// </summary>
        public object each(JsAction fn, object scope=null){return null;}
        /// <summary>
        /// Filter by a function. ...
        /// </summary>
        public object filterBy(JsAction fn, object scope=null){return null;}
        /// <summary>
        /// Find the index of the first matching Record in this Store by a function. ...
        /// </summary>
        public JsNumber findBy(JsAction fn, object scope=null, JsNumber startIndex=null){return null;}
        /// <summary>
        /// Finds the index of the first matching Record in this store by a specific field value. ...
        /// </summary>
        public JsNumber findExact(JsString fieldName, object value, JsNumber startIndex=null){return null;}
        /// <summary>
        /// Gets the number of cached records. ...
        /// </summary>
        public JsNumber getCount(){return null;}
        /// <summary>
        /// Returns a range of Records between specified indices. ...
        /// </summary>
        public Ext.data.Model getRange(JsNumber startIndex=null, JsNumber endIndex=null){return null;}
        /// <summary>
        /// Returns the total number of Model instances that the Proxy
        /// indicates exist. ...
        /// </summary>
        public JsNumber getTotalCount(){return null;}
        /// <summary>
        /// Returns the number of pending requests out. ...
        /// </summary>
        public object hasPendingRequests(){return null;}
        /// <summary>
        /// Returns true if this store is currently filtered ...
        /// </summary>
        public bool isFiltered(){return false;}
        /// <summary>
        /// Checks if the store is currently grouped ...
        /// </summary>
        public bool isGrouped(){return false;}
        /// <summary>
        /// Loads the next 'page' in the current data set ...
        /// </summary>
        public object nextPage(){return null;}
        /// <summary>
        /// Loads the previous 'page' in the current data set ...
        /// </summary>
        public object previousPage(){return null;}
        /// <summary>
        /// Purge the least recently used records in the prefetch if the purgeCount
        /// has been exceeded. ...
        /// </summary>
        public object purgeRecords(){return null;}
        /// <summary>
        /// Query the cached records in this Store using a filtering function. ...
        /// </summary>
        public MixedCollection queryBy(JsAction fn, object scope=null){return null;}
        public JsNumber currentPage{get;set;}
        public Ext.util.MixedCollection data{get;set;}
        /// <summary>
        /// The direction in which sorting should be applied when grouping. ...
        /// </summary>
        public JsString groupDir{get;set;}
        /// <summary>
        /// The (optional) field by which to group data in the store. ...
        /// </summary>
        public JsString groupField{get;set;}
        public Ext.util.MixedCollection groupers{get;set;}
        /// <summary>
        /// A pristine (unfiltered) collection of the records in this store. ...
        /// </summary>
        public Ext.util.MixedCollection snapshot{get;set;}
    }
    #endregion
    #region StoreConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class StoreConfig
    {
        /// <summary>
        /// Allow the store to buffer and pre-fetch pages of records. ...
        /// </summary>
        public bool buffered{get;set;}
        /// <summary>
        /// True to empty the store when loading another page via loadPage,
        /// nextPage or previousPage (defaults to true). ...
        /// </summary>
        public bool clearOnPageLoad{get;set;}
        /// <summary>
        /// Optional array of Model instances or data objects to load locally. ...
        /// </summary>
        public JsArray data{get;set;}
        public JsString model{get;set;}
        /// <summary>
        /// The number of records considered to form a 'page'. ...
        /// </summary>
        public JsNumber pageSize{get;set;}
        /// <summary>
        /// The Proxy to use for this Store. ...
        /// </summary>
        public object proxy{get;set;}
        /// <summary>
        /// The number of pages to keep in the cache before purging additional records. ...
        /// </summary>
        public JsNumber purgePageCount{get;set;}
        /// <summary>
        /// True to defer any filtering operation to the server. ...
        /// </summary>
        public bool remoteFilter{get;set;}
        /// <summary>
        /// True if the grouping should apply on the server side, false if it is local only (defaults to false). ...
        /// </summary>
        public bool remoteGroup{get;set;}
        /// <summary>
        /// True to defer any sorting operation to the server. ...
        /// </summary>
        public bool remoteSort{get;set;}
        /// <summary>
        /// For local filtering only, causes sort to be called whenever filter is called,
        /// causing the sorters to be reapplied aft...
        /// </summary>
        public bool sortOnFilter{get;set;}
    }
    #endregion
    #region StoreEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class StoreEvents
    {
        /// <summary>
        /// Fires before a prefetch occurs. ...
        /// </summary>
        public static JsString beforeprefetch="beforeprefetch";
        /// <summary>
        /// Fired whenever the grouping in the grid changes ...
        /// </summary>
        public static JsString groupchange="groupchange";
        /// <summary>
        /// Fires whenever records have been prefetched ...
        /// </summary>
        public static JsString load="load";
    }
    #endregion
}
#endregion
