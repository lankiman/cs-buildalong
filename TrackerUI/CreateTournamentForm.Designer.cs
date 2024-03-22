namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListbox = new ListBox();
            tournamentPlayersLabel = new Label();
            removeSelectedPlayerButton = new Button();
            removeSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 22F);
            headerLabel.Location = new Point(44, 57);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(344, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = " Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.Location = new Point(65, 170);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(323, 41);
            tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 14F);
            tournamentNameLabel.Location = new Point(65, 134);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(214, 32);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.Location = new Point(184, 240);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(134, 41);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 14F);
            entryFeeLabel.Location = new Point(65, 240);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(113, 32);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(64, 360);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(324, 43);
            selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Location = new Point(64, 322);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(146, 35);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Font = new Font("Segoe UI", 12F);
            createNewTeamLink.Location = new Point(276, 329);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(112, 28);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create New";
            createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.Location = new Point(130, 424);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(199, 41);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.Location = new Point(130, 483);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(199, 41);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListbox
            // 
            tournamentTeamsListbox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListbox.FormattingEnabled = true;
            tournamentTeamsListbox.ItemHeight = 35;
            tournamentTeamsListbox.Location = new Point(459, 170);
            tournamentTeamsListbox.Name = "tournamentTeamsListbox";
            tournamentTeamsListbox.Size = new Size(300, 177);
            tournamentTeamsListbox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 14F);
            tournamentPlayersLabel.Location = new Point(459, 135);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(178, 32);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // removeSelectedPlayerButton
            // 
            removeSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedPlayerButton.Location = new Point(786, 222);
            removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            removeSelectedPlayerButton.Size = new Size(116, 76);
            removeSelectedPlayerButton.TabIndex = 20;
            removeSelectedPlayerButton.Text = "Remove Selected";
            removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            removeSelectedPlayerButton.Click += removeSelectedPlayerButton_Click;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedPrizeButton.Location = new Point(786, 446);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(116, 78);
            removeSelectedPrizeButton.TabIndex = 23;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 14F);
            prizesLabel.Location = new Point(459, 357);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(75, 32);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 35;
            prizesListBox.Location = new Point(459, 392);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(300, 177);
            prizesListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.Location = new Point(295, 612);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(291, 72);
            createTournamentButton.TabIndex = 24;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 717);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(removeSelectedPlayerButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentTeamsListbox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15F);
            ForeColor = SystemColors.MenuHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListbox;
        private Label tournamentPlayersLabel;
        private Button removeSelectedPlayerButton;
        private Button removeSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}