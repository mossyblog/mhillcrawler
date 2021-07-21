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
    public class LoyaltyClueProducer : BaseClueProducer<Loyalty>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<LoyaltyClueProducer> _log;

        public LoyaltyClueProducer([NotNull] IClueFactory factory, ILogger<LoyaltyClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Loyalty input, Guid id)
        {
            var vocab = new LoyaltyVocabulary();

            var clue = _factory.Create(vocab.Grouping, input.LoyaltyID, id);

            //Create Edges
            //if (!string.IsNullOrEmpty(input.LoyaltyID))
            //{
            //    _factory.CreateOutgoingEntityReference(clue, vocab.Grouping, EntityEdgeType.At, input, input.LoyaltyID);
            //}

            var data = clue.Data.EntityData;

            data.Codes.Add(new EntityCode(vocab.Grouping, "Global", input.LoyaltyID));

            data.Properties[vocab.LoyaltyID] = input.LoyaltyID.PrintIfAvailable();
            data.Properties[vocab.LoyaltyNumber] = input.LoyaltyNumber.PrintIfAvailable();
            data.Properties[vocab.CustomerID] = input.CustomerID.PrintIfAvailable();
            data.Properties[vocab.IsLoyalty] = input.IsLoyalty.PrintIfAvailable();
            data.Properties[vocab.LegalEntity] = input.LegalEntity.PrintIfAvailable();
            data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
            data.Properties[vocab.ExternalModifiedOn] = input.ExternalModifiedOn.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();

            return clue;
        }
    }
}
