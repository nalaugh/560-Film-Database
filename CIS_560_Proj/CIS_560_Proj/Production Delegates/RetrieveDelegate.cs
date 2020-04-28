using CIS_560_Proj.Items;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace CIS_560_Proj.Production_Delegates
{
    internal class RetrieveDelegate : DataReaderDelegate<IReadOnlyList<ProductionHouse>>
    {

        public RetrieveDelegate()
           : base("RetrieveProduction")
        {
        }

        public override IReadOnlyList<ProductionHouse> Translate(SqlCommand command, IDataRowReader reader)
        {
            var production = new List<ProductionHouse>();

            while (reader.Read())
            {
                production.Add(new ProductionHouse(
                   reader.GetInt32("ProductionId"),
                   reader.GetString("ProductionName"),
                   reader.GetString("Location")));
            }

            return production;
        }
    }
    internal class RetrieveDelegateName : DataReaderDelegate<IReadOnlyList<ProductionHouse>>
    {

        private readonly string name;
        public RetrieveDelegateName(string names)
           : base("RetrieveProductionByName")
        {
            this.name = names;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("Name",SqlDbType.NVarChar);
            p.Value = name;
        }
        public override IReadOnlyList<ProductionHouse> Translate(SqlCommand command, IDataRowReader reader)
        {
            var production = new List<ProductionHouse>();

            while (reader.Read())
            {
                production.Add(new ProductionHouse(
                   reader.GetInt32("ProductionId"),
                   reader.GetString("ProductionName"),
                   reader.GetString("Location")
                  
                   )) ;
            }

            return production;
        }


    }
    internal class RetrieveDelegateDeleated : DataReaderDelegate<IReadOnlyList<ProductionHouse>>
    {

        public RetrieveDelegateDeleated()
           : base("RetrieveProductionDeleated")
        {
        }

        public override IReadOnlyList<ProductionHouse> Translate(SqlCommand command, IDataRowReader reader)
        {
            var production = new List<ProductionHouse>();

            while (reader.Read())
            {
                production.Add(new ProductionHouse(
                   reader.GetInt32("ProductionId"),
                   reader.GetString("ProductionName"),
                   reader.GetString("Location"),
                   reader.GetString("IsDeleated")
                   ));
            }

            return production;
        }
    }

}
