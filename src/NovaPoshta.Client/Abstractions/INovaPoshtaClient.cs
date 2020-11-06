using NovaPoshta.Client.Abstractions.Services;

namespace NovaPoshta.Client.Abstractions
{
    public interface INovaPoshtaClient : INovaPoshtaBasicClient
    {
        ILoyaltyInfoService LoyaltyInfo { get; }
        IAddressService Address { get; }
        IExpressWaybillService ExpressWaybill { get; }
    }
}
