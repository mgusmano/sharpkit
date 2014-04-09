using SharpKit.JavaScript;


namespace Moment
{
	// Moment.js
	// An incomplete wrapper library for Script#
	
	[JsType(JsMode.Prototype, Export = false, Name = "moment")]
	public abstract class Moment<T>
	{
		[JsType(JsMode.Json)]
		public class Options
		{
			public int years;
			public int months;
			public int days;
			public int hours;
			public int minutes;
			public int seconds;
			public int milliseconds;
		}

		[JsType(JsMode.Json)]
		[JsEnumAttribute(ValuesAsNames = true)]
		public enum Units
		{
			[JsField(Name = "year")]
			year,
			[JsField(Name = "month")]
			month,
			[JsField(Name = "week")]
			week,
			[JsField(Name = "isoWeek")]
			isoWeek,
			[JsField(Name = "day")]
			day,
			[JsField(Name = "date")]
			date,
			[JsField(Name = "hour")]
			hour,
			[JsField(Name = "minute")]
			minute,
			[JsField(Name = "second")]
			second,
			[JsField(Name = "millisecond")]
			millisecond
		};

		[JsType(JsMode.Prototype, Export = false, Name = "moment.duration")]
		public class Duration
		{
			/// <summary>
			///To create a duration with the length of time in milliseconds.
			/// </summary>
			[JsMethod(OmitNewOperator = true)]
			public Duration(int milliseconds) { }
			/// <summary>
			///To create a duration from string
			///The format is an hour, minute, second string separated by colons like 23:59:59. 
			///The number of days can be prefixed with a dot separator like so 7.23:59:59. 
			///Partial seconds are supported as well 23:59:59.999.
			/// </summary>
			[JsMethod(OmitNewOperator = true)]
			public Duration(JsString duration) { }
			/// <summary>
			///If you want to duration with a unit of measurement other than milliseconds, 
			///you can pass the unit of measurement as well.
			/// </summary>
			[JsMethod(OmitNewOperator = true)]
			public Duration(int duration, Units unit) { }
			/// <summary>
			///To create a duration with Options.
			/// </summary>
			[JsMethod(OmitNewOperator = true)]
			public Duration(Options options) { }

			/// <summary>
			///Shows a human readable duration, such as "a minute".
			///By default, the return string is suffixless.
			///If you want a suffix "in a minute", pass in true.
			///For suffixes before now "a minute ago", pass in a negative number.
			/// </summary>
			[JsMethod(Name = "humanize")]
			public JsString Humanize(bool suffix = false) { return null; }
			/// <summary>
			///Get the number of milliseconds in a duration.
			///It will return a number between 0 and 1000
			/// </summary>
			[JsMethod(Name = "milliseconds")]
			public int Milliseconds() { return 0; }
			/// <summary>
			///Get the duration in milliseconds.
			/// </summary>
			[JsMethod(Name = "asMilliseconds")]
			public double AsMilliseconds() { return 0; }
			/// <summary>
			///Get the number of seconds in a duration.
			///It will return a number between 0 and 59
			/// </summary>
			[JsMethod(Name = "seconds")]
			public int Seconds() { return 0; }
			/// <summary>
			///Get the duration in seconds.
			/// </summary>
			[JsMethod(Name = "asSeconds")]
			public double AsSeconds() { return 0; }
			/// <summary>
			///Get the number of minutes in a duration.
			///It will return a number between 0 and 59
			/// </summary>
			[JsMethod(Name = "minutes")]
			public int Minutes() { return 0; }
			/// <summary>
			///Get the duration in minutes.
			/// </summary>
			[JsMethod(Name = "asMinutes")]
			public double AsMinutes() { return 0; }
			/// <summary>
			///Get the number of hours in a duration.
			///It will return a number between 0 and 59
			/// </summary>
			[JsMethod(Name = "hours")]
			/// <summary>
			///Get the duration in hours.
			/// </summary>
			public int Hours() { return 0; }
			[JsMethod(Name = "asHours")]
			public double AsHours() { return 0; }
			[JsMethod(Name = "days")]
			public int Days() { return 0; }
			[JsMethod(Name = "asDays")]
			public double AsDays() { return 0; }
			[JsMethod(Name = "months")]
			public int Months() { return 0; }
			[JsMethod(Name = "asMonths")]
			public double AsMonths() { return 0; }
			[JsMethod(Name = "years")]
			public int Years() { return 0; }
			[JsMethod(Name = "asYears")]
			public double AsYears() { return 0; }
			[JsMethod(Name = "as")]
			public int As(Units unit) { return 0; }
			[JsMethod(Name = "get")]
			public int Get(Units unit) { return 0; }

			[JsMethod(Name = "fromNow")]
			public JsString FromNow(bool withoutSuffix = false) { return null; }
			[JsMethod(Name = "from")]
			public JsString From(T moment, bool withoutSuffix = false) { return null; }
			[JsMethod(Name = "from")]
			public JsString From(JsString moment, bool withoutSuffix = false) { return null; }
			[JsMethod(Name = "from")]
			public JsString From(int milliseconds, bool withoutSuffix = false) { return null; }
			[JsMethod(Name = "from")]
			public JsString From(JsArray<int> moment, bool withoutSuffix = false) { return null; }
			[JsMethod(Name = "from")]
			public JsString From(JsDate date, bool withoutSuffix = false) { return null; }
			[JsMethod(Name = "calendar")]
			public JsString Calendar() { return null; }

			[JsMethod(Name = "subtract")]
			public Duration Subtract(int number, Units unit) { return null; }
			[JsMethod(Name = "subtract")]
			public Duration Subtract(int number) { return null; }
			[JsMethod(Name = "subtract")]
			public Duration Subtract(Duration duration) { return null; }
			[JsMethod(Name = "subtract")]
			public Duration Subtract(Options options) { return null; }

			[JsMethod(Name = "add")]
			public Duration Add(int number, Units unit) { return null; }
			[JsMethod(Name = "add")]
			public Duration Add(int number) { return null; }
			[JsMethod(Name = "add")]
			public Duration Add(Duration duration) { return null; }
			[JsMethod(Name = "add")]
			public Duration Add(Options options) { return null; }
		}



		/// <summary>
		///Clone the moment
		/// </summary>
		[JsMethod(Name = "clone")]
		public T Clone() { return default(T); }
		[JsMethod(Name = "isValid")]
		public T IsValid() { return default(T); }
		[JsMethod(Name = "invalidAt")]
		public int InvalidAt() { return 0; }

		[JsMethod(Name = "millisecond")]
		public int Millisecond() { return 0; }
		[JsMethod(Name = "milliseconds")]
		public int Milliseconds() { return 0; }
		[JsMethod(Name = "millisecond")]
		public T Millisecond(int number) { return default(T); }
		[JsMethod(Name = "milliseconds")]
		public T Milliseconds(int number) { return default(T); }

		[JsMethod(Name = "second")]
		public int Second() { return 0; }
		[JsMethod(Name = "seconds")]
		public int Seconds() { return 0; }
		[JsMethod(Name = "second")]
		public T Second(int number) { return default(T); }
		[JsMethod(Name = "seconds")]
		public T Seconds(int number) { return default(T); }

		[JsMethod(Name = "minute")]
		public int Minute() { return 0; }
		[JsMethod(Name = "minutes")]
		public int Minutes() { return 0; }
		[JsMethod(Name = "minute")]
		public T Minute(int number) { return default(T); }
		[JsMethod(Name = "minutes")]
		public T Minutes(int number) { return default(T); }

		[JsMethod(Name = "hour")]
		public int Hour() { return 0; }
		[JsMethod(Name = "hours")]
		public int Hours() { return 0; }
		[JsMethod(Name = "hour")]
		public T Hour(int number) { return default(T); }
		[JsMethod(Name = "hours")]
		public T Hours(int number) { return default(T); }

		[JsMethod(Name = "date")]
		public int Day() { return 0; }
		[JsMethod(Name = "dates")]
		public int Days() { return 0; }
		[JsMethod(Name = "date")]
		public T Day(int number) { return default(T); }
		[JsMethod(Name = "dates")]
		public T Days(int number) { return default(T); }

		// Sunday: 0, ... Saturday: 6
		// todo: use enum
		[JsMethod(Name = "day")]
		public int DayOfWeek() { return 0; }
		[JsMethod(Name = "days")]
		public int DayOfWeeks() { return 0; }
		[JsMethod(Name = "day")]
		public T DayOfWeek(int number) { return default(T); }
		[JsMethod(Name = "days")]
		public T DayOfWeeks(int number) { return default(T); }

		[JsMethod(Name = "weekday")]
		public int Weekday() { return 0; }
		[JsMethod(Name = "weekday")]
		public T Weekday(int number) { return default(T); }
	
		[JsMethod(Name = "isoWeekday")]
		public int IsoWeekday() { return 0; }
		[JsMethod(Name = "isoWeekday")]
		public T IsoWeekday(int number) { return default(T); }

		[JsMethod(Name = "dayOfYear")]
		public int DayOfYear() { return 0; }
		[JsMethod(Name = "dayOfYear")]
		public T DayOfYear(int number) { return default(T); }
	
		[JsMethod(Name = "week")]
		public int Week() { return 0; }
		[JsMethod(Name = "weeks")]
		public int Weeks() { return 0; }
		[JsMethod(Name = "week")]
		public T Week(int number) { return default(T); }
		[JsMethod(Name = "weeks")]
		public T Weeks(int number) { return default(T); }

		[JsMethod(Name = "isoWeek")]
		public int IsoWeek() { return 0; }
		[JsMethod(Name = "isoWeeks")]
		public int IsoWeeks() { return 0; }
		[JsMethod(Name = "isoWeek")]
		public T IsoWeek(int number) { return default(T); }
		[JsMethod(Name = "isoWeeks")]
		public T IsoWeeks(int number) { return default(T); }

		[JsMethod(Name = "month")]
		public int Month() { return 0; }
		[JsMethod(Name = "months")]
		public int Months() { return 0; }
		[JsMethod(Name = "month")]
		public T Month(int number) { return default(T); }
		[JsMethod(Name = "months")]
		public T Months(int number) { return default(T); }

		[JsMethod(Name = "quarter")]
		public int Quarter() { return 0; }

		[JsMethod(Name = "year")]
		public int Year() { return 0; }
		[JsMethod(Name = "years")]
		public int Years() { return 0; }
		[JsMethod(Name = "year")]
		public T Year(int number) { return default(T); }
		[JsMethod(Name = "years")]
		public T Years(int number) { return default(T); }

		[JsMethod(Name = "weekYear")]
		public int WeekYear() { return 0; }
		[JsMethod(Name = "weekYear")]
		public T WeekYear(int number) { return default(T); }

		[JsMethod(Name = "isoWeekYear")]
		public int IsoWeekYear() { return 0; }
		[JsMethod(Name = "isoWeekYear")]
		public T IsoWeekYear(int number) { return default(T); }

		[JsMethod(Name = "subtract")]
		public T Subtract(Units unit, int number) { return default(T); }
		[JsMethod(Name = "subtract")]
		public T Subtract(int number, Units unit) { return default(T); }
		[JsMethod(Name = "subtract")]
		public T Subtract(Duration duration) { return default(T); }
		[JsMethod(Name = "subtract")]
		public T Subtract(Options options) { return default(T); }

		[JsMethod(Name = "add")]
		public T Add(Units unit, int number) { return default(T); }
		[JsMethod(Name = "add")]
		public T Add(int number, Units unit) { return default(T); }
		[JsMethod(Name = "add")]
		public T Add(Duration duration) { return default(T); }
		[JsMethod(Name = "add")]
		public T Add(Options options) { return default(T); }

		// moment().diff(Moment|String|Number|Date|Array, String, Boolean);
		[JsMethod(Name = "diff")]
		public int Diff(T moment, Units unit = Units.millisecond) { return 0; }
		[JsMethod(Name = "diff")]
		public int Diff(JsString moment, Units unit = Units.millisecond) { return 0; }
		[JsMethod(Name = "diff")]
		public int Diff(int milliseconds, Units unit = Units.millisecond) { return 0; }
		[JsMethod(Name = "diff")]
		public int Diff(JsDate date, Units unit = Units.millisecond) { return 0; }
		[JsMethod(Name = "diff")]
		public int Diff(JsArray<int> moment, Units unit = Units.millisecond) { return 0; }
		[JsMethod(Name = "diff")]
		public double Diff(T moment, Units unit = Units.millisecond, bool asDouble = true) { return 0; }
		[JsMethod(Name = "diff")]
		public double Diff(JsString moment, Units unit = Units.millisecond, bool asDouble = true) { return 0; }
		[JsMethod(Name = "diff")]
		public double Diff(int milliseconds, Units unit = Units.millisecond, bool asDouble = true) { return 0; }
		[JsMethod(Name = "diff")]
		public double Diff(JsDate date, Units unit = Units.millisecond, bool asDouble = true) { return 0; }
		[JsMethod(Name = "diff")]
		public double Diff(JsArray<int> moment, Units unit = Units.millisecond, bool asDouble = true) { return 0; }

		[JsMethod(Name = "max")]
		public T Max(T moment) { return default(T); }
		[JsMethod(Name = "max")]
		public T Max(JsString moment) { return default(T); }
		[JsMethod(Name = "max")]
		public T Max(int milliseconds) { return default(T); }
		[JsMethod(Name = "max")]
		public T Max(JsDate date) { return default(T); }
		[JsMethod(Name = "max")]
		public T Max(JsArray<int> moment) { return default(T); }
		[JsMethod(Name = "min")]
		public T Min(T moment) { return default(T); }
		[JsMethod(Name = "min")]
		public T Min(JsString moment) { return default(T); }
		[JsMethod(Name = "min")]
		public T Min(int milliseconds) { return default(T); }
		[JsMethod(Name = "min")]
		public T Min(JsDate date) { return default(T); }
		[JsMethod(Name = "min")]
		public T Min(JsArray<int> moment) { return default(T); }

		[JsMethod(Name = "startOf")]
		public T StartOf(Units unit) { return default(T); }
		[JsMethod(Name = "endOf")]
		public T EndOf(Units unit) { return default(T); }
		[JsMethod(Name = "daysInMonth")]
		public int DaysInMonth() { return 0; }
		[JsMethod(Name = "toDate")]
		public JsDate ToDate() { return null; }
		[JsMethod(Name = "toArray")]
		public JsArray<int> ToArray() { return null; }
		[JsMethod(Name = "valueOf")]
		public int UnixOffset() { return 0; }
		[JsMethod(Name = "unix")]
		public int UnixTimestamp() { return 0; }

		[JsMethod(Name = "format")]
		public T Format(JsString format) { return default(T); }
		[JsMethod(Name = "toJSON")]
		public JsString ToJSON() { return null; }
		[JsMethod(Name = "toISOString")]
		public JsString ToISOString() { return null; }

		[JsMethod(InlineCodeExpression = "first.isBefore(second)")]
		public static bool operator < (Moment<T> first, Moment<T> second) { return false; }
		[JsMethod(InlineCodeExpression = "first.isAfter(second)")]
		public static bool operator >(Moment<T> first, Moment<T> second) { return false; }
		[JsMethod(InlineCodeExpression = "first.isSame(second)")]
		public static bool operator ==(Moment<T> first, Moment<T> second) { return false; }
		[JsMethod(InlineCodeExpression = "!first.isSame(second)")]
		public static bool operator !=(Moment<T> first, Moment<T> second) { return false; }
		[JsMethod(InlineCodeExpression = "(first.isSame(second) || first.isAfter(second))")]
		public static bool operator >=(Moment<T> first, Moment<T> second) { return false; }
		[JsMethod(InlineCodeExpression = "(first.isSame(second) || first.isBefore(second))")]
		public static bool operator <=(Moment<T> first, Moment<T> second) { return false; }
		[JsMethod(InlineCodeExpression = "this === equalTo")]
		public override bool Equals(object equalTo) { return false; }

		[JsMethod(Name = "isLeapYear")]
		public bool IsLeapYear() { return false; }
		[JsMethod(Name = "isDST")]
		public bool IsDST() { return false; }
		[JsMethod(Name = "lang")]
		public void Language(JsString languageShort) { }
		[JsMethod(Name = "lang")]
		public JsString Language() { return null; }
		/* prohibited to maintain class integrity between Local and Utc,
		 * use appropriate clone constructor or Clone() instead
		[JsMethod(Name = "utc")]
		public T Utc() { return default(T); }
		[JsMethod(Name = "local")]
		public T Local() { return default(T); }
		*/

		[JsMethod(Name = "zone")]
		public T Zone(int offset) { return default(T); }
		[JsMethod(Name = "zone")]
		public T Zone(JsString offset) { return default(T); }
		[JsMethod(Name = "zone")]
		public int Zone() { return 0; }
		[JsMethod(Name = "parseZone")]
		public T ParseZone(JsString dataTime) { return default(T); }
	}

	public class Local : Moment<Local>
	{
		// constructor
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local() { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(Moment<Local>.Options options) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(JsDate date) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(JsString date) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(JsString date, JsString format) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(JsString date, JsString format, bool strict) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(JsString date, JsString format, JsString language, bool strict) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(JsString date, JsString format, JsString language) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(JsString date, JsString format, bool strict, JsString language) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(JsArray<int> data) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Local(Local momentToClone) { }
		[JsMethod(OmitNewOperator = true, Name = "moment", ArgumentsSuffix = ".local()")]
		public Local(Utc momentToClone) { }
	}

	public class Utc : Moment<Utc>
	{
		// constructor
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc() { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(Moment<Utc>.Options options) { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(JsDate date) { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(JsString date) { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(JsString date, JsString format) { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(JsString date, JsString format, bool strict) { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(JsString date, JsString format, JsString language, bool strict) { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(JsString date, JsString format, JsString language) { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(JsString date, JsString format, bool strict, JsString language) { }
		[JsMethod(OmitNewOperator = true, Name = "moment.utc")]
		public Utc(JsArray<int> data) { }
		[JsMethod(OmitNewOperator = true, Name = "moment")]
		public Utc(Utc momentToClone) { }
		[JsMethod(OmitNewOperator = true, Name = "moment", ArgumentsSuffix = ".utc()")]
		public Utc(Local momentToClone) { }
	}

}
