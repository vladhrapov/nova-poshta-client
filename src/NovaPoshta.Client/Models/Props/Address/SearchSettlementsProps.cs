using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class SearchSettlementsProps
    {
        public string CityName { get; set; }

        public uint Limit { get; set; }
    }
}
