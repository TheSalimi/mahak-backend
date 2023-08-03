using System.Globalization;

namespace mahakBackend.Shared.Date
{
    abstract public class HijriDateConverter
    {
        static bool CheckGregorian(DateTime date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();

            int year = persianCalendar.GetYear(date);
            return year < 1000;
        }

        static DateTime ConvertToSolarHijri(DateTime gregorianDate)
        {
            PersianCalendar persianCalendar = new PersianCalendar();

            int year = persianCalendar.GetYear(gregorianDate);
            int month = persianCalendar.GetMonth(gregorianDate);
            int day = persianCalendar.GetDayOfMonth(gregorianDate);

            DateTime solarHijriDate = persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);

            return solarHijriDate;
        }

        public static DateTime returnHijriDate(DateTime date)
        {
            bool isGregorian = CheckGregorian(date);

            if (isGregorian)
            {
                return ConvertToSolarHijri(date);
            }
            else
            {
                return date;
            }
        }
    }
}