using CIS_560_Proj.Interface;
using CIS_560_Proj.Items;
using CIS_560_Proj.Person_Delegates;
using System;
using System.Collections.Generic;


namespace CIS_560_Proj
{
    public class SqlPersonRepository : IPerson
    {
        private readonly SqlCommandExecutor executor;

        public SqlPersonRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Person CeatePerson(string Name, string DOB, string DeathDate)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Name));

            if (string.IsNullOrWhiteSpace(DOB))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(DOB));


            var d = new CreateDelegate(Name, DOB, DeathDate);
            return executor.ExecuteNonQuery(d);
        }

        public Person DeleatePerson(int id,string Name, string DOB, string DeathDate)
        {
            var d = new DeleateDelegate(id,Name, DOB, DeathDate);
            return executor.ExecuteNonQuery(d);
        }

        public Person FetchPerson(int personId)
        {
            var d = new FetchDelegate(personId);
            return executor.ExecuteReader(d);
        }

        public Person GetPerson(string name)
        {
            var d = new GetDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Person> RetrievePersonDealeated()
        {
            return executor.ExecuteReader(new RetrieveDelegateDeleated());
        }

        public IReadOnlyList<Person> RetrievePersons()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }
        public IReadOnlyList<Person> RetrievePersonsName(string name)
        {
            return executor.ExecuteReader(new RetrieveDelegateName(name));
        }
        public Person UpdateProduction(int productionName, string location, string productionID, string death)
        {
            var d = new UpdateDelegate(productionName, location, productionID, death);
            return executor.ExecuteNonQuery(d);
        }

    }
}
