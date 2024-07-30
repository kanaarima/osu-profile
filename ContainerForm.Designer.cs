namespace osu_stats
{
    partial class ContainerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label3 = new Label();
            minimiseBtn = new Button();
            minBtn = new Button();
            closeBtn = new Button();
            label4 = new Label();
            ScoreRankBox = new TextBox();
            ScoreRankGainBox = new TextBox();
            GlobalRankGainBox = new TextBox();
            GlobalRankBox = new TextBox();
            label5 = new Label();
            CountryRankGainBox = new TextBox();
            CountryRankBox = new TextBox();
            label6 = new Label();
            PpGainBox = new TextBox();
            PpBox = new TextBox();
            label7 = new Label();
            TotalScoreGainBox = new TextBox();
            TotalScoreBox = new TextBox();
            label8 = new Label();
            RankedScoreGainBox = new TextBox();
            RankedScoreBox = new TextBox();
            label9 = new Label();
            ClearsBoxGain = new TextBox();
            ClearsBox = new TextBox();
            label11 = new Label();
            TotalHitGainBox = new TextBox();
            TotalHitsBox = new TextBox();
            label12 = new Label();
            PlayCountGainBox = new TextBox();
            PlayCountBox = new TextBox();
            label13 = new Label();
            PlayTimeGainBox = new TextBox();
            PlayTimeBox = new TextBox();
            label14 = new Label();
            AccuracyGainBox = new TextBox();
            AccuracyBox = new TextBox();
            label15 = new Label();
            AvatarBox = new PictureBox();
            InfoLabel = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)AvatarBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(82, 148, 217);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "Ranking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(158, 9);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 2;
            label3.Text = "Settings";
            label3.Click += label3_Click;
            // 
            // minimiseBtn
            // 
            minimiseBtn.BackColor = Color.FromArgb(40, 40, 40);
            minimiseBtn.FlatStyle = FlatStyle.Flat;
            minimiseBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minimiseBtn.Location = new Point(-104, -240);
            minimiseBtn.Name = "minimiseBtn";
            minimiseBtn.Size = new Size(50, 44);
            minimiseBtn.TabIndex = 4;
            minimiseBtn.Text = "-";
            minimiseBtn.UseVisualStyleBackColor = false;
            // 
            // minBtn
            // 
            minBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minBtn.BackColor = Color.FromArgb(30, 30, 30);
            minBtn.FlatStyle = FlatStyle.Flat;
            minBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            minBtn.ForeColor = SystemColors.ButtonShadow;
            minBtn.Location = new Point(266, -6);
            minBtn.Name = "minBtn";
            minBtn.Size = new Size(50, 50);
            minBtn.TabIndex = 5;
            minBtn.Text = "-";
            minBtn.UseVisualStyleBackColor = false;
            minBtn.Click += minBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.BackColor = Color.FromArgb(30, 30, 30);
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            closeBtn.ForeColor = SystemColors.ButtonShadow;
            closeBtn.Location = new Point(315, -4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(50, 48);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "x";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 55);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 7;
            label4.Text = "Score Rank";
            // 
            // ScoreRankBox
            // 
            ScoreRankBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ScoreRankBox.BackColor = Color.FromArgb(50, 50, 50);
            ScoreRankBox.ForeColor = Color.White;
            ScoreRankBox.Location = new Point(118, 54);
            ScoreRankBox.Name = "ScoreRankBox";
            ScoreRankBox.ReadOnly = true;
            ScoreRankBox.Size = new Size(137, 23);
            ScoreRankBox.TabIndex = 8;
            ScoreRankBox.TextAlign = HorizontalAlignment.Right;
            // 
            // ScoreRankGainBox
            // 
            ScoreRankGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScoreRankGainBox.BackColor = Color.FromArgb(50, 50, 50);
            ScoreRankGainBox.ForeColor = Color.White;
            ScoreRankGainBox.Location = new Point(261, 54);
            ScoreRankGainBox.Name = "ScoreRankGainBox";
            ScoreRankGainBox.ReadOnly = true;
            ScoreRankGainBox.Size = new Size(92, 23);
            ScoreRankGainBox.TabIndex = 9;
            ScoreRankGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // GlobalRankGainBox
            // 
            GlobalRankGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GlobalRankGainBox.BackColor = Color.FromArgb(50, 50, 50);
            GlobalRankGainBox.ForeColor = Color.White;
            GlobalRankGainBox.Location = new Point(261, 83);
            GlobalRankGainBox.Name = "GlobalRankGainBox";
            GlobalRankGainBox.ReadOnly = true;
            GlobalRankGainBox.Size = new Size(92, 23);
            GlobalRankGainBox.TabIndex = 12;
            GlobalRankGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // GlobalRankBox
            // 
            GlobalRankBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GlobalRankBox.BackColor = Color.FromArgb(50, 50, 50);
            GlobalRankBox.ForeColor = Color.White;
            GlobalRankBox.Location = new Point(118, 83);
            GlobalRankBox.Name = "GlobalRankBox";
            GlobalRankBox.ReadOnly = true;
            GlobalRankBox.Size = new Size(137, 23);
            GlobalRankBox.TabIndex = 11;
            GlobalRankBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 84);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 10;
            label5.Text = "Global Rank";
            // 
            // CountryRankGainBox
            // 
            CountryRankGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CountryRankGainBox.BackColor = Color.FromArgb(50, 50, 50);
            CountryRankGainBox.ForeColor = Color.White;
            CountryRankGainBox.Location = new Point(261, 112);
            CountryRankGainBox.Name = "CountryRankGainBox";
            CountryRankGainBox.ReadOnly = true;
            CountryRankGainBox.Size = new Size(92, 23);
            CountryRankGainBox.TabIndex = 15;
            CountryRankGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CountryRankBox
            // 
            CountryRankBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CountryRankBox.BackColor = Color.FromArgb(50, 50, 50);
            CountryRankBox.ForeColor = Color.White;
            CountryRankBox.Location = new Point(118, 112);
            CountryRankBox.Name = "CountryRankBox";
            CountryRankBox.ReadOnly = true;
            CountryRankBox.Size = new Size(137, 23);
            CountryRankBox.TabIndex = 14;
            CountryRankBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 113);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 13;
            label6.Text = "Country Rank";
            // 
            // PpGainBox
            // 
            PpGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PpGainBox.BackColor = Color.FromArgb(50, 50, 50);
            PpGainBox.ForeColor = Color.White;
            PpGainBox.Location = new Point(261, 199);
            PpGainBox.Name = "PpGainBox";
            PpGainBox.ReadOnly = true;
            PpGainBox.Size = new Size(92, 23);
            PpGainBox.TabIndex = 24;
            PpGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PpBox
            // 
            PpBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PpBox.BackColor = Color.FromArgb(50, 50, 50);
            PpBox.ForeColor = Color.White;
            PpBox.Location = new Point(118, 199);
            PpBox.Name = "PpBox";
            PpBox.ReadOnly = true;
            PpBox.Size = new Size(137, 23);
            PpBox.TabIndex = 23;
            PpBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 200);
            label7.Name = "label7";
            label7.Size = new Size(82, 17);
            label7.TabIndex = 22;
            label7.Text = "Performance";
            // 
            // TotalScoreGainBox
            // 
            TotalScoreGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalScoreGainBox.BackColor = Color.FromArgb(50, 50, 50);
            TotalScoreGainBox.ForeColor = Color.White;
            TotalScoreGainBox.Location = new Point(261, 170);
            TotalScoreGainBox.Name = "TotalScoreGainBox";
            TotalScoreGainBox.ReadOnly = true;
            TotalScoreGainBox.Size = new Size(92, 23);
            TotalScoreGainBox.TabIndex = 21;
            TotalScoreGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // TotalScoreBox
            // 
            TotalScoreBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TotalScoreBox.BackColor = Color.FromArgb(50, 50, 50);
            TotalScoreBox.ForeColor = Color.White;
            TotalScoreBox.Location = new Point(118, 170);
            TotalScoreBox.Name = "TotalScoreBox";
            TotalScoreBox.ReadOnly = true;
            TotalScoreBox.Size = new Size(137, 23);
            TotalScoreBox.TabIndex = 20;
            TotalScoreBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 171);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 19;
            label8.Text = "Total Score";
            // 
            // RankedScoreGainBox
            // 
            RankedScoreGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RankedScoreGainBox.BackColor = Color.FromArgb(50, 50, 50);
            RankedScoreGainBox.ForeColor = Color.White;
            RankedScoreGainBox.Location = new Point(261, 141);
            RankedScoreGainBox.Name = "RankedScoreGainBox";
            RankedScoreGainBox.ReadOnly = true;
            RankedScoreGainBox.Size = new Size(92, 23);
            RankedScoreGainBox.TabIndex = 18;
            RankedScoreGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // RankedScoreBox
            // 
            RankedScoreBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RankedScoreBox.BackColor = Color.FromArgb(50, 50, 50);
            RankedScoreBox.ForeColor = Color.White;
            RankedScoreBox.Location = new Point(118, 141);
            RankedScoreBox.Name = "RankedScoreBox";
            RankedScoreBox.ReadOnly = true;
            RankedScoreBox.Size = new Size(137, 23);
            RankedScoreBox.TabIndex = 17;
            RankedScoreBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 142);
            label9.Name = "label9";
            label9.Size = new Size(88, 17);
            label9.TabIndex = 16;
            label9.Text = "Ranked Score";
            // 
            // ClearsBoxGain
            // 
            ClearsBoxGain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearsBoxGain.BackColor = Color.FromArgb(50, 50, 50);
            ClearsBoxGain.ForeColor = Color.White;
            ClearsBoxGain.Location = new Point(261, 344);
            ClearsBoxGain.Name = "ClearsBoxGain";
            ClearsBoxGain.ReadOnly = true;
            ClearsBoxGain.Size = new Size(92, 23);
            ClearsBoxGain.TabIndex = 39;
            ClearsBoxGain.TextAlign = HorizontalAlignment.Right;
            // 
            // ClearsBox
            // 
            ClearsBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ClearsBox.BackColor = Color.FromArgb(50, 50, 50);
            ClearsBox.ForeColor = Color.White;
            ClearsBox.Location = new Point(118, 344);
            ClearsBox.Name = "ClearsBox";
            ClearsBox.ReadOnly = true;
            ClearsBox.Size = new Size(137, 23);
            ClearsBox.TabIndex = 38;
            ClearsBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 345);
            label11.Name = "label11";
            label11.Size = new Size(44, 17);
            label11.TabIndex = 37;
            label11.Text = "Clears";
            // 
            // TotalHitGainBox
            // 
            TotalHitGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalHitGainBox.BackColor = Color.FromArgb(50, 50, 50);
            TotalHitGainBox.ForeColor = Color.White;
            TotalHitGainBox.Location = new Point(261, 315);
            TotalHitGainBox.Name = "TotalHitGainBox";
            TotalHitGainBox.ReadOnly = true;
            TotalHitGainBox.Size = new Size(92, 23);
            TotalHitGainBox.TabIndex = 36;
            TotalHitGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // TotalHitsBox
            // 
            TotalHitsBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TotalHitsBox.BackColor = Color.FromArgb(50, 50, 50);
            TotalHitsBox.ForeColor = Color.White;
            TotalHitsBox.Location = new Point(118, 315);
            TotalHitsBox.Name = "TotalHitsBox";
            TotalHitsBox.ReadOnly = true;
            TotalHitsBox.Size = new Size(137, 23);
            TotalHitsBox.TabIndex = 35;
            TotalHitsBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 316);
            label12.Name = "label12";
            label12.Size = new Size(62, 17);
            label12.TabIndex = 34;
            label12.Text = "Total Hits";
            // 
            // PlayCountGainBox
            // 
            PlayCountGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PlayCountGainBox.BackColor = Color.FromArgb(50, 50, 50);
            PlayCountGainBox.ForeColor = Color.White;
            PlayCountGainBox.Location = new Point(261, 286);
            PlayCountGainBox.Name = "PlayCountGainBox";
            PlayCountGainBox.ReadOnly = true;
            PlayCountGainBox.Size = new Size(92, 23);
            PlayCountGainBox.TabIndex = 33;
            PlayCountGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PlayCountBox
            // 
            PlayCountBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PlayCountBox.BackColor = Color.FromArgb(50, 50, 50);
            PlayCountBox.ForeColor = Color.White;
            PlayCountBox.Location = new Point(118, 286);
            PlayCountBox.Name = "PlayCountBox";
            PlayCountBox.ReadOnly = true;
            PlayCountBox.Size = new Size(137, 23);
            PlayCountBox.TabIndex = 32;
            PlayCountBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(12, 287);
            label13.Name = "label13";
            label13.Size = new Size(69, 17);
            label13.TabIndex = 31;
            label13.Text = "Play Count";
            // 
            // PlayTimeGainBox
            // 
            PlayTimeGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PlayTimeGainBox.BackColor = Color.FromArgb(50, 50, 50);
            PlayTimeGainBox.ForeColor = Color.White;
            PlayTimeGainBox.Location = new Point(261, 257);
            PlayTimeGainBox.Name = "PlayTimeGainBox";
            PlayTimeGainBox.ReadOnly = true;
            PlayTimeGainBox.Size = new Size(92, 23);
            PlayTimeGainBox.TabIndex = 30;
            PlayTimeGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PlayTimeBox
            // 
            PlayTimeBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PlayTimeBox.BackColor = Color.FromArgb(50, 50, 50);
            PlayTimeBox.ForeColor = Color.White;
            PlayTimeBox.Location = new Point(118, 257);
            PlayTimeBox.Name = "PlayTimeBox";
            PlayTimeBox.ReadOnly = true;
            PlayTimeBox.Size = new Size(137, 23);
            PlayTimeBox.TabIndex = 29;
            PlayTimeBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(12, 258);
            label14.Name = "label14";
            label14.Size = new Size(63, 17);
            label14.TabIndex = 28;
            label14.Text = "Play Time";
            // 
            // AccuracyGainBox
            // 
            AccuracyGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AccuracyGainBox.BackColor = Color.FromArgb(50, 50, 50);
            AccuracyGainBox.ForeColor = Color.White;
            AccuracyGainBox.Location = new Point(261, 228);
            AccuracyGainBox.Name = "AccuracyGainBox";
            AccuracyGainBox.ReadOnly = true;
            AccuracyGainBox.Size = new Size(92, 23);
            AccuracyGainBox.TabIndex = 27;
            AccuracyGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // AccuracyBox
            // 
            AccuracyBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AccuracyBox.BackColor = Color.FromArgb(50, 50, 50);
            AccuracyBox.ForeColor = Color.White;
            AccuracyBox.Location = new Point(118, 228);
            AccuracyBox.Name = "AccuracyBox";
            AccuracyBox.ReadOnly = true;
            AccuracyBox.Size = new Size(137, 23);
            AccuracyBox.TabIndex = 26;
            AccuracyBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(12, 229);
            label15.Name = "label15";
            label15.Size = new Size(59, 17);
            label15.TabIndex = 25;
            label15.Text = "Accuracy";
            // 
            // AvatarBox
            // 
            AvatarBox.Location = new Point(15, 12);
            AvatarBox.Name = "AvatarBox";
            AvatarBox.Size = new Size(37, 33);
            AvatarBox.TabIndex = 41;
            AvatarBox.TabStop = false;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            InfoLabel.Location = new Point(12, 376);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(30, 17);
            InfoLabel.TabIndex = 42;
            InfoLabel.Text = "Info";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(261, 373);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 43;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ContainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(365, 402);
            Controls.Add(button1);
            Controls.Add(InfoLabel);
            Controls.Add(AvatarBox);
            Controls.Add(ClearsBoxGain);
            Controls.Add(ClearsBox);
            Controls.Add(label11);
            Controls.Add(TotalHitGainBox);
            Controls.Add(TotalHitsBox);
            Controls.Add(label12);
            Controls.Add(PlayCountGainBox);
            Controls.Add(PlayCountBox);
            Controls.Add(label13);
            Controls.Add(PlayTimeGainBox);
            Controls.Add(PlayTimeBox);
            Controls.Add(label14);
            Controls.Add(AccuracyGainBox);
            Controls.Add(AccuracyBox);
            Controls.Add(label15);
            Controls.Add(PpGainBox);
            Controls.Add(PpBox);
            Controls.Add(label7);
            Controls.Add(TotalScoreGainBox);
            Controls.Add(TotalScoreBox);
            Controls.Add(label8);
            Controls.Add(RankedScoreGainBox);
            Controls.Add(RankedScoreBox);
            Controls.Add(label9);
            Controls.Add(CountryRankGainBox);
            Controls.Add(CountryRankBox);
            Controls.Add(label6);
            Controls.Add(GlobalRankGainBox);
            Controls.Add(GlobalRankBox);
            Controls.Add(label5);
            Controls.Add(ScoreRankGainBox);
            Controls.Add(ScoreRankBox);
            Controls.Add(label4);
            Controls.Add(closeBtn);
            Controls.Add(minBtn);
            Controls.Add(minimiseBtn);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContainerForm";
            Text = "Osu! Stats";
            Load += StatsUI_Load;
            MouseDown += StatsUI_MouseDown;
            ((System.ComponentModel.ISupportInitialize)AvatarBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button minimiseBtn;
        private Button minBtn;
        private Button closeBtn;
        private Label label4;
        private TextBox ScoreRankBox;
        private TextBox ScoreRankGainBox;
        private TextBox GlobalRankGainBox;
        private TextBox GlobalRankBox;
        private Label label5;
        private TextBox CountryRankGainBox;
        private TextBox CountryRankBox;
        private Label label6;
        private TextBox PpGainBox;
        private TextBox PpBox;
        private Label label7;
        private TextBox TotalScoreGainBox;
        private TextBox TotalScoreBox;
        private Label label8;
        private TextBox RankedScoreGainBox;
        private TextBox RankedScoreBox;
        private Label label9;
        private TextBox ClearsBoxGain;
        private TextBox ClearsBox;
        private Label label11;
        private TextBox TotalHitGainBox;
        private TextBox TotalHitsBox;
        private Label label12;
        private TextBox PlayCountGainBox;
        private TextBox PlayCountBox;
        private Label label13;
        private TextBox PlayTimeGainBox;
        private TextBox PlayTimeBox;
        private Label label14;
        private TextBox AccuracyGainBox;
        private TextBox AccuracyBox;
        private Label label15;
        private PictureBox AvatarBox;
        private Label InfoLabel;
        private Button button1;
    }
}