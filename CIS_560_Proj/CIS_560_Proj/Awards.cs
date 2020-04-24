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
        }
    }
}
