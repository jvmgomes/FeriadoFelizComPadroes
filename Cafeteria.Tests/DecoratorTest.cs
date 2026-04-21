using Xunit;
using Cafeteria;

namespace Cafeteria.Tests
{
    public class DecoratorTests
    {
        [Fact]
        public void Decorator_ShouldAddExtra()
        {
            IDrinks coffee = new Expresso();

            coffee = new Calda(coffee);

            Assert.NotNull(coffee.getDescricao());
        }
    }
}