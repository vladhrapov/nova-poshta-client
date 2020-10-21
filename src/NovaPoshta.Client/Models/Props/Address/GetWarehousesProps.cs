using System;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class GetWarehousesProps
    {
        /// <summary>
        /// Filter by city name.
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Filter by city id.
        /// </summary>
        public Guid? CityRef { get; set; }

        /// <summary>
        /// Output language. UA by default if not passed.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Page number to return. Use within Limit property.
        /// </summary>
        public uint? Page { get; set; }

        /// <summary>
        /// Records per page limit. Use within Page property.
        /// </summary>
        public uint? Limit { get; set; }
    }
}
