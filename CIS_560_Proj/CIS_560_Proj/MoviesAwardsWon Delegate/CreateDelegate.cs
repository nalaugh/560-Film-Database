using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.MoviesAwardsWon_Delegate
{
    internal class CreateDelegate : NonQueryDataDelegate<MovieAwardsWon>
    {
        public readonly int movieId;
        public readonly string category;


        public CreateDelegate(int movieId, string category)
           : base("CreateMovieAwardsWon")
        {
            this.movieId = movieId;
            this.category = category;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.NVarChar);
            p.Value = movieId;

            p = command.Parameters.Add("Category", SqlDbType.NVarChar);
            p.Value = category;


            p = command.Parameters.Add("MovieAwardsWon", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override MovieAwardsWon Translate(SqlCommand command)
        {
            return new MovieAwardsWon((int)command.Parameters["MovieAwardsWon"].Value, movieId, category);
        }
    }
}
