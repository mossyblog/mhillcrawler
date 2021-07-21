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
    public class CustomerClueProducer : BaseClueProducer<Customer>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<CustomerClueProducer> _log;

        public CustomerClueProducer([NotNull] IClueFactory factory, ILogger<CustomerClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Customer input, Guid id)
        {
            var vocab = new CustomerVocabulary();

            var clue = _factory.Create(vocab.Grouping, input.CustomerID, id);

            //Create Edges
            if (!string.IsNullOrEmpty(input.CustomerID))
            {
                _factory.CreateOutgoingEntityReference(clue, vocab.Grouping, EntityEdgeType.At, input, input.CustomerID);
            }

            var data = clue.Data.EntityData;

            data.Codes.Add(new EntityCode(vocab.Grouping, "Global", input.CustomerID));

            data.Properties[vocab.CustomerID] = input.CustomerID.PrintIfAvailable();
            data.Properties[vocab.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[vocab.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[vocab.Email] = input.Email.PrintIfAvailable();
            data.Properties[vocab.MobileNumber] = input.MobileNumber.PrintIfAvailable();
            data.Properties[vocab.DateOfBirth] = input.DateOfBirth.PrintIfAvailable();
            data.Properties[vocab.AddressLine1] = input.AddressLine1.PrintIfAvailable();
            data.Properties[vocab.AddressLine2] = input.AddressLine2.PrintIfAvailable();
            data.Properties[vocab.City] = input.City.PrintIfAvailable();
            data.Properties[vocab.State] = input.State.PrintIfAvailable();
            data.Properties[vocab.Country] = input.Country.PrintIfAvailable();
            data.Properties[vocab.Postcode] = input.Postcode.PrintIfAvailable();
            data.Properties[vocab.SourceCreatedDate] = input.SourceCreatedDate.PrintIfAvailable();
            data.Properties[vocab.SourceModifiedDate] = input.SourceModifiedDate.PrintIfAvailable();
            data.Properties[vocab.ActiveStatus] = input.ActiveStatus.PrintIfAvailable();
            data.Properties[vocab.IsDeleted] = input.IsDeleted.PrintIfAvailable();
            data.Properties[vocab.Gender] = input.Gender.PrintIfAvailable();

            return clue;
        }
    }
}
