namespace Cafeteria
{
    public class ExpressDelivery : IDelivery
    {
        public double Calculate()
        {
            return 10.0;
        }

        public string GetType()
        {
            return "Entrega expressa";
        }
    }
}