using Newtonsoft.Json;
using Pendlare.Api.Models.TrafficInfo.Rails;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pendlare.Api.Models.Response
{
    public class ResultModel
    {
        [JsonProperty]
        public List<TrainStation>? TrainStation;

        [JsonProperty]
        public List<TrainAnnouncement>? TrainAnnouncement;

        [JsonProperty]
        public List<TrainMessage>? TrainMessage;
    }
}
