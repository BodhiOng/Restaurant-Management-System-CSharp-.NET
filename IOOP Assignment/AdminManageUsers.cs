using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace IOOP_Assignment
{
    public partial class AdminManageUsers : UserControl
    {
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
