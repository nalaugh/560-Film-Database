using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Oscars_Delegates
{
    internal class CreateDelegate : NonQueryDataDelegate<Oscars>
    {
        public readonly int individualawardswonId;
        public readonly int movieawardswonId;
        public readonly int year;



        public CreateDelegate(int IndividualAwardsWonId, int MovieAwardsWonId, int Year)
           : base("CreateOscars")
        {
            this.individualawardswonId = IndividualAwardsWonId;
            this.movieawardswonId = MovieAwardsWonId;
            this.year = Year;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("IndividualAwardsWonId", SqlDbType.NVarChar);
            p.Value = individualawardswonId;

            p = command.Parameters.Add("MovieAwardsWonId", SqlDbType.NVarChar);
            p.Value = movieawardswonId;
            p = command.Parameters.Add("Year", SqlDbType.NVarChar);
            p.Value = year;


            p = command.Parameters.Add("OscarId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Oscars Translate(SqlCommand command)
        {
            return new Oscars((int)command.Parameters["OscarId"].Value, individualawardswonId, movieawardswonId,year);
        }
    }
}
