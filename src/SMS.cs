using System;

namespace Cafeteria
{
    public class SMS : INotification
    {
        public void send(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }
}