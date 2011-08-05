//using System;
//using System.Collections.Generic;
//
//using System.Text;
//

//namespace SharpKit.Core.JavaScript.Extensions.Private
//{
///// <summary>Represents a time interval.</summary>
///// <filterpriority>1</filterpriority>
//  [RunAtClient]
//  [JsType(Name = "System.TimeSpan")]
//  public class JsImplTimeSpan
//  {

//    /// <summary>Represents the number of ticks in 1 millisecond. This field is constant.</summary>
//    /// <filterpriority>1</filterpriority>
//    public const long TicksPerMillisecond = 10000L;
//    private const double MillisecondsPerTick = 0.0001;
//    /// <summary>Represents the number of ticks in 1 second.</summary>
//    /// <filterpriority>1</filterpriority>
//    public const long TicksPerSecond = 10000000L;
//    private const double SecondsPerTick = 1E-07;
//    /// <summary>Represents the number of ticks in 1 minute. This field is constant.</summary>
//    /// <filterpriority>1</filterpriority>
//    public const long TicksPerMinute = 600000000L;
//    private const double MinutesPerTick = 1.6666666666666667E-09;
//    /// <summary>Represents the number of ticks in 1 hour. This field is constant.</summary>
//    /// <filterpriority>1</filterpriority>
//    public const long TicksPerHour = 36000000000L;
//    private const double HoursPerTick = 2.7777777777777777E-11;
//    /// <summary>Represents the number of ticks in 1 day. This field is constant.</summary>
//    /// <filterpriority>1</filterpriority>
//    public const long TicksPerDay = 864000000000L;
//    private const double DaysPerTick = 1.1574074074074074E-12;
//    private const int MillisPerSecond = 1000;
//    private const int MillisPerMinute = 60000;
//    private const int MillisPerHour = 3600000;
//    private const int MillisPerDay = 86400000;
//    private const long MaxSeconds = 922337203685L;
//    private const long MinSeconds = -922337203685L;
//    private const long MaxMilliSeconds = 922337203685477L;
//    private const long MinMilliSeconds = -922337203685477L;
//    /// <summary>Represents the zero <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
//    /// <filterpriority>1</filterpriority>
//    public static readonly TimeSpan Zero;
//    /// <summary>Represents the maximum <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
//    /// <filterpriority>1</filterpriority>
//    public static readonly TimeSpan MaxValue;
//    /// <summary>Represents the minimum <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
//    /// <filterpriority>1</filterpriority>
//    public static readonly TimeSpan MinValue;
//    internal long _ticks;
//    /// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to the specified number of ticks.</summary>
//    /// <param name="ticks">A time period expressed in 100-nanosecond units. </param>
//    public JsImplTimeSpan(long ticks)
//    {
//        this._ticks = ticks;
//    }

//    /// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to a specified number of hours, minutes, and seconds.</summary>
//    /// <param name="hours">Number of hours. </param>
//    /// <param name="minutes">Number of minutes. </param>
//    /// <param name="seconds">Number of seconds. </param>
//    /// <exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
//    public JsImplTimeSpan(int hours, int minutes, int seconds)
//    {
//        this._ticks = TimeToTicks(hours, minutes, seconds);
//    }

//    /// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to a specified number of days, hours, minutes, and seconds.</summary>
//    /// <param name="days">Number of days. </param>
//    /// <param name="hours">Number of hours. </param>
//    /// <param name="minutes">Number of minutes. </param>
//    /// <param name="seconds">Number of seconds. </param>
//    /// <exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
//    public JsImplTimeSpan(int days, int hours, int minutes, int seconds) : this(days, hours, minutes, seconds, 0)
//    {
//    }

//    /// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to a specified number of days, hours, minutes, seconds, and milliseconds.</summary>
//    /// <param name="days">Number of days. </param>
//    /// <param name="hours">Number of hours. </param>
//    /// <param name="minutes">Number of minutes. </param>
//    /// <param name="seconds">Number of seconds. </param>
//    /// <param name="milliseconds">Number of milliseconds. </param>
//    /// <exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
//    public JsImplTimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
//    {
//        long num = ((((((days * 3600L) * 24L) + (hours * 3600L)) + (minutes * 60L)) + seconds) * 1000L) + milliseconds;
//        if ((num > 922337203685477L) || (num < -922337203685477L))
//        {
//            throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Overflow_TimeSpanTooLong"));
//        }
//        this._ticks = num * 10000L;
//    }

//    /// <summary>Gets the number of ticks that represent the value of the current <see cref="T:System.TimeSpan" /> structure.</summary>
//    /// <returns>The number of ticks contained in this instance.</returns>
//    /// <filterpriority>1</filterpriority>
//    public long Ticks
//    {
//        get
//        {
//            return this._ticks;
//        }
//    }
//    /// <summary>Gets the number of whole days represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
//    /// <returns>The day component of this instance. The return value can be positive or negative.</returns>
//    /// <filterpriority>1</filterpriority>
//    public int Days
//    {
//        get
//        {
//            return (int) (this._ticks / 864000000000L);
//        }
//    }
//    /// <summary>Gets the number of whole hours represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
//    /// <returns>The hour component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -23 through 23.</returns>
//    /// <filterpriority>1</filterpriority>
//    public int Hours
//    {
//        get
//        {
//            return (int) ((this._ticks / 36000000000L) % 24L);
//        }
//    }
//    /// <summary>Gets the number of whole milliseconds represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
//    /// <returns>The millisecond component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -999 through 999.</returns>
//    /// <filterpriority>1</filterpriority>
//    public int Milliseconds
//    {
//        get
//        {
//            return (int) ((this._ticks / 10000L) % 1000L);
//        }
//    }
//    /// <summary>Gets the number of whole minutes represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
//    /// <returns>The minute component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -59 through 59.</returns>
//    /// <filterpriority>1</filterpriority>
//    public int Minutes
//    {
//        get
//        {
//            return (int) ((this._ticks / 600000000L) % 60L);
//        }
//    }
//    /// <summary>Gets the number of whole seconds represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
//    /// <returns>The second component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -59 through 59.</returns>
//    /// <filterpriority>1</filterpriority>
//    public int Seconds
//    {
//        get
//        {
//            return (int) ((this._ticks / 10000000L) % 60L);
//        }
//    }
//    /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional days.</summary>
//    /// <returns>The total number of days represented by this instance.</returns>
//    /// <filterpriority>1</filterpriority>
//    public double TotalDays
//    {
//        get
//        {
//            return (this._ticks * 1.1574074074074074E-12);
//        }
//    }
//    /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional hours.</summary>
//    /// <returns>The total number of hours represented by this instance.</returns>
//    /// <filterpriority>1</filterpriority>
//    public double TotalHours
//    {
//        get
//        {
//            return (this._ticks * 2.7777777777777777E-11);
//        }
//    }
//    /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional milliseconds.</summary>
//    /// <returns>The total number of milliseconds represented by this instance.</returns>
//    /// <filterpriority>1</filterpriority>
//    public double TotalMilliseconds
//    {
//        get
//        {
//            double num = this._ticks * 0.0001;
//            if (num > 922337203685477)
//            {
//                return 922337203685477;
//            }
//            if (num < -922337203685477)
//            {
//                return -922337203685477;
//            }
//            return num;
//        }
//    }
//    /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional minutes.</summary>
//    /// <returns>The total number of minutes represented by this instance.</returns>
//    /// <filterpriority>1</filterpriority>
//    public double TotalMinutes
//    {
//        get
//        {
//            return (this._ticks * 1.6666666666666667E-09);
//        }
//    }
//    /// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional seconds.</summary>
//    /// <returns>The total number of seconds represented by this instance.</returns>
//    /// <filterpriority>1</filterpriority>
//    public double TotalSeconds
//    {
//        get
//        {
//            return (this._ticks * 1E-07);
//        }
//    }
//    /// <summary>Adds the specified <see cref="T:System.TimeSpan" /> to this instance.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> that represents the value of this instance plus the value of <paramref name="ts" />.</returns>
//    /// <param name="ts">A <see cref="T:System.TimeSpan" />. </param>
//    /// <exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public TimeSpan Add(TimeSpan ts)
//    {
//        long ticks = this._ticks + ts._ticks;
//        if (((this._ticks >> 63) == (ts._ticks >> 63)) && ((this._ticks >> 63) != (ticks >> 63)))
//        {
//            throw new OverflowException(Environment.GetResourceString("Overflow_TimeSpanTooLong"));
//        }
//        return new TimeSpan(ticks);
//    }

//    /// <summary>Compares two <see cref="T:System.TimeSpan" /> values and returns an integer that indicates their relationship.</summary>
//    /// <returns>Value Condition -1 <paramref name="t1" /> is less than <paramref name="t2" />0 <paramref name="t1" /> is equal to <paramref name="t2" />1 <paramref name="t1" /> is greater than <paramref name="t2" /></returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A <see cref="T:System.TimeSpan" />. </param>
//    /// <filterpriority>1</filterpriority>
//    public static int Compare(TimeSpan t1, TimeSpan t2)
//    {
//        if (t1._ticks > t2._ticks)
//        {
//            return 1;
//        }
//        if (t1._ticks < t2._ticks)
//        {
//            return -1;
//        }
//        return 0;
//    }

//    /// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
//    /// <returns>Value Condition -1 The value of this instance is less than the value of <paramref name="value" />. 0 The value of this instance is equal to the value of <paramref name="value" />. 1 The value of this instance is greater than the value of <paramref name="value" />.-or- <paramref name="value" /> is null. </returns>
//    /// <param name="value">An object to compare, or null. </param>
//    /// <exception cref="T:System.ArgumentException">
//    /// <paramref name="value" /> is not a <see cref="T:System.TimeSpan" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public int CompareTo(object value)
//    {
//        if (value == null)
//        {
//            return 1;
//        }
//        if (!(value is TimeSpan))
//        {
//            throw new ArgumentException(Environment.GetResourceString("Arg_MustBeTimeSpan"));
//        }
//        long num = ((TimeSpan) value)._ticks;
//        if (this._ticks > num)
//        {
//            return 1;
//        }
//        if (this._ticks < num)
//        {
//            return -1;
//        }
//        return 0;
//    }

//    /// <summary>Compares this instance to a specified <see cref="T:System.TimeSpan" /> object and returns an indication of their relative values.</summary>
//    /// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description A negative integer This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is greater than <paramref name="value" />. </returns>
//    /// <param name="value">A <see cref="T:System.TimeSpan" /> object to compare to this instance.</param>
//    /// <filterpriority>1</filterpriority>
//    public int CompareTo(TimeSpan value)
//    {
//        long num = value._ticks;
//        if (this._ticks > num)
//        {
//            return 1;
//        }
//        if (this._ticks < num)
//        {
//            return -1;
//        }
//        return 0;
//    }

//    /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of days, where the specification is accurate to the nearest millisecond.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> that represents <paramref name="value" />.</returns>
//    /// <param name="value">A number of days, accurate to the nearest millisecond. </param>
//    /// <exception cref="T:System.OverflowException">
//    /// <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. -or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception>
//    /// <exception cref="T:System.ArgumentException">
//    /// <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public static TimeSpan FromDays(double value)
//    {
//        return Interval(value, 86400000);
//    }

//    /// <summary>Returns a new <see cref="T:System.TimeSpan" /> object whose value is the absolute value of the current <see cref="T:System.TimeSpan" /> object.</summary>
//    /// <returns>A new <see cref="T:System.TimeSpan" /> whose value is the absolute value of the current <see cref="T:System.TimeSpan" /> object.</returns>
//    /// <exception cref="T:System.OverflowException">The value of this instance is <see cref="F:System.TimeSpan.MinValue" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public TimeSpan Duration()
//    {
//        if (this._ticks == MinValue._ticks)
//        {
//            throw new OverflowException(Environment.GetResourceString("Overflow_Duration"));
//        }
//        return new TimeSpan((this._ticks >= 0L) ? this._ticks : -this._ticks);
//    }

//    /// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
//    /// <returns>true if <paramref name="value" /> is a <see cref="T:System.TimeSpan" /> object that represents the same time interval as the current <see cref="T:System.TimeSpan" /> structure; otherwise, false.</returns>
//    /// <param name="value">An object to compare with this instance. </param>
//    /// <filterpriority>1</filterpriority>
//    public override bool Equals(object value)
//    {
//        return ((value is TimeSpan) && (this._ticks == ((TimeSpan) value)._ticks));
//    }

//    /// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.TimeSpan" /> object.</summary>
//    /// <returns>true if <paramref name="obj" /> represents the same time interval as this instance; otherwise, false.</returns>
//    /// <param name="obj">An <see cref="T:System.TimeSpan" /> object to compare with this instance. </param>
//    /// <filterpriority>1</filterpriority>
//    public bool Equals(TimeSpan obj)
//    {
//        return (this._ticks == obj._ticks);
//    }

//    /// <summary>Returns a value indicating whether two specified instances of <see cref="T:System.TimeSpan" /> are equal.</summary>
//    /// <returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are equal; otherwise, false.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <filterpriority>1</filterpriority>
//    public static bool Equals(TimeSpan t1, TimeSpan t2)
//    {
//        return (t1._ticks == t2._ticks);
//    }

//    /// <summary>Returns a hash code for this instance.</summary>
//    /// <returns>A 32-bit signed integer hash code.</returns>
//    /// <filterpriority>2</filterpriority>
//    public override int GetHashCode()
//    {
//        return (((int) this._ticks) ^ ((int) (this._ticks >> 32)));
//    }

//    /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of hours, where the specification is accurate to the nearest millisecond.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> that represents <paramref name="value" />.</returns>
//    /// <param name="value">A number of hours accurate to the nearest millisecond. </param>
//    /// <exception cref="T:System.OverflowException">
//    /// <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. -or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception>
//    /// <exception cref="T:System.ArgumentException">
//    /// <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public static TimeSpan FromHours(double value)
//    {
//        return Interval(value, 3600000);
//    }

//    private static TimeSpan Interval(double value, int scale)
//    {
//        if (double.IsNaN(value))
//        {
//            throw new ArgumentException(Environment.GetResourceString("Arg_CannotBeNaN"));
//        }
//        double num = value * scale;
//        double num2 = num + ((value >= 0.0) ? 0.5 : -0.5);
//        if ((num2 > 922337203685477) || (num2 < -922337203685477))
//        {
//            throw new OverflowException(Environment.GetResourceString("Overflow_TimeSpanTooLong"));
//        }
//        return new TimeSpan(((long) num2) * 10000L);
//    }

//    /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of milliseconds.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> that represents <paramref name="value" />.</returns>
//    /// <param name="value">A number of milliseconds. </param>
//    /// <exception cref="T:System.OverflowException">
//    /// <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception>
//    /// <exception cref="T:System.ArgumentException">
//    /// <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public static TimeSpan FromMilliseconds(double value)
//    {
//        return Interval(value, 1);
//    }

//    /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of minutes, where the specification is accurate to the nearest millisecond.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> that represents <paramref name="value" />.</returns>
//    /// <param name="value">A number of minutes, accurate to the nearest millisecond. </param>
//    /// <exception cref="T:System.OverflowException">
//    /// <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception>
//    /// <exception cref="T:System.ArgumentException">
//    /// <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public static TimeSpan FromMinutes(double value)
//    {
//        return Interval(value, 60000);
//    }

//    /// <summary>Returns a <see cref="T:System.TimeSpan" /> whose value is the negated value of this instance.</summary>
//    /// <returns>The same numeric value as this instance, but with the opposite sign.</returns>
//    /// <exception cref="T:System.OverflowException">The negated value of this instance cannot be represented by a <see cref="T:System.TimeSpan" />; that is, the value of this instance is <see cref="F:System.TimeSpan.MinValue" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public TimeSpan Negate()
//    {
//        if (this._ticks == MinValue._ticks)
//        {
//            throw new OverflowException(Environment.GetResourceString("Overflow_NegateTwosCompNum"));
//        }
//        return new TimeSpan(-this._ticks);
//    }

//    /// <summary>Constructs a new <see cref="T:System.TimeSpan" /> object from a time interval specified in a string.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> that corresponds to <paramref name="s" />.</returns>
//    /// <param name="s">A string that specifies a time interval. </param>
//    /// <exception cref="T:System.ArgumentNullException">
//    /// <paramref name="s" /> is null. </exception>
//    /// <exception cref="T:System.FormatException">
//    /// <paramref name="s" /> has an invalid format. </exception>
//    /// <exception cref="T:System.OverflowException">
//    /// <paramref name="s" /> represents a number less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or- At least one of the days, hours, minutes, or seconds components is outside its valid range. </exception>
//    /// <filterpriority>1</filterpriority>
//    public static TimeSpan Parse(string s)
//    {
//        StringParser parser2 = new StringParser();
//        return new TimeSpan(parser2.Parse(s));
//    }

//    /// <summary>Constructs a new <see cref="T:System.TimeSpan" /> object from a time interval specified in a string. Parameters specify the time interval and the variable where the new <see cref="T:System.TimeSpan" /> object is returned. </summary>
//    /// <returns>true if <paramref name="s" /> was converted successfully; otherwise, false. This operation returns false if the <paramref name="s" /> parameter is null, has an invalid format, represents a time interval less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />, or has at least one days, hours, minutes, or seconds component outside its valid range.</returns>
//    /// <param name="s">A string that specifies a time interval.</param>
//    /// <param name="result">When this method returns, contains an object that represents the time interval specified by <paramref name="s" />, or <see cref="F:System.TimeSpan.Zero" /> if the conversion failed. This parameter is passed uninitialized.</param>
//    /// <filterpriority>1</filterpriority>
//    public static bool TryParse(string s, out TimeSpan result)
//    {
//        long num;
//        StringParser parser2 = new StringParser();
//        if (parser2.TryParse(s, out num))
//        {
//            result = new TimeSpan(num);
//            return true;
//        }
//        result = Zero;
//        return false;
//    }

//    /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of seconds, where the specification is accurate to the nearest millisecond.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> that represents <paramref name="value" />.</returns>
//    /// <param name="value">A number of seconds, accurate to the nearest millisecond. </param>
//    /// <exception cref="T:System.OverflowException">
//    /// <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception>
//    /// <exception cref="T:System.ArgumentException">
//    /// <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public static TimeSpan FromSeconds(double value)
//    {
//        return Interval(value, 1000);
//    }

//    /// <summary>Subtracts the specified <see cref="T:System.TimeSpan" /> from this instance.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> whose value is the result of the value of this instance minus the value of <paramref name="ts" />.</returns>
//    /// <param name="ts">A <see cref="T:System.TimeSpan" />. </param>
//    /// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
//    /// <filterpriority>1</filterpriority>
//    public TimeSpan Subtract(TimeSpan ts)
//    {
//        long ticks = this._ticks - ts._ticks;
//        if (((this._ticks >> 63) != (ts._ticks >> 63)) && ((this._ticks >> 63) != (ticks >> 63)))
//        {
//            throw new OverflowException(Environment.GetResourceString("Overflow_TimeSpanTooLong"));
//        }
//        return new TimeSpan(ticks);
//    }

//    /// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified time, where the specification is in units of ticks.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> with a value of <paramref name="value" />.</returns>
//    /// <param name="value">A number of ticks that represent a time. </param>
//    /// <filterpriority>1</filterpriority>
//    public static TimeSpan FromTicks(long value)
//    {
//        return new TimeSpan(value);
//    }

//    internal static long TimeToTicks(int hour, int minute, int second)
//    {
//        long num = ((hour * 3600L) + (minute * 60L)) + second;
//        if ((num > 922337203685L) || (num < -922337203685L))
//        {
//            throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Overflow_TimeSpanTooLong"));
//        }
//        return (num * 10000000L);
//    }

//    private string IntToString(int n, int digits)
//    {
//        return ParseNumbers.IntToString(n, 10, digits, '0', 0);
//    }

//    /// <summary>Returns the string representation of the value of this instance.</summary>
//    /// <returns>A string that represents the value of this instance. The return value is of the form: [-][d.]hh:mm:ss[.ff] Items in square brackets ([ and ]) are optional, colons and periods (: and.) are literal characters; and the other items are as follows.Item Description "-" optional minus sign indicating a negative time "d" optional days "hh" hours, ranging from 0 to 23 "mm" minutes, ranging from 0 to 59 "ss" seconds, ranging from 0 to 59 "ff" optional fractional seconds, from 1 to 7 decimal digits For more information about comparing the string representation of <see cref="T:System.TimeSpan" /> and Oracle data types, see article Q324577, "System.TimeSpan Does Not Match Oracle 9i INTERVAL DAY TO SECOND Data Type," in the Microsoft Knowledge Base at http://support.microsoft.com.</returns>
//    /// <filterpriority>1</filterpriority>
//    public override string ToString()
//    {
//        StringBuilder builder = new StringBuilder();
//        int num = (int) (this._ticks / 864000000000L);
//        long num2 = this._ticks % 864000000000L;
//        if (this._ticks < 0L)
//        {
//            builder.Append("-");
//            num = -num;
//            num2 = -num2;
//        }
//        if (num != 0)
//        {
//            builder.Append(num);
//            builder.Append(".");
//        }
//        builder.Append(this.IntToString((int) ((num2 / 36000000000L) % 24L), 2));
//        builder.Append(":");
//        builder.Append(this.IntToString((int) ((num2 / 600000000L) % 60L), 2));
//        builder.Append(":");
//        builder.Append(this.IntToString((int) ((num2 / 10000000L) % 60L), 2));
//        int n = (int) (num2 % 10000000L);
//        if (n != 0)
//        {
//            builder.Append(".");
//            builder.Append(this.IntToString(n, 7));
//        }
//        return builder.ToString();
//    }

//    /// <summary>Returns a <see cref="T:System.TimeSpan" /> whose value is the negated value of the specified instance.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> with the same numeric value as this instance, but the opposite sign.</returns>
//    /// <param name="t">A <see cref="T:System.TimeSpan" />. </param>
//    /// <exception cref="T:System.OverflowException">The negated value of this instance cannot be represented by a <see cref="T:System.TimeSpan" />; that is, the value of this instance is <see cref="F:System.TimeSpan.MinValue" />. </exception>
//    /// <filterpriority>3</filterpriority>
//    public static TimeSpan operator -(TimeSpan t)
//    {
//        if (t._ticks == MinValue._ticks)
//        {
//            throw new OverflowException(Environment.GetResourceString("Overflow_NegateTwosCompNum"));
//        }
//        return new TimeSpan(-t._ticks);
//    }

//    /// <summary>Subtracts a specified <see cref="T:System.TimeSpan" /> from another specified <see cref="T:System.TimeSpan" />.</summary>
//    /// <returns>A TimeSpan whose value is the result of the value of <paramref name="t1" /> minus the value of <paramref name="t2" />.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
//    /// <filterpriority>3</filterpriority>
//    public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
//    {
//        return t1.Subtract(t2);
//    }

//    /// <summary>Returns the specified instance of <see cref="T:System.TimeSpan" />.</summary>
//    /// <returns>Returns <paramref name="t" />.</returns>
//    /// <param name="t">A <see cref="T:System.TimeSpan" />. </param>
//    /// <filterpriority>3</filterpriority>
//    public static TimeSpan operator +(TimeSpan t)
//    {
//        return t;
//    }

//    /// <summary>Adds two specified <see cref="T:System.TimeSpan" /> instances.</summary>
//    /// <returns>A <see cref="T:System.TimeSpan" /> whose value is the sum of the values of <paramref name="t1" /> and <paramref name="t2" />.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
//    /// <filterpriority>3</filterpriority>
//    public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
//    {
//        return t1.Add(t2);
//    }

//    /// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are equal.</summary>
//    /// <returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are equal; otherwise, false.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <filterpriority>3</filterpriority>
//    public static bool operator ==(TimeSpan t1, TimeSpan t2)
//    {
//        return (t1._ticks == t2._ticks);
//    }

//    /// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are not equal.</summary>
//    /// <returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are not equal; otherwise, false.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <filterpriority>3</filterpriority>
//    public static bool operator !=(TimeSpan t1, TimeSpan t2)
//    {
//        return (t1._ticks != t2._ticks);
//    }

//    /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than another specified <see cref="T:System.TimeSpan" />.</summary>
//    /// <returns>true if the value of <paramref name="t1" /> is less than the value of <paramref name="t2" />; otherwise, false.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <filterpriority>3</filterpriority>
//    public static bool operator <(TimeSpan t1, TimeSpan t2)
//    {
//        return (t1._ticks < t2._ticks);
//    }

//    /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than or equal to another specified <see cref="T:System.TimeSpan" />.</summary>
//    /// <returns>true if the value of <paramref name="t1" /> is less than or equal to the value of <paramref name="t2" />; otherwise, false.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <filterpriority>3</filterpriority>
//    public static bool operator <=(TimeSpan t1, TimeSpan t2)
//    {
//        return (t1._ticks <= t2._ticks);
//    }

//    /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than another specified <see cref="T:System.TimeSpan" />.</summary>
//    /// <returns>true if the value of <paramref name="t1" /> is greater than the value of <paramref name="t2" />; otherwise, false.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <filterpriority>3</filterpriority>
//    public static bool operator >(TimeSpan t1, TimeSpan t2)
//    {
//        return (t1._ticks > t2._ticks);
//    }

//    /// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than or equal to another specified <see cref="T:System.TimeSpan" />.</summary>
//    /// <returns>true if the value of <paramref name="t1" /> is greater than or equal to the value of <paramref name="t2" />; otherwise, false.</returns>
//    /// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
//    /// <param name="t2">A TimeSpan. </param>
//    /// <filterpriority>3</filterpriority>
//    public static bool operator >=(TimeSpan t1, TimeSpan t2)
//    {
//        return (t1._ticks >= t2._ticks);
//    }

//    static TimeSpan()
//    {
//        Zero = new TimeSpan(0L);
//        MaxValue = new TimeSpan(9223372036854775807L);
//        MinValue = new TimeSpan(-9223372036854775808L);
//    }
//    [StructLayout(LayoutKind.Sequential)]
//    private struct StringParser
//    {
//        private string str;
//        private char ch;
//        private int pos;
//        private int len;
//        private ParseError error;
//        internal void NextChar()
//        {
//            if (this.pos < this.len)
//            {
//                this.pos++;
//            }
//            this.ch = (this.pos < this.len) ? this.str[this.pos] : '\0';
//        }

//        internal char NextNonDigit()
//        {
//            for (int i = this.pos; i < this.len; i++)
//            {
//                char ch = this.str[i];
//                if ((ch < '0') || (ch > '9'))
//                {
//                    return ch;
//                }
//            }
//            return '\0';
//        }

//        internal long Parse(string s)
//        {
//            long num;
//            if (this.TryParse(s, out num))
//            {
//                return num;
//            }
//            switch (this.error)
//            {
//                case ParseError.Format:
//                    throw new FormatException(Environment.GetResourceString("Format_InvalidString"));

//                case ParseError.Overflow:
//                    throw new OverflowException(Environment.GetResourceString("Overflow_TimeSpanTooLong"));

//                case ParseError.OverflowHoursMinutesSeconds:
//                    throw new OverflowException(Environment.GetResourceString("Overflow_TimeSpanElementTooLarge"));

//                case ParseError.ArgumentNull:
//                    throw new ArgumentNullException("s");
//            }
//            return 0L;
//        }

//        internal bool TryParse(string s, out long value)
//        {
//            long num;
//            value = 0L;
//            if (s == null)
//            {
//                this.error = ParseError.ArgumentNull;
//                return false;
//            }
//            this.str = s;
//            this.len = s.Length;
//            this.pos = -1;
//            this.NextChar();
//            this.SkipBlanks();
//            bool flag = false;
//            if (this.ch == '-')
//            {
//                flag = true;
//                this.NextChar();
//            }
//            if (this.NextNonDigit() == ':')
//            {
//                if (!this.ParseTime(out num))
//                {
//                    return false;
//                }
//            }
//            else
//            {
//                int num2;
//                if (!this.ParseInt(10675199, out num2))
//                {
//                    return false;
//                }
//                num = num2 * 864000000000L;
//                if (this.ch == '.')
//                {
//                    long num3;
//                    this.NextChar();
//                    if (!this.ParseTime(out num3))
//                    {
//                        return false;
//                    }
//                    num += num3;
//                }
//            }
//            if (flag)
//            {
//                num = -num;
//                if (num > 0L)
//                {
//                    this.error = ParseError.Overflow;
//                    return false;
//                }
//            }
//            else if (num < 0L)
//            {
//                this.error = ParseError.Overflow;
//                return false;
//            }
//            this.SkipBlanks();
//            if (this.pos < this.len)
//            {
//                this.error = ParseError.Format;
//                return false;
//            }
//            value = num;
//            return true;
//        }

//        internal bool ParseInt(int max, out int i)
//        {
//            i = 0;
//            int pos = this.pos;
//            while ((this.ch >= '0') && (this.ch <= '9'))
//            {
//                if ((((long) i) & 4026531840L) != 0L)
//                {
//                    this.error = ParseError.Overflow;
//                    return false;
//                }
//                i = ((i * 10) + this.ch) - 48;
//                if (i < 0)
//                {
//                    this.error = ParseError.Overflow;
//                    return false;
//                }
//                this.NextChar();
//            }
//            if (pos == this.pos)
//            {
//                this.error = ParseError.Format;
//                return false;
//            }
//            if (i > max)
//            {
//                this.error = ParseError.Overflow;
//                return false;
//            }
//            return true;
//        }

//        internal bool ParseTime(out long time)
//        {
//            int num;
//            time = 0L;
//            if (!this.ParseInt(23, out num))
//            {
//                if (this.error == ParseError.Overflow)
//                {
//                    this.error = ParseError.OverflowHoursMinutesSeconds;
//                }
//                return false;
//            }
//            time = num * 36000000000L;
//            if (this.ch != ':')
//            {
//                this.error = ParseError.Format;
//                return false;
//            }
//            this.NextChar();
//            if (!this.ParseInt(59, out num))
//            {
//                if (this.error == ParseError.Overflow)
//                {
//                    this.error = ParseError.OverflowHoursMinutesSeconds;
//                }
//                return false;
//            }
//            time += num * 600000000L;
//            if (this.ch == ':')
//            {
//                this.NextChar();
//                if (this.ch != '.')
//                {
//                    if (!this.ParseInt(59, out num))
//                    {
//                        if (this.error == ParseError.Overflow)
//                        {
//                            this.error = ParseError.OverflowHoursMinutesSeconds;
//                        }
//                        return false;
//                    }
//                    time += num * 10000000L;
//                }
//                if (this.ch == '.')
//                {
//                    this.NextChar();
//                    int num2 = 10000000;
//                    while (((num2 > 1) && (this.ch >= '0')) && (this.ch <= '9'))
//                    {
//                        num2 /= 10;
//                        time += (this.ch - '0') * num2;
//                        this.NextChar();
//                    }
//                }
//            }
//            return true;
//        }

//        internal void SkipBlanks()
//        {
//            while ((this.ch == ' ') || (this.ch == '\t'))
//            {
//                this.NextChar();
//            }
//        }
//        private enum ParseError
//        {
//            ArgumentNull = 4,
//            Format = 1,
//            Overflow = 2,
//            OverflowHoursMinutesSeconds = 3
//        }
//    }
//}

 
 
//}
