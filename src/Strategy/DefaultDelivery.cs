namespace Cafeteria
{
    public class DefaultOrder : IDelivery
    {
        public double Calculate()
        {
            return 5.0;
        }

        public string GetType()
        {
            return "Entrega padrão";
        }
    }
}