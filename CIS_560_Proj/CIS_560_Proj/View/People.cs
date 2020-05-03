using System;
using System.Data;
using System.Windows.Forms;
using CIS_560_Proj.Interface;

namespace CIS_560_Proj.GUI
{
    public partial class People : UserControl
    {
        private IPerson repo;

        private int PersonId;

        public People()
        {
            InitializeComponent();
            uxDeleteButton.Enabled = false;
            
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {

            repo = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");

            string name = uxPersonName.Text;
            string DOB = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd ");

            string death;
            if (uxDeathCheckBox.Checked)
                death = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            else
                death = "NULL";

            if (uxInsertButton.Text == "Insert")
            {

                try
                {
                    var createdPerson = repo.CeatePerson(name, DOB, death);
                    MessageBox.Show("The data has been successfully added.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Data failed to be inserted." + exception);
                }
            }
            else
            {
                
                  var updatePerson = repo.UpdatePerson(PersonId,name, DOB, death);
                    MessageBox.Show("The data has been successfully updated.");
             
            }
              
           
              
            


            //Show all people
            dataGridView1.DataSource = repo.RetrievePersons();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {

            repo = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");

            var name = uxSearchBox.Text;
            //Retrieve person by name 
            dataGridView1.DataSource = repo.RetrievePersonsName(name);
        }

   

        private void uxViewButton_Click(object sender, EventArgs e)
        {

            repo = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");

            dataGridView1.DataSource = repo.RetrievePersons();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                PersonId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                uxPersonName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                uxInsertButton.Text = "Update";
                uxDeleteButton.Enabled = true;
            }
           
        }

        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            repo = new SqlPersonRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            var name = uxPersonName.Text;
            string DOB = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd ");

            string death;
            if (uxDeathCheckBox.Checked)
                death = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            else
                death = "NULL";

            var id = repo.FetchPerson(PersonId);
            var createdPH = repo.DeleatePerson(PersonId, name, DOB, death);

            MessageBox.Show("Person sucessfully deleted.");

            dataGridView1.DataSource = repo.RetrievePersons();

        }
    }
}
