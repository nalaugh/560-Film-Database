using CIS_560_Proj.Items;
using System.Collections.Generic;

namespace CIS_560_Proj.Interface
{
    public interface Isales
    {
        Sales FetchSales(int MovieId);
        Sales AddSales(int movieId, int domesticsales, int foreignsales);
        IReadOnlyList<Sales> RetrieveSales();
        Sales DeleteSales(int MovieID);
    }
}
