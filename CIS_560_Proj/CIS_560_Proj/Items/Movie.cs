using System;


namespace CIS_560_Proj.Items
{
    public class Movie
    {
        public int MovieId { get; }
        public int ProductionId { get; }
        public string MovieName { get; }
        public string ReleaseDate { get; }
        public string Deleated { get;  }

        public Movie(int movieId, int productionId, string moviename, string releasedate)
        {
            this.MovieId = movieId;
            this.ProductionId = productionId;
            this.MovieName = moviename;
            this.ReleaseDate = releasedate;
        }
        public Movie(int movieId, int productionId, string moviename, string releasedate, string del)
        {
            this.MovieId = movieId;
            this.ProductionId = productionId;
            this.MovieName = moviename;
            this.ReleaseDate = releasedate;
            this.Deleated = del;
        }

    }
}
