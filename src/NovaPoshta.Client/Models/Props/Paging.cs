using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Props
{
    public abstract class Paging
    {
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}
