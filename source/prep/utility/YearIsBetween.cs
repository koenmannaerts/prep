using System;

namespace prep.utility
{
    public class YearIsBetween : IMatchAn<DateTime> 
    {
        int start, end;

        public YearIsBetween(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public bool matches(DateTime item)
        {
            int year = item.Year;
            return year.CompareTo(start) >= 0 && year.CompareTo(end) <= 0;
        }
    }
}