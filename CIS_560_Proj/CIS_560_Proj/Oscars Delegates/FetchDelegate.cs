using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Oscars_Delegates
{
    internal class FetchDelegate : DataReaderDelegate<Oscars>
    {
        private readonly int OscarsId;

        public FetchDelegate(int MovieAwardsWonId)
           : base("FetchOscars")
        {
            this.OscarsId = MovieAwardsWonId;
        }

        public override void PrepareCommand(SqlCommand command)///may need to overide
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = OscarsId;
        }

        public override Oscars Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            if (!reader.Read())
                throw new RecordNotFoundException(OscarsId.ToString());

            return new Oscars(OscarsId,
               reader.GetInt32("IndiviualAwardsWonId"),
               reader.GetInt32("MovieAwardsWon"),
               reader.GetInt32("Year")
             );
        }
    }
}
