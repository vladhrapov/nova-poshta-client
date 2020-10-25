using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Props.ExpressWaybill
{
    public sealed class GetDocumentListProps
    {
        /// <summary>
        /// 
        /// </summary>
        public string DateTimeFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DateTimeTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public uint Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public byte GetFullList { get; set; }

        // New Feature

        /// <summary>
        /// 
        /// </summary>
        public ushort RedeliveryMoney { get; set; }
    }
}
