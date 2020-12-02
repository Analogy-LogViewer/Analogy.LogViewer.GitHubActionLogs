using Analogy.Interfaces;
using Analogy.LogViewer.GitHubActionLogs.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.LogViewer.GitHubActionLogs.Parser
{
    public class GitHubActionPlainTextLogFileLoader
    {
        public GitHubActionSettings Settings => UserSettingsManager.UserSettings.Settings;

        public async Task<IEnumerable<AnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"File is null or empty. Aborting.",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, GetFileNameAsDataSource(fileName));
                return new List<AnalogyLogMessage> { empty };
            }
            List<AnalogyLogMessage> messages = new List<AnalogyLogMessage>();
            try
            {
                AnalogyLogMessage? entry = null;
                using (var stream = File.OpenRead(fileName))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = await reader.ReadLineAsync();
                            var indexOfFirstSpace = line.IndexOf(' ');
                            if (indexOfFirstSpace == 28 && DateTime.TryParse(line.Substring(0, indexOfFirstSpace), out var dateTime))
                            {
                                if (entry != null)
                                {
                                    messages.Add(entry);
                                }

                                string data = line.Substring(indexOfFirstSpace + 1);
                                entry = new AnalogyLogMessage();
                                entry.Text = data;
                                entry.Date = dateTime;
                                entry.Level = GetLogLevel(data);
                                entry.Id=Guid.NewGuid();
                                entry.Source = GetFileNameAsDataSource(fileName);
                                entry.Module = "";
                            }
                            else if (entry != null)
                            {
                                if (entry.Text == "")
                                {
                                    entry.Text = line;
                                }
                                else
                                {
                                    entry.Text += Environment.NewLine + line;
                                }
                            }
                        }
                    }
                }
                messagesHandler.AppendMessages(messages, fileName);
                return messages;
            }
            catch (Exception e)
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"Error occured processing file {fileName}. Reason: {e.Message}",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, GetFileNameAsDataSource(fileName));
                return new List<AnalogyLogMessage> { empty };
            }
        }

        private AnalogyLogLevel GetLogLevel(string data)
        {
            foreach (KeyValuePair<AnalogyLogLevel, List<string>> pair in Settings.LogLevelText)
            {
                if (pair.Value.Any(data.Contains))
                {
                    return pair.Key;
                }
            }

            return AnalogyLogLevel.Information;
        }


        private static string GetFileNameAsDataSource(string fileName)
        {
            string file = Path.GetFileName(fileName);
            return fileName.Equals(file) ? fileName : $"{file} ({fileName})";
        }
    }
}
