using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class CustomerOrderFoodMenu : UserControl
    {
        public CustomerOrderFoodMenu()
        {
            InitializeComponent();
        }

        string username;
        public string Username { get => username; set => username = value; }

        //creation of object
        FoodMenuAndOrderFood foodMenu = new FoodMenuAndOrderFood();

        private void CustomerFoodMenu_Load(object sender, EventArgs e)
        {
            //method calling 
            foodMenu.LoadMenu(dgvFoodMenu);

            panelFoodCart.Hide();
            pbxShowMenu.Hide();

        }

        private void pbxSearchMenu_Click(object sender, EventArgs e)
        {
            //method calling
            foodMenu.SearchBar(dgvFoodMenu, txtFoodSearch.Text);
        }

        private void pbxMainCourse_Click(object sender, EventArgs e)
        {
            //method calling
            foodMenu.MainCourse(dgvFoodMenu);
        }

        private void pbxBeverages_Click(object sender, EventArgs e)
        {
            //method calling
            foodMenu.Beverages(dgvFoodMenu);
        }

        private void pbxDessert_Click(object sender, EventArgs e)
        {
            //method calling
            foodMenu.Dessert(dgvFoodMenu);
        }

        private void pbxAppetizer_Click(object sender, EventArgs e)
        {
            //method calling
            foodMenu.Appetizers(dgvFoodMenu);
        }

        private void pbxAll_Click(object sender, EventArgs e)
        {
            //method calling
            foodMenu.LoadMenu(dgvFoodMenu);
        }

        private void dgvFoodMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //make a variable to get the selected row from data grid view in user controls
            DataGridViewRow selectedRow = dgvFoodMenu.Rows[index];
            //change the textbox to food name of the selected row
            lblOrder.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(lblQty.Text);
            int num = 1;
            int max;

            if (qty == 50)
            {
                MessageBox.Show("Maximum order up to 50");
            }
            else
            {
                max = qty + num;
                lblQty.Text = max.ToString();

            }

        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(lblQty.Text);
            int num = -1;
            int min;

            //to limit user from decreasing the food to 0
            if (qty == 1)
            {
                MessageBox.Show("Must at least have 1 to add");
            }
            else
            {
                min = qty + num;
                lblQty.Text = min.ToString();
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            string qty = lblQty.Text;
            string order = lblOrder.Text;

            //add items to the food cart if the order is not empty
            if (!string.IsNullOrEmpty(order))
            {
                lstOrderDetails.Items.Add($"{qty} {order}");
                lblOrder.Text = "";
                //resets the quantity of food back to 1
                lblQty.Text = "1";
            }
            else
            {
                MessageBox.Show("No food was selected");
            }


        }

        private void pbxShowCart_Click(object sender, EventArgs e)
        {
            //changes the label text to "Show Menu" and bring the food cart panel to front
            lblShowCartnMenu.Text = "Show Menu";
            lblFoodMenunCart.Text = "Food Cart";
            panelFoodCart.Show();
            panelFoodCart.BringToFront();

            //hide the show cart button and show the show menu button
            pbxShowCart.Hide();
            pbxShowMenu.Show();
            pbxShowMenu.BringToFront();
        }

        private void pbxShowMenu_Click(object sender, EventArgs e)
        {
            //changes the label text to "Show Cart" and hide the panel aswell as the show menu picture
            lblShowCartnMenu.Text = "Show Cart";
            lblFoodMenunCart.Text = "Food Menu";
            panelFoodCart.Hide();
            pbxShowMenu.Hide();

            //Show the showcart button
            pbxShowCart.Show();
            pbxShowCart.BringToFront();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (lstOrderDetails.Items.Count == 0)
            {
                MessageBox.Show($"The Cart is empty :(");
            }
            else
            {
                //method to seperate each items from list box and join into one string then assign to variable
                string orderDetails = string.Join(", ", lstOrderDetails.Items.Cast<string>());
                //object creation
                FoodMenuAndOrderFood addOrder = new FoodMenuAndOrderFood(username, orderDetails);
                //method calling to insert name and order details into order_list table
                addOrder.AddOrder();
                lstOrderDetails.Items.Clear();
                ////testing
                MessageBox.Show($"{username}, Your Order is {orderDetails}");
            }
        }
    }
}
