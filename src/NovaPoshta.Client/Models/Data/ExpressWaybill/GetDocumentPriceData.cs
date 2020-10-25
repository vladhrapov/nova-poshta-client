using Newtonsoft.Json;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public sealed class GetDocumentPriceData
    {
        /// <summary>
        /// 
        /// </summary>
        public double? AssessedCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? CostRedelivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TZoneInfo TZoneInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? CostPack { get; set; }
    }

    public sealed class TZoneInfo
    {
        /// <summary>
        /// Tariff zone id.
        /// </summary>
        [JsonProperty("TzoneID")]
        public int? TZoneID { get; set; }

        /// <summary>
        /// Tariff zone name.
        /// </summary>
        [JsonProperty("TzoneName")]
        public string TZoneName { get; set; }
    }
}
