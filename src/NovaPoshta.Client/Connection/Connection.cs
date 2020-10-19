using Newtonsoft.Json;
using NovaPoshta.Client.Abstractions.Connection;
using NovaPoshta.Client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Connection
{
    public sealed class Connection : IConnection
    {
        private readonly HttpClient _httpClient;

        public Uri BaseAddress { get; }

        public Connection(Uri baseUrl)
            : this(baseUrl, new HttpClient())
        {
        }

        public Connection(Uri baseUrl, HttpClient httpClient)
        {
            BaseAddress = baseUrl;
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> PostAsync<TProps>(RequestPayload<TProps> requestPayload)
        {
            using (var content = new StringContent(JsonConvert.SerializeObject(requestPayload), Encoding.UTF8, "application/json"))
            {
                var response = await _httpClient.PostAsync(BaseAddress, content)
                    .ConfigureAwait(false);

                // ToDo: HttpCliet should be here
                return response;
            };
        }
    }
}
