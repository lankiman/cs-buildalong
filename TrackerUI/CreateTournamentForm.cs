using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        private List<TeamModel> avalibleTeams = GlobalConfig.Connection.GetTeam_All();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            selectTeamDropDown.DataSource = avalibleTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListbox.DataSource = selectedTeams;
            tournamentTeamsListbox.DisplayMember = "TeamName";

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            // PersonModel person = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            // if (person != null)
            // {
            //     avaliableTeamMembers.Remove(person);
            //     selectedTeamMembers.Add(person);
            //     WireUPLists();
            // }
        }
    }
}