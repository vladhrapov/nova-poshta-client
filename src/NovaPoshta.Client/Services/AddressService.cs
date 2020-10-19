using NovaPoshta.Client.Abstractions;
using NovaPoshta.Client.Abstractions.Connection;
using NovaPoshta.Client.Abstractions.Services;
using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.Address;
using NovaPoshta.Client.Models.Props.Address;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Services
{
    public sealed class AddressService : ApiClient, IAddressService
    {
        public AddressService(IApiConnection connection)
            : base(connection)
        {
        }

        public Task<ResponsePayload<DeleteContragentAddressData>> DeleteContragentAddress(Guid addressRef)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsePayload<GetAreasData>> GetAreas()
        {
            throw new NotImplementedException();
        }

        public Task<ResponsePayload<GetCitiesData>> GetCities(Guid cityRef)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsePayload<GetSettlementsData>> GetSettlements(Guid areaRef, Guid addressRef, Guid regionRef, int page)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsePayload<GetStreetData>> GetStreet(Guid cityRef)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsePayload<GetWarehousesData>> GetWarehouses(string language)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsePayload<SaveContragentAddressData>> SaveContragentAddress(Guid counterpartyRef, Guid streetRef, string buildingNumber, ushort flat, string note)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsePayload<SearchSettlementsData>> SearchSettlements(string cityName, uint limit)
        {
            var payload = new RequestPayload<SearchSettlementsProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "searchSettlements",
                MethodProperties = new SearchSettlementsProps
                {
                    CityName = cityName,
                    Limit = limit
                }
            };

            return base.ApiConnection.PostAsync<SearchSettlementsProps, SearchSettlementsData>(payload);
        }

        public Task<ResponsePayload<SearchSettlementStreetData>> SearchSettlementStreets(Guid settlementRef, string streetName, uint limit)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsePayload<UpdateContragentAddressData>> UpdateContragentAddress(Guid counterpartyRef, Guid streetRef, Guid addressRef, string buildingNumber, ushort flat, string note)
        {
            throw new NotImplementedException();
        }
    }
}
