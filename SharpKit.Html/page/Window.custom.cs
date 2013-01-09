using System;
using SharpKit.Html.filesystem;
using SharpKit.Html.storage;
using SharpKit.JavaScript;

namespace SharpKit.Html
{
    //[JsType(JsMode.Prototype, Export = true, Name = "Window")]
    partial class Window : ILocalFileSystem
    {
        //[JsMethod(Name = "requestFileSystem", Code = "(requestFileSystem||webkitRequestFileSystem)(type, size, successCallback, errorCallback);")]
        [JsMethod(Name = "requestFileSystem")]
        public void RequestFileSystem(ushort type, ulong size, FileSystemCallback successCallback, ErrorCallback errorCallback = null) { }

        [JsMethod(Name = "resolveLocalFileSystemURL")]
        public void ResolveLocalFileSystemUrl(string url, EntryCallback successCallback, ErrorCallback errorCallback = null) { }

        [JsMethod(Name = "webkitRequestFileSystem")]
        [Obsolete("Methods with the 'webkit' prefix may be deprecated without warning.")]
        public void WebkitRequestFileSystem(ushort type, ulong size, FileSystemCallback successCallback, ErrorCallback errorCallback = null) { }

        [JsMethod(Name = "WebkitResolveLocalFileSystemURL")]
        [Obsolete("Methods with the 'webkit' prefix may be deprecated without warning.")]
        public void WebkitResolveLocalFileSystemUrl(string url, EntryCallback successCallback, ErrorCallback errorCallback = null) { }
    }
}
