namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class SearchSettlementsProps
    {
        /// <summary>
        /// Settlement name or settlement index to search.
        /// </summary>
        public string CityName { get; private set; }

        /// <summary>
        /// Records number to return.
        /// </summary>
        public uint Limit { get; private set; }

        private SearchSettlementsProps()
        {
        }

        /// <summary>
        /// Constructor with all and required params.
        /// </summary>
        /// <param name="cityNameOrIndex">Settlement name or settlement index to search.</param>
        /// <param name="limit">Records number to return.</param>
        public SearchSettlementsProps(string cityNameOrIndex, uint limit)
        {
            CityName = cityNameOrIndex;
            Limit = limit;
        }
    }
}
