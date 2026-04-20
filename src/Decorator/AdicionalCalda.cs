using System;

namespace Cafeteria
{
    public class Calda : AdicionalDecorator
    {
        public Calda (IDrinks drink) : base(drink) {}

        public override string getDescricao()
        {
            return drink.getDescricao() + ", Calda de Chocolate";
        }

        public override double getCusto()
        {
            return drink.getCusto() + 1;
        }
    }
}