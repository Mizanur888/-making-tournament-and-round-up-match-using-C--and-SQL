using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string fullFilePath(this string filename) {
            //F:\tournament\TrackerLibarry\prizemodel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{filename}";
        }

        public static List<string> loadpath(this string file) {

            if (!File.Exists(file)) {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines) {

            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string Lines in lines) {

                string[] cols = Lines.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.Placename = cols[2];
                p.PriceAmount = decimal.Parse(cols[3]);
                p.PricePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }
        public static List<personModel> ConvertToPersonModel(this List<string> Lines) {

            List<personModel> output = new List<personModel>();

            foreach(string lines in Lines) {

                string[] cole = lines.Split(',');
                personModel p = new personModel();
                p.Id = int.Parse(cole[0]);
                p.Fname = cole[1];
                p.Lname = cole[2];
                p.EmailAddress = cole[3];
                p.phoneNumber = cole[4];
                output.Add(p);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peoplefilename) {
            List<TeamModel> output = new List<TeamModel>();

            List<personModel> people = peoplefilename.fullFilePath().loadpath().ConvertToPersonModel();

            foreach (string p in lines) {

                string[] cols = p.Split(',');
                TeamModel tm = new TeamModel();

                tm.Id =int.Parse( cols[0]);
                tm.TeamName = cols[1];

                string[] personId = cols[2].Split('|');

                foreach (string id in personId) {

                    tm.Teammember.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(tm);
            }

            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string>lines,
            string teamFile, string peopleFileName, string prizesFile) {
            List<TournamentModel> output = new List<TournamentModel>();
            //Id,TournamentName,EntreyFee(id|id|id EntredTeam),(id|id|id Prizes), (Rounds id^id^id|id^id^id|id^id^id)
            List<TeamModel> teams = teamFile.fullFilePath().loadpath().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizesFile.fullFilePath().loadpath().ConvertToPrizeModel();

            foreach (string line in lines) {

                string[] col = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id =int.Parse( col[0]);
                tm.TournamentName = col[1];
                tm.EntreyFee = decimal.Parse(col[2]);
                string[] teamId = col[3].Split('|');
                foreach (string id in teamId) {

                    //tm.Teammember.Add(people.Where(x => x.Id == int.Parse(id)).First());
                    tm.EntredTeam.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeId = col[4].Split('|');
                foreach (string prId in prizeId) {

                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(prId)).First());
                }

                //TODO - capture round information


                output.Add(tm);
                
            }
            return output;

        }
        public static void saveToPrizeFile(this List<PrizeModel> model , string filename) {

            List<string> lines = new List<string>();
            foreach (PrizeModel p in model) {

                lines.Add($"{p.Id}, {p.PlaceNumber}, {p.Placename}, {p.PriceAmount}, {p.PricePercentage}");
            }
            File.WriteAllLines(filename.fullFilePath(), lines);
        }

        public static void savePeopleFile(this List<personModel> model, string filename) {

            List<string> lines = new List<string>();

            foreach (personModel p in model) {
                lines.Add($"{p.Id}, {p.Fname}, {p.Lname}, {p.EmailAddress}, {p.phoneNumber}");
            }
            File.WriteAllLines(filename.fullFilePath(), lines);
        }

        public static void saveToTeamFile(this List<TeamModel> model, string filename) {

            List<string> lines = new List<string>();

            foreach (TeamModel t in model) {

                lines.Add($"{t.Id}, {t.TeamName}, {convertPeopleListToString(t.Teammember)}");
            }

            //File.WriteAllLines(filename.fullFilePath(), lines);
            File.AppendAllLines(filename.fullFilePath(), lines);
        }
        public static void saveToTournaMentFile(this List<TournamentModel> model, string filename) {

            List<string> lines = new List<string>();

            foreach (TournamentModel tm in model) {

                lines.Add($@"{tm.Id},{tm.TournamentName},
                        {tm.EntreyFee},
                        {convertTeamListToString(tm.EntredTeam)},
                        {convertPrizeListToString(tm.Prizes)},
                        {convertRoundListToString(tm.Rounds)}");
            }
            File.AppendAllLines(filename.fullFilePath(), lines);
        }
        private static string convertRoundListToString(List<List<MachUpModel>>roundModel)
        {
            string output = "";

            if (roundModel.Count == 0)
            {

                return "";
            }

            foreach (List<MachUpModel> round in roundModel)
            {

                output += $"{convertMatchUpListToString(round)}|";

            }

            output = output.Substring(0, output.Length - 1);

            return output;

        }
        private static string convertMatchUpListToString(List<MachUpModel> MatchUp) {

            string output = "";

            if (MatchUp.Count == 0)
            {

                return "";
            }

            foreach ( MachUpModel m in MatchUp)
            {

                output += $"{m.Id}^";

            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string convertTeamListToString(List<TeamModel> model) {
            string output = "";

            if (model.Count == 0)
            {

                return "";
            }

            foreach (TeamModel tm in model)
            {

                output += $"{tm.Id}|";

            }

            output = output.Substring(0, output.Length - 1);

            return output;

        }
        private static string convertPrizeListToString(List<PrizeModel> model)
        {
            string output = "";

            if (model.Count == 0)
            {

                return "";
            }

            foreach (PrizeModel pr in model)
            {

                output += $"{pr.Id}|";

            }

            output = output.Substring(0, output.Length - 1);

            return output;

        }

        private static string convertPeopleListToString(List<personModel> people) {

            string output = "";

            if (people.Count == 0) {

                return "";
            }

            foreach (personModel p in people) {

                output += $"{p.Id}|";

            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
