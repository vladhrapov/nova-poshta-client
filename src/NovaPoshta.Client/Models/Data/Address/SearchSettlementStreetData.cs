using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.Address
{
    public sealed class SearchSettlementStreetData : WithTotalCount
    {
        public List<Address2> Addresses { get; set; }
    }

    public sealed class Address2
    {
        /// <summary>
        /// Settlement id.
        /// </summary>
        public Guid SettlementRef { get; set; }

        /// <summary>
        /// Settlement street id.
        /// </summary>
        public Guid SettlementStreetRef { get; set; }

        /// <summary>
        /// Searched settlement street description.
        /// </summary>
        public string SettlementStreetDescription { get; set; }

        /// <summary>
        /// Full settlement street description.
        /// </summary>
        public string Present { get; set; }

        /// <summary>
        /// Street type id.
        /// </summary>
        public Guid StreetsType { get; set; }

        /// <summary>
        /// Abbreviation of the street type name.
        /// </summary>
        public string StreetsTypeDescription { get; set; }

        /// <summary>
        /// New. Empty field currently.
        /// </summary>
        public string Location { get; set; }
    }
}
