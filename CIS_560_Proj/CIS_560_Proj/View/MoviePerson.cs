using System;
using System.Collections.Generic;
using System.Text;

namespace _560.Models
{
    public class MoviePerson
    {
        public int MoviePersonId { get; }
        public int PersonId { get; }
        public int MovieId { get; }
        public string Role { get; }


        public MoviePerson(int moviepersonId, int personId, int movieId, string role)
        {
            this.MoviePersonId = moviepersonId;
            this.MovieId = movieId;
            this.PersonId = personId;
            this.Role = role;
        }

    }

}
