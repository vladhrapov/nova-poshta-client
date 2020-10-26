using NovaPoshta.Client.Models;
using System.Threading.Tasks;

namespace NovaPoshta.Client.Abstractions.Connection
{
    public interface IApiConnection
    {
        string ApiKey { get; }
        IConnection Connection { get; }
        Task<ResponsePayload<TResponse>> PostAsync<TProps, TResponse>(RequestPayload<TProps> request);
    }
}
