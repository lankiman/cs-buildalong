using System.ComponentModel;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;

        BindingList<int> rounds = new BindingList<int>();

        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        MatchupModel deterList;

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
            roundDropdown.DataSource = rounds;
        }

        private void WireUpMatchupsLists()
        {
            matchupListbox.DataSource = selectedMatchups;
            matchupListbox.DisplayMember = "DisplayName";
            deterList = (MatchupModel)matchupListbox.Items[0];
            LoadMatchup();
        }

        private void LoadRounds()
        {
            rounds.Clear();

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
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in mathcups)
                    {
                        selectedMatchups.Add(m);
                    }
                }
            }

            WireUpMatchupsLists();
        }

        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)matchupListbox.SelectedItem;


            if (m == null)
            {
                m = deterList;
            }

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        teamTwoName.Text = "<bye>";
                        teamTwoScoreValue.Text = "0";
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