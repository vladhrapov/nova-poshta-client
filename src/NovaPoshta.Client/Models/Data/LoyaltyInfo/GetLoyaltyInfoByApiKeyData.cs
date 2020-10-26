using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.LoyaltyInfo
{
    public sealed class GetLoyaltyInfoByApiKeyData
    {
        public Guid LoyaltyCardRef { get; set; }
        public string LoyaltyCard { get; set; }
        public string FullName { get; set; }
        public string FullNameCounterparty { get; set; }
        public float? Discount { get; set; }
        public Guid City { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string BarcodeNumber { get; set; }
        public Guid ContactSender { get; set; }
        public Guid CounterpartySender { get; set; }
        public bool CheckQuestion { get; set; }
    }
}
