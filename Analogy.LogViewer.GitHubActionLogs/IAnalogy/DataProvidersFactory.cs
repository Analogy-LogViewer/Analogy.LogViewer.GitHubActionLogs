using Analogy.Interfaces;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GitHubActionLogs.IAnalogy
{
    public class DataProvidersFactory : LogViewer.Template.DataProvidersFactory
    {
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override string Title { get; set; } = "Log Parsers";
        public override IEnumerable<IAnalogyDataProvider> DataProviders { get; set; } = new List<IAnalogyDataProvider>
        {
            new OfflineDataProvider()
        };
    }
}
