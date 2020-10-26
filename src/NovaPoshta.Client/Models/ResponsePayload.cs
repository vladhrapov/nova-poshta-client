using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models
{
    public sealed class ResponsePayload<T>
    {
        public bool Success { get; set; }

        public List<string> Errors { get; set; }

        public List<string> Warnings { get; set; }

        // ToDo: uncomment later.
        // Temp fix for deserialization issue.
        //public List<string> Info { get; set; }

        public List<string> MessageCodes { get; set; }

        public List<string> ErrorCodes { get; set; }

        public List<string> WarningCodes { get; set; }

        public List<string> InfoCodes { get; set; }

        public List<T> Data { get; set; }
    }

    public class WithTotalCount
    {
        /// <summary>
        /// Total items count in the collection.
        /// </summary>
        public uint TotalCount { get; set; }
    }
}
