using CIS_560_Proj.Items;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CIS_560_Proj.Movie_Delegates
{
    internal class RetrieveDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        public RetrieveDelegate()
          : base("RetrieveMovie")
        {
        }

        public override IReadOnlyList<Movie> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Movie = new List<Movie>();

            while (reader.Read())
            {

                Movie.Add(new Movie(Convert.ToInt32(reader.GetInt32("MovieId")),
               reader.GetInt32("ProductionId"),
                reader.GetString("MovieName"),
                reader.GetString("ReleaseDate"),
               reader.GetString("IsDeleted")));
            }

            return Movie;
        }
    }
    internal class RetrieveDelegateDeleated : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        public RetrieveDelegateDeleated()
          : base("RetrieveMovieDeleated")
        {
        }

        public override IReadOnlyList<Movie> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Movie = new List<Movie>();

            while (reader.Read())
            {

                Movie.Add(new Movie(Convert.ToInt32(reader.GetInt32("MovieId")),
               reader.GetInt32("ProductionId"),
                reader.GetString("MovieName"),
               "NULL",
              "NULL"));
            }

            return Movie;
        }
    }
}
