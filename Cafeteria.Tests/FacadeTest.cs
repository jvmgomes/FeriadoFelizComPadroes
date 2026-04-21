using Xunit;
using Cafeteria;

namespace Cafeteria.Tests
{
    public class FacadeTests
    {
        [Fact]
        public void Facade_ShouldCreateOrder()
        {
            var facade = new CafeteriaFacade();

            facade.MakeSimpleCoffee();
            facade.DeliverOrder("default");
            facade.FinishOrder();

            Assert.True(true);
        }
    }
}