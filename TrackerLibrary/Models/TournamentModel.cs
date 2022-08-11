using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Unique identifier for the tournament
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// Represents the name given to a Tournament.
        /// </summary>

        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the cost / fee for entry to a tournament.
        /// </summary>

        public decimal EntryFee { get; set; }

        /// <summary>
        /// A list that fits the TeamModel.
        /// </summary>

        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// A list that fits the PrizeModel.
        /// </summary>

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// A list that fits the MatchupModel.
        /// </summary>

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
