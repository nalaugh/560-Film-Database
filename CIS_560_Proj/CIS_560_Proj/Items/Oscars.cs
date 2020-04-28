namespace CIS_560_Proj.Items
{
    public class Oscars
    {
        public int OscarsId { get; }
        public int IndividualAwardsWonId { get; }
        public int MovieAwardsWonId { get; }
        public int Year { get; }
        public string Deleated { get; }

        public Oscars(int oscarsId, int individualawardswon, int movieawardswon, int year)
        {
            this.OscarsId = oscarsId;
            this.IndividualAwardsWonId = individualawardswon;
            this.MovieAwardsWonId = movieawardswon;
            this.Year = year;
        }
        public Oscars(int oscarsId, int individualawardswon, int movieawardswon, int year, string Del)
        {
            this.OscarsId = oscarsId;
            this.IndividualAwardsWonId = individualawardswon;
            this.MovieAwardsWonId = movieawardswon;
            this.Year = year;
            this.Deleated = Del;
        }


    }
}
