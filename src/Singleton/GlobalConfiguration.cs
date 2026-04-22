using System;

namespace Cafeteria
{

/// <summary>
/// Singleton that stores global configuration of the cafeteria system,
/// such as application settings and available ingredients.
/// </summary>
    public class GlobalConfiguration : Subject
    {
        private static GlobalConfiguration instance = null!;

        public string ApplicationName { get; private set; }
        public string SenderServer { get; private set; }
        public string PhoneNumber { get; private set; }
        public int MaxTries { get; private set; }
        public int ClientLimitNumber { get; private set; }
        public List<string> Ingredients { get; private set; }
        
        private GlobalConfiguration()
        {
            ApplicationName = "John´s Cafeteria";
            SenderServer = "johncafeteria.com";
            PhoneNumber = "1134567890";
            MaxTries = 5;
            ClientLimitNumber = 100;
            Ingredients = new List<string>
            {
                "Cappuccino",
                "Expresso",
                "Cha",
                "Canela",
                "Calda de Chocolate"
            };
        }
        public void SetNewIngredient(string newIngredient)
        {
            Ingredients.Add(newIngredient);
            LastIngredientAdded = newIngredient;
            notifyClients();
        }

        public static GlobalConfiguration getInstance()
        {
            if(instance == null)
            {
                instance = new GlobalConfiguration();    
            }
            return instance;
        }
    }
}