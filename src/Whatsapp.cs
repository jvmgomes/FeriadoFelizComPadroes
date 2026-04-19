using System;

namespace Cafeteria
{
    public class Whatsapp : INotification
    {
        public void send(string message)
        {
            Console.WriteLine("Enviando mensagem no Whatsapp do cliente...");
        }
    }
}