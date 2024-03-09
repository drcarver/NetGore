using System.Diagnostics;

namespace NetGore.Features.GameTime;

/// <summary>
/// A structure containing the virtual game time.
/// </summary>
public struct GameDateTime
{
    private static readonly GameTimeSettings _gameTimeSettings = GameTimeSettings.Instance;
    private static TimeSpan _serverTimeOffset;

    /// <summary>
    /// The day.
    /// </summary>
    private readonly byte _day;

    /// <summary>
    /// The hour.
    /// </summary>
    private readonly byte _hour;

    /// <summary>
    /// The minute.
    /// </summary>
    private readonly byte _minute;

    /// <summary>
    /// The month.
    /// </summary>
    private readonly byte _month;

    /// <summary>
    /// The year.
    /// </summary>
    private readonly ushort _year;

    /// <summary>
    /// Initializes the <see cref="GameDateTime"/> struct.
    /// </summary>
    static GameDateTime()
    {
        MinutesPerHour = 60;
        DaysPerMonth = 30;
        HoursPerDay = 24;
        MonthsPerYear = 12;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GameDateTime"/> struct.
    /// </summary>
    /// <param name="totalMinutes">The total number of real-world minutes that have elapsed since the
    /// <see cref="GameTimeSettings.BaseTime"/>.</param>
    public GameDateTime(double totalMinutes)
    {
        // Convert the total real-world minutes to total game-world minutes
        totalMinutes = totalMinutes * _gameTimeSettings.GameTimeMultiplier;

        // Years
        var year = (int)(totalMinutes / MinutesPerYear);
        totalMinutes -= MinutesPerYear * year;

        // Months
        var month = (int)(totalMinutes / MinutesPerMonth);
        totalMinutes -= MinutesPerMonth * month;

        // Days
        var day = (int)(totalMinutes / MinutesPerDay);
        totalMinutes -= MinutesPerDay * day;

        // Hours
        var hour = (int)(totalMinutes / MinutesPerHour);
        totalMinutes -= MinutesPerHour * hour;

        // Store in the appropriate member variables
        Debug.Assert(year <= ushort.MaxValue);
        _year = (ushort)year;

        Debug.Assert(month <= byte.MaxValue);
        _month = (byte)month;

        Debug.Assert(day <= byte.MaxValue);
        _day = (byte)day;

        Debug.Assert(hour <= byte.MaxValue);
        _hour = (byte)hour;

        Debug.Assert(totalMinutes <= byte.MaxValue);
        _minute = (byte)totalMinutes;
    }

    /// <summary>
    /// Gets or sets the base year value in game-time. That is, when the total elapsed game time is 0 minutes,
    /// this is what the year will be.
    /// </summary>
    public static int BaseYear { get; set; }

    /// <summary>
    /// Gets the day of the month in game-time.
    /// </summary>
    public int Day => _day;

    /// <summary>
    /// Gets or sets the number of days per month in game-time.
    /// </summary>
    public static uint DaysPerMonth { get; set; }

    /// <summary>
    /// Gets the hour in game-time.
    /// </summary>
    public int Hour => _hour;

    /// <summary>
    /// Gets or sets the number of hours per day in game-time.
    /// </summary>
    public static uint HoursPerDay { get; set; }

    /// <summary>
    /// Gets the minute in game-time.
    /// </summary>
    public int Minute => _minute;

    /// <summary>
    /// Gets the number of minutes per day in game-time.
    /// </summary>
    public static uint MinutesPerDay => MinutesPerHour * HoursPerDay;

    /// <summary>
    /// Gets the number of minutes per hour in game-time.
    /// </summary>
    public static uint MinutesPerHour { get; set; }

    /// <summary>
    /// Gets the number of minutes per month in game-time.
    /// </summary>
    public static uint MinutesPerMonth => MinutesPerHour * HoursPerDay * DaysPerMonth;

    /// <summary>
    /// Gets the number of minutes per year in game-time.
    /// </summary>
    public static uint MinutesPerYear => MinutesPerHour * HoursPerDay * DaysPerMonth * MonthsPerYear;

    /// <summary>
    /// Gets the month in game-time.
    /// </summary>
    public uint Month => _month;

    /// <summary>
    /// Gets or sets the number of months per year in game-time.
    /// </summary>
    public static uint MonthsPerYear { get; set; }

    /// <summary>
    /// Gets the <see cref="GameDateTime"/> for the current time.
    /// </summary>
    public static GameDateTime Now => FromDateTime(DateTime.Now);

    /// <summary>
    /// Gets the difference between the client and server's real times. This should only be used on the
    /// clients. On the server, this value should remain the default, which is a <see cref="TimeSpan"/> of 0.
    /// </summary>
    public static TimeSpan ServerTimeOffset => _serverTimeOffset;

    /// <summary>
    /// Gets the total number of game-time minutes for this <see cref="GameDateTime"/>.
    /// </summary>
    public uint TotalMinutes
    {
        get
        {
            long ret = _year * MinutesPerYear;
            ret += Month * MinutesPerMonth;
            ret += Hour * MinutesPerHour;
            ret += Day * MinutesPerDay;
            ret += Minute;

            Debug.Assert(ret <= uint.MaxValue);
            return (uint)ret;
        }
    }

    /// <summary>
    /// Gets the total number of real-world minutes for this <see cref="GameDateTime"/>.
    /// </summary>
    public double TotalRealMinutes => TotalMinutes / _gameTimeSettings.GameTimeMultiplier;

    /// <summary>
    /// Gets the year in game-time.
    /// </summary>
    public int Year => _year + BaseYear;

    /// <summary>
    /// Determines if this <see cref="GameDateTime"/> is equal to another <see cref="GameDateTime"/>.
    /// </summary>
    /// <param name="other">The other <see cref="GameDateTime"/>.</param>
    /// <returns>True if this <see cref="GameDateTime"/> is equal to the <paramref name="other"/>; otherwise false.</returns>
    public readonly bool Equals(GameDateTime other) =>
            other._day == _day 
        &&  other._hour == _hour 
        &&  other._minute == _minute 
        &&  other._month == _month 
        &&  other._year == _year;

    /// <summary>
    /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
    /// </summary>
    /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
    /// <returns>
    /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
    /// </returns>
    public override readonly bool Equals(object obj) => obj is GameDateTime && this == (GameDateTime)obj;

    /// <summary>
    /// Gets a <see cref="GameDateTime"/> for a <see cref="DateTime"/>.
    /// </summary>
    /// <param name="realDateTime">The <see cref="DateTime"/> for the real local time for this system.</param>
    /// <returns>The <see cref="GameDateTime"/> for the <paramref name="realDateTime"/>.</returns>
    public static GameDateTime FromDateTime(DateTime realDateTime)
    {
        var realTimeDiff = realDateTime - _gameTimeSettings.BaseTime - ServerTimeOffset;
        return new GameDateTime(realTimeDiff.TotalMinutes);
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
    /// </returns>
    public override readonly int GetHashCode()
    {
        unchecked
        {
            var result = _day.GetHashCode();
            result = (result * 397) ^ _hour.GetHashCode();
            result = (result * 397) ^ _minute.GetHashCode();
            result = (result * 397) ^ _month.GetHashCode();
            result = (result * 397) ^ _year.GetHashCode();
            return result;
        }
    }

    /// <summary>
    /// Sets the <see cref="GameDateTime.ServerTimeOffset"/> using the specified <paramref name="serverTime"/>.
    /// </summary>
    /// <param name="serverTime">The current time on the server.</param>
    public static void SetServerTimeOffset(DateTime serverTime) => _serverTimeOffset = DateTime.Now - serverTime;

    /// <summary>
    /// Returns a <see cref="System.String"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String"/> that represents this instance.
    /// </returns>
    public override string ToString() => string.Format("Day {0} of month {1} of year {2}; {3}:{4:00}", Month, Day, Year, Hour, Minute);

    /// <summary>
    /// Implements the operator less-than.
    /// </summary>
    /// <param name="l">The left-side argument.</param>
    /// <param name="r">The right-side argument.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator <(GameDateTime l, GameDateTime r) => l.TotalMinutes < r.TotalMinutes;

    /// <summary>
    /// Implements the operator greater-than.
    /// </summary>
    /// <param name="l">The left-side argument.</param>
    /// <param name="r">The right-side argument.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator >(GameDateTime l, GameDateTime r) => l.TotalMinutes > r.TotalMinutes;

    /// <summary>
    /// Implements the operator less-than or equal to.
    /// </summary>
    /// <param name="l">The left-side argument.</param>
    /// <param name="r">The right-side argument.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator <=(GameDateTime l, GameDateTime r) => l.TotalMinutes <= r.TotalMinutes;

    /// <summary>
    /// Implements the operator greater-than or equal to.
    /// </summary>
    /// <param name="l">The left-side argument.</param>
    /// <param name="r">The right-side argument.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator >=(GameDateTime l, GameDateTime r) => l.TotalMinutes >= r.TotalMinutes;

    /// <summary>
    /// Implements the operator ==.
    /// </summary>
    /// <param name="l">The left-side argument.</param>
    /// <param name="r">The right-side argument.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(GameDateTime l, GameDateTime r) => l.Equals(r);

    /// <summary>
    /// Implements the operator !=.
    /// </summary>
    /// <param name="l">The left-side argument.</param>
    /// <param name="r">The right-side argument.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(GameDateTime l, GameDateTime r) => !(l == r);

    /// <summary>
    /// Implements the operator -.
    /// </summary>
    /// <param name="l">The left-side argument.</param>
    /// <param name="r">The right-side argument.</param>
    /// <returns>The result of the operator.</returns>
    public static GameDateTime operator -(GameDateTime l, GameDateTime r) => new GameDateTime(l.TotalRealMinutes - r.TotalRealMinutes);

    /// <summary>
    /// Implements the operator +.
    /// </summary>
    /// <param name="l">The left-side argument.</param>
    /// <param name="r">The right-side argument.</param>
    /// <returns>The result of the operator.</returns>
    public static GameDateTime operator +(GameDateTime l, GameDateTime r) => new GameDateTime(l.TotalRealMinutes + r.TotalRealMinutes);
}