using System.Collections.Generic;
using CluedIn.Crawling.Sample.Core;

namespace CluedIn.Crawling.Sample.Integration.Test
{
  public static class SampleConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { SampleConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
