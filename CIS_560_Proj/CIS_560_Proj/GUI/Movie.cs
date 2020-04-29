using CIS_560_Proj.Interface;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS_560_Proj
{
    public partial class Add : UserControl
    {
        private IProductionHouse repo;
        private IMovie movierepo;
        private Isales sales;

        public Add()
        {
            InitializeComponent();
            this.uxInsertButton.Enabled = true;
            this.uxViewMovies.Enabled = true;
            this.uxDeleteMovie.Enabled = true;
            
        }


        private int MovieId;
        private int ProductionId;

        /// <summary>
        /// Uses GetProductionHouse Procedure to retrieve ProductionID 
        /// </summary>
        /// <returns></returns>
        public int GetProudctionId()
        {


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
            "Data Source=mssql.cs.ksu.edu;" +
              "Initial Catalog=phyo;" +
              "User id=phyo;" +
              "Password=zinrocks@4321;";
            connection.Open();

            SqlCommand cmd = new SqlCommand("GetProductionHouseName", connection);
            cmd.Parameters.AddWithValue("ProductionName", uxProductionName.Text);
            cmd.ExecuteNonQuery();

            SqlParameter output = new SqlParameter();
            output.ParameterName = "@P.ProductionId";
            output.SqlDbType = SqlDbType.Int;
            output.Direction = System.Data.ParameterDirection.Output;

            int i = Convert.ToInt32(output.Value.ToString());
            return i;




        }

      
        private void uxViewMovies_Click(object sender, EventArgs e)
        {
            movierepo = new SqlMovieRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=phyo;" +
                    "Password=zinrocks@4321;");
            sales = new SqlSalesRepository("Data Source=mssql.cs.ksu.edu;" +
                    "Initial Catalog=phyo;" +
                    "User id=phyo;" +
                    "Password=zinrocks@4321;");
            dataGridView1.DataSource = movierepo.RetrieveMovie();
            dataGridView3.DataSource = sales.RetrieveSales();
        }

        private void uxDeleteMovie_Click(object sender, EventArgs e)
        {
           
            movierepo = new SqlMovieRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");
            sales = new SqlSalesRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            
            var createdPH = movierepo.DeleteMovie(MovieId, ProductionId, uxTextBoxMovieTitle.Text, date);
            //MessageBox.Show("past");
            var b = sales.DeleteSales(MovieId);

            dataGridView1.DataSource = movierepo.RetrieveMovie();
            dataGridView3.DataSource = sales.RetrieveSales();
        }

        private void uxInsertButton_Click_1(object sender, EventArgs e)
        {
            sales = new SqlSalesRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");
            repo = new SqlProductionRepository("Data Source=mssql.cs.ksu.edu;" +
              "Initial Catalog=phyo;" +
              "User id=phyo;" +
              "Password=zinrocks@4321;");
            var production = repo.GetProductionHouse(this.uxProductionName.Text);

            int pID = Convert.ToInt32(production.ProductionId.ToString());
            movierepo = new SqlMovieRepository("Data Source=mssql.cs.ksu.edu;" +
              "Initial Catalog=phyo;" +
              "User id=phyo;" +
              "Password=zinrocks@4321;");
            var date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            movierepo.CreateMovie(pID, uxTextBoxMovieTitle.Text,date);


            dataGridView1.DataSource = movierepo.RetrieveMovie();
            dataGridView3.DataSource = sales.RetrieveSales();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            MovieId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ProductionId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            uxTextBoxMovieTitle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            uxProductionName.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            uxInsertButton.Text = "Update";
        }
    }
}
