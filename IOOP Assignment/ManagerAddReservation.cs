using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IOOP_Assignment
{
    public partial class ManagerAddReservation : UserControl
    {
        ManagerFunct manager = new ManagerFunct();

        public ManagerAddReservation()
        {
            InitializeComponent();
        }

        private void ManagerAddReservation_Load(object sender, EventArgs e)
        {
            manager.FillUsername(dgvViewName);
            DataGridViewColumn column1 = dgvViewName.Columns[1];
            column1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            column1.Width = 105;
            hide();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Clear();
            txtName.ForeColor = SystemColors.WindowText;
        }

        private void dgvViewName_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewCell cell = dgvViewName.SelectedCells[0];
            DataGridViewRow row = dgvViewName.Rows[cell.RowIndex];
            string name = row.Cells["Name"].Value.ToString();
            name = char.ToUpper(name[0]) + name.Substring(1);
            lblCusname.Text = name;
            lblInstruction1.ForeColor = SystemColors.Control;
            lblInstruction2.Show();
            lblDate.Show();
            dtpDate.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            manager.FillUsername(dgvViewName, txtName.Text);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                txtName.Text = "Search Name...";
                txtName.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            lblInstruction2.ForeColor = SystemColors.Control;
            lblInstruction3.Show();
            lblNum.Show();
            nudNum.Show();
        }

        private void nudNum_ValueChanged(object sender, EventArgs e)
        {
            lblInstruction3.ForeColor = SystemColors.Control;
            lblInstruction4.Show();
            lblType.Show();
            cbxType.Show();
        }

        private void cbxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblInstruction4.ForeColor = SystemColors.Control;
            lblInstruction5.Show();
            lblStatus.Show();
            radConfirmed.Show();
            radPending.Show();
        }

        private void radPending_CheckedChanged(object sender, EventArgs e)
        {
            lblInstruction5.ForeColor = SystemColors.Control;
            lblInstruction6.Show();
            lblComments.Show();
            rtbComments.Show();
            btnAdd.Show();
        }

        private void radConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            lblInstruction5.ForeColor = SystemColors.Control;
            lblInstruction6.Show();
            lblComments.Show();
            rtbComments.Show();
            btnAdd.Show();
        }

        private void rtbComments_Enter(object sender, EventArgs e)
        {
            if (rtbComments.Text == "I want my food to be extra spicy..")
            {
                rtbComments.Clear();
                rtbComments.ForeColor = SystemColors.WindowText;
            }
        }

        private void rtbComments_Leave(object sender, EventArgs e)
        {
            if (rtbComments.Text.Length == 0)
            {
                rtbComments.Text = "I want my food to be extra spicy..";
                rtbComments.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string status = string.Empty;
            if (radConfirmed.Checked)
            {
                status = "Confirmed";
            }
            else if (radPending.Checked)
            {
                status = "Pending";
            }
            if (rtbComments.Text == "I want my food to be extra spicy..")
            {
                rtbComments.Text = "";
            }
            var result = MessageBox.Show($"Are you sure your reservation is correct?\n\n" +
                $"Name: {lblCusname.Text}\n" +
                $"Date: {dtpDate.Text}\n" +
                $"Type: {cbxType.Text}\n" +
                $"Guests: {nudNum.Value.ToString()}\n" +
                $"Status: {status}\n" +
                $"Description: {rtbComments.Text}"
                , "Check Your Reservation"
                , MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ManagerFunct manager = new ManagerFunct(lblCusname.Text, dtpDate.Value, cbxType.Text, (int)nudNum.Value, status, rtbComments.Text);
                if (manager.CheckReservation())
                {
                    var result2 = MessageBox.Show("You made a reservation on the specified date\n\nDid you mean to Manage Reservation?", "Reservation Exists", MessageBoxButtons.YesNo);
                    if (result2 == DialogResult.Yes)
                    {
                        Manager managerForm = this.ParentForm as Manager;
                        managerForm.openManage(lblCusname.Text, dtpDate.Value);
                    }
                }
                else
                {
                    manager.AddReservation();
                    manager.FillUsername(dgvViewName);
                    hide();
                }
            }
        }

        //Reset UI to initial load state
        private void hide()
        {
            radConfirmed.Checked = false;
            radPending.Checked = false;
            lblCusname.Text = string.Empty;
            lblInstruction1.Show();
            lblInstruction1.ForeColor = Color.ForestGreen;
            lblInstruction2.Hide();
            lblInstruction2.ForeColor = Color.ForestGreen;
            lblDate.Hide();
            dtpDate.Hide();
            lblInstruction3.Hide();
            lblInstruction3.ForeColor = Color.ForestGreen;
            lblNum.Hide();
            nudNum.Hide();
            lblInstruction4.Hide();
            lblInstruction4.ForeColor = Color.ForestGreen;
            lblType.Hide();
            cbxType.Hide();
            lblInstruction5.Hide();
            lblInstruction5.ForeColor = Color.ForestGreen;
            lblStatus.Hide();
            radConfirmed.Hide();
            radPending.Hide();
            lblInstruction6.Hide();
            lblInstruction6.ForeColor = Color.ForestGreen;
            lblComments.Hide();
            rtbComments.Text = "I want my food to be extra spicy..";
            rtbComments.ForeColor = SystemColors.WindowFrame;
            rtbComments.Hide();
            txtName.Text = "Search Name...";
            txtName.ForeColor = SystemColors.WindowFrame;
            btnAdd.Hide();
        }
    }
}
