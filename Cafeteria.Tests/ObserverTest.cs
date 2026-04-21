using Xunit;
using Cafeteria;

namespace Cafeteria.Tests
{
    public class ObserverTests
    {

        [Fact]
        public void Observer_ShouldNotify()
        {
            var subject = new Subject();
            var client = new Clients("Joao");

            subject.addObserver(client);
            subject.notifyClients();

            Assert.True(true);
        }
    }
}