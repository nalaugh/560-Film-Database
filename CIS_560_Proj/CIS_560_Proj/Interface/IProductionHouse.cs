using CIS_560_Proj.Items;
using System.Collections.Generic;

namespace CIS_560_Proj.Interface
{
    public interface IProductionHouse
    {

        IReadOnlyList<ProductionHouse> RetrieveProduction2();
        IReadOnlyList<ProductionHouse> RetrieveProductionbyName(string name);
        /// <summary>
        /// Creates a new Production House
        /// </summary>
        /// <param name="productionName">First name of the person to create.</param>
        /// <param name="location">Last name of the person to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="ProductionHouse"/>.
        /// </returns>
        ProductionHouse AddProductionHouse(string productionName, string location);

        /// <summary>
        /// Retrievers the productionID using productionName
        /// </summary>
        /// <param name="productionName">Name of production</param>
        /// <returns>ProductionId</returns>
        ProductionHouse GetProductionHouse(string productionName);

        ProductionHouse FetchProductionHouse(int productionId);

        ProductionHouse UpdateProduction(string productionName, string location, int productionID);

        ProductionHouse DeleteProduction(string Name, string location, int pId);


    }
}
