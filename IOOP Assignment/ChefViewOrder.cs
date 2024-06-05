using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ChefViewOrder : UserControl
    {
        public ChefViewOrder()
        {
            InitializeComponent();
        }

        OrderList orderList = new OrderList();
        StatusUpdater statusUpdater = new StatusUpdater();
        private void ChefViewOrder_Load(object sender, EventArgs e)
        {
            // Calling method.
            orderList.LoadOrder(dgv_viewupdateorder);
        }

        private void radbtn_pending_CheckedChanged(object sender, EventArgs e)
        {
            orderList.ViewPending(dgv_viewupdateorder);
        }

        private void radbtn_inprogress_CheckedChanged(object sender, EventArgs e)
        {
            orderList.ViewInProgress(dgv_viewupdateorder);
        }

        private void radbtn_completed_CheckedChanged(object sender, EventArgs e)
        {
            orderList.ViewCompleted(dgv_viewupdateorder);
        }
     
        private void btn_refreshtbl_Click(object sender, EventArgs e)
        {
            orderList.RefreshTable(dgv_viewupdateorder);
        }

        private void dgv_ViewUpdateOrderClick(object sender, DataGridViewCellEventArgs e)
        {
            //check if a row is selected
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgv_viewupdateorder.Rows[index];

                // Access custName and order detail
                string custName = selectedRow.Cells[1].Value?.ToString();
                string orderDetails = selectedRow.Cells[2].Value?.ToString();
                //? is used to handle null values

                // Update label with info
                lbl_custName.Text = custName;
                lbl_orderDetail.Text = orderDetails;
            }
        }

        private void btn_updateinprogress_Click(object sender, EventArgs e)
        {
            statusUpdater.UpdateInProgress(dgv_viewupdateorder);
            orderList.RefreshTable(dgv_viewupdateorder);
        }

        private void btn_updatecompleted_Click(object sender, EventArgs e)
        {
            statusUpdater.UpdateCompleted(dgv_viewupdateorder);
            orderList.RefreshTable(dgv_viewupdateorder);
        }

        private void btn_deletecompleted_Click(object sender, EventArgs e)
        {
            statusUpdater.DeleteCompleted(dgv_viewupdateorder);
            orderList.RefreshTable(dgv_viewupdateorder);
        }
    }
}

