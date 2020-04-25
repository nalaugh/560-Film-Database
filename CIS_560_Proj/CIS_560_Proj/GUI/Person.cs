using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Proj
{
    public partial class Person : UserControl
    {
        public Person()
        {
            InitializeComponent();
            this.uxButtonAddMovie.Enabled = true;
        }

        private void uxButtonAddMovie_Click(object sender, EventArgs e)
        {
            if (this.uxTextBoxMovieTitle.Text.Length > 0)
            {
                Form1.items.Add(this.uxTextBoxMovieTitle.Text);
            }
            if (this.checkBox1.Checked)
            {
                Form1.items.Add(this.dateTimePicker2.Value.ToString("yyyy-mm-dd"));
            }
            if (this.checkBox2.Checked)
            {
                Form1.items.Add(this.dateTimePicker2.Value.ToString("yyyy-mm-dd"));
            }
            this.Dispose();
        }


    }
}
