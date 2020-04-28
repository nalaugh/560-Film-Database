using CIS_560_Proj.Items;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Person_Delegates
{
    internal class UpdateDelegate : NonQueryDataDelegate<Person>
    {
        public readonly string Name;
        public readonly string DOB;
        public readonly string Death;
        public readonly int personId;


        public UpdateDelegate(int PersonId,string Name, string DOB, string Death)
           : base("UpdatePerson")
        {
            this.Name = Name;
            this.DOB = DOB;
            this.Death = Death;
            this.personId = PersonId;
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
            p.Value = personId;
        }

        public override Person Translate(SqlCommand command)
        {
            return new Person(personId, Name, DOB, Death);
        }

    }
    internal class DeleateDelegate : NonQueryDataDelegate<Person>
    {
        public readonly string Name;
        public readonly string DOB;
        public readonly string Death;
        public readonly int personId;


        public DeleateDelegate(int PersonId, string Name, string DOB, string Death)
           : base("DeleatePerson")
        {
            this.Name = Name;
            this.DOB = DOB;
            this.Death = Death;
            this.personId = PersonId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("PersonId", SqlDbType.Int);
            p.Value = personId;
        }

        public override Person Translate(SqlCommand command)
        {
            return new Person(personId, Name, DOB, Death, "Deleated");
        }

    }
}
