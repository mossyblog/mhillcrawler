using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sample.Vocabularies
{
    public class SpecialOccasionVocabulary : SimpleVocabulary
    {
        public SpecialOccasionVocabulary()
        {
            VocabularyName = "MHill Special Occasions Vocabulary";
            KeyPrefix = "mHill.specialoccasion";
            KeySeparator = ".";
            Grouping = "/SpecialOccasion";

            AddGroup("MHill Special Occasions Vocabulary Details", group =>
            {
                ContactID = group.Add(new VocabularyKey("ContactID", "Contact ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Relationship = group.Add(new VocabularyKey("Relationship", "Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey("Status", "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey("ModifiedOn", "Modified On", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                OccasionToCelebrate = group.Add(new VocabularyKey("OccasionToCelebrate", "Occasion to Celebrate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfOccasion = group.Add(new VocabularyKey("DateOfOccasion", "Date of Occasion", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ContactID { get; internal set; }
        public VocabularyKey Relationship { get; internal set; }
        public VocabularyKey Status { get; internal set; }
        public VocabularyKey ModifiedOn { get; internal set; }
        public VocabularyKey OccasionToCelebrate { get; internal set; }
        public VocabularyKey DateOfOccasion { get; internal set; }
    }
}
