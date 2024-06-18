using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class DateTimeUtils
    {
        public DateTime AddDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        public DateTime SubtractDays(DateTime date, int days)
        {
            return date.AddDays(-days);
        }

        public int DaysBetween(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Days;
        }
    }
}
