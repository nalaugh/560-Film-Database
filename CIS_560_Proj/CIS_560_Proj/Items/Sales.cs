using System;
using System.Collections.Generic;
using System.Text;

namespace _560.Models
{
    public class Sales
    {
        public int MovieId { get; }
        public int DomesticSales { get; }
        public int ForeignSales { get; }

        public Sales(int movieId, int domesticsales,int foreignsales)
        {
            this.MovieId = movieId;
            this.DomesticSales = domesticsales;
            this.ForeignSales = foreignsales;
        }
    }
}
