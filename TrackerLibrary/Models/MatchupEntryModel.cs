using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }

        /// <summary>
        /// The id To represent of find the Team competing in the matchup
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents the score for the team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// represents the matchup the team came from
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// initializes the object
        /// </summary>
        /// <param name="initialScore"></param>
        // public MatchupEntryModel(double initialScore)
        // {
        // }
    }
}