using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Production_Delegates
{
    internal class FetchDelegate : DataReaderDelegate<ProductionHouse>
    {
        private readonly int productionId;

        public FetchDelegate(int productionId)
           : base("FetchProductionHouse")
        {
            this.productionId = productionId;
        }

        public override void PrepareCommand(SqlCommand command)///may need to overide
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ProductionId", SqlDbType.Int);
            p.Value = productionId;
        }

        public override ProductionHouse Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            if (!reader.Read())
                throw new RecordNotFoundException(productionId.ToString());

            return new ProductionHouse(productionId,
               reader.GetString("ProductionName"),
               reader.GetString("Location"));
        }
    }

     

    
}

    
    
