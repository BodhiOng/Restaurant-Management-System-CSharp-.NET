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
