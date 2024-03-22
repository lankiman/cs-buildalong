using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrackerLibrary
{
    public class TournamentModel
    {
        public int Id { get; set; }

        /// <summary>
        /// represents the name or the type of tournament being played
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// represents the entry fee required for teams to play in the tounament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// represent the teams entered or registered to play in the tournament
        /// </summary>

        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// represents the wining prizes for reach wining place
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// represent the set of matches and rounds that will take place in the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}