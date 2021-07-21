using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Sample;
using CluedIn.Crawling.Sample.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Sample.Unit.Test
{
    public class SampleCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public SampleCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<ISampleClientFactory>();

            _sut = new SampleCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
