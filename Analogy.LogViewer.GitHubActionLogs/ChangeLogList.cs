using Analogy.Interfaces;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.GitHubActionLogs
{
    static class ChangeLogList
    {
        public static IEnumerable<AnalogyChangeLog> GetChangeLog()
        {
            return new List<AnalogyChangeLog>{
                new AnalogyChangeLog("Initial version", AnalogChangeLogType.None, "Lior Banai", new DateTime(2020, 11, 27)
                )
            };
        }
    }
}
