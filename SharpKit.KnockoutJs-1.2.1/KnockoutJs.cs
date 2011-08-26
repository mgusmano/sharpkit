using SharpKit.Html4;
using SharpKit.JavaScript;

namespace SharpKit.KnockoutJs
{
    [JsType(JsMode.Prototype, Export = false)]
    public interface IDisposable
    {
        void dispose();
    }
	/// <summary>
	/// Represents a custom binding handler in Knockout.
	/// </summary>
	[JsType(JsMode.Prototype, Export=false)]
	public abstract class BindingHandler
	{
		/// <summary>
		/// Performs one time initialization for a binding.
		/// </summary>
		/// <param name="element">The element involved in this binding.</param>
		/// <param name="valueAccessor">A function which returns the model property that is involved in this binding.</param>
		/// <param name="allBindingsAccessor">A function which returns all the model properties bound to this element.</param>
		/// <param name="viewModel">The view model instance involved in this binding.</param>
        public virtual void init(HtmlElement element, JsFunc<object> valueAccessor, JsFunc<JsObject> allBindingsAccessor, object viewModel)
		{
		}
		/// <summary>
		/// Invoked whenever an observable associated with this binding changes.
		/// </summary>
		/// <param name="element">The element involved in this binding.</param>
		/// <param name="valueAccessor">A function which returns the model property that is involved in this binding.</param>
		/// <param name="allBindingsAccessor">A function which returns all the model properties bound to this element.</param>
		/// <param name="viewModel">The view model instance involved in this binding.</param>
		public virtual void update(HtmlElement element, JsFunc<object> valueAccessor, JsFunc<JsObject> allBindingsAccessor, object viewModel)
		{
		}
	}
	/// <summary>
	/// Represents an object containing a value dependent on other observable values.
	/// </summary>
	/// <typeparam name="T">The type of the contained value.</typeparam>
    [JsType(JsMode.Prototype, Export=false)]
    public sealed class DependentObservable<T>
	{
		private DependentObservable()
		{
		}
		/// <summary>
		/// Gets the current computed value.
		/// </summary>
		/// <returns>The current value.</returns>
		[JsMethod(Name="")]
		public T GetValue()
		{
			return default(T);
		}
		/// <summary>
		/// Subscribes to change notifications raised when the value changes.
		/// </summary>
		/// <param name="changeCallback">The callback to invoke.</param>
		/// <returns>A subscription cookie that can be disposed to unsubscribe.</returns>
		public IDisposable subscribe(JsAction<T> changeCallback)
		{
			return null;
		}
	}

	/// <summary>
	/// Provides advanced options for defining a dependent observable.
	/// </summary>
	/// <typeparam name="T">The type of the observable value.</typeparam>
    [JsType(JsMode.Prototype, Export=false)]
    public sealed class DependentObservableOptions<T>
	{
		/// <summary>
		/// Gets or sets whether the evaluation should be deferred, i.e. not
		/// performed when the observable is first created.
		/// </summary>
		public bool deferEvaluation
		{
			get;
			set;
		}
		/// <summary>
		/// Gets or sets the function to compute the value.
		/// </summary>
		public JsFunc<T> read
		{
			get;
			set;
		}
		/// <summary>
		/// Gets the model instance which acts as 'this' in the get value function.
		/// </summary>
        public object owner
		{
			get;
			set;
		}
	}
	/// <summary>
	/// Provides Knockout functionality.
	/// </summary>
    [JsType(JsMode.Prototype, Name="ko")]
    public class Knockout
	{
        /// <summary>
        /// Converts a model into the equivalent JSON representation.
        /// </summary>
        /// <param name="model">The model object to convert.</param>
        /// <returns>The JSON string representing the model data.</returns>
        public static string toJSON(object model)
        {
            return null;
        }
        /// <summary>
        /// Converts a model into the equivalent vanilla script object.
        /// </summary>
        /// <param name="model">The model object to convert.</param>
        /// <returns>The vanilla script object representing the model data.</returns>
        public static object toJS(object model)
        {
            return null;
        }

		/// <summary>
		/// Provides access to the currently registered binding handlers.
		/// </summary>
		public static JsObject<string, BindingHandler> bindingHandlers{get;private set;}
		/// <summary>
		/// Gets the mapping plugin which allows converting models to plain
		/// objects and JSON and vice-versa.
		/// </summary>
        public static KnockoutMapping mapping{get;private set;}

		public static object @this
		{
			get
			{
				return null;
			}
		}
		/// <summary>
		/// Sets up bindings using the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		public static void applyBindings(object model)
		{
		}
		/// <summary>
		/// Sets up bindings within the specified root element using the specified the model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="rootElement">The element to bind to.</param>
		public static void applyBindings(object model, HtmlElement rootElement)
		{
		}
		/// <summary>
		/// Set up bindings on a single node without binding any of its descendents.
		/// </summary>
		/// <param name="node">The node to bind to.</param>
		/// <param name="bindings">An optional dictionary of bindings, pass null to let Knockout gather them from the element.</param>
		/// <param name="viewModel">The view model instance.</param>
        public static void applyBindingsToNode(HtmlElement node, JsObject bindings, object viewModel)
		{
		}
		/// <summary>
		/// Set up bindings on a single node without binding any of its descendents.
		/// </summary>
		/// <param name="node">The node to bind to.</param>
		/// <param name="bindings">An optional dictionary of bindings, pass null to let Knockout gather them from the element.</param>
		/// <param name="viewModel">The view model instance.</param>
		/// <param name="bindingAttributeName">The name of the attribute which has the binding definitions.</param>
        public static void ApplyBindingsToNode(HtmlElement node, JsObject bindings, object viewModel, string bindingAttributeName)
		{
		}
		/// <summary>
		/// Creates an observable with a value computed from one or more other values.
		/// </summary>
		/// <typeparam name="T">The type of the observable value.</typeparam>
		/// <param name="function">A function to compute the value.</param>
		/// <returns>A new dependent observable instance.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static DependentObservable<T> dependentObservable<T>(JsFunc<T> func)
		{
			return null;
		}
		/// <summary>
		/// Creates an observable with a value computed from one or more other values.
		/// </summary>
		/// <typeparam name="T">The type of the observable value.</typeparam>
		/// <param name="options">Options for the dependent observable.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static DependentObservable<T> dependentObservable<T>(DependentObservableOptions<T> options)
		{
			return null;
		}
		/// <summary>
		/// Returns true if the value is an observable, false otherwise.
		/// </summary>
		/// <param name="value">The value to check.</param>
		public static bool IsObservable(object value)
		{
			return false;
		}
		/// <summary>
		/// Creates an observable value.
		/// </summary>
		/// <typeparam name="T">The type of the observable.</typeparam>
		/// <returns>A new observable value instance.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static Observable<T> observable<T>()
		{
			return null;
		}
		/// <summary>
		/// Creates an observable with an initial value.
		/// </summary>
		/// <typeparam name="T">The type of the observable.</typeparam>
		/// <param name="initialValue">The initial value.</param>
		/// <returns>A new observable value instance.</returns>
        [JsMethod(IgnoreGenericArguments=true, NativeOverloads=true, NativeDelegates=true)]
        public static Observable<T> observable<T>(T initialValue)
		{
			return null;
		}
		/// <summary>
		/// Creates an empty observable array.
		/// </summary>
		/// <returns>A new observable array.</returns>
		/// <typeparam name="T">The type of items in the array.</typeparam>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static ObservableArray<T> observableArray<T>()
		{
			return null;
		}
		/// <summary>
		/// Creates an observable array with some initial items.
		/// </summary>
		/// <param name="initialItems">A sequence of initial items.</param>
		/// <returns>A new observable array.</returns>
		/// <typeparam name="T">The type of items in the array.</typeparam>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static ObservableArray<T> observableArray<T>(JsArray<T> initialItems)
		{
			return null;
		}
	}
    [JsType(JsMode.Prototype, Export=false)]
    public class KnockoutUtils
    {
        /// <summary>
        /// If the provided value is an observable, return its value, otherwise just pass it through.
        /// </summary>
        /// <param name="value">The value to unwrap.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static T unwrapObservable<T>(object value)
		{
			return default(T);
		}
    }
	/// <summary>
	/// Provides functionality for mapping between knockout models and JSON or
	/// vanilla script objects.
	/// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public sealed class KnockoutMapping
	{
		private KnockoutMapping()
		{
		}
		/// <summary>
		/// Creates a model instance from the specified JSON string.
		/// </summary>
		/// <typeparam name="TModel">The type of the model.</typeparam>
		/// <param name="jsonData">The JSON data.</param>
		/// <returns>A new instance of the model.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public TModel fromJSON<TModel>(string jsonData)
		{
			return default(TModel);
		}
		/// <summary>
		/// Creates a model instance from the specified JSON string and a
		/// custom mapping.
		/// </summary>
		/// <typeparam name="TModel">The type of the model.</typeparam>
		/// <param name="jsonData">The JSON data.</param>
		/// <param name="mapping">The mapping rules to apply.</param>
		/// <returns>A new instance of the model.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public TModel fromJSON<TModel>(string jsonData, object mapping)
		{
			return default(TModel);
		}
		/// <summary>
		/// Creates a model instance from the specified script object.
		/// </summary>
		/// <typeparam name="TModel">The type of the model.</typeparam>
		/// <param name="data">The vanilla script object.</param>
		/// <returns>A new instance of the model.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public TModel fromJS<TModel>(object data)
		{
			return default(TModel);
		}
		/// <summary>
		/// Creates a model instance from the specified script object and a
		/// custom mapping.
		/// </summary>
		/// <typeparam name="TModel">The type of the model.</typeparam>
		/// <param name="data">The vanilla script object.</param>
		/// <param name="mapping">The mapping rules to apply.</param>
		/// <returns>A new instance of the model.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public TModel fromJS<TModel>(object data, object mapping)
		{
			return default(TModel);
		}
		/// <summary>
		/// Updates the specified model with the specified JSON string.
		/// </summary>
		/// <typeparam name="TModel">The tyoe of the model.</typeparam>
		/// <param name="model">The model to update.</param>
		/// <param name="jsonData">The JSON string representing the new values.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public void updateFromJSON<TModel>(TModel model, string jsonData)
		{
		}
		/// <summary>
		/// Updates the specified model with the specified script object.
		/// </summary>
		/// <typeparam name="TModel">The tyoe of the model.</typeparam>
		/// <param name="model">The model to update.</param>
		/// <param name="data">The script object representing the new values.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public void updateFromJS<TModel>(TModel model, object data)
		{
		}
	}
	/// <summary>
	/// Represents an object containing an observable value.
	/// </summary>
	/// <typeparam name="T">The type of the contained value.</typeparam>
    [JsType(JsMode.Prototype, Export=false)]
    public sealed class Observable<T>
	{
		private Observable()
		{
		}
        public T Value 
        {
            [JsMethod(Name="")]
            get { return default(T); }
            [JsMethod(Name = "")]
            set { }
        }
		/// <summary>
		/// Gets the current value within the observable object.
		/// </summary>
		/// <returns>The current value.</returns>
		[JsMethod(Name="")]
		public T GetValue()
		{
			return default(T);
		}
		/// <summary>
		/// Sets the value within the observable object.
		/// </summary>
		/// <param name="value">The new value.</param>
		[JsMethod(Name="")]
		public void SetValue(T value)
		{
		}
		/// <summary>
		/// Subscribes to change notifications raised when the value changes.
		/// </summary>
		/// <param name="changeCallback">The callback to invoke.</param>
		/// <returns>A subscription cookie that can be disposed to unsubscribe.</returns>
		public IDisposable subscribe(JsAction<T> changeCallback)
		{
			return null;
		}
	}
	/// <summary>
	/// Represents an array of items that can be observed for changes to the set of
	/// contained items.
	/// </summary>
	/// <typeparam name="T">The type of the contained values.</typeparam>
    [JsType(JsMode.Prototype, Export=false)]
    public sealed class ObservableArray<T>
	{
		private ObservableArray()
		{
		}
		/// <summary>
		/// Marks all values that match the given parameter as deleted.
		/// </summary>
		/// <param name="value">The value to mark as deleted.</param>
		public void destroy(T value)
		{
		}
		/// <summary>
		/// Marks all values that satisfy the predicate as deleted.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		public void destroy(JsFunc<T, bool> predicate)
		{
		}
		/// <summary>
		/// Marks all values that satisfy the given parameters as deleted.
		/// </summary>
		/// <param name="values">An array of items to destroy.</param>
		public void destroyAll(params T[] values)
		{
		}
		/// <summary>
		/// Gets the underlying items within the observable array.
		/// </summary>
		/// <returns>The collection of items.</returns>
		[JsMethod(Name="")]
		public JsArray<T> GetItems()
		{
			return null;
		}
		/// <summary>
		/// Returns the index of the first array item that equals the value.
		/// </summary>
		/// <param name="value">The value to check.</param>
		/// <returns>The index of the matching item; -1 if there is no match.</returns>
		public int indexOf(T value)
		{
			return 0;
		}
		/// <summary>
		/// Removes the last value from the array and returns it.
		/// </summary>
		/// <returns>The last value.</returns>
		public T pop()
		{
			return default(T);
		}
		/// <summary>
		/// Adds the value and notifies observers.
		/// </summary>
		/// <param name="value">The value to add.</param>
		public void push(T value)
		{
		}
		/// <summary>
		/// Removes all values that match the given parameter and returns them.
		/// </summary>
		/// <param name="value">The value to remove.</param>
		/// <returns>The removed values.</returns>
		public T[] remove(T value)
		{
			return null;
		}
		/// <summary>
		/// Removes all values that satisfy the predicate and returns them.
		/// </summary>
		/// <param name="predicate">The removal predicate.</param>
		/// <returns>The removed values.</returns>
		public T[] remove(JsFunc<T, bool> predicate)
		{
			return null;
		}
		/// <summary>
		/// Removes all values that satisfy the given parameters and returns them.
		/// </summary>
		/// <param name="values">An array of items to remove.</param>
		/// <returns>The removed values.</returns>
		public T[] removeAll(params T[] values)
		{
			return null;
		}
		/// <summary>
		/// Reverses the order of the array.
		/// </summary>
		public void reverse()
		{
		}
		/// <summary>
		/// Removes the first value from the array and returns it
		/// </summary>
		/// <returns>The removed value.</returns>
		public T shift()
		{
			return default(T);
		}
		/// <summary>
		/// Returns elements from start index to the end of the array.
		/// </summary>
		/// <param name="start">Starting point of the sequence, if negative then it starts from the end.</param>
		/// <returns>The matched items.</returns>
		public T[] slice(int start)
		{
			return null;
		}
		/// <summary>
		/// Returns elements from start index to end index.
		/// </summary>
		/// <param name="start">Starting point of the sequence, if negative then it starts from the end.</param>
		/// <param name="end">End point of the sequence.</param>
		/// <returns>The matched items.</returns>
		public T[] slice(int start, int end)
		{
			return null;
		}
		/// <summary>
		/// Performs a default alphanumeric sort on the elements of the array.
		/// </summary>
		public void sort()
		{
		}
		/// <summary>
		/// Subscribes to change notifications raised when the value changes.
		/// </summary>
		/// <param name="changeCallback">The callback to invoke.</param>
		/// <returns>A subscription cookie that can be disposed to unsubscribe.</returns>
		public IDisposable subscribe(JsAction<T> changeCallback)
		{
			return null;
		}
		/// <summary>
		/// Performs a sort using the comparator function.
		/// </summary>
		/// <param name="comparator">The comparing function.</param>
		public void sort(JsFunc<T, T, int> comparator)
		{
		}
		/// <summary>
		/// Inserts the value at the beginning of the array.
		/// </summary>
		/// <param name="value">The value to insert.</param>
		public void unshift(T value)
		{
		}
	}
}
