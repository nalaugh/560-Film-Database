﻿using System;
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
            this.uxButtonInsertMovie.Enabled = true;
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
             "User id=phyo;" +
            "Password=zinrocks@4321;");

            person = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
               "Initial Catalog=phyo;" +
             "User id=phyo;" +
            "Password=zinrocks@4321;");
            //person.GetPerson()

            personrepo = new SqlMoviePersonsRepository("Data Source=mssql.cs.ksu.edu;" +
               "Initial Catalog=phyo;" +
             "User id=phyo;" +
            "Password=zinrocks@4321;");

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

        private void Deleate_Click(object sender, EventArgs e)
        {
            oscarsrepo = new SqlOscarsRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");
            var id = oscarsrepo.GetOscars(Convert.ToInt32(uxNumericUpDownYear.Value));
            var createdPH = oscarsrepo.DeleateOscars(id.OscarsId, id.IndividualAwardsWonId, id.MovieAwardsWonId, id.Year);
            dataGridView1.DataSource = oscarsrepo.RetrieveOscars();
        }


        private void uxSearchProduction_Click(object sender, EventArgs e)
        {

            personrepo = new SqlMoviePersonsRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");
            person = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");

            movieAwardsWon = new SqlMovieAwardsWonRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");
            movieCategory = new SqlMovieRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");

            List<Movie> won = new List<Movie>();
            if (this.listBox2.SelectedItem.Equals("Best Picture"))
            {
                foreach(MovieAwardsWon i in movieAwardsWon.RetrieveMovieAwardsWon())
                {
                    if (i.Category.Equals("Adapted Screenplay"))
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
               
                foreach(MoviePerson i in personrepo.RetrieveMoviePerson())
                {
                    if (i.Role.Equals("Director"))
                    {
                        Person a = person.FetchPerson(i.PersonId);
                        won1.Add(a);
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
