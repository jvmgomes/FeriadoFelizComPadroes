using System;

namespace Cafeteria
{
    public class ExternalClientAPI
    {
        public string GetClientName()
        {
            return "Cliente Externo";
        }

        public bool IsActive()
        {
            return true;
        }
    }
}