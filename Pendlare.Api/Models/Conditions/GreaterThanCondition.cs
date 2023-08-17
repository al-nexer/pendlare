
namespace Pendlare.Api.Models.Conditions
{
    public class GreaterThanCondition : GenericCondition
    {
        public GreaterThanCondition() : base() { }
        public GreaterThanCondition(string name, string value) : base(name, value) { }
        public GreaterThanCondition(string name, int minutes) : base(name, minutes) { }
    }
}
