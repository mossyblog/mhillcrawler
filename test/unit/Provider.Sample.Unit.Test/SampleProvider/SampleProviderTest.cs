using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Sample.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Sample.Unit.Test.SampleProvider
{
    public abstract class SampleProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<ISampleClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected SampleProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<ISampleClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Sample.SampleProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
