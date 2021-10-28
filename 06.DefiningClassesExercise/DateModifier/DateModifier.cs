using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static double GetDifferenceOfTwoDates(DateTime date1, DateTime date2)
        {
            int compareDates = date1.CompareTo(date2);        
            if (compareDates == -1)
            {
                return (date2 - date1).TotalDays;
            }

            if (compareDates == 1)
            {
                return (date1 - date2).TotalDays;
            }

            return 0;
        }
    }
}
