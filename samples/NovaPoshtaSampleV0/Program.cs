using NovaPoshta.Client;
using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Props.Address;
using System;
using System.Threading.Tasks;

namespace NovaPoshtaSampleV0
{
    class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();

            Console.ReadKey();
        }

        async static Task MainAsync(string[] args)
        {
            var apiKey = "your_api_key_provided_by_nova_poshta";
            var client = new NovaPoshtaClient(apiKey); // create instance of client

            #region You can use built in APIs:

            // call APIs on the client

            // Address API
            var citiesResponse = await client.Address.GetCities(new GetCitiesProps());
            var cities = citiesResponse.Data;

            // Loyalty info API (Users info, auth, etc)
            var loyaltyInfoResponse = await client.LoyaltyInfo.GetLoyaltyInfoByApiKey(apiKey);
            var loyaltyInfo = loyaltyInfoResponse.Data;

            #endregion

            #region Or implement custom APIs

            // Once you need to customize or create custom implementation to call Nova Poshta API
            var response = await client.ApiConnection.PostAsync<CustomPayload, CustomData>(new RequestPayload<CustomPayload>());
            var data = response.Data;

            #endregion
        }
    }
}
