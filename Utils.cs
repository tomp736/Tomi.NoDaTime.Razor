using NodaTime;
using System;

namespace Tomi.NoDaTime.Razor
{
    public static class NoDaUtils
    {

        public static LocalTime ToLocalTime(this DateTime dateTime)
        {
            return new LocalTime(dateTime.Hour, dateTime.Minute, dateTime.Second);
        }

        public static DateTime ToDateTime(this LocalTime localTime)
        {
            return new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day, localTime.Hour, localTime.Minute, localTime.Second);
        }

        public static LocalDate ToLocalDate(this DateTime dateTime)
        {
            return LocalDate.FromDateTime(dateTime);
        }

        public static DateTime ToDateTime(this LocalDate localDate)
        {
            return localDate.ToDateTimeUnspecified();
        }
    }
}
