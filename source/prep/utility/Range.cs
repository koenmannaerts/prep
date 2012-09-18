using System;

namespace prep.utility
{
  public interface Range<T> where T : IComparable<T>
  {
    bool contains(T item);
    T Start { get; set; }
    T End { get; set; }
  }
}