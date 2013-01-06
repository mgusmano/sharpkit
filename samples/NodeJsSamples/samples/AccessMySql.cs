using SharpKit.JavaScript;
using SharpKit.NodeJs.events;
using SharpKit.Html;
using SharpKit.NodeJs.http;
using SharpKit.NodeJs;
namespace NodeJsSamples.samples
{
    [JsType(JsMode.Global)]
    public class AccessMySql
    {
        static void OnReady()
        {
            // Include http module,
            var http = require("http").As<SharpKit.NodeJs.http.Utils>();
            // And mysql module you've just installed.
            var mysql = require("mysql").As<SharpKit.NodeJs.net.Utils>();
            // Create the connection.
            // Data is default to new mysql installation and should be changed according to your configuration.
            var connection = mysql.createConnection(new
            {
                user = "root",
                password = "",
                database = "db_name"
            }).As<AccessMySql>();
            // Create the http server.
            http.createServer((request, response) =>
            {
                // Attach listener on end event.
                request.As<EventEmitter>().on("end", () =>
                {
                    // Query the database.
                    Connection.query("SELECT * FROM your_table;", (error, rows, fields) =>
                    {
                        response.writeHead(200, new
                        {
                            ContentType = "x-application/json"
                        });
                        // Send data as JSON string.
                        // Rows variable holds the result of the query.
                        response.end(JSON.stringify(rows));
                    });
                });
                // Listen on the 8080 port.
            }).As<Server>().listen(8080);

        }
        static object require(JsString className) { return null; }
       
    }
}