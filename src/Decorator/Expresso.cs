using System;

namespace Cafeteria
{
    public class Expresso : IDrinks
    {
        public string getDescricao()
        {
            return "Expresso";
        }
    
        public double getCusto()
        {
            return 5.0;
        }
    }
}