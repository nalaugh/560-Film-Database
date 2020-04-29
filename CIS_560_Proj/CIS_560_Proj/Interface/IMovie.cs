using CIS_560_Proj.Items;
using System.Collections.Generic;

namespace CIS_560_Proj.Interface
{
    public interface IMovie
    {
        /// <summary>
        /// Retrieves all persons in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Movie}"/> containing all persons.
        /// </returns>
        IReadOnlyList<Movie> RetrieveMovie();
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
        Movie FetchMovie(int MovieId);
        /// <summary>
        /// Gets the person with the given <paramref name="productionhouseId"/> if it exists.
        /// </summary>
        /// <param name="name">Email of the person to get.</param>
        /// <returns>
        /// An instance of <see cref="Person"/> containing the information of the requested person
        /// if one exists with with the provided <paramref name="email"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Movie GetMovie(string name);
        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="firstName">First name of the person to create.</param>
        /// <param name="lastName">Last name of the person to create.</param>
        /// <param name="email">Email of the person to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Person"/>.
        /// </returns>
        Movie CreateMovie(int ProductionId, string MovieName, string ReleaseDate);

        Movie UpdateMovie(int Movie, string ProductionId, string MovieName, string ReleaseDate);
        Movie DeleteMovie(int id, int pid, string name, string release);
        IReadOnlyList<Movie> RetrieveMovieDealeated();

    }
}
