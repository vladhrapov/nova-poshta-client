using System.Collections.Generic;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public sealed class GetArchiveDocumentsByPhoneData
    {
        /// <summary>
        /// List of declared documents for archieved parcels.
        /// </summary>
        public List<GetDocumentsByPhoneData> Result { get; set; }
    }
}
