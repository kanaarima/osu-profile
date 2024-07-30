using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_stats
{
    public partial class SettingsForm : Form
    {
        public SettingsForm() {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            var settings = Settings.Load();
            GameModeBox.SelectedIndex = settings.DefaultGameMode;
            UserIDBox.Value = settings.UserID;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            var settings = Settings.Load();
            settings.DefaultGameMode = GameModeBox.SelectedIndex;
            settings.UserID = (int)UserIDBox.Value;
            settings.Save();
        }

    }
}
