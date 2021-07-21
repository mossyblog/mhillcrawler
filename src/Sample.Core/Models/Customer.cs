using System;
using System.Collections.Generic;
using System.Text;

namespace CluedIn.Crawling.Sample.Core.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public DateTime SourceCreatedDate { get; set; }
        public DateTime SourceModifiedDate { get; set; }
        public string ActiveStatus { get; set; }
        public bool IsDeleted { get; set; }
        public string Gender { get; set; }
    }
}
