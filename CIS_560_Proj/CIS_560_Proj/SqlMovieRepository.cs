using CIS_560_Proj.Interface;
using CIS_560_Proj.Items;
using CIS_560_Proj.Movie_Delegates;
using System;
using System.Collections.Generic;

namespace CIS_560_Proj
{


    public class SqlMovieRepository : IMovie
    {
        private readonly SqlCommandExecutor executor;

        public SqlMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public Movie CreateMovie(string ProductionId, string MovieName, string ReleaseDate)
        {
            if (string.IsNullOrWhiteSpace(ProductionId))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(ProductionId));

            if (string.IsNullOrWhiteSpace(MovieName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(MovieName));
            if (string.IsNullOrWhiteSpace(ReleaseDate))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(ReleaseDate));


            var d = new CreateDelegate(ProductionId, MovieName, ReleaseDate);
            return executor.ExecuteNonQuery(d);
        }

        public Movie DeleateMovie(int id,string pid, string name, string release)
        {
            var d = new DeleateDelegate(id, pid, name, release);
            return executor.ExecuteNonQuery(d);
        }

        public Movie FetchMovie(int productionId)
        {
            var d = new FetchDelegate(productionId);
            return executor.ExecuteReader(d);
        }

        public Movie GetMovie(string email)
        {
            var d = new GetDelegate(email);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> RetrieveMovie()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }

        public IReadOnlyList<Movie> RetrieveMovieDealeated()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }
        public Movie UpdateMovie(int Movie, string ProductionId, string MovieName, string ReleaseDate)
        {
            var d = new UpdateDelegate( Movie, ProductionId, MovieName,  ReleaseDate);
            return executor.ExecuteNonQuery(d);
        }
    }
}
