using System;
using System.Collections.Generic;
using System.Text;

namespace CluedIn.Crawling.Sample.Core.Models
{
    public class SubscriptionPreference
    {
        public string CustomerID { get; set; }
        public string SubscriptionType { get; set; }
        public string EmailPreference { get; set; }
        public string GlobalPreference { get; set; }
        public string PhonePreference { get; set; }
        public string SmsPreference { get; set; }
        public string DirectMailPreference { get; set; }
        public DateTime SourceModifiedOn { get; set; }
        public DateTime SourceCreatedOn { get; set; }
        public string Status { get; set; }
    }
}
