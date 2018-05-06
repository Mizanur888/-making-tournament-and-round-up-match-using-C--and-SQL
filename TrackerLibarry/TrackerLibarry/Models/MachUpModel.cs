using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
   public class MachUpModel
    {
        public int Id { get; set; }
        public List<MatchUpEtreyModel> Entries { get; set; } = new List<MatchUpEtreyModel>();
        public TeamModel winer { get; set; }
        public int MatchRound { get; set; }

    }
}
