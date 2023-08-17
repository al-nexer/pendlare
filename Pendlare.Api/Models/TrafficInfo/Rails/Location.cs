using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pendlare.Api.Models.TrafficInfo.Rails
{
    public class Location
    {

        [JsonProperty]
        public string? LocationName { get; set; }

        [JsonProperty]
        public int Order { get; set; }

        [JsonProperty]
        public int Priority { get; set; }
    }
}
