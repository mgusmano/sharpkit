using SharpKit.JavaScript;
using SharpKit.NodeJs.events;
using SharpKit.NodeJs;
using SharpKit.NodeJs.http;
namespace NodeJsSamples.samples
{
    [JsType(JsMode.Global)]
    public class UrlParam
    {
        static void OnReady()
        {
            // Include http module,
            var http = require("http");
            // And url module, which is very helpful in parsing request parameters.
            var url = require("url").As<Url>();
            // Create the server.
            http.createServer((request, response) =>
            {
                // Attach listener on end event.
                request.As<EventEmitter>().on("end", () =>
                {
                    // Parse the request for arguments and store them in _get variable.
                    // This function parses the url from request and returns object representation.
                    var _get = Url.parse(request.As<Request>().url, true).query;
                    // Write headers to the response.
                    response.writeHead(200, new
                    {
                        ContentType = "text/plain"
                    });
                    // Send data and end response.
                    response.end("Here is your data: " + _get.As<JsObject>()["data"]);
                });
                // Listen on the 8080 port.
            }).As<Server>().listen(8080);

        }
        static SharpKit.NodeJs.http.Utils require(JsString className) { return null; }
    }
}