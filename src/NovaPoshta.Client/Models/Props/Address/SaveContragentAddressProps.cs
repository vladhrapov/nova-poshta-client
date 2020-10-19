using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class SaveContragentAddressProps
    {
        /// <summary>
        /// Contragent id.
        /// </summary>
        public Guid CounterpartyRef { get; set; }

        public Guid StreetRef { get; set; }
        public string BuildingNumber { get; set; }
        public uint Flat { get; set; }
        public string Note { get; set; }
    }
}
