using System;

namespace Cafeteria
{
    public class NotificationFactory
    {
        public static INotification Create(string type)
        {
            INotification notification;

            switch (type.ToLower())
            {
                case "whatsapp": 
                    notification = new Whatsapp();
                    break;
                case "email":
                    notification = new Email();
                    break;
                case "sms":
                    notification = new SMS();
                    break;
                default: 
                    throw new ArgumentException("Tipo de Notificação Inválido");
            }
            return new NotificationProxy(notification);
        }
    }
}