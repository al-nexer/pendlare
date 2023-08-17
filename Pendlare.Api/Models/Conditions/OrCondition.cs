namespace Pendlare.Api.Models.Conditions
{
    public class OrCondition : GenericConditionGroup
    {
        public OrCondition() : base() { }
        public OrCondition(List<QueryFilter> children) : base(children) { }
    }
}
