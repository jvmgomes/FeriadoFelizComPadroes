using Xunit;
using Cafeteria;

namespace Cafeteria.Tests
{
    public class StrategyTests
    {
        [Fact]
        public void DefaultDelivery_ShouldReturnValue()
        {
            IDelivery delivery = new DefaultOrder();

            double result = delivery.Calculate();

            Assert.True(result >= 0);
        }

        [Fact]
        public void ExpressDelivery_ShouldReturnValue()
        {
            IDelivery delivery = new ExpressDelivery();

            double result = delivery.Calculate();

            Assert.True(result >= 0);
        }

        [Fact]
        public void PickupDelivery_ShouldReturnZero()
        {
            IDelivery delivery = new PickupDelivery();

            double result = delivery.Calculate();

            Assert.Equal(0, result);
        }
    }
}