using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Google.Chrome
{
    public class ChromeEvent<T>
    {
        public void addEventListener(T action) { }
    }

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
        public ChromeEvent<JsAction<Alarm>> onAlarm { get; set; }

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
        public ChromeEvent<JsAction<string, BookmarkChangeInfoDestination>> onChanged { get; set; }

        /// <summary>
        /// Fired when the children of a folder have changed their order due to the order being sorted in the UI. This is not called as a result of a move().
        /// </summary>
        public ChromeEvent<JsAction<string, BookmarkReorderInfoDestination>> onChildrenReordered { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is created.
        /// </summary>
        public ChromeEvent<JsAction<string, BookmarkTreeNode>> onCreated { get; set; }

        /// <summary>
        /// Fired when a bookmark import session is begun.
        /// Expensive observers should ignore handleCreated updates until onImportEnded is fired. Observers should still handle other notifications immediately.
        /// </summary>
        public ChromeEvent<JsAction> onImportBegan { get; set; }

        /// <summary>
        /// Fired when a bookmark import session is ended.
        /// </summary>
        public ChromeEvent<JsAction> onImportEnded { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is moved to a different parent folder.
        /// </summary>
        public ChromeEvent<JsAction<string, BookmarkMoveInfo>> onMoved { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is removed. When a folder is removed recursively, a single notification is fired for the folder, and none for its contents.
        /// </summary>
        public ChromeEvent<JsAction<string, BookmarkRemoveInfo>> onRemoved { get; set; }

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
        public ChromeEvent<JsAction<object>> onClicked { get; set; }
        //TODDO: (function(tabs.Tab tab)), needs to be chcnged later. (needs class tabs.Tab)

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
        public ChromeEvent<JsAction<OnClickData, object>> onClicked { get; set; }
        //TODDO: (function(tabs.Tab tab)), needs to be chcnged later. (needs class tabs.Tab)



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
        public JsAction<object, OnClickData> onclick { get; set; }
        //TODO: object = tab ( tabs.Tab ) (needs to create this class)

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
        public JsString url  { get; set; }

        /// <summary>
        /// The name of the cookie to retrieve.
        /// </summary>
        public JsString name  { get; set; }

        /// <summary>
        /// ( optional ) The ID of the cookie store in which to look for the cookie. By default, the current execution context's cookie store will be used.
        /// </summary>
        public JsString storeId  { get; set; }


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
    }

    [JsType(JsMode.Prototype, Name = "chrome.cookies.CookieStore", Export = false)]
    public class CookieStore
    {
    }


}

