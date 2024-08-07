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
            FieldsBox = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            PlaytimeOffset = new NumericUpDown();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            SaveBtn = new Button();
            label8 = new Label();
            AvailableVarBox = new ListBox();
            label7 = new Label();
            label6 = new Label();
            ResultBox = new TextBox();
            FileStreamContentBox = new TextBox();
            JsonBtn = new RadioButton();
            TextBtn = new RadioButton();
            NewStreamButton = new Button();
            DeleteStreamButton = new Button();
            FileStreamBox = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)UserIDBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlaytimeOffset).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // GameModeBox
            // 
            GameModeBox.BackColor = Color.FromArgb(50, 50, 50);
            GameModeBox.ForeColor = Color.White;
            GameModeBox.FormattingEnabled = true;
            GameModeBox.Items.AddRange(new object[] { "Standard", "Standard RX", "Standard AP", "Taiko", "Taiko RX", "Catch the Beat", "Catch the Beat RX", "Mania" });
            GameModeBox.Location = new Point(328, 5);
            GameModeBox.Name = "GameModeBox";
            GameModeBox.Size = new Size(142, 23);
            GameModeBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 3);
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
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 3;
            label2.Text = "User ID";
            // 
            // UserIDBox
            // 
            UserIDBox.BackColor = Color.FromArgb(50, 50, 50);
            UserIDBox.ForeColor = Color.White;
            UserIDBox.Location = new Point(85, 5);
            UserIDBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            UserIDBox.Name = "UserIDBox";
            UserIDBox.Size = new Size(120, 23);
            UserIDBox.TabIndex = 4;
            // 
            // FieldsBox
            // 
            FieldsBox.BackColor = Color.FromArgb(50, 50, 50);
            FieldsBox.ForeColor = Color.White;
            FieldsBox.FormattingEnabled = true;
            FieldsBox.Location = new Point(7, 76);
            FieldsBox.Name = "FieldsBox";
            FieldsBox.Size = new Size(463, 274);
            FieldsBox.TabIndex = 5;
            FieldsBox.Tag = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 6;
            label3.Text = "Enabled fields:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(159, 35);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 8;
            label4.Text = "RX playtime offset";
            // 
            // PlaytimeOffset
            // 
            PlaytimeOffset.BackColor = Color.FromArgb(50, 50, 50);
            PlaytimeOffset.ForeColor = Color.White;
            PlaytimeOffset.Location = new Point(328, 37);
            PlaytimeOffset.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            PlaytimeOffset.Name = "PlaytimeOffset";
            PlaytimeOffset.Size = new Size(141, 23);
            PlaytimeOffset.TabIndex = 9;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(712, 393);
            tabControl1.TabIndex = 10;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(30, 30, 30);
            tabPage1.Controls.Add(FieldsBox);
            tabPage1.Controls.Add(PlaytimeOffset);
            tabPage1.Controls.Add(GameModeBox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(UserIDBox);
            tabPage1.ForeColor = SystemColors.ControlDarkDark;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(704, 365);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(30, 30, 30);
            tabPage2.Controls.Add(SaveBtn);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(AvailableVarBox);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(ResultBox);
            tabPage2.Controls.Add(FileStreamContentBox);
            tabPage2.Controls.Add(JsonBtn);
            tabPage2.Controls.Add(TextBtn);
            tabPage2.Controls.Add(NewStreamButton);
            tabPage2.Controls.Add(DeleteStreamButton);
            tabPage2.Controls.Add(FileStreamBox);
            tabPage2.Controls.Add(label5);
            tabPage2.ForeColor = Color.FromArgb(30, 30, 30);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(704, 365);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "File streams";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(604, 6);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(40, 23);
            SaveBtn.TabIndex = 12;
            SaveBtn.Text = "save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(520, 60);
            label8.Name = "label8";
            label8.Size = new Size(142, 21);
            label8.TabIndex = 11;
            label8.Text = "Available variables:";
            // 
            // AvailableVarBox
            // 
            AvailableVarBox.FormattingEnabled = true;
            AvailableVarBox.ItemHeight = 15;
            AvailableVarBox.Location = new Point(520, 84);
            AvailableVarBox.Name = "AvailableVarBox";
            AvailableVarBox.Size = new Size(176, 274);
            AvailableVarBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(264, 60);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 9;
            label7.Text = "Result:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 60);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 8;
            label6.Text = "Content:";
            // 
            // ResultBox
            // 
            ResultBox.Enabled = false;
            ResultBox.Location = new Point(264, 84);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(250, 274);
            ResultBox.TabIndex = 7;
            // 
            // FileStreamContentBox
            // 
            FileStreamContentBox.Location = new Point(8, 84);
            FileStreamContentBox.Multiline = true;
            FileStreamContentBox.Name = "FileStreamContentBox";
            FileStreamContentBox.Size = new Size(250, 274);
            FileStreamContentBox.TabIndex = 6;
            FileStreamContentBox.TextChanged += FileStreamContentBox_TextChanged;
            // 
            // JsonBtn
            // 
            JsonBtn.AutoSize = true;
            JsonBtn.ForeColor = Color.White;
            JsonBtn.Location = new Point(99, 34);
            JsonBtn.Name = "JsonBtn";
            JsonBtn.Size = new Size(92, 19);
            JsonBtn.TabIndex = 5;
            JsonBtn.TabStop = true;
            JsonBtn.Text = "JSON stream";
            JsonBtn.UseVisualStyleBackColor = true;
            JsonBtn.CheckedChanged += JsonBtn_CheckedChanged;
            // 
            // TextBtn
            // 
            TextBtn.AutoSize = true;
            TextBtn.ForeColor = Color.White;
            TextBtn.Location = new Point(8, 34);
            TextBtn.Name = "TextBtn";
            TextBtn.Size = new Size(85, 19);
            TextBtn.TabIndex = 4;
            TextBtn.TabStop = true;
            TextBtn.Text = "Text stream";
            TextBtn.UseVisualStyleBackColor = true;
            TextBtn.CheckedChanged += TextBtn_CheckedChanged;
            // 
            // NewStreamButton
            // 
            NewStreamButton.Location = new Point(650, 6);
            NewStreamButton.Name = "NewStreamButton";
            NewStreamButton.Size = new Size(50, 23);
            NewStreamButton.TabIndex = 3;
            NewStreamButton.Text = "new";
            NewStreamButton.UseVisualStyleBackColor = true;
            NewStreamButton.Click += NewStreamButton_Click;
            // 
            // DeleteStreamButton
            // 
            DeleteStreamButton.Location = new Point(548, 6);
            DeleteStreamButton.Name = "DeleteStreamButton";
            DeleteStreamButton.Size = new Size(50, 23);
            DeleteStreamButton.TabIndex = 2;
            DeleteStreamButton.Text = "delete";
            DeleteStreamButton.UseVisualStyleBackColor = true;
            DeleteStreamButton.Click += DeleteStreamButton_Click;
            // 
            // FileStreamBox
            // 
            FileStreamBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FileStreamBox.FormattingEnabled = true;
            FileStreamBox.Location = new Point(99, 5);
            FileStreamBox.Name = "FileStreamBox";
            FileStreamBox.Size = new Size(443, 23);
            FileStreamBox.TabIndex = 1;
            FileStreamBox.SelectedIndexChanged += FileStreamBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 3);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 0;
            label5.Text = "Filestream:";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(712, 393);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SettingsForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Settings";
            FormClosing += SettingsForm_FormClosing;
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)UserIDBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlaytimeOffset).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox GameModeBox;
        private Label label1;
        private Label label2;
        private NumericUpDown UserIDBox;
        private CheckedListBox FieldsBox;
        private Label label3;
        private Label label4;
        private NumericUpDown PlaytimeOffset;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RadioButton JsonBtn;
        private RadioButton TextBtn;
        private Button NewStreamButton;
        private Button DeleteStreamButton;
        private ComboBox FileStreamBox;
        private Label label5;
        private TextBox FileStreamContentBox;
        private Label label7;
        private Label label6;
        private TextBox ResultBox;
        private Label label8;
        private ListBox AvailableVarBox;
        private Button SaveBtn;
    }
}