using System;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();

            // CreateSampleData();

            WireUpLists();
        }

        private List<PersonModel> avaliableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = avaliableTeamMembers;

            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;

            teamMembersListBox.DisplayMember = "FullName";
        }

        private void CreateSampleData()
        {
            avaliableTeamMembers.Add(new PersonModel() { FirstName = "marve", LastName = "lannki" });
            avaliableTeamMembers.Add(new PersonModel() { FirstName = "maasdfve", LastName = "lannki" });

            selectedTeamMembers.Add(new PersonModel() { FirstName = "Try", LastName = "Gooed" });
            selectedTeamMembers.Add(new PersonModel() { FirstName = "Try", LastName = "Gooed" });
        }


        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellPhoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellPhoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (person != null)
            {
                avaliableTeamMembers.Remove(person);
                selectedTeamMembers.Add(person);
                WireUpLists();
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)teamMembersListBox.SelectedItem;
            if (person != null)
            {
                selectedTeamMembers.Remove(person);
                avaliableTeamMembers.Add(person);
                WireUpLists();
            }
            else
            {
                MessageBox.Show("Please Select a Team Member to Remove");
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            var Team = new TeamModel();
            Team.TeamName = teamNameValue.Text;
            Team.TeamMembers = selectedTeamMembers;

            Team = GlobalConfig.Connection.CreateTeam(Team);

            //TODO if we are not closing this form after creation, reset the form.
        }
    }
}