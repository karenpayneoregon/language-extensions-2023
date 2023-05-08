namespace UtilitiesLibrary;
public static class DateOnlyExtensions
{
    /// <summary>
    /// Deconstruct DateOnly instance to day, month, year
    /// </summary>
    /// <param name="date">instance</param>
    /// <param name="day">day part</param>
    /// <param name="month">month part</param>
    /// <param name="year">year part</param>
    public static void Deconstruct(this DateOnly date, out int day, out int month, out int year) =>
        (day, month, year) = (date.Day, date.Month, date.Year);



    /// <summary>
    /// Return if the DateOnly is a weekend
    /// </summary>
    /// <param name="sender">date only instance</param>
    /// <returns>true if weekend, false if week day</returns>
    public static bool IsWeekend(this DateOnly sender)
        => sender.DayOfWeek is DayOfWeek.Sunday or DayOfWeek.Saturday;

    /// <summary>
    /// Return if the DateOnly is a week day
    /// </summary>
    /// <param name="sender">date only instance</param>
    /// <returns>true if weekday, false if weekend</returns>
    public static bool IsWeekday(this DateOnly sender)
        => sender.DayOfWeek is DayOfWeek.Monday or 
            DayOfWeek.Tuesday or 
            DayOfWeek.Wednesday or 
            DayOfWeek.Thursday or 
            DayOfWeek.Friday;
}
