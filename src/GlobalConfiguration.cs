using System;

namespace Cafeteria
{
    public class GlobalConfiguration
    {
        private static GlobalConfiguration instance;

        public string ApplicationName { get; private set; }
        public string SenderServer { get; private set; }
        public string PhoneNumber { get; private set; }
        public int ClientLimitNumber { get; private set; }
        private GlobalConfiguration()
        {
            ApplicationName = "John´s Cafeteria";
            SenderServer = "johncafeteria.com";
            PhoneNumber = "1134567890";
            ClientLimitNumber = 100;
        }

        public GlobalConfiguration getInstance()
        {
            if(instance == null)
            {
                instance = new GlobalConfiguration();    
            }
            return instance;
        }
    }
}