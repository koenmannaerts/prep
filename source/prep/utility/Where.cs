namespace prep.utility
{
  public class Where<ItemToMatch>
  {
    public static MatchCreationExtensionPoint<ItemToMatch, PropertyType> has_a<PropertyType>(
      PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      return new MatchCreationExtensionPoint<ItemToMatch, PropertyType>(accessor);
    }
  }
}