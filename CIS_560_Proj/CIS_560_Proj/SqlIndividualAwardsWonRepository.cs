using CIS_560_Proj.Interface;
using CIS_560_Proj.Items;
using CIS_560_Proj.IndividualAwardsWon_Delegate;
using System;
using System.Collections.Generic;
namespace CIS_560_Proj
{
    public class SqlIndividualAwardsWonRepository : IIndividualAwardsWon
    {
        private readonly SqlCommandExecutor executor;

        public SqlIndividualAwardsWonRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public IndividualAwardsWon CreateIndividualAwardsWon(int movieId)
        {


            if (string.IsNullOrWhiteSpace(movieId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(movieId));


            var d = new CreateDelegate(movieId);
            return executor.ExecuteNonQuery(d);
        }

        public IndividualAwardsWon FetchIndividualAwardsWon(int productionId)
        {
            var d = new FetchDelegate(productionId);
            return executor.ExecuteReader(d);
        }

        public IndividualAwardsWon GetIndividualAwardsWon(int email)
        {
            var d = new GetDelegate(email);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<IndividualAwardsWon> RetrieveIndividualAwardsWon()
        {
            return executor.ExecuteReader(new RetrieveDelegat());
        }
    }
}
