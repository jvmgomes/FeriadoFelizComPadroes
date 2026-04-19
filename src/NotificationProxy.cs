using System;

namespace Cafeteria
{
    public class NotificationProxy : INotification
    {
        private INotification realNotification;
        public NotificationProxy (INotification notification)
        {
            realNotification = notification;
        }
        public void send(string message)
        {
            
        }
    }
}