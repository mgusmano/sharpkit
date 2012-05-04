//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_.DataSchema_
{
    /// <summary>
    /// Provides a DataSchema implementation which can be used to work with data
    /// stored in arrays.
    /// See the `apply` method below for usage.
    /// </summary>
    public partial class Array : YUI_.DataSchema_.Base
    {
        /// <summary>
        /// Schema-parsed list of results from full data
        /// </summary>
        protected object _parseResults(YUI_.Array fields, YUI_.Array array_in, object data_out){return null;}
        /// <summary>
        /// Applies a schema to an array of data, returning a normalized object
        /// with results in the `results` property. The `meta` property of the
        /// response object is present for consistency, but is assigned an empty
        /// object.  If the input data is absent or not an array, an `error`
        /// property will be added.
        /// The input array is expected to contain objects, arrays, or strings.
        /// If _schema_ is not specified or _schema.resultFields_ is not an array,
        /// `response.results` will be assigned the input array unchanged.
        /// When a _schema_ is specified, the following will occur:
        /// If the input array contains strings, they will be copied as-is into the
        /// `response.results` array.
        /// If the input array contains arrays, `response.results` will contain an
        /// array of objects with key:value pairs assuming the fields in
        /// _schema.resultFields_ are ordered in accordance with the data array
        /// values.
        /// If the input array contains objects, the identified
        /// _schema.resultFields_ will be used to extract a value from those
        /// objects for the output result.
        /// _schema.resultFields_ field identifiers are objects with the following properties:
        /// * `key`   : <strong>(required)</strong> The locator name (String)
        /// * `parser`: A function or the name of a function on `Y.Parsers` used
        /// to convert the input value into a normalized type.  Parser
        /// functions are passed the value as input and are expected to
        /// return a value.
        /// If no value parsing is needed, you can use strings as identifiers
        /// instead of objects (see example below).
        /// </summary>
        public object apply(YUI_.Array data){return null;}
        /// <summary>
        /// Applies a schema to an array of data, returning a normalized object
        /// with results in the `results` property. The `meta` property of the
        /// response object is present for consistency, but is assigned an empty
        /// object.  If the input data is absent or not an array, an `error`
        /// property will be added.
        /// The input array is expected to contain objects, arrays, or strings.
        /// If _schema_ is not specified or _schema.resultFields_ is not an array,
        /// `response.results` will be assigned the input array unchanged.
        /// When a _schema_ is specified, the following will occur:
        /// If the input array contains strings, they will be copied as-is into the
        /// `response.results` array.
        /// If the input array contains arrays, `response.results` will contain an
        /// array of objects with key:value pairs assuming the fields in
        /// _schema.resultFields_ are ordered in accordance with the data array
        /// values.
        /// If the input array contains objects, the identified
        /// _schema.resultFields_ will be used to extract a value from those
        /// objects for the output result.
        /// _schema.resultFields_ field identifiers are objects with the following properties:
        /// * `key`   : <strong>(required)</strong> The locator name (String)
        /// * `parser`: A function or the name of a function on `Y.Parsers` used
        /// to convert the input value into a normalized type.  Parser
        /// functions are passed the value as input and are expected to
        /// return a value.
        /// If no value parsing is needed, you can use strings as identifiers
        /// instead of objects (see example below).
        /// </summary>
        public object apply(object schema, YUI_.Array data){return null;}
    }
}
