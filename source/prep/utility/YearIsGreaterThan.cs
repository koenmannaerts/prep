using System;

namespace prep.utility
{
    public class YearIsGreaterThan : IMatchAn<DateTime> 
    {
        readonly int _start;

        public YearIsGreaterThan(int start)
        {
            this._start = start;
        }

        public bool matches(DateTime item)
        {
            return item.Year.CompareTo(_start) > 0;
        }
    }
}