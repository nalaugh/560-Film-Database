using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.MoviePersons
{
    internal class CreateDelegate : NonQueryDataDelegate<MoviePerson>
    {
        public readonly int personId;
        public readonly int movieId;
        public readonly string role;


        public CreateDelegate(int PersonId, int MovieId, string Role)
           : base("CreateMoviePerson")
        {
            this.personId = PersonId;
            this.movieId = MovieId;
            this.role = Role;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("PersonId", SqlDbType.NVarChar);
            p.Value = personId;

            p = command.Parameters.Add("MovieId", SqlDbType.NVarChar);
            p.Value = movieId;

            p = command.Parameters.Add("Role", SqlDbType.NVarChar);
            p.Value = role;


            p = command.Parameters.Add("MoviePersonId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override MoviePerson Translate(SqlCommand command)
        {
            return new MoviePerson((int)command.Parameters["MoviePersonId"].Value,personId, movieId, role);
        }
    }
}
