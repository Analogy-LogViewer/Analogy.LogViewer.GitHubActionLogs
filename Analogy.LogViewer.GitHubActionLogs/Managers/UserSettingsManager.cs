using Analogy.LogViewer.Template.Managers;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Analogy.LogViewer.GitHubActionLogs.Managers
{
    public class UserSettingsManager
    {
        private static readonly Lazy<UserSettingsManager> _instance =
            new Lazy<UserSettingsManager>(() => new UserSettingsManager());
        public static UserSettingsManager UserSettings { get; set; } = _instance.Value;
        public string GitHubActionLogsFileSetting { get; private set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Analogy.LogViewer", "AnalogyGitHubActionLogsSettings.json");
        public GitHubActionSettings Settings { get; set; }


        public UserSettingsManager()
        {
            if (File.Exists(GitHubActionLogsFileSetting))
            {
                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        ObjectCreationHandling = ObjectCreationHandling.Replace
                    };
                    string data = File.ReadAllText(GitHubActionLogsFileSetting);
                    Settings = JsonConvert.DeserializeObject<GitHubActionSettings>(data, settings)!;
                }
                catch (Exception ex)
                {
                    LogManager.Instance.LogException("Error loading user setting file", ex, "Analogy Power Toys Settings");
                    Settings = new GitHubActionSettings();

                }
            }
            else
            {
                Settings = new GitHubActionSettings();
            }

        }

        public void Save()
        {
            try
            {
                File.WriteAllText(GitHubActionLogsFileSetting, JsonConvert.SerializeObject(Settings));
            }
            catch (Exception e)
            {
                LogManager.Instance.LogException("Error saving settings: " + e.Message, e, "Analogy Power Toys Settings");
            }


        }
    }
}