using TrackerLibrary;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;

        List<int> rounds = new List<int>();

        private List<MatchupModel> selectedMatchups = new List<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpRoundsLists()
        {
            roundDropdown.DataSource = null;
            roundDropdown.DataSource = rounds;
        }

        private void WireUpMatchupsLists()
        {
            matchupListbox.DataSource = null;
            matchupListbox.DataSource = selectedMatchups;
            matchupListbox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds = new List<int>();

            rounds.Add(1);

            int currRound = 1;

            foreach (List<MatchupModel> mathcups in tournament.Rounds)
            {
                if (mathcups.First().MatchupRound > currRound)
                {
                    currRound = mathcups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            WireUpRoundsLists();
        }


        private void roundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            int round = (int)roundDropdown.SelectedItem;

            foreach (List<MatchupModel> mathcups in tournament.Rounds)
            {
                if (mathcups.First().MatchupRound == round)
                {
                    selectedMatchups = mathcups;
                }
            }

            WireUpMatchupsLists();
        }

        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)matchupListbox.SelectedItem;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Text = m.Entries[0].Score.ToString();
                    }
                    else
                    {
                        teamOneName.Text = "Not Yet Set";
                        teamOneScoreValue.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoName.Text = "Not Yet Set";
                        teamTwoScoreValue.Text = "";
                    }
                }
            }
        }

        private void matchupListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }
    }
}