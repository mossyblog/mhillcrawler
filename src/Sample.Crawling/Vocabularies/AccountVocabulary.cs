using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "MHill Account Vocabulary";
            KeyPrefix = "mHill.account";
            KeySeparator = ".";
            Grouping = EntityType.Account;

            AddGroup("MHill Account Vocabulary Details", group =>
            {
                AccountID = group.Add(new VocabularyKey("AccountID", "Location ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStatus = group.Add(new VocabularyKey("AccountStatus", "Location Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", "Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey("Company", "Company", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationName = group.Add(new VocabularyKey("LocationName", "Location Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationNumber = group.Add(new VocabularyKey("LocationNumber", "Location Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Region = group.Add(new VocabularyKey("Region", "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey("State", "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey AccountID { get; internal set; }
        public VocabularyKey AccountStatus { get; internal set; }
        public VocabularyKey City { get; internal set; }
        public VocabularyKey Country { get; internal set; }
        public VocabularyKey Company { get; internal set; }
        public VocabularyKey LocationName { get; internal set; }
        public VocabularyKey LocationNumber { get; internal set; }
        public VocabularyKey Region { get; internal set; }
        public VocabularyKey State { get; internal set; }
    }
}
