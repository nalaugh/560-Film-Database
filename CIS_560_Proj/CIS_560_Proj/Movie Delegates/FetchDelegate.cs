using CIS_560_Proj.Items;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Movie_Delegates
{
    internal class FetchDelegate : DataReaderDelegate<Movie>
    {
        private readonly int MovieId;

        public FetchDelegate(int MovieId)
           : base("FetchMovie")
        {
            this.MovieId = MovieId;
        }

        public override void PrepareCommand(SqlCommand command)///may need to overide
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = MovieId;
        }

        public override Movie Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            if (!reader.Read())
                throw new RecordNotFoundException(MovieId.ToString());

            return new Movie(MovieId,
               reader.GetInt32("ProductionId"),
               reader.GetString("MovieName"),
               reader.GetString("ReleasDate"));
        }
    }
}
