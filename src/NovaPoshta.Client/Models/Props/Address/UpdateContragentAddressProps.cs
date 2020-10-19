using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class UpdateContragentAddressProps
    {
        /// <summary>
        /// Contragent id.
        /// </summary>
        public Guid CounterpartyRef { get; set; }

        /// <summary>
        /// Address id.
        /// </summary>
        public Guid Ref { get; set; }

        /// <summary>
        /// Street id.
        /// </summary>
        public Guid StreetRef { get; set; }

        public string BuildingNumber { get; set; }

        public ushort Flat { get; set; }

        public string Note { get; set; }
    }
}
