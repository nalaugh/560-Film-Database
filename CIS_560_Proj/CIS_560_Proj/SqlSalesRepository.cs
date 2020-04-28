using CIS_560_Proj.Interface;
using CIS_560_Proj.Items;
using CIS_560_Proj.Sales_Delegates;
using System;
using System.Collections.Generic;


namespace CIS_560_Proj
{
    public class SqlSalesRepository : Isales
    {
        private readonly SqlCommandExecutor executor;

        public SqlSalesRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public Sales AddSales(int movieId, int domesticsales, int foreignsales)
        {
            if (string.IsNullOrWhiteSpace(movieId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieId));


            var d = new CreateDelegate(movieId, domesticsales, foreignsales);
            return executor.ExecuteNonQuery(d);
        }

        public Sales FetchSales(int productionId)
        {
            var d = new FetchDelegate(productionId);
            return executor.ExecuteReader(d);
        }


        public IReadOnlyList<Sales> RetrieveSales()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }
    }
}
