using System;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class GetSettlementsProps
    {
        /// <summary>
        /// Area id.
        /// </summary>
        public Guid? AreaRef { get; set; }

        /// <summary>
        /// Address id.
        /// </summary>
        public Guid? Ref { get; set; }

        /// <summary>
        /// Region id.
        /// </summary>
        public Guid? RegionRef { get; set; }

        /// <summary>
        /// Loaded page.
        /// In case to load all settlements - pass '1'.
        /// </summary>
        public uint? Page { get; set; }

        /// <summary>
        /// [Optional] Allows to find settlements by name.
        /// API supports ONLY ukrainian language.
        /// </summary>
        public string FindByString { get; set; }

        /// <summary>
        /// [Optional] Flag that indicates to show ONLY settlements where
        /// Nova Poshta delivery is present.
        /// </summary>
        public byte? Warehouse { get; set; }
    }
}
