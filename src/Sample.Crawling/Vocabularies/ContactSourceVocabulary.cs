using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class ContactSourceVocabulary : SimpleVocabulary
    {
        public ContactSourceVocabulary()
        {
            VocabularyName = "MHill Contact Source Vocabulary";
            KeyPrefix = "mHill.contact";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("MHill Contact Source Vocabulary Details", group =>
            {
                CustomerID = group.Add(new VocabularyKey("CustomerID", "Customer ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Source = group.Add(new VocabularyKey("Source", "Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceID = group.Add(new VocabularyKey("SourceID", "Source System Customer ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey("CreatedOn", "Interaction Date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                IsDeleted = group.Add(new VocabularyKey("IsDeleted", "Deleted by Customer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerID { get; internal set; }
        public VocabularyKey Source { get; internal set; }
        public VocabularyKey SourceID { get; internal set; }
        public VocabularyKey CreatedOn { get; internal set; }
        public VocabularyKey IsDeleted { get; internal set; }
    }
}
