using System;

namespace prep.utility
{
  public class InclusiveRange<T> : Range<T> where T : IComparable<T>
  {
    T end;
    T start;

    public InclusiveRange(T end, T start)
    {
      this.end = end;
      this.start = start;
    }

    public bool contains(T item)
    {
      return item.CompareTo(start) >= 0 && item.CompareTo(end) <= 0;
    }
  }
}