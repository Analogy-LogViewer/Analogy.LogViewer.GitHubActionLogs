using Analogy.Interfaces;
using Analogy.LogViewer.GitHubActionLogs.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Analogy.LogViewer.GitHubActionLogs.IAnalogy
{
    public class PrimaryFactory : Analogy.LogViewer.Template.PrimaryFactory
    {
        internal static Guid Id { get; } = new Guid("b4e4fd75-4d20-4dfa-8d1e-b93cf1737992");
        public override Guid FactoryId { get; set; } = Id;
        public override string Title { get; set; } = "GitHub Actions Log";
        public override IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; } = ChangeLogList.GetChangeLog();
        public override IEnumerable<string> Contributors { get; set; } = new List<string> { "Lior Banai" };
        public override string About { get; set; } = "Analogy Log Parser for GitHub Actions Log";
        public override Image? SmallImage { get; set; } = Resources.actions16x16;
        public override Image? LargeImage { get; set; } = Resources.actions32x32;


    }
}
