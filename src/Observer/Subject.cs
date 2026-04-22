using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Cafeteria
{
    
/// <summary>
/// Represents the subject in the Observer pattern,
/// responsible for managing observers and notifying them of changes.
/// </summary>
    public class Subject
    {
        private List<IObserver> clients = new List<IObserver>();

        public string LastIngredientAdded { get; set; }
        public void addObserver(IObserver client)
        {
            clients.Add(client);
        }

        public void removeObserver(IObserver client)
        {
            clients.Remove(client);
        }

        public void notifyClients()
        {
            foreach (IObserver obs in clients)
            {
                obs.Update(this);
            }
        }
    }
}