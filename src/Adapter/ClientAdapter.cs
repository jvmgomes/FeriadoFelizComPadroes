using System;

namespace Cafeteria
{

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
