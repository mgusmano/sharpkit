using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.NodeJs.events;
using SharpKit.NodeJs.http;

namespace NodeJsSamples.samples
{
    [JsType(JsMode.Global)]
    public static class HttpServer
    {
        static void OnReady() {
        // Include http module.
var http = require("http");
// Create the server. Function passed as parameter is called on every request made.
// request variable holds all request parameters
// response variable allows you to do anything with response sent to the client.
http.createServer((request, response) => {
   // Attach listener on end event.
   // This event is called when client sent all data and is waiting for response.
   request.As<EventEmitter>().on("end", listener => {
      // Write headers to the response.
      // 200 is HTTP status code (this one means success)
      // Second parameter holds header fields in object
      // We are sending plain text, so Content-Type should be text/plain
      response.writeHead(200, new {
         ContentType = "text/plain"
      });
      // Send data and end response.
      response.end("Hello HTTP!");
   });
// Listen on the 8080 port.
}).As<Server>().listen(8080);
    }
        static SharpKit.NodeJs.http.Utils require(JsString className) { return null; }
    }
}