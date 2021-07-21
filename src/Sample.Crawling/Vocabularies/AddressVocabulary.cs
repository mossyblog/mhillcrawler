using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class AddressVocabulary : SimpleVocabulary
    {
        public AddressVocabulary()
        {
            VocabularyName = "Address Vocabulary";
            KeyPrefix = "address.Vocab";
            KeySeparator = ".";
            Grouping = "/SampleVocab";

            AddGroup("Address Vocabulary Details", group =>
            {
                Street = group.Add(new VocabularyKey("Street", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey Street { get; internal set; }
        public VocabularyKey City { get; internal set; }
        public VocabularyKey Country { get; internal set; }
    }
}
