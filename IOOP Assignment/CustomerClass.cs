using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections;
using System.Net.NetworkInformation;

namespace IOOP_Assignment
{
    public class FoodMenuAndOrderFood
    {
        public string name;
        public string details; 
        //Constructor that holds name and details
        public FoodMenuAndOrderFood(string name, string details) 
        { 
            this.name = name;
            this.details = details;
        }
        //empty contructor
        public FoodMenuAndOrderFood()
        {

        }
        

        // create a connection for use
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

        public void LoadMenu(DataGridView dataGridView)
        {
            Query = "SELECT foodCategory, foodName, foodPrice FROM food_menu ORDER BY foodCategory DESC";
            FillData(dataGridView, Query);
        }

        public void SearchBar(DataGridView dataGridView, string a)
        {
            Query = $"SELECT foodCategory, foodName, foodPrice FROM food_menu WHERE foodName LIKE '%{a}%' ORDER BY foodCategory DESC";
            FillData(dataGridView, Query);
        }

        public void MainCourse(DataGridView dataGridView)
        {
            Query = "SELECT foodCategory, foodName, foodPrice FROM food_menu WHERE foodCategory = 'Main Course'";
            FillData(dataGridView, Query);
        }

        public void Beverages(DataGridView dataGridView)
        {
            Query = "SELECT foodCategory, foodName, foodPrice FROM food_menu WHERE foodCategory = 'Beverages'";
            FillData(dataGridView, Query);
        }

        public void Dessert(DataGridView dataGridView)
        {
            Query = "SELECT foodCategory, foodName, foodPrice FROM food_menu WHERE foodCategory = 'Dessert'";
            FillData(dataGridView, Query);
        }

        public void Appetizers(DataGridView dataGridView)
        {
            Query = "SELECT foodCategory, foodName, foodPrice FROM food_menu WHERE foodCategory = 'Appetizers'";
            FillData(dataGridView, Query);
        }
        
        public void AddOrder()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Query = "INSERT INTO order_list (customerName, orderDetails, orderStatus) VALUES (@Name, @Details, 'Pending')";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    connection.Open();

                    //to change @ in the query to parameter that store data from user control
                    command.Parameters.AddWithValue("@name", name.ToLower());
                    command.Parameters.AddWithValue("@Details", details);

                    //try execute the command
                    try
                    {
                        //to execute the query
                        command.ExecuteNonQuery();
                    }
                    //show error message if error occurs
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error, {ex.Message}");
                    }
                        
                }
            }
        }
    }

    public class ViewStatus
    {
        string Query;
        DataGridView dataGridView;
        string cusName;

        //create an object to borrow method from another class
        FoodMenuAndOrderFood borrow = new FoodMenuAndOrderFood();
        public ViewStatus(DataGridView dataGridView, string customerName)
        {
            this.dataGridView = dataGridView;
            this.cusName = customerName;
        }
        public void ViewOrderStatus()
        {
            Query = $"SELECT customerName, orderDetails, orderStatus FROM order_list WHERE customerName LIKE '%{cusName}%'";
            borrow.FillData(dataGridView, Query);
        }
        public void ViewReservationStatus()
        {
            Query = $"SELECT customerName, [description], [status], numberofguests, reserveDate, reserveType FROM customer_reservation WHERE customerName LIKE '{cusName}'";
            borrow.FillData(dataGridView, Query);
        }
    }
    
    public class SendFeedback
    {
        string name;
        string feedback;
        public SendFeedback(string name, string feedback) 
        { 
            this.name = name;
            this.feedback = feedback;
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        string Query;
        public void sendFeedback()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Query = "INSERT INTO customer_feedbacks (customer_name, feedback_message, read_status) VALUES (@Name, @Feedback, 'unread')";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    connection.Open();

                    //to change @ in the query to parameter that store data from user control
                    command.Parameters.AddWithValue("@name", name.ToLower());
                    command.Parameters.AddWithValue("@Feedback", feedback);

                    //try execute the command
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    //show error message if error occurs
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error, {ex.Message}");
                    }
                }
            }
        }
    }
}
