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

        public Add()
        {
            InitializeComponent();
            this.listBoxOptoins.Items.Add("Actor");
            this.listBoxOptoins.Items.Add("Director");
            this.uxButtonInsertMovie.Enabled = true;
        }

        private void uxButtonInsertMovie_Click(object sender, EventArgs e)
        {
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
            movierepo.CreateMovie(pID.ToString(), uxTextBoxMovieTitle.Text, dateTimePicker1.Value.Date.ToString());


            

        }


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

        /// <summary>
        /// Displays the data everytime insert is pressed 
        /// </summary>
        public void display_data()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
              "Data Source=mssql.cs.ksu.edu;" +
              "Initial Catalog=phyo;" +
              "User id=phyo;" +
              "Password=zinrocks@4321;";

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Film.Movie";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void uxViewMovies_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void uxDeleteMovie_Click(object sender, EventArgs e)
        {
           
            movierepo = new SqlMovieRepository("Data Source=mssql.cs.ksu.edu;" +
                     "Initial Catalog=phyo;" +
                     "User id=phyo;" +
                     "Password=zinrocks@4321;");

            var id = movierepo.GetMovie(uxTextBoxMovieTitle.ToString());
            var createdPH = movierepo.DeleateMovie(id.MovieId, id.ProductionId.ToString(), id.MovieName, id.ReleaseDate);

            dataGridView1.DataSource = movierepo.RetrieveMovieDealeated();
        }
    }
}
