using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {

        /// <summary>
        /// A list that fits the PersonModel.
        /// </summary>

        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the name of a Team.
        /// </summary>

        public string TeamName { get; set; }
    }
}
