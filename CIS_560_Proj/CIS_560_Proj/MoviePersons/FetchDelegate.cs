using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.MoviePersons
{
     internal class FetchDelegate : DataReaderDelegate<MoviePerson>
    {
        private readonly int moviepersonId;

        public FetchDelegate(int moviepersonId)
           : base("FetchMoviePerson")
        {
            this.moviepersonId = moviepersonId;
        }

        public override void PrepareCommand(SqlCommand command)///may need to overide
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MoviePersonId", SqlDbType.Int);
            p.Value = moviepersonId;
        }

        public override MoviePerson Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            if (!reader.Read())
                throw new RecordNotFoundException(moviepersonId.ToString());

            return new MoviePerson(moviepersonId,
               reader.GetInt32("PersonId"),
                reader.GetInt32("MovieId"),
               reader.GetString("Role"));
        }
    }
}
