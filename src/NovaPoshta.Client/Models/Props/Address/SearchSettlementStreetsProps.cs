namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class SearchSettlementStreetsProps
    {
        /// <summary>
        /// Searched street name
        /// </summary>
        public string StreetName { get; private set; }

        /// <summary>
        /// Records number to return.
        /// </summary>
        public uint Limit { get; private set; }

        private SearchSettlementStreetsProps()
        {
        }

        /// <summary>
        /// Constructor with all and required params.
        /// </summary>
        /// <param name="settlementRef"></param>
        /// <param name="streetName"></param>
        /// <param name="limit"></param>
        public SearchSettlementStreetsProps(string streetName, uint limit)
        {
            StreetName = streetName;
            Limit = limit;
        }
    }
}
