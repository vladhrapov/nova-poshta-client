using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NovaPoshta.Client.Models.Props.LoyaltyInfo
{
    public sealed class GetUserByLoginProps
    {
        [Required]
        [EmailAddress]
        public string Login { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
