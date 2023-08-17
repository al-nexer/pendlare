using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pendlare.Api.Models.TrafficInfo.Rails
{
    public class TrafficImpact
    {

        [JsonProperty]
        public List<string>? AffectedLocation { get; set; }

        [JsonProperty]
        public List<string>? FromLocation { get; set; }

        [JsonProperty]
        public List<string>? ToLocation { get; set; }
    }
}
