using CluedIn.Crawling.Sample.Core;

namespace CluedIn.Crawling.Sample
{
    public class SampleCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<SampleCrawlJobData>
    {
        public SampleCrawlerJobProcessor(SampleCrawlerComponent component) : base(component)
        {
        }
    }
}
