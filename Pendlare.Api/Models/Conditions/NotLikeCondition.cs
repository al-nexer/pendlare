namespace Pendlare.Api.Models.Conditions
{
    public class NotLikeCondition : GenericCondition
    {
        public NotLikeCondition() : base() { }
        public NotLikeCondition(string name, string value) : base(name, value) { }
        public NotLikeCondition(string name, int minutes) : base(name, minutes) { }
    }
}
