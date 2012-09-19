
using SharpKit.JavaScript;

namespace TheMProject
{
    #region Components & Utilities

    /// <summary>
    /// M.Controller is the prototype of any controller within your application.
    /// It basically provides two very important methods you will use in most of your applications.
    /// The first one is responsible for switching pages, the second one is the key to the whole content binding feature and triggers rendering updates if content did change.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Controller", Export = false)]
    public class Controller
    {
        /// <summary>
        /// This method initializes the notification of all observers, that observe the property behind 'key'.
        /// So you will use this method out of a controller to inform the application that a property, respectively some content, did change.
        /// See Content Binding for more information about that.
        /// </summary>
        /// <param name="key">The key of the property to be changed.</param>
        /// <param name="value">The value to be set.</param>
        public void set(JsString key, object value) { }
        /// <summary>
        /// This method initializes the notification of all observers, that observe the property behind 'key'.
        /// So you will use this method out of a controller to inform the application that a property, respectively some content, did change.
        /// See Content Binding for more information about that.
        /// </summary>
        /// <param name="key">The key of the property to be changed.</param>
        /// <param name="value">The value to be set.</param>
        public void set(JsString key, JsString value) { }

        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        /// <param name="isBack">YES will cause a reverse-direction transition. Default: NO.</param>
        /// <param name="updateHistory">Update the browser history. Default: YES.</param>
        public void switchToPage(object page, JsString transition, bool isBack, bool updateHistory) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        /// <param name="isBack">YES will cause a reverse-direction transition. Default: NO.</param>
        /// <param name="updateHistory">Update the browser history. Default: YES.</param>
        public void switchToPage(JsString page, JsString transition, bool isBack, bool updateHistory) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        /// <param name="isBack">YES will cause a reverse-direction transition. Default: NO.</param>
        public void switchToPage(object page, JsString transition, bool isBack) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        /// <param name="isBack">YES will cause a reverse-direction transition. Default: NO.</param>
        public void switchToPage(JsString page, JsString transition, bool isBack) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        public void switchToPage(object page, JsString transition) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        public void switchToPage(JsString page, JsString transition) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        public void switchToPage(object page) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        public void switchToPage(JsString page) { }

        /// <summary>
        /// This method will perform a page switch to the passed tab. Internally this is used whenever a user taps/clicks on a tab.
        /// But you can also trigger such a switch programmatically out of your application if necessary.
        /// </summary>
        /// <param name="tab">The tab to be activated.</param>
        public void switchToTab(TabBarView tab) { }
    }

    /// <summary>
    /// Since JavaScript's date object doesn't provide lots of built-in functionality, we decided to create a wrapper for this, called M.Date.
    /// This utility object is equipped with many convenient and easy to use methods you will need whenever you are dealing with dates.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Date", Export = false)]
    public class Date
    {
        /// <summary>
        /// This method returns the current date, encapsulated in an M.Date object.
        /// </summary>
        /// <returns></returns>
        public Date now() { return null; }

        /// <summary>
        /// This method internally creates the current date, transfers it 24 hours into the future and returns this date, encapsulated in an M.Date object.
        /// </summary>
        /// <returns></returns>
        public Date tomorrow() { return null; }

        /// <summary>
        /// This method internally creates the current date, transfers it 24 hours into the past and returns this date, encapsulated in an M.Date object.
        /// </summary>
        /// <returns></returns>
        public Date yesterday() { return null; }

        /// <summary>
        /// This method returns a date for a given date string. It is based on JS Date's parse method. The following formats are accepted (time and timezone are optional):
        /// 11/12/2010
        /// 11/12/2010 15:28:15
        /// 11/12/2010 13:28:15 GMT
        /// 11/12/2010 15:28:15 GMT+0200
        /// 12 November 2010
        /// 12 November 2010 15:28:15
        /// 12 November 2010 13:28:15 GMT
        /// 12 November 2010 15:28:15 GMT+0200
        /// 12 Nov 2010
        /// 12 Nov 2010 15:28:15
        /// 12 Nov 2010 13:28:15 GMT
        /// 12 Nov 2010 15:28:15 GMT+0200
        /// If a wrong formatted date string is given, the method will return null. Otherwise an M.Date object will be returned.
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public Date create(JsString dateString) { return null; }

        /// <summary>
        /// This method formats a given date object according to the passed format property and returns it as a String. The following list defines the special characters that can be used in the format property to format the given date:
        /// d Day of the month as digits; no leading zero for single-digit days.
        /// dd Day of the month as digits; leading zero for single-digit days.
        /// ddd Day of the week as a three-letter abbreviation.
        /// dddd Day of the week as its full name.
        /// D Day of the week as number.
        /// m Month as digits; no leading zero for single-digit months.
        /// mm Month as digits; leading zero for single-digit months.
        /// mmm Month as a three-letter abbreviation.
        /// mmmm Month as its full name.
        /// yy Year as last two digits; leading zero for years less than 10.
        /// yyyy Year represented by four digits.
        /// h Hours; no leading zero for single-digit hours (12-hour clock).
        /// hh Hours; leading zero for single-digit hours (12-hour clock).
        /// HH ours; no leading zero for single-digit hours (24-hour clock).
        /// HH Hours; leading zero for single-digit hours (24-hour clock).
        ///  MMinutes; no leading zero for single-digit minutes.
        /// MM Minutes; leading zero for single-digit minutes.
        /// s Seconds; no leading zero for single-digit seconds.
        /// ss Seconds; leading zero for single-digit seconds.
        /// l or L Milliseconds. l gives 3 digits. L gives 2 digits.
        /// t Lowercase, single-character time marker string: a or p.
        /// tt Lowercase, two-character time marker string: am or pm.
        /// T Uppercase, single-character time marker string: A or P.
        /// TT Uppercase, two-character time marker string: AM or PM.
        /// Z US timezone abbreviation, e.g. EST or MDT. With non-US timezones or in the Opera browser, the GMT/UTC offset is returned, e.g. GMT-0500
        /// o GMT/UTC timezone offset, e.g. -0500 or +0230.
        /// S The date's ordinal suffix (st, nd, rd, or th). Works well with d.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public JsString format(JsString format) { return null; }

        /// <summary>
        /// This method returns the current date as a timestamp, e.g: 1308907720887
        /// </summary>
        /// <returns></returns>
        public JsNumber getTimestamp() { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on days.
        /// Basically it adds or subtracts x times the milliseconds of a day,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="days">The number of days to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date daysFromNow(JsNumber days) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on days and the current date.
        /// Basically it adds or subtracts x times the milliseconds of a day,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="days">The number of days to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date daysFromDate(JsNumber days) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on hours.
        /// Basically it adds or subtracts x times the milliseconds of an hour,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="hours">The number of hours to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date hoursFromNow(JsNumber hours) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on hours and the current date.
        /// Basically it adds or subtracts x times the milliseconds of an hour,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="hours">The number of hours to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date hoursFromDate(JsNumber hours) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on minutes.
        /// Basically it adds or subtracts x times the milliseconds of a minute,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="minutes">The number of minutes to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date minutesFromNow(JsNumber minutes) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on minutes and the current date.
        /// Basically it adds or subtracts x times the milliseconds of a minute,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="minutes">The number of minutes to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date minutesFromDate(JsNumber minutes) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on seconds.
        /// Basically it adds or subtracts x times the milliseconds of a second,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="seconds">The number of seconds to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date secondsFromNow(JsNumber seconds) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on seconds and the current date.
        /// Basically it adds or subtracts x times the milliseconds of a second,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="seconds">The number of seconds to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date secondsFromDate(JsNumber seconds) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on milliseconds.
        /// Basically it adds or subtracts x milliseconds,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date millisecondsFromNow(JsNumber milliseconds) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on milliseconds and the current date.
        /// Basically it adds or subtracts x milliseconds,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date millisecondsFromDate(JsNumber milliseconds) { return null; }

        /// <summary>
        /// This method returns the time between two dates, based on the given returnType. Possible return types are:
        /// M.MILLISECONDS: milliseconds
        /// M.SECONDS: seconds
        /// M.MINUTES: minutes
        /// M.HOURS: hours
        /// M.DAYS: days
        /// </summary>
        /// <param name="date"></param>
        /// <param name="returnType"></param>
        /// <returns></returns>
        public JsNumber timeBetween(Date date, JsString returnType) { return null; }

        /// <summary>
        /// This method computes the calendar week of a date. It can either be executed on a M.Date object,
        /// to get the calendar week of that date, or you can pass parameters to get the calendar week for the specified date.
        /// </summary>
        /// <param name="year"> The year part of the date, e.g. 2011. Must be four digits.</param>
        /// <param name="month">The month part of the date: 0-11. Must be one/two digit.</param>
        /// <param name="day">The day part of the date: 1-31. Must be one/two digits.</param>
        /// <returns></returns>
        public JsNumber getCalendarWeek(JsNumber year, JsNumber month, JsNumber day) { return null; }

        /// <summary>
        /// This method returns an array containing all dates within one calendar week as an M.Date object..
        /// If no parameters are given, the calendar week of the current date is taken.
        /// </summary>
        /// <param name="calendarWeek">The calendar week. Note: Pass 'null' if you use this method on an existing M.Date object.</param>
        /// <param name="startWeekOnMonday">Determines whether a week starts on monday or sunday. Optional, default is NO.</param>
        /// <param name="year">The year. Optional, default is current year.</param>
        /// <returns></returns>
        public JsArray getDatesOfCalendarWeek(JsNumber calendarWeek, bool startWeekOnMonday, JsNumber year) { return null; }
        /// <summary>
        /// This method returns an array containing all dates within one calendar week as an M.Date object..
        /// If no parameters are given, the calendar week of the current date is taken.
        /// </summary>
        /// <param name="calendarWeek">The calendar week. Note: Pass 'null' if you use this method on an existing M.Date object.</param>
        /// <param name="startWeekOnMonday">Determines whether a week starts on monday or sunday. Optional, default is NO.</param>
        /// <returns></returns>
        public JsArray getDatesOfCalendarWeek(JsNumber calendarWeek, bool startWeekOnMonday) { return null; }
        /// <summary>
        /// This method returns an array containing all dates within one calendar week as an M.Date object..
        /// If no parameters are given, the calendar week of the current date is taken.
        /// </summary>
        /// <param name="calendarWeek">The calendar week. Note: Pass 'null' if you use this method on an existing M.Date object.</param>
        /// <returns></returns>
        public JsArray getDatesOfCalendarWeek(JsNumber calendarWeek) { return null; }

        /// <summary>
        /// This method returns a date (M.Date) for a given calendar week and day of this week.
        /// </summary>
        /// <param name="calendarWeek"> The calendar week. or sunday. Optional, default is NO.</param>
        /// <param name="dayOfWeek">The day of the week (0 = sunday, ..., 7 = saturday).</param>
        /// <param name="year">The year. Optional, default is current year.</param>
        /// <returns></returns>
        public JsNumber getDateByWeekdayAndCalendarWeek(JsNumber calendarWeek, JsNumber dayOfWeek, JsNumber year) { return null; }
        /// <summary>
        /// This method returns a date (M.Date) for a given calendar week and day of this week.
        /// </summary>
        /// <param name="calendarWeek"> The calendar week. or sunday. Optional, default is NO.</param>
        /// <param name="dayOfWeek">The day of the week (0 = sunday, ..., 7 = saturday).</param>
        /// <returns></returns>
        public JsNumber getDateByWeekdayAndCalendarWeek(JsNumber calendarWeek, JsNumber dayOfWeek) { return null; }
        /// <summary>
        /// This method returns a date (M.Date) for a given calendar week and day of this week.
        /// </summary>
        /// <param name="dayOfWeek">The day of the week (0 = sunday, ..., 7 = saturday).</param>
        /// <returns></returns>
        public JsNumber getDateByWeekdayAndCalendarWeek(JsNumber dayOfWeek) { return null; }

    }
    //TODO: is it ok to call a class that name?

    /// <summary>
    /// The M.Environment object provides information about the environment that your app is running in. It provides methods that return the respective state of the environment:
    /// user agent
    /// platform
    /// viewport size
    /// device orientation
    /// connection status (online/offline)
    /// In several methods, it accesses the global navigator object.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Environment", Export = false)]
    public class Environment
    {
        /// <summary>
        /// The method returns the connection status of the device by invoking a callback function with the status passed.
        /// The status is retrieved by trying to insert an image (tag) into the DOM whose reference URL is a remote stored image
        /// (by default the google logo of google.de is used - we assume that if google is down, you're not connected.
        /// If this is not reliable enough, simply pass your URL as second parameter to the method call).
        /// </summary>
        /// <param name="callback">The callback object defining target and action.
        /// It is also possible to just pass a function to action instead of a string naming the method in a controller.
        /// A constant string (M.ONLINE or M.OFFLINE) is passed to the callback as parameter defining whether the device is online or offline.</param>
        /// <param name="url"> A URL defining a location of an image that is tried to include. If nothing is passed, a default url is used.</param>
        public void getConnectionStatus(JsAction callback, JsString url) { }
        /// <summary>
        /// The method returns the connection status of the device by invoking a callback function with the status passed.
        /// The status is retrieved by trying to insert an image (tag) into the DOM whose reference URL is a remote stored image
        /// (by default the google logo of google.de is used - we assume that if google is down, you're not connected.
        /// If this is not reliable enough, simply pass your URL as second parameter to the method call).
        /// </summary>
        /// <param name="callback">The callback object defining target and action.
        /// It is also possible to just pass a function to action instead of a string naming the method in a controller.
        /// A constant string (M.ONLINE or M.OFFLINE) is passed to the callback as parameter defining whether the device is online or offline.</param>
        public void getConnectionStatus(JsAction callback) { }
        /// <summary>
        /// The method returns the connection status of the device by invoking a callback function with the status passed.
        /// The status is retrieved by trying to insert an image (tag) into the DOM whose reference URL is a remote stored image
        /// (by default the google logo of google.de is used - we assume that if google is down, you're not connected.
        /// If this is not reliable enough, simply pass your URL as second parameter to the method call).
        /// </summary>
        /// <param name="callback">The callback object defining target and action.
        /// It is also possible to just pass a function to action instead of a string naming the method in a controller.
        /// A constant string (M.ONLINE or M.OFFLINE) is passed to the callback as parameter defining whether the device is online or offline.</param>
        /// <param name="url"> A URL defining a location of an image that is tried to include. If nothing is passed, a default url is used.</param>
        public void getConnectionStatus(JsString callback, JsString url) { }
        /// <summary>
        /// The method returns the connection status of the device by invoking a callback function with the status passed.
        /// The status is retrieved by trying to insert an image (tag) into the DOM whose reference URL is a remote stored image
        /// (by default the google logo of google.de is used - we assume that if google is down, you're not connected.
        /// If this is not reliable enough, simply pass your URL as second parameter to the method call).
        /// </summary>
        /// <param name="callback">The callback object defining target and action.
        /// It is also possible to just pass a function to action instead of a string naming the method in a controller.
        /// A constant string (M.ONLINE or M.OFFLINE) is passed to the callback as parameter defining whether the device is online or offline.</param>
        public void getConnectionStatus(JsString callback) { }

        /// <summary>
        /// The method maps to navigator.userAgent and returns the user agent string defined by the browser. The string defines several useful information.
        /// </summary>
        /// <returns>The user agent string.</returns>
        public JsString getUserAgent() { return null; }

        /// <summary>
        /// The method maps to navigator.platform and returns a platform string.
        /// </summary>
        /// <returns> A platform string, e.g. 'MacIntel'.</returns>
        public JsString getPlatform() { return null; }

        /// <summary>
        /// The method returns the currently available width and height of the browser window as an array.
        /// </summary>
        /// <returns>Width and height as numbers in an array: 
        /// [0]: width 
        /// [1]: height</returns>
        public JsArray getSize() { return null; }

        /// <summary>
        /// The method returns the width of the user's browser window (and therefor uses getSize).
        /// </summary>
        /// <returns>The width of the user's browser window.</returns>
        public JsNumber getWidth() { return null; }

        /// <summary>
        /// The method returns the height of the user's browser window (and therefor uses getSize).
        /// </summary>
        /// <returns>The height of the user's browser window.</returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// The method returns the total width and height of the document. Uses getTotalWidth and getTotalHeight.
        /// </summary>
        /// <returns>Width and height as numbers in an array: 
        /// [0]: width 
        /// [1]: height</returns>
        public JsArray getTotalHeight() { return null; }

        /// <summary>
        /// The method returns the total width of the document.
        /// </summary>
        /// <returns> The total width of the document.</returns>
        public JsString getTotalWidth() { return null; }

        /// <summary>
        /// This method returns the device's current orientation, depending on whether or not the device is capable of detecting the current orientation.
        /// If the device is unable to detect the current orientation, this method will return NO.
        /// </summary>
        /// <returns>Number or Boolean: The orientation type as a constant value. If the orientation can not be detected: NO. 
        /// Possible orientation values:
        /// M.PORTRAIT_TOP
        /// M.PORTRAIT_BOTTOM
        /// M.LANDSCAPE_LEFT
        /// M.LANDSCAPE_RIGHT</returns>
        public object getOrientation() { return null; }
    }

    /// <summary>
    /// With M.I18N, The-M-Project provides a tool for internationalisation and localisation.
    /// It can be used to set and get the application's language and to localize any string within an application.
    /// Such a string, for example, can be a label, a url or a path to an image.
    /// To get an idea of what is possible with this feature, take a look at our Todos demo application and switch the language.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.I18N", Export = false)]
    public class I18N
    {
        /// <summary>
        /// This method is used to get a language for the current user. This process is divided into four steps. If one step leads to a language, this one is returned. The steps are prioritized as follows:
        /// 1.get a previously stored language for the user (set by setLanguage)
        /// 2.get the user's language by checking his navigator
        /// 3.use the application's default language
        /// 4.use the systems's default language
        /// </summary>
        /// <returns></returns>
        public JsString getLanguage() { return null; }

        /// <summary>
        /// This method checks if the passed language is available within the application or not.
        /// Normally you, as a developer, should know what language your application support.
        /// Anyway, you can use this method to learn whether a language is supported or not.
        /// </summary>
        /// <param name="language">The language to be checked.</param>
        /// <returns></returns>
        public bool isLanguageAvailable(JsString language) { return false; }

        /// <summary>
        /// This method returns the localized string for the given key based on the current language. 
        /// If context is passed, the input string is searched for pattern &lt;%= the_key %> to be replaced by the property named the_key of context.
        /// With this, dynamic parts in translations can be achieved.
        /// </summary>
        /// <param name="key">The key to the localized string.</param>
        /// <param name="context">Optional. An object defining the values for a parameterized, dynamic translation.</param>
        /// <returns></returns>
        public JsString l(JsString key, object context) { return null; }
        /// <summary>
        /// This method returns the localized string for the given key based on the current language. 
        /// If context is passed, the input string is searched for pattern &lt;%= the_key %> to be replaced by the property named the_key of context.
        /// With this, dynamic parts in translations can be achieved.
        /// </summary>
        /// <param name="key">The key to the localized string.</param>
        /// <returns></returns>
        public JsString l(JsString key) { return null; }

        /// <summary>
        /// This method sets the application's current language and forces it to reload. After the reload, the application will be displayed in the selected language.
        /// Note: Even though we force a reload of the application, this features works offline, too! so don't hesitate to localize your app, you won't lose any functionality.
        /// </summary>
        /// <param name="language"> The language to be set.</param>
        public void setLanguage(JsString language) { }
    }

    /// <summary>
    /// It is used to log messages out of the application based on a given logging level.
    /// There are four logging levels available:
    /// M.INFO
    /// M.DEBUG
    /// M.WARN
    /// M.ERR
    /// By defining a logging level, the developer can decide the importance of a logged message.
    /// The screenshot below shows the particular output on the JavaScript console (here in Chrome Developer Tools).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Logger", Export = false)]
    public class Logger
    {
        /// <summary>
        /// Logs the passed message on the console. The type of output is defined via an optional passed logging level. If no level is passed, M.DEBUG is used by default.
        /// The method also takes care, that things don't blow up, when this object is used in browsers that don't support this or don't have a console.
        /// </summary>
        /// <param name="msg">The logging message.</param>
        /// <param name="level">level (Number, optional): The logging level, as a number from 0 to 3. Can be passed via constant:
        /// M.INFO: 0
        /// M.DEBUG: 1
        /// M.WARN: 2
        /// M.ERR: 3</param>
        public void log(JsString msg, JsNumber level) { }
        /// <summary>
        /// Logs the passed message on the console. The type of output is defined via an optional passed logging level. If no level is passed, M.DEBUG is used by default.
        /// The method also takes care, that things don't blow up, when this object is used in browsers that don't support this or don't have a console.
        /// </summary>
        /// <param name="msg">The logging message.</param>
        public void log(JsString msg) { }

    }

    /// <summary>
    /// Making Ajax requests and accessing remote services is fundamental to every modern web application.
    /// The-M-Project provides an object, M.Request, to make requests. Basically, it uses jQuery to fulfill this task.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Request", Export = false)]
    public class Request
    {
        /// <summary>
        /// Any request must be initialized with this method before it is possible to send.
        /// </summary>
        /// <param name="obj">obj (Object): The parameter object. The object has the following properties:
        /// url (String): the request url, e.g. 'search.twitter.com/search.json' (needs a proxy to be set because of Same-Origin-Policy)
        /// method (String): the http method to use, e.g. 'POST', defaults to 'GET'.
        /// isAsync (Boolean): defines whether request should be made async or not. defaults to YES. Should be YES.
        /// isJSON (Boolean): defines whether to process request and response as JSON, defaults to NO.
        /// timout (Number): defines timeout in milliseconds (optional)
        /// data (String|Object): the data to be transmitted (optional)
        /// beforeSend (function): callback that is called before request is sent (optional)
        /// onError (function): callback that is called when an error occured (optional)
        /// onSuccess (function): callback that is called when request was successful (optional)</param>
        /// <returns>The initialized request object.</returns>
        public Request init(InitOptions obj) { return null; }

        /// <summary>
        /// This methods sends a request, defined by its parameters.
        /// </summary>
        public void send() { }

        /// <summary>
        /// This methods aborts a request.
        /// </summary>
        /// <returns>A boolean value indicating whether the .</returns>
        public bool abort() { return false; }
    }

    [JsType(JsMode.Json)]
    public class InitOptions
    {
        /// <summary>
        /// the request url, e.g. 'search.twitter.com/search.json' (needs a proxy to be set because of Same-Origin-Policy)
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        ///  the http method to use, e.g. 'POST', defaults to 'GET'.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// defines whether request should be made async or not. defaults to YES. Should be YES.
        /// </summary>
        public bool isAsync { get; set; }

        /// <summary>
        /// defines whether to process request and response as JSON, defaults to NO.
        /// </summary>
        public bool isJSON { get; set; }

        /// <summary>
        /// defines timeout in milliseconds (optional)
        /// </summary>
        public JsNumber timout { get; set; }

        /// <summary>
        /// the data to be transmitted (optional)
        /// </summary>
        [JsProperty(Name = "data")]
        public JsString dataString { get; set; }
        /// <summary>
        /// the data to be transmitted (optional)
        /// </summary>
        public object data { get; set; }

        /// <summary>
        ///  callback that is called before request is sent (optional)
        /// </summary>
        public JsAction beforeSend { get; set; }

        /// <summary>
        /// callback that is called when an error occured (optional)
        /// </summary>
        public JsAction onError { get; set; }

        /// <summary>
        /// callback that is called when request was successful (optional)
        /// </summary>
        public JsAction onSuccess { get; set; }

    }

    /// <summary>
    /// The M.Math object wraps JavaScript's Math object and extends it with several own methods. It offers methods for:
    /// expontentiate
    /// retrieving random numbers in a range
    /// rounding
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Math", Export = false)]
    public class Math
    {
        /// <summary>
        /// This method returns the value of the base to the power of the exponent. So e.g. pow(2, 3) would return '2 to the power of 3' --> 8.
        /// </summary>
        /// <param name="base">The base.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The result of the exponentiation operation.</returns>
        public JsNumber pow(JsNumber @base, JsNumber exponent) { return null; }
        //TODO: parametrs type?

        /// <summary>
        /// The method returns a random number within the range given by the min property and the max property, including the min and max value.
        /// A test with 100.000 iterations for random(1, 3) created the following distribution:
        /// - 1: 33.2% 
        /// - 2: 33.2% 
        /// - 3: 33.6%
        /// </summary>
        /// <param name="min"> The minimal value.</param>
        /// <param name="max">The maximal value.</param>
        /// <returns>A random number between the passed range.</returns>
        public JsNumber random(JsNumber min, JsNumber max) { return null; }

        /// <summary>
        /// The method returns rounded version of the given input number.
        /// The type of rounding is defined by the second parameter: type. With the optional third parameter decimals, you can specify the number of decimal digits to be returned.
        /// For example round(1.2345, M.FLOOR, 3) would return 1.234. The default for this parameter is 0.
        /// </summary>
        /// <param name="input"> The input value.</param>
        /// <param name="type">The type of rounding. Needs to be one of these three:
        /// M.FLOOR: Returns the next lower integer, so 2.1 and 2.9 both would return 2.
        /// M.CEIL: Returns the next higher integer, so 2.1 and 2.9 both would return 3.
        /// M.ROUND: Returns the nearest integer, so 2.1 would return 2 and 2.9 would return 3.</param>
        /// <param name="decimals">The number of decimals (only available for M.ROUND).</param>
        /// <returns>The rounded number.</returns>
        public JsNumber round(JsNumber input, object type, JsNumber decimals) { return null; }
        //TODO: type parameter's type?
        /// <summary>
        /// The method returns rounded version of the given input number.
        /// The type of rounding is defined by the second parameter: type. With the optional third parameter decimals, you can specify the number of decimal digits to be returned.
        /// For example round(1.2345, M.FLOOR, 3) would return 1.234. The default for this parameter is 0.
        /// </summary>
        /// <param name="input"> The input value.</param>
        /// <param name="type">The type of rounding. Needs to be one of these three:
        /// M.FLOOR: Returns the next lower integer, so 2.1 and 2.9 both would return 2.
        /// M.CEIL: Returns the next higher integer, so 2.1 and 2.9 both would return 3.
        /// M.ROUND: Returns the nearest integer, so 2.1 would return 2 and 2.9 would return 3.</param>
        /// <returns>The rounded number.</returns>
        public JsNumber round(JsNumber input, object type) { return null; }
        //TODO: type parameter's type?
    }

    /// <summary>
    /// The view manager manages and knows all views that are used within an application.
    /// It is one of the core components and participates in many internal operations.
    /// Everytime there is a communication between the UI, respectively the DOM,
    /// and the actual application, the JS objects, the view manager is used to dispatch notifications between these two layers.
    /// Inside your application, you would typically use the view manager for accessing views in general.
    /// It provides methods for finding a certain view within a page and it helps, retrieving pages by their name.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ViewManager", Export = false)]
    public class ViewManager
    {
        /// <summary>
        /// If you want to access the corresponding JS object of the currently displayed page, simply call this method. It returns excactly what you are looking for.
        /// </summary>
        /// <returns></returns>
        public Page getCurrentPage() { return null; }

        /// <summary>
        /// This will return the DOM id of the passed view object.
        /// </summary>
        /// <param name="view">The view for which the id value is wanted.</param>
        /// <returns></returns>
        public JsString getIdByView(object view) { return null; }

        /// <summary>
        /// This method returns the page object from the view list array identified by its name.
        /// If there are multiple pages with the same name, the first result is returned.
        /// Note: Use unique names for your pages!
        /// </summary>
        /// <param name="pageName">The name of the page to be returned.</param>
        /// <returns></returns>
        public Page getPage(JsString pageName) { return null; }

        /// <summary>
        /// This method returns the view object from the view list array identified by the view's name (targetView) and its surrounding view parentView.
        /// If there are multiple views with the same name on the same surrounding view, the first result is returned.
        /// Note: Use unique names for your views within the same surrounding view!
        /// </summary>
        /// <param name="parentView">The name of the parent view (if it is a page) or the parent view itself.</param>
        /// <param name="targetView">The name of the view to be returned.</param>
        /// <returns></returns>
        public object getView(JsString parentView, JsString targetView) { return null; }
        /// <summary>
        /// This method returns the view object from the view list array identified by the view's name (targetView) and its surrounding view parentView.
        /// If there are multiple views with the same name on the same surrounding view, the first result is returned.
        /// Note: Use unique names for your views within the same surrounding view!
        /// </summary>
        /// <param name="parentView">The name of the parent view (if it is a page) or the parent view itself.</param>
        /// <param name="targetView">The name of the view to be returned.</param>
        /// <returns></returns>
        public object getView(object parentView, JsString targetView) { return null; }

        /// <summary>
        /// This method will return the view object from an internal the view list array, identified by the value of its id property.
        /// Internally we use this method a lot. During the development process this can be very useful for debugging your application.
        /// Just take a look at the DOM, find a view that maybe causes trouble, get its id property and finally use this method to retrieve the corresponding JS object.
        /// </summary>
        /// <param name="id">The DOM id of the corresponding view object.</param>
        public void getViewById(JsString id) { }

    }

    #endregion

    /// <summary>
    /// The action sheet dialog is mostly known from iOS, where it is used in a variety of applications.
    /// It presents a dialog that offers multiple options to the user. One of these options often is a destructive action, e.g. for removing something from a collection.
    /// This button is rendered red. Another option is a 'Cancel'-Option that is used to not make a choice, but cancel it. It's rendered black in default.
    /// In addition to these two buttons, a variable number of other buttons can be defined by passing in an array to the property otherButtonValues.
    /// In difference to the other two dialogs, the action sheet does not show a message, it only shows a title and the choices represented by buttons.
    /// The action sheet's behaviour and look is defined by its properties.
    /// Note: It is also possible to pass a function as action instead of a string (this is possible throughout every callback passing). It is executed in the scope of the target.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ActionSheetDialog", Export = false)]
    public class ActionSheetDialog
    {
        /// <summary>
        /// recommended
        /// Default: "Confirm".
        /// Defines the title of the confirm dialog. The title is shown on the top of the dialog.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// optional
        /// Defines the value shown on the destructive button. If this property is not used, no destructive button is shown.
        /// </summary>
        public JsString destructiveButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Defines the value shown on the cancel button. If this property is not used, no cancel button is shown.
        /// </summary>
        public JsString cancelButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Represents array of strings defining the values of the other shown buttons. Each string represents one button and its value.
        /// </summary>
        public JsArray otherButtonValues { get; set; }

        /// <summary>
        /// optional
        /// An array of strings defining a tag for each of the buttons defined by the previously mentioned values.
        /// The number of strings in this array must match the number of values defined in otherButtonValues.
        /// If not, these tags are skipped and the index number of the button is used as tags.
        /// The index for the tag is the same as the respective index in the otherButtonValues array.
        /// The tags are used to identify which button was pressed in the callback (see below).
        /// </summary>
        public JsArray otherButtonTags { get; set; }

        /// <summary>
        /// mandatory
        /// The object defining the several callbacks. Several sub objects must be defined, when using the respective button:
        /// -destruction must be defined when having a destructive button.
        /// -cancel must be defined when having a cancel button.
        /// -other must be defined when having other buttons.
        /// There's only one callback for the other buttons.
        /// The button tag of the pressed button is passed to this callback. The user needs to decide on basis of this information what to do next.
        /// </summary>
        public object callbacks { get; set; }
    }

    /// <summary>
    /// The alert dialog view is a simple view that has two mandatory and two optional parameters: 
    /// The dialog is similar to the alert dialog that JavaScript offers with the alert('Hello World') call,
    /// except that the TMP alert dialog does not block the application.
    /// In addition it can show a much more customized title than the native JavaScript alert dialog
    /// (this one usually shows something strange like "The page at www.the-m-project.net says:" in the title bar).
    /// It is also possible to pass a callback to the dialog, that is executed after the user clicked the confirm button in the dialog.
    /// Therefore we pass the callback object with a nested object named confirm to the call. In this confirm object we define target and action.
    /// Note: It is also possible to pass a function as action instead of a string (this is possible throughout every callback passing).
    /// It is executed in the scope of the target.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.AlertDialogView", Export = false)]
    public class AlertDialogView
    {
        /// <summary>
        /// recommended
        /// Default: "Alert"
        /// Defines the title of the alert dialog. The title is shown on the top of the dialog
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// optional
        /// Defines the message of the alert dialog.
        /// </summary>
        public JsString message { get; set; }

        /// <summary>
        /// optional
        /// Default: "Ok"
        /// Defines the value of the button shown in the dialog.
        /// </summary>
        public JsString confirmButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Represents array of strings defining the values of the other shown buttons. Each string represents one button and its value.
        /// </summary>
        public JsArray otherButtonValues { get; set; }

        /// <summary>
        /// optional
        /// The object defining the confirm callback. This is optional. If it is passed, a sub object named confirm, defining target and action for the callback.
        /// </summary>
        public JsString callbacks { get; set; }
    }

    /// <summary>
    /// The button view is one of the basic views of the UI library of The-M-Project.
    /// Though it is not rendered as the typical HTML-based button you might know if you are a web developer, its functionality is pretty much the same.
    /// A button view is a tappable / clickable area, that displays a text value and mostly will be used to trigger a certain action.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ButtonView", Export = false)]
    public class ButtonView
    {
        /// <summary>
        /// optional
        /// With this property a dynamic content can be bound to the button view.
        /// Everytime the bound property changes, the button view will automatically update its value and its representation.
        /// </summary>
        public object contentBinding { get; set; }

        /// <summary>
        /// optional
        /// With this property one or more css classes can be added to the button view.
        /// Note: By doing this, the default styling of the button view almost fully disappears. You will need to style the button view yourself.
        /// </summary>
        public JsString cssClass { get; set; }


        /// <summary>
        /// optional
        /// Determines whether this button is active or not.
        /// Note: This property is only used if the button is part of a button group (M.ButtonGroupView).
        /// </summary>
        public bool isActive { get; set; }

        /// <summary>
        /// optional
        /// Determines whether the button is only displayed as an icon, without a text value.
        /// </summary>
        public bool isIconOnly { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to specify a hyperlink target for this button. It only works in combination with the hyperlinkType property.
        /// </summary>
        public JsString hyperlinkTarget { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to specify a certain hyperlink type for this button. It only works in combination with the hyperlinkTarget property.
        /// </summary>
        public JsString hyperlinkType { get; set; }

        /// <summary>
        /// recommended
        /// Defines the value of the button. This value is displayed as the button's text.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// This method can be used to disable the button. This leads to a visual 'disabled' look and disabled the buttons tap/click events.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// This method can be used to enable a disabled button and make it usable again.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// This method can be used to set the button's value at runtime. It updates both the value property and the button's visual representation.
        /// </summary>
        /// <param name="value">The button's new value.</param>
        public void setValue(JsString value) { }

        //TODO: Events

    }

    /// <summary>
    /// A button group is an arrangement of several buttons combined within one control.
    /// They can be vertically or horizontally aligned and they can consist of multiple lines.
    /// By default a button group's button views are selectable. This means that everytime a user clicks / taps a button of a button group view, this button gets selected.
    /// A possible previous selection will be automatically removed before. Such a slection change always fires a change event.
    /// Additionally the included button views can have their own events (e.g. tap events), that are fired at the same time.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ButtonGroupView", Export = false)]
    public class ButtonGroupView
    {
        /// <summary>
        /// optional
        /// This property, if set, defines how many buttons are rendered per line.
        /// If there are more buttons defined that fitting into one line, the following buttons are rendered into a new line.
        /// Make sure, the number of your buttons is divisible by the number of buttons per line, since only full lines are displayed.
        /// So if you for example specify 5 buttons and 2 buttons per line, the fifth button won't be visible.
        /// </summary>
        public JsNumber buttonsPerLine { get; set; }

        /// <summary>
        /// optional
        /// With this property one or more css classes can be added to the button group view.
        /// The string passed with this property is assigned to the class property of the surrounding div container of the button group view.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// optional
        /// Default: M.HORIZONTAL
        /// Determines the direction of the button group. This can either be M.HORIZONTAL (see screenshot #1) or M.VERTICAL (see screenshot #2).
        /// </summary>
        public JsString direction { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// Determines whether to display the button group compact, i.e. without top/bottom margin.
        /// This property only is relevant in combination with multiple lines of buttons (c.p.: buttonsPerLine property).
        /// </summary>
        public bool isCompact { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// Determines whether to display the button group view 'inset' or at full width.
        /// </summary>
        public bool isInset { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property determines whether the buttons of this button group are selectable or not.
        /// </summary>
        public bool isSelectable { get; set; }

        /// <summary>
        /// This method returns the currently selected button of this button group. If no button is selected, null is returned.
        /// </summary>
        /// <returns></returns>
        public ButtonView getActiveButton() { return null; }

        /// <summary>
        /// This method activates one button within the button group.
        /// </summary>
        /// <param name="button">The button to be set active or its id.</param>
        public void setActiveButton(ButtonView button) { }
        /// <summary>
        /// This method activates one button within the button group.
        /// </summary>
        /// <param name="button">The button to be set active or its id.</param>
        public void setActiveButton(JsString button) { }

        //TODO: Events

    }

    /// <summary>
    /// The canvas view basically renders a simple canvas tag into the DOM.
    /// Additionally it offers some wrappers for canvas-based methods,
    /// but mostly you will just use this view for the first rendering of the canvas element and then work on the dom element itself.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.CanvasView", Export = false)]
    public class CanvasView
    {
        /// <summary>
        /// This method returns the canvas' context.
        /// </summary>
        /// <returns></returns>
        public object getCanvas() { return null; }

        /// <summary>
        /// This method returns the canvas' DOM representation.
        /// </summary>
        /// <param name="type">The context type to return.</param>
        /// <returns></returns>
        public object getContext(JsString type) { return null; }

        /// <summary>
        /// This method returns the canvas' height.
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// This method returns the canvas' width.
        /// </summary>
        /// <returns></returns>
        public JsNumber getWidth() { return null; }

        /// <summary>
        /// This method sets the canvas' height.
        /// </summary>
        /// <param name="height">The height to be applied to the canvas view.</param>
        public void setHeight(JsNumber height) { }

        /// <summary>
        /// This method sets the canvas' size.
        /// </summary>
        /// <param name="width">The width to be applied to the canvas view.</param>
        /// <param name="height">The height to be applied to the canvas view.</param>
        public void setSize(JsNumber width, JsNumber height) { }

        /// <summary>
        /// This method sets the canvas' width.
        /// </summary>
        /// <param name="width">The width to be applied to the canvas view.</param>
        public void setWidth(JsNumber width) { }


    }

    /// <summary>
    /// A Carousel View holds other views (M.CarouselItemView). Only one view is displayed at a time and you can navigate through these views by swiping the view's area.
    /// This gives you a sort of page browsing behaviour. This view can be used for many purposes, e.g. a picture gallery.
    /// CSS Styles:
    /// The styling of the carousel itself is written down in a CSS file named tmp.css located in modules/tmp_themes/ in the framework's directory.
    /// All relevant styling properties are written down here:
    /// tmp-carousel-wrapper: The wrapper of the carousel.
    /// tmp-carousel-scroller: The inner scroller component that includes the elements.
    /// ul.tmp-carousel-list li: for the several items in the carousel
    /// tmp-carousel-paginatorand tmp-carousel-paginator-horizontal (or vertical): The paginator
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.CarouselView", Export = false)]
    public class CarouselView
    {
        /// <summary>
        /// optional
        /// Default: YES
        /// This property can be used to specify whether or not to show a paginator with the carousel.
        /// If set to YES, there will be dots visible, indicating the total number of items and highlighting the currently visible item.
        /// </summary>
        public bool showPaginator { get; set; }

        /// <summary>
        /// optional
        /// Default: M.HORIZONTAL
        /// This property determines whether the carousel is vertically or horizontally scrollable. Possible values are:
        /// M.HORIZONTAL: horizontal
        /// M.VERTICAL: vertical
        /// </summary>
        public JsString direction { get; set; }

        /// <summary>
        /// optional
        /// Default: M.CAROUSEL_SIZE_CONTENT
        /// This property can be used to specify on what bases the size of the carousel shall be calculated.
        /// By default the content of the items determine that size (M.CAROUSEL_SIZE_CONTENT).
        /// So the item with the longest / biggest content sets the size for all the other items and the carousel itself.
        /// If set to M.CAROUSEL_SIZE_SURROUNDING_ELEMENT, the surrounding element will determine the size of the carousel.
        /// If set to M.CAROUSEL_SIZE_NONE, there will be no special size calculation for the carousel. You will have to take care about this instead.
        /// </summary>
        public JsNumber sizeCalculator { get; set; }

        /// <summary>
        /// This method activates one specific item within the carousel. Simply pass a valid M.CarouselItemView object or the ID of the view and it gets shown.
        /// </summary>
        /// <param name="item">The ID or the object of a M.CarouselItemView.</param>
        public void setActiveItem(CarouselItemView item) { }
        /// <summary>
        /// This method activates one specific item within the carousel. Simply pass a valid M.CarouselItemView object or the ID of the view and it gets shown.
        /// </summary>
        /// <param name="item">The ID or the object of a M.CarouselItemView.</param>
        public void setActiveItem(JsString item) { }

        /// <summary>
        /// This method activates the next item in the row.
        /// </summary>
        public void next() { }

        /// <summary>
        /// This method activates the previous item in the row.
        /// </summary>
        public void prev() { }

    }

    /// <summary>
    /// A carousel item view is the one and only valid sub view of a carousel view. It basically serves as a container that allows you to put anything into such an element.
    /// Simply apply as much child views as you like and let this view (in combination with the carousel) take care of the rest.
    /// CSS Styles:
    /// The carousel item view receives the following class
    /// tmp-carousel-item
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.CarouselItemView", Export = false)]
    public class CarouselItemView
    {
        /// <summary>
        /// optional
        /// This property can be used to specify a tag, that is independent from the carousel item's content.
        /// This allows you to identify a carousel item e.g. within the callback of the carousel's change event.
        /// </summary>
        public JsString tag { get; set; }
    }

    /// <summary>
    /// The confirm dialog is a little more complex than the alert dialog.
    /// It also takes the two parameters of the alert dialog but additionaly has another mandatory parameter (callbacks) and two optional parameters. 
    /// You might ask yourself "Why do I need callbacks for a confirm dialog?". A confirm dialog marks a fork in your application flow.
    /// You want the user to make a decision. And for every decision the application continues in different directions.
    /// For this purpose, you pass callbacks that define where to go after the user made a decision.
    /// Note: It is also possible to pass a function as action instead of a string (this is possible throughout every callback passing).
    /// It is executed in the scope of the target.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ConfirmDialogView", Export = false)]
    public class ConfirmDialogView
    {
        /// <summary>
        /// recommended
        /// Default: "Confirm".
        /// Defines the title of the confirm dialog. The title is shown on the top of the dialog.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// optional
        /// Defines the value shown on the destructive button. If this property is not used, no destructive button is shown.
        /// </summary>
        public JsString message { get; set; }

        /// <summary>
        /// optional
        /// Default: "Confirm".
        /// Defines the value shown on the confirm button. If this value is not set, the default value is used.
        /// </summary>
        public JsString confirmButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Default: "Cancel".
        /// Defines the value shown on the cancel button. If this value is not set, the default value is used.
        /// </summary>
        public JsString cancelButtonValue { get; set; }

        /// <summary>
        /// mandatory
        /// The object defining the callbacks for confirm and cancel. Two sub objects have to be defined:
        /// confirm : the callback for the confirm button.
        /// cancel : the callback for the cancel button.
        /// </summary>
        public object callbacks { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "M.ContainerView", Export = false)]
    public class ContainerView
    {
    }

    public class TabBarView
    {
    }

    public class Page
    {
        //TODO: i have created this class cuse M.Page is the return type of getCurrentPage and getPage methodes, but i don't see ant doc for this class http://panacodalabs.github.com/The-M-Docs/#components_&_utilities/m_viewmanager

    }
}
