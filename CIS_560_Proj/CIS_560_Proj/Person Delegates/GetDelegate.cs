using CIS_560_Proj.Items;
using System;
using System.Data.SqlClient;

namespace CIS_560_Proj.Person_Delegates
{
    class GetDelegate : DataReaderDelegate<Person>
    {
        private readonly string Name;

        public GetDelegate(string name)
           : base("GetPersonName")
        {
            this.Name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", Name);
        }

        public override Person Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(Name);

            return new Person(reader.GetInt32("PersonId"),
               Name,
               reader.GetString("DOB"),
               reader.GetString("DeathDate"));
        }
    }
}
