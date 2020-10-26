using NovaPoshta.Client.Abstractions;
using NovaPoshta.Client.Abstractions.Connection;
using NovaPoshta.Client.Abstractions.Services;
using NovaPoshta.Client.Connection;
using NovaPoshta.Client.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client
{
    public sealed class NovaPoshtaClient : INovaPoshtaClient
    {
        public static Uri BaseUri
        {
            get;
        } = new Uri("https://api.novaposhta.ua/v2.0/json/", UriKind.Absolute);

        public NovaPoshtaClient(string apiKey)
        {
            ApiConnection = new ApiConnection(apiKey, BaseUri);
            LoyaltyInfo = new LoyaltyInfoService(ApiConnection);
            Address = new AddressService(ApiConnection);
            ExpressWaybill = new ExpressWaybillService(ApiConnection);
        }

        public IApiConnection ApiConnection { get; }
        public ILoyaltyInfoService LoyaltyInfo { get; }
        public IAddressService Address { get; }
        public IExpressWaybillService ExpressWaybill { get; }
    }
}
