using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public class ManageUsersFunctionalities
    {
        // Declares connection string for usage
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public void AddUser(string username, string password, string role)
        {

            // Checks in case user doesn't input anything in the username, password, or role
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Username, password, and role cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Checks whether username inputted had existed in "username" column or not
            if (CheckForExistingUsers(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Adds user to database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO login_database (username, password, role) VALUES (@Username, @Password, @Role)";

                // Uses command to execute query into table
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    // Starts connection
                    connection.Open();

                    // Replaces string with the values inputted by user
                    cmd.Parameters.AddWithValue("@Username", username.ToLower());
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role.ToLower());

                    try
                    {
                        // Query executed and user is added
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User successfully added");
                    }
                    // Exception handling to display potential errors
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public bool CheckForExistingUsers(string username)
        {
            // Checks for existing users 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM login_database WHERE username = @Username";

                // Uses command to execute query into table
                using (SqlCommand cmd = new SqlCommand(checkQuery, connection))
                {
                    // Starts connection
                    connection.Open();

                    // Replaces string with user inputted values
                    cmd.Parameters.AddWithValue("@Username", username.ToLower());

                    // Stores the single value received as an object after executing query
                    object result = cmd.ExecuteScalar();

                    // Username doesn't exist yet
                    if (result != null)
                    {
                        // Declares count and parses it from object to string to integer
                        int count;
                        if (int.TryParse(result.ToString(), out count))
                        {
                            // Essentially similar to "return true" if count is 1
                            return count > 0;
                        }
                    }

                    // Username does exist
                    return false;
                }
            }
        }

        public void DeleteUser(string username)
        {
            // Checks in case user doesn't input anything into username 
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Checks whether username inputted had existed in "username" column or not
            if (!CheckForExistingUsers(username))
            {
                MessageBox.Show("User doesn't exist, cannot delete a user that doesn't exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Deletes user
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM login_database WHERE username = @Username";

                // Uses command to execute query into the table
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    // Starts connection
                    connection.Open();

                    // Replaces string with user-inputted values
                    cmd.Parameters.AddWithValue("@Username", username.ToLower());

                    try
                    {
                        // Query executed and user is deleted
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User successfully deleted");
                    }
                    // Exception handling in case of errors
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        public void UpdateUser(string username, string password, string role)
        {

            // Checks in case user doesn't input anything in the username, password, or role
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Username, password, and role cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Checks whether username inputted had existed in "username" column or not
            if (!CheckForExistingUsers(username))
            {
                MessageBox.Show("User doesn't exist, cannot update a user that doesn't exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Updates user to database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "BEGIN TRANSACTION; DELETE FROM login_database WHERE username = @Username; INSERT INTO login_database (username, password, role) VALUES (@Username, @Password, @Role); COMMIT TRANSACTION;";

                // Uses command to execute query into the database 
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    // Starts connection
                    connection.Open();

                    // Replaces string with user-inputted values
                    cmd.Parameters.AddWithValue("@Username", username.ToLower());
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role.ToLower());

                    try
                    {
                        // Query executed and user updated
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User successfully updated");
                    }
                    // Exception handling in case of errors
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }

    public class ViewSalesReportFunctionality
    {
        // Declares connection string for usage
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public void ViewByWhat(string query, DataGridView dataGridView)
        {
            // View by specific requirement
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Starts connection
                connection.Open();

                // Makes table to fill it with data from the actual SQL table
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                // Display data from SQL table into DataGridView inside of User Control
                dataGridView.DataSource = dtbl;
            }
        }

        public void RefreshDataGridView(string query, DataGridView dataGridView)
        {
            // Makes new table
            DataTable dtbl = new DataTable();

            // Refreshes data in DataGridView
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Starts connection
                connection.Open();

                // Extracts data to table from SQL tablr
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dtbl);
            }

            // Displays refreshed data to DataGridView
            dataGridView.DataSource = dtbl;
        }
    }

    public class ViewFeedbackFunctionalities
    {
        // Declares connection string & query for usage
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        string viewQuery;

        public void ViewMarkedUnRead(DataGridView dataGridView)
        {
            viewQuery = "SELECT * FROM customer_feedbacks WHERE read_status = 'unread'";

            // View by feedbacks that are marked 'unread'
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Starts connection
                connection.Open();

                // Makes table to fill it with data from the actual SQL table
                SqlDataAdapter adapter = new SqlDataAdapter(viewQuery, connection);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                // Display data from SQL table into DataGridView inside of User Control
                dataGridView.DataSource = dtbl;
            }
        }

        public void ViewMarkedRead(DataGridView dataGridView)
        {
            viewQuery = "SELECT * FROM customer_feedbacks WHERE read_status = 'read'";

            // View by feedbacks that are marked 'read'
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Starts connection
                connection.Open();

                // Makes table to fill it with data from the actual SQL table
                SqlDataAdapter adapter = new SqlDataAdapter(viewQuery, connection);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                // Display data from SQL table into DataGridView inside of User Control
                dataGridView.DataSource = dtbl;
            }
        }

        public void MarkAsWhat(string feedback_id, string whatToMarkAs)
        {

            // Checks whether feedback_id text box is filled or not
            if (string.IsNullOrEmpty(feedback_id))
            {
                MessageBox.Show("Selected feedback_id cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Checks whether inputted feedback_id exists in the table or not
            if (!CheckFeedbackExistence(feedback_id))
            {
                MessageBox.Show("Selected feedback_id doesn't exist in the table", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mark feedback as read/unread
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Declare query to update into tbe table
                string updateQuery = "UPDATE customer_feedbacks SET read_status = @ReadStatus WHERE feedback_id = @FeedbackID";

                // Uses command to execute query
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    // Starts the connection
                    connection.Open();

                    // Type casting
                    int feedbackID = int.Parse(feedback_id);

                    // Replace string with user-inputted values
                    cmd.Parameters.AddWithValue("@ReadStatus", whatToMarkAs);
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);

                    try
                    {
                        // Query executed and user is added
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Feedback read status successfully updated");
                    }
                    // Exception handling to display potential errors
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }


        }
        public bool CheckFeedbackExistence(string f_id)
        {
            try
            {
                // Type casting
                int feedback_id = int.Parse(f_id);

                // Checks for feedback_id existence
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Declare query to check feedback_id existence
                    string checkQuery = "SELECT COUNT(*) FROM customer_feedbacks WHERE feedback_id = @FeedbackID";

                    // Uses command to execute query
                    using (SqlCommand cmd = new SqlCommand(checkQuery, connection))
                    {
                        // Starts connection
                        connection.Open();

                        // Replaces string with user value
                        cmd.Parameters.AddWithValue("@FeedbackID", feedback_id);

                        // Stores the single value received as an object after executing query
                        object result = cmd.ExecuteScalar();

                        // feedback_id does exist
                        if (result != null)
                        {
                            // Parses object 'result' to string, then to int
                            if (int.TryParse(result.ToString(), out int count))
                            {
                                // Essentially similar to "return true" if count is 1
                                return count > 0;
                            }
                        }
                        // feedback_id doesn't exist
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input, please only enter integers for feedback_id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ShowMessage(string feedbackID, RichTextBox rtb)
        {
            // Checks whether feedback_id text box is filled or not
            if (string.IsNullOrEmpty(feedbackID))
            {
                MessageBox.Show("Selected feedback_id cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Checks whether inputted feedback_id exists in the table or not
            if (!CheckFeedbackExistence(feedbackID))
            {
                MessageBox.Show("Selected feedback_id doesn't exist in the table", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Declare query to search for message
                string searchQuery = "SELECT feedback_message FROM customer_feedbacks WHERE feedback_id = @FeedbackID;";
                // Search for feedback message
                using (SqlCommand cmd = new SqlCommand(searchQuery, connection))
                {
                    // Starts the connection
                    connection.Open();

                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);

                    // Store the message in a string
                    string feedbackMessage = (string)cmd.ExecuteScalar();

                    // Displays the message in the rich textbox
                    rtb.Text = feedbackMessage;
                }
            }
        }
    }
}