using System;

namespace Cafeteria
{   
    public class Clients : IObserver
    {
        private string clientName;

        public Clients(String name)
        {
            setClientName(name);
        }

        public void setClientName(String name)
        {
            this.clientName = name;
        }

        public string getClientName()
        {
            return clientName;
        }
        public void Update (Subject s)
        {
            INotification notification = NotificationFactory.Create("whatsapp");
            notification.send(clientName + " Novo ingrediente chegou: " + s.LastIngredientAdded);
            Console.WriteLine("\n");
        }
    }
}