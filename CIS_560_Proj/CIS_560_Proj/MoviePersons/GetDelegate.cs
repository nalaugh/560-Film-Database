using CIS_560_Proj.Items;
using System;
using System.Data.SqlClient;

namespace CIS_560_Proj.MoviePersons
{
    internal class GetDelegate : DataReaderDelegate<MoviePerson>
    {
        private readonly int Name;

        public GetDelegate(int name)
           : base("GetMoviePersonPersonId")
        {
            this.Name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PersonId", Name);
        }

        public override MoviePerson Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(Name.ToString());

            return new MoviePerson(reader.GetInt32("MoviePersonId"),
               Name,
               reader.GetInt32("MovieId"),
               reader.GetString("Role")
               );
        }
    }
}
