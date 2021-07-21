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
    public class SalesTransactionClueProducer : BaseClueProducer<SalesTransaction>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<SalesTransactionClueProducer> _log;

        public SalesTransactionClueProducer([NotNull] IClueFactory factory, ILogger<SalesTransactionClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(SalesTransaction input, Guid id)
        {
            var vocab = new SalesTransactionVocabulary();

            var clue = _factory.Create(vocab.Grouping, input.SalesID, id);

            //Create Edges
            //if (!string.IsNullOrEmpty(input.SalesTransactionID))
            //{
            //    _factory.CreateOutgoingEntityReference(clue, vocab.Grouping, EntityEdgeType.At, input, input.SalesTransactionID);
            //}

            var data = clue.Data.EntityData;

            data.Codes.Add(new EntityCode(vocab.Grouping, "Global", input.SalesID));

            data.Properties[vocab.CustomerID] = input.CustomerID.PrintIfAvailable();
            data.Properties[vocab.SalesID] = input.SalesID.PrintIfAvailable();
            data.Properties[vocab.TransactionID] = input.TransactionID.PrintIfAvailable();
            data.Properties[vocab.SalesStatus] = input.SalesStatus.PrintIfAvailable();
            data.Properties[vocab.SalesLineStatus] = input.SalesLineStatus.PrintIfAvailable();
            data.Properties[vocab.PosCustomerNumber] = input.PosCustomerNumber.PrintIfAvailable();
            data.Properties[vocab.SalesDate] = input.SalesDate.PrintIfAvailable();
            data.Properties[vocab.LineNumber] = input.LineNumber.PrintIfAvailable();
            data.Properties[vocab.ItemName] = input.ItemName.PrintIfAvailable();
            data.Properties[vocab.ItemID] = input.ItemID.PrintIfAvailable();
            data.Properties[vocab.ItemColourID] = input.ItemColourID.PrintIfAvailable();
            data.Properties[vocab.ItemSizeID] = input.ItemSizeID.PrintIfAvailable();
            data.Properties[vocab.ItemBarcode] = input.ItemBarcode.PrintIfAvailable();
            data.Properties[vocab.SalesPricePerItem] = input.SalesPricePerItem.PrintIfAvailable();
            data.Properties[vocab.Quantity] = input.Quantity.PrintIfAvailable();
            data.Properties[vocab.TaxAmount] = input.TaxAmount.PrintIfAvailable();
            data.Properties[vocab.LocationNumber] = input.LocationNumber.PrintIfAvailable();

            return clue;
        }
    }
}
