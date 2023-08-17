namespace Pendlare.Api.Models.Conditions
{
    public class AndCondition : GenericConditionGroup
    {
        public AndCondition() : base() { }
        public AndCondition(List<QueryFilter> children) : base(children) { }
    }
}
