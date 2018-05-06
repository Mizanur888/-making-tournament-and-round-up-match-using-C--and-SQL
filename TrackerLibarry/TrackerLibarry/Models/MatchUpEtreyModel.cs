using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
    public class MatchUpEtreyModel
    {
        public int Id { get; set; }
        /// <summary>
        /// represent oneteam in the matchup
        /// </summary>
        public TeamModel teamCompleationg { get; set; }
        /// <summary>
        /// represent Score for the particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MachUpModel parentMatchUp { get; set; }
        
       
    }
}
