using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Reflection;
using System.Security.Policy;

namespace osu_stats
{
    internal static class Program
    {

        static readonly string VERSION = "6";

        [STAThread]
        static void Main() {
            Trace.Listeners.Add(new TextWriterTraceListener("logfile.txt"));
            Trace.AutoFlush = true;
            TraceSwitch traceSwitch = new TraceSwitch("General", "Entire Application");
            traceSwitch.Level = TraceLevel.Info;

            ApplicationConfiguration.Initialize();
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            Application.ThreadException += ThreadExceptionTrapper;

            var update = CheckForUpdates();
            if (update != null) {
                DialogResult result = MessageBox.Show(
                    $"{update}\n\nClick yes to redirect to website",
                    "Update available",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes) {
                    Process.Start(new ProcessStartInfo {
                        FileName = "https://github.com/kanaarima/osu-profile/releases",
                        UseShellExecute = true
                    });
                    return;
                }
            }
            Application.Run(new ContainerForm());
        }

        static void ThreadExceptionTrapper(object sender, System.Threading.ThreadExceptionEventArgs e) {
            LogException(e.Exception);
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e) {
            LogException((Exception)e.ExceptionObject);
            Application.Exit();
        }

        public static void LogException(Exception ex) {
            string logFilePath = "error.log";
            using (StreamWriter writer = new StreamWriter(logFilePath, true)) {
                writer.WriteLine($"[{DateTime.Now}] Exception: {ex.Message}");
                writer.WriteLine($"Stack Trace: {ex.StackTrace}");
                writer.WriteLine();
            }
        }

        static string? CheckForUpdates() {
            string releasesUrl = "https://api.github.com/repos/kanaarima/osu-profile/releases/latest";

            using (HttpClient client = new HttpClient()) {
                client.DefaultRequestHeaders.Add("User-Agent", "VersionChecker");

                try {
                    string responseString = client.GetStringAsync(releasesUrl).Result;
                    JObject releaseData = JObject.Parse(responseString);
                    string latestVersion = releaseData["name"]?.ToString().TrimStart('b');
                    if (!string.Equals(VERSION, latestVersion, StringComparison.OrdinalIgnoreCase)) {
                        return (string?)releaseData["body"];
                    }
                } catch {
                    return null;
                }
            }
            return null;
        }

        public static void RestartApplication() {
            try {
                Process currentProcess = Process.GetCurrentProcess();
                string exePath = currentProcess.MainModule.FileName;
                Process.Start(exePath);
                Application.Exit();
            } catch (Exception ex) {
                MessageBox.Show($"An error occurred while restarting the application: {ex.Message}");
            }
        }

    }

}