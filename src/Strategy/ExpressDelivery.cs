namespace Cafeteria
{
    public class ExpressDelivery : IDelivery
    {
        public double Calculate()
        {
            return 10.0;
        }

        public string GetDeliveryType()
        {
            return "Entrega expressa";
        }
    }
}