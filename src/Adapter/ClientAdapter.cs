using System;

namespace Cafeteria
{

/// <summary>
/// Adapter that converts the external client API
/// into the internal IClient interface expected by the system.
/// </summary>

    public class ClientAdapter : IClient
    {
        private ExternalClientAPI externalClient;

        public ClientAdapter(ExternalClientAPI client)
        {
            externalClient = client;
        }

        public string GetName()
        {
            return externalClient.GetClientName();
        }

        public bool IsActive()
        {
            return externalClient.IsActive();
        }
    }
        
}
