using System;

public class ClientAdapter : IClient
{
    private ExternalClientAPI externalClient;

    public ClientAdapter(ExternalClientAPI client)
    {
        externalClient = client;
    }

    public string GetName()
    {
        return externalClient.name;
    }

    public bool IsActive()
    {
        return (DateTime.Now - externalClient.lastOrder).TotalDays <= 180;
    }
}