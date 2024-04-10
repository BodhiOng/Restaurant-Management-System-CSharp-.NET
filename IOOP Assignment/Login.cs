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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtbxUsername.Text;
            string password = txbxPassword.Text;

            string connectionString = Properties.Settings.Default.DRDatabaseConnectionString;

            string loginQuery = "SELECT * FROM login_database WHERE username = @Username AND password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(loginQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {   
                                    reader.Read();

                                    string role = reader["role"].ToString();
                                    if (role.ToLower() == "admin")
                                    {
                                        Admin adminForm = new Admin();
                                        adminForm.Show();

                                        reader.Close();

                                        string logStatusQuery = "INSERT INTO log_status (username, role) VALUES (@Username, 'admin')";

                                        using (SqlCommand logStatusCommand = new SqlCommand(logStatusQuery, connection, transaction))
                                        {
                                            logStatusCommand.Parameters.AddWithValue("@Username", username);
                                            logStatusCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password");
                                }
                            }
                        }

                        transaction.Commit();
                    }

                    catch (Exception ex) 
                    { 
                        transaction.Rollback();
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
