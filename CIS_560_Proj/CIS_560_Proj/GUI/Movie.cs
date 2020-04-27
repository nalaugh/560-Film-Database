using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CIS_560_Proj
{
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
            this.listBoxOptoins.Items.Add("Actor");
            this.listBoxOptoins.Items.Add("Director");
            this.uxButtonInsertMovie.Enabled = true;
        }
        public string conStr = "Server=mssql.cs.ksu.edu;Initial Catalog=phyo;Persist Security Info=True;User ID=phyo;Password=***********";

        private void uxButtonInsertMovie_Click(object sender, EventArgs e)
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
            cmd.CommandText ="Insert into Film.Movie values('" + uxTextBoxMovieTitle + "', '" + dateTimePicker1.Value.Date + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("The movie has been added to the database.");
            display_data();
            connection.Close();

        }

        /// <summary>
        /// Displays the data everytime insert is pressed 
        /// </summary>
        public void display_data()
        {
            SqlConnection connection = new SqlConnection(conStr);

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
    }
}
