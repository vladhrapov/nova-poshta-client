using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.ExpressWaybill;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Abstractions.Services
{
    public interface IExpressWaybillService
    {
        Task<ResponsePayload<GetArchiveDocumentsByPhoneData>> GetArchieveDocumentList();
        Task<ResponsePayload<GetIncomingDocumentsByPhoneData>> GetIncomingDocumentList();
    }
}
