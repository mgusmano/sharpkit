//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// A concurrent parallel processor to help in running several async functions.
    /// var stack = new Y.Parallel();
    /// for (var i = 0; i < 15; i++) {
    /// Y.io('./api/json/' + i, {
    /// on: {
    /// success: stack.add(function() {
    /// Y.log('Done!');
    /// })
    /// }
    /// });
    /// }
    /// stack.done(function() {
    /// Y.log('All IO requests complete!');
    /// });
    /// </summary>
    public partial class Parallel
    {
        /// <summary>
        /// Add a callback to the stack
        /// </summary>
        public void add(JsAction fn){}
        /// <summary>
        /// The method to call when all the items in the stack are complete.
        /// </summary>
        public void done(JsAction callback, object data){}
        /// <summary>
        /// Test to see if all registered items in the stack have completed, if so call the callback to `done`
        /// </summary>
        public void test(){}
        /// <summary>
        /// The number of stacked callbacks executed
        /// </summary>
        public YUI_.DataType_.Number finished{get;set;}
        /// <summary>
        /// An Array of results from all the callbacks in the stack
        /// </summary>
        public YUI_.Array results{get;set;}
        /// <summary>
        /// The total items in the stack
        /// </summary>
        public YUI_.DataType_.Number total{get;set;}
    }
}
