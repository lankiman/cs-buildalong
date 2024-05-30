using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace TrackerLibrary
{
    internal class SqlConnector : IDataConnection

    {
        private string db = "Tournaments";

        /// <summary>
        /// Save a new price to the Database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ///
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                //
                // @PlaceNumber int,
                // @PlaceName nvarchar(50),
                // @PrizeAmount money,
                //     @PrizePercentage float,
                // @id int=0 output

                var parameters = new DynamicParameters();
                parameters.Add("@PlaceNumber", model.PlaceNumber);
                parameters.Add("@PlaceName", model.PlaceName);
                parameters.Add("@PrizeAmount", model.PrizeAmount);
                parameters.Add("@PrizePercentage", model.PrizePercentage);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@id");

                return model;
            }
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", model.FirstName);
                parameters.Add("@LastName", model.LastName);
                parameters.Add("@EmailAddress", model.EmailAddress);
                parameters.Add("@CellphoneNumber", model.CellphoneNumber);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@id");
            }

            return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                SaveTournament(model, connection);
                SaveTournamentPrizes(model, connection);
                SaveTournamentEntries(model, connection);
                SaveTournamentRounds(model, connection);
            }
        }


        public void updateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", model.Id);
                parameters.Add("@WinnerId", model.Winner.Id);

                connection.Execute("dbo.spMatchups_Update", parameters, commandType: CommandType.StoredProcedure);

                foreach (MatchupEntryModel me in model.Entries)
                {
                    parameters = new DynamicParameters();
                    parameters.Add("@id", me.Id);
                    parameters.Add("@TeamCompetingId", me.TeamCompeting.Id);
                    parameters.Add("@Score", me.Score);

                    connection.Execute("dbo.spMatchupsEntries_Update", parameters,
                        commandType: CommandType.StoredProcedure);
                }
            }
        }

        private void SaveTournament(TournamentModel model, IDbConnection connection)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@TournamentName", model.TournamentName);
            parameters.Add("@EntryFee", model.EntryFee);

            parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", parameters, commandType: CommandType.StoredProcedure);

            model.Id = parameters.Get<int>("@id");
        }

        private void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
        {
            foreach (PrizeModel prize in model.Prizes)
            {
                var parameters = new DynamicParameters();
                parameters.Add("@TournamentId", model.Id);
                parameters.Add("@PrizeId", prize.Id);

                connection.Execute("dbo.spTournamentPrizes_Insert", parameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentEntries(TournamentModel model, IDbConnection connection)
        {
            foreach (TeamModel team in model.EnteredTeams)
            {
                var parameters = new DynamicParameters();
                parameters.Add("@TournamentId", model.Id);
                parameters.Add("@TeamId", team.Id);

                connection.Execute("dbo.spTournamentEntries_Insert", parameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentRounds(TournamentModel model, IDbConnection connection)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@TournamentId", model.Id);
                    parameters.Add("@MatchupRound", matchup.MatchupRound);
                    parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", parameters,
                        commandType: CommandType.StoredProcedure);

                    matchup.Id = parameters.Get<int>("@id");

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        parameters = new DynamicParameters();
                        parameters.Add("@MatchupId", matchup.Id);

                        if (entry.ParentMatchup == null)
                        {
                            parameters.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            parameters.Add("@ParentMatchupId", entry.ParentMatchup.Id);
                        }

                        if (entry.TeamCompeting == null)
                        {
                            parameters.Add("@TeamCompetingId", null);
                        }
                        else
                        {
                            parameters.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        }

                        parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", parameters,
                            commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", parameters,
                        commandType: CommandType.StoredProcedure).ToList();
                }
            }"test push"

            return output;
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();

                foreach (TournamentModel tournament in output)
                {
                    //populate prices
                    var para = new DynamicParameters();
                    para.Add("@TournamentId", tournament.Id);
                    tournament.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", para,
                        commandType: CommandType.StoredProcedure).ToList();


                    //populiate team
                    tournament.EnteredTeams = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", para,
                        commandType: CommandType.StoredProcedure).ToList();

                    foreach (TeamModel team in tournament.EnteredTeams)
                    {
                        var param = new DynamicParameters();
                        param.Add("@TeamId", team.Id);
                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", param,
                            commandType: CommandType.StoredProcedure).ToList();
                    }

                    //populate Rounds

                    var parameters = new DynamicParameters();
                    parameters.Add("@TournamentId", tournament.Id);
                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament",
                        parameters,
                        commandType: CommandType.StoredProcedure).ToList();
                    foreach (MatchupModel m in matchups)
                    {
                        var p = new DynamicParameters();
                        p.Add("@MatchupId", m.Id);
                        m.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup",
                            p,
                            commandType: CommandType.StoredProcedure).ToList();
                        List<TeamModel> allTeams = GetTeam_All();


                        if (m.WinnerId > 0)
                        {
                            m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
                        }

                        foreach (MatchupEntryModel e in m.Entries)
                        {
                            if (e.TeamCompetingId > 0)
                            {
                                e.TeamCompeting = allTeams.Where(x => x.Id == e.TeamCompetingId).First();
                            }

                            if (e.ParentMatchpuId > 0)
                            {
                                e.ParentMatchup = matchups.Where(x => x.Id == e.ParentMatchpuId).First();
                            }
                        }
                    }

                    //list<list><mathupmodel>
                    List<MatchupModel> currRow = new List<MatchupModel>();
                    int currRound = 1;

                    foreach (MatchupModel m in matchups)
                    {
                        if (m.MatchupRound > currRound)
                        {
                            tournament.Rounds.Add(currRow);
                            currRow = new List<MatchupModel>();
                            currRound += 1;
                        }

                        currRow.Add(m);
                    }

                    tournament.Rounds.Add(currRow);
                }
            }

            return output;
        }


        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@TeamName", model.TeamName);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@id");

                foreach (PersonModel person in model.TeamMembers)
                {
                    parameters = new DynamicParameters();
                    parameters.Add("@TeamId", model.Id);
                    parameters.Add("@PersonId", person.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", parameters,
                        commandType: CommandType.StoredProcedure);
                }

                return model;
            }
        }
    }
}