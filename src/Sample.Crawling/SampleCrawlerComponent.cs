using CluedIn.Core;
using CluedIn.Crawling.Sample.Core;

using ComponentHost;

namespace CluedIn.Crawling.Sample
{
    [Component(SampleConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class SampleCrawlerComponent : CrawlerComponentBase
    {
        public SampleCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

