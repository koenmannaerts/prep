using System;

namespace prep.utility
{
  public static class MatchCreationExtensions
  {
    public static IMatchAn<ItemToMatch> equal_to<ItemToMatch,PropertyType>(this IProvideAccessToCreateMatchers<ItemToMatch,PropertyType> extension_point,PropertyType value)
    {
      return equal_to_any(extension_point,value);
    }

    public static IMatchAn<ItemToMatch> equal_to_any<ItemToMatch,PropertyType>(this IProvideAccessToCreateMatchers<ItemToMatch,PropertyType> extension_point,params PropertyType[] values)
    {
      return create_using(extension_point,new EqualToAny<PropertyType>(values));
    }

    public static IMatchAn<ItemToMatch> create_using<ItemToMatch,PropertyType>(this IProvideAccessToCreateMatchers<ItemToMatch,PropertyType> extension_point,IMatchAn<PropertyType> condition)
    {
      return extension_point.create_match_using(condition);
    }

    public static IMatchAn<ItemToMatch> not_equal_to<ItemToMatch,PropertyType>(this IProvideAccessToCreateMatchers<ItemToMatch,PropertyType> extension_point,PropertyType value)
    {
      return new NegatingMatch<ItemToMatch>(equal_to(extension_point,value));
    }

    public static IMatchAn<ItemToMatch> greater_than<ItemToMatch,PropertyType>(this IProvideAccessToCreateMatchers<ItemToMatch,PropertyType> extension_point,PropertyType value) where PropertyType : IComparable<PropertyType>
    {
      return create_using(extension_point,new FallsInRange<PropertyType>(new RangeWithNoUpperBound<PropertyType>(value)));
    }

    public static IMatchAn<ItemToMatch> between<ItemToMatch,PropertyType>(this IProvideAccessToCreateMatchers<ItemToMatch,PropertyType> extension_point,PropertyType start, PropertyType end) where PropertyType : IComparable<PropertyType>
    {
      return
        create_using(extension_point,new FallsInRange<PropertyType>(new InclusiveRange<PropertyType>(start, end)));
    }
  }
}
