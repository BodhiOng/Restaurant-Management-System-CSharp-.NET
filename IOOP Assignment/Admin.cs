using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Assignment
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            // Hides all User Controls by the booting up of the Admin Form
            uc_manageusers.Hide();
            uc_viewsalesreport.Hide();
            uc_viewfeedbacks.Hide();
            uc_updateprofile.Hide();
        }

        string username;
        public void SetName(string name)
        {
            // Catch username from login for usage in Form or User Control
            username = name;
            uc_updateprofile.Username = name;
        }

        private void linklbl_backtologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Closes this Admin Form window
            this.Close();
        }

        private void linklbl_adminhomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hides all the other User Controls to prioritize the original Admin Form   
            uc_manageusers.Hide();
            uc_viewsalesreport.Hide();
            uc_viewfeedbacks.Hide();
            uc_updateprofile.Hide();
        }

        private void btn_functionality1_Click(object sender, EventArgs e)
        {
            // Shows AdminManageUsers User Control and bring it to front for usage
            uc_manageusers.Show();
            uc_manageusers.BringToFront();
        }

        private void btn_functionality2_Click(object sender, EventArgs e)
        {
            // Shows AdminSalesReport User Control and bring it to front for usage
            uc_viewsalesreport.Show();
            uc_viewsalesreport.BringToFront();
        }

        private void btn_functionality3_Click(object sender, EventArgs e)
        {
            // Show AdminViewCustomerFeedbacks User Control and bring it front for usage
            uc_viewfeedbacks.Show();
            uc_viewfeedbacks.BringToFront();
        }

        private void btn_functionality4_Click(object sender, EventArgs e)
        {
            // Show AdminUpdateProfile User Control and bring it front for usage
            uc_updateprofile.Show();
            uc_updateprofile.BringToFront();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lbl_greetings.Text = ($"Welcome, {char.ToUpper(username[0]) + username.Substring(1)}!\nClick a button to use a functionality:");
        }
    }
}
