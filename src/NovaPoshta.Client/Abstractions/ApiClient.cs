using NovaPoshta.Client.Abstractions.Connection;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Abstractions
{
    public abstract class ApiClient
    {
        protected IApiConnection ApiConnection { get; }

        protected ApiClient(IApiConnection apiConnection)
        {
            ApiConnection = apiConnection;
        }
    }
}
