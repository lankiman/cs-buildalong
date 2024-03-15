namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            memberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellPhoneValue = new TextBox();
            cellPhoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            memberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMemberButton.Location = new Point(81, 355);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(199, 41);
            addMemberButton.TabIndex = 22;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(32, 274);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(365, 45);
            selectTeamMemberDropDown.TabIndex = 21;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Location = new Point(32, 236);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(263, 37);
            selectTeamMemberLabel.TabIndex = 20;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamNameValue
            // 
            teamNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamNameValue.Location = new Point(33, 157);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(364, 43);
            teamNameValue.TabIndex = 19;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 14F);
            teamNameLabel.Location = new Point(33, 121);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(142, 32);
            teamNameLabel.TabIndex = 18;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 22F);
            headerLabel.Location = new Point(12, 44);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(233, 50);
            headerLabel.TabIndex = 17;
            headerLabel.Text = " Create Team";
            // 
            // memberGroupBox
            // 
            memberGroupBox.Controls.Add(createMemberButton);
            memberGroupBox.Controls.Add(cellPhoneValue);
            memberGroupBox.Controls.Add(cellPhoneLabel);
            memberGroupBox.Controls.Add(emailValue);
            memberGroupBox.Controls.Add(emailLabel);
            memberGroupBox.Controls.Add(lastNameValue);
            memberGroupBox.Controls.Add(lastNameLabel);
            memberGroupBox.Controls.Add(firstNameValue);
            memberGroupBox.Controls.Add(firstNameLabel);
            memberGroupBox.Location = new Point(32, 427);
            memberGroupBox.Name = "memberGroupBox";
            memberGroupBox.Size = new Size(391, 299);
            memberGroupBox.TabIndex = 23;
            memberGroupBox.TabStop = false;
            memberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMemberButton.Location = new Point(75, 247);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(199, 41);
            createMemberButton.TabIndex = 24;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.BorderStyle = BorderStyle.FixedSingle;
            cellPhoneValue.Location = new Point(141, 189);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new Size(224, 43);
            cellPhoneValue.TabIndex = 16;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI", 14F);
            cellPhoneLabel.Location = new Point(13, 196);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(123, 32);
            cellPhoneLabel.TabIndex = 15;
            cellPhoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.Location = new Point(141, 140);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(224, 43);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 14F);
            emailLabel.Location = new Point(13, 147);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(71, 32);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.BorderStyle = BorderStyle.FixedSingle;
            lastNameValue.Location = new Point(141, 91);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(224, 43);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 14F);
            lastNameLabel.Location = new Point(13, 98);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(126, 32);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.Location = new Point(141, 42);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(224, 43);
            firstNameValue.TabIndex = 10;
            // firstNameValue.TextChanged += textBox1_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 14F);
            firstNameLabel.Location = new Point(13, 49);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(129, 32);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 37;
            teamMembersListBox.Location = new Point(451, 121);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(344, 594);
            teamMembersListBox.TabIndex = 24;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedMemberButton.Location = new Point(801, 380);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(116, 76);
            deleteSelectedMemberButton.TabIndex = 25;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTeamButton.Location = new Point(285, 761);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(291, 72);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(945, 861);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Controls.Add(memberGroupBox);
            Font = new Font("Segoe UI", 16F);
            ForeColor = Color.FromArgb(21, 153, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            memberGroupBox.ResumeLayout(false);
            memberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private GroupBox memberGroupBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox cellPhoneValue;
        private Label cellPhoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}