using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models
{
    public sealed class RequestPayload<T>
    {
        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("calledMethod")]
        public string CalledMethod { get; set; }

        [JsonProperty("methodProperties")]
        public T MethodProperties { get; set; }
    }
}
