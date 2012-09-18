using System;

namespace prep.utility
{
    public static class RangeExtensions
    {
        // range.include.start(x)
        public static Range<T> StartsWith<T>(this Range<T> range, T start) where T : IComparable<T>
        {
            range.Start = start;
            return range;
        }

        public static Range<T> EndsWith<T>(this Range<T> range, T end) where T : IComparable<T>
        {
            range.End = end;
            return range;
        }
    }

    
    

}