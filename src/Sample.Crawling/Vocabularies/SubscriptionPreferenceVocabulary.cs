using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class SubscriptionPreferenceVocabulary : SimpleVocabulary
    {
        public SubscriptionPreferenceVocabulary()
        {
            VocabularyName = "MHill Subscription Preference Vocabulary";
            KeyPrefix = "mHill.subcriptionpreference";
            KeySeparator = ".";
            Grouping = "/Subscription";

            AddGroup("MHill Subscription Preference Vocabulary Details", group =>
            {
                CustomerID = group.Add(new VocabularyKey("CustomerID", "Customer ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubscriptionType = group.Add(new VocabularyKey("SubscriptionType", "Legal Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailPreference = group.Add(new VocabularyKey("EmailPreference", "Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GlobalPreference = group.Add(new VocabularyKey("GlobalPreference", "Global opt-in/opt-out", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhonePreference = group.Add(new VocabularyKey("PhonePreference", "Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SmsPreference = group.Add(new VocabularyKey("SmsPreference", "SMS", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectMailPreference = group.Add(new VocabularyKey("DirectMailPreference", "Postal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceModifiedOn = group.Add(new VocabularyKey("SourceModifiedOn", "Modified Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SourceCreatedOn = group.Add(new VocabularyKey("SourceCreatedOn", "Creation Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey("Status", "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerID { get; internal set; }
        public VocabularyKey SubscriptionType { get; internal set; }
        public VocabularyKey EmailPreference { get; internal set; }
        public VocabularyKey GlobalPreference { get; internal set; }
        public VocabularyKey PhonePreference { get; internal set; }
        public VocabularyKey SmsPreference { get; internal set; }
        public VocabularyKey DirectMailPreference { get; internal set; }
        public VocabularyKey SourceModifiedOn { get; internal set; }
        public VocabularyKey SourceCreatedOn { get; internal set; }
        public VocabularyKey Status { get; internal set; }
    }
}
