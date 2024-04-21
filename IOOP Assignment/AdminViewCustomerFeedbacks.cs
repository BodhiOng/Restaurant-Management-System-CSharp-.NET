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
        }

        public AdminViewCustomerFeedbacks()
        {
            InitializeComponent();
        }

        // Object instantiation
        ViewFeedbackFunctionalities functionalities = new ViewFeedbackFunctionalities();

        private void radbtn_unread_CheckedChanged(object sender, EventArgs e)
        {
            functionalities.ViewMarkedUnRead(dgv_viewfeedback);
        }

        private void radbtn_read_CheckedChanged(object sender, EventArgs e)
        {
            functionalities.ViewMarkedRead(dgv_viewfeedback);
        }

        private void dgv_viewfeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
