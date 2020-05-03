using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS_560_Proj.Interface;


namespace CIS_560_Proj.View
{
    public partial class Form2 : Form
    {
        private IProductionHouse repo;

        public Form2()
        {
            InitializeComponent();
            uxButtonInsertProduction.Enabled = true;
            uxDelete.Enabled = true;
        }

        private void uxButtonInsertProduction_Click(object sender, EventArgs e)
        {
            repo = new SqlProductionRepository("Data Source=mssql.cs.ksu.edu;" +
                   "Initial Catalog=phyo;" +
                   "User id=phyo;" +
                   "Password=zinrocks@432;");
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
            Close();
        }


        public int GetId ( )
        {
            repo = new SqlProductionRepository("Data Source=mssql.cs.ksu.edu;" +
                      "Initial Catalog=phyo;" +
                      "User id=phyo;" +
                      "Password=zinrocks@432;");
            var name = uxProductionName.Text;
            var production = repo.GetProductionHouse(this.uxProductionName.Text);

            int pID = Convert.ToInt32(production.ProductionId.ToString());
            return pID;

        }

        public string GetProductionName ()
        {
            var name = uxProductionName.Text;
            return name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
