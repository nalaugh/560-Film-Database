using CIS_560_Proj.Items;
using System.Collections.Generic;


namespace CIS_560_Proj.Interface
{
    public interface IMoviePerson
    {
        /// <summary>
        /// Retrieves all persons in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{MoviePerson}"/> containing all persons.
        /// </returns>
        IReadOnlyList<MoviePerson> RetrieveMoviePerson();
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
        MoviePerson FetchMoviePerson(int MoviePersonId);
        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="firstName">First name of the person to create.</param>
        /// <param name="lastName">Last name of the person to create.</param>
        /// <param name="email">Email of the person to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Person"/>.
        /// </returns>
        MoviePerson CreateMoviePerson(int PersonId, int MovieId, string Role);


    }
}
