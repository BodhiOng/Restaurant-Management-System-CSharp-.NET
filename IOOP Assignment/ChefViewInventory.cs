using System;
using System.Collections;
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
    public partial class ChefViewInventory : UserControl
    {
        public ChefViewInventory()
        {
            InitializeComponent();
        }

        //creates connection to database
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        string Query;

        InventoryList inventorylist = new InventoryList();
        private void ChefViewInventory_Load(object sender, EventArgs e)
        {
            inventorylist.LoadInventoryData(dgv_viewupdateinventory);
        }

        private void radBeverages_CheckedChanged(object sender, EventArgs e)
        {
            inventorylist.ShowTypeBeverage(dgv_viewupdateinventory);
        }

        private void radFood_CheckedChanged(object sender, EventArgs e)
        {
            inventorylist.ShowTypeFood(dgv_viewupdateinventory);
        }

        private void radFoodBev_CheckedChanged(object sender, EventArgs e)
        {
            inventorylist.ShowTypeBoth(dgv_viewupdateinventory);
        }
        private string SelectedType()
        {
            //Check which type of ingredient is being added
            if (rad_food.Checked)
            {
                return "Food";
            }
            else if (rad_beverage.Checked)
            {
                return "Beverage";
            }
            else if (rad_foodbev.Checked)
            {
                return "Both";
            }
            else
            {
                return "none";
            }
        }
        private void tbx_newingredient_Enter(object sender, EventArgs e)
        {
            //remove text when user click the textbox
            tbx_newingredient.Text = "";
        }
        private void tbx_initialstock_Enter(object sender, EventArgs e)
        {
            //remove text when user click the textbox
            tbx_initialstock.Text = "";
        }
        private void btn_addingredient_Click(object sender, EventArgs e)
        {
            string ingredientType = SelectedType();
            string ingredientName = tbx_newingredient.Text;
            if (ingredientName == "Type Here")
            {
                MessageBox.Show("Enter a valid Ingredient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int initialStock;
            if (!int.TryParse(tbx_initialstock.Text, out initialStock)) //! means that if the parse fails, it'll send out a  'true'
            {
                MessageBox.Show("Initial stock must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Ingredients (ingredientName, inventoryStock, InventoryType) VALUES (@Name, @Stock, @Type)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", ingredientName);
                    command.Parameters.AddWithValue("@Stock", initialStock);
                    command.Parameters.AddWithValue("@Type", ingredientType);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ingredient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear textbox after data is inserted to table
                        tbx_newingredient.Text = "";
                        tbx_initialstock.Text = "";
                    }
                    catch (Exception ex) //error handling
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Refresh table everytime an ingredient is added.
                    inventorylist.RefreshInventoryTable(dgv_viewupdateinventory);
                }
            }
        }
        private void btn_deleteingredient_Click(object sender, EventArgs e)
        {
            inventorylist.DeleteIngredient(dgv_viewupdateinventory);
            inventorylist.RefreshInventoryTable(dgv_viewupdateinventory);
        }
        private void tbx_stockadd_Enter(object sender, EventArgs e)
        {
            tbx_stockadd.Text = "";
        }
        private void btn_addmorestock_Click(object sender, EventArgs e)
        {

            int addStock;
            if (!int.TryParse(tbx_stockadd.Text, out addStock))
            {
                MessageBox.Show("Please Enter a Valid Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }
            //get current stock
            int currentStock = Convert.ToInt32(dgv_viewupdateinventory.CurrentRow.Cells["inventoryStock"].Value);
            int newStock = currentStock + addStock;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string ingredientName = dgv_viewupdateinventory.CurrentRow.Cells["ingredientName"].Value.ToString();
                string Query = "UPDATE Ingredients SET inventoryStock = @NewStock WHERE ingredientName = @IngredientName";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@NewStock", newStock);
                    command.Parameters.AddWithValue("@IngredientName", ingredientName);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Stock updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            tbx_stockadd.Text = "";
            inventorylist.RefreshInventoryTable(dgv_viewupdateinventory);
        }
        private void dgv_ViewInventory(object sender, DataGridViewCellEventArgs e)
        {
            //check if a row is selected
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgv_viewupdateinventory.Rows[index];

                // Access custName and order detail
                string ingredientName = selectedRow.Cells[0].Value?.ToString();
                string ingredientStock = selectedRow.Cells[1].Value?.ToString();
                //? is used to handle null values

                // Update label with info
                lbl_selectedingredient.Text = ingredientName;
                lbl_stockleft.Text = ingredientStock;
            }
        }

        private void btn_subtractstock_Click(object sender, EventArgs e)
        {

            int addStock;
            if (!int.TryParse(tbx_stockadd.Text, out addStock))
            {
                MessageBox.Show("Please Enter a Valid Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }
            //get current stock
            int currentStock = Convert.ToInt32(dgv_viewupdateinventory.CurrentRow.Cells["inventoryStock"].Value);
            int newStock = currentStock - addStock;
            if (newStock < 0)
            {
                MessageBox.Show("Stock Can't be less than 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string ingredientName = dgv_viewupdateinventory.CurrentRow.Cells["ingredientName"].Value.ToString();
                string Query = "UPDATE Ingredients SET inventoryStock = @NewStock WHERE ingredientName = @IngredientName";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@NewStock", newStock);
                    command.Parameters.AddWithValue("@IngredientName", ingredientName);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Stock updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            tbx_stockadd.Text = "";
            inventorylist.RefreshInventoryTable(dgv_viewupdateinventory);
        }
    }
}

