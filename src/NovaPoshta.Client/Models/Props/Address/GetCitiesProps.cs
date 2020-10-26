using System;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class GetCitiesProps
    {
        /// <summary>
        /// City id.
        /// </summary>
        public Guid? Ref { get; set; }

        /// <summary>
        /// Search by city name.
        /// </summary>
        public string FindByString { get; set; }

        /// <summary>
        /// Page number to return.
        /// </summary>
        public uint Page { get; set; }
    }
}
