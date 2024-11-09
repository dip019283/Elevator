using MySqlConnector; 
using System;
using System.Data;
using System.Windows.Forms;

//namespace Dipesh_lift_system
//{
//    internal class DatabaseConnection
//    {
//        private readonly string url = "server=localhost;database=Elevator_Control;port=3306;user=root;password=pass123;AllowZeroDateTime=True;ConvertZeroDateTime=True;";

//        public void Insert(string Action)
//        {
//            string sql = "INSERT INTO Elevator_Control.Elevator (Date, Time, Action) VALUES (@date, @time, @action)";

//            try
//            {
//                using (var conn = new MySqlConnection(url))
//                using (var cmd = new MySqlCommand(sql, conn))
//                {
//                    conn.Open();

//                    DateTime currentDateTime = DateTime.Now;
//                    cmd.Parameters.Add(new MySqlParameter("@date", MySqlDbType.Date)).Value = currentDateTime.Date;
//                    cmd.Parameters.Add(new MySqlParameter("@time", MySqlDbType.Time)).Value = currentDateTime.TimeOfDay;
//                    cmd.Parameters.AddWithValue("@action", Action ?? ""); // Handling possible null Action

//                    cmd.ExecuteNonQuery();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + (ex.Message ?? "An unknown error occurred"));
//            }
//        }

//        public DataTable Display_AllData()
//        {
//            string sql = "SELECT DATE_FORMAT(Date, '%Y-%m-%d') as Date, TIME(Time) as Time, Action FROM Elevator_Control.Elevator ORDER BY Date DESC, Time DESC;";

//            try
//            {
//                using (var conn = new MySqlConnection(url))
//                using (var cmd = new MySqlCommand(sql, conn))
//                using (var adapter = new MySqlDataAdapter(cmd))
//                {
//                    conn.Open();

//                    DataTable dt = new DataTable();
//                    adapter.Fill(dt);
//                    return dt;
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + (ex.Message ?? "An unknown error occurred"));
//                return new DataTable(); // Returning an empty DataTable to handle null warnings
//            }
//        }

//        public void Remove()
//        {
//            string sql = "DELETE FROM Elevator_Control.Elevator";

//            try
//            {
//                using (var conn = new MySqlConnection(url))
//                using (var cmd = new MySqlCommand(sql, conn))
//                {
//                    conn.Open();
//                    cmd.ExecuteNonQuery();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + (ex.Message ?? "An unknown error occurred"));
//            }
//        }
//    }
//}

namespace Dipesh_lift_system
{
    internal class DatabaseConnection
    {
        private readonly string url = "server=localhost;database=Elevator_Control;port=3306;user=root;password=pass123;AllowZeroDateTime=True;ConvertZeroDateTime=True;";
        private readonly string selectSql = "SELECT * FROM Elevator_Control.Elevator";

        public void Insert(string Action)
        {
            try
            {
                using (var conn = new MySqlConnection(url))
                using (var adapter = new MySqlDataAdapter(selectSql, conn))
                using (var builder = new MySqlCommandBuilder(adapter))
                {
                    DataTable dt = new DataTable();

                    // Define column types explicitly
                    dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
                    dt.Columns.Add(new DataColumn("Time", typeof(TimeSpan)));
                    dt.Columns.Add(new DataColumn("Action", typeof(string)));

                    // Fill the DataTable after defining the schema
                    adapter.Fill(dt);

                    // Create a new row with the current data and action
                    DataRow newRow = dt.NewRow();
                    DateTime currentDateTime = DateTime.Now;

                    // Set the values for the new row
                    newRow["Date"] = currentDateTime.Date;
                    newRow["Time"] = currentDateTime.TimeOfDay;
                    newRow["Action"] = Action ?? ""; // Handle possible null Action

                    // Add the row to the DataTable
                    dt.Rows.Add(newRow);

                    // Update the database with the new row
                    adapter.Update(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + (ex.Message ?? "An unknown error occurred"));
            }
        }

        public DataTable Display_AllData()
        {
            string displaySql = "SELECT DATE_FORMAT(Date, '%Y-%m-%d') as Date, TIME(Time) as Time, Action FROM Elevator_Control.Elevator ORDER BY Date DESC, Time DESC;";
            try
            {
                using (var conn = new MySqlConnection(url))
                using (var cmd = new MySqlCommand(displaySql, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + (ex.Message ?? "An unknown error occurred"));
                return new DataTable(); // Return an empty DataTable in case of an error
            }
        }


        public void Remove()
        {
            try
            {
                using (var conn = new MySqlConnection(url))
                {
                    // Define the SELECT command for filling the DataTable
                    using (var adapter = new MySqlDataAdapter(selectSql, conn))
                    {
                        // Define a manual DELETE command
                        var deleteCommand = new MySqlCommand("DELETE FROM Elevator_Control.Elevator WHERE Date = @Date AND Time = @Time", conn);

                        // Add parameters for Date and Time
                        deleteCommand.Parameters.Add("@Date", MySqlDbType.Date).SourceColumn = "Date";
                        deleteCommand.Parameters.Add("@Time", MySqlDbType.Time).SourceColumn = "Time";

                        // Assign the delete command to the adapter
                        adapter.DeleteCommand = deleteCommand;

                        // Fill the DataTable
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Mark all rows for deletion
                        foreach (DataRow row in dt.Rows)
                        {
                            row.Delete();
                        }

                        // Update the database to apply deletions
                        conn.Open();
                        adapter.Update(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + (ex.Message ?? "An unknown error occurred"));
            }
        }

    }
}