using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Person_Delegates
{
    internal class CreateDelegate : NonQueryDataDelegate<Person>
    {
        public readonly string Name;
        public readonly string DOB;
        public readonly string Death;


        public CreateDelegate(string Name, string DOB, string Death)
           : base("AddPerson")
        {
            this.Name = Name;
            this.DOB = DOB;
            this.Death = Death;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = Name;

            p = command.Parameters.Add("DOB", SqlDbType.NVarChar);
            p.Value = DOB;
            p = command.Parameters.Add("DeathDate", SqlDbType.NVarChar);
            p.Value = Death;

            p = command.Parameters.Add("PersonId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Person Translate(SqlCommand command)
        {
            return new Person((int)command.Parameters["PersonId"].Value, Name, DOB, Death);
        }

    }
}
