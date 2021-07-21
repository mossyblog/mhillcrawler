using System;
using System.Collections.Generic;
using System.Text;

namespace CluedIn.Crawling.Sample.Core.Models
{
    public class SpecialOccasion
    {
        public string ContactID { get; set; }
        public string Relationship { get; set; }
        public string Status { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string OccasionToCelebrate { get; set; }
        public DateTime DateOfOccasion { get; set; }
    }
}
