using CIS_560_Proj.Interface;
using CIS_560_Proj.Items;
using CIS_560_Proj.MoviesAwardsWon_Delegate;
using System;
using System.Collections.Generic;

namespace CIS_560_Proj
{
    public class SqlMovieAwardsWonRepository : IMovieAwardsWon
    {
        private readonly SqlCommandExecutor executor;

        public SqlMovieAwardsWonRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public MovieAwardsWon CreateMovieAwardsWon(int movieId, string category)
        {


            if (string.IsNullOrWhiteSpace(movieId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieId));
            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(category));


            var d = new CreateDelegate(movieId, category);
            return executor.ExecuteNonQuery(d);
        }

        public MovieAwardsWon FetchMovieAwardsWon(int productionId)
        {
            var d = new FetchDelegate(productionId);
            return executor.ExecuteReader(d);
        }

        public MovieAwardsWon GetMovieAwardsWon(string email)
        {
            var d = new GetDelegate(email);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<MovieAwardsWon> RetrieveMovieAwardsWon()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }
    }
}
