using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class TeamModel
    {
        /// <summary>
        /// represents name of the persons or team members
        /// participating in the tournament
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// represent the name of the teams participating in the tournament
        /// </summary>
        public string TeamName { get; set; }
    }
}