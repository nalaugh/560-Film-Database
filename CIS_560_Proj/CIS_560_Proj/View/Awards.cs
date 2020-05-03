using System;
using System.Windows.Forms;
using CIS_560_Proj.Interface;
using CIS_560_Proj;
using System.Collections.Generic;
using CIS_560_Proj.Items;

namespace CIS_560_Proj
{
    public partial class Awards : UserControl
    {
        private IIndividualAwardsWon Inrepo;
        private IMovieAwardsWon movieAwardsWon;
        private IOscars oscarsrepo;
        private IMoviePerson personrepo;
        private IPerson person;
        private IMovie movieCategory;
        public Awards()
        {
            InitializeComponent();
            this.listBox1.Items.Add("Indiviual Awards");
            this.listBox1.Items.Add("Movie Awards");
          //  this.uxButtonInsertMovie.Enabled = true;
            this.uxSearchProduction.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.Equals("Indiviual Awards"))
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("Leading Actor");
                this.listBox2.Items.Add("Supporting Actor");
                this.listBox2.Items.Add("Leading Actress");
                this.listBox2.Items.Add("Supporting Actress");
                this.listBox2.Items.Add("Director");
            }
            if (listBox1.SelectedItem.Equals("Movie Awards"))
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("Best Picture");
                this.listBox2.Items.Add("Adapted Screenplay");
                this.listBox2.Items.Add("Original Screenplay");
            }
            this.uxSearchProduction.Enabled = true;
        }

        private void uxButtonAddMovie_Click(object sender, EventArgs e)
        {
             Inrepo = new SqlIndividualAwardsWonRepository("Data Source=mssql.cs.ksu.edu;" +
               "Initial Catalog=phyo;" +
             "User id=UserId;" +
            "Password=Password;");

            person = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
               "Initial Catalog=phyo;" +
             "User id=UserId;" +
            "Password=Password;");
            //person.GetPerson()

            personrepo = new SqlMoviePersonsRepository("Data Source=mssql.cs.ksu.edu;" +
               "Initial Catalog=phyo;" +
             "User id=UserId;" +
            "Password=Password;");

            personrepo.RetrieveMoviePerson();




            if (this.listBox1.SelectedItem != null && !Form1.items.Contains(this.listBox1.SelectedItem.ToString()))
            {
                Form1.items.Add(this.listBox1.SelectedItem.ToString());
            }
            if (this.listBox2.SelectedItem != null && !Form1.items.Contains(this.listBox2.SelectedItem.ToString()))
            {
                Form1.items.Add(this.listBox2.SelectedItem.ToString());
            }
            this.Dispose();
        }

  


        private void uxSearchProduction_Click(object sender, EventArgs e)
        {

            personrepo = new SqlMoviePersonsRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=UserId;" +
                     "Password=Password;");
            person = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=UserId;" +
                     "Password=Password;");

            movieAwardsWon = new SqlMovieAwardsWonRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=UserId;" +
                     "Password=Password;");
            movieCategory = new SqlMovieRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=UserId;" +
                     "Password=Password;");
            Inrepo = new SqlIndividualAwardsWonRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=UserId;" +
                     "Password=Password;");

            List<Movie> won = new List<Movie>();
            if (this.listBox2.SelectedItem.Equals("Best Picture"))
            {
                foreach(MovieAwardsWon i in movieAwardsWon.RetrieveMovieAwardsWon())
                {
                    if (i.Category.Equals("Best Picture"))
                    {
                        Movie a = movieCategory.FetchMovie(i.MovieId);
                        won.Add(a);
                    }
                }
                dataGridView1.DataSource = won;
            }


            List<Person> won1 = new List<Person>();
            if (this.listBox2.SelectedItem.Equals("Director"))
            {
               
                foreach(IndividualAwardsWon i in Inrepo.RetrieveIndividualAwardsWon())
                {
                    MoviePerson a = personrepo.FetchMoviePerson(i.MoviePersonId);
                    if (a.Role.Equals("Director"))
                    {
                        Person b = person.FetchPerson(a.PersonId);
                        won1.Add(b);
                    }
                }
                dataGridView1.DataSource = won1;
                

            }
            if (this.listBox2.SelectedItem.Equals("Adapted Screenplay"))
            { 
                foreach(MovieAwardsWon i in movieAwardsWon.RetrieveMovieAwardsWon())
                {
                    if(i.Category.Equals("Adapted Screenplay"))
                    {
                        Movie a = movieCategory.FetchMovie(i.MovieId);
                            won.Add(a);
                    }

                }
                dataGridView1.DataSource = won;


            }



              
        }
    }
}
