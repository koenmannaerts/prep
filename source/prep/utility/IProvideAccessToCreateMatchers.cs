namespace prep.utility
{
  public interface IProvideAccessToCreateMatchers<ItemToMatch, PropertyType>
  {
    IMatchAn<ItemToMatch> create_match_using(IMatchAn<PropertyType> condition);
  }
}