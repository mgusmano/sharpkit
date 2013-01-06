using SharpKit.NodeJs.events;
using SharpKit.JavaScript;
using SharpKit.NodeJs.http;
using SharpKit.Html;
using SharpKit.NodeJs;

namespace NodeJsSamples.samples
{
    [JsType(JsMode.Global)]
    public class ReadWrieFile
    {
        static void OnReady1()
        {
            // Include http module,
var http = require("http");
// And mysql module you've just installed.
   var fs = require("fs");
// Create the http server.
http.As<SharpKit.NodeJs.http.Utils>().createServer((request, response) => {
   // Attach listener on end event.
   request.As<EventEmitter>().on("end", () => {
      // Read the file.
       fs.As<SharpKit.NodeJs.fs.Utils>().readFile("test.txt", "utf-8", (error, data) =>
       {
         // Write headers.
         response.writeHead(200, new {
            ContentType = "text/plain"
         });
         // Increment the number obtained from file.
         data = (int.Parse(data) + 1).As<JsString>();
         // Write incremented number to file.
         fs.As<SharpKit.NodeJs.fs.Utils>().writeFile("test.txt", data);
         // End response with some nice message.
         response.end("This page was refreshed " + data + " times!");
      });
   });
// Listen on the 8080 port.
}).As<Server>().listen(8080);
        }
        static void OnReady2()
        {
            // Include http module,
var http = require("http");
// And mysql module you've just installed.
   var fs = require("fs").As<SharpKit.NodeJs.fs.Utils>();
// Create the http server.
http.As<SharpKit.NodeJs.http.Utils>().createServer((request, response) => {
   // Attach listener on end event.
   request.As<EventEmitter>().on("end", () => {
      // Check if user requests /
      if (request.As<Request>().url.ExactEquals('/')) {
         // Read the file.
         fs.readFile("test.txt", "utf-8", (error, data) => {
            // Write headers.
            response.writeHead(200, new {
               ContentType = "text/plain"
            });
            // Increment the number obtained from file.
            data = (HtmlContext.parseInt(data) + 1).As<JsString>();
            // Write incremented number to file.
            fs.writeFile("test.txt", data);
            // End response with some nice message.
            response.end("This page was refreshed " + data + " times!");
         });
      } else {
         // Indicate that requested file was not found.
         response.writeHead(404);
         // And end request without sending any data.
         response.end();
      }
   });
// Listen on the 8080 port.
}).As<Server>().listen(8080);
        }

        static object require(JsString className) { return null; }
 
    }
}