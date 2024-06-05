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
        public AdminViewSalesReport()
        {
            InitializeComponent();
        }

        // Object instantiation
        ViewSalesReportFunctionality functionality = new ViewSalesReportFunctionality();

        private void btn_viewbycategory_Click(object sender, EventArgs e)
        {
            string byCategoryQuery = "SElECT month, category_name, month_category_sales FROM category_sales";

            // Method calling
            functionality.ViewByWhat(byCategoryQuery, dgv_viewsalesreport);
            functionality.RefreshDataGridView(byCategoryQuery, dgv_viewsalesreport);
        }

        private void btn_viewbychef_Click(object sender, EventArgs e)
        {
            string byChefQuery = "SElECT month, chef_name, month_chef_sales FROM chef_sales";

            // Method calling
            functionality.ViewByWhat(byChefQuery, dgv_viewsalesreport);
            functionality.RefreshDataGridView(byChefQuery, dgv_viewsalesreport);
        }

        private void btn_viewbymonth_Click(object sender, EventArgs e)
        {
            string byMonthQuery = "UPDATE ms\r\nSET ms.month_sales = (\r\n    SELECT COALESCE(SUM(cs.month_category_sales), 0)\r\n    FROM category_sales cs\r\n    WHERE cs.month = ms.month_name\r\n  )\r\n  +\r\n  (\r\n    SELECT COALESCE(SUM(chs.month_chef_sales), 0)\r\n    FROM chef_sales chs\r\n    WHERE chs.month = ms.month_name\r\n  )\r\nFROM monthly_sales ms;\r\n\r\nSELECT month_name, month_sales FROM monthly_sales ORDER BY id;";
            
            // Method calling
            functionality.ViewByWhat(byMonthQuery, dgv_viewsalesreport);
            functionality.RefreshDataGridView(byMonthQuery, dgv_viewsalesreport);
        }
    }
}
