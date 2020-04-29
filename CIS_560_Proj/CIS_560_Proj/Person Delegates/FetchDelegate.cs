using CIS_560_Proj.Items;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Person_Delegates
{
    internal class FetchDelegate : DataReaderDelegate<Person>
    {
        private readonly int personId;

        public FetchDelegate(int personId)
           : base("FetchPerson")
        {
            this.personId = personId;
        }

        public override void PrepareCommand(SqlCommand command)///may need to overide
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("PersonId", SqlDbType.Int);
            p.Value = personId;
        }

        public override Person Translate(SqlCommand command, IDataRowReader reader)///may need to overide
        {
            if (!reader.Read())
                throw new RecordNotFoundException(personId.ToString());

            return new Person(personId,
               reader.GetString("Name"),
               reader.GetString("DOB"),
               "NULL", "NULL");
        }

    }
}
