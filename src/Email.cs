using System;

namespace Cafeteria
{
    public class Email : INotification
    {
        public void send(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}