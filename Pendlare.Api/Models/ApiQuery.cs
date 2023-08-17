using System.Xml.Serialization;
using Pendlare.Api.Models.Conditions;
namespace Pendlare.Api.Models
{
    /// <summary>
    /// A trafikverket API query.
    /// Note that the API accepts multiple queries per request.
    /// Reference: https://api.trafikinfo.trafikverket.se/API/TheRequest
    /// </summary>
    [XmlRoot("QUERY")]
    public class ApiQuery
    {
        [XmlAttribute("objecttype")]
        public String? ObjectType { get; set; }

        [XmlAttribute("id")]
        public String? Id { get; set; }

        [XmlAttribute("limit")]
        public String? Limit { get; set; }

        [XmlAttribute("orderby")]
        public String? OrderBy { get; set; }

        [XmlAttribute("count")]
        public String? Count { get; set; }

        [XmlAttribute("lastmodified")]
        public String? LastModified { get; set; }

        [XmlAttribute("skip")]
        public String? Skip { get; set; }

        [XmlAttribute("includedeletedobjects")]
        public String? includedeletedobjects { get; set; }

        [XmlArray("FILTER")]
        [XmlArrayItem("EQ", typeof(EqualsCondition))]
        [XmlArrayItem("EXISTS", typeof(ExistsCondition))]
        [XmlArrayItem("GT", typeof(GreaterThanCondition))]
        [XmlArrayItem("GTE", typeof(GreaterThanOrEualsCondition))]
        [XmlArrayItem("LT", typeof(LessThanCondition))]
        [XmlArrayItem("LTE", typeof(LessThanOrEqualsCondition))]
        [XmlArrayItem("LIKE", typeof(LikeCondition))]
        [XmlArrayItem("NOTLIKE", typeof(NotLikeCondition))]
        [XmlArrayItem("IN", typeof(InCondition))]
        [XmlArrayItem("NOTIN", typeof(NotInCondition))]
        [XmlArrayItem("WITHIN", typeof(WithinCondition))]
        [XmlArrayItem("AND", typeof(AndCondition))]
        [XmlArrayItem("OR", typeof(OrCondition))]
        [XmlArrayItem("ELEMENTMATCH", typeof(ElementMatchCondition))]
        public List<QueryFilter>? Filters { get; set; }

    }
}
