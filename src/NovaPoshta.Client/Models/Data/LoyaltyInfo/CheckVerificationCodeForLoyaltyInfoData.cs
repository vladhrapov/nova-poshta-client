using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.LoyaltyInfo
{
    public sealed class CheckVerificationCodeForLoyaltyInfoData
    {
        public string ApiKey { get; set; }
        public string LoyaltyCardNumber { get; set; }
        public string FullName { get; set; }
        public float? Discount { get; set; }
        public Guid City { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public Guid CounterpartyRef { get; set; }
        public byte AuthType { get; set; }
        public string AuthHash { get; set; }
        public string UserLogin { get; set; }
        public string LoyaltyCardType { get; set; }
        public string CounterpartyType { get; set; }
        public Guid ContactSender { get; set; }
        public string FullNameCounterparty { get; set; }
    }
}
