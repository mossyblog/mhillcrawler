using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Sample.Core.Models;
using CluedIn.Crawling.Sample.Vocabularies;
using Microsoft.Extensions.Logging;

namespace CluedIn.Crawling.Sample.ClueProducers
{
    public class SpecialOccasionClueProducer : BaseClueProducer<SpecialOccasion>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<SpecialOccasionClueProducer> _log;

        public SpecialOccasionClueProducer([NotNull] IClueFactory factory, ILogger<SpecialOccasionClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(SpecialOccasion input, Guid id)
        {
            var vocab = new SpecialOccasionVocabulary();

            var clue = _factory.Create(vocab.Grouping, input.ContactID, id);

            //Create Edges
            //if (!string.IsNullOrEmpty(input.SpecialOccasionID))
            //{
            //    _factory.CreateOutgoingEntityReference(clue, vocab.Grouping, EntityEdgeType.At, input, input.SpecialOccasionID);
            //}

            var data = clue.Data.EntityData;

            data.Codes.Add(new EntityCode(vocab.Grouping, "Global", input.ContactID));

            data.Properties[vocab.ContactID] = input.ContactID.PrintIfAvailable();
            data.Properties[vocab.Relationship] = input.Relationship.PrintIfAvailable();
            data.Properties[vocab.Status] = input.Status.PrintIfAvailable();
            data.Properties[vocab.ModifiedOn] = input.ModifiedOn.PrintIfAvailable();
            data.Properties[vocab.OccasionToCelebrate] = input.OccasionToCelebrate.PrintIfAvailable();
            data.Properties[vocab.DateOfOccasion] = input.DateOfOccasion.PrintIfAvailable();

            return clue;
        }
    }
}
