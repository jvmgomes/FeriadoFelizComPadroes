using System;

namespace Cafeteria
{
    public class ExternalClientAPI
    {
        public DateTime lastOrder = DateTime.Now.AddMonths(-3);
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