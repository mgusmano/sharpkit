using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Google.Chrome
{

    #region alarms

    [JsType(JsMode.Prototype, Export = false)]
    public class alarms
    {
        /// <summary>
        /// Clears the alarm with the given name.
        /// </summary>
        /// <param name="name">The name of the alarm to clear. Defaults to the empty string.</param>
        public static void clear(JsString name) { }
        /// <summary>
        /// Clears the alarm with the given name.
        /// </summary>
        public static void clear() { }

        /// <summary>
        /// Clears all alarms.
        /// </summary>
        public static void clearAll() { }

        /// <summary>
        /// Creates an alarm. Near the time(s) specified by 'alarmInfo', the onAlarm event is fired. If there is another alarm with the same name (or no name if none is specified),
        /// it will be cancelled and replaced by this alarm. Note that granularity is not guaranteed: times are more of a hint to the browser. For performance reasons, alarms may be delayed an arbitrary amount of time before firing. string. be specified by either |when| or |delayInMinutes| (but not both). If minutes after the initial event.
        /// If neither |when| or |delayInMinutes| is set for a repeating alarm, |periodInMinutes| is used as the default for |delayInMinutes|.
        /// </summary>
        /// <param name="name">Optional name to identify this alarm. Defaults to the empty</param>
        /// <param name="alarmInfo">Describes when the alarm should fire. The initial time must</param>
        public static void create(JsString name, AlarmCreateInfo alarmInfo) { }
        /// <summary>
        /// Creates an alarm. Near the time(s) specified by 'alarmInfo', the onAlarm event is fired. If there is another alarm with the same name (or no name if none is specified),
        /// it will be cancelled and replaced by this alarm. Note that granularity is not guaranteed: times are more of a hint to the browser. For performance reasons, alarms may be delayed an arbitrary amount of time before firing. string. be specified by either |when| or |delayInMinutes| (but not both). If minutes after the initial event.
        /// If neither |when| or |delayInMinutes| is set for a repeating alarm, |periodInMinutes| is used as the default for |delayInMinutes|.
        /// </summary>
        /// <param name="alarmInfo">Describes when the alarm should fire. The initial time must</param>
        public static void create(AlarmCreateInfo alarmInfo) { }

        /// <summary>
        /// Retrieves details about the specified alarm.
        /// </summary>
        /// <param name="name">The name of the alarm to get. Defaults to the empty string.</param>
        /// <param name="AlarmCallback"></param>
        public static void get(JsString name, JsAction<Alarm> AlarmCallback) { }
        /// <summary>
        /// Retrieves details about the specified alarm.
        /// </summary>
        /// <param name="AlarmCallback"></param>
        public static void get(JsAction<Alarm> AlarmCallback) { }

        /// <summary>
        /// Gets an array of all the alarms.
        /// </summary>
        /// <param name="AlarmListCallback"></param>
        public static void getAll(JsAction<JsArray<Alarm>> AlarmListCallback) { }

        /// <summary>
        /// Fired when an alarm has elapsed. Useful for transient background pages.
        /// </summary>
        public static Event<JsAction<Alarm>> onAlarm { get; set; }

    }

    [JsType(JsMode.Prototype, Name = "chrome.alarms.Alarm", Export = false)]
    public class Alarm
    {
        /// <summary>
        /// Name of this alarm.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional )
        /// If not null, the alarm is a repeating alarm and will fire again in 'periodInMinutes' minutes.
        /// </summary>
        public JsNumber periodInMinutes { get; set; }

        /// <summary>
        /// Time at which this alarm was scheduled to fire, in milliseconds past the epoch (e.g. Date.now() + n).
        /// For performance reasons, the alarm may have been delayed an arbitrary amount beyond this.
        /// </summary>
        public JsNumber scheduledTime { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.alarms.AlarmCreateInfo", Export = false)]
    public class AlarmCreateInfo
    {
        /// <summary>
        /// ( optional )
        /// Length of time in minutes after which the onAlarm event should fire. TODO: need minimum=0
        /// </summary>
        public JsNumber delayInMinutes { get; set; }

        /// <summary>
        /// ( optional )
        /// If set, the onAlarm event should fire every |periodInMinutes| minutes after the initial event specified by |when| or |delayInMinutes|.
        /// If not set, the alarm will only fire once. TODO: need minimum=0
        /// </summary>
        public JsNumber periodInMinutes { get; set; }

        /// <summary>
        /// ( optional )
        /// Time at which the alarm should fire, in milliseconds past the epoch (e.g. Date.now() + n).
        /// </summary>
        public JsNumber when { get; set; }
    }
    //The "TODO" in this class are googles' not mays'

    #endregion

    #region bookmarks

    /// <summary>
    /// Use the chrome.bookmarks module to create, organize, and otherwise manipulate bookmarks. Also see Override Pages, which you can use to create a custom Bookmark Manager page.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.bookmarks", Export = false)]
    public class bookmarks
    {
        /// <summary>
        /// Creates a bookmark or folder under the specified parentId. If url is NULL or missing, it will be a folder.
        /// </summary>
        /// <param name="bookmark"></param>
        /// <param name="callback"></param>
        public static void create(Bookmark bookmark, JsAction callback) { }

        /// <summary>
        /// Retrieves the specified BookmarkTreeNode(s).
        /// </summary>
        /// <param name="idOrIdList">A single string-valued id, or an array of string-valued ids</param>
        /// <param name="callback"></param>
        public static void get(JsString idOrIdList, JsAction callback) { }
        /// <summary>
        /// Retrieves the specified BookmarkTreeNode(s).
        /// </summary>
        /// <param name="idOrIdList">A single string-valued id, or an array of string-valued ids</param>
        /// <param name="callback"></param>
        public static void get(JsArray<JsString> idOrIdList, JsAction callback) { }

        /// <summary>
        /// Retrieves the children of the specified BookmarkTreeNode id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callback"></param>
        public static void getChildren(JsString id, JsAction callback) { }

        /// <summary>
        /// Retrieves the recently added bookmarks.
        /// </summary>
        /// <param name="numberOfItems">The maximum number of items to return.</param>
        /// <param name="callback"></param>
        public static void getRecent(JsNumber numberOfItems, JsAction callback) { }

        /// <summary>
        /// Retrieves part of the Bookmarks hierarchy, starting at the specified node.
        /// </summary>
        /// <param name="id">The ID of the root of the subtree to retrieve.</param>
        /// <param name="callback"></param>
        public static void getSubTree(JsString id, JsAction callback) { }

        /// <summary>
        /// Retrieves the entire Bookmarks hierarchy.
        /// </summary>
        /// <param name="callback"></param>
        public static void getTree(JsAction callback) { }

        /// <summary>
        /// Moves the specified BookmarkTreeNode to the provided location.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="destination"></param>
        /// <param name="callback"></param>
        public static void move(JsString id, BookmarkMoveDestination destination, JsAction callback) { }
        /// <summary>
        /// Moves the specified BookmarkTreeNode to the provided location.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="destination"></param>
        public static void move(JsString id, BookmarkMoveDestination destination) { }

        /// <summary>
        /// Removes a bookmark or an empty bookmark folder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callback"></param>
        public static void remove(JsString id, JsAction callback) { }
        /// <summary>
        /// Removes a bookmark or an empty bookmark folder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callback"></param>
        public static void remove(JsString id) { }

        /// <summary>
        /// Recursively removes a bookmark folder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callback"></param>
        public static void removeTree(JsString id, JsAction callback) { }
        /// <summary>
        /// Recursively removes a bookmark folder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callback"></param>
        public static void removeTree(JsString id) { }

        /// <summary>
        /// Searches for BookmarkTreeNodes matching the given query.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="callback"></param>
        public static void search(JsString query, JsAction callback) { }

        /// <summary>
        /// Updates the properties of a bookmark or folder. Specify only the properties that you want to change;
        /// unspecified properties will be left unchanged. Note: Currently, only 'title' and 'url' are supported.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="changes"></param>
        /// <param name="callback"></param>
        public static void update(JsString id, BookmarkUpdateChanges changes, JsAction callback) { }

        /// <summary>
        /// Fired when a bookmark or folder changes. Note: Currently, only title and url changes trigger this.
        /// </summary>
        public static Event<JsAction<string, BookmarkChangeInfoDestination>> onChanged { get; set; }

        /// <summary>
        /// Fired when the children of a folder have changed their order due to the order being sorted in the UI. This is not called as a result of a move().
        /// </summary>
        public static Event<JsAction<string, BookmarkReorderInfoDestination>> onChildrenReordered { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is created.
        /// </summary>
        public static Event<JsAction<string, BookmarkTreeNode>> onCreated { get; set; }

        /// <summary>
        /// Fired when a bookmark import session is begun.
        /// Expensive observers should ignore handleCreated updates until onImportEnded is fired. Observers should still handle other notifications immediately.
        /// </summary>
        public static Event<JsAction> onImportBegan { get; set; }

        /// <summary>
        /// Fired when a bookmark import session is ended.
        /// </summary>
        public static Event<JsAction> onImportEnded { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is moved to a different parent folder.
        /// </summary>
        public static Event<JsAction<string, BookmarkMoveInfo>> onMoved { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is removed. When a folder is removed recursively, a single notification is fired for the folder, and none for its contents.
        /// </summary>
        public static Event<JsAction<string, BookmarkRemoveInfo>> onRemoved { get; set; }

    }

    [JsType(JsMode.Json)]
    public class Bookmark
    {
        /// <summary>
        /// ( optional )
        /// Defaults to the Other Bookmarks folder.
        /// </summary>
        public JsString parentId { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsNumber index { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString url { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkMoveDestination
    {
        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString parentId { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsNumber index { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkUpdateChanges
    {
        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString title { get; set; }
        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString url { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkChangeInfoDestination
    {
        public JsString title { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString url { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkReorderInfoDestination
    {
        public JsArray<JsString> childIds { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkMoveInfo
    {
        public JsString parentId { get; set; }

        public JsNumber index { get; set; }

        public JsString oldParentId { get; set; }

        public JsNumber oldIndex { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkRemoveInfo
    {
        public JsString parentId { get; set; }

        public JsNumber index { get; set; }

    }

    [JsType(JsMode.Prototype, Name = "chrome.bookmarks.BookmarkTreeNode", Export = false)]
    public class BookmarkTreeNode
    {
        /// <summary>
        /// The unique identifier for the node. IDs are unique within the current profile, and they remain valid even after the browser is restarted.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional ) The id of the parent folder. Omitted for the root node.
        /// </summary>
        public JsString parentId { get; set; }

        /// <summary>
        ///  ( optional ) The 0-based position of this node within its parent folder.
        /// </summary>
        public JsNumber index { get; set; }

        /// <summary>
        /// ( optional )The URL navigated to when a user clicks the bookmark. Omitted for folders.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The text displayed for the node.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional ) When this node was created, in milliseconds since the epoch (new Date(dateAdded)).
        /// </summary>
        public JsNumber dateAdded { get; set; }

        /// <summary>
        /// ( optional ) When the contents of this folder last changed, in milliseconds since the epoch.
        /// </summary>
        public JsNumber dateGroupModified { get; set; }

        /// <summary>
        /// ( optional array of bookmarks.BookmarkTreeNode ) An ordered list of children of this node.
        /// </summary>
        public JsArray<BookmarkTreeNode> children { get; set; }
    }

    #endregion

    #region browserAction

    [JsType(JsMode.Prototype, Name = "chrome.browserAction", Export = false)]
    public class browserAction
    {
        /// <summary>
        /// Gets the background color of the browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getBadgeBackgroundColor(BrowserActionBadgeBackgroundColorDetails details, JsAction callback) { }

        /// <summary>
        /// Gets the badge text of the browser action. If no tab is specified, the non-tab-specific badge text is returned.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getBadgeText(BrowserActionBadgeTextDetails details, JsAction callback) { }

        /// <summary>
        /// Gets the html document set as the popup for this browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getPopup(BrowserActionPopupDetails details, JsAction callback) { }

        /// <summary>
        /// Gets the title of the browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getTitle(BrowserActionTitleDetails details, JsAction callback) { }

        /// <summary>
        /// Sets the background color for the badge.
        /// </summary>
        /// <param name="details"></param>
        public static void setBadgeBackgroundColor(BrowserActionBadgeBackgroundColorDetails details) { }

        /// <summary>
        /// Sets the badge text for the browser action. The badge is displayed on top of the icon.
        /// </summary>
        /// <param name="details"></param>
        public static void setBadgeText(BrowserActionBadgeTextDetails details) { }

        /// <summary>
        /// Sets the icon for the browser action. The icon can be specified either as the path to an image file or as the pixel data from a canvas element.
        /// Either the path or the imageData property must be specified.
        /// </summary>
        /// <param name="details"></param>
        public static void setIcon(BrowserActionSetIconDetails details) { }

        /// <summary>
        /// Sets the html document to be opened as a popup when the user clicks on the browser action's icon.
        /// </summary>
        /// <param name="details"></param>
        public static void setPopup(BrowserActionPopupDetails details) { }

        /// <summary>
        /// Sets the title of the browser action. This shows up in the tooltip.
        /// </summary>
        /// <param name="details"></param>
        public static void setTitle(BrowserActionTitleDetails details) { }

        /// <summary>
        /// Fired when a browser action icon is clicked. This event will not fire if the browser action has a popup.
        /// </summary>
        public static Event<JsAction<Tab>> onClicked { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BrowserActionBadgeBackgroundColorDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// An array of four integers in the range [0,255] that make up the RGBA color of the badge.
        /// For example, opaque red is [255, 0, 0, 255]. Can also be a string with a CSS value, with opaque red being #FF0000 or #F00.
        /// </summary>
        [JsProperty(Name = "color")]
        public JsString colorString { get; set; }

        /// <summary>
        /// This property is available for setter operations only.
        /// An array of four integers in the range [0,255] that make up the RGBA color of the badge.
        /// For example, opaque red is [255, 0, 0, 255]. Can also be a string with a CSS value, with opaque red being #FF0000 or #F00.
        /// </summary>
        public ColorArray color { get; set; }

        /// <summary>
        /// When using the getter operations: Specify the tab to get the badge background color from.
        /// If no tab is specified, the non-tab-specific badge background color is returned.
        /// When using the setter operations: Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BrowserActionBadgeTextDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// Any number of characters can be passed, but only about four can fit in the space.
        /// </summary>
        public JsString text { get; set; }

        /// <summary>
        /// When using the getter operations: Specify the tab to get the badge text from. If no tab is specified, the non-tab-specific badge text is returned.
        /// When using the setter operations: Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BrowserActionPopupDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// The html file to show in a popup. If set to the empty string (''), no popup is shown.
        /// </summary>
        public JsString popup { get; set; }

        /// <summary>
        /// When using the getter operations: Specify the tab to get the popup from. If no tab is specified, the non-tab-specific popup is returned.
        /// When using the setter operations: Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BrowserActionTitleDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// The string the browser action should display when moused over.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// When using the getter operations: Specify the tab to get the title from. If no tab is specified, the non-tab-specific title is returned.
        /// When using the setter operations: Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BrowserActionSetIconDetails
    {
        /// <summary>
        /// ( optional )
        /// Pixel data for an image. Must be an ImageData object (for example, from a canvas element).
        /// </summary>
        public ImageData imageData { get; set; }

        /// <summary>
        /// ( optional )
        /// Relative path to an image in the extension to show in the browser action.
        /// </summary>
        public JsString path { get; set; }

        /// <summary>
        /// ( optional )
        /// Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.browserAction.ColorArray", Export = false)]
    public class ColorArray : JsArray<JsNumber>
    {
    }

    #endregion

    #region browsingData

    [JsType(JsMode.Prototype, Name = "chrome.browsingData", Export = false)]
    public class browsingData
    {
        /// <summary>
        /// Clears various types of browsing data stored in a user's profile.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="dataToRemove"></param>
        /// <param name="callback"></param>
        public static void remove(RemovalOptions options, BrowsingDataDataToRemove dataToRemove, JsAction callback) { }
        /// <summary>
        /// Clears various types of browsing data stored in a user's profile.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="dataToRemove"></param>
        public static void remove(RemovalOptions options, BrowsingDataDataToRemove dataToRemove) { }

        /// <summary>
        /// Clears websites' appcache data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional )Called when websites' appcache data has been cleared.</param>
        public static void removeAppcache(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' appcache data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeAppcache(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's cache.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional )Called when the browser's cache has been cleared.</param>
        public static void removeCache(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's cache.
        /// </summary>
        /// <param name="options"></param>
        public static void removeCache(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's cookies modified within a particular timeframe.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's cookies have been cleared.</param>
        public static void removeCookies(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's cookies modified within a particular timeframe.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's cookies have been cleared.</param>
        public static void removeCookies(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's list of downloaded files (not the downloaded files themselves).
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's list of downloaded files has been cleared.</param>
        public static void removeDownloads(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's list of downloaded files (not the downloaded files themselves).
        /// </summary>
        /// <param name="options"></param>
        public static void removeDownloads(RemovalOptions options) { }

        /// <summary>
        /// Clears websites' file system data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback"> ( optional ) Called when websites' file systems have been cleared.</param>
        public static void removeFileSystems(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' file system data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeFileSystems(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's stored form data (autofill).
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's form data has been cleared.</param>
        public static void removeFormData(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's stored form data (autofill).
        /// </summary>
        /// <param name="options"></param>
        public static void removeFormData(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's history.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's history has cleared.</param>
        public static void removeHistory(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's history.
        /// </summary>
        /// <param name="options"></param>
        public static void removeHistory(RemovalOptions options) { }

        /// <summary>
        /// Clears websites' IndexedDB data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when websites' IndexedDB data has been cleared.</param>
        public static void removeIndexedDB(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' IndexedDB data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeIndexedDB(RemovalOptions options) { }

        /// <summary>
        /// Clears websites' local storage data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when websites' local storage has been cleared.</param>
        public static void removeLocalStorage(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' local storage data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeLocalStorage(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's stored passwords.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's passwords have been cleared.</param>
        public static void removePasswords(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's stored passwords.
        /// </summary>
        /// <param name="options"></param>
        public static void removePasswords(RemovalOptions options) { }

        /// <summary>
        /// Clears plugins' data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when plugins' data has been cleared.</param>
        public static void removePluginData(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears plugins' data.
        /// </summary>
        /// <param name="options"></param>
        public static void removePluginData(RemovalOptions options) { }

        /// <summary>
        /// Clears websites' WebSQL data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback"> ( optional ) Called when websites' WebSQL databases have been cleared.</param>
        public static void removeWebSQL(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' WebSQL data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeWebSQL(RemovalOptions options) { }
    }

    [JsType(JsMode.Json)]
    public class BrowsingDataDataToRemove
    {
        /// <summary>
        /// ( optional )
        /// Should websites' appcaches be cleared?
        /// </summary>
        public bool appcache { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's cache be cleared? Note: this clears the entire cache: it is not limited to the range you specify.
        /// </summary>
        public bool cache { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's cookies be cleared?
        /// </summary>
        public bool cookies { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's download list be cleared?
        /// </summary>
        public bool downloads { get; set; }

        /// <summary>
        /// ( optional )
        /// Should websites' file systems be cleared?
        /// </summary>
        public bool fileSystems { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's stored form data be cleared?
        /// </summary>
        public bool formData { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's history be cleared?
        /// </summary>
        public bool history { get; set; }

        /// <summary>
        /// ( optional )
        /// Should websites' IndexedDB data be cleared?
        /// </summary>
        public bool indexedDB { get; set; }

        /// <summary>
        /// ( optional )
        /// Should websites' local storage data be cleared?
        /// </summary>
        public bool localStorage { get; set; }

        /// <summary>
        /// ( optional )
        /// Should server-bound certificates be removed?
        /// </summary>
        public bool serverBoundCertificates { get; set; }

        /// <summary>
        /// ( optional )
        /// Should plugins' data be cleared?
        /// </summary>
        public bool pluginData { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the stored passwords be cleared?
        /// </summary>
        public bool passwords { get; set; }

        /// <summary>
        /// ( optional )
        /// Should websites' WebSQL data be cleared?
        /// </summary>
        public bool webSQL { get; set; }

    }

    /// <summary>
    /// Options that determine exactly what data will be removed.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.browsingData.RemovalOptions", Export = false)]
    public class RemovalOptions
    {
        /// <summary>
        /// Remove data accumulated on or after this date, represented in milliseconds since the epoch(accessible via the getTime method of the JavaScript Date object).
        /// If absent, defaults to 0 (which would remove all browsing data).
        /// </summary>
        public JsNumber since { get; set; }

        /// <summary>
        /// An object whose properties specify which origin types ought to be cleared. If this object isn't specified, it defaults to clearing only "unprotected" origins.
        /// Please ensure that you really want to remove application data before adding 'protectedWeb' or 'extensions'.
        /// </summary>
        public RemovalOptionsOriginTypes originTypes { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RemovalOptionsOriginTypes
    {
        /// <summary>
        /// ( optional )Normal websites.
        /// </summary>
        public bool unprotectedWeb { get; set; }

        /// <summary>
        /// ( optional )Websites that have been installed as hosted applications (be careful!).
        /// </summary>
        public bool protectedWeb { get; set; }

        /// <summary>
        /// ( optional ) Extensions and packaged applications a user has installed (be _really_ careful!).
        /// </summary>
        public bool extension { get; set; }
    }

    #endregion

    #region contentSettings

    [JsType(JsMode.Prototype, Name = "chrome.contentSettings", Export = false)]
    public class contentSettings
    {
        /// <summary>
        /// Whether to allow cookies and other local data to be set by websites. One of
        /// allow: Accept cookies,
        /// block: Block cookies,
        /// session_only: Accept cookies only for the current session. 
        /// Default is allow.
        /// The primary URL is the URL representing the cookie origin. The secondary URL is the URL of the top-level frame.
        /// </summary>
        public ContentSetting cookies { get; set; }

        /// <summary>
        /// Whether to show images. One of
        /// allow: Show images,
        /// block: Don't show images. 
        /// Default is allow.
        /// The primary URL is the main-frame URL. The secondary URL is the URL of the image.
        /// </summary>
        public ContentSetting images { get; set; }

        /// <summary>
        /// Whether to run JavaScript. One of
        /// allow: Run JavaScript,
        /// block: Don't run JavaScript. 
        /// Default is allow.
        /// The primary URL is the main-frame URL. The secondary URL is not used.
        /// </summary>
        public ContentSetting javascript { get; set; }

        /// <summary>
        /// Whether to run plug-ins. One of
        /// allow: Run plug-ins automatically,
        /// block: Don't run plug-ins automatically. 
        /// Default is allow.
        /// The primary URL is the main-frame URL. The secondary URL is not used.
        /// </summary>
        public ContentSetting plugins { get; set; }

        /// <summary>
        /// Whether to allow sites to show pop-ups. One of
        /// allow: Allow sites to show pop-ups,
        /// block: Don't allow sites to show pop-ups. 
        /// Default is block.
        /// The primary URL is the main-frame URL. The secondary URL is not used.
        /// </summary>
        public ContentSetting popups { get; set; }

        /// <summary>
        /// Whether to allow sites to show desktop notifications. One of
        /// allow: Allow sites to show desktop notifications,
        /// block: Don't allow sites to show desktop notifications,
        /// ask: Ask when a site wants to show desktop notifications. 
        /// Default is ask.
        /// The primary URL is the main-frame URL. The secondary URL is not used.
        /// </summary>
        public ContentSetting notifications { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.contentSettings.ContentSetting", Export = false)]
    public class ContentSetting
    {
        /// <summary>
        /// Clear all content setting rules set by this extension.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void clear(ContentSettingClearDetails details, JsAction callback) { }
        /// <summary>
        /// Clear all content setting rules set by this extension.
        /// </summary>
        /// <param name="details"></param>
        public static void clear(ContentSettingClearDetails details) { }

        /// <summary>
        /// Gets the current content setting for a given pair of URLs.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void get(ContentSettingGetDetails details, JsAction callback) { }

        public static void getResourceIdentifiers(JsAction callback) { }

        /// <summary>
        /// Applies a new content setting rule.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void set(ContentSettingSetDetails details, JsAction callback) { }
        /// <summary>
        /// Applies a new content setting rule.
        /// </summary>
        /// <param name="details"></param>
        public static void set(ContentSettingSetDetails details) { }
    }
    //TODO: the methods in this class are static right?

    /// <summary>
    /// The only content type using resource identifiers is plugins. For more information, see Resource Identifiers.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.contentSettings.ResourceIdentifier", Export = false)]
    public class ResourceIdentifier
    {

        /// <summary>
        /// The resource identifier for the given content type.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional )A human readable description of the resource.
        /// </summary>
        public JsString description { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ContentSettingClearDetails
    {
        /// <summary>
        /// ( optional enumerated string ["regular", "incognito_session_only"] ). Where to set the setting (default: regular). 
        /// </summary>
        public ScopeType scope { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ScopeType
    {
        /// <summary>
        /// setting for regular profile (which is inherited by the incognito profile if not overridden elsewhere),
        /// </summary>
        regular,
        /// <summary>
        /// setting for incognito profile that can only be set during an incognito session and is deleted when the incognito session ends (overrides regular settings).
        /// </summary>
        incognito_session_only,
    }
    //TODO: make sure i was right with this eunm

    [JsType(JsMode.Json)]
    public class ContentSettingGetDetails
    {
        /// <summary>
        /// The primary URL for which the content setting should be retrieved. Note that the meaning of a primary URL depends on the content type.
        /// </summary>
        public JsString primaryUrl { get; set; }

        /// <summary>
        /// ( optional ) The secondary URL for which the content setting should be retrieved. Defaults to the primary URL.
        /// Note that the meaning of a secondary URL depends on the content type, and not all content types use secondary URLs.
        /// </summary>
        public JsString secondaryUrl { get; set; }

        /// <summary>
        ///  ( optional ) A more specific identifier of the type of content for which the settings should be retrieved.
        /// </summary>
        public ResourceIdentifier resourceIdentifier { get; set; }

        /// <summary>
        /// ( optional ) Whether to check the content settings for an incognito session. (default false)
        /// </summary>
        public bool incognito { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ContentSettingSetDetails
    {
        /// <summary>
        /// The pattern for the primary URL. For details on the format of a pattern, see Content Setting Patterns.
        /// </summary>
        public JsString primaryPattern { get; set; }

        /// <summary>
        /// ( optional ) The pattern for the secondary URL. Defaults to matching all URLs. For details on the format of a pattern, see Content Setting Patterns.
        /// </summary>
        public JsString secondaryPattern { get; set; }

        /// <summary>
        ///  ( optional ) The resource identifier for the content type.
        /// </summary>
        public ResourceIdentifier resourceIdentifier { get; set; }

        /// <summary>
        /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
        /// </summary>
        public ContentSetting setting { get; set; }

        /// <summary>
        /// ( optional enumerated string ["regular", "incognito_session_only"] ).Where to clear the setting (default: regular). 
        /// </summary>
        public ScopeType scope { get; set; }
    }

    #endregion

    #region contextMenus

    [JsType(JsMode.Prototype, Name = "chrome.contextMenus", Export = false)]
    public class contextMenus
    {
        /// <summary>
        /// Creates a new context menu item. Note that if an error occurs during creation,
        /// you may not find out until the creation callback fires (the details will be in chrome.extension.lastError).
        /// </summary>
        /// <param name="createProperties"></param>
        /// <param name="callback">( optional )Called when the item has been created in the browser.
        /// If there were any problems creating the item, details will be available in chrome.extension.lastError.</param>
        /// <returns></returns>
        public static object create(CreateProperties createProperties, JsAction callback) { return null; }
        /// <summary>
        /// Creates a new context menu item. Note that if an error occurs during creation,
        /// you may not find out until the creation callback fires (the details will be in chrome.extension.lastError).
        /// </summary>
        /// <param name="createProperties"></param>
        /// <returns></returns>
        public static object create(CreateProperties createProperties) { return null; }

        /// <summary>
        /// Removes a context menu item.
        /// </summary>
        /// <param name="menuItemId">The ID of the context menu item to remove.</param>
        /// <param name="callback">( optional function ) Called when the context menu has been removed.</param>
        public static void remove(JsNumber menuItemId, JsAction callback) { }
        /// <summary>
        /// Removes a context menu item.
        /// </summary>
        /// <param name="menuItemId">The ID of the context menu item to remove.</param>
        /// <param name="callback">( optional function ) Called when the context menu has been removed.</param>
        public static void remove(JsString menuItemId, JsAction callback) { }
        /// <summary>
        /// Removes a context menu item.
        /// </summary>
        /// <param name="menuItemId">The ID of the context menu item to remove.</param>
        public static void remove(JsNumber menuItemId) { }
        /// <summary>
        /// Removes a context menu item.
        /// </summary>
        /// <param name="menuItemId">The ID of the context menu item to remove.</param>
        public static void remove(JsString menuItemId) { }

        /// <summary>
        /// Removes all context menu items added by this extension.
        /// </summary>
        /// <param name="callback">( optional )Called when removal is complete.</param>
        public static void removeAll(JsAction callback) { }
        /// <summary>
        /// Removes all context menu items added by this extension.
        /// </summary>
        public static void removeAll() { }

        /// <summary>
        /// Updates a previously created context menu item.
        /// </summary>
        /// <param name="id">The ID of the item to update</param>
        /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
        /// <param name="callback"> ( optional ) Called when the context menu has been updated.</param>
        public static void update(JsNumber id, UpdateProperties updateProperties, JsAction callback) { }
        /// <summary>
        /// Updates a previously created context menu item.
        /// </summary>
        /// <param name="id">The ID of the item to update</param>
        /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
        /// <param name="callback"> ( optional ) Called when the context menu has been updated.</param>
        public static void update(JsString id, UpdateProperties updateProperties, JsAction callback) { }
        /// <summary>
        /// Updates a previously created context menu item.
        /// </summary>
        /// <param name="id">The ID of the item to update</param>
        /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
        public static void update(JsNumber id, UpdateProperties updateProperties) { }
        /// <summary>
        /// Updates a previously created context menu item.
        /// </summary>
        /// <param name="id">The ID of the item to update</param>
        /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
        public static void update(JsString id, UpdateProperties updateProperties) { }

        /// <summary>
        /// Fired when a context menu item is clicked.
        /// </summary>
        public static Event<JsAction<OnClickData, Tab>> onClicked { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CreateProperties
    {
        /// <summary>
        ///  ( optional enumerated string ["normal", "checkbox", "radio", "separator"] )
        ///  The type of menu item. Defaults to 'normal' if not specified.
        /// </summary>
        public CreatePropertiesType type { get; set; }

        /// <summary>
        /// ( optional )
        /// The unique ID to assign to this item. Mandatory for event pages. Cannot be the same as another ID for this extension.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional )
        /// The text to be displayed in the item; this is required unless type is 'separator'. When the context is 'selection', you can use %s within the string to show the selected text.
        /// For example, if this parameter's value is "Translate '%s' to Pig Latin" and the user selects the word "cool",the context menu item for the selection is "Translate 'cool' to Pig Latin".
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional )
        /// The initial state of a checkbox or radio item: true for selected and false for unselected. Only one radio item can be selected at a time in a given group of radio items.
        /// </summary>
        public bool @checked { get; set; }

        /// <summary>
        /// ( optional array of string ["all", "page", "frame", "selection", "link", "editable", "image", "video", "audio"] )
        /// List of contexts this menu item will appear in. Defaults to ['page'] if not specified.
        /// </summary>
        public JsArray<CreatePropertiesContexts> contexts { get; set; }

        /// <summary>
        /// ( optional )
        /// A function that will be called back when the menu item is clicked.
        /// Event pages cannot use this; instead, they should register a listener for chrome.contextMenus.onClicked.
        /// </summary>
        public JsAction<Tab, OnClickData> onclick { get; set; }

        /// <summary>
        /// ( optional )
        /// The ID of a parent menu item; this makes the item a child of a previously added item.
        /// </summary>
        [JsProperty(Name = "parentId")]
        public JsString parentIdString { get; set; }
        /// <summary>
        /// ( optional )
        /// The ID of a parent menu item; this makes the item a child of a previously added item.
        /// </summary>
        public JsNumber parentId { get; set; }

        /// <summary>
        /// ( optional )
        /// Lets you restrict the item to apply only to documents whose URL matches one of the given patterns.
        /// (This applies to frames as well.) For details on the format of a pattern, see Match Patterns.
        /// </summary>
        public JsArray<JsString> documentUrlPatterns { get; set; }

        /// <summary>
        /// ( optional )
        /// Similar to documentUrlPatterns, but lets you filter based on the src attribute of img/audio/video tags and the href of anchor tags.
        /// </summary>
        public JsArray<JsString> targetUrlPatterns { get; set; }

        /// <summary>
        /// ( optional )
        /// Whether this context menu item is enabled or disabled. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum CreatePropertiesType
    {
        normal,
        checkbox,
        radio,
        separator,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum CreatePropertiesContexts
    {
        all,
        page,
        frame,
        selection,
        link,
        editable,
        image,
        video,
        audio,
    }

    /// <summary>
    /// Information sent when a context menu item is clicked.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.contextMenus.OnClickData", Export = false)]
    public class OnClickData
    {
        /// <summary>
        /// The ID of the menu item that was clicked.
        /// </summary>
        [JsProperty(Name = "menuItemId")]
        public JsString menuItemIdString { get; set; }
        /// <summary>
        /// The ID of the menu item that was clicked.
        /// </summary>
        [JsProperty(Name = "menuItemId")]
        public JsNumber menuItemId { get; set; }

        /// <summary>
        /// ( optional ) The parent ID, if any, for the item clicked.
        /// </summary>
        [JsProperty(Name = "parentMenuItemId")]
        public JsString parentMenuItemIdString { get; set; }
        /// <summary>
        /// ( optional ) The parent ID, if any, for the item clicked.
        /// </summary>
        public JsNumber parentMenuItemId { get; set; }

        /// <summary>
        /// ( optional ) One of 'image', 'video', or 'audio' if the context menu was activated on one of these types of elements.
        /// </summary>
        public MediaType mediaType { get; set; }

        /// <summary>
        /// ( optional ) If the element is a link, the URL it points to.
        /// </summary>
        public JsString linkUrl { get; set; }

        /// <summary>
        /// ( optional ) Will be present for elements with a 'src' URL.
        /// </summary>
        public JsString srcUrl { get; set; }

        /// <summary>
        /// The URL of the page where the menu item was clicked.
        /// </summary>
        public JsString pageUrl { get; set; }

        /// <summary>
        /// ( optional ) The URL of the frame of the element where the context menu was clicked, if it was in a frame.
        /// </summary>
        public JsString frameUrl { get; set; }

        /// <summary>
        /// ( optional ) The text for the context selection, if any.
        /// </summary>
        public JsString selectionText { get; set; }

        /// <summary>
        /// ( optional ) A flag indicating whether the element is editable (text input, textarea, etc.).
        /// </summary>
        public bool editable { get; set; }

        /// <summary>
        /// ( optional ) A flag indicating the state of a checkbox or radio item before it was clicked.
        /// </summary>
        public bool wasChecked { get; set; }

        /// <summary>
        /// ( optional ) A flag indicating the state of a checkbox or radio item after it is clicked.
        /// </summary>
        public bool @checked { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum MediaType
    {
        image,
        video,
        audio,
    }

    [JsType(JsMode.Json)]
    public class UpdateProperties : CreateProperties
    {
    }

    #endregion

    #region cookies

    [JsType(JsMode.Prototype, Name = "chrome.cookies", Export = false)]
    public class cookies
    {
        /// <summary>
        /// Retrieves information about a single cookie. If more than one cookie of the same name exists for the given URL, the one with the longest path will be returned.
        /// For cookies with the same path length, the cookie with the earliest creation time will be returned.
        /// </summary>
        /// <param name="details">Details to identify the cookie being retrieved.</param>
        /// <param name="callback"></param>
        public static void get(CookiesGetDetails details, JsAction<Cookie> callback) { }

        /// <summary>
        /// Retrieves all cookies from a single cookie store that match the given information. The cookies returned will be sorted, with those with the longest path first.
        /// If multiple cookies have the same path length, those with the earliest creation time will be first.
        /// </summary>
        /// <param name="details">Information to filter the cookies being retrieved.</param>
        /// <param name="callback"></param>
        public static void getAll(CookiesGetAllDetails details, JsAction<JsArray<Cookie>> callback) { }

        /// <summary>
        /// Lists all existing cookie stores.
        /// </summary>
        /// <param name="callback"></param>
        public static void getAllCookieStores(JsAction<JsArray<CookieStore>> callback) { }

        /// <summary>
        /// Deletes a cookie by name.
        /// </summary>
        /// <param name="details">Information to identify the cookie to remove.</param>
        /// <param name="callback">( optional ) This parameter was added in version 11.0.674.0. You must omit this parameter in earlier versions, and you may omit it in any version.
        /// If you require this parameter, the manifest key minimum_chrome_version can ensure that your extension won't be run in an earlier browser version.</param>
        public static void remove(CookiesRemoveDetails details, JsAction callback) { }
        /// <summary>
        /// Deletes a cookie by name.
        /// </summary>
        /// <param name="details">Information to identify the cookie to remove.</param>
        public static void remove(CookiesRemoveDetails details) { }

        /// <summary>
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// </summary>
        /// <param name="details">Details about the cookie being set.</param>
        /// <param name="callback"> ( optional ) This parameter was added in version 11.0.674.0. You must omit this parameter in earlier versions, and you may omit it in any version.
        /// If you require this parameter, the manifest key minimum_chrome_version can ensure that your extension won't be run in an earlier browser version.</param>
        public static void set(CookiesSetAllDetails details, JsAction callback) { }
        /// <summary>
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// </summary>
        /// <param name="details">Details about the cookie being set.</param>
        public static void set(CookiesSetAllDetails details) { }
    }

    [JsType(JsMode.Json)]
    public class CookiesGetDetails
    {

        /// <summary>
        /// The URL with which the cookie to retrieve is associated. This argument may be a full URL, in which case any data following the URL path (e.g. the query string) is simply ignored.
        /// If host permissions for this URL are not specified in the manifest file, the API call will fail.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The name of the cookie to retrieve.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) The ID of the cookie store in which to look for the cookie. By default, the current execution context's cookie store will be used.
        /// </summary>
        public JsString storeId { get; set; }


    }

    [JsType(JsMode.Json)]
    public class CookiesGetAllDetails
    {

        /// <summary>
        /// ( optional ) Restricts the retrieved cookies to those that would match the given URL.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) Filters the cookies by name.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) Restricts the retrieved cookies to those whose domains match or are subdomains of this one.
        /// </summary>
        public JsString domain { get; set; }

        /// <summary>
        /// ( optional ) Restricts the retrieved cookies to those whose path exactly matches this string.
        /// </summary>
        public JsString path { get; set; }

        /// <summary>
        /// ( optional ) Filters the cookies by their Secure property.
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// ( optional ) Filters out session vs. persistent cookies.
        /// </summary>
        public bool session { get; set; }

        /// <summary>
        /// ( optional ) The cookie store to retrieve cookies from. If omitted, the current execution context's cookie store will be used.
        /// </summary>
        public JsString storeId { get; set; }


    }

    [JsType(JsMode.Json)]
    public class CookiesRemoveDetails
    {

        /// <summary>
        /// The URL associated with the cookie. If host permissions for this URL are not specified in the manifest file, the API call will fail.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The name of the cookie to remove.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) The ID of the cookie store to look in for the cookie. If unspecified, the cookie is looked for by default in the current execution context's cookie store.
        /// </summary>
        public JsString storeId { get; set; }


    }

    [JsType(JsMode.Json)]
    public class CookiesSetAllDetails
    {

        /// <summary>
        /// ( optional ) The request-URI to associate with the setting of the cookie. This value can affect the default domain and path values of the created cookie.
        /// If host permissions for this URL are not specified in the manifest file, the API call will fail.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) The name of the cookie. Empty by default if omitted.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) The value of the cookie. Empty by default if omitted.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// ( optional ) The domain of the cookie. If omitted, the cookie becomes a host-only cookie.
        /// </summary>
        public JsString domain { get; set; }

        /// <summary>
        /// ( optional ) The path of the cookie. Defaults to the path portion of the url parameter.
        /// </summary>
        public JsString path { get; set; }

        /// <summary>
        /// ( optional ) Whether the cookie should be marked as Secure. Defaults to false.
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// ( optional ) Whether the cookie should be marked as HttpOnly. Defaults to false.
        /// </summary>
        public bool httpOnly { get; set; }

        /// <summary>
        /// ( optional ) The expiration date of the cookie as the number of seconds since the UNIX epoch. If omitted, the cookie becomes a session cookie.
        /// </summary>
        public JsNumber expirationDate { get; set; }

        /// <summary>
        /// ( optional ) The ID of the cookie store in which to set the cookie. By default, the cookie is set in the current execution context's cookie store.
        /// </summary>
        public JsString storeId { get; set; }
    }

    /// <summary>
    /// Represents information about an HTTP cookie.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.cookies.Cookie", Export = false)]
    public class Cookie
    {

        /// <summary>
        /// The name of the cookie.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// The value of the cookie.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// The domain of the cookie (e.g. "www.google.com", "example.com").
        /// </summary>
        public JsString domain { get; set; }

        /// <summary>
        /// True if the cookie is a host-only cookie (i.e. a request's host must exactly match the domain of the cookie).
        /// </summary>
        public bool hostOnly { get; set; }

        /// <summary>
        /// The path of the cookie.
        /// </summary>
        public JsString path { get; set; }

        /// <summary>
        /// True if the cookie is marked as Secure (i.e. its scope is limited to secure channels, typically HTTPS).
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// True if the cookie is marked as HttpOnly (i.e. the cookie is inaccessible to client-side scripts).
        /// </summary>
        public bool httpOnly { get; set; }

        /// <summary>
        /// True if the cookie is a session cookie, as opposed to a persistent cookie with an expiration date.
        /// </summary>
        public bool session { get; set; }

        /// <summary>
        /// The expiration date of the cookie as the number of seconds since the UNIX epoch. Not provided for session cookies.
        /// </summary>
        public JsNumber expirationDate { get; set; }

        /// <summary>
        /// The ID of the cookie store containing this cookie, as provided in getAllCookieStores().
        /// </summary>
        public JsString storeId { get; set; }
    }

    /// <summary>
    /// Represents a cookie store in the browser. An incognito mode window, for instance, uses a separate cookie store from a non-incognito window.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.cookies.CookieStore", Export = false)]
    public class CookieStore
    {
        /// <summary>
        /// The unique identifier for the cookie store.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Identifiers of all the browser tabs that share this cookie store.
        /// </summary>
        public JsArray<JsNumber> tabIds { get; set; }
    }

    #endregion

    #region debugger

    [JsType(JsMode.Prototype, Name = "chrome.debugger", Export = false)]
    public class debugger
    {
        /// <summary>
        /// Attaches debugger to the given target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to attach.</param>
        /// <param name="requiredVersion">Required debugging protocol version ("0.1"). One can only attach to the debuggee with matching major version and greater or equal minor version.
        /// List of the protocol versions can be obtained here: https://developers.google.com/chrome-developer-tools/docs/remote-debugging </param>
        /// <param name="callback">( optional )Called once the attach operation succeeds or fails. Callback receives no arguments. If the attach fails, chrome.extension.lastError will be set to the error message.</param>
        public static void attach(Debuggee target, JsString requiredVersion, JsAction callback) { }
        /// <summary>
        /// Attaches debugger to the given target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to attach.</param>
        /// <param name="requiredVersion">Required debugging protocol version ("0.1"). One can only attach to the debuggee with matching major version and greater or equal minor version.
        /// List of the protocol versions can be obtained here: https://developers.google.com/chrome-developer-tools/docs/remote-debugging </param>
        public static void attach(Debuggee target, JsString requiredVersion) { }

        /// <summary>
        /// Detaches debugger from the given target.
        /// </summary>
        /// <param name="target">Debugging target from which you want to detach.</param>
        /// <param name="callback">( optional ) Called once the detach operation succeeds or fails. Callback receives no arguments.
        /// If the detach fails, chrome.extension.lastError will be set to the error message.</param>
        public static void detach(Debuggee target, JsAction callback) { }
        /// <summary>
        /// Detaches debugger from the given target.
        /// </summary>
        /// <param name="target">Debugging target from which you want to detach.</param>
        public static void detach(Debuggee target) { }

        /// <summary>
        /// Sends given command to the debugging target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to send the command.</param>
        /// <param name="method">Method name. Should be one of the methods defined by the remote debugging protocol.</param>
        /// <param name="params">JSON object with request parameters. This object must conform to the remote debugging params scheme for given method.</param>
        /// <param name="callback">Response body. If an error occurs while posting the message, the callback will be called with no arguments and chrome.extension.lastError will be set to the error message.</param>
        public static void sendCommand(Debuggee target, JsString method, object @params, JsAction callback) { }
        /// <summary>
        /// Sends given command to the debugging target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to send the command.</param>
        /// <param name="method">Method name. Should be one of the methods defined by the remote debugging protocol.</param>
        /// <param name="params">JSON object with request parameters. This object must conform to the remote debugging params scheme for given method.</param>
        public static void sendCommand(Debuggee target, JsString method, object @params) { }
        /// <summary>
        /// Sends given command to the debugging target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to send the command.</param>
        /// <param name="method">Method name. Should be one of the methods defined by the remote debugging protocol.</param>
        public static void sendCommand(Debuggee target, JsString method) { }

        /// <summary>
        /// Fired when browser terminates debugging session for the tab. This happens when either the tab is being closed or Chrome DevTools is being invoked for the attached tab.
        /// </summary>
        public static Event<JsAction<Debuggee>> onDetach { get; set; }

        /// <summary>
        /// Fired whenever debugging target issues instrumentation event.
        /// Listener parameters:
        /// source ( debugger.Debuggee )
        /// The debuggee that generated this event.
        /// method ( string )
        /// Method name. Should be one of the notifications defined by the remote debugging protocol.
        /// params ( optional object )
        /// JSON object with the response. Structure of the response varies depending on the method and is defined by the remote debugging protocol.
        /// </summary>
        public static Event<JsAction<Debuggee, JsString, object>> onEvent { get; set; }
    }

    /// <summary>
    /// Debuggee identifier.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.debugger.Debuggee", Export = false)]
    public class Debuggee
    {
        /// <summary>
        /// The id of the tab which you intend to debug.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    #endregion

    #region declarativeWebRequest

    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest", Export = false)]
    public class declarativeWebRequest
    {
        //TODO: this class is empty (?)
    }

    /// <summary>
    /// Redirects a request by applying a regular expression on the URL. The regular expressions use the RE2 syntax.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RedirectByRegEx", Export = false)]
    public class RedirectByRegEx
    {
        /// <summary>
        /// A match pattern that may contain capture groups. Capture groups are referenced in the Perl syntax
        /// ($1, $2, ...) instead of the RE2 syntax (\1, \2, ...) in order to be closer to JavaScript Regular Expressions.
        /// </summary>
        public JsString from { get; set; }

        /// <summary>
        /// Destination pattern.
        /// </summary>
        public JsString to { get; set; }
    }

    /// <summary>
    /// Matches network events by various criteria.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RequestMatcher", Export = false)]
    public class RequestMatcher
    {
        /// <summary>
        /// ( optional events.UrlFilter ) Matches if the condition of the UrlFilter are fulfilled for the URL of the request.
        /// </summary>
        public UrlFilter url { get; set; }

        /// <summary>
        /// ( optional array of string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] ) Matches if the request type of a request is contained in the list. Requests that cannot match any of the types will be filtered out.
        /// </summary>
        public JsArray<ResourceType> resourceType { get; set; }

        /// <summary>
        /// ( enumerated string ["declarativeWebRequest.RequestMatcher"] )
        /// </summary>
        public JsString instanceType { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ResourceType
    {
        main_frame,
        sub_frame,
        stylesheet,
        script,
        image,
        @object,
        xmlhttprequest,
        other,
    }

    /// <summary>
    /// Declarative event action that redirects a network request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RedirectRequest", Export = false)]
    public class RedirectRequest
    {
        /// <summary>
        /// ( enumerated string ["declarativeWebRequest.RedirectRequest"] )
        /// </summary>
        public JsString instanceType { get; set; }

        /// <summary>
        /// Destination to where the request is redirected.
        /// </summary>
        public JsString redirectUrl { get; set; }
    }

    /// <summary>
    /// Declarative event action that redirects a network request to a transparent image.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RedirectToTransparentImage", Export = false)]
    public class RedirectToTransparentImage
    {
    }

    /// <summary>
    /// Declarative event action that redirects a network request to an empty document.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RedirectToEmptyDocument", Export = false)]
    public class RedirectToEmptyDocument
    {
    }

    /// <summary>
    /// Declarative event action that cancels a network request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.CancelRequest", Export = false)]
    public class CancelRequest
    {
        /// <summary>
        /// ( enumerated string ["declarativeWebRequest.CancelRequest"] )
        /// </summary>
        public JsString instanceType { get; set; }
    }

    /// <summary>
    /// Sets the request header of the specified name to the specified value. If a header with the specified name did not exist before, a new one is created.
    /// Header name comparison is always case-insensitive. Each request header name occurs only once in each request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.SetRequestHeader", Export = false)]
    public class SetRequestHeader
    {
        /// <summary>
        /// HTTP request header name.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// HTTP request header value.
        /// </summary>
        public JsString value { get; set; }
    }

    /// <summary>
    /// Removes the request header of the specified name. Do not use SetRequestHeader and RemoveRequestHeader with the same header name on the same request.
    /// Each request header name occurs only once in each request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RemoveRequestHeader", Export = false)]
    public class RemoveRequestHeader
    {
        /// <summary>
        /// HTTP request header name (case-insensitive).
        /// </summary>
        public JsString name { get; set; }
    }

    /// <summary>
    /// Adds the response header to the response of this web request.
    /// As multiple response headers may share the same name, you need to first remove and then add a new response header in order to replace one.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.AddResponseHeader", Export = false)]
    public class AddResponseHeader
    {
        /// <summary>
        /// HTTP request header name.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// HTTP request header value.
        /// </summary>
        public JsString value { get; set; }
    }

    /// <summary>
    /// Removes all response headers of the specified names and values.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RemoveResponseHeader", Export = false)]
    public class RemoveResponseHeader
    {
        /// <summary>
        /// HTTP request header name.(case-insensitive).
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        ///( optional ) HTTP request header value.(case-insensitive).
        /// </summary>
        public JsString value { get; set; }


    }

    /// <summary>
    /// Masks all rules that match the specified criteria.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.IgnoreRules", Export = false)]
    public class IgnoreRules
    {
        /// <summary>
        /// If set, rules with a lower priority than the specified value are ignored.
        /// This boundary is not persited, it affects only rules and their actions of the same network request stage. TODO(battre): Explain network request stages.
        /// </summary>
        public JsNumber lowerPriorityThan { get; set; }
    }

    #endregion

    #region events

    [JsType(JsMode.Prototype, Name = "chrome.events.Event", Export = false)]
    public class Event<T>
    {
        public void addEventListener(T action) { }
        public void removeEventListener(T action) { }
        public bool hasEventListener(T action) { return false; }


        /// <summary>
        /// Registers rules to handle events.
        /// </summary>
        /// <param name="rules">Rules to be registered. These do not replace previously registered rules.</param>
        /// <param name="callback">( optional ) Called with registered rules.</param>
        public void addRules(JsArray<Rule> rules, JsAction<AddRulesDetails> callback) { }
        /// <summary>
        /// Registers rules to handle events.
        /// </summary>
        /// <param name="rules">Rules to be registered. These do not replace previously registered rules.</param>
        public void addRules(JsArray<Rule> rules) { }

        /// <summary>
        /// Returns currently registered rules.
        /// </summary>
        /// <param name="ruleIdentifiers">( optional ) If an array is passed, only rules with identifiers contained in this array are returned.</param>
        /// <param name="callback">Called with registered rules.</param>
        public void getRules(JsArray<JsString> ruleIdentifiers, JsAction<AddRulesDetails> callback) { }
        /// <summary>
        /// Returns currently registered rules.
        /// </summary>
        /// <param name="callback">Called with registered rules.</param>
        public void getRules(JsAction<AddRulesDetails> callback) { }

        public void hasListener() { }
        public void hasListeners() { }
        public void removeListener() { }

        /// <summary>
        /// Unregisters currently registered rules.
        /// </summary>
        /// <param name="ruleIdentifiers"> ( optional ) If an array is passed, only rules with identifiers contained in this array are unregistered.</param>
        /// <param name="callback">( optional ) Called when rules were unregistered.</param>
        public void removeRules(JsArray<JsString> ruleIdentifiers, JsAction callback) { }
        /// <summary>
        /// Unregisters currently registered rules.
        /// </summary>
        /// <param name="ruleIdentifiers"> ( optional ) If an array is passed, only rules with identifiers contained in this array are unregistered.</param>
        public void removeRules(JsArray<JsString> ruleIdentifiers) { }
        /// <summary>
        /// Unregisters currently registered rules.
        /// </summary>
        public void removeRules() { }

    }

    /// <summary>
    /// Description of a declarative rule for handling events.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.events.Rule", Export = false)]
    public class Rule
    {
        /// <summary>
        /// Optional identifier that allows referencing this rule.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// List of conditions that can trigger the actions.
        /// </summary>
        public JsArray<object> conditions { get; set; }

        /// <summary>
        /// List of actions that are triggered if one of the condtions is fulfilled.
        /// </summary>
        public JsArray<object> actions { get; set; }

        /// <summary>
        /// Optional priority of this rule. Defaults to 100.
        /// </summary>
        public JsNumber priority { get; set; }

    }

    /// <summary>
    /// Filters URLs for various criteria
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.events.UrlFilter", Export = false)]
    public class UrlFilter
    {
        /// <summary>
        /// ( optional ) Matches if the host name of the URL contains a specified string.
        /// </summary>
        public JsString hostContains { get; set; }

        /// <summary>
        /// ( optional ) Matches if the host name of the URL is equal to a specified string.
        /// </summary>
        public JsString hostEquals { get; set; }

        /// <summary>
        /// ( optional ) Matches if the host name of the URL starts with a specified string.
        /// </summary>
        public JsString hostPrefix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the host name of the URL ends with a specified string.
        /// </summary>
        public JsString hostSuffix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the path segment of the URL contains a specified string.
        /// </summary>
        public JsString pathContains { get; set; }

        /// <summary>
        /// ( optional ) Matches if the path segment of the URL is equal to a specified string.
        /// </summary>
        public JsString pathEquals { get; set; }

        /// <summary>
        /// ( optional ) Matches if the path segment of the URL starts with a specified string.
        /// </summary>
        public JsString pathPrefix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the path segment of the URL ends with a specified string.
        /// </summary>
        public JsString pathSuffix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the query segment of the URL contains a specified string.
        /// </summary>
        public JsString queryContains { get; set; }

        /// <summary>
        /// ( optional ) Matches if the query segment of the URL is equal to a specified string.
        /// </summary>
        public JsString queryEquals { get; set; }

        /// <summary>
        /// ( optional ) Matches if the query segment of the URL starts with a specified string.
        /// </summary>
        public JsString queryPrefix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the query segment of the URL ends with a specified string.
        /// </summary>
        public JsString querySuffix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the URL contains a specified string.
        /// </summary>
        public JsString urlContains { get; set; }

        /// <summary>
        /// ( optional ) Matches if the URL is equal to a specified string.
        /// </summary>
        public JsString urlEquals { get; set; }

        /// <summary>
        /// ( optional ) Matches if the URL starts with a specified string.
        /// </summary>
        public JsString urlPrefix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the URL ends with a specified string.
        /// </summary>
        public JsString urlSuffix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the scheme of the URL is equal to any of the schemes specified in the array.
        /// </summary>
        public JsArray<JsString> schemes { get; set; }

        /// <summary>
        /// ( optional ) Matches if the port of the URL is contained in any of the specified port lists.
        /// For example [80, 443, [1000, 1200]] matches all requests on port 80, 443 and in the range 1000-1200.
        /// </summary>
        public JsArray<object> ports { get; set; }
    }

    public class AddRulesDetails : JsArray<Rule>
    {
    }
    //TODO: danel don't know what to do here

    #endregion

    #region extension

    [JsType(JsMode.Prototype, Name = "chrome.extension", Export = false)]
    public class extension
    {
        /// <summary>
        /// ( optional ) Set for the lifetime of a callback if an ansychronous extension api has resulted in an error.
        /// If no error has occured lastError will be undefined.
        /// </summary>
        public ExtensionLastError lastError { get; set; }

        /// <summary>
        /// ( optional ) True for content scripts running inside incognito tabs, and for extension pages running inside an incognito process.
        /// The latter only applies to extensions with 'split' incognito_behavior.
        /// </summary>
        public bool inIncognitoContext { get; set; }

        /// <summary>
        /// Attempts to connect to other listeners within the extension (such as the extension's background page).
        /// This is primarily useful for content scripts connecting to their extension processes.
        /// Extensions may connect to content scripts embedded in tabs via chrome.tabs.connect().
        /// </summary>
        /// <param name="extensionId"> ( optional ) The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
        /// <param name="connectInfo">( optional )</param>
        /// <returns>Port through which messages can be sent and received with the extension. The port's onDisconnect event is fired if extension does not exist.</returns>
        public static Port connect(JsString extensionId, ExtensionConnectInfo connectInfo) { return null; }
        /// <summary>
        /// Attempts to connect to other listeners within the extension (such as the extension's background page).
        /// This is primarily useful for content scripts connecting to their extension processes.
        /// Extensions may connect to content scripts embedded in tabs via chrome.tabs.connect().
        /// </summary>
        /// <param name="extensionId"> ( optional ) The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
        /// <returns>Port through which messages can be sent and received with the extension. The port's onDisconnect event is fired if extension does not exist.</returns>
        public static Port connect(JsString extensionId) { return null; }
        /// <summary>
        /// Attempts to connect to other listeners within the extension (such as the extension's background page).
        /// This is primarily useful for content scripts connecting to their extension processes.
        /// Extensions may connect to content scripts embedded in tabs via chrome.tabs.connect().
        /// </summary>
        /// <returns>Port through which messages can be sent and received with the extension. The port's onDisconnect event is fired if extension does not exist.</returns>
        public static Port connect() { return null; }

        /// <summary>
        /// Returns the JavaScript 'window' object for the background page running inside the current extension. Returns null if the extension has no background page.
        /// </summary>
        /// <returns></returns>
        public static Window getBackgroundPage() { return null; }

        /// <summary>
        /// Converts a relative path within an extension install directory to a fully-qualified URL.
        /// </summary>
        /// <param name="path">A path to a resource within an extension expressed relative to its install directory.</param>
        /// <returns>The fully-qualified URL to the resource.</returns>
        public static JsString getURL(JsString path) { return null; }

        /// <summary>
        /// Returns an array of the JavaScript 'window' objects for each of the pages running inside the current extension.
        /// </summary>
        /// <param name="fetchProperties"></param>
        /// <returns>Array of global objects</returns>
        public static JsArray<Window> getViews(ExtensionFetchProperties fetchProperties) { return null; }
        /// <summary>
        /// Returns an array of the JavaScript 'window' objects for each of the pages running inside the current extension.
        /// </summary>
        /// <returns>Array of global objects</returns>
        public static JsArray<Window> getViews() { return null; }

        /// <summary>
        /// Retrieves the state of the extension's access to the 'file://' scheme (as determined by the user-controlled 'Allow access to File URLs' checkbox.
        /// *This function was added in version 12.0.706.0.
        /// If you require this function, the manifest key minimum_chrome_version can ensure that your extension won't be run in an earlier browser version.*
        /// </summary>
        /// <param name="callback"></param>
        public static void isAllowedFileSchemeAccess(JsAction callback) { }

        /// <summary>
        /// Retrieves the state of the extension's access to Incognito-mode (as determined by the user-controlled 'Allowed in Incognito' checkbox.
        /// *This function was added in version 12.0.706.0.
        /// If you require this function, the manifest key minimum_chrome_version can ensure that your extension won't be run in an earlier browser version.*
        /// </summary>
        /// <param name="callback"></param>
        public static void isAllowedIncognitoAccess(JsAction callback) { }

        /// <summary>
        /// Sends a single message to other listeners within the extension. Similar to chrome.extension.connect, but only sends a single message with an optional response.
        /// The chrome.extension.onMessage event is fired in each page of the extension.
        /// </summary>
        /// <param name="extensionId">( optional ) The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
        /// <param name="message"></param>
        /// <param name="responseCallback">( optional ) The JSON response object sent by the handler of the message. If an error occurs while connecting to the extension,
        /// the callback will be called with no arguments and chrome.extension.lastError will be set to the error message.</param>
        public static void sendMessage(JsString extensionId, object message, JsAction<object> responseCallback) { }
        /// <summary>
        /// Sends a single message to other listeners within the extension. Similar to chrome.extension.connect, but only sends a single message with an optional response.
        /// The chrome.extension.onMessage event is fired in each page of the extension.
        /// </summary>
        /// <param name="extensionId">( optional ) The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
        /// <param name="message"></param>
        public static void sendMessage(JsString extensionId, object message) { }
        /// <summary>
        /// Sends a single message to other listeners within the extension. Similar to chrome.extension.connect, but only sends a single message with an optional response.
        /// The chrome.extension.onMessage event is fired in each page of the extension.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="responseCallback">( optional ) The JSON response object sent by the handler of the message. If an error occurs while connecting to the extension,
        /// the callback will be called with no arguments and chrome.extension.lastError will be set to the error message.</param>
        public static void sendMessage(object message, JsAction<object> responseCallback) { }
        /// <summary>
        /// Sends a single message to other listeners within the extension. Similar to chrome.extension.connect, but only sends a single message with an optional response.
        /// The chrome.extension.onMessage event is fired in each page of the extension.
        /// </summary>
        /// <param name="message"></param>
        public static void sendMessage(object message) { }

        /// <summary>
        /// Sets the value of the ap CGI parameter used in the extension's update URL.
        /// This value is ignored for extensions that are hosted in the Chrome Extension Gallery.
        /// </summary>
        /// <param name="data"></param>
        public static void setUpdateUrlData(JsString data) { }

        /// <summary>
        /// Fired when a connection is made from either an extension process or a content script.
        /// </summary>
        public static Event<JsAction<Port>> onConnect { get; set; }

        /// <summary>
        /// Fired when a connection is made from another extension.
        /// </summary>
        public static Event<JsAction<Port>> onConnectExternal { get; set; }

        /// <summary>
        /// Fired when a message is sent from either an extension process or a content script.
        /// </summary>
        public static Event<JsFunc<ExtensionOnMessageDetails, bool>> onMessage { get; set; }

        /// <summary>
        /// Fired when a message is sent from another extension.
        /// </summary>
        public static Event<JsFunc<ExtensionOnMessageDetails, bool>> onMessageExternal { get; set; }

    }

    [JsType(JsMode.Json)]
    public class ExtensionLastError
    {
        /// <summary>
        /// Description of the error that has taken place.
        /// </summary>
        public JsString message { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ExtensionConnectInfo
    {
        /// <summary>
        /// ( optional ) Will be passed into onConnect for extension processes that are listening for the connection event.
        /// </summary>
        public JsString name { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ExtensionFetchProperties
    {
        /// <summary>
        /// type ( optional enumerated string ["tab", "infobar", "notification", "popup"] )
        /// The type of view to get. If omitted, returns all views (including background pages and tabs). Valid values: 'tab', 'infobar', 'notification', 'popup'.
        /// </summary>
        public FetchPropertiesType type { get; set; }

        /// <summary>
        /// The window to restrict the search to. If omitted, returns all views.
        /// </summary>
        public JsNumber windowId { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum FetchPropertiesType
    {
        tab,
        infobar,
        notification,
        popup,
    }

    [JsType(JsMode.Json)]
    public class ExtensionOnMessageDetails
    {
        /// <summary>
        /// The message sent by the calling script.
        /// </summary>
        public object message { get; set; }

        public MessageSender sender { get; set; }

        /// <summary>
        /// Function to call (at most once) when you have a response. The argument should be any JSON-ifiable object.
        /// If you have more than one onMessage listener in the same document, then only one may send a response.
        /// This function becomes invalid when the event listener returns, unless you return true from the event listener to indicate you wish to send a response asynchronously
        /// (this will keep the message channel open to the other end until sendResponse is called).
        /// </summary>
        public JsAction sendResponse { get; set; }

    }

    /// <summary>
    /// An object containing information about the script context that sent a message or request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.extension.MessageSender", Export = false)]
    public class MessageSender
    {
        /// <summary>
        /// ( optional tabs.Tab ) This property will only be present when the connection was opened from a tab or content script.
        /// </summary>
        public Tab tab { get; set; }

        /// <summary>
        /// The extension ID of the extension that opened the connection.
        /// </summary>
        public JsString id { get; set; }
    }

    /// <summary>
    /// An object which allows two way communication with other pages.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.extension.Port", Export = false)]
    public class Port
    {

        public JsString name { get; set; }

        public object onDisconnect { get; set; }
        //TODO: type is ( events.Event ) (needs to create this class)

        public object onMessage { get; set; }
        //TODO: type is ( events.Event ) (needs to create this class)

        public JsAction postMessage { get; set; }

        public MessageSender sender { get; set; }
    }
    #endregion

    #region fileBrowserHandler


    /// <summary>
    /// Use the chrome.fileBrowserHandler module to extend the Chrome OS file browser.
    /// For example, you can use this API to enable users to upload files to your website.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.fileBrowserHandler", Export = false)]
    public class fileBrowserHandler
    {

        /// <summary>
        /// Prompts user to select file path under which a new file will be created.
        /// When the user selects file, the file gets created or, if it already existed, truncated. The function has to be called with a user gesture.
        /// </summary>
        /// <param name="selectionParams">Parameters that will be used to create a new file.</param>
        /// <param name="callback">Function called upon completion.</param>
        public static void selectFile(SelectionParams selectionParams, JsAction callback) { }

        /// <summary>
        /// Fired when file system action is executed from ChromeOS file browser.
        /// </summary>
        public static Event<JsAction<JsString, FileHandlerExecuteEventDetails>> onExecute { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SelectionParams
    {
        /// <summary>
        /// Suggested name for the new file.
        /// </summary>
        public JsString suggestedName { get; set; }
    }

    /// <summary>
    /// Event details payload for fileBrowserHandler.onExecute event.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.fileBrowserHandler.FileHandlerExecuteEventDetails", Export = false)]
    public class FileHandlerExecuteEventDetails
    {
        /// <summary>
        /// Array of Entry instances representing files that are targets of this action (selected in ChromeOS file browser).
        /// </summary>
        public JsArray<object> entries { get; set; }

        /// <summary>
        /// ( optional ) The ID of the tab that raised this event. Tab IDs are unique within a browser session.
        /// </summary>
        public JsNumber tab_id { get; set; }
    }

    #endregion

    #region history

    /// <summary>
    /// Use the chrome.history module to interact with the browser's record of visited pages.
    /// You can add, remove, and query for URLs in the browser's history. To override the history page with your own version, see Override Pages.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.history", Export = false)]
    public class history
    {
        /// <summary>
        /// Adds a URL to the history at the current time with a transition type of "link".
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void addUrl(HistoryAddUrlDetails details, JsAction callback) { }
        /// <summary>
        /// Adds a URL to the history at the current time with a transition type of "link".
        /// </summary>
        /// <param name="details"></param>
        public static void addUrl(HistoryAddUrlDetails details) { }

        /// <summary>
        /// Deletes all items from the history.
        /// </summary>
        /// <param name="callback"></param>
        public static void deleteAll(JsAction callback) { }

        /// <summary>
        /// Removes all items within the specified date range from the history. Pages will not be removed from the history unless all visits fall within the range.
        /// </summary>
        /// <param name="range"></param>
        /// <param name="callback"></param>
        public static void deleteRange(HistoryDeleteRange range, JsAction callback) { }

        /// <summary>
        /// Removes all occurrences of the given URL from the history.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void deleteUrl(HistoryDeleteUrlDetails details, JsAction callback) { }
        /// <summary>
        /// Removes all occurrences of the given URL from the history.
        /// </summary>
        /// <param name="details"></param>
        public static void deleteUrl(HistoryDeleteUrlDetails details) { }

        /// <summary>
        /// Retrieves information about visits to a URL.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getVisits(HistoryGetVisitsDetails details, JsAction callback) { }

        /// <summary>
        /// Searches the history for the last visit time of each page matching the query.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="callback"></param>
        public static void search(HistorySearchQuery query, JsAction callback) { }

        /// <summary>
        /// Fired when one or more URLs are removed from the history service. When all visits have been removed the URL is purged from history.
        /// </summary>
        public static Event<JsAction<HistoryOnVisitRemoved>> onVisitRemoved { get; set; }

        /// <summary>
        /// Fired when a URL is visited, providing the HistoryItem data for that URL. This event fires before the page has loaded.
        /// </summary>
        public static Event<JsAction<HistoryItem>> onVisited { get; set; }

    }

    [JsType(JsMode.Json)]
    public class HistoryAddUrlDetails
    {
        /// <summary>
        /// The URL to add.
        /// </summary>
        public JsString url { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HistoryDeleteRange
    {
        /// <summary>
        /// Items added to history after this date, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber startTime { get; set; }
        /// <summary>
        /// Items added to history before this date, represented in milliseconds since the epoch
        /// </summary>
        public JsNumber endTime { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HistoryDeleteUrlDetails
    {
        /// <summary>
        /// The URL to remove.
        /// </summary>
        public JsString url { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HistoryGetVisitsDetails
    {
        /// <summary>
        /// The URL for which to retrieve visit information. It must be in the format as returned from a call to history.search.
        /// </summary>
        public JsString url { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HistorySearchQuery
    {
        /// <summary>
        /// A free-text query to the history service. Leave empty to retrieve all pages.
        /// </summary>
        public JsString text { get; set; }

        /// <summary>
        /// ( optional ) Limit results to those visited after this date, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber startTime { get; set; }

        /// <summary>
        /// ( optional )Limit results to those visited before this date, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber endTime { get; set; }

        /// <summary>
        /// ( optional )The maximum number of results to retrieve. Defaults to 100.
        /// </summary>
        public JsNumber maxResults { get; set; }

    }

    [JsType(JsMode.Json)]
    public class HistoryOnVisitRemoved
    {
        /// <summary>
        /// True if all history was removed. If true, then urls will be empty.
        /// </summary>
        public bool allHistory { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsArray<JsString> urls { get; set; }
    }

    /// <summary>
    /// An object encapsulating one result of a history query.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.history.HistoryItem", Export = false)]
    public class HistoryItem
    {
        /// <summary>
        /// The unique identifier for the item.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional ) The URL navigated to by a user.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) The title of the page when it was last loaded.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional ) When this page was last loaded, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber lastVisitTime { get; set; }

        /// <summary>
        /// ( optional ) The number of times the user has navigated to this page.
        /// </summary>
        public JsNumber visitCount { get; set; }

        /// <summary>
        /// ( optional ) The number of times the user has navigated to this page by typing in the address.
        /// </summary>
        public JsNumber typedCount { get; set; }
    }

    /// <summary>
    /// An object encapsulating one visit to a URL.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.history.VisitItem", Export = false)]
    public class VisitItem
    {
        /// <summary>
        /// The unique identifier for the item.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// The unique identifier for this visit.
        /// </summary>
        public JsString visitId { get; set; }

        /// <summary>
        /// ( optional ) When this visit occurred, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber visitTime { get; set; }

        /// <summary>
        /// The visit ID of the referrer.
        /// </summary>
        public JsString referringVisitId { get; set; }

        /// <summary>
        /// ( enumerated string ["link", "typed", "auto_bookmark", "auto_subframe", "manual_subframe", "generated", "start_page", "form_submit", "reload", "keyword", "keyword_generated"] )
        /// The transition type for this visit from its referrer.
        /// </summary>
        public TransitionType transition { get; set; }
    }

    /// <summary>
    /// The history API uses a transition type to describe how the browser navigated to a particular URL on a particular visit.
    /// For example, if a user visits a page by clicking a link on another page, the transition type is "link".
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum TransitionType
    {
        /// <summary>
        /// The user got to this page by clicking a link on another page.
        /// </summary>
        link,
        /// <summary>
        /// The user got this page by typing the URL in the address bar. Also used for other explicit navigation actions.
        /// See also generated, which is used for cases where the user selected a choice that didn't look at all like a URL.
        /// </summary>
        typed,
        /// <summary>
        /// The user got to this page through a suggestion in the UI — for example, through a menu item.
        /// </summary>
        auto_bookmark,
        /// <summary>
        /// Subframe navigation. This is any content that is automatically loaded in a non-top-level frame.
        /// For example, if a page consists of several frames containing ads, those ad URLs have this transition type.
        /// The user may not even realize the content in these pages is a separate frame, and so may not care about the URL (see also manual_subframe).
        /// </summary>
        auto_subframe,
        /// <summary>
        /// For subframe navigations that are explicitly requested by the user and generate new navigation entries in the back/forward list.
        /// An explicitly requested frame is probably more important than an automatically loaded frame because the user probably cares about 
        /// he fact that the requested frame was loaded.
        /// </summary>
        manual_subframe,
        /// <summary>
        /// The user got to this page by typing in the address bar and selecting an entry that did not look like a URL.
        /// For example, a match might have the URL of a Google search result page, but it might appear to the user as "Search Google for ...".
        /// These are not quite the same as typed navigations because the user didn't type or see the destination URL. See also keyword.
        /// </summary>
        generated,
        /// <summary>
        /// The page was specified in the command line or is the start page.
        /// </summary>
        start_page,
        /// <summary>
        /// The user filled out values in a form and submitted it.
        /// Note that in some situations — such as when a form uses script to submit contents — submitting a form does not result in this transition type.
        /// </summary>
        form_submit,
        /// <summary>
        /// The user reloaded the page, either by clicking the reload button or by pressing Enter in the address bar.
        /// Session restore and Reopen closed tab use this transition type, too.
        /// </summary>
        reload,
        /// <summary>
        /// The URL was generated from a replaceable keyword other than the default search provider. See also keyword_generated.
        /// </summary>
        keyword,
        /// <summary>
        /// Corresponds to a visit generated for a keyword. See also keyword.
        /// </summary>
        keyword_generated,
    }

    #endregion

    #region i18n

    /// <summary>
    /// An internationalized extension can be easily localized — adapted to languages and regions that it didn't originally support.
    /// To internationalize your extension, you need to put all of its user-visible strings into a file named messages.json.
    /// Each time you localize your extension you add a messages file under a directory named _locales/localeCode, where localeCode is a code such as en for English.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.i18n", Export = false)]
    public class i18n
    {
        /// <summary>
        /// Gets the accept-languages of the browser. This is different from the locale used by the browser; to get the locale, use window.navigator.language.
        /// </summary>
        /// <param name="callback"></param>
        public static void getAcceptLanguages(JsAction callback) { }

        /// <summary>
        /// Gets the localized string for the specified message.
        /// If the message is missing, this method returns an empty string (''). If the format of the getMessage() call is wrong — for example, essageName is not a string or the substitutions array has more than 9 elements — this method returns undefined.
        /// </summary>
        /// <param name="messageName">The name of the message, as specified in the messages.json file.</param>
        /// <param name="substitutions">( optional ) Up to 9 substitution strings, if the message requires any.</param>
        /// <returns>Message localized for current locale</returns>
        public static JsString getMessage(JsString messageName, object substitutions) { return null; }
        /// <summary>
        /// Gets the localized string for the specified message.
        /// If the message is missing, this method returns an empty string (''). If the format of the getMessage() call is wrong — for example, essageName is not a string or the substitutions array has more than 9 elements — this method returns undefined.
        /// </summary>
        /// <param name="messageName">The name of the message, as specified in the messages.json file.</param>
        /// <returns>Message localized for current locale</returns>
        public static JsString getMessage(JsString messageName) { return null; }
    }
    #endregion

    #region idle

    /// <summary>
    /// You must declare the "idle" permission in your extension's manifest to use the idle API.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.idle", Export = false)]
    public class idle
    {
        /// <summary>
        /// Returns the current state of the browser.
        /// </summary>
        /// <param name="thresholdSeconds">Threshold, in seconds, used to determine when a machine is in the idle state.</param>
        /// <param name="callback"></param>
        public static void queryState(JsNumber thresholdSeconds, JsAction callback) { }

        /// <summary>
        /// Fired when the browser changes to an active state. Currently only reports the transition from idle to active.
        /// </summary>
        public static Event<JsAction<IdleStateType>> onStateChanged { get; set; }
        //TODO: check

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum IdleStateType
    {
        active,
    }
    //TODO: can eunm have only one option?

    #endregion

    #region input.ime

    [JsType(JsMode.Prototype, Name = "chrome.input.ime", Export = false)]
    public class InputIme
    {
        /// <summary>
        /// Clear the current composition. If this extension does not own the active IME, this fails.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.extension.lastError is set.</param>
        public static void clearComposition(InputImeClearCompositionParameter parameters, JsAction callback) { }
        /// <summary>
        /// Clear the current composition. If this extension does not own the active IME, this fails.
        /// </summary>
        /// <param name="parameters"></param>
        public static void clearComposition(InputImeClearCompositionParameter parameters) { }

        /// <summary>
        /// Commits the provided text to the current input.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.extension.lastError is set.</param>
        public static void commitText(InputImeCommitTextParameter parameters, JsAction callback) { }
        /// <summary>
        /// Commits the provided text to the current input.
        /// </summary>
        /// <param name="parameters"></param>
        public static void commitText(InputImeCommitTextParameter parameters) { }

        /// <summary>
        /// Sets the properties of the candidate window. This fails if the extension doesn’t own the active IME
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes.</param>
        public static void setCandidateWindowProperties(InputImeCandidateWindowParameter parameters, JsAction callback) { }
        /// <summary>
        /// Sets the properties of the candidate window. This fails if the extension doesn’t own the active IME
        /// </summary>
        /// <param name="parameters"></param>
        public static void setCandidateWindowProperties(InputImeCandidateWindowParameter parameters) { }

        /// <summary>
        /// Sets the current candidate list. This fails if this extension doesn’t own the active IME
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes.</param>
        public static void setCandidates(InputImeCandidatesParameter parameters, JsAction callback) { }
        /// <summary>
        /// Sets the current candidate list. This fails if this extension doesn’t own the active IME
        /// </summary>
        /// <param name="parameters"></param>
        public static void setCandidates(InputImeCandidatesParameter parameters) { }

        /// <summary>
        /// Set the current composition. If this extension does not own the active IME, this fails.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.extension.lastError is set.</param>
        public static void setComposition(InputImeCompositionParameter parameters, JsAction callback) { }
        /// <summary>
        /// Set the current composition. If this extension does not own the active IME, this fails.
        /// </summary>
        /// <param name="parameters"></param>
        public static void setComposition(InputImeCompositionParameter parameters) { }

        /// <summary>
        /// Set the position of the cursor in the candidate window. This is a no-op if this extension does not own the active IME.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes</param>
        public static void setCursorPosition(InputImeCursorPositionParameter parameters, JsAction callback) { }
        /// <summary>
        /// Set the position of the cursor in the candidate window. This is a no-op if this extension does not own the active IME.
        /// </summary>
        /// <param name="parameters"></param>
        public static void setCursorPosition(InputImeCursorPositionParameter parameters) { }

        /// <summary>
        /// Adds the provided menu items to the language menu when this IME is active.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) </param>
        public static void setMenuItems(InputImeMenuItemsParameter parameters, JsAction callback) { }
        /// <summary>
        /// Adds the provided menu items to the language menu when this IME is active.
        /// </summary>
        /// <param name="parameters"></param>
        public static void setMenuItems(InputImeMenuItemsParameter parameters) { }

        /// <summary>
        /// Updates the state of the MenuItems specified
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes</param>
        public static void updateMenuItems(InputImeMenuItemsParameter parameters, JsAction callback) { }
        /// <summary>
        /// Updates the state of the MenuItems specified
        /// </summary>
        /// <param name="parameters"></param>
        public static void updateMenuItems(InputImeMenuItemsParameter parameters) { }

        /// <summary>
        /// This event is sent when an IME is activated. It signals that the IME will be receiving onKeyPress events.
        /// </summary>
        public static Event<JsAction<JsString>> onActivate { get; set; }

        /// <summary>
        /// This event is sent when focus leaves a text box. It is sent to all extensions that are listening to this event, and enabled by the user.
        /// </summary>
        public static Event<JsAction<JsNumber>> onBlur { get; set; }

        /// <summary>
        /// This event is sent if this extension owns the active IME.
        /// </summary>
        public static Event<JsAction<JsString, JsNumber, CandidateClickedButtonType>> onCandidateClicked { get; set; }

        /// <summary>
        /// This event is sent when an IME is deactivated. It signals that the IME will no longer be receiving onKeyPress events.
        /// </summary>
        public static Event<JsAction<JsString>> onDeactivated { get; set; }

        /// <summary>
        /// This event is sent when focus enters a text box. It is sent to all extensions that are listening to this event, and enabled by the user.
        /// </summary>
        public static Event<JsAction<InputContext>> onFocus { get; set; }

        /// <summary>
        /// This event is sent when the properties of the current InputContext change, such as the the type.
        /// It is sent to all extensions that are listening to this event, and enabled by the user.
        /// </summary>
        public static Event<JsAction<InputContext>> onInputContextUpdate { get; set; }

        /// <summary>
        /// This event is sent if this extension owns the active IME.
        /// </summary>
        public static Event<JsAction<JsString, KeyboardEvent>> onKeyEvent { get; set; }
        //TODO: returns boolean (???)

        /// <summary>
        /// Called when the user selects a menu item
        /// </summary>
        public static Event<JsAction<JsString, JsString>> onMenuItemActivated { get; set; }

    }
    //TODO: class name (???)

    [JsType(JsMode.Json)]
    public class InputImeClearCompositionParameter
    {
        /// <summary>
        /// ID of the context where the composition will be cleared
        /// </summary>
        public JsNumber contextID { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCommitTextParameter
    {
        /// <summary>
        /// ID of the context where the text will be committed
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// The text to commit
        /// </summary>
        public JsString text { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCandidateWindowParameter
    {
        /// <summary>
        /// ID of the engine to set properties on.
        /// </summary>
        public JsString engineID { get; set; }

        public InputImeCandidateWindowParameterProperties properties { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCandidateWindowParameterProperties
    {
        /// <summary>
        /// ( optional )True to show the Candidate window, false to hide it.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// ( optional ) True to show the cursor, false to hide it.
        /// </summary>
        public bool cursorVisible { get; set; }

        /// <summary>
        /// ( optional )True if the candidate window should be rendered vertical, false to make it horizontal.
        /// </summary>
        public bool vertical { get; set; }

        /// <summary>
        /// ( optional ) The number of candidates to display per page.
        /// </summary>
        public JsNumber pageSize { get; set; }

        /// <summary>
        /// ( optional )Text that is shown at the bottom of the candidate window.
        /// </summary>
        public JsString auxiliaryText { get; set; }

        /// <summary>
        /// ( optional )True to display the auxiliary text, false to hide it.
        /// </summary>
        public bool auxiliaryTextVisible { get; set; }

    }

    [JsType(JsMode.Json)]
    public class InputImeCandidatesParameter
    {
        /// <summary>
        /// ID of the context that owns the candidate window.
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// List of candidates to show in the candidate window
        /// </summary>
        public JsArray<InputImeCandidatesParameterCandidates> candidates { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCandidatesParameterCandidates
    {
        /// <summary>
        /// The candidate
        /// </summary>
        public JsString candidate { get; set; }

        /// <summary>
        /// The candidate's id
        /// </summary>
        public JsNumber id { get; set; }

        /// <summary>
        /// ( optional ) The id to add these candidates under
        /// </summary>
        public JsNumber parentId { get; set; }

        /// <summary>
        /// ( optional ) Short string displayed to next to the candidate, often the shortcut key or index
        /// </summary>
        public JsString label { get; set; }

        /// <summary>
        /// ( optional ) Additional text describing the candidate
        /// </summary>
        public JsString annotation { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCompositionParameter
    {
        /// <summary>
        /// ID of the context where the composition text will be set
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// Text to set
        /// </summary>
        public JsString text { get; set; }

        /// <summary>
        ///  ( optional ) Position in the text that the selection starts at.
        /// </summary>
        public JsNumber selectionStart { get; set; }

        /// <summary>
        /// ( optional ) Position in the text that the selection ends at.
        /// </summary>
        public JsNumber selectionEnd { get; set; }

        /// <summary>
        /// Position in the text of the cursor.
        /// </summary>
        public JsNumber cursor { get; set; }

        /// <summary>
        /// List of segments and their associated types.
        /// </summary>
        public JsArray<InputImeCompositionParameterSegment> segments { get; set; }

    }

    /// <summary>
    /// List of segments and their associated types.
    /// </summary>
    [JsType(JsMode.Json)]
    public class InputImeCompositionParameterSegment
    {
        /// <summary>
        /// Index of the character to start this segment at
        /// </summary>
        public JsNumber start { get; set; }

        /// <summary>
        /// Index of the character to end this segment after.
        /// </summary>
        public JsNumber end { get; set; }

        /// <summary>
        /// ( enumerated string ["underline", "doubleUnderline"] ) How to render this segment
        /// </summary>
        public SegmentsStyle style { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCursorPositionParameter
    {
        /// <summary>
        /// ID of the context that owns the candidate window.
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// ID of the candidate to select.
        /// </summary>
        public JsNumber candidateID { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeMenuItemsParameter
    {
        /// <summary>
        /// ID of the engine to use
        /// </summary>
        public JsString engineID { get; set; }

        /// <summary>
        /// ID of the candidate to select.
        /// </summary>
        public JsArray<object> items { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeMenuItemsParameterItem
    {

        /// <summary>
        /// String that will be passed to callbacks referencing this MenuItem.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional ) Text displayed in the menu for this item.
        /// </summary>
        public JsString label { get; set; }

        /// <summary>
        /// ( optional enumerated string ["none", "check", "radio", "separator"] ) Enum representing if this item is: none, check, radio, or a separator.
        /// Radio buttons between separators are considered grouped.
        /// </summary>
        public MenuItemsStyle style { get; set; }

        /// <summary>
        /// ( optional ) Indicates this item is visible.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// ( optional ) Indicates this item should be drawn with a check.
        /// </summary>
        public bool @checked { get; set; }

        /// <summary>
        /// ( optional ) Indicates this item is enabled.
        /// </summary>
        public bool enabled { get; set; }
    }

    /// <summary>
    /// See http://www.w3.org/TR/DOM-Level-3-Events/#events-KeyboardEvent
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.input.ime", Export = false)]
    public class KeyboardEvent
    {
        /// <summary>
        /// One of keyup or keydown.
        /// </summary>
        public KeyboardEventType type { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        public JsString requestId { get; set; }

        /// <summary>
        /// Value of the key being pressed
        /// </summary>
        public JsString key { get; set; }

        /// <summary>
        /// ( optional )Whether or not the ALT key is pressed.
        /// </summary>
        public bool altKey { get; set; }

        /// <summary>
        /// ( optional )Whether or not the CTRL key is pressed.
        /// </summary>
        public bool ctrlKey { get; set; }

        /// <summary>
        /// ( optional )Whether or not the SHIFT key is pressed.
        /// </summary>
        public bool shiftKey { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum KeyboardEventType
    {
        keyup,
        keydown,
    }

    /// <summary>
    /// Describes an input Context
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.input.ime", Export = false)]
    public class InputContext
    {
        /// <summary>
        /// This is used to specify targets of text field operations. This ID becomes invalid as soon as onBlur is called.
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// Type of value this text field edits, (Text, Number, Password, etc)
        /// </summary>
        public InputContextType type { get; set; }
    }

    /// <summary>
    /// Type of value this text field edits, (Text, Number, Password, etc)
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum InputContextType
    {
        text,
        number,
        password,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum SegmentsStyle
    {
        underline,
        doubleUnderline,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum MenuItemsStyle
    {
        none,
        check,
        radio,
        separator,
    }


    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum CandidateClickedButtonType
    {
        left,
        middle,
        right,
    }

    #endregion

    #region management

    /// <summary>
    /// You must declare the "management" permission in the extension manifest to use the management API. 
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.management", Export = false)]
    public class management
    {
        /// <summary>
        /// Returns information about the installed extension or app that has the given ID.
        /// </summary>
        /// <param name="id">The ID from an item of $ref:ExtensionInfo.</param>
        /// <param name="callback">( optional )</param>
        public static void get(JsString id, JsAction callback) { }
        /// <summary>
        /// Returns information about the installed extension or app that has the given ID.
        /// </summary>
        /// <param name="id">The ID from an item of $ref:ExtensionInfo.</param>
        public static void get(JsString id) { }

        /// <summary>
        /// Returns a list of information about installed extensions and apps.
        /// </summary>
        /// <param name="callback">( optional ) </param>
        public static void getAll(JsAction callback) { }
        /// <summary>
        /// Returns a list of information about installed extensions and apps.
        /// </summary>
        public static void getAll() { }

        /// <summary>
        /// Returns a list of permission warnings for the given extension id.
        /// </summary>
        /// <param name="id">The ID of an already installed extension.</param>
        /// <param name="callback">( optional ) </param>
        public static void getPermissionWarningsById(JsString id, JsAction callback) { }
        /// <summary>
        /// Returns a list of permission warnings for the given extension id.
        /// </summary>
        /// <param name="id">The ID of an already installed extension.</param>
        public static void getPermissionWarningsById(JsString id) { }

        /// <summary>
        /// Returns a list of permission warnings for the given extension manifest string.
        /// Note: This function can be used without requesting the 'management' permission in the manifest.
        /// </summary>
        /// <param name="manifestStr">Extension manifest JSON string.</param>
        /// <param name="callback">( optional ) </param>
        public static void getPermissionWarningsByManifest(JsString manifestStr, JsAction callback) { }
        /// <summary>
        /// Returns a list of permission warnings for the given extension manifest string.
        /// Note: This function can be used without requesting the 'management' permission in the manifest.
        /// </summary>
        /// <param name="manifestStr">Extension manifest JSON string.</param>
        public static void getPermissionWarningsByManifest(JsString manifestStr) { }

        /// <summary>
        /// Launches an application.
        /// </summary>
        /// <param name="id">The extension id of the application.</param>
        /// <param name="callback">( optional ) </param>
        public static void launchApp(JsString id, JsAction callback) { }
        /// <summary>
        /// Launches an application.
        /// </summary>
        /// <param name="id">The extension id of the application.</param>
        public static void launchApp(JsString id) { }

        /// <summary>
        /// Enables or disables an app or extension.
        /// </summary>
        /// <param name="id">This should be the id from an item of $ref:ExtensionInfo.</param>
        /// <param name="enabled">Whether this item should be enabled or disabled.</param>
        /// <param name="callback">( optional ) </param>
        public static void setEnabled(JsString id, bool enabled, JsAction callback) { }
        /// <summary>
        /// Enables or disables an app or extension.
        /// </summary>
        /// <param name="id">This should be the id from an item of $ref:ExtensionInfo.</param>
        /// <param name="enabled">Whether this item should be enabled or disabled.</param>
        public static void setEnabled(JsString id, bool enabled) { }

        /// <summary>
        /// Uninstalls a currently installed app or extension.
        /// </summary>
        /// <param name="id">This should be the id from an item of $ref:ExtensionInfo.</param>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) </param>
        public static void uninstall(JsString id, ManagementUninstallOptions options, JsAction callback) { }
        /// <summary>
        /// Uninstalls a currently installed app or extension.
        /// </summary>
        /// <param name="id">This should be the id from an item of $ref:ExtensionInfo.</param>
        /// <param name="options"></param>
        public static void uninstall(JsString id, ManagementUninstallOptions options) { }

        /// <summary>
        /// Fired when an app or extension has been disabled
        /// </summary>
        public static Event<JsAction<ExtensionInfo>> onDisabled { get; set; }

        /// <summary>
        /// Fired when an app or extension has been enabled.
        /// </summary>
        public static Event<JsAction<ExtensionInfo>> onEnabled { get; set; }

        /// <summary>
        /// Fired when an app or extension has been installed.
        /// </summary>
        public static Event<JsAction<ExtensionInfo>> onInstalled { get; set; }

        /// <summary>
        /// Fired when an app or extension has been uninstalled.
        /// </summary>
        public static Event<JsAction<JsString>> onUninstalled { get; set; }

    }

    /// <summary>
    /// Information about an icon belonging to an extension or app.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.management.IconInfo", Export = false)]
    public class IconInfo
    {
        /// <summary>
        /// A number representing the width and height of the icon. Likely values include (but are not limited to) 128, 48, 24, and 16.
        /// </summary>
        public JsNumber size { get; set; }

        /// <summary>
        /// The URL for this icon image. To display a grayscale version of the icon (to indicate that an extension is disabled, for example), append ?grayscale=true to the URL.
        /// </summary>
        public JsString url { get; set; }
    }

    /// <summary>
    /// Information about an installed extension or app.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.management.ExtensionInfo", Export = false)]
    public class ExtensionInfo
    {
        /// <summary>
        /// The extension's unique identifier.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// The name of this extension or app.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// The description of this extension or app.
        /// </summary>
        public JsString description { get; set; }

        /// <summary>
        /// The version of this extension or app.
        /// </summary>
        public JsString version { get; set; }

        /// <summary>
        /// Whether this extension can be disabled or uninstalled by the user.
        /// </summary>
        public bool mayDisable { get; set; }

        /// <summary>
        /// Whether it is currently enabled or disabled.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// ( optional enumerated string ["unknown", "permissions_increase"] ) A reason the item is disabled.
        /// </summary>
        public object disabledReason { get; set; }

        /// <summary>
        /// True if this is an app.
        /// </summary>
        public bool isApp { get; set; }

        /// <summary>
        /// ( optional ) The launch url (only present for apps).
        /// </summary>
        public JsString appLaunchUrl { get; set; }

        /// <summary>
        /// ( optional ) The URL of the homepage of this extension or app.
        /// </summary>
        public JsString homepageUrl { get; set; }

        /// <summary>
        ///  ( optional string ) The update URL of this extension or app.
        /// </summary>
        public JsString updateUrl { get; set; }

        /// <summary>
        /// Whether the extension or app declares that it supports offline.
        /// </summary>
        public bool offlineEnabled { get; set; }

        /// <summary>
        /// The url for the item's options page, if it has one.
        /// </summary>
        public JsString optionsUrl { get; set; }

        /// <summary>
        /// ( optional )  A list of icon information. Note that this just reflects what was declared in the manifest, and the actual image at that url may be larger or smaller than
        /// what was declared, so you might consider using explicit width and height attributes on img tags referencing these images. See the manifest documentation on icons for more details.
        /// </summary>
        public JsArray<IconInfo> icons { get; set; }

        /// <summary>
        /// Returns a list of API based permissions.
        /// </summary>
        public JsArray<JsString> permissions { get; set; }

        /// <summary>
        /// Returns a list of host based permissions.
        /// </summary>
        public JsArray<JsString> hostPermissions { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ManagementUninstallOptions
    {
        /// <summary>
        /// Whether or not a confirm-uninstall dialog should prompt the user. Defaults to false.
        /// </summary>
        public bool showConfirmDialog { get; set; }
    }

    #endregion

    #region omnibox

    /// <summary>
    /// The omnibox API allows you to register a keyword with Google Chrome's address bar, which is also known as the omnibox.
    /// Note: Chrome automatically creates a grayscale version of your 16x16-pixel icon. You should provide a full-color version so that it can also be used in other situations that require color.
    /// For example, the context menus API also uses a 16x16-pixel icon, but it is displayed in color.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.omnibox", Export = false)]
    public class omnibox
    {
        /// <summary>
        /// Sets the description and styling for the default suggestion. The default suggestion is the text that is displayed in the first suggestion row underneath the URL bar.
        /// </summary>
        /// <param name="suggestion">A partial SuggestResult object, without the 'content' parameter. See SuggestResult for a description of the parameters.</param>
        public static void setDefaultSuggestion(OmniboxDefaultSuggestion suggestion) { }

        /// <summary>
        /// User has ended the keyword input session without accepting the input.
        /// </summary>
        public static Event<JsAction> onInputCancelled { get; set; }

        /// <summary>
        /// User has changed what is typed into the omnibox.
        /// </summary>
        public static Event<JsAction<JsString, JsAction<JsArray<SuggestResult>>>> onInputChanged { get; set; }

        /// <summary>
        /// User has accepted what is typed into the omnibox.
        /// </summary>
        public static Event<JsAction<JsString>> onInputEntered { get; set; }

        /// <summary>
        /// User has started a keyword input session by typing the extension's keyword.
        /// This is guaranteed to be sent exactly once per input session, and before any onInputChanged events.
        /// </summary>
        public static Event<JsAction> onInputStarted { get; set; }

    }

    /// <summary>
    /// A partial SuggestResult object, without the 'content' parameter. See SuggestResult for a description of the parameters.
    /// </summary>
    [JsType(JsMode.Json)]
    public class OmniboxDefaultSuggestion
    {
        /// <summary>
        /// The text to display in the default suggestion. The placeholder string '%s' can be included and will be replaced with the user's input.
        /// </summary>
        public JsString description { get; set; }
    }

    /// <summary>
    /// A suggest result.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.omnibox.SuggestResult", Export = false)]
    public class SuggestResult
    {
        /// <summary>
        /// The text that is put into the URL bar, and that is sent to the extension when the user chooses this entry.
        /// </summary>
        public JsString content { get; set; }

        /// <summary>
        /// The text that is displayed in the URL dropdown. Can contain XML-style markup for styling. The supported tags are 'url' (for a literal URL),
        /// 'match' (for highlighting text that matched what the user's query), and 'dim' (for dim helper text). The styles can be nested, eg. dimmed match
        /// </summary>
        public JsString description { get; set; }
    }

    #endregion

    #region pageAction

    /// <summary>
    /// Use page actions to put icons inside the address bar. Page actions represent actions that can be taken on the current page, but that aren't applicable to all pages. Some examples:
    /// Subscribe to this page's RSS feed
    /// Make a slideshow out of this page's photos
    /// The RSS icon in the following screenshot represents a page action that lets you subscribe to the RSS feed for the current page.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.pageAction", Export = false)]
    public class pageAction
    {
        /// <summary>
        /// Gets the html document set as the popup for this browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getPopup(PageActionPopupDetails details, JsAction callback) { }

        /// <summary>
        /// Gets the title of the browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getTitle(PageActionTitleDetails details, JsAction callback) { }

        /// <summary>
        /// Hides the page action.
        /// </summary>
        /// <param name="tabId">The id of the tab for which you want to modify the page action.</param>
        public static void hide(JsNumber tabId) { }

        /// <summary>
        /// Sets the icon for the page action. The icon can be specified either as the path to an image file
        /// or as the pixel data from a canvas element. Either the path or the imageData property must be specified.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback">( optional )</param>
        public static void setIcon(PageActionIconDetails details, JsAction callback) { }
        /// <summary>
        /// Sets the icon for the page action. The icon can be specified either as the path to an image file
        /// or as the pixel data from a canvas element. Either the path or the imageData property must be specified.
        /// </summary>
        /// <param name="details"></param>
        public static void setIcon(PageActionIconDetails details) { }

        /// <summary>
        /// Sets the html document to be opened as a popup when the user clicks on the page action's icon.
        /// </summary>
        /// <param name="details"></param>
        public static void setPopup(PageActionPopupDetails details) { }

        /// <summary>
        /// Sets the title of the page action. This is displayed in a tooltip over the page action.
        /// </summary>
        /// <param name="details"></param>
        public static void setTitle(PageActionTitleDetails details) { }

        /// <summary>
        /// Shows the page action. The page action is shown whenever the tab is selected.
        /// </summary>
        /// <param name="tabId">The id of the tab for which you want to modify the page action.</param>
        public static void show(JsNumber tabId) { }

        /// <summary>
        /// Fired when a page action icon is clicked. This event will not fire if the page action has a popup.
        /// </summary>
        public static Event<JsAction<Tab>> onClicked { get; set; }

    }

    [JsType(JsMode.Json)]
    public class PageActionPopupDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// The html file to show in a popup. If set to the empty string (''), no popup is shown.
        /// </summary>
        public JsString popup { get; set; }

        /// <summary>
        /// for get operation: Specify the tab to get the popup from.
        /// for set operation:The id of the tab for which you want to modify the page action.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PageActionTitleDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// The tooltip string.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// for get operation: Specify the tab to get the title from.
        /// for set operation:The id of the tab for which you want to modify the page action.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PageActionIconDetails
    {
        /// <summary>
        /// The id of the tab for which you want to modify the page action.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( optional ) Pixel data for an image. Must be an ImageData object (for example, from a canvas element).
        /// </summary>
        public ImageData imageData { get; set; }

        /// <summary>
        /// ( optional ) Relative path to an image in the extension to show in the browser action.
        /// </summary>
        public JsNumber path { get; set; }

        /// <summary>
        /// ( optional ) Deprecated. The zero-based index into the icons vector specified in the manifest.
        /// </summary>
        public JsNumber iconIndex { get; set; }

    }

    #endregion

    #region pageCapture

    /// <summary>
    /// The pageCapture API allows you to save a tab as MHTML.
    /// MHTML is a standard format supported by most browsers. It encapsulates in a single file a page and all its resources (CSS files, images..).
    /// Note that for security reasons a MHTML file can only be loaded from the file system and that it can only be loaded in the main frame.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.pageCapture ", Export = false)]
    public class pageCapture
    {
        /// <summary>
        /// Saves the content of the tab with given id as MHTML.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback">Called when the MHTML has been generated.</param>
        public static void saveAsMHTML(PageCaptureDetails details, JsAction callback) { }
    }

    [JsType(JsMode.Json)]
    public class PageCaptureDetails
    {
        /// <summary>
        /// The id of the tab to save as MHTML.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    #endregion

    #region permissions
    
    /// <summary>
    /// Use the chrome.permissions module to implement optional permissions.
    /// You can request optional permissions during your extension's regular application flow rather than at install time,
    /// so users understand why the permissions are needed and use only those that are necessary.
    /// For general information about permissions and details about each permission, see the permissions section of the manifest documentation.
    /// 
    /// You can specify any of the following as optional permissions:
    /// host permissions
    /// appNotifications
    /// background
    /// bookmarks
    /// clipboardRead
    /// clipboardWrite
    /// contentSettings
    /// contextMenusk
    /// cookies
    /// debugger
    /// histokry
    /// idle
    /// management
    /// notifications
    /// pageCapture
    /// tabs
    /// topSites
    /// webNavigation
    /// webRequest
    /// webRequestBlocking
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.permissions ", Export = false)]
    public class permissions
    {
        /// <summary>
        /// Checks if the extension has the specified permissions.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="callback"></param>
        public static void contains(Permissions permissions, JsAction callback) { }

        /// <summary>
        /// Gets the extension's current set of permissions.
        /// </summary>
        /// <param name="callback"></param>
        public static void getAll(JsAction callback) { }

        /// <summary>
        /// Removes access to the specified permissions. If there are any problems removing the permissions, chrome.extension.lastError will be set.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="callback"></param>
        public static void remove(Permissions permissions, JsAction callback) { }
        /// <summary>
        /// Removes access to the specified permissions. If there are any problems removing the permissions, chrome.extension.lastError will be set.
        /// </summary>
        /// <param name="permissions"></param>
        public static void remove(Permissions permissions) { }

        /// <summary>
        /// Requests access to the specified permissions. These permissions must be defined in the optional_permissions field of the manifest.
        /// If there are any problems requesting the permissions, chrome.extension.lastError will be set.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="callback"></param>
        public static void request(Permissions permissions, JsAction callback) { }
        /// <summary>
        /// Requests access to the specified permissions. These permissions must be defined in the optional_permissions field of the manifest.
        /// If there are any problems requesting the permissions, chrome.extension.lastError will be set.
        /// </summary>
        /// <param name="permissions"></param>
        public static void request(Permissions permissions) { }

        /// <summary>
        /// Fired when the extension acquires new permissions.
        /// </summary>
        public static Event<JsAction< Permissions>> onAdded { get; set; }

        /// <summary>
        /// Fired when access to permissions has been removed from the extension.
        /// </summary>
        public static Event<JsAction<Permissions>> onRemoved { get; set; }

    }

    [JsType(JsMode.Prototype, Name = "chrome.permissions.Permissions ", Export = false)]
    public class Permissions
    {

        /// <summary>
        /// ( optional ) List of named permissions (does not include hosts or origins).
        /// </summary>
        public JsArray<JsString> permissions { get; set; }
    }

    #endregion

    #region privacy
    
    /// <summary>
    /// Use the chrome.privacy module to control usage of the features in Chrome that can affect a user's privacy.
    /// This module relies on the ChromeSetting prototype of the type API for getting and setting Chrome's configuration.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.privacy ", Export = false)]
    public class privacy
    {
        /// <summary>
        /// Settings that influence Chrome's handling of network connections in general.
        /// </summary>
        public PrivacyNetworkSetting network { get; set; }

        /// <summary>
        /// Settings that enable or disable features that require third-party network services provided by Google and your default search provider.
        /// </summary>
        public PrivacyServicesSetting services { get; set; }

        /// <summary>
        /// Settings that determine what information Chrome makes available to websites.
        /// </summary>
        public PrivacyWebsitesSetting websites { get; set; }
    }

    /// <summary>
    /// Settings that influence Chrome's handling of network connections in general.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PrivacyNetworkSetting
    {
        /// <summary>
        /// If enabled, Chrome attempts to speed up your web browsing experience by pre-resolving DNS entries, prerendering sites (&lt;link rel='prefetch' ...>),
        /// and preemptively opening TCP and SSL connections to servers. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting networkPredictionEnabled { get; set; }
    }

    /// <summary>
    /// Settings that enable or disable features that require third-party network services provided by Google and your default search provider.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PrivacyServicesSetting
    {
        /// <summary>
        /// If enabled, Chrome uses a web service to help resolve navigation errors. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting alternateErrorPagesEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome offers to automatically fill in forms. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting autofillEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome automatically performs and displays search requests for text you type into the Omnibox as you type it.
        /// This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting NameinstantEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome does its best to protect you from phishing and malware. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting safeBrowsingEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome sends the text you type into the Omnibox to your default search engine, which provides predictions of websites and searches that are likely completions of what you've typed so far.
        /// This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting searchSuggestEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome uses a web service to help correct spelling errors. This preference's value is a boolean, defaulting to false.
        /// </summary>
        public ChromeSetting spellingServiceEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome offers to translate pages that aren't in a language you read. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting translationServiceEnabled { get; set; }
    }

    /// <summary>
    /// Settings that determine what information Chrome makes available to websites.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PrivacyWebsitesSetting
    {
        /// <summary>
        /// If disabled, Chrome blocks third-party sites from setting cookies. The value of this preference is of type boolean, and the default value is true.
        /// </summary>
        public ChromeSetting thirdPartyCookiesAllowed { get; set; }

        /// <summary>
        /// If enabled, Chrome sends auditing pings when requested by a website (<a ping>). The value of this preference is of type boolean, and the default value is true.
        /// </summary>
        public ChromeSetting hyperlinkAuditingEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome sends referer headers with your requests. Yes, the name of this preference doesn't match the misspelled header.
        /// No, we're not going to change it. The value of this preference is of type boolean, and the default value is true.
        /// </summary>
        public ChromeSetting referrersEnabled { get; set; }

        /// <summary>
        /// Available on ChromeOS only: If enabled, Chrome provides a unique ID to plugins in order to run protected content.
        /// The value of this preference is of type boolean, and the default value is true.
        /// </summary>
        public ChromeSetting protectedContentEnabled { get; set; }
    }

    #endregion

    #region proxy
    
    /// <summary>
    /// Use the chrome.proxy module to manage Chrome's proxy settings.
    /// This module relies on the ChromeSetting prototype of the type API for getting and setting the proxy configuration.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy ", Export = false)]
    public class proxy
    {
        /// <summary>
        /// Proxy settings to be used. The value of this setting is a ProxyConfig object
        /// </summary>
        public ChromeSetting settings { get; set; }

        /// <summary>
        /// Notifies about proxy errors.
        /// </summary>
        public static Event<JsAction<ProxyErrorDetails>> onProxyError { get; set; }

    }

    [JsType(JsMode.Json)]
    public class ProxyErrorDetails 
    {
        /// <summary>
        /// If true, the error was fatal and the network transaction was aborted. Otherwise, a direct connection is used instead.
        /// </summary>
        public bool fatal  { get; set; }

        /// <summary>
        /// The error description.
        /// </summary>
        public JsString error { get; set; }

        /// <summary>
        /// Additional details about the error such as a JavaScript runtime error..
        /// </summary>
        public JsString details { get; set; }
    }

    /// <summary>
    /// An object encapsulating a single proxy server's specification.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy.ProxyServer ", Export = false)]
    public class ProxyServer
    {
        /// <summary>
        ///  ( optional enumerated string ["http", "https", "socks4", "socks5"] )
        ///  The scheme (protocol) of the proxy server itself. Defaults to 'http'.
        /// </summary>
        public ProxyServerSchemeType scheme  { get; set; }

        /// <summary>
        /// The URI of the proxy server. This must be an ASCII hostname (in Punycode format). IDNA is not supported, yet.
        /// </summary>
        public JsString host  { get; set; }

        /// <summary>
        /// ( optional ) The port of the proxy server. Defaults to a port that depends on the scheme.
        /// </summary>
        public JsNumber port  { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ProxyServerSchemeType 
    {
        http,
        https,
        socks4,
        socks5,
    }

    /// <summary>
    /// An object encapsulating the set of proxy rules for all protocols.
    /// Use either 'singleProxy' or (a subset of) 'proxyForHttp', 'proxyForHttps', 'proxyForFtp' and 'fallbackProxy'.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy.ProxyRules ", Export = false)]
    public class ProxyRules
    {
        /// <summary>
        ///  ( optional )The proxy server to be used for all per-URL requests (that is http, https, and ftp).
        /// </summary>
        public ProxyServer singleProxy { get; set; }

        /// <summary>
        ///  ( optional ) The proxy server to be used for HTTP requests.
        /// </summary>
        public ProxyServer proxyForHttp { get; set; }

        /// <summary>
        ///  ( optional ) The proxy server to be used for HTTPS requests.
        /// </summary>
        public ProxyServer proxyForHttps { get; set; }

        /// <summary>
        ///  ( optional )The proxy server to be used for FTP requests.
        /// </summary>
        public ProxyServer proxyForFtp { get; set; }

        /// <summary>
        ///  ( optional )The proxy server to be used for everthing else or if any of the specific proxyFor... is not specified.
        /// </summary>
        public ProxyServer fallbackProxy { get; set; }

        /// <summary>
        ///  ( optional ) List of servers to connect to without a proxy server.
        /// </summary>
        public JsArray<JsString> bypassList { get; set; }
    }

    /// <summary>
    /// An object holding proxy auto-config information. Exactly one of the fields should be non-empty.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy.PacScript ", Export = false)]
    public class PacScript
    {
        /// <summary>
        /// ( optional ) URL of the PAC file to be used.
        /// </summary>
        public JsString url  { get; set; }

        /// <summary>
        /// ( optional ) A PAC script.
        /// </summary>
        public JsString data { get; set; }

        /// <summary>
        /// ( optional ) If true, an invalid PAC script will prevent the network stack from falling back to direct connections. Defaults to false.
        /// </summary>
        public bool mandatory { get; set; }
    }

    /// <summary>
    /// An object encapsulating a complete proxy configuration.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy.ProxyConfig ", Export = false)]
    public class ProxyConfig
    {
        /// <summary>
        /// ( optional ) The proxy rules describing this configuration. Use this for 'fixed_servers' mode.
        /// </summary>
        public ProxyRules rules  { get; set; }

        /// <summary>
        /// ( optional ) The proxy auto-config (PAC) script for this configuration. Use this for 'pac_script' mode.
        /// </summary>
        public PacScript pacScript { get; set; }

        /// <summary>
        /// ( enumerated string ["direct", "auto_detect", "pac_script", "fixed_servers", "system"] )
        /// </summary>
        public ProxyConfigModeType mode { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ProxyConfigModeType
    {
        /// <summary>
        /// Never use a proxy
        /// </summary>
        direct,
        /// <summary>
        /// Auto detect proxy settings
        /// </summary>
        auto_detect,
        /// <summary>
        /// Use specified PAC script
        /// </summary>
        pac_script,
        /// <summary>
        /// Manually specify proxy servers
        /// </summary>
        fixed_servers,
        /// <summary>
        /// Use system proxy settings
        /// </summary>
        system,
    }

    #endregion

    [JsType(JsMode.Prototype, Name = "chrome.runtime ", Export = false)]
    public class runtime
    {
        /// <summary>
        /// Retrieves the JavaScript 'window' object for the background page running inside the current extension.
        /// If the background page is transient, the system will ensure it is loaded before calling the callback. If there is no background page, an error is set.
        /// </summary>
        /// <param name="callback"></param>
        public static void getBackgroundPage(JsAction callback) { }

        /// <summary>
        /// Sent to the transient background page just before it is unloaded. This gives the extension opportunity to do some clean up.
        /// Note that since the page is unloading, any asynchronous operations started while handling this event are not guaranteed to complete.
        /// </summary>
        public static Event<JsAction> onBackgroundPageUnloadingSoon { get; set; }

        /// <summary>
        /// Fired when the extension is first installed.
        /// </summary>
        public static Event<JsAction> onInstalled { get; set; }

    }

    [JsType(JsMode.Prototype, Name = "chrome.tabs.Tab ", Export = false)]
    public class Tab
    {
        //TODO: this class is empty. needs to be done

    }

    [JsType(JsMode.Prototype, Name = "chrome.types.ChromeSetting  ", Export = false)]
    public class ChromeSetting 
    {
        //TODO: this class is empty. needs to be done

    }
}

