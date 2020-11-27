using Analogy.Interfaces;
using Analogy.LogViewer.GitHubActionLogs.Managers;
using System.Windows.Forms;

namespace Analogy.LogViewer.GitHubActionLogs
{
    public partial class SettingsForm : Form
    {
        public AnalogyLogLevel CurrentLogLevel { get; set; }
        public string? SelectedTextItem { get; set; }
        public GitHubActionSettings Settings => UserSettingsManager.UserSettings.Settings;
        public SettingsForm()
        {

            InitializeComponent();
        }

        private void listboxLogLevel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CurrentLogLevel = (AnalogyLogLevel)listboxLogLevel.SelectedItem;
            lblCurrentLogLevel.Text = $"Add new Text for log level {CurrentLogLevel}:";
            SelectedTextItem = null;
            lblSelectedText.Text = "N/A";
            listTextsForLogLevel.DataSource = Settings.LogLevelText[CurrentLogLevel];

        }

        private void listTextsForLogLevel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SelectedTextItem = lblSelectedText.Text = listTextsForLogLevel.SelectedItem as string;
        }

        private void SettingsForm_Load(object sender, System.EventArgs e)
        {
            if (DesignMode)
            {
                return;

            }

            listboxLogLevel.DataSource = Settings.LogLevelText.Keys;

        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedTextItem))
            {
                return;
            }

            Settings.LogLevelText[CurrentLogLevel].Remove(SelectedTextItem);
            listTextsForLogLevel.DataSource = Settings.LogLevelText[CurrentLogLevel];
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textForLog.Text) || Settings.LogLevelText[CurrentLogLevel].Contains(textForLog.Text))
            {
                return;
            }
            Settings.LogLevelText[CurrentLogLevel].Add(textForLog.Text);
        }
    }
}
