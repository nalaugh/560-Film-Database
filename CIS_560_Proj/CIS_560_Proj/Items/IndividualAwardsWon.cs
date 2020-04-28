namespace CIS_560_Proj.Items
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
