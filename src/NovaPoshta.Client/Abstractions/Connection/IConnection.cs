using NovaPoshta.Client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Abstractions.Connection
{
    public interface IConnection
    {
        Uri BaseAddress { get; }
        //string ApiVersion { get; }
        //string Format { get; }
        Task<HttpResponseMessage> PostAsync<TProps>(RequestPayload<TProps> requestPayload);
    }
}
