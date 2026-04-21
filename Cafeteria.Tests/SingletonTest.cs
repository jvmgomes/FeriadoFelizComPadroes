using Xunit;
using Cafeteria;

namespace Cafeteria.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void ShouldReturnSameInstance()
        {
            var instance1 = GlobalConfiguration.getInstance();
            var instance2 = GlobalConfiguration.getInstance();

            Assert.Equal(instance1, instance2);
        }
    }
}