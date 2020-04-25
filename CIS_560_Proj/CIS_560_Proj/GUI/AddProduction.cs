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
    public partial class AddProduction : UserControl
    {
        public AddProduction()
        {
            InitializeComponent();
            this.uxButtonAddProduction.Enabled = true;
        }

        private void uxButtonAddProduction_Click(object sender, EventArgs e)
        {
            if (this.ProductionName.Text.Length > 0)
            {
                Form1.items.Add(this.ProductionName.Text);
            }
            if (this.uxTextBoxLocation.Text.Length > 0)
            {
                Form1.items.Add(this.uxTextBoxLocation.Text);
            }
            this.Dispose();
        }
    }
}
