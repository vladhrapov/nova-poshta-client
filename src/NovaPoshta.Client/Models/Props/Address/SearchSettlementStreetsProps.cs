using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class SearchSettlementStreetsProps
    {
        /// <summary>
        /// Settlement id.
        /// </summary>
        public Guid SettlementRef { get; set; }
        public string StreetName { get; set; }
        public uint Limit { get; set; }
    }
}
