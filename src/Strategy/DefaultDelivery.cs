namespace Cafeteria
{
    public class DefaultOrder : IDelivery
    {
        public double Calculate()
        {
            return 5.0;
        }

        public string GetDeliveryType()
        {
            return "Entrega padrão";
        }
    }
}