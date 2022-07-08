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
    public partial class AddSample : Form
    {
        public AddSample()
        {
            InitializeComponent();
        }

        private void btNewOperator_Click(object sender, EventArgs e)
        {
            txtOperatorName.Clear();
        }

        private void btNewSample_Click(object sender, EventArgs e)
        {
            chReflux.Checked = false;
            chMiscella.Checked = false;
            chOlein.Checked = false;
            chStearin.Checked = false;
            chCButter.Checked = false;
            txtOperator1.Clear();
            txtOperator2.Clear();
        }

        private void btGetOperatorData_Click(object sender, EventArgs e)
        {
            OperatorsRecord opr = new OperatorsRecord();
            opr.Show();
        }
    }
}
