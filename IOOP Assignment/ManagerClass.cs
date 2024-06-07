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
using Microsoft.Identity.Client;
using System.Drawing.Text;
using System.Collections;
using System.Data.Common;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens;
using System.Runtime.InteropServices;

namespace IOOP_Assignment
{
    public class ManagerFunct
    {
        string menu;
        string category;
        decimal price;
        string name;
        DateTime date;
        string type;
        int numguests;
        string status;
        string desc;
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";


        //Manage Reservation & Menu
        public ManagerFunct()
        {

        }

        //Add Menu
        public ManagerFunct(string menu, string cat, decimal price)
        {
            this.menu = menu;
            this.category = cat;
            this.price = price;
        }

        //Add Reservation
        public ManagerFunct(string name, DateTime date, string type, int numguests, string status = "Pending", string desc = "")
        {
            this.name = name.ToLower();
            this.date = date;
            this.type = type;
            this.numguests = numguests;
            this.status = status;
            this.desc = desc;
        }

        //Get reservation data from table
        public string[] GetReservation(DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            string[] data = new string[7];
            DataGridViewRow row = dataGrid.Rows[rowindex];

            //append the customer data into string array
            data.SetValue(row.Cells["reservationID"].Value.ToString(), 0);
            data.SetValue(row.Cells["customerName"].Value.ToString(), 1);
            data.SetValue(row.Cells["reserveDate"].Value.ToString(), 2);
            data.SetValue(row.Cells["reserveType"].Value.ToString(), 3);
            data.SetValue(row.Cells["numberofguests"].Value.ToString(), 4);
            data.SetValue(row.Cells["status"].Value.ToString(), 5);

            //check if the description is present
            if (row.Cells["description"] != null)
            {
                data.SetValue(row.Cells["description"].Value.ToString(), 6);
            }
            //avoid null data getting enterred into the array
            else
            {
                data.SetValue("-", 6);
            }

            //return the array
            return data;
        }

        //Get reservation data given reservationID
        public string[] GetReservation(DataGridView dataGrid, string id)
        {
            String search = id;
            int rowindex = 0;
            foreach (DataGridViewRow searchrow in dataGrid.Rows)
            {
                if (searchrow.Cells["reservationID"].Value != null)
                {
                    if (searchrow.Cells["reservationID"].Value.ToString().Equals(search))
                    {
                        rowindex = searchrow.Index;
                        break;
                    }
                }
            }

            //get each row data
            string[] data = new string[7];
            DataGridViewRow row = dataGrid.Rows[rowindex];

            //append the customer data into string array
            data.SetValue(row.Cells["reservationID"].Value.ToString(), 0);
            data.SetValue(row.Cells["customerName"].Value.ToString(), 1);
            data.SetValue(row.Cells["reserveDate"].Value.ToString(), 2);
            data.SetValue(row.Cells["reserveType"].Value.ToString(), 3);
            data.SetValue(row.Cells["numberofguests"].Value.ToString(), 4);
            data.SetValue(row.Cells["status"].Value.ToString(), 5);

            //check if the description is present
            if (row.Cells["description"] != null)
            {
                data.SetValue(row.Cells["description"].Value.ToString(), 6);
            }
            //avoid null data getting enterred into the array
            else
            {
                data.SetValue("-", 6);
            }

            //return the array
            return data;
        }

        //Get menu from database
        public string[] GetMenu(DataGridView dataGrid)
        {
            //get each row data
            int rowindex = 0;
            string[] data = new string[6];
            foreach (DataGridViewCell cell in dataGrid.SelectedCells)
            {
                rowindex = cell.RowIndex;
            }
            DataGridViewRow row = dataGrid.Rows[rowindex];

            //append the customer data into string array
            data.SetValue(row.Cells["foodID"].Value.ToString(), 0);
            data.SetValue(row.Cells["foodName"].Value.ToString(), 1);
            data.SetValue(row.Cells["foodPrice"].Value.ToString(), 2);
            data.SetValue(row.Cells["foodCategory"].Value.ToString(), 3);

            //return the array
            return data;
        }

        //Insert the reservation into database
        public void AddReservation()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string sqlquery = $"INSERT INTO customer_reservation " +
                    $"(customerName, reserveDate, reserveType, numberofguests, status, description) " +
                    $"VALUES (@name, @date, @type, @num, @status, @desc)";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@num", numguests);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@desc", desc);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Update the reservation on the database
        public void UpdateReservation(int id, DateTime dt, string type, int num, string stat, string desc)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string sqlquery = "UPDATE customer_reservation " +
                    "SET reserveDate=@dt, reserveType=@type, numberofguests=@num, status=@stat, description=@desc " +
                    "WHERE reservationID=@id";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("type", type);
                cmd.Parameters.AddWithValue("@num", num);
                cmd.Parameters.AddWithValue("@stat", stat);
                cmd.Parameters.AddWithValue("@desc", desc);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data updated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Delete reservation from database
        public void DeleteReservation(DataGridView dataGrid)
        {
            //get the customer name
            int rowindex = 0;
            foreach (DataGridViewCell cell in dataGrid.SelectedCells)
            {
                rowindex = cell.RowIndex;
            }
            DataGridViewRow row = dataGrid.Rows[rowindex];
            string name = row.Cells["customerName"].Value.ToString();
            DateTime date = (DateTime)row.Cells["reserveDate"].Value;
            //make the query
            using (SqlConnection con = new SqlConnection(constring))
            {
                string sqlquery = "DELETE FROM customer_reservation WHERE customerName = @nm AND reserveDate = @date";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@date", date);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record has been removed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        //Get list of username and their number of reservations from database
        public void FillUsername(DataGridView dataGrid, string Name = "_")
        {
            name = Name;
            if (name.Length == 0 || name == "Search Name...")
            {
                //assign a wild card character to prevent null character in query
                name = "_";
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    string sqlquery = $"SELECT login_database.username AS [Name], " +
                        $"COUNT(customer_reservation.reservationID) AS [Reservations] " +
                        $"FROM login_database LEFT JOIN customer_reservation " +
                        $"ON customer_reservation.customerName = login_database.username " +
                        $"WHERE login_database.username LIKE '%{name}%' GROUP BY login_database.username";
                    SqlCommand cmd = new SqlCommand(sqlquery, conn);
                    conn.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    dataGrid.ReadOnly = true;
                    dataGrid.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Check whether there is the same reservation on the database
        public bool CheckReservation()
        {
            string check = string.Empty;
            using (SqlConnection con = new SqlConnection(constring))
            {
                string sqlquery = $"SELECT customerName FROM customer_reservation " +
                    $"WHERE customerName = @name AND " +
                    $"EXISTS (SELECT customerName FROM customer_reservation WHERE customerName LIKE @name AND reserveDate = @date);";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                try
                {
                    con.Open();
                    check = (string)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (string.IsNullOrEmpty(check))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //Insert new menu into database
        public void AddMenu()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string sqlquery = "INSERT INTO food_menu (foodName, foodPrice, foodCategory)" +
                    "VALUES (@nm, @pr, @cat)";
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@nm", menu);
                cmd.Parameters.AddWithValue("@pr", price);
                cmd.Parameters.AddWithValue("@cat", category);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Menu Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Update the menu with new details into the database
        public void UpdateMenu(int id, string nm, decimal pr, string cat)
        {
            string sqlquery = "UPDATE food_menu SET " +
                            "foodName = @nm, " +
                            "foodPrice = @pr, " +
                            "foodCategory = @cat " +
                            "WHERE foodID = @id";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nm", nm);
                cmd.Parameters.AddWithValue("@pr", pr);
                cmd.Parameters.AddWithValue("@cat", cat);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Menu updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Delete the selected menu from database
        public void DeleteMenu(DataGridView dataGrid)
        {
            int rowindex = 0;
            foreach (DataGridViewCell cell in dataGrid.SelectedCells)
            {
                rowindex = cell.RowIndex;
            }
            DataGridViewRow row = dataGrid.Rows[rowindex];
            int id = (int)row.Cells["foodID"].Value;
            string sqlquery = "DELETE FROM food_menu WHERE foodID = @id";
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Menu Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Check whether the menu exists or not
        public bool CheckMenu()
        {
            bool check = false;
            string data = string.Empty;
            string sqlquery = "SELECT foodName FROM food_menu WHERE foodName = @nm";
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.AddWithValue("@nm", menu);

                try
                {
                    con.Open();
                    data = (string)cmd.ExecuteScalar();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (data.Length != 0)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

    }

    //Class for populating the DataGridView
    public class View
    {
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DRDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        private ManagerViewReservation managerReservation;
        private ManagerManageMenu managerMenu;

        //Constructor to retrieve reservation data
        public View(ManagerViewReservation managerViewReservation)
        {
            this.managerReservation = managerViewReservation;
        }

        //Constructor to retrieve menu data
        public View(ManagerManageMenu managerManageMenu)
        {
            this.managerMenu = managerManageMenu;
        }

        //Get the data from database into the DataGridView
        public void filldata(DataGridView dataGrid)
        {
            try
            {
                //Starts the connection
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    //Get the query string from the function
                    string sqlquery = getquery();
                    //Define the SQL command
                    SqlCommand cmd = new SqlCommand(sqlquery, conn);
                    conn.Open();
                    //Define the data adapter
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    //Define the dataset
                    DataTable dt = new DataTable();
                    //Copy the data from query to dataset
                    sqlDataAdapter.Fill(dt);
                    //Ensure the datagrid is in read only mode
                    dataGrid.ReadOnly = true;
                    //Populate the datagrid
                    dataGrid.DataSource = dt;
                    //Closes the connection
                    conn.Close();
                    dataGrid.Columns[0].HeaderText = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Construct the query string from the filters
        private string getquery()
        {
            //Initialize the query
            string sqlquery = string.Empty;
            bool notchanged = false;

            //Check whether to create query for Menu or Reservation
            //If managerMenu is empty, it means the constructor for menu is not called
            //Hence create the query for reservation
            if (managerMenu == null)
            {
                //Empty query template
                sqlquery = "SELECT * FROM customer_reservation WHERE";
                //Add condition for name
                if (!string.IsNullOrEmpty(managerReservation.textboxName))
                {
                    sqlquery = sqlquery + $" customerName LIKE '%{managerReservation.textboxName}%'";
                    notchanged = false;
                }
                else
                {
                    notchanged = true;
                }

                //Add condition for date
                if (managerReservation.datetimepickDate != "01/01/2024" && managerReservation.datetimepickDate != "1/1/2024")
                {
                    if (notchanged)
                    {
                        sqlquery = sqlquery + $" reserveDate IN ('{managerReservation.datetimepickDate}')";
                    }
                    else
                    {
                        sqlquery = sqlquery + $" AND reserveDate IN ('{managerReservation.datetimepickDate}')";
                    }
                    notchanged = false;
                }
                else if (notchanged)
                {
                    notchanged = true;
                }

                //Add condition for number of guets
                if (managerReservation.numupdownNum != 0)
                {
                    if (notchanged)
                    {
                        sqlquery = sqlquery + $" numberofguests = {managerReservation.numupdownNum}";
                    }
                    else
                    {
                        sqlquery = sqlquery + $" AND numberofguests = {managerReservation.numupdownNum}";
                    }
                    notchanged = false;
                }
                else if (notchanged)
                {
                    notchanged = true;
                }

                //Add condition for reservation status
                if (managerReservation.checklistStatus != "")
                {
                    if (notchanged)
                    {
                        sqlquery = sqlquery + $" status IN ({managerReservation.checklistStatus})";
                    }
                    else
                    {
                        sqlquery = sqlquery + $" AND status IN ({managerReservation.checklistStatus})";
                    }
                    notchanged = false;
                }
                else if (notchanged)
                {
                    notchanged = true;
                }

                //Add condition for reservation type
                if (managerReservation.checklistType != "")
                {
                    if (notchanged)
                    {
                        sqlquery = sqlquery + $" reserveType IN ({managerReservation.checklistType})";
                    }
                    else
                    {
                        sqlquery = sqlquery + $" AND reserveType IN ({managerReservation.checklistType})";
                    }
                    notchanged = false;
                }
                else if (notchanged)
                {
                    notchanged = true;
                }

                //Remove WHERE statement in query in case user have not insert any value
                if (notchanged)
                {
                    sqlquery = sqlquery.Substring(0, 34);
                }
                notchanged = false;

                //Give the query to sql command method
                return sqlquery;
            }

            //managerMenu is not empty = constructor for menu was called
            //Create query for menu
            else
            {
                //Initialize the query
                sqlquery = $"SELECT * FROM food_menu WHERE";
                //Add name to the query
                if (managerMenu.textboxName != "")
                {
                    sqlquery = sqlquery + $" foodName LIKE '%{managerMenu.textboxName}%'";
                    notchanged = false;
                }
                else
                {
                    notchanged = true;
                }

                //Check if the query is alterred or not
                if (notchanged)
                {
                    //The query was not alterred
                    //Hence we remove the conditional "WHERE" statement from the query
                    sqlquery = sqlquery.Substring(0, 23);
                }
                notchanged = false;

                //Give the query to sql command method
                return sqlquery;
            }
        }
    }
}