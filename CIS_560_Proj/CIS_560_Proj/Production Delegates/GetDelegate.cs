using CIS_560_Proj.Items;
using System.Data.SqlClient;

namespace CIS_560_Proj.Production_Delegates
{
    internal class GetDelegate : DataReaderDelegate<ProductionHouse>
    {
        private readonly string Name;
         
        public GetDelegate(string name)
           : base("GetProductionHouseName")
        {
            this.Name = name;
        }

        public override void PrepareCommand(SqlCommand command)//overide
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ProductionName", Name);
        }

        public override ProductionHouse Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(Name);

            return new ProductionHouse(
               reader.GetInt32("ProductionId"),
               Name,
               reader.GetString("Location"),
               "NULL"
              );
        }
    }
}
