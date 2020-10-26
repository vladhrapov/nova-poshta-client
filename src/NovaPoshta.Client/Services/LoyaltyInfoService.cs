using NovaPoshta.Client.Abstractions;
using NovaPoshta.Client.Abstractions.Connection;
using NovaPoshta.Client.Abstractions.Services;
using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.LoyaltyInfo;
using NovaPoshta.Client.Models.Props.LoyaltyInfo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Services
{
    public sealed class LoyaltyInfoService : ApiClient, ILoyaltyInfoService
    {
        public LoyaltyInfoService(IApiConnection connection)
            : base(connection)
        {
        }

        public string ModelName { get => "LoyaltyUser"; }

        public Task<ResponsePayload<GetUserByLoginData>> SignIn(string email, string password)
        {
            var payload = new RequestPayload<GetUserByLoginProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                CalledMethod = "getUserByLogin",
                MethodProperties = new GetUserByLoginProps
                {
                    Login = email,
                    Password = password
                }
            };

            return ApiConnection.PostAsync<GetUserByLoginProps, GetUserByLoginData>(payload);
        }

        public Task<ResponsePayload<CheckVerificationCodeForLoyaltyInfoData>> ConfirmTFA(string email, uint code)
        {
            var payload = new RequestPayload<CheckVerificationCodeForLoyaltyInfoProps>
            {
                ApiKey = ApiConnection.ApiKey,
                ModelName = ModelName,
                CalledMethod = "checkVerificationCodeForLoyaltyInfo",
                MethodProperties = new CheckVerificationCodeForLoyaltyInfoProps
                {
                    VerificationCode = code,
                    Login = email,
                    AuthVerification = true
                }
            };

            return ApiConnection.PostAsync<CheckVerificationCodeForLoyaltyInfoProps, CheckVerificationCodeForLoyaltyInfoData>(payload);
        }

        // ToDo: Implement later for getLoyaltyInfo
        // {"system":"PA 3.0","modelName":"LoyaltyUser","calledMethod":"getLoyaltyInfoByApiKey","methodProperties":{}}
        public Task<ResponsePayload<GetLoyaltyInfoByApiKeyData>> GetLoyaltyInfoByApiKey(string apiKey)
        {
            var payload = new RequestPayload<GetLoyaltyInfoByApiKeyProps>
            {
                ApiKey = apiKey,
                ModelName = ModelName,
                CalledMethod = "getLoyaltyInfoByApiKey",
                MethodProperties = new GetLoyaltyInfoByApiKeyProps()
            };

            return ApiConnection.PostAsync<GetLoyaltyInfoByApiKeyProps, GetLoyaltyInfoByApiKeyData>(payload);
        }
    }
}
