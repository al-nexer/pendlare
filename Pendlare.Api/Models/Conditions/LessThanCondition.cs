namespace Pendlare.Api.Models.Conditions
{
    public class LessThanCondition : GenericCondition
    {
        public LessThanCondition() : base() { }
        public LessThanCondition(string name, string value) : base(name, value) { }
        public LessThanCondition(string name, int minutes) : base(name, minutes) { }
    }
}
