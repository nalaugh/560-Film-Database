using CIS_560_Proj.Interface;
using CIS_560_Proj.Items;
using CIS_560_Proj.Oscars_Delegates;
using System;
using System.Collections.Generic;
namespace CIS_560_Proj
{
    public class SqlOscarsRepository : IOscars
    {
        private readonly SqlCommandExecutor executor;

        public SqlOscarsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Oscars CreateOscars(int IndividualAwardsWonId, int MovieAwardsWonId, int Year)
        {
            if (string.IsNullOrWhiteSpace(IndividualAwardsWonId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(IndividualAwardsWonId));

            if (string.IsNullOrWhiteSpace(MovieAwardsWonId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(MovieAwardsWonId));
            if (string.IsNullOrWhiteSpace(Year.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Year));


            var d = new CreateDelegate( IndividualAwardsWonId,  MovieAwardsWonId, Year);
            return executor.ExecuteNonQuery(d);
        }

        public Oscars DeleateOscars(int id, int IId, int mid, int year)
        {
            var d = new DeleateDelegate(id, IId,mid, year);
            return executor.ExecuteNonQuery(d);
        }

        public Oscars FetchOscars(int OscarId)
        {
            var d = new FetchDelegate(OscarId);
            return executor.ExecuteReader(d);
        }

        public Oscars GetOscars(int Year)
        {
            var d = new GetDelegate(Year);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Oscars> RetrieveOscars()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }

        public IReadOnlyList<Oscars> RetrieveOscarsDealeated()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }
        public Oscars UpdateDelegate(int OID, int IndividualAwardsWonId, int MovieAwardsWonId, int Year)
        {
            var d = new UpdateDelegate(OID, IndividualAwardsWonId, MovieAwardsWonId, Year);
            return executor.ExecuteNonQuery(d);
        }
    }
}
