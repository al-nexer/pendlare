using Pendlare.Api.Models.Conditions;

namespace Pendlare.Api.Models.Queries
{
    /// <summary>
    /// Generate Trafikverket API requests for information about Train messages.
    /// </summary>
    public static class StationMessages
    {
        /// <summary>
        /// Inquire about the messages of a station.
        /// </summary>
        /// <param name="LocationSignature">the Location Signature of a train station</param>
        /// <returns>An Api query</returns>
        public static ApiQuery MessageList(string LocationSignature)
        {
            return new ApiQuery()
            {
                ObjectType = "TrainMessage",
                Filters = new List<QueryFilter>()
                {
                    new EqualsCondition("AffectedLocation",LocationSignature),
                },
            };
        }
    }
}
