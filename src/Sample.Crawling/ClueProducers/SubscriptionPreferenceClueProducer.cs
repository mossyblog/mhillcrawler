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
    public class SubscriptionPreferenceClueProducer : BaseClueProducer<SubscriptionPreference>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<SubscriptionPreferenceClueProducer> _log;

        public SubscriptionPreferenceClueProducer([NotNull] IClueFactory factory, ILogger<SubscriptionPreferenceClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(SubscriptionPreference input, Guid id)
        {
            var vocab = new SubscriptionPreferenceVocabulary();

            var clue = _factory.Create(vocab.Grouping, input.CustomerID, id);

            //Create Edges
            //if (!string.IsNullOrEmpty(input.SubscriptionPreferenceID))
            //{
            //    _factory.CreateOutgoingEntityReference(clue, vocab.Grouping, EntityEdgeType.At, input, input.SubscriptionPreferenceID);
            //}

            var data = clue.Data.EntityData;

            data.Codes.Add(new EntityCode(vocab.Grouping, "Global", input.CustomerID));

            data.Properties[vocab.CustomerID] = input.CustomerID.PrintIfAvailable();
            data.Properties[vocab.SubscriptionType] = input.SubscriptionType.PrintIfAvailable();
            data.Properties[vocab.EmailPreference] = input.EmailPreference.PrintIfAvailable();
            data.Properties[vocab.GlobalPreference] = input.GlobalPreference.PrintIfAvailable();
            data.Properties[vocab.PhonePreference] = input.PhonePreference.PrintIfAvailable();
            data.Properties[vocab.SmsPreference] = input.SmsPreference.PrintIfAvailable();
            data.Properties[vocab.DirectMailPreference] = input.DirectMailPreference.PrintIfAvailable();
            data.Properties[vocab.SourceModifiedOn] = input.SourceModifiedOn.PrintIfAvailable();
            data.Properties[vocab.SourceCreatedOn] = input.SourceCreatedOn.PrintIfAvailable();
            data.Properties[vocab.Status] = input.Status.PrintIfAvailable();

            return clue;
        }
    }
}
