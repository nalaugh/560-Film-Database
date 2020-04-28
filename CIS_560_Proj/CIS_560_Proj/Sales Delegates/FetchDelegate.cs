using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Sales_Delegates
{
    internal class FetchDelegate : DataReaderDelegate<Sales>
    {
        private readonly int movieId;

        public FetchDelegate(int movieId)
           : base("FetchSales")
        {
            this.movieId = movieId;
        }

        public override void PrepareCommand(SqlCommand command)///may need to overide
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = movieId;
        }

        public override Sales Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            if (!reader.Read())
                throw new RecordNotFoundException(movieId.ToString());

            return new Sales(movieId,
               reader.GetInt32("Domesticsales"),
               reader.GetInt32("Foreignsales")
             );
        }
    }
}
