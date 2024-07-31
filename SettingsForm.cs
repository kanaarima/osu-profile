using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static osu_stats.Daemon;

namespace osu_stats
{
    public partial class SettingsForm : Form
    {

        public bool closed = false;
        public SettingsForm() {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            var settings = Settings.Load();
            GameModeBox.SelectedIndex = settings.DefaultGameMode;
            UserIDBox.Value = settings.UserID;
            foreach (var key in settings.Fields.Keys) {
                FieldsBox.Items.Add(key, settings.Fields[key]);
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (closed)
                return;
            closed = true;
            var settings = Settings.Load();
            if (settings.UserID != (int)UserIDBox.Value) {
                settings = new Settings(); // Reset settings on user switch
                settings.Fields = new Dictionary<string, bool>();
                LeaderboardModel.Load(true).Save(); // Reset leaderboard so score rank updates
            }
            for (int i = 0; i < FieldsBox.Items.Count; i++) {
                settings.Fields[FieldsBox.Items[i].ToString()] = FieldsBox.GetItemChecked(i);
            }
            settings.DefaultGameMode = GameModeBox.SelectedIndex;
            settings.UserID = (int)UserIDBox.Value;
            settings.Save();
            Program.RestartApplication();
        }

    }
}
