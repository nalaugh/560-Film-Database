using CIS_560_Proj.Items;
using System;
using System.Data.SqlClient;

namespace CIS_560_Proj.IndividualAwardsWon_Delegate
{
    class GetDelegate : DataReaderDelegate<IndividualAwardsWon>
    {
        private readonly int Name;

        public GetDelegate(int name)
           : base("GetIndividualAwardsWonPerson")
        {
            this.Name = name;
        }

        public override void PrepareCommand(SqlCommand command)//overide
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MoviePerson", Name);
        }

        public override IndividualAwardsWon Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new IndividualAwardsWon(reader.GetInt32("IndividualAwardsWonId"),
               reader.GetInt32("MoviePersonId")
                );
        }
    }
}
