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
    public class SamplePersonClueProducer : BaseClueProducer<SamplePerson>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<SamplePersonClueProducer> _log;

        public SamplePersonClueProducer([NotNull] IClueFactory factory, ILogger<SamplePersonClueProducer> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(SamplePerson input, Guid id)
        {
            var clue = _factory.Create("/SamplePerson", input.ID, id);
            var data = clue.Data.EntityData;

            var vocab = new SamplePersonVocabulary();

            data.Codes.Add(new EntityCode("/SamplePerson", "Global", input.ID));

            data.Properties[vocab.ID] = input.ID.PrintIfAvailable();
            data.Properties[vocab.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[vocab.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[vocab.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[vocab.Age] = input.Age.PrintIfAvailable();

            return clue;
        }
    }
}
