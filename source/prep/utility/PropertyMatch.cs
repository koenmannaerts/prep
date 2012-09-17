namespace prep.utility
{
  public class PropertyMatch<ItemToMatch,PropertyType> : IMatchAn<ItemToMatch>
  {
    PropertyAccessor<ItemToMatch, PropertyType> accessor;
    IMatchAn<PropertyType> raw_criteria;

    public PropertyMatch(PropertyAccessor<ItemToMatch, PropertyType> accessor, IMatchAn<PropertyType> raw_criteria)
    {
      this.accessor = accessor;
      this.raw_criteria = raw_criteria;
    }

    public bool matches(ItemToMatch item)
    {
      return raw_criteria.matches(accessor(item));
    }
  }
}