using CIS_560_Proj.Items;
using System.Collections.Generic;

namespace CIS_560_Proj.Interface
{
    public interface IOscars
    {
        /// <summary>
        /// Retrieves all persons in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Oscars}"/> containing all persons.
        /// </returns>
        IReadOnlyList<Oscars> RetrieveOscars();
        /// <summary>
        /// Fetches the person with the given <paramref name="productionhouseId"/> if it exists.
        /// </summary>
        /// <param name="productionhouseId">Identifier of the person to fetch.</param>
        /// <returns>
        /// An instance of <see cref="ProductionHouse"/> containing the information of the requested person.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="productionhouseId"/> does not exist.
        /// </exception>
        Oscars FetchOscars(int OscarsId);
        /// <summary>
        /// Gets the person with the given <paramref name="productionhouseId"/> if it exists.
        /// </summary>
        /// <param name="name">Email of the person to get.</param>
        /// <returns>
        /// An instance of <see cref="Person"/> containing the information of the requested person
        /// if one exists with with the provided <paramref name="email"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Oscars GetOscars(int name);
        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="firstName">First name of the person to create.</param>
        /// <param name="lastName">Last name of the person to create.</param>
        /// <param name="email">Email of the person to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Person"/>.
        /// </returns>
        Oscars CreateOscars(int IndividualAwardsWonId, int MovieAwardsWonId, int Year);

        Oscars DeleateOscars(int name);
        IReadOnlyList<Oscars> RetrieveOscarsDealeated();

    }
}
