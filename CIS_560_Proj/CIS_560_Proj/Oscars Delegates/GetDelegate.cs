using CIS_560_Proj.Items;
using System;
using System.Data.SqlClient;

namespace CIS_560_Proj.Oscars_Delegates
{
    internal class GetDelegate : DataReaderDelegate<Oscars>
    {
        private readonly int Name;

        public GetDelegate(int name)
           : base("GetOscarsYear")
        {
            this.Name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Year", Name);
        }

        public override Oscars Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Oscars(reader.GetInt32("OscarsId"),
               reader.GetInt32("InidiualAwardsWonId"),
                reader.GetInt32("MovieAwardsWonId"),
                Name
                );
        }
    }
}
