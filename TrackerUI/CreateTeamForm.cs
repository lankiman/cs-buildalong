using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();

            // CreateSampleData();

            WireUPLists();
        }

        private List<PersonModel> avaliableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        private void WireUPLists()
        {
            selectTeamMemberDropDown.DataSource = avaliableTeamMembers;

            selectTeamMemberDropDown.DisplayMember = "FullName";

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

                GlobalConfig.Connection.CreatePerson(p);

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
    }
}