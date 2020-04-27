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
    public partial class Awards : UserControl
    {
        public Awards()
        {
            InitializeComponent();
            this.listBox1.Items.Add("Indiviual Awards");
            this.listBox1.Items.Add("Movie Awards");
            this.uxButtonAddMovie.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.Equals("Indiviual Awards"))
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("Leading Actor");
                this.listBox2.Items.Add("Supporting Actor");
                this.listBox2.Items.Add("Leading Actress");
                this.listBox2.Items.Add("Supporting Actress");
                this.listBox2.Items.Add("Director");
            }
            if (listBox1.SelectedItem.Equals("Movie Awards"))
            {
                this.listBox2.Items.Clear();
                this.listBox2.Items.Add("Best Pricture");
                this.listBox2.Items.Add("Adapted Screenplay");
                this.listBox2.Items.Add("Original Screenplay");
            }
        }

        private void uxButtonAddMovie_Click(object sender, EventArgs e)
        {
            if(this.listBox1.SelectedItem!= null&&!Form1.items.Contains(this.listBox1.SelectedItem.ToString()))
            {
                Form1.items.Add(this.listBox1.SelectedItem.ToString());
            }
            if (this.listBox2.SelectedItem != null && !Form1.items.Contains(this.listBox2.SelectedItem.ToString()))
            {
                Form1.items.Add(this.listBox2.SelectedItem.ToString());
            }
            this.Dispose();
        }
    }
}
