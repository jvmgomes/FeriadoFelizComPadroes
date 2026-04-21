using Xunit;
using Cafeteria;

namespace Cafeteria.Tests
{
    public class FactoryTests
    {
        [Fact]
        public void ShouldCreateEmail()
        {
            var notification = NotificationFactory.Create("email");

            Assert.NotNull(notification);
        }

        [Fact]
        public void ShouldCreateWhatsapp()
        {
            var notification = NotificationFactory.Create("whatsapp");

            Assert.NotNull(notification);
        }

        [Fact]
        public void ShouldCreateSMS()
        {
            var notification = NotificationFactory.Create("sms");

            Assert.NotNull(notification);
        }
    }
}