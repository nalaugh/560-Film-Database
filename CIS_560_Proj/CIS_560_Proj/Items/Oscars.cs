using System;
using System.Collections.Generic;
using System.Text;

namespace _560.Models
{
    public class Oscars
    {
        public int OscarsId { get; }
        public int IndividualAwardsWonId { get; }
        public int MovieAwardsWonId { get; }

        public Oscars(int oscarsId, int individualawardswon, int movieawardswon)
        {
            this.OscarsId = oscarsId;
            this.IndividualAwardsWonId = individualawardswon;
            this.MovieAwardsWonId = movieawardswon;
        }


    }
}
