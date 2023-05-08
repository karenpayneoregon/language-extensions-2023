namespace UtilitiesLibrary;
public static class DayOfWeekExtensions
{
    public static bool IsWeekDay(this DayOfWeek sender) =>
        sender is DayOfWeek.Monday or
            DayOfWeek.Tuesday or
            DayOfWeek.Wednesday or
            DayOfWeek.Thursday or
            DayOfWeek.Friday;

    public static bool IsWeekend(this DayOfWeek sender)
        => !sender.IsWeekDay();
}
