using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.ExpressWaybill;
using NovaPoshta.Client.Models.Props.ExpressWaybill;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Abstractions.Services
{
    public interface IExpressWaybillService
    {
        /// <summary>
        /// Search for archieved parcels.
        /// </summary>
        /// <param name="page">Page number.</param>
        /// <param name="limit">Records per page limit.</param>
        /// <returns>List of archieved parcels.</returns>
        Task<ResponsePayload<GetArchiveDocumentsByPhoneData>> GetArchieveDocumentList(int page, int limit);

        /// <summary>
        /// Search for incomming parcels.
        /// </summary>
        /// <param name="page">Page number.</param>
        /// <param name="limit">Records per page limit.</param>
        /// <returns>List of incomming parcels.</returns>
        Task<ResponsePayload<GetIncomingDocumentsByPhoneData>> GetIncomingDocumentList(int page, int limit);

        /// <summary>
        /// Search for all parcels.
        /// </summary>
        /// <param name="methodProps"></param>
        /// <returns></returns>
        Task<ResponsePayload<GetDocumentListData>> GetDocumentList(GetDocumentListProps methodProps);
    }
}
