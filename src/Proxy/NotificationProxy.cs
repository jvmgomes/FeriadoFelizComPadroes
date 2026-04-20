using System;

namespace Cafeteria
{
    public class NotificationProxy : INotification
    {
        private INotification realNotification;
        private int tries = 0; // contador de tentativas

        public NotificationProxy(INotification notification)
        {
            realNotification = notification;
        }

        public void send(string message)
        {
            var config = GlobalConfiguration.getInstance();

            if (tries >= config.MaxTries)
            {
                Console.WriteLine("Limite atingido"); //limitador de tentativas
                return;
            }

            Console.WriteLine("Log: enviando mensagem..."); //simulando logs
            tries++;

            realNotification.send(message);
        }
    }
}