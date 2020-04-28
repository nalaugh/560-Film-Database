using CIS_560_Proj.Items;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CIS_560_Proj.Sales_Delegates
{
    internal class RetrieveDelegate : DataReaderDelegate<IReadOnlyList<Sales>>
    {
        public RetrieveDelegate()
          : base("Film.RetrieveSales")
        {
        }

        public override IReadOnlyList<Sales> Translate(SqlCommand command, IDataRowReader reader)
        {
            var person = new List<Sales>();

            while (reader.Read())
            {

                person.Add(new Sales(reader.GetInt32("MovieId"),
               reader.GetInt32("Domesticsales"),
               reader.GetInt32("Foreignsales")));
            }

            return person;
        }
    }
}
