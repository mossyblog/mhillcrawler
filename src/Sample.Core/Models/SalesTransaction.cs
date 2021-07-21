using System;
using System.Collections.Generic;
using System.Text;

namespace CluedIn.Crawling.Sample.Core.Models
{
    public class SalesTransaction
    {
        public string CustomerID { get; set; }
        public string SalesID { get; set; }
        public string TransactionID { get; set; }
        public string SalesStatus { get; set; }
        public string SalesLineStatus { get; set; }
        public string PosCustomerNumber { get; set; }
        public DateTime SalesDate { get; set; }
        public string LineNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemID { get; set; }
        public string ItemColourID { get; set; }
        public string ItemSizeID { get; set; }
        public string ItemBarcode { get; set; }
        public decimal SalesPricePerItem { get; set; }
        public int Quantity { get; set; }
        public decimal TaxAmount { get; set; }
        public string LocationNumber { get; set; }
    }
}
