using CIS_560_Proj.Interface;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS_560_Proj.GUI
{
    public partial class AddProduction : UserControl
    {
        private IProductionHouse repo;



        int ProductionId = 0;
        public AddProduction()
        {
            InitializeComponent();
            uxButtonInsertProduction.Enabled = true;
            uxSearchProduction.Enabled = true;
            uxDeleteProduction.Enabled = false;
            uxViewButton.Enabled = true;

        }

        private void uxButtonInsertProduction_Click(object sender, EventArgs e)
        {
           
                repo = new SqlProductionRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            if (uxButtonInsertProduction.Text == "Insert")
            {
                var name = uxProductionName.Text;
                var location = uxProductionLocation.Text;
                try
                {
                    var createdPH = repo.AddProductionHouse(name, location);
                    MessageBox.Show("Production house succesfully added.");

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Sorry, the production company already exists.");
                }
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = repo.RetrieveProduction2();
                


            }
            else
            {
                var name = uxProductionName.Text;
                var location = uxProductionLocation.Text;

                //Should be modify stored procedure 
                var createdPH = repo.UpdateProduction(name, location, ProductionId);
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = repo.RetrieveProduction2();

            }

        }




      

        private void uxViewMovies_Click(object sender, EventArgs e)
        {
            repo = new SqlProductionRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            string Name = uxSearchTextBox.Text;
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = repo.RetrieveProductionbyName(Name);
            

        }

     


        private void uxDeleteProduction_Click(object sender, EventArgs e)
        {
            repo = new SqlProductionRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            var id = repo.GetProductionHouse(uxProductionName.Text);
            var createdPH = repo.DeleteProduction(uxProductionName.Text, uxProductionLocation.Text, id.ProductionId);
            MessageBox.Show("Production sucessfully deleted.");

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = repo.RetrieveProduction2();
        }

        private void uxViewButton_Click(object sender, EventArgs e)
        {
            repo = new SqlProductionRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = repo.RetrieveProduction2();

            dataGridView1.Refresh();
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            //Check to see if the row clicked is inside the grid
            if (dataGridView1.CurrentRow.Index != -1)
            {
                uxDeleteProduction.Enabled = true;
                ProductionId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                uxProductionName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                uxProductionLocation.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                uxButtonInsertProduction.Text = "Update";
                uxDeleteProduction.Enabled = true;
            }
        }
    }
}
