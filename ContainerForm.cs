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
            fields.Add((NextScoreRankLabel, NextScoreRankBox, NextScoreRankGain));
            fields.Add((NextPPRankLabel, NextPPRankBox, NextPPRankGain));
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

        private Dictionary<string, string> GetStats() {
            var dict = new Dictionary<string, string>();
            var settings = Settings.Load();
            if (settings.NewJson == null || settings.OldJson == null)
                return dict;
            var mode = settings.DefaultGameMode;
            var response_new = JsonConvert.DeserializeObject<UserInfo>(settings.NewJson);
            var response_old = JsonConvert.DeserializeObject<UserInfo>(settings.OldJson);
            var new_stats = ReorganiseStats(response_new);
            var old_stats = ReorganiseStats(response_old);
            var playtimeoffset = mode == 1 ? settings.StdRxPlayTimeOffset : 0;
            dict["global_rank"] = FormatNumber(new_stats[mode].GlobalLeaderboardRank);
            dict["global_rank_change"] = FormatGainInt(new_stats[mode].GlobalLeaderboardRank, old_stats[mode].GlobalLeaderboardRank, true);
            dict["country_rank"] = FormatNumber(new_stats[mode].CountryLeaderboardRank);
            dict["country_rank_change"] = FormatGainInt(new_stats[mode].CountryLeaderboardRank, old_stats[mode].CountryLeaderboardRank, true);
            dict["ranked_score"] = FormatNumber(new_stats[mode].RankedScore);
            dict["ranked_score_change"] = FormatGainInt((int)new_stats[mode].RankedScore, (int)old_stats[mode].RankedScore);
            dict["total_score"] = FormatNumber(new_stats[mode].TotalScore);
            dict["total_score_change"] = FormatGainInt((int)new_stats[mode].TotalScore, (int)old_stats[mode].TotalScore);
            dict["pp"] = FormatNumber(new_stats[mode].Pp);
            dict["pp_change"] = FormatGainInt((int)new_stats[mode].Pp, (int)old_stats[mode].Pp);
            dict["accuracy"] = FormatAccuracy(new_stats[mode].Accuracy);
            dict["accuracy_change"] = FormatAccuracyGain(new_stats[mode].Accuracy, old_stats[mode].Accuracy);
            dict["playtime"] = FormatPlayTime(new_stats[mode].Playtime - playtimeoffset);
            dict["playtime_change"] = FormatPlayTimeGain(new_stats[mode].Playtime, old_stats[mode].Playtime);
            dict["playcount"] = FormatNumber(new_stats[mode].Playcount);
            dict["playcount_change"] = FormatGainInt((int)new_stats[mode].Playcount, (int)old_stats[mode].Playcount);
            dict["total_hits"] = FormatNumber(new_stats[mode].TotalHits);
            dict["total_hits_change"] = FormatGainInt((int)new_stats[mode].TotalHits, (int)old_stats[mode].TotalHits);
            dict["clears"] = FormatNumber(settings.Clears[mode]);
            dict["clears_change"] = FormatGainInt(settings.Clears[mode], settings.ClearsOld[mode]);
            if (settings.ScoreRank != null) {
                dict["score_rank"] = FormatNumber(settings.ScoreRank[mode]);
                dict["score_rank_change"] = FormatGainInt(settings.ScoreRank[mode], settings.ScoreRankOld[mode]);
            }
            if (settings.Firsts != null && settings.FirstsOld != null) {
                dict["firsts"] = FormatNumber(settings.Firsts[mode]);
                dict["firsts_change"] = FormatGainInt(settings.Firsts[mode], settings.FirstsOld[mode]);
            }
            if (settings.NextScoreRank != null) {
                dict["next_rank_score"] = FormatNumber(settings.NextScoreRank[mode]);
                dict["next_rank_score_needed"] = FormatNumber(settings.NextScoreRank[mode] - new_stats[mode].RankedScore);
            }
            if (settings.NextPPRank != null) {
                dict["next_rank_pp"] = FormatNumber(settings.NextPPRank[mode]);
                dict["next_rank_pp_needed"] = FormatNumber(settings.NextPPRank[mode] - new_stats[mode].Pp);
            }
            dict["ssh"] = FormatNumber(new_stats[mode].Grades.XhCount);
            dict["ssh_change"] = FormatGainInt(new_stats[mode].Grades.XhCount, old_stats[mode].Grades.XhCount);
            dict["ss"] = FormatNumber(new_stats[mode].Grades.XCount);
            dict["ss_change"] = FormatGainInt(new_stats[mode].Grades.XCount, old_stats[mode].Grades.XCount);
            dict["sh"] = FormatNumber(new_stats[mode].Grades.ShCount);
            dict["sh_change"] = FormatGainInt(new_stats[mode].Grades.ShCount, old_stats[mode].Grades.ShCount);
            dict["s"] = FormatNumber(new_stats[mode].Grades.SCount);
            dict["s_change"] = FormatGainInt(new_stats[mode].Grades.SCount, old_stats[mode].Grades.SCount);
            dict["a"] = FormatNumber(new_stats[mode].Grades.ACount);
            dict["a_change"] = FormatGainInt(new_stats[mode].Grades.ACount, old_stats[mode].Grades.ACount);
            dict["b"] = FormatNumber(new_stats[mode].Grades.BCount);
            dict["b_change"] = FormatGainInt(new_stats[mode].Grades.BCount, old_stats[mode].Grades.BCount);
            dict["c"] = FormatNumber(new_stats[mode].Grades.CCount);
            dict["c_change"] = FormatGainInt(new_stats[mode].Grades.CCount, old_stats[mode].Grades.CCount);
            dict["d"] = FormatNumber(new_stats[mode].Grades.DCount);
            dict["d_change"] = FormatGainInt(new_stats[mode].Grades.DCount, old_stats[mode].Grades.DCount);
            return dict;
        }

        private void ReloadStats() {
            var settings = Settings.Load();
            if (settings.NewJson == null || settings.OldJson == null)
                return;
            var modes = new string[] { "Standard", "Standard RX", "Standard AP", "Taiko", "Taiko RX", "Ctb", "Ctb RX", "Mania" };
            var mode = settings.DefaultGameMode;
            var response_new = JsonConvert.DeserializeObject<UserInfo>(settings.NewJson);
            var info = GetStats();
            GlobalRankBox.Text = info["global_rank"];
            GlobalRankGainBox.Text = info["global_rank_change"];
            CountryRankBox.Text = info["country_rank"];
            CountryRankGainBox.Text = info["country_rank_change"];
            RankedScoreBox.Text = info["ranked_score"];
            RankedScoreGainBox.Text = info["ranked_score_change"];
            TotalScoreBox.Text = info["total_score"];
            TotalScoreGainBox.Text = info["total_score_change"];
            PpBox.Text = info["pp"];
            PpGainBox.Text = info["pp_change"];
            AccuracyBox.Text = info["accuracy"];
            AccuracyGainBox.Text = info["accuracy_change"];
            PlayTimeBox.Text = info["playtime"];
            PlayTimeGainBox.Text = info["playtime_change"];
            PlayCountBox.Text = info["playcount"];
            PlayCountGainBox.Text = info["playcount_change"];
            TotalHitsBox.Text = info["total_hits"];
            TotalHitsGainBox.Text = info["total_hits_change"];
            ClearsBox.Text = info["clears"];
            ClearsBoxGain.Text = info["clears_change"];
            if (settings.ScoreRank != null) {
                ScoreRankBox.Text = info["score_rank"];
                ScoreRankGainBox.Text = info["score_rank_change"];
            }
            if (settings.Firsts != null && settings.FirstsOld != null) {
                FirstsBox.Text = info["firsts"];
                FirstsBoxGain.Text = info["firsts_change"];
            }
            if (settings.NextScoreRank != null) {
                NextScoreRankBox.Text = info["next_rank_score"];
                NextScoreRankGain.Text = info["next_rank_score_needed"];
            }
            if (settings.NextPPRank != null) {
                NextPPRankBox.Text = info["next_rank_pp"];
                NextPPRankGain.Text = info["next_rank_pp_needed"];
            }
            SSHBox.Text = info["ssh"];
            SSHGainBox.Text = info["ssh_change"];
            SSBox.Text = info["ss"];
            SSGainBox.Text = info["ss_change"];
            SHBox.Text = info["sh"];
            SHGainBox.Text = info["sh_change"];
            SBox.Text = info["s"];
            SGainBox.Text = info["s_change"];
            ABox.Text = info["a"];
            AGainBox.Text = info["a_change"];
            BBox.Text = info["b"];
            BGainBox.Text = info["b_change"];
            CBox.Text = info["c"];
            CGainBox.Text = info["c_change"];
            DBox.Text = info["d"];
            DGainBox.Text = info["d_change"];
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