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
    public partial class AdminViewSalesReport : UserControl
    {
        public class ViewSalesReportFunctionality
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            public void ViewByWhat(string query, DataGridView dataGridView)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    dataGridView.DataSource = dtbl;
                }
            }

            public void RefreshDataGridView(string query, DataGridView dataGridView)
            {
                DataTable dtbl = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dtbl);
                }

                dataGridView.DataSource = dtbl;
            }
        }

        public AdminViewSalesReport()
        {
            InitializeComponent();
        }

        private void btn_viewbycategory_Click(object sender, EventArgs e)
        {
            string byCategoryQuery = "SElECT month, category_name, month_category_sales FROM category_sales";

            ViewSalesReportFunctionality functionality = new ViewSalesReportFunctionality();
            functionality.ViewByWhat(byCategoryQuery, dgv_viewsalesreport);
            functionality.RefreshDataGridView(byCategoryQuery, dgv_viewsalesreport);
        }

        private void btn_viewbychef_Click(object sender, EventArgs e)
        {
            string byChefQuery = "SElECT month, chef_name, month_chef_sales FROM chef_sales";

            ViewSalesReportFunctionality functionality = new ViewSalesReportFunctionality();
            functionality.ViewByWhat(byChefQuery, dgv_viewsalesreport);
            functionality.RefreshDataGridView(byChefQuery, dgv_viewsalesreport);
        }

        private void btn_viewbymonth_Click(object sender, EventArgs e)
        {
            string byMonthQuery = "SElECT * FROM monthly_sales";
            
            ViewSalesReportFunctionality functionality = new ViewSalesReportFunctionality();
            functionality.ViewByWhat(byMonthQuery, dgv_viewsalesreport);
            functionality.RefreshDataGridView(byMonthQuery, dgv_viewsalesreport);
        }
    }
}
