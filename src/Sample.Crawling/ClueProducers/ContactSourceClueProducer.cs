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
    public class ContactSourceClueProducer : BaseClueProducer<ContactSource>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<ContactSourceClueProducer> _log;

        public ContactSourceClueProducer([NotNull] IClueFactory factory, ILogger<ContactSourceClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(ContactSource input, Guid id)
        {
            var vocab = new ContactSourceVocabulary();

            var clue = _factory.Create(vocab.Grouping, input.CustomerID, id);

            //Create Edges
            //if (!string.IsNullOrEmpty(input.ContactSourceID))
            //{
            //    _factory.CreateOutgoingEntityReference(clue, vocab.Grouping, EntityEdgeType.At, input, input.ContactSourceID);
            //}

            var data = clue.Data.EntityData;

            data.Codes.Add(new EntityCode(vocab.Grouping, "Global", input.CustomerID));

            data.Properties[vocab.CustomerID] = input.CustomerID.PrintIfAvailable();
            data.Properties[vocab.Source] = input.Source.PrintIfAvailable();
            data.Properties[vocab.SourceID] = input.SourceID.PrintIfAvailable();
            data.Properties[vocab.CreatedOn] = input.CreatedOn.PrintIfAvailable();
            data.Properties[vocab.IsDeleted] = input.IsDeleted.PrintIfAvailable();

            return clue;
        }
    }
}
