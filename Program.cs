using Newtonsoft.Json;

namespace osu_stats
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            Application.ThreadException += ThreadExceptionTrapper;
            Application.Run(new ContainerForm());
        }

        static void ThreadExceptionTrapper(object sender, System.Threading.ThreadExceptionEventArgs e) {
            // Log the exception
            LogException(e.Exception);
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e) {
            // Log the exception
            LogException((Exception)e.ExceptionObject);

            // Exit the application
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

    }

    public class Settings {
        public int UserID { get; set; }
        public int[] ClearsPage { get; set; }
        public int[] Clears {  get; set; }
        public int[] ClearsOld { get; set; }
        public int[] ScoreRank { get; set; }
        public int[] ScoreRankOld { get; set; }
        public int DefaultGameMode { get; set; }
        public string NewJson { get; set; }
        public string OldJson { get; set; }

        public static Settings Load() {
            try {
                return JsonConvert.DeserializeObject<Settings>(File.ReadAllText("settings.json"));
            } catch {
                return new Settings();
            }
        }

        public void Save() {
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }

}