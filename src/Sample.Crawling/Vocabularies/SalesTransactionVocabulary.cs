using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class SalesTransactionVocabulary : SimpleVocabulary
    {
        public SalesTransactionVocabulary()
        {
            VocabularyName = "MHill Sales Transaction Vocabulary";
            KeyPrefix = "mHill.sales.transaction";
            KeySeparator = ".";
            Grouping = EntityType.Sales;

            AddGroup("MHill Sales Transaction Vocabulary Details", group =>
            {
                CustomerID = group.Add(new VocabularyKey("CustomerID", "Customer ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesID = group.Add(new VocabularyKey("SalesID", "Sales Order ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionID = group.Add(new VocabularyKey("TransactionID", "Transaction ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesStatus = group.Add(new VocabularyKey("SalesStatus", "Sales Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesLineStatus = group.Add(new VocabularyKey("SalesLineStatus", "Line Item Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PosCustomerNumber = group.Add(new VocabularyKey("PosCustomerNumber", "POS Customer Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDate = group.Add(new VocabularyKey("SalesDate", "Sales Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey("LineNumber", "Line Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemName = group.Add(new VocabularyKey("ItemName", "Product Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemID = group.Add(new VocabularyKey("ItemID", "Product Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemColourID = group.Add(new VocabularyKey("ItemColourID", "Product Colour", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSizeID = group.Add(new VocabularyKey("ItemSizeID", "Product Size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBarcode = group.Add(new VocabularyKey("ItemBarcode", "Variant Barcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPricePerItem = group.Add(new VocabularyKey("SalesPricePerItem", "Sales Price", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey("Quantity", "Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                TaxAmount = group.Add(new VocabularyKey("TaxAmount", "Tax Amount", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible));
                LocationNumber = group.Add(new VocabularyKey("LocationNumber", "Location Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey CustomerID { get; internal set; }
        public VocabularyKey SalesID { get; internal set; }
        public VocabularyKey TransactionID { get; internal set; }
        public VocabularyKey SalesStatus { get; internal set; }
        public VocabularyKey SalesLineStatus { get; internal set; }
        public VocabularyKey PosCustomerNumber { get; internal set; }
        public VocabularyKey SalesDate { get; internal set; }
        public VocabularyKey LineNumber { get; internal set; }
        public VocabularyKey ItemName { get; internal set; }
        public VocabularyKey ItemID { get; internal set; }
        public VocabularyKey ItemColourID { get; internal set; }
        public VocabularyKey ItemSizeID { get; internal set; }
        public VocabularyKey ItemBarcode { get; internal set; }
        public VocabularyKey SalesPricePerItem { get; internal set; }
        public VocabularyKey Quantity { get; internal set; }
        public VocabularyKey TaxAmount { get; internal set; }
        public VocabularyKey LocationNumber { get; internal set; }
    }
}
