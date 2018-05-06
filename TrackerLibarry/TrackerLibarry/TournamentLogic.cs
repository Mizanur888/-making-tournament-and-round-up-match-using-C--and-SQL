using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
   public static class TournamentLogic
    {
        public static void CreateRound(TournamentModel model) {

            List<TeamModel> randomizeTeam = randomizeTeamOrder(model.EntredTeam);
            int rounds = findNumberOfRounds(randomizeTeam.Count);
            int buyes = NumberOfByes(rounds,randomizeTeam.Count);

            model.Rounds.Add(createFirstRound(buyes, randomizeTeam));
            createOtherRound(model, rounds);
        }

        private static void createOtherRound(TournamentModel model, int numOfRounds) {

            int round = 2;
            List< MachUpModel > previewsModel = model.Rounds[0];
            List<MachUpModel> currentRound = new List<MachUpModel>();
            MachUpModel currentMatchUp = new MachUpModel();
            while (round <= numOfRounds) {

                foreach (MachUpModel matchup in previewsModel) {
                    currentMatchUp.Entries.Add(new MatchUpEtreyModel { parentMatchUp = matchup });
                    if (currentMatchUp.Entries.Count > 1) {

                        currentMatchUp.MatchRound = round;
                        currentRound.Add(currentMatchUp);
                        currentMatchUp = new MachUpModel();
                        
                    }
                }
                model.Rounds.Add(currentRound);
                previewsModel = currentRound;
                currentRound = new List<MachUpModel>();
                round += 1;
            }
        }


        private static List<MachUpModel> createFirstRound(int byes, List<TeamModel>teams) {

            List<MachUpModel> output = new List<MachUpModel>();
            MachUpModel curr = new MachUpModel();

            foreach (TeamModel tm in teams) {
                curr.Entries.Add(new MatchUpEtreyModel { teamCompleationg = tm });
                if (byes > 0 || curr.Entries.Count > 1) {
                    curr.MatchRound = 1;
                    output.Add(curr);
                    curr = new MachUpModel();
                    if (byes > 0) {
                        byes -=1;
                    }
                }

            }
            return output;
        }
        private static int NumberOfByes(int round, int numberofTeams) {

            int output = 0;
            int totalTeam = 1;

            for (int i = 1; i <= round; i++) {

                totalTeam *= 2;
            }

            return output = totalTeam-numberofTeams;
        }
        private static int findNumberOfRounds(int teamCout) {

            int output = 1;
            int val = 2;
            while (val < teamCout) {

                output += 1;
                val *= 2;
            }
            return output;
        }
        private static List<TeamModel> randomizeTeamOrder(List<TeamModel> teams) {

            return teams.OrderBy(x => Guid.NewGuid()).ToList();

        }
    }
}
