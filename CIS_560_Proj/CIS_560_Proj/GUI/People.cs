using System;
using System.Data;
using System.Windows.Forms;
using CIS_560_Proj.Interface;

namespace CIS_560_Proj.GUI
{
    public partial class People : UserControl
    {
        private IPerson repo;

        public People()
        {
            InitializeComponent();
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {

            repo = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
                 "Initial Catalog=phyo;" +
                 "User id=phyo;" +
                 "Password=zinrocks@4321;");

            var name = uxPersonName.Text;
            var DOB = dateTimePicker1.Value.Date.ToString();
            string death;
            if (uxDeathCheckBox.Checked)
                death = dateTimePicker2.Value.Date.ToString();
            else
                death = "NULL";

            try
            {
                var createdPerson = repo.CeatePerson(name, DOB, death);
                MessageBox.Show("The data has been successfully added.");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error:" + exception);
            }


            //Show all people
            dataGridView1.DataSource = repo.RetrievePersons();
        }

        private void uxViewButton_Click(object sender, EventArgs e)
        {

            repo = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
            "Initial Catalog=phyo;" +
            "User id=phyo;" +
            "Password=zinrocks@4321;");

            var name = uxSearchBox.Text;
            //Retrieve person by name 
            dataGridView1.DataSource = repo.RetrievePersonsName(name);
        }

        private void Deleate_Click(object sender, EventArgs e)
        {
            repo = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");

            var id = repo.GetPerson(uxPersonName.ToString());
            var createdPH = repo.DeleatePerson(id.PersonId, id.Name, id.DOB, id.DeathDate);

            dataGridView1.DataSource = repo.RetrievePersonDealeated();
        }
    }
}
