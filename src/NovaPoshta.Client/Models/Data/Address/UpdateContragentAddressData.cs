using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.Address
{
    public sealed class UpdateContragentAddressData
    {
        /// <summary>
        /// Contragent address id.
        /// </summary>
        public Guid Ref { get; set; }
        public string Description { get; set; }
    }
}
