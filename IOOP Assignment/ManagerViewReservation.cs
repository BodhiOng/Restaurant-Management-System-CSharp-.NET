using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Drawing.Text;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing;
using System.Diagnostics.Tracing;
using Microsoft.IdentityModel.Tokens;

namespace IOOP_Assignment
{
    public partial class ManagerViewReservation : UserControl
    {
        View view;
        ManagerFunct manage = new ManagerFunct();

        public ManagerViewReservation()
        {
            InitializeComponent();
            view = new View(this);
        }

        public string textboxName { get { return txtName.Text; } }
        public string datetimepickDate { get { return dtpDate.Text; } }
        public int numupdownNum { get { return (int)nudNum.Value; } }
        public string checklistStatus { get { return getstatusitems(); } }
        public string checklistType { get { return gettypeitems(); } }

        private string getstatusitems()
        {
            string itemschecked = string.Empty;
            if (clbStatus.CheckedItems.Count > 0)
            {
                foreach (string check in clbStatus.CheckedItems)
                {
                    itemschecked = itemschecked + ", '" + check + "'";
                }
                itemschecked = itemschecked.Remove(0, 2);
            }
            return itemschecked;
        }
        private string gettypeitems()
        {
            string itemschecked = string.Empty;
            if (clbType.CheckedItems.Count > 0)
            {
                foreach (string check in clbType.CheckedItems)
                {
                    itemschecked = itemschecked + ", '" + check + "'";
                }
                itemschecked = itemschecked.Remove(0, 2);
            }
            return itemschecked;
        }

        private void ManagerViewReservation_Load(object sender, EventArgs e)
        {
            view.filldata(dgvViewReserve);
            DataGridViewColumn column0 = dgvViewReserve.Columns[0];
            DataGridViewColumn column1 = dgvViewReserve.Columns[1];
            DataGridViewColumn column2 = dgvViewReserve.Columns[2];
            DataGridViewColumn column3 = dgvViewReserve.Columns[3];
            DataGridViewColumn column4 = dgvViewReserve.Columns[4];
            DataGridViewColumn column5 = dgvViewReserve.Columns[5];
            DataGridViewColumn column6 = dgvViewReserve.Columns[6];
            column0.Width = 35;
            column1.HeaderText = "Name";
            column2.HeaderText = "Date";
            column3.HeaderText = "Type";
            column4.HeaderText = "Size";
            column4.Width = 45;
            column5.HeaderText = "Status";
            column5.Width = 80;
            column6.HeaderText = "Notes";
            btnView.Hide();
            lblCusname.Hide();
            cbxStatus.Hide();
            cbxType.Hide();
            btnUpdate.Hide();
            lblInstruction1.Hide();
            lblDesc.Text = "Description\n(Read-only)";
            rtbDesc.ReadOnly = true;
            btnDelete.Show();
            lblType.Show();
            lblTypeManage.Hide();
            lblId.Hide();
            dgvViewReserve.ScrollBars = ScrollBars.Both;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            view.filldata(dgvViewReserve);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (btnUpdate.Visible == false)
            {
                view.filldata(dgvViewReserve);
            }
        }

        private void nudNum_ValueChanged(object sender, EventArgs e)
        {
            if (btnUpdate.Visible == false)
            {
                view.filldata(dgvViewReserve);
            }
        }

        private void clbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            view.filldata(dgvViewReserve);
        }

        private void clbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            view.filldata(dgvViewReserve);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Parse("1/1/2024");
            view.filldata(dgvViewReserve);
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageReservation();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewReservation();
        }

        private void dgvViewReserve_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblInstruction1.Hide();
            ShowData(e);
            if (btnView.Visible)
            {
                lblId.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                manage.UpdateReservation(int.Parse(lblId.Text), dtpDate.Value, cbxType.Text, (int)nudNum.Value, cbxStatus.Text, rtbDesc.Text);
                view.filldata(dgvViewReserve);
            }
            catch
            {
                MessageBox.Show("Please select a record from the table");
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            dtpDate.Value = DateTime.Parse("1/1/2024");
            nudNum.Value = 0;
            ClearItems(clbStatus);
            ClearItems(clbType);
            view.filldata(dgvViewReserve);
        }

        private void ClearItems(CheckedListBox checkedList)
        {
            CheckedListBox.CheckedIndexCollection indexcollection = checkedList.CheckedIndices;
            foreach (int index in indexcollection)
            {
                checkedList.SetItemChecked(index, false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the selected record?", "Delete?", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                manage.DeleteReservation(dgvViewReserve);
                view.filldata(dgvViewReserve);
                btnAllClear.PerformClick();
            }
        }

        private void clbStatus_Click(object sender, EventArgs e)
        {
            view.filldata(dgvViewReserve);
        }

        private void clbType_Click(object sender, EventArgs e)
        {
            view.filldata(dgvViewReserve);
        }

        private void clbStatus_MouseDown(object sender, MouseEventArgs e)
        {
            view.filldata(dgvViewReserve);
        }

        private void clbType_MouseDown(object sender, MouseEventArgs e)
        {
            view.filldata(dgvViewReserve);
        }

        private void ManagerViewReservation_Enter(object sender, EventArgs e)
        {
            view.filldata(dgvViewReserve);
        }

        public void ManageReservationFromAdd(string name, DateTime date)
        {
            ManageReservation();
            txtName.Text = name;
            dtpDate.Value = date;
            view.filldata(dgvViewReserve);
            dgvViewReserve.Rows[0].Selected = true;
            ShowData();
            lblInstruction1.Hide();
        }

        private void ShowData(DataGridViewCellEventArgs e)
        {
            string[] data = new string[7];
            data = manage.GetReservation(dgvViewReserve, e);
            lblId.Text = $"ID: {data[0].ToString()}";
            txtName.Text = data[1].ToString();
            lblCusname.Text = data[1].ToString();
            dtpDate.Value = DateTime.Parse(data[2]);
            cbxType.Text = data[3].ToString();
            nudNum.Value = int.Parse(data[4]);
            cbxStatus.Text = data[5].ToString();
            rtbDesc.Text = data[6].ToString();
        }

        private void ShowData()
        {
            string[] data = new string[7];
            data = manage.GetReservation(dgvViewReserve, lblId.Text);
            txtName.Text = data[1].ToString();
            lblCusname.Text = data[1].ToString();
            dtpDate.Value = DateTime.Parse(data[2]);
            cbxType.Text = data[3].ToString();
            nudNum.Value = int.Parse(data[4]);
            cbxStatus.Text = data[5].ToString();
            rtbDesc.Text = data[6].ToString();
        }

        private void ViewReservation()
        {
            lblViewManageReservation.Text = "View Reservations";
            lblInstruction1.Hide();
            btnManage.Enabled = true;
            btnManage.Show();
            btnView.Hide();
            lblCusname.Hide();
            txtName.Show();
            btnUpdate.Hide();
            cbxStatus.Hide();
            cbxType.Hide();
            clbStatus.Show();
            clbType.Show();
            lblDesc.Text = "Description\n(Read-only)";
            rtbDesc.ReadOnly = true;
            btnDelete.Show();
            lblType.Show();
            btnAllClear.Show();
            btnDateClear.Show();
            lblTypeManage.Hide();
            nudNum.Value = 0;
            dtpDate.Value = DateTime.Parse("1/1/2024");
            txtName.Text = string.Empty;
            lblCusname.Text = string.Empty;
            rtbDesc.Text = string.Empty;
            lblId.Text = "ID:...";
            lblId.Hide();
            cbxStatus.ResetText();
            cbxType.ResetText();
        }

        private void ManageReservation()
        {
            btnView.Enabled = true;
            btnView.Show();
            btnManage.Hide();
            lblCusname.Show();
            btnUpdate.Show();
            lblViewManageReservation.Text = "Manage Reservations";
            txtName.Hide();
            cbxStatus.Show();
            cbxType.Show();
            clbStatus.Hide();
            clbType.Hide();
            lblDesc.Text = "Description\n(Optional)";
            rtbDesc.ReadOnly = false;
            btnDelete.Hide();
            btnAllClear.Hide();
            btnDateClear.Hide();
            lblType.Hide();
            lblTypeManage.Show();
            lblId.Show();
            ShowInstruction();
        }

        private void ShowInstruction()
        {
            if (lblCusname.Text == string.Empty)
            {
                lblInstruction1.Show();
                lblId.Hide();
            }
            else
            {
                lblInstruction1.Hide();
            }
        }


    }
}
