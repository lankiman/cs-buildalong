using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public int Id { get; set; }

        /// <summary>
        /// represents the teams Playing 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// the id form teh database that will be used to identify the user
        /// </summary>

        public int WinnerId { get; set; }

        /// <summary>
        /// represents the winner of the mathcup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// represents the round played
        /// </summary>
        public int MatchupRound { get; set; }


        public string DisplayName
        {
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup not yet Determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}