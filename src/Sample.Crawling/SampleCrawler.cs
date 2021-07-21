using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Sample.Core;
using CluedIn.Crawling.Sample.Infrastructure.Factories;

namespace CluedIn.Crawling.Sample
{
    public class SampleCrawler : ICrawlerDataGenerator
    {
        private readonly ISampleClientFactory clientFactory;
        public SampleCrawler(ISampleClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is SampleCrawlJobData samplecrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(samplecrawlJobData);

            //foreach (var samplePerson in client.GetSamplePersons())
            //    yield return samplePerson;
            
        }       
    }
}
