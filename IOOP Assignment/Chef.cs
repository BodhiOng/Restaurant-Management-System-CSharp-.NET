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
    public partial class Chef : Form
    {

        string username;
        public void SetName(string name)
        {
            //catch username from login to use for form and user controls
            username = name;
            uc_updateprofile.Username = name;
        }
        public Chef()
        {
            InitializeComponent();

            // Hides all user controls when Chef form boots up.
            uc_updateprofile.Hide();
            uc_viewupdateorder.Hide();
            uc_viewinventory.Hide();
        }

        private void btn_vieworder_Click(object sender, EventArgs e)
        {
            uc_viewupdateorder.Show();
            uc_viewupdateorder.BringToFront();
        }

        private void btn_viewinventory_Click(object sender, EventArgs e)
        {
            uc_viewinventory.Show();
            uc_viewinventory.BringToFront();
        }

        private void btn_updateprofile_Click(object sender, EventArgs e)
        {
            uc_updateprofile.Show();
            uc_updateprofile.BringToFront();
        }

        private void linklbl_backtologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Closes Chef form to return back to Login form.
            this.Close();
        }

        private void linklbl_chefhomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Displays the Chef form by hiding all user controls.
            uc_updateprofile.Hide();
            uc_viewupdateorder.Hide();
            uc_viewinventory.Hide();
        }
    }
}
