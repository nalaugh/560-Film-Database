using CIS_560_Proj.Items;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace CIS_560_Proj.IndividualAwardsWon_Delegate
{
    internal class RetrieveDelegat : DataReaderDelegate<IReadOnlyList<IndividualAwardsWon>>
    {
        public RetrieveDelegat()
         : base("Film.RetrieveIndividualAwardsWon")
        {
        }

        public override IReadOnlyList<IndividualAwardsWon> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Movie = new List<IndividualAwardsWon>();

            while (reader.Read())
            {

                Movie.Add(new IndividualAwardsWon(reader.GetInt32("IndividualAwardsWonId"),
               reader.GetInt32("MoviePersonId")

               ));
            }

            return Movie;
        }
    }
}
