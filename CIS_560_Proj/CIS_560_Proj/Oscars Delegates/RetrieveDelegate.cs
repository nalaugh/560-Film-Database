using CIS_560_Proj.Items;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CIS_560_Proj.Oscars_Delegates
{
    internal class RetrieveDelegate : DataReaderDelegate<IReadOnlyList<Oscars>>
    {
        public RetrieveDelegate()
          : base("Film.RetrieveOscars")
        {
        }

        public override IReadOnlyList<Oscars> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Movie = new List<Oscars>();

            while (reader.Read())
            {

                Movie.Add(new Oscars(reader.GetInt32("OscarsId"),
               reader.GetInt32("InidiualAwardsWonId"),
                reader.GetInt32("MovieAwardsWonId"),
                reader.GetInt32("Year")
               ));
            }

            return Movie;
        }
    }
}
