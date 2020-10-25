using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public sealed class UpdateWaybillData
    {
        /// <summary>
        /// Waybill id.
        /// </summary>
        public Guid? Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? CostOnSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IntDocNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TypeDocument { get; set; }
    }
}
