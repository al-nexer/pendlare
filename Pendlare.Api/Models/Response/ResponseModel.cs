using Newtonsoft.Json;

namespace Pendlare.Api.Models.Response
{
    public class ResponseModel
    {
        [JsonProperty]
        public List<ResultModel> RESULT = new();
    }
}
