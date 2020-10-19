using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public sealed class GetIncomingDocumentsByPhoneData
    {
        public List<GetDocumentsByPhoneData> Result { get; set; }
    }
}
