using Xunit;
using Cafeteria;

namespace Cafeteria.Tests
{
    public class AdapterTests
    {
        [Fact]
        public void Adapter_ShouldReturnClientName()
        {
            var external = new ExternalClientAPI();
            IClient adapter = new ClientAdapter(external);

            Assert.NotNull(adapter.GetName());
        }

        [Fact]
        public void Adapter_ShouldCheckActive()
        {
            var external = new ExternalClientAPI();
            IClient adapter = new ClientAdapter(external);

            Assert.True(adapter.IsActive());
        }
    }
}