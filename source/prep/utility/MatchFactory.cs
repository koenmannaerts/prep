namespace prep.utility
{
  public class MatchFactory<ItemToMatch, PropertyType> : ICreateMatchers<ItemToMatch, PropertyType>
  {
    PropertyAccessor<ItemToMatch, PropertyType> accessor;

    public MatchFactory(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<ItemToMatch> equal_to(PropertyType value)
    {
      return equal_to_any(value);
    }

    public IMatchAn<ItemToMatch> equal_to_any(params PropertyType[] values)
    {
      return create_using(new EqualToAny<PropertyType>(values));
    }

    public IMatchAn<ItemToMatch> create_using(IMatchAn<PropertyType> condition)
    {
      return new PropertyMatch<ItemToMatch, PropertyType>(accessor,
                                                          condition); 
    }

    public IMatchAn<ItemToMatch> not_equal_to(PropertyType value)
    {
      return new NegatingMatch<ItemToMatch>(equal_to(value));
    }
  }
}