using NovaPoshta.Client.Abstractions;
using NovaPoshta.Client.Abstractions.Connection;
using NovaPoshta.Client.Abstractions.Services;
using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.ExpressWaybill;
using NovaPoshta.Client.Models.Props.ExpressWaybill;
using System;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Services
{
    public sealed class ExpressWaybillService : ApiClient, IExpressWaybillService, IModelNameResolver
    {
        public ExpressWaybillService(IApiConnection connection)
            : base(connection)
        {
        }

        public string ModelName => "InternetDocument";

        public Task<ResponsePayload<GetArchiveDocumentsByPhoneData>> GetArchieveDocumentList(int page, int limit)
        {
            var payload = new RequestPayload<GetArchiveDocumentsByPhoneProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                //CalledMethod = "getDocumentList",
                CalledMethod = "getArchiveDocumentsByPhone",
                MethodProperties = new GetArchiveDocumentsByPhoneProps
                {
                    DateFrom = $"{DateTime.UtcNow.AddDays(-90).Date.ToString("dd.MM.yyyy")} 00:00:00",
                    DateTo = $"{DateTime.UtcNow.Date.ToString("dd.MM.yyyy")} 00:00:00",
                    Page = page,
                    Limit = limit
                }
            };

            return ApiConnection.PostAsync<GetArchiveDocumentsByPhoneProps, GetArchiveDocumentsByPhoneData>(payload);
        }

        public Task<ResponsePayload<GetDocumentDeliveryDateData>> GetDocumentDeliveryDate(GetDocumentDeliveryDateProps methodProps)
        {
            var payload = new RequestPayload<GetDocumentDeliveryDateProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                CalledMethod = "getDocumentDeliveryDate",
                MethodProperties = methodProps
            };

            return ApiConnection.PostAsync<GetDocumentDeliveryDateProps, GetDocumentDeliveryDateData>(payload);
        }

        public Task<ResponsePayload<GetDocumentListData>> GetDocumentList(GetDocumentListProps methodProps)
        {
            var payload = new RequestPayload<GetDocumentListProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                CalledMethod = "getDocumentList",
                MethodProperties = methodProps
            };

            return ApiConnection.PostAsync<GetDocumentListProps, GetDocumentListData>(payload);
        }

        public Task<ResponsePayload<GetDocumentPriceData>> GetDocumentPriceData(GetDocumentPriceProps methodProps)
        {
            var payload = new RequestPayload<GetDocumentPriceProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                CalledMethod = "getDocumentPrice",
                MethodProperties = methodProps
            };

            return ApiConnection.PostAsync<GetDocumentPriceProps, GetDocumentPriceData>(payload);
        }

        public Task<ResponsePayload<GetIncomingDocumentsByPhoneData>> GetIncomingDocumentList(int page, int limit)
        {
            var payload = new RequestPayload<GetIncomingDocumentsByPhoneProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                CalledMethod = "getIncomingDocumentsByPhone",
                MethodProperties = new GetIncomingDocumentsByPhoneProps
                {
                    DateFrom = $"{DateTime.UtcNow.AddDays(-60).Date.ToString("dd.MM.yyyy")} 00:00:00",
                    DateTo = $"{DateTime.UtcNow.AddDays(30).Date.ToString("dd.MM.yyyy")} 00:00:00",
                    Page = page,
                    Limit = limit
                }
            };

            return ApiConnection.PostAsync<GetIncomingDocumentsByPhoneProps, GetIncomingDocumentsByPhoneData>(payload);
        }

        public Task<ResponsePayload<SaveWaybillByAddressData>> SaveWaybillByAddress(SaveWaybillByAddressProps methodProps)
        {
            var payload = new RequestPayload<SaveWaybillByAddressProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                CalledMethod = "save",
                MethodProperties = methodProps
            };

            return ApiConnection.PostAsync<SaveWaybillByAddressProps, SaveWaybillByAddressData>(payload);
        }

        public Task<ResponsePayload<UpdateWaybillData>> UpdateWaybill(UpdateWaybillProps methodProps)
        {
            var payload = new RequestPayload<UpdateWaybillProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                CalledMethod = "update",
                MethodProperties = methodProps
            };

            return ApiConnection.PostAsync<UpdateWaybillProps, UpdateWaybillData>(payload);
        }
    }
}
