using System;
using System.Collections.Generic;
using System.Text;

namespace CluedIn.Crawling.Sample.Core.Models
{
    public class Loyalty
    {
        public string LoyaltyID { get; set; }
        public string LoyaltyNumber { get; set; }
        public string CustomerID { get; set; }
        public bool IsLoyalty { get; set; }
        public string LegalEntity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ExternalModifiedOn { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
