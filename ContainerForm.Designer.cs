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
            FirstsBoxGain = new TextBox();
            FirstsBox = new TextBox();
            FirstsLabel = new Label();
            SGainBox = new TextBox();
            SBox = new TextBox();
            SLabel = new Label();
            SHGainBox = new TextBox();
            SHBox = new TextBox();
            SHLabel = new Label();
            SSGainBox = new TextBox();
            SSBox = new TextBox();
            SSLabel = new Label();
            SSHGainBox = new TextBox();
            SSHBox = new TextBox();
            SSHLabel = new Label();
            BGainBox = new TextBox();
            BBox = new TextBox();
            BLabel = new Label();
            AGainBox = new TextBox();
            ABox = new TextBox();
            ALabel = new Label();
            DGainBox = new TextBox();
            DBox = new TextBox();
            DLabel = new Label();
            CGainBox = new TextBox();
            CBox = new TextBox();
            CLabel = new Label();
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
            InfoLabel.Location = new Point(12, 644);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(95, 17);
            InfoLabel.TabIndex = 42;
            InfoLabel.Text = "Fetching data...";
            // 
            // ResetButton
            // 
            ResetButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Location = new Point(261, 641);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(92, 23);
            ResetButton.TabIndex = 43;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += button1_Click;
            // 
            // FirstsBoxGain
            // 
            FirstsBoxGain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FirstsBoxGain.BackColor = Color.FromArgb(50, 50, 50);
            FirstsBoxGain.ForeColor = Color.White;
            FirstsBoxGain.Location = new Point(261, 373);
            FirstsBoxGain.Name = "FirstsBoxGain";
            FirstsBoxGain.ReadOnly = true;
            FirstsBoxGain.Size = new Size(92, 23);
            FirstsBoxGain.TabIndex = 46;
            FirstsBoxGain.TextAlign = HorizontalAlignment.Right;
            // 
            // FirstsBox
            // 
            FirstsBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FirstsBox.BackColor = Color.FromArgb(50, 50, 50);
            FirstsBox.ForeColor = Color.White;
            FirstsBox.Location = new Point(118, 373);
            FirstsBox.Name = "FirstsBox";
            FirstsBox.ReadOnly = true;
            FirstsBox.Size = new Size(137, 23);
            FirstsBox.TabIndex = 45;
            FirstsBox.TextAlign = HorizontalAlignment.Right;
            // 
            // FirstsLabel
            // 
            FirstsLabel.AutoSize = true;
            FirstsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstsLabel.Location = new Point(12, 374);
            FirstsLabel.Name = "FirstsLabel";
            FirstsLabel.Size = new Size(38, 17);
            FirstsLabel.TabIndex = 44;
            FirstsLabel.Text = "Firsts";
            // 
            // SGainBox
            // 
            SGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SGainBox.BackColor = Color.FromArgb(50, 50, 50);
            SGainBox.ForeColor = Color.White;
            SGainBox.Location = new Point(261, 490);
            SGainBox.Name = "SGainBox";
            SGainBox.ReadOnly = true;
            SGainBox.Size = new Size(92, 23);
            SGainBox.TabIndex = 58;
            SGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SBox
            // 
            SBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SBox.BackColor = Color.FromArgb(50, 50, 50);
            SBox.ForeColor = Color.White;
            SBox.Location = new Point(118, 490);
            SBox.Name = "SBox";
            SBox.ReadOnly = true;
            SBox.Size = new Size(137, 23);
            SBox.TabIndex = 57;
            SBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SLabel
            // 
            SLabel.AutoSize = true;
            SLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SLabel.Location = new Point(12, 491);
            SLabel.Name = "SLabel";
            SLabel.Size = new Size(47, 17);
            SLabel.TabIndex = 56;
            SLabel.Text = "Rank S";
            // 
            // SHGainBox
            // 
            SHGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SHGainBox.BackColor = Color.FromArgb(50, 50, 50);
            SHGainBox.ForeColor = Color.White;
            SHGainBox.Location = new Point(261, 461);
            SHGainBox.Name = "SHGainBox";
            SHGainBox.ReadOnly = true;
            SHGainBox.Size = new Size(92, 23);
            SHGainBox.TabIndex = 55;
            SHGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SHBox
            // 
            SHBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SHBox.BackColor = Color.FromArgb(50, 50, 50);
            SHBox.ForeColor = Color.White;
            SHBox.Location = new Point(118, 461);
            SHBox.Name = "SHBox";
            SHBox.ReadOnly = true;
            SHBox.Size = new Size(137, 23);
            SHBox.TabIndex = 54;
            SHBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SHLabel
            // 
            SHLabel.AutoSize = true;
            SHLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SHLabel.Location = new Point(12, 462);
            SHLabel.Name = "SHLabel";
            SHLabel.Size = new Size(56, 17);
            SHLabel.TabIndex = 53;
            SHLabel.Text = "Rank SH";
            // 
            // SSGainBox
            // 
            SSGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SSGainBox.BackColor = Color.FromArgb(50, 50, 50);
            SSGainBox.ForeColor = Color.White;
            SSGainBox.Location = new Point(261, 432);
            SSGainBox.Name = "SSGainBox";
            SSGainBox.ReadOnly = true;
            SSGainBox.Size = new Size(92, 23);
            SSGainBox.TabIndex = 52;
            SSGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SSBox
            // 
            SSBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SSBox.BackColor = Color.FromArgb(50, 50, 50);
            SSBox.ForeColor = Color.White;
            SSBox.Location = new Point(118, 432);
            SSBox.Name = "SSBox";
            SSBox.ReadOnly = true;
            SSBox.Size = new Size(137, 23);
            SSBox.TabIndex = 51;
            SSBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SSLabel
            // 
            SSLabel.AutoSize = true;
            SSLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SSLabel.Location = new Point(12, 433);
            SSLabel.Name = "SSLabel";
            SSLabel.Size = new Size(54, 17);
            SSLabel.TabIndex = 50;
            SSLabel.Text = "Rank SS";
            // 
            // SSHGainBox
            // 
            SSHGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SSHGainBox.BackColor = Color.FromArgb(50, 50, 50);
            SSHGainBox.ForeColor = Color.White;
            SSHGainBox.Location = new Point(261, 403);
            SSHGainBox.Name = "SSHGainBox";
            SSHGainBox.ReadOnly = true;
            SSHGainBox.Size = new Size(92, 23);
            SSHGainBox.TabIndex = 49;
            SSHGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SSHBox
            // 
            SSHBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SSHBox.BackColor = Color.FromArgb(50, 50, 50);
            SSHBox.ForeColor = Color.White;
            SSHBox.Location = new Point(118, 403);
            SSHBox.Name = "SSHBox";
            SSHBox.ReadOnly = true;
            SSHBox.Size = new Size(137, 23);
            SSHBox.TabIndex = 48;
            SSHBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SSHLabel
            // 
            SSHLabel.AutoSize = true;
            SSHLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SSHLabel.Location = new Point(12, 404);
            SSHLabel.Name = "SSHLabel";
            SSHLabel.Size = new Size(63, 17);
            SSHLabel.TabIndex = 47;
            SSHLabel.Text = "Rank SSH";
            // 
            // BGainBox
            // 
            BGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BGainBox.BackColor = Color.FromArgb(50, 50, 50);
            BGainBox.ForeColor = Color.White;
            BGainBox.Location = new Point(261, 545);
            BGainBox.Name = "BGainBox";
            BGainBox.ReadOnly = true;
            BGainBox.Size = new Size(92, 23);
            BGainBox.TabIndex = 64;
            BGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // BBox
            // 
            BBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BBox.BackColor = Color.FromArgb(50, 50, 50);
            BBox.ForeColor = Color.White;
            BBox.Location = new Point(118, 545);
            BBox.Name = "BBox";
            BBox.ReadOnly = true;
            BBox.Size = new Size(137, 23);
            BBox.TabIndex = 63;
            BBox.TextAlign = HorizontalAlignment.Right;
            // 
            // BLabel
            // 
            BLabel.AutoSize = true;
            BLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BLabel.Location = new Point(12, 546);
            BLabel.Name = "BLabel";
            BLabel.Size = new Size(47, 17);
            BLabel.TabIndex = 62;
            BLabel.Text = "Rank B";
            // 
            // AGainBox
            // 
            AGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AGainBox.BackColor = Color.FromArgb(50, 50, 50);
            AGainBox.ForeColor = Color.White;
            AGainBox.Location = new Point(261, 516);
            AGainBox.Name = "AGainBox";
            AGainBox.ReadOnly = true;
            AGainBox.Size = new Size(92, 23);
            AGainBox.TabIndex = 61;
            AGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // ABox
            // 
            ABox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ABox.BackColor = Color.FromArgb(50, 50, 50);
            ABox.ForeColor = Color.White;
            ABox.Location = new Point(118, 516);
            ABox.Name = "ABox";
            ABox.ReadOnly = true;
            ABox.Size = new Size(137, 23);
            ABox.TabIndex = 60;
            ABox.TextAlign = HorizontalAlignment.Right;
            // 
            // ALabel
            // 
            ALabel.AutoSize = true;
            ALabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ALabel.Location = new Point(12, 517);
            ALabel.Name = "ALabel";
            ALabel.Size = new Size(48, 17);
            ALabel.TabIndex = 59;
            ALabel.Text = "Rank A";
            // 
            // DGainBox
            // 
            DGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DGainBox.BackColor = Color.FromArgb(50, 50, 50);
            DGainBox.ForeColor = Color.White;
            DGainBox.Location = new Point(261, 604);
            DGainBox.Name = "DGainBox";
            DGainBox.ReadOnly = true;
            DGainBox.Size = new Size(92, 23);
            DGainBox.TabIndex = 70;
            DGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // DBox
            // 
            DBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DBox.BackColor = Color.FromArgb(50, 50, 50);
            DBox.ForeColor = Color.White;
            DBox.Location = new Point(118, 604);
            DBox.Name = "DBox";
            DBox.ReadOnly = true;
            DBox.Size = new Size(137, 23);
            DBox.TabIndex = 69;
            DBox.TextAlign = HorizontalAlignment.Right;
            // 
            // DLabel
            // 
            DLabel.AutoSize = true;
            DLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DLabel.Location = new Point(12, 605);
            DLabel.Name = "DLabel";
            DLabel.Size = new Size(49, 17);
            DLabel.TabIndex = 68;
            DLabel.Text = "Rank D";
            // 
            // CGainBox
            // 
            CGainBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CGainBox.BackColor = Color.FromArgb(50, 50, 50);
            CGainBox.ForeColor = Color.White;
            CGainBox.Location = new Point(261, 575);
            CGainBox.Name = "CGainBox";
            CGainBox.ReadOnly = true;
            CGainBox.Size = new Size(92, 23);
            CGainBox.TabIndex = 67;
            CGainBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CBox
            // 
            CBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBox.BackColor = Color.FromArgb(50, 50, 50);
            CBox.ForeColor = Color.White;
            CBox.Location = new Point(118, 575);
            CBox.Name = "CBox";
            CBox.ReadOnly = true;
            CBox.Size = new Size(137, 23);
            CBox.TabIndex = 66;
            CBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CLabel
            // 
            CLabel.AutoSize = true;
            CLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CLabel.Location = new Point(12, 576);
            CLabel.Name = "CLabel";
            CLabel.Size = new Size(48, 17);
            CLabel.TabIndex = 65;
            CLabel.Text = "Rank C";
            // 
            // ContainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(365, 721);
            Controls.Add(DGainBox);
            Controls.Add(DBox);
            Controls.Add(DLabel);
            Controls.Add(CGainBox);
            Controls.Add(CBox);
            Controls.Add(CLabel);
            Controls.Add(BGainBox);
            Controls.Add(BBox);
            Controls.Add(BLabel);
            Controls.Add(AGainBox);
            Controls.Add(ABox);
            Controls.Add(ALabel);
            Controls.Add(SGainBox);
            Controls.Add(SBox);
            Controls.Add(SLabel);
            Controls.Add(SHGainBox);
            Controls.Add(SHBox);
            Controls.Add(SHLabel);
            Controls.Add(SSGainBox);
            Controls.Add(SSBox);
            Controls.Add(SSLabel);
            Controls.Add(SSHGainBox);
            Controls.Add(SSHBox);
            Controls.Add(SSHLabel);
            Controls.Add(FirstsBoxGain);
            Controls.Add(FirstsBox);
            Controls.Add(FirstsLabel);
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
        private TextBox FirstsBoxGain;
        private TextBox FirstsBox;
        private Label FirstsLabel;
        private TextBox SGainBox;
        private TextBox SBox;
        private Label SLabel;
        private TextBox SHGainBox;
        private TextBox SHBox;
        private Label SHLabel;
        private TextBox SSGainBox;
        private TextBox SSBox;
        private Label SSLabel;
        private TextBox SSHGainBox;
        private TextBox SSHBox;
        private Label SSHLabel;
        private TextBox BGainBox;
        private TextBox BBox;
        private Label BLabel;
        private TextBox AGainBox;
        private TextBox ABox;
        private Label ALabel;
        private TextBox DGainBox;
        private TextBox DBox;
        private Label DLabel;
        private TextBox CGainBox;
        private TextBox CBox;
        private Label CLabel;
    }
}