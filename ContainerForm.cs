using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static osu_stats.Akatsuki;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace osu_stats
{
    public partial class ContainerForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public readonly Color ForegroundColor = Color.FromArgb(130, 130, 130);
        public readonly Color ForegroundColorActivated = Color.FromArgb(170, 170, 170);
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public List<(Label, TextBox, TextBox)> fields;

        public ContainerForm() {
            InitializeComponent();
            fields = new List<(Label, TextBox, TextBox)>();
            fields.Add((ScoreRankLabel, ScoreRankBox, ScoreRankGainBox));
            fields.Add((GlobalRankLabel, GlobalRankBox, GlobalRankGainBox));
            fields.Add((CountryRankLabel, CountryRankBox, CountryRankGainBox));
            fields.Add((RankedScoreLabel, RankedScoreBox, RankedScoreGainBox));
            fields.Add((TotalScoreLabel, TotalScoreBox, TotalScoreGainBox));
            fields.Add((PpLabel, PpBox, PpGainBox));
            fields.Add((AccuracyLabel, AccuracyBox, AccuracyGainBox));
            fields.Add((PlayTimeLabel, PlayTimeBox, PlayTimeGainBox));
            fields.Add((PlayCountLabel, PlayCountBox, PlayCountGainBox));
            fields.Add((TotalHitsLabel, TotalHitsBox, TotalHitsGainBox));
            fields.Add((ClearsLabel, ClearsBox, ClearsBoxGain));
            fields.Add((FirstsLabel, FirstsBox, FirstsBoxGain));
            fields.Add((SSHLabel, SSHBox, SSHGainBox));
            fields.Add((SSLabel, SSBox, SSGainBox));
            fields.Add((SHLabel, SHBox, SHGainBox));
            fields.Add((SLabel, SBox, SGainBox));
            fields.Add((ALabel, ABox, AGainBox));
            fields.Add((BLabel, BBox, BGainBox));
            fields.Add((CLabel, CBox, CGainBox));
            fields.Add((DLabel, DBox, DGainBox));
        }

        private void StatsUI_Load(object sender, EventArgs e) {
            var settings = Settings.Load();
            if (settings.Fields == null)
                settings.Fields = new Dictionary<string, bool>();
            minBtn.FlatAppearance.BorderColor = minBtn.BackColor;
            closeBtn.FlatAppearance.BorderColor = closeBtn.BackColor;
            Daemon daemon = new Daemon();
            daemon.Start();
            int locY = 54;
            foreach (var field in fields) {
                bool show = false;
                if (settings.Fields.ContainsKey(field.Item1.Text))
                    show = settings.Fields[field.Item1.Text];
                else
                    settings.Fields[field.Item1.Text] = true;
                Trace.TraceInformation($"{field.Item1.Text} {show}");
                if (!show) {
                    field.Item1.Hide();
                    field.Item2.Hide();
                    field.Item3.Hide();
                } else {
                    field.Item1.Show();
                    field.Item2.Show();
                    field.Item3.Show();
                    field.Item1.Location = new Point(field.Item1.Location.X, locY + 1);
                    field.Item2.Location = new Point(field.Item2.Location.X, locY);
                    field.Item3.Location = new Point(field.Item3.Location.X, locY);
                    locY += 29;
                }
                InfoLabel.Location = new Point(InfoLabel.Location.X, locY + 2);
                ResetButton.Location = new Point(ResetButton.Location.X, locY - 1);
                this.Size = new Size(this.Size.Width, locY + 29);
            }
            settings.Save();
            ReloadStats();
            try {
                AvatarBox.Load($"https://a.akatsuki.gg/{settings.UserID}");
                AvatarBox.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch { }

            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void StatsUI_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void minBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e) {
            new SettingsForm().Show();
        }

        private List<Stats> ReorganiseStats(UserInfo info) {
            List<Stats> stats =
            [
                info.Stats[0].Std,
                info.Stats[1].Std,
                info.Stats[2].Std,
                info.Stats[0].Taiko,
                info.Stats[1].Taiko,
                info.Stats[0].Ctb,
                info.Stats[1].Ctb,
                info.Stats[0].Mania
            ];
            return stats;
        }

        private string FormatNumber(object number) {
            return string.Format("{0:#,##0}", number);
        }

        private string FormatGainInt(int? new_number, int? old_number, bool reversed = false) {
            if (new_number == null)
                return "";
            int gain = reversed ? (int)old_number - (int)new_number : (int)new_number - (int)old_number;
            if (gain == 0)
                return "";
            if (gain > 0)
                return string.Format("+{0:#,##0}", gain);
            return string.Format("{0:#,##0}", gain);
        }

        private string FormatAccuracy(double accuracy) {
            return string.Format("{0:0.00}%", accuracy);
        }

        private string FormatAccuracyGain(double new_acc, double old_acc) {
            var gain = new_acc - old_acc;
            if (gain == 0)
                return "";
            if (gain > 0)
                return string.Format("+{0:0.00}%", gain);
            return string.Format("{0:0.00}%", gain);
        }

        private string FormatPlayTime(int totalSeconds) {
            TimeSpan t = TimeSpan.FromSeconds(totalSeconds);
            return string.Format("{0:#,##0}h {1:D2}m", (int)t.TotalHours, t.Minutes);
        }

        private string FormatPlayTimeGain(int new_seconds, int old_seconds) {
            int totalSeconds = new_seconds - old_seconds;
            if (totalSeconds == 0)
                return "";
            TimeSpan t = TimeSpan.FromSeconds(totalSeconds);
            return string.Format("{0:#,##0}h {1:D2}m", (int)t.TotalHours, t.Minutes);
        }

        private void ReloadStats() {
            var settings = Settings.Load();
            if (settings.NewJson == null || settings.OldJson == null)
                return;
            var modes = new string[] { "Standard", "Standard RX", "Standard AP", "Taiko", "Taiko RX", "Ctb", "Ctb RX", "Mania" };
            var mode = settings.DefaultGameMode;
            var response_new = JsonConvert.DeserializeObject<UserInfo>(settings.NewJson);
            var response_old = JsonConvert.DeserializeObject<UserInfo>(settings.OldJson);
            var new_stats = ReorganiseStats(response_new);
            var old_stats = ReorganiseStats(response_old);
            var playtimeoffset = mode == 1 ? settings.StdRxPlayTimeOffset : 0;
            GlobalRankBox.Text = FormatNumber(new_stats[mode].GlobalLeaderboardRank);
            GlobalRankGainBox.Text = FormatGainInt(new_stats[mode].GlobalLeaderboardRank, old_stats[mode].GlobalLeaderboardRank, true);
            CountryRankBox.Text = FormatNumber(new_stats[mode].CountryLeaderboardRank);
            CountryRankGainBox.Text = FormatGainInt(new_stats[mode].CountryLeaderboardRank, old_stats[mode].CountryLeaderboardRank, true);
            RankedScoreBox.Text = FormatNumber(new_stats[mode].RankedScore);
            RankedScoreGainBox.Text = FormatGainInt((int)new_stats[mode].RankedScore, (int)old_stats[mode].RankedScore);
            TotalScoreBox.Text = FormatNumber(new_stats[mode].TotalScore);
            TotalScoreGainBox.Text = FormatGainInt((int)new_stats[mode].TotalScore, (int)old_stats[mode].TotalScore);
            PpBox.Text = FormatNumber(new_stats[mode].Pp);
            PpGainBox.Text = FormatGainInt((int)new_stats[mode].Pp, (int)old_stats[mode].Pp);
            AccuracyBox.Text = FormatAccuracy(new_stats[mode].Accuracy);
            AccuracyGainBox.Text = FormatAccuracyGain(new_stats[mode].Accuracy, old_stats[mode].Accuracy);
            PlayTimeBox.Text = FormatPlayTime(new_stats[mode].Playtime-playtimeoffset);
            PlayTimeGainBox.Text = FormatPlayTimeGain(new_stats[mode].Playtime, old_stats[mode].Playtime);
            PlayCountBox.Text = FormatNumber(new_stats[mode].Playcount);
            PlayCountGainBox.Text = FormatGainInt((int)new_stats[mode].Playcount, (int)old_stats[mode].Playcount);
            TotalHitsBox.Text = FormatNumber(new_stats[mode].TotalHits);
            TotalHitsGainBox.Text = FormatGainInt((int)new_stats[mode].TotalHits, (int)old_stats[mode].TotalHits);
            ClearsBoxGain.Text = FormatGainInt((int)new_stats[mode].TotalHits, (int)old_stats[mode].TotalHits);
            ClearsBox.Text = FormatNumber(settings.Clears[mode]);
            ClearsBoxGain.Text = FormatGainInt(settings.Clears[mode], settings.ClearsOld[mode]);
            if (settings.ScoreRank != null) {
                ScoreRankBox.Text = FormatNumber(settings.ScoreRank[mode]);
                ScoreRankGainBox.Text = FormatGainInt(settings.ScoreRank[mode], settings.ScoreRankOld[mode]);
            }
            if (settings.Firsts != null && settings.FirstsOld != null) {
                FirstsBox.Text = FormatNumber(settings.Firsts[mode]);
                FirstsBoxGain.Text = FormatGainInt(settings.Firsts[mode], settings.FirstsOld[mode]);
            }
            SSHBox.Text = FormatNumber(new_stats[mode].Grades.XhCount);
            SSHGainBox.Text = FormatGainInt(new_stats[mode].Grades.XhCount, old_stats[mode].Grades.XhCount);
            SSBox.Text = FormatNumber(new_stats[mode].Grades.XCount);
            SSGainBox.Text = FormatGainInt(new_stats[mode].Grades.XCount, old_stats[mode].Grades.XCount);
            SHBox.Text = FormatNumber(new_stats[mode].Grades.ShCount);
            SHGainBox.Text = FormatGainInt(new_stats[mode].Grades.ShCount, old_stats[mode].Grades.ShCount);
            SBox.Text = FormatNumber(new_stats[mode].Grades.SCount);
            SGainBox.Text = FormatGainInt(new_stats[mode].Grades.SCount, old_stats[mode].Grades.SCount);
            ABox.Text = FormatNumber(new_stats[mode].Grades.ACount);
            AGainBox.Text = FormatGainInt(new_stats[mode].Grades.ACount, old_stats[mode].Grades.ACount);
            BBox.Text = FormatNumber(new_stats[mode].Grades.BCount);
            BGainBox.Text = FormatGainInt(new_stats[mode].Grades.BCount, old_stats[mode].Grades.BCount);
            CBox.Text = FormatNumber(new_stats[mode].Grades.CCount);
            CGainBox.Text = FormatGainInt(new_stats[mode].Grades.CCount, old_stats[mode].Grades.CCount);
            DBox.Text = FormatNumber(new_stats[mode].Grades.DCount);
            DGainBox.Text = FormatGainInt(new_stats[mode].Grades.DCount, old_stats[mode].Grades.DCount);
            InfoLabel.Text = $"{response_new.Username}'s {modes[mode]} session.";
        }

        private void Timer_Tick(object sender, EventArgs e) {
            ReloadStats();
        }

        private void button1_Click(object sender, EventArgs e) {
            var settings = Settings.Load();
            if (settings.ScoreRank != null) {
                settings.ScoreRankOld = (int[])settings.ScoreRank.Clone();
            }
            if (settings.ClearsOld != null) {
                settings.ClearsOld = (int[])settings.Clears.Clone();
            }
            settings.OldJson = settings.NewJson;
            settings.Save();
            ReloadStats();
        }
    }


}