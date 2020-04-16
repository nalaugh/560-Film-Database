using System;
using System.Collections.Generic;
using System.Text;

namespace _560.Models
{
    public class Person
    {
        public int PersonId { get; }
        public string Name { get; }
        public DateTime DOB { get; }
        public DateTime DeathDate { get; }

        public Person(int personId, string name, DateTime dob, DateTime deathdate)
        {
            this.PersonId = personId;
            this.Name = name;
            this.DOB = dob;
            this.DeathDate = deathdate;
        }
    }
}
