using System;

namespace Cafeteria
{
    public class Whatsapp : INotification
    {
        public void send(string message)
        {
            Console.WriteLine("Whatsapp: " + message);
        }
    }
}