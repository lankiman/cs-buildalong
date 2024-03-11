using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace TrackerLibrary
{
    internal class SqlConnector : IDataConnection

    {
        private IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("Tournaments"));

        /// <summary>
        /// Save a new price to the Database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ///
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (connection)
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
            using (connection)
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", model.FirstName);
                parameters.Add("@LastName", model.LastName);
                parameters.Add("@EmailAddress", model.EmailAddress);
                parameters.Add("@PrizePercentage", model.CellphoneNumber);
                parameters.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@id");
            }

            return model;
        }
    }
}