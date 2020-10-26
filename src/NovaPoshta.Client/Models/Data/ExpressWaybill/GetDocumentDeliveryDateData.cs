using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public sealed class GetDocumentDeliveryDateData
    {
        public DeliveryDate DeliveryDate { get; set; }
    }

    public sealed class DeliveryDate
    {
        public string Date { get; set; }

        [JsonProperty("timezone_type")]
        public byte TimezoneType { get; set; }

        public string Timezone { get; set; }
    }
}
