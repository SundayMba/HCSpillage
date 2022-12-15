using System.Globalization;

namespace HCSpillage.Time
{
    public static class TimeConversion
    {
        public static string GetFormattedTime()
        {
            var WestAfricaTime = TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time");
            var localTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, WestAfricaTime);
            var formattedTime = localTime.ToString("h:mm tt", CultureInfo.InvariantCulture);
            return formattedTime;
        }
    }
}
