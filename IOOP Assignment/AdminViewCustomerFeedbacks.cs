using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class AdminViewCustomerFeedbacks : UserControl
    {
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

        public AdminViewCustomerFeedbacks()
        {
            InitializeComponent();
        }

        // Object instantiation
        ViewFeedbackFunctionalities functionalities = new ViewFeedbackFunctionalities();

        private void radbtn_unread_CheckedChanged(object sender, EventArgs e)
        {
            // Method calling
            functionalities.ViewMarkedUnRead(dgv_viewfeedback);
            RefreshDataGridView("unread");
        }

        private void radbtn_read_CheckedChanged(object sender, EventArgs e)
        {
            // Method calling
            functionalities.ViewMarkedRead(dgv_viewfeedback);
            RefreshDataGridView("read");
        }

        private void btn_markread_Click(object sender, EventArgs e)
        {
            string selectedId = txtbx_selectedid.Text;
            string markAs = "read";

            functionalities.MarkAsWhat(selectedId, markAs);
        }

        private void btn_markunread_Click(object sender, EventArgs e)
        {
            string selectedId = txtbx_selectedid.Text;
            string markAs = "unread";

            functionalities.MarkAsWhat(selectedId, markAs);
        }


        // Declare connection string for usage
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public void RefreshDataGridView(string viewAs)
        {
            // New table to fill 
            DataTable dtbl = new DataTable();

            // Establishes connection to SQL database (and the table too)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Starts connection 
                connection.Open();

                // Fills table with refreshed data of customer_feedbacks (SQL table)
                // User happens to be using view by marked as 'read'
                if (viewAs == "read")
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customer_feedbacks WHERE read_status = 'read'", connection);
                    adapter.Fill(dtbl);
                }
                // User happens to be using view by marked as 'unread'
                else
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customer_feedbacks WHERE read_status = 'unread'", connection);
                    adapter.Fill(dtbl);
                }

            }

            // Displays the modified/refreshed data too the DataGridView inside the User Control
            dgv_viewfeedback.DataSource = dtbl;
        }

        private void btn_showmsg_Click(object sender, EventArgs e)
        {
            string selectedId = txtbx_selectedid.Text;

            functionalities.ShowMessage(selectedId, richtxtbx_displaymsg);
        }
    }
}       
