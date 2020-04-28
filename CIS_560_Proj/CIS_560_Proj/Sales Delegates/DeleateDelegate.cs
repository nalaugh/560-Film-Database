using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Sales_Delegates
{
    internal class DeleateDelegate : NonQueryDataDelegate<Sales>
    {

        public readonly int movieId;



        public DeleateDelegate(int movieID)
           : base("DeleateSales")
        {
      
            this.movieId = movieID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);



           var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = movieId;
        }

        public override Sales Translate(SqlCommand command)
        {
            return null;
        }
    }
}
