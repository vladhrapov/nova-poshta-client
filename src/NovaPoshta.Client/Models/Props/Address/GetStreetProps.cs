using System;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class GetStreetProps
    {
        /// <summary>
        /// Serach by city id.
        /// </summary>
        public Guid? CityRef { get; set; }

        /// <summary>
        /// Search by street name.
        /// </summary>
        public string FindByString { get; set; }

        /// <summary>
        /// Page number to return.
        /// </summary>
        public uint? Page { get; set; }
    }
}
