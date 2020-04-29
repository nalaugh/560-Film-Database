namespace CIS_560_Proj.Items
{
    public class IndividualAwardsWon
    {
        public int IndividualAwardsWonId { get; }
        public int MoviePersonId { get; }
        
        public string Deleted { get; }


        public IndividualAwardsWon(int individualAwardsWon, int moviepersonId,  string delete)
        {
            this.IndividualAwardsWonId = individualAwardsWon;
            this.MoviePersonId = moviepersonId;
            this.Deleted = delete;
        }
    }
}
