using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.IndividualAwardsWon_Delegate
{
    internal class CreateDelegate : NonQueryDataDelegate<IndividualAwardsWon>
    {
        public readonly int movieId;


        public CreateDelegate(int movieId)
           : base("CreateIndividualAwardsWon")
        {
            this.movieId = movieId;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MoviePersonId", SqlDbType.NVarChar);
            p.Value = movieId;


            p = command.Parameters.Add("IndividualAwardsWon", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override IndividualAwardsWon Translate(SqlCommand command)
        {
            return new IndividualAwardsWon((int)command.Parameters["MovieAwardsWon"].Value, movieId, "NULL");
        }
    }
}
