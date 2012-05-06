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
    /// YUI user agent detection.
    /// Do not fork for a browser if it can be avoided.  Use feature detection when
    /// you can.  Use the user agent as a last resort.  For all fields listed
    /// as @type float, UA stores a version number for the browser engine,
    /// 0 otherwise.  This value may or may not map to the version number of
    /// the browser using the engine.  The value is presented as a float so
    /// that it can easily be used for boolean evaluation as well as for
    /// looking for a particular range of versions.  Because of this,
    /// some of the granularity of the version info may be lost.  The fields that
    /// are @type string default to null.  The API docs list the values that
    /// these fields can have.
    /// </summary>
    public partial class UA
    {
        /// <summary>
        /// Static method on `YUI.Env` for parsing a UA string.  Called at instantiation
        /// to populate `Y.UA`.
        /// </summary>
        public object parseUA(){return null;}
        /// <summary>
        /// Static method on `YUI.Env` for parsing a UA string.  Called at instantiation
        /// to populate `Y.UA`.
        /// </summary>
        public object parseUA(object subUA){return null;}
        /// <summary>
        /// The mobile property will be set to a string containing any relevant
        /// user agent information when a modern mobile browser is detected.
        /// Currently limited to Safari on the iPhone/iPod Touch, Nokia N-series
        /// devices with the WebKit-based browser, and Opera Mini.
        /// </summary>
        public string mobile{get;set;}
        /// <summary>
        /// The operating system.  Currently only detecting windows or macintosh
        /// </summary>
        public string os{get;set;}
    }
}