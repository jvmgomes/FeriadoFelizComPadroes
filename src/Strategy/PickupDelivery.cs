namespace Cafeteria
{
    public class PickupDelivery : IDelivery
    {
        public double Calculate()
        {
            return 0.0;
        }

        public string GetDeliveryType()
        {
            return "Retirada no local";
        }
    }
}