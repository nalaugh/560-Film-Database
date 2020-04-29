namespace CIS_560_Proj.Items
{
    public class Sales
    {
        public int MovieId { get; }
        public int DomesticSales { get; }
        public int ForeignSales { get; }

        public string Deleted { get; }

        public Sales(int movieId, int domesticsales, int foreignsales, string delete)
        {
            this.MovieId = movieId;
            this.DomesticSales = domesticsales;
            this.ForeignSales = foreignsales;
            this.Deleted = delete;
        }
    }
}
