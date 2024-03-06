using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class MatchupModel
    {
        /// <summary>
        /// represents the teams Playing 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// represents the winner of the mathcup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// represents the round played
        /// </summary>
        public int MatchupRound { get; set; }
    }
}