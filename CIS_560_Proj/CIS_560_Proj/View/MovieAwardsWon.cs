using System;
using System.Collections.Generic;
using System.Text;

namespace _560.Models
{
    public class MovieAwardsWon
    {
        public int MovieAwardsWonId { get; }
        public int MovieId { get; }
        public string Category { get; }

        public MovieAwardsWon(int movieawardswonId, int movieId, string category)
        {
            this.MovieAwardsWonId = movieawardswonId;
            this.MovieId = movieId;
            this.Category = category;
        }

    }
}
