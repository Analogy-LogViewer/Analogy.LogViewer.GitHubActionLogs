using Analogy.LogViewer.GitHubActionLogs.Managers;
using Analogy.LogViewer.GitHubActionLogs.Properties;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.GitHubActionLogs.IAnalogy
{
    public class UserSettingsFactory : Analogy.LogViewer.Template.UserSettingsFactory
    {
        public override string Title { get; set; } = "GitHub Actions User Settings";
        public override UserControl DataProviderSettings { get; set; } = new SettingsForm();
        public override Image? SmallImage { get; set; } = Resources.actions16x16;
        public override Image? LargeImage { get; set; } = Resources.actions32x32;
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override Guid Id { get; set; } = new Guid("dacd32b6-9a3d-4f13-83db-08d3fc00838c");

        public override Task SaveSettingsAsync()
        {
            UserSettingsManager.UserSettings.Save();
            return Task.CompletedTask;
        }
    }
}
