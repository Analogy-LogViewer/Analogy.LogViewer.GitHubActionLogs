using Analogy.Interfaces;
using Analogy.LogViewer.GitHubActionLogs.Parser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.LogViewer.GitHubActionLogs.IAnalogy
{
    public class OfflineDataProvider : Analogy.LogViewer.Template.OfflineDataProvider
    {
        public override Image? SmallImage { get; set; } = null;
        public override Image? LargeImage { get; set; } = null;
        public override string? OptionalTitle { get; set; } = "GitHub Actions Log Parser";
        public override string FileOpenDialogFilters { get; set; } = "txt files (*.txt)|*.txt";
        public override IEnumerable<string> SupportFormats { get; set; } = new List<string> { "*.txt" };
        public override string? InitialFolderFullPath { get; set; } = null;
        public override Guid Id { get; set; } = new Guid("3cb374e9-42a5-4e4c-a586-1561bf13070b");
        private GitHubActionPlainTextLogFileLoader parser;

        public OfflineDataProvider()
        {
            parser = new GitHubActionPlainTextLogFileLoader();
        }

        public override Task<IEnumerable<AnalogyLogMessage>> Process(string fileName, CancellationToken token,
            ILogMessageCreatedHandler messagesHandler)
            => parser.Process(fileName, token, messagesHandler);
    }
}
