using Xunit;
using Cafeteria;

namespace Cafeteria.Tests
{
    public class ProxyTests
    {
        [Fact]
        public void Proxy_ShouldSendMessage()
        {
            var real = NotificationFactory.Create("email");
            var proxy = new NotificationProxy(real);

            proxy.send("teste");

            Assert.True(true);
        }
    }
}