using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NovaPoshta.Client.Models.Props.ExpressWaybill
{
    public sealed class GetDocumentPriceProps
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid CitySender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CityRecipient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ServiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CargoType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PackCalculate PackCalculate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RedeliveryCalculate RedeliveryCalculate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<CargoDetails> CargoDetails { get; set; }

        public GetDocumentPriceProps(Guid citySender,
            Guid cityRecipient,
            double weight,
            string serviceType,
            double cost,
            string cargoType)
        {
            CitySender = citySender;
            CityRecipient = cityRecipient;
            Weight = weight;
            ServiceType = serviceType;
            Cost = cost;
            CargoType = cargoType;
        }

        public GetDocumentPriceProps(Guid citySender,
            Guid cityRecipient,
            double weight,
            string serviceType,
            double cost,
            string cargoType,
            PackCalculate packCalculate = null,
            RedeliveryCalculate redeliveryCalculate = null,
            IEnumerable<CargoDetails> cargoDetails = null)
                : this(citySender,
                      cityRecipient,
                      weight,
                      serviceType,
                      cost,
                      cargoType)
        {
            PackCalculate = packCalculate;
            RedeliveryCalculate = redeliveryCalculate;
            CargoDetails = cargoDetails.ToList();
        }
    }

    public class CargoDetails
    {
        /// <summary>
        /// Cargo description id.
        /// </summary>
        public Guid CargoDescription { get; private set; }

        /// <summary>
        /// Cargo amount.
        /// </summary>
        public uint Amount { get; private set; }

        /// <summary>
        /// Constructor with all and required params.
        /// </summary>
        /// <param name="cargoDescription">Cargo description id.</param>
        /// <param name="amount">Cargo amount.</param>
        public CargoDetails(Guid cargoDescription, uint amount)
        {
            CargoDescription = cargoDescription;
            Amount = amount;
        }
    }

    public sealed class RedeliveryCalculate
    {
        /// <summary>
        /// Cargo type name(Cargo, Documents, TiresWheels, etc).
        /// </summary>
        public string CargoType { get; private set; }

        /// <summary>
        /// Cargo amount.
        /// </summary>
        public double Amount { get; private set; }

        /// <summary>
        /// Constructor with all params.
        /// </summary>
        /// <param name="cargoType">Cargo type name(Cargo, Documents, TiresWheels, etc).</param>
        /// <param name="amount">Cargo amount.</param>
        public RedeliveryCalculate(string cargoType, double amount)
        {
            CargoType = cargoType;
            Amount = amount;
        }
    }

    public sealed class PackCalculate
    {
        /// <summary>
        /// Pack id.
        /// </summary>
        public Guid PackRef { get; private set; }

        /// <summary>
        /// Count of the parcel packs.
        /// </summary>
        public ushort PackCount { get; private set; }

        /// <summary>
        /// Constructor with all params.
        /// </summary>
        /// <param name="packRef">Pack id.</param>
        /// <param name="packCount">Count of the parcel packs.</param>
        public PackCalculate(Guid packRef, ushort packCount)
        {
            PackRef = packRef;
            PackCount = packCount;
        }
    }
}
