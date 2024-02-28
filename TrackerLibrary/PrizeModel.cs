using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// represents identifier for the price
        /// </summary>

        public int Id { get; set; }


        /// <summary>
        /// represents the number of
        /// place or position a team got
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// represents the name of the place or position the team got
        /// </summary>
        public string PlaceName { get; set; }


        /// <summary>
        /// represents the prize amount to be won by a team
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// represents the prizePercentage to be won
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}