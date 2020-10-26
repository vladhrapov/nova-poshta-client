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
            var payload = new RequestPayload<DeleteContragentAddressProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "delete",
                MethodProperties = new DeleteContragentAddressProps(addressRef)
            };

            return ApiConnection.PostAsync<DeleteContragentAddressProps, DeleteContragentAddressData>(payload);
        }

        public Task<ResponsePayload<GetAreasData>> GetAreas()
        {
            var payload = new RequestPayload<GetAreasProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "getAreas",
                MethodProperties = new GetAreasProps()
            };

            return ApiConnection.PostAsync<GetAreasProps, GetAreasData>(payload);
        }

        public Task<ResponsePayload<GetCitiesData>> GetCities(GetCitiesProps methodProps)
        {
            var payload = new RequestPayload<GetCitiesProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "getCities",
                MethodProperties = methodProps
            };

            return ApiConnection.PostAsync<GetCitiesProps, GetCitiesData>(payload);
        }

        public Task<ResponsePayload<GetSettlementsData>> GetSettlements(GetSettlementsProps methodProps)
        {
            var payload = new RequestPayload<GetSettlementsProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "AddressGeneral",
                CalledMethod = "getSettlements",
                MethodProperties = methodProps
            };

            return ApiConnection.PostAsync<GetSettlementsProps, GetSettlementsData>(payload);
        }

        public Task<ResponsePayload<GetStreetData>> GetStreet(GetStreetProps methodProps)
        {
            var payload = new RequestPayload<GetStreetProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "getStreet",
                MethodProperties = methodProps
            };

            return base.ApiConnection.PostAsync<GetStreetProps, GetStreetData>(payload);

        }

        public Task<ResponsePayload<GetWarehousesData>> GetWarehouses(GetWarehousesProps methodProps)
        {
            var payload = new RequestPayload<GetWarehousesProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "AddressGeneral",
                CalledMethod = "getWarehouses",
                MethodProperties = methodProps
            };

            return base.ApiConnection.PostAsync<GetWarehousesProps, GetWarehousesData>(payload);
        }

        public Task<ResponsePayload<SaveContragentAddressData>> SaveContragentAddress(SaveContragentAddressProps methodProps)
        {
            var payload = new RequestPayload<SaveContragentAddressProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "save",
                MethodProperties = methodProps
            };

            return base.ApiConnection.PostAsync<SaveContragentAddressProps, SaveContragentAddressData>(payload);
        }

        public Task<ResponsePayload<SearchSettlementsData>> SearchSettlements(SearchSettlementsProps methodProps)
        {
            var payload = new RequestPayload<SearchSettlementsProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "searchSettlements",
                MethodProperties = methodProps
            };

            return base.ApiConnection.PostAsync<SearchSettlementsProps, SearchSettlementsData>(payload);
        }

        public Task<ResponsePayload<SearchSettlementStreetData>> SearchSettlementStreets(SearchSettlementStreetsProps methodProps)
        {
            if (methodProps is null)
                throw new ArgumentNullException(nameof(methodProps));

            if (string.IsNullOrEmpty(methodProps.StreetName))
                throw new ArgumentException($"{nameof(methodProps.StreetName)} can't be null or empty.");

            var payload = new RequestPayload<SearchSettlementStreetsProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "searchSettlementStreets",
                MethodProperties = methodProps
            };

            return base.ApiConnection.PostAsync<SearchSettlementStreetsProps, SearchSettlementStreetData>(payload);
        }

        public Task<ResponsePayload<UpdateContragentAddressData>> UpdateContragentAddress(UpdateContragentAddressProps methodProps)
        {
            if (methodProps is null)
                throw new ArgumentNullException(nameof(methodProps));

            var payload = new RequestPayload<UpdateContragentAddressProps>
            {
                ApiKey = base.ApiConnection.ApiKey,
                ModelName = "Address",
                CalledMethod = "update",
                MethodProperties = methodProps
            };

            return base.ApiConnection.PostAsync<UpdateContragentAddressProps, UpdateContragentAddressData>(payload);
        }
    }
}
