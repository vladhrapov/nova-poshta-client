using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public class SaveWaybillData
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? CostOnSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? EstimatedDeliveryDate { get; set; }

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
