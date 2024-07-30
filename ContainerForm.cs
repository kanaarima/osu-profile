using Newtonsoft.Json;
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

        public ContainerForm() {
            InitializeComponent();
        }

        private void StatsUI_Load(object sender, EventArgs e) {
            var settings = Settings.Load();
            settings.Save();
            minBtn.FlatAppearance.BorderColor = minBtn.BackColor;
            closeBtn.FlatAppearance.BorderColor = closeBtn.BackColor;
            Daemon daemon = new Daemon();
            daemon.Start();
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

        private string FormatPlayTime(int totalMinutes) {
            int hours = totalMinutes / 60 / 60;
            int minutes = totalMinutes % 60;
            return string.Format("{0:#,##0}h ", hours) + string.Format("{0:#,##0}m", minutes);
        }

        private string FormatPlayTimeGain(int new_minutes, int old_minutes) {
            int totalMinutes = new_minutes - old_minutes;
            if (totalMinutes == 0)
                return "";
            int hours = totalMinutes / 60 / 60;
            int minutes = totalMinutes % 60;
            return string.Format("+{0:#,##0}h ", hours) + string.Format("{0:#,##0}m", minutes);
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
            PlayTimeBox.Text = FormatPlayTime(new_stats[mode].Playtime);
            PlayTimeGainBox.Text = FormatPlayTimeGain(new_stats[mode].Playtime, old_stats[mode].Playtime);
            PlayCountBox.Text = FormatNumber(new_stats[mode].Playcount);
            PlayCountGainBox.Text = FormatGainInt((int)new_stats[mode].Playcount, (int)old_stats[mode].Playcount);
            TotalHitsBox.Text = FormatNumber(new_stats[mode].TotalHits);
            ClearsBoxGain.Text = FormatGainInt((int)new_stats[mode].TotalHits, (int)old_stats[mode].TotalHits);
            ClearsBox.Text = FormatNumber(settings.Clears[mode]);
            ClearsBoxGain.Text = FormatGainInt(settings.Clears[mode], settings.ClearsOld[mode]);
            if (settings.ScoreRank != null) {
                ScoreRankBox.Text = FormatNumber(settings.ScoreRank[mode]);
                ScoreRankGainBox.Text = FormatGainInt(settings.ScoreRank[mode], settings.ScoreRankOld[mode]);

            }
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