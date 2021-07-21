using System;
using System.Collections.Generic;
using System.Text;

namespace CluedIn.Crawling.Sample.Core.Models
{
    public class ContactSource
    {
        public string CustomerID { get; internal set; }
        public string Source { get; internal set; }
        public string SourceID { get; internal set; }
        public DateTime CreatedOn { get; internal set; }
        public bool IsDeleted { get; internal set; }
    }
}
