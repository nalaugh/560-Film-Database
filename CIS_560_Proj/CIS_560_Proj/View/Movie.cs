using CIS_560_Proj.Interface;
using CIS_560_Proj.View;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CIS_560_Proj
{
    public partial class Add : UserControl
    {
        private IProductionHouse repo;
        private IMovie movierepo;
        private Isales sales;
      //  private Form2 _f2;

        public Add()
        {
            InitializeComponent();
            this.uxInsertButton.Enabled = true;
            this.uxViewMovies.Enabled = true;
            this.uxDeleteMovie.Enabled = false;

        }


        private int MovieId;
        private int ProductionId;

      
        

      
        private void uxViewMovies_Click(object sender, EventArgs e)
        {
            movierepo = new SqlMovieRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            sales = new SqlSalesRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            dataGridView1.DataSource = movierepo.RetrieveMovie();
            dataGridView3.DataSource = sales.RetrieveSales();
        }

        private void uxDeleteMovie_Click(object sender, EventArgs e)
        {
           
            movierepo = new SqlMovieRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            sales = new SqlSalesRepository("Data Source = mssql.cs.ksu.edu; " +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            
            var createdPH = movierepo.DeleteMovie(MovieId, ProductionId, uxTextBoxMovieTitle.Text, date);
            //MessageBox.Show("past");
            var b = sales.DeleteSales(MovieId);

            MessageBox.Show("Movie sucessfully deleted.");

            dataGridView1.DataSource = movierepo.RetrieveMovie();
            dataGridView3.DataSource = sales.RetrieveSales();
        }

        private void uxInsertButton_Click_1(object sender, EventArgs e)
        {
            sales = new SqlSalesRepository("Data Source = mssql.cs.ksu.edu; " +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");
            repo = new SqlProductionRepository("Data Source = mssql.cs.ksu.edu; " +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");

         
            movierepo = new SqlMovieRepository("Data Source = mssql.cs.ksu.edu; " +
                    "Initial Catalog=phyo;" +
                    "User id=username;" +
                    "Password=password;");

            try
            {
                var production = repo.GetProductionHouse(this.uxProductionName.Text);

                int pID = Convert.ToInt32(production.ProductionId.ToString());
                var date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

                movierepo.CreateMovie(pID, uxTextBoxMovieTitle.Text, date);
            }
            catch (Exception exception)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                int pID= f2.GetId();
                var date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                uxProductionName.Text = f2.GetProductionName();

                movierepo.CreateMovie(pID, uxTextBoxMovieTitle.Text, date);


            }




            dataGridView1.DataSource = movierepo.RetrieveMovie();
            dataGridView3.DataSource = sales.RetrieveSales();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                uxDeleteMovie.Enabled = true;
             
                uxTextBoxMovieTitle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                uxProductionName.Text= "";
                uxInsertButton.Text = "Update";
            }
        }
    }
}
