using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Order our list randomly of teams
        // Check if it is big enough - if not, add in byes  2*2*2*2 (2^4) or 2^nth
        // Create our first round of matchups
        // Create every round after that - 8 mathcups - 4 mathcups - 2 mathcups - 1 matchup

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizeTeams = RandomizeTeamOrder(model.EnteredTeams);
        }



        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            // teams.OrderBy(a => Guid.NewGuid()).ToList();
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
