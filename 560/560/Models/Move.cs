using System;
using System.Collections.Generic;
using System.Text;

namespace _560.Models
{
    public class Movie
    {
        public int MovieId { get; }
        public int ProductionId { get; }
        public string MovieName { get; }
        public DateTime ReleaseDate { get; }

        public Movie(int movieId, int productionId, string moviename, DateTime releasedate)
        {
            this.MovieId = movieId;
            this.ProductionId = productionId;
            this.MovieName = moviename;
            this.ReleaseDate = releasedate;
        }

    }
}
