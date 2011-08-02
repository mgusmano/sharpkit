using SharpKit.JavaScript;

namespace org.w3c.dom.html
{
    partial interface HTMLDocument : Document
    {
    }
}

namespace org.w3c.dom.geolocation
{
    [JsDelegate(NativeDelegates=true, NativeFunction=true)]
    public delegate void PositionCallback(Position position);
}

namespace org.w3c.dom.geolocation
{
      [JsDelegate(NativeDelegates=true, NativeFunction=true)]
    public delegate void PositionErrorCallback(PositionError error);
}
namespace org.w3c.dom.webdatabase
{
      [JsDelegate(NativeDelegates=true, NativeFunction=true)]
    public delegate void DatabaseCallback(Database database);

}
namespace org.w3c.dom.webdatabase
{
      [JsDelegate(NativeDelegates=true, NativeFunction=true)]
    public delegate void SQLStatementCallback(SQLTransaction transaction, SQLResultSet resultSet);


}
namespace org.w3c.dom.webdatabase
{
    [JsDelegate(NativeDelegates = true, NativeFunction = true)]
    public delegate void SQLStatementErrorCallback(SQLTransaction transaction, SQLError error);


}
namespace org.w3c.dom.webdatabase
{
    [JsDelegate(NativeDelegates = true, NativeFunction = true)]
    public delegate void SQLTransactionCallback(SQLTransaction transaction);


}
namespace org.w3c.dom.webdatabase
{
    [JsDelegate(NativeDelegates = true, NativeFunction = true)]
    public delegate void SQLTransactionErrorCallback(SQLError error);


}
namespace org.w3c.dom.webdatabase
{
    [JsDelegate(NativeDelegates = true, NativeFunction = true)]
    public delegate void SQLTransactionSyncCallback(SQLTransactionSync transaction);


}
namespace org.w3c.dom.webdatabase
{
    [JsDelegate(NativeDelegates = true, NativeFunction = true)]
    public delegate void SQLVoidCallback();

}
namespace org.w3c.dom.html
{
    [JsDelegate(NativeDelegates = true, NativeFunction = true)]
    public delegate void Function();

}
