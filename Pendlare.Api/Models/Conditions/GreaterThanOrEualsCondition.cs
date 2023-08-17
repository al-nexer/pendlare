namespace Pendlare.Api.Models.Conditions
{
    public class GreaterThanOrEualsCondition : GenericCondition
    {
        public GreaterThanOrEualsCondition() : base() { }
        public GreaterThanOrEualsCondition(string name, string value) : base(name, value) { }
        public GreaterThanOrEualsCondition(string name, int minutes) : base(name, minutes) { }
    }
}
