using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.LoyaltyInfo;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Abstractions.Services
{
    public interface ILoyaltyInfoService
    {
        /// <summary>
        /// Sign in by email and password.
        /// </summary>
        /// <param name="email">User's email.</param>
        /// <param name="password">User's password</param>
        /// <returns>User login data.</returns>
        Task<ResponsePayload<GetUserByLoginData>> SignIn(string email, string password);

        /// <summary>
        /// Confirm TFA after sign in.
        /// </summary>
        /// <param name="email">User's email.</param>
        /// <param name="code">Verification code.</param>
        /// <returns>Logged in user info.</returns>
        Task<ResponsePayload<CheckVerificationCodeForLoyaltyInfoData>> ConfirmTFA(string email, uint code);

        /// <summary>
        /// Get user info by user's api key.
        /// </summary>
        /// <param name="apiKey">User's api key.</param>
        /// <returns>Logged in user info.</returns>
        Task<ResponsePayload<GetLoyaltyInfoByApiKeyData>> GetLoyaltyInfoByApiKey(string apiKey);
    }
}
