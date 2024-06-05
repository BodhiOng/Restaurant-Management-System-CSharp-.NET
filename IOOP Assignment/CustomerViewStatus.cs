using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class CustomerViewStatus : UserControl
    {
        string username = string.Empty;
        public string Username { get => username; set => username = value; }

        public CustomerViewStatus()
        {
            InitializeComponent();
        }
        private void CustomerViewStatus_Load(object sender, EventArgs e)
        {
            //if string is not empty it will show username in greetings
            if (!string.IsNullOrEmpty(username))
            {
                username = char.ToUpper(username[0]) + username.Substring(1);
                lblGreetings.Text = $"Hello {username}, please press any button :)";
            }
            else
            {
                lblGreetings.Text = "Hello, please press any button :)";
            }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            ViewStatus viewOrder = new ViewStatus(dgvViewStatus, username.ToLower());
            //calling method from class to show order table
            viewOrder.ViewOrderStatus();
            lblStatusView.Text = "Order Status";
            lblDetails.Text = "Order Details";
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            ViewStatus viewRes = new ViewStatus(dgvViewStatus, username.ToLower());
            //calling method from class to show reservation table
            viewRes.ViewReservationStatus();
            lblStatusView.Text = "Reservation Status";
            lblDetails.Text = "Reservation Description";
        }

        private void dgvViewStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //make a variable to get the selected row from data grid view in user controls
            DataGridViewRow selectedRow = dgvViewStatus.Rows[index];
            //change the textbox to food name of the selected row
            txtStatusView.Text = selectedRow.Cells[2].Value.ToString();
            rtbDetails.Text = selectedRow.Cells[1].Value.ToString();
        }
    }
}
