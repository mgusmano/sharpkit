// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.navigation
{
    /// <summary>
	/// <para>Very basic navigation manager. Still work in progress.</para>
	/// <para>Define routes to react on certain GET / POST / DELETE / PUT operations.</para>
	/// <list type="bullet">
	/// <item>GET is triggered when the hash value of the url is changed. Can be called
	/// manually by calling the <see cref="ExecuteGet"/> method.</item>
	/// <item>POST / DELETE / PUT has to be triggered manually right now (will be changed later)
	/// by calling the <see cref="ExecutePost"/>, <see cref="ExecuteDelete"/>, <see cref="ExecutePut"/> method.</item>
	/// </list
	/// <para>This manager can also be used to provide browser history.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var nm = qx.ui.mobile.navigation.Manager.getInstance();
	/// // show the start page, when no hash is given or the hash is "#/"
	/// nm.onGet("/", function(data) {
	/// startPage.show();
	/// },this);
	/// // whenever the url /address is called show the addressbook page.
	/// nm.onGet("/address", function(data)
	/// {
	/// addressBookPage.show();
	/// },this);
	/// // address with the parameter "id"
	/// nm.onGet("/address/:id", function(data)
	/// {
	/// addressPage.show();
	/// model.loadAddress(data.params.id);
	/// },this);
	/// // Alternative you can use regExp for a route
	/// nm.onGet(/address\/(.*)/, function(data)
	/// {
	/// addressPage.show();
	/// model.loadAddress(data.params.0);
	/// },this);
	/// // make sure that the data is always loaded
	/// nm.onGet("/address.*", function(data)
	/// {
	/// if (!model.isLoaded()) {
	/// model.loadAddresses();
	/// }
	/// },this);
	/// // update the address
	/// nm.onPost("/address/:id, function(data)
	/// {
	/// model.updateAddress(data.params.id);
	/// },this);
	/// // delete the address and navigate back
	/// nm.onDelete("/address/:id, function(data)
	/// {
	/// model.deleteAddress(data.params.id);
	/// nm.executeGet("/address", {reverse:true});
	/// },this);
	/// </code>
	/// <para>This example defines different routes to handle navigation events.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.navigation.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager : qx.core.Object
    {
		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the singleton instance of the navigation manager.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getInstance")]
		public static qx.ui.mobile.navigation.Manager GetInstance() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Executes the delete operation and informs all matching route handler.</para>
		/// </summary>
		/// <param name="path">The path to execute</param>
		/// <param name="paramsx">The given parameters that should be propagated</param>
		/// <param name="customData">The given custom data that should be propagated</param>
		[JsMethod(Name = "executeDelete")]
		public void ExecuteDelete(string path, object paramsx, object customData) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Executes the get operation and informs all matching route handler.</para>
		/// </summary>
		/// <param name="path">The path to execute</param>
		/// <param name="customData">The given custom data that should be propagated</param>
		[JsMethod(Name = "executeGet")]
		public void ExecuteGet(string path, object customData) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Executes the post operation and informs all matching route handler.</para>
		/// </summary>
		/// <param name="path">The path to execute</param>
		/// <param name="paramsx">The given parameters that should be propagated</param>
		/// <param name="customData">The given custom data that should be propagated</param>
		[JsMethod(Name = "executePost")]
		public void ExecutePost(string path, object paramsx, object customData) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Executes the put operation and informs all matching route handler.</para>
		/// </summary>
		/// <param name="path">The path to execute</param>
		/// <param name="paramsx">The given parameters that should be propagated</param>
		/// <param name="customData">The given custom data that should be propagated</param>
		[JsMethod(Name = "executePut")]
		public void ExecutePut(string path, object paramsx, object customData) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current path behind the # hash.</para>
		/// </summary>
		/// <returns>The current hash path</returns>
		[JsMethod(Name = "getCurrentGetPath")]
		public string GetCurrentGetPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a route handler for the &#8220;any&#8221; operation. The &#8220;any&#8221; operation is called
		/// before all other operations.</para>
		/// </summary>
		/// <param name="route">The route, used for checking if the executed path matches</param>
		/// <param name="handler">The handler to call, when the route matches with the executed path</param>
		/// <param name="scope">The scope of the handler</param>
		/// <returns>The route ID</returns>
		[JsMethod(Name = "onAny")]
		public double OnAny(object route, Action<object> handler, object scope) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a route handler for the &#8220;delete&#8221; operation. The route gets called
		/// when the <see cref="ExecuteDelete"/> method found a match.</para>
		/// </summary>
		/// <param name="route">The route, used for checking if the executed path matches</param>
		/// <param name="handler">The handler to call, when the route matches with the executed path</param>
		/// <param name="scope">The scope of the handler</param>
		/// <returns>The route ID</returns>
		[JsMethod(Name = "onDelete")]
		public double OnDelete(object route, Action<object> handler, object scope) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a route handler for the &#8220;get&#8221; operation. The route gets called
		/// when the <see cref="ExecuteGet"/> method found a match.</para>
		/// </summary>
		/// <param name="route">The route, used for checking if the executed path matches</param>
		/// <param name="handler">The handler to call, when the route matches with the executed path</param>
		/// <param name="scope">The scope of the handler</param>
		/// <returns>The route ID</returns>
		[JsMethod(Name = "onGet")]
		public double OnGet(object route, Action<object> handler, object scope) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a route handler for the &#8220;post&#8221; operation. The route gets called
		/// when the <see cref="ExecutePost"/> method found a match.</para>
		/// </summary>
		/// <param name="route">The route, used for checking if the executed path matches</param>
		/// <param name="handler">The handler to call, when the route matches with the executed path</param>
		/// <param name="scope">The scope of the handler</param>
		/// <returns>The route ID</returns>
		[JsMethod(Name = "onPost")]
		public double OnPost(object route, Action<object> handler, object scope) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a route handler for the &#8220;put&#8221; operation. The route gets called
		/// when the <see cref="ExecutePut"/> method found a match.</para>
		/// </summary>
		/// <param name="route">The route, used for checking if the executed path matches</param>
		/// <param name="handler">The handler to call, when the route matches with the executed path</param>
		/// <param name="scope">The scope of the handler</param>
		/// <returns>The route ID</returns>
		[JsMethod(Name = "onPut")]
		public double OnPut(object route, Action<object> handler, object scope) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes a registered route by the given id.</para>
		/// </summary>
		/// <param name="id">The id of the registered route</param>
		[JsMethod(Name = "remove")]
		public void Remove(string id) { throw new NotImplementedException(); }

		#endregion Methods
    }
}