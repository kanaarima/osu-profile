namespace osu_stats
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            GameModeBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            UserIDBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)UserIDBox).BeginInit();
            SuspendLayout();
            // 
            // GameModeBox
            // 
            GameModeBox.BackColor = Color.FromArgb(50, 50, 50);
            GameModeBox.FormattingEnabled = true;
            GameModeBox.Items.AddRange(new object[] { "Standard", "Standard RX", "Standard AP", "Taiko", "Taiko RX", "Catch the Beat", "Catch the Beat RX", "Mania" });
            GameModeBox.Location = new Point(334, 11);
            GameModeBox.Name = "GameModeBox";
            GameModeBox.Size = new Size(142, 23);
            GameModeBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Game Mode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 3;
            label2.Text = "User ID";
            // 
            // UserIDBox
            // 
            UserIDBox.BackColor = Color.FromArgb(50, 50, 50);
            UserIDBox.ForeColor = Color.White;
            UserIDBox.Location = new Point(91, 11);
            UserIDBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            UserIDBox.Name = "UserIDBox";
            UserIDBox.Size = new Size(120, 23);
            UserIDBox.TabIndex = 4;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(487, 478);
            Controls.Add(UserIDBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GameModeBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SettingsForm";
            Text = "SettingsForm";
            FormClosing += SettingsForm_FormClosing;
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)UserIDBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox GameModeBox;
        private Label label1;
        private Label label2;
        private NumericUpDown UserIDBox;
    }
}