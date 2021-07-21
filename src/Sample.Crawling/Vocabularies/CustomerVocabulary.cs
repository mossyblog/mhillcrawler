using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class CustomerVocabulary : SimpleVocabulary
    {
        public CustomerVocabulary()
        {
            VocabularyName = "MHill Customer Vocabulary";
            KeyPrefix = "mHill.customer";
            KeySeparator = ".";
            Grouping = "/Customer";

            AddGroup("MHill Customer Vocabulary Details", group =>
            {
                CustomerID = group.Add(new VocabularyKey("CustomerID", "Customer ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey("FirstName", "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey("LastName", "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                MobileNumber = group.Add(new VocabularyKey("MobileNumber", "Mobile Number", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                DateOfBirth = group.Add(new VocabularyKey("DateOfBirth", "Date of Birth", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey("AddressLine1", "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine2 = group.Add(new VocabularyKey("AddressLine2", "Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Postcode = group.Add(new VocabularyKey("Postcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCreatedDate = group.Add(new VocabularyKey("SourceCreatedDate", "Source Created Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                SourceModifiedDate = group.Add(new VocabularyKey("SourceModifiedDate", "Source Modified Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ActiveStatus = group.Add(new VocabularyKey("ActiveStatus", "Active Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeleted = group.Add(new VocabularyKey("IsDeleted", "Is Deleted?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey("Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey CustomerID { get; internal set; }
        public VocabularyKey FirstName { get; internal set; }
        public VocabularyKey LastName { get; internal set; }
        public VocabularyKey Email { get; internal set; }
        public VocabularyKey MobileNumber { get; internal set; }
        public VocabularyKey DateOfBirth { get; internal set; }
        public VocabularyKey AddressLine1 { get; internal set; }
        public VocabularyKey AddressLine2 { get; internal set; }
        public VocabularyKey City { get; internal set; }
        public VocabularyKey State { get; internal set; }
        public VocabularyKey Country { get; internal set; }
        public VocabularyKey Postcode { get; internal set; }
        public VocabularyKey SourceCreatedDate { get; internal set; }
        public VocabularyKey SourceModifiedDate { get; internal set; }
        public VocabularyKey ActiveStatus { get; internal set; }
        public VocabularyKey IsDeleted { get; internal set; }
        public VocabularyKey Gender { get; internal set; }
    }
}
