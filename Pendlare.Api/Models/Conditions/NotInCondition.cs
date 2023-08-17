namespace Pendlare.Api.Models.Conditions
{
    public class NotInCondition : GenericCondition
    {
        public NotInCondition() : base() { }
        public NotInCondition(string name, string value) : base(name, value) { }
        public NotInCondition(string name, int minutes) : base(name, minutes) { }
    }
}
