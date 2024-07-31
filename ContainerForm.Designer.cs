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
            ScoreRankLabel = new Label();
            ScoreRankBox = new TextBox();
            ScoreRankGainBox = new TextBox();
            GlobalRankGainBox = new TextBox();
            GlobalRankBox = new TextBox();
            GlobalRankLabel = new Label();
            CountryRankGainBox = new TextBox();
            CountryRankBox = new TextBox();
            CountryRankLabel = new Label();
            PpGainBox = new TextBox();
            PpBox = new TextBox();
            PpLabel = new Label();
            TotalScoreGainBox = new TextBox();
            TotalScoreBox = new TextBox();
            TotalScoreLabel = new Label();
            RankedScoreGainBox = new TextBox();
            RankedScoreBox = new TextBox();
            RankedScoreLabel = new Label();
            ClearsBoxGain = new TextBox();
            ClearsBox = new TextBox();
            ClearsLabel = new Label();
            TotalHitsGainBox = new TextBox();
            TotalHitsBox = new TextBox();
            TotalHitsLabel = new Label();
            PlayCountGainBox = new TextBox();
            PlayCountBox = new TextBox();
            PlayCountLabel = new Label();
            PlayTimeGainBox = new TextBox();
            PlayTimeBox = new TextBox();
            PlayTimeLabel = new Label();
            AccuracyGainBox = new TextBox();
            AccuracyBox = new TextBox();
            AccuracyLabel = new Label();
            AvatarBox = new PictureBox();
            InfoLabel = new Label();
            ResetButton = new Button();
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
            // ScoreRankLabel
            // 
            ScoreRankLabel.AutoSize = true;
            ScoreRankLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreRankLabel.Location = new Point(12, 55);
            ScoreRankLabel.Name = "ScoreRankLabel";
            ScoreRankLabel.Size = new Size(73, 17);
            ScoreRankLabel.TabIndex = 7;
            ScoreRankLabel.Text = "Score Rank";
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
            // GlobalRankLabel
            // 
            GlobalRankLabel.AutoSize = true;
            GlobalRankLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            GlobalRankLabel.Location = new Point(12, 84);
            GlobalRankLabel.Name = "GlobalRankLabel";
            GlobalRankLabel.Size = new Size(78, 17);
            GlobalRankLabel.TabIndex = 10;
            GlobalRankLabel.Text = "Global Rank";
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
            // CountryRankLabel
            // 
            CountryRankLabel.AutoSize = true;
            CountryRankLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CountryRankLabel.Location = new Point(12, 113);
            CountryRankLabel.Name = "CountryRankLabel";
            CountryRankLabel.Size = new Size(85, 17);
            CountryRankLabel.TabIndex = 13;
            CountryRankLabel.Text = "Country Rank";
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
            // PpLabel
            // 
            PpLabel.AutoSize = true;
            PpLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PpLabel.Location = new Point(12, 200);
            PpLabel.Name = "PpLabel";
            PpLabel.Size = new Size(82, 17);
            PpLabel.TabIndex = 22;
            PpLabel.Text = "Performance";
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
            // TotalScoreLabel
            // 
            TotalScoreLabel.AutoSize = true;
            TotalScoreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TotalScoreLabel.Location = new Point(12, 171);
            TotalScoreLabel.Name = "TotalScoreLabel";
            TotalScoreLabel.Size = new Size(73, 17);
            TotalScoreLabel.TabIndex = 19;
            TotalScoreLabel.Text = "Total Score";
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
            // RankedScoreLabel
            // 
            RankedScoreLabel.AutoSize = true;
            RankedScoreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RankedScoreLabel.Location = new Point(12, 142);
            RankedScoreLabel.Name = "RankedScoreLabel";
            RankedScoreLabel.Size = new Size(88, 17);
            RankedScoreLabel.TabIndex = 16;
            RankedScoreLabel.Text = "Ranked Score";
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
            // ClearsLabel
            // 
            ClearsLabel.AutoSize = true;
            ClearsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ClearsLabel.Location = new Point(12, 345);
            ClearsLabel.Name = "ClearsLabel";
            ClearsLabel.Size = new Size(44, 17);
            ClearsLabel.TabIndex = 37;
            ClearsLabel.Text = "Clears";
            // 
            // TotalHitsGainBox
            // 
            TotalHitsGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalHitsGainBox.BackColor = Color.FromArgb(50, 50, 50);
            TotalHitsGainBox.ForeColor = Color.White;
            TotalHitsGainBox.Location = new Point(261, 315);
            TotalHitsGainBox.Name = "TotalHitsGainBox";
            TotalHitsGainBox.ReadOnly = true;
            TotalHitsGainBox.Size = new Size(92, 23);
            TotalHitsGainBox.TabIndex = 36;
            TotalHitsGainBox.TextAlign = HorizontalAlignment.Right;
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
            // TotalHitsLabel
            // 
            TotalHitsLabel.AutoSize = true;
            TotalHitsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TotalHitsLabel.Location = new Point(12, 316);
            TotalHitsLabel.Name = "TotalHitsLabel";
            TotalHitsLabel.Size = new Size(62, 17);
            TotalHitsLabel.TabIndex = 34;
            TotalHitsLabel.Text = "Total Hits";
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
            // PlayCountLabel
            // 
            PlayCountLabel.AutoSize = true;
            PlayCountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PlayCountLabel.Location = new Point(12, 287);
            PlayCountLabel.Name = "PlayCountLabel";
            PlayCountLabel.Size = new Size(69, 17);
            PlayCountLabel.TabIndex = 31;
            PlayCountLabel.Text = "Play Count";
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
            // PlayTimeLabel
            // 
            PlayTimeLabel.AutoSize = true;
            PlayTimeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PlayTimeLabel.Location = new Point(12, 258);
            PlayTimeLabel.Name = "PlayTimeLabel";
            PlayTimeLabel.Size = new Size(63, 17);
            PlayTimeLabel.TabIndex = 28;
            PlayTimeLabel.Text = "Play Time";
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
            // AccuracyLabel
            // 
            AccuracyLabel.AutoSize = true;
            AccuracyLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AccuracyLabel.Location = new Point(12, 229);
            AccuracyLabel.Name = "AccuracyLabel";
            AccuracyLabel.Size = new Size(59, 17);
            AccuracyLabel.TabIndex = 25;
            AccuracyLabel.Text = "Accuracy";
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
            InfoLabel.Size = new Size(95, 17);
            InfoLabel.TabIndex = 42;
            InfoLabel.Text = "Fetching data...";
            // 
            // ResetButton
            // 
            ResetButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Location = new Point(261, 373);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(92, 23);
            ResetButton.TabIndex = 43;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += button1_Click;
            // 
            // ContainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(365, 402);
            Controls.Add(ResetButton);
            Controls.Add(InfoLabel);
            Controls.Add(AvatarBox);
            Controls.Add(ClearsBoxGain);
            Controls.Add(ClearsBox);
            Controls.Add(ClearsLabel);
            Controls.Add(TotalHitsGainBox);
            Controls.Add(TotalHitsBox);
            Controls.Add(TotalHitsLabel);
            Controls.Add(PlayCountGainBox);
            Controls.Add(PlayCountBox);
            Controls.Add(PlayCountLabel);
            Controls.Add(PlayTimeGainBox);
            Controls.Add(PlayTimeBox);
            Controls.Add(PlayTimeLabel);
            Controls.Add(AccuracyGainBox);
            Controls.Add(AccuracyBox);
            Controls.Add(AccuracyLabel);
            Controls.Add(PpGainBox);
            Controls.Add(PpBox);
            Controls.Add(PpLabel);
            Controls.Add(TotalScoreGainBox);
            Controls.Add(TotalScoreBox);
            Controls.Add(TotalScoreLabel);
            Controls.Add(RankedScoreGainBox);
            Controls.Add(RankedScoreBox);
            Controls.Add(RankedScoreLabel);
            Controls.Add(CountryRankGainBox);
            Controls.Add(CountryRankBox);
            Controls.Add(CountryRankLabel);
            Controls.Add(GlobalRankGainBox);
            Controls.Add(GlobalRankBox);
            Controls.Add(GlobalRankLabel);
            Controls.Add(ScoreRankGainBox);
            Controls.Add(ScoreRankBox);
            Controls.Add(ScoreRankLabel);
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
        private Label ScoreRankLabel;
        private TextBox ScoreRankBox;
        private TextBox ScoreRankGainBox;
        private TextBox GlobalRankGainBox;
        private TextBox GlobalRankBox;
        private Label GlobalRankLabel;
        private TextBox CountryRankGainBox;
        private TextBox CountryRankBox;
        private Label CountryRankLabel;
        private TextBox PpGainBox;
        private TextBox PpBox;
        private Label PpLabel;
        private TextBox TotalScoreGainBox;
        private TextBox TotalScoreBox;
        private Label TotalScoreLabel;
        private TextBox RankedScoreGainBox;
        private TextBox RankedScoreBox;
        private Label RankedScoreLabel;
        private TextBox ClearsBoxGain;
        private TextBox ClearsBox;
        private Label ClearsLabel;
        private TextBox TotalHitsGainBox;
        private TextBox TotalHitsBox;
        private Label TotalHitsLabel;
        private TextBox PlayCountGainBox;
        private TextBox PlayCountBox;
        private Label PlayCountLabel;
        private TextBox PlayTimeGainBox;
        private TextBox PlayTimeBox;
        private Label PlayTimeLabel;
        private TextBox AccuracyGainBox;
        private TextBox AccuracyBox;
        private Label AccuracyLabel;
        private PictureBox AvatarBox;
        private Label InfoLabel;
        private Button ResetButton;
    }
}