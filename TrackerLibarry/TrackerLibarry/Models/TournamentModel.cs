using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
   public class TournamentModel
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public decimal EntreyFee { get; set; }
        public List<TeamModel> EntredTeam { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MachUpModel>> Rounds { get; set; } = new List<List<MachUpModel>>();

    }
}
