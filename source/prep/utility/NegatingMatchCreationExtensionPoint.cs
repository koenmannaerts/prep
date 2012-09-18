namespace prep.utility
{
  public class NegatingMatchCreationExtensionPoint<ItemToMatch,PropertyType> : IProvideAccessToCreateMatchers<ItemToMatch,PropertyType>
  {
    IProvideAccessToCreateMatchers<ItemToMatch, PropertyType> original;

    public NegatingMatchCreationExtensionPoint(IProvideAccessToCreateMatchers<ItemToMatch, PropertyType> original)
    {
      this.original = original;
    }

    public IMatchAn<ItemToMatch> create_match_using(IMatchAn<PropertyType> condition)
    {
      return original.create_match_using(condition).not();
    }
  }
}