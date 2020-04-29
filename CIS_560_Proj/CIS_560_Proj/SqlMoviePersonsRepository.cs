using CIS_560_Proj.Interface;
using CIS_560_Proj.Items;
using CIS_560_Proj.MoviePersons;
using System;
using System.Collections.Generic;

namespace CIS_560_Proj
{
    public class SqlMoviePersonsRepository : IMoviePerson
    {
        private readonly SqlCommandExecutor executor;

        public SqlMoviePersonsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public MoviePerson CreateMoviePerson(int PersonId, int MovieId, string Role)
        {
            if (string.IsNullOrWhiteSpace(PersonId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(PersonId));

            if (string.IsNullOrWhiteSpace(MovieId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(MovieId));
            if (string.IsNullOrWhiteSpace(Role))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Role));


            var d = new CreateDelegate(PersonId, MovieId, Role);
            return executor.ExecuteNonQuery(d);
        }

        public MoviePerson FetchMoviePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public MoviePerson GetMoviePerson(string name)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<MoviePerson> RetrieveMoviePerson()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }
    }
}
