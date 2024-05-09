using System;
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
    public partial class UpdateProfile : UserControl
    {
        public class UpdateProfileFunctionalities
        {
            // Declares connection string & variables for constructor usage
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            string UN, PW, newUN, newPW;

            // Initializes the a constructor, object with user information
            public UpdateProfileFunctionalities(string username, string password, string newUsername, string newPassword)
            {
                this.UN = username;
                this.PW = password;
                this.newUN = newUsername;
                this.newPW = newPassword;
            }

            public void NewUNAndPW()
            {
                // Checks whether user filled the information that should be provided (old UN & PW)
                if (string.IsNullOrEmpty(UN) || string.IsNullOrEmpty(PW))
                {
                    MessageBox.Show("Current username or password cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // User inputted neither new username nor password
                if (string.IsNullOrEmpty(newUN) && string.IsNullOrEmpty(newPW))
                {
                    return;
                }

                // Checks whether user with corresponding password exist or not
                if (!CheckUserExistence())
                {
                    MessageBox.Show("Current username or password doesn't exist in the database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Declares queries (for one of them to get executed)
                    string modifyBothQuery = "UPDATE login_database SET username = @NewUN, password = @NewPW WHERE username LIKE @OldUN;";
                    string modifyUsernameOnlyQuery = "UPDATE login_database SET username = @NewUN WHERE username LIKE @OldUN;";
                    string modifyPasswordOnlyQuery = "UPDATE login_database SET password = @NewPW WHERE username LIKE @OldUN;";

                    // Only username is modified
                    if (string.IsNullOrEmpty(newPW))
                    {
                        using(SqlCommand cmd = new SqlCommand(modifyUsernameOnlyQuery, connection))
                        {
                            // Starts connection
                            connection.Open();

                            // Replaces string with user-inputted values
                            cmd.Parameters.AddWithValue("@NewUN", newUN);
                            cmd.Parameters.AddWithValue("@OldUN", UN);

                            try
                            {
                                // Query executed and username of user is modified
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Username successfully modified");
                            }
                            // Exception handling to display potential errors
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                    // Only password is modified
                    else if (string.IsNullOrEmpty(newUN))
                    {
                        using (SqlCommand cmd = new SqlCommand(modifyPasswordOnlyQuery, connection))
                        {
                            // Starts connection
                            connection.Open();

                            // Replaces string with user-inputted values
                            cmd.Parameters.AddWithValue("@NewPW", newPW);
                            cmd.Parameters.AddWithValue("@OldUN", UN);

                            try
                            {
                                // Query executed and password of user is modified
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Password successfully modified");
                            }
                            // Exception handling to display potential errors
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                    // Both username & password are modified
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(modifyBothQuery, connection))
                        {
                            // Starts connection
                            connection.Open();

                            // Replaces string with user-inputted values
                            cmd.Parameters.AddWithValue("@NewUN", newUN);
                            cmd.Parameters.AddWithValue("@NewPW", newPW);
                            cmd.Parameters.AddWithValue("@OldUN", UN);

                            try
                            {
                                // Query executed, username & password of user is modified
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Username & password successfully modified");
                            }
                            // Exception handling to display potential errors
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                }
            }

            public bool CheckUserExistence()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Declare query to check user with a specified password existence
                    string checkQuery = "SELECT COUNT(*) FROM login_database WHERE username = @Username AND password = @Password";

                    // Uses command to execute query
                    using (SqlCommand cmd = new SqlCommand(checkQuery, connection))
                    {
                        // Starts connection
                        connection.Open();

                        cmd.Parameters.AddWithValue("@Username", UN);
                        cmd.Parameters.AddWithValue("@Password", PW);

                        // Stores the single value received as an object after executing query
                        object result = cmd.ExecuteScalar();

                        // Username with corresponding password does exist
                        if (result != null)
                        {
                            // Parses object 'result' to string, then to int
                            if (int.TryParse(result.ToString(), out int count))
                            {
                                // Essentially similar to "return true" if count is 1
                                return count > 0;
                            }
                        }
                        // Username with corresponding password doesn't exist
                        return false;
                    }
                }
            }
        
            public void DeactivateAccount()
            {
                // Checks whether user filled the information that should be provided (old UN & PW)
                if (string.IsNullOrEmpty(UN) || string.IsNullOrEmpty(PW))
                {
                    MessageBox.Show("Current username or password cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                                
                // Checks whether user with corresponding password exist or not
                if (!CheckUserExistence())
                {
                    MessageBox.Show("Current username or password doesn't exist in the database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Declare query to execute
                    string deleteQuery = "DELETE FROM login_database WHERE username LIKE @Username AND password LIKE @Password;";

                    // Execute query using command
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        // Starts connection
                        connection.Open();

                        // Replaces string with user inputted values
                        cmd.Parameters.AddWithValue("@Username", UN);
                        cmd.Parameters.AddWithValue("@Password", PW);

                        try
                        {
                            // Query executed and user is deleted
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("User successfully deleted");
                        }
                        // Exception handling to display potential errors
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        
            public void ForgetPassword()
            {
                // Checks whether user filled the information that should be provided (old UN & PW)
                if (string.IsNullOrEmpty(UN) || string.IsNullOrEmpty(PW))
                {
                    MessageBox.Show("Current username or password cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Checks whether user with corresponding password exist or not
                if (!CheckUserExistence())
                {
                    MessageBox.Show("Current username or password doesn't exist in the database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Declare query to execute
                    string setPasswordQuery = "UPDATE login_database SET password = 'password' WHERE username LIKE @Username AND password LIKE @Password;";

                    // Execute query using command
                    using (SqlCommand cmd = new SqlCommand(setPasswordQuery, connection))
                    {
                        // Starts connection
                        connection.Open();

                        // Replaces string with user inputted values
                        cmd.Parameters.AddWithValue("@Username", UN);
                        cmd.Parameters.AddWithValue("@Password", PW);

                        try
                        {
                            // Query executed and user is deleted
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Your password is set to \"password\"\n*You can now update your password again");
                        }
                        // Exception handling to display potential errors
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

            }
        }

        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Catch all of the user inputs and store it in a variable
            string currentUN = txtbx_username.Text;
            string currentPW = txtbx_password.Text;
            string updatedUN = txtbx_newusername.Text;
            string updatedPW = txtbx_newpassword.Text;

            // Object instantiation and method calling
            UpdateProfileFunctionalities functionalities = new UpdateProfileFunctionalities(currentUN, currentPW, updatedUN, updatedPW);
            functionalities.NewUNAndPW();
        }

        private void linklbl_deactivateacc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Catch all of the user inputs and store it in a variable
            string currentUN = txtbx_username.Text;
            string currentPW = txtbx_password.Text;

            // Object instantiation and method calling
            UpdateProfileFunctionalities functionalities = new UpdateProfileFunctionalities(currentUN, currentPW, null, null);
            functionalities.DeactivateAccount();
        }

        private void linklbl_forgetpw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Catch all of the user inputs and store it in a variable
            string currentUN = txtbx_username.Text;
            string currentPW = txtbx_password.Text;

            // Object instantiation and method calling
            UpdateProfileFunctionalities functionalities = new UpdateProfileFunctionalities(currentUN, currentPW, null, null);
            functionalities.ForgetPassword();
        }
    }
}
