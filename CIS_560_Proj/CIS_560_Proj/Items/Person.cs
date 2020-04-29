using System.Windows.Forms;

namespace CIS_560_Proj.Items
{
    public class Person
    {
        public int PersonId { get; }
        public string Name { get; }
        public string DOB { get; }
        public string DeathDate { get; }
        public string Deleted { get; }

        
        public Person(int personId, string name, string dob, string deathdate, string Deleated)
        {
            this.PersonId = personId;
            this.Name = name;
            this.DOB = dob;
            this.DeathDate = deathdate;
            this.Deleted = Deleated;
        }
    }
}
