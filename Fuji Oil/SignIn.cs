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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }


        private void aacountlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            animation1.HideSync(p2);
            //animation1.ShowSync(p1);
            animation1.ShowSync(p3);
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            animation1.HideSync(p3);
            animation1.ShowSync(p2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsignin_Click(object sender, EventArgs e)
        {
            this.Close();
            DBoard db = new DBoard();
            db.Show();
        }
    }
}
