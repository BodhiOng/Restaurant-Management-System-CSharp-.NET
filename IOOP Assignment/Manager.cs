using System;
using System.Collections;
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
    public partial class Manager : Form
    {
        string username;
        new string Name;

        public Manager()
        {
            InitializeComponent();
            ViewReservation.Hide();
            ManagerManageMenu.Hide();
            UpdateProfile.Hide();
            AddReservation.Hide();
        }

        public void SetName(string name)
        {
            username = name;
            Name = char.ToUpper(name[0]) + name.Substring(1);
            UpdateProfile.Username = name;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ManagerManageMenu.Hide();
            AddReservation.Hide();
            UpdateProfile.Hide();
            ViewReservation.Show();
            ViewReservation.BringToFront();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {Name}";
        }

        private void lilblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewReservation.Hide();
            ManagerManageMenu.Hide();
            UpdateProfile.Hide();
            AddReservation.Hide();
        }

        private void lilblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ViewReservation.Hide();
            ManagerManageMenu.Hide();
            AddReservation.Hide();
            UpdateProfile.Show();
            UpdateProfile.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ViewReservation.Hide();
            AddReservation.Hide();
            UpdateProfile.Hide();
            ManagerManageMenu.Show();
            ManagerManageMenu.BringToFront();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            AddReservation.Show();
            ManagerManageMenu.Hide();
            ViewReservation.Hide();
            UpdateProfile.Hide();
            AddReservation.BringToFront();
        }

        public void openManage(string name, DateTime date)
        {
            ManagerManageMenu.Hide();
            AddReservation.Hide();
            UpdateProfile.Hide();
            ViewReservation.Show();
            ViewReservation.BringToFront();
            ViewReservation.ManageReservationFromAdd(name, date);
        }
    }
}
