using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Closes Login window
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Catches user input into respective text boxes
            string username = txtbxUsername.Text;
            string password = txbxPassword.Text;

            // Declares connection string and query to perform login
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            string loginQuery = "SELECT * FROM login_database WHERE username = @Username AND password = @Password";

            // Starting connection for reading purposes
            using (connection)
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(loginQuery, connection))
                {   
                    // Replaces the string bits with user-inputted valiues
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        // STarts reader to read content in SQL table
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Username and password does exist in the table
                            if (reader.HasRows)
                            {
                                // Attempts to read "role" after passing the matching username-password test
                                reader.Read();
                                string role = reader["role"].ToString();

                                // Selection logic that will lead user to their role-dedicated form
                                if (role.ToLower() == "admin")
                                {
                                    Admin adminForm = new Admin();
                                    adminForm.ShowDialog();
                                }
                            }
                            // Username and password doesn't exist in the table or nothing inputted by user
                            else
                            {
                                MessageBox.Show("Invalid username or password");
                            }
                        }
                    }
                    // Exception handling in case of errors
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
