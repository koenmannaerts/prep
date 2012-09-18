namespace prep.utility
{
  public class MatchCreationExtensionPoint<ItemToMatch, PropertyType> :
    IProvideAccessToCreateMatchers<ItemToMatch, PropertyType>
  {
    PropertyAccessor<ItemToMatch, PropertyType> accessor;

    public IProvideAccessToCreateMatchers<ItemToMatch, PropertyType> not
    {
      get { return new NegatingMatchCreationExtensionPoint<ItemToMatch, PropertyType>(this);}
    }

    public IMatchAn<ItemToMatch> create_match_using(IMatchAn<PropertyType> condition)
    {
      return new PropertyMatch<ItemToMatch, PropertyType>(accessor, condition);
    }

    public MatchCreationExtensionPoint(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }
  }
}