using System.Collections.Generic;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public sealed class GetIncomingDocumentsByPhoneData
    {
        /// <summary>
        /// List of declared documents for incomming parcels.
        /// </summary>
        public List<GetDocumentsByPhoneData> Result { get; set; }
    }
}
