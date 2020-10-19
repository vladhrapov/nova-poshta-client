using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.Address;
using System;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Abstractions.Services
{
    public interface IAddressService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ResponsePayload<GetAreasData>> GetAreas();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cityRef"></param>
        /// <returns></returns>
        Task<ResponsePayload<GetCitiesData>> GetCities(Guid cityRef);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="areaRef"></param>
        /// <param name="addressRef"></param>
        /// <param name="regionRef"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        Task<ResponsePayload<GetSettlementsData>> GetSettlements(Guid areaRef, Guid addressRef, Guid regionRef, int page);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cityRef"></param>
        /// <returns></returns>
        Task<ResponsePayload<GetStreetData>> GetStreet(Guid cityRef);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        Task<ResponsePayload<GetWarehousesData>> GetWarehouses(string language);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cityName"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        Task<ResponsePayload<SearchSettlementsData>> SearchSettlements(string cityName, uint limit);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settlementRef"></param>
        /// <param name="streetName"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        Task<ResponsePayload<SearchSettlementStreetData>> SearchSettlementStreets(Guid settlementRef, string streetName, uint limit);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="counterpartyRef"></param>
        /// <param name="streetRef"></param>
        /// <param name="addressRef"></param>
        /// <param name="buildingNumber"></param>
        /// <param name="flat"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        Task<ResponsePayload<UpdateContragentAddressData>> UpdateContragentAddress(Guid counterpartyRef, Guid streetRef, Guid addressRef, string buildingNumber, ushort flat, string note);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="counterpartyRef"></param>
        /// <param name="streetRef"></param>
        /// <param name="buildingNumber"></param>
        /// <param name="flat"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        Task<ResponsePayload<SaveContragentAddressData>> SaveContragentAddress(Guid counterpartyRef, Guid streetRef, string buildingNumber, ushort flat, string note);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addressRef"></param>
        /// <returns></returns>
        Task<ResponsePayload<DeleteContragentAddressData>> DeleteContragentAddress(Guid addressRef);

    }
}
