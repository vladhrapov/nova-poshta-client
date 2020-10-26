using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.Address
{
    public sealed class GetSettlementsData
    {
        public Guid Ref { get; set; }
        public Guid SettlementType { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public string DescriptionRu { get; set; }
        public string SettlementTypeDescription { get; set; }
        public string SettlementTypeDescriptionRu { get; set; }
        public string Region { get; set; }
        public string RegionsDescription { get; set; }
        public string RegionsDescriptionRu { get; set; }
        public Guid Area { get; set; }
        public string AreaDescription { get; set; }
        public string AreaDescriptionRu { get; set; }
        public string Index1 { get; set; }
        public string Index2 { get; set; }
        public string IndexCOATSU1 { get; set; }

        /// <summary>
        /// Day of the delivery. (Monday).
        /// </summary>
        public byte Delivery1 { get; set; }

        /// <summary>
        /// Day of the delivery. (Tuesday).
        /// </summary>
        public byte Delivery2 { get; set; }

        /// <summary>
        /// Day of the delivery. (Wednesday).
        /// </summary>
        public byte Delivery3 { get; set; }

        /// <summary>
        /// Day of the delivery. (Thursday).
        /// </summary>
        public byte Delivery4 { get; set; }

        /// <summary>
        /// Day of the delivery. (Friday).
        /// </summary>
        public byte Delivery5 { get; set; }

        /// <summary>
        /// Day of the delivery. (Saturday).
        /// </summary>
        public byte Delivery6 { get; set; }

        /// <summary>
        /// Day of the delivery. (Sunday).
        /// </summary>
        public byte Delivery7 { get; set; }

        /// <summary>
        /// Flag that indicates to show settlements where
        /// Nova Poshta delivery is present.
        /// </summary>
        public byte Warehouse { get; set; }

        public List<Guid> Conglomerates { get; set; }
    }
}
