namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropdown = new ComboBox();
            unplayedCheckbox = new CheckBox();
            matchupListbox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            textBox1 = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 22F);
            headerLabel.Location = new Point(12, 24);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(226, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            headerLabel.Click += label1_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 22F);
            tournamentName.Location = new Point(227, 24);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(155, 50);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(28, 116);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(97, 38);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(121, 109);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(231, 45);
            roundDropdown.TabIndex = 3;
            // 
            // unplayedCheckbox
            // 
            unplayedCheckbox.AutoSize = true;
            unplayedCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedCheckbox.Font = new Font("Segoe UI", 14F);
            unplayedCheckbox.Location = new Point(121, 160);
            unplayedCheckbox.Name = "unplayedCheckbox";
            unplayedCheckbox.Size = new Size(190, 36);
            unplayedCheckbox.TabIndex = 4;
            unplayedCheckbox.Text = "Unplayed Only";
            unplayedCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListbox
            // 
            matchupListbox.BorderStyle = BorderStyle.FixedSingle;
            matchupListbox.FormattingEnabled = true;
            matchupListbox.ItemHeight = 37;
            matchupListbox.Location = new Point(28, 216);
            matchupListbox.Name = "matchupListbox";
            matchupListbox.Size = new Size(324, 261);
            matchupListbox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 14F);
            teamOneName.Location = new Point(377, 216);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(148, 32);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            teamOneName.Click += teamOneName_Click;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 14F);
            teamOneScoreLabel.Location = new Point(377, 260);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(73, 32);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(445, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 43);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.BorderStyle = BorderStyle.FixedSingle;
            teamTwoScoreValue.Location = new Point(445, 392);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(89, 43);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 14F);
            teamTwoScoreLabel.Location = new Point(377, 399);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(73, 32);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 14F);
            teamTwoName.Location = new Point(377, 355);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(146, 32);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 14F);
            versusLabel.Location = new Point(419, 310);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(62, 32);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            versusLabel.Click += label1_Click_1;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.Location = new Point(529, 310);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(116, 42);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(673, 510);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(textBox1);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListbox);
            Controls.Add(unplayedCheckbox);
            Controls.Add(roundDropdown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(51, 153, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedCheckbox;
        private ListBox matchupListbox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox textBox1;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}
