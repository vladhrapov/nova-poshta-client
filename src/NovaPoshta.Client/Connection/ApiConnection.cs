using Newtonsoft.Json;
using NovaPoshta.Client.Abstractions.Connection;
using NovaPoshta.Client.Models;
using NovaPoshta.Client.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Connection
{
    public sealed class ApiConnection : IApiConnection
    {
        public string ApiKey { get; }

        public IConnection Connection { get; }

        public ApiConnection(string apiKey, IConnection connection)
        {
            ApiKey = apiKey;
            Connection = connection;
        }

        public ApiConnection(string apiKey, Uri baseUrl)
            : this(apiKey, new Connection(baseUrl))
        {
        }

        public ApiConnection(string apiKey, Uri baseUrl, HttpClient httpClient)
            : this(apiKey, new Connection(baseUrl, httpClient))
        {
        }

        public async Task<ResponsePayload<TResponse>> PostAsync<TProps, TResponse>(RequestPayload<TProps> requestPayload)
        {
            var response = await Connection.PostAsync(requestPayload)
                .ConfigureAwait(false);

            //var content = new StringContent(JsonConvert.SerializeObject(requestPayload), Encoding.UTF8, "application/json");
            //var response = await _httpClient.PostAsync(_urlHost, content)
            //    .ConfigureAwait(false);

            //// ToDo: Handle if response failed.

            var responsePayload = await response.Content
                .ReadAsStringAsync()
                .ConfigureAwait(false);

            try
            {
                var res = JsonConvert.DeserializeObject<ResponsePayload<TResponse>>(responsePayload);
                var errors = res.ToErrorList();
                var hasError = errors?.Any() ?? false;

                if (hasError)
                {
                    // ToDo: How to handle error if 200 Ok response?
                    // empty or what?
                }

                return res;
            }
            catch (Exception ex)
            {
                // ToDo: Worth to track somehow that we had bad request or whatever.
                return default;
            }
        }

        // ToDo: Performance improvement
        //public Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(RequestPayload<TRequest> requestPayload)
        //{
        //    var content = new StringContent(JsonConvert.SerializeObject(requestPayload), Encoding.UTF8, "application/json");

        //    return _httpClient.PostAsync(_urlHost, content)
        //        .ContinueWith((res) => res.Result.Content.ReadAsStringAsync(), TaskScheduler.Default)
        //        .Unwrap()
        //        .ContinueWith((payload) => JsonConvert.DeserializeObject<TResponse>(payload.Result), TaskScheduler.Default);
        //}
    }
}
