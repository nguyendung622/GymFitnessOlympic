using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Util
{
    public static class DateTimeUtil
    {
        public static string dateToString(DateTime date, string format = "{0:dd/MM/yyyy}") {
            return string.Format(format, date);
        }

        public static string timeToString(TimeSpan sp)
        {
            return sp.Hours + ":" + sp.Minutes;
        }

        public static DateTime StartOfDay(this DateTime theDate)
        {
            return theDate.Date;
        }

        public static DateTime EndOfDay(this DateTime theDate)
        {
            return theDate.Date.AddDays(1).AddTicks(-1);
        }
    }
}
