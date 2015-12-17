using System;
using System.Threading.Tasks;
using AFT.UGS.Core.Clients;
using AFT.UGS.Core.Messages.OAuth;
using AFT.UGS.Core.Messages.Players;
using Newtonsoft.Json;

namespace PlayerAuthorization
{
    class Program
    {
        static void Main(string[] args)
        {
            var serverBaseUrl = "http://integration-8-ugs-api.flycowdev.com";

            IBrandApiClient client = new BrandApiClient(serverBaseUrl);

            var clientCredentials = new ClientCredentialsTokenRequest()
            {
                client_id = "BRAND_3",
                client_secret = "w0jdfZGyDB3gWFJqGsBCTO3E7liTDgYoVrCaP7t13JMzryNIuKA3G2",
                grant_type = "client_credentials",
                scope = "playerapi"
            };


            TokenResponse brandTokenResponse = null;

            var task = Task.Run(async () =>
            {
                Console.WriteLine("Getting brand authorization token....");
                brandTokenResponse = await client.GetTokenAsync(clientCredentials);
                System.Console.WriteLine(JsonConvert.SerializeObject(brandTokenResponse));
            });           

            task.Wait();

            // Authorize a player

            var request = new AuthorizePlayerRequest()
            {
                ipaddress = "184.70.137.34",
                username  = "testuser112",
                userid    = "1234567891",
                tag       = "{\"aff\": \"123\"}",
                lang      = "zh-CN",
                cur       = "RMB",
                betlimitid = 1,
                loginurl  = "http://ugslobby.com/login",
                cashierurl = "http://ugslobby.com/cashier",            
                termsurl = "http://ugslobby.com/terms",
                helpurl = "http://ugslobby.com/help"
            };

            task = Task.Run(async () =>
            {
                Console.WriteLine("Authorizing player....");
                var playerAuthResponse = await client.AuthorizePlayerAsync(request, brandTokenResponse.access_token);
                System.Console.WriteLine(JsonConvert.SerializeObject(playerAuthResponse));
            });

            task.Wait();
        }
    }
}
