namespace Pendlare.Api.Services.Http
{
    public class TrafikVerketClientService: ITrafikVerketClientInterface
    {
        private readonly IClientInterface client;
        public TrafikVerketClientService(IClientInterface clientService) {
            client = clientService;
        }

        public void GetAllStations() {
        
        }

    }
}
