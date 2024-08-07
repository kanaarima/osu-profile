using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static osu_stats.Akatsuki;
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
            var stats = ContainerForm.GetStats();
            var settings = Settings.Load();
            var filestreams = FileStreams.Load();
            GameModeBox.SelectedIndex = settings.DefaultGameMode;
            UserIDBox.Value = settings.UserID;
            PlaytimeOffset.Value = settings.StdRxPlayTimeOffset;
            foreach (var key in settings.Fields.Keys) {
                FieldsBox.Items.Add(key, settings.Fields[key]);
            }
            foreach (var filestream in filestreams.streams) {
                FileStreamBox.Items.Add(filestream.path);
            }
            foreach (var key in stats.Keys) {
                AvailableVarBox.Items.Add(key);
            }
            this.Size = new Size(498, 424);
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
            settings.StdRxPlayTimeOffset = (int)PlaytimeOffset.Value;
            settings.DefaultGameMode = GameModeBox.SelectedIndex;
            settings.UserID = (int)UserIDBox.Value;
            settings.Save();
            Program.RestartApplication();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 0) {
                this.Size = new Size(498, 424);
            } else {
                this.Size = new Size(728, 432);
            }
        }

        private void FileStreamBox_SelectedIndexChanged(object sender, EventArgs e) {
            var filestreams = FileStreams.Load();
            var stream = filestreams.streams[FileStreamBox.SelectedIndex];
            var stats = ContainerForm.GetStats();
            FileStreamContentBox.Text = stream.content;
            JsonBtn.Checked = stream.json;
            TextBtn.Checked = !stream.json;
            ResultBox.Text = stream.Compile(stats);
        }

        private void JsonBtn_CheckedChanged(object sender, EventArgs e) {
            FileStreamContentBox.Enabled = false;
        }

        private void TextBtn_CheckedChanged(object sender, EventArgs e) {
            FileStreamContentBox.Enabled = true;
        }

        private void FileStreamContentBox_TextChanged(object sender, EventArgs e) {
            var filestreams = FileStreams.Load();
            var stats = ContainerForm.GetStats();
            var stream = filestreams.streams[FileStreamBox.SelectedIndex];
            stream.content = FileStreamContentBox.Text;
            ResultBox.Text = stream.Compile(stats);
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            var filestreams = FileStreams.Load();
            var stream = filestreams.streams[FileStreamBox.SelectedIndex];
            stream.content = FileStreamContentBox.Text;
            stream.json = JsonBtn.Checked;
            filestreams.Save();
        }

        private void DeleteStreamButton_Click(object sender, EventArgs e) {
            var filestreams = FileStreams.Load();
            filestreams.streams.RemoveAt(FileStreamBox.SelectedIndex);
            FileStreamBox.Items.RemoveAt(FileStreamBox.SelectedIndex);
            filestreams.Save();
            FileStreamContentBox.Text = "";
            ResultBox.Text = "";
        }

        private void NewStreamButton_Click(object sender, EventArgs e) {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Text file/JSON file Text|*.txt|JSON|*.json";
            dialog.DefaultExt = "text";
            dialog.AddExtension = true;
            if (dialog.ShowDialog() == DialogResult.OK) {
                var filestreams = FileStreams.Load();
                var stream = new FileStream();
                stream.path = dialog.FileName;
                stream.content = "Ranked score: $ranked_score $ranked_score_change\r\nClears: $clears $clears_change\r\n #1: $firsts $firsts_change\r\n PP: $pp $pp_change";
                stream.json = false;
                filestreams.streams.Add(stream);
                filestreams.Save();
                FileStreamBox.Items.Add(stream.path);
                FileStreamBox.SelectedIndex = FileStreamBox.Items.Count;
            }
        }
    }
}
