using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.Address
{
    public sealed class SaveContragentAddressData
    {
        /// <summary>
        /// Address id.
        /// </summary>
        public Guid Ref { get; set; }

        /// <summary>
        /// Address description.
        /// </summary>
        public string Description { get; set; }
    }
}
