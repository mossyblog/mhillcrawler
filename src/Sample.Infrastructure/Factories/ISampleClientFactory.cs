using CluedIn.Crawling.Sample.Core;

namespace CluedIn.Crawling.Sample.Infrastructure.Factories
{
    public interface ISampleClientFactory
    {
        SampleClient CreateNew(SampleCrawlJobData sampleCrawlJobData);
    }
}
