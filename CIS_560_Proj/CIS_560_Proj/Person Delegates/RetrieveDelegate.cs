using CIS_560_Proj.Items;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace CIS_560_Proj.Person_Delegates
{
    internal class RetrieveDelegate : DataReaderDelegate<IReadOnlyList<Person>>
    {
        public RetrieveDelegate()
          : base("RetrievePersons")
        {
        }

        public override IReadOnlyList<Person> Translate(SqlCommand command, IDataRowReader reader)
        {
            var person = new List<Person>();

            while (reader.Read())
            {
                person.Add(new Person(reader.GetInt32("PersonId"),
                                   reader.GetString("Name"),
                                   reader.GetString("DOB"), 
                                   reader.GetString("DeathDate"),
                                   reader.GetString("IsDeleted")
                                   )
                                        ); 

            }

            return person;
        }



    }
    internal class RetrieveDelegateName : DataReaderDelegate<IReadOnlyList<Person>>
    {

        private readonly string name;

        public RetrieveDelegateName(string names)
           : base("RetrievePersonByName")
        {
            this.name = names;
        }
        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = name;
        }
        public override IReadOnlyList<Person> Translate(SqlCommand command, IDataRowReader reader)
        {
            var person = new List<Person>();

            while (reader.Read())
            {
                person.Add(new Person(reader.GetInt32("PersonId"),
                    reader.GetString("Name"),
                    reader.GetString("DOB"), 
                    reader.GetString("DeathDate"),
                    reader.GetString("IsDeleted")
                    )
                         ); 
            }

            return person;
        }
    }
        internal class RetrieveDelegateDeleated : DataReaderDelegate<IReadOnlyList<Person>>
        {



            public RetrieveDelegateDeleated()
               : base("RetrievePersonsDeleated")
            {

            }
        public override IReadOnlyList<Person> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Person = new List<Person>();

            while (reader.Read())
            {

                Person.Add(new Person(Convert.ToInt32(reader.GetInt32("PersonId")),
               reader.GetString("Name"),
                reader.GetString("DOB"),
                reader.GetString("DeathDate"),
               reader.GetString("IsDeleted")));
            }

            return Person;
        }
    }
    
}
