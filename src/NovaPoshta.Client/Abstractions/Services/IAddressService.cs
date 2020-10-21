using NovaPoshta.Client.Models;
using NovaPoshta.Client.Models.Data.Address;
using NovaPoshta.Client.Models.Props.Address;
using System;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Abstractions.Services
{
    public interface IAddressService
    {
        /// <summary>
        /// Search all areas.
        /// </summary>
        /// <returns>List of areas.</returns>
        Task<ResponsePayload<GetAreasData>> GetAreas();

        /// <summary>
        /// Search cities by searched criteria.
        /// </summary>
        /// <param name="methodProps">Get cities model.</param>
        /// <returns>List of searched cities.</returns>
        Task<ResponsePayload<GetCitiesData>> GetCities(GetCitiesProps methodProps);

        /// <summary>
        /// Search settlements by searched criteria.
        /// </summary>
        /// <param name="methodProps">Get settlements model.</param>
        /// <returns>List of searched settlements.</returns>
        Task<ResponsePayload<GetSettlementsData>> GetSettlements(GetSettlementsProps methodProps);

        /// <summary>
        /// Search streets for the area by searched criteria.
        /// </summary>
        /// <param name="methodProps">Get street model</param>
        /// <returns>List of searched streets.</returns>
        Task<ResponsePayload<GetStreetData>> GetStreet(GetStreetProps methodProps);

        /// <summary>
        /// Search list of warehouses.
        /// </summary>
        /// <param name="methodProps">Get warehouses model.</param>
        /// <returns>List of Nova Poshta warehouses.</returns>
        Task<ResponsePayload<GetWarehousesData>> GetWarehouses(GetWarehousesProps methodProps);

        /// <summary>
        /// Search settlements by search criteria. 
        /// </summary>
        /// <param name="methodProps">Search settlements model.</param>
        /// <returns>List of settlements.</returns>
        Task<ResponsePayload<SearchSettlementsData>> SearchSettlements(SearchSettlementsProps methodProps);

        /// <summary>
        /// Search streets for the settlement by search criteria.
        /// </summary>
        /// <param name="methodProps">Search settlement streets model.</param>
        /// <returns>List of settlement streets.</returns>
        Task<ResponsePayload<SearchSettlementStreetData>> SearchSettlementStreets(SearchSettlementStreetsProps methodProps);

        /// <summary>
        /// Update contragent address.
        /// </summary>
        /// <param name="methodProps">Contragent address model.</param>
        /// <returns>Updated contragent address.</returns>
        Task<ResponsePayload<UpdateContragentAddressData>> UpdateContragentAddress(UpdateContragentAddressProps methodProps);

        /// <summary>
        /// Save contragent address.
        /// </summary>
        /// <param name="methodProps">Contragent address model.</param>
        /// <returns>Saved contragent address.</returns>
        Task<ResponsePayload<SaveContragentAddressData>> SaveContragentAddress(SaveContragentAddressProps methodProps);

        /// <summary>
        /// Delete contragent address by id.
        /// </summary>
        /// <param name="addressRef">Address id.</param>
        /// <returns>List with deleted address id.</returns>
        Task<ResponsePayload<DeleteContragentAddressData>> DeleteContragentAddress(Guid addressRef);
    }
}
