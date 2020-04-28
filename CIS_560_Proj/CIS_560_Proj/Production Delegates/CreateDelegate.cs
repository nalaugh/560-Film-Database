using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Production_Delegates
{
    internal class CreateDelegate : NonQueryDataDelegate<ProductionHouse>
    {
        public readonly string Name;
        public readonly string location;


        public CreateDelegate(string Name, string location)
           : base("AddProductionHouse")
        {
            this.Name = Name;
            this.location = location;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ProductionName", SqlDbType.NVarChar);
            p.Value = Name;

            p = command.Parameters.Add("Location", SqlDbType.NVarChar);
            p.Value = location;

            p = command.Parameters.Add("ProductionId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }


        public override ProductionHouse Translate(SqlCommand command)
        {
            return new ProductionHouse((int)command.Parameters["ProductionId"].Value, Name, location);
        }

    }
}
