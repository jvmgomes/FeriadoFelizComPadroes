namespace Cafeteria
{
    public class PickupDelivery : IDelivery
    {
        public double Calculate()
        {
            return 0.0;
        }

        public string GetType()
        {
            return "Retirada no local";
        }
    }
}