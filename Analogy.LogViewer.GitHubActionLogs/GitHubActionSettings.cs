using Analogy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Analogy.LogViewer.GitHubActionLogs
{
    public class GitHubActionSettings
    {
        public Dictionary<AnalogyLogLevel, List<string>> LogLevelText { get; set; }

        public GitHubActionSettings()
        {
            LogLevelText = new Dictionary<AnalogyLogLevel, List<string>>();
            var loglevels = Enum.GetValues(typeof(AnalogyLogLevel)).Cast<AnalogyLogLevel>();
            foreach (AnalogyLogLevel loglevel in loglevels)
            {
                LogLevelText[loglevel] = new List<string>();
            }
        }
    }
}
