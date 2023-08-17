using System.Xml.Serialization;

namespace Pendlare.Api.Models.Conditions
{

    [XmlRoot("EQ")]
    [Serializable]
    public class EqualsCondition : GenericCondition
    {
        public EqualsCondition() : base() { }
        public EqualsCondition(string name, string value) : base(name, value) { }
        public EqualsCondition(string name, int minutes) : base(name, minutes) { }

    }
}
