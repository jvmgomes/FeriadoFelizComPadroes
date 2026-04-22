using System;

namespace Cafeteria
{

/// <summary>
/// Base decorator class for extending drink functionality dynamically.
/// </summary>
    public abstract class AdicionalDecorator : IDrinks
    {
        protected IDrinks drink;

        public AdicionalDecorator(IDrinks drink)
        {
            this.drink = drink;
        }

        public abstract string getDescricao();
        public abstract double getCusto();
    }
}