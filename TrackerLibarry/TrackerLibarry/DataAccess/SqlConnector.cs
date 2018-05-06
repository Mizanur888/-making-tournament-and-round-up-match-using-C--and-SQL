using TrackerLibarry;
using Dapper;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibarry
{
    class SqlConnector : IDbconnection
    {
        private const string db = "Tournaments";
        //TODO - implement perosn method

        public personModel createPerson(personModel pModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {
              
                var p = new DynamicParameters();
                p.Add("@Fname", pModel.Fname);
                p.Add("@Lname", pModel.Lname);
                p.Add("@EmailAddress", pModel.EmailAddress);
                p.Add("@phoneNumber", pModel.phoneNumber);
                p.Add("@Id", 0, dbType: DbType.Int32, direction:ParameterDirection.Output);
                connection.Execute("[Tournament].[dbo].[SpPeople_Insert]", p, commandType: CommandType.StoredProcedure);

                pModel.Id = p.Get<int>("@Id");

                return pModel;
            }
        }

        //TODO - make the create prize method to actually save the database

        /// <summary>
        /// save new price to the database
        /// </summary>
        /// <param name="return model data and save it in the database i"></param>
        /// <returns> return price info, including unique identifier</returns>
        public PrizeModel createPrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db))) {
                //Dictionary<string, PrizeModel> dicCustomer = new Dictionary<string, PrizeModel>();
                //string id = conver
                //dicCustomer.Add("@PlaceNumber", int.Parse(model.Id));
                //dicCustomer.Add("@PlaceName", model.Placename);
                //dicCustomer.Add("@PriceAmount", model.PriceAmount);
                //dicCustomer.Add("@PricePercentage", model.PricePercentage);
                //dicCustomer.Add("@Id", model.Id);

                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName",model.Placename);
                p.Add("@PriceAmount", model.PriceAmount);
                p.Add("@PricePercentage", model.PricePercentage);
               // p.Add("@Id",model.Id);
                 p.Add("@Id", 0, dbType: DbType.Int32, direction:ParameterDirection.Output);
                connection.Execute("[Tournament].[dbo].[SpSmaplePrizingInsert]", p,commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }

        public TeamModel createTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("[Tournament].[dbo].[spTeams_Insert]", p,
                    commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("Id");

                foreach(personModel tm in model.Teammember){
                     p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", tm.Id);
                    connection.Execute("[Tournament].[dbo].[spTeamMember_Insert]", p,
                        commandType: CommandType.StoredProcedure);
                    
                }
                return model;
            }
        }

        public void createTournamnet(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {

                saveTournament(connection, model);
                SaveTournamentPrizes(connection, model);
                save_tournamentEntries(connection, model);
                saveTournaMentRounds(connection, model);
               // return model;
            }
        }

        private void saveTournament(IDbConnection connection, TournamentModel model) {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntreyFee", model.EntreyFee);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("[Tournament].[dbo].[spTournament_insert]", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@Id");
        }
        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model) {
            var p = new DynamicParameters();
            foreach (PrizeModel pz in model.Prizes)
            {
                p = new DynamicParameters();
                p.Add("@TournaMentId", model.Id);
                p.Add("@PriceId", pz.Id);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("[Tournament].dbo.TournamentPrizes_Insert", p,
                    commandType: CommandType.StoredProcedure);

            }
        }
        private void save_tournamentEntries(IDbConnection connection, TournamentModel model) {
            var p = new DynamicParameters();

            foreach (TeamModel tm in model.EntredTeam)
            {
                p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("[Tournament].dbo.spTournaMentEntries_Insert", p,
                    commandType: CommandType.StoredProcedure);
            }

        }
        private void saveTournaMentRounds(IDbConnection connection, TournamentModel model) {

            foreach (List<MachUpModel> round in model.Rounds) {

                foreach (MachUpModel matchup in round) {
                    var p = new DynamicParameters();
                    p = new DynamicParameters();
                    p.Add("@TournaMentId", model.Id);
                    p.Add("@MatchUpRound", matchup.MatchRound);
                    p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("[Tournament].dbo.spMatchUpInsert", p,
                        commandType: CommandType.StoredProcedure);
                    matchup.Id = p.Get<int>("@Id");

                    foreach (MatchUpEtreyModel entry in matchup.Entries) {

                        p = new DynamicParameters();
                      
                        p.Add("@MatchUpId", matchup.Id);
                        if (entry.parentMatchUp == null)
                        {
                            p.Add("@ParentMatchUpId", null);
                        }
                        else {
                            p.Add("@ParentMatchUpId", entry.parentMatchUp.Id);
                        }
                    
                        if (entry.teamCompleationg == null)
                        {
                            p.Add("@TeamCompeatingId", null);
                        }
                        else
                        {
                            p.Add("@TeamCompeatingId", entry.teamCompleationg.Id);
                        }
                        p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        connection.Execute("[Tournament].dbo.spMatchUpEntriesInsert", p,
                            commandType: CommandType.StoredProcedure);
                       

                    }
                }
            }
        }
        public List<personModel> GetPerson_All()
        {
           
            List<personModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db))) {

                output = connection.Query<personModel>("Tournament.dbo.spPeopleGetAll").ToList();
            }
            return output;
        }

        public List<TeamModel> GetTeam_All()
        {

            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(db)))
            {

                output = connection.Query<TeamModel>("Tournament.dbo.spPeople_GetAll").ToList();

                foreach (TeamModel team in output) {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.Teammember = connection.Query<personModel>("Tournament.dbo.spTeamMember_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }
    }
}
