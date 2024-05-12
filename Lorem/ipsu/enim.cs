// Represents the number of seconds in a time unit
public static class TimeConstants
{
    public const int SecondsPerMinute = 60;
    public const int MinutesPerHour = 60;
    public const int HoursPerDay = 24;

    // Delay between days in seconds
    public const int DelayBetweenDaysInSeconds = SecondsPerMinute * MinutesPerHour * HoursPerDay;
}
