using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            uc_manageusers.Hide();
            uc_viewsalesreport.Hide();
        }

        private void linklbl_backtologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void adminManageUsers1_Load(object sender, EventArgs e)
        {
        }

        private void adminHomePage1_Load(object sender, EventArgs e)
        {

        }

        private void linklbl_adminhomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uc_manageusers.Hide();
            uc_viewsalesreport.Hide();
        }

        private void adminManageUsers1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_functionality1_Click(object sender, EventArgs e)
        { 
            uc_manageusers.Show();
            uc_manageusers.BringToFront();
        }

        private void lbl_greetings_Click(object sender, EventArgs e)
        {

        }

        private void adminManageUsers1_Load_2(object sender, EventArgs e)
        {
           
        }

        private void adminManageUsers1_Load_3(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_manageusers_Load(object sender, EventArgs e)
        {

        }

        private void btn_functionality2_Click(object sender, EventArgs e)
        {
            uc_viewsalesreport.Show();
            uc_viewsalesreport.BringToFront();
        }
    }
}
