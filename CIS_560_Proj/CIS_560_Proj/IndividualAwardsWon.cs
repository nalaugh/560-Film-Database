using System;
using System.Collections.Generic;
using System.Text;

namespace _560.Models
{
    public class IndividualAwardsWon
    {
        public int IndividualAwardsWonId { get; }
        public int MoviePersonId { get; }


        public IndividualAwardsWon(int individualAwardsWon, int moviepersonId)
        {
            this.IndividualAwardsWonId = individualAwardsWon;
            this.MoviePersonId = moviepersonId;
        }
    }
}
