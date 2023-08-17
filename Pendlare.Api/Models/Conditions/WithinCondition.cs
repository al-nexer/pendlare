using System.Xml.Serialization;

namespace Pendlare.Api.Models.Conditions
{
    public class WithinCondition : GenericCondition
    {
        [XmlAttribute("shape")]
        public string Shape { get; set; }
    }
}
