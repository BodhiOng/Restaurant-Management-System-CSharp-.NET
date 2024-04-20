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

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("@Username", username.ToLower());
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role.ToLower());

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            MessageBox.Show("User successfully added");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }

            public bool CheckForExistingUsers(string username)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string checkQuery = "SELECT COUNT(*) FROM login_database WHERE username = @Username";

                    using (SqlCommand cmd = new SqlCommand(checkQuery, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("@Username", username.ToLower());

                        object result = cmd.ExecuteScalar();

                        // Username doesn't exist yet
                        if (result != null && result != DBNull.Value)
                        {
                            int count;
                            if (int.TryParse(result.ToString(), out count))
                            {
                                return count > 0;
                            }
                        }

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

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string deleteQuery = "DELETE FROM login_database WHERE username = @Username";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("@Username", username.ToLower());

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            MessageBox.Show("User successfully deleted");
                        }

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

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("@Username", username.ToLower());
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role.ToLower());

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            MessageBox.Show("User successfully updated");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public AdminManageUsers()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM login_database;", connection);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dgv_logindatabase.DataSource = dtbl;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string un = txtbx_username.Text;
            string pw = txtbx_password.Text;
            string role = cmbbx_role.Text;

            ManageUsersFunctionalities adminFunc = new ManageUsersFunctionalities();
            adminFunc.AddUser(un, pw, role);
            RefreshDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string un = txtbx_username.Text;

            ManageUsersFunctionalities adminfunc = new ManageUsersFunctionalities();
            adminfunc.DeleteUser(un);
            RefreshDataGridView();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string un = txtbx_username.Text;
            string pw = txtbx_password.Text;
            string role = cmbbx_role.Text;

            ManageUsersFunctionalities adminFunc = new ManageUsersFunctionalities();
            adminFunc.UpdateUser(un, pw, role);
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM login_database;", connection);
                adapter.Fill(dtbl);
            }

            dgv_logindatabase.DataSource = dtbl;
        }
    }
}
