using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class AdminManageUsers : UserControl
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

        // Declares connection string for usage
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public AdminManageUsers()
        {
            InitializeComponent();

            // Refreshes table from the booting up of the User Control
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Starts connection
                connection.Open();

                // Links query wih connection
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT username, role FROM login_database;", connection);

                // Extracts current data to table from the actual SQL table (login_database)
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                // Displays the modified/refreshed data too the DataGridView inside the User Control
                dgv_logindatabase.DataSource = dtbl;       
            }
        }

        // Object instantiation for method calling in button-clicks event handling
        ManageUsersFunctionalities functionalities = new ManageUsersFunctionalities();

        private void btn_add_Click(object sender, EventArgs e)
        {   
            // Catches user inputs into a string variable
            string un = txtbx_username.Text;
            string pw = txtbx_password.Text;
            string role = cmbbx_role.Text;

            // Method calling
            functionalities.AddUser(un, pw, role);
            RefreshDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Catches user input into a string variable
            string un = txtbx_username.Text;

            // Method calling
            functionalities.DeleteUser(un);
            RefreshDataGridView();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Catches user inputs into a string variable
            string un = txtbx_username.Text;
            string pw = txtbx_password.Text;
            string role = cmbbx_role.Text;

            // Method calling
            functionalities.UpdateUser(un, pw, role);
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {   
            // New table to fill 
            DataTable dtbl = new DataTable();

            // Establishes connection to SQL database (and the table too)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Starts connection 
                connection.Open();

                // Fills table with refreshed data of login_database (SQL table)
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT username, role FROM login_database;", connection);
                adapter.Fill(dtbl);
            }

            // Displays the modified/refreshed data too the DataGridView inside the User Control
            dgv_logindatabase.DataSource = dtbl;
        }

        private void btn_refreshtbl_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
