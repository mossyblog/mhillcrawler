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
    public class CustomerInterestClueProducer : BaseClueProducer<CustomerInterest>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<CustomerInterestClueProducer> _log;

        public CustomerInterestClueProducer([NotNull] IClueFactory factory, ILogger<CustomerInterestClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(CustomerInterest input, Guid id)
        {
            var vocab = new CustomerInterestVocabulary();

            var clue = _factory.Create(vocab.Grouping, input.CustomerID, id);

            //Create Edges
            //if (!string.IsNullOrEmpty(input.CustomerInterestID))
            //{
            //    _factory.CreateOutgoingEntityReference(clue, vocab.Grouping, EntityEdgeType.At, input, input.CustomerInterestID);
            //}

            var data = clue.Data.EntityData;

            data.Codes.Add(new EntityCode(vocab.Grouping, "Global", input.CustomerID));

            data.Properties[vocab.CustomerID] = input.CustomerID.PrintIfAvailable();
            data.Properties[vocab.InterestID] = input.InterestID.PrintIfAvailable();
            data.Properties[vocab.InterestValue] = input.InterestValue.PrintIfAvailable();
            data.Properties[vocab.Interest1] = input.Interest1.PrintIfAvailable();
            data.Properties[vocab.Interest2] = input.Interest2.PrintIfAvailable();
            data.Properties[vocab.Interest3] = input.Interest3.PrintIfAvailable();
            data.Properties[vocab.Interest4] = input.Interest4.PrintIfAvailable();
            data.Properties[vocab.LegalEntity] = input.LegalEntity.PrintIfAvailable();

            return clue;
        }
    }
}
