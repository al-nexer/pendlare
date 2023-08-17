using Pendlare.Api.Models.Conditions;

namespace Pendlare.Api.Models.Queries
{
    /// <summary>
    /// Generate Trafikverket API requests for information about train stations
    /// </summary>
    public static class StationList
    {
        /// <summary>
        /// Query about all active stations
        /// </summary>
        /// <returns>An Api query</returns>
        public static ApiQuery AllActiveStations()
        {
            return new ApiQuery()
            {
                ObjectType = "TrainStation",
                OrderBy = "LocationSignature ASC",
                Filters = new List<QueryFilter>()
                {
                    new EqualsCondition("Advertised","true"),
                    new EqualsCondition("Prognosticated","true"),
                },
            };
        }

        /// <summary>
        /// Query about all active Swedish stations
        /// </summary>
        /// <returns>An Api query</returns>
        public static ApiQuery AllActiveSwedenStations()
        {
            ApiQuery All = AllActiveStations();
            All.Filters.Add(new EqualsCondition("CountryCode", "SE"));
            return All;
        }
    }
}
