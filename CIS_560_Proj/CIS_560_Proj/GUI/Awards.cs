using System;
using System.Windows.Forms;
using CIS_560_Proj.Interface;
using CIS_560_Proj;
using System.Collections.Generic;

namespace CIS_560_Proj
{
    public partial class Awards : UserControl
    {
        private IIndividualAwardsWon Inrepo;
        private IMovieAwardsWon movie;
        private IOscars oscarsrepo;
        private IMoviePerson personrepo;
        private IPerson person;
        public Awards()
        {
            InitializeComponent();
            this.listBox1.Items.Add("Indiviual Awards");
            this.listBox1.Items.Add("Movie Awards");
            this.uxButtonInsertMovie.Enabled = true;
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
                this.listBox2.Items.Add("Best Pricture");
                this.listBox2.Items.Add("Adapted Screenplay");
                this.listBox2.Items.Add("Original Screenplay");
            }
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
            dataGridView1.DataSource = oscarsrepo.RetrieveOscarsDealeated();
        }


        private void uxSearchProduction_Click(object sender, EventArgs e)
        {
            oscarsrepo = new SqlOscarsRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");
            Inrepo = new SqlIndividualAwardsWonRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");
            movie = new SqlMovieAwardsWonRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");

            var id = oscarsrepo.GetOscars(Convert.ToInt32(uxNumericUpDownYear.Value));
            List<object> list = new List<object>();
            foreach(object i in Inrepo.RetrieveIndividualAwardsWon())
            {
                list.Add(i);
            }
            foreach (object i in movie.RetrieveMovieAwardsWon())
            {
                list.Add(i);
            }

            dataGridView1.DataSource = list;
        }
    }
}
