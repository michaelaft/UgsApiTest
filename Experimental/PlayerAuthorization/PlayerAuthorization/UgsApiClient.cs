namespace PlayerAuthorization
{
    public class UgsApiClient
    {
        private string _serverBaseUrl = "http://integration-8-ugs-api.flycowdev.com";

        public UgsApiClient()
        {

        }

        public UgsApiClient(string serverBaseUrl)
        {
            _serverBaseUrl = serverBaseUrl;
        }

    }
}
