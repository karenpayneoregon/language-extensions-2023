namespace UtilitiesLibrary;
internal static class DateTimeExtensions
{
    /// <summary>
    /// Deconstruct DateTime instance to day, month, year
    /// </summary>
    /// <param name="date">date instance</param>
    /// <param name="day">day part</param>
    /// <param name="month">month part</param>
    /// <param name="year">year part</param>
    public static void Deconstruct(this DateTime date, out int day, out int month, out int year) =>
        (day, month, year) = (date.Day, date.Month, date.Year);

    public static bool IsWeekend(this DateTime sender)
        => sender.DayOfWeek is DayOfWeek.Sunday or DayOfWeek.Saturday;

    public static bool IsWeekDay(this DateTime sender)
        => !sender.IsWeekend();


}
