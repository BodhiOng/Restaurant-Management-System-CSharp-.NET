using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using IOOP_Assignment;

namespace IOOP_Assignment
{

    public class OrderList
    {
        // Creates connection for OrderList class to use.
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        string Query;
        public void FillData(DataGridView dataGridView, string Query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Open the connection
                connection.Open();

                //to connect query with DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
                //to keep data received from database
                DataTable data = new DataTable();
                adapter.Fill(data);

                //display the data from table to datagridview
                dataGridView.DataSource = data;
            }
        }
        public void LoadOrder(DataGridView dataGridView)
        {
            Query = "SELECT * FROM order_list";
            FillData(dataGridView, Query);
        }
        public void ViewPending(DataGridView dataGridView)
        {
            Query = "SELECT * FROM order_list WHERE orderStatus = 'Pending'";
            FillData(dataGridView, Query);
        }
        public void ViewInProgress(DataGridView dataGridView)
        {
            Query = "SELECT * FROM order_list WHERE orderStatus = 'In Progress'";
            FillData(dataGridView, Query);
        }

        public void ViewCompleted(DataGridView dataGridView)
        {
            Query = "SELECT * FROM order_list WHERE orderStatus = 'Completed'";
            FillData(dataGridView, Query);
        }

        public void RefreshTable(DataGridView dataGridView)
        {
            Query = "SELECT * FROM order_list";
            FillData(dataGridView, Query);
        }
    }
    public class StatusUpdater
    {
        // Creates connection for StatusUpdater class to use.
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        string Query;


        public void ParameterData(DataGridView dataGridView, string Query, int orderID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Open the connection
                connection.Open();

                //Create command
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    //Add orderID parameter
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    //Executes query, also takes note of rows changed
                    int rowsChanged = command.ExecuteNonQuery();

                    //Check if rows are changed successfully or no, informs user
                    if (rowsChanged > 0)
                    {
                        MessageBox.Show("Order status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Failed to update order status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void UpdateInProgress(DataGridView dataGridView)
        {
            // Check whether a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtain orderID
                int orderID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["orderID"].Value);
                //Check whether selected order is in "Pending" status
                string orderStatus = dataGridView.SelectedRows[0].Cells["orderStatus"].Value.ToString();

                if (orderStatus == "Pending")
                {
                    //Query to update orderStatus to In Progress
                    Query = $"UPDATE order_list SET orderStatus = 'In Progress' WHERE orderID = @OrderID";
                    ParameterData(dataGridView, Query, orderID);
                }
                else if (orderStatus == "In Progress")
                {
                    MessageBox.Show("This order is already in progress.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (orderStatus == "Completed")
                {
                    MessageBox.Show("Order already completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateCompleted(DataGridView dataGridView)
        {
            // Check whether a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtain orderID
                int orderID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["orderID"].Value);
                //Check whether selected order is in "In Progress" status
                string orderStatus = dataGridView.SelectedRows[0].Cells["orderStatus"].Value.ToString();

                if (orderStatus == "In Progress")
                {
                    //Query to update orderStatus to In Progress
                    Query = $"UPDATE order_list SET orderStatus = 'Completed' WHERE orderID = @OrderID";
                    ParameterData(dataGridView, Query, orderID);
                }
                else if (orderStatus == "Pending")
                {
                    MessageBox.Show("Order has not been confirmed (Pending).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (orderStatus == "Completed")
                {
                    MessageBox.Show("Order is in completed status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteCompleted(DataGridView dataGridView)
        {
            // Check whether a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtain orderID
                int orderID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["orderID"].Value);

                //Check whether selected order is in "completed" status
                string orderStatus = dataGridView.SelectedRows[0].Cells["orderStatus"].Value.ToString();
                if (orderStatus == "Completed")
                {
                    //Query to update orderStatus to In Progress
                    string Query = $"DELETE FROM order_list WHERE orderID = @OrderID";
                    ParameterData(dataGridView, Query, orderID);
                }
                else
                {
                    MessageBox.Show("Only completed orders can be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class InventoryList
    {
        // Creates connection for InventoryList class to use.
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        string Query;

        OrderList borrow = new OrderList();
        public void LoadInventoryData(DataGridView dataGridView)
        {
            Query = "SELECT * FROM Ingredients";
            borrow.FillData(dataGridView, Query);
        }
        public void ShowTypeFood(DataGridView dataGridView)
        {
            Query = "SELECT * FROM Ingredients WHERE inventoryType IN ('Food', 'Both')";
            borrow.FillData(dataGridView, Query);
        }
        public void ShowTypeBeverage(DataGridView dataGridView)
        {
            Query = "SELECT * FROM Ingredients WHERE inventoryType IN ('Beverage', 'Both')";
            borrow.FillData(dataGridView, Query);
        }
        public void ShowTypeBoth(DataGridView dataGridView)
        {
            Query = "SELECT * FROM Ingredients WHERE inventoryType = 'Both'";
            borrow.FillData(dataGridView, Query);
        }
        public void RefreshInventoryTable(DataGridView dataGridView)
        {
            Query = "SELECT * FROM Ingredients";
            borrow.FillData(dataGridView, Query);
        }
        public void DeleteIngredient(DataGridView dataGridView)
        {
            // To check if a row is highlighted
            if (dataGridView.SelectedRows.Count > 0)
            {
                // to get ingredientName from selected row
                string ingredientName = dataGridView.SelectedRows[0].Cells["ingredientName"].Value.ToString();

                //Query to delete the ingredient
                string query = $"DELETE FROM Ingredients WHERE ingredientName = @IngredientName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IngredientName", ingredientName);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Ingredient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}