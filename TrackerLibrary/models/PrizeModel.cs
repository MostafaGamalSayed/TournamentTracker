using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.models
{
    class PrizeModel
    {

        /// <summary>
        /// Represents the number of the place which occupied by the winner team 
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Repersents the name of the place which occupied by the winner team 
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of money that will be given to the team 
        /// as a prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage amount of money that will be given to the team
        /// as a prize
        /// </summary>
        public double PrizePercentage { get; set; }


    }
}
