using System;
using System.Globalization;

namespace xif.Lib
{
    static class DateTimeExtensions
    {
        public static string MonthName(this DateTime dateTime) => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);

    }
}
