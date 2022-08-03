using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    /// <summary>
    /// Represents what the prize is for the given place.
    /// </summary>

    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>

        public int Id { get; set; }

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

        public PrizeModel() { }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
