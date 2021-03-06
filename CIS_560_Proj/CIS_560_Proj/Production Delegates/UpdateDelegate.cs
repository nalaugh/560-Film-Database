﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;


namespace CIS_560_Proj.Production_Delegates
{
  
    internal class UpdateDelegate : DataReaderDelegate<ProductionHouse>
    {
        public readonly string Name;
        public readonly string location;
        public readonly int pId; 


        public UpdateDelegate(string Name, string location, int pId)
           : base("UpdateProduction")
        {
            this.Name = Name;
            this.location = location;
            this.pId = pId;
        }


        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);


            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = Name;
             p = command.Parameters.Add("Location", SqlDbType.NVarChar);
            p.Value = location;
             p = command.Parameters.Add("ProductionId", SqlDbType.Int);
            p.Value = pId;
        }


        public override ProductionHouse Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            //if (!reader.Read())
            ///    throw new RecordNotFoundException(pId);

            return new ProductionHouse(pId,
               Name,
               location, 
               "Deleted");
        }
    }

    internal class DeleateDelegate : DataReaderDelegate<ProductionHouse>
    {
        public readonly string Name;
        public readonly string location;
        public readonly int pId;


        public DeleateDelegate(string Name, string location, int pId)
           : base("DeleteProduction")
        {
            this.Name = Name;
            this.location = location;
            this.pId = pId;
        }


        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);


           var  p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = Name;
        }




        public override ProductionHouse Translate(SqlCommand command, IDataRowReader reader)
        {

            return new ProductionHouse(pId, Name, location, "Delete");

        }
    }
}
