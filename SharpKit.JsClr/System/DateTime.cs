using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

	//TODO: struct

	[JsType(Name = "System.DateTime", Filename = "~/Internal/Core.js")]
	internal class JsImplDateTime
	{
		public JsDate ToJsDate()
		{
			return date;
		}
		JsDate date;

		//HACK - metaspec doesn't resolve the DateTime(year, month, day) ctor
		[JsMethod(Code= @"
if(arguments.length==3)
System.DateTime.ctor$$Int32$$Int32$$Int32.apply(this, arguments);
else if(arguments.length==6)
System.DateTime.ctor$$Int32$$Int32$$Int32$$Int32$$Int32$$Int32.apply(this, arguments);
else
this.date = System.DateTime.MinValue.date;
")]
		public JsImplDateTime()
		{
			this.date = MinValue.date;
		}

		public JsImplDateTime(int year, int month, int day)
		{
			this.date = new JsDate();
			Year = year;
			Month = month;
			Day = day;
		}
		
		public JsImplDateTime(int year, int month, int day, int hour, int minute, int second)
		{
			this.date = new JsDate();
			Year = year;
			Month = month;
			Day = day;
			Hour = hour;
			Minute = minute;
			Second = second;
		}

		JsImplDateTime(JsDate jsDate)
		{
			if (jsDate != null)
				this.date = jsDate;
			else
				this.date = MinValue.date;
		}

		public static JsImplDateTime MinValue=null;

		[JsMethod(Code="return 32 - new Date(year, month-1, 32).getDate();")]
		public static int DaysInMonth(int year, int month)
		{
			return DateTime.DaysInMonth(year, month);
		}

		public int CompareTo(JsImplDateTime value)
		{
			return this.date.valueOf() - value.date.valueOf();
		}		
		
		public static int Compare(JsImplDateTime t1, JsImplDateTime t2)
		{
			return t1.date.valueOf() - t2.date.valueOf();
		}

		//public JsImplDateTime Substract(JsImplDateTime dt)
		//{
		//  return new JsImplDateTime(new JsDate(this.date - dt;
		//}
		public int Year
		{
			get
			{
				return this.date.getFullYear();
			}
			set
			{
				this.date.setFullYear(value);
			}

		}
		public int Month
		{
			get
			{
				return this.date.getMonth() + 1;
			}
			set
			{
				this.date.setMonth(value - 1);
			}

		}
		public int Day
		{
			get
			{
				return this.date.getDate();
			}
			set
			{
				this.date.setDate(value);
			}

		}
		public int Hour
		{
			get
			{
				return this.date.getHours();
			}
			set
			{
				this.date.setHours(value);
			}
		}
		public int Minute
		{
			get
			{									
				return this.date.getMinutes();
			}
			set
			{
				this.date.setMinutes(value);
			}
		}
		public int Second
		{
			get
			{
				return this.date.getSeconds();
			}
			set
			{
				this.date.setSeconds(value);
			}
		}
		public int Millisecond
		{
			get
			{
				return this.date.getMilliseconds();
			}
			set
			{
				this.date.setMilliseconds(value);
			}
		}

		//TODO: JS Enums problem (DayOfWeek)
		public int DayOfWeek 
		{
			get
			{
				return this.date.getDay();
			}
		}
		public override string ToString()
		{
			return this.date.toString();
		}
		public JsImplDateTime AddDays(double days)
		{
			return new JsImplDateTime(this.date.addDays(days.As<int>()));
		}
		public JsImplDateTime AddMonths(int months)
		{
			return new JsImplDateTime(this.date.addMonths(months));
		}
		public static JsImplDateTime Now
		{
			get
			{
				return new JsImplDateTime(new JsDate());
			}
		}
		public JsImplDateTime Today
		{
			get
			{
				return new JsImplDateTime(new JsDate().removeTime());
			}
		}

		public string ToString(string format)
		{
			format = format.Replace("yyyy", Year.ToString("0000"));
			format = format.Replace("yyyy", Year.ToString("00"));
			format = format.Replace("y", Year.ToString());
			format = format.Replace("MM", Month.ToString("00"));
			format = format.Replace("M", Month.ToString());
			format = format.Replace("dd", Day.ToString("00"));
			format = format.Replace("d", Day.ToString());
			format = format.Replace("HH", Hour.ToString("00"));
			format = format.Replace("H", Hour.ToString());
			format = format.Replace("mm", Minute.ToString("00"));
			format = format.Replace("m", Minute.ToString());
			format = format.Replace("ss", Second.ToString("00"));
			format = format.Replace("s", Second.ToString());
			return format;
		}
	}

}
