using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Xml;


namespace TrackerLibrary
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{GlobalConfig.configuration.GetSection("FilePath")["TextFiles"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                var p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }

        public static List<PersonModel> ConverToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                var p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();

            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConverToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                var team = new TeamModel();
                team.Id = int.Parse(cols[0]);
                team.TeamName = cols[1];
                string[] personIds = cols[2].Split("|");

                foreach (string id in personIds)
                {
                    team.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(team);
            }

            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName,
            string peopleFileName, string prizesFilename)
        {
            // id, TournamentName, EntryFee, (id | id| id- entered teams), (id|id|id - prizes), (Rounds- id ^ id ^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizesFilename.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();


            foreach (string line in lines)
            {
                string[] cols = line.Split(",");

                TournamentModel tournament = new TournamentModel();
                tournament.Id = int.Parse(cols[0]);
                tournament.TournamentName = cols[1];
                tournament.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split("|");

                foreach (string id in teamIds)
                {
                    tournament.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split("|");

                foreach (string id in prizeIds)
                {
                    if (id != "")
                    {
                        tournament.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }

                string[] rounds = cols[5].Split("|");


                foreach (string round in rounds)
                {
                    List<MatchupModel> ms = new List<MatchupModel>();
                    string[] msText = round.Split("^");
                    foreach (string mathcupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(mathcupModelTextId)).First());
                    }

                    tournament.Rounds.Add(ms);
                }

                output.Add(tournament);
            }

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id}, {p.PlaceNumber}, {p.PlaceName}, {p.PrizeAmount}, {p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id}, {p.FirstName}, {p.LastName}, {p.EmailAddress}, {p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel team in models)
            {
                lines.Add($"{team.Id},{team.TeamName},{ConvertPeoplelistToString(team.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tournament in models)
            {
                lines.Add(
                    $@"{tournament.Id},{tournament.TournamentName},{tournament.EntryFee},{ConvertTeamlistToString(tournament.EnteredTeams)},{ConvertPrizeslistToString(tournament.Prizes)},{ConvertRoundlistToString(tournament.Rounds)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveRoundsToFile(this TournamentModel model, string matchupFile,
            string matchupEntryFile)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile(matchupFile, matchupEntryFile);
                }
            }
        }

        private static List<MatchupEntryModel> ConvertStringtoMatchupEntryModels(string input)
        {
            string[] ids = input.Split("|");

            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries =
                GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();

            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(",");

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }

            output = matchingEntries.ConvertToMatchupEntryModels();

            return output;
        }

        private static TeamModel LookTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(",");

                if (cols[0] == id.ToString())
                {
                    List<String> matchingTeams = new List<string>();

                    matchingTeams.Add(team);

                    return matchingTeams.ConvertToTeamModels(GlobalConfig.PeopleFile).First();
                }
            }

            return null;
        }


        private static MatchupModel LookMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(",");

                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();

                    matchingMatchups.Add(matchup);

                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }

            return null;
        }

        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                var mathchup = new MatchupModel();
                mathchup.Id = int.Parse(cols[0]);
                mathchup.Entries = ConvertStringtoMatchupEntryModels(cols[1]);
                if (cols[2].Length == 0)
                {
                    mathchup.Winner = null;
                }
                else
                {
                    mathchup.Winner = LookTeamById(int.Parse(cols[2]));
                }

                mathchup.MatchupRound = int.Parse(cols[3]);

                output.Add(mathchup);
            }

            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                var m = new MatchupEntryModel();
                m.Id = int.Parse(cols[0]);

                if (cols[1].Length == 0)
                {
                    m.TeamCompeting = null;
                }
                else
                {
                    m.TeamCompeting = LookTeamById(int.Parse(cols[1]));
                }

                m.Score = double.Parse(cols[2]);

                int parentId = 0;

                if (int.TryParse(cols[3], out parentId))
                {
                    m.ParentMatchup = LookMatchupById(parentId);
                }
                else
                {
                    m.ParentMatchup = null;
                }


                output.Add(m);
            }

            return output;
        }


        public static void SaveMatchupToFile(this MatchupModel matchup, string matchupFile, string matchupEntryFile)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;

            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile(matchupEntryFile);
            }

            //save to file
            List<string> lines = new List<string>();

            foreach (MatchupModel mat in matchups)

            {
                string winner = "";
                if (mat.Winner != null)
                {
                    winner = mat.Winner.Id.ToString();
                }

                lines.Add($"{mat.Id},{ConvertMatchupEntryListToString(mat.Entries)},{winner},{mat.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry, string matchupEntryFile)
        {
            List<MatchupEntryModel> entries =
                GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;

            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }

            entry.Id = currentId;

            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel etr in entries)
            {
                string parent = "";
                if (etr.ParentMatchup != null)
                {
                    parent = etr.ParentMatchup.Id.ToString();
                }

                string teamCompeting = "";

                if (etr.TeamCompeting != null)
                {
                    teamCompeting = etr.TeamCompeting.Id.ToString();
                }

                lines.Add($"{etr.Id},{teamCompeting},{etr.Score}, {parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        private static string ConvertPeoplelistToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }

            foreach (PersonModel person in people)
            {
                output += $"{person.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizeslistToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel prize in prizes)
            {
                output += $"{prize.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertTeamlistToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel team in teams)
            {
                output += $"{team.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertRoundlistToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> matchup in rounds)
            {
                output += $"{ConvertMatchupListToString(matchup)}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel matchup in matchups)
            {
                output += $"{matchup.Id}^";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";

            if (entries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel entry in entries)
            {
                output += $"{entry.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}