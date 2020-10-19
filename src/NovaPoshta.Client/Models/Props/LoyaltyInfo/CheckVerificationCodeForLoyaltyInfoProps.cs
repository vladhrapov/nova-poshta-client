using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NovaPoshta.Client.Models.Props.LoyaltyInfo
{
    public sealed class CheckVerificationCodeForLoyaltyInfoProps
    {
        [Required]
        public uint VerificationCode { get; set; }

        [Required]
        [EmailAddress]
        public string Login { get; set; }

        [Required]
        public bool AuthVerification { get; set; }
    }
}
