namespace Pendlare.Api.Services.Http
{
    public interface IClientInterface
    {
        public void Get(String url);

        public void Post(String url, String body);
    }
}
