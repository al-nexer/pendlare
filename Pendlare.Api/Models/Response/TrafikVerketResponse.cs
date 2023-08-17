using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pendlare.Api.Models.Response
{
    public class TrafikVerketResponse
    {
        [JsonProperty]
        public ResponseModel? RESPONSE { get; set; }
    }
}
