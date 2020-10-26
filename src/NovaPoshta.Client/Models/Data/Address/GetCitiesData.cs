using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.Address
{
    public sealed class GetCitiesData
    {
        public string Description { get; set; }
        public string DescriptionRu { get; set; }

        /// <summary>
        /// City id.
        /// </summary>
        public Guid Ref { get; set; }

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
        /// Area id.
        /// </summary>
        public Guid Area { get; set; }

        /// <summary>
        /// Settlement type id.
        /// </summary>
        public Guid SettlementType { get; set; }

        /// <summary>
        /// Not clear from API. What's that?
        /// </summary>
        public int IsBranch { get; set; }

        /// <summary>
        /// Not clear from API. What's that?
        /// </summary>
        public PreventEntryNewStreetsUser PreventEntryNewStreetsUser { get; set; }

        /// <summary>
        /// Not clear from API. What's the type and how it's used?
        /// </summary>
        public List<Guid> Conglomerates { get; set; }

        /// <summary>
        /// City code.
        /// </summary>
        public int CityID { get; set; }

        public string SettlementTypeDescription { get; set; }
        public string SettlementTypeDescriptionRu { get; set; }
    }

    public class PreventEntryNewStreetsUser
    {
    }
}
