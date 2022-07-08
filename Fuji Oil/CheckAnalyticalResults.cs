using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuji_Oil
{
    public partial class CheckAnalyticalResults : Form
    {
        public CheckAnalyticalResults()
        {
            InitializeComponent();
        }

        private void btViewSampleResult_Click(object sender, EventArgs e)
        {
            if (txtSelectedProduct.selectedIndex == -1)
            {
                MessageBox.Show("Please select a Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSelectedProduct.Focus();
            }
        }
    }
}
