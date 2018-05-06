using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibarry.DataAccess.TextHelpers;
namespace TrackerLibarry
{
    class TextConnector : IDbconnection
    {
        private const string prizesFile = "PrizeModels.text";
        private const string peopleFile = "PeopleModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournaMentFile = "TournamentModels.csv";
        public personModel createPerson(personModel pModel)
        {
            List<personModel> people = peopleFile.fullFilePath().loadpath().ConvertToPersonModel();
            int currentId = 1;
            if (people.Count > 0) {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            pModel.Id = currentId;
            people.Add(pModel);

            people.savePeopleFile(peopleFile);

            return pModel;
        }

        public PrizeModel createPrize(PrizeModel model)
        {
            //load the text file
            //convert the text list of prize mode
            //using extesion method
            List<PrizeModel> prizes = prizesFile.fullFilePath().loadpath().ConvertToPrizeModel();


            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            //currentId += 1;
            //then find the max id
            prizes.Add(model);


            //add the new record with the ned id (max + 1)
            //convert the prizes list of <string>
            //save the list <string> to the text file

            prizes.saveToPrizeFile(prizesFile);

            return model;
        }

        public TeamModel createTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.fullFilePath().loadpath().ConvertToTeamModels(peopleFile);

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);
            teams.saveToTeamFile(TeamFile);

            return model;
        }

        public void  createTournamnet(TournamentModel model)
        {
            List<TournamentModel> tournaMent = TournaMentFile
                .fullFilePath()
                .loadpath()
                .ConvertToTournamentModels(TeamFile, peopleFile, prizesFile);


            int currentId = 1;
            if (tournaMent.Count > 0)
            {
                currentId = tournaMent.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            tournaMent.Add(model);
            tournaMent.saveToTournaMentFile(TournaMentFile);
            //return tournaMent;
        }

        public List<personModel> GetPerson_All()
        {
            return peopleFile.fullFilePath().loadpath().ConvertToPersonModel();
          
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.fullFilePath().loadpath().ConvertToTeamModels(peopleFile);

        }
    }
}
