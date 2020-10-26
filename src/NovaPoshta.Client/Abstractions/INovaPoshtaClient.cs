using NovaPoshta.Client.Abstractions.Connection;
using NovaPoshta.Client.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Abstractions
{
    public interface INovaPoshtaClient
    {
        IApiConnection ApiConnection { get; }
        ILoyaltyInfoService LoyaltyInfo { get; }
        IAddressService Address { get; }
        IExpressWaybillService ExpressWaybill { get; }
    }
}
