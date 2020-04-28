using CIS_560_Proj.Items;
using System;
using System.Data.SqlClient;


namespace CIS_560_Proj.MoviesAwardsWon_Delegate
{
    internal class GetDelegate : DataReaderDelegate<MovieAwardsWon>
    {
        private readonly string Name;

        public GetDelegate(string name)
           : base("GetMoviesAwardsWonCategory")
        {
            this.Name = name;
        }

        public override void PrepareCommand(SqlCommand command)//overide
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Category", Name);
        }

        public override MovieAwardsWon Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new MovieAwardsWon(Convert.ToInt32(reader.GetString("MoviesAwardsWonId")),
               reader.GetInt32("MovieId"),
                Name
                );
        }
    }
}
