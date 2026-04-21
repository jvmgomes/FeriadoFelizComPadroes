using System;

namespace Cafeteria
{
    public interface IClient
    {
        string GetName();
        bool IsActive();
    }
}