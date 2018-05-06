using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
    public interface IDbconnection
    {
        PrizeModel createPrize(PrizeModel model);
        personModel createPerson(personModel pModel);

        TeamModel createTeam(TeamModel model);
        void createTournamnet(TournamentModel model);
        List<TeamModel> GetTeam_All();
        List<personModel> GetPerson_All();
    }
}
