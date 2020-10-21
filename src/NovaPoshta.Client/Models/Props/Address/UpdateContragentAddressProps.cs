using System;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class UpdateContragentAddressProps
    {
        /// <summary>
        /// Contragent id.
        /// </summary>
        public Guid? CounterpartyRef { get; set; }

        /// <summary>
        /// Address id.
        /// </summary>
        public Guid? Ref { get; set; }

        /// <summary>
        /// Street id.
        /// </summary>
        public Guid? StreetRef { get; set; }

        /// <summary>
        /// Number of the building.
        /// </summary>
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Number of the flat.
        /// </summary>
        public ushort? Flat { get; set; }

        /// <summary>
        /// Any comments.
        /// </summary>
        public string Note { get; set; }
    }
}
