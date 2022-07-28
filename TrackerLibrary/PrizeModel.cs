using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the numeric place a team finished.
        /// </summary>

        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name / title of the place a team finished.
        /// </summary>

        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the total prize amount.
        /// </summary>

        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the prize given to a finisher.
        /// </summary>

        public double PrizePercentage { get; set; }
    }
}
