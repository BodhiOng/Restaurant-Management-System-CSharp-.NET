using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace IOOP_Assignment
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            OrderFoodMenu.Hide();
            ViewStatus.Hide();
            SendFeedback.Hide();
            UpdateProfile.Hide();
        }

        string username;
        public void SetName(string name)
        {
            //catch username from login to use for form and user controls
            username = name;
            OrderFoodMenu.Username = name;
            ViewStatus.Username = name;
            SendFeedback.Username = name;
            UpdateProfile.Username = name;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            lblGreetings.Text = ($"Welcome, {char.ToUpper(username[0]) + username.Substring(1)}!\nClick a Button To:");
        }
        private void linklblBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Close The Customer Form
            this.Close();
        }

        private void linklblCustomerHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Hides all of the user controls to focus on the main form
            OrderFoodMenu.Hide();
            ViewStatus.Hide();
            SendFeedback.Hide();
            UpdateProfile.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OrderFoodMenu.Show();
            OrderFoodMenu.BringToFront();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            ViewStatus.Show();
            ViewStatus.BringToFront();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            SendFeedback.Show();
            SendFeedback.BringToFront();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile.Show();
            UpdateProfile.BringToFront();
        }
        }
}
