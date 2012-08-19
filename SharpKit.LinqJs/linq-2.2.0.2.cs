using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.Html4;
using SharpKit.JavaScript;

namespace SharpKit.LinqJs
{
    /*--------------------------------------------------------------------------
    * linq-vsdoc.js - LINQ for JavaScript
    * ver 2.2.0.2 (Jan. 21th, 2011)
    *
    * created and maintained by neuecc <ils@neue.cc>
    * licensed under Microsoft Public License(Ms-PL)
    * http://neue.cc/
    * http://linqjs.codeplex.com/
    *--------------------------------------------------------------------------*/
    public class Enumerable
    {
        public Enumerable(object getEnumerator)
        {
            //TODO: this.GetEnumerator = getEnumerator;
        }

        /// <summary>Random choice from arguments.
        /// Ex: Choice(1,2,3) - 1,3,2,3,3,2,1...</summary>
        /// <param type="T" name="Params_Contents" parameterArray="true">Array or Params Contents</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Choice(object Params_Contents) { return null; }

        /// <summary>Cycle Repeat from arguments.
        /// Ex: Cycle(1,2,3) - 1,2,3,1,2,3,1,2,3...</summary>
        /// <param type="T" name="Params_Contents" parameterArray="true">Array or Params Contents</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Cycle(object Params_Contents) { return null; }


        /// <summary>Returns an empty Enumerable.</summary>
        /// <returns type="Enumerable"></returns>         
        public static Enumerable Empty() { return null; }

        /// <summary>
        /// Make Enumerable from obj.
        /// 1. null = Enumerable.Empty().
        /// 2. Enumerable = Enumerable.
        /// 3. Number/Boolean = Enumerable.Repeat(obj, 1).
        /// 4. String = to CharArray.(Ex:"abc" => "a","b","c").
        /// 5. Object/Function = to KeyValuePair(except function) Ex:"{a:0}" => (.Key=a, .Value=0).
        /// 6. Array or ArrayLikeObject(has length) = to Enumerable.
        /// 7. JScript's IEnumerable = to Enumerable(using Enumerator).
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable From(object obj) { return null; }

        /// <summary>Make one sequence. This equals Repeat(element, 1)</summary>
        /// <param name="element">element</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Return(HtmlElement element) { return null; }

        /// <summary>Global regex match and send regexp object.
        /// Ex: Matches((.)z,"0z1z2z") - $[1] => 0,1,2</summary>
        /// <param type="String" name="input">input string</param>
        /// <param type="RegExp/String" name="pattern">RegExp or Pattern string</param>
        /// <param type="Optional:String" name="flags" optional="true">If pattern is String then can use regexp flags "i" or "m" or "im"</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Matches(JsString input, JsRegExp pattern, JsString flags) { return null; }
        /// <summary>Global regex match and send regexp object.
        /// Ex: Matches((.)z,"0z1z2z") - $[1] => 0,1,2</summary>
        /// <param type="String" name="input">input string</param>
        /// <param type="RegExp/String" name="pattern">RegExp or Pattern string</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Matches(JsString input, JsRegExp pattern) { return null; }
        /// <summary>Global regex match and send regexp object.
        /// Ex: Matches((.)z,"0z1z2z") - $[1] => 0,1,2</summary>
        /// <param type="String" name="input">input string</param>
        /// <param type="RegExp/String" name="pattern">RegExp or Pattern string</param>
        /// <param type="Optional:String" name="flags" optional="true">If pattern is String then can use regexp flags "i" or "m" or "im"</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Matches(JsString input, JsString pattern, JsString flags) { return null; }
        /// <summary>Global regex match and send regexp object.
        /// Ex: Matches((.)z,"0z1z2z") - $[1] => 0,1,2</summary>
        /// <param type="String" name="input">input string</param>
        /// <param type="RegExp/String" name="pattern">RegExp or Pattern string</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Matches(JsString input, JsString pattern) { return null; }


        /// <summary>Generates a sequence of integral numbers within a specified range.
        /// Ex: Range(1,5) - 1,2,3,4,5</summary>
        /// <param type="Number" integer="true" name="start">The value of the first integer in the sequence.</param>
        /// <param type="Number" integer="true" name="count">The number of sequential integers to generate.</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:Range(0,3,5) - 0,5,10)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Range(JsNumber start, JsNumber count, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers within a specified range.
        /// Ex: Range(1,5) - 1,2,3,4,5</summary>
        /// <param type="Number" integer="true" name="start">The value of the first integer in the sequence.</param>
        /// <param type="Number" integer="true" name="count">The number of sequential integers to generate.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Range(JsNumber start, JsNumber count) { return null; }

        /// <summary>Generates a sequence of integral numbers within a specified range.
        /// Ex: RangeDown(5,5) - 5,4,3,2,1</summary>
        /// <param type="Number" integer="true" name="start">The value of the first integer in the sequence.</param>
        /// <param type="Number" integer="true" name="count">The number of sequential integers to generate.</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:RangeDown(0,3,5) - 0,-5,-10)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable RangeDown(JsNumber start, JsNumber count, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers within a specified range.
        /// Ex: RangeDown(5,5) - 5,4,3,2,1</summary>
        /// <param type="Number" integer="true" name="start">The value of the first integer in the sequence.</param>
        /// <param type="Number" integer="true" name="count">The number of sequential integers to generate.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable RangeDown(JsNumber start, JsNumber count) { return null; }

        /// <summary>Generates a sequence of integral numbers.
        /// Ex: RangeTo(10,12) - 10,11,12 RangeTo(0,-2) - 0, -1, -2</summary>
        /// <param type="Number" integer="true" name="start">start integer</param>
        /// <param type="Number" integer="true" name="to">to integer</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:RangeTo(0,7,3) - 0,3,6)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable RangeTo(JsNumber start, JsNumber to, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers.
        /// Ex: RangeTo(10,12) - 10,11,12 RangeTo(0,-2) - 0, -1, -2</summary>
        /// <param type="Number" integer="true" name="start">start integer</param>
        /// <param type="Number" integer="true" name="to">to integer</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable RangeTo(JsNumber start, JsNumber to) { return null; }

        /// <summary>Generates a sequence that contains one repeated value.
        /// If omit count then generate to infinity.
        /// Ex: Repeat("foo",3) - "foo","foo","foo"</summary>
        /// <param type="TResult" name="obj">The value to be repeated.</param>
        /// <param type="Optional:Number" integer="true" name="count" optional="true">The number of times to repeat the value in the generated sequence.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Repeat(object obj, JsNumber count) { return null; }
        //TODO: obj type

        /// <summary>Generates a sequence that contains one repeated value.
        /// If omit count then generate to infinity.
        /// Ex: Repeat("foo",3) - "foo","foo","foo"</summary>
        /// <param type="TResult" name="obj">The value to be repeated.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Repeat(object obj) { return null; }
        //TODO: obj type

        /// <summary>Lazy Generates one value by initializer's result and do finalize when enumerate end</summary>
        /// <param type="Func&lt;T>" name="initializer">value factory.</param>
        /// <param type="Action&lt;T>" name="finalizer">execute when finalize.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable RepeatWithFinalize(object initializer, object finalizer) { return null; }
        //TODO: parameters type

        /// <summary>Generates a sequence that execute func value.
        /// If omit count then generate to infinity.
        /// Ex: Generate("Math.random()", 5) - 0.131341,0.95425252,...</summary>
        /// <param type="Func&lt;T>" name="func">The value of execute func to be repeated.</param>
        /// <param type="Optional:Number" integer="true" name="count" optional="true">The number of times to repeat the value in the generated sequence.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Generate(object func, JsNumber count) { return null; }
        //TODO: func type

        /// <summary>Generates a sequence that execute func value.
        /// If omit count then generate to infinity.
        /// Ex: Generate("Math.random()", 5) - 0.131341,0.95425252,...</summary>
        /// <param type="Func&lt;T>" name="func">The value of execute func to be repeated.</param>
        /// <param type="Optional:Number" integer="true" name="count" optional="true">The number of times to repeat the value in the generated sequence.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Generate(object func) { return null; }
        //TODO: func type

        /// <summary>Generates a sequence of integral numbers to infinity.
        /// Ex: ToInfinity() - 0,1,2,3...</summary>
        /// <param type="Optional:Number" integer="true" name="start" optional="true">start integer</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:ToInfinity(10,3) - 10,13,16,19,...)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable ToInfinity(JsNumber start, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers to infinity.
        /// Ex: ToInfinity() - 0,1,2,3...</summary>
        /// <param type="Optional:Number" integer="true" name="start" optional="true">start integer</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable ToInfinity(JsNumber start) { return null; }
        /// <summary>Generates a sequence of integral numbers to infinity.
        /// Ex: ToInfinity() - 0,1,2,3...</summary>
        /// <returns type="Enumerable"></returns>
        public static Enumerable ToInfinity() { return null; }

        /// <summary>Generates a sequence of integral numbers to negative infinity.
        /// Ex: ToNegativeInfinity() - 0,-1,-2,-3...</summary>
        /// <param type="Optional:Number" integer="true" name="start" optional="true">start integer</param>
        /// <param type="Optional:Number" integer="true" name="step" optional="true">Step of generate number.(Ex:ToNegativeInfinity(10,3) - 10,7,4,1,...)</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable ToNegativeInfinity(JsNumber start, JsNumber step) { return null; }
        /// <summary>Generates a sequence of integral numbers to negative infinity.
        /// Ex: ToNegativeInfinity() - 0,-1,-2,-3...</summary>
        /// <param type="Optional:Number" integer="true" name="start" optional="true">start integer</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable ToNegativeInfinity(JsNumber start) { return null; }
        /// <summary>Generates a sequence of integral numbers to negative infinity.
        /// Ex: ToNegativeInfinity() - 0,-1,-2,-3...</summary>
        /// <returns type="Enumerable"></returns>
        public static Enumerable ToNegativeInfinity() { return null; }

        /// <summary>Applies function and generates a infinity sequence.
        /// Ex: Unfold(3,"$+10") - 3,13,23,...</summary>
        /// <param type="T" name="seed">The initial accumulator value.</param>
        /// <param type="Func&lt;T,T>" name="func">An accumulator function to be invoked on each element.</param>
        /// <returns type="Enumerable"></returns>
        public static Enumerable Unfold(object seed, object func) { return null; }
        //TODO: parameters type
    }
    public class Enumerable<T>
    {
        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use breadth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T>_or_Func&lt;T,int>" optional="true">Optional:the second parameter of the function represents the nestlevel of the source sequence.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable CascadeBreadthFirst(object func, object resultSelector) { return null; }
        //TODO: parameters type

        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use breadth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable CascadeBreadthFirst(object func) { return null; }
        //TODO: parameters type

        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use depth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T>_or_Func&lt;T,int>" optional="true">Optional:the second parameter of the function represents the nestlevel of the source sequence.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable CascadeDepthFirst(object func, object resultSelector) { return null; }
        //TODO: parameters type
        /// <summary>Projects each element of sequence and flattens the resulting sequences into one sequence use depth first search.</summary>
        /// <param name="func" type="Func&lt;T,T[]>">Select child sequence.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable CascadeDepthFirst(object func) { return null; }
        //TODO: parameters type

        /// <summary>Flatten sequences into one sequence.</summary>
        /// <returns type="Enumerable"></returns>
        public Enumerable Flatten() { return null; }

        /// <summary>Projects current and next element of a sequence into a new form.</summary>
        /// <param type="Func&lt;TSource,TSource,TResult>" name="selector">A transform function to apply to current and next element.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable Pairwise(JsString selector) { return null; }
        //TODO: parameters type

        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        /// <param name="func" type="Optional:Func&lt;TAccumulate,T,TAccumulate>" optional="true">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;TAccumulate,TResult>" optional="true">A function to transform the final accumulator value into the result value.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable Scan(object func_or_seed, object func, object resultSelector) { return null; }
        //TODO: parameters type

        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable Scan(object func_or_seed) { return null; }
        //TODO: parameters type

        /// <summary>Projects each element of a sequence into a new form.</summary>
        /// <param name="selector" type="Func&lt;T,T>_or_Func&lt;T,int,T>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable Select(JsString selector) { return null; }
        //TODO: parameters type

        /// <summary>Projects each element of a sequence and flattens the resulting sequences into one sequence.</summary>
        /// <param name="collectionSelector" type="Func&lt;T,TCollection[]>_or_Func&lt;T,int,TCollection[]>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <param name="resultSelector" type="Optional:Func&lt;T,TCollection,TResult>" optional="true">Optional:A transform function to apply to each element of the intermediate sequence.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable SelectMany(object collectionSelector, object resultSelector) { return null; }
        //TODO: parameters type
        /// <summary>Projects each element of a sequence and flattens the resulting sequences into one sequence.</summary>
        /// <param name="collectionSelector" type="Func&lt;T,TCollection[]>_or_Func&lt;T,int,TCollection[]>">A transform function to apply to each source element; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable SelectMany(Func< object> collectionSelector) { return null; }
        //TODO: parameters type

        /// <summary>Filters a sequence of values based on a predicate.</summary>
        /// <param name="predicate" type="Func&lt;T,bool>_or_Func&lt;T,int,bool>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable Where(JsFunc<object, bool>  predicate) { return null; }
        //TODO: parameters type
                /// <summary>Filters a sequence of values based on a predicate.</summary>
        /// <param name="predicate" type="Func&lt;T,bool>_or_Func&lt;T,int,bool>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable Where(JsFunc<object, JsNumber, bool>  predicate) { return null; }
        //TODO: parameters type

        /// <summary>Filters the elements based on a specified type.</summary>
        /// <param name="type" type="T">The type to filter the elements of the sequence on.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable OfType(object type) { return null; }
        //TODO: parameters type

        /// <summary>Merges two sequences by using the specified predicate function.</summary>
        /// <param name="second" type="T[]">The second sequence to merge.</param>
        /// <param name="selector" type="Func&lt;TFirst,TSecond,TResult>_or_Func&lt;TFirst,TSecond,int,TResult>">A function that specifies how to merge the elements from the two sequences. Optional:the third parameter of the function represents the index of the source element.</param>
        /// <returns type="Enumerable"></returns>
        public object Zip(object second, JsString selector) { return null; }
        //TODO: parameters type

        #region Join Methods

        /// <summary>Correlates the elements of two sequences based on matching keys.</summary>
        /// <param name="inner" type="T[]">The sequence to join to the first sequence.</param>
        /// <param name="outerKeySelector" type="Func&lt;TOuter,TKey>">A function to extract the join key from each element of the first sequence.</param>
        /// <param name="innerKeySelector" type="Func&lt;TInner,TKey>">A function to extract the join key from each element of the second sequence.</param>
        /// <param name="resultSelector" type="Func&lt;TOuter,TInner,TResult>">A function to create a result element from two matching elements.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable Join(object inner, object outerKeySelector, object innerKeySelector, object resultSelector, object compareSelector) { return null; }
        //TODO: parameters type

        /// <summary>Correlates the elements of two sequences based on matching keys.</summary>
        /// <param name="inner" type="T[]">The sequence to join to the first sequence.</param>
        /// <param name="outerKeySelector" type="Func&lt;TOuter,TKey>">A function to extract the join key from each element of the first sequence.</param>
        /// <param name="innerKeySelector" type="Func&lt;TInner,TKey>">A function to extract the join key from each element of the second sequence.</param>
        /// <param name="resultSelector" type="Func&lt;TOuter,TInner,TResult>">A function to create a result element from two matching elements.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable Join(object inner, object outerKeySelector, object innerKeySelector, object resultSelector) { return null; }
        //TODO: parameters type

        /// <summary>Correlates the elements of two sequences based on equality of keys and groups the results.</summary>
        /// <param name="inner" type="T[]">The sequence to join to the first sequence.</param>
        /// <param name="outerKeySelector" type="Func&lt;TOuter>">A function to extract the join key from each element of the first sequence.</param>
        /// <param name="innerKeySelector" type="Func&lt;TInner>">A function to extract the join key from each element of the second sequence.</param>
        /// <param name="resultSelector" type="Func&lt;TOuter,Enumerable&lt;TInner>,TResult">A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable GroupJoin(object inner, object outerKeySelector, object innerKeySelector, object resultSelector, object compareSelector) { return null; }
        //TODO: parameters type
        /// <summary>Correlates the elements of two sequences based on equality of keys and groups the results.</summary>
        /// <param name="inner" type="T[]">The sequence to join to the first sequence.</param>
        /// <param name="outerKeySelector" type="Func&lt;TOuter>">A function to extract the join key from each element of the first sequence.</param>
        /// <param name="innerKeySelector" type="Func&lt;TInner>">A function to extract the join key from each element of the second sequence.</param>
        /// <param name="resultSelector" type="Func&lt;TOuter,Enumerable&lt;TInner>,TResult">A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence.</param>
        /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        /// <returns type="Enumerable"></returns>
        public Enumerable GroupJoin(object inner, object outerKeySelector, object innerKeySelector, object resultSelector) { return null; }
        //TODO: parameters type

        #endregion

        //#region Set Methods
        //                    /// <summary>Determines whether all elements of a sequence satisfy a condition.</summary>
        //            /// <param type="Func&lt;T,bool>" name="predicate">A function to test each element for a condition.</param>
        //            /// <returns type="Boolean"></returns>
        //        public bool All (JsFunc<object, bool> predicate){ return null; }
        //        //TODO: parameters type

        //        public object Any (predicate){ return null; }
        //        {
        //            /// <summary>Determines whether a sequence contains any elements or any element of a sequence satisfies a condition.</summary>
        //            /// <param name="predicate" type="Optional:Func&lt;T,bool>" optional="true">A function to test each element for a condition.</param>
        //            /// <returns type="Boolean"></returns>
        //        },

        //        public object Concat: function (second){ return null; }
        //        {
        //            /// <summary>Concatenates two sequences.</summary>
        //            /// <param name="second" type="T[]">The sequence to concatenate to the first sequence.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object Insert: function (index, second){ return null; }
        //        {
        //            /// <summary>Merge two sequences.</summary>
        //            /// <param name="index" type="Number" integer="true">The index of insert start position.</param>
        //            /// <param name="second" type="T[]">The sequence to concatenate to the first sequence.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object Alternate: function (value){ return null; }
        //        {
        //            /// <summary>Insert value to between sequence.</summary>
        //            /// <param name="value" type="T">The value of insert.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        // Overload:function(value)
        //        // Overload:function(value, compareSelector)
        //        public object Contains: function (value, compareSelector){ return null; }
        //        {
        //            /// <summary>Determines whether a sequence contains a specified element.</summary>
        //            /// <param name="value" type="T">The value to locate in the sequence.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        //            /// <returns type="Boolean"></returns>
        //        },

        //        public object DefaultIfEmpty: function (defaultValue){ return null; }
        //        {
        //            /// <summary>Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.</summary>
        //            /// <param name="defaultValue" type="T">The value to return if the sequence is empty.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object Distinct: function (compareSelector){ return null; }
        //        {
        //            /// <summary>Returns distinct elements from a sequence.</summary>
        //            /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object Except: function (second, compareSelector){ return null; }
        //        {
        //            /// <summary>Produces the set difference of two sequences.</summary>
        //            /// <param name="second" type="T[]">An T[] whose Elements that also occur in the first sequence will cause those elements to be removed from the returned sequence.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object Intersect: function (second, compareSelector){ return null; }
        //        {
        //            /// <summary>Produces the set difference of two sequences.</summary>
        //            /// <param name="second" type="T[]">An T[] whose distinct elements that also appear in the first sequence will be returned.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object SequenceEqual: function (second, compareSelector){ return null; }
        //        {
        //            /// <summary>Determines whether two sequences are equal by comparing the elements.</summary>
        //            /// <param name="second" type="T[]">An T[] to compare to the first sequence.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object Union: function (second, compareSelector){ return null; }
        //        {
        //            /// <summary>Produces the union of two sequences.</summary>
        //            /// <param name="second" type="T[]">An T[] whose distinct elements form the second set for the union.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;T,TKey>" optional="true">An equality comparer to compare values.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //#endregion

        //        /* Ordering Methods */

        //        public object OrderBy: function (keySelector)
        //        {
        //            /// <summary>Sorts the elements of a sequence in ascending order according to a key.</summary>
        //            /// <param name="keySelector" type="Optional:Func&lt;T,TKey>">A function to extract a key from an element.</param>
        //            return new OrderedEnumerable();
        //        },

        //        public object OrderByDescending: function (keySelector)
        //        {
        //            /// <summary>Sorts the elements of a sequence in descending order according to a key.</summary>
        //            /// <param name="keySelector" type="Optional:Func&lt;T,TKey>">A function to extract a key from an element.</param>
        //            return new OrderedEnumerable();
        //        },

        //        public object Reverse: function ()
        //        {
        //            /// <summary>Inverts the order of the elements in a sequence.</summary>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object Shuffle: function ()
        //        {
        //            /// <summary>Shuffle sequence.</summary>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        /* Grouping Methods */

        //        public object GroupBy: function (keySelector, elementSelector, resultSelector, compareSelector)
        //        {
        //            /// <summary>Groups the elements of a sequence according to a specified key selector function.</summary>
        //            /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract the key for each element.</param>
        //            /// <param name="elementSelector" type="Optional:Func&lt;T,TElement>">A function to map each source element to an element in an Grouping&lt;TKey, TElement>.</param>
        //            /// <param name="resultSelector" type="Optional:Func&lt;TKey,Enumerable&lt;TElement>,TResult>">A function to create a result value from each group.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object PartitionBy: function (keySelector, elementSelector, resultSelector, compareSelector)
        //        {
        //            /// <summary>Create Group by continuation key.</summary>
        //            /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract the key for each element.</param>
        //            /// <param name="elementSelector" type="Optional:Func&lt;T,TElement>">A function to map each source element to an element in an Grouping&lt;TKey, TElement>.</param>
        //            /// <param name="resultSelector" type="Optional:Func&lt;TKey,Enumerable&lt;TElement>,TResult>">A function to create a result value from each group.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        public object BufferWithCount: function (count)
        //        {
        //            /// <summary>Divide by count</summary>
        //            /// <param name="count" type="Number" integer="true">integer</param>
        //            /// <returns type="Enumerable"></returns>
        //        },


        //        /* Aggregate Methods */

        //        public object Aggregate: function (func_or_seed, func, resultSelector)
        //        {
        //            /// <summary>Applies an accumulator function over a sequence.</summary>
        //            /// <param name="func_or_seed" type="Func&lt;T,T,T>_or_TAccumulate">Func is an accumulator function to be invoked on each element. Seed is the initial accumulator value.</param>
        //            /// <param name="func" type="Optional:Func&lt;TAccumulate,T,TAccumulate>" optional="true">An accumulator function to be invoked on each element.</param>
        //            /// <param name="resultSelector" type="Optional:Func&lt;TAccumulate,TResult>" optional="true">A function to transform the final accumulator value into the result value.</param>
        //            /// <returns type="TResult"></returns>
        //        },

        //       public object  Average: function (selector)
        //        {
        //            /// <summary>Computes the average of a sequence.</summary>
        //            /// <param name="selector" type="Optional:Func&lt;T,Number>" optional="true">A transform function to apply to each element.</param>
        //            /// <returns type="Number"></returns>
        //        },

        //        public object Count: function (predicate)
        //        {
        //            /// <summary>Returns the number of elements in a sequence.</summary>
        //            /// <param name="predicate" type="Optional:Func&lt;T,Boolean>" optional="true">A function to test each element for a condition.</param>
        //            /// <returns type="Number"></returns>
        //        },

        //        public object Max: function (selector)
        //        {
        //            /// <summary>Returns the maximum value in a sequence</summary>
        //            /// <param name="selector" type="Optional:Func&lt;T,TKey>" optional="true">A transform function to apply to each element.</param>
        //            /// <returns type="Number"></returns>
        //        },

        //        public object Min: function (selector)
        //        {
        //            /// <summary>Returns the minimum value in a sequence</summary>
        //            /// <param name="selector" type="Optional:Func&lt;T,TKey>" optional="true">A transform function to apply to each element.</param>
        //            /// <returns type="Number"></returns>
        //        },

        //        public object MaxBy: function (keySelector)
        //        {
        //            /// <summary>Returns the maximum value in a sequence by keySelector</summary>
        //            /// <param name="keySelector" type="Func&lt;T,TKey>">A compare selector of element.</param>
        //            /// <returns type="T"></returns>
        //        },

        //        public object MinBy: function (keySelector)
        //        {
        //            /// <summary>Returns the minimum value in a sequence by keySelector</summary>
        //            /// <param name="keySelector" type="Func&lt;T,TKey>">A compare selector of element.</param>
        //            /// <returns type="T"></returns>
        //        },

        //        public object Sum: function (selector)
        //        {
        //            /// <summary>Computes the sum of a sequence of values.</summary>
        //            /// <param name="selector" type="Optional:Func&lt;T,TKey>" optional="true">A transform function to apply to each element.</param>
        //            /// <returns type="Number"></returns>
        //        },

        //        /* Paging Methods */

        //        public object ElementAt: function (index)
        //        {
        //            /// <summary>Returns the element at a specified index in a sequence.</summary>
        //            /// <param name="index" type="Number" integer="true">The zero-based index of the element to retrieve.</param>
        //            /// <returns type="T"></returns>
        //        },

        //        public object ElementAtOrDefault: function (index, defaultValue)
        //        {
        //            /// <summary>Returns the element at a specified index in a sequence or a default value if the index is out of range.</summary>
        //            /// <param name="index" type="Number" integer="true">The zero-based index of the element to retrieve.</param>
        //            /// <param name="defaultValue" type="T">The value if the index is outside the bounds then send.</param>
        //            /// <returns type="T"></returns>
        //        },

        //        public object First: function (predicate)
        //        {
        //            /// <summary>Returns the first element of a sequence.</summary>
        //            /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>
        //            /// <returns type="T"></returns>
        //        },

        //        public object FirstOrDefault: function (defaultValue, predicate)
        //        {
        //            /// <summary>Returns the first element of a sequence, or a default value.</summary>
        //            /// <param name="defaultValue" type="T">The value if not found then send.</param>
        //            /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>        
        //            /// <returns type="T"></returns>
        //        },

        //        public object Last: function (predicate)
        //        {
        //            /// <summary>Returns the last element of a sequence.</summary>
        //            /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>
        //            /// <returns type="T"></returns>
        //        },

        //        public object LastOrDefault: function (defaultValue, predicate)
        //        {
        //            /// <summary>Returns the last element of a sequence, or a default value.</summary>
        //            /// <param name="defaultValue" type="T">The value if not found then send.</param>
        //            /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>        
        //            /// <returns type="T"></returns>
        //        },

        //        public object Single: function (predicate)
        //        {
        //            /// <summary>Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.</summary>
        //            /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>
        //            /// <returns type="T"></returns>
        //        },

        //        SingleOrDefault: function (defaultValue, predicate)
        //        {
        //            /// <summary>Returns a single, specific element of a sequence of values, or a default value if no such element is found.</summary>
        //            /// <param name="defaultValue" type="T">The value if not found then send.</param>
        //            /// <param name="predicate" type="Optional:Func&lt;T,Boolean>">A function to test each element for a condition.</param>        
        //            /// <returns type="T"></returns>
        //        },

        //        Skip: function (count)
        //        {
        //            /// <summary>Bypasses a specified number of elements in a sequence and then returns the remaining elements.</summary>
        //            /// <param name="count" type="Number" integer="true">The number of elements to skip before returning the remaining elements.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        SkipWhile: function (predicate)
        //        {
        //            /// <summary>Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.</summary>
        //            /// <param name="predicate" type="Func&lt;T,Boolean>_or_Func&lt;T,int,Boolean>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        Take: function (count)
        //        {
        //            /// <summary>Returns a specified number of contiguous elements from the start of a sequence.</summary>
        //            /// <param name="count" type="Number" integer="true">The number of elements to return.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        TakeWhile: function (predicate)
        //        {
        //            /// <summary>Returns elements from a sequence as long as a specified condition is true, and then skips the remaining elements.</summary>
        //            /// <param name="predicate" type="Func&lt;T,Boolean>_or_Func&lt;T,int,Boolean>">A function to test each source element for a condition; Optional:the second parameter of the function represents the index of the source element.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        TakeExceptLast: function (count)
        //        {
        //            /// <summary>Take a sequence except last count.</summary>
        //            /// <param name="count" type="Optional:Number" integer="true">The number of skip count.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        TakeFromLast: function (count)
        //        {
        //            /// <summary>Take a sequence from last count.</summary>
        //            /// <param name="count" type="Number" integer="true">The number of take count.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        IndexOf: function (item)
        //        {
        //            /// <summary>Returns the zero-based index of the flrst occurrence of a value.</summary>
        //            /// <param name="item" type="T">The zero-based starting index of the search.</param>
        //            /// <returns type="Number" integer="true"></returns>
        //        },

        //        LastIndexOf: function (item)
        //        {
        //            /// <summary>Returns the zero-based index of the last occurrence of a value.</summary>
        //            /// <param name="item" type="T">The zero-based starting index of the search.</param>
        //            /// <returns type="Number" integer="true"></returns>
        //        },

        //        /* Convert Methods */

        //        ToArray: function ()
        //        {
        //            /// <summary>Creates an array from this sequence.</summary>
        //            /// <returns type="Array"></returns>
        //        },

        //        ToLookup: function (keySelector, elementSelector, compareSelector)
        //        {
        //            /// <summary>Creates a Lookup from this sequence.</summary>
        //            /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        //            /// <param name="elementSelector" type="Optional:Func&lt;T,TElement>">A transform function to produce a result element value from each element.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        //            return new Lookup();
        //        },

        //        ToObject: function (keySelector, elementSelector)
        //        {
        //            /// <summary>Creates a Object from this sequence.</summary>
        //            /// <param name="keySelector" type="Func&lt;T,String>">A function to extract a key from each element.</param>
        //            /// <param name="elementSelector" type="Func&lt;T,TElement>">A transform function to produce a result element value from each element.</param>
        //            /// <returns type="Object"></returns>
        //        },

        //        ToDictionary: function (keySelector, elementSelector, compareSelector)
        //        {
        //            /// <summary>Creates a Dictionary from this sequence.</summary>
        //            /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        //            /// <param name="elementSelector" type="Func&lt;T,TElement>">A transform function to produce a result element value from each element.</param>
        //            /// <param name="compareSelector" type="Optional:Func&lt;TKey,TCompare>" optional="true">An equality comparer to compare values.</param>
        //            return new Dictionary();
        //        },

        //        // Overload:function()
        //        // Overload:function(replacer)
        //        // Overload:function(replacer, space)
        //        ToJSON: function (replacer, space)
        //        {
        //            /// <summary>Creates a JSON String from sequence, performed only native JSON support browser or included json2.js.</summary>
        //            /// <param name="replacer" type="Optional:Func">a replacer.</param>
        //            /// <param name="space" type="Optional:Number">indent spaces.</param>
        //            /// <returns type="String"></returns>
        //        },

        //        // Overload:function()
        //        // Overload:function(separator)
        //        // Overload:function(separator,selector)
        //        ToString: function (separator, selector)
        //        {
        //            /// <summary>Creates Joined string from this sequence.</summary>
        //            /// <param name="separator" type="Optional:String">A String.</param>
        //            /// <param name="selector" type="Optional:Func&lt;T,String>">A transform function to apply to each source element.</param>
        //            /// <returns type="String"></returns>
        //        },

        //        /* Action Methods */

        //        Do: function (action)
        //        {
        //            /// <summary>Performs the specified action on each element of the sequence.</summary>
        //            /// <param name="action" type="Action&lt;T>_or_Action&lt;T,int>">Optional:the second parameter of the function represents the index of the source element.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        ForEach: function (action)
        //        {
        //            /// <summary>Performs the specified action on each element of the sequence.</summary>
        //            /// <param name="action" type="Action&lt;T>_or_Action&lt;T,int>">[return true;]continue iteration.[return false;]break iteration. Optional:the second parameter of the function represents the index of the source element.</param>
        //            /// <returns type="void"></returns>
        //        },

        //        Write: function (separator, selector)
        //        {
        //            /// <summary>Do document.write.</summary>
        //            /// <param name="separator" type="Optional:String">A String.</param>
        //            /// <param name="selector" type="Optional:Func&lt;T,String>">A transform function to apply to each source element.</param>
        //            /// <returns type="void"></returns>
        //        },

        //        WriteLine: function (selector)
        //        {
        //            /// <summary>Do document.write + &lt;br />.</summary>
        //            /// <param name="selector" type="Optional:Func&lt;T,String>">A transform function to apply to each source element.</param>
        //            /// <returns type="void"></returns>
        //        },

        //        Force: function ()
        //        {
        //            /// <summary>Execute enumerate.</summary>
        //            /// <returns type="void"></returns>
        //        },

        //        /* Functional Methods */

        //        Let: function (func)
        //        {
        //            /// <summary>Bind the source to the parameter so that it can be used multiple times.</summary>
        //            /// <param name="func" type="Func&lt;Enumerable&lt;T>,Enumerable&lt;TR>>">apply function.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        Share: function ()
        //        {
        //            /// <summary>Shares cursor of all enumerators to the sequence.</summary>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        MemoizeAll: function ()
        //        {
        //            /// <summary>Creates an enumerable that enumerates the original enumerable only once and caches its results.</summary>
        //            /// <returns type="Enumerable"></returns>
        //        },


        //        /* Error Handling Methods */

        //        Catch: function (handler)
        //        {
        //            /// <summary>catch error and do handler.</summary>
        //            /// <param name="handler" type="Action&lt;Error>">execute if error occured.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        Finally: function (finallyAction)
        //        {
        //            /// <summary>do action if enumerate end or disposed or error occured.</summary>
        //            /// <param name="handler" type="Action">finally execute.</param>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        /* For Debug Methods */

        //        Trace: function (message, selector)
        //        {
        //            /// <summary>Trace object use console.log.</summary>
        //            /// <param name="message" type="Optional:String">Default is 'Trace:'.</param>
        //            /// <param name="selector" type="Optional:Func&lt;T,String>">A transform function to apply to each source element.</param>
        //            /// <returns type="Enumerable"></returns>
        //        }
        //    }

        //    // vsdoc-dummy

        //    Enumerable.prototype.GetEnumerator = function ()
        //    {
        //        /// <summary>Returns an enumerator that iterates through the collection.</summary>
        //        return new IEnumerator();
        //    }

        //    var IEnumerator = function () { }
        //    IEnumerator.prototype.Current = function ()
        //    {
        //        /// <summary>Gets the element in the collection at the current position of the enumerator.</summary>
        //        /// <returns type="T"></returns>
        //    }
        //    IEnumerator.prototype.MoveNext = function ()
        //    {
        //        /// <summary>Advances the enumerator to the next element of the collection.</summary>
        //        /// <returns type="Boolean"></returns>
        //    }
        //    IEnumerator.prototype.Dispose = function ()
        //    {
        //        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        //        /// <returns type="Void"></returns>
        //    }

        //    var Dictionary = function () { }
        //    Dictionary.prototype =
        //    {
        //        Add: function (key, value)
        //        {
        //            /// <summary>add new pair. if duplicate key then overwrite new value.</summary>
        //            /// <returns type="Void"></returns>
        //        },

        //        Get: function (key)
        //        {
        //            /// <summary>get value. if not find key then return undefined.</summary>
        //            /// <returns type="T"></returns>
        //        },

        //        Set: function (key, value)
        //        {
        //            /// <summary>set value. if complete set value then return true, not find key then return false.</summary>
        //            /// <returns type="Boolean"></returns>
        //        },

        //        Contains: function (key)
        //        {
        //            /// <summary>check contains key.</summary>
        //            /// <returns type="Boolean"></returns>
        //        },

        //        Clear: function ()
        //        {
        //            /// <summary>clear dictionary.</summary>
        //            /// <returns type="Void"></returns>
        //        },

        //        Remove: function (key)
        //        {
        //            /// <summary>remove key and value.</summary>
        //            /// <returns type="Void"></returns>
        //        },

        //        Count: function ()
        //        {
        //            /// <summary>contains value's count.</summary>
        //            /// <returns type="Number"></returns>
        //        },

        //        ToEnumerable: function ()
        //        {
        //            /// <summary>Convert to Enumerable&lt;{Key:, Value:}&gt;.</summary>
        //            /// <returns type="Enumerable"></returns>
        //        }
        //    }

        //    var Lookup = function () { }
        //    Lookup.prototype =
        //    {
        //        Count: function ()
        //        {
        //            /// <summary>contains value's count.</summary>
        //            /// <returns type="Number"></returns>
        //        },

        //        Get: function (key)
        //        {
        //            /// <summary>get grouped enumerable.</summary>
        //            /// <returns type="Enumerable"></returns>
        //        },

        //        Contains: function (key)
        //        {
        //            /// <summary>check contains key.</summary>
        //            /// <returns type="Boolean"></returns>
        //        },

        //        ToEnumerable: function ()
        //        {
        //            /// <summary>Convert to Enumerable&lt;Grouping&gt;.</summary>
        //            /// <returns type="Enumerable"></returns>
        //        }
        //    }


        //    var Grouping = function () { }
        //    Grouping.prototype = new Enumerable();
        //    Grouping.prototype.Key = function ()
        //    {
        //        /// <summary>get grouping key.</summary>
        //        /// <returns type="T"></returns>  
        //    }

        //    var OrderedEnumerable = function () { }
        //    OrderedEnumerable.prototype = new Enumerable();

        //    OrderedEnumerable.prototype.ThenBy = function (keySelector)
        //    {
        //        /// <summary>Performs a subsequent ordering of the elements in a sequence in ascending order according to a key.</summary>
        //        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        //        return Enumerable.Empty().OrderBy();
        //    }

        //    OrderedEnumerable.prototype.ThenByDescending = function (keySelector)
        //    {
        //        /// <summary>Performs a subsequent ordering of the elements in a sequence in descending order, according to a key.</summary>
        //        /// <param name="keySelector" type="Func&lt;T,TKey>">A function to extract a key from each element.</param>
        //        return Enumerable.Empty().OrderBy();
        //    }

        //    return Enumerable;
        //})()}
    }
}