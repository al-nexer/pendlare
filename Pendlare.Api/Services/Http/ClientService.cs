namespace Pendlare.Api.Services.Http
{
    public class ClientService: IClientInterface
    {

        private readonly IHttpClientFactory _httpClientFactory;


        public ClientService(IHttpClientFactory httpClientFactory) {
            _httpClientFactory = httpClientFactory;
        }

        public void Get(String url) { }

        public void Post(String url, String body) { }


    }
}
