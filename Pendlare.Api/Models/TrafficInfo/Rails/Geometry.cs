using Newtonsoft.Json;

namespace Pendlare.Api.Models.TrafficInfo.Rails
{
    public class Geometry
    {
        [JsonProperty]
        public string? SWEREF99TM { get; set; }

        [JsonProperty]
        public string? WGS84 { get; set; }

    }
}
