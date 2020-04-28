using CIS_560_Proj.Interface;
using CIS_560_Proj.Items;
using CIS_560_Proj.Production_Delegates;
using System;
using System.Collections.Generic;


namespace CIS_560_Proj
{
    public class SqlProductionRepository : IProductionHouse
    {
        private readonly SqlCommandExecutor executor;

        public SqlProductionRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public ProductionHouse AddProductionHouse(string productionName, string location)
        {
            if (string.IsNullOrWhiteSpace(productionName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(productionName));

            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(location));


            var d = new CreateDelegate(productionName, location);
            return executor.ExecuteNonQuery(d);
        }


        public ProductionHouse FetchProductionHouse(int productionId)
        {
            var d = new FetchDelegate(productionId);
            return executor.ExecuteReader(d);
        }

        public ProductionHouse GetProductionHouse(string email)
        {
            var d = new GetDelegate(email);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<ProductionHouse> RetrieveProduction()
        {
            return executor.ExecuteReader(new RetrieveDelegate());
        }

        public IReadOnlyList<ProductionHouse> RetrieveProductionbyName(string Name)
        {
            return executor.ExecuteReader(new RetrieveDelegateName(Name));
        }

        public IReadOnlyList<ProductionHouse> RetrieveProductionHouseDealeated()
        {
            return executor.ExecuteReader(new RetrieveDelegateDeleated());
        }

        public ProductionHouse UpdateProduction (string productionName, string location, int productionID)
        {
            var d = new UpdateDelegate(productionName, location, productionID);
            return executor.ExecuteReader(d);
        }

        public ProductionHouse DeleateProductionHouse(string Name, string location, int pId)
        {
            return executor.ExecuteReader(new DeleateDelegate(Name, location, pId));
        }

    }
}
