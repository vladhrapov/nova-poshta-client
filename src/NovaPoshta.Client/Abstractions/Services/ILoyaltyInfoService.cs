using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.LoyaltyInfo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Abstractions.Services
{
    public interface ILoyaltyInfoService
    {
        Task<ResponsePayload<GetUserByLoginData>> SignIn(string email, string password);
        Task<ResponsePayload<CheckVerificationCodeForLoyaltyInfoData>> ConfirmTFA(string email, uint code);
        Task<ResponsePayload<GetLoyaltyInfoByApiKeyData>> GetLoyaltyInfoByApiKey(string apiKey);
    }
}
