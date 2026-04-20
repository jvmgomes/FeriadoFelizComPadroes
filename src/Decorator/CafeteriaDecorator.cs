using System;

namespace Cafeteria
{
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