using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class LoyaltyVocabulary : SimpleVocabulary
    {
        public LoyaltyVocabulary()
        {
            VocabularyName = "MHill Loyalty Vocabulary";
            KeyPrefix = "mHill.loyalty";
            KeySeparator = ".";
            Grouping = "/Loyalty";

            AddGroup("MHill Loyalty Vocabulary Details", group =>
            {
                LoyaltyID = group.Add(new VocabularyKey("LoyaltyID", "Loyalty ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyNumber = group.Add(new VocabularyKey("LoyaltyNumber", "Loyalty Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerID = group.Add(new VocabularyKey("CustomerID", "Customer ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLoyalty = group.Add(new VocabularyKey("IsLoyalty", "Removed from Loyalty Scheme", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey("LegalEntity", "Legal Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", "Commencement Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey("EndDate", "Cessation Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ExternalModifiedOn = group.Add(new VocabularyKey("ExternalModifiedOn", "Date Modified", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey("CreatedOn", "Activated Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey LoyaltyID { get; internal set; }
        public VocabularyKey LoyaltyNumber { get; internal set; }
        public VocabularyKey CustomerID { get; internal set; }
        public VocabularyKey IsLoyalty { get; internal set; }
        public VocabularyKey LegalEntity { get; internal set; }
        public VocabularyKey StartDate { get; internal set; }
        public VocabularyKey EndDate { get; internal set; }
        public VocabularyKey ExternalModifiedOn { get; internal set; }
        public VocabularyKey CreatedOn { get; internal set; }
    }
}
