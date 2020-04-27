using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CIS_560_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Insert_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var addmovies = new AddMovie();
                panel2.Controls.Add(addmovies);
            }
            if(radioButton2.Checked == true)
            {
                var addproduction = new AddProduction();
                panel2.Controls.Add(addproduction);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}
