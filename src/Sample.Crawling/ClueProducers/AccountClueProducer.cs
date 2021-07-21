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
    public class AccountClueProducer : BaseClueProducer<Account>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<AccountClueProducer> _log;

        public AccountClueProducer([NotNull] IClueFactory factory, ILogger<AccountClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Account input, Guid id)
        {
            var vocab = new AccountVocabulary();

            var clue = _factory.Create(vocab.Grouping, input.AccountID, id);

            //Create Edges
            //if (!string.IsNullOrEmpty(input.AccountID))
            //{
            //    _factory.CreateOutgoingEntityReference(clue, vocab.Grouping, EntityEdgeType.At, input, input.AccountID);
            //}

            var data = clue.Data.EntityData;

            data.Codes.Add(new EntityCode(vocab.Grouping, "Global", input.AccountID));

            data.Properties[vocab.AccountID] = input.AccountID.PrintIfAvailable();
            data.Properties[vocab.AccountStatus] = input.AccountStatus.PrintIfAvailable();
            data.Properties[vocab.City] = input.City.PrintIfAvailable();
            data.Properties[vocab.Country] = input.Country.PrintIfAvailable();
            data.Properties[vocab.Company] = input.Company.PrintIfAvailable();
            data.Properties[vocab.LocationName] = input.LocationName.PrintIfAvailable();
            data.Properties[vocab.LocationNumber] = input.LocationNumber.PrintIfAvailable();
            data.Properties[vocab.Region] = input.Region.PrintIfAvailable();
            data.Properties[vocab.State] = input.State.PrintIfAvailable();

            return clue;
        }
    }
}
