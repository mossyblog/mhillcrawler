using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class CustomerInterestVocabulary : SimpleVocabulary
    {
        public CustomerInterestVocabulary()
        {
            VocabularyName = "MHill Customer Interest Vocabulary";
            KeyPrefix = "mHill.customerinterest";
            KeySeparator = ".";
            Grouping = "/Customer";

            AddGroup("MHill Customer Interest Vocabulary Details", group =>
            {
                CustomerID = group.Add(new VocabularyKey("CustomerID", "Customer ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestID = group.Add(new VocabularyKey("InterestID", "Interest ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestValue = group.Add(new VocabularyKey("InterestValue", "Interest Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interest1 = group.Add(new VocabularyKey("Interest1", "Interest 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interest2 = group.Add(new VocabularyKey("Interest2", "Interest 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interest3 = group.Add(new VocabularyKey("Interest3", "Interest 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interest4 = group.Add(new VocabularyKey("Interest4", "Interest 4", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey("LegalEntity", "Legal Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerID { get; internal set; }
        public VocabularyKey InterestID { get; internal set; }
        public VocabularyKey InterestValue { get; internal set; }
        public VocabularyKey Interest1 { get; internal set; }
        public VocabularyKey Interest2 { get; internal set; }
        public VocabularyKey Interest3 { get; internal set; }
        public VocabularyKey Interest4 { get; internal set; }
        public VocabularyKey LegalEntity { get; internal set; }
    }
}
