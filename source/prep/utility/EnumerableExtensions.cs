﻿using System;
using System.Collections.Generic;
using prep.collections;

namespace prep.utility
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
    {
      foreach (var item in items)
        yield return item;
    }

    public static IEnumerable<ItemToFilter> all_items_matching<ItemToFilter>(this IEnumerable<ItemToFilter> items,
                                                                             IMatchAn<ItemToFilter> specification)
    {
      return items.all_items_matching(specification.matches);
    }

    static IEnumerable<ItemToFilter> all_items_matching<ItemToFilter>(this IEnumerable<ItemToFilter> items,
                                                                             Condition<ItemToFilter> filter)
    {
      foreach (var item in items)
        if (filter(item))
          yield return item;
    }

      //public static IProvideAccessToCreateMatchers<Movie, DateTime> where()
      //{
      //    return null;
      //}
  }
}