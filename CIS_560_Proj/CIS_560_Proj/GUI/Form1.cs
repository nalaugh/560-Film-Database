using CIS_560_Proj.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS_560_Proj
{

    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=mssql.cs.ksu.edu;Initial Catalog=phyo;User ID=phyo;Password=***********");

        public static List<string> items = new List<string>();
        public Form1()
        {
            InitializeComponent();
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(items.ToArray());
        }



        private void Insert_Click(object sender, EventArgs e)
        {

            connection.Open();
            //2 things for movie table
            //Plus add person name 
            //Plus add person's role 

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

        }
        public void Updatelist(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(items.ToArray());
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Movie_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var addmovies = new Add();
            panel2.Controls.Add(addmovies);
            addmovies.HandleDestroyed += new EventHandler(Updatelist);
        }

        private void Production_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var addproduction = new AddProduction();
            panel2.Controls.Add(addproduction);
            addproduction.HandleDestroyed += new EventHandler(Updatelist);
        }

        private void People_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var addperson = new People();
            panel2.Controls.Add(addperson);
            addperson.HandleDestroyed += new EventHandler(Updatelist);
        }

        private void Awards_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var awards = new Awards();
            panel2.Controls.Add(awards);
            awards.HandleDestroyed += new EventHandler(Updatelist);
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
