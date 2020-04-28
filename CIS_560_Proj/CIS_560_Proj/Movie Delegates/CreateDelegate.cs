using CIS_560_Proj.Items;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Movie_Delegates
{
    internal class CreateDelegate : NonQueryDataDelegate<Movie>
    {
        public readonly string ProductionId;
        public readonly string MovieName;
        public readonly string ReleaseDate;


        public CreateDelegate(string ProductionId, string MovieName, string ReleaseDate)
           : base("Film.CreateMovie")
        {
            this.ProductionId = ProductionId;
            this.MovieName = MovieName;
            this.ReleaseDate = ReleaseDate;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ProductionId", SqlDbType.NVarChar);
            p.Value = ProductionId;

            p = command.Parameters.Add("MovieName", SqlDbType.NVarChar);
            p.Value = MovieName;
            p = command.Parameters.Add("ReleaseDate", SqlDbType.NVarChar);
            p.Value = ReleaseDate;

            p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Movie Translate(SqlCommand command)
        {
            return new Movie((int)command.Parameters["MovieId"].Value, Convert.ToInt32(ProductionId), MovieName, Convert.ToDateTime(ReleaseDate));
        }
    }
}
