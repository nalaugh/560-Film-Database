using CIS_560_Proj.Items;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Sales_Delegates
{
    class CreateDelegate : NonQueryDataDelegate<Sales>
    {

        public readonly int movieId;
        public readonly int domesticsales;
        public readonly int foreignsales;


        public CreateDelegate(int movieId, int domesticsales, int foreignsales)
           : base("Film.CreateSales")
        {
            this.movieId = movieId;
            this.domesticsales = domesticsales;
            this.foreignsales = foreignsales;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.NVarChar);
            p.Value = movieId;

            p = command.Parameters.Add("Domesticsales", SqlDbType.NVarChar);
            p.Value = domesticsales;
            p = command.Parameters.Add("Foreignsales", SqlDbType.NVarChar);
            p.Value = foreignsales;

            p.Direction = ParameterDirection.Output;
        }

        public override Sales Translate(SqlCommand command)
        {
            return new Sales(Convert.ToInt32(movieId), Convert.ToInt32(domesticsales), Convert.ToInt32(foreignsales));
        }
    }
}
