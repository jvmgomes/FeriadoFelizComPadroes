using System;

namespace Cafeteria
{

/// <summary>
/// Factory responsible for creating notification instances
/// based on the specified type (e.g., WhatsApp, Email).
/// </summary>
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