using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.Address
{
    public sealed class GetAreasData
    {
        /// <summary>
        /// Area id.
        /// </summary>
        public Guid Ref { get; set; }

        /// <summary>
        /// Area description in ukrainian.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Area city center id.
        /// </summary>
        public Guid AreasCenter { get; set; }
    }
}
