using NovaPoshta.Client.Abstractions.Connection;

namespace NovaPoshta.Client.Abstractions
{
    public interface INovaPoshtaBasicClient
    {
        IApiConnection ApiConnection { get; }
    }
}
