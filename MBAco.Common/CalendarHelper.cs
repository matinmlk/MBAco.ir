using System;
using System.Globalization;

namespace Shahmat.Common
{
    public static class CalendarHelper
    {
        public static string ConvertPersianToJulian(string persianDate)
        {
            try
            {
                int year = int.Parse(persianDate.Substring(0, 4));
                int month = int.Parse(persianDate.Substring(5, 2));
                int day = int.Parse(persianDate.Substring(8, 2));
                System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
                DateTime dt = p.ToDateTime(year, month, day, 0, 0, 0, 0);
                string xyear = dt.Year.ToString();
                string xmonth = dt.Month.ToString();
                if (xmonth.ToString().Length == 1)
                {
                    xmonth = "0" + xmonth;
                }
                string xday = dt.Day.ToString();
                if (xday.ToString().Length == 1)
                {
                    xday = "0" + xday;
                }
                return xyear + "/" + xmonth + "/" + xday;
            }
            catch (Exception ex)
            {
                //throw new Exception("Error, Convert failed cause of :" + ex.Message);
                return string.Empty;
            }
        }

        public static DateTime ConvertPersianToJulianDateTime(string persianDate)
        {
            try
            {
                return DateTime.Parse(ConvertPersianToJulian(persianDate), new CultureInfo("en-US", false));
            }
            catch (Exception ex)
            {
                throw new Exception("Error, Convert failed cause of :" + ex.Message);
            }
        }

        public static string ConvertJulianToPersian(string julianDate)
        {
            try
            {
                int year = int.Parse(julianDate.Substring(0, 4));
                int month = int.Parse(julianDate.Substring(5, 2));
                int day = int.Parse(julianDate.Substring(8, 2));
                System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
                DateTime dt = new DateTime(year, month, day);
                string xyear = p.GetYear(dt).ToString();
                string xmonth = p.GetMonth(dt).ToString();
                if (xmonth.ToString().Length == 1)
                {
                    xmonth = "0" + xmonth;
                }
                string xday = p.GetDayOfMonth(dt).ToString();
                if (xday.ToString().Length == 1)
                {
                    xday = "0" + xday;
                }
                return xyear + "/" + xmonth + "/" + xday;
            }
            catch (Exception ex)
            {
                //throw new Exception("Error, Convert failed cause of :" + ex.Message);
                return string.Empty;
            }
        }

        public static string ConvertJulianDateTimeToPersian(DateTime julianDate)
        {
            try
            {
                string xmonth = julianDate.Month.ToString();
                if (xmonth.ToString().Length == 1)
                {
                    xmonth = "0" + xmonth;
                }
                string xday = julianDate.Day.ToString();
                if (xday.ToString().Length == 1)
                {
                    xday = "0" + xday;
                }
                return ConvertJulianToPersian(julianDate.Year.ToString() + "/" + xmonth + "/" + xday);
            }
            catch (Exception ex)
            {
                //throw new Exception("Error, Convert failed cause of :" + ex.Message);
                return string.Empty;
            }
        }

        public static string GetTodayPersianName()
        {
            string today = System.DateTime.Now.DayOfWeek.ToString();
            switch (today.ToLower())
            {
                case "saturday":
                {
                    today = "شنبه";
                    break;
                }
                case "sunday":
                {
                    today = "یکشنبه";
                    break;
                }
                case "monday":
                {
                    today = "دوشنبه";
                    break;
                }
                case "tuesday":
                {
                    today = "سه شنبه";
                    break;
                }
                case "wednesday":
                {
                    today = "چهارشنبه";
                    break;
                }
                case "thursday":
                {
                    today = "پنجشنبه";
                    break;
                }
                case "friday":
                {
                    today = "جمعه";
                    break;
                }
            }
            return today;
        }

        public static string GetTodayJulianName()
        {
            string today = System.DateTime.Now.DayOfWeek.ToString();
            return today;
        }
    }
}
