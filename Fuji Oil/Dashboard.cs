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
    public partial class DBoard : Form
    {
        public DBoard()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            productionPanel.Visible = false;
            laboratorypanel.Visible = false;
            reportspanel.Visible = false;
            wateranalysispanel.Visible = false;
            consumablespanel.Visible = false;
        }
        private void hideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
                menuanimation.HideSync(subMenu);
           
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                
                hideSubMenu(subMenu);
                menuanimation.ShowSync(subMenu);
                //subMenu.Visible = true

            }
            else
            {
                //subMenu.Visible = false;
                menuanimation.HideSync(subMenu);
            }
        }

        private void production_Click(object sender, EventArgs e)
        {
            showSubMenu(productionPanel);
        }

        private void sample_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            openChildForm(new AddSample());
        }

        private void analyticalRes_Click(object sender, EventArgs e)
        {
            // hideSubMenu();
            openChildForm(new CheckAnalyticalResults());
        }

        private void prodRemarks_Click(object sender, EventArgs e)
        {
            // hideSubMenu();
            openChildForm(new AddProductionRemarks());
        }

        private void waterAnalysis_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
        }

        private void btlaboratory_Click(object sender, EventArgs e)
        {
            showSubMenu(laboratorypanel);
        }

        private void btsample_Click(object sender, EventArgs e)
        {
           // hideSubMenu();
        }

        private void btAnalyticalRes_Click(object sender, EventArgs e)
        {
            //  hideSubMenu();
            openChildForm(new AddSampleResults());
        }

        private void btProductionRemarks_Click(object sender, EventArgs e)
        {
            // hideSubMenu();
            openChildForm(new ViewProductionRemarks());
        }

        private void btcalculator_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
        }

        private void btReports_Click(object sender, EventArgs e)
        {
            showSubMenu(reportspanel);
        }

        private void btAnalyticalResults_Click(object sender, EventArgs e)
        {
           // hideSubMenu();
        }

        private void btstocks_Click(object sender, EventArgs e)
        {
           // hideSubMenu();
        }

        private void bttrends_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
        }

        private void btWaterAnalysis_Click(object sender, EventArgs e)
        {
            showSubMenu(wateranalysispanel);
        }

        private void btWellWater_Click(object sender, EventArgs e)
        {
           // hideSubMenu();
        }

        private void btSoftWater_Click(object sender, EventArgs e)
        {
           // hideSubMenu();
        }

        private void btFeedWater_Click(object sender, EventArgs e)
        {
          //  hideSubMenu();
        }

        private void btBoilerWater_Click(object sender, EventArgs e)
        {
           // hideSubMenu();
        }

        private void btCondensate_Click(object sender, EventArgs e)
        {
           // hideSubMenu();
        }

        private void btCoolingWater_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
        }

        private void btchillerWater_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
        }

        private void bteffluent_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
                
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childformPanel.Controls.Add(childForm);
            childformPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
           // DashboardUpdate du = new DashboardUpdate();
            //du.Dock = DockStyle.Fill;
            openChildForm(new DashboardUpdate());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void childformPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btConsumables_Click(object sender, EventArgs e)
        {
            showSubMenu(consumablespanel);
        }

        private void btreports_Click_1(object sender, EventArgs e)
        {
            showSubMenu(reportspanel);
        }

        private void btWaterAnalysis_Click_1(object sender, EventArgs e)
        {
            showSubMenu(wateranalysispanel);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn si = new SignIn();
            si.Show();
        }

        private void DBoard_Load(object sender, EventArgs e)
        {
            timer.Start();
            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void btcalculator_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
    }
}
