using CIS_560_Proj.Items;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CIS_560_Proj.MoviePersons
{
    internal class RetrieveDelegate : DataReaderDelegate<IReadOnlyList<MoviePerson>>
    {
        public RetrieveDelegate()
         : base("Film.RetrieveMoviePerson")
        {
        }

        public override IReadOnlyList<MoviePerson> Translate(SqlCommand command, IDataRowReader reader)
        {
            var person = new List<MoviePerson>();

            while (reader.Read())
            {

                person.Add(new MoviePerson(reader.GetInt32("MoviePersonId"),
               reader.GetInt32("PersonId"),
               reader.GetInt32("MovieId"),
               reader.GetString("Role")));
            }

            return person;
        }
    }
}
