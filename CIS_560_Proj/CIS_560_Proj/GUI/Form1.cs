using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Proj
{
    
    public partial class Form1 : Form
    {

        public static List<string> items = new List<string>();
        public Form1()
        {
            InitializeComponent();
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(items.ToArray());
        }

      

        private void Insert_Click(object sender, EventArgs e)
        {   
           
     
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
            var addperson = new Person();
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
