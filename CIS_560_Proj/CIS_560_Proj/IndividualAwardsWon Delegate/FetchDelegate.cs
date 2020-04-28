using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;


namespace CIS_560_Proj.IndividualAwardsWon_Delegate
{
    internal class FetchDelegate : DataReaderDelegate<IndividualAwardsWon>
    {
        private readonly int MovieAwardsWonId;

        public FetchDelegate(int MovieAwardsWonId)
           : base("FetchIndividualAwardsWon")
        {
            this.MovieAwardsWonId = MovieAwardsWonId;
        }

        public override void PrepareCommand(SqlCommand command)///may need to overide
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = MovieAwardsWonId;
        }

        public override IndividualAwardsWon Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            if (!reader.Read())
                throw new RecordNotFoundException(MovieAwardsWonId.ToString());

            return new IndividualAwardsWon(MovieAwardsWonId,
               reader.GetInt32("MoviePersonId")
              
             );
        }
    }
}
