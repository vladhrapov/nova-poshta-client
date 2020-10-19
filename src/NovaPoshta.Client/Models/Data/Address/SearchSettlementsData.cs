using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.Address
{
    public class SearchSettlementsData : WithTotalCount
    {
        /// <summary>
        /// Collection of addresses.
        /// </summary>
        public List<SearchSettlementsAddress> Addresses { get; set; }
    }

    public sealed class SearchSettlementsAddress
    {
        public string Present { get; set; }
        public uint Warehouses { get; set; }
        public string MainDescription { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string SettlementTypeCode { get; set; }
        public Guid Ref { get; set; }
        public Guid DeliveryCity { get; set; }
        public bool AddressDeliveryAllowed { get; set; }
        public bool StreetsAvailability { get; set; }
        public string ParentRegionTypes { get; set; }
        public string ParentRegionCode { get; set; }
        public string RegionTypes { get; set; }
        public string RegionTypesCode { get; set; }
    }
}
