using CIS_560_Proj.Items;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CIS_560_Proj.MoviesAwardsWon_Delegate
{
    internal class RetrieveDelegate : DataReaderDelegate<IReadOnlyList<MovieAwardsWon>>
    {
        public RetrieveDelegate()
          : base("Film.RetrieveMovieAwardsWon")
        {
        }

        public override IReadOnlyList<MovieAwardsWon> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Movie = new List<MovieAwardsWon>();

            while (reader.Read())
            {

                Movie.Add(new MovieAwardsWon(reader.GetInt32("MovieAwardsWonId"),
               reader.GetInt32("MovieId"),
                reader.GetString("Category")
               ));
            }

            return Movie;
        }
    }
}
