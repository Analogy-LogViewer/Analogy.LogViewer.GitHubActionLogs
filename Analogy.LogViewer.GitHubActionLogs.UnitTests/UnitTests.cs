using Analogy.Interfaces;
using Analogy.LogViewer.GitHubActionLogs.IAnalogy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.LogViewer.GitHubActionLogs.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var parser = new OfflineDataProvider();
            await parser.InitializeDataProviderAsync(null);
            var results = await parser.Process("1_Codacy Security Scan.txt", new CancellationToken(), new MessageHandlerForTesting());
            Assert.IsTrue(Enumerable.Count<AnalogyLogMessage>(results) == 1230);


        }
        [TestMethod]
        public async Task TestMethod2()
        {
            var parser = new OfflineDataProvider();
            await parser.InitializeDataProviderAsync(null);
            var results = await parser.Process("1_build (Debug).txt", new CancellationToken(), new MessageHandlerForTesting());
            Assert.IsTrue(Enumerable.Count<AnalogyLogMessage>(results) == 4532);


        }
    }
}
