using System;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class SaveContragentAddressProps
    {
        /// <summary>
        /// Contragent id.
        /// </summary>
        public Guid CounterpartyRef { get; private set; }

        /// <summary>
        /// Street id.
        /// </summary>
        public Guid StreetRef { get; private set; }

        /// <summary>
        /// Number of the building.
        /// </summary>
        public string BuildingNumber { get; private set; }

        /// <summary>
        /// Number of the flat.
        /// </summary>
        public ushort Flat { get; private set; }

        /// <summary>
        /// Any comments.
        /// </summary>
        public string Note { get; private set; }

        private SaveContragentAddressProps()
        {
        }

        /// <summary>
        /// Constructor with required params.
        /// </summary>
        /// <param name="counterpartyRef">Contragent id.</param>
        /// <param name="streetRef">Street id.</param>
        /// <param name="buildingNumber">Number of the building.</param>
        /// <param name="flat">Number of the flat.</param>
        public SaveContragentAddressProps(Guid counterpartyRef, Guid streetRef, string buildingNumber, ushort flat)
        {
            CounterpartyRef = counterpartyRef;
            StreetRef = streetRef;
            BuildingNumber = buildingNumber;
            Flat = flat;
        }

        /// <summary>
        /// Constructor with all params.
        /// </summary>
        /// <param name="counterpartyRef">Contragent id.</param>
        /// <param name="streetRef">Street id.</param>
        /// <param name="buildingNumber">Number of the building.</param>
        /// <param name="flat">Number of the flat.</param>
        /// <param name="note">Any comments.</param>
        public SaveContragentAddressProps(Guid counterpartyRef, Guid streetRef, string buildingNumber, ushort flat, string note)
            : this(counterpartyRef, streetRef, buildingNumber, flat)
        {
            Note = note;
        }
    }
}
