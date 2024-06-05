using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ManagerManageMenu : UserControl
    {
        //Initialize View & ManagerFunction Class
        View view;
        ManagerFunct manager = new ManagerFunct();

        public ManagerManageMenu()
        {
            InitializeComponent();
            //Bound this User Control to View Class
            view = new View(this);
        }

        //Enable ManagerFunct Class to access the object
        public string textboxName { get { return txtName.Text; } }

        private void ManagerManageMenu_Load(object sender, EventArgs e)
        {
            view.filldata(dgvViewMenu);
            DataGridViewColumn column0 = dgvViewMenu.Columns[0];
            DataGridViewColumn column1 = dgvViewMenu.Columns[1];
            DataGridViewColumn column2 = dgvViewMenu.Columns[2];
            DataGridViewColumn column3 = dgvViewMenu.Columns[3];
            column0.Width = 40;
            column1.HeaderText = "Name";
            column1.Width = 250;
            column2.HeaderText = "Price";
            column2.Width = 70;
            column3.HeaderText = "Category";
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lblManageMenu.Text = "Add Menu";
            lblFoodId.Hide();
            lblId.Hide();
            btnDelete.Hide();
            btnEdit.Hide();
            btnSwitchAdd.BackColor = SystemColors.ButtonFace;
            btnSwitchAdd.Enabled = false;
            btnSwitchEdit.BackColor = SystemColors.ButtonHighlight;
        }

        private void btnSwitchEdit_Click(object sender, EventArgs e)
        {
            SwitchEdit();
        }

        //Switch the UI to Adding Menu
        private void btnSwitchAdd_Click(object sender, EventArgs e)
        {
            lblManageMenu.Text = "Add Menu";
            lblFoodId.Hide();
            lblId.Hide();
            btnSwitchAdd.BackColor = SystemColors.ButtonFace;
            btnSwitchEdit.BackColor = SystemColors.ButtonHighlight;
            btnSwitchAdd.Enabled = false;
            btnSwitchEdit.Enabled = true;
            btnEdit.Hide();
            btnDelete.Hide();
            btnInsert.Show();
            lblInstruction1.Show();
            txtName.Clear();
            lblId.Text = "...";
            nudPrice.Value = 0;
            cbxCat.ResetText();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            view.filldata(dgvViewMenu);
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            view.filldata(dgvViewMenu);
        }

        private void cbxCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            view.filldata(dgvViewMenu);
        }

        private void dgvViewMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] data = manager.GetMenu(dgvViewMenu);
            lblId.Text = data[0].ToString();
            txtName.Text = data[1].ToString();
            nudPrice.Value = decimal.Parse(data[2]);
            cbxCat.Text = data[3].ToString();
            lblInstruction1.Hide();
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.ForeColor = SystemColors.ControlText;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Check existence of data
            if (txtName.Text.Length != 0 && nudPrice.Value != 0 && cbxCat.Text.Length != 0)
            {
                ManagerFunct manager = new ManagerFunct(txtName.Text, cbxCat.Text, nudPrice.Value);
                //Checks the existence of the current menu in database (prevent dupilcates)
                if (manager.CheckMenu())
                {
                    DialogResult result;
                    result = MessageBox.Show("A menu of that name exists\nDo you want to edit the mentioned menu?", "Menu exists", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SwitchEdit();
                    }
                    else { }
                }
                else
                {
                    manager.AddMenu();
                    view.filldata(dgvViewMenu);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Empty Fields");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            manager.UpdateMenu(int.Parse(lblId.Text), txtName.Text, (decimal)nudPrice.Value, cbxCat.Text);
            view.filldata(dgvViewMenu);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "..." || lblId.Text.Length == 0 || txtName.Text.Length == 0)
            {
                MessageBox.Show("Please select a record before deleting", "No record selected");
            }
            else
            {
                manager.DeleteMenu(dgvViewMenu);
                view.filldata(dgvViewMenu);
                txtName.Clear();
                nudPrice.Value = 0;
                cbxCat.ResetText();
            }
        }

        //Switch the UI to Editing Menu
        private void SwitchEdit()
        {
            lblManageMenu.Text = "Edit Menu";
            lblFoodId.Show();
            lblId.Show();
            btnSwitchAdd.BackColor = SystemColors.ButtonHighlight;
            btnSwitchEdit.Enabled = false;
            btnSwitchAdd.Enabled = true;
            btnSwitchEdit.BackColor = SystemColors.ButtonFace;
            btnEdit.Show();
            btnDelete.Show();
            btnInsert.Hide();
            lblInstruction1.Show();
            if (lblId.Text == "..." || lblId.Text.Length == 0 || txtName.Text.Length == 0)
            {
                btnDelete.BackColor = Color.Silver;
                btnDelete.ForeColor = SystemColors.ControlLight;
            }
        }
    }
}
