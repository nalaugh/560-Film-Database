using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.MoviesAwardsWon_Delegate
{
    class FetchDelegate : DataReaderDelegate<MovieAwardsWon>
    {
        private readonly int MovieAwardsWonId;

        public FetchDelegate(int MovieAwardsWonId)
           : base("FetchMovieAwardsWon")
        {
            this.MovieAwardsWonId = MovieAwardsWonId;
        }

        public override void PrepareCommand(SqlCommand command)///may need to overide
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = MovieAwardsWonId;
        }

        public override MovieAwardsWon Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            if (!reader.Read())
                throw new RecordNotFoundException(MovieAwardsWonId.ToString());

            return new MovieAwardsWon(MovieAwardsWonId,
               reader.GetInt32("MovieId"),
               reader.GetString("Category")
             );
        }
    }
}
